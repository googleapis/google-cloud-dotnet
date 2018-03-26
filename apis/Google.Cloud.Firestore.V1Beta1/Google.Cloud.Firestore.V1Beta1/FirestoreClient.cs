// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Firestore.V1Beta1
{
    /// <summary>
    /// Settings for a <see cref="FirestoreClient"/>.
    /// </summary>
    public sealed partial class FirestoreSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="FirestoreSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="FirestoreSettings"/>.
        /// </returns>
        public static FirestoreSettings GetDefault() => new FirestoreSettings();

        /// <summary>
        /// Constructs a new <see cref="FirestoreSettings"/> object with default settings.
        /// </summary>
        public FirestoreSettings() { }

        private FirestoreSettings(FirestoreSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetDocumentSettings = existing.GetDocumentSettings;
            ListDocumentsSettings = existing.ListDocumentsSettings;
            CreateDocumentSettings = existing.CreateDocumentSettings;
            UpdateDocumentSettings = existing.UpdateDocumentSettings;
            DeleteDocumentSettings = existing.DeleteDocumentSettings;
            BatchGetDocumentsSettings = existing.BatchGetDocumentsSettings;
            BeginTransactionSettings = existing.BeginTransactionSettings;
            CommitSettings = existing.CommitSettings;
            RollbackSettings = existing.RollbackSettings;
            RunQuerySettings = existing.RunQuerySettings;
            WriteSettings = existing.WriteSettings;
            WriteStreamingSettings = existing.WriteStreamingSettings;
            ListenSettings = existing.ListenSettings;
            ListenStreamingSettings = existing.ListenStreamingSettings;
            ListCollectionIdsSettings = existing.ListCollectionIdsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FirestoreSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="FirestoreClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static Predicate<RpcException> IdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes(StatusCode.DeadlineExceeded, StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="FirestoreClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="FirestoreClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="FirestoreClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="FirestoreClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(100),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="FirestoreClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="FirestoreClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="FirestoreClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(20000),
            maxDelay: TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// "Streaming" retry backoff for <see cref="FirestoreClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Streaming" retry backoff for <see cref="FirestoreClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Streaming" retry backoff for <see cref="FirestoreClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetStreamingRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(100),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Streaming" timeout backoff for <see cref="FirestoreClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Streaming" timeout backoff for <see cref="FirestoreClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Streaming" timeout backoff for <see cref="FirestoreClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 300000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetStreamingTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(300000),
            maxDelay: TimeSpan.FromMilliseconds(300000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.GetDocument</c> and <c>FirestoreClient.GetDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreClient.GetDocument</c> and
        /// <c>FirestoreClient.GetDocumentAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings GetDocumentSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.ListDocuments</c> and <c>FirestoreClient.ListDocumentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreClient.ListDocuments</c> and
        /// <c>FirestoreClient.ListDocumentsAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListDocumentsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.CreateDocument</c> and <c>FirestoreClient.CreateDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreClient.CreateDocument</c> and
        /// <c>FirestoreClient.CreateDocumentAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings CreateDocumentSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.UpdateDocument</c> and <c>FirestoreClient.UpdateDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreClient.UpdateDocument</c> and
        /// <c>FirestoreClient.UpdateDocumentAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings UpdateDocumentSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.DeleteDocument</c> and <c>FirestoreClient.DeleteDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreClient.DeleteDocument</c> and
        /// <c>FirestoreClient.DeleteDocumentAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings DeleteDocumentSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for calls to <c>FirestoreClient.BatchGetDocuments</c>.
        /// </summary>
        /// <remarks>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings BatchGetDocumentsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromTimeout(TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.BeginTransaction</c> and <c>FirestoreClient.BeginTransactionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreClient.BeginTransaction</c> and
        /// <c>FirestoreClient.BeginTransactionAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings BeginTransactionSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.Commit</c> and <c>FirestoreClient.CommitAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreClient.Commit</c> and
        /// <c>FirestoreClient.CommitAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings CommitSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.Rollback</c> and <c>FirestoreClient.RollbackAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreClient.Rollback</c> and
        /// <c>FirestoreClient.RollbackAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings RollbackSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for calls to <c>FirestoreClient.RunQuery</c>.
        /// </summary>
        /// <remarks>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings RunQuerySettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromTimeout(TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="CallSettings"/> for calls to <c>FirestoreClient.Write</c>.
        /// </summary>
        /// <remarks>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings WriteSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromTimeout(TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="BidirectionalStreamingSettings"/> for calls to
        /// <c>FirestoreClient.Write</c>.
        /// </summary>
        /// <remarks>
        /// The default local send queue size is 100.
        /// </remarks>
        public BidirectionalStreamingSettings WriteStreamingSettings { get; set; } =
            new BidirectionalStreamingSettings(100);

        /// <summary>
        /// <see cref="CallSettings"/> for calls to <c>FirestoreClient.Listen</c>.
        /// </summary>
        /// <remarks>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListenSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromTimeout(TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="BidirectionalStreamingSettings"/> for calls to
        /// <c>FirestoreClient.Listen</c>.
        /// </summary>
        /// <remarks>
        /// The default local send queue size is 100.
        /// </remarks>
        public BidirectionalStreamingSettings ListenStreamingSettings { get; set; } =
            new BidirectionalStreamingSettings(100);

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.ListCollectionIds</c> and <c>FirestoreClient.ListCollectionIdsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreClient.ListCollectionIds</c> and
        /// <c>FirestoreClient.ListCollectionIdsAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListCollectionIdsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="FirestoreSettings"/> object.</returns>
        public FirestoreSettings Clone() => new FirestoreSettings(this);
    }

    /// <summary>
    /// Firestore client wrapper, for convenient use.
    /// </summary>
    public abstract partial class FirestoreClient
    {
        /// <summary>
        /// The default endpoint for the Firestore service, which is a host of "firestore.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("firestore.googleapis.com", 443);

        /// <summary>
        /// The default Firestore scopes.
        /// </summary>
        /// <remarks>
        /// The default Firestore scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/datastore"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/datastore",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="FirestoreClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="FirestoreSettings"/>.</param>
        /// <returns>The task representing the created <see cref="FirestoreClient"/>.</returns>
        public static async Task<FirestoreClient> CreateAsync(ServiceEndpoint endpoint = null, FirestoreSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="FirestoreClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="FirestoreSettings"/>.</param>
        /// <returns>The created <see cref="FirestoreClient"/>.</returns>
        public static FirestoreClient Create(ServiceEndpoint endpoint = null, FirestoreSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="FirestoreClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="FirestoreSettings"/>.</param>
        /// <returns>The created <see cref="FirestoreClient"/>.</returns>
        public static FirestoreClient Create(Channel channel, FirestoreSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            Firestore.FirestoreClient grpcClient = new Firestore.FirestoreClient(channel);
            return new FirestoreClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, FirestoreSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, FirestoreSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, FirestoreSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, FirestoreSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC Firestore client.
        /// </summary>
        public virtual Firestore.FirestoreClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets a single document.
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
        public virtual Task<Document> GetDocumentAsync(
            GetDocumentRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a single document.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Document> GetDocumentAsync(
            GetDocumentRequest request,
            CancellationToken cancellationToken) => GetDocumentAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single document.
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
        public virtual Document GetDocument(
            GetDocumentRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists documents.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Document"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListDocumentsResponse, Document> ListDocumentsAsync(
            ListDocumentsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists documents.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Document"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListDocumentsResponse, Document> ListDocuments(
            ListDocumentsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new document.
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
        public virtual Task<Document> CreateDocumentAsync(
            CreateDocumentRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new document.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Document> CreateDocumentAsync(
            CreateDocumentRequest request,
            CancellationToken cancellationToken) => CreateDocumentAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new document.
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
        public virtual Document CreateDocument(
            CreateDocumentRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates or inserts a document.
        /// </summary>
        /// <param name="document">
        /// The updated document.
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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Document> UpdateDocumentAsync(
            Document document,
            DocumentMask updateMask,
            CallSettings callSettings = null) => UpdateDocumentAsync(
                new UpdateDocumentRequest
                {
                    Document = GaxPreconditions.CheckNotNull(document, nameof(document)),
                    UpdateMask = GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// Updates or inserts a document.
        /// </summary>
        /// <param name="document">
        /// The updated document.
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
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Document> UpdateDocumentAsync(
            Document document,
            DocumentMask updateMask,
            CancellationToken cancellationToken) => UpdateDocumentAsync(
                document,
                updateMask,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates or inserts a document.
        /// </summary>
        /// <param name="document">
        /// The updated document.
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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Document UpdateDocument(
            Document document,
            DocumentMask updateMask,
            CallSettings callSettings = null) => UpdateDocument(
                new UpdateDocumentRequest
                {
                    Document = GaxPreconditions.CheckNotNull(document, nameof(document)),
                    UpdateMask = GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// Updates or inserts a document.
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
        public virtual Task<Document> UpdateDocumentAsync(
            UpdateDocumentRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates or inserts a document.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Document> UpdateDocumentAsync(
            UpdateDocumentRequest request,
            CancellationToken cancellationToken) => UpdateDocumentAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates or inserts a document.
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
        public virtual Document UpdateDocument(
            UpdateDocumentRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a document.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Document to delete. In the format:
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteDocumentAsync(
            string name,
            CallSettings callSettings = null) => DeleteDocumentAsync(
                new DeleteDocumentRequest
                {
                    Name = GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a document.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Document to delete. In the format:
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteDocumentAsync(
            string name,
            CancellationToken cancellationToken) => DeleteDocumentAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a document.
        /// </summary>
        /// <param name="name">
        /// The resource name of the Document to delete. In the format:
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteDocument(
            string name,
            CallSettings callSettings = null) => DeleteDocument(
                new DeleteDocumentRequest
                {
                    Name = GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a document.
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
        public virtual Task DeleteDocumentAsync(
            DeleteDocumentRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a document.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteDocumentAsync(
            DeleteDocumentRequest request,
            CancellationToken cancellationToken) => DeleteDocumentAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a document.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteDocument(
            DeleteDocumentRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets multiple documents.
        ///
        /// Documents returned by this method are not guaranteed to be returned in the
        /// same order that they were requested.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual BatchGetDocumentsStream BatchGetDocuments(
            BatchGetDocumentsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Server streaming methods for <c>BatchGetDocuments</c>.
        /// </summary>
        public abstract partial class BatchGetDocumentsStream : ServerStreamingBase<BatchGetDocumentsResponse>
        {
        }

        /// <summary>
        /// Starts a new transaction.
        /// </summary>
        /// <param name="database">
        /// The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<BeginTransactionResponse> BeginTransactionAsync(
            string database,
            CallSettings callSettings = null) => BeginTransactionAsync(
                new BeginTransactionRequest
                {
                    Database = GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                },
                callSettings);

        /// <summary>
        /// Starts a new transaction.
        /// </summary>
        /// <param name="database">
        /// The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<BeginTransactionResponse> BeginTransactionAsync(
            string database,
            CancellationToken cancellationToken) => BeginTransactionAsync(
                database,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a new transaction.
        /// </summary>
        /// <param name="database">
        /// The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual BeginTransactionResponse BeginTransaction(
            string database,
            CallSettings callSettings = null) => BeginTransaction(
                new BeginTransactionRequest
                {
                    Database = GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                },
                callSettings);

        /// <summary>
        /// Starts a new transaction.
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
        public virtual Task<BeginTransactionResponse> BeginTransactionAsync(
            BeginTransactionRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Starts a new transaction.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<BeginTransactionResponse> BeginTransactionAsync(
            BeginTransactionRequest request,
            CancellationToken cancellationToken) => BeginTransactionAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a new transaction.
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
        public virtual BeginTransactionResponse BeginTransaction(
            BeginTransactionRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Commits a transaction, while optionally updating documents.
        /// </summary>
        /// <param name="database">
        /// The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="writes">
        /// The writes to apply.
        ///
        /// Always executed atomically and in order.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<CommitResponse> CommitAsync(
            string database,
            IEnumerable<Write> writes,
            CallSettings callSettings = null) => CommitAsync(
                new CommitRequest
                {
                    Database = GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                    Writes = { GaxPreconditions.CheckNotNull(writes, nameof(writes)) },
                },
                callSettings);

        /// <summary>
        /// Commits a transaction, while optionally updating documents.
        /// </summary>
        /// <param name="database">
        /// The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="writes">
        /// The writes to apply.
        ///
        /// Always executed atomically and in order.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<CommitResponse> CommitAsync(
            string database,
            IEnumerable<Write> writes,
            CancellationToken cancellationToken) => CommitAsync(
                database,
                writes,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Commits a transaction, while optionally updating documents.
        /// </summary>
        /// <param name="database">
        /// The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="writes">
        /// The writes to apply.
        ///
        /// Always executed atomically and in order.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CommitResponse Commit(
            string database,
            IEnumerable<Write> writes,
            CallSettings callSettings = null) => Commit(
                new CommitRequest
                {
                    Database = GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                    Writes = { GaxPreconditions.CheckNotNull(writes, nameof(writes)) },
                },
                callSettings);

        /// <summary>
        /// Commits a transaction, while optionally updating documents.
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
        public virtual Task<CommitResponse> CommitAsync(
            CommitRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Commits a transaction, while optionally updating documents.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<CommitResponse> CommitAsync(
            CommitRequest request,
            CancellationToken cancellationToken) => CommitAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Commits a transaction, while optionally updating documents.
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
        public virtual CommitResponse Commit(
            CommitRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="database">
        /// The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="transaction">
        /// The transaction to roll back.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task RollbackAsync(
            string database,
            ByteString transaction,
            CallSettings callSettings = null) => RollbackAsync(
                new RollbackRequest
                {
                    Database = GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                    Transaction = GaxPreconditions.CheckNotNull(transaction, nameof(transaction)),
                },
                callSettings);

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="database">
        /// The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="transaction">
        /// The transaction to roll back.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task RollbackAsync(
            string database,
            ByteString transaction,
            CancellationToken cancellationToken) => RollbackAsync(
                database,
                transaction,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="database">
        /// The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="transaction">
        /// The transaction to roll back.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void Rollback(
            string database,
            ByteString transaction,
            CallSettings callSettings = null) => Rollback(
                new RollbackRequest
                {
                    Database = GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                    Transaction = GaxPreconditions.CheckNotNull(transaction, nameof(transaction)),
                },
                callSettings);

        /// <summary>
        /// Rolls back a transaction.
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
        public virtual Task RollbackAsync(
            RollbackRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task RollbackAsync(
            RollbackRequest request,
            CancellationToken cancellationToken) => RollbackAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void Rollback(
            RollbackRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Runs a query.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual RunQueryStream RunQuery(
            RunQueryRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Server streaming methods for <c>RunQuery</c>.
        /// </summary>
        public abstract partial class RunQueryStream : ServerStreamingBase<RunQueryResponse>
        {
        }

        /// <summary>
        /// Streams batches of document updates and deletes, in order.
        /// </summary>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <param name="streamingSettings">
        /// If not null, applies streaming overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The client-server stream.
        /// </returns>
        public virtual WriteStream Write(
            CallSettings callSettings = null,
            BidirectionalStreamingSettings streamingSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Bidirectional streaming methods for <c>Write</c>.
        /// </summary>
        public abstract partial class WriteStream : BidirectionalStreamingBase<WriteRequest, WriteResponse>
        {
        }

        /// <summary>
        /// Listens to changes.
        /// </summary>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <param name="streamingSettings">
        /// If not null, applies streaming overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The client-server stream.
        /// </returns>
        public virtual ListenStream Listen(
            CallSettings callSettings = null,
            BidirectionalStreamingSettings streamingSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Bidirectional streaming methods for <c>Listen</c>.
        /// </summary>
        public abstract partial class ListenStream : BidirectionalStreamingBase<ListenRequest, ListenResponse>
        {
        }

        /// <summary>
        /// Lists all the collection IDs underneath a document.
        /// </summary>
        /// <param name="parent">
        /// The parent document. In the format:
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
        /// For example:
        /// `projects/my-project/databases/my-database/documents/chatrooms/my-chatroom`
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
        /// A pageable asynchronous sequence of <see cref="string"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListCollectionIdsResponse, string> ListCollectionIdsAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListCollectionIdsAsync(
                new ListCollectionIdsRequest
                {
                    Parent = GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all the collection IDs underneath a document.
        /// </summary>
        /// <param name="parent">
        /// The parent document. In the format:
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
        /// For example:
        /// `projects/my-project/databases/my-database/documents/chatrooms/my-chatroom`
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
        /// A pageable sequence of <see cref="string"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListCollectionIdsResponse, string> ListCollectionIds(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListCollectionIds(
                new ListCollectionIdsRequest
                {
                    Parent = GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all the collection IDs underneath a document.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="string"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListCollectionIdsResponse, string> ListCollectionIdsAsync(
            ListCollectionIdsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists all the collection IDs underneath a document.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="string"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListCollectionIdsResponse, string> ListCollectionIds(
            ListCollectionIdsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// Firestore client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class FirestoreClientImpl : FirestoreClient
    {
        private readonly ApiCall<GetDocumentRequest, Document> _callGetDocument;
        private readonly ApiCall<ListDocumentsRequest, ListDocumentsResponse> _callListDocuments;
        private readonly ApiCall<CreateDocumentRequest, Document> _callCreateDocument;
        private readonly ApiCall<UpdateDocumentRequest, Document> _callUpdateDocument;
        private readonly ApiCall<DeleteDocumentRequest, Empty> _callDeleteDocument;
        private readonly ApiServerStreamingCall<BatchGetDocumentsRequest, BatchGetDocumentsResponse> _callBatchGetDocuments;
        private readonly ApiCall<BeginTransactionRequest, BeginTransactionResponse> _callBeginTransaction;
        private readonly ApiCall<CommitRequest, CommitResponse> _callCommit;
        private readonly ApiCall<RollbackRequest, Empty> _callRollback;
        private readonly ApiServerStreamingCall<RunQueryRequest, RunQueryResponse> _callRunQuery;
        private readonly ApiBidirectionalStreamingCall<WriteRequest, WriteResponse> _callWrite;
        private readonly ApiBidirectionalStreamingCall<ListenRequest, ListenResponse> _callListen;
        private readonly ApiCall<ListCollectionIdsRequest, ListCollectionIdsResponse> _callListCollectionIds;

        /// <summary>
        /// Constructs a client wrapper for the Firestore service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FirestoreSettings"/> used within this client </param>
        public FirestoreClientImpl(Firestore.FirestoreClient grpcClient, FirestoreSettings settings)
        {
            GrpcClient = grpcClient;
            FirestoreSettings effectiveSettings = settings ?? FirestoreSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            _callGetDocument = clientHelper.BuildApiCall<GetDocumentRequest, Document>(
                GrpcClient.GetDocumentAsync, GrpcClient.GetDocument, effectiveSettings.GetDocumentSettings);
            _callListDocuments = clientHelper.BuildApiCall<ListDocumentsRequest, ListDocumentsResponse>(
                GrpcClient.ListDocumentsAsync, GrpcClient.ListDocuments, effectiveSettings.ListDocumentsSettings);
            _callCreateDocument = clientHelper.BuildApiCall<CreateDocumentRequest, Document>(
                GrpcClient.CreateDocumentAsync, GrpcClient.CreateDocument, effectiveSettings.CreateDocumentSettings);
            _callUpdateDocument = clientHelper.BuildApiCall<UpdateDocumentRequest, Document>(
                GrpcClient.UpdateDocumentAsync, GrpcClient.UpdateDocument, effectiveSettings.UpdateDocumentSettings);
            _callDeleteDocument = clientHelper.BuildApiCall<DeleteDocumentRequest, Empty>(
                GrpcClient.DeleteDocumentAsync, GrpcClient.DeleteDocument, effectiveSettings.DeleteDocumentSettings);
            _callBatchGetDocuments = clientHelper.BuildApiCall<BatchGetDocumentsRequest, BatchGetDocumentsResponse>(
                GrpcClient.BatchGetDocuments, effectiveSettings.BatchGetDocumentsSettings);
            _callBeginTransaction = clientHelper.BuildApiCall<BeginTransactionRequest, BeginTransactionResponse>(
                GrpcClient.BeginTransactionAsync, GrpcClient.BeginTransaction, effectiveSettings.BeginTransactionSettings);
            _callCommit = clientHelper.BuildApiCall<CommitRequest, CommitResponse>(
                GrpcClient.CommitAsync, GrpcClient.Commit, effectiveSettings.CommitSettings);
            _callRollback = clientHelper.BuildApiCall<RollbackRequest, Empty>(
                GrpcClient.RollbackAsync, GrpcClient.Rollback, effectiveSettings.RollbackSettings);
            _callRunQuery = clientHelper.BuildApiCall<RunQueryRequest, RunQueryResponse>(
                GrpcClient.RunQuery, effectiveSettings.RunQuerySettings);
            _callWrite = clientHelper.BuildApiCall<WriteRequest, WriteResponse>(
                GrpcClient.Write, effectiveSettings.WriteSettings, effectiveSettings.WriteStreamingSettings);
            _callListen = clientHelper.BuildApiCall<ListenRequest, ListenResponse>(
                GrpcClient.Listen, effectiveSettings.ListenSettings, effectiveSettings.ListenStreamingSettings);
            _callListCollectionIds = clientHelper.BuildApiCall<ListCollectionIdsRequest, ListCollectionIdsResponse>(
                GrpcClient.ListCollectionIdsAsync, GrpcClient.ListCollectionIds, effectiveSettings.ListCollectionIdsSettings);
            Modify_ApiCall(ref _callGetDocument);
            Modify_GetDocumentApiCall(ref _callGetDocument);
            Modify_ApiCall(ref _callListDocuments);
            Modify_ListDocumentsApiCall(ref _callListDocuments);
            Modify_ApiCall(ref _callCreateDocument);
            Modify_CreateDocumentApiCall(ref _callCreateDocument);
            Modify_ApiCall(ref _callUpdateDocument);
            Modify_UpdateDocumentApiCall(ref _callUpdateDocument);
            Modify_ApiCall(ref _callDeleteDocument);
            Modify_DeleteDocumentApiCall(ref _callDeleteDocument);
            Modify_ApiCall(ref _callBatchGetDocuments);
            Modify_BatchGetDocumentsApiCall(ref _callBatchGetDocuments);
            Modify_ApiCall(ref _callBeginTransaction);
            Modify_BeginTransactionApiCall(ref _callBeginTransaction);
            Modify_ApiCall(ref _callCommit);
            Modify_CommitApiCall(ref _callCommit);
            Modify_ApiCall(ref _callRollback);
            Modify_RollbackApiCall(ref _callRollback);
            Modify_ApiCall(ref _callRunQuery);
            Modify_RunQueryApiCall(ref _callRunQuery);
            Modify_ApiCall(ref _callWrite);
            Modify_WriteApiCall(ref _callWrite);
            Modify_ApiCall(ref _callListen);
            Modify_ListenApiCall(ref _callListen);
            Modify_ApiCall(ref _callListCollectionIds);
            Modify_ListCollectionIdsApiCall(ref _callListCollectionIds);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref ApiCall<TRequest, TResponse> call)
            where TRequest : class, IMessage<TRequest>
            where TResponse : class, IMessage<TResponse>;
        partial void Modify_ApiCall<TRequest, TResponse>(ref ApiServerStreamingCall<TRequest, TResponse> call)
            where TRequest : class, IMessage<TRequest>
            where TResponse : class, IMessage<TResponse>;
        partial void Modify_ApiCall<TRequest, TResponse>(ref ApiBidirectionalStreamingCall<TRequest, TResponse> call)
            where TRequest : class, IMessage<TRequest>
            where TResponse : class, IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_GetDocumentApiCall(ref ApiCall<GetDocumentRequest, Document> call);
        partial void Modify_ListDocumentsApiCall(ref ApiCall<ListDocumentsRequest, ListDocumentsResponse> call);
        partial void Modify_CreateDocumentApiCall(ref ApiCall<CreateDocumentRequest, Document> call);
        partial void Modify_UpdateDocumentApiCall(ref ApiCall<UpdateDocumentRequest, Document> call);
        partial void Modify_DeleteDocumentApiCall(ref ApiCall<DeleteDocumentRequest, Empty> call);
        partial void Modify_BatchGetDocumentsApiCall(ref ApiServerStreamingCall<BatchGetDocumentsRequest, BatchGetDocumentsResponse> call);
        partial void Modify_BeginTransactionApiCall(ref ApiCall<BeginTransactionRequest, BeginTransactionResponse> call);
        partial void Modify_CommitApiCall(ref ApiCall<CommitRequest, CommitResponse> call);
        partial void Modify_RollbackApiCall(ref ApiCall<RollbackRequest, Empty> call);
        partial void Modify_RunQueryApiCall(ref ApiServerStreamingCall<RunQueryRequest, RunQueryResponse> call);
        partial void Modify_WriteApiCall(ref ApiBidirectionalStreamingCall<WriteRequest, WriteResponse> call);
        partial void Modify_ListenApiCall(ref ApiBidirectionalStreamingCall<ListenRequest, ListenResponse> call);
        partial void Modify_ListCollectionIdsApiCall(ref ApiCall<ListCollectionIdsRequest, ListCollectionIdsResponse> call);
        partial void OnConstruction(Firestore.FirestoreClient grpcClient, FirestoreSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC Firestore client.
        /// </summary>
        public override Firestore.FirestoreClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetDocumentRequest(ref GetDocumentRequest request, ref CallSettings settings);
        partial void Modify_ListDocumentsRequest(ref ListDocumentsRequest request, ref CallSettings settings);
        partial void Modify_CreateDocumentRequest(ref CreateDocumentRequest request, ref CallSettings settings);
        partial void Modify_UpdateDocumentRequest(ref UpdateDocumentRequest request, ref CallSettings settings);
        partial void Modify_DeleteDocumentRequest(ref DeleteDocumentRequest request, ref CallSettings settings);
        partial void Modify_BatchGetDocumentsRequest(ref BatchGetDocumentsRequest request, ref CallSettings settings);
        partial void Modify_BeginTransactionRequest(ref BeginTransactionRequest request, ref CallSettings settings);
        partial void Modify_CommitRequest(ref CommitRequest request, ref CallSettings settings);
        partial void Modify_RollbackRequest(ref RollbackRequest request, ref CallSettings settings);
        partial void Modify_RunQueryRequest(ref RunQueryRequest request, ref CallSettings settings);
        partial void Modify_WriteRequestCallSettings(ref CallSettings settings);
        partial void Modify_WriteRequestRequest(ref WriteRequest request);
        partial void Modify_ListenRequestCallSettings(ref CallSettings settings);
        partial void Modify_ListenRequestRequest(ref ListenRequest request);
        partial void Modify_ListCollectionIdsRequest(ref ListCollectionIdsRequest request, ref CallSettings settings);

        /// <summary>
        /// Gets a single document.
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
        public override Task<Document> GetDocumentAsync(
            GetDocumentRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetDocumentRequest(ref request, ref callSettings);
            return _callGetDocument.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a single document.
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
        public override Document GetDocument(
            GetDocumentRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetDocumentRequest(ref request, ref callSettings);
            return _callGetDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists documents.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Document"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListDocumentsResponse, Document> ListDocumentsAsync(
            ListDocumentsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListDocumentsRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListDocumentsRequest, ListDocumentsResponse, Document>(_callListDocuments, request, callSettings);
        }

        /// <summary>
        /// Lists documents.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Document"/> resources.
        /// </returns>
        public override PagedEnumerable<ListDocumentsResponse, Document> ListDocuments(
            ListDocumentsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListDocumentsRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListDocumentsRequest, ListDocumentsResponse, Document>(_callListDocuments, request, callSettings);
        }

        /// <summary>
        /// Creates a new document.
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
        public override Task<Document> CreateDocumentAsync(
            CreateDocumentRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateDocumentRequest(ref request, ref callSettings);
            return _callCreateDocument.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new document.
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
        public override Document CreateDocument(
            CreateDocumentRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateDocumentRequest(ref request, ref callSettings);
            return _callCreateDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates or inserts a document.
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
        public override Task<Document> UpdateDocumentAsync(
            UpdateDocumentRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateDocumentRequest(ref request, ref callSettings);
            return _callUpdateDocument.Async(request, callSettings);
        }

        /// <summary>
        /// Updates or inserts a document.
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
        public override Document UpdateDocument(
            UpdateDocumentRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateDocumentRequest(ref request, ref callSettings);
            return _callUpdateDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a document.
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
        public override Task DeleteDocumentAsync(
            DeleteDocumentRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteDocumentRequest(ref request, ref callSettings);
            return _callDeleteDocument.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a document.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteDocument(
            DeleteDocumentRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteDocumentRequest(ref request, ref callSettings);
            _callDeleteDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets multiple documents.
        ///
        /// Documents returned by this method are not guaranteed to be returned in the
        /// same order that they were requested.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public override BatchGetDocumentsStream BatchGetDocuments(
            BatchGetDocumentsRequest request,
            CallSettings callSettings = null)
        {
            Modify_BatchGetDocumentsRequest(ref request, ref callSettings);
            return new BatchGetDocumentsStreamImpl(_callBatchGetDocuments.Call(request, callSettings));
        }

        internal sealed partial class BatchGetDocumentsStreamImpl : BatchGetDocumentsStream
        {
            /// <summary>
            /// Construct the server-streaming method for <c>BatchGetDocuments</c>.
            /// </summary>
            /// <param name="call">The underlying gRPC server-streaming call.</param>
            internal BatchGetDocumentsStreamImpl(AsyncServerStreamingCall<BatchGetDocumentsResponse> call)
            {
                GrpcCall = call;
            }

            /// <inheritdoc/>
            public override AsyncServerStreamingCall<BatchGetDocumentsResponse> GrpcCall { get; }

            /// <inheritdoc/>
            public override IAsyncEnumerator<BatchGetDocumentsResponse> ResponseStream => GrpcCall.ResponseStream;
        }

        /// <summary>
        /// Starts a new transaction.
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
        public override Task<BeginTransactionResponse> BeginTransactionAsync(
            BeginTransactionRequest request,
            CallSettings callSettings = null)
        {
            Modify_BeginTransactionRequest(ref request, ref callSettings);
            return _callBeginTransaction.Async(request, callSettings);
        }

        /// <summary>
        /// Starts a new transaction.
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
        public override BeginTransactionResponse BeginTransaction(
            BeginTransactionRequest request,
            CallSettings callSettings = null)
        {
            Modify_BeginTransactionRequest(ref request, ref callSettings);
            return _callBeginTransaction.Sync(request, callSettings);
        }

        /// <summary>
        /// Commits a transaction, while optionally updating documents.
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
        public override Task<CommitResponse> CommitAsync(
            CommitRequest request,
            CallSettings callSettings = null)
        {
            Modify_CommitRequest(ref request, ref callSettings);
            return _callCommit.Async(request, callSettings);
        }

        /// <summary>
        /// Commits a transaction, while optionally updating documents.
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
        public override CommitResponse Commit(
            CommitRequest request,
            CallSettings callSettings = null)
        {
            Modify_CommitRequest(ref request, ref callSettings);
            return _callCommit.Sync(request, callSettings);
        }

        /// <summary>
        /// Rolls back a transaction.
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
        public override Task RollbackAsync(
            RollbackRequest request,
            CallSettings callSettings = null)
        {
            Modify_RollbackRequest(ref request, ref callSettings);
            return _callRollback.Async(request, callSettings);
        }

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void Rollback(
            RollbackRequest request,
            CallSettings callSettings = null)
        {
            Modify_RollbackRequest(ref request, ref callSettings);
            _callRollback.Sync(request, callSettings);
        }

        /// <summary>
        /// Runs a query.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public override RunQueryStream RunQuery(
            RunQueryRequest request,
            CallSettings callSettings = null)
        {
            Modify_RunQueryRequest(ref request, ref callSettings);
            return new RunQueryStreamImpl(_callRunQuery.Call(request, callSettings));
        }

        internal sealed partial class RunQueryStreamImpl : RunQueryStream
        {
            /// <summary>
            /// Construct the server-streaming method for <c>RunQuery</c>.
            /// </summary>
            /// <param name="call">The underlying gRPC server-streaming call.</param>
            internal RunQueryStreamImpl(AsyncServerStreamingCall<RunQueryResponse> call)
            {
                GrpcCall = call;
            }

            /// <inheritdoc/>
            public override AsyncServerStreamingCall<RunQueryResponse> GrpcCall { get; }

            /// <inheritdoc/>
            public override IAsyncEnumerator<RunQueryResponse> ResponseStream => GrpcCall.ResponseStream;
        }

        /// <summary>
        /// Streams batches of document updates and deletes, in order.
        /// </summary>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <param name="streamingSettings">
        /// If not null, applies streaming overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The client-server stream.
        /// </returns>
        public override WriteStream Write(
            CallSettings callSettings = null,
            BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_WriteRequestCallSettings(ref callSettings);
            BidirectionalStreamingSettings effectiveStreamingSettings =
                streamingSettings ?? _callWrite.StreamingSettings;
            AsyncDuplexStreamingCall<WriteRequest, WriteResponse> call =
                _callWrite.Call(callSettings);
            BufferedClientStreamWriter<WriteRequest> writeBuffer =
                new BufferedClientStreamWriter<WriteRequest>(
                    call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new WriteStreamImpl(this, call, writeBuffer);
        }

        internal sealed partial class WriteStreamImpl : WriteStream
        {
            /// <summary>
            /// Construct the bidirectional streaming method for <c>Write</c>.
            /// </summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">The <see cref="BufferedClientStreamWriter{WriteRequest}"/>
            /// instance associated with this streaming call.</param>
            public WriteStreamImpl(
                FirestoreClientImpl service,
                AsyncDuplexStreamingCall<WriteRequest, WriteResponse> call,
                BufferedClientStreamWriter<WriteRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private FirestoreClientImpl _service;
            private BufferedClientStreamWriter<WriteRequest> _writeBuffer;

            private WriteRequest ModifyRequest(WriteRequest request)
            {
                _service.Modify_WriteRequestRequest(ref request);
                return request;
            }

            /// <inheritdoc/>
            public override AsyncDuplexStreamingCall<WriteRequest, WriteResponse> GrpcCall { get; }

            /// <inheritdoc/>
            public override Task TryWriteAsync(WriteRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            /// <inheritdoc/>
            public override Task WriteAsync(WriteRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            /// <inheritdoc/>
            public override Task TryWriteAsync(WriteRequest message, WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            /// <inheritdoc/>
            public override Task WriteAsync(WriteRequest message, WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            /// <inheritdoc/>
            public override Task TryWriteCompleteAsync() =>
                _writeBuffer.TryWriteCompleteAsync();

            /// <inheritdoc/>
            public override Task WriteCompleteAsync() =>
                _writeBuffer.WriteCompleteAsync();

            /// <inheritdoc/>
            public override IAsyncEnumerator<WriteResponse> ResponseStream =>
                GrpcCall.ResponseStream;
        }

        /// <summary>
        /// Listens to changes.
        /// </summary>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <param name="streamingSettings">
        /// If not null, applies streaming overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The client-server stream.
        /// </returns>
        public override ListenStream Listen(
            CallSettings callSettings = null,
            BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_ListenRequestCallSettings(ref callSettings);
            BidirectionalStreamingSettings effectiveStreamingSettings =
                streamingSettings ?? _callListen.StreamingSettings;
            AsyncDuplexStreamingCall<ListenRequest, ListenResponse> call =
                _callListen.Call(callSettings);
            BufferedClientStreamWriter<ListenRequest> writeBuffer =
                new BufferedClientStreamWriter<ListenRequest>(
                    call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new ListenStreamImpl(this, call, writeBuffer);
        }

        internal sealed partial class ListenStreamImpl : ListenStream
        {
            /// <summary>
            /// Construct the bidirectional streaming method for <c>Listen</c>.
            /// </summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">The <see cref="BufferedClientStreamWriter{ListenRequest}"/>
            /// instance associated with this streaming call.</param>
            public ListenStreamImpl(
                FirestoreClientImpl service,
                AsyncDuplexStreamingCall<ListenRequest, ListenResponse> call,
                BufferedClientStreamWriter<ListenRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private FirestoreClientImpl _service;
            private BufferedClientStreamWriter<ListenRequest> _writeBuffer;

            private ListenRequest ModifyRequest(ListenRequest request)
            {
                _service.Modify_ListenRequestRequest(ref request);
                return request;
            }

            /// <inheritdoc/>
            public override AsyncDuplexStreamingCall<ListenRequest, ListenResponse> GrpcCall { get; }

            /// <inheritdoc/>
            public override Task TryWriteAsync(ListenRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            /// <inheritdoc/>
            public override Task WriteAsync(ListenRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            /// <inheritdoc/>
            public override Task TryWriteAsync(ListenRequest message, WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            /// <inheritdoc/>
            public override Task WriteAsync(ListenRequest message, WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            /// <inheritdoc/>
            public override Task TryWriteCompleteAsync() =>
                _writeBuffer.TryWriteCompleteAsync();

            /// <inheritdoc/>
            public override Task WriteCompleteAsync() =>
                _writeBuffer.WriteCompleteAsync();

            /// <inheritdoc/>
            public override IAsyncEnumerator<ListenResponse> ResponseStream =>
                GrpcCall.ResponseStream;
        }

        /// <summary>
        /// Lists all the collection IDs underneath a document.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="string"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListCollectionIdsResponse, string> ListCollectionIdsAsync(
            ListCollectionIdsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListCollectionIdsRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListCollectionIdsRequest, ListCollectionIdsResponse, string>(_callListCollectionIds, request, callSettings);
        }

        /// <summary>
        /// Lists all the collection IDs underneath a document.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="string"/> resources.
        /// </returns>
        public override PagedEnumerable<ListCollectionIdsResponse, string> ListCollectionIds(
            ListCollectionIdsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListCollectionIdsRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListCollectionIdsRequest, ListCollectionIdsResponse, string>(_callListCollectionIds, request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListDocumentsRequest : IPageRequest { }
    public partial class ListDocumentsResponse : IPageResponse<Document>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<Document> GetEnumerator() => Documents.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCollectionIdsRequest : IPageRequest { }
    public partial class ListCollectionIdsResponse : IPageResponse<string>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<string> GetEnumerator() => CollectionIds.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
