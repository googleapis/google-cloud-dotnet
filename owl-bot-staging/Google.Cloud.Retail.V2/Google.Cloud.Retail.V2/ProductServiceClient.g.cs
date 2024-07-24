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

namespace Google.Cloud.Retail.V2
{
    /// <summary>Settings for <see cref="ProductServiceClient"/> instances.</summary>
    public sealed partial class ProductServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ProductServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ProductServiceSettings"/>.</returns>
        public static ProductServiceSettings GetDefault() => new ProductServiceSettings();

        /// <summary>Constructs a new <see cref="ProductServiceSettings"/> object with default settings.</summary>
        public ProductServiceSettings()
        {
        }

        private ProductServiceSettings(ProductServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateProductSettings = existing.CreateProductSettings;
            GetProductSettings = existing.GetProductSettings;
            ListProductsSettings = existing.ListProductsSettings;
            UpdateProductSettings = existing.UpdateProductSettings;
            DeleteProductSettings = existing.DeleteProductSettings;
            PurgeProductsSettings = existing.PurgeProductsSettings;
            PurgeProductsOperationsSettings = existing.PurgeProductsOperationsSettings.Clone();
            ImportProductsSettings = existing.ImportProductsSettings;
            ImportProductsOperationsSettings = existing.ImportProductsOperationsSettings.Clone();
            SetInventorySettings = existing.SetInventorySettings;
            SetInventoryOperationsSettings = existing.SetInventoryOperationsSettings.Clone();
            AddFulfillmentPlacesSettings = existing.AddFulfillmentPlacesSettings;
            AddFulfillmentPlacesOperationsSettings = existing.AddFulfillmentPlacesOperationsSettings.Clone();
            RemoveFulfillmentPlacesSettings = existing.RemoveFulfillmentPlacesSettings;
            RemoveFulfillmentPlacesOperationsSettings = existing.RemoveFulfillmentPlacesOperationsSettings.Clone();
            AddLocalInventoriesSettings = existing.AddLocalInventoriesSettings;
            AddLocalInventoriesOperationsSettings = existing.AddLocalInventoriesOperationsSettings.Clone();
            RemoveLocalInventoriesSettings = existing.RemoveLocalInventoriesSettings;
            RemoveLocalInventoriesOperationsSettings = existing.RemoveLocalInventoriesOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ProductServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductServiceClient.CreateProduct</c> and <c>ProductServiceClient.CreateProductAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateProductSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductServiceClient.GetProduct</c> and <c>ProductServiceClient.GetProductAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetProductSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductServiceClient.ListProducts</c> and <c>ProductServiceClient.ListProductsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListProductsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductServiceClient.UpdateProduct</c> and <c>ProductServiceClient.UpdateProductAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateProductSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductServiceClient.DeleteProduct</c> and <c>ProductServiceClient.DeleteProductAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteProductSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductServiceClient.PurgeProducts</c> and <c>ProductServiceClient.PurgeProductsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PurgeProductsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProductServiceClient.PurgeProducts</c> and
        /// <c>ProductServiceClient.PurgeProductsAsync</c>.
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

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductServiceClient.ImportProducts</c> and <c>ProductServiceClient.ImportProductsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 300000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportProductsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(300000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProductServiceClient.ImportProducts</c> and
        /// <c>ProductServiceClient.ImportProductsAsync</c>.
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
        public lro::OperationsSettings ImportProductsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductServiceClient.SetInventory</c> and <c>ProductServiceClient.SetInventoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetInventorySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProductServiceClient.SetInventory</c> and
        /// <c>ProductServiceClient.SetInventoryAsync</c>.
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
        public lro::OperationsSettings SetInventoryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductServiceClient.AddFulfillmentPlaces</c> and <c>ProductServiceClient.AddFulfillmentPlacesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddFulfillmentPlacesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProductServiceClient.AddFulfillmentPlaces</c> and
        /// <c>ProductServiceClient.AddFulfillmentPlacesAsync</c>.
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
        public lro::OperationsSettings AddFulfillmentPlacesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductServiceClient.RemoveFulfillmentPlaces</c> and <c>ProductServiceClient.RemoveFulfillmentPlacesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveFulfillmentPlacesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProductServiceClient.RemoveFulfillmentPlaces</c> and
        /// <c>ProductServiceClient.RemoveFulfillmentPlacesAsync</c>.
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
        public lro::OperationsSettings RemoveFulfillmentPlacesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductServiceClient.AddLocalInventories</c> and <c>ProductServiceClient.AddLocalInventoriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddLocalInventoriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProductServiceClient.AddLocalInventories</c> and
        /// <c>ProductServiceClient.AddLocalInventoriesAsync</c>.
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
        public lro::OperationsSettings AddLocalInventoriesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductServiceClient.RemoveLocalInventories</c> and <c>ProductServiceClient.RemoveLocalInventoriesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveLocalInventoriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProductServiceClient.RemoveLocalInventories</c> and
        /// <c>ProductServiceClient.RemoveLocalInventoriesAsync</c>.
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
        public lro::OperationsSettings RemoveLocalInventoriesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ProductServiceSettings"/> object.</returns>
        public ProductServiceSettings Clone() => new ProductServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ProductServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ProductServiceClientBuilder : gaxgrpc::ClientBuilderBase<ProductServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ProductServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ProductServiceClientBuilder() : base(ProductServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ProductServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ProductServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ProductServiceClient Build()
        {
            ProductServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ProductServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ProductServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ProductServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ProductServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ProductServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ProductServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ProductServiceClient.ChannelPool;
    }

    /// <summary>ProductService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for ingesting [Product][google.cloud.retail.v2.Product] information
    /// of the customer's website.
    /// </remarks>
    public abstract partial class ProductServiceClient
    {
        /// <summary>
        /// The default endpoint for the ProductService service, which is a host of "retail.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "retail.googleapis.com:443";

        /// <summary>The default ProductService scopes.</summary>
        /// <remarks>
        /// The default ProductService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ProductService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ProductServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ProductServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ProductServiceClient"/>.</returns>
        public static stt::Task<ProductServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ProductServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ProductServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ProductServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ProductServiceClient"/>.</returns>
        public static ProductServiceClient Create() => new ProductServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ProductServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ProductServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ProductServiceClient"/>.</returns>
        internal static ProductServiceClient Create(grpccore::CallInvoker callInvoker, ProductServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ProductService.ProductServiceClient grpcClient = new ProductService.ProductServiceClient(callInvoker);
            return new ProductServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ProductService client</summary>
        public virtual ProductService.ProductServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product CreateProduct(CreateProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> CreateProductAsync(CreateProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> CreateProductAsync(CreateProductRequest request, st::CancellationToken cancellationToken) =>
            CreateProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch`.
        /// </param>
        /// <param name="product">
        /// Required. The [Product][google.cloud.retail.v2.Product] to create.
        /// </param>
        /// <param name="productId">
        /// Required. The ID to use for the [Product][google.cloud.retail.v2.Product],
        /// which will become the final component of the
        /// [Product.name][google.cloud.retail.v2.Product.name].
        /// 
        /// If the caller does not have permission to create the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// This field must be unique among all
        /// [Product][google.cloud.retail.v2.Product]s with the same
        /// [parent][google.cloud.retail.v2.CreateProductRequest.parent]. Otherwise, an
        /// ALREADY_EXISTS error is returned.
        /// 
        /// This field must be a UTF-8 encoded string with a length limit of 128
        /// characters. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product CreateProduct(string parent, Product product, string productId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProduct(new CreateProductRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Product = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
                ProductId = gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)),
            }, callSettings);

        /// <summary>
        /// Creates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch`.
        /// </param>
        /// <param name="product">
        /// Required. The [Product][google.cloud.retail.v2.Product] to create.
        /// </param>
        /// <param name="productId">
        /// Required. The ID to use for the [Product][google.cloud.retail.v2.Product],
        /// which will become the final component of the
        /// [Product.name][google.cloud.retail.v2.Product.name].
        /// 
        /// If the caller does not have permission to create the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// This field must be unique among all
        /// [Product][google.cloud.retail.v2.Product]s with the same
        /// [parent][google.cloud.retail.v2.CreateProductRequest.parent]. Otherwise, an
        /// ALREADY_EXISTS error is returned.
        /// 
        /// This field must be a UTF-8 encoded string with a length limit of 128
        /// characters. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> CreateProductAsync(string parent, Product product, string productId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProductAsync(new CreateProductRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Product = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
                ProductId = gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)),
            }, callSettings);

        /// <summary>
        /// Creates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch`.
        /// </param>
        /// <param name="product">
        /// Required. The [Product][google.cloud.retail.v2.Product] to create.
        /// </param>
        /// <param name="productId">
        /// Required. The ID to use for the [Product][google.cloud.retail.v2.Product],
        /// which will become the final component of the
        /// [Product.name][google.cloud.retail.v2.Product.name].
        /// 
        /// If the caller does not have permission to create the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// This field must be unique among all
        /// [Product][google.cloud.retail.v2.Product]s with the same
        /// [parent][google.cloud.retail.v2.CreateProductRequest.parent]. Otherwise, an
        /// ALREADY_EXISTS error is returned.
        /// 
        /// This field must be a UTF-8 encoded string with a length limit of 128
        /// characters. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> CreateProductAsync(string parent, Product product, string productId, st::CancellationToken cancellationToken) =>
            CreateProductAsync(parent, product, productId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch`.
        /// </param>
        /// <param name="product">
        /// Required. The [Product][google.cloud.retail.v2.Product] to create.
        /// </param>
        /// <param name="productId">
        /// Required. The ID to use for the [Product][google.cloud.retail.v2.Product],
        /// which will become the final component of the
        /// [Product.name][google.cloud.retail.v2.Product.name].
        /// 
        /// If the caller does not have permission to create the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// This field must be unique among all
        /// [Product][google.cloud.retail.v2.Product]s with the same
        /// [parent][google.cloud.retail.v2.CreateProductRequest.parent]. Otherwise, an
        /// ALREADY_EXISTS error is returned.
        /// 
        /// This field must be a UTF-8 encoded string with a length limit of 128
        /// characters. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product CreateProduct(BranchName parent, Product product, string productId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProduct(new CreateProductRequest
            {
                ParentAsBranchName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Product = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
                ProductId = gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)),
            }, callSettings);

        /// <summary>
        /// Creates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch`.
        /// </param>
        /// <param name="product">
        /// Required. The [Product][google.cloud.retail.v2.Product] to create.
        /// </param>
        /// <param name="productId">
        /// Required. The ID to use for the [Product][google.cloud.retail.v2.Product],
        /// which will become the final component of the
        /// [Product.name][google.cloud.retail.v2.Product.name].
        /// 
        /// If the caller does not have permission to create the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// This field must be unique among all
        /// [Product][google.cloud.retail.v2.Product]s with the same
        /// [parent][google.cloud.retail.v2.CreateProductRequest.parent]. Otherwise, an
        /// ALREADY_EXISTS error is returned.
        /// 
        /// This field must be a UTF-8 encoded string with a length limit of 128
        /// characters. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> CreateProductAsync(BranchName parent, Product product, string productId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProductAsync(new CreateProductRequest
            {
                ParentAsBranchName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Product = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
                ProductId = gax::GaxPreconditions.CheckNotNullOrEmpty(productId, nameof(productId)),
            }, callSettings);

        /// <summary>
        /// Creates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent catalog resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch`.
        /// </param>
        /// <param name="product">
        /// Required. The [Product][google.cloud.retail.v2.Product] to create.
        /// </param>
        /// <param name="productId">
        /// Required. The ID to use for the [Product][google.cloud.retail.v2.Product],
        /// which will become the final component of the
        /// [Product.name][google.cloud.retail.v2.Product.name].
        /// 
        /// If the caller does not have permission to create the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// This field must be unique among all
        /// [Product][google.cloud.retail.v2.Product]s with the same
        /// [parent][google.cloud.retail.v2.CreateProductRequest.parent]. Otherwise, an
        /// ALREADY_EXISTS error is returned.
        /// 
        /// This field must be a UTF-8 encoded string with a length limit of 128
        /// characters. Otherwise, an INVALID_ARGUMENT error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> CreateProductAsync(BranchName parent, Product product, string productId, st::CancellationToken cancellationToken) =>
            CreateProductAsync(parent, product, productId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product GetProduct(GetProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(GetProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(GetProductRequest request, st::CancellationToken cancellationToken) =>
            GetProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested [Product][google.cloud.retail.v2.Product] does not exist,
        /// a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product GetProduct(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProduct(new GetProductRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested [Product][google.cloud.retail.v2.Product] does not exist,
        /// a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProductAsync(new GetProductRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested [Product][google.cloud.retail.v2.Product] does not exist,
        /// a NOT_FOUND error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(string name, st::CancellationToken cancellationToken) =>
            GetProductAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested [Product][google.cloud.retail.v2.Product] does not exist,
        /// a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product GetProduct(ProductName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProduct(new GetProductRequest
            {
                ProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested [Product][google.cloud.retail.v2.Product] does not exist,
        /// a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(ProductName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProductAsync(new GetProductRequest
            {
                ProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the requested [Product][google.cloud.retail.v2.Product] does not exist,
        /// a NOT_FOUND error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> GetProductAsync(ProductName name, st::CancellationToken cancellationToken) =>
            GetProductAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a list of [Product][google.cloud.retail.v2.Product]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProductsResponse, Product> ListProducts(ListProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of [Product][google.cloud.retail.v2.Product]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProductsResponse, Product> ListProductsAsync(ListProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of [Product][google.cloud.retail.v2.Product]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent branch resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/0`. Use
        /// `default_branch` as the branch ID, to list products under the default
        /// branch.
        /// 
        /// If the caller does not have permission to list
        /// [Product][google.cloud.retail.v2.Product]s under this branch, regardless of
        /// whether or not this branch exists, a PERMISSION_DENIED error is returned.
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
        /// Gets a list of [Product][google.cloud.retail.v2.Product]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent branch resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/0`. Use
        /// `default_branch` as the branch ID, to list products under the default
        /// branch.
        /// 
        /// If the caller does not have permission to list
        /// [Product][google.cloud.retail.v2.Product]s under this branch, regardless of
        /// whether or not this branch exists, a PERMISSION_DENIED error is returned.
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
        /// Gets a list of [Product][google.cloud.retail.v2.Product]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent branch resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/0`. Use
        /// `default_branch` as the branch ID, to list products under the default
        /// branch.
        /// 
        /// If the caller does not have permission to list
        /// [Product][google.cloud.retail.v2.Product]s under this branch, regardless of
        /// whether or not this branch exists, a PERMISSION_DENIED error is returned.
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
        public virtual gax::PagedEnumerable<ListProductsResponse, Product> ListProducts(BranchName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductsRequest request = new ListProductsRequest
            {
                ParentAsBranchName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Gets a list of [Product][google.cloud.retail.v2.Product]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent branch resource name, such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/0`. Use
        /// `default_branch` as the branch ID, to list products under the default
        /// branch.
        /// 
        /// If the caller does not have permission to list
        /// [Product][google.cloud.retail.v2.Product]s under this branch, regardless of
        /// whether or not this branch exists, a PERMISSION_DENIED error is returned.
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
        public virtual gax::PagedAsyncEnumerable<ListProductsResponse, Product> ListProductsAsync(BranchName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProductsRequest request = new ListProductsRequest
            {
                ParentAsBranchName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Updates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Product UpdateProduct(UpdateProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> UpdateProductAsync(UpdateProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> UpdateProductAsync(UpdateProductRequest request, st::CancellationToken cancellationToken) =>
            UpdateProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="product">
        /// Required. The product to update/create.
        /// 
        /// If the caller does not have permission to update the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Product][google.cloud.retail.v2.Product] to update does not exist
        /// and
        /// [allow_missing][google.cloud.retail.v2.UpdateProductRequest.allow_missing]
        /// is not set, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [Product][google.cloud.retail.v2.Product] to update. The immutable and
        /// output only fields are NOT supported. If not set, all supported fields (the
        /// fields that are neither immutable nor output only) are updated.
        /// 
        /// If an unsupported or unknown field is provided, an INVALID_ARGUMENT error
        /// is returned.
        /// 
        /// The attribute key can be updated by setting the mask path as
        /// "attributes.${key_name}". If a key name is present in the mask but not in
        /// the patching product from the request, this key will be deleted after the
        /// update.
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
        /// Updates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="product">
        /// Required. The product to update/create.
        /// 
        /// If the caller does not have permission to update the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Product][google.cloud.retail.v2.Product] to update does not exist
        /// and
        /// [allow_missing][google.cloud.retail.v2.UpdateProductRequest.allow_missing]
        /// is not set, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [Product][google.cloud.retail.v2.Product] to update. The immutable and
        /// output only fields are NOT supported. If not set, all supported fields (the
        /// fields that are neither immutable nor output only) are updated.
        /// 
        /// If an unsupported or unknown field is provided, an INVALID_ARGUMENT error
        /// is returned.
        /// 
        /// The attribute key can be updated by setting the mask path as
        /// "attributes.${key_name}". If a key name is present in the mask but not in
        /// the patching product from the request, this key will be deleted after the
        /// update.
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
        /// Updates a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="product">
        /// Required. The product to update/create.
        /// 
        /// If the caller does not have permission to update the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Product][google.cloud.retail.v2.Product] to update does not exist
        /// and
        /// [allow_missing][google.cloud.retail.v2.UpdateProductRequest.allow_missing]
        /// is not set, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [Product][google.cloud.retail.v2.Product] to update. The immutable and
        /// output only fields are NOT supported. If not set, all supported fields (the
        /// fields that are neither immutable nor output only) are updated.
        /// 
        /// If an unsupported or unknown field is provided, an INVALID_ARGUMENT error
        /// is returned.
        /// 
        /// The attribute key can be updated by setting the mask path as
        /// "attributes.${key_name}". If a key name is present in the mask but not in
        /// the patching product from the request, this key will be deleted after the
        /// update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Product> UpdateProductAsync(Product product, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateProductAsync(product, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteProduct(DeleteProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductAsync(DeleteProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductAsync(DeleteProductRequest request, st::CancellationToken cancellationToken) =>
            DeleteProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to delete the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Product][google.cloud.retail.v2.Product] to delete does not exist,
        /// a NOT_FOUND error is returned.
        /// 
        /// The [Product][google.cloud.retail.v2.Product] to delete can neither be a
        /// [Product.Type.COLLECTION][google.cloud.retail.v2.Product.Type.COLLECTION]
        /// [Product][google.cloud.retail.v2.Product] member nor a
        /// [Product.Type.PRIMARY][google.cloud.retail.v2.Product.Type.PRIMARY]
        /// [Product][google.cloud.retail.v2.Product] with more than one
        /// [variants][google.cloud.retail.v2.Product.Type.VARIANT]. Otherwise, an
        /// INVALID_ARGUMENT error is returned.
        /// 
        /// All inventory information for the named
        /// [Product][google.cloud.retail.v2.Product] will be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteProduct(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProduct(new DeleteProductRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to delete the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Product][google.cloud.retail.v2.Product] to delete does not exist,
        /// a NOT_FOUND error is returned.
        /// 
        /// The [Product][google.cloud.retail.v2.Product] to delete can neither be a
        /// [Product.Type.COLLECTION][google.cloud.retail.v2.Product.Type.COLLECTION]
        /// [Product][google.cloud.retail.v2.Product] member nor a
        /// [Product.Type.PRIMARY][google.cloud.retail.v2.Product.Type.PRIMARY]
        /// [Product][google.cloud.retail.v2.Product] with more than one
        /// [variants][google.cloud.retail.v2.Product.Type.VARIANT]. Otherwise, an
        /// INVALID_ARGUMENT error is returned.
        /// 
        /// All inventory information for the named
        /// [Product][google.cloud.retail.v2.Product] will be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProductAsync(new DeleteProductRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to delete the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Product][google.cloud.retail.v2.Product] to delete does not exist,
        /// a NOT_FOUND error is returned.
        /// 
        /// The [Product][google.cloud.retail.v2.Product] to delete can neither be a
        /// [Product.Type.COLLECTION][google.cloud.retail.v2.Product.Type.COLLECTION]
        /// [Product][google.cloud.retail.v2.Product] member nor a
        /// [Product.Type.PRIMARY][google.cloud.retail.v2.Product.Type.PRIMARY]
        /// [Product][google.cloud.retail.v2.Product] with more than one
        /// [variants][google.cloud.retail.v2.Product.Type.VARIANT]. Otherwise, an
        /// INVALID_ARGUMENT error is returned.
        /// 
        /// All inventory information for the named
        /// [Product][google.cloud.retail.v2.Product] will be deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteProductAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to delete the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Product][google.cloud.retail.v2.Product] to delete does not exist,
        /// a NOT_FOUND error is returned.
        /// 
        /// The [Product][google.cloud.retail.v2.Product] to delete can neither be a
        /// [Product.Type.COLLECTION][google.cloud.retail.v2.Product.Type.COLLECTION]
        /// [Product][google.cloud.retail.v2.Product] member nor a
        /// [Product.Type.PRIMARY][google.cloud.retail.v2.Product.Type.PRIMARY]
        /// [Product][google.cloud.retail.v2.Product] with more than one
        /// [variants][google.cloud.retail.v2.Product.Type.VARIANT]. Otherwise, an
        /// INVALID_ARGUMENT error is returned.
        /// 
        /// All inventory information for the named
        /// [Product][google.cloud.retail.v2.Product] will be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteProduct(ProductName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProduct(new DeleteProductRequest
            {
                ProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to delete the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Product][google.cloud.retail.v2.Product] to delete does not exist,
        /// a NOT_FOUND error is returned.
        /// 
        /// The [Product][google.cloud.retail.v2.Product] to delete can neither be a
        /// [Product.Type.COLLECTION][google.cloud.retail.v2.Product.Type.COLLECTION]
        /// [Product][google.cloud.retail.v2.Product] member nor a
        /// [Product.Type.PRIMARY][google.cloud.retail.v2.Product.Type.PRIMARY]
        /// [Product][google.cloud.retail.v2.Product] with more than one
        /// [variants][google.cloud.retail.v2.Product.Type.VARIANT]. Otherwise, an
        /// INVALID_ARGUMENT error is returned.
        /// 
        /// All inventory information for the named
        /// [Product][google.cloud.retail.v2.Product] will be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductAsync(ProductName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProductAsync(new DeleteProductRequest
            {
                ProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="name">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to delete the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Product][google.cloud.retail.v2.Product] to delete does not exist,
        /// a NOT_FOUND error is returned.
        /// 
        /// The [Product][google.cloud.retail.v2.Product] to delete can neither be a
        /// [Product.Type.COLLECTION][google.cloud.retail.v2.Product.Type.COLLECTION]
        /// [Product][google.cloud.retail.v2.Product] member nor a
        /// [Product.Type.PRIMARY][google.cloud.retail.v2.Product.Type.PRIMARY]
        /// [Product][google.cloud.retail.v2.Product] with more than one
        /// [variants][google.cloud.retail.v2.Product.Type.VARIANT]. Otherwise, an
        /// INVALID_ARGUMENT error is returned.
        /// 
        /// All inventory information for the named
        /// [Product][google.cloud.retail.v2.Product] will be deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteProductAsync(ProductName name, st::CancellationToken cancellationToken) =>
            DeleteProductAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes all selected [Product][google.cloud.retail.v2.Product]s
        /// under a branch.
        /// 
        /// This process is asynchronous. If the request is valid, the removal will be
        /// enqueued and processed offline. Depending on the number of
        /// [Product][google.cloud.retail.v2.Product]s, this operation could take hours
        /// to complete. Before the operation completes, some
        /// [Product][google.cloud.retail.v2.Product]s may still be returned by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Depending on the number of [Product][google.cloud.retail.v2.Product]s, this
        /// operation could take hours to complete. To get a sample of
        /// [Product][google.cloud.retail.v2.Product]s that would be deleted, set
        /// [PurgeProductsRequest.force][google.cloud.retail.v2.PurgeProductsRequest.force]
        /// to false.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PurgeProductsResponse, PurgeProductsMetadata> PurgeProducts(PurgeProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes all selected [Product][google.cloud.retail.v2.Product]s
        /// under a branch.
        /// 
        /// This process is asynchronous. If the request is valid, the removal will be
        /// enqueued and processed offline. Depending on the number of
        /// [Product][google.cloud.retail.v2.Product]s, this operation could take hours
        /// to complete. Before the operation completes, some
        /// [Product][google.cloud.retail.v2.Product]s may still be returned by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Depending on the number of [Product][google.cloud.retail.v2.Product]s, this
        /// operation could take hours to complete. To get a sample of
        /// [Product][google.cloud.retail.v2.Product]s that would be deleted, set
        /// [PurgeProductsRequest.force][google.cloud.retail.v2.PurgeProductsRequest.force]
        /// to false.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeProductsResponse, PurgeProductsMetadata>> PurgeProductsAsync(PurgeProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes all selected [Product][google.cloud.retail.v2.Product]s
        /// under a branch.
        /// 
        /// This process is asynchronous. If the request is valid, the removal will be
        /// enqueued and processed offline. Depending on the number of
        /// [Product][google.cloud.retail.v2.Product]s, this operation could take hours
        /// to complete. Before the operation completes, some
        /// [Product][google.cloud.retail.v2.Product]s may still be returned by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Depending on the number of [Product][google.cloud.retail.v2.Product]s, this
        /// operation could take hours to complete. To get a sample of
        /// [Product][google.cloud.retail.v2.Product]s that would be deleted, set
        /// [PurgeProductsRequest.force][google.cloud.retail.v2.PurgeProductsRequest.force]
        /// to false.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeProductsResponse, PurgeProductsMetadata>> PurgeProductsAsync(PurgeProductsRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<PurgeProductsResponse, PurgeProductsMetadata> PollOncePurgeProducts(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PurgeProductsResponse, PurgeProductsMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PurgeProductsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PurgeProducts</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PurgeProductsResponse, PurgeProductsMetadata>> PollOncePurgeProductsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PurgeProductsResponse, PurgeProductsMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PurgeProductsOperationsClient, callSettings);

        /// <summary>
        /// Bulk import of multiple [Product][google.cloud.retail.v2.Product]s.
        /// 
        /// Request processing may be synchronous.
        /// Non-existing items are created.
        /// 
        /// Note that it is possible for a subset of the
        /// [Product][google.cloud.retail.v2.Product]s to be successfully updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportProductsResponse, ImportMetadata> ImportProducts(ImportProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bulk import of multiple [Product][google.cloud.retail.v2.Product]s.
        /// 
        /// Request processing may be synchronous.
        /// Non-existing items are created.
        /// 
        /// Note that it is possible for a subset of the
        /// [Product][google.cloud.retail.v2.Product]s to be successfully updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportProductsResponse, ImportMetadata>> ImportProductsAsync(ImportProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bulk import of multiple [Product][google.cloud.retail.v2.Product]s.
        /// 
        /// Request processing may be synchronous.
        /// Non-existing items are created.
        /// 
        /// Note that it is possible for a subset of the
        /// [Product][google.cloud.retail.v2.Product]s to be successfully updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportProductsResponse, ImportMetadata>> ImportProductsAsync(ImportProductsRequest request, st::CancellationToken cancellationToken) =>
            ImportProductsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportProducts</c>.</summary>
        public virtual lro::OperationsClient ImportProductsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportProducts</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportProductsResponse, ImportMetadata> PollOnceImportProducts(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportProductsResponse, ImportMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportProductsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportProducts</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportProductsResponse, ImportMetadata>> PollOnceImportProductsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportProductsResponse, ImportMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportProductsOperationsClient, callSettings);

        /// <summary>
        /// Updates inventory information for a
        /// [Product][google.cloud.retail.v2.Product] while respecting the last update
        /// timestamps of each inventory field.
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update is enqueued
        /// and processed downstream. As a consequence, when a response is returned,
        /// updates are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// When inventory is updated with
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct],
        /// the specified inventory field value(s) overwrite any existing value(s)
        /// while ignoring the last update time for this field. Furthermore, the last
        /// update times for the specified inventory fields are overwritten by the
        /// times of the
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// or
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// request.
        /// 
        /// If no inventory fields are set in
        /// [CreateProductRequest.product][google.cloud.retail.v2.CreateProductRequest.product],
        /// then any pre-existing inventory information for this product is used.
        /// 
        /// If no inventory fields are set in
        /// [SetInventoryRequest.set_mask][google.cloud.retail.v2.SetInventoryRequest.set_mask],
        /// then any existing inventory information is preserved.
        /// 
        /// Pre-existing inventory information can only be updated with
        /// [ProductService.SetInventory][google.cloud.retail.v2.ProductService.SetInventory],
        /// [ProductService.AddFulfillmentPlaces][google.cloud.retail.v2.ProductService.AddFulfillmentPlaces],
        /// and
        /// [ProductService.RemoveFulfillmentPlaces][google.cloud.retail.v2.ProductService.RemoveFulfillmentPlaces].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s is obsolete after
        /// one day, and the [GetOperation][google.longrunning.Operations.GetOperation]
        /// API returns `NOT_FOUND` afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates are not marked as [done][google.longrunning.Operation.done] until
        /// they are obsolete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SetInventoryResponse, SetInventoryMetadata> SetInventory(SetInventoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates inventory information for a
        /// [Product][google.cloud.retail.v2.Product] while respecting the last update
        /// timestamps of each inventory field.
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update is enqueued
        /// and processed downstream. As a consequence, when a response is returned,
        /// updates are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// When inventory is updated with
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct],
        /// the specified inventory field value(s) overwrite any existing value(s)
        /// while ignoring the last update time for this field. Furthermore, the last
        /// update times for the specified inventory fields are overwritten by the
        /// times of the
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// or
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// request.
        /// 
        /// If no inventory fields are set in
        /// [CreateProductRequest.product][google.cloud.retail.v2.CreateProductRequest.product],
        /// then any pre-existing inventory information for this product is used.
        /// 
        /// If no inventory fields are set in
        /// [SetInventoryRequest.set_mask][google.cloud.retail.v2.SetInventoryRequest.set_mask],
        /// then any existing inventory information is preserved.
        /// 
        /// Pre-existing inventory information can only be updated with
        /// [ProductService.SetInventory][google.cloud.retail.v2.ProductService.SetInventory],
        /// [ProductService.AddFulfillmentPlaces][google.cloud.retail.v2.ProductService.AddFulfillmentPlaces],
        /// and
        /// [ProductService.RemoveFulfillmentPlaces][google.cloud.retail.v2.ProductService.RemoveFulfillmentPlaces].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s is obsolete after
        /// one day, and the [GetOperation][google.longrunning.Operations.GetOperation]
        /// API returns `NOT_FOUND` afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates are not marked as [done][google.longrunning.Operation.done] until
        /// they are obsolete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SetInventoryResponse, SetInventoryMetadata>> SetInventoryAsync(SetInventoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates inventory information for a
        /// [Product][google.cloud.retail.v2.Product] while respecting the last update
        /// timestamps of each inventory field.
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update is enqueued
        /// and processed downstream. As a consequence, when a response is returned,
        /// updates are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// When inventory is updated with
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct],
        /// the specified inventory field value(s) overwrite any existing value(s)
        /// while ignoring the last update time for this field. Furthermore, the last
        /// update times for the specified inventory fields are overwritten by the
        /// times of the
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// or
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// request.
        /// 
        /// If no inventory fields are set in
        /// [CreateProductRequest.product][google.cloud.retail.v2.CreateProductRequest.product],
        /// then any pre-existing inventory information for this product is used.
        /// 
        /// If no inventory fields are set in
        /// [SetInventoryRequest.set_mask][google.cloud.retail.v2.SetInventoryRequest.set_mask],
        /// then any existing inventory information is preserved.
        /// 
        /// Pre-existing inventory information can only be updated with
        /// [ProductService.SetInventory][google.cloud.retail.v2.ProductService.SetInventory],
        /// [ProductService.AddFulfillmentPlaces][google.cloud.retail.v2.ProductService.AddFulfillmentPlaces],
        /// and
        /// [ProductService.RemoveFulfillmentPlaces][google.cloud.retail.v2.ProductService.RemoveFulfillmentPlaces].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s is obsolete after
        /// one day, and the [GetOperation][google.longrunning.Operations.GetOperation]
        /// API returns `NOT_FOUND` afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates are not marked as [done][google.longrunning.Operation.done] until
        /// they are obsolete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SetInventoryResponse, SetInventoryMetadata>> SetInventoryAsync(SetInventoryRequest request, st::CancellationToken cancellationToken) =>
            SetInventoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetInventory</c>.</summary>
        public virtual lro::OperationsClient SetInventoryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetInventory</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<SetInventoryResponse, SetInventoryMetadata> PollOnceSetInventory(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SetInventoryResponse, SetInventoryMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetInventoryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetInventory</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<SetInventoryResponse, SetInventoryMetadata>> PollOnceSetInventoryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SetInventoryResponse, SetInventoryMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetInventoryOperationsClient, callSettings);

        /// <summary>
        /// Updates inventory information for a
        /// [Product][google.cloud.retail.v2.Product] while respecting the last update
        /// timestamps of each inventory field.
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update is enqueued
        /// and processed downstream. As a consequence, when a response is returned,
        /// updates are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// When inventory is updated with
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct],
        /// the specified inventory field value(s) overwrite any existing value(s)
        /// while ignoring the last update time for this field. Furthermore, the last
        /// update times for the specified inventory fields are overwritten by the
        /// times of the
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// or
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// request.
        /// 
        /// If no inventory fields are set in
        /// [CreateProductRequest.product][google.cloud.retail.v2.CreateProductRequest.product],
        /// then any pre-existing inventory information for this product is used.
        /// 
        /// If no inventory fields are set in
        /// [SetInventoryRequest.set_mask][google.cloud.retail.v2.SetInventoryRequest.set_mask],
        /// then any existing inventory information is preserved.
        /// 
        /// Pre-existing inventory information can only be updated with
        /// [ProductService.SetInventory][google.cloud.retail.v2.ProductService.SetInventory],
        /// [ProductService.AddFulfillmentPlaces][google.cloud.retail.v2.ProductService.AddFulfillmentPlaces],
        /// and
        /// [ProductService.RemoveFulfillmentPlaces][google.cloud.retail.v2.ProductService.RemoveFulfillmentPlaces].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s is obsolete after
        /// one day, and the [GetOperation][google.longrunning.Operations.GetOperation]
        /// API returns `NOT_FOUND` afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates are not marked as [done][google.longrunning.Operation.done] until
        /// they are obsolete.
        /// </summary>
        /// <param name="inventory">
        /// Required. The inventory information to update. The allowable fields to
        /// update are:
        /// 
        /// * [Product.price_info][google.cloud.retail.v2.Product.price_info]
        /// * [Product.availability][google.cloud.retail.v2.Product.availability]
        /// * [Product.available_quantity][google.cloud.retail.v2.Product.available_quantity]
        /// * [Product.fulfillment_info][google.cloud.retail.v2.Product.fulfillment_info]
        /// The updated inventory fields must be specified in
        /// [SetInventoryRequest.set_mask][google.cloud.retail.v2.SetInventoryRequest.set_mask].
        /// 
        /// If
        /// [SetInventoryRequest.inventory.name][google.cloud.retail.v2.Product.name]
        /// is empty or invalid, an INVALID_ARGUMENT error is returned.
        /// 
        /// If the caller does not have permission to update the
        /// [Product][google.cloud.retail.v2.Product] named in
        /// [Product.name][google.cloud.retail.v2.Product.name], regardless of whether
        /// or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Product][google.cloud.retail.v2.Product] to update does not have
        /// existing inventory information, the provided inventory information will be
        /// inserted.
        /// 
        /// If the [Product][google.cloud.retail.v2.Product] to update has existing
        /// inventory information, the provided inventory information will be merged
        /// while respecting the last update time for each inventory field, using the
        /// provided or default value for
        /// [SetInventoryRequest.set_time][google.cloud.retail.v2.SetInventoryRequest.set_time].
        /// 
        /// The caller can replace place IDs for a subset of fulfillment types in the
        /// following ways:
        /// 
        /// * Adds "fulfillment_info" in
        /// [SetInventoryRequest.set_mask][google.cloud.retail.v2.SetInventoryRequest.set_mask]
        /// * Specifies only the desired fulfillment types and corresponding place IDs
        /// to update in
        /// [SetInventoryRequest.inventory.fulfillment_info][google.cloud.retail.v2.Product.fulfillment_info]
        /// 
        /// The caller can clear all place IDs from a subset of fulfillment types in
        /// the following ways:
        /// 
        /// * Adds "fulfillment_info" in
        /// [SetInventoryRequest.set_mask][google.cloud.retail.v2.SetInventoryRequest.set_mask]
        /// * Specifies only the desired fulfillment types to clear in
        /// [SetInventoryRequest.inventory.fulfillment_info][google.cloud.retail.v2.Product.fulfillment_info]
        /// * Checks that only the desired fulfillment info types have empty
        /// [SetInventoryRequest.inventory.fulfillment_info.place_ids][google.cloud.retail.v2.FulfillmentInfo.place_ids]
        /// 
        /// The last update time is recorded for the following inventory fields:
        /// * [Product.price_info][google.cloud.retail.v2.Product.price_info]
        /// * [Product.availability][google.cloud.retail.v2.Product.availability]
        /// * [Product.available_quantity][google.cloud.retail.v2.Product.available_quantity]
        /// * [Product.fulfillment_info][google.cloud.retail.v2.Product.fulfillment_info]
        /// 
        /// If a full overwrite of inventory information while ignoring timestamps is
        /// needed,
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// should be invoked instead.
        /// </param>
        /// <param name="setMask">
        /// Indicates which inventory fields in the provided
        /// [Product][google.cloud.retail.v2.Product] to update.
        /// 
        /// At least one field must be provided.
        /// 
        /// If an unsupported or unknown field is provided, an INVALID_ARGUMENT error
        /// is returned and the entire update will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SetInventoryResponse, SetInventoryMetadata> SetInventory(Product inventory, wkt::FieldMask setMask, gaxgrpc::CallSettings callSettings = null) =>
            SetInventory(new SetInventoryRequest
            {
                Inventory = gax::GaxPreconditions.CheckNotNull(inventory, nameof(inventory)),
                SetMask = setMask,
            }, callSettings);

        /// <summary>
        /// Updates inventory information for a
        /// [Product][google.cloud.retail.v2.Product] while respecting the last update
        /// timestamps of each inventory field.
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update is enqueued
        /// and processed downstream. As a consequence, when a response is returned,
        /// updates are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// When inventory is updated with
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct],
        /// the specified inventory field value(s) overwrite any existing value(s)
        /// while ignoring the last update time for this field. Furthermore, the last
        /// update times for the specified inventory fields are overwritten by the
        /// times of the
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// or
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// request.
        /// 
        /// If no inventory fields are set in
        /// [CreateProductRequest.product][google.cloud.retail.v2.CreateProductRequest.product],
        /// then any pre-existing inventory information for this product is used.
        /// 
        /// If no inventory fields are set in
        /// [SetInventoryRequest.set_mask][google.cloud.retail.v2.SetInventoryRequest.set_mask],
        /// then any existing inventory information is preserved.
        /// 
        /// Pre-existing inventory information can only be updated with
        /// [ProductService.SetInventory][google.cloud.retail.v2.ProductService.SetInventory],
        /// [ProductService.AddFulfillmentPlaces][google.cloud.retail.v2.ProductService.AddFulfillmentPlaces],
        /// and
        /// [ProductService.RemoveFulfillmentPlaces][google.cloud.retail.v2.ProductService.RemoveFulfillmentPlaces].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s is obsolete after
        /// one day, and the [GetOperation][google.longrunning.Operations.GetOperation]
        /// API returns `NOT_FOUND` afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates are not marked as [done][google.longrunning.Operation.done] until
        /// they are obsolete.
        /// </summary>
        /// <param name="inventory">
        /// Required. The inventory information to update. The allowable fields to
        /// update are:
        /// 
        /// * [Product.price_info][google.cloud.retail.v2.Product.price_info]
        /// * [Product.availability][google.cloud.retail.v2.Product.availability]
        /// * [Product.available_quantity][google.cloud.retail.v2.Product.available_quantity]
        /// * [Product.fulfillment_info][google.cloud.retail.v2.Product.fulfillment_info]
        /// The updated inventory fields must be specified in
        /// [SetInventoryRequest.set_mask][google.cloud.retail.v2.SetInventoryRequest.set_mask].
        /// 
        /// If
        /// [SetInventoryRequest.inventory.name][google.cloud.retail.v2.Product.name]
        /// is empty or invalid, an INVALID_ARGUMENT error is returned.
        /// 
        /// If the caller does not have permission to update the
        /// [Product][google.cloud.retail.v2.Product] named in
        /// [Product.name][google.cloud.retail.v2.Product.name], regardless of whether
        /// or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Product][google.cloud.retail.v2.Product] to update does not have
        /// existing inventory information, the provided inventory information will be
        /// inserted.
        /// 
        /// If the [Product][google.cloud.retail.v2.Product] to update has existing
        /// inventory information, the provided inventory information will be merged
        /// while respecting the last update time for each inventory field, using the
        /// provided or default value for
        /// [SetInventoryRequest.set_time][google.cloud.retail.v2.SetInventoryRequest.set_time].
        /// 
        /// The caller can replace place IDs for a subset of fulfillment types in the
        /// following ways:
        /// 
        /// * Adds "fulfillment_info" in
        /// [SetInventoryRequest.set_mask][google.cloud.retail.v2.SetInventoryRequest.set_mask]
        /// * Specifies only the desired fulfillment types and corresponding place IDs
        /// to update in
        /// [SetInventoryRequest.inventory.fulfillment_info][google.cloud.retail.v2.Product.fulfillment_info]
        /// 
        /// The caller can clear all place IDs from a subset of fulfillment types in
        /// the following ways:
        /// 
        /// * Adds "fulfillment_info" in
        /// [SetInventoryRequest.set_mask][google.cloud.retail.v2.SetInventoryRequest.set_mask]
        /// * Specifies only the desired fulfillment types to clear in
        /// [SetInventoryRequest.inventory.fulfillment_info][google.cloud.retail.v2.Product.fulfillment_info]
        /// * Checks that only the desired fulfillment info types have empty
        /// [SetInventoryRequest.inventory.fulfillment_info.place_ids][google.cloud.retail.v2.FulfillmentInfo.place_ids]
        /// 
        /// The last update time is recorded for the following inventory fields:
        /// * [Product.price_info][google.cloud.retail.v2.Product.price_info]
        /// * [Product.availability][google.cloud.retail.v2.Product.availability]
        /// * [Product.available_quantity][google.cloud.retail.v2.Product.available_quantity]
        /// * [Product.fulfillment_info][google.cloud.retail.v2.Product.fulfillment_info]
        /// 
        /// If a full overwrite of inventory information while ignoring timestamps is
        /// needed,
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// should be invoked instead.
        /// </param>
        /// <param name="setMask">
        /// Indicates which inventory fields in the provided
        /// [Product][google.cloud.retail.v2.Product] to update.
        /// 
        /// At least one field must be provided.
        /// 
        /// If an unsupported or unknown field is provided, an INVALID_ARGUMENT error
        /// is returned and the entire update will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SetInventoryResponse, SetInventoryMetadata>> SetInventoryAsync(Product inventory, wkt::FieldMask setMask, gaxgrpc::CallSettings callSettings = null) =>
            SetInventoryAsync(new SetInventoryRequest
            {
                Inventory = gax::GaxPreconditions.CheckNotNull(inventory, nameof(inventory)),
                SetMask = setMask,
            }, callSettings);

        /// <summary>
        /// Updates inventory information for a
        /// [Product][google.cloud.retail.v2.Product] while respecting the last update
        /// timestamps of each inventory field.
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update is enqueued
        /// and processed downstream. As a consequence, when a response is returned,
        /// updates are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// When inventory is updated with
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct],
        /// the specified inventory field value(s) overwrite any existing value(s)
        /// while ignoring the last update time for this field. Furthermore, the last
        /// update times for the specified inventory fields are overwritten by the
        /// times of the
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// or
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// request.
        /// 
        /// If no inventory fields are set in
        /// [CreateProductRequest.product][google.cloud.retail.v2.CreateProductRequest.product],
        /// then any pre-existing inventory information for this product is used.
        /// 
        /// If no inventory fields are set in
        /// [SetInventoryRequest.set_mask][google.cloud.retail.v2.SetInventoryRequest.set_mask],
        /// then any existing inventory information is preserved.
        /// 
        /// Pre-existing inventory information can only be updated with
        /// [ProductService.SetInventory][google.cloud.retail.v2.ProductService.SetInventory],
        /// [ProductService.AddFulfillmentPlaces][google.cloud.retail.v2.ProductService.AddFulfillmentPlaces],
        /// and
        /// [ProductService.RemoveFulfillmentPlaces][google.cloud.retail.v2.ProductService.RemoveFulfillmentPlaces].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s is obsolete after
        /// one day, and the [GetOperation][google.longrunning.Operations.GetOperation]
        /// API returns `NOT_FOUND` afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates are not marked as [done][google.longrunning.Operation.done] until
        /// they are obsolete.
        /// </summary>
        /// <param name="inventory">
        /// Required. The inventory information to update. The allowable fields to
        /// update are:
        /// 
        /// * [Product.price_info][google.cloud.retail.v2.Product.price_info]
        /// * [Product.availability][google.cloud.retail.v2.Product.availability]
        /// * [Product.available_quantity][google.cloud.retail.v2.Product.available_quantity]
        /// * [Product.fulfillment_info][google.cloud.retail.v2.Product.fulfillment_info]
        /// The updated inventory fields must be specified in
        /// [SetInventoryRequest.set_mask][google.cloud.retail.v2.SetInventoryRequest.set_mask].
        /// 
        /// If
        /// [SetInventoryRequest.inventory.name][google.cloud.retail.v2.Product.name]
        /// is empty or invalid, an INVALID_ARGUMENT error is returned.
        /// 
        /// If the caller does not have permission to update the
        /// [Product][google.cloud.retail.v2.Product] named in
        /// [Product.name][google.cloud.retail.v2.Product.name], regardless of whether
        /// or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Product][google.cloud.retail.v2.Product] to update does not have
        /// existing inventory information, the provided inventory information will be
        /// inserted.
        /// 
        /// If the [Product][google.cloud.retail.v2.Product] to update has existing
        /// inventory information, the provided inventory information will be merged
        /// while respecting the last update time for each inventory field, using the
        /// provided or default value for
        /// [SetInventoryRequest.set_time][google.cloud.retail.v2.SetInventoryRequest.set_time].
        /// 
        /// The caller can replace place IDs for a subset of fulfillment types in the
        /// following ways:
        /// 
        /// * Adds "fulfillment_info" in
        /// [SetInventoryRequest.set_mask][google.cloud.retail.v2.SetInventoryRequest.set_mask]
        /// * Specifies only the desired fulfillment types and corresponding place IDs
        /// to update in
        /// [SetInventoryRequest.inventory.fulfillment_info][google.cloud.retail.v2.Product.fulfillment_info]
        /// 
        /// The caller can clear all place IDs from a subset of fulfillment types in
        /// the following ways:
        /// 
        /// * Adds "fulfillment_info" in
        /// [SetInventoryRequest.set_mask][google.cloud.retail.v2.SetInventoryRequest.set_mask]
        /// * Specifies only the desired fulfillment types to clear in
        /// [SetInventoryRequest.inventory.fulfillment_info][google.cloud.retail.v2.Product.fulfillment_info]
        /// * Checks that only the desired fulfillment info types have empty
        /// [SetInventoryRequest.inventory.fulfillment_info.place_ids][google.cloud.retail.v2.FulfillmentInfo.place_ids]
        /// 
        /// The last update time is recorded for the following inventory fields:
        /// * [Product.price_info][google.cloud.retail.v2.Product.price_info]
        /// * [Product.availability][google.cloud.retail.v2.Product.availability]
        /// * [Product.available_quantity][google.cloud.retail.v2.Product.available_quantity]
        /// * [Product.fulfillment_info][google.cloud.retail.v2.Product.fulfillment_info]
        /// 
        /// If a full overwrite of inventory information while ignoring timestamps is
        /// needed,
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// should be invoked instead.
        /// </param>
        /// <param name="setMask">
        /// Indicates which inventory fields in the provided
        /// [Product][google.cloud.retail.v2.Product] to update.
        /// 
        /// At least one field must be provided.
        /// 
        /// If an unsupported or unknown field is provided, an INVALID_ARGUMENT error
        /// is returned and the entire update will be ignored.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SetInventoryResponse, SetInventoryMetadata>> SetInventoryAsync(Product inventory, wkt::FieldMask setMask, st::CancellationToken cancellationToken) =>
            SetInventoryAsync(inventory, setMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// We recommend that you use the
        /// [ProductService.AddLocalInventories][google.cloud.retail.v2.ProductService.AddLocalInventories]
        /// method instead of the
        /// [ProductService.AddFulfillmentPlaces][google.cloud.retail.v2.ProductService.AddFulfillmentPlaces]
        /// method.
        /// [ProductService.AddLocalInventories][google.cloud.retail.v2.ProductService.AddLocalInventories]
        /// achieves the same results but provides more fine-grained control over
        /// ingesting local inventory data.
        /// 
        /// Incrementally adds place IDs to
        /// [Product.fulfillment_info.place_ids][google.cloud.retail.v2.FulfillmentInfo.place_ids].
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, the added place IDs are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata> AddFulfillmentPlaces(AddFulfillmentPlacesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// We recommend that you use the
        /// [ProductService.AddLocalInventories][google.cloud.retail.v2.ProductService.AddLocalInventories]
        /// method instead of the
        /// [ProductService.AddFulfillmentPlaces][google.cloud.retail.v2.ProductService.AddFulfillmentPlaces]
        /// method.
        /// [ProductService.AddLocalInventories][google.cloud.retail.v2.ProductService.AddLocalInventories]
        /// achieves the same results but provides more fine-grained control over
        /// ingesting local inventory data.
        /// 
        /// Incrementally adds place IDs to
        /// [Product.fulfillment_info.place_ids][google.cloud.retail.v2.FulfillmentInfo.place_ids].
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, the added place IDs are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata>> AddFulfillmentPlacesAsync(AddFulfillmentPlacesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// We recommend that you use the
        /// [ProductService.AddLocalInventories][google.cloud.retail.v2.ProductService.AddLocalInventories]
        /// method instead of the
        /// [ProductService.AddFulfillmentPlaces][google.cloud.retail.v2.ProductService.AddFulfillmentPlaces]
        /// method.
        /// [ProductService.AddLocalInventories][google.cloud.retail.v2.ProductService.AddLocalInventories]
        /// achieves the same results but provides more fine-grained control over
        /// ingesting local inventory data.
        /// 
        /// Incrementally adds place IDs to
        /// [Product.fulfillment_info.place_ids][google.cloud.retail.v2.FulfillmentInfo.place_ids].
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, the added place IDs are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata>> AddFulfillmentPlacesAsync(AddFulfillmentPlacesRequest request, st::CancellationToken cancellationToken) =>
            AddFulfillmentPlacesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AddFulfillmentPlaces</c>.</summary>
        public virtual lro::OperationsClient AddFulfillmentPlacesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AddFulfillmentPlaces</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata> PollOnceAddFulfillmentPlaces(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddFulfillmentPlacesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AddFulfillmentPlaces</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata>> PollOnceAddFulfillmentPlacesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddFulfillmentPlacesOperationsClient, callSettings);

        /// <summary>
        /// We recommend that you use the
        /// [ProductService.AddLocalInventories][google.cloud.retail.v2.ProductService.AddLocalInventories]
        /// method instead of the
        /// [ProductService.AddFulfillmentPlaces][google.cloud.retail.v2.ProductService.AddFulfillmentPlaces]
        /// method.
        /// [ProductService.AddLocalInventories][google.cloud.retail.v2.ProductService.AddLocalInventories]
        /// achieves the same results but provides more fine-grained control over
        /// ingesting local inventory data.
        /// 
        /// Incrementally adds place IDs to
        /// [Product.fulfillment_info.place_ids][google.cloud.retail.v2.FulfillmentInfo.place_ids].
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, the added place IDs are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="product">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata> AddFulfillmentPlaces(string product, gaxgrpc::CallSettings callSettings = null) =>
            AddFulfillmentPlaces(new AddFulfillmentPlacesRequest
            {
                Product = gax::GaxPreconditions.CheckNotNullOrEmpty(product, nameof(product)),
            }, callSettings);

        /// <summary>
        /// We recommend that you use the
        /// [ProductService.AddLocalInventories][google.cloud.retail.v2.ProductService.AddLocalInventories]
        /// method instead of the
        /// [ProductService.AddFulfillmentPlaces][google.cloud.retail.v2.ProductService.AddFulfillmentPlaces]
        /// method.
        /// [ProductService.AddLocalInventories][google.cloud.retail.v2.ProductService.AddLocalInventories]
        /// achieves the same results but provides more fine-grained control over
        /// ingesting local inventory data.
        /// 
        /// Incrementally adds place IDs to
        /// [Product.fulfillment_info.place_ids][google.cloud.retail.v2.FulfillmentInfo.place_ids].
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, the added place IDs are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="product">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata>> AddFulfillmentPlacesAsync(string product, gaxgrpc::CallSettings callSettings = null) =>
            AddFulfillmentPlacesAsync(new AddFulfillmentPlacesRequest
            {
                Product = gax::GaxPreconditions.CheckNotNullOrEmpty(product, nameof(product)),
            }, callSettings);

        /// <summary>
        /// We recommend that you use the
        /// [ProductService.AddLocalInventories][google.cloud.retail.v2.ProductService.AddLocalInventories]
        /// method instead of the
        /// [ProductService.AddFulfillmentPlaces][google.cloud.retail.v2.ProductService.AddFulfillmentPlaces]
        /// method.
        /// [ProductService.AddLocalInventories][google.cloud.retail.v2.ProductService.AddLocalInventories]
        /// achieves the same results but provides more fine-grained control over
        /// ingesting local inventory data.
        /// 
        /// Incrementally adds place IDs to
        /// [Product.fulfillment_info.place_ids][google.cloud.retail.v2.FulfillmentInfo.place_ids].
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, the added place IDs are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="product">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata>> AddFulfillmentPlacesAsync(string product, st::CancellationToken cancellationToken) =>
            AddFulfillmentPlacesAsync(product, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// We recommend that you use the
        /// [ProductService.AddLocalInventories][google.cloud.retail.v2.ProductService.AddLocalInventories]
        /// method instead of the
        /// [ProductService.AddFulfillmentPlaces][google.cloud.retail.v2.ProductService.AddFulfillmentPlaces]
        /// method.
        /// [ProductService.AddLocalInventories][google.cloud.retail.v2.ProductService.AddLocalInventories]
        /// achieves the same results but provides more fine-grained control over
        /// ingesting local inventory data.
        /// 
        /// Incrementally adds place IDs to
        /// [Product.fulfillment_info.place_ids][google.cloud.retail.v2.FulfillmentInfo.place_ids].
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, the added place IDs are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="product">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata> AddFulfillmentPlaces(ProductName product, gaxgrpc::CallSettings callSettings = null) =>
            AddFulfillmentPlaces(new AddFulfillmentPlacesRequest
            {
                ProductAsProductName = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
            }, callSettings);

        /// <summary>
        /// We recommend that you use the
        /// [ProductService.AddLocalInventories][google.cloud.retail.v2.ProductService.AddLocalInventories]
        /// method instead of the
        /// [ProductService.AddFulfillmentPlaces][google.cloud.retail.v2.ProductService.AddFulfillmentPlaces]
        /// method.
        /// [ProductService.AddLocalInventories][google.cloud.retail.v2.ProductService.AddLocalInventories]
        /// achieves the same results but provides more fine-grained control over
        /// ingesting local inventory data.
        /// 
        /// Incrementally adds place IDs to
        /// [Product.fulfillment_info.place_ids][google.cloud.retail.v2.FulfillmentInfo.place_ids].
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, the added place IDs are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="product">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata>> AddFulfillmentPlacesAsync(ProductName product, gaxgrpc::CallSettings callSettings = null) =>
            AddFulfillmentPlacesAsync(new AddFulfillmentPlacesRequest
            {
                ProductAsProductName = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
            }, callSettings);

        /// <summary>
        /// We recommend that you use the
        /// [ProductService.AddLocalInventories][google.cloud.retail.v2.ProductService.AddLocalInventories]
        /// method instead of the
        /// [ProductService.AddFulfillmentPlaces][google.cloud.retail.v2.ProductService.AddFulfillmentPlaces]
        /// method.
        /// [ProductService.AddLocalInventories][google.cloud.retail.v2.ProductService.AddLocalInventories]
        /// achieves the same results but provides more fine-grained control over
        /// ingesting local inventory data.
        /// 
        /// Incrementally adds place IDs to
        /// [Product.fulfillment_info.place_ids][google.cloud.retail.v2.FulfillmentInfo.place_ids].
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, the added place IDs are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="product">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata>> AddFulfillmentPlacesAsync(ProductName product, st::CancellationToken cancellationToken) =>
            AddFulfillmentPlacesAsync(product, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// We recommend that you use the
        /// [ProductService.RemoveLocalInventories][google.cloud.retail.v2.ProductService.RemoveLocalInventories]
        /// method instead of the
        /// [ProductService.RemoveFulfillmentPlaces][google.cloud.retail.v2.ProductService.RemoveFulfillmentPlaces]
        /// method.
        /// [ProductService.RemoveLocalInventories][google.cloud.retail.v2.ProductService.RemoveLocalInventories]
        /// achieves the same results but provides more fine-grained control over
        /// ingesting local inventory data.
        /// 
        /// Incrementally removes place IDs from a
        /// [Product.fulfillment_info.place_ids][google.cloud.retail.v2.FulfillmentInfo.place_ids].
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, the removed place IDs are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> RemoveFulfillmentPlaces(RemoveFulfillmentPlacesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// We recommend that you use the
        /// [ProductService.RemoveLocalInventories][google.cloud.retail.v2.ProductService.RemoveLocalInventories]
        /// method instead of the
        /// [ProductService.RemoveFulfillmentPlaces][google.cloud.retail.v2.ProductService.RemoveFulfillmentPlaces]
        /// method.
        /// [ProductService.RemoveLocalInventories][google.cloud.retail.v2.ProductService.RemoveLocalInventories]
        /// achieves the same results but provides more fine-grained control over
        /// ingesting local inventory data.
        /// 
        /// Incrementally removes place IDs from a
        /// [Product.fulfillment_info.place_ids][google.cloud.retail.v2.FulfillmentInfo.place_ids].
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, the removed place IDs are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata>> RemoveFulfillmentPlacesAsync(RemoveFulfillmentPlacesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// We recommend that you use the
        /// [ProductService.RemoveLocalInventories][google.cloud.retail.v2.ProductService.RemoveLocalInventories]
        /// method instead of the
        /// [ProductService.RemoveFulfillmentPlaces][google.cloud.retail.v2.ProductService.RemoveFulfillmentPlaces]
        /// method.
        /// [ProductService.RemoveLocalInventories][google.cloud.retail.v2.ProductService.RemoveLocalInventories]
        /// achieves the same results but provides more fine-grained control over
        /// ingesting local inventory data.
        /// 
        /// Incrementally removes place IDs from a
        /// [Product.fulfillment_info.place_ids][google.cloud.retail.v2.FulfillmentInfo.place_ids].
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, the removed place IDs are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata>> RemoveFulfillmentPlacesAsync(RemoveFulfillmentPlacesRequest request, st::CancellationToken cancellationToken) =>
            RemoveFulfillmentPlacesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RemoveFulfillmentPlaces</c>.</summary>
        public virtual lro::OperationsClient RemoveFulfillmentPlacesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RemoveFulfillmentPlaces</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> PollOnceRemoveFulfillmentPlaces(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveFulfillmentPlacesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RemoveFulfillmentPlaces</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata>> PollOnceRemoveFulfillmentPlacesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveFulfillmentPlacesOperationsClient, callSettings);

        /// <summary>
        /// We recommend that you use the
        /// [ProductService.RemoveLocalInventories][google.cloud.retail.v2.ProductService.RemoveLocalInventories]
        /// method instead of the
        /// [ProductService.RemoveFulfillmentPlaces][google.cloud.retail.v2.ProductService.RemoveFulfillmentPlaces]
        /// method.
        /// [ProductService.RemoveLocalInventories][google.cloud.retail.v2.ProductService.RemoveLocalInventories]
        /// achieves the same results but provides more fine-grained control over
        /// ingesting local inventory data.
        /// 
        /// Incrementally removes place IDs from a
        /// [Product.fulfillment_info.place_ids][google.cloud.retail.v2.FulfillmentInfo.place_ids].
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, the removed place IDs are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="product">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> RemoveFulfillmentPlaces(string product, gaxgrpc::CallSettings callSettings = null) =>
            RemoveFulfillmentPlaces(new RemoveFulfillmentPlacesRequest
            {
                Product = gax::GaxPreconditions.CheckNotNullOrEmpty(product, nameof(product)),
            }, callSettings);

        /// <summary>
        /// We recommend that you use the
        /// [ProductService.RemoveLocalInventories][google.cloud.retail.v2.ProductService.RemoveLocalInventories]
        /// method instead of the
        /// [ProductService.RemoveFulfillmentPlaces][google.cloud.retail.v2.ProductService.RemoveFulfillmentPlaces]
        /// method.
        /// [ProductService.RemoveLocalInventories][google.cloud.retail.v2.ProductService.RemoveLocalInventories]
        /// achieves the same results but provides more fine-grained control over
        /// ingesting local inventory data.
        /// 
        /// Incrementally removes place IDs from a
        /// [Product.fulfillment_info.place_ids][google.cloud.retail.v2.FulfillmentInfo.place_ids].
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, the removed place IDs are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="product">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata>> RemoveFulfillmentPlacesAsync(string product, gaxgrpc::CallSettings callSettings = null) =>
            RemoveFulfillmentPlacesAsync(new RemoveFulfillmentPlacesRequest
            {
                Product = gax::GaxPreconditions.CheckNotNullOrEmpty(product, nameof(product)),
            }, callSettings);

        /// <summary>
        /// We recommend that you use the
        /// [ProductService.RemoveLocalInventories][google.cloud.retail.v2.ProductService.RemoveLocalInventories]
        /// method instead of the
        /// [ProductService.RemoveFulfillmentPlaces][google.cloud.retail.v2.ProductService.RemoveFulfillmentPlaces]
        /// method.
        /// [ProductService.RemoveLocalInventories][google.cloud.retail.v2.ProductService.RemoveLocalInventories]
        /// achieves the same results but provides more fine-grained control over
        /// ingesting local inventory data.
        /// 
        /// Incrementally removes place IDs from a
        /// [Product.fulfillment_info.place_ids][google.cloud.retail.v2.FulfillmentInfo.place_ids].
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, the removed place IDs are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="product">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata>> RemoveFulfillmentPlacesAsync(string product, st::CancellationToken cancellationToken) =>
            RemoveFulfillmentPlacesAsync(product, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// We recommend that you use the
        /// [ProductService.RemoveLocalInventories][google.cloud.retail.v2.ProductService.RemoveLocalInventories]
        /// method instead of the
        /// [ProductService.RemoveFulfillmentPlaces][google.cloud.retail.v2.ProductService.RemoveFulfillmentPlaces]
        /// method.
        /// [ProductService.RemoveLocalInventories][google.cloud.retail.v2.ProductService.RemoveLocalInventories]
        /// achieves the same results but provides more fine-grained control over
        /// ingesting local inventory data.
        /// 
        /// Incrementally removes place IDs from a
        /// [Product.fulfillment_info.place_ids][google.cloud.retail.v2.FulfillmentInfo.place_ids].
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, the removed place IDs are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="product">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> RemoveFulfillmentPlaces(ProductName product, gaxgrpc::CallSettings callSettings = null) =>
            RemoveFulfillmentPlaces(new RemoveFulfillmentPlacesRequest
            {
                ProductAsProductName = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
            }, callSettings);

        /// <summary>
        /// We recommend that you use the
        /// [ProductService.RemoveLocalInventories][google.cloud.retail.v2.ProductService.RemoveLocalInventories]
        /// method instead of the
        /// [ProductService.RemoveFulfillmentPlaces][google.cloud.retail.v2.ProductService.RemoveFulfillmentPlaces]
        /// method.
        /// [ProductService.RemoveLocalInventories][google.cloud.retail.v2.ProductService.RemoveLocalInventories]
        /// achieves the same results but provides more fine-grained control over
        /// ingesting local inventory data.
        /// 
        /// Incrementally removes place IDs from a
        /// [Product.fulfillment_info.place_ids][google.cloud.retail.v2.FulfillmentInfo.place_ids].
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, the removed place IDs are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="product">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata>> RemoveFulfillmentPlacesAsync(ProductName product, gaxgrpc::CallSettings callSettings = null) =>
            RemoveFulfillmentPlacesAsync(new RemoveFulfillmentPlacesRequest
            {
                ProductAsProductName = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
            }, callSettings);

        /// <summary>
        /// We recommend that you use the
        /// [ProductService.RemoveLocalInventories][google.cloud.retail.v2.ProductService.RemoveLocalInventories]
        /// method instead of the
        /// [ProductService.RemoveFulfillmentPlaces][google.cloud.retail.v2.ProductService.RemoveFulfillmentPlaces]
        /// method.
        /// [ProductService.RemoveLocalInventories][google.cloud.retail.v2.ProductService.RemoveLocalInventories]
        /// achieves the same results but provides more fine-grained control over
        /// ingesting local inventory data.
        /// 
        /// Incrementally removes place IDs from a
        /// [Product.fulfillment_info.place_ids][google.cloud.retail.v2.FulfillmentInfo.place_ids].
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, the removed place IDs are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="product">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata>> RemoveFulfillmentPlacesAsync(ProductName product, st::CancellationToken cancellationToken) =>
            RemoveFulfillmentPlacesAsync(product, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates local inventory information for a
        /// [Product][google.cloud.retail.v2.Product] at a list of places, while
        /// respecting the last update timestamps of each inventory field.
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// inventory information. If the request is valid, the update will be enqueued
        /// and processed downstream. As a consequence, when a response is returned,
        /// updates are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Local inventory information can only be modified using this method.
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// has no effect on local inventories.
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata> AddLocalInventories(AddLocalInventoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates local inventory information for a
        /// [Product][google.cloud.retail.v2.Product] at a list of places, while
        /// respecting the last update timestamps of each inventory field.
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// inventory information. If the request is valid, the update will be enqueued
        /// and processed downstream. As a consequence, when a response is returned,
        /// updates are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Local inventory information can only be modified using this method.
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// has no effect on local inventories.
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata>> AddLocalInventoriesAsync(AddLocalInventoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates local inventory information for a
        /// [Product][google.cloud.retail.v2.Product] at a list of places, while
        /// respecting the last update timestamps of each inventory field.
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// inventory information. If the request is valid, the update will be enqueued
        /// and processed downstream. As a consequence, when a response is returned,
        /// updates are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Local inventory information can only be modified using this method.
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// has no effect on local inventories.
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata>> AddLocalInventoriesAsync(AddLocalInventoriesRequest request, st::CancellationToken cancellationToken) =>
            AddLocalInventoriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AddLocalInventories</c>.</summary>
        public virtual lro::OperationsClient AddLocalInventoriesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AddLocalInventories</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata> PollOnceAddLocalInventories(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddLocalInventoriesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AddLocalInventories</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata>> PollOnceAddLocalInventoriesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddLocalInventoriesOperationsClient, callSettings);

        /// <summary>
        /// Updates local inventory information for a
        /// [Product][google.cloud.retail.v2.Product] at a list of places, while
        /// respecting the last update timestamps of each inventory field.
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// inventory information. If the request is valid, the update will be enqueued
        /// and processed downstream. As a consequence, when a response is returned,
        /// updates are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Local inventory information can only be modified using this method.
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// has no effect on local inventories.
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="product">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata> AddLocalInventories(string product, gaxgrpc::CallSettings callSettings = null) =>
            AddLocalInventories(new AddLocalInventoriesRequest
            {
                Product = gax::GaxPreconditions.CheckNotNullOrEmpty(product, nameof(product)),
            }, callSettings);

        /// <summary>
        /// Updates local inventory information for a
        /// [Product][google.cloud.retail.v2.Product] at a list of places, while
        /// respecting the last update timestamps of each inventory field.
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// inventory information. If the request is valid, the update will be enqueued
        /// and processed downstream. As a consequence, when a response is returned,
        /// updates are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Local inventory information can only be modified using this method.
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// has no effect on local inventories.
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="product">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata>> AddLocalInventoriesAsync(string product, gaxgrpc::CallSettings callSettings = null) =>
            AddLocalInventoriesAsync(new AddLocalInventoriesRequest
            {
                Product = gax::GaxPreconditions.CheckNotNullOrEmpty(product, nameof(product)),
            }, callSettings);

        /// <summary>
        /// Updates local inventory information for a
        /// [Product][google.cloud.retail.v2.Product] at a list of places, while
        /// respecting the last update timestamps of each inventory field.
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// inventory information. If the request is valid, the update will be enqueued
        /// and processed downstream. As a consequence, when a response is returned,
        /// updates are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Local inventory information can only be modified using this method.
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// has no effect on local inventories.
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="product">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata>> AddLocalInventoriesAsync(string product, st::CancellationToken cancellationToken) =>
            AddLocalInventoriesAsync(product, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates local inventory information for a
        /// [Product][google.cloud.retail.v2.Product] at a list of places, while
        /// respecting the last update timestamps of each inventory field.
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// inventory information. If the request is valid, the update will be enqueued
        /// and processed downstream. As a consequence, when a response is returned,
        /// updates are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Local inventory information can only be modified using this method.
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// has no effect on local inventories.
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="product">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata> AddLocalInventories(ProductName product, gaxgrpc::CallSettings callSettings = null) =>
            AddLocalInventories(new AddLocalInventoriesRequest
            {
                ProductAsProductName = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
            }, callSettings);

        /// <summary>
        /// Updates local inventory information for a
        /// [Product][google.cloud.retail.v2.Product] at a list of places, while
        /// respecting the last update timestamps of each inventory field.
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// inventory information. If the request is valid, the update will be enqueued
        /// and processed downstream. As a consequence, when a response is returned,
        /// updates are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Local inventory information can only be modified using this method.
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// has no effect on local inventories.
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="product">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata>> AddLocalInventoriesAsync(ProductName product, gaxgrpc::CallSettings callSettings = null) =>
            AddLocalInventoriesAsync(new AddLocalInventoriesRequest
            {
                ProductAsProductName = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
            }, callSettings);

        /// <summary>
        /// Updates local inventory information for a
        /// [Product][google.cloud.retail.v2.Product] at a list of places, while
        /// respecting the last update timestamps of each inventory field.
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// inventory information. If the request is valid, the update will be enqueued
        /// and processed downstream. As a consequence, when a response is returned,
        /// updates are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Local inventory information can only be modified using this method.
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// has no effect on local inventories.
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="product">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata>> AddLocalInventoriesAsync(ProductName product, st::CancellationToken cancellationToken) =>
            AddLocalInventoriesAsync(product, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Remove local inventory information for a
        /// [Product][google.cloud.retail.v2.Product] at a list of places at a removal
        /// timestamp.
        /// 
        /// This process is asynchronous. If the request is valid, the removal will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, removals are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Local inventory information can only be removed using this method.
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// has no effect on local inventories.
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> RemoveLocalInventories(RemoveLocalInventoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Remove local inventory information for a
        /// [Product][google.cloud.retail.v2.Product] at a list of places at a removal
        /// timestamp.
        /// 
        /// This process is asynchronous. If the request is valid, the removal will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, removals are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Local inventory information can only be removed using this method.
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// has no effect on local inventories.
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata>> RemoveLocalInventoriesAsync(RemoveLocalInventoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Remove local inventory information for a
        /// [Product][google.cloud.retail.v2.Product] at a list of places at a removal
        /// timestamp.
        /// 
        /// This process is asynchronous. If the request is valid, the removal will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, removals are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Local inventory information can only be removed using this method.
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// has no effect on local inventories.
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata>> RemoveLocalInventoriesAsync(RemoveLocalInventoriesRequest request, st::CancellationToken cancellationToken) =>
            RemoveLocalInventoriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RemoveLocalInventories</c>.</summary>
        public virtual lro::OperationsClient RemoveLocalInventoriesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RemoveLocalInventories</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> PollOnceRemoveLocalInventories(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveLocalInventoriesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RemoveLocalInventories</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata>> PollOnceRemoveLocalInventoriesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveLocalInventoriesOperationsClient, callSettings);

        /// <summary>
        /// Remove local inventory information for a
        /// [Product][google.cloud.retail.v2.Product] at a list of places at a removal
        /// timestamp.
        /// 
        /// This process is asynchronous. If the request is valid, the removal will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, removals are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Local inventory information can only be removed using this method.
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// has no effect on local inventories.
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="product">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> RemoveLocalInventories(string product, gaxgrpc::CallSettings callSettings = null) =>
            RemoveLocalInventories(new RemoveLocalInventoriesRequest
            {
                Product = gax::GaxPreconditions.CheckNotNullOrEmpty(product, nameof(product)),
            }, callSettings);

        /// <summary>
        /// Remove local inventory information for a
        /// [Product][google.cloud.retail.v2.Product] at a list of places at a removal
        /// timestamp.
        /// 
        /// This process is asynchronous. If the request is valid, the removal will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, removals are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Local inventory information can only be removed using this method.
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// has no effect on local inventories.
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="product">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata>> RemoveLocalInventoriesAsync(string product, gaxgrpc::CallSettings callSettings = null) =>
            RemoveLocalInventoriesAsync(new RemoveLocalInventoriesRequest
            {
                Product = gax::GaxPreconditions.CheckNotNullOrEmpty(product, nameof(product)),
            }, callSettings);

        /// <summary>
        /// Remove local inventory information for a
        /// [Product][google.cloud.retail.v2.Product] at a list of places at a removal
        /// timestamp.
        /// 
        /// This process is asynchronous. If the request is valid, the removal will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, removals are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Local inventory information can only be removed using this method.
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// has no effect on local inventories.
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="product">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata>> RemoveLocalInventoriesAsync(string product, st::CancellationToken cancellationToken) =>
            RemoveLocalInventoriesAsync(product, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Remove local inventory information for a
        /// [Product][google.cloud.retail.v2.Product] at a list of places at a removal
        /// timestamp.
        /// 
        /// This process is asynchronous. If the request is valid, the removal will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, removals are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Local inventory information can only be removed using this method.
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// has no effect on local inventories.
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="product">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> RemoveLocalInventories(ProductName product, gaxgrpc::CallSettings callSettings = null) =>
            RemoveLocalInventories(new RemoveLocalInventoriesRequest
            {
                ProductAsProductName = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
            }, callSettings);

        /// <summary>
        /// Remove local inventory information for a
        /// [Product][google.cloud.retail.v2.Product] at a list of places at a removal
        /// timestamp.
        /// 
        /// This process is asynchronous. If the request is valid, the removal will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, removals are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Local inventory information can only be removed using this method.
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// has no effect on local inventories.
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="product">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata>> RemoveLocalInventoriesAsync(ProductName product, gaxgrpc::CallSettings callSettings = null) =>
            RemoveLocalInventoriesAsync(new RemoveLocalInventoriesRequest
            {
                ProductAsProductName = gax::GaxPreconditions.CheckNotNull(product, nameof(product)),
            }, callSettings);

        /// <summary>
        /// Remove local inventory information for a
        /// [Product][google.cloud.retail.v2.Product] at a list of places at a removal
        /// timestamp.
        /// 
        /// This process is asynchronous. If the request is valid, the removal will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, removals are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Local inventory information can only be removed using this method.
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// has no effect on local inventories.
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="product">
        /// Required. Full resource name of [Product][google.cloud.retail.v2.Product],
        /// such as
        /// `projects/*/locations/global/catalogs/default_catalog/branches/default_branch/products/some_product_id`.
        /// 
        /// If the caller does not have permission to access the
        /// [Product][google.cloud.retail.v2.Product], regardless of whether or not it
        /// exists, a PERMISSION_DENIED error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata>> RemoveLocalInventoriesAsync(ProductName product, st::CancellationToken cancellationToken) =>
            RemoveLocalInventoriesAsync(product, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ProductService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for ingesting [Product][google.cloud.retail.v2.Product] information
    /// of the customer's website.
    /// </remarks>
    public sealed partial class ProductServiceClientImpl : ProductServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateProductRequest, Product> _callCreateProduct;

        private readonly gaxgrpc::ApiCall<GetProductRequest, Product> _callGetProduct;

        private readonly gaxgrpc::ApiCall<ListProductsRequest, ListProductsResponse> _callListProducts;

        private readonly gaxgrpc::ApiCall<UpdateProductRequest, Product> _callUpdateProduct;

        private readonly gaxgrpc::ApiCall<DeleteProductRequest, wkt::Empty> _callDeleteProduct;

        private readonly gaxgrpc::ApiCall<PurgeProductsRequest, lro::Operation> _callPurgeProducts;

        private readonly gaxgrpc::ApiCall<ImportProductsRequest, lro::Operation> _callImportProducts;

        private readonly gaxgrpc::ApiCall<SetInventoryRequest, lro::Operation> _callSetInventory;

        private readonly gaxgrpc::ApiCall<AddFulfillmentPlacesRequest, lro::Operation> _callAddFulfillmentPlaces;

        private readonly gaxgrpc::ApiCall<RemoveFulfillmentPlacesRequest, lro::Operation> _callRemoveFulfillmentPlaces;

        private readonly gaxgrpc::ApiCall<AddLocalInventoriesRequest, lro::Operation> _callAddLocalInventories;

        private readonly gaxgrpc::ApiCall<RemoveLocalInventoriesRequest, lro::Operation> _callRemoveLocalInventories;

        /// <summary>
        /// Constructs a client wrapper for the ProductService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ProductServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ProductServiceClientImpl(ProductService.ProductServiceClient grpcClient, ProductServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ProductServiceSettings effectiveSettings = settings ?? ProductServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            PurgeProductsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.PurgeProductsOperationsSettings, logger);
            ImportProductsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportProductsOperationsSettings, logger);
            SetInventoryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SetInventoryOperationsSettings, logger);
            AddFulfillmentPlacesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.AddFulfillmentPlacesOperationsSettings, logger);
            RemoveFulfillmentPlacesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RemoveFulfillmentPlacesOperationsSettings, logger);
            AddLocalInventoriesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.AddLocalInventoriesOperationsSettings, logger);
            RemoveLocalInventoriesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RemoveLocalInventoriesOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateProduct = clientHelper.BuildApiCall<CreateProductRequest, Product>("CreateProduct", grpcClient.CreateProductAsync, grpcClient.CreateProduct, effectiveSettings.CreateProductSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateProduct);
            Modify_CreateProductApiCall(ref _callCreateProduct);
            _callGetProduct = clientHelper.BuildApiCall<GetProductRequest, Product>("GetProduct", grpcClient.GetProductAsync, grpcClient.GetProduct, effectiveSettings.GetProductSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProduct);
            Modify_GetProductApiCall(ref _callGetProduct);
            _callListProducts = clientHelper.BuildApiCall<ListProductsRequest, ListProductsResponse>("ListProducts", grpcClient.ListProductsAsync, grpcClient.ListProducts, effectiveSettings.ListProductsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListProducts);
            Modify_ListProductsApiCall(ref _callListProducts);
            _callUpdateProduct = clientHelper.BuildApiCall<UpdateProductRequest, Product>("UpdateProduct", grpcClient.UpdateProductAsync, grpcClient.UpdateProduct, effectiveSettings.UpdateProductSettings).WithGoogleRequestParam("product.name", request => request.Product?.Name);
            Modify_ApiCall(ref _callUpdateProduct);
            Modify_UpdateProductApiCall(ref _callUpdateProduct);
            _callDeleteProduct = clientHelper.BuildApiCall<DeleteProductRequest, wkt::Empty>("DeleteProduct", grpcClient.DeleteProductAsync, grpcClient.DeleteProduct, effectiveSettings.DeleteProductSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteProduct);
            Modify_DeleteProductApiCall(ref _callDeleteProduct);
            _callPurgeProducts = clientHelper.BuildApiCall<PurgeProductsRequest, lro::Operation>("PurgeProducts", grpcClient.PurgeProductsAsync, grpcClient.PurgeProducts, effectiveSettings.PurgeProductsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callPurgeProducts);
            Modify_PurgeProductsApiCall(ref _callPurgeProducts);
            _callImportProducts = clientHelper.BuildApiCall<ImportProductsRequest, lro::Operation>("ImportProducts", grpcClient.ImportProductsAsync, grpcClient.ImportProducts, effectiveSettings.ImportProductsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportProducts);
            Modify_ImportProductsApiCall(ref _callImportProducts);
            _callSetInventory = clientHelper.BuildApiCall<SetInventoryRequest, lro::Operation>("SetInventory", grpcClient.SetInventoryAsync, grpcClient.SetInventory, effectiveSettings.SetInventorySettings).WithGoogleRequestParam("inventory.name", request => request.Inventory?.Name);
            Modify_ApiCall(ref _callSetInventory);
            Modify_SetInventoryApiCall(ref _callSetInventory);
            _callAddFulfillmentPlaces = clientHelper.BuildApiCall<AddFulfillmentPlacesRequest, lro::Operation>("AddFulfillmentPlaces", grpcClient.AddFulfillmentPlacesAsync, grpcClient.AddFulfillmentPlaces, effectiveSettings.AddFulfillmentPlacesSettings).WithGoogleRequestParam("product", request => request.Product);
            Modify_ApiCall(ref _callAddFulfillmentPlaces);
            Modify_AddFulfillmentPlacesApiCall(ref _callAddFulfillmentPlaces);
            _callRemoveFulfillmentPlaces = clientHelper.BuildApiCall<RemoveFulfillmentPlacesRequest, lro::Operation>("RemoveFulfillmentPlaces", grpcClient.RemoveFulfillmentPlacesAsync, grpcClient.RemoveFulfillmentPlaces, effectiveSettings.RemoveFulfillmentPlacesSettings).WithGoogleRequestParam("product", request => request.Product);
            Modify_ApiCall(ref _callRemoveFulfillmentPlaces);
            Modify_RemoveFulfillmentPlacesApiCall(ref _callRemoveFulfillmentPlaces);
            _callAddLocalInventories = clientHelper.BuildApiCall<AddLocalInventoriesRequest, lro::Operation>("AddLocalInventories", grpcClient.AddLocalInventoriesAsync, grpcClient.AddLocalInventories, effectiveSettings.AddLocalInventoriesSettings).WithGoogleRequestParam("product", request => request.Product);
            Modify_ApiCall(ref _callAddLocalInventories);
            Modify_AddLocalInventoriesApiCall(ref _callAddLocalInventories);
            _callRemoveLocalInventories = clientHelper.BuildApiCall<RemoveLocalInventoriesRequest, lro::Operation>("RemoveLocalInventories", grpcClient.RemoveLocalInventoriesAsync, grpcClient.RemoveLocalInventories, effectiveSettings.RemoveLocalInventoriesSettings).WithGoogleRequestParam("product", request => request.Product);
            Modify_ApiCall(ref _callRemoveLocalInventories);
            Modify_RemoveLocalInventoriesApiCall(ref _callRemoveLocalInventories);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateProductApiCall(ref gaxgrpc::ApiCall<CreateProductRequest, Product> call);

        partial void Modify_GetProductApiCall(ref gaxgrpc::ApiCall<GetProductRequest, Product> call);

        partial void Modify_ListProductsApiCall(ref gaxgrpc::ApiCall<ListProductsRequest, ListProductsResponse> call);

        partial void Modify_UpdateProductApiCall(ref gaxgrpc::ApiCall<UpdateProductRequest, Product> call);

        partial void Modify_DeleteProductApiCall(ref gaxgrpc::ApiCall<DeleteProductRequest, wkt::Empty> call);

        partial void Modify_PurgeProductsApiCall(ref gaxgrpc::ApiCall<PurgeProductsRequest, lro::Operation> call);

        partial void Modify_ImportProductsApiCall(ref gaxgrpc::ApiCall<ImportProductsRequest, lro::Operation> call);

        partial void Modify_SetInventoryApiCall(ref gaxgrpc::ApiCall<SetInventoryRequest, lro::Operation> call);

        partial void Modify_AddFulfillmentPlacesApiCall(ref gaxgrpc::ApiCall<AddFulfillmentPlacesRequest, lro::Operation> call);

        partial void Modify_RemoveFulfillmentPlacesApiCall(ref gaxgrpc::ApiCall<RemoveFulfillmentPlacesRequest, lro::Operation> call);

        partial void Modify_AddLocalInventoriesApiCall(ref gaxgrpc::ApiCall<AddLocalInventoriesRequest, lro::Operation> call);

        partial void Modify_RemoveLocalInventoriesApiCall(ref gaxgrpc::ApiCall<RemoveLocalInventoriesRequest, lro::Operation> call);

        partial void OnConstruction(ProductService.ProductServiceClient grpcClient, ProductServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ProductService client</summary>
        public override ProductService.ProductServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateProductRequest(ref CreateProductRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetProductRequest(ref GetProductRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProductsRequest(ref ListProductsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateProductRequest(ref UpdateProductRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteProductRequest(ref DeleteProductRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PurgeProductsRequest(ref PurgeProductsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportProductsRequest(ref ImportProductsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetInventoryRequest(ref SetInventoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddFulfillmentPlacesRequest(ref AddFulfillmentPlacesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveFulfillmentPlacesRequest(ref RemoveFulfillmentPlacesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddLocalInventoriesRequest(ref AddLocalInventoriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveLocalInventoriesRequest(ref RemoveLocalInventoriesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a [Product][google.cloud.retail.v2.Product].
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
        /// Creates a [Product][google.cloud.retail.v2.Product].
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
        /// Gets a [Product][google.cloud.retail.v2.Product].
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
        /// Gets a [Product][google.cloud.retail.v2.Product].
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
        /// Gets a list of [Product][google.cloud.retail.v2.Product]s.
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
        /// Gets a list of [Product][google.cloud.retail.v2.Product]s.
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
        /// Updates a [Product][google.cloud.retail.v2.Product].
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
        /// Updates a [Product][google.cloud.retail.v2.Product].
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
        /// Deletes a [Product][google.cloud.retail.v2.Product].
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
        /// Deletes a [Product][google.cloud.retail.v2.Product].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteProductAsync(DeleteProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProductRequest(ref request, ref callSettings);
            return _callDeleteProduct.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>PurgeProducts</c>.</summary>
        public override lro::OperationsClient PurgeProductsOperationsClient { get; }

        /// <summary>
        /// Permanently deletes all selected [Product][google.cloud.retail.v2.Product]s
        /// under a branch.
        /// 
        /// This process is asynchronous. If the request is valid, the removal will be
        /// enqueued and processed offline. Depending on the number of
        /// [Product][google.cloud.retail.v2.Product]s, this operation could take hours
        /// to complete. Before the operation completes, some
        /// [Product][google.cloud.retail.v2.Product]s may still be returned by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Depending on the number of [Product][google.cloud.retail.v2.Product]s, this
        /// operation could take hours to complete. To get a sample of
        /// [Product][google.cloud.retail.v2.Product]s that would be deleted, set
        /// [PurgeProductsRequest.force][google.cloud.retail.v2.PurgeProductsRequest.force]
        /// to false.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PurgeProductsResponse, PurgeProductsMetadata> PurgeProducts(PurgeProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PurgeProductsRequest(ref request, ref callSettings);
            return new lro::Operation<PurgeProductsResponse, PurgeProductsMetadata>(_callPurgeProducts.Sync(request, callSettings), PurgeProductsOperationsClient);
        }

        /// <summary>
        /// Permanently deletes all selected [Product][google.cloud.retail.v2.Product]s
        /// under a branch.
        /// 
        /// This process is asynchronous. If the request is valid, the removal will be
        /// enqueued and processed offline. Depending on the number of
        /// [Product][google.cloud.retail.v2.Product]s, this operation could take hours
        /// to complete. Before the operation completes, some
        /// [Product][google.cloud.retail.v2.Product]s may still be returned by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Depending on the number of [Product][google.cloud.retail.v2.Product]s, this
        /// operation could take hours to complete. To get a sample of
        /// [Product][google.cloud.retail.v2.Product]s that would be deleted, set
        /// [PurgeProductsRequest.force][google.cloud.retail.v2.PurgeProductsRequest.force]
        /// to false.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PurgeProductsResponse, PurgeProductsMetadata>> PurgeProductsAsync(PurgeProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PurgeProductsRequest(ref request, ref callSettings);
            return new lro::Operation<PurgeProductsResponse, PurgeProductsMetadata>(await _callPurgeProducts.Async(request, callSettings).ConfigureAwait(false), PurgeProductsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ImportProducts</c>.</summary>
        public override lro::OperationsClient ImportProductsOperationsClient { get; }

        /// <summary>
        /// Bulk import of multiple [Product][google.cloud.retail.v2.Product]s.
        /// 
        /// Request processing may be synchronous.
        /// Non-existing items are created.
        /// 
        /// Note that it is possible for a subset of the
        /// [Product][google.cloud.retail.v2.Product]s to be successfully updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportProductsResponse, ImportMetadata> ImportProducts(ImportProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportProductsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportProductsResponse, ImportMetadata>(_callImportProducts.Sync(request, callSettings), ImportProductsOperationsClient);
        }

        /// <summary>
        /// Bulk import of multiple [Product][google.cloud.retail.v2.Product]s.
        /// 
        /// Request processing may be synchronous.
        /// Non-existing items are created.
        /// 
        /// Note that it is possible for a subset of the
        /// [Product][google.cloud.retail.v2.Product]s to be successfully updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportProductsResponse, ImportMetadata>> ImportProductsAsync(ImportProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportProductsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportProductsResponse, ImportMetadata>(await _callImportProducts.Async(request, callSettings).ConfigureAwait(false), ImportProductsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetInventory</c>.</summary>
        public override lro::OperationsClient SetInventoryOperationsClient { get; }

        /// <summary>
        /// Updates inventory information for a
        /// [Product][google.cloud.retail.v2.Product] while respecting the last update
        /// timestamps of each inventory field.
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update is enqueued
        /// and processed downstream. As a consequence, when a response is returned,
        /// updates are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// When inventory is updated with
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct],
        /// the specified inventory field value(s) overwrite any existing value(s)
        /// while ignoring the last update time for this field. Furthermore, the last
        /// update times for the specified inventory fields are overwritten by the
        /// times of the
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// or
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// request.
        /// 
        /// If no inventory fields are set in
        /// [CreateProductRequest.product][google.cloud.retail.v2.CreateProductRequest.product],
        /// then any pre-existing inventory information for this product is used.
        /// 
        /// If no inventory fields are set in
        /// [SetInventoryRequest.set_mask][google.cloud.retail.v2.SetInventoryRequest.set_mask],
        /// then any existing inventory information is preserved.
        /// 
        /// Pre-existing inventory information can only be updated with
        /// [ProductService.SetInventory][google.cloud.retail.v2.ProductService.SetInventory],
        /// [ProductService.AddFulfillmentPlaces][google.cloud.retail.v2.ProductService.AddFulfillmentPlaces],
        /// and
        /// [ProductService.RemoveFulfillmentPlaces][google.cloud.retail.v2.ProductService.RemoveFulfillmentPlaces].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s is obsolete after
        /// one day, and the [GetOperation][google.longrunning.Operations.GetOperation]
        /// API returns `NOT_FOUND` afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates are not marked as [done][google.longrunning.Operation.done] until
        /// they are obsolete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<SetInventoryResponse, SetInventoryMetadata> SetInventory(SetInventoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetInventoryRequest(ref request, ref callSettings);
            return new lro::Operation<SetInventoryResponse, SetInventoryMetadata>(_callSetInventory.Sync(request, callSettings), SetInventoryOperationsClient);
        }

        /// <summary>
        /// Updates inventory information for a
        /// [Product][google.cloud.retail.v2.Product] while respecting the last update
        /// timestamps of each inventory field.
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update is enqueued
        /// and processed downstream. As a consequence, when a response is returned,
        /// updates are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// When inventory is updated with
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct],
        /// the specified inventory field value(s) overwrite any existing value(s)
        /// while ignoring the last update time for this field. Furthermore, the last
        /// update times for the specified inventory fields are overwritten by the
        /// times of the
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// or
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// request.
        /// 
        /// If no inventory fields are set in
        /// [CreateProductRequest.product][google.cloud.retail.v2.CreateProductRequest.product],
        /// then any pre-existing inventory information for this product is used.
        /// 
        /// If no inventory fields are set in
        /// [SetInventoryRequest.set_mask][google.cloud.retail.v2.SetInventoryRequest.set_mask],
        /// then any existing inventory information is preserved.
        /// 
        /// Pre-existing inventory information can only be updated with
        /// [ProductService.SetInventory][google.cloud.retail.v2.ProductService.SetInventory],
        /// [ProductService.AddFulfillmentPlaces][google.cloud.retail.v2.ProductService.AddFulfillmentPlaces],
        /// and
        /// [ProductService.RemoveFulfillmentPlaces][google.cloud.retail.v2.ProductService.RemoveFulfillmentPlaces].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s is obsolete after
        /// one day, and the [GetOperation][google.longrunning.Operations.GetOperation]
        /// API returns `NOT_FOUND` afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates are not marked as [done][google.longrunning.Operation.done] until
        /// they are obsolete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<SetInventoryResponse, SetInventoryMetadata>> SetInventoryAsync(SetInventoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetInventoryRequest(ref request, ref callSettings);
            return new lro::Operation<SetInventoryResponse, SetInventoryMetadata>(await _callSetInventory.Async(request, callSettings).ConfigureAwait(false), SetInventoryOperationsClient);
        }

        /// <summary>The long-running operations client for <c>AddFulfillmentPlaces</c>.</summary>
        public override lro::OperationsClient AddFulfillmentPlacesOperationsClient { get; }

        /// <summary>
        /// We recommend that you use the
        /// [ProductService.AddLocalInventories][google.cloud.retail.v2.ProductService.AddLocalInventories]
        /// method instead of the
        /// [ProductService.AddFulfillmentPlaces][google.cloud.retail.v2.ProductService.AddFulfillmentPlaces]
        /// method.
        /// [ProductService.AddLocalInventories][google.cloud.retail.v2.ProductService.AddLocalInventories]
        /// achieves the same results but provides more fine-grained control over
        /// ingesting local inventory data.
        /// 
        /// Incrementally adds place IDs to
        /// [Product.fulfillment_info.place_ids][google.cloud.retail.v2.FulfillmentInfo.place_ids].
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, the added place IDs are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata> AddFulfillmentPlaces(AddFulfillmentPlacesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddFulfillmentPlacesRequest(ref request, ref callSettings);
            return new lro::Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata>(_callAddFulfillmentPlaces.Sync(request, callSettings), AddFulfillmentPlacesOperationsClient);
        }

        /// <summary>
        /// We recommend that you use the
        /// [ProductService.AddLocalInventories][google.cloud.retail.v2.ProductService.AddLocalInventories]
        /// method instead of the
        /// [ProductService.AddFulfillmentPlaces][google.cloud.retail.v2.ProductService.AddFulfillmentPlaces]
        /// method.
        /// [ProductService.AddLocalInventories][google.cloud.retail.v2.ProductService.AddLocalInventories]
        /// achieves the same results but provides more fine-grained control over
        /// ingesting local inventory data.
        /// 
        /// Incrementally adds place IDs to
        /// [Product.fulfillment_info.place_ids][google.cloud.retail.v2.FulfillmentInfo.place_ids].
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, the added place IDs are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata>> AddFulfillmentPlacesAsync(AddFulfillmentPlacesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddFulfillmentPlacesRequest(ref request, ref callSettings);
            return new lro::Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata>(await _callAddFulfillmentPlaces.Async(request, callSettings).ConfigureAwait(false), AddFulfillmentPlacesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RemoveFulfillmentPlaces</c>.</summary>
        public override lro::OperationsClient RemoveFulfillmentPlacesOperationsClient { get; }

        /// <summary>
        /// We recommend that you use the
        /// [ProductService.RemoveLocalInventories][google.cloud.retail.v2.ProductService.RemoveLocalInventories]
        /// method instead of the
        /// [ProductService.RemoveFulfillmentPlaces][google.cloud.retail.v2.ProductService.RemoveFulfillmentPlaces]
        /// method.
        /// [ProductService.RemoveLocalInventories][google.cloud.retail.v2.ProductService.RemoveLocalInventories]
        /// achieves the same results but provides more fine-grained control over
        /// ingesting local inventory data.
        /// 
        /// Incrementally removes place IDs from a
        /// [Product.fulfillment_info.place_ids][google.cloud.retail.v2.FulfillmentInfo.place_ids].
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, the removed place IDs are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> RemoveFulfillmentPlaces(RemoveFulfillmentPlacesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveFulfillmentPlacesRequest(ref request, ref callSettings);
            return new lro::Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata>(_callRemoveFulfillmentPlaces.Sync(request, callSettings), RemoveFulfillmentPlacesOperationsClient);
        }

        /// <summary>
        /// We recommend that you use the
        /// [ProductService.RemoveLocalInventories][google.cloud.retail.v2.ProductService.RemoveLocalInventories]
        /// method instead of the
        /// [ProductService.RemoveFulfillmentPlaces][google.cloud.retail.v2.ProductService.RemoveFulfillmentPlaces]
        /// method.
        /// [ProductService.RemoveLocalInventories][google.cloud.retail.v2.ProductService.RemoveLocalInventories]
        /// achieves the same results but provides more fine-grained control over
        /// ingesting local inventory data.
        /// 
        /// Incrementally removes place IDs from a
        /// [Product.fulfillment_info.place_ids][google.cloud.retail.v2.FulfillmentInfo.place_ids].
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// fulfillment information. If the request is valid, the update will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, the removed place IDs are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata>> RemoveFulfillmentPlacesAsync(RemoveFulfillmentPlacesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveFulfillmentPlacesRequest(ref request, ref callSettings);
            return new lro::Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata>(await _callRemoveFulfillmentPlaces.Async(request, callSettings).ConfigureAwait(false), RemoveFulfillmentPlacesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>AddLocalInventories</c>.</summary>
        public override lro::OperationsClient AddLocalInventoriesOperationsClient { get; }

        /// <summary>
        /// Updates local inventory information for a
        /// [Product][google.cloud.retail.v2.Product] at a list of places, while
        /// respecting the last update timestamps of each inventory field.
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// inventory information. If the request is valid, the update will be enqueued
        /// and processed downstream. As a consequence, when a response is returned,
        /// updates are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Local inventory information can only be modified using this method.
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// has no effect on local inventories.
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata> AddLocalInventories(AddLocalInventoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddLocalInventoriesRequest(ref request, ref callSettings);
            return new lro::Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata>(_callAddLocalInventories.Sync(request, callSettings), AddLocalInventoriesOperationsClient);
        }

        /// <summary>
        /// Updates local inventory information for a
        /// [Product][google.cloud.retail.v2.Product] at a list of places, while
        /// respecting the last update timestamps of each inventory field.
        /// 
        /// This process is asynchronous and does not require the
        /// [Product][google.cloud.retail.v2.Product] to exist before updating
        /// inventory information. If the request is valid, the update will be enqueued
        /// and processed downstream. As a consequence, when a response is returned,
        /// updates are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Local inventory information can only be modified using this method.
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// has no effect on local inventories.
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata>> AddLocalInventoriesAsync(AddLocalInventoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddLocalInventoriesRequest(ref request, ref callSettings);
            return new lro::Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata>(await _callAddLocalInventories.Async(request, callSettings).ConfigureAwait(false), AddLocalInventoriesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RemoveLocalInventories</c>.</summary>
        public override lro::OperationsClient RemoveLocalInventoriesOperationsClient { get; }

        /// <summary>
        /// Remove local inventory information for a
        /// [Product][google.cloud.retail.v2.Product] at a list of places at a removal
        /// timestamp.
        /// 
        /// This process is asynchronous. If the request is valid, the removal will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, removals are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Local inventory information can only be removed using this method.
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// has no effect on local inventories.
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> RemoveLocalInventories(RemoveLocalInventoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveLocalInventoriesRequest(ref request, ref callSettings);
            return new lro::Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata>(_callRemoveLocalInventories.Sync(request, callSettings), RemoveLocalInventoriesOperationsClient);
        }

        /// <summary>
        /// Remove local inventory information for a
        /// [Product][google.cloud.retail.v2.Product] at a list of places at a removal
        /// timestamp.
        /// 
        /// This process is asynchronous. If the request is valid, the removal will be
        /// enqueued and processed downstream. As a consequence, when a response is
        /// returned, removals are not immediately manifested in the
        /// [Product][google.cloud.retail.v2.Product] queried by
        /// [ProductService.GetProduct][google.cloud.retail.v2.ProductService.GetProduct]
        /// or
        /// [ProductService.ListProducts][google.cloud.retail.v2.ProductService.ListProducts].
        /// 
        /// Local inventory information can only be removed using this method.
        /// [ProductService.CreateProduct][google.cloud.retail.v2.ProductService.CreateProduct]
        /// and
        /// [ProductService.UpdateProduct][google.cloud.retail.v2.ProductService.UpdateProduct]
        /// has no effect on local inventories.
        /// 
        /// The returned [Operation][google.longrunning.Operation]s will be obsolete
        /// after 1 day, and [GetOperation][google.longrunning.Operations.GetOperation]
        /// API will return NOT_FOUND afterwards.
        /// 
        /// If conflicting updates are issued, the
        /// [Operation][google.longrunning.Operation]s associated with the stale
        /// updates will not be marked as [done][google.longrunning.Operation.done]
        /// until being obsolete.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata>> RemoveLocalInventoriesAsync(RemoveLocalInventoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveLocalInventoriesRequest(ref request, ref callSettings);
            return new lro::Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata>(await _callRemoveLocalInventories.Async(request, callSettings).ConfigureAwait(false), RemoveLocalInventoriesOperationsClient);
        }
    }

    public partial class ListProductsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProductsResponse : gaxgrpc::IPageResponse<Product>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Product> GetEnumerator() => Products.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ProductService
    {
        public partial class ProductServiceClient
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

    public static partial class ProductService
    {
        public partial class ProductServiceClient
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
