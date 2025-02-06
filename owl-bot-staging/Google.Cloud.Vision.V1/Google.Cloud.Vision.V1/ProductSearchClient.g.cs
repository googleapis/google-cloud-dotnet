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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
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

namespace Google.Cloud.Vision.V1
{
    /// <summary>Settings for <see cref="ProductSearchClient"/> instances.</summary>
    public sealed partial class ProductSearchSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ProductSearchSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ProductSearchSettings"/>.</returns>
        public static ProductSearchSettings GetDefault() => new ProductSearchSettings();

        /// <summary>Constructs a new <see cref="ProductSearchSettings"/> object with default settings.</summary>
        public ProductSearchSettings()
        {
        }

        private ProductSearchSettings(ProductSearchSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateProductSetSettings = existing.CreateProductSetSettings;
            ListProductSetsSettings = existing.ListProductSetsSettings;
            GetProductSetSettings = existing.GetProductSetSettings;
            UpdateProductSetSettings = existing.UpdateProductSetSettings;
            DeleteProductSetSettings = existing.DeleteProductSetSettings;
            CreateProductSettings = existing.CreateProductSettings;
            ListProductsSettings = existing.ListProductsSettings;
            GetProductSettings = existing.GetProductSettings;
            UpdateProductSettings = existing.UpdateProductSettings;
            DeleteProductSettings = existing.DeleteProductSettings;
            CreateReferenceImageSettings = existing.CreateReferenceImageSettings;
            DeleteReferenceImageSettings = existing.DeleteReferenceImageSettings;
            ListReferenceImagesSettings = existing.ListReferenceImagesSettings;
            GetReferenceImageSettings = existing.GetReferenceImageSettings;
            AddProductToProductSetSettings = existing.AddProductToProductSetSettings;
            RemoveProductFromProductSetSettings = existing.RemoveProductFromProductSetSettings;
            ListProductsInProductSetSettings = existing.ListProductsInProductSetSettings;
            ImportProductSetsSettings = existing.ImportProductSetsSettings;
            ImportProductSetsOperationsSettings = existing.ImportProductSetsOperationsSettings.Clone();
            PurgeProductsSettings = existing.PurgeProductsSettings;
            PurgeProductsOperationsSettings = existing.PurgeProductsOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(ProductSearchSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.CreateProductSet</c> and <c>ProductSearchClient.CreateProductSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>No status codes are retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateProductSetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes()));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.ListProductSets</c> and <c>ProductSearchClient.ListProductSetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListProductSetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.GetProductSet</c> and <c>ProductSearchClient.GetProductSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetProductSetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.UpdateProductSet</c> and <c>ProductSearchClient.UpdateProductSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateProductSetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.DeleteProductSet</c> and <c>ProductSearchClient.DeleteProductSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteProductSetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.CreateProduct</c> and <c>ProductSearchClient.CreateProductAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>No status codes are retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateProductSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes()));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.ListProducts</c> and <c>ProductSearchClient.ListProductsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListProductsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.GetProduct</c> and <c>ProductSearchClient.GetProductAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetProductSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.UpdateProduct</c> and <c>ProductSearchClient.UpdateProductAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateProductSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.DeleteProduct</c> and <c>ProductSearchClient.DeleteProductAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteProductSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.CreateReferenceImage</c> and <c>ProductSearchClient.CreateReferenceImageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>No status codes are retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateReferenceImageSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes()));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.DeleteReferenceImage</c> and <c>ProductSearchClient.DeleteReferenceImageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteReferenceImageSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.ListReferenceImages</c> and <c>ProductSearchClient.ListReferenceImagesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListReferenceImagesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.GetReferenceImage</c> and <c>ProductSearchClient.GetReferenceImageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetReferenceImageSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.AddProductToProductSet</c> and <c>ProductSearchClient.AddProductToProductSetAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddProductToProductSetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.RemoveProductFromProductSet</c> and
        /// <c>ProductSearchClient.RemoveProductFromProductSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveProductFromProductSetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.ListProductsInProductSet</c> and <c>ProductSearchClient.ListProductsInProductSetAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListProductsInProductSetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.ImportProductSets</c> and <c>ProductSearchClient.ImportProductSetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>No status codes are retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportProductSetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes()));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProductSearchClient.ImportProductSets</c> and
        /// <c>ProductSearchClient.ImportProductSetsAsync</c>.
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
        public lro::OperationsSettings ImportProductSetsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductSearchClient.PurgeProducts</c> and <c>ProductSearchClient.PurgeProductsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>No status codes are retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PurgeProductsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes()));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProductSearchClient.PurgeProducts</c> and
        /// <c>ProductSearchClient.PurgeProductsAsync</c>.
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
        public lro::OperationsSettings PurgeProductsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ProductSearchSettings"/> object.</returns>
        public ProductSearchSettings Clone() => new ProductSearchSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ProductSearchClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ProductSearchClientBuilder : gaxgrpc::ClientBuilderBase<ProductSearchClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ProductSearchSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ProductSearchClientBuilder() : base(ProductSearchClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ProductSearchClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ProductSearchClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ProductSearchClient Build()
        {
            ProductSearchClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ProductSearchClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ProductSearchClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ProductSearchClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ProductSearchClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ProductSearchClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ProductSearchClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ProductSearchClient.ChannelPool;
    }

    /// <summary>ProductSearch client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages Products and ProductSets of reference images for use in product
    /// search. It uses the following resource model:
    /// 
    /// - The API has a collection of [ProductSet][google.cloud.vision.v1.ProductSet]
    /// resources, named `projects/*/locations/*/productSets/*`, which acts as a way
    /// to put different products into groups to limit identification.
    /// 
    /// In parallel,
    /// 
    /// - The API has a collection of [Product][google.cloud.vision.v1.Product]
    /// resources, named
    /// `projects/*/locations/*/products/*`
    /// 
    /// - Each [Product][google.cloud.vision.v1.Product] has a collection of
    /// [ReferenceImage][google.cloud.vision.v1.ReferenceImage] resources, named
    /// `projects/*/locations/*/products/*/referenceImages/*`
    /// </remarks>
    public abstract partial class ProductSearchClient
    {
        /// <summary>
        /// The default endpoint for the ProductSearch service, which is a host of "vision.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "vision.googleapis.com:443";

        /// <summary>The default ProductSearch scopes.</summary>
        /// <remarks>
        /// The default ProductSearch scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-vision</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-vision",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ProductSearch.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ProductSearchClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ProductSearchClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ProductSearchClient"/>.</returns>
        public static stt::Task<ProductSearchClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ProductSearchClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ProductSearchClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ProductSearchClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ProductSearchClient"/>.</returns>
        public static ProductSearchClient Create() => new ProductSearchClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ProductSearchClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ProductSearchSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ProductSearchClient"/>.</returns>
        internal static ProductSearchClient Create(grpccore::CallInvoker callInvoker, ProductSearchSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ProductSearch.ProductSearchClient grpcClient = new ProductSearch.ProductSearchClient(callInvoker);
            return new ProductSearchClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ProductSearch client</summary>
        public virtual ProductSearch.ProductSearchClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and returns a new ProductSet resource.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if display_name is missing, or is longer than
        /// 4096 characters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProductSet CreateProductSet(CreateProductSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and returns a new ProductSet resource.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if display_name is missing, or is longer than
        /// 4096 characters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductSet> CreateProductSetAsync(CreateProductSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and returns a new ProductSet resource.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if display_name is missing, or is longer than
        /// 4096 characters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductSet> CreateProductSetAsync(CreateProductSetRequest request, st::CancellationToken cancellationToken) =>
            CreateProductSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and returns a new ProductSet resource.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if display_name is missing, or is longer than
        /// 4096 characters.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the ProductSet should be created.
        /// 
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="productSet">
        /// Required. The ProductSet to create.
        /// </param>
        /// <param name="productSetId">
        /// A user-supplied resource id for this ProductSet. If set, the server will
        /// attempt to use this value as the resource id. If it is already in use, an
        /// error is returned with code ALREADY_EXISTS. Must be at most 128 characters
        /// long. It cannot contain the character `/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProductSet CreateProductSet(string parent, ProductSet productSet, string productSetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProductSet(new CreateProductSetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ProductSet = gax::GaxPreconditions.CheckNotNull(productSet, nameof(productSet)),
                ProductSetId = productSetId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates and returns a new ProductSet resource.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if display_name is missing, or is longer than
        /// 4096 characters.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the ProductSet should be created.
        /// 
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="productSet">
        /// Required. The ProductSet to create.
        /// </param>
        /// <param name="productSetId">
        /// A user-supplied resource id for this ProductSet. If set, the server will
        /// attempt to use this value as the resource id. If it is already in use, an
        /// error is returned with code ALREADY_EXISTS. Must be at most 128 characters
        /// long. It cannot contain the character `/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductSet> CreateProductSetAsync(string parent, ProductSet productSet, string productSetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProductSetAsync(new CreateProductSetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ProductSet = gax::GaxPreconditions.CheckNotNull(productSet, nameof(productSet)),
                ProductSetId = productSetId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates and returns a new ProductSet resource.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if display_name is missing, or is longer than
        /// 4096 characters.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the ProductSet should be created.
        /// 
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="productSet">
        /// Required. The ProductSet to create.
        /// </param>
        /// <param name="productSetId">
        /// A user-supplied resource id for this ProductSet. If set, the server will
        /// attempt to use this value as the resource id. If it is already in use, an
        /// error is returned with code ALREADY_EXISTS. Must be at most 128 characters
        /// long. It cannot contain the character `/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductSet> CreateProductSetAsync(string parent, ProductSet productSet, string productSetId, st::CancellationToken cancellationToken) =>
            CreateProductSetAsync(parent, productSet, productSetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and returns a new ProductSet resource.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if display_name is missing, or is longer than
        /// 4096 characters.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the ProductSet should be created.
        /// 
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="productSet">
        /// Required. The ProductSet to create.
        /// </param>
        /// <param name="productSetId">
        /// A user-supplied resource id for this ProductSet. If set, the server will
        /// attempt to use this value as the resource id. If it is already in use, an
        /// error is returned with code ALREADY_EXISTS. Must be at most 128 characters
        /// long. It cannot contain the character `/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProductSet CreateProductSet(gagr::LocationName parent, ProductSet productSet, string productSetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProductSet(new CreateProductSetRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProductSet = gax::GaxPreconditions.CheckNotNull(productSet, nameof(productSet)),
                ProductSetId = productSetId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates and returns a new ProductSet resource.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if display_name is missing, or is longer than
        /// 4096 characters.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the ProductSet should be created.
        /// 
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="productSet">
        /// Required. The ProductSet to create.
        /// </param>
        /// <param name="productSetId">
        /// A user-supplied resource id for this ProductSet. If set, the server will
        /// attempt to use this value as the resource id. If it is already in use, an
        /// error is returned with code ALREADY_EXISTS. Must be at most 128 characters
        /// long. It cannot contain the character `/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductSet> CreateProductSetAsync(gagr::LocationName parent, ProductSet productSet, string productSetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProductSetAsync(new CreateProductSetRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProductSet = gax::GaxPreconditions.CheckNotNull(productSet, nameof(productSet)),
                ProductSetId = productSetId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates and returns a new ProductSet resource.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if display_name is missing, or is longer than
        /// 4096 characters.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the ProductSet should be created.
        /// 
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="productSet">
        /// Required. The ProductSet to create.
        /// </param>
        /// <param name="productSetId">
        /// A user-supplied resource id for this ProductSet. If set, the server will
        /// attempt to use this value as the resource id. If it is already in use, an
        /// error is returned with code ALREADY_EXISTS. Must be at most 128 characters
        /// long. It cannot contain the character `/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductSet> CreateProductSetAsync(gagr::LocationName parent, ProductSet productSet, string productSetId, st::CancellationToken cancellationToken) =>
            CreateProductSetAsync(parent, productSet, productSetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists ProductSets in an unspecified order.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100, or less
        /// than 1.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ProductSet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProductSetsResponse, ProductSet> ListProductSets(ListProductSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ProductSets in an unspecified order.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100, or less
        /// than 1.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ProductSet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProductSetsResponse, ProductSet> ListProductSetsAsync(ListProductSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ProductSets in an unspecified order.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100, or less
        /// than 1.
        /// </summary>
        /// <param name="parent">
        /// Required. The project from which ProductSets should be listed.
        /// 
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
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
        /// <returns>A pageable sequence of <see cref="ProductSet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProductSetsResponse, ProductSet> ListProductSets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductSetsRequest request = new ListProductSetsRequest
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
            return ListProductSets(request, callSettings);
        }

        /// <summary>
        /// Lists ProductSets in an unspecified order.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100, or less
        /// than 1.
        /// </summary>
        /// <param name="parent">
        /// Required. The project from which ProductSets should be listed.
        /// 
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ProductSet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProductSetsResponse, ProductSet> ListProductSetsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductSetsRequest request = new ListProductSetsRequest
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
            return ListProductSetsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ProductSets in an unspecified order.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100, or less
        /// than 1.
        /// </summary>
        /// <param name="parent">
        /// Required. The project from which ProductSets should be listed.
        /// 
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
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
        /// <returns>A pageable sequence of <see cref="ProductSet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProductSetsResponse, ProductSet> ListProductSets(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductSetsRequest request = new ListProductSetsRequest
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
            return ListProductSets(request, callSettings);
        }

        /// <summary>
        /// Lists ProductSets in an unspecified order.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100, or less
        /// than 1.
        /// </summary>
        /// <param name="parent">
        /// Required. The project from which ProductSets should be listed.
        /// 
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ProductSet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProductSetsResponse, ProductSet> ListProductSetsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductSetsRequest request = new ListProductSetsRequest
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
            return ListProductSetsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets information associated with a ProductSet.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProductSet GetProductSet(GetProductSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information associated with a ProductSet.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductSet> GetProductSetAsync(GetProductSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information associated with a ProductSet.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductSet> GetProductSetAsync(GetProductSetRequest request, st::CancellationToken cancellationToken) =>
            GetProductSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information associated with a ProductSet.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the ProductSet to get.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProductSet GetProductSet(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProductSet(new GetProductSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information associated with a ProductSet.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the ProductSet to get.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductSet> GetProductSetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProductSetAsync(new GetProductSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information associated with a ProductSet.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the ProductSet to get.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductSet> GetProductSetAsync(string name, st::CancellationToken cancellationToken) =>
            GetProductSetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information associated with a ProductSet.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the ProductSet to get.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProductSet GetProductSet(ProductSetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProductSet(new GetProductSetRequest
            {
                ProductSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information associated with a ProductSet.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the ProductSet to get.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductSet> GetProductSetAsync(ProductSetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProductSetAsync(new GetProductSetRequest
            {
                ProductSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information associated with a ProductSet.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the ProductSet to get.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductSet> GetProductSetAsync(ProductSetName name, st::CancellationToken cancellationToken) =>
            GetProductSetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Makes changes to a ProductSet resource.
        /// Only display_name can be updated currently.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// * Returns INVALID_ARGUMENT if display_name is present in update_mask but
        /// missing from the request or longer than 4096 characters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProductSet UpdateProductSet(UpdateProductSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Makes changes to a ProductSet resource.
        /// Only display_name can be updated currently.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// * Returns INVALID_ARGUMENT if display_name is present in update_mask but
        /// missing from the request or longer than 4096 characters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductSet> UpdateProductSetAsync(UpdateProductSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Makes changes to a ProductSet resource.
        /// Only display_name can be updated currently.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// * Returns INVALID_ARGUMENT if display_name is present in update_mask but
        /// missing from the request or longer than 4096 characters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductSet> UpdateProductSetAsync(UpdateProductSetRequest request, st::CancellationToken cancellationToken) =>
            UpdateProductSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Makes changes to a ProductSet resource.
        /// Only display_name can be updated currently.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// * Returns INVALID_ARGUMENT if display_name is present in update_mask but
        /// missing from the request or longer than 4096 characters.
        /// </summary>
        /// <param name="productSet">
        /// Required. The ProductSet resource which replaces the one on the server.
        /// </param>
        /// <param name="updateMask">
        /// The [FieldMask][google.protobuf.FieldMask] that specifies which fields to
        /// update.
        /// If update_mask isn't specified, all mutable fields are to be updated.
        /// Valid mask path is `display_name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProductSet UpdateProductSet(ProductSet productSet, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProductSet(new UpdateProductSetRequest
            {
                ProductSet = gax::GaxPreconditions.CheckNotNull(productSet, nameof(productSet)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Makes changes to a ProductSet resource.
        /// Only display_name can be updated currently.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// * Returns INVALID_ARGUMENT if display_name is present in update_mask but
        /// missing from the request or longer than 4096 characters.
        /// </summary>
        /// <param name="productSet">
        /// Required. The ProductSet resource which replaces the one on the server.
        /// </param>
        /// <param name="updateMask">
        /// The [FieldMask][google.protobuf.FieldMask] that specifies which fields to
        /// update.
        /// If update_mask isn't specified, all mutable fields are to be updated.
        /// Valid mask path is `display_name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductSet> UpdateProductSetAsync(ProductSet productSet, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProductSetAsync(new UpdateProductSetRequest
            {
                ProductSet = gax::GaxPreconditions.CheckNotNull(productSet, nameof(productSet)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Makes changes to a ProductSet resource.
        /// Only display_name can be updated currently.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// * Returns INVALID_ARGUMENT if display_name is present in update_mask but
        /// missing from the request or longer than 4096 characters.
        /// </summary>
        /// <param name="productSet">
        /// Required. The ProductSet resource which replaces the one on the server.
        /// </param>
        /// <param name="updateMask">
        /// The [FieldMask][google.protobuf.FieldMask] that specifies which fields to
        /// update.
        /// If update_mask isn't specified, all mutable fields are to be updated.
        /// Valid mask path is `display_name`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProductSet> UpdateProductSetAsync(ProductSet productSet, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateProductSetAsync(productSet, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes a ProductSet. Products and ReferenceImages in the
        /// ProductSet are not deleted.
        /// 
        /// The actual image files are not deleted from Google Cloud Storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteProductSet(DeleteProductSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes a ProductSet. Products and ReferenceImages in the
        /// ProductSet are not deleted.
        /// 
        /// The actual image files are not deleted from Google Cloud Storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductSetAsync(DeleteProductSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes a ProductSet. Products and ReferenceImages in the
        /// ProductSet are not deleted.
        /// 
        /// The actual image files are not deleted from Google Cloud Storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductSetAsync(DeleteProductSetRequest request, st::CancellationToken cancellationToken) =>
            DeleteProductSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes a ProductSet. Products and ReferenceImages in the
        /// ProductSet are not deleted.
        /// 
        /// The actual image files are not deleted from Google Cloud Storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the ProductSet to delete.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteProductSet(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProductSet(new DeleteProductSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes a ProductSet. Products and ReferenceImages in the
        /// ProductSet are not deleted.
        /// 
        /// The actual image files are not deleted from Google Cloud Storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the ProductSet to delete.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductSetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProductSetAsync(new DeleteProductSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes a ProductSet. Products and ReferenceImages in the
        /// ProductSet are not deleted.
        /// 
        /// The actual image files are not deleted from Google Cloud Storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the ProductSet to delete.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductSetAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteProductSetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes a ProductSet. Products and ReferenceImages in the
        /// ProductSet are not deleted.
        /// 
        /// The actual image files are not deleted from Google Cloud Storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the ProductSet to delete.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteProductSet(ProductSetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProductSet(new DeleteProductSetRequest
            {
                ProductSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes a ProductSet. Products and ReferenceImages in the
        /// ProductSet are not deleted.
        /// 
        /// The actual image files are not deleted from Google Cloud Storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the ProductSet to delete.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductSetAsync(ProductSetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProductSetAsync(new DeleteProductSetRequest
            {
                ProductSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes a ProductSet. Products and ReferenceImages in the
        /// ProductSet are not deleted.
        /// 
        /// The actual image files are not deleted from Google Cloud Storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the ProductSet to delete.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductSetAsync(ProductSetName name, st::CancellationToken cancellationToken) =>
            DeleteProductSetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and returns a new product resource.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if display_name is missing or longer than 4096
        /// characters.
        /// * Returns INVALID_ARGUMENT if description is longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is missing or invalid.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product CreateProduct(CreateProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and returns a new product resource.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if display_name is missing or longer than 4096
        /// characters.
        /// * Returns INVALID_ARGUMENT if description is longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is missing or invalid.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> CreateProductAsync(CreateProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and returns a new product resource.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if display_name is missing or longer than 4096
        /// characters.
        /// * Returns INVALID_ARGUMENT if description is longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is missing or invalid.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> CreateProductAsync(CreateProductRequest request, st::CancellationToken cancellationToken) =>
            CreateProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and returns a new product resource.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if display_name is missing or longer than 4096
        /// characters.
        /// * Returns INVALID_ARGUMENT if description is longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is missing or invalid.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the Product should be created.
        /// 
        /// Format is
        /// `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="product">
        /// Required. The product to create.
        /// </param>
        /// <param name="productId">
        /// A user-supplied resource id for this Product. If set, the server will
        /// attempt to use this value as the resource id. If it is already in use, an
        /// error is returned with code ALREADY_EXISTS. Must be at most 128 characters
        /// long. It cannot contain the character `/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product CreateProduct(string parent, Product product, string productId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProduct(new CreateProductRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Product = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
                ProductId = productId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates and returns a new product resource.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if display_name is missing or longer than 4096
        /// characters.
        /// * Returns INVALID_ARGUMENT if description is longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is missing or invalid.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the Product should be created.
        /// 
        /// Format is
        /// `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="product">
        /// Required. The product to create.
        /// </param>
        /// <param name="productId">
        /// A user-supplied resource id for this Product. If set, the server will
        /// attempt to use this value as the resource id. If it is already in use, an
        /// error is returned with code ALREADY_EXISTS. Must be at most 128 characters
        /// long. It cannot contain the character `/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> CreateProductAsync(string parent, Product product, string productId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProductAsync(new CreateProductRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Product = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
                ProductId = productId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates and returns a new product resource.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if display_name is missing or longer than 4096
        /// characters.
        /// * Returns INVALID_ARGUMENT if description is longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is missing or invalid.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the Product should be created.
        /// 
        /// Format is
        /// `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="product">
        /// Required. The product to create.
        /// </param>
        /// <param name="productId">
        /// A user-supplied resource id for this Product. If set, the server will
        /// attempt to use this value as the resource id. If it is already in use, an
        /// error is returned with code ALREADY_EXISTS. Must be at most 128 characters
        /// long. It cannot contain the character `/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> CreateProductAsync(string parent, Product product, string productId, st::CancellationToken cancellationToken) =>
            CreateProductAsync(parent, product, productId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and returns a new product resource.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if display_name is missing or longer than 4096
        /// characters.
        /// * Returns INVALID_ARGUMENT if description is longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is missing or invalid.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the Product should be created.
        /// 
        /// Format is
        /// `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="product">
        /// Required. The product to create.
        /// </param>
        /// <param name="productId">
        /// A user-supplied resource id for this Product. If set, the server will
        /// attempt to use this value as the resource id. If it is already in use, an
        /// error is returned with code ALREADY_EXISTS. Must be at most 128 characters
        /// long. It cannot contain the character `/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product CreateProduct(gagr::LocationName parent, Product product, string productId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProduct(new CreateProductRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Product = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
                ProductId = productId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates and returns a new product resource.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if display_name is missing or longer than 4096
        /// characters.
        /// * Returns INVALID_ARGUMENT if description is longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is missing or invalid.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the Product should be created.
        /// 
        /// Format is
        /// `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="product">
        /// Required. The product to create.
        /// </param>
        /// <param name="productId">
        /// A user-supplied resource id for this Product. If set, the server will
        /// attempt to use this value as the resource id. If it is already in use, an
        /// error is returned with code ALREADY_EXISTS. Must be at most 128 characters
        /// long. It cannot contain the character `/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> CreateProductAsync(gagr::LocationName parent, Product product, string productId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProductAsync(new CreateProductRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Product = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
                ProductId = productId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates and returns a new product resource.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if display_name is missing or longer than 4096
        /// characters.
        /// * Returns INVALID_ARGUMENT if description is longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is missing or invalid.
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the Product should be created.
        /// 
        /// Format is
        /// `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="product">
        /// Required. The product to create.
        /// </param>
        /// <param name="productId">
        /// A user-supplied resource id for this Product. If set, the server will
        /// attempt to use this value as the resource id. If it is already in use, an
        /// error is returned with code ALREADY_EXISTS. Must be at most 128 characters
        /// long. It cannot contain the character `/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> CreateProductAsync(gagr::LocationName parent, Product product, string productId, st::CancellationToken cancellationToken) =>
            CreateProductAsync(parent, product, productId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists products in an unspecified order.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100 or less than 1.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProductsResponse, Product> ListProducts(ListProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists products in an unspecified order.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100 or less than 1.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProductsResponse, Product> ListProductsAsync(ListProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists products in an unspecified order.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100 or less than 1.
        /// </summary>
        /// <param name="parent">
        /// Required. The project OR ProductSet from which Products should be listed.
        /// 
        /// Format:
        /// `projects/PROJECT_ID/locations/LOC_ID`
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
        /// <returns>A pageable sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProductsResponse, Product> ListProducts(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductsRequest request = new ListProductsRequest
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
            return ListProducts(request, callSettings);
        }

        /// <summary>
        /// Lists products in an unspecified order.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100 or less than 1.
        /// </summary>
        /// <param name="parent">
        /// Required. The project OR ProductSet from which Products should be listed.
        /// 
        /// Format:
        /// `projects/PROJECT_ID/locations/LOC_ID`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProductsResponse, Product> ListProductsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductsRequest request = new ListProductsRequest
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
            return ListProductsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists products in an unspecified order.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100 or less than 1.
        /// </summary>
        /// <param name="parent">
        /// Required. The project OR ProductSet from which Products should be listed.
        /// 
        /// Format:
        /// `projects/PROJECT_ID/locations/LOC_ID`
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
        /// <returns>A pageable sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProductsResponse, Product> ListProducts(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductsRequest request = new ListProductsRequest
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
            return ListProducts(request, callSettings);
        }

        /// <summary>
        /// Lists products in an unspecified order.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100 or less than 1.
        /// </summary>
        /// <param name="parent">
        /// Required. The project OR ProductSet from which Products should be listed.
        /// 
        /// Format:
        /// `projects/PROJECT_ID/locations/LOC_ID`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProductsResponse, Product> ListProductsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductsRequest request = new ListProductsRequest
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
            return ListProductsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets information associated with a Product.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the Product does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product GetProduct(GetProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information associated with a Product.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the Product does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(GetProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information associated with a Product.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the Product does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(GetProductRequest request, st::CancellationToken cancellationToken) =>
            GetProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information associated with a Product.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the Product does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Product to get.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product GetProduct(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProduct(new GetProductRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information associated with a Product.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the Product does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Product to get.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProductAsync(new GetProductRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information associated with a Product.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the Product does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Product to get.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(string name, st::CancellationToken cancellationToken) =>
            GetProductAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information associated with a Product.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the Product does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Product to get.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product GetProduct(ProductName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProduct(new GetProductRequest
            {
                ProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information associated with a Product.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the Product does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Product to get.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(ProductName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProductAsync(new GetProductRequest
            {
                ProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information associated with a Product.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the Product does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Product to get.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(ProductName name, st::CancellationToken cancellationToken) =>
            GetProductAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// missing from the request or longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if description is present in update_mask but is
        /// longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is present in update_mask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product UpdateProduct(UpdateProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

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
        /// missing from the request or longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if description is present in update_mask but is
        /// longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is present in update_mask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> UpdateProductAsync(UpdateProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

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
        /// missing from the request or longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if description is present in update_mask but is
        /// longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is present in update_mask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> UpdateProductAsync(UpdateProductRequest request, st::CancellationToken cancellationToken) =>
            UpdateProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// missing from the request or longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if description is present in update_mask but is
        /// longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is present in update_mask.
        /// </summary>
        /// <param name="product">
        /// Required. The Product resource which replaces the one on the server.
        /// product.name is immutable.
        /// </param>
        /// <param name="updateMask">
        /// The [FieldMask][google.protobuf.FieldMask] that specifies which fields
        /// to update.
        /// If update_mask isn't specified, all mutable fields are to be updated.
        /// Valid mask paths include `product_labels`, `display_name`, and
        /// `description`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product UpdateProduct(Product product, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProduct(new UpdateProductRequest
            {
                Product = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
                UpdateMask = updateMask,
            }, callSettings);

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
        /// missing from the request or longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if description is present in update_mask but is
        /// longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is present in update_mask.
        /// </summary>
        /// <param name="product">
        /// Required. The Product resource which replaces the one on the server.
        /// product.name is immutable.
        /// </param>
        /// <param name="updateMask">
        /// The [FieldMask][google.protobuf.FieldMask] that specifies which fields
        /// to update.
        /// If update_mask isn't specified, all mutable fields are to be updated.
        /// Valid mask paths include `product_labels`, `display_name`, and
        /// `description`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> UpdateProductAsync(Product product, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProductAsync(new UpdateProductRequest
            {
                Product = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
                UpdateMask = updateMask,
            }, callSettings);

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
        /// missing from the request or longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if description is present in update_mask but is
        /// longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is present in update_mask.
        /// </summary>
        /// <param name="product">
        /// Required. The Product resource which replaces the one on the server.
        /// product.name is immutable.
        /// </param>
        /// <param name="updateMask">
        /// The [FieldMask][google.protobuf.FieldMask] that specifies which fields
        /// to update.
        /// If update_mask isn't specified, all mutable fields are to be updated.
        /// Valid mask paths include `product_labels`, `display_name`, and
        /// `description`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> UpdateProductAsync(Product product, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateProductAsync(product, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes a product and its reference images.
        /// 
        /// Metadata of the product and all its images will be deleted right away, but
        /// search queries against ProductSets containing the product may still work
        /// until all related caches are refreshed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteProduct(DeleteProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes a product and its reference images.
        /// 
        /// Metadata of the product and all its images will be deleted right away, but
        /// search queries against ProductSets containing the product may still work
        /// until all related caches are refreshed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductAsync(DeleteProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes a product and its reference images.
        /// 
        /// Metadata of the product and all its images will be deleted right away, but
        /// search queries against ProductSets containing the product may still work
        /// until all related caches are refreshed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductAsync(DeleteProductRequest request, st::CancellationToken cancellationToken) =>
            DeleteProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes a product and its reference images.
        /// 
        /// Metadata of the product and all its images will be deleted right away, but
        /// search queries against ProductSets containing the product may still work
        /// until all related caches are refreshed.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of product to delete.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteProduct(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProduct(new DeleteProductRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes a product and its reference images.
        /// 
        /// Metadata of the product and all its images will be deleted right away, but
        /// search queries against ProductSets containing the product may still work
        /// until all related caches are refreshed.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of product to delete.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProductAsync(new DeleteProductRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes a product and its reference images.
        /// 
        /// Metadata of the product and all its images will be deleted right away, but
        /// search queries against ProductSets containing the product may still work
        /// until all related caches are refreshed.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of product to delete.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteProductAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes a product and its reference images.
        /// 
        /// Metadata of the product and all its images will be deleted right away, but
        /// search queries against ProductSets containing the product may still work
        /// until all related caches are refreshed.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of product to delete.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteProduct(ProductName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProduct(new DeleteProductRequest
            {
                ProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes a product and its reference images.
        /// 
        /// Metadata of the product and all its images will be deleted right away, but
        /// search queries against ProductSets containing the product may still work
        /// until all related caches are refreshed.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of product to delete.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductAsync(ProductName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProductAsync(new DeleteProductRequest
            {
                ProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes a product and its reference images.
        /// 
        /// Metadata of the product and all its images will be deleted right away, but
        /// search queries against ProductSets containing the product may still work
        /// until all related caches are refreshed.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of product to delete.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductAsync(ProductName name, st::CancellationToken cancellationToken) =>
            DeleteProductAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// characters.
        /// * Returns INVALID_ARGUMENT if the product does not exist.
        /// * Returns INVALID_ARGUMENT if bounding_poly is not provided, and nothing
        /// compatible with the parent product's product_category is detected.
        /// * Returns INVALID_ARGUMENT if bounding_poly contains more than 10 polygons.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReferenceImage CreateReferenceImage(CreateReferenceImageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

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
        /// characters.
        /// * Returns INVALID_ARGUMENT if the product does not exist.
        /// * Returns INVALID_ARGUMENT if bounding_poly is not provided, and nothing
        /// compatible with the parent product's product_category is detected.
        /// * Returns INVALID_ARGUMENT if bounding_poly contains more than 10 polygons.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceImage> CreateReferenceImageAsync(CreateReferenceImageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

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
        /// characters.
        /// * Returns INVALID_ARGUMENT if the product does not exist.
        /// * Returns INVALID_ARGUMENT if bounding_poly is not provided, and nothing
        /// compatible with the parent product's product_category is detected.
        /// * Returns INVALID_ARGUMENT if bounding_poly contains more than 10 polygons.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceImage> CreateReferenceImageAsync(CreateReferenceImageRequest request, st::CancellationToken cancellationToken) =>
            CreateReferenceImageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// characters.
        /// * Returns INVALID_ARGUMENT if the product does not exist.
        /// * Returns INVALID_ARGUMENT if bounding_poly is not provided, and nothing
        /// compatible with the parent product's product_category is detected.
        /// * Returns INVALID_ARGUMENT if bounding_poly contains more than 10 polygons.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the product in which to create the reference
        /// image.
        /// 
        /// Format is
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`.
        /// </param>
        /// <param name="referenceImage">
        /// Required. The reference image to create.
        /// If an image ID is specified, it is ignored.
        /// </param>
        /// <param name="referenceImageId">
        /// A user-supplied resource id for the ReferenceImage to be added. If set,
        /// the server will attempt to use this value as the resource id. If it is
        /// already in use, an error is returned with code ALREADY_EXISTS. Must be at
        /// most 128 characters long. It cannot contain the character `/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReferenceImage CreateReferenceImage(string parent, ReferenceImage referenceImage, string referenceImageId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReferenceImage(new CreateReferenceImageRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReferenceImage = gax::GaxPreconditions.CheckNotNull(referenceImage, nameof(referenceImage)),
                ReferenceImageId = referenceImageId ?? "",
            }, callSettings);

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
        /// characters.
        /// * Returns INVALID_ARGUMENT if the product does not exist.
        /// * Returns INVALID_ARGUMENT if bounding_poly is not provided, and nothing
        /// compatible with the parent product's product_category is detected.
        /// * Returns INVALID_ARGUMENT if bounding_poly contains more than 10 polygons.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the product in which to create the reference
        /// image.
        /// 
        /// Format is
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`.
        /// </param>
        /// <param name="referenceImage">
        /// Required. The reference image to create.
        /// If an image ID is specified, it is ignored.
        /// </param>
        /// <param name="referenceImageId">
        /// A user-supplied resource id for the ReferenceImage to be added. If set,
        /// the server will attempt to use this value as the resource id. If it is
        /// already in use, an error is returned with code ALREADY_EXISTS. Must be at
        /// most 128 characters long. It cannot contain the character `/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceImage> CreateReferenceImageAsync(string parent, ReferenceImage referenceImage, string referenceImageId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReferenceImageAsync(new CreateReferenceImageRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReferenceImage = gax::GaxPreconditions.CheckNotNull(referenceImage, nameof(referenceImage)),
                ReferenceImageId = referenceImageId ?? "",
            }, callSettings);

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
        /// characters.
        /// * Returns INVALID_ARGUMENT if the product does not exist.
        /// * Returns INVALID_ARGUMENT if bounding_poly is not provided, and nothing
        /// compatible with the parent product's product_category is detected.
        /// * Returns INVALID_ARGUMENT if bounding_poly contains more than 10 polygons.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the product in which to create the reference
        /// image.
        /// 
        /// Format is
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`.
        /// </param>
        /// <param name="referenceImage">
        /// Required. The reference image to create.
        /// If an image ID is specified, it is ignored.
        /// </param>
        /// <param name="referenceImageId">
        /// A user-supplied resource id for the ReferenceImage to be added. If set,
        /// the server will attempt to use this value as the resource id. If it is
        /// already in use, an error is returned with code ALREADY_EXISTS. Must be at
        /// most 128 characters long. It cannot contain the character `/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceImage> CreateReferenceImageAsync(string parent, ReferenceImage referenceImage, string referenceImageId, st::CancellationToken cancellationToken) =>
            CreateReferenceImageAsync(parent, referenceImage, referenceImageId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// characters.
        /// * Returns INVALID_ARGUMENT if the product does not exist.
        /// * Returns INVALID_ARGUMENT if bounding_poly is not provided, and nothing
        /// compatible with the parent product's product_category is detected.
        /// * Returns INVALID_ARGUMENT if bounding_poly contains more than 10 polygons.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the product in which to create the reference
        /// image.
        /// 
        /// Format is
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`.
        /// </param>
        /// <param name="referenceImage">
        /// Required. The reference image to create.
        /// If an image ID is specified, it is ignored.
        /// </param>
        /// <param name="referenceImageId">
        /// A user-supplied resource id for the ReferenceImage to be added. If set,
        /// the server will attempt to use this value as the resource id. If it is
        /// already in use, an error is returned with code ALREADY_EXISTS. Must be at
        /// most 128 characters long. It cannot contain the character `/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReferenceImage CreateReferenceImage(ProductName parent, ReferenceImage referenceImage, string referenceImageId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReferenceImage(new CreateReferenceImageRequest
            {
                ParentAsProductName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReferenceImage = gax::GaxPreconditions.CheckNotNull(referenceImage, nameof(referenceImage)),
                ReferenceImageId = referenceImageId ?? "",
            }, callSettings);

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
        /// characters.
        /// * Returns INVALID_ARGUMENT if the product does not exist.
        /// * Returns INVALID_ARGUMENT if bounding_poly is not provided, and nothing
        /// compatible with the parent product's product_category is detected.
        /// * Returns INVALID_ARGUMENT if bounding_poly contains more than 10 polygons.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the product in which to create the reference
        /// image.
        /// 
        /// Format is
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`.
        /// </param>
        /// <param name="referenceImage">
        /// Required. The reference image to create.
        /// If an image ID is specified, it is ignored.
        /// </param>
        /// <param name="referenceImageId">
        /// A user-supplied resource id for the ReferenceImage to be added. If set,
        /// the server will attempt to use this value as the resource id. If it is
        /// already in use, an error is returned with code ALREADY_EXISTS. Must be at
        /// most 128 characters long. It cannot contain the character `/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceImage> CreateReferenceImageAsync(ProductName parent, ReferenceImage referenceImage, string referenceImageId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReferenceImageAsync(new CreateReferenceImageRequest
            {
                ParentAsProductName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReferenceImage = gax::GaxPreconditions.CheckNotNull(referenceImage, nameof(referenceImage)),
                ReferenceImageId = referenceImageId ?? "",
            }, callSettings);

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
        /// characters.
        /// * Returns INVALID_ARGUMENT if the product does not exist.
        /// * Returns INVALID_ARGUMENT if bounding_poly is not provided, and nothing
        /// compatible with the parent product's product_category is detected.
        /// * Returns INVALID_ARGUMENT if bounding_poly contains more than 10 polygons.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the product in which to create the reference
        /// image.
        /// 
        /// Format is
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`.
        /// </param>
        /// <param name="referenceImage">
        /// Required. The reference image to create.
        /// If an image ID is specified, it is ignored.
        /// </param>
        /// <param name="referenceImageId">
        /// A user-supplied resource id for the ReferenceImage to be added. If set,
        /// the server will attempt to use this value as the resource id. If it is
        /// already in use, an error is returned with code ALREADY_EXISTS. Must be at
        /// most 128 characters long. It cannot contain the character `/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceImage> CreateReferenceImageAsync(ProductName parent, ReferenceImage referenceImage, string referenceImageId, st::CancellationToken cancellationToken) =>
            CreateReferenceImageAsync(parent, referenceImage, referenceImageId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes a reference image.
        /// 
        /// The image metadata will be deleted right away, but search queries
        /// against ProductSets containing the image may still work until all related
        /// caches are refreshed.
        /// 
        /// The actual image files are not deleted from Google Cloud Storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteReferenceImage(DeleteReferenceImageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes a reference image.
        /// 
        /// The image metadata will be deleted right away, but search queries
        /// against ProductSets containing the image may still work until all related
        /// caches are refreshed.
        /// 
        /// The actual image files are not deleted from Google Cloud Storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReferenceImageAsync(DeleteReferenceImageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes a reference image.
        /// 
        /// The image metadata will be deleted right away, but search queries
        /// against ProductSets containing the image may still work until all related
        /// caches are refreshed.
        /// 
        /// The actual image files are not deleted from Google Cloud Storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReferenceImageAsync(DeleteReferenceImageRequest request, st::CancellationToken cancellationToken) =>
            DeleteReferenceImageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes a reference image.
        /// 
        /// The image metadata will be deleted right away, but search queries
        /// against ProductSets containing the image may still work until all related
        /// caches are refreshed.
        /// 
        /// The actual image files are not deleted from Google Cloud Storage.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the reference image to delete.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID/referenceImages/IMAGE_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteReferenceImage(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReferenceImage(new DeleteReferenceImageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes a reference image.
        /// 
        /// The image metadata will be deleted right away, but search queries
        /// against ProductSets containing the image may still work until all related
        /// caches are refreshed.
        /// 
        /// The actual image files are not deleted from Google Cloud Storage.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the reference image to delete.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID/referenceImages/IMAGE_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReferenceImageAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReferenceImageAsync(new DeleteReferenceImageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes a reference image.
        /// 
        /// The image metadata will be deleted right away, but search queries
        /// against ProductSets containing the image may still work until all related
        /// caches are refreshed.
        /// 
        /// The actual image files are not deleted from Google Cloud Storage.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the reference image to delete.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID/referenceImages/IMAGE_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReferenceImageAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteReferenceImageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes a reference image.
        /// 
        /// The image metadata will be deleted right away, but search queries
        /// against ProductSets containing the image may still work until all related
        /// caches are refreshed.
        /// 
        /// The actual image files are not deleted from Google Cloud Storage.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the reference image to delete.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID/referenceImages/IMAGE_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteReferenceImage(ReferenceImageName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReferenceImage(new DeleteReferenceImageRequest
            {
                ReferenceImageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes a reference image.
        /// 
        /// The image metadata will be deleted right away, but search queries
        /// against ProductSets containing the image may still work until all related
        /// caches are refreshed.
        /// 
        /// The actual image files are not deleted from Google Cloud Storage.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the reference image to delete.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID/referenceImages/IMAGE_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReferenceImageAsync(ReferenceImageName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReferenceImageAsync(new DeleteReferenceImageRequest
            {
                ReferenceImageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes a reference image.
        /// 
        /// The image metadata will be deleted right away, but search queries
        /// against ProductSets containing the image may still work until all related
        /// caches are refreshed.
        /// 
        /// The actual image files are not deleted from Google Cloud Storage.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the reference image to delete.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID/referenceImages/IMAGE_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReferenceImageAsync(ReferenceImageName name, st::CancellationToken cancellationToken) =>
            DeleteReferenceImageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists reference images.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the parent product does not exist.
        /// * Returns INVALID_ARGUMENT if the page_size is greater than 100, or less
        /// than 1.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReferenceImage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReferenceImagesResponse, ReferenceImage> ListReferenceImages(ListReferenceImagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists reference images.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the parent product does not exist.
        /// * Returns INVALID_ARGUMENT if the page_size is greater than 100, or less
        /// than 1.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReferenceImage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReferenceImagesResponse, ReferenceImage> ListReferenceImagesAsync(ListReferenceImagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists reference images.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the parent product does not exist.
        /// * Returns INVALID_ARGUMENT if the page_size is greater than 100, or less
        /// than 1.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the product containing the reference images.
        /// 
        /// Format is
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`.
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
        /// <returns>A pageable sequence of <see cref="ReferenceImage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReferenceImagesResponse, ReferenceImage> ListReferenceImages(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReferenceImagesRequest request = new ListReferenceImagesRequest
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
            return ListReferenceImages(request, callSettings);
        }

        /// <summary>
        /// Lists reference images.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the parent product does not exist.
        /// * Returns INVALID_ARGUMENT if the page_size is greater than 100, or less
        /// than 1.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the product containing the reference images.
        /// 
        /// Format is
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReferenceImage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReferenceImagesResponse, ReferenceImage> ListReferenceImagesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReferenceImagesRequest request = new ListReferenceImagesRequest
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
            return ListReferenceImagesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists reference images.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the parent product does not exist.
        /// * Returns INVALID_ARGUMENT if the page_size is greater than 100, or less
        /// than 1.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the product containing the reference images.
        /// 
        /// Format is
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`.
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
        /// <returns>A pageable sequence of <see cref="ReferenceImage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReferenceImagesResponse, ReferenceImage> ListReferenceImages(ProductName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReferenceImagesRequest request = new ListReferenceImagesRequest
            {
                ParentAsProductName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListReferenceImages(request, callSettings);
        }

        /// <summary>
        /// Lists reference images.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the parent product does not exist.
        /// * Returns INVALID_ARGUMENT if the page_size is greater than 100, or less
        /// than 1.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the product containing the reference images.
        /// 
        /// Format is
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReferenceImage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReferenceImagesResponse, ReferenceImage> ListReferenceImagesAsync(ProductName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReferenceImagesRequest request = new ListReferenceImagesRequest
            {
                ParentAsProductName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListReferenceImagesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets information associated with a ReferenceImage.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the specified image does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReferenceImage GetReferenceImage(GetReferenceImageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information associated with a ReferenceImage.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the specified image does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceImage> GetReferenceImageAsync(GetReferenceImageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information associated with a ReferenceImage.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the specified image does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceImage> GetReferenceImageAsync(GetReferenceImageRequest request, st::CancellationToken cancellationToken) =>
            GetReferenceImageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information associated with a ReferenceImage.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the specified image does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ReferenceImage to get.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID/referenceImages/IMAGE_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReferenceImage GetReferenceImage(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReferenceImage(new GetReferenceImageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information associated with a ReferenceImage.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the specified image does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ReferenceImage to get.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID/referenceImages/IMAGE_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceImage> GetReferenceImageAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReferenceImageAsync(new GetReferenceImageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information associated with a ReferenceImage.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the specified image does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ReferenceImage to get.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID/referenceImages/IMAGE_ID`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceImage> GetReferenceImageAsync(string name, st::CancellationToken cancellationToken) =>
            GetReferenceImageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information associated with a ReferenceImage.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the specified image does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ReferenceImage to get.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID/referenceImages/IMAGE_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReferenceImage GetReferenceImage(ReferenceImageName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReferenceImage(new GetReferenceImageRequest
            {
                ReferenceImageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information associated with a ReferenceImage.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the specified image does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ReferenceImage to get.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID/referenceImages/IMAGE_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceImage> GetReferenceImageAsync(ReferenceImageName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReferenceImageAsync(new GetReferenceImageRequest
            {
                ReferenceImageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information associated with a ReferenceImage.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the specified image does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ReferenceImage to get.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID/referenceImages/IMAGE_ID`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReferenceImage> GetReferenceImageAsync(ReferenceImageName name, st::CancellationToken cancellationToken) =>
            GetReferenceImageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void AddProductToProductSet(AddProductToProductSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task AddProductToProductSetAsync(AddProductToProductSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task AddProductToProductSetAsync(AddProductToProductSetRequest request, st::CancellationToken cancellationToken) =>
            AddProductToProductSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// Required. The resource name for the ProductSet to modify.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="product">
        /// Required. The resource name for the Product to be added to this ProductSet.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void AddProductToProductSet(string name, string product, gaxgrpc::CallSettings callSettings = null) =>
            AddProductToProductSet(new AddProductToProductSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Product = gax::GaxPreconditions.CheckNotNullOrEmpty(product, nameof(product)),
            }, callSettings);

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
        /// Required. The resource name for the ProductSet to modify.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="product">
        /// Required. The resource name for the Product to be added to this ProductSet.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task AddProductToProductSetAsync(string name, string product, gaxgrpc::CallSettings callSettings = null) =>
            AddProductToProductSetAsync(new AddProductToProductSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Product = gax::GaxPreconditions.CheckNotNullOrEmpty(product, nameof(product)),
            }, callSettings);

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
        /// Required. The resource name for the ProductSet to modify.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="product">
        /// Required. The resource name for the Product to be added to this ProductSet.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task AddProductToProductSetAsync(string name, string product, st::CancellationToken cancellationToken) =>
            AddProductToProductSetAsync(name, product, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// Required. The resource name for the ProductSet to modify.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="product">
        /// Required. The resource name for the Product to be added to this ProductSet.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void AddProductToProductSet(ProductSetName name, ProductName product, gaxgrpc::CallSettings callSettings = null) =>
            AddProductToProductSet(new AddProductToProductSetRequest
            {
                ProductSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ProductAsProductName = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
            }, callSettings);

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
        /// Required. The resource name for the ProductSet to modify.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="product">
        /// Required. The resource name for the Product to be added to this ProductSet.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task AddProductToProductSetAsync(ProductSetName name, ProductName product, gaxgrpc::CallSettings callSettings = null) =>
            AddProductToProductSetAsync(new AddProductToProductSetRequest
            {
                ProductSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ProductAsProductName = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
            }, callSettings);

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
        /// Required. The resource name for the ProductSet to modify.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="product">
        /// Required. The resource name for the Product to be added to this ProductSet.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task AddProductToProductSetAsync(ProductSetName name, ProductName product, st::CancellationToken cancellationToken) =>
            AddProductToProductSetAsync(name, product, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a Product from the specified ProductSet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void RemoveProductFromProductSet(RemoveProductFromProductSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a Product from the specified ProductSet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RemoveProductFromProductSetAsync(RemoveProductFromProductSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a Product from the specified ProductSet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RemoveProductFromProductSetAsync(RemoveProductFromProductSetRequest request, st::CancellationToken cancellationToken) =>
            RemoveProductFromProductSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a Product from the specified ProductSet.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for the ProductSet to modify.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="product">
        /// Required. The resource name for the Product to be removed from this
        /// ProductSet.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void RemoveProductFromProductSet(string name, string product, gaxgrpc::CallSettings callSettings = null) =>
            RemoveProductFromProductSet(new RemoveProductFromProductSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Product = gax::GaxPreconditions.CheckNotNullOrEmpty(product, nameof(product)),
            }, callSettings);

        /// <summary>
        /// Removes a Product from the specified ProductSet.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for the ProductSet to modify.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="product">
        /// Required. The resource name for the Product to be removed from this
        /// ProductSet.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RemoveProductFromProductSetAsync(string name, string product, gaxgrpc::CallSettings callSettings = null) =>
            RemoveProductFromProductSetAsync(new RemoveProductFromProductSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Product = gax::GaxPreconditions.CheckNotNullOrEmpty(product, nameof(product)),
            }, callSettings);

        /// <summary>
        /// Removes a Product from the specified ProductSet.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for the ProductSet to modify.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="product">
        /// Required. The resource name for the Product to be removed from this
        /// ProductSet.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RemoveProductFromProductSetAsync(string name, string product, st::CancellationToken cancellationToken) =>
            RemoveProductFromProductSetAsync(name, product, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a Product from the specified ProductSet.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for the ProductSet to modify.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="product">
        /// Required. The resource name for the Product to be removed from this
        /// ProductSet.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void RemoveProductFromProductSet(ProductSetName name, ProductName product, gaxgrpc::CallSettings callSettings = null) =>
            RemoveProductFromProductSet(new RemoveProductFromProductSetRequest
            {
                ProductSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ProductAsProductName = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
            }, callSettings);

        /// <summary>
        /// Removes a Product from the specified ProductSet.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for the ProductSet to modify.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="product">
        /// Required. The resource name for the Product to be removed from this
        /// ProductSet.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RemoveProductFromProductSetAsync(ProductSetName name, ProductName product, gaxgrpc::CallSettings callSettings = null) =>
            RemoveProductFromProductSetAsync(new RemoveProductFromProductSetRequest
            {
                ProductSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ProductAsProductName = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
            }, callSettings);

        /// <summary>
        /// Removes a Product from the specified ProductSet.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for the ProductSet to modify.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
        /// </param>
        /// <param name="product">
        /// Required. The resource name for the Product to be removed from this
        /// ProductSet.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/products/PRODUCT_ID`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RemoveProductFromProductSetAsync(ProductSetName name, ProductName product, st::CancellationToken cancellationToken) =>
            RemoveProductFromProductSetAsync(name, product, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the Products in a ProductSet, in an unspecified order. If the
        /// ProductSet does not exist, the products field of the response will be
        /// empty.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100 or less than 1.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProductsInProductSetResponse, Product> ListProductsInProductSet(ListProductsInProductSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Products in a ProductSet, in an unspecified order. If the
        /// ProductSet does not exist, the products field of the response will be
        /// empty.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100 or less than 1.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProductsInProductSetResponse, Product> ListProductsInProductSetAsync(ListProductsInProductSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

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
        /// Required. The ProductSet resource for which to retrieve Products.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
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
        /// <returns>A pageable sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProductsInProductSetResponse, Product> ListProductsInProductSet(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductsInProductSetRequest request = new ListProductsInProductSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListProductsInProductSet(request, callSettings);
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
        /// Required. The ProductSet resource for which to retrieve Products.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProductsInProductSetResponse, Product> ListProductsInProductSetAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductsInProductSetRequest request = new ListProductsInProductSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListProductsInProductSetAsync(request, callSettings);
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
        /// Required. The ProductSet resource for which to retrieve Products.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
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
        /// <returns>A pageable sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProductsInProductSetResponse, Product> ListProductsInProductSet(ProductSetName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductsInProductSetRequest request = new ListProductsInProductSetRequest
            {
                ProductSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListProductsInProductSet(request, callSettings);
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
        /// Required. The ProductSet resource for which to retrieve Products.
        /// 
        /// Format is:
        /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProductsInProductSetResponse, Product> ListProductsInProductSetAsync(ProductSetName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductsInProductSetRequest request = new ListProductsInProductSetRequest
            {
                ProductSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListProductsInProductSetAsync(request, callSettings);
        }

        /// <summary>
        /// Asynchronous API that imports a list of reference images to specified
        /// product sets based on a list of image information.
        /// 
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be
        /// used to keep track of the progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// `Operation.response` contains `ImportProductSetsResponse`. (results)
        /// 
        /// The input source of this method is a csv file on Google Cloud Storage.
        /// For the format of the csv file please see
        /// [ImportProductSetsGcsSource.csv_file_uri][google.cloud.vision.v1.ImportProductSetsGcsSource.csv_file_uri].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportProductSetsResponse, BatchOperationMetadata> ImportProductSets(ImportProductSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Asynchronous API that imports a list of reference images to specified
        /// product sets based on a list of image information.
        /// 
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be
        /// used to keep track of the progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// `Operation.response` contains `ImportProductSetsResponse`. (results)
        /// 
        /// The input source of this method is a csv file on Google Cloud Storage.
        /// For the format of the csv file please see
        /// [ImportProductSetsGcsSource.csv_file_uri][google.cloud.vision.v1.ImportProductSetsGcsSource.csv_file_uri].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportProductSetsResponse, BatchOperationMetadata>> ImportProductSetsAsync(ImportProductSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Asynchronous API that imports a list of reference images to specified
        /// product sets based on a list of image information.
        /// 
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be
        /// used to keep track of the progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// `Operation.response` contains `ImportProductSetsResponse`. (results)
        /// 
        /// The input source of this method is a csv file on Google Cloud Storage.
        /// For the format of the csv file please see
        /// [ImportProductSetsGcsSource.csv_file_uri][google.cloud.vision.v1.ImportProductSetsGcsSource.csv_file_uri].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportProductSetsResponse, BatchOperationMetadata>> ImportProductSetsAsync(ImportProductSetsRequest request, st::CancellationToken cancellationToken) =>
            ImportProductSetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportProductSets</c>.</summary>
        public virtual lro::OperationsClient ImportProductSetsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportProductSets</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportProductSetsResponse, BatchOperationMetadata> PollOnceImportProductSets(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportProductSetsResponse, BatchOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportProductSetsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportProductSets</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportProductSetsResponse, BatchOperationMetadata>> PollOnceImportProductSetsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportProductSetsResponse, BatchOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportProductSetsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronous API that imports a list of reference images to specified
        /// product sets based on a list of image information.
        /// 
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be
        /// used to keep track of the progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// `Operation.response` contains `ImportProductSetsResponse`. (results)
        /// 
        /// The input source of this method is a csv file on Google Cloud Storage.
        /// For the format of the csv file please see
        /// [ImportProductSetsGcsSource.csv_file_uri][google.cloud.vision.v1.ImportProductSetsGcsSource.csv_file_uri].
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the ProductSets should be imported.
        /// 
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The input content for the list of requests.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportProductSetsResponse, BatchOperationMetadata> ImportProductSets(string parent, ImportProductSetsInputConfig inputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportProductSets(new ImportProductSetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
            }, callSettings);

        /// <summary>
        /// Asynchronous API that imports a list of reference images to specified
        /// product sets based on a list of image information.
        /// 
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be
        /// used to keep track of the progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// `Operation.response` contains `ImportProductSetsResponse`. (results)
        /// 
        /// The input source of this method is a csv file on Google Cloud Storage.
        /// For the format of the csv file please see
        /// [ImportProductSetsGcsSource.csv_file_uri][google.cloud.vision.v1.ImportProductSetsGcsSource.csv_file_uri].
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the ProductSets should be imported.
        /// 
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The input content for the list of requests.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportProductSetsResponse, BatchOperationMetadata>> ImportProductSetsAsync(string parent, ImportProductSetsInputConfig inputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportProductSetsAsync(new ImportProductSetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
            }, callSettings);

        /// <summary>
        /// Asynchronous API that imports a list of reference images to specified
        /// product sets based on a list of image information.
        /// 
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be
        /// used to keep track of the progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// `Operation.response` contains `ImportProductSetsResponse`. (results)
        /// 
        /// The input source of this method is a csv file on Google Cloud Storage.
        /// For the format of the csv file please see
        /// [ImportProductSetsGcsSource.csv_file_uri][google.cloud.vision.v1.ImportProductSetsGcsSource.csv_file_uri].
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the ProductSets should be imported.
        /// 
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The input content for the list of requests.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportProductSetsResponse, BatchOperationMetadata>> ImportProductSetsAsync(string parent, ImportProductSetsInputConfig inputConfig, st::CancellationToken cancellationToken) =>
            ImportProductSetsAsync(parent, inputConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Asynchronous API that imports a list of reference images to specified
        /// product sets based on a list of image information.
        /// 
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be
        /// used to keep track of the progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// `Operation.response` contains `ImportProductSetsResponse`. (results)
        /// 
        /// The input source of this method is a csv file on Google Cloud Storage.
        /// For the format of the csv file please see
        /// [ImportProductSetsGcsSource.csv_file_uri][google.cloud.vision.v1.ImportProductSetsGcsSource.csv_file_uri].
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the ProductSets should be imported.
        /// 
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The input content for the list of requests.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportProductSetsResponse, BatchOperationMetadata> ImportProductSets(gagr::LocationName parent, ImportProductSetsInputConfig inputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportProductSets(new ImportProductSetsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
            }, callSettings);

        /// <summary>
        /// Asynchronous API that imports a list of reference images to specified
        /// product sets based on a list of image information.
        /// 
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be
        /// used to keep track of the progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// `Operation.response` contains `ImportProductSetsResponse`. (results)
        /// 
        /// The input source of this method is a csv file on Google Cloud Storage.
        /// For the format of the csv file please see
        /// [ImportProductSetsGcsSource.csv_file_uri][google.cloud.vision.v1.ImportProductSetsGcsSource.csv_file_uri].
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the ProductSets should be imported.
        /// 
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The input content for the list of requests.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportProductSetsResponse, BatchOperationMetadata>> ImportProductSetsAsync(gagr::LocationName parent, ImportProductSetsInputConfig inputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportProductSetsAsync(new ImportProductSetsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
            }, callSettings);

        /// <summary>
        /// Asynchronous API that imports a list of reference images to specified
        /// product sets based on a list of image information.
        /// 
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be
        /// used to keep track of the progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// `Operation.response` contains `ImportProductSetsResponse`. (results)
        /// 
        /// The input source of this method is a csv file on Google Cloud Storage.
        /// For the format of the csv file please see
        /// [ImportProductSetsGcsSource.csv_file_uri][google.cloud.vision.v1.ImportProductSetsGcsSource.csv_file_uri].
        /// </summary>
        /// <param name="parent">
        /// Required. The project in which the ProductSets should be imported.
        /// 
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The input content for the list of requests.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportProductSetsResponse, BatchOperationMetadata>> ImportProductSetsAsync(gagr::LocationName parent, ImportProductSetsInputConfig inputConfig, st::CancellationToken cancellationToken) =>
            ImportProductSetsAsync(parent, inputConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Asynchronous API to delete all Products in a ProductSet or all Products
        /// that are in no ProductSet.
        /// 
        /// If a Product is a member of the specified ProductSet in addition to other
        /// ProductSets, the Product will still be deleted.
        /// 
        /// It is recommended to not delete the specified ProductSet until after this
        /// operation has completed. It is also recommended to not add any of the
        /// Products involved in the batch delete to a new ProductSet while this
        /// operation is running because those Products may still end up deleted.
        /// 
        /// It's not possible to undo the PurgeProducts operation. Therefore, it is
        /// recommended to keep the csv files used in ImportProductSets (if that was
        /// how you originally built the Product Set) before starting PurgeProducts, in
        /// case you need to re-import the data after deletion.
        /// 
        /// If the plan is to purge all of the Products from a ProductSet and then
        /// re-use the empty ProductSet to re-import new Products into the empty
        /// ProductSet, you must wait until the PurgeProducts operation has finished
        /// for that ProductSet.
        /// 
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be
        /// used to keep track of the progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, BatchOperationMetadata> PurgeProducts(PurgeProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Asynchronous API to delete all Products in a ProductSet or all Products
        /// that are in no ProductSet.
        /// 
        /// If a Product is a member of the specified ProductSet in addition to other
        /// ProductSets, the Product will still be deleted.
        /// 
        /// It is recommended to not delete the specified ProductSet until after this
        /// operation has completed. It is also recommended to not add any of the
        /// Products involved in the batch delete to a new ProductSet while this
        /// operation is running because those Products may still end up deleted.
        /// 
        /// It's not possible to undo the PurgeProducts operation. Therefore, it is
        /// recommended to keep the csv files used in ImportProductSets (if that was
        /// how you originally built the Product Set) before starting PurgeProducts, in
        /// case you need to re-import the data after deletion.
        /// 
        /// If the plan is to purge all of the Products from a ProductSet and then
        /// re-use the empty ProductSet to re-import new Products into the empty
        /// ProductSet, you must wait until the PurgeProducts operation has finished
        /// for that ProductSet.
        /// 
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be
        /// used to keep track of the progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, BatchOperationMetadata>> PurgeProductsAsync(PurgeProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Asynchronous API to delete all Products in a ProductSet or all Products
        /// that are in no ProductSet.
        /// 
        /// If a Product is a member of the specified ProductSet in addition to other
        /// ProductSets, the Product will still be deleted.
        /// 
        /// It is recommended to not delete the specified ProductSet until after this
        /// operation has completed. It is also recommended to not add any of the
        /// Products involved in the batch delete to a new ProductSet while this
        /// operation is running because those Products may still end up deleted.
        /// 
        /// It's not possible to undo the PurgeProducts operation. Therefore, it is
        /// recommended to keep the csv files used in ImportProductSets (if that was
        /// how you originally built the Product Set) before starting PurgeProducts, in
        /// case you need to re-import the data after deletion.
        /// 
        /// If the plan is to purge all of the Products from a ProductSet and then
        /// re-use the empty ProductSet to re-import new Products into the empty
        /// ProductSet, you must wait until the PurgeProducts operation has finished
        /// for that ProductSet.
        /// 
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be
        /// used to keep track of the progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, BatchOperationMetadata>> PurgeProductsAsync(PurgeProductsRequest request, st::CancellationToken cancellationToken) =>
            PurgeProductsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>PurgeProducts</c>.</summary>
        public virtual lro::OperationsClient PurgeProductsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PurgeProducts</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, BatchOperationMetadata> PollOncePurgeProducts(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, BatchOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PurgeProductsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PurgeProducts</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, BatchOperationMetadata>> PollOncePurgeProductsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, BatchOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PurgeProductsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronous API to delete all Products in a ProductSet or all Products
        /// that are in no ProductSet.
        /// 
        /// If a Product is a member of the specified ProductSet in addition to other
        /// ProductSets, the Product will still be deleted.
        /// 
        /// It is recommended to not delete the specified ProductSet until after this
        /// operation has completed. It is also recommended to not add any of the
        /// Products involved in the batch delete to a new ProductSet while this
        /// operation is running because those Products may still end up deleted.
        /// 
        /// It's not possible to undo the PurgeProducts operation. Therefore, it is
        /// recommended to keep the csv files used in ImportProductSets (if that was
        /// how you originally built the Product Set) before starting PurgeProducts, in
        /// case you need to re-import the data after deletion.
        /// 
        /// If the plan is to purge all of the Products from a ProductSet and then
        /// re-use the empty ProductSet to re-import new Products into the empty
        /// ProductSet, you must wait until the PurgeProducts operation has finished
        /// for that ProductSet.
        /// 
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be
        /// used to keep track of the progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the Products should be deleted.
        /// 
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, BatchOperationMetadata> PurgeProducts(string parent, gaxgrpc::CallSettings callSettings = null) =>
            PurgeProducts(new PurgeProductsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Asynchronous API to delete all Products in a ProductSet or all Products
        /// that are in no ProductSet.
        /// 
        /// If a Product is a member of the specified ProductSet in addition to other
        /// ProductSets, the Product will still be deleted.
        /// 
        /// It is recommended to not delete the specified ProductSet until after this
        /// operation has completed. It is also recommended to not add any of the
        /// Products involved in the batch delete to a new ProductSet while this
        /// operation is running because those Products may still end up deleted.
        /// 
        /// It's not possible to undo the PurgeProducts operation. Therefore, it is
        /// recommended to keep the csv files used in ImportProductSets (if that was
        /// how you originally built the Product Set) before starting PurgeProducts, in
        /// case you need to re-import the data after deletion.
        /// 
        /// If the plan is to purge all of the Products from a ProductSet and then
        /// re-use the empty ProductSet to re-import new Products into the empty
        /// ProductSet, you must wait until the PurgeProducts operation has finished
        /// for that ProductSet.
        /// 
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be
        /// used to keep track of the progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the Products should be deleted.
        /// 
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, BatchOperationMetadata>> PurgeProductsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            PurgeProductsAsync(new PurgeProductsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Asynchronous API to delete all Products in a ProductSet or all Products
        /// that are in no ProductSet.
        /// 
        /// If a Product is a member of the specified ProductSet in addition to other
        /// ProductSets, the Product will still be deleted.
        /// 
        /// It is recommended to not delete the specified ProductSet until after this
        /// operation has completed. It is also recommended to not add any of the
        /// Products involved in the batch delete to a new ProductSet while this
        /// operation is running because those Products may still end up deleted.
        /// 
        /// It's not possible to undo the PurgeProducts operation. Therefore, it is
        /// recommended to keep the csv files used in ImportProductSets (if that was
        /// how you originally built the Product Set) before starting PurgeProducts, in
        /// case you need to re-import the data after deletion.
        /// 
        /// If the plan is to purge all of the Products from a ProductSet and then
        /// re-use the empty ProductSet to re-import new Products into the empty
        /// ProductSet, you must wait until the PurgeProducts operation has finished
        /// for that ProductSet.
        /// 
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be
        /// used to keep track of the progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the Products should be deleted.
        /// 
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, BatchOperationMetadata>> PurgeProductsAsync(string parent, st::CancellationToken cancellationToken) =>
            PurgeProductsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Asynchronous API to delete all Products in a ProductSet or all Products
        /// that are in no ProductSet.
        /// 
        /// If a Product is a member of the specified ProductSet in addition to other
        /// ProductSets, the Product will still be deleted.
        /// 
        /// It is recommended to not delete the specified ProductSet until after this
        /// operation has completed. It is also recommended to not add any of the
        /// Products involved in the batch delete to a new ProductSet while this
        /// operation is running because those Products may still end up deleted.
        /// 
        /// It's not possible to undo the PurgeProducts operation. Therefore, it is
        /// recommended to keep the csv files used in ImportProductSets (if that was
        /// how you originally built the Product Set) before starting PurgeProducts, in
        /// case you need to re-import the data after deletion.
        /// 
        /// If the plan is to purge all of the Products from a ProductSet and then
        /// re-use the empty ProductSet to re-import new Products into the empty
        /// ProductSet, you must wait until the PurgeProducts operation has finished
        /// for that ProductSet.
        /// 
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be
        /// used to keep track of the progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the Products should be deleted.
        /// 
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, BatchOperationMetadata> PurgeProducts(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            PurgeProducts(new PurgeProductsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Asynchronous API to delete all Products in a ProductSet or all Products
        /// that are in no ProductSet.
        /// 
        /// If a Product is a member of the specified ProductSet in addition to other
        /// ProductSets, the Product will still be deleted.
        /// 
        /// It is recommended to not delete the specified ProductSet until after this
        /// operation has completed. It is also recommended to not add any of the
        /// Products involved in the batch delete to a new ProductSet while this
        /// operation is running because those Products may still end up deleted.
        /// 
        /// It's not possible to undo the PurgeProducts operation. Therefore, it is
        /// recommended to keep the csv files used in ImportProductSets (if that was
        /// how you originally built the Product Set) before starting PurgeProducts, in
        /// case you need to re-import the data after deletion.
        /// 
        /// If the plan is to purge all of the Products from a ProductSet and then
        /// re-use the empty ProductSet to re-import new Products into the empty
        /// ProductSet, you must wait until the PurgeProducts operation has finished
        /// for that ProductSet.
        /// 
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be
        /// used to keep track of the progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the Products should be deleted.
        /// 
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, BatchOperationMetadata>> PurgeProductsAsync(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            PurgeProductsAsync(new PurgeProductsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Asynchronous API to delete all Products in a ProductSet or all Products
        /// that are in no ProductSet.
        /// 
        /// If a Product is a member of the specified ProductSet in addition to other
        /// ProductSets, the Product will still be deleted.
        /// 
        /// It is recommended to not delete the specified ProductSet until after this
        /// operation has completed. It is also recommended to not add any of the
        /// Products involved in the batch delete to a new ProductSet while this
        /// operation is running because those Products may still end up deleted.
        /// 
        /// It's not possible to undo the PurgeProducts operation. Therefore, it is
        /// recommended to keep the csv files used in ImportProductSets (if that was
        /// how you originally built the Product Set) before starting PurgeProducts, in
        /// case you need to re-import the data after deletion.
        /// 
        /// If the plan is to purge all of the Products from a ProductSet and then
        /// re-use the empty ProductSet to re-import new Products into the empty
        /// ProductSet, you must wait until the PurgeProducts operation has finished
        /// for that ProductSet.
        /// 
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be
        /// used to keep track of the progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the Products should be deleted.
        /// 
        /// Format is `projects/PROJECT_ID/locations/LOC_ID`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, BatchOperationMetadata>> PurgeProductsAsync(gagr::LocationName parent, st::CancellationToken cancellationToken) =>
            PurgeProductsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ProductSearch client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages Products and ProductSets of reference images for use in product
    /// search. It uses the following resource model:
    /// 
    /// - The API has a collection of [ProductSet][google.cloud.vision.v1.ProductSet]
    /// resources, named `projects/*/locations/*/productSets/*`, which acts as a way
    /// to put different products into groups to limit identification.
    /// 
    /// In parallel,
    /// 
    /// - The API has a collection of [Product][google.cloud.vision.v1.Product]
    /// resources, named
    /// `projects/*/locations/*/products/*`
    /// 
    /// - Each [Product][google.cloud.vision.v1.Product] has a collection of
    /// [ReferenceImage][google.cloud.vision.v1.ReferenceImage] resources, named
    /// `projects/*/locations/*/products/*/referenceImages/*`
    /// </remarks>
    public sealed partial class ProductSearchClientImpl : ProductSearchClient
    {
        private readonly gaxgrpc::ApiCall<CreateProductSetRequest, ProductSet> _callCreateProductSet;

        private readonly gaxgrpc::ApiCall<ListProductSetsRequest, ListProductSetsResponse> _callListProductSets;

        private readonly gaxgrpc::ApiCall<GetProductSetRequest, ProductSet> _callGetProductSet;

        private readonly gaxgrpc::ApiCall<UpdateProductSetRequest, ProductSet> _callUpdateProductSet;

        private readonly gaxgrpc::ApiCall<DeleteProductSetRequest, wkt::Empty> _callDeleteProductSet;

        private readonly gaxgrpc::ApiCall<CreateProductRequest, Product> _callCreateProduct;

        private readonly gaxgrpc::ApiCall<ListProductsRequest, ListProductsResponse> _callListProducts;

        private readonly gaxgrpc::ApiCall<GetProductRequest, Product> _callGetProduct;

        private readonly gaxgrpc::ApiCall<UpdateProductRequest, Product> _callUpdateProduct;

        private readonly gaxgrpc::ApiCall<DeleteProductRequest, wkt::Empty> _callDeleteProduct;

        private readonly gaxgrpc::ApiCall<CreateReferenceImageRequest, ReferenceImage> _callCreateReferenceImage;

        private readonly gaxgrpc::ApiCall<DeleteReferenceImageRequest, wkt::Empty> _callDeleteReferenceImage;

        private readonly gaxgrpc::ApiCall<ListReferenceImagesRequest, ListReferenceImagesResponse> _callListReferenceImages;

        private readonly gaxgrpc::ApiCall<GetReferenceImageRequest, ReferenceImage> _callGetReferenceImage;

        private readonly gaxgrpc::ApiCall<AddProductToProductSetRequest, wkt::Empty> _callAddProductToProductSet;

        private readonly gaxgrpc::ApiCall<RemoveProductFromProductSetRequest, wkt::Empty> _callRemoveProductFromProductSet;

        private readonly gaxgrpc::ApiCall<ListProductsInProductSetRequest, ListProductsInProductSetResponse> _callListProductsInProductSet;

        private readonly gaxgrpc::ApiCall<ImportProductSetsRequest, lro::Operation> _callImportProductSets;

        private readonly gaxgrpc::ApiCall<PurgeProductsRequest, lro::Operation> _callPurgeProducts;

        /// <summary>
        /// Constructs a client wrapper for the ProductSearch service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ProductSearchSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ProductSearchClientImpl(ProductSearch.ProductSearchClient grpcClient, ProductSearchSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ProductSearchSettings effectiveSettings = settings ?? ProductSearchSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            ImportProductSetsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportProductSetsOperationsSettings, logger);
            PurgeProductsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.PurgeProductsOperationsSettings, logger);
            _callCreateProductSet = clientHelper.BuildApiCall<CreateProductSetRequest, ProductSet>("CreateProductSet", grpcClient.CreateProductSetAsync, grpcClient.CreateProductSet, effectiveSettings.CreateProductSetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateProductSet);
            Modify_CreateProductSetApiCall(ref _callCreateProductSet);
            _callListProductSets = clientHelper.BuildApiCall<ListProductSetsRequest, ListProductSetsResponse>("ListProductSets", grpcClient.ListProductSetsAsync, grpcClient.ListProductSets, effectiveSettings.ListProductSetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListProductSets);
            Modify_ListProductSetsApiCall(ref _callListProductSets);
            _callGetProductSet = clientHelper.BuildApiCall<GetProductSetRequest, ProductSet>("GetProductSet", grpcClient.GetProductSetAsync, grpcClient.GetProductSet, effectiveSettings.GetProductSetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProductSet);
            Modify_GetProductSetApiCall(ref _callGetProductSet);
            _callUpdateProductSet = clientHelper.BuildApiCall<UpdateProductSetRequest, ProductSet>("UpdateProductSet", grpcClient.UpdateProductSetAsync, grpcClient.UpdateProductSet, effectiveSettings.UpdateProductSetSettings).WithGoogleRequestParam("product_set.name", request => request.ProductSet?.Name);
            Modify_ApiCall(ref _callUpdateProductSet);
            Modify_UpdateProductSetApiCall(ref _callUpdateProductSet);
            _callDeleteProductSet = clientHelper.BuildApiCall<DeleteProductSetRequest, wkt::Empty>("DeleteProductSet", grpcClient.DeleteProductSetAsync, grpcClient.DeleteProductSet, effectiveSettings.DeleteProductSetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteProductSet);
            Modify_DeleteProductSetApiCall(ref _callDeleteProductSet);
            _callCreateProduct = clientHelper.BuildApiCall<CreateProductRequest, Product>("CreateProduct", grpcClient.CreateProductAsync, grpcClient.CreateProduct, effectiveSettings.CreateProductSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateProduct);
            Modify_CreateProductApiCall(ref _callCreateProduct);
            _callListProducts = clientHelper.BuildApiCall<ListProductsRequest, ListProductsResponse>("ListProducts", grpcClient.ListProductsAsync, grpcClient.ListProducts, effectiveSettings.ListProductsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListProducts);
            Modify_ListProductsApiCall(ref _callListProducts);
            _callGetProduct = clientHelper.BuildApiCall<GetProductRequest, Product>("GetProduct", grpcClient.GetProductAsync, grpcClient.GetProduct, effectiveSettings.GetProductSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProduct);
            Modify_GetProductApiCall(ref _callGetProduct);
            _callUpdateProduct = clientHelper.BuildApiCall<UpdateProductRequest, Product>("UpdateProduct", grpcClient.UpdateProductAsync, grpcClient.UpdateProduct, effectiveSettings.UpdateProductSettings).WithGoogleRequestParam("product.name", request => request.Product?.Name);
            Modify_ApiCall(ref _callUpdateProduct);
            Modify_UpdateProductApiCall(ref _callUpdateProduct);
            _callDeleteProduct = clientHelper.BuildApiCall<DeleteProductRequest, wkt::Empty>("DeleteProduct", grpcClient.DeleteProductAsync, grpcClient.DeleteProduct, effectiveSettings.DeleteProductSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteProduct);
            Modify_DeleteProductApiCall(ref _callDeleteProduct);
            _callCreateReferenceImage = clientHelper.BuildApiCall<CreateReferenceImageRequest, ReferenceImage>("CreateReferenceImage", grpcClient.CreateReferenceImageAsync, grpcClient.CreateReferenceImage, effectiveSettings.CreateReferenceImageSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateReferenceImage);
            Modify_CreateReferenceImageApiCall(ref _callCreateReferenceImage);
            _callDeleteReferenceImage = clientHelper.BuildApiCall<DeleteReferenceImageRequest, wkt::Empty>("DeleteReferenceImage", grpcClient.DeleteReferenceImageAsync, grpcClient.DeleteReferenceImage, effectiveSettings.DeleteReferenceImageSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteReferenceImage);
            Modify_DeleteReferenceImageApiCall(ref _callDeleteReferenceImage);
            _callListReferenceImages = clientHelper.BuildApiCall<ListReferenceImagesRequest, ListReferenceImagesResponse>("ListReferenceImages", grpcClient.ListReferenceImagesAsync, grpcClient.ListReferenceImages, effectiveSettings.ListReferenceImagesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListReferenceImages);
            Modify_ListReferenceImagesApiCall(ref _callListReferenceImages);
            _callGetReferenceImage = clientHelper.BuildApiCall<GetReferenceImageRequest, ReferenceImage>("GetReferenceImage", grpcClient.GetReferenceImageAsync, grpcClient.GetReferenceImage, effectiveSettings.GetReferenceImageSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetReferenceImage);
            Modify_GetReferenceImageApiCall(ref _callGetReferenceImage);
            _callAddProductToProductSet = clientHelper.BuildApiCall<AddProductToProductSetRequest, wkt::Empty>("AddProductToProductSet", grpcClient.AddProductToProductSetAsync, grpcClient.AddProductToProductSet, effectiveSettings.AddProductToProductSetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callAddProductToProductSet);
            Modify_AddProductToProductSetApiCall(ref _callAddProductToProductSet);
            _callRemoveProductFromProductSet = clientHelper.BuildApiCall<RemoveProductFromProductSetRequest, wkt::Empty>("RemoveProductFromProductSet", grpcClient.RemoveProductFromProductSetAsync, grpcClient.RemoveProductFromProductSet, effectiveSettings.RemoveProductFromProductSetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRemoveProductFromProductSet);
            Modify_RemoveProductFromProductSetApiCall(ref _callRemoveProductFromProductSet);
            _callListProductsInProductSet = clientHelper.BuildApiCall<ListProductsInProductSetRequest, ListProductsInProductSetResponse>("ListProductsInProductSet", grpcClient.ListProductsInProductSetAsync, grpcClient.ListProductsInProductSet, effectiveSettings.ListProductsInProductSetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListProductsInProductSet);
            Modify_ListProductsInProductSetApiCall(ref _callListProductsInProductSet);
            _callImportProductSets = clientHelper.BuildApiCall<ImportProductSetsRequest, lro::Operation>("ImportProductSets", grpcClient.ImportProductSetsAsync, grpcClient.ImportProductSets, effectiveSettings.ImportProductSetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportProductSets);
            Modify_ImportProductSetsApiCall(ref _callImportProductSets);
            _callPurgeProducts = clientHelper.BuildApiCall<PurgeProductsRequest, lro::Operation>("PurgeProducts", grpcClient.PurgeProductsAsync, grpcClient.PurgeProducts, effectiveSettings.PurgeProductsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callPurgeProducts);
            Modify_PurgeProductsApiCall(ref _callPurgeProducts);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateProductSetApiCall(ref gaxgrpc::ApiCall<CreateProductSetRequest, ProductSet> call);

        partial void Modify_ListProductSetsApiCall(ref gaxgrpc::ApiCall<ListProductSetsRequest, ListProductSetsResponse> call);

        partial void Modify_GetProductSetApiCall(ref gaxgrpc::ApiCall<GetProductSetRequest, ProductSet> call);

        partial void Modify_UpdateProductSetApiCall(ref gaxgrpc::ApiCall<UpdateProductSetRequest, ProductSet> call);

        partial void Modify_DeleteProductSetApiCall(ref gaxgrpc::ApiCall<DeleteProductSetRequest, wkt::Empty> call);

        partial void Modify_CreateProductApiCall(ref gaxgrpc::ApiCall<CreateProductRequest, Product> call);

        partial void Modify_ListProductsApiCall(ref gaxgrpc::ApiCall<ListProductsRequest, ListProductsResponse> call);

        partial void Modify_GetProductApiCall(ref gaxgrpc::ApiCall<GetProductRequest, Product> call);

        partial void Modify_UpdateProductApiCall(ref gaxgrpc::ApiCall<UpdateProductRequest, Product> call);

        partial void Modify_DeleteProductApiCall(ref gaxgrpc::ApiCall<DeleteProductRequest, wkt::Empty> call);

        partial void Modify_CreateReferenceImageApiCall(ref gaxgrpc::ApiCall<CreateReferenceImageRequest, ReferenceImage> call);

        partial void Modify_DeleteReferenceImageApiCall(ref gaxgrpc::ApiCall<DeleteReferenceImageRequest, wkt::Empty> call);

        partial void Modify_ListReferenceImagesApiCall(ref gaxgrpc::ApiCall<ListReferenceImagesRequest, ListReferenceImagesResponse> call);

        partial void Modify_GetReferenceImageApiCall(ref gaxgrpc::ApiCall<GetReferenceImageRequest, ReferenceImage> call);

        partial void Modify_AddProductToProductSetApiCall(ref gaxgrpc::ApiCall<AddProductToProductSetRequest, wkt::Empty> call);

        partial void Modify_RemoveProductFromProductSetApiCall(ref gaxgrpc::ApiCall<RemoveProductFromProductSetRequest, wkt::Empty> call);

        partial void Modify_ListProductsInProductSetApiCall(ref gaxgrpc::ApiCall<ListProductsInProductSetRequest, ListProductsInProductSetResponse> call);

        partial void Modify_ImportProductSetsApiCall(ref gaxgrpc::ApiCall<ImportProductSetsRequest, lro::Operation> call);

        partial void Modify_PurgeProductsApiCall(ref gaxgrpc::ApiCall<PurgeProductsRequest, lro::Operation> call);

        partial void OnConstruction(ProductSearch.ProductSearchClient grpcClient, ProductSearchSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ProductSearch client</summary>
        public override ProductSearch.ProductSearchClient GrpcClient { get; }

        partial void Modify_CreateProductSetRequest(ref CreateProductSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProductSetsRequest(ref ListProductSetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetProductSetRequest(ref GetProductSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateProductSetRequest(ref UpdateProductSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteProductSetRequest(ref DeleteProductSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateProductRequest(ref CreateProductRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProductsRequest(ref ListProductsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetProductRequest(ref GetProductRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateProductRequest(ref UpdateProductRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteProductRequest(ref DeleteProductRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateReferenceImageRequest(ref CreateReferenceImageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteReferenceImageRequest(ref DeleteReferenceImageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReferenceImagesRequest(ref ListReferenceImagesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetReferenceImageRequest(ref GetReferenceImageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddProductToProductSetRequest(ref AddProductToProductSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveProductFromProductSetRequest(ref RemoveProductFromProductSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProductsInProductSetRequest(ref ListProductsInProductSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportProductSetsRequest(ref ImportProductSetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PurgeProductsRequest(ref PurgeProductsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates and returns a new ProductSet resource.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if display_name is missing, or is longer than
        /// 4096 characters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProductSet CreateProductSet(CreateProductSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProductSetRequest(ref request, ref callSettings);
            return _callCreateProductSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates and returns a new ProductSet resource.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if display_name is missing, or is longer than
        /// 4096 characters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProductSet> CreateProductSetAsync(CreateProductSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProductSetRequest(ref request, ref callSettings);
            return _callCreateProductSet.Async(request, callSettings);
        }

        /// <summary>
        /// Lists ProductSets in an unspecified order.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100, or less
        /// than 1.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ProductSet"/> resources.</returns>
        public override gax::PagedEnumerable<ListProductSetsResponse, ProductSet> ListProductSets(ListProductSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProductSetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProductSetsRequest, ListProductSetsResponse, ProductSet>(_callListProductSets, request, callSettings);
        }

        /// <summary>
        /// Lists ProductSets in an unspecified order.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100, or less
        /// than 1.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ProductSet"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListProductSetsResponse, ProductSet> ListProductSetsAsync(ListProductSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProductSetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProductSetsRequest, ListProductSetsResponse, ProductSet>(_callListProductSets, request, callSettings);
        }

        /// <summary>
        /// Gets information associated with a ProductSet.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProductSet GetProductSet(GetProductSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProductSetRequest(ref request, ref callSettings);
            return _callGetProductSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information associated with a ProductSet.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProductSet> GetProductSetAsync(GetProductSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProductSetRequest(ref request, ref callSettings);
            return _callGetProductSet.Async(request, callSettings);
        }

        /// <summary>
        /// Makes changes to a ProductSet resource.
        /// Only display_name can be updated currently.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// * Returns INVALID_ARGUMENT if display_name is present in update_mask but
        /// missing from the request or longer than 4096 characters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProductSet UpdateProductSet(UpdateProductSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProductSetRequest(ref request, ref callSettings);
            return _callUpdateProductSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Makes changes to a ProductSet resource.
        /// Only display_name can be updated currently.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the ProductSet does not exist.
        /// * Returns INVALID_ARGUMENT if display_name is present in update_mask but
        /// missing from the request or longer than 4096 characters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProductSet> UpdateProductSetAsync(UpdateProductSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProductSetRequest(ref request, ref callSettings);
            return _callUpdateProductSet.Async(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes a ProductSet. Products and ReferenceImages in the
        /// ProductSet are not deleted.
        /// 
        /// The actual image files are not deleted from Google Cloud Storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteProductSet(DeleteProductSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProductSetRequest(ref request, ref callSettings);
            _callDeleteProductSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes a ProductSet. Products and ReferenceImages in the
        /// ProductSet are not deleted.
        /// 
        /// The actual image files are not deleted from Google Cloud Storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteProductSetAsync(DeleteProductSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProductSetRequest(ref request, ref callSettings);
            return _callDeleteProductSet.Async(request, callSettings);
        }

        /// <summary>
        /// Creates and returns a new product resource.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if display_name is missing or longer than 4096
        /// characters.
        /// * Returns INVALID_ARGUMENT if description is longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is missing or invalid.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Product CreateProduct(CreateProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProductRequest(ref request, ref callSettings);
            return _callCreateProduct.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates and returns a new product resource.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if display_name is missing or longer than 4096
        /// characters.
        /// * Returns INVALID_ARGUMENT if description is longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is missing or invalid.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Product> CreateProductAsync(CreateProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProductRequest(ref request, ref callSettings);
            return _callCreateProduct.Async(request, callSettings);
        }

        /// <summary>
        /// Lists products in an unspecified order.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100 or less than 1.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Product"/> resources.</returns>
        public override gax::PagedEnumerable<ListProductsResponse, Product> ListProducts(ListProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProductsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProductsRequest, ListProductsResponse, Product>(_callListProducts, request, callSettings);
        }

        /// <summary>
        /// Lists products in an unspecified order.
        /// 
        /// Possible errors:
        /// 
        /// * Returns INVALID_ARGUMENT if page_size is greater than 100 or less than 1.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Product"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListProductsResponse, Product> ListProductsAsync(ListProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProductsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProductsRequest, ListProductsResponse, Product>(_callListProducts, request, callSettings);
        }

        /// <summary>
        /// Gets information associated with a Product.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the Product does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Product GetProduct(GetProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProductRequest(ref request, ref callSettings);
            return _callGetProduct.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information associated with a Product.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the Product does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Product> GetProductAsync(GetProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProductRequest(ref request, ref callSettings);
            return _callGetProduct.Async(request, callSettings);
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
        /// missing from the request or longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if description is present in update_mask but is
        /// longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is present in update_mask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Product UpdateProduct(UpdateProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProductRequest(ref request, ref callSettings);
            return _callUpdateProduct.Sync(request, callSettings);
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
        /// missing from the request or longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if description is present in update_mask but is
        /// longer than 4096 characters.
        /// * Returns INVALID_ARGUMENT if product_category is present in update_mask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Product> UpdateProductAsync(UpdateProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProductRequest(ref request, ref callSettings);
            return _callUpdateProduct.Async(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes a product and its reference images.
        /// 
        /// Metadata of the product and all its images will be deleted right away, but
        /// search queries against ProductSets containing the product may still work
        /// until all related caches are refreshed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteProduct(DeleteProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProductRequest(ref request, ref callSettings);
            _callDeleteProduct.Sync(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes a product and its reference images.
        /// 
        /// Metadata of the product and all its images will be deleted right away, but
        /// search queries against ProductSets containing the product may still work
        /// until all related caches are refreshed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteProductAsync(DeleteProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProductRequest(ref request, ref callSettings);
            return _callDeleteProduct.Async(request, callSettings);
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
        /// characters.
        /// * Returns INVALID_ARGUMENT if the product does not exist.
        /// * Returns INVALID_ARGUMENT if bounding_poly is not provided, and nothing
        /// compatible with the parent product's product_category is detected.
        /// * Returns INVALID_ARGUMENT if bounding_poly contains more than 10 polygons.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReferenceImage CreateReferenceImage(CreateReferenceImageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReferenceImageRequest(ref request, ref callSettings);
            return _callCreateReferenceImage.Sync(request, callSettings);
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
        /// characters.
        /// * Returns INVALID_ARGUMENT if the product does not exist.
        /// * Returns INVALID_ARGUMENT if bounding_poly is not provided, and nothing
        /// compatible with the parent product's product_category is detected.
        /// * Returns INVALID_ARGUMENT if bounding_poly contains more than 10 polygons.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReferenceImage> CreateReferenceImageAsync(CreateReferenceImageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReferenceImageRequest(ref request, ref callSettings);
            return _callCreateReferenceImage.Async(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes a reference image.
        /// 
        /// The image metadata will be deleted right away, but search queries
        /// against ProductSets containing the image may still work until all related
        /// caches are refreshed.
        /// 
        /// The actual image files are not deleted from Google Cloud Storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteReferenceImage(DeleteReferenceImageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReferenceImageRequest(ref request, ref callSettings);
            _callDeleteReferenceImage.Sync(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes a reference image.
        /// 
        /// The image metadata will be deleted right away, but search queries
        /// against ProductSets containing the image may still work until all related
        /// caches are refreshed.
        /// 
        /// The actual image files are not deleted from Google Cloud Storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteReferenceImageAsync(DeleteReferenceImageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReferenceImageRequest(ref request, ref callSettings);
            return _callDeleteReferenceImage.Async(request, callSettings);
        }

        /// <summary>
        /// Lists reference images.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the parent product does not exist.
        /// * Returns INVALID_ARGUMENT if the page_size is greater than 100, or less
        /// than 1.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReferenceImage"/> resources.</returns>
        public override gax::PagedEnumerable<ListReferenceImagesResponse, ReferenceImage> ListReferenceImages(ListReferenceImagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReferenceImagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReferenceImagesRequest, ListReferenceImagesResponse, ReferenceImage>(_callListReferenceImages, request, callSettings);
        }

        /// <summary>
        /// Lists reference images.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the parent product does not exist.
        /// * Returns INVALID_ARGUMENT if the page_size is greater than 100, or less
        /// than 1.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReferenceImage"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListReferenceImagesResponse, ReferenceImage> ListReferenceImagesAsync(ListReferenceImagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReferenceImagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReferenceImagesRequest, ListReferenceImagesResponse, ReferenceImage>(_callListReferenceImages, request, callSettings);
        }

        /// <summary>
        /// Gets information associated with a ReferenceImage.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the specified image does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReferenceImage GetReferenceImage(GetReferenceImageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReferenceImageRequest(ref request, ref callSettings);
            return _callGetReferenceImage.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information associated with a ReferenceImage.
        /// 
        /// Possible errors:
        /// 
        /// * Returns NOT_FOUND if the specified image does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReferenceImage> GetReferenceImageAsync(GetReferenceImageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReferenceImageRequest(ref request, ref callSettings);
            return _callGetReferenceImage.Async(request, callSettings);
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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void AddProductToProductSet(AddProductToProductSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddProductToProductSetRequest(ref request, ref callSettings);
            _callAddProductToProductSet.Sync(request, callSettings);
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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task AddProductToProductSetAsync(AddProductToProductSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddProductToProductSetRequest(ref request, ref callSettings);
            return _callAddProductToProductSet.Async(request, callSettings);
        }

        /// <summary>
        /// Removes a Product from the specified ProductSet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void RemoveProductFromProductSet(RemoveProductFromProductSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveProductFromProductSetRequest(ref request, ref callSettings);
            _callRemoveProductFromProductSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Removes a Product from the specified ProductSet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task RemoveProductFromProductSetAsync(RemoveProductFromProductSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveProductFromProductSetRequest(ref request, ref callSettings);
            return _callRemoveProductFromProductSet.Async(request, callSettings);
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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Product"/> resources.</returns>
        public override gax::PagedEnumerable<ListProductsInProductSetResponse, Product> ListProductsInProductSet(ListProductsInProductSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProductsInProductSetRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProductsInProductSetRequest, ListProductsInProductSetResponse, Product>(_callListProductsInProductSet, request, callSettings);
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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Product"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListProductsInProductSetResponse, Product> ListProductsInProductSetAsync(ListProductsInProductSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProductsInProductSetRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProductsInProductSetRequest, ListProductsInProductSetResponse, Product>(_callListProductsInProductSet, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ImportProductSets</c>.</summary>
        public override lro::OperationsClient ImportProductSetsOperationsClient { get; }

        /// <summary>
        /// Asynchronous API that imports a list of reference images to specified
        /// product sets based on a list of image information.
        /// 
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be
        /// used to keep track of the progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// `Operation.response` contains `ImportProductSetsResponse`. (results)
        /// 
        /// The input source of this method is a csv file on Google Cloud Storage.
        /// For the format of the csv file please see
        /// [ImportProductSetsGcsSource.csv_file_uri][google.cloud.vision.v1.ImportProductSetsGcsSource.csv_file_uri].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportProductSetsResponse, BatchOperationMetadata> ImportProductSets(ImportProductSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportProductSetsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportProductSetsResponse, BatchOperationMetadata>(_callImportProductSets.Sync(request, callSettings), ImportProductSetsOperationsClient);
        }

        /// <summary>
        /// Asynchronous API that imports a list of reference images to specified
        /// product sets based on a list of image information.
        /// 
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be
        /// used to keep track of the progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// `Operation.response` contains `ImportProductSetsResponse`. (results)
        /// 
        /// The input source of this method is a csv file on Google Cloud Storage.
        /// For the format of the csv file please see
        /// [ImportProductSetsGcsSource.csv_file_uri][google.cloud.vision.v1.ImportProductSetsGcsSource.csv_file_uri].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportProductSetsResponse, BatchOperationMetadata>> ImportProductSetsAsync(ImportProductSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportProductSetsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportProductSetsResponse, BatchOperationMetadata>(await _callImportProductSets.Async(request, callSettings).ConfigureAwait(false), ImportProductSetsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>PurgeProducts</c>.</summary>
        public override lro::OperationsClient PurgeProductsOperationsClient { get; }

        /// <summary>
        /// Asynchronous API to delete all Products in a ProductSet or all Products
        /// that are in no ProductSet.
        /// 
        /// If a Product is a member of the specified ProductSet in addition to other
        /// ProductSets, the Product will still be deleted.
        /// 
        /// It is recommended to not delete the specified ProductSet until after this
        /// operation has completed. It is also recommended to not add any of the
        /// Products involved in the batch delete to a new ProductSet while this
        /// operation is running because those Products may still end up deleted.
        /// 
        /// It's not possible to undo the PurgeProducts operation. Therefore, it is
        /// recommended to keep the csv files used in ImportProductSets (if that was
        /// how you originally built the Product Set) before starting PurgeProducts, in
        /// case you need to re-import the data after deletion.
        /// 
        /// If the plan is to purge all of the Products from a ProductSet and then
        /// re-use the empty ProductSet to re-import new Products into the empty
        /// ProductSet, you must wait until the PurgeProducts operation has finished
        /// for that ProductSet.
        /// 
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be
        /// used to keep track of the progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, BatchOperationMetadata> PurgeProducts(PurgeProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PurgeProductsRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, BatchOperationMetadata>(_callPurgeProducts.Sync(request, callSettings), PurgeProductsOperationsClient);
        }

        /// <summary>
        /// Asynchronous API to delete all Products in a ProductSet or all Products
        /// that are in no ProductSet.
        /// 
        /// If a Product is a member of the specified ProductSet in addition to other
        /// ProductSets, the Product will still be deleted.
        /// 
        /// It is recommended to not delete the specified ProductSet until after this
        /// operation has completed. It is also recommended to not add any of the
        /// Products involved in the batch delete to a new ProductSet while this
        /// operation is running because those Products may still end up deleted.
        /// 
        /// It's not possible to undo the PurgeProducts operation. Therefore, it is
        /// recommended to keep the csv files used in ImportProductSets (if that was
        /// how you originally built the Product Set) before starting PurgeProducts, in
        /// case you need to re-import the data after deletion.
        /// 
        /// If the plan is to purge all of the Products from a ProductSet and then
        /// re-use the empty ProductSet to re-import new Products into the empty
        /// ProductSet, you must wait until the PurgeProducts operation has finished
        /// for that ProductSet.
        /// 
        /// The [google.longrunning.Operation][google.longrunning.Operation] API can be
        /// used to keep track of the progress and results of the request.
        /// `Operation.metadata` contains `BatchOperationMetadata`. (progress)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, BatchOperationMetadata>> PurgeProductsAsync(PurgeProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PurgeProductsRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, BatchOperationMetadata>(await _callPurgeProducts.Async(request, callSettings).ConfigureAwait(false), PurgeProductsOperationsClient);
        }
    }

    public partial class ListProductSetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProductsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReferenceImagesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProductsInProductSetRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProductSetsResponse : gaxgrpc::IPageResponse<ProductSet>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ProductSet> GetEnumerator() => ProductSets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListProductsResponse : gaxgrpc::IPageResponse<Product>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Product> GetEnumerator() => Products.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListReferenceImagesResponse : gaxgrpc::IPageResponse<ReferenceImage>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ReferenceImage> GetEnumerator() => ReferenceImages.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListProductsInProductSetResponse : gaxgrpc::IPageResponse<Product>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Product> GetEnumerator() => Products.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ProductSearch
    {
        public partial class ProductSearchClient
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
