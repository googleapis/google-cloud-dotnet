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

namespace Google.Cloud.Dialogflow.V2
{
    /// <summary>
    /// Settings for a <see cref="EntityTypesClient"/>.
    /// </summary>
    public sealed partial class EntityTypesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="EntityTypesSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="EntityTypesSettings"/>.
        /// </returns>
        public static EntityTypesSettings GetDefault() => new EntityTypesSettings();

        /// <summary>
        /// Constructs a new <see cref="EntityTypesSettings"/> object with default settings.
        /// </summary>
        public EntityTypesSettings() { }

        private EntityTypesSettings(EntityTypesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListEntityTypesSettings = existing.ListEntityTypesSettings;
            GetEntityTypeSettings = existing.GetEntityTypeSettings;
            CreateEntityTypeSettings = existing.CreateEntityTypeSettings;
            UpdateEntityTypeSettings = existing.UpdateEntityTypeSettings;
            DeleteEntityTypeSettings = existing.DeleteEntityTypeSettings;
            BatchUpdateEntityTypesSettings = existing.BatchUpdateEntityTypesSettings;
            BatchUpdateEntityTypesOperationsSettings = existing.BatchUpdateEntityTypesOperationsSettings?.Clone();
            BatchDeleteEntityTypesSettings = existing.BatchDeleteEntityTypesSettings;
            BatchDeleteEntityTypesOperationsSettings = existing.BatchDeleteEntityTypesOperationsSettings?.Clone();
            BatchCreateEntitiesSettings = existing.BatchCreateEntitiesSettings;
            BatchCreateEntitiesOperationsSettings = existing.BatchCreateEntitiesOperationsSettings?.Clone();
            BatchUpdateEntitiesSettings = existing.BatchUpdateEntitiesSettings;
            BatchUpdateEntitiesOperationsSettings = existing.BatchUpdateEntitiesOperationsSettings?.Clone();
            BatchDeleteEntitiesSettings = existing.BatchDeleteEntitiesSettings;
            BatchDeleteEntitiesOperationsSettings = existing.BatchDeleteEntitiesOperationsSettings?.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(EntityTypesSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="EntityTypesClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="EntityTypesClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="EntityTypesClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="EntityTypesClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="EntityTypesClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="EntityTypesClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="EntityTypesClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="EntityTypesClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityTypesClient.ListEntityTypes</c> and <c>EntityTypesClient.ListEntityTypesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>EntityTypesClient.ListEntityTypes</c> and
        /// <c>EntityTypesClient.ListEntityTypesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListEntityTypesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityTypesClient.GetEntityType</c> and <c>EntityTypesClient.GetEntityTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>EntityTypesClient.GetEntityType</c> and
        /// <c>EntityTypesClient.GetEntityTypeAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetEntityTypeSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityTypesClient.CreateEntityType</c> and <c>EntityTypesClient.CreateEntityTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>EntityTypesClient.CreateEntityType</c> and
        /// <c>EntityTypesClient.CreateEntityTypeAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateEntityTypeSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityTypesClient.UpdateEntityType</c> and <c>EntityTypesClient.UpdateEntityTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>EntityTypesClient.UpdateEntityType</c> and
        /// <c>EntityTypesClient.UpdateEntityTypeAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateEntityTypeSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityTypesClient.DeleteEntityType</c> and <c>EntityTypesClient.DeleteEntityTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>EntityTypesClient.DeleteEntityType</c> and
        /// <c>EntityTypesClient.DeleteEntityTypeAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEntityTypeSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityTypesClient.BatchUpdateEntityTypes</c> and <c>EntityTypesClient.BatchUpdateEntityTypesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>EntityTypesClient.BatchUpdateEntityTypes</c> and
        /// <c>EntityTypesClient.BatchUpdateEntityTypesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings BatchUpdateEntityTypesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EntityTypesClient.BatchUpdateEntityTypes</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings BatchUpdateEntityTypesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityTypesClient.BatchDeleteEntityTypes</c> and <c>EntityTypesClient.BatchDeleteEntityTypesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>EntityTypesClient.BatchDeleteEntityTypes</c> and
        /// <c>EntityTypesClient.BatchDeleteEntityTypesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeleteEntityTypesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EntityTypesClient.BatchDeleteEntityTypes</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings BatchDeleteEntityTypesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityTypesClient.BatchCreateEntities</c> and <c>EntityTypesClient.BatchCreateEntitiesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>EntityTypesClient.BatchCreateEntities</c> and
        /// <c>EntityTypesClient.BatchCreateEntitiesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings BatchCreateEntitiesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EntityTypesClient.BatchCreateEntities</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings BatchCreateEntitiesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityTypesClient.BatchUpdateEntities</c> and <c>EntityTypesClient.BatchUpdateEntitiesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>EntityTypesClient.BatchUpdateEntities</c> and
        /// <c>EntityTypesClient.BatchUpdateEntitiesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings BatchUpdateEntitiesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EntityTypesClient.BatchUpdateEntities</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings BatchUpdateEntitiesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityTypesClient.BatchDeleteEntities</c> and <c>EntityTypesClient.BatchDeleteEntitiesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>EntityTypesClient.BatchDeleteEntities</c> and
        /// <c>EntityTypesClient.BatchDeleteEntitiesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeleteEntitiesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EntityTypesClient.BatchDeleteEntities</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings BatchDeleteEntitiesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="EntityTypesSettings"/> object.</returns>
        public EntityTypesSettings Clone() => new EntityTypesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="EntityTypesClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class EntityTypesClientBuilder : gaxgrpc::ClientBuilderBase<EntityTypesClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public EntityTypesSettings Settings { get; set; }

        /// <inheritdoc/>
        public override EntityTypesClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return EntityTypesClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<EntityTypesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return EntityTypesClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => EntityTypesClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => EntityTypesClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => EntityTypesClient.ChannelPool;
    }

    /// <summary>
    /// EntityTypes client wrapper, for convenient use.
    /// </summary>
    public abstract partial class EntityTypesClient
    {
        /// <summary>
        /// The default endpoint for the EntityTypes service, which is a host of "dialogflow.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("dialogflow.googleapis.com", 443);

        /// <summary>
        /// The default EntityTypes scopes.
        /// </summary>
        /// <remarks>
        /// The default EntityTypes scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/dialogflow"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="EntityTypesClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Dialogflow.V2;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// EntityTypesClient client = await EntityTypesClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Dialogflow.V2;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     EntityTypesClient.DefaultEndpoint.Host, EntityTypesClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// EntityTypesClient client = EntityTypesClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="EntityTypesSettings"/>.</param>
        /// <returns>The task representing the created <see cref="EntityTypesClient"/>.</returns>
        public static async stt::Task<EntityTypesClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, EntityTypesSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="EntityTypesClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Dialogflow.V2;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// EntityTypesClient client = EntityTypesClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Dialogflow.V2;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     EntityTypesClient.DefaultEndpoint.Host, EntityTypesClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// EntityTypesClient client = EntityTypesClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="EntityTypesSettings"/>.</param>
        /// <returns>The created <see cref="EntityTypesClient"/>.</returns>
        public static EntityTypesClient Create(gaxgrpc::ServiceEndpoint endpoint = null, EntityTypesSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="EntityTypesClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="EntityTypesSettings"/>.</param>
        /// <returns>The created <see cref="EntityTypesClient"/>.</returns>
        public static EntityTypesClient Create(grpccore::Channel channel, EntityTypesSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="EntityTypesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="EntityTypesSettings"/>.</param>
        /// <returns>The created <see cref="EntityTypesClient"/>.</returns>
        public static EntityTypesClient Create(grpccore::CallInvoker callInvoker, EntityTypesSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            EntityTypes.EntityTypesClient grpcClient = new EntityTypes.EntityTypesClient(callInvoker);
            return new EntityTypesClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, EntityTypesSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, EntityTypesSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, EntityTypesSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, EntityTypesSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC EntityTypes client.
        /// </summary>
        public virtual EntityTypes.EntityTypesClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the list of all entity types in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all entity types from.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
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
        /// A pageable asynchronous sequence of <see cref="EntityType"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypesAsync(
            ProjectAgentName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListEntityTypesAsync(
                new ListEntityTypesRequest
                {
                    ParentAsProjectAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of all entity types in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all entity types from.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
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
        /// A pageable sequence of <see cref="EntityType"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypes(
            ProjectAgentName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListEntityTypes(
                new ListEntityTypesRequest
                {
                    ParentAsProjectAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of all entity types in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all entity types from.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
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
        /// A pageable asynchronous sequence of <see cref="EntityType"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypesAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListEntityTypesAsync(
                new ListEntityTypesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of all entity types in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all entity types from.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
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
        /// A pageable sequence of <see cref="EntityType"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypes(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListEntityTypes(
                new ListEntityTypesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of all entity types in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all entity types from.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language to list entity synonyms for. If not specified,
        /// the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
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
        /// A pageable asynchronous sequence of <see cref="EntityType"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypesAsync(
            ProjectAgentName parent,
            string languageCode,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListEntityTypesAsync(
                new ListEntityTypesRequest
                {
                    ParentAsProjectAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    LanguageCode = languageCode ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of all entity types in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all entity types from.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language to list entity synonyms for. If not specified,
        /// the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
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
        /// A pageable sequence of <see cref="EntityType"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypes(
            ProjectAgentName parent,
            string languageCode,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListEntityTypes(
                new ListEntityTypesRequest
                {
                    ParentAsProjectAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    LanguageCode = languageCode ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of all entity types in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all entity types from.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language to list entity synonyms for. If not specified,
        /// the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
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
        /// A pageable asynchronous sequence of <see cref="EntityType"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypesAsync(
            string parent,
            string languageCode,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListEntityTypesAsync(
                new ListEntityTypesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    LanguageCode = languageCode ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of all entity types in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all entity types from.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language to list entity synonyms for. If not specified,
        /// the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
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
        /// A pageable sequence of <see cref="EntityType"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypes(
            string parent,
            string languageCode,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListEntityTypes(
                new ListEntityTypesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    LanguageCode = languageCode ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the list of all entity types in the specified agent.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="EntityType"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypesAsync(
            ListEntityTypesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the list of all entity types in the specified agent.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="EntityType"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypes(
            ListEntityTypesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;EntityType ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EntityType> GetEntityTypeAsync(
            EntityTypeName name,
            gaxgrpc::CallSettings callSettings = null) => GetEntityTypeAsync(
                new GetEntityTypeRequest
                {
                    EntityTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;EntityType ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EntityType> GetEntityTypeAsync(
            EntityTypeName name,
            st::CancellationToken cancellationToken) => GetEntityTypeAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;EntityType ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual EntityType GetEntityType(
            EntityTypeName name,
            gaxgrpc::CallSettings callSettings = null) => GetEntityType(
                new GetEntityTypeRequest
                {
                    EntityTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;EntityType ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EntityType> GetEntityTypeAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetEntityTypeAsync(
                new GetEntityTypeRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;EntityType ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EntityType> GetEntityTypeAsync(
            string name,
            st::CancellationToken cancellationToken) => GetEntityTypeAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;EntityType ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual EntityType GetEntityType(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetEntityType(
                new GetEntityTypeRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;EntityType ID&gt;`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language to retrieve entity synonyms for. If not specified,
        /// the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EntityType> GetEntityTypeAsync(
            EntityTypeName name,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => GetEntityTypeAsync(
                new GetEntityTypeRequest
                {
                    EntityTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;EntityType ID&gt;`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language to retrieve entity synonyms for. If not specified,
        /// the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EntityType> GetEntityTypeAsync(
            EntityTypeName name,
            string languageCode,
            st::CancellationToken cancellationToken) => GetEntityTypeAsync(
                name,
                languageCode,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;EntityType ID&gt;`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language to retrieve entity synonyms for. If not specified,
        /// the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual EntityType GetEntityType(
            EntityTypeName name,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => GetEntityType(
                new GetEntityTypeRequest
                {
                    EntityTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;EntityType ID&gt;`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language to retrieve entity synonyms for. If not specified,
        /// the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EntityType> GetEntityTypeAsync(
            string name,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => GetEntityTypeAsync(
                new GetEntityTypeRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;EntityType ID&gt;`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language to retrieve entity synonyms for. If not specified,
        /// the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EntityType> GetEntityTypeAsync(
            string name,
            string languageCode,
            st::CancellationToken cancellationToken) => GetEntityTypeAsync(
                name,
                languageCode,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;EntityType ID&gt;`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language to retrieve entity synonyms for. If not specified,
        /// the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual EntityType GetEntityType(
            string name,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => GetEntityType(
                new GetEntityTypeRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Retrieves the specified entity type.
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
        public virtual stt::Task<EntityType> GetEntityTypeAsync(
            GetEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Retrieves the specified entity type.
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
        public virtual stt::Task<EntityType> GetEntityTypeAsync(
            GetEntityTypeRequest request,
            st::CancellationToken cancellationToken) => GetEntityTypeAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified entity type.
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
        public virtual EntityType GetEntityType(
            GetEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="entityType">
        /// Required. The entity type to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EntityType> CreateEntityTypeAsync(
            ProjectAgentName parent,
            EntityType entityType,
            gaxgrpc::CallSettings callSettings = null) => CreateEntityTypeAsync(
                new CreateEntityTypeRequest
                {
                    ParentAsProjectAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
                },
                callSettings);

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="entityType">
        /// Required. The entity type to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EntityType> CreateEntityTypeAsync(
            ProjectAgentName parent,
            EntityType entityType,
            st::CancellationToken cancellationToken) => CreateEntityTypeAsync(
                parent,
                entityType,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="entityType">
        /// Required. The entity type to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual EntityType CreateEntityType(
            ProjectAgentName parent,
            EntityType entityType,
            gaxgrpc::CallSettings callSettings = null) => CreateEntityType(
                new CreateEntityTypeRequest
                {
                    ParentAsProjectAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
                },
                callSettings);

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="entityType">
        /// Required. The entity type to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EntityType> CreateEntityTypeAsync(
            string parent,
            EntityType entityType,
            gaxgrpc::CallSettings callSettings = null) => CreateEntityTypeAsync(
                new CreateEntityTypeRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
                },
                callSettings);

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="entityType">
        /// Required. The entity type to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EntityType> CreateEntityTypeAsync(
            string parent,
            EntityType entityType,
            st::CancellationToken cancellationToken) => CreateEntityTypeAsync(
                parent,
                entityType,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="entityType">
        /// Required. The entity type to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual EntityType CreateEntityType(
            string parent,
            EntityType entityType,
            gaxgrpc::CallSettings callSettings = null) => CreateEntityType(
                new CreateEntityTypeRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
                },
                callSettings);

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="entityType">
        /// Required. The entity type to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entity_type`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EntityType> CreateEntityTypeAsync(
            ProjectAgentName parent,
            EntityType entityType,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => CreateEntityTypeAsync(
                new CreateEntityTypeRequest
                {
                    ParentAsProjectAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="entityType">
        /// Required. The entity type to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entity_type`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EntityType> CreateEntityTypeAsync(
            ProjectAgentName parent,
            EntityType entityType,
            string languageCode,
            st::CancellationToken cancellationToken) => CreateEntityTypeAsync(
                parent,
                entityType,
                languageCode,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="entityType">
        /// Required. The entity type to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entity_type`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual EntityType CreateEntityType(
            ProjectAgentName parent,
            EntityType entityType,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => CreateEntityType(
                new CreateEntityTypeRequest
                {
                    ParentAsProjectAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="entityType">
        /// Required. The entity type to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entity_type`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EntityType> CreateEntityTypeAsync(
            string parent,
            EntityType entityType,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => CreateEntityTypeAsync(
                new CreateEntityTypeRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="entityType">
        /// Required. The entity type to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entity_type`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EntityType> CreateEntityTypeAsync(
            string parent,
            EntityType entityType,
            string languageCode,
            st::CancellationToken cancellationToken) => CreateEntityTypeAsync(
                parent,
                entityType,
                languageCode,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Format: `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="entityType">
        /// Required. The entity type to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entity_type`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual EntityType CreateEntityType(
            string parent,
            EntityType entityType,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => CreateEntityType(
                new CreateEntityTypeRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Creates an entity type in the specified agent.
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
        public virtual stt::Task<EntityType> CreateEntityTypeAsync(
            CreateEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates an entity type in the specified agent.
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
        public virtual stt::Task<EntityType> CreateEntityTypeAsync(
            CreateEntityTypeRequest request,
            st::CancellationToken cancellationToken) => CreateEntityTypeAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an entity type in the specified agent.
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
        public virtual EntityType CreateEntityType(
            CreateEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the specified entity type.
        /// </summary>
        /// <param name="entityType">
        /// Required. The entity type to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EntityType> UpdateEntityTypeAsync(
            EntityType entityType,
            gaxgrpc::CallSettings callSettings = null) => UpdateEntityTypeAsync(
                new UpdateEntityTypeRequest
                {
                    EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
                },
                callSettings);

        /// <summary>
        /// Updates the specified entity type.
        /// </summary>
        /// <param name="entityType">
        /// Required. The entity type to update.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EntityType> UpdateEntityTypeAsync(
            EntityType entityType,
            st::CancellationToken cancellationToken) => UpdateEntityTypeAsync(
                entityType,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified entity type.
        /// </summary>
        /// <param name="entityType">
        /// Required. The entity type to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual EntityType UpdateEntityType(
            EntityType entityType,
            gaxgrpc::CallSettings callSettings = null) => UpdateEntityType(
                new UpdateEntityTypeRequest
                {
                    EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
                },
                callSettings);

        /// <summary>
        /// Updates the specified entity type.
        /// </summary>
        /// <param name="entityType">
        /// Required. The entity type to update.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entity_type`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EntityType> UpdateEntityTypeAsync(
            EntityType entityType,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => UpdateEntityTypeAsync(
                new UpdateEntityTypeRequest
                {
                    EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Updates the specified entity type.
        /// </summary>
        /// <param name="entityType">
        /// Required. The entity type to update.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entity_type`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EntityType> UpdateEntityTypeAsync(
            EntityType entityType,
            string languageCode,
            st::CancellationToken cancellationToken) => UpdateEntityTypeAsync(
                entityType,
                languageCode,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified entity type.
        /// </summary>
        /// <param name="entityType">
        /// Required. The entity type to update.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entity_type`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual EntityType UpdateEntityType(
            EntityType entityType,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => UpdateEntityType(
                new UpdateEntityTypeRequest
                {
                    EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Updates the specified entity type.
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
        public virtual stt::Task<EntityType> UpdateEntityTypeAsync(
            UpdateEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates the specified entity type.
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
        public virtual stt::Task<EntityType> UpdateEntityTypeAsync(
            UpdateEntityTypeRequest request,
            st::CancellationToken cancellationToken) => UpdateEntityTypeAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified entity type.
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
        public virtual EntityType UpdateEntityType(
            UpdateEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type to delete.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;EntityType ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteEntityTypeAsync(
            EntityTypeName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteEntityTypeAsync(
                new DeleteEntityTypeRequest
                {
                    EntityTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type to delete.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;EntityType ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteEntityTypeAsync(
            EntityTypeName name,
            st::CancellationToken cancellationToken) => DeleteEntityTypeAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type to delete.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;EntityType ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteEntityType(
            EntityTypeName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteEntityType(
                new DeleteEntityTypeRequest
                {
                    EntityTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type to delete.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;EntityType ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteEntityTypeAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteEntityTypeAsync(
                new DeleteEntityTypeRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type to delete.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;EntityType ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteEntityTypeAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteEntityTypeAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type to delete.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;EntityType ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteEntityType(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteEntityType(
                new DeleteEntityTypeRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes the specified entity type.
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
        public virtual stt::Task DeleteEntityTypeAsync(
            DeleteEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified entity type.
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
        public virtual stt::Task DeleteEntityTypeAsync(
            DeleteEntityTypeRequest request,
            st::CancellationToken cancellationToken) => DeleteEntityTypeAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified entity type.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteEntityType(
            DeleteEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates/Creates multiple entity types in the specified agent.
        ///
        /// Operation &lt;response: [BatchUpdateEntityTypesResponse][google.cloud.dialogflow.v2.BatchUpdateEntityTypesResponse]&gt;
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
        public virtual stt::Task<lro::Operation<BatchUpdateEntityTypesResponse, pbwkt::Struct>> BatchUpdateEntityTypesAsync(
            BatchUpdateEntityTypesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchUpdateEntityTypesAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchUpdateEntityTypesResponse, pbwkt::Struct>> PollOnceBatchUpdateEntityTypesAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<BatchUpdateEntityTypesResponse, pbwkt::Struct>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                BatchUpdateEntityTypesOperationsClient,
                callSettings);

        /// <summary>
        /// Updates/Creates multiple entity types in the specified agent.
        ///
        /// Operation &lt;response: [BatchUpdateEntityTypesResponse][google.cloud.dialogflow.v2.BatchUpdateEntityTypesResponse]&gt;
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
        public virtual lro::Operation<BatchUpdateEntityTypesResponse, pbwkt::Struct> BatchUpdateEntityTypes(
            BatchUpdateEntityTypesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>BatchUpdateEntityTypes</c>.
        /// </summary>
        public virtual lro::OperationsClient BatchUpdateEntityTypesOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchUpdateEntityTypes</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchUpdateEntityTypesResponse, pbwkt::Struct> PollOnceBatchUpdateEntityTypes(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<BatchUpdateEntityTypesResponse, pbwkt::Struct>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                BatchUpdateEntityTypesOperationsClient,
                callSettings);

        /// <summary>
        /// Deletes entity types in the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to delete all entities types for. Format:
        /// `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="entityTypeNames">
        /// Required. The names entity types to delete. All names must point to the
        /// same agent as `parent`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchDeleteEntityTypesAsync(
            ProjectAgentName parent,
            scg::IEnumerable<string> entityTypeNames,
            gaxgrpc::CallSettings callSettings = null) => BatchDeleteEntityTypesAsync(
                new BatchDeleteEntityTypesRequest
                {
                    ParentAsProjectAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    EntityTypeNames = { gax::GaxPreconditions.CheckNotNull(entityTypeNames, nameof(entityTypeNames)) },
                },
                callSettings);

        /// <summary>
        /// Deletes entity types in the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to delete all entities types for. Format:
        /// `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="entityTypeNames">
        /// Required. The names entity types to delete. All names must point to the
        /// same agent as `parent`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchDeleteEntityTypesAsync(
            ProjectAgentName parent,
            scg::IEnumerable<string> entityTypeNames,
            st::CancellationToken cancellationToken) => BatchDeleteEntityTypesAsync(
                parent,
                entityTypeNames,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes entity types in the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to delete all entities types for. Format:
        /// `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="entityTypeNames">
        /// Required. The names entity types to delete. All names must point to the
        /// same agent as `parent`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchDeleteEntityTypes(
            ProjectAgentName parent,
            scg::IEnumerable<string> entityTypeNames,
            gaxgrpc::CallSettings callSettings = null) => BatchDeleteEntityTypes(
                new BatchDeleteEntityTypesRequest
                {
                    ParentAsProjectAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    EntityTypeNames = { gax::GaxPreconditions.CheckNotNull(entityTypeNames, nameof(entityTypeNames)) },
                },
                callSettings);

        /// <summary>
        /// Deletes entity types in the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to delete all entities types for. Format:
        /// `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="entityTypeNames">
        /// Required. The names entity types to delete. All names must point to the
        /// same agent as `parent`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchDeleteEntityTypesAsync(
            string parent,
            scg::IEnumerable<string> entityTypeNames,
            gaxgrpc::CallSettings callSettings = null) => BatchDeleteEntityTypesAsync(
                new BatchDeleteEntityTypesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    EntityTypeNames = { gax::GaxPreconditions.CheckNotNull(entityTypeNames, nameof(entityTypeNames)) },
                },
                callSettings);

        /// <summary>
        /// Deletes entity types in the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to delete all entities types for. Format:
        /// `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="entityTypeNames">
        /// Required. The names entity types to delete. All names must point to the
        /// same agent as `parent`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchDeleteEntityTypesAsync(
            string parent,
            scg::IEnumerable<string> entityTypeNames,
            st::CancellationToken cancellationToken) => BatchDeleteEntityTypesAsync(
                parent,
                entityTypeNames,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes entity types in the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to delete all entities types for. Format:
        /// `projects/&lt;Project ID&gt;/agent`.
        /// </param>
        /// <param name="entityTypeNames">
        /// Required. The names entity types to delete. All names must point to the
        /// same agent as `parent`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchDeleteEntityTypes(
            string parent,
            scg::IEnumerable<string> entityTypeNames,
            gaxgrpc::CallSettings callSettings = null) => BatchDeleteEntityTypes(
                new BatchDeleteEntityTypesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    EntityTypeNames = { gax::GaxPreconditions.CheckNotNull(entityTypeNames, nameof(entityTypeNames)) },
                },
                callSettings);

        /// <summary>
        /// Deletes entity types in the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchDeleteEntityTypesAsync(
            BatchDeleteEntityTypesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchDeleteEntityTypesAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> PollOnceBatchDeleteEntityTypesAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, pbwkt::Struct>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                BatchDeleteEntityTypesOperationsClient,
                callSettings);

        /// <summary>
        /// Deletes entity types in the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchDeleteEntityTypes(
            BatchDeleteEntityTypesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>BatchDeleteEntityTypes</c>.
        /// </summary>
        public virtual lro::OperationsClient BatchDeleteEntityTypesOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchDeleteEntityTypes</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> PollOnceBatchDeleteEntityTypes(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, pbwkt::Struct>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                BatchDeleteEntityTypesOperationsClient,
                callSettings);

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to create entities in. Format:
        /// `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entities">
        /// Required. The entities to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchCreateEntitiesAsync(
            EntityTypeName parent,
            scg::IEnumerable<EntityType.Types.Entity> entities,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateEntitiesAsync(
                new BatchCreateEntitiesRequest
                {
                    ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Entities = { gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)) },
                },
                callSettings);

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to create entities in. Format:
        /// `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entities">
        /// Required. The entities to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchCreateEntitiesAsync(
            EntityTypeName parent,
            scg::IEnumerable<EntityType.Types.Entity> entities,
            st::CancellationToken cancellationToken) => BatchCreateEntitiesAsync(
                parent,
                entities,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to create entities in. Format:
        /// `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entities">
        /// Required. The entities to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchCreateEntities(
            EntityTypeName parent,
            scg::IEnumerable<EntityType.Types.Entity> entities,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateEntities(
                new BatchCreateEntitiesRequest
                {
                    ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Entities = { gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)) },
                },
                callSettings);

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to create entities in. Format:
        /// `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entities">
        /// Required. The entities to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchCreateEntitiesAsync(
            string parent,
            scg::IEnumerable<EntityType.Types.Entity> entities,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateEntitiesAsync(
                new BatchCreateEntitiesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Entities = { gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)) },
                },
                callSettings);

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to create entities in. Format:
        /// `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entities">
        /// Required. The entities to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchCreateEntitiesAsync(
            string parent,
            scg::IEnumerable<EntityType.Types.Entity> entities,
            st::CancellationToken cancellationToken) => BatchCreateEntitiesAsync(
                parent,
                entities,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to create entities in. Format:
        /// `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entities">
        /// Required. The entities to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchCreateEntities(
            string parent,
            scg::IEnumerable<EntityType.Types.Entity> entities,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateEntities(
                new BatchCreateEntitiesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Entities = { gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)) },
                },
                callSettings);

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to create entities in. Format:
        /// `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entities">
        /// Required. The entities to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entities`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchCreateEntitiesAsync(
            EntityTypeName parent,
            scg::IEnumerable<EntityType.Types.Entity> entities,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateEntitiesAsync(
                new BatchCreateEntitiesRequest
                {
                    ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Entities = { gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)) },
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to create entities in. Format:
        /// `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entities">
        /// Required. The entities to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entities`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchCreateEntitiesAsync(
            EntityTypeName parent,
            scg::IEnumerable<EntityType.Types.Entity> entities,
            string languageCode,
            st::CancellationToken cancellationToken) => BatchCreateEntitiesAsync(
                parent,
                entities,
                languageCode,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to create entities in. Format:
        /// `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entities">
        /// Required. The entities to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entities`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchCreateEntities(
            EntityTypeName parent,
            scg::IEnumerable<EntityType.Types.Entity> entities,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateEntities(
                new BatchCreateEntitiesRequest
                {
                    ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Entities = { gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)) },
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to create entities in. Format:
        /// `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entities">
        /// Required. The entities to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entities`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchCreateEntitiesAsync(
            string parent,
            scg::IEnumerable<EntityType.Types.Entity> entities,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateEntitiesAsync(
                new BatchCreateEntitiesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Entities = { gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)) },
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to create entities in. Format:
        /// `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entities">
        /// Required. The entities to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entities`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchCreateEntitiesAsync(
            string parent,
            scg::IEnumerable<EntityType.Types.Entity> entities,
            string languageCode,
            st::CancellationToken cancellationToken) => BatchCreateEntitiesAsync(
                parent,
                entities,
                languageCode,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to create entities in. Format:
        /// `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entities">
        /// Required. The entities to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entities`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchCreateEntities(
            string parent,
            scg::IEnumerable<EntityType.Types.Entity> entities,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => BatchCreateEntities(
                new BatchCreateEntitiesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Entities = { gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)) },
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchCreateEntitiesAsync(
            BatchCreateEntitiesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchCreateEntitiesAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> PollOnceBatchCreateEntitiesAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, pbwkt::Struct>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                BatchCreateEntitiesOperationsClient,
                callSettings);

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchCreateEntities(
            BatchCreateEntitiesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>BatchCreateEntities</c>.
        /// </summary>
        public virtual lro::OperationsClient BatchCreateEntitiesOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchCreateEntities</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> PollOnceBatchCreateEntities(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, pbwkt::Struct>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                BatchCreateEntitiesOperationsClient,
                callSettings);

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to update or create entities in.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entities">
        /// Required. The entities to update or create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchUpdateEntitiesAsync(
            EntityTypeName parent,
            scg::IEnumerable<EntityType.Types.Entity> entities,
            gaxgrpc::CallSettings callSettings = null) => BatchUpdateEntitiesAsync(
                new BatchUpdateEntitiesRequest
                {
                    ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Entities = { gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)) },
                },
                callSettings);

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to update or create entities in.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entities">
        /// Required. The entities to update or create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchUpdateEntitiesAsync(
            EntityTypeName parent,
            scg::IEnumerable<EntityType.Types.Entity> entities,
            st::CancellationToken cancellationToken) => BatchUpdateEntitiesAsync(
                parent,
                entities,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to update or create entities in.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entities">
        /// Required. The entities to update or create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchUpdateEntities(
            EntityTypeName parent,
            scg::IEnumerable<EntityType.Types.Entity> entities,
            gaxgrpc::CallSettings callSettings = null) => BatchUpdateEntities(
                new BatchUpdateEntitiesRequest
                {
                    ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Entities = { gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)) },
                },
                callSettings);

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to update or create entities in.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entities">
        /// Required. The entities to update or create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchUpdateEntitiesAsync(
            string parent,
            scg::IEnumerable<EntityType.Types.Entity> entities,
            gaxgrpc::CallSettings callSettings = null) => BatchUpdateEntitiesAsync(
                new BatchUpdateEntitiesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Entities = { gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)) },
                },
                callSettings);

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to update or create entities in.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entities">
        /// Required. The entities to update or create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchUpdateEntitiesAsync(
            string parent,
            scg::IEnumerable<EntityType.Types.Entity> entities,
            st::CancellationToken cancellationToken) => BatchUpdateEntitiesAsync(
                parent,
                entities,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to update or create entities in.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entities">
        /// Required. The entities to update or create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchUpdateEntities(
            string parent,
            scg::IEnumerable<EntityType.Types.Entity> entities,
            gaxgrpc::CallSettings callSettings = null) => BatchUpdateEntities(
                new BatchUpdateEntitiesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Entities = { gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)) },
                },
                callSettings);

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to update or create entities in.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entities">
        /// Required. The entities to update or create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entities`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchUpdateEntitiesAsync(
            EntityTypeName parent,
            scg::IEnumerable<EntityType.Types.Entity> entities,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => BatchUpdateEntitiesAsync(
                new BatchUpdateEntitiesRequest
                {
                    ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Entities = { gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)) },
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to update or create entities in.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entities">
        /// Required. The entities to update or create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entities`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchUpdateEntitiesAsync(
            EntityTypeName parent,
            scg::IEnumerable<EntityType.Types.Entity> entities,
            string languageCode,
            st::CancellationToken cancellationToken) => BatchUpdateEntitiesAsync(
                parent,
                entities,
                languageCode,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to update or create entities in.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entities">
        /// Required. The entities to update or create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entities`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchUpdateEntities(
            EntityTypeName parent,
            scg::IEnumerable<EntityType.Types.Entity> entities,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => BatchUpdateEntities(
                new BatchUpdateEntitiesRequest
                {
                    ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Entities = { gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)) },
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to update or create entities in.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entities">
        /// Required. The entities to update or create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entities`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchUpdateEntitiesAsync(
            string parent,
            scg::IEnumerable<EntityType.Types.Entity> entities,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => BatchUpdateEntitiesAsync(
                new BatchUpdateEntitiesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Entities = { gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)) },
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to update or create entities in.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entities">
        /// Required. The entities to update or create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entities`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchUpdateEntitiesAsync(
            string parent,
            scg::IEnumerable<EntityType.Types.Entity> entities,
            string languageCode,
            st::CancellationToken cancellationToken) => BatchUpdateEntitiesAsync(
                parent,
                entities,
                languageCode,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to update or create entities in.
        /// Format: `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entities">
        /// Required. The entities to update or create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entities`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchUpdateEntities(
            string parent,
            scg::IEnumerable<EntityType.Types.Entity> entities,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => BatchUpdateEntities(
                new BatchUpdateEntitiesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Entities = { gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)) },
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchUpdateEntitiesAsync(
            BatchUpdateEntitiesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchUpdateEntitiesAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> PollOnceBatchUpdateEntitiesAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, pbwkt::Struct>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                BatchUpdateEntitiesOperationsClient,
                callSettings);

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchUpdateEntities(
            BatchUpdateEntitiesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>BatchUpdateEntities</c>.
        /// </summary>
        public virtual lro::OperationsClient BatchUpdateEntitiesOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchUpdateEntities</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> PollOnceBatchUpdateEntities(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, pbwkt::Struct>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                BatchUpdateEntitiesOperationsClient,
                callSettings);

        /// <summary>
        /// Deletes entities in the specified entity type.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to delete entries for. Format:
        /// `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entityValues">
        /// Required. The canonical `values` of the entities to delete. Note that
        /// these are not fully-qualified names, i.e. they don't start with
        /// `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchDeleteEntitiesAsync(
            EntityTypeName parent,
            scg::IEnumerable<string> entityValues,
            gaxgrpc::CallSettings callSettings = null) => BatchDeleteEntitiesAsync(
                new BatchDeleteEntitiesRequest
                {
                    ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    EntityValues = { gax::GaxPreconditions.CheckNotNull(entityValues, nameof(entityValues)) },
                },
                callSettings);

        /// <summary>
        /// Deletes entities in the specified entity type.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to delete entries for. Format:
        /// `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entityValues">
        /// Required. The canonical `values` of the entities to delete. Note that
        /// these are not fully-qualified names, i.e. they don't start with
        /// `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchDeleteEntitiesAsync(
            EntityTypeName parent,
            scg::IEnumerable<string> entityValues,
            st::CancellationToken cancellationToken) => BatchDeleteEntitiesAsync(
                parent,
                entityValues,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes entities in the specified entity type.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to delete entries for. Format:
        /// `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entityValues">
        /// Required. The canonical `values` of the entities to delete. Note that
        /// these are not fully-qualified names, i.e. they don't start with
        /// `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchDeleteEntities(
            EntityTypeName parent,
            scg::IEnumerable<string> entityValues,
            gaxgrpc::CallSettings callSettings = null) => BatchDeleteEntities(
                new BatchDeleteEntitiesRequest
                {
                    ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    EntityValues = { gax::GaxPreconditions.CheckNotNull(entityValues, nameof(entityValues)) },
                },
                callSettings);

        /// <summary>
        /// Deletes entities in the specified entity type.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to delete entries for. Format:
        /// `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entityValues">
        /// Required. The canonical `values` of the entities to delete. Note that
        /// these are not fully-qualified names, i.e. they don't start with
        /// `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchDeleteEntitiesAsync(
            string parent,
            scg::IEnumerable<string> entityValues,
            gaxgrpc::CallSettings callSettings = null) => BatchDeleteEntitiesAsync(
                new BatchDeleteEntitiesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    EntityValues = { gax::GaxPreconditions.CheckNotNull(entityValues, nameof(entityValues)) },
                },
                callSettings);

        /// <summary>
        /// Deletes entities in the specified entity type.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to delete entries for. Format:
        /// `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entityValues">
        /// Required. The canonical `values` of the entities to delete. Note that
        /// these are not fully-qualified names, i.e. they don't start with
        /// `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchDeleteEntitiesAsync(
            string parent,
            scg::IEnumerable<string> entityValues,
            st::CancellationToken cancellationToken) => BatchDeleteEntitiesAsync(
                parent,
                entityValues,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes entities in the specified entity type.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to delete entries for. Format:
        /// `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entityValues">
        /// Required. The canonical `values` of the entities to delete. Note that
        /// these are not fully-qualified names, i.e. they don't start with
        /// `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchDeleteEntities(
            string parent,
            scg::IEnumerable<string> entityValues,
            gaxgrpc::CallSettings callSettings = null) => BatchDeleteEntities(
                new BatchDeleteEntitiesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    EntityValues = { gax::GaxPreconditions.CheckNotNull(entityValues, nameof(entityValues)) },
                },
                callSettings);

        /// <summary>
        /// Deletes entities in the specified entity type.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to delete entries for. Format:
        /// `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entityValues">
        /// Required. The canonical `values` of the entities to delete. Note that
        /// these are not fully-qualified names, i.e. they don't start with
        /// `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entities`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchDeleteEntitiesAsync(
            EntityTypeName parent,
            scg::IEnumerable<string> entityValues,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => BatchDeleteEntitiesAsync(
                new BatchDeleteEntitiesRequest
                {
                    ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    EntityValues = { gax::GaxPreconditions.CheckNotNull(entityValues, nameof(entityValues)) },
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Deletes entities in the specified entity type.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to delete entries for. Format:
        /// `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entityValues">
        /// Required. The canonical `values` of the entities to delete. Note that
        /// these are not fully-qualified names, i.e. they don't start with
        /// `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entities`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchDeleteEntitiesAsync(
            EntityTypeName parent,
            scg::IEnumerable<string> entityValues,
            string languageCode,
            st::CancellationToken cancellationToken) => BatchDeleteEntitiesAsync(
                parent,
                entityValues,
                languageCode,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes entities in the specified entity type.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to delete entries for. Format:
        /// `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entityValues">
        /// Required. The canonical `values` of the entities to delete. Note that
        /// these are not fully-qualified names, i.e. they don't start with
        /// `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entities`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchDeleteEntities(
            EntityTypeName parent,
            scg::IEnumerable<string> entityValues,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => BatchDeleteEntities(
                new BatchDeleteEntitiesRequest
                {
                    ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    EntityValues = { gax::GaxPreconditions.CheckNotNull(entityValues, nameof(entityValues)) },
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Deletes entities in the specified entity type.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to delete entries for. Format:
        /// `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entityValues">
        /// Required. The canonical `values` of the entities to delete. Note that
        /// these are not fully-qualified names, i.e. they don't start with
        /// `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entities`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchDeleteEntitiesAsync(
            string parent,
            scg::IEnumerable<string> entityValues,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => BatchDeleteEntitiesAsync(
                new BatchDeleteEntitiesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    EntityValues = { gax::GaxPreconditions.CheckNotNull(entityValues, nameof(entityValues)) },
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Deletes entities in the specified entity type.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to delete entries for. Format:
        /// `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entityValues">
        /// Required. The canonical `values` of the entities to delete. Note that
        /// these are not fully-qualified names, i.e. they don't start with
        /// `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entities`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchDeleteEntitiesAsync(
            string parent,
            scg::IEnumerable<string> entityValues,
            string languageCode,
            st::CancellationToken cancellationToken) => BatchDeleteEntitiesAsync(
                parent,
                entityValues,
                languageCode,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes entities in the specified entity type.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to delete entries for. Format:
        /// `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="entityValues">
        /// Required. The canonical `values` of the entities to delete. Note that
        /// these are not fully-qualified names, i.e. they don't start with
        /// `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language of entity synonyms defined in `entities`. If not
        /// specified, the agent's default language is used.
        /// [Many
        /// languages](https://cloud.google.com/dialogflow/docs/reference/language)
        /// are supported. Note: languages must be enabled in the agent before they can
        /// be used.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchDeleteEntities(
            string parent,
            scg::IEnumerable<string> entityValues,
            string languageCode,
            gaxgrpc::CallSettings callSettings = null) => BatchDeleteEntities(
                new BatchDeleteEntitiesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    EntityValues = { gax::GaxPreconditions.CheckNotNull(entityValues, nameof(entityValues)) },
                    LanguageCode = languageCode ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Deletes entities in the specified entity type.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchDeleteEntitiesAsync(
            BatchDeleteEntitiesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchDeleteEntitiesAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> PollOnceBatchDeleteEntitiesAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, pbwkt::Struct>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                BatchDeleteEntitiesOperationsClient,
                callSettings);

        /// <summary>
        /// Deletes entities in the specified entity type.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchDeleteEntities(
            BatchDeleteEntitiesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>BatchDeleteEntities</c>.
        /// </summary>
        public virtual lro::OperationsClient BatchDeleteEntitiesOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchDeleteEntities</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Struct> PollOnceBatchDeleteEntities(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, pbwkt::Struct>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                BatchDeleteEntitiesOperationsClient,
                callSettings);

    }

    /// <summary>
    /// EntityTypes client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class EntityTypesClientImpl : EntityTypesClient
    {
        private readonly gaxgrpc::ApiCall<ListEntityTypesRequest, ListEntityTypesResponse> _callListEntityTypes;
        private readonly gaxgrpc::ApiCall<GetEntityTypeRequest, EntityType> _callGetEntityType;
        private readonly gaxgrpc::ApiCall<CreateEntityTypeRequest, EntityType> _callCreateEntityType;
        private readonly gaxgrpc::ApiCall<UpdateEntityTypeRequest, EntityType> _callUpdateEntityType;
        private readonly gaxgrpc::ApiCall<DeleteEntityTypeRequest, pbwkt::Empty> _callDeleteEntityType;
        private readonly gaxgrpc::ApiCall<BatchUpdateEntityTypesRequest, lro::Operation> _callBatchUpdateEntityTypes;
        private readonly gaxgrpc::ApiCall<BatchDeleteEntityTypesRequest, lro::Operation> _callBatchDeleteEntityTypes;
        private readonly gaxgrpc::ApiCall<BatchCreateEntitiesRequest, lro::Operation> _callBatchCreateEntities;
        private readonly gaxgrpc::ApiCall<BatchUpdateEntitiesRequest, lro::Operation> _callBatchUpdateEntities;
        private readonly gaxgrpc::ApiCall<BatchDeleteEntitiesRequest, lro::Operation> _callBatchDeleteEntities;

        /// <summary>
        /// Constructs a client wrapper for the EntityTypes service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="EntityTypesSettings"/> used within this client </param>
        public EntityTypesClientImpl(EntityTypes.EntityTypesClient grpcClient, EntityTypesSettings settings)
        {
            GrpcClient = grpcClient;
            EntityTypesSettings effectiveSettings = settings ?? EntityTypesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            BatchUpdateEntityTypesOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.BatchUpdateEntityTypesOperationsSettings);
            BatchDeleteEntityTypesOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.BatchDeleteEntityTypesOperationsSettings);
            BatchCreateEntitiesOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.BatchCreateEntitiesOperationsSettings);
            BatchUpdateEntitiesOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.BatchUpdateEntitiesOperationsSettings);
            BatchDeleteEntitiesOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.BatchDeleteEntitiesOperationsSettings);
            _callListEntityTypes = clientHelper.BuildApiCall<ListEntityTypesRequest, ListEntityTypesResponse>(
                GrpcClient.ListEntityTypesAsync, GrpcClient.ListEntityTypes, effectiveSettings.ListEntityTypesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callGetEntityType = clientHelper.BuildApiCall<GetEntityTypeRequest, EntityType>(
                GrpcClient.GetEntityTypeAsync, GrpcClient.GetEntityType, effectiveSettings.GetEntityTypeSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callCreateEntityType = clientHelper.BuildApiCall<CreateEntityTypeRequest, EntityType>(
                GrpcClient.CreateEntityTypeAsync, GrpcClient.CreateEntityType, effectiveSettings.CreateEntityTypeSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callUpdateEntityType = clientHelper.BuildApiCall<UpdateEntityTypeRequest, EntityType>(
                GrpcClient.UpdateEntityTypeAsync, GrpcClient.UpdateEntityType, effectiveSettings.UpdateEntityTypeSettings)
                .WithGoogleRequestParam("entity_type.name", request => request.EntityType?.Name);
            _callDeleteEntityType = clientHelper.BuildApiCall<DeleteEntityTypeRequest, pbwkt::Empty>(
                GrpcClient.DeleteEntityTypeAsync, GrpcClient.DeleteEntityType, effectiveSettings.DeleteEntityTypeSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callBatchUpdateEntityTypes = clientHelper.BuildApiCall<BatchUpdateEntityTypesRequest, lro::Operation>(
                GrpcClient.BatchUpdateEntityTypesAsync, GrpcClient.BatchUpdateEntityTypes, effectiveSettings.BatchUpdateEntityTypesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callBatchDeleteEntityTypes = clientHelper.BuildApiCall<BatchDeleteEntityTypesRequest, lro::Operation>(
                GrpcClient.BatchDeleteEntityTypesAsync, GrpcClient.BatchDeleteEntityTypes, effectiveSettings.BatchDeleteEntityTypesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callBatchCreateEntities = clientHelper.BuildApiCall<BatchCreateEntitiesRequest, lro::Operation>(
                GrpcClient.BatchCreateEntitiesAsync, GrpcClient.BatchCreateEntities, effectiveSettings.BatchCreateEntitiesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callBatchUpdateEntities = clientHelper.BuildApiCall<BatchUpdateEntitiesRequest, lro::Operation>(
                GrpcClient.BatchUpdateEntitiesAsync, GrpcClient.BatchUpdateEntities, effectiveSettings.BatchUpdateEntitiesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callBatchDeleteEntities = clientHelper.BuildApiCall<BatchDeleteEntitiesRequest, lro::Operation>(
                GrpcClient.BatchDeleteEntitiesAsync, GrpcClient.BatchDeleteEntities, effectiveSettings.BatchDeleteEntitiesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEntityTypes);
            Modify_ListEntityTypesApiCall(ref _callListEntityTypes);
            Modify_ApiCall(ref _callGetEntityType);
            Modify_GetEntityTypeApiCall(ref _callGetEntityType);
            Modify_ApiCall(ref _callCreateEntityType);
            Modify_CreateEntityTypeApiCall(ref _callCreateEntityType);
            Modify_ApiCall(ref _callUpdateEntityType);
            Modify_UpdateEntityTypeApiCall(ref _callUpdateEntityType);
            Modify_ApiCall(ref _callDeleteEntityType);
            Modify_DeleteEntityTypeApiCall(ref _callDeleteEntityType);
            Modify_ApiCall(ref _callBatchUpdateEntityTypes);
            Modify_BatchUpdateEntityTypesApiCall(ref _callBatchUpdateEntityTypes);
            Modify_ApiCall(ref _callBatchDeleteEntityTypes);
            Modify_BatchDeleteEntityTypesApiCall(ref _callBatchDeleteEntityTypes);
            Modify_ApiCall(ref _callBatchCreateEntities);
            Modify_BatchCreateEntitiesApiCall(ref _callBatchCreateEntities);
            Modify_ApiCall(ref _callBatchUpdateEntities);
            Modify_BatchUpdateEntitiesApiCall(ref _callBatchUpdateEntities);
            Modify_ApiCall(ref _callBatchDeleteEntities);
            Modify_BatchDeleteEntitiesApiCall(ref _callBatchDeleteEntities);
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
        partial void Modify_ListEntityTypesApiCall(ref gaxgrpc::ApiCall<ListEntityTypesRequest, ListEntityTypesResponse> call);
        partial void Modify_GetEntityTypeApiCall(ref gaxgrpc::ApiCall<GetEntityTypeRequest, EntityType> call);
        partial void Modify_CreateEntityTypeApiCall(ref gaxgrpc::ApiCall<CreateEntityTypeRequest, EntityType> call);
        partial void Modify_UpdateEntityTypeApiCall(ref gaxgrpc::ApiCall<UpdateEntityTypeRequest, EntityType> call);
        partial void Modify_DeleteEntityTypeApiCall(ref gaxgrpc::ApiCall<DeleteEntityTypeRequest, pbwkt::Empty> call);
        partial void Modify_BatchUpdateEntityTypesApiCall(ref gaxgrpc::ApiCall<BatchUpdateEntityTypesRequest, lro::Operation> call);
        partial void Modify_BatchDeleteEntityTypesApiCall(ref gaxgrpc::ApiCall<BatchDeleteEntityTypesRequest, lro::Operation> call);
        partial void Modify_BatchCreateEntitiesApiCall(ref gaxgrpc::ApiCall<BatchCreateEntitiesRequest, lro::Operation> call);
        partial void Modify_BatchUpdateEntitiesApiCall(ref gaxgrpc::ApiCall<BatchUpdateEntitiesRequest, lro::Operation> call);
        partial void Modify_BatchDeleteEntitiesApiCall(ref gaxgrpc::ApiCall<BatchDeleteEntitiesRequest, lro::Operation> call);
        partial void OnConstruction(EntityTypes.EntityTypesClient grpcClient, EntityTypesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC EntityTypes client.
        /// </summary>
        public override EntityTypes.EntityTypesClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListEntityTypesRequest(ref ListEntityTypesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetEntityTypeRequest(ref GetEntityTypeRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateEntityTypeRequest(ref CreateEntityTypeRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateEntityTypeRequest(ref UpdateEntityTypeRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteEntityTypeRequest(ref DeleteEntityTypeRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_BatchUpdateEntityTypesRequest(ref BatchUpdateEntityTypesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_BatchDeleteEntityTypesRequest(ref BatchDeleteEntityTypesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_BatchCreateEntitiesRequest(ref BatchCreateEntitiesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_BatchUpdateEntitiesRequest(ref BatchUpdateEntitiesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_BatchDeleteEntitiesRequest(ref BatchDeleteEntitiesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the list of all entity types in the specified agent.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="EntityType"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypesAsync(
            ListEntityTypesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntityTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEntityTypesRequest, ListEntityTypesResponse, EntityType>(_callListEntityTypes, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all entity types in the specified agent.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="EntityType"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypes(
            ListEntityTypesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntityTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEntityTypesRequest, ListEntityTypesResponse, EntityType>(_callListEntityTypes, request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified entity type.
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
        public override stt::Task<EntityType> GetEntityTypeAsync(
            GetEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntityTypeRequest(ref request, ref callSettings);
            return _callGetEntityType.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified entity type.
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
        public override EntityType GetEntityType(
            GetEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntityTypeRequest(ref request, ref callSettings);
            return _callGetEntityType.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an entity type in the specified agent.
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
        public override stt::Task<EntityType> CreateEntityTypeAsync(
            CreateEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntityTypeRequest(ref request, ref callSettings);
            return _callCreateEntityType.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an entity type in the specified agent.
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
        public override EntityType CreateEntityType(
            CreateEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntityTypeRequest(ref request, ref callSettings);
            return _callCreateEntityType.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified entity type.
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
        public override stt::Task<EntityType> UpdateEntityTypeAsync(
            UpdateEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEntityTypeRequest(ref request, ref callSettings);
            return _callUpdateEntityType.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified entity type.
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
        public override EntityType UpdateEntityType(
            UpdateEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEntityTypeRequest(ref request, ref callSettings);
            return _callUpdateEntityType.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified entity type.
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
        public override stt::Task DeleteEntityTypeAsync(
            DeleteEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEntityTypeRequest(ref request, ref callSettings);
            return _callDeleteEntityType.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified entity type.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteEntityType(
            DeleteEntityTypeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEntityTypeRequest(ref request, ref callSettings);
            _callDeleteEntityType.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates/Creates multiple entity types in the specified agent.
        ///
        /// Operation &lt;response: [BatchUpdateEntityTypesResponse][google.cloud.dialogflow.v2.BatchUpdateEntityTypesResponse]&gt;
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
        public override async stt::Task<lro::Operation<BatchUpdateEntityTypesResponse, pbwkt::Struct>> BatchUpdateEntityTypesAsync(
            BatchUpdateEntityTypesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateEntityTypesRequest(ref request, ref callSettings);
            return new lro::Operation<BatchUpdateEntityTypesResponse, pbwkt::Struct>(
                await _callBatchUpdateEntityTypes.Async(request, callSettings).ConfigureAwait(false), BatchUpdateEntityTypesOperationsClient);
        }

        /// <summary>
        /// Updates/Creates multiple entity types in the specified agent.
        ///
        /// Operation &lt;response: [BatchUpdateEntityTypesResponse][google.cloud.dialogflow.v2.BatchUpdateEntityTypesResponse]&gt;
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
        public override lro::Operation<BatchUpdateEntityTypesResponse, pbwkt::Struct> BatchUpdateEntityTypes(
            BatchUpdateEntityTypesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateEntityTypesRequest(ref request, ref callSettings);
            return new lro::Operation<BatchUpdateEntityTypesResponse, pbwkt::Struct>(
                _callBatchUpdateEntityTypes.Sync(request, callSettings), BatchUpdateEntityTypesOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>BatchUpdateEntityTypes</c>.
        /// </summary>
        public override lro::OperationsClient BatchUpdateEntityTypesOperationsClient { get; }

        /// <summary>
        /// Deletes entity types in the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public override async stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchDeleteEntityTypesAsync(
            BatchDeleteEntityTypesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteEntityTypesRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, pbwkt::Struct>(
                await _callBatchDeleteEntityTypes.Async(request, callSettings).ConfigureAwait(false), BatchDeleteEntityTypesOperationsClient);
        }

        /// <summary>
        /// Deletes entity types in the specified agent.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public override lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchDeleteEntityTypes(
            BatchDeleteEntityTypesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteEntityTypesRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, pbwkt::Struct>(
                _callBatchDeleteEntityTypes.Sync(request, callSettings), BatchDeleteEntityTypesOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>BatchDeleteEntityTypes</c>.
        /// </summary>
        public override lro::OperationsClient BatchDeleteEntityTypesOperationsClient { get; }

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public override async stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchCreateEntitiesAsync(
            BatchCreateEntitiesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateEntitiesRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, pbwkt::Struct>(
                await _callBatchCreateEntities.Async(request, callSettings).ConfigureAwait(false), BatchCreateEntitiesOperationsClient);
        }

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public override lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchCreateEntities(
            BatchCreateEntitiesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateEntitiesRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, pbwkt::Struct>(
                _callBatchCreateEntities.Sync(request, callSettings), BatchCreateEntitiesOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>BatchCreateEntities</c>.
        /// </summary>
        public override lro::OperationsClient BatchCreateEntitiesOperationsClient { get; }

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public override async stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchUpdateEntitiesAsync(
            BatchUpdateEntitiesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateEntitiesRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, pbwkt::Struct>(
                await _callBatchUpdateEntities.Async(request, callSettings).ConfigureAwait(false), BatchUpdateEntitiesOperationsClient);
        }

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public override lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchUpdateEntities(
            BatchUpdateEntitiesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateEntitiesRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, pbwkt::Struct>(
                _callBatchUpdateEntities.Sync(request, callSettings), BatchUpdateEntitiesOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>BatchUpdateEntities</c>.
        /// </summary>
        public override lro::OperationsClient BatchUpdateEntitiesOperationsClient { get; }

        /// <summary>
        /// Deletes entities in the specified entity type.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public override async stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Struct>> BatchDeleteEntitiesAsync(
            BatchDeleteEntitiesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteEntitiesRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, pbwkt::Struct>(
                await _callBatchDeleteEntities.Async(request, callSettings).ConfigureAwait(false), BatchDeleteEntitiesOperationsClient);
        }

        /// <summary>
        /// Deletes entities in the specified entity type.
        ///
        ///
        /// Operation &lt;response: [google.protobuf.Empty][google.protobuf.Empty]&gt;
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
        public override lro::Operation<pbwkt::Empty, pbwkt::Struct> BatchDeleteEntities(
            BatchDeleteEntitiesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteEntitiesRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, pbwkt::Struct>(
                _callBatchDeleteEntities.Sync(request, callSettings), BatchDeleteEntitiesOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>BatchDeleteEntities</c>.
        /// </summary>
        public override lro::OperationsClient BatchDeleteEntitiesOperationsClient { get; }

    }

    // Partial classes to enable page-streaming

    public partial class ListEntityTypesRequest : gaxgrpc::IPageRequest { }
    public partial class ListEntityTypesResponse : gaxgrpc::IPageResponse<EntityType>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<EntityType> GetEnumerator() => EntityTypes.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // Partial Grpc class to enable LRO client creation
    public static partial class EntityTypes
    {
        public partial class EntityTypesClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() => new lro::Operations.OperationsClient(CallInvoker);
        }
    }


}
