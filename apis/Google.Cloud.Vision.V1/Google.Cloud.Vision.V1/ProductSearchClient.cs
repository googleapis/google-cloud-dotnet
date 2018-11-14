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

namespace Google.Cloud.Vision.V1
{
    /// <summary>
    /// Settings for a <see cref="ProductSearchClient"/>.
    /// </summary>
    public sealed partial class ProductSearchSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ProductSearchSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="ProductSearchSettings"/>.
        /// </returns>
        public static ProductSearchSettings GetDefault() => new ProductSearchSettings();

        /// <summary>
        /// Constructs a new <see cref="ProductSearchSettings"/> object with default settings.
        /// </summary>
        public ProductSearchSettings() { }

        private ProductSearchSettings(ProductSearchSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateProductSettings = existing.CreateProductSettings;
            ListProductsSettings = existing.ListProductsSettings;
            GetProductSettings = existing.GetProductSettings;
            UpdateProductSettings = existing.UpdateProductSettings;
            DeleteProductSettings = existing.DeleteProductSettings;
            ListReferenceImagesSettings = existing.ListReferenceImagesSettings;
            GetReferenceImageSettings = existing.GetReferenceImageSettings;
            DeleteReferenceImageSettings = existing.DeleteReferenceImageSettings;
            CreateReferenceImageSettings = existing.CreateReferenceImageSettings;
            CreateProductSetSettings = existing.CreateProductSetSettings;
            ListProductSetsSettings = existing.ListProductSetsSettings;
            GetProductSetSettings = existing.GetProductSetSettings;
            UpdateProductSetSettings = existing.UpdateProductSetSettings;
            DeleteProductSetSettings = existing.DeleteProductSetSettings;
            AddProductToProductSetSettings = existing.AddProductToProductSetSettings;
            RemoveProductFromProductSetSettings = existing.RemoveProductFromProductSetSettings;
            ListProductsInProductSetSettings = existing.ListProductsInProductSetSettings;
            ImportProductSetsSettings = existing.ImportProductSetsSettings;
            ImportProductSetsOperationsSettings = existing.ImportProductSetsOperationsSettings?.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(ProductSearchSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="ProductSearchClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="ProductSearchClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="ProductSearchClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="ProductSearchClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="ProductSearchClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="ProductSearchClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="ProductSearchClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="ProductSearchClient"/> RPC methods is defined as:
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
        /// <c>ProductSearchClient.CreateProduct</c> and <c>ProductSearchClient.CreateProductAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ProductSearchClient.CreateProduct</c> and
        /// <c>ProductSearchClient.CreateProductAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateProductSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.ListProducts</c> and <c>ProductSearchClient.ListProductsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ProductSearchClient.ListProducts</c> and
        /// <c>ProductSearchClient.ListProductsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListProductsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.GetProduct</c> and <c>ProductSearchClient.GetProductAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ProductSearchClient.GetProduct</c> and
        /// <c>ProductSearchClient.GetProductAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetProductSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.UpdateProduct</c> and <c>ProductSearchClient.UpdateProductAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ProductSearchClient.UpdateProduct</c> and
        /// <c>ProductSearchClient.UpdateProductAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings UpdateProductSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.DeleteProduct</c> and <c>ProductSearchClient.DeleteProductAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ProductSearchClient.DeleteProduct</c> and
        /// <c>ProductSearchClient.DeleteProductAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteProductSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.ListReferenceImages</c> and <c>ProductSearchClient.ListReferenceImagesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ProductSearchClient.ListReferenceImages</c> and
        /// <c>ProductSearchClient.ListReferenceImagesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListReferenceImagesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.GetReferenceImage</c> and <c>ProductSearchClient.GetReferenceImageAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ProductSearchClient.GetReferenceImage</c> and
        /// <c>ProductSearchClient.GetReferenceImageAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetReferenceImageSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.DeleteReferenceImage</c> and <c>ProductSearchClient.DeleteReferenceImageAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ProductSearchClient.DeleteReferenceImage</c> and
        /// <c>ProductSearchClient.DeleteReferenceImageAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteReferenceImageSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.CreateReferenceImage</c> and <c>ProductSearchClient.CreateReferenceImageAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ProductSearchClient.CreateReferenceImage</c> and
        /// <c>ProductSearchClient.CreateReferenceImageAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateReferenceImageSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.CreateProductSet</c> and <c>ProductSearchClient.CreateProductSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ProductSearchClient.CreateProductSet</c> and
        /// <c>ProductSearchClient.CreateProductSetAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateProductSetSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.ListProductSets</c> and <c>ProductSearchClient.ListProductSetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ProductSearchClient.ListProductSets</c> and
        /// <c>ProductSearchClient.ListProductSetsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListProductSetsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.GetProductSet</c> and <c>ProductSearchClient.GetProductSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ProductSearchClient.GetProductSet</c> and
        /// <c>ProductSearchClient.GetProductSetAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetProductSetSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.UpdateProductSet</c> and <c>ProductSearchClient.UpdateProductSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ProductSearchClient.UpdateProductSet</c> and
        /// <c>ProductSearchClient.UpdateProductSetAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings UpdateProductSetSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.DeleteProductSet</c> and <c>ProductSearchClient.DeleteProductSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ProductSearchClient.DeleteProductSet</c> and
        /// <c>ProductSearchClient.DeleteProductSetAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteProductSetSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.AddProductToProductSet</c> and <c>ProductSearchClient.AddProductToProductSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ProductSearchClient.AddProductToProductSet</c> and
        /// <c>ProductSearchClient.AddProductToProductSetAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings AddProductToProductSetSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.RemoveProductFromProductSet</c> and <c>ProductSearchClient.RemoveProductFromProductSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ProductSearchClient.RemoveProductFromProductSet</c> and
        /// <c>ProductSearchClient.RemoveProductFromProductSetAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings RemoveProductFromProductSetSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.ListProductsInProductSet</c> and <c>ProductSearchClient.ListProductsInProductSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ProductSearchClient.ListProductsInProductSet</c> and
        /// <c>ProductSearchClient.ListProductsInProductSetAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListProductsInProductSetSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.ImportProductSets</c> and <c>ProductSearchClient.ImportProductSetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ProductSearchClient.ImportProductSets</c> and
        /// <c>ProductSearchClient.ImportProductSetsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ImportProductSetsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProductSearchClient.ImportProductSets</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45000 milliseconds</description></item>
        /// <item><description>Total timeout: 86400000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings ImportProductSetsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(86400000L)),
                sys::TimeSpan.FromMilliseconds(20000L),
                1.5,
                sys::TimeSpan.FromMilliseconds(45000L))
        };

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="ProductSearchSettings"/> object.</returns>
        public ProductSearchSettings Clone() => new ProductSearchSettings(this);
    }

    /// <summary>
    /// ProductSearch client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ProductSearchClient
    {
        /// <summary>
        /// The default endpoint for the ProductSearch service, which is a host of "vision.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("vision.googleapis.com", 443);

        /// <summary>
        /// The default ProductSearch scopes.
        /// </summary>
        /// <remarks>
        /// The default ProductSearch scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-vision"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-vision",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ProductSearchClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ProductSearchClient client = await ProductSearchClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ProductSearchClient.DefaultEndpoint.Host, ProductSearchClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ProductSearchClient client = ProductSearchClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ProductSearchSettings"/>.</param>
        /// <returns>The task representing the created <see cref="ProductSearchClient"/>.</returns>
        public static async stt::Task<ProductSearchClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, ProductSearchSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ProductSearchClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ProductSearchClient client = ProductSearchClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ProductSearchClient.DefaultEndpoint.Host, ProductSearchClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ProductSearchClient client = ProductSearchClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ProductSearchSettings"/>.</param>
        /// <returns>The created <see cref="ProductSearchClient"/>.</returns>
        public static ProductSearchClient Create(gaxgrpc::ServiceEndpoint endpoint = null, ProductSearchSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ProductSearchClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ProductSearchSettings"/>.</param>
        /// <returns>The created <see cref="ProductSearchClient"/>.</returns>
        public static ProductSearchClient Create(grpccore::Channel channel, ProductSearchSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="ProductSearchClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ProductSearchSettings"/>.</param>
        /// <returns>The created <see cref="ProductSearchClient"/>.</returns>
        public static ProductSearchClient Create(grpccore::CallInvoker callInvoker, ProductSearchSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ProductSearch.ProductSearchClient grpcClient = new ProductSearch.ProductSearchClient(callInvoker);
            return new ProductSearchClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, ProductSearchSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ProductSearchSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, ProductSearchSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ProductSearchSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC ProductSearch client.
        /// </summary>
        public virtual ProductSearch.ProductSearchClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Creates and returns a new product resource.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if display_name is missing or longer than 4096
        ///   characters.
        /// * Returns INVALID_ARGUMENT if description is longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is missing or invalid.
        /// </summary>
        /// <param name="parent">
        /// The project in which the Product should be created.
        ///
        /// Format is
        /// `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="product">
        /// The product to create.
        /// </param>
        /// <param name="productId">
        /// A user-supplied resource id for this Product. If set, the server will
        /// attempt to use this value as the resource id. If it is already in use, an
        /// error is returned with code ALREADY_EXISTS. Must be at most 128 characters
        /// long. It cannot contain the character `/`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Product> CreateProductAsync(
            LocationName parent,
            Product product,
            string productId,
            gaxgrpc::CallSettings callSettings = null) => CreateProductAsync(
                new CreateProductRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Product = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
                    ProductId = productId ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Creates and returns a new product resource.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if display_name is missing or longer than 4096
        ///   characters.
        /// * Returns INVALID_ARGUMENT if description is longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is missing or invalid.
        /// </summary>
        /// <param name="parent">
        /// The project in which the Product should be created.
        ///
        /// Format is
        /// `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="product">
        /// The product to create.
        /// </param>
        /// <param name="productId">
        /// A user-supplied resource id for this Product. If set, the server will
        /// attempt to use this value as the resource id. If it is already in use, an
        /// error is returned with code ALREADY_EXISTS. Must be at most 128 characters
        /// long. It cannot contain the character `/`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Product> CreateProductAsync(
            LocationName parent,
            Product product,
            string productId,
            st::CancellationToken cancellationToken) => CreateProductAsync(
                parent,
                product,
                productId,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and returns a new product resource.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if display_name is missing or longer than 4096
        ///   characters.
        /// * Returns INVALID_ARGUMENT if description is longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is missing or invalid.
        /// </summary>
        /// <param name="parent">
        /// The project in which the Product should be created.
        ///
        /// Format is
        /// `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="product">
        /// The product to create.
        /// </param>
        /// <param name="productId">
        /// A user-supplied resource id for this Product. If set, the server will
        /// attempt to use this value as the resource id. If it is already in use, an
        /// error is returned with code ALREADY_EXISTS. Must be at most 128 characters
        /// long. It cannot contain the character `/`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Product CreateProduct(
            LocationName parent,
            Product product,
            string productId,
            gaxgrpc::CallSettings callSettings = null) => CreateProduct(
                new CreateProductRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Product = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
                    ProductId = productId ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Creates and returns a new product resource.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if display_name is missing or longer than 4096
        ///   characters.
        /// * Returns INVALID_ARGUMENT if description is longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is missing or invalid.
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
        public virtual stt::Task<Product> CreateProductAsync(
            CreateProductRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates and returns a new product resource.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if display_name is missing or longer than 4096
        ///   characters.
        /// * Returns INVALID_ARGUMENT if description is longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is missing or invalid.
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
        public virtual stt::Task<Product> CreateProductAsync(
            CreateProductRequest request,
            st::CancellationToken cancellationToken) => CreateProductAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and returns a new product resource.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if display_name is missing or longer than 4096
        ///   characters.
        /// * Returns INVALID_ARGUMENT if description is longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is missing or invalid.
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
        public virtual Product CreateProduct(
            CreateProductRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists products in an unspecified order.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100 or less than 1.
        /// </summary>
        /// <param name="parent">
        /// The project OR ProductSet from which Products should be listed.
        ///
        /// Format:
        /// `projects/PROJECT_ID/locations/LOC_ID`
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
        /// A pageable asynchronous sequence of <see cref="Product"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListProductsResponse, Product> ListProductsAsync(
            LocationName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListProductsAsync(
                new ListProductsRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists products in an unspecified order.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100 or less than 1.
        /// </summary>
        /// <param name="parent">
        /// The project OR ProductSet from which Products should be listed.
        ///
        /// Format:
        /// `projects/PROJECT_ID/locations/LOC_ID`
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
        /// A pageable sequence of <see cref="Product"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListProductsResponse, Product> ListProducts(
            LocationName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListProducts(
                new ListProductsRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists products in an unspecified order.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100 or less than 1.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Product"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListProductsResponse, Product> ListProductsAsync(
            ListProductsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists products in an unspecified order.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100 or less than 1.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Product"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListProductsResponse, Product> ListProducts(
            ListProductsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets information associated with a Product.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the Product does not exist.
        /// </summary>
        /// <param name="name">
        /// Resource name of the Product to get.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Product> GetProductAsync(
            ProductName name,
            gaxgrpc::CallSettings callSettings = null) => GetProductAsync(
                new GetProductRequest
                {
                    ProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information associated with a Product.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the Product does not exist.
        /// </summary>
        /// <param name="name">
        /// Resource name of the Product to get.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Product> GetProductAsync(
            ProductName name,
            st::CancellationToken cancellationToken) => GetProductAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information associated with a Product.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the Product does not exist.
        /// </summary>
        /// <param name="name">
        /// Resource name of the Product to get.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Product GetProduct(
            ProductName name,
            gaxgrpc::CallSettings callSettings = null) => GetProduct(
                new GetProductRequest
                {
                    ProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information associated with a Product.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the Product does not exist.
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
        public virtual stt::Task<Product> GetProductAsync(
            GetProductRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets information associated with a Product.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the Product does not exist.
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
        public virtual stt::Task<Product> GetProductAsync(
            GetProductRequest request,
            st::CancellationToken cancellationToken) => GetProductAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information associated with a Product.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the Product does not exist.
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
        public virtual Product GetProduct(
            GetProductRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Makes changes to a Product resource.
        /// Only the `display_name`, `description`, and `labels` fields can be updated
        /// right now.
        ///
        /// If labels are updated, the change will not be reflected in queries until
        /// the next index time.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the Product does not exist.
        /// * Returns INVALID_ARGUMENT if display_name is present in update_mask but is
        ///   missing from the request or longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if description is present in update_mask but is
        ///   longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is present in update_mask.
        /// </summary>
        /// <param name="product">
        /// The Product resource which replaces the one on the server.
        /// product.name is immutable.
        /// </param>
        /// <param name="updateMask">
        /// The [FieldMask][google.protobuf.FieldMask] that specifies which fields
        /// to update.
        /// If update_mask isn't specified, all mutable fields are to be updated.
        /// Valid mask paths include `product_labels`, `display_name`, and
        /// `description`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Product> UpdateProductAsync(
            Product product,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateProductAsync(
                new UpdateProductRequest
                {
                    Product = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Makes changes to a Product resource.
        /// Only the `display_name`, `description`, and `labels` fields can be updated
        /// right now.
        ///
        /// If labels are updated, the change will not be reflected in queries until
        /// the next index time.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the Product does not exist.
        /// * Returns INVALID_ARGUMENT if display_name is present in update_mask but is
        ///   missing from the request or longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if description is present in update_mask but is
        ///   longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is present in update_mask.
        /// </summary>
        /// <param name="product">
        /// The Product resource which replaces the one on the server.
        /// product.name is immutable.
        /// </param>
        /// <param name="updateMask">
        /// The [FieldMask][google.protobuf.FieldMask] that specifies which fields
        /// to update.
        /// If update_mask isn't specified, all mutable fields are to be updated.
        /// Valid mask paths include `product_labels`, `display_name`, and
        /// `description`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Product> UpdateProductAsync(
            Product product,
            pbwkt::FieldMask updateMask,
            st::CancellationToken cancellationToken) => UpdateProductAsync(
                product,
                updateMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Makes changes to a Product resource.
        /// Only the `display_name`, `description`, and `labels` fields can be updated
        /// right now.
        ///
        /// If labels are updated, the change will not be reflected in queries until
        /// the next index time.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the Product does not exist.
        /// * Returns INVALID_ARGUMENT if display_name is present in update_mask but is
        ///   missing from the request or longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if description is present in update_mask but is
        ///   longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is present in update_mask.
        /// </summary>
        /// <param name="product">
        /// The Product resource which replaces the one on the server.
        /// product.name is immutable.
        /// </param>
        /// <param name="updateMask">
        /// The [FieldMask][google.protobuf.FieldMask] that specifies which fields
        /// to update.
        /// If update_mask isn't specified, all mutable fields are to be updated.
        /// Valid mask paths include `product_labels`, `display_name`, and
        /// `description`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Product UpdateProduct(
            Product product,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateProduct(
                new UpdateProductRequest
                {
                    Product = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Makes changes to a Product resource.
        /// Only the `display_name`, `description`, and `labels` fields can be updated
        /// right now.
        ///
        /// If labels are updated, the change will not be reflected in queries until
        /// the next index time.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the Product does not exist.
        /// * Returns INVALID_ARGUMENT if display_name is present in update_mask but is
        ///   missing from the request or longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if description is present in update_mask but is
        ///   longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is present in update_mask.
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
        public virtual stt::Task<Product> UpdateProductAsync(
            UpdateProductRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Makes changes to a Product resource.
        /// Only the `display_name`, `description`, and `labels` fields can be updated
        /// right now.
        ///
        /// If labels are updated, the change will not be reflected in queries until
        /// the next index time.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the Product does not exist.
        /// * Returns INVALID_ARGUMENT if display_name is present in update_mask but is
        ///   missing from the request or longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if description is present in update_mask but is
        ///   longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is present in update_mask.
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
        public virtual stt::Task<Product> UpdateProductAsync(
            UpdateProductRequest request,
            st::CancellationToken cancellationToken) => UpdateProductAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Makes changes to a Product resource.
        /// Only the `display_name`, `description`, and `labels` fields can be updated
        /// right now.
        ///
        /// If labels are updated, the change will not be reflected in queries until
        /// the next index time.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the Product does not exist.
        /// * Returns INVALID_ARGUMENT if display_name is present in update_mask but is
        ///   missing from the request or longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if description is present in update_mask but is
        ///   longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is present in update_mask.
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
        public virtual Product UpdateProduct(
            UpdateProductRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Permanently deletes a product and its reference images.
        ///
        /// Metadata of the product and all its images will be deleted right away, but
        /// search queries against ProductSets containing the product may still work
        /// until all related caches are refreshed.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the product does not exist.
        /// </summary>
        /// <param name="name">
        /// Resource name of product to delete.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteProductAsync(
            ProductName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteProductAsync(
                new DeleteProductRequest
                {
                    ProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Permanently deletes a product and its reference images.
        ///
        /// Metadata of the product and all its images will be deleted right away, but
        /// search queries against ProductSets containing the product may still work
        /// until all related caches are refreshed.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the product does not exist.
        /// </summary>
        /// <param name="name">
        /// Resource name of product to delete.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteProductAsync(
            ProductName name,
            st::CancellationToken cancellationToken) => DeleteProductAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes a product and its reference images.
        ///
        /// Metadata of the product and all its images will be deleted right away, but
        /// search queries against ProductSets containing the product may still work
        /// until all related caches are refreshed.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the product does not exist.
        /// </summary>
        /// <param name="name">
        /// Resource name of product to delete.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteProduct(
            ProductName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteProduct(
                new DeleteProductRequest
                {
                    ProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Permanently deletes a product and its reference images.
        ///
        /// Metadata of the product and all its images will be deleted right away, but
        /// search queries against ProductSets containing the product may still work
        /// until all related caches are refreshed.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the product does not exist.
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
        public virtual stt::Task DeleteProductAsync(
            DeleteProductRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Permanently deletes a product and its reference images.
        ///
        /// Metadata of the product and all its images will be deleted right away, but
        /// search queries against ProductSets containing the product may still work
        /// until all related caches are refreshed.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the product does not exist.
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
        public virtual stt::Task DeleteProductAsync(
            DeleteProductRequest request,
            st::CancellationToken cancellationToken) => DeleteProductAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes a product and its reference images.
        ///
        /// Metadata of the product and all its images will be deleted right away, but
        /// search queries against ProductSets containing the product may still work
        /// until all related caches are refreshed.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the product does not exist.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteProduct(
            DeleteProductRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists reference images.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the parent product does not exist.
        /// * Returns INVALID_ARGUMENT if the page_size is greater than 100, or less
        ///   than 1.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the product containing the reference images.
        ///
        /// Format is
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`.
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
        /// A pageable asynchronous sequence of <see cref="ReferenceImage"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListReferenceImagesResponse, ReferenceImage> ListReferenceImagesAsync(
            ProductName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListReferenceImagesAsync(
                new ListReferenceImagesRequest
                {
                    ParentAsProductName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists reference images.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the parent product does not exist.
        /// * Returns INVALID_ARGUMENT if the page_size is greater than 100, or less
        ///   than 1.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the product containing the reference images.
        ///
        /// Format is
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`.
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
        /// A pageable sequence of <see cref="ReferenceImage"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListReferenceImagesResponse, ReferenceImage> ListReferenceImages(
            ProductName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListReferenceImages(
                new ListReferenceImagesRequest
                {
                    ParentAsProductName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists reference images.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the parent product does not exist.
        /// * Returns INVALID_ARGUMENT if the page_size is greater than 100, or less
        ///   than 1.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ReferenceImage"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListReferenceImagesResponse, ReferenceImage> ListReferenceImagesAsync(
            ListReferenceImagesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists reference images.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the parent product does not exist.
        /// * Returns INVALID_ARGUMENT if the page_size is greater than 100, or less
        ///   than 1.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ReferenceImage"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListReferenceImagesResponse, ReferenceImage> ListReferenceImages(
            ListReferenceImagesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets information associated with a ReferenceImage.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the specified image does not exist.
        /// </summary>
        /// <param name="name">
        /// The resource name of the ReferenceImage to get.
        ///
        /// Format is:
        ///
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID/referenceImages/IMAGE_ID`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ReferenceImage> GetReferenceImageAsync(
            ReferenceImageName name,
            gaxgrpc::CallSettings callSettings = null) => GetReferenceImageAsync(
                new GetReferenceImageRequest
                {
                    ReferenceImageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information associated with a ReferenceImage.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the specified image does not exist.
        /// </summary>
        /// <param name="name">
        /// The resource name of the ReferenceImage to get.
        ///
        /// Format is:
        ///
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID/referenceImages/IMAGE_ID`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ReferenceImage> GetReferenceImageAsync(
            ReferenceImageName name,
            st::CancellationToken cancellationToken) => GetReferenceImageAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information associated with a ReferenceImage.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the specified image does not exist.
        /// </summary>
        /// <param name="name">
        /// The resource name of the ReferenceImage to get.
        ///
        /// Format is:
        ///
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID/referenceImages/IMAGE_ID`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ReferenceImage GetReferenceImage(
            ReferenceImageName name,
            gaxgrpc::CallSettings callSettings = null) => GetReferenceImage(
                new GetReferenceImageRequest
                {
                    ReferenceImageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information associated with a ReferenceImage.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the specified image does not exist.
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
        public virtual stt::Task<ReferenceImage> GetReferenceImageAsync(
            GetReferenceImageRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets information associated with a ReferenceImage.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the specified image does not exist.
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
        public virtual stt::Task<ReferenceImage> GetReferenceImageAsync(
            GetReferenceImageRequest request,
            st::CancellationToken cancellationToken) => GetReferenceImageAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information associated with a ReferenceImage.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the specified image does not exist.
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
        public virtual ReferenceImage GetReferenceImage(
            GetReferenceImageRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Permanently deletes a reference image.
        ///
        /// The image metadata will be deleted right away, but search queries
        /// against ProductSets containing the image may still work until all related
        /// caches are refreshed.
        ///
        /// The actual image files are not deleted from Google Cloud Storage.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the reference image does not exist.
        /// </summary>
        /// <param name="name">
        /// The resource name of the reference image to delete.
        ///
        /// Format is:
        ///
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID/referenceImages/IMAGE_ID`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteReferenceImageAsync(
            ReferenceImageName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteReferenceImageAsync(
                new DeleteReferenceImageRequest
                {
                    ReferenceImageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Permanently deletes a reference image.
        ///
        /// The image metadata will be deleted right away, but search queries
        /// against ProductSets containing the image may still work until all related
        /// caches are refreshed.
        ///
        /// The actual image files are not deleted from Google Cloud Storage.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the reference image does not exist.
        /// </summary>
        /// <param name="name">
        /// The resource name of the reference image to delete.
        ///
        /// Format is:
        ///
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID/referenceImages/IMAGE_ID`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteReferenceImageAsync(
            ReferenceImageName name,
            st::CancellationToken cancellationToken) => DeleteReferenceImageAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes a reference image.
        ///
        /// The image metadata will be deleted right away, but search queries
        /// against ProductSets containing the image may still work until all related
        /// caches are refreshed.
        ///
        /// The actual image files are not deleted from Google Cloud Storage.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the reference image does not exist.
        /// </summary>
        /// <param name="name">
        /// The resource name of the reference image to delete.
        ///
        /// Format is:
        ///
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID/referenceImages/IMAGE_ID`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteReferenceImage(
            ReferenceImageName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteReferenceImage(
                new DeleteReferenceImageRequest
                {
                    ReferenceImageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Permanently deletes a reference image.
        ///
        /// The image metadata will be deleted right away, but search queries
        /// against ProductSets containing the image may still work until all related
        /// caches are refreshed.
        ///
        /// The actual image files are not deleted from Google Cloud Storage.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the reference image does not exist.
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
        public virtual stt::Task DeleteReferenceImageAsync(
            DeleteReferenceImageRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Permanently deletes a reference image.
        ///
        /// The image metadata will be deleted right away, but search queries
        /// against ProductSets containing the image may still work until all related
        /// caches are refreshed.
        ///
        /// The actual image files are not deleted from Google Cloud Storage.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the reference image does not exist.
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
        public virtual stt::Task DeleteReferenceImageAsync(
            DeleteReferenceImageRequest request,
            st::CancellationToken cancellationToken) => DeleteReferenceImageAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes a reference image.
        ///
        /// The image metadata will be deleted right away, but search queries
        /// against ProductSets containing the image may still work until all related
        /// caches are refreshed.
        ///
        /// The actual image files are not deleted from Google Cloud Storage.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the reference image does not exist.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteReferenceImage(
            DeleteReferenceImageRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates and returns a new ReferenceImage resource.
        ///
        /// The `bounding_poly` field is optional. If `bounding_poly` is not specified,
        /// the system will try to detect regions of interest in the image that are
        /// compatible with the product_category on the parent product. If it is
        /// specified, detection is ALWAYS skipped. The system converts polygons into
        /// non-rotated rectangles.
        ///
        /// Note that the pipeline will resize the image if the image resolution is too
        /// large to process (above 50MP).
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if the image_uri is missing or longer than 4096
        ///   characters.
        /// * Returns INVALID_ARGUMENT if the product does not exist.
        /// * Returns INVALID_ARGUMENT if bounding_poly is not provided, and nothing
        ///   compatible with the parent product's product_category is detected.
        /// * Returns INVALID_ARGUMENT if bounding_poly contains more than 10 polygons.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the product in which to create the reference image.
        ///
        /// Format is
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`.
        /// </param>
        /// <param name="referenceImage">
        /// The reference image to create.
        /// If an image ID is specified, it is ignored.
        /// </param>
        /// <param name="referenceImageId">
        /// A user-supplied resource id for the ReferenceImage to be added. If set,
        /// the server will attempt to use this value as the resource id. If it is
        /// already in use, an error is returned with code ALREADY_EXISTS. Must be at
        /// most 128 characters long. It cannot contain the character `/`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ReferenceImage> CreateReferenceImageAsync(
            ProductName parent,
            ReferenceImage referenceImage,
            string referenceImageId,
            gaxgrpc::CallSettings callSettings = null) => CreateReferenceImageAsync(
                new CreateReferenceImageRequest
                {
                    ParentAsProductName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    ReferenceImage = gax::GaxPreconditions.CheckNotNull(referenceImage, nameof(referenceImage)),
                    ReferenceImageId = referenceImageId ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Creates and returns a new ReferenceImage resource.
        ///
        /// The `bounding_poly` field is optional. If `bounding_poly` is not specified,
        /// the system will try to detect regions of interest in the image that are
        /// compatible with the product_category on the parent product. If it is
        /// specified, detection is ALWAYS skipped. The system converts polygons into
        /// non-rotated rectangles.
        ///
        /// Note that the pipeline will resize the image if the image resolution is too
        /// large to process (above 50MP).
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if the image_uri is missing or longer than 4096
        ///   characters.
        /// * Returns INVALID_ARGUMENT if the product does not exist.
        /// * Returns INVALID_ARGUMENT if bounding_poly is not provided, and nothing
        ///   compatible with the parent product's product_category is detected.
        /// * Returns INVALID_ARGUMENT if bounding_poly contains more than 10 polygons.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the product in which to create the reference image.
        ///
        /// Format is
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`.
        /// </param>
        /// <param name="referenceImage">
        /// The reference image to create.
        /// If an image ID is specified, it is ignored.
        /// </param>
        /// <param name="referenceImageId">
        /// A user-supplied resource id for the ReferenceImage to be added. If set,
        /// the server will attempt to use this value as the resource id. If it is
        /// already in use, an error is returned with code ALREADY_EXISTS. Must be at
        /// most 128 characters long. It cannot contain the character `/`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ReferenceImage> CreateReferenceImageAsync(
            ProductName parent,
            ReferenceImage referenceImage,
            string referenceImageId,
            st::CancellationToken cancellationToken) => CreateReferenceImageAsync(
                parent,
                referenceImage,
                referenceImageId,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and returns a new ReferenceImage resource.
        ///
        /// The `bounding_poly` field is optional. If `bounding_poly` is not specified,
        /// the system will try to detect regions of interest in the image that are
        /// compatible with the product_category on the parent product. If it is
        /// specified, detection is ALWAYS skipped. The system converts polygons into
        /// non-rotated rectangles.
        ///
        /// Note that the pipeline will resize the image if the image resolution is too
        /// large to process (above 50MP).
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if the image_uri is missing or longer than 4096
        ///   characters.
        /// * Returns INVALID_ARGUMENT if the product does not exist.
        /// * Returns INVALID_ARGUMENT if bounding_poly is not provided, and nothing
        ///   compatible with the parent product's product_category is detected.
        /// * Returns INVALID_ARGUMENT if bounding_poly contains more than 10 polygons.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the product in which to create the reference image.
        ///
        /// Format is
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`.
        /// </param>
        /// <param name="referenceImage">
        /// The reference image to create.
        /// If an image ID is specified, it is ignored.
        /// </param>
        /// <param name="referenceImageId">
        /// A user-supplied resource id for the ReferenceImage to be added. If set,
        /// the server will attempt to use this value as the resource id. If it is
        /// already in use, an error is returned with code ALREADY_EXISTS. Must be at
        /// most 128 characters long. It cannot contain the character `/`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ReferenceImage CreateReferenceImage(
            ProductName parent,
            ReferenceImage referenceImage,
            string referenceImageId,
            gaxgrpc::CallSettings callSettings = null) => CreateReferenceImage(
                new CreateReferenceImageRequest
                {
                    ParentAsProductName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    ReferenceImage = gax::GaxPreconditions.CheckNotNull(referenceImage, nameof(referenceImage)),
                    ReferenceImageId = referenceImageId ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Creates and returns a new ReferenceImage resource.
        ///
        /// The `bounding_poly` field is optional. If `bounding_poly` is not specified,
        /// the system will try to detect regions of interest in the image that are
        /// compatible with the product_category on the parent product. If it is
        /// specified, detection is ALWAYS skipped. The system converts polygons into
        /// non-rotated rectangles.
        ///
        /// Note that the pipeline will resize the image if the image resolution is too
        /// large to process (above 50MP).
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if the image_uri is missing or longer than 4096
        ///   characters.
        /// * Returns INVALID_ARGUMENT if the product does not exist.
        /// * Returns INVALID_ARGUMENT if bounding_poly is not provided, and nothing
        ///   compatible with the parent product's product_category is detected.
        /// * Returns INVALID_ARGUMENT if bounding_poly contains more than 10 polygons.
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
        public virtual stt::Task<ReferenceImage> CreateReferenceImageAsync(
            CreateReferenceImageRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates and returns a new ReferenceImage resource.
        ///
        /// The `bounding_poly` field is optional. If `bounding_poly` is not specified,
        /// the system will try to detect regions of interest in the image that are
        /// compatible with the product_category on the parent product. If it is
        /// specified, detection is ALWAYS skipped. The system converts polygons into
        /// non-rotated rectangles.
        ///
        /// Note that the pipeline will resize the image if the image resolution is too
        /// large to process (above 50MP).
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if the image_uri is missing or longer than 4096
        ///   characters.
        /// * Returns INVALID_ARGUMENT if the product does not exist.
        /// * Returns INVALID_ARGUMENT if bounding_poly is not provided, and nothing
        ///   compatible with the parent product's product_category is detected.
        /// * Returns INVALID_ARGUMENT if bounding_poly contains more than 10 polygons.
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
        public virtual stt::Task<ReferenceImage> CreateReferenceImageAsync(
            CreateReferenceImageRequest request,
            st::CancellationToken cancellationToken) => CreateReferenceImageAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and returns a new ReferenceImage resource.
        ///
        /// The `bounding_poly` field is optional. If `bounding_poly` is not specified,
        /// the system will try to detect regions of interest in the image that are
        /// compatible with the product_category on the parent product. If it is
        /// specified, detection is ALWAYS skipped. The system converts polygons into
        /// non-rotated rectangles.
        ///
        /// Note that the pipeline will resize the image if the image resolution is too
        /// large to process (above 50MP).
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if the image_uri is missing or longer than 4096
        ///   characters.
        /// * Returns INVALID_ARGUMENT if the product does not exist.
        /// * Returns INVALID_ARGUMENT if bounding_poly is not provided, and nothing
        ///   compatible with the parent product's product_category is detected.
        /// * Returns INVALID_ARGUMENT if bounding_poly contains more than 10 polygons.
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
        public virtual ReferenceImage CreateReferenceImage(
            CreateReferenceImageRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates and returns a new ProductSet resource.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if display_name is missing, or is longer than
        ///   4096 characters.
        /// </summary>
        /// <param name="parent">
        /// The project in which the ProductSet should be created.
        ///
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="productSet">
        /// The ProductSet to create.
        /// </param>
        /// <param name="productSetId">
        /// A user-supplied resource id for this ProductSet. If set, the server will
        /// attempt to use this value as the resource id. If it is already in use, an
        /// error is returned with code ALREADY_EXISTS. Must be at most 128 characters
        /// long. It cannot contain the character `/`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ProductSet> CreateProductSetAsync(
            LocationName parent,
            ProductSet productSet,
            string productSetId,
            gaxgrpc::CallSettings callSettings = null) => CreateProductSetAsync(
                new CreateProductSetRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    ProductSet = gax::GaxPreconditions.CheckNotNull(productSet, nameof(productSet)),
                    ProductSetId = productSetId ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Creates and returns a new ProductSet resource.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if display_name is missing, or is longer than
        ///   4096 characters.
        /// </summary>
        /// <param name="parent">
        /// The project in which the ProductSet should be created.
        ///
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="productSet">
        /// The ProductSet to create.
        /// </param>
        /// <param name="productSetId">
        /// A user-supplied resource id for this ProductSet. If set, the server will
        /// attempt to use this value as the resource id. If it is already in use, an
        /// error is returned with code ALREADY_EXISTS. Must be at most 128 characters
        /// long. It cannot contain the character `/`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ProductSet> CreateProductSetAsync(
            LocationName parent,
            ProductSet productSet,
            string productSetId,
            st::CancellationToken cancellationToken) => CreateProductSetAsync(
                parent,
                productSet,
                productSetId,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and returns a new ProductSet resource.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if display_name is missing, or is longer than
        ///   4096 characters.
        /// </summary>
        /// <param name="parent">
        /// The project in which the ProductSet should be created.
        ///
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="productSet">
        /// The ProductSet to create.
        /// </param>
        /// <param name="productSetId">
        /// A user-supplied resource id for this ProductSet. If set, the server will
        /// attempt to use this value as the resource id. If it is already in use, an
        /// error is returned with code ALREADY_EXISTS. Must be at most 128 characters
        /// long. It cannot contain the character `/`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ProductSet CreateProductSet(
            LocationName parent,
            ProductSet productSet,
            string productSetId,
            gaxgrpc::CallSettings callSettings = null) => CreateProductSet(
                new CreateProductSetRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    ProductSet = gax::GaxPreconditions.CheckNotNull(productSet, nameof(productSet)),
                    ProductSetId = productSetId ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Creates and returns a new ProductSet resource.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if display_name is missing, or is longer than
        ///   4096 characters.
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
        public virtual stt::Task<ProductSet> CreateProductSetAsync(
            CreateProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates and returns a new ProductSet resource.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if display_name is missing, or is longer than
        ///   4096 characters.
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
        public virtual stt::Task<ProductSet> CreateProductSetAsync(
            CreateProductSetRequest request,
            st::CancellationToken cancellationToken) => CreateProductSetAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and returns a new ProductSet resource.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if display_name is missing, or is longer than
        ///   4096 characters.
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
        public virtual ProductSet CreateProductSet(
            CreateProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists ProductSets in an unspecified order.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100, or less
        ///   than 1.
        /// </summary>
        /// <param name="parent">
        /// The project from which ProductSets should be listed.
        ///
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
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
        /// A pageable asynchronous sequence of <see cref="ProductSet"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListProductSetsResponse, ProductSet> ListProductSetsAsync(
            LocationName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListProductSetsAsync(
                new ListProductSetsRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists ProductSets in an unspecified order.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100, or less
        ///   than 1.
        /// </summary>
        /// <param name="parent">
        /// The project from which ProductSets should be listed.
        ///
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
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
        /// A pageable sequence of <see cref="ProductSet"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListProductSetsResponse, ProductSet> ListProductSets(
            LocationName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListProductSets(
                new ListProductSetsRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists ProductSets in an unspecified order.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100, or less
        ///   than 1.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ProductSet"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListProductSetsResponse, ProductSet> ListProductSetsAsync(
            ListProductSetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists ProductSets in an unspecified order.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100, or less
        ///   than 1.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ProductSet"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListProductSetsResponse, ProductSet> ListProductSets(
            ListProductSetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets information associated with a ProductSet.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// </summary>
        /// <param name="name">
        /// Resource name of the ProductSet to get.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOG_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ProductSet> GetProductSetAsync(
            ProductSetName name,
            gaxgrpc::CallSettings callSettings = null) => GetProductSetAsync(
                new GetProductSetRequest
                {
                    ProductSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information associated with a ProductSet.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// </summary>
        /// <param name="name">
        /// Resource name of the ProductSet to get.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOG_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ProductSet> GetProductSetAsync(
            ProductSetName name,
            st::CancellationToken cancellationToken) => GetProductSetAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information associated with a ProductSet.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// </summary>
        /// <param name="name">
        /// Resource name of the ProductSet to get.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOG_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ProductSet GetProductSet(
            ProductSetName name,
            gaxgrpc::CallSettings callSettings = null) => GetProductSet(
                new GetProductSetRequest
                {
                    ProductSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information associated with a ProductSet.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the ProductSet does not exist.
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
        public virtual stt::Task<ProductSet> GetProductSetAsync(
            GetProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets information associated with a ProductSet.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the ProductSet does not exist.
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
        public virtual stt::Task<ProductSet> GetProductSetAsync(
            GetProductSetRequest request,
            st::CancellationToken cancellationToken) => GetProductSetAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information associated with a ProductSet.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the ProductSet does not exist.
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
        public virtual ProductSet GetProductSet(
            GetProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Makes changes to a ProductSet resource.
        /// Only display_name can be updated currently.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// * Returns INVALID_ARGUMENT if display_name is present in update_mask but
        ///   missing from the request or longer than 4096 characters.
        /// </summary>
        /// <param name="productSet">
        /// The ProductSet resource which replaces the one on the server.
        /// </param>
        /// <param name="updateMask">
        /// The [FieldMask][google.protobuf.FieldMask] that specifies which fields to
        /// update.
        /// If update_mask isn't specified, all mutable fields are to be updated.
        /// Valid mask path is `display_name`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ProductSet> UpdateProductSetAsync(
            ProductSet productSet,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateProductSetAsync(
                new UpdateProductSetRequest
                {
                    ProductSet = gax::GaxPreconditions.CheckNotNull(productSet, nameof(productSet)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Makes changes to a ProductSet resource.
        /// Only display_name can be updated currently.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// * Returns INVALID_ARGUMENT if display_name is present in update_mask but
        ///   missing from the request or longer than 4096 characters.
        /// </summary>
        /// <param name="productSet">
        /// The ProductSet resource which replaces the one on the server.
        /// </param>
        /// <param name="updateMask">
        /// The [FieldMask][google.protobuf.FieldMask] that specifies which fields to
        /// update.
        /// If update_mask isn't specified, all mutable fields are to be updated.
        /// Valid mask path is `display_name`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ProductSet> UpdateProductSetAsync(
            ProductSet productSet,
            pbwkt::FieldMask updateMask,
            st::CancellationToken cancellationToken) => UpdateProductSetAsync(
                productSet,
                updateMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Makes changes to a ProductSet resource.
        /// Only display_name can be updated currently.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// * Returns INVALID_ARGUMENT if display_name is present in update_mask but
        ///   missing from the request or longer than 4096 characters.
        /// </summary>
        /// <param name="productSet">
        /// The ProductSet resource which replaces the one on the server.
        /// </param>
        /// <param name="updateMask">
        /// The [FieldMask][google.protobuf.FieldMask] that specifies which fields to
        /// update.
        /// If update_mask isn't specified, all mutable fields are to be updated.
        /// Valid mask path is `display_name`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ProductSet UpdateProductSet(
            ProductSet productSet,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateProductSet(
                new UpdateProductSetRequest
                {
                    ProductSet = gax::GaxPreconditions.CheckNotNull(productSet, nameof(productSet)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Makes changes to a ProductSet resource.
        /// Only display_name can be updated currently.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// * Returns INVALID_ARGUMENT if display_name is present in update_mask but
        ///   missing from the request or longer than 4096 characters.
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
        public virtual stt::Task<ProductSet> UpdateProductSetAsync(
            UpdateProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Makes changes to a ProductSet resource.
        /// Only display_name can be updated currently.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// * Returns INVALID_ARGUMENT if display_name is present in update_mask but
        ///   missing from the request or longer than 4096 characters.
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
        public virtual stt::Task<ProductSet> UpdateProductSetAsync(
            UpdateProductSetRequest request,
            st::CancellationToken cancellationToken) => UpdateProductSetAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Makes changes to a ProductSet resource.
        /// Only display_name can be updated currently.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// * Returns INVALID_ARGUMENT if display_name is present in update_mask but
        ///   missing from the request or longer than 4096 characters.
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
        public virtual ProductSet UpdateProductSet(
            UpdateProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Permanently deletes a ProductSet. All Products and ReferenceImages in the
        /// ProductSet will be deleted.
        ///
        /// The actual image files are not deleted from Google Cloud Storage.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// </summary>
        /// <param name="name">
        /// Resource name of the ProductSet to delete.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteProductSetAsync(
            ProductSetName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteProductSetAsync(
                new DeleteProductSetRequest
                {
                    ProductSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Permanently deletes a ProductSet. All Products and ReferenceImages in the
        /// ProductSet will be deleted.
        ///
        /// The actual image files are not deleted from Google Cloud Storage.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// </summary>
        /// <param name="name">
        /// Resource name of the ProductSet to delete.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteProductSetAsync(
            ProductSetName name,
            st::CancellationToken cancellationToken) => DeleteProductSetAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes a ProductSet. All Products and ReferenceImages in the
        /// ProductSet will be deleted.
        ///
        /// The actual image files are not deleted from Google Cloud Storage.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// </summary>
        /// <param name="name">
        /// Resource name of the ProductSet to delete.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteProductSet(
            ProductSetName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteProductSet(
                new DeleteProductSetRequest
                {
                    ProductSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Permanently deletes a ProductSet. All Products and ReferenceImages in the
        /// ProductSet will be deleted.
        ///
        /// The actual image files are not deleted from Google Cloud Storage.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the ProductSet does not exist.
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
        public virtual stt::Task DeleteProductSetAsync(
            DeleteProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Permanently deletes a ProductSet. All Products and ReferenceImages in the
        /// ProductSet will be deleted.
        ///
        /// The actual image files are not deleted from Google Cloud Storage.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the ProductSet does not exist.
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
        public virtual stt::Task DeleteProductSetAsync(
            DeleteProductSetRequest request,
            st::CancellationToken cancellationToken) => DeleteProductSetAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes a ProductSet. All Products and ReferenceImages in the
        /// ProductSet will be deleted.
        ///
        /// The actual image files are not deleted from Google Cloud Storage.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteProductSet(
            DeleteProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Adds a Product to the specified ProductSet. If the Product is already
        /// present, no change is made.
        ///
        /// One Product can be added to at most 100 ProductSets.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the Product or the ProductSet doesn't exist.
        /// </summary>
        /// <param name="name">
        /// The resource name for the ProductSet to modify.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="product">
        /// The resource name for the Product to be added to this ProductSet.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task AddProductToProductSetAsync(
            ProductSetName name,
            ProductName product,
            gaxgrpc::CallSettings callSettings = null) => AddProductToProductSetAsync(
                new AddProductToProductSetRequest
                {
                    ProductSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    ProductAsProductName = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
                },
                callSettings);

        /// <summary>
        /// Adds a Product to the specified ProductSet. If the Product is already
        /// present, no change is made.
        ///
        /// One Product can be added to at most 100 ProductSets.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the Product or the ProductSet doesn't exist.
        /// </summary>
        /// <param name="name">
        /// The resource name for the ProductSet to modify.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="product">
        /// The resource name for the Product to be added to this ProductSet.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task AddProductToProductSetAsync(
            ProductSetName name,
            ProductName product,
            st::CancellationToken cancellationToken) => AddProductToProductSetAsync(
                name,
                product,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a Product to the specified ProductSet. If the Product is already
        /// present, no change is made.
        ///
        /// One Product can be added to at most 100 ProductSets.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the Product or the ProductSet doesn't exist.
        /// </summary>
        /// <param name="name">
        /// The resource name for the ProductSet to modify.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="product">
        /// The resource name for the Product to be added to this ProductSet.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void AddProductToProductSet(
            ProductSetName name,
            ProductName product,
            gaxgrpc::CallSettings callSettings = null) => AddProductToProductSet(
                new AddProductToProductSetRequest
                {
                    ProductSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    ProductAsProductName = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
                },
                callSettings);

        /// <summary>
        /// Adds a Product to the specified ProductSet. If the Product is already
        /// present, no change is made.
        ///
        /// One Product can be added to at most 100 ProductSets.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the Product or the ProductSet doesn't exist.
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
        public virtual stt::Task AddProductToProductSetAsync(
            AddProductToProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Adds a Product to the specified ProductSet. If the Product is already
        /// present, no change is made.
        ///
        /// One Product can be added to at most 100 ProductSets.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the Product or the ProductSet doesn't exist.
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
        public virtual stt::Task AddProductToProductSetAsync(
            AddProductToProductSetRequest request,
            st::CancellationToken cancellationToken) => AddProductToProductSetAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a Product to the specified ProductSet. If the Product is already
        /// present, no change is made.
        ///
        /// One Product can be added to at most 100 ProductSets.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the Product or the ProductSet doesn't exist.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void AddProductToProductSet(
            AddProductToProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Removes a Product from the specified ProductSet.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND If the Product is not found under the ProductSet.
        /// </summary>
        /// <param name="name">
        /// The resource name for the ProductSet to modify.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="product">
        /// The resource name for the Product to be removed from this ProductSet.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task RemoveProductFromProductSetAsync(
            ProductSetName name,
            ProductName product,
            gaxgrpc::CallSettings callSettings = null) => RemoveProductFromProductSetAsync(
                new RemoveProductFromProductSetRequest
                {
                    ProductSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    ProductAsProductName = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
                },
                callSettings);

        /// <summary>
        /// Removes a Product from the specified ProductSet.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND If the Product is not found under the ProductSet.
        /// </summary>
        /// <param name="name">
        /// The resource name for the ProductSet to modify.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="product">
        /// The resource name for the Product to be removed from this ProductSet.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task RemoveProductFromProductSetAsync(
            ProductSetName name,
            ProductName product,
            st::CancellationToken cancellationToken) => RemoveProductFromProductSetAsync(
                name,
                product,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a Product from the specified ProductSet.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND If the Product is not found under the ProductSet.
        /// </summary>
        /// <param name="name">
        /// The resource name for the ProductSet to modify.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="product">
        /// The resource name for the Product to be removed from this ProductSet.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void RemoveProductFromProductSet(
            ProductSetName name,
            ProductName product,
            gaxgrpc::CallSettings callSettings = null) => RemoveProductFromProductSet(
                new RemoveProductFromProductSetRequest
                {
                    ProductSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    ProductAsProductName = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
                },
                callSettings);

        /// <summary>
        /// Removes a Product from the specified ProductSet.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND If the Product is not found under the ProductSet.
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
        public virtual stt::Task RemoveProductFromProductSetAsync(
            RemoveProductFromProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Removes a Product from the specified ProductSet.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND If the Product is not found under the ProductSet.
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
        public virtual stt::Task RemoveProductFromProductSetAsync(
            RemoveProductFromProductSetRequest request,
            st::CancellationToken cancellationToken) => RemoveProductFromProductSetAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a Product from the specified ProductSet.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND If the Product is not found under the ProductSet.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void RemoveProductFromProductSet(
            RemoveProductFromProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists the Products in a ProductSet, in an unspecified order. If the
        /// ProductSet does not exist, the products field of the response will be
        /// empty.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100 or less than 1.
        /// </summary>
        /// <param name="name">
        /// The ProductSet resource for which to retrieve Products.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
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
        /// A pageable asynchronous sequence of <see cref="Product"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListProductsInProductSetResponse, Product> ListProductsInProductSetAsync(
            ProductSetName name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListProductsInProductSetAsync(
                new ListProductsInProductSetRequest
                {
                    ProductSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the Products in a ProductSet, in an unspecified order. If the
        /// ProductSet does not exist, the products field of the response will be
        /// empty.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100 or less than 1.
        /// </summary>
        /// <param name="name">
        /// The ProductSet resource for which to retrieve Products.
        ///
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
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
        /// A pageable sequence of <see cref="Product"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListProductsInProductSetResponse, Product> ListProductsInProductSet(
            ProductSetName name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListProductsInProductSet(
                new ListProductsInProductSetRequest
                {
                    ProductSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the Products in a ProductSet, in an unspecified order. If the
        /// ProductSet does not exist, the products field of the response will be
        /// empty.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100 or less than 1.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Product"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListProductsInProductSetResponse, Product> ListProductsInProductSetAsync(
            ListProductsInProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists the Products in a ProductSet, in an unspecified order. If the
        /// ProductSet does not exist, the products field of the response will be
        /// empty.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100 or less than 1.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Product"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListProductsInProductSetResponse, Product> ListProductsInProductSet(
            ListProductsInProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronous API that imports a list of reference images to specified
        /// product sets based on a list of image information.
        ///
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be used to keep track of the
        /// progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// `Operation.response` contains `ImportProductSetsResponse`. (results)
        ///
        /// The input source of this method is a csv file on Google Cloud Storage.
        /// For the format of the csv file please see
        /// [ImportProductSetsGcsSource.csv_file_uri][google.cloud.vision.v1.ImportProductSetsGcsSource.csv_file_uri].
        /// </summary>
        /// <param name="parent">
        /// The project in which the ProductSets should be imported.
        ///
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="inputConfig">
        /// The input content for the list of requests.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<ImportProductSetsResponse, BatchOperationMetadata>> ImportProductSetsAsync(
            LocationName parent,
            ImportProductSetsInputConfig inputConfig,
            gaxgrpc::CallSettings callSettings = null) => ImportProductSetsAsync(
                new ImportProductSetsRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
                },
                callSettings);

        /// <summary>
        /// Asynchronous API that imports a list of reference images to specified
        /// product sets based on a list of image information.
        ///
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be used to keep track of the
        /// progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// `Operation.response` contains `ImportProductSetsResponse`. (results)
        ///
        /// The input source of this method is a csv file on Google Cloud Storage.
        /// For the format of the csv file please see
        /// [ImportProductSetsGcsSource.csv_file_uri][google.cloud.vision.v1.ImportProductSetsGcsSource.csv_file_uri].
        /// </summary>
        /// <param name="parent">
        /// The project in which the ProductSets should be imported.
        ///
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="inputConfig">
        /// The input content for the list of requests.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<ImportProductSetsResponse, BatchOperationMetadata>> ImportProductSetsAsync(
            LocationName parent,
            ImportProductSetsInputConfig inputConfig,
            st::CancellationToken cancellationToken) => ImportProductSetsAsync(
                parent,
                inputConfig,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Asynchronous API that imports a list of reference images to specified
        /// product sets based on a list of image information.
        ///
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be used to keep track of the
        /// progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// `Operation.response` contains `ImportProductSetsResponse`. (results)
        ///
        /// The input source of this method is a csv file on Google Cloud Storage.
        /// For the format of the csv file please see
        /// [ImportProductSetsGcsSource.csv_file_uri][google.cloud.vision.v1.ImportProductSetsGcsSource.csv_file_uri].
        /// </summary>
        /// <param name="parent">
        /// The project in which the ProductSets should be imported.
        ///
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="inputConfig">
        /// The input content for the list of requests.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<ImportProductSetsResponse, BatchOperationMetadata> ImportProductSets(
            LocationName parent,
            ImportProductSetsInputConfig inputConfig,
            gaxgrpc::CallSettings callSettings = null) => ImportProductSets(
                new ImportProductSetsRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
                },
                callSettings);

        /// <summary>
        /// Asynchronous API that imports a list of reference images to specified
        /// product sets based on a list of image information.
        ///
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be used to keep track of the
        /// progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// `Operation.response` contains `ImportProductSetsResponse`. (results)
        ///
        /// The input source of this method is a csv file on Google Cloud Storage.
        /// For the format of the csv file please see
        /// [ImportProductSetsGcsSource.csv_file_uri][google.cloud.vision.v1.ImportProductSetsGcsSource.csv_file_uri].
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
        public virtual stt::Task<lro::Operation<ImportProductSetsResponse, BatchOperationMetadata>> ImportProductSetsAsync(
            ImportProductSetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportProductSetsAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportProductSetsResponse, BatchOperationMetadata>> PollOnceImportProductSetsAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<ImportProductSetsResponse, BatchOperationMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                ImportProductSetsOperationsClient,
                callSettings);

        /// <summary>
        /// Asynchronous API that imports a list of reference images to specified
        /// product sets based on a list of image information.
        ///
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be used to keep track of the
        /// progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// `Operation.response` contains `ImportProductSetsResponse`. (results)
        ///
        /// The input source of this method is a csv file on Google Cloud Storage.
        /// For the format of the csv file please see
        /// [ImportProductSetsGcsSource.csv_file_uri][google.cloud.vision.v1.ImportProductSetsGcsSource.csv_file_uri].
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
        public virtual lro::Operation<ImportProductSetsResponse, BatchOperationMetadata> ImportProductSets(
            ImportProductSetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>ImportProductSets</c>.
        /// </summary>
        public virtual lro::OperationsClient ImportProductSetsOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportProductSets</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportProductSetsResponse, BatchOperationMetadata> PollOnceImportProductSets(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<ImportProductSetsResponse, BatchOperationMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                ImportProductSetsOperationsClient,
                callSettings);

    }

    /// <summary>
    /// ProductSearch client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class ProductSearchClientImpl : ProductSearchClient
    {
        private readonly gaxgrpc::ApiCall<CreateProductRequest, Product> _callCreateProduct;
        private readonly gaxgrpc::ApiCall<ListProductsRequest, ListProductsResponse> _callListProducts;
        private readonly gaxgrpc::ApiCall<GetProductRequest, Product> _callGetProduct;
        private readonly gaxgrpc::ApiCall<UpdateProductRequest, Product> _callUpdateProduct;
        private readonly gaxgrpc::ApiCall<DeleteProductRequest, pbwkt::Empty> _callDeleteProduct;
        private readonly gaxgrpc::ApiCall<ListReferenceImagesRequest, ListReferenceImagesResponse> _callListReferenceImages;
        private readonly gaxgrpc::ApiCall<GetReferenceImageRequest, ReferenceImage> _callGetReferenceImage;
        private readonly gaxgrpc::ApiCall<DeleteReferenceImageRequest, pbwkt::Empty> _callDeleteReferenceImage;
        private readonly gaxgrpc::ApiCall<CreateReferenceImageRequest, ReferenceImage> _callCreateReferenceImage;
        private readonly gaxgrpc::ApiCall<CreateProductSetRequest, ProductSet> _callCreateProductSet;
        private readonly gaxgrpc::ApiCall<ListProductSetsRequest, ListProductSetsResponse> _callListProductSets;
        private readonly gaxgrpc::ApiCall<GetProductSetRequest, ProductSet> _callGetProductSet;
        private readonly gaxgrpc::ApiCall<UpdateProductSetRequest, ProductSet> _callUpdateProductSet;
        private readonly gaxgrpc::ApiCall<DeleteProductSetRequest, pbwkt::Empty> _callDeleteProductSet;
        private readonly gaxgrpc::ApiCall<AddProductToProductSetRequest, pbwkt::Empty> _callAddProductToProductSet;
        private readonly gaxgrpc::ApiCall<RemoveProductFromProductSetRequest, pbwkt::Empty> _callRemoveProductFromProductSet;
        private readonly gaxgrpc::ApiCall<ListProductsInProductSetRequest, ListProductsInProductSetResponse> _callListProductsInProductSet;
        private readonly gaxgrpc::ApiCall<ImportProductSetsRequest, lro::Operation> _callImportProductSets;

        /// <summary>
        /// Constructs a client wrapper for the ProductSearch service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ProductSearchSettings"/> used within this client </param>
        public ProductSearchClientImpl(ProductSearch.ProductSearchClient grpcClient, ProductSearchSettings settings)
        {
            GrpcClient = grpcClient;
            ProductSearchSettings effectiveSettings = settings ?? ProductSearchSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            ImportProductSetsOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.ImportProductSetsOperationsSettings);
            _callCreateProduct = clientHelper.BuildApiCall<CreateProductRequest, Product>(
                GrpcClient.CreateProductAsync, GrpcClient.CreateProduct, effectiveSettings.CreateProductSettings);
            _callListProducts = clientHelper.BuildApiCall<ListProductsRequest, ListProductsResponse>(
                GrpcClient.ListProductsAsync, GrpcClient.ListProducts, effectiveSettings.ListProductsSettings);
            _callGetProduct = clientHelper.BuildApiCall<GetProductRequest, Product>(
                GrpcClient.GetProductAsync, GrpcClient.GetProduct, effectiveSettings.GetProductSettings);
            _callUpdateProduct = clientHelper.BuildApiCall<UpdateProductRequest, Product>(
                GrpcClient.UpdateProductAsync, GrpcClient.UpdateProduct, effectiveSettings.UpdateProductSettings);
            _callDeleteProduct = clientHelper.BuildApiCall<DeleteProductRequest, pbwkt::Empty>(
                GrpcClient.DeleteProductAsync, GrpcClient.DeleteProduct, effectiveSettings.DeleteProductSettings);
            _callListReferenceImages = clientHelper.BuildApiCall<ListReferenceImagesRequest, ListReferenceImagesResponse>(
                GrpcClient.ListReferenceImagesAsync, GrpcClient.ListReferenceImages, effectiveSettings.ListReferenceImagesSettings);
            _callGetReferenceImage = clientHelper.BuildApiCall<GetReferenceImageRequest, ReferenceImage>(
                GrpcClient.GetReferenceImageAsync, GrpcClient.GetReferenceImage, effectiveSettings.GetReferenceImageSettings);
            _callDeleteReferenceImage = clientHelper.BuildApiCall<DeleteReferenceImageRequest, pbwkt::Empty>(
                GrpcClient.DeleteReferenceImageAsync, GrpcClient.DeleteReferenceImage, effectiveSettings.DeleteReferenceImageSettings);
            _callCreateReferenceImage = clientHelper.BuildApiCall<CreateReferenceImageRequest, ReferenceImage>(
                GrpcClient.CreateReferenceImageAsync, GrpcClient.CreateReferenceImage, effectiveSettings.CreateReferenceImageSettings);
            _callCreateProductSet = clientHelper.BuildApiCall<CreateProductSetRequest, ProductSet>(
                GrpcClient.CreateProductSetAsync, GrpcClient.CreateProductSet, effectiveSettings.CreateProductSetSettings);
            _callListProductSets = clientHelper.BuildApiCall<ListProductSetsRequest, ListProductSetsResponse>(
                GrpcClient.ListProductSetsAsync, GrpcClient.ListProductSets, effectiveSettings.ListProductSetsSettings);
            _callGetProductSet = clientHelper.BuildApiCall<GetProductSetRequest, ProductSet>(
                GrpcClient.GetProductSetAsync, GrpcClient.GetProductSet, effectiveSettings.GetProductSetSettings);
            _callUpdateProductSet = clientHelper.BuildApiCall<UpdateProductSetRequest, ProductSet>(
                GrpcClient.UpdateProductSetAsync, GrpcClient.UpdateProductSet, effectiveSettings.UpdateProductSetSettings);
            _callDeleteProductSet = clientHelper.BuildApiCall<DeleteProductSetRequest, pbwkt::Empty>(
                GrpcClient.DeleteProductSetAsync, GrpcClient.DeleteProductSet, effectiveSettings.DeleteProductSetSettings);
            _callAddProductToProductSet = clientHelper.BuildApiCall<AddProductToProductSetRequest, pbwkt::Empty>(
                GrpcClient.AddProductToProductSetAsync, GrpcClient.AddProductToProductSet, effectiveSettings.AddProductToProductSetSettings);
            _callRemoveProductFromProductSet = clientHelper.BuildApiCall<RemoveProductFromProductSetRequest, pbwkt::Empty>(
                GrpcClient.RemoveProductFromProductSetAsync, GrpcClient.RemoveProductFromProductSet, effectiveSettings.RemoveProductFromProductSetSettings);
            _callListProductsInProductSet = clientHelper.BuildApiCall<ListProductsInProductSetRequest, ListProductsInProductSetResponse>(
                GrpcClient.ListProductsInProductSetAsync, GrpcClient.ListProductsInProductSet, effectiveSettings.ListProductsInProductSetSettings);
            _callImportProductSets = clientHelper.BuildApiCall<ImportProductSetsRequest, lro::Operation>(
                GrpcClient.ImportProductSetsAsync, GrpcClient.ImportProductSets, effectiveSettings.ImportProductSetsSettings);
            Modify_ApiCall(ref _callCreateProduct);
            Modify_CreateProductApiCall(ref _callCreateProduct);
            Modify_ApiCall(ref _callListProducts);
            Modify_ListProductsApiCall(ref _callListProducts);
            Modify_ApiCall(ref _callGetProduct);
            Modify_GetProductApiCall(ref _callGetProduct);
            Modify_ApiCall(ref _callUpdateProduct);
            Modify_UpdateProductApiCall(ref _callUpdateProduct);
            Modify_ApiCall(ref _callDeleteProduct);
            Modify_DeleteProductApiCall(ref _callDeleteProduct);
            Modify_ApiCall(ref _callListReferenceImages);
            Modify_ListReferenceImagesApiCall(ref _callListReferenceImages);
            Modify_ApiCall(ref _callGetReferenceImage);
            Modify_GetReferenceImageApiCall(ref _callGetReferenceImage);
            Modify_ApiCall(ref _callDeleteReferenceImage);
            Modify_DeleteReferenceImageApiCall(ref _callDeleteReferenceImage);
            Modify_ApiCall(ref _callCreateReferenceImage);
            Modify_CreateReferenceImageApiCall(ref _callCreateReferenceImage);
            Modify_ApiCall(ref _callCreateProductSet);
            Modify_CreateProductSetApiCall(ref _callCreateProductSet);
            Modify_ApiCall(ref _callListProductSets);
            Modify_ListProductSetsApiCall(ref _callListProductSets);
            Modify_ApiCall(ref _callGetProductSet);
            Modify_GetProductSetApiCall(ref _callGetProductSet);
            Modify_ApiCall(ref _callUpdateProductSet);
            Modify_UpdateProductSetApiCall(ref _callUpdateProductSet);
            Modify_ApiCall(ref _callDeleteProductSet);
            Modify_DeleteProductSetApiCall(ref _callDeleteProductSet);
            Modify_ApiCall(ref _callAddProductToProductSet);
            Modify_AddProductToProductSetApiCall(ref _callAddProductToProductSet);
            Modify_ApiCall(ref _callRemoveProductFromProductSet);
            Modify_RemoveProductFromProductSetApiCall(ref _callRemoveProductFromProductSet);
            Modify_ApiCall(ref _callListProductsInProductSet);
            Modify_ListProductsInProductSetApiCall(ref _callListProductsInProductSet);
            Modify_ApiCall(ref _callImportProductSets);
            Modify_ImportProductSetsApiCall(ref _callImportProductSets);
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
        partial void Modify_CreateProductApiCall(ref gaxgrpc::ApiCall<CreateProductRequest, Product> call);
        partial void Modify_ListProductsApiCall(ref gaxgrpc::ApiCall<ListProductsRequest, ListProductsResponse> call);
        partial void Modify_GetProductApiCall(ref gaxgrpc::ApiCall<GetProductRequest, Product> call);
        partial void Modify_UpdateProductApiCall(ref gaxgrpc::ApiCall<UpdateProductRequest, Product> call);
        partial void Modify_DeleteProductApiCall(ref gaxgrpc::ApiCall<DeleteProductRequest, pbwkt::Empty> call);
        partial void Modify_ListReferenceImagesApiCall(ref gaxgrpc::ApiCall<ListReferenceImagesRequest, ListReferenceImagesResponse> call);
        partial void Modify_GetReferenceImageApiCall(ref gaxgrpc::ApiCall<GetReferenceImageRequest, ReferenceImage> call);
        partial void Modify_DeleteReferenceImageApiCall(ref gaxgrpc::ApiCall<DeleteReferenceImageRequest, pbwkt::Empty> call);
        partial void Modify_CreateReferenceImageApiCall(ref gaxgrpc::ApiCall<CreateReferenceImageRequest, ReferenceImage> call);
        partial void Modify_CreateProductSetApiCall(ref gaxgrpc::ApiCall<CreateProductSetRequest, ProductSet> call);
        partial void Modify_ListProductSetsApiCall(ref gaxgrpc::ApiCall<ListProductSetsRequest, ListProductSetsResponse> call);
        partial void Modify_GetProductSetApiCall(ref gaxgrpc::ApiCall<GetProductSetRequest, ProductSet> call);
        partial void Modify_UpdateProductSetApiCall(ref gaxgrpc::ApiCall<UpdateProductSetRequest, ProductSet> call);
        partial void Modify_DeleteProductSetApiCall(ref gaxgrpc::ApiCall<DeleteProductSetRequest, pbwkt::Empty> call);
        partial void Modify_AddProductToProductSetApiCall(ref gaxgrpc::ApiCall<AddProductToProductSetRequest, pbwkt::Empty> call);
        partial void Modify_RemoveProductFromProductSetApiCall(ref gaxgrpc::ApiCall<RemoveProductFromProductSetRequest, pbwkt::Empty> call);
        partial void Modify_ListProductsInProductSetApiCall(ref gaxgrpc::ApiCall<ListProductsInProductSetRequest, ListProductsInProductSetResponse> call);
        partial void Modify_ImportProductSetsApiCall(ref gaxgrpc::ApiCall<ImportProductSetsRequest, lro::Operation> call);
        partial void OnConstruction(ProductSearch.ProductSearchClient grpcClient, ProductSearchSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC ProductSearch client.
        /// </summary>
        public override ProductSearch.ProductSearchClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_CreateProductRequest(ref CreateProductRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListProductsRequest(ref ListProductsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetProductRequest(ref GetProductRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateProductRequest(ref UpdateProductRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteProductRequest(ref DeleteProductRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListReferenceImagesRequest(ref ListReferenceImagesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetReferenceImageRequest(ref GetReferenceImageRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteReferenceImageRequest(ref DeleteReferenceImageRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateReferenceImageRequest(ref CreateReferenceImageRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateProductSetRequest(ref CreateProductSetRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListProductSetsRequest(ref ListProductSetsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetProductSetRequest(ref GetProductSetRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateProductSetRequest(ref UpdateProductSetRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteProductSetRequest(ref DeleteProductSetRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_AddProductToProductSetRequest(ref AddProductToProductSetRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_RemoveProductFromProductSetRequest(ref RemoveProductFromProductSetRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListProductsInProductSetRequest(ref ListProductsInProductSetRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ImportProductSetsRequest(ref ImportProductSetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates and returns a new product resource.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if display_name is missing or longer than 4096
        ///   characters.
        /// * Returns INVALID_ARGUMENT if description is longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is missing or invalid.
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
        public override stt::Task<Product> CreateProductAsync(
            CreateProductRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProductRequest(ref request, ref callSettings);
            return _callCreateProduct.Async(request, callSettings);
        }

        /// <summary>
        /// Creates and returns a new product resource.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if display_name is missing or longer than 4096
        ///   characters.
        /// * Returns INVALID_ARGUMENT if description is longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is missing or invalid.
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
        public override Product CreateProduct(
            CreateProductRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProductRequest(ref request, ref callSettings);
            return _callCreateProduct.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists products in an unspecified order.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100 or less than 1.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Product"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListProductsResponse, Product> ListProductsAsync(
            ListProductsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProductsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProductsRequest, ListProductsResponse, Product>(_callListProducts, request, callSettings);
        }

        /// <summary>
        /// Lists products in an unspecified order.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100 or less than 1.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Product"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListProductsResponse, Product> ListProducts(
            ListProductsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProductsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProductsRequest, ListProductsResponse, Product>(_callListProducts, request, callSettings);
        }

        /// <summary>
        /// Gets information associated with a Product.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the Product does not exist.
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
        public override stt::Task<Product> GetProductAsync(
            GetProductRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProductRequest(ref request, ref callSettings);
            return _callGetProduct.Async(request, callSettings);
        }

        /// <summary>
        /// Gets information associated with a Product.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the Product does not exist.
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
        public override Product GetProduct(
            GetProductRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProductRequest(ref request, ref callSettings);
            return _callGetProduct.Sync(request, callSettings);
        }

        /// <summary>
        /// Makes changes to a Product resource.
        /// Only the `display_name`, `description`, and `labels` fields can be updated
        /// right now.
        ///
        /// If labels are updated, the change will not be reflected in queries until
        /// the next index time.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the Product does not exist.
        /// * Returns INVALID_ARGUMENT if display_name is present in update_mask but is
        ///   missing from the request or longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if description is present in update_mask but is
        ///   longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is present in update_mask.
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
        public override stt::Task<Product> UpdateProductAsync(
            UpdateProductRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProductRequest(ref request, ref callSettings);
            return _callUpdateProduct.Async(request, callSettings);
        }

        /// <summary>
        /// Makes changes to a Product resource.
        /// Only the `display_name`, `description`, and `labels` fields can be updated
        /// right now.
        ///
        /// If labels are updated, the change will not be reflected in queries until
        /// the next index time.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the Product does not exist.
        /// * Returns INVALID_ARGUMENT if display_name is present in update_mask but is
        ///   missing from the request or longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if description is present in update_mask but is
        ///   longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is present in update_mask.
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
        public override Product UpdateProduct(
            UpdateProductRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProductRequest(ref request, ref callSettings);
            return _callUpdateProduct.Sync(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes a product and its reference images.
        ///
        /// Metadata of the product and all its images will be deleted right away, but
        /// search queries against ProductSets containing the product may still work
        /// until all related caches are refreshed.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the product does not exist.
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
        public override stt::Task DeleteProductAsync(
            DeleteProductRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProductRequest(ref request, ref callSettings);
            return _callDeleteProduct.Async(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes a product and its reference images.
        ///
        /// Metadata of the product and all its images will be deleted right away, but
        /// search queries against ProductSets containing the product may still work
        /// until all related caches are refreshed.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the product does not exist.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteProduct(
            DeleteProductRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProductRequest(ref request, ref callSettings);
            _callDeleteProduct.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists reference images.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the parent product does not exist.
        /// * Returns INVALID_ARGUMENT if the page_size is greater than 100, or less
        ///   than 1.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ReferenceImage"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListReferenceImagesResponse, ReferenceImage> ListReferenceImagesAsync(
            ListReferenceImagesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReferenceImagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReferenceImagesRequest, ListReferenceImagesResponse, ReferenceImage>(_callListReferenceImages, request, callSettings);
        }

        /// <summary>
        /// Lists reference images.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the parent product does not exist.
        /// * Returns INVALID_ARGUMENT if the page_size is greater than 100, or less
        ///   than 1.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ReferenceImage"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListReferenceImagesResponse, ReferenceImage> ListReferenceImages(
            ListReferenceImagesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReferenceImagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReferenceImagesRequest, ListReferenceImagesResponse, ReferenceImage>(_callListReferenceImages, request, callSettings);
        }

        /// <summary>
        /// Gets information associated with a ReferenceImage.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the specified image does not exist.
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
        public override stt::Task<ReferenceImage> GetReferenceImageAsync(
            GetReferenceImageRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReferenceImageRequest(ref request, ref callSettings);
            return _callGetReferenceImage.Async(request, callSettings);
        }

        /// <summary>
        /// Gets information associated with a ReferenceImage.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the specified image does not exist.
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
        public override ReferenceImage GetReferenceImage(
            GetReferenceImageRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReferenceImageRequest(ref request, ref callSettings);
            return _callGetReferenceImage.Sync(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes a reference image.
        ///
        /// The image metadata will be deleted right away, but search queries
        /// against ProductSets containing the image may still work until all related
        /// caches are refreshed.
        ///
        /// The actual image files are not deleted from Google Cloud Storage.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the reference image does not exist.
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
        public override stt::Task DeleteReferenceImageAsync(
            DeleteReferenceImageRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReferenceImageRequest(ref request, ref callSettings);
            return _callDeleteReferenceImage.Async(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes a reference image.
        ///
        /// The image metadata will be deleted right away, but search queries
        /// against ProductSets containing the image may still work until all related
        /// caches are refreshed.
        ///
        /// The actual image files are not deleted from Google Cloud Storage.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the reference image does not exist.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteReferenceImage(
            DeleteReferenceImageRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReferenceImageRequest(ref request, ref callSettings);
            _callDeleteReferenceImage.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates and returns a new ReferenceImage resource.
        ///
        /// The `bounding_poly` field is optional. If `bounding_poly` is not specified,
        /// the system will try to detect regions of interest in the image that are
        /// compatible with the product_category on the parent product. If it is
        /// specified, detection is ALWAYS skipped. The system converts polygons into
        /// non-rotated rectangles.
        ///
        /// Note that the pipeline will resize the image if the image resolution is too
        /// large to process (above 50MP).
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if the image_uri is missing or longer than 4096
        ///   characters.
        /// * Returns INVALID_ARGUMENT if the product does not exist.
        /// * Returns INVALID_ARGUMENT if bounding_poly is not provided, and nothing
        ///   compatible with the parent product's product_category is detected.
        /// * Returns INVALID_ARGUMENT if bounding_poly contains more than 10 polygons.
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
        public override stt::Task<ReferenceImage> CreateReferenceImageAsync(
            CreateReferenceImageRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReferenceImageRequest(ref request, ref callSettings);
            return _callCreateReferenceImage.Async(request, callSettings);
        }

        /// <summary>
        /// Creates and returns a new ReferenceImage resource.
        ///
        /// The `bounding_poly` field is optional. If `bounding_poly` is not specified,
        /// the system will try to detect regions of interest in the image that are
        /// compatible with the product_category on the parent product. If it is
        /// specified, detection is ALWAYS skipped. The system converts polygons into
        /// non-rotated rectangles.
        ///
        /// Note that the pipeline will resize the image if the image resolution is too
        /// large to process (above 50MP).
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if the image_uri is missing or longer than 4096
        ///   characters.
        /// * Returns INVALID_ARGUMENT if the product does not exist.
        /// * Returns INVALID_ARGUMENT if bounding_poly is not provided, and nothing
        ///   compatible with the parent product's product_category is detected.
        /// * Returns INVALID_ARGUMENT if bounding_poly contains more than 10 polygons.
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
        public override ReferenceImage CreateReferenceImage(
            CreateReferenceImageRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReferenceImageRequest(ref request, ref callSettings);
            return _callCreateReferenceImage.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates and returns a new ProductSet resource.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if display_name is missing, or is longer than
        ///   4096 characters.
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
        public override stt::Task<ProductSet> CreateProductSetAsync(
            CreateProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProductSetRequest(ref request, ref callSettings);
            return _callCreateProductSet.Async(request, callSettings);
        }

        /// <summary>
        /// Creates and returns a new ProductSet resource.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if display_name is missing, or is longer than
        ///   4096 characters.
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
        public override ProductSet CreateProductSet(
            CreateProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProductSetRequest(ref request, ref callSettings);
            return _callCreateProductSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists ProductSets in an unspecified order.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100, or less
        ///   than 1.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ProductSet"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListProductSetsResponse, ProductSet> ListProductSetsAsync(
            ListProductSetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProductSetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProductSetsRequest, ListProductSetsResponse, ProductSet>(_callListProductSets, request, callSettings);
        }

        /// <summary>
        /// Lists ProductSets in an unspecified order.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100, or less
        ///   than 1.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ProductSet"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListProductSetsResponse, ProductSet> ListProductSets(
            ListProductSetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProductSetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProductSetsRequest, ListProductSetsResponse, ProductSet>(_callListProductSets, request, callSettings);
        }

        /// <summary>
        /// Gets information associated with a ProductSet.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the ProductSet does not exist.
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
        public override stt::Task<ProductSet> GetProductSetAsync(
            GetProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProductSetRequest(ref request, ref callSettings);
            return _callGetProductSet.Async(request, callSettings);
        }

        /// <summary>
        /// Gets information associated with a ProductSet.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the ProductSet does not exist.
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
        public override ProductSet GetProductSet(
            GetProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProductSetRequest(ref request, ref callSettings);
            return _callGetProductSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Makes changes to a ProductSet resource.
        /// Only display_name can be updated currently.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// * Returns INVALID_ARGUMENT if display_name is present in update_mask but
        ///   missing from the request or longer than 4096 characters.
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
        public override stt::Task<ProductSet> UpdateProductSetAsync(
            UpdateProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProductSetRequest(ref request, ref callSettings);
            return _callUpdateProductSet.Async(request, callSettings);
        }

        /// <summary>
        /// Makes changes to a ProductSet resource.
        /// Only display_name can be updated currently.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// * Returns INVALID_ARGUMENT if display_name is present in update_mask but
        ///   missing from the request or longer than 4096 characters.
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
        public override ProductSet UpdateProductSet(
            UpdateProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProductSetRequest(ref request, ref callSettings);
            return _callUpdateProductSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes a ProductSet. All Products and ReferenceImages in the
        /// ProductSet will be deleted.
        ///
        /// The actual image files are not deleted from Google Cloud Storage.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the ProductSet does not exist.
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
        public override stt::Task DeleteProductSetAsync(
            DeleteProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProductSetRequest(ref request, ref callSettings);
            return _callDeleteProductSet.Async(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes a ProductSet. All Products and ReferenceImages in the
        /// ProductSet will be deleted.
        ///
        /// The actual image files are not deleted from Google Cloud Storage.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteProductSet(
            DeleteProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProductSetRequest(ref request, ref callSettings);
            _callDeleteProductSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds a Product to the specified ProductSet. If the Product is already
        /// present, no change is made.
        ///
        /// One Product can be added to at most 100 ProductSets.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the Product or the ProductSet doesn't exist.
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
        public override stt::Task AddProductToProductSetAsync(
            AddProductToProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddProductToProductSetRequest(ref request, ref callSettings);
            return _callAddProductToProductSet.Async(request, callSettings);
        }

        /// <summary>
        /// Adds a Product to the specified ProductSet. If the Product is already
        /// present, no change is made.
        ///
        /// One Product can be added to at most 100 ProductSets.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND if the Product or the ProductSet doesn't exist.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void AddProductToProductSet(
            AddProductToProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddProductToProductSetRequest(ref request, ref callSettings);
            _callAddProductToProductSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Removes a Product from the specified ProductSet.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND If the Product is not found under the ProductSet.
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
        public override stt::Task RemoveProductFromProductSetAsync(
            RemoveProductFromProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveProductFromProductSetRequest(ref request, ref callSettings);
            return _callRemoveProductFromProductSet.Async(request, callSettings);
        }

        /// <summary>
        /// Removes a Product from the specified ProductSet.
        ///
        /// Possible errors:
        ///
        /// * Returns NOT_FOUND If the Product is not found under the ProductSet.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void RemoveProductFromProductSet(
            RemoveProductFromProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveProductFromProductSetRequest(ref request, ref callSettings);
            _callRemoveProductFromProductSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists the Products in a ProductSet, in an unspecified order. If the
        /// ProductSet does not exist, the products field of the response will be
        /// empty.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100 or less than 1.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Product"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListProductsInProductSetResponse, Product> ListProductsInProductSetAsync(
            ListProductsInProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProductsInProductSetRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProductsInProductSetRequest, ListProductsInProductSetResponse, Product>(_callListProductsInProductSet, request, callSettings);
        }

        /// <summary>
        /// Lists the Products in a ProductSet, in an unspecified order. If the
        /// ProductSet does not exist, the products field of the response will be
        /// empty.
        ///
        /// Possible errors:
        ///
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100 or less than 1.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Product"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListProductsInProductSetResponse, Product> ListProductsInProductSet(
            ListProductsInProductSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProductsInProductSetRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProductsInProductSetRequest, ListProductsInProductSetResponse, Product>(_callListProductsInProductSet, request, callSettings);
        }

        /// <summary>
        /// Asynchronous API that imports a list of reference images to specified
        /// product sets based on a list of image information.
        ///
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be used to keep track of the
        /// progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// `Operation.response` contains `ImportProductSetsResponse`. (results)
        ///
        /// The input source of this method is a csv file on Google Cloud Storage.
        /// For the format of the csv file please see
        /// [ImportProductSetsGcsSource.csv_file_uri][google.cloud.vision.v1.ImportProductSetsGcsSource.csv_file_uri].
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
        public override async stt::Task<lro::Operation<ImportProductSetsResponse, BatchOperationMetadata>> ImportProductSetsAsync(
            ImportProductSetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportProductSetsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportProductSetsResponse, BatchOperationMetadata>(
                await _callImportProductSets.Async(request, callSettings).ConfigureAwait(false), ImportProductSetsOperationsClient);
        }

        /// <summary>
        /// Asynchronous API that imports a list of reference images to specified
        /// product sets based on a list of image information.
        ///
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be used to keep track of the
        /// progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// `Operation.response` contains `ImportProductSetsResponse`. (results)
        ///
        /// The input source of this method is a csv file on Google Cloud Storage.
        /// For the format of the csv file please see
        /// [ImportProductSetsGcsSource.csv_file_uri][google.cloud.vision.v1.ImportProductSetsGcsSource.csv_file_uri].
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
        public override lro::Operation<ImportProductSetsResponse, BatchOperationMetadata> ImportProductSets(
            ImportProductSetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportProductSetsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportProductSetsResponse, BatchOperationMetadata>(
                _callImportProductSets.Sync(request, callSettings), ImportProductSetsOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>ImportProductSets</c>.
        /// </summary>
        public override lro::OperationsClient ImportProductSetsOperationsClient { get; }

    }

    // Partial classes to enable page-streaming

    public partial class ListProductsRequest : gaxgrpc::IPageRequest { }
    public partial class ListProductsResponse : gaxgrpc::IPageResponse<Product>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Product> GetEnumerator() => Products.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListReferenceImagesRequest : gaxgrpc::IPageRequest { }
    public partial class ListReferenceImagesResponse : gaxgrpc::IPageResponse<ReferenceImage>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<ReferenceImage> GetEnumerator() => ReferenceImages.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListProductSetsRequest : gaxgrpc::IPageRequest { }
    public partial class ListProductSetsResponse : gaxgrpc::IPageResponse<ProductSet>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<ProductSet> GetEnumerator() => ProductSets.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListProductsInProductSetRequest : gaxgrpc::IPageRequest { }
    public partial class ListProductsInProductSetResponse : gaxgrpc::IPageResponse<Product>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Product> GetEnumerator() => Products.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // Partial Grpc class to enable LRO client creation
    public static partial class ProductSearch
    {
        public partial class ProductSearchClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() => new lro::Operations.OperationsClient(CallInvoker);
        }
    }


}
