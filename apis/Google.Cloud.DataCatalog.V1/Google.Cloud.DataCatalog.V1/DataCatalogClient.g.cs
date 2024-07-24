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
using gciv = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.DataCatalog.V1
{
    /// <summary>Settings for <see cref="DataCatalogClient"/> instances.</summary>
    public sealed partial class DataCatalogSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataCatalogSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataCatalogSettings"/>.</returns>
        public static DataCatalogSettings GetDefault() => new DataCatalogSettings();

        /// <summary>Constructs a new <see cref="DataCatalogSettings"/> object with default settings.</summary>
        public DataCatalogSettings()
        {
        }

        private DataCatalogSettings(DataCatalogSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SearchCatalogSettings = existing.SearchCatalogSettings;
            CreateEntryGroupSettings = existing.CreateEntryGroupSettings;
            GetEntryGroupSettings = existing.GetEntryGroupSettings;
            UpdateEntryGroupSettings = existing.UpdateEntryGroupSettings;
            DeleteEntryGroupSettings = existing.DeleteEntryGroupSettings;
            ListEntryGroupsSettings = existing.ListEntryGroupsSettings;
            CreateEntrySettings = existing.CreateEntrySettings;
            UpdateEntrySettings = existing.UpdateEntrySettings;
            DeleteEntrySettings = existing.DeleteEntrySettings;
            GetEntrySettings = existing.GetEntrySettings;
            LookupEntrySettings = existing.LookupEntrySettings;
            ListEntriesSettings = existing.ListEntriesSettings;
            ModifyEntryOverviewSettings = existing.ModifyEntryOverviewSettings;
            ModifyEntryContactsSettings = existing.ModifyEntryContactsSettings;
            CreateTagTemplateSettings = existing.CreateTagTemplateSettings;
            GetTagTemplateSettings = existing.GetTagTemplateSettings;
            UpdateTagTemplateSettings = existing.UpdateTagTemplateSettings;
            DeleteTagTemplateSettings = existing.DeleteTagTemplateSettings;
            CreateTagTemplateFieldSettings = existing.CreateTagTemplateFieldSettings;
            UpdateTagTemplateFieldSettings = existing.UpdateTagTemplateFieldSettings;
            RenameTagTemplateFieldSettings = existing.RenameTagTemplateFieldSettings;
            RenameTagTemplateFieldEnumValueSettings = existing.RenameTagTemplateFieldEnumValueSettings;
            DeleteTagTemplateFieldSettings = existing.DeleteTagTemplateFieldSettings;
            CreateTagSettings = existing.CreateTagSettings;
            UpdateTagSettings = existing.UpdateTagSettings;
            DeleteTagSettings = existing.DeleteTagSettings;
            ListTagsSettings = existing.ListTagsSettings;
            ReconcileTagsSettings = existing.ReconcileTagsSettings;
            ReconcileTagsOperationsSettings = existing.ReconcileTagsOperationsSettings.Clone();
            StarEntrySettings = existing.StarEntrySettings;
            UnstarEntrySettings = existing.UnstarEntrySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            ImportEntriesSettings = existing.ImportEntriesSettings;
            ImportEntriesOperationsSettings = existing.ImportEntriesOperationsSettings.Clone();
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataCatalogSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.SearchCatalog</c> and <c>DataCatalogClient.SearchCatalogAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchCatalogSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.CreateEntryGroup</c> and <c>DataCatalogClient.CreateEntryGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEntryGroupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.GetEntryGroup</c> and <c>DataCatalogClient.GetEntryGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEntryGroupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.UpdateEntryGroup</c> and <c>DataCatalogClient.UpdateEntryGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEntryGroupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.DeleteEntryGroup</c> and <c>DataCatalogClient.DeleteEntryGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEntryGroupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.ListEntryGroups</c> and <c>DataCatalogClient.ListEntryGroupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEntryGroupsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.CreateEntry</c> and <c>DataCatalogClient.CreateEntryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEntrySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.UpdateEntry</c> and <c>DataCatalogClient.UpdateEntryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEntrySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.DeleteEntry</c> and <c>DataCatalogClient.DeleteEntryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEntrySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DataCatalogClient.GetEntry</c>
        ///  and <c>DataCatalogClient.GetEntryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEntrySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.LookupEntry</c> and <c>DataCatalogClient.LookupEntryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings LookupEntrySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.ListEntries</c> and <c>DataCatalogClient.ListEntriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEntriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.ModifyEntryOverview</c> and <c>DataCatalogClient.ModifyEntryOverviewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ModifyEntryOverviewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.ModifyEntryContacts</c> and <c>DataCatalogClient.ModifyEntryContactsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ModifyEntryContactsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.CreateTagTemplate</c> and <c>DataCatalogClient.CreateTagTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTagTemplateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.GetTagTemplate</c> and <c>DataCatalogClient.GetTagTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTagTemplateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.UpdateTagTemplate</c> and <c>DataCatalogClient.UpdateTagTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTagTemplateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.DeleteTagTemplate</c> and <c>DataCatalogClient.DeleteTagTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTagTemplateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.CreateTagTemplateField</c> and <c>DataCatalogClient.CreateTagTemplateFieldAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTagTemplateFieldSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.UpdateTagTemplateField</c> and <c>DataCatalogClient.UpdateTagTemplateFieldAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTagTemplateFieldSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.RenameTagTemplateField</c> and <c>DataCatalogClient.RenameTagTemplateFieldAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RenameTagTemplateFieldSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.RenameTagTemplateFieldEnumValue</c> and
        /// <c>DataCatalogClient.RenameTagTemplateFieldEnumValueAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RenameTagTemplateFieldEnumValueSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.DeleteTagTemplateField</c> and <c>DataCatalogClient.DeleteTagTemplateFieldAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTagTemplateFieldSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DataCatalogClient.CreateTag</c>
        ///  and <c>DataCatalogClient.CreateTagAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTagSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DataCatalogClient.UpdateTag</c>
        ///  and <c>DataCatalogClient.UpdateTagAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTagSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DataCatalogClient.DeleteTag</c>
        ///  and <c>DataCatalogClient.DeleteTagAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTagSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DataCatalogClient.ListTags</c>
        ///  and <c>DataCatalogClient.ListTagsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTagsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.ReconcileTags</c> and <c>DataCatalogClient.ReconcileTagsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReconcileTagsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataCatalogClient.ReconcileTags</c> and
        /// <c>DataCatalogClient.ReconcileTagsAsync</c>.
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
        public lro::OperationsSettings ReconcileTagsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DataCatalogClient.StarEntry</c>
        ///  and <c>DataCatalogClient.StarEntryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StarEntrySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.UnstarEntry</c> and <c>DataCatalogClient.UnstarEntryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UnstarEntrySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.SetIamPolicy</c> and <c>DataCatalogClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.GetIamPolicy</c> and <c>DataCatalogClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.TestIamPermissions</c> and <c>DataCatalogClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataCatalogClient.ImportEntries</c> and <c>DataCatalogClient.ImportEntriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportEntriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Internal)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataCatalogClient.ImportEntries</c> and
        /// <c>DataCatalogClient.ImportEntriesAsync</c>.
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
        public lro::OperationsSettings ImportEntriesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DataCatalogSettings"/> object.</returns>
        public DataCatalogSettings Clone() => new DataCatalogSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataCatalogClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class DataCatalogClientBuilder : gaxgrpc::ClientBuilderBase<DataCatalogClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataCatalogSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataCatalogClientBuilder() : base(DataCatalogClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataCatalogClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataCatalogClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataCatalogClient Build()
        {
            DataCatalogClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataCatalogClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataCatalogClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataCatalogClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataCatalogClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DataCatalogClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataCatalogClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataCatalogClient.ChannelPool;
    }

    /// <summary>DataCatalog client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Data Catalog API service allows you to discover, understand, and manage
    /// your data.
    /// </remarks>
    public abstract partial class DataCatalogClient
    {
        /// <summary>
        /// The default endpoint for the DataCatalog service, which is a host of "datacatalog.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "datacatalog.googleapis.com:443";

        /// <summary>The default DataCatalog scopes.</summary>
        /// <remarks>
        /// The default DataCatalog scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DataCatalog.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataCatalogClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataCatalogClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataCatalogClient"/>.</returns>
        public static stt::Task<DataCatalogClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataCatalogClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataCatalogClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataCatalogClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DataCatalogClient"/>.</returns>
        public static DataCatalogClient Create() => new DataCatalogClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataCatalogClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataCatalogSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataCatalogClient"/>.</returns>
        internal static DataCatalogClient Create(grpccore::CallInvoker callInvoker, DataCatalogSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataCatalog.DataCatalogClient grpcClient = new DataCatalog.DataCatalogClient(callInvoker);
            return new DataCatalogClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DataCatalog client</summary>
        public virtual DataCatalog.DataCatalogClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Searches Data Catalog for multiple resources like entries and tags that
        /// match a query.
        /// 
        /// This is a [Custom Method]
        /// (https://cloud.google.com/apis/design/custom_methods) that doesn't return
        /// all information on a resource, only its ID and high level fields. To get
        /// more information, you can subsequently call specific get methods.
        /// 
        /// Note: Data Catalog search queries don't guarantee full recall. Results
        /// that match your query might not be returned, even in subsequent
        /// result pages. Additionally, returned (and not returned) results can vary
        /// if you repeat search queries.
        /// 
        /// For more information, see [Data Catalog search syntax]
        /// (https://cloud.google.com/data-catalog/docs/how-to/search-reference).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SearchCatalogResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchCatalogResponse, SearchCatalogResult> SearchCatalog(SearchCatalogRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches Data Catalog for multiple resources like entries and tags that
        /// match a query.
        /// 
        /// This is a [Custom Method]
        /// (https://cloud.google.com/apis/design/custom_methods) that doesn't return
        /// all information on a resource, only its ID and high level fields. To get
        /// more information, you can subsequently call specific get methods.
        /// 
        /// Note: Data Catalog search queries don't guarantee full recall. Results
        /// that match your query might not be returned, even in subsequent
        /// result pages. Additionally, returned (and not returned) results can vary
        /// if you repeat search queries.
        /// 
        /// For more information, see [Data Catalog search syntax]
        /// (https://cloud.google.com/data-catalog/docs/how-to/search-reference).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SearchCatalogResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchCatalogResponse, SearchCatalogResult> SearchCatalogAsync(SearchCatalogRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches Data Catalog for multiple resources like entries and tags that
        /// match a query.
        /// 
        /// This is a [Custom Method]
        /// (https://cloud.google.com/apis/design/custom_methods) that doesn't return
        /// all information on a resource, only its ID and high level fields. To get
        /// more information, you can subsequently call specific get methods.
        /// 
        /// Note: Data Catalog search queries don't guarantee full recall. Results
        /// that match your query might not be returned, even in subsequent
        /// result pages. Additionally, returned (and not returned) results can vary
        /// if you repeat search queries.
        /// 
        /// For more information, see [Data Catalog search syntax]
        /// (https://cloud.google.com/data-catalog/docs/how-to/search-reference).
        /// </summary>
        /// <param name="scope">
        /// Required. The scope of this search request.
        /// 
        /// The `scope` is invalid if `include_org_ids`, `include_project_ids` are
        /// empty AND `include_gcp_public_datasets` is set to `false`. In this case,
        /// the request returns an error.
        /// </param>
        /// <param name="query">
        /// Optional. The query string with a minimum of 3 characters and specific
        /// syntax. For more information, see [Data Catalog search
        /// syntax](https://cloud.google.com/data-catalog/docs/how-to/search-reference).
        /// 
        /// An empty query string returns all data assets (in the specified scope)
        /// that you have access to.
        /// 
        /// A query string can be a simple `xyz` or qualified by predicates:
        /// 
        /// * `name:x`
        /// * `column:y`
        /// * `description:z`
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
        /// <returns>A pageable sequence of <see cref="SearchCatalogResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchCatalogResponse, SearchCatalogResult> SearchCatalog(SearchCatalogRequest.Types.Scope scope, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchCatalogRequest request = new SearchCatalogRequest
            {
                Scope = gax::GaxPreconditions.CheckNotNull(scope, nameof(scope)),
                Query = query ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchCatalog(request, callSettings);
        }

        /// <summary>
        /// Searches Data Catalog for multiple resources like entries and tags that
        /// match a query.
        /// 
        /// This is a [Custom Method]
        /// (https://cloud.google.com/apis/design/custom_methods) that doesn't return
        /// all information on a resource, only its ID and high level fields. To get
        /// more information, you can subsequently call specific get methods.
        /// 
        /// Note: Data Catalog search queries don't guarantee full recall. Results
        /// that match your query might not be returned, even in subsequent
        /// result pages. Additionally, returned (and not returned) results can vary
        /// if you repeat search queries.
        /// 
        /// For more information, see [Data Catalog search syntax]
        /// (https://cloud.google.com/data-catalog/docs/how-to/search-reference).
        /// </summary>
        /// <param name="scope">
        /// Required. The scope of this search request.
        /// 
        /// The `scope` is invalid if `include_org_ids`, `include_project_ids` are
        /// empty AND `include_gcp_public_datasets` is set to `false`. In this case,
        /// the request returns an error.
        /// </param>
        /// <param name="query">
        /// Optional. The query string with a minimum of 3 characters and specific
        /// syntax. For more information, see [Data Catalog search
        /// syntax](https://cloud.google.com/data-catalog/docs/how-to/search-reference).
        /// 
        /// An empty query string returns all data assets (in the specified scope)
        /// that you have access to.
        /// 
        /// A query string can be a simple `xyz` or qualified by predicates:
        /// 
        /// * `name:x`
        /// * `column:y`
        /// * `description:z`
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
        /// <returns>A pageable asynchronous sequence of <see cref="SearchCatalogResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchCatalogResponse, SearchCatalogResult> SearchCatalogAsync(SearchCatalogRequest.Types.Scope scope, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchCatalogRequest request = new SearchCatalogRequest
            {
                Scope = gax::GaxPreconditions.CheckNotNull(scope, nameof(scope)),
                Query = query ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchCatalogAsync(request, callSettings);
        }

        /// <summary>
        /// Creates an entry group.
        /// 
        /// An entry group contains logically related entries together with [Cloud
        /// Identity and Access Management](/data-catalog/docs/concepts/iam) policies.
        /// These policies specify users who can create, edit, and view entries
        /// within entry groups.
        /// 
        /// Data Catalog automatically creates entry groups with names that start with
        /// the `@` symbol for the following resources:
        /// 
        /// * BigQuery entries (`@bigquery`)
        /// * Pub/Sub topics (`@pubsub`)
        /// * Dataproc Metastore services (`@dataproc_metastore_{SERVICE_NAME_HASH}`)
        /// 
        /// You can create your own entry groups for Cloud Storage fileset entries
        /// and custom entries together with the corresponding IAM policies.
        /// User-created entry groups can't contain the `@` symbol, it is reserved
        /// for automatically created groups.
        /// 
        /// Entry groups, like entries, can be searched.
        /// 
        /// A maximum of 10,000 entry groups may be created per organization across all
        /// locations.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntryGroup CreateEntryGroup(CreateEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an entry group.
        /// 
        /// An entry group contains logically related entries together with [Cloud
        /// Identity and Access Management](/data-catalog/docs/concepts/iam) policies.
        /// These policies specify users who can create, edit, and view entries
        /// within entry groups.
        /// 
        /// Data Catalog automatically creates entry groups with names that start with
        /// the `@` symbol for the following resources:
        /// 
        /// * BigQuery entries (`@bigquery`)
        /// * Pub/Sub topics (`@pubsub`)
        /// * Dataproc Metastore services (`@dataproc_metastore_{SERVICE_NAME_HASH}`)
        /// 
        /// You can create your own entry groups for Cloud Storage fileset entries
        /// and custom entries together with the corresponding IAM policies.
        /// User-created entry groups can't contain the `@` symbol, it is reserved
        /// for automatically created groups.
        /// 
        /// Entry groups, like entries, can be searched.
        /// 
        /// A maximum of 10,000 entry groups may be created per organization across all
        /// locations.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> CreateEntryGroupAsync(CreateEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an entry group.
        /// 
        /// An entry group contains logically related entries together with [Cloud
        /// Identity and Access Management](/data-catalog/docs/concepts/iam) policies.
        /// These policies specify users who can create, edit, and view entries
        /// within entry groups.
        /// 
        /// Data Catalog automatically creates entry groups with names that start with
        /// the `@` symbol for the following resources:
        /// 
        /// * BigQuery entries (`@bigquery`)
        /// * Pub/Sub topics (`@pubsub`)
        /// * Dataproc Metastore services (`@dataproc_metastore_{SERVICE_NAME_HASH}`)
        /// 
        /// You can create your own entry groups for Cloud Storage fileset entries
        /// and custom entries together with the corresponding IAM policies.
        /// User-created entry groups can't contain the `@` symbol, it is reserved
        /// for automatically created groups.
        /// 
        /// Entry groups, like entries, can be searched.
        /// 
        /// A maximum of 10,000 entry groups may be created per organization across all
        /// locations.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> CreateEntryGroupAsync(CreateEntryGroupRequest request, st::CancellationToken cancellationToken) =>
            CreateEntryGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an entry group.
        /// 
        /// An entry group contains logically related entries together with [Cloud
        /// Identity and Access Management](/data-catalog/docs/concepts/iam) policies.
        /// These policies specify users who can create, edit, and view entries
        /// within entry groups.
        /// 
        /// Data Catalog automatically creates entry groups with names that start with
        /// the `@` symbol for the following resources:
        /// 
        /// * BigQuery entries (`@bigquery`)
        /// * Pub/Sub topics (`@pubsub`)
        /// * Dataproc Metastore services (`@dataproc_metastore_{SERVICE_NAME_HASH}`)
        /// 
        /// You can create your own entry groups for Cloud Storage fileset entries
        /// and custom entries together with the corresponding IAM policies.
        /// User-created entry groups can't contain the `@` symbol, it is reserved
        /// for automatically created groups.
        /// 
        /// Entry groups, like entries, can be searched.
        /// 
        /// A maximum of 10,000 entry groups may be created per organization across all
        /// locations.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="parent">
        /// Required. The names of the project and location that the new entry group
        /// belongs to.
        /// 
        /// Note: The entry group itself and its child resources might not be
        /// stored in the location specified in its name.
        /// </param>
        /// <param name="entryGroupId">
        /// Required. The ID of the entry group to create.
        /// 
        /// The ID must contain only letters (a-z, A-Z), numbers (0-9),
        /// underscores (_), and must start with a letter or underscore.
        /// The maximum size is 64 bytes when encoded in UTF-8.
        /// </param>
        /// <param name="entryGroup">
        /// The entry group to create. Defaults to empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntryGroup CreateEntryGroup(string parent, string entryGroupId, EntryGroup entryGroup, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntryGroup(new CreateEntryGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntryGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(entryGroupId, nameof(entryGroupId)),
                EntryGroup = entryGroup,
            }, callSettings);

        /// <summary>
        /// Creates an entry group.
        /// 
        /// An entry group contains logically related entries together with [Cloud
        /// Identity and Access Management](/data-catalog/docs/concepts/iam) policies.
        /// These policies specify users who can create, edit, and view entries
        /// within entry groups.
        /// 
        /// Data Catalog automatically creates entry groups with names that start with
        /// the `@` symbol for the following resources:
        /// 
        /// * BigQuery entries (`@bigquery`)
        /// * Pub/Sub topics (`@pubsub`)
        /// * Dataproc Metastore services (`@dataproc_metastore_{SERVICE_NAME_HASH}`)
        /// 
        /// You can create your own entry groups for Cloud Storage fileset entries
        /// and custom entries together with the corresponding IAM policies.
        /// User-created entry groups can't contain the `@` symbol, it is reserved
        /// for automatically created groups.
        /// 
        /// Entry groups, like entries, can be searched.
        /// 
        /// A maximum of 10,000 entry groups may be created per organization across all
        /// locations.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="parent">
        /// Required. The names of the project and location that the new entry group
        /// belongs to.
        /// 
        /// Note: The entry group itself and its child resources might not be
        /// stored in the location specified in its name.
        /// </param>
        /// <param name="entryGroupId">
        /// Required. The ID of the entry group to create.
        /// 
        /// The ID must contain only letters (a-z, A-Z), numbers (0-9),
        /// underscores (_), and must start with a letter or underscore.
        /// The maximum size is 64 bytes when encoded in UTF-8.
        /// </param>
        /// <param name="entryGroup">
        /// The entry group to create. Defaults to empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> CreateEntryGroupAsync(string parent, string entryGroupId, EntryGroup entryGroup, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntryGroupAsync(new CreateEntryGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntryGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(entryGroupId, nameof(entryGroupId)),
                EntryGroup = entryGroup,
            }, callSettings);

        /// <summary>
        /// Creates an entry group.
        /// 
        /// An entry group contains logically related entries together with [Cloud
        /// Identity and Access Management](/data-catalog/docs/concepts/iam) policies.
        /// These policies specify users who can create, edit, and view entries
        /// within entry groups.
        /// 
        /// Data Catalog automatically creates entry groups with names that start with
        /// the `@` symbol for the following resources:
        /// 
        /// * BigQuery entries (`@bigquery`)
        /// * Pub/Sub topics (`@pubsub`)
        /// * Dataproc Metastore services (`@dataproc_metastore_{SERVICE_NAME_HASH}`)
        /// 
        /// You can create your own entry groups for Cloud Storage fileset entries
        /// and custom entries together with the corresponding IAM policies.
        /// User-created entry groups can't contain the `@` symbol, it is reserved
        /// for automatically created groups.
        /// 
        /// Entry groups, like entries, can be searched.
        /// 
        /// A maximum of 10,000 entry groups may be created per organization across all
        /// locations.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="parent">
        /// Required. The names of the project and location that the new entry group
        /// belongs to.
        /// 
        /// Note: The entry group itself and its child resources might not be
        /// stored in the location specified in its name.
        /// </param>
        /// <param name="entryGroupId">
        /// Required. The ID of the entry group to create.
        /// 
        /// The ID must contain only letters (a-z, A-Z), numbers (0-9),
        /// underscores (_), and must start with a letter or underscore.
        /// The maximum size is 64 bytes when encoded in UTF-8.
        /// </param>
        /// <param name="entryGroup">
        /// The entry group to create. Defaults to empty.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> CreateEntryGroupAsync(string parent, string entryGroupId, EntryGroup entryGroup, st::CancellationToken cancellationToken) =>
            CreateEntryGroupAsync(parent, entryGroupId, entryGroup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an entry group.
        /// 
        /// An entry group contains logically related entries together with [Cloud
        /// Identity and Access Management](/data-catalog/docs/concepts/iam) policies.
        /// These policies specify users who can create, edit, and view entries
        /// within entry groups.
        /// 
        /// Data Catalog automatically creates entry groups with names that start with
        /// the `@` symbol for the following resources:
        /// 
        /// * BigQuery entries (`@bigquery`)
        /// * Pub/Sub topics (`@pubsub`)
        /// * Dataproc Metastore services (`@dataproc_metastore_{SERVICE_NAME_HASH}`)
        /// 
        /// You can create your own entry groups for Cloud Storage fileset entries
        /// and custom entries together with the corresponding IAM policies.
        /// User-created entry groups can't contain the `@` symbol, it is reserved
        /// for automatically created groups.
        /// 
        /// Entry groups, like entries, can be searched.
        /// 
        /// A maximum of 10,000 entry groups may be created per organization across all
        /// locations.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="parent">
        /// Required. The names of the project and location that the new entry group
        /// belongs to.
        /// 
        /// Note: The entry group itself and its child resources might not be
        /// stored in the location specified in its name.
        /// </param>
        /// <param name="entryGroupId">
        /// Required. The ID of the entry group to create.
        /// 
        /// The ID must contain only letters (a-z, A-Z), numbers (0-9),
        /// underscores (_), and must start with a letter or underscore.
        /// The maximum size is 64 bytes when encoded in UTF-8.
        /// </param>
        /// <param name="entryGroup">
        /// The entry group to create. Defaults to empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntryGroup CreateEntryGroup(gagr::LocationName parent, string entryGroupId, EntryGroup entryGroup, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntryGroup(new CreateEntryGroupRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntryGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(entryGroupId, nameof(entryGroupId)),
                EntryGroup = entryGroup,
            }, callSettings);

        /// <summary>
        /// Creates an entry group.
        /// 
        /// An entry group contains logically related entries together with [Cloud
        /// Identity and Access Management](/data-catalog/docs/concepts/iam) policies.
        /// These policies specify users who can create, edit, and view entries
        /// within entry groups.
        /// 
        /// Data Catalog automatically creates entry groups with names that start with
        /// the `@` symbol for the following resources:
        /// 
        /// * BigQuery entries (`@bigquery`)
        /// * Pub/Sub topics (`@pubsub`)
        /// * Dataproc Metastore services (`@dataproc_metastore_{SERVICE_NAME_HASH}`)
        /// 
        /// You can create your own entry groups for Cloud Storage fileset entries
        /// and custom entries together with the corresponding IAM policies.
        /// User-created entry groups can't contain the `@` symbol, it is reserved
        /// for automatically created groups.
        /// 
        /// Entry groups, like entries, can be searched.
        /// 
        /// A maximum of 10,000 entry groups may be created per organization across all
        /// locations.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="parent">
        /// Required. The names of the project and location that the new entry group
        /// belongs to.
        /// 
        /// Note: The entry group itself and its child resources might not be
        /// stored in the location specified in its name.
        /// </param>
        /// <param name="entryGroupId">
        /// Required. The ID of the entry group to create.
        /// 
        /// The ID must contain only letters (a-z, A-Z), numbers (0-9),
        /// underscores (_), and must start with a letter or underscore.
        /// The maximum size is 64 bytes when encoded in UTF-8.
        /// </param>
        /// <param name="entryGroup">
        /// The entry group to create. Defaults to empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> CreateEntryGroupAsync(gagr::LocationName parent, string entryGroupId, EntryGroup entryGroup, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntryGroupAsync(new CreateEntryGroupRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntryGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(entryGroupId, nameof(entryGroupId)),
                EntryGroup = entryGroup,
            }, callSettings);

        /// <summary>
        /// Creates an entry group.
        /// 
        /// An entry group contains logically related entries together with [Cloud
        /// Identity and Access Management](/data-catalog/docs/concepts/iam) policies.
        /// These policies specify users who can create, edit, and view entries
        /// within entry groups.
        /// 
        /// Data Catalog automatically creates entry groups with names that start with
        /// the `@` symbol for the following resources:
        /// 
        /// * BigQuery entries (`@bigquery`)
        /// * Pub/Sub topics (`@pubsub`)
        /// * Dataproc Metastore services (`@dataproc_metastore_{SERVICE_NAME_HASH}`)
        /// 
        /// You can create your own entry groups for Cloud Storage fileset entries
        /// and custom entries together with the corresponding IAM policies.
        /// User-created entry groups can't contain the `@` symbol, it is reserved
        /// for automatically created groups.
        /// 
        /// Entry groups, like entries, can be searched.
        /// 
        /// A maximum of 10,000 entry groups may be created per organization across all
        /// locations.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="parent">
        /// Required. The names of the project and location that the new entry group
        /// belongs to.
        /// 
        /// Note: The entry group itself and its child resources might not be
        /// stored in the location specified in its name.
        /// </param>
        /// <param name="entryGroupId">
        /// Required. The ID of the entry group to create.
        /// 
        /// The ID must contain only letters (a-z, A-Z), numbers (0-9),
        /// underscores (_), and must start with a letter or underscore.
        /// The maximum size is 64 bytes when encoded in UTF-8.
        /// </param>
        /// <param name="entryGroup">
        /// The entry group to create. Defaults to empty.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> CreateEntryGroupAsync(gagr::LocationName parent, string entryGroupId, EntryGroup entryGroup, st::CancellationToken cancellationToken) =>
            CreateEntryGroupAsync(parent, entryGroupId, entryGroup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an entry group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntryGroup GetEntryGroup(GetEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an entry group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> GetEntryGroupAsync(GetEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an entry group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> GetEntryGroupAsync(GetEntryGroupRequest request, st::CancellationToken cancellationToken) =>
            GetEntryGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an entry group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry group to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntryGroup GetEntryGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntryGroup(new GetEntryGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an entry group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry group to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> GetEntryGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntryGroupAsync(new GetEntryGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an entry group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry group to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> GetEntryGroupAsync(string name, st::CancellationToken cancellationToken) =>
            GetEntryGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an entry group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry group to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntryGroup GetEntryGroup(EntryGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntryGroup(new GetEntryGroupRequest
            {
                EntryGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an entry group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry group to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> GetEntryGroupAsync(EntryGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntryGroupAsync(new GetEntryGroupRequest
            {
                EntryGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an entry group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry group to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> GetEntryGroupAsync(EntryGroupName name, st::CancellationToken cancellationToken) =>
            GetEntryGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an entry group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry group to get.
        /// </param>
        /// <param name="readMask">
        /// The fields to return. If empty or omitted, all fields are returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntryGroup GetEntryGroup(string name, wkt::FieldMask readMask, gaxgrpc::CallSettings callSettings = null) =>
            GetEntryGroup(new GetEntryGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ReadMask = readMask,
            }, callSettings);

        /// <summary>
        /// Gets an entry group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry group to get.
        /// </param>
        /// <param name="readMask">
        /// The fields to return. If empty or omitted, all fields are returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> GetEntryGroupAsync(string name, wkt::FieldMask readMask, gaxgrpc::CallSettings callSettings = null) =>
            GetEntryGroupAsync(new GetEntryGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ReadMask = readMask,
            }, callSettings);

        /// <summary>
        /// Gets an entry group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry group to get.
        /// </param>
        /// <param name="readMask">
        /// The fields to return. If empty or omitted, all fields are returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> GetEntryGroupAsync(string name, wkt::FieldMask readMask, st::CancellationToken cancellationToken) =>
            GetEntryGroupAsync(name, readMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an entry group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry group to get.
        /// </param>
        /// <param name="readMask">
        /// The fields to return. If empty or omitted, all fields are returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntryGroup GetEntryGroup(EntryGroupName name, wkt::FieldMask readMask, gaxgrpc::CallSettings callSettings = null) =>
            GetEntryGroup(new GetEntryGroupRequest
            {
                EntryGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ReadMask = readMask,
            }, callSettings);

        /// <summary>
        /// Gets an entry group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry group to get.
        /// </param>
        /// <param name="readMask">
        /// The fields to return. If empty or omitted, all fields are returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> GetEntryGroupAsync(EntryGroupName name, wkt::FieldMask readMask, gaxgrpc::CallSettings callSettings = null) =>
            GetEntryGroupAsync(new GetEntryGroupRequest
            {
                EntryGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ReadMask = readMask,
            }, callSettings);

        /// <summary>
        /// Gets an entry group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry group to get.
        /// </param>
        /// <param name="readMask">
        /// The fields to return. If empty or omitted, all fields are returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> GetEntryGroupAsync(EntryGroupName name, wkt::FieldMask readMask, st::CancellationToken cancellationToken) =>
            GetEntryGroupAsync(name, readMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an entry group.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `entry_group.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntryGroup UpdateEntryGroup(UpdateEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an entry group.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `entry_group.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> UpdateEntryGroupAsync(UpdateEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an entry group.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `entry_group.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> UpdateEntryGroupAsync(UpdateEntryGroupRequest request, st::CancellationToken cancellationToken) =>
            UpdateEntryGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an entry group.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `entry_group.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="entryGroup">
        /// Required. Updates for the entry group. The `name` field must be set.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntryGroup UpdateEntryGroup(EntryGroup entryGroup, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntryGroup(new UpdateEntryGroupRequest
            {
                EntryGroup = gax::GaxPreconditions.CheckNotNull(entryGroup, nameof(entryGroup)),
            }, callSettings);

        /// <summary>
        /// Updates an entry group.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `entry_group.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="entryGroup">
        /// Required. Updates for the entry group. The `name` field must be set.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> UpdateEntryGroupAsync(EntryGroup entryGroup, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntryGroupAsync(new UpdateEntryGroupRequest
            {
                EntryGroup = gax::GaxPreconditions.CheckNotNull(entryGroup, nameof(entryGroup)),
            }, callSettings);

        /// <summary>
        /// Updates an entry group.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `entry_group.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="entryGroup">
        /// Required. Updates for the entry group. The `name` field must be set.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> UpdateEntryGroupAsync(EntryGroup entryGroup, st::CancellationToken cancellationToken) =>
            UpdateEntryGroupAsync(entryGroup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an entry group.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `entry_group.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="entryGroup">
        /// Required. Updates for the entry group. The `name` field must be set.
        /// </param>
        /// <param name="updateMask">
        /// Names of fields whose values to overwrite on an entry group.
        /// 
        /// If this parameter is absent or empty, all modifiable fields
        /// are overwritten. If such fields are non-required and omitted in the
        /// request body, their values are emptied.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntryGroup UpdateEntryGroup(EntryGroup entryGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntryGroup(new UpdateEntryGroupRequest
            {
                EntryGroup = gax::GaxPreconditions.CheckNotNull(entryGroup, nameof(entryGroup)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an entry group.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `entry_group.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="entryGroup">
        /// Required. Updates for the entry group. The `name` field must be set.
        /// </param>
        /// <param name="updateMask">
        /// Names of fields whose values to overwrite on an entry group.
        /// 
        /// If this parameter is absent or empty, all modifiable fields
        /// are overwritten. If such fields are non-required and omitted in the
        /// request body, their values are emptied.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> UpdateEntryGroupAsync(EntryGroup entryGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntryGroupAsync(new UpdateEntryGroupRequest
            {
                EntryGroup = gax::GaxPreconditions.CheckNotNull(entryGroup, nameof(entryGroup)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an entry group.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `entry_group.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="entryGroup">
        /// Required. Updates for the entry group. The `name` field must be set.
        /// </param>
        /// <param name="updateMask">
        /// Names of fields whose values to overwrite on an entry group.
        /// 
        /// If this parameter is absent or empty, all modifiable fields
        /// are overwritten. If such fields are non-required and omitted in the
        /// request body, their values are emptied.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> UpdateEntryGroupAsync(EntryGroup entryGroup, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEntryGroupAsync(entryGroup, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an entry group.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEntryGroup(DeleteEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an entry group.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntryGroupAsync(DeleteEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an entry group.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntryGroupAsync(DeleteEntryGroupRequest request, st::CancellationToken cancellationToken) =>
            DeleteEntryGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an entry group.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry group to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEntryGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntryGroup(new DeleteEntryGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an entry group.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry group to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntryGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntryGroupAsync(new DeleteEntryGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an entry group.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry group to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntryGroupAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEntryGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an entry group.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry group to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEntryGroup(EntryGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntryGroup(new DeleteEntryGroupRequest
            {
                EntryGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an entry group.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry group to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntryGroupAsync(EntryGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntryGroupAsync(new DeleteEntryGroupRequest
            {
                EntryGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an entry group.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry group to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntryGroupAsync(EntryGroupName name, st::CancellationToken cancellationToken) =>
            DeleteEntryGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists entry groups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EntryGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntryGroupsResponse, EntryGroup> ListEntryGroups(ListEntryGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists entry groups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EntryGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntryGroupsResponse, EntryGroup> ListEntryGroupsAsync(ListEntryGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists entry groups.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the location that contains the entry groups to list.
        /// 
        /// Can be provided as a URL.
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
        /// <returns>A pageable sequence of <see cref="EntryGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntryGroupsResponse, EntryGroup> ListEntryGroups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntryGroupsRequest request = new ListEntryGroupsRequest
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
            return ListEntryGroups(request, callSettings);
        }

        /// <summary>
        /// Lists entry groups.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the location that contains the entry groups to list.
        /// 
        /// Can be provided as a URL.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EntryGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntryGroupsResponse, EntryGroup> ListEntryGroupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntryGroupsRequest request = new ListEntryGroupsRequest
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
            return ListEntryGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists entry groups.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the location that contains the entry groups to list.
        /// 
        /// Can be provided as a URL.
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
        /// <returns>A pageable sequence of <see cref="EntryGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntryGroupsResponse, EntryGroup> ListEntryGroups(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntryGroupsRequest request = new ListEntryGroupsRequest
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
            return ListEntryGroups(request, callSettings);
        }

        /// <summary>
        /// Lists entry groups.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the location that contains the entry groups to list.
        /// 
        /// Can be provided as a URL.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EntryGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntryGroupsResponse, EntryGroup> ListEntryGroupsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntryGroupsRequest request = new ListEntryGroupsRequest
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
            return ListEntryGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates an entry.
        /// 
        /// You can create entries only with 'FILESET', 'CLUSTER', 'DATA_STREAM',
        /// or custom types. Data Catalog automatically creates entries with other
        /// types during metadata ingestion from integrated systems.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// 
        /// An entry group can have a maximum of 100,000 entries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entry CreateEntry(CreateEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an entry.
        /// 
        /// You can create entries only with 'FILESET', 'CLUSTER', 'DATA_STREAM',
        /// or custom types. Data Catalog automatically creates entries with other
        /// types during metadata ingestion from integrated systems.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// 
        /// An entry group can have a maximum of 100,000 entries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> CreateEntryAsync(CreateEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an entry.
        /// 
        /// You can create entries only with 'FILESET', 'CLUSTER', 'DATA_STREAM',
        /// or custom types. Data Catalog automatically creates entries with other
        /// types during metadata ingestion from integrated systems.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// 
        /// An entry group can have a maximum of 100,000 entries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> CreateEntryAsync(CreateEntryRequest request, st::CancellationToken cancellationToken) =>
            CreateEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an entry.
        /// 
        /// You can create entries only with 'FILESET', 'CLUSTER', 'DATA_STREAM',
        /// or custom types. Data Catalog automatically creates entries with other
        /// types during metadata ingestion from integrated systems.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// 
        /// An entry group can have a maximum of 100,000 entries.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entry group this entry belongs to.
        /// 
        /// Note: The entry itself and its child resources might not be stored in
        /// the location specified in its name.
        /// </param>
        /// <param name="entryId">
        /// Required. The ID of the entry to create.
        /// 
        /// The ID must contain only letters (a-z, A-Z), numbers (0-9),
        /// and underscores (_).
        /// The maximum size is 64 bytes when encoded in UTF-8.
        /// </param>
        /// <param name="entry">
        /// Required. The entry to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entry CreateEntry(string parent, string entryId, Entry entry, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntry(new CreateEntryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntryId = gax::GaxPreconditions.CheckNotNullOrEmpty(entryId, nameof(entryId)),
                Entry = gax::GaxPreconditions.CheckNotNull(entry, nameof(entry)),
            }, callSettings);

        /// <summary>
        /// Creates an entry.
        /// 
        /// You can create entries only with 'FILESET', 'CLUSTER', 'DATA_STREAM',
        /// or custom types. Data Catalog automatically creates entries with other
        /// types during metadata ingestion from integrated systems.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// 
        /// An entry group can have a maximum of 100,000 entries.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entry group this entry belongs to.
        /// 
        /// Note: The entry itself and its child resources might not be stored in
        /// the location specified in its name.
        /// </param>
        /// <param name="entryId">
        /// Required. The ID of the entry to create.
        /// 
        /// The ID must contain only letters (a-z, A-Z), numbers (0-9),
        /// and underscores (_).
        /// The maximum size is 64 bytes when encoded in UTF-8.
        /// </param>
        /// <param name="entry">
        /// Required. The entry to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> CreateEntryAsync(string parent, string entryId, Entry entry, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntryAsync(new CreateEntryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntryId = gax::GaxPreconditions.CheckNotNullOrEmpty(entryId, nameof(entryId)),
                Entry = gax::GaxPreconditions.CheckNotNull(entry, nameof(entry)),
            }, callSettings);

        /// <summary>
        /// Creates an entry.
        /// 
        /// You can create entries only with 'FILESET', 'CLUSTER', 'DATA_STREAM',
        /// or custom types. Data Catalog automatically creates entries with other
        /// types during metadata ingestion from integrated systems.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// 
        /// An entry group can have a maximum of 100,000 entries.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entry group this entry belongs to.
        /// 
        /// Note: The entry itself and its child resources might not be stored in
        /// the location specified in its name.
        /// </param>
        /// <param name="entryId">
        /// Required. The ID of the entry to create.
        /// 
        /// The ID must contain only letters (a-z, A-Z), numbers (0-9),
        /// and underscores (_).
        /// The maximum size is 64 bytes when encoded in UTF-8.
        /// </param>
        /// <param name="entry">
        /// Required. The entry to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> CreateEntryAsync(string parent, string entryId, Entry entry, st::CancellationToken cancellationToken) =>
            CreateEntryAsync(parent, entryId, entry, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an entry.
        /// 
        /// You can create entries only with 'FILESET', 'CLUSTER', 'DATA_STREAM',
        /// or custom types. Data Catalog automatically creates entries with other
        /// types during metadata ingestion from integrated systems.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// 
        /// An entry group can have a maximum of 100,000 entries.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entry group this entry belongs to.
        /// 
        /// Note: The entry itself and its child resources might not be stored in
        /// the location specified in its name.
        /// </param>
        /// <param name="entryId">
        /// Required. The ID of the entry to create.
        /// 
        /// The ID must contain only letters (a-z, A-Z), numbers (0-9),
        /// and underscores (_).
        /// The maximum size is 64 bytes when encoded in UTF-8.
        /// </param>
        /// <param name="entry">
        /// Required. The entry to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entry CreateEntry(EntryGroupName parent, string entryId, Entry entry, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntry(new CreateEntryRequest
            {
                ParentAsEntryGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntryId = gax::GaxPreconditions.CheckNotNullOrEmpty(entryId, nameof(entryId)),
                Entry = gax::GaxPreconditions.CheckNotNull(entry, nameof(entry)),
            }, callSettings);

        /// <summary>
        /// Creates an entry.
        /// 
        /// You can create entries only with 'FILESET', 'CLUSTER', 'DATA_STREAM',
        /// or custom types. Data Catalog automatically creates entries with other
        /// types during metadata ingestion from integrated systems.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// 
        /// An entry group can have a maximum of 100,000 entries.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entry group this entry belongs to.
        /// 
        /// Note: The entry itself and its child resources might not be stored in
        /// the location specified in its name.
        /// </param>
        /// <param name="entryId">
        /// Required. The ID of the entry to create.
        /// 
        /// The ID must contain only letters (a-z, A-Z), numbers (0-9),
        /// and underscores (_).
        /// The maximum size is 64 bytes when encoded in UTF-8.
        /// </param>
        /// <param name="entry">
        /// Required. The entry to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> CreateEntryAsync(EntryGroupName parent, string entryId, Entry entry, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntryAsync(new CreateEntryRequest
            {
                ParentAsEntryGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntryId = gax::GaxPreconditions.CheckNotNullOrEmpty(entryId, nameof(entryId)),
                Entry = gax::GaxPreconditions.CheckNotNull(entry, nameof(entry)),
            }, callSettings);

        /// <summary>
        /// Creates an entry.
        /// 
        /// You can create entries only with 'FILESET', 'CLUSTER', 'DATA_STREAM',
        /// or custom types. Data Catalog automatically creates entries with other
        /// types during metadata ingestion from integrated systems.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// 
        /// An entry group can have a maximum of 100,000 entries.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entry group this entry belongs to.
        /// 
        /// Note: The entry itself and its child resources might not be stored in
        /// the location specified in its name.
        /// </param>
        /// <param name="entryId">
        /// Required. The ID of the entry to create.
        /// 
        /// The ID must contain only letters (a-z, A-Z), numbers (0-9),
        /// and underscores (_).
        /// The maximum size is 64 bytes when encoded in UTF-8.
        /// </param>
        /// <param name="entry">
        /// Required. The entry to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> CreateEntryAsync(EntryGroupName parent, string entryId, Entry entry, st::CancellationToken cancellationToken) =>
            CreateEntryAsync(parent, entryId, entry, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing entry.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `entry.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entry UpdateEntry(UpdateEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing entry.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `entry.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> UpdateEntryAsync(UpdateEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing entry.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `entry.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> UpdateEntryAsync(UpdateEntryRequest request, st::CancellationToken cancellationToken) =>
            UpdateEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing entry.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `entry.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="entry">
        /// Required. Updates for the entry. The `name` field must be set.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entry UpdateEntry(Entry entry, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntry(new UpdateEntryRequest
            {
                Entry = gax::GaxPreconditions.CheckNotNull(entry, nameof(entry)),
            }, callSettings);

        /// <summary>
        /// Updates an existing entry.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `entry.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="entry">
        /// Required. Updates for the entry. The `name` field must be set.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> UpdateEntryAsync(Entry entry, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntryAsync(new UpdateEntryRequest
            {
                Entry = gax::GaxPreconditions.CheckNotNull(entry, nameof(entry)),
            }, callSettings);

        /// <summary>
        /// Updates an existing entry.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `entry.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="entry">
        /// Required. Updates for the entry. The `name` field must be set.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> UpdateEntryAsync(Entry entry, st::CancellationToken cancellationToken) =>
            UpdateEntryAsync(entry, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing entry.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `entry.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="entry">
        /// Required. Updates for the entry. The `name` field must be set.
        /// </param>
        /// <param name="updateMask">
        /// Names of fields whose values to overwrite on an entry.
        /// 
        /// If this parameter is absent or empty, all modifiable fields
        /// are overwritten. If such fields are non-required and omitted in the
        /// request body, their values are emptied.
        /// 
        /// You can modify only the fields listed below.
        /// 
        /// For entries with type `DATA_STREAM`:
        /// 
        /// * `schema`
        /// 
        /// For entries with type `FILESET`:
        /// 
        /// * `schema`
        /// * `display_name`
        /// * `description`
        /// * `gcs_fileset_spec`
        /// * `gcs_fileset_spec.file_patterns`
        /// 
        /// For entries with `user_specified_type`:
        /// 
        /// * `schema`
        /// * `display_name`
        /// * `description`
        /// * `user_specified_type`
        /// * `user_specified_system`
        /// * `linked_resource`
        /// * `source_system_timestamps`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entry UpdateEntry(Entry entry, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntry(new UpdateEntryRequest
            {
                Entry = gax::GaxPreconditions.CheckNotNull(entry, nameof(entry)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an existing entry.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `entry.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="entry">
        /// Required. Updates for the entry. The `name` field must be set.
        /// </param>
        /// <param name="updateMask">
        /// Names of fields whose values to overwrite on an entry.
        /// 
        /// If this parameter is absent or empty, all modifiable fields
        /// are overwritten. If such fields are non-required and omitted in the
        /// request body, their values are emptied.
        /// 
        /// You can modify only the fields listed below.
        /// 
        /// For entries with type `DATA_STREAM`:
        /// 
        /// * `schema`
        /// 
        /// For entries with type `FILESET`:
        /// 
        /// * `schema`
        /// * `display_name`
        /// * `description`
        /// * `gcs_fileset_spec`
        /// * `gcs_fileset_spec.file_patterns`
        /// 
        /// For entries with `user_specified_type`:
        /// 
        /// * `schema`
        /// * `display_name`
        /// * `description`
        /// * `user_specified_type`
        /// * `user_specified_system`
        /// * `linked_resource`
        /// * `source_system_timestamps`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> UpdateEntryAsync(Entry entry, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntryAsync(new UpdateEntryRequest
            {
                Entry = gax::GaxPreconditions.CheckNotNull(entry, nameof(entry)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an existing entry.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `entry.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="entry">
        /// Required. Updates for the entry. The `name` field must be set.
        /// </param>
        /// <param name="updateMask">
        /// Names of fields whose values to overwrite on an entry.
        /// 
        /// If this parameter is absent or empty, all modifiable fields
        /// are overwritten. If such fields are non-required and omitted in the
        /// request body, their values are emptied.
        /// 
        /// You can modify only the fields listed below.
        /// 
        /// For entries with type `DATA_STREAM`:
        /// 
        /// * `schema`
        /// 
        /// For entries with type `FILESET`:
        /// 
        /// * `schema`
        /// * `display_name`
        /// * `description`
        /// * `gcs_fileset_spec`
        /// * `gcs_fileset_spec.file_patterns`
        /// 
        /// For entries with `user_specified_type`:
        /// 
        /// * `schema`
        /// * `display_name`
        /// * `description`
        /// * `user_specified_type`
        /// * `user_specified_system`
        /// * `linked_resource`
        /// * `source_system_timestamps`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> UpdateEntryAsync(Entry entry, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEntryAsync(entry, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing entry.
        /// 
        /// You can delete only the entries created by the
        /// [CreateEntry][google.cloud.datacatalog.v1.DataCatalog.CreateEntry]
        /// method.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEntry(DeleteEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing entry.
        /// 
        /// You can delete only the entries created by the
        /// [CreateEntry][google.cloud.datacatalog.v1.DataCatalog.CreateEntry]
        /// method.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntryAsync(DeleteEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing entry.
        /// 
        /// You can delete only the entries created by the
        /// [CreateEntry][google.cloud.datacatalog.v1.DataCatalog.CreateEntry]
        /// method.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntryAsync(DeleteEntryRequest request, st::CancellationToken cancellationToken) =>
            DeleteEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing entry.
        /// 
        /// You can delete only the entries created by the
        /// [CreateEntry][google.cloud.datacatalog.v1.DataCatalog.CreateEntry]
        /// method.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEntry(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntry(new DeleteEntryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing entry.
        /// 
        /// You can delete only the entries created by the
        /// [CreateEntry][google.cloud.datacatalog.v1.DataCatalog.CreateEntry]
        /// method.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntryAsync(new DeleteEntryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing entry.
        /// 
        /// You can delete only the entries created by the
        /// [CreateEntry][google.cloud.datacatalog.v1.DataCatalog.CreateEntry]
        /// method.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntryAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEntryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing entry.
        /// 
        /// You can delete only the entries created by the
        /// [CreateEntry][google.cloud.datacatalog.v1.DataCatalog.CreateEntry]
        /// method.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEntry(EntryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntry(new DeleteEntryRequest
            {
                EntryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing entry.
        /// 
        /// You can delete only the entries created by the
        /// [CreateEntry][google.cloud.datacatalog.v1.DataCatalog.CreateEntry]
        /// method.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntryAsync(EntryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntryAsync(new DeleteEntryRequest
            {
                EntryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing entry.
        /// 
        /// You can delete only the entries created by the
        /// [CreateEntry][google.cloud.datacatalog.v1.DataCatalog.CreateEntry]
        /// method.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntryAsync(EntryName name, st::CancellationToken cancellationToken) =>
            DeleteEntryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entry GetEntry(GetEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> GetEntryAsync(GetEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> GetEntryAsync(GetEntryRequest request, st::CancellationToken cancellationToken) =>
            GetEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an entry.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entry GetEntry(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntry(new GetEntryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an entry.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> GetEntryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntryAsync(new GetEntryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an entry.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> GetEntryAsync(string name, st::CancellationToken cancellationToken) =>
            GetEntryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an entry.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entry GetEntry(EntryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntry(new GetEntryRequest
            {
                EntryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an entry.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> GetEntryAsync(EntryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntryAsync(new GetEntryRequest
            {
                EntryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an entry.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> GetEntryAsync(EntryName name, st::CancellationToken cancellationToken) =>
            GetEntryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an entry by its target resource name.
        /// 
        /// The resource name comes from the source Google Cloud Platform service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entry LookupEntry(LookupEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an entry by its target resource name.
        /// 
        /// The resource name comes from the source Google Cloud Platform service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> LookupEntryAsync(LookupEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an entry by its target resource name.
        /// 
        /// The resource name comes from the source Google Cloud Platform service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> LookupEntryAsync(LookupEntryRequest request, st::CancellationToken cancellationToken) =>
            LookupEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists entries.
        /// 
        /// Note: Currently, this method can list only custom entries.
        /// To get a list of both custom and automatically created entries, use
        /// [SearchCatalog][google.cloud.datacatalog.v1.DataCatalog.SearchCatalog].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Entry"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntriesResponse, Entry> ListEntries(ListEntriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists entries.
        /// 
        /// Note: Currently, this method can list only custom entries.
        /// To get a list of both custom and automatically created entries, use
        /// [SearchCatalog][google.cloud.datacatalog.v1.DataCatalog.SearchCatalog].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Entry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntriesResponse, Entry> ListEntriesAsync(ListEntriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists entries.
        /// 
        /// Note: Currently, this method can list only custom entries.
        /// To get a list of both custom and automatically created entries, use
        /// [SearchCatalog][google.cloud.datacatalog.v1.DataCatalog.SearchCatalog].
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entry group that contains the entries to list.
        /// 
        /// Can be provided in URL format.
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
        /// <returns>A pageable sequence of <see cref="Entry"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntriesResponse, Entry> ListEntries(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntriesRequest request = new ListEntriesRequest
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
            return ListEntries(request, callSettings);
        }

        /// <summary>
        /// Lists entries.
        /// 
        /// Note: Currently, this method can list only custom entries.
        /// To get a list of both custom and automatically created entries, use
        /// [SearchCatalog][google.cloud.datacatalog.v1.DataCatalog.SearchCatalog].
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entry group that contains the entries to list.
        /// 
        /// Can be provided in URL format.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Entry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntriesResponse, Entry> ListEntriesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntriesRequest request = new ListEntriesRequest
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
            return ListEntriesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists entries.
        /// 
        /// Note: Currently, this method can list only custom entries.
        /// To get a list of both custom and automatically created entries, use
        /// [SearchCatalog][google.cloud.datacatalog.v1.DataCatalog.SearchCatalog].
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entry group that contains the entries to list.
        /// 
        /// Can be provided in URL format.
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
        /// <returns>A pageable sequence of <see cref="Entry"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntriesResponse, Entry> ListEntries(EntryGroupName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntriesRequest request = new ListEntriesRequest
            {
                ParentAsEntryGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEntries(request, callSettings);
        }

        /// <summary>
        /// Lists entries.
        /// 
        /// Note: Currently, this method can list only custom entries.
        /// To get a list of both custom and automatically created entries, use
        /// [SearchCatalog][google.cloud.datacatalog.v1.DataCatalog.SearchCatalog].
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entry group that contains the entries to list.
        /// 
        /// Can be provided in URL format.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Entry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntriesResponse, Entry> ListEntriesAsync(EntryGroupName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntriesRequest request = new ListEntriesRequest
            {
                ParentAsEntryGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEntriesAsync(request, callSettings);
        }

        /// <summary>
        /// Modifies entry overview, part of the business context of an
        /// [Entry][google.cloud.datacatalog.v1.Entry].
        /// 
        /// To call this method, you must have the `datacatalog.entries.updateOverview`
        /// IAM permission on the corresponding project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntryOverview ModifyEntryOverview(ModifyEntryOverviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Modifies entry overview, part of the business context of an
        /// [Entry][google.cloud.datacatalog.v1.Entry].
        /// 
        /// To call this method, you must have the `datacatalog.entries.updateOverview`
        /// IAM permission on the corresponding project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryOverview> ModifyEntryOverviewAsync(ModifyEntryOverviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Modifies entry overview, part of the business context of an
        /// [Entry][google.cloud.datacatalog.v1.Entry].
        /// 
        /// To call this method, you must have the `datacatalog.entries.updateOverview`
        /// IAM permission on the corresponding project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryOverview> ModifyEntryOverviewAsync(ModifyEntryOverviewRequest request, st::CancellationToken cancellationToken) =>
            ModifyEntryOverviewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies contacts, part of the business context of an
        /// [Entry][google.cloud.datacatalog.v1.Entry].
        /// 
        /// To call this method, you must have the `datacatalog.entries.updateContacts`
        /// IAM permission on the corresponding project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Contacts ModifyEntryContacts(ModifyEntryContactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Modifies contacts, part of the business context of an
        /// [Entry][google.cloud.datacatalog.v1.Entry].
        /// 
        /// To call this method, you must have the `datacatalog.entries.updateContacts`
        /// IAM permission on the corresponding project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contacts> ModifyEntryContactsAsync(ModifyEntryContactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Modifies contacts, part of the business context of an
        /// [Entry][google.cloud.datacatalog.v1.Entry].
        /// 
        /// To call this method, you must have the `datacatalog.entries.updateContacts`
        /// IAM permission on the corresponding project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Contacts> ModifyEntryContactsAsync(ModifyEntryContactsRequest request, st::CancellationToken cancellationToken) =>
            ModifyEntryContactsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by the
        /// `parent` parameter.
        /// For more information, see [Data Catalog resource project]
        /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagTemplate CreateTagTemplate(CreateTagTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by the
        /// `parent` parameter.
        /// For more information, see [Data Catalog resource project]
        /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplate> CreateTagTemplateAsync(CreateTagTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by the
        /// `parent` parameter.
        /// For more information, see [Data Catalog resource project]
        /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplate> CreateTagTemplateAsync(CreateTagTemplateRequest request, st::CancellationToken cancellationToken) =>
            CreateTagTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by the
        /// `parent` parameter.
        /// For more information, see [Data Catalog resource project]
        /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project and the template location
        /// [region](https://cloud.google.com/data-catalog/docs/concepts/regions).
        /// </param>
        /// <param name="tagTemplateId">
        /// Required. The ID of the tag template to create.
        /// 
        /// The ID must contain only lowercase letters (a-z), numbers (0-9),
        /// or underscores (_), and must start with a letter or underscore.
        /// The maximum size is 64 bytes when encoded in UTF-8.
        /// </param>
        /// <param name="tagTemplate">
        /// Required. The tag template to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagTemplate CreateTagTemplate(string parent, string tagTemplateId, TagTemplate tagTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateTagTemplate(new CreateTagTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TagTemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(tagTemplateId, nameof(tagTemplateId)),
                TagTemplate = gax::GaxPreconditions.CheckNotNull(tagTemplate, nameof(tagTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by the
        /// `parent` parameter.
        /// For more information, see [Data Catalog resource project]
        /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project and the template location
        /// [region](https://cloud.google.com/data-catalog/docs/concepts/regions).
        /// </param>
        /// <param name="tagTemplateId">
        /// Required. The ID of the tag template to create.
        /// 
        /// The ID must contain only lowercase letters (a-z), numbers (0-9),
        /// or underscores (_), and must start with a letter or underscore.
        /// The maximum size is 64 bytes when encoded in UTF-8.
        /// </param>
        /// <param name="tagTemplate">
        /// Required. The tag template to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplate> CreateTagTemplateAsync(string parent, string tagTemplateId, TagTemplate tagTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateTagTemplateAsync(new CreateTagTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TagTemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(tagTemplateId, nameof(tagTemplateId)),
                TagTemplate = gax::GaxPreconditions.CheckNotNull(tagTemplate, nameof(tagTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by the
        /// `parent` parameter.
        /// For more information, see [Data Catalog resource project]
        /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project and the template location
        /// [region](https://cloud.google.com/data-catalog/docs/concepts/regions).
        /// </param>
        /// <param name="tagTemplateId">
        /// Required. The ID of the tag template to create.
        /// 
        /// The ID must contain only lowercase letters (a-z), numbers (0-9),
        /// or underscores (_), and must start with a letter or underscore.
        /// The maximum size is 64 bytes when encoded in UTF-8.
        /// </param>
        /// <param name="tagTemplate">
        /// Required. The tag template to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplate> CreateTagTemplateAsync(string parent, string tagTemplateId, TagTemplate tagTemplate, st::CancellationToken cancellationToken) =>
            CreateTagTemplateAsync(parent, tagTemplateId, tagTemplate, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by the
        /// `parent` parameter.
        /// For more information, see [Data Catalog resource project]
        /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project and the template location
        /// [region](https://cloud.google.com/data-catalog/docs/concepts/regions).
        /// </param>
        /// <param name="tagTemplateId">
        /// Required. The ID of the tag template to create.
        /// 
        /// The ID must contain only lowercase letters (a-z), numbers (0-9),
        /// or underscores (_), and must start with a letter or underscore.
        /// The maximum size is 64 bytes when encoded in UTF-8.
        /// </param>
        /// <param name="tagTemplate">
        /// Required. The tag template to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagTemplate CreateTagTemplate(gagr::LocationName parent, string tagTemplateId, TagTemplate tagTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateTagTemplate(new CreateTagTemplateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TagTemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(tagTemplateId, nameof(tagTemplateId)),
                TagTemplate = gax::GaxPreconditions.CheckNotNull(tagTemplate, nameof(tagTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by the
        /// `parent` parameter.
        /// For more information, see [Data Catalog resource project]
        /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project and the template location
        /// [region](https://cloud.google.com/data-catalog/docs/concepts/regions).
        /// </param>
        /// <param name="tagTemplateId">
        /// Required. The ID of the tag template to create.
        /// 
        /// The ID must contain only lowercase letters (a-z), numbers (0-9),
        /// or underscores (_), and must start with a letter or underscore.
        /// The maximum size is 64 bytes when encoded in UTF-8.
        /// </param>
        /// <param name="tagTemplate">
        /// Required. The tag template to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplate> CreateTagTemplateAsync(gagr::LocationName parent, string tagTemplateId, TagTemplate tagTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateTagTemplateAsync(new CreateTagTemplateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TagTemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(tagTemplateId, nameof(tagTemplateId)),
                TagTemplate = gax::GaxPreconditions.CheckNotNull(tagTemplate, nameof(tagTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by the
        /// `parent` parameter.
        /// For more information, see [Data Catalog resource project]
        /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project and the template location
        /// [region](https://cloud.google.com/data-catalog/docs/concepts/regions).
        /// </param>
        /// <param name="tagTemplateId">
        /// Required. The ID of the tag template to create.
        /// 
        /// The ID must contain only lowercase letters (a-z), numbers (0-9),
        /// or underscores (_), and must start with a letter or underscore.
        /// The maximum size is 64 bytes when encoded in UTF-8.
        /// </param>
        /// <param name="tagTemplate">
        /// Required. The tag template to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplate> CreateTagTemplateAsync(gagr::LocationName parent, string tagTemplateId, TagTemplate tagTemplate, st::CancellationToken cancellationToken) =>
            CreateTagTemplateAsync(parent, tagTemplateId, tagTemplate, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a tag template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagTemplate GetTagTemplate(GetTagTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a tag template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplate> GetTagTemplateAsync(GetTagTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a tag template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplate> GetTagTemplateAsync(GetTagTemplateRequest request, st::CancellationToken cancellationToken) =>
            GetTagTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a tag template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagTemplate GetTagTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTagTemplate(new GetTagTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a tag template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplate> GetTagTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTagTemplateAsync(new GetTagTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a tag template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplate> GetTagTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            GetTagTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a tag template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagTemplate GetTagTemplate(TagTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTagTemplate(new GetTagTemplateRequest
            {
                TagTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a tag template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplate> GetTagTemplateAsync(TagTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTagTemplateAsync(new GetTagTemplateRequest
            {
                TagTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a tag template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplate> GetTagTemplateAsync(TagTemplateName name, st::CancellationToken cancellationToken) =>
            GetTagTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a tag template.
        /// 
        /// You can't update template fields with this method. These fields are
        /// separate resources with their own create, update, and delete methods.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `tag_template.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagTemplate UpdateTagTemplate(UpdateTagTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a tag template.
        /// 
        /// You can't update template fields with this method. These fields are
        /// separate resources with their own create, update, and delete methods.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `tag_template.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplate> UpdateTagTemplateAsync(UpdateTagTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a tag template.
        /// 
        /// You can't update template fields with this method. These fields are
        /// separate resources with their own create, update, and delete methods.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `tag_template.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplate> UpdateTagTemplateAsync(UpdateTagTemplateRequest request, st::CancellationToken cancellationToken) =>
            UpdateTagTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a tag template.
        /// 
        /// You can't update template fields with this method. These fields are
        /// separate resources with their own create, update, and delete methods.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `tag_template.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="tagTemplate">
        /// Required. The template to update. The `name` field must be set.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagTemplate UpdateTagTemplate(TagTemplate tagTemplate, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTagTemplate(new UpdateTagTemplateRequest
            {
                TagTemplate = gax::GaxPreconditions.CheckNotNull(tagTemplate, nameof(tagTemplate)),
            }, callSettings);

        /// <summary>
        /// Updates a tag template.
        /// 
        /// You can't update template fields with this method. These fields are
        /// separate resources with their own create, update, and delete methods.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `tag_template.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="tagTemplate">
        /// Required. The template to update. The `name` field must be set.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplate> UpdateTagTemplateAsync(TagTemplate tagTemplate, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTagTemplateAsync(new UpdateTagTemplateRequest
            {
                TagTemplate = gax::GaxPreconditions.CheckNotNull(tagTemplate, nameof(tagTemplate)),
            }, callSettings);

        /// <summary>
        /// Updates a tag template.
        /// 
        /// You can't update template fields with this method. These fields are
        /// separate resources with their own create, update, and delete methods.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `tag_template.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="tagTemplate">
        /// Required. The template to update. The `name` field must be set.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplate> UpdateTagTemplateAsync(TagTemplate tagTemplate, st::CancellationToken cancellationToken) =>
            UpdateTagTemplateAsync(tagTemplate, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a tag template.
        /// 
        /// You can't update template fields with this method. These fields are
        /// separate resources with their own create, update, and delete methods.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `tag_template.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="tagTemplate">
        /// Required. The template to update. The `name` field must be set.
        /// </param>
        /// <param name="updateMask">
        /// Names of fields whose values to overwrite on a tag template. Currently,
        /// only `display_name` and `is_publicly_readable` can be overwritten.
        /// 
        /// If this parameter is absent or empty, all modifiable fields
        /// are overwritten. If such fields are non-required and omitted in the
        /// request body, their values are emptied.
        /// 
        /// Note: Updating the `is_publicly_readable` field may require up to 12
        /// hours to take effect in search results.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagTemplate UpdateTagTemplate(TagTemplate tagTemplate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTagTemplate(new UpdateTagTemplateRequest
            {
                TagTemplate = gax::GaxPreconditions.CheckNotNull(tagTemplate, nameof(tagTemplate)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a tag template.
        /// 
        /// You can't update template fields with this method. These fields are
        /// separate resources with their own create, update, and delete methods.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `tag_template.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="tagTemplate">
        /// Required. The template to update. The `name` field must be set.
        /// </param>
        /// <param name="updateMask">
        /// Names of fields whose values to overwrite on a tag template. Currently,
        /// only `display_name` and `is_publicly_readable` can be overwritten.
        /// 
        /// If this parameter is absent or empty, all modifiable fields
        /// are overwritten. If such fields are non-required and omitted in the
        /// request body, their values are emptied.
        /// 
        /// Note: Updating the `is_publicly_readable` field may require up to 12
        /// hours to take effect in search results.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplate> UpdateTagTemplateAsync(TagTemplate tagTemplate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTagTemplateAsync(new UpdateTagTemplateRequest
            {
                TagTemplate = gax::GaxPreconditions.CheckNotNull(tagTemplate, nameof(tagTemplate)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a tag template.
        /// 
        /// You can't update template fields with this method. These fields are
        /// separate resources with their own create, update, and delete methods.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `tag_template.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="tagTemplate">
        /// Required. The template to update. The `name` field must be set.
        /// </param>
        /// <param name="updateMask">
        /// Names of fields whose values to overwrite on a tag template. Currently,
        /// only `display_name` and `is_publicly_readable` can be overwritten.
        /// 
        /// If this parameter is absent or empty, all modifiable fields
        /// are overwritten. If such fields are non-required and omitted in the
        /// request body, their values are emptied.
        /// 
        /// Note: Updating the `is_publicly_readable` field may require up to 12
        /// hours to take effect in search results.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplate> UpdateTagTemplateAsync(TagTemplate tagTemplate, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTagTemplateAsync(tagTemplate, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a tag template and all tags that use it.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTagTemplate(DeleteTagTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a tag template and all tags that use it.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTagTemplateAsync(DeleteTagTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a tag template and all tags that use it.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTagTemplateAsync(DeleteTagTemplateRequest request, st::CancellationToken cancellationToken) =>
            DeleteTagTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a tag template and all tags that use it.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template to delete.
        /// </param>
        /// <param name="force">
        /// Required. If true, deletes all tags that use this template.
        /// 
        /// Currently, `true` is the only supported value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTagTemplate(string name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagTemplate(new DeleteTagTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a tag template and all tags that use it.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template to delete.
        /// </param>
        /// <param name="force">
        /// Required. If true, deletes all tags that use this template.
        /// 
        /// Currently, `true` is the only supported value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTagTemplateAsync(string name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagTemplateAsync(new DeleteTagTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a tag template and all tags that use it.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template to delete.
        /// </param>
        /// <param name="force">
        /// Required. If true, deletes all tags that use this template.
        /// 
        /// Currently, `true` is the only supported value.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTagTemplateAsync(string name, bool force, st::CancellationToken cancellationToken) =>
            DeleteTagTemplateAsync(name, force, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a tag template and all tags that use it.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template to delete.
        /// </param>
        /// <param name="force">
        /// Required. If true, deletes all tags that use this template.
        /// 
        /// Currently, `true` is the only supported value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTagTemplate(TagTemplateName name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagTemplate(new DeleteTagTemplateRequest
            {
                TagTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a tag template and all tags that use it.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template to delete.
        /// </param>
        /// <param name="force">
        /// Required. If true, deletes all tags that use this template.
        /// 
        /// Currently, `true` is the only supported value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTagTemplateAsync(TagTemplateName name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagTemplateAsync(new DeleteTagTemplateRequest
            {
                TagTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a tag template and all tags that use it.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template to delete.
        /// </param>
        /// <param name="force">
        /// Required. If true, deletes all tags that use this template.
        /// 
        /// Currently, `true` is the only supported value.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTagTemplateAsync(TagTemplateName name, bool force, st::CancellationToken cancellationToken) =>
            DeleteTagTemplateAsync(name, force, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a field in a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagTemplateField CreateTagTemplateField(CreateTagTemplateFieldRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a field in a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> CreateTagTemplateFieldAsync(CreateTagTemplateFieldRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a field in a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> CreateTagTemplateFieldAsync(CreateTagTemplateFieldRequest request, st::CancellationToken cancellationToken) =>
            CreateTagTemplateFieldAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a field in a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project and the template location
        /// [region](https://cloud.google.com/data-catalog/docs/concepts/regions).
        /// </param>
        /// <param name="tagTemplateFieldId">
        /// Required. The ID of the tag template field to create.
        /// 
        /// Note: Adding a required field to an existing template is *not* allowed.
        /// 
        /// Field IDs can contain letters (both uppercase and lowercase), numbers
        /// (0-9), underscores (_) and dashes (-). Field IDs must be at least 1
        /// character long and at most 128 characters long. Field IDs must also be
        /// unique within their template.
        /// </param>
        /// <param name="tagTemplateField">
        /// Required. The tag template field to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagTemplateField CreateTagTemplateField(string parent, string tagTemplateFieldId, TagTemplateField tagTemplateField, gaxgrpc::CallSettings callSettings = null) =>
            CreateTagTemplateField(new CreateTagTemplateFieldRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TagTemplateFieldId = gax::GaxPreconditions.CheckNotNullOrEmpty(tagTemplateFieldId, nameof(tagTemplateFieldId)),
                TagTemplateField = gax::GaxPreconditions.CheckNotNull(tagTemplateField, nameof(tagTemplateField)),
            }, callSettings);

        /// <summary>
        /// Creates a field in a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project and the template location
        /// [region](https://cloud.google.com/data-catalog/docs/concepts/regions).
        /// </param>
        /// <param name="tagTemplateFieldId">
        /// Required. The ID of the tag template field to create.
        /// 
        /// Note: Adding a required field to an existing template is *not* allowed.
        /// 
        /// Field IDs can contain letters (both uppercase and lowercase), numbers
        /// (0-9), underscores (_) and dashes (-). Field IDs must be at least 1
        /// character long and at most 128 characters long. Field IDs must also be
        /// unique within their template.
        /// </param>
        /// <param name="tagTemplateField">
        /// Required. The tag template field to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> CreateTagTemplateFieldAsync(string parent, string tagTemplateFieldId, TagTemplateField tagTemplateField, gaxgrpc::CallSettings callSettings = null) =>
            CreateTagTemplateFieldAsync(new CreateTagTemplateFieldRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TagTemplateFieldId = gax::GaxPreconditions.CheckNotNullOrEmpty(tagTemplateFieldId, nameof(tagTemplateFieldId)),
                TagTemplateField = gax::GaxPreconditions.CheckNotNull(tagTemplateField, nameof(tagTemplateField)),
            }, callSettings);

        /// <summary>
        /// Creates a field in a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project and the template location
        /// [region](https://cloud.google.com/data-catalog/docs/concepts/regions).
        /// </param>
        /// <param name="tagTemplateFieldId">
        /// Required. The ID of the tag template field to create.
        /// 
        /// Note: Adding a required field to an existing template is *not* allowed.
        /// 
        /// Field IDs can contain letters (both uppercase and lowercase), numbers
        /// (0-9), underscores (_) and dashes (-). Field IDs must be at least 1
        /// character long and at most 128 characters long. Field IDs must also be
        /// unique within their template.
        /// </param>
        /// <param name="tagTemplateField">
        /// Required. The tag template field to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> CreateTagTemplateFieldAsync(string parent, string tagTemplateFieldId, TagTemplateField tagTemplateField, st::CancellationToken cancellationToken) =>
            CreateTagTemplateFieldAsync(parent, tagTemplateFieldId, tagTemplateField, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a field in a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project and the template location
        /// [region](https://cloud.google.com/data-catalog/docs/concepts/regions).
        /// </param>
        /// <param name="tagTemplateFieldId">
        /// Required. The ID of the tag template field to create.
        /// 
        /// Note: Adding a required field to an existing template is *not* allowed.
        /// 
        /// Field IDs can contain letters (both uppercase and lowercase), numbers
        /// (0-9), underscores (_) and dashes (-). Field IDs must be at least 1
        /// character long and at most 128 characters long. Field IDs must also be
        /// unique within their template.
        /// </param>
        /// <param name="tagTemplateField">
        /// Required. The tag template field to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagTemplateField CreateTagTemplateField(TagTemplateName parent, string tagTemplateFieldId, TagTemplateField tagTemplateField, gaxgrpc::CallSettings callSettings = null) =>
            CreateTagTemplateField(new CreateTagTemplateFieldRequest
            {
                ParentAsTagTemplateName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TagTemplateFieldId = gax::GaxPreconditions.CheckNotNullOrEmpty(tagTemplateFieldId, nameof(tagTemplateFieldId)),
                TagTemplateField = gax::GaxPreconditions.CheckNotNull(tagTemplateField, nameof(tagTemplateField)),
            }, callSettings);

        /// <summary>
        /// Creates a field in a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project and the template location
        /// [region](https://cloud.google.com/data-catalog/docs/concepts/regions).
        /// </param>
        /// <param name="tagTemplateFieldId">
        /// Required. The ID of the tag template field to create.
        /// 
        /// Note: Adding a required field to an existing template is *not* allowed.
        /// 
        /// Field IDs can contain letters (both uppercase and lowercase), numbers
        /// (0-9), underscores (_) and dashes (-). Field IDs must be at least 1
        /// character long and at most 128 characters long. Field IDs must also be
        /// unique within their template.
        /// </param>
        /// <param name="tagTemplateField">
        /// Required. The tag template field to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> CreateTagTemplateFieldAsync(TagTemplateName parent, string tagTemplateFieldId, TagTemplateField tagTemplateField, gaxgrpc::CallSettings callSettings = null) =>
            CreateTagTemplateFieldAsync(new CreateTagTemplateFieldRequest
            {
                ParentAsTagTemplateName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TagTemplateFieldId = gax::GaxPreconditions.CheckNotNullOrEmpty(tagTemplateFieldId, nameof(tagTemplateFieldId)),
                TagTemplateField = gax::GaxPreconditions.CheckNotNull(tagTemplateField, nameof(tagTemplateField)),
            }, callSettings);

        /// <summary>
        /// Creates a field in a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project and the template location
        /// [region](https://cloud.google.com/data-catalog/docs/concepts/regions).
        /// </param>
        /// <param name="tagTemplateFieldId">
        /// Required. The ID of the tag template field to create.
        /// 
        /// Note: Adding a required field to an existing template is *not* allowed.
        /// 
        /// Field IDs can contain letters (both uppercase and lowercase), numbers
        /// (0-9), underscores (_) and dashes (-). Field IDs must be at least 1
        /// character long and at most 128 characters long. Field IDs must also be
        /// unique within their template.
        /// </param>
        /// <param name="tagTemplateField">
        /// Required. The tag template field to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> CreateTagTemplateFieldAsync(TagTemplateName parent, string tagTemplateFieldId, TagTemplateField tagTemplateField, st::CancellationToken cancellationToken) =>
            CreateTagTemplateFieldAsync(parent, tagTemplateFieldId, tagTemplateField, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a field in a tag template.
        /// 
        /// You can't update the field type with this method.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagTemplateField UpdateTagTemplateField(UpdateTagTemplateFieldRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a field in a tag template.
        /// 
        /// You can't update the field type with this method.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> UpdateTagTemplateFieldAsync(UpdateTagTemplateFieldRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a field in a tag template.
        /// 
        /// You can't update the field type with this method.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> UpdateTagTemplateFieldAsync(UpdateTagTemplateFieldRequest request, st::CancellationToken cancellationToken) =>
            UpdateTagTemplateFieldAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a field in a tag template.
        /// 
        /// You can't update the field type with this method.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template field.
        /// </param>
        /// <param name="tagTemplateField">
        /// Required. The template to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagTemplateField UpdateTagTemplateField(string name, TagTemplateField tagTemplateField, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTagTemplateField(new UpdateTagTemplateFieldRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                TagTemplateField = gax::GaxPreconditions.CheckNotNull(tagTemplateField, nameof(tagTemplateField)),
            }, callSettings);

        /// <summary>
        /// Updates a field in a tag template.
        /// 
        /// You can't update the field type with this method.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template field.
        /// </param>
        /// <param name="tagTemplateField">
        /// Required. The template to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> UpdateTagTemplateFieldAsync(string name, TagTemplateField tagTemplateField, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTagTemplateFieldAsync(new UpdateTagTemplateFieldRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                TagTemplateField = gax::GaxPreconditions.CheckNotNull(tagTemplateField, nameof(tagTemplateField)),
            }, callSettings);

        /// <summary>
        /// Updates a field in a tag template.
        /// 
        /// You can't update the field type with this method.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template field.
        /// </param>
        /// <param name="tagTemplateField">
        /// Required. The template to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> UpdateTagTemplateFieldAsync(string name, TagTemplateField tagTemplateField, st::CancellationToken cancellationToken) =>
            UpdateTagTemplateFieldAsync(name, tagTemplateField, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a field in a tag template.
        /// 
        /// You can't update the field type with this method.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template field.
        /// </param>
        /// <param name="tagTemplateField">
        /// Required. The template to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagTemplateField UpdateTagTemplateField(TagTemplateFieldName name, TagTemplateField tagTemplateField, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTagTemplateField(new UpdateTagTemplateFieldRequest
            {
                TagTemplateFieldName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                TagTemplateField = gax::GaxPreconditions.CheckNotNull(tagTemplateField, nameof(tagTemplateField)),
            }, callSettings);

        /// <summary>
        /// Updates a field in a tag template.
        /// 
        /// You can't update the field type with this method.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template field.
        /// </param>
        /// <param name="tagTemplateField">
        /// Required. The template to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> UpdateTagTemplateFieldAsync(TagTemplateFieldName name, TagTemplateField tagTemplateField, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTagTemplateFieldAsync(new UpdateTagTemplateFieldRequest
            {
                TagTemplateFieldName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                TagTemplateField = gax::GaxPreconditions.CheckNotNull(tagTemplateField, nameof(tagTemplateField)),
            }, callSettings);

        /// <summary>
        /// Updates a field in a tag template.
        /// 
        /// You can't update the field type with this method.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template field.
        /// </param>
        /// <param name="tagTemplateField">
        /// Required. The template to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> UpdateTagTemplateFieldAsync(TagTemplateFieldName name, TagTemplateField tagTemplateField, st::CancellationToken cancellationToken) =>
            UpdateTagTemplateFieldAsync(name, tagTemplateField, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a field in a tag template.
        /// 
        /// You can't update the field type with this method.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template field.
        /// </param>
        /// <param name="tagTemplateField">
        /// Required. The template to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Names of fields whose values to overwrite on an individual field
        /// of a tag template. The following fields are modifiable:
        /// 
        /// * `display_name`
        /// * `type.enum_type`
        /// * `is_required`
        /// 
        /// If this parameter is absent or empty, all modifiable fields
        /// are overwritten. If such fields are non-required and omitted in the request
        /// body, their values are emptied with one exception: when updating an enum
        /// type, the provided values are merged with the existing values. Therefore,
        /// enum values can only be added, existing enum values cannot be deleted or
        /// renamed.
        /// 
        /// Additionally, updating a template field from optional to required is
        /// *not* allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagTemplateField UpdateTagTemplateField(string name, TagTemplateField tagTemplateField, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTagTemplateField(new UpdateTagTemplateFieldRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                TagTemplateField = gax::GaxPreconditions.CheckNotNull(tagTemplateField, nameof(tagTemplateField)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a field in a tag template.
        /// 
        /// You can't update the field type with this method.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template field.
        /// </param>
        /// <param name="tagTemplateField">
        /// Required. The template to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Names of fields whose values to overwrite on an individual field
        /// of a tag template. The following fields are modifiable:
        /// 
        /// * `display_name`
        /// * `type.enum_type`
        /// * `is_required`
        /// 
        /// If this parameter is absent or empty, all modifiable fields
        /// are overwritten. If such fields are non-required and omitted in the request
        /// body, their values are emptied with one exception: when updating an enum
        /// type, the provided values are merged with the existing values. Therefore,
        /// enum values can only be added, existing enum values cannot be deleted or
        /// renamed.
        /// 
        /// Additionally, updating a template field from optional to required is
        /// *not* allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> UpdateTagTemplateFieldAsync(string name, TagTemplateField tagTemplateField, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTagTemplateFieldAsync(new UpdateTagTemplateFieldRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                TagTemplateField = gax::GaxPreconditions.CheckNotNull(tagTemplateField, nameof(tagTemplateField)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a field in a tag template.
        /// 
        /// You can't update the field type with this method.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template field.
        /// </param>
        /// <param name="tagTemplateField">
        /// Required. The template to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Names of fields whose values to overwrite on an individual field
        /// of a tag template. The following fields are modifiable:
        /// 
        /// * `display_name`
        /// * `type.enum_type`
        /// * `is_required`
        /// 
        /// If this parameter is absent or empty, all modifiable fields
        /// are overwritten. If such fields are non-required and omitted in the request
        /// body, their values are emptied with one exception: when updating an enum
        /// type, the provided values are merged with the existing values. Therefore,
        /// enum values can only be added, existing enum values cannot be deleted or
        /// renamed.
        /// 
        /// Additionally, updating a template field from optional to required is
        /// *not* allowed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> UpdateTagTemplateFieldAsync(string name, TagTemplateField tagTemplateField, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTagTemplateFieldAsync(name, tagTemplateField, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a field in a tag template.
        /// 
        /// You can't update the field type with this method.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template field.
        /// </param>
        /// <param name="tagTemplateField">
        /// Required. The template to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Names of fields whose values to overwrite on an individual field
        /// of a tag template. The following fields are modifiable:
        /// 
        /// * `display_name`
        /// * `type.enum_type`
        /// * `is_required`
        /// 
        /// If this parameter is absent or empty, all modifiable fields
        /// are overwritten. If such fields are non-required and omitted in the request
        /// body, their values are emptied with one exception: when updating an enum
        /// type, the provided values are merged with the existing values. Therefore,
        /// enum values can only be added, existing enum values cannot be deleted or
        /// renamed.
        /// 
        /// Additionally, updating a template field from optional to required is
        /// *not* allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagTemplateField UpdateTagTemplateField(TagTemplateFieldName name, TagTemplateField tagTemplateField, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTagTemplateField(new UpdateTagTemplateFieldRequest
            {
                TagTemplateFieldName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                TagTemplateField = gax::GaxPreconditions.CheckNotNull(tagTemplateField, nameof(tagTemplateField)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a field in a tag template.
        /// 
        /// You can't update the field type with this method.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template field.
        /// </param>
        /// <param name="tagTemplateField">
        /// Required. The template to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Names of fields whose values to overwrite on an individual field
        /// of a tag template. The following fields are modifiable:
        /// 
        /// * `display_name`
        /// * `type.enum_type`
        /// * `is_required`
        /// 
        /// If this parameter is absent or empty, all modifiable fields
        /// are overwritten. If such fields are non-required and omitted in the request
        /// body, their values are emptied with one exception: when updating an enum
        /// type, the provided values are merged with the existing values. Therefore,
        /// enum values can only be added, existing enum values cannot be deleted or
        /// renamed.
        /// 
        /// Additionally, updating a template field from optional to required is
        /// *not* allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> UpdateTagTemplateFieldAsync(TagTemplateFieldName name, TagTemplateField tagTemplateField, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTagTemplateFieldAsync(new UpdateTagTemplateFieldRequest
            {
                TagTemplateFieldName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                TagTemplateField = gax::GaxPreconditions.CheckNotNull(tagTemplateField, nameof(tagTemplateField)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a field in a tag template.
        /// 
        /// You can't update the field type with this method.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template field.
        /// </param>
        /// <param name="tagTemplateField">
        /// Required. The template to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Names of fields whose values to overwrite on an individual field
        /// of a tag template. The following fields are modifiable:
        /// 
        /// * `display_name`
        /// * `type.enum_type`
        /// * `is_required`
        /// 
        /// If this parameter is absent or empty, all modifiable fields
        /// are overwritten. If such fields are non-required and omitted in the request
        /// body, their values are emptied with one exception: when updating an enum
        /// type, the provided values are merged with the existing values. Therefore,
        /// enum values can only be added, existing enum values cannot be deleted or
        /// renamed.
        /// 
        /// Additionally, updating a template field from optional to required is
        /// *not* allowed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> UpdateTagTemplateFieldAsync(TagTemplateFieldName name, TagTemplateField tagTemplateField, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTagTemplateFieldAsync(name, tagTemplateField, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Renames a field in a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by the
        /// `name` parameter. For more information, see [Data Catalog resource project]
        /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagTemplateField RenameTagTemplateField(RenameTagTemplateFieldRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Renames a field in a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by the
        /// `name` parameter. For more information, see [Data Catalog resource project]
        /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> RenameTagTemplateFieldAsync(RenameTagTemplateFieldRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Renames a field in a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by the
        /// `name` parameter. For more information, see [Data Catalog resource project]
        /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> RenameTagTemplateFieldAsync(RenameTagTemplateFieldRequest request, st::CancellationToken cancellationToken) =>
            RenameTagTemplateFieldAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Renames a field in a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by the
        /// `name` parameter. For more information, see [Data Catalog resource project]
        /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template field.
        /// </param>
        /// <param name="newTagTemplateFieldId">
        /// Required. The new ID of this tag template field. For example,
        /// `my_new_field`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagTemplateField RenameTagTemplateField(string name, string newTagTemplateFieldId, gaxgrpc::CallSettings callSettings = null) =>
            RenameTagTemplateField(new RenameTagTemplateFieldRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                NewTagTemplateFieldId = gax::GaxPreconditions.CheckNotNullOrEmpty(newTagTemplateFieldId, nameof(newTagTemplateFieldId)),
            }, callSettings);

        /// <summary>
        /// Renames a field in a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by the
        /// `name` parameter. For more information, see [Data Catalog resource project]
        /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template field.
        /// </param>
        /// <param name="newTagTemplateFieldId">
        /// Required. The new ID of this tag template field. For example,
        /// `my_new_field`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> RenameTagTemplateFieldAsync(string name, string newTagTemplateFieldId, gaxgrpc::CallSettings callSettings = null) =>
            RenameTagTemplateFieldAsync(new RenameTagTemplateFieldRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                NewTagTemplateFieldId = gax::GaxPreconditions.CheckNotNullOrEmpty(newTagTemplateFieldId, nameof(newTagTemplateFieldId)),
            }, callSettings);

        /// <summary>
        /// Renames a field in a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by the
        /// `name` parameter. For more information, see [Data Catalog resource project]
        /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template field.
        /// </param>
        /// <param name="newTagTemplateFieldId">
        /// Required. The new ID of this tag template field. For example,
        /// `my_new_field`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> RenameTagTemplateFieldAsync(string name, string newTagTemplateFieldId, st::CancellationToken cancellationToken) =>
            RenameTagTemplateFieldAsync(name, newTagTemplateFieldId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Renames a field in a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by the
        /// `name` parameter. For more information, see [Data Catalog resource project]
        /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template field.
        /// </param>
        /// <param name="newTagTemplateFieldId">
        /// Required. The new ID of this tag template field. For example,
        /// `my_new_field`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagTemplateField RenameTagTemplateField(TagTemplateFieldName name, string newTagTemplateFieldId, gaxgrpc::CallSettings callSettings = null) =>
            RenameTagTemplateField(new RenameTagTemplateFieldRequest
            {
                TagTemplateFieldName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                NewTagTemplateFieldId = gax::GaxPreconditions.CheckNotNullOrEmpty(newTagTemplateFieldId, nameof(newTagTemplateFieldId)),
            }, callSettings);

        /// <summary>
        /// Renames a field in a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by the
        /// `name` parameter. For more information, see [Data Catalog resource project]
        /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template field.
        /// </param>
        /// <param name="newTagTemplateFieldId">
        /// Required. The new ID of this tag template field. For example,
        /// `my_new_field`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> RenameTagTemplateFieldAsync(TagTemplateFieldName name, string newTagTemplateFieldId, gaxgrpc::CallSettings callSettings = null) =>
            RenameTagTemplateFieldAsync(new RenameTagTemplateFieldRequest
            {
                TagTemplateFieldName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                NewTagTemplateFieldId = gax::GaxPreconditions.CheckNotNullOrEmpty(newTagTemplateFieldId, nameof(newTagTemplateFieldId)),
            }, callSettings);

        /// <summary>
        /// Renames a field in a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by the
        /// `name` parameter. For more information, see [Data Catalog resource project]
        /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template field.
        /// </param>
        /// <param name="newTagTemplateFieldId">
        /// Required. The new ID of this tag template field. For example,
        /// `my_new_field`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> RenameTagTemplateFieldAsync(TagTemplateFieldName name, string newTagTemplateFieldId, st::CancellationToken cancellationToken) =>
            RenameTagTemplateFieldAsync(name, newTagTemplateFieldId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Renames an enum value in a tag template.
        /// 
        /// Within a single enum field, enum values must be unique.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagTemplateField RenameTagTemplateFieldEnumValue(RenameTagTemplateFieldEnumValueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Renames an enum value in a tag template.
        /// 
        /// Within a single enum field, enum values must be unique.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> RenameTagTemplateFieldEnumValueAsync(RenameTagTemplateFieldEnumValueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Renames an enum value in a tag template.
        /// 
        /// Within a single enum field, enum values must be unique.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> RenameTagTemplateFieldEnumValueAsync(RenameTagTemplateFieldEnumValueRequest request, st::CancellationToken cancellationToken) =>
            RenameTagTemplateFieldEnumValueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Renames an enum value in a tag template.
        /// 
        /// Within a single enum field, enum values must be unique.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the enum field value.
        /// </param>
        /// <param name="newEnumValueDisplayName">
        /// Required. The new display name of the enum value. For example,
        /// `my_new_enum_value`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagTemplateField RenameTagTemplateFieldEnumValue(string name, string newEnumValueDisplayName, gaxgrpc::CallSettings callSettings = null) =>
            RenameTagTemplateFieldEnumValue(new RenameTagTemplateFieldEnumValueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                NewEnumValueDisplayName = gax::GaxPreconditions.CheckNotNullOrEmpty(newEnumValueDisplayName, nameof(newEnumValueDisplayName)),
            }, callSettings);

        /// <summary>
        /// Renames an enum value in a tag template.
        /// 
        /// Within a single enum field, enum values must be unique.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the enum field value.
        /// </param>
        /// <param name="newEnumValueDisplayName">
        /// Required. The new display name of the enum value. For example,
        /// `my_new_enum_value`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> RenameTagTemplateFieldEnumValueAsync(string name, string newEnumValueDisplayName, gaxgrpc::CallSettings callSettings = null) =>
            RenameTagTemplateFieldEnumValueAsync(new RenameTagTemplateFieldEnumValueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                NewEnumValueDisplayName = gax::GaxPreconditions.CheckNotNullOrEmpty(newEnumValueDisplayName, nameof(newEnumValueDisplayName)),
            }, callSettings);

        /// <summary>
        /// Renames an enum value in a tag template.
        /// 
        /// Within a single enum field, enum values must be unique.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the enum field value.
        /// </param>
        /// <param name="newEnumValueDisplayName">
        /// Required. The new display name of the enum value. For example,
        /// `my_new_enum_value`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> RenameTagTemplateFieldEnumValueAsync(string name, string newEnumValueDisplayName, st::CancellationToken cancellationToken) =>
            RenameTagTemplateFieldEnumValueAsync(name, newEnumValueDisplayName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Renames an enum value in a tag template.
        /// 
        /// Within a single enum field, enum values must be unique.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the enum field value.
        /// </param>
        /// <param name="newEnumValueDisplayName">
        /// Required. The new display name of the enum value. For example,
        /// `my_new_enum_value`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagTemplateField RenameTagTemplateFieldEnumValue(TagTemplateFieldEnumValueName name, string newEnumValueDisplayName, gaxgrpc::CallSettings callSettings = null) =>
            RenameTagTemplateFieldEnumValue(new RenameTagTemplateFieldEnumValueRequest
            {
                TagTemplateFieldEnumValueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                NewEnumValueDisplayName = gax::GaxPreconditions.CheckNotNullOrEmpty(newEnumValueDisplayName, nameof(newEnumValueDisplayName)),
            }, callSettings);

        /// <summary>
        /// Renames an enum value in a tag template.
        /// 
        /// Within a single enum field, enum values must be unique.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the enum field value.
        /// </param>
        /// <param name="newEnumValueDisplayName">
        /// Required. The new display name of the enum value. For example,
        /// `my_new_enum_value`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> RenameTagTemplateFieldEnumValueAsync(TagTemplateFieldEnumValueName name, string newEnumValueDisplayName, gaxgrpc::CallSettings callSettings = null) =>
            RenameTagTemplateFieldEnumValueAsync(new RenameTagTemplateFieldEnumValueRequest
            {
                TagTemplateFieldEnumValueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                NewEnumValueDisplayName = gax::GaxPreconditions.CheckNotNullOrEmpty(newEnumValueDisplayName, nameof(newEnumValueDisplayName)),
            }, callSettings);

        /// <summary>
        /// Renames an enum value in a tag template.
        /// 
        /// Within a single enum field, enum values must be unique.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the enum field value.
        /// </param>
        /// <param name="newEnumValueDisplayName">
        /// Required. The new display name of the enum value. For example,
        /// `my_new_enum_value`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagTemplateField> RenameTagTemplateFieldEnumValueAsync(TagTemplateFieldEnumValueName name, string newEnumValueDisplayName, st::CancellationToken cancellationToken) =>
            RenameTagTemplateFieldEnumValueAsync(name, newEnumValueDisplayName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a field in a tag template and all uses of this field from the tags
        /// based on this template.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTagTemplateField(DeleteTagTemplateFieldRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a field in a tag template and all uses of this field from the tags
        /// based on this template.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTagTemplateFieldAsync(DeleteTagTemplateFieldRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a field in a tag template and all uses of this field from the tags
        /// based on this template.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTagTemplateFieldAsync(DeleteTagTemplateFieldRequest request, st::CancellationToken cancellationToken) =>
            DeleteTagTemplateFieldAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a field in a tag template and all uses of this field from the tags
        /// based on this template.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template field to delete.
        /// </param>
        /// <param name="force">
        /// Required. If true, deletes this field from any tags that use it.
        /// 
        /// Currently, `true` is the only supported value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTagTemplateField(string name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagTemplateField(new DeleteTagTemplateFieldRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a field in a tag template and all uses of this field from the tags
        /// based on this template.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template field to delete.
        /// </param>
        /// <param name="force">
        /// Required. If true, deletes this field from any tags that use it.
        /// 
        /// Currently, `true` is the only supported value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTagTemplateFieldAsync(string name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagTemplateFieldAsync(new DeleteTagTemplateFieldRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a field in a tag template and all uses of this field from the tags
        /// based on this template.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template field to delete.
        /// </param>
        /// <param name="force">
        /// Required. If true, deletes this field from any tags that use it.
        /// 
        /// Currently, `true` is the only supported value.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTagTemplateFieldAsync(string name, bool force, st::CancellationToken cancellationToken) =>
            DeleteTagTemplateFieldAsync(name, force, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a field in a tag template and all uses of this field from the tags
        /// based on this template.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template field to delete.
        /// </param>
        /// <param name="force">
        /// Required. If true, deletes this field from any tags that use it.
        /// 
        /// Currently, `true` is the only supported value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTagTemplateField(TagTemplateFieldName name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagTemplateField(new DeleteTagTemplateFieldRequest
            {
                TagTemplateFieldName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a field in a tag template and all uses of this field from the tags
        /// based on this template.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template field to delete.
        /// </param>
        /// <param name="force">
        /// Required. If true, deletes this field from any tags that use it.
        /// 
        /// Currently, `true` is the only supported value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTagTemplateFieldAsync(TagTemplateFieldName name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagTemplateFieldAsync(new DeleteTagTemplateFieldRequest
            {
                TagTemplateFieldName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a field in a tag template and all uses of this field from the tags
        /// based on this template.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag template field to delete.
        /// </param>
        /// <param name="force">
        /// Required. If true, deletes this field from any tags that use it.
        /// 
        /// Currently, `true` is the only supported value.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTagTemplateFieldAsync(TagTemplateFieldName name, bool force, st::CancellationToken cancellationToken) =>
            DeleteTagTemplateFieldAsync(name, force, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a tag and assigns it to:
        /// 
        /// * An [Entry][google.cloud.datacatalog.v1.Entry] if the method name is
        /// `projects.locations.entryGroups.entries.tags.create`.
        /// * Or [EntryGroup][google.cloud.datacatalog.v1.EntryGroup]if the method
        /// name is `projects.locations.entryGroups.tags.create`.
        /// 
        /// Note: The project identified by the `parent` parameter for the [tag]
        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.entries.tags/create#path-parameters)
        /// and the [tag template]
        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.tagTemplates/create#path-parameters)
        /// used to create the tag must be in the same organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tag CreateTag(CreateTagRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a tag and assigns it to:
        /// 
        /// * An [Entry][google.cloud.datacatalog.v1.Entry] if the method name is
        /// `projects.locations.entryGroups.entries.tags.create`.
        /// * Or [EntryGroup][google.cloud.datacatalog.v1.EntryGroup]if the method
        /// name is `projects.locations.entryGroups.tags.create`.
        /// 
        /// Note: The project identified by the `parent` parameter for the [tag]
        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.entries.tags/create#path-parameters)
        /// and the [tag template]
        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.tagTemplates/create#path-parameters)
        /// used to create the tag must be in the same organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tag> CreateTagAsync(CreateTagRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a tag and assigns it to:
        /// 
        /// * An [Entry][google.cloud.datacatalog.v1.Entry] if the method name is
        /// `projects.locations.entryGroups.entries.tags.create`.
        /// * Or [EntryGroup][google.cloud.datacatalog.v1.EntryGroup]if the method
        /// name is `projects.locations.entryGroups.tags.create`.
        /// 
        /// Note: The project identified by the `parent` parameter for the [tag]
        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.entries.tags/create#path-parameters)
        /// and the [tag template]
        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.tagTemplates/create#path-parameters)
        /// used to create the tag must be in the same organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tag> CreateTagAsync(CreateTagRequest request, st::CancellationToken cancellationToken) =>
            CreateTagAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a tag and assigns it to:
        /// 
        /// * An [Entry][google.cloud.datacatalog.v1.Entry] if the method name is
        /// `projects.locations.entryGroups.entries.tags.create`.
        /// * Or [EntryGroup][google.cloud.datacatalog.v1.EntryGroup]if the method
        /// name is `projects.locations.entryGroups.tags.create`.
        /// 
        /// Note: The project identified by the `parent` parameter for the [tag]
        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.entries.tags/create#path-parameters)
        /// and the [tag template]
        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.tagTemplates/create#path-parameters)
        /// used to create the tag must be in the same organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the resource to attach this tag to.
        /// 
        /// Tags can be attached to entries or entry groups. An entry can have up to
        /// 1000 attached tags.
        /// 
        /// Note: The tag and its child resources might not be stored in
        /// the location specified in its name.
        /// </param>
        /// <param name="tag">
        /// Required. The tag to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tag CreateTag(string parent, Tag tag, gaxgrpc::CallSettings callSettings = null) =>
            CreateTag(new CreateTagRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Tag = gax::GaxPreconditions.CheckNotNull(tag, nameof(tag)),
            }, callSettings);

        /// <summary>
        /// Creates a tag and assigns it to:
        /// 
        /// * An [Entry][google.cloud.datacatalog.v1.Entry] if the method name is
        /// `projects.locations.entryGroups.entries.tags.create`.
        /// * Or [EntryGroup][google.cloud.datacatalog.v1.EntryGroup]if the method
        /// name is `projects.locations.entryGroups.tags.create`.
        /// 
        /// Note: The project identified by the `parent` parameter for the [tag]
        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.entries.tags/create#path-parameters)
        /// and the [tag template]
        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.tagTemplates/create#path-parameters)
        /// used to create the tag must be in the same organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the resource to attach this tag to.
        /// 
        /// Tags can be attached to entries or entry groups. An entry can have up to
        /// 1000 attached tags.
        /// 
        /// Note: The tag and its child resources might not be stored in
        /// the location specified in its name.
        /// </param>
        /// <param name="tag">
        /// Required. The tag to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tag> CreateTagAsync(string parent, Tag tag, gaxgrpc::CallSettings callSettings = null) =>
            CreateTagAsync(new CreateTagRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Tag = gax::GaxPreconditions.CheckNotNull(tag, nameof(tag)),
            }, callSettings);

        /// <summary>
        /// Creates a tag and assigns it to:
        /// 
        /// * An [Entry][google.cloud.datacatalog.v1.Entry] if the method name is
        /// `projects.locations.entryGroups.entries.tags.create`.
        /// * Or [EntryGroup][google.cloud.datacatalog.v1.EntryGroup]if the method
        /// name is `projects.locations.entryGroups.tags.create`.
        /// 
        /// Note: The project identified by the `parent` parameter for the [tag]
        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.entries.tags/create#path-parameters)
        /// and the [tag template]
        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.tagTemplates/create#path-parameters)
        /// used to create the tag must be in the same organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the resource to attach this tag to.
        /// 
        /// Tags can be attached to entries or entry groups. An entry can have up to
        /// 1000 attached tags.
        /// 
        /// Note: The tag and its child resources might not be stored in
        /// the location specified in its name.
        /// </param>
        /// <param name="tag">
        /// Required. The tag to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tag> CreateTagAsync(string parent, Tag tag, st::CancellationToken cancellationToken) =>
            CreateTagAsync(parent, tag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a tag and assigns it to:
        /// 
        /// * An [Entry][google.cloud.datacatalog.v1.Entry] if the method name is
        /// `projects.locations.entryGroups.entries.tags.create`.
        /// * Or [EntryGroup][google.cloud.datacatalog.v1.EntryGroup]if the method
        /// name is `projects.locations.entryGroups.tags.create`.
        /// 
        /// Note: The project identified by the `parent` parameter for the [tag]
        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.entries.tags/create#path-parameters)
        /// and the [tag template]
        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.tagTemplates/create#path-parameters)
        /// used to create the tag must be in the same organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the resource to attach this tag to.
        /// 
        /// Tags can be attached to entries or entry groups. An entry can have up to
        /// 1000 attached tags.
        /// 
        /// Note: The tag and its child resources might not be stored in
        /// the location specified in its name.
        /// </param>
        /// <param name="tag">
        /// Required. The tag to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tag CreateTag(EntryName parent, Tag tag, gaxgrpc::CallSettings callSettings = null) =>
            CreateTag(new CreateTagRequest
            {
                ParentAsEntryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Tag = gax::GaxPreconditions.CheckNotNull(tag, nameof(tag)),
            }, callSettings);

        /// <summary>
        /// Creates a tag and assigns it to:
        /// 
        /// * An [Entry][google.cloud.datacatalog.v1.Entry] if the method name is
        /// `projects.locations.entryGroups.entries.tags.create`.
        /// * Or [EntryGroup][google.cloud.datacatalog.v1.EntryGroup]if the method
        /// name is `projects.locations.entryGroups.tags.create`.
        /// 
        /// Note: The project identified by the `parent` parameter for the [tag]
        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.entries.tags/create#path-parameters)
        /// and the [tag template]
        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.tagTemplates/create#path-parameters)
        /// used to create the tag must be in the same organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the resource to attach this tag to.
        /// 
        /// Tags can be attached to entries or entry groups. An entry can have up to
        /// 1000 attached tags.
        /// 
        /// Note: The tag and its child resources might not be stored in
        /// the location specified in its name.
        /// </param>
        /// <param name="tag">
        /// Required. The tag to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tag> CreateTagAsync(EntryName parent, Tag tag, gaxgrpc::CallSettings callSettings = null) =>
            CreateTagAsync(new CreateTagRequest
            {
                ParentAsEntryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Tag = gax::GaxPreconditions.CheckNotNull(tag, nameof(tag)),
            }, callSettings);

        /// <summary>
        /// Creates a tag and assigns it to:
        /// 
        /// * An [Entry][google.cloud.datacatalog.v1.Entry] if the method name is
        /// `projects.locations.entryGroups.entries.tags.create`.
        /// * Or [EntryGroup][google.cloud.datacatalog.v1.EntryGroup]if the method
        /// name is `projects.locations.entryGroups.tags.create`.
        /// 
        /// Note: The project identified by the `parent` parameter for the [tag]
        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.entries.tags/create#path-parameters)
        /// and the [tag template]
        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.tagTemplates/create#path-parameters)
        /// used to create the tag must be in the same organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the resource to attach this tag to.
        /// 
        /// Tags can be attached to entries or entry groups. An entry can have up to
        /// 1000 attached tags.
        /// 
        /// Note: The tag and its child resources might not be stored in
        /// the location specified in its name.
        /// </param>
        /// <param name="tag">
        /// Required. The tag to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tag> CreateTagAsync(EntryName parent, Tag tag, st::CancellationToken cancellationToken) =>
            CreateTagAsync(parent, tag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tag UpdateTag(UpdateTagRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tag> UpdateTagAsync(UpdateTagRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tag> UpdateTagAsync(UpdateTagRequest request, st::CancellationToken cancellationToken) =>
            UpdateTagAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing tag.
        /// </summary>
        /// <param name="tag">
        /// Required. The updated tag. The "name" field must be set.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tag UpdateTag(Tag tag, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTag(new UpdateTagRequest
            {
                Tag = gax::GaxPreconditions.CheckNotNull(tag, nameof(tag)),
            }, callSettings);

        /// <summary>
        /// Updates an existing tag.
        /// </summary>
        /// <param name="tag">
        /// Required. The updated tag. The "name" field must be set.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tag> UpdateTagAsync(Tag tag, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTagAsync(new UpdateTagRequest
            {
                Tag = gax::GaxPreconditions.CheckNotNull(tag, nameof(tag)),
            }, callSettings);

        /// <summary>
        /// Updates an existing tag.
        /// </summary>
        /// <param name="tag">
        /// Required. The updated tag. The "name" field must be set.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tag> UpdateTagAsync(Tag tag, st::CancellationToken cancellationToken) =>
            UpdateTagAsync(tag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing tag.
        /// </summary>
        /// <param name="tag">
        /// Required. The updated tag. The "name" field must be set.
        /// </param>
        /// <param name="updateMask">
        /// Names of fields whose values to overwrite on a tag. Currently, a tag has
        /// the only modifiable field with the name `fields`.
        /// 
        /// In general, if this parameter is absent or empty, all modifiable fields
        /// are overwritten. If such fields are non-required and omitted in the
        /// request body, their values are emptied.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tag UpdateTag(Tag tag, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTag(new UpdateTagRequest
            {
                Tag = gax::GaxPreconditions.CheckNotNull(tag, nameof(tag)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an existing tag.
        /// </summary>
        /// <param name="tag">
        /// Required. The updated tag. The "name" field must be set.
        /// </param>
        /// <param name="updateMask">
        /// Names of fields whose values to overwrite on a tag. Currently, a tag has
        /// the only modifiable field with the name `fields`.
        /// 
        /// In general, if this parameter is absent or empty, all modifiable fields
        /// are overwritten. If such fields are non-required and omitted in the
        /// request body, their values are emptied.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tag> UpdateTagAsync(Tag tag, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTagAsync(new UpdateTagRequest
            {
                Tag = gax::GaxPreconditions.CheckNotNull(tag, nameof(tag)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an existing tag.
        /// </summary>
        /// <param name="tag">
        /// Required. The updated tag. The "name" field must be set.
        /// </param>
        /// <param name="updateMask">
        /// Names of fields whose values to overwrite on a tag. Currently, a tag has
        /// the only modifiable field with the name `fields`.
        /// 
        /// In general, if this parameter is absent or empty, all modifiable fields
        /// are overwritten. If such fields are non-required and omitted in the
        /// request body, their values are emptied.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tag> UpdateTagAsync(Tag tag, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTagAsync(tag, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTag(DeleteTagRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTagAsync(DeleteTagRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTagAsync(DeleteTagRequest request, st::CancellationToken cancellationToken) =>
            DeleteTagAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a tag.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTag(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTag(new DeleteTagRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a tag.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTagAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagAsync(new DeleteTagRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a tag.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTagAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTagAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a tag.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTag(EntryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTag(new DeleteTagRequest
            {
                EntryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a tag.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTagAsync(EntryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagAsync(new DeleteTagRequest
            {
                EntryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a tag.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the tag to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTagAsync(EntryName name, st::CancellationToken cancellationToken) =>
            DeleteTagAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists tags assigned to an [Entry][google.cloud.datacatalog.v1.Entry].
        /// The [columns][google.cloud.datacatalog.v1.Tag.column] in the response are
        /// lowercased.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Tag"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTagsResponse, Tag> ListTags(ListTagsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists tags assigned to an [Entry][google.cloud.datacatalog.v1.Entry].
        /// The [columns][google.cloud.datacatalog.v1.Tag.column] in the response are
        /// lowercased.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Tag"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTagsResponse, Tag> ListTagsAsync(ListTagsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists tags assigned to an [Entry][google.cloud.datacatalog.v1.Entry].
        /// The [columns][google.cloud.datacatalog.v1.Tag.column] in the response are
        /// lowercased.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the Data Catalog resource to list the tags of.
        /// 
        /// The resource can be an [Entry][google.cloud.datacatalog.v1.Entry]
        /// or an [EntryGroup][google.cloud.datacatalog.v1.EntryGroup]
        /// (without `/entries/{entries}` at the end).
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
        /// <returns>A pageable sequence of <see cref="Tag"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTagsResponse, Tag> ListTags(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTagsRequest request = new ListTagsRequest
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
            return ListTags(request, callSettings);
        }

        /// <summary>
        /// Lists tags assigned to an [Entry][google.cloud.datacatalog.v1.Entry].
        /// The [columns][google.cloud.datacatalog.v1.Tag.column] in the response are
        /// lowercased.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the Data Catalog resource to list the tags of.
        /// 
        /// The resource can be an [Entry][google.cloud.datacatalog.v1.Entry]
        /// or an [EntryGroup][google.cloud.datacatalog.v1.EntryGroup]
        /// (without `/entries/{entries}` at the end).
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
        /// <returns>A pageable asynchronous sequence of <see cref="Tag"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTagsResponse, Tag> ListTagsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTagsRequest request = new ListTagsRequest
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
            return ListTagsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists tags assigned to an [Entry][google.cloud.datacatalog.v1.Entry].
        /// The [columns][google.cloud.datacatalog.v1.Tag.column] in the response are
        /// lowercased.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the Data Catalog resource to list the tags of.
        /// 
        /// The resource can be an [Entry][google.cloud.datacatalog.v1.Entry]
        /// or an [EntryGroup][google.cloud.datacatalog.v1.EntryGroup]
        /// (without `/entries/{entries}` at the end).
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
        /// <returns>A pageable sequence of <see cref="Tag"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTagsResponse, Tag> ListTags(EntryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTagsRequest request = new ListTagsRequest
            {
                ParentAsEntryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTags(request, callSettings);
        }

        /// <summary>
        /// Lists tags assigned to an [Entry][google.cloud.datacatalog.v1.Entry].
        /// The [columns][google.cloud.datacatalog.v1.Tag.column] in the response are
        /// lowercased.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the Data Catalog resource to list the tags of.
        /// 
        /// The resource can be an [Entry][google.cloud.datacatalog.v1.Entry]
        /// or an [EntryGroup][google.cloud.datacatalog.v1.EntryGroup]
        /// (without `/entries/{entries}` at the end).
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
        /// <returns>A pageable asynchronous sequence of <see cref="Tag"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTagsResponse, Tag> ListTagsAsync(EntryName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTagsRequest request = new ListTagsRequest
            {
                ParentAsEntryName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTagsAsync(request, callSettings);
        }

        /// <summary>
        /// `ReconcileTags` creates or updates a list of tags on the entry.
        /// If the
        /// [ReconcileTagsRequest.force_delete_missing][google.cloud.datacatalog.v1.ReconcileTagsRequest.force_delete_missing]
        /// parameter is set, the operation deletes tags not included in the input tag
        /// list.
        /// 
        /// `ReconcileTags` returns a [long-running operation]
        /// [google.longrunning.Operation] resource that can be queried with
        /// [Operations.GetOperation][google.longrunning.Operations.GetOperation]
        /// to return [ReconcileTagsMetadata]
        /// [google.cloud.datacatalog.v1.ReconcileTagsMetadata] and
        /// a [ReconcileTagsResponse]
        /// [google.cloud.datacatalog.v1.ReconcileTagsResponse] message.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ReconcileTagsResponse, ReconcileTagsMetadata> ReconcileTags(ReconcileTagsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// `ReconcileTags` creates or updates a list of tags on the entry.
        /// If the
        /// [ReconcileTagsRequest.force_delete_missing][google.cloud.datacatalog.v1.ReconcileTagsRequest.force_delete_missing]
        /// parameter is set, the operation deletes tags not included in the input tag
        /// list.
        /// 
        /// `ReconcileTags` returns a [long-running operation]
        /// [google.longrunning.Operation] resource that can be queried with
        /// [Operations.GetOperation][google.longrunning.Operations.GetOperation]
        /// to return [ReconcileTagsMetadata]
        /// [google.cloud.datacatalog.v1.ReconcileTagsMetadata] and
        /// a [ReconcileTagsResponse]
        /// [google.cloud.datacatalog.v1.ReconcileTagsResponse] message.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReconcileTagsResponse, ReconcileTagsMetadata>> ReconcileTagsAsync(ReconcileTagsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// `ReconcileTags` creates or updates a list of tags on the entry.
        /// If the
        /// [ReconcileTagsRequest.force_delete_missing][google.cloud.datacatalog.v1.ReconcileTagsRequest.force_delete_missing]
        /// parameter is set, the operation deletes tags not included in the input tag
        /// list.
        /// 
        /// `ReconcileTags` returns a [long-running operation]
        /// [google.longrunning.Operation] resource that can be queried with
        /// [Operations.GetOperation][google.longrunning.Operations.GetOperation]
        /// to return [ReconcileTagsMetadata]
        /// [google.cloud.datacatalog.v1.ReconcileTagsMetadata] and
        /// a [ReconcileTagsResponse]
        /// [google.cloud.datacatalog.v1.ReconcileTagsResponse] message.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReconcileTagsResponse, ReconcileTagsMetadata>> ReconcileTagsAsync(ReconcileTagsRequest request, st::CancellationToken cancellationToken) =>
            ReconcileTagsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ReconcileTags</c>.</summary>
        public virtual lro::OperationsClient ReconcileTagsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ReconcileTags</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ReconcileTagsResponse, ReconcileTagsMetadata> PollOnceReconcileTags(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ReconcileTagsResponse, ReconcileTagsMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReconcileTagsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ReconcileTags</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ReconcileTagsResponse, ReconcileTagsMetadata>> PollOnceReconcileTagsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ReconcileTagsResponse, ReconcileTagsMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReconcileTagsOperationsClient, callSettings);

        /// <summary>
        /// Marks an [Entry][google.cloud.datacatalog.v1.Entry] as starred by
        /// the current user. Starring information is private to each user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StarEntryResponse StarEntry(StarEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Marks an [Entry][google.cloud.datacatalog.v1.Entry] as starred by
        /// the current user. Starring information is private to each user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StarEntryResponse> StarEntryAsync(StarEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Marks an [Entry][google.cloud.datacatalog.v1.Entry] as starred by
        /// the current user. Starring information is private to each user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StarEntryResponse> StarEntryAsync(StarEntryRequest request, st::CancellationToken cancellationToken) =>
            StarEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks an [Entry][google.cloud.datacatalog.v1.Entry] as starred by
        /// the current user. Starring information is private to each user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry to mark as starred.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StarEntryResponse StarEntry(string name, gaxgrpc::CallSettings callSettings = null) =>
            StarEntry(new StarEntryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Marks an [Entry][google.cloud.datacatalog.v1.Entry] as starred by
        /// the current user. Starring information is private to each user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry to mark as starred.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StarEntryResponse> StarEntryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            StarEntryAsync(new StarEntryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Marks an [Entry][google.cloud.datacatalog.v1.Entry] as starred by
        /// the current user. Starring information is private to each user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry to mark as starred.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StarEntryResponse> StarEntryAsync(string name, st::CancellationToken cancellationToken) =>
            StarEntryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks an [Entry][google.cloud.datacatalog.v1.Entry] as starred by
        /// the current user. Starring information is private to each user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry to mark as starred.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StarEntryResponse StarEntry(EntryName name, gaxgrpc::CallSettings callSettings = null) =>
            StarEntry(new StarEntryRequest
            {
                EntryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Marks an [Entry][google.cloud.datacatalog.v1.Entry] as starred by
        /// the current user. Starring information is private to each user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry to mark as starred.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StarEntryResponse> StarEntryAsync(EntryName name, gaxgrpc::CallSettings callSettings = null) =>
            StarEntryAsync(new StarEntryRequest
            {
                EntryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Marks an [Entry][google.cloud.datacatalog.v1.Entry] as starred by
        /// the current user. Starring information is private to each user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry to mark as starred.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StarEntryResponse> StarEntryAsync(EntryName name, st::CancellationToken cancellationToken) =>
            StarEntryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks an [Entry][google.cloud.datacatalog.v1.Entry] as NOT starred by
        /// the current user. Starring information is private to each user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UnstarEntryResponse UnstarEntry(UnstarEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Marks an [Entry][google.cloud.datacatalog.v1.Entry] as NOT starred by
        /// the current user. Starring information is private to each user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnstarEntryResponse> UnstarEntryAsync(UnstarEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Marks an [Entry][google.cloud.datacatalog.v1.Entry] as NOT starred by
        /// the current user. Starring information is private to each user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnstarEntryResponse> UnstarEntryAsync(UnstarEntryRequest request, st::CancellationToken cancellationToken) =>
            UnstarEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks an [Entry][google.cloud.datacatalog.v1.Entry] as NOT starred by
        /// the current user. Starring information is private to each user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry to mark as **not** starred.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UnstarEntryResponse UnstarEntry(string name, gaxgrpc::CallSettings callSettings = null) =>
            UnstarEntry(new UnstarEntryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Marks an [Entry][google.cloud.datacatalog.v1.Entry] as NOT starred by
        /// the current user. Starring information is private to each user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry to mark as **not** starred.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnstarEntryResponse> UnstarEntryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            UnstarEntryAsync(new UnstarEntryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Marks an [Entry][google.cloud.datacatalog.v1.Entry] as NOT starred by
        /// the current user. Starring information is private to each user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry to mark as **not** starred.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnstarEntryResponse> UnstarEntryAsync(string name, st::CancellationToken cancellationToken) =>
            UnstarEntryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks an [Entry][google.cloud.datacatalog.v1.Entry] as NOT starred by
        /// the current user. Starring information is private to each user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry to mark as **not** starred.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UnstarEntryResponse UnstarEntry(EntryName name, gaxgrpc::CallSettings callSettings = null) =>
            UnstarEntry(new UnstarEntryRequest
            {
                EntryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Marks an [Entry][google.cloud.datacatalog.v1.Entry] as NOT starred by
        /// the current user. Starring information is private to each user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry to mark as **not** starred.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnstarEntryResponse> UnstarEntryAsync(EntryName name, gaxgrpc::CallSettings callSettings = null) =>
            UnstarEntryAsync(new UnstarEntryRequest
            {
                EntryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Marks an [Entry][google.cloud.datacatalog.v1.Entry] as NOT starred by
        /// the current user. Starring information is private to each user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entry to mark as **not** starred.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnstarEntryResponse> UnstarEntryAsync(EntryName name, st::CancellationToken cancellationToken) =>
            UnstarEntryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets an access control policy for a resource. Replaces any existing
        /// policy.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method sets policies only within Data Catalog and can't be
        /// used to manage policies in BigQuery, Pub/Sub, Dataproc Metastore, and any
        /// external Google Cloud Platform resources synced with the Data Catalog.
        /// 
        /// To call this method, you must have the following Google IAM permissions:
        /// 
        /// - `datacatalog.tagTemplates.setIamPolicy` to set policies on tag
        /// templates.
        /// - `datacatalog.entryGroups.setIamPolicy` to set policies on entry groups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets an access control policy for a resource. Replaces any existing
        /// policy.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method sets policies only within Data Catalog and can't be
        /// used to manage policies in BigQuery, Pub/Sub, Dataproc Metastore, and any
        /// external Google Cloud Platform resources synced with the Data Catalog.
        /// 
        /// To call this method, you must have the following Google IAM permissions:
        /// 
        /// - `datacatalog.tagTemplates.setIamPolicy` to set policies on tag
        /// templates.
        /// - `datacatalog.entryGroups.setIamPolicy` to set policies on entry groups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets an access control policy for a resource. Replaces any existing
        /// policy.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method sets policies only within Data Catalog and can't be
        /// used to manage policies in BigQuery, Pub/Sub, Dataproc Metastore, and any
        /// external Google Cloud Platform resources synced with the Data Catalog.
        /// 
        /// To call this method, you must have the following Google IAM permissions:
        /// 
        /// - `datacatalog.tagTemplates.setIamPolicy` to set policies on tag
        /// templates.
        /// - `datacatalog.entryGroups.setIamPolicy` to set policies on entry groups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets an access control policy for a resource. Replaces any existing
        /// policy.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method sets policies only within Data Catalog and can't be
        /// used to manage policies in BigQuery, Pub/Sub, Dataproc Metastore, and any
        /// external Google Cloud Platform resources synced with the Data Catalog.
        /// 
        /// To call this method, you must have the following Google IAM permissions:
        /// 
        /// - `datacatalog.tagTemplates.setIamPolicy` to set policies on tag
        /// templates.
        /// - `datacatalog.entryGroups.setIamPolicy` to set policies on entry groups.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets an access control policy for a resource. Replaces any existing
        /// policy.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method sets policies only within Data Catalog and can't be
        /// used to manage policies in BigQuery, Pub/Sub, Dataproc Metastore, and any
        /// external Google Cloud Platform resources synced with the Data Catalog.
        /// 
        /// To call this method, you must have the following Google IAM permissions:
        /// 
        /// - `datacatalog.tagTemplates.setIamPolicy` to set policies on tag
        /// templates.
        /// - `datacatalog.entryGroups.setIamPolicy` to set policies on entry groups.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets an access control policy for a resource. Replaces any existing
        /// policy.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method sets policies only within Data Catalog and can't be
        /// used to manage policies in BigQuery, Pub/Sub, Dataproc Metastore, and any
        /// external Google Cloud Platform resources synced with the Data Catalog.
        /// 
        /// To call this method, you must have the following Google IAM permissions:
        /// 
        /// - `datacatalog.tagTemplates.setIamPolicy` to set policies on tag
        /// templates.
        /// - `datacatalog.entryGroups.setIamPolicy` to set policies on entry groups.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets an access control policy for a resource. Replaces any existing
        /// policy.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method sets policies only within Data Catalog and can't be
        /// used to manage policies in BigQuery, Pub/Sub, Dataproc Metastore, and any
        /// external Google Cloud Platform resources synced with the Data Catalog.
        /// 
        /// To call this method, you must have the following Google IAM permissions:
        /// 
        /// - `datacatalog.tagTemplates.setIamPolicy` to set policies on tag
        /// templates.
        /// - `datacatalog.entryGroups.setIamPolicy` to set policies on entry groups.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets an access control policy for a resource. Replaces any existing
        /// policy.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method sets policies only within Data Catalog and can't be
        /// used to manage policies in BigQuery, Pub/Sub, Dataproc Metastore, and any
        /// external Google Cloud Platform resources synced with the Data Catalog.
        /// 
        /// To call this method, you must have the following Google IAM permissions:
        /// 
        /// - `datacatalog.tagTemplates.setIamPolicy` to set policies on tag
        /// templates.
        /// - `datacatalog.entryGroups.setIamPolicy` to set policies on entry groups.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets an access control policy for a resource. Replaces any existing
        /// policy.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method sets policies only within Data Catalog and can't be
        /// used to manage policies in BigQuery, Pub/Sub, Dataproc Metastore, and any
        /// external Google Cloud Platform resources synced with the Data Catalog.
        /// 
        /// To call this method, you must have the following Google IAM permissions:
        /// 
        /// - `datacatalog.tagTemplates.setIamPolicy` to set policies on tag
        /// templates.
        /// - `datacatalog.entryGroups.setIamPolicy` to set policies on entry groups.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a resource.
        /// 
        /// May return:
        /// 
        /// * A`NOT_FOUND` error if the resource doesn't exist or you don't have the
        /// permission to view it.
        /// * An empty policy if the resource exists but doesn't have a set policy.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method doesn't get policies from Google Cloud Platform
        /// resources ingested into Data Catalog.
        /// 
        /// To call this method, you must have the following Google IAM permissions:
        /// 
        /// - `datacatalog.tagTemplates.getIamPolicy` to get policies on tag
        /// templates.
        /// - `datacatalog.entryGroups.getIamPolicy` to get policies on entry groups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a resource.
        /// 
        /// May return:
        /// 
        /// * A`NOT_FOUND` error if the resource doesn't exist or you don't have the
        /// permission to view it.
        /// * An empty policy if the resource exists but doesn't have a set policy.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method doesn't get policies from Google Cloud Platform
        /// resources ingested into Data Catalog.
        /// 
        /// To call this method, you must have the following Google IAM permissions:
        /// 
        /// - `datacatalog.tagTemplates.getIamPolicy` to get policies on tag
        /// templates.
        /// - `datacatalog.entryGroups.getIamPolicy` to get policies on entry groups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a resource.
        /// 
        /// May return:
        /// 
        /// * A`NOT_FOUND` error if the resource doesn't exist or you don't have the
        /// permission to view it.
        /// * An empty policy if the resource exists but doesn't have a set policy.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method doesn't get policies from Google Cloud Platform
        /// resources ingested into Data Catalog.
        /// 
        /// To call this method, you must have the following Google IAM permissions:
        /// 
        /// - `datacatalog.tagTemplates.getIamPolicy` to get policies on tag
        /// templates.
        /// - `datacatalog.entryGroups.getIamPolicy` to get policies on entry groups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a resource.
        /// 
        /// May return:
        /// 
        /// * A`NOT_FOUND` error if the resource doesn't exist or you don't have the
        /// permission to view it.
        /// * An empty policy if the resource exists but doesn't have a set policy.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method doesn't get policies from Google Cloud Platform
        /// resources ingested into Data Catalog.
        /// 
        /// To call this method, you must have the following Google IAM permissions:
        /// 
        /// - `datacatalog.tagTemplates.getIamPolicy` to get policies on tag
        /// templates.
        /// - `datacatalog.entryGroups.getIamPolicy` to get policies on entry groups.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a resource.
        /// 
        /// May return:
        /// 
        /// * A`NOT_FOUND` error if the resource doesn't exist or you don't have the
        /// permission to view it.
        /// * An empty policy if the resource exists but doesn't have a set policy.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method doesn't get policies from Google Cloud Platform
        /// resources ingested into Data Catalog.
        /// 
        /// To call this method, you must have the following Google IAM permissions:
        /// 
        /// - `datacatalog.tagTemplates.getIamPolicy` to get policies on tag
        /// templates.
        /// - `datacatalog.entryGroups.getIamPolicy` to get policies on entry groups.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a resource.
        /// 
        /// May return:
        /// 
        /// * A`NOT_FOUND` error if the resource doesn't exist or you don't have the
        /// permission to view it.
        /// * An empty policy if the resource exists but doesn't have a set policy.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method doesn't get policies from Google Cloud Platform
        /// resources ingested into Data Catalog.
        /// 
        /// To call this method, you must have the following Google IAM permissions:
        /// 
        /// - `datacatalog.tagTemplates.getIamPolicy` to get policies on tag
        /// templates.
        /// - `datacatalog.entryGroups.getIamPolicy` to get policies on entry groups.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a resource.
        /// 
        /// May return:
        /// 
        /// * A`NOT_FOUND` error if the resource doesn't exist or you don't have the
        /// permission to view it.
        /// * An empty policy if the resource exists but doesn't have a set policy.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method doesn't get policies from Google Cloud Platform
        /// resources ingested into Data Catalog.
        /// 
        /// To call this method, you must have the following Google IAM permissions:
        /// 
        /// - `datacatalog.tagTemplates.getIamPolicy` to get policies on tag
        /// templates.
        /// - `datacatalog.entryGroups.getIamPolicy` to get policies on entry groups.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a resource.
        /// 
        /// May return:
        /// 
        /// * A`NOT_FOUND` error if the resource doesn't exist or you don't have the
        /// permission to view it.
        /// * An empty policy if the resource exists but doesn't have a set policy.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method doesn't get policies from Google Cloud Platform
        /// resources ingested into Data Catalog.
        /// 
        /// To call this method, you must have the following Google IAM permissions:
        /// 
        /// - `datacatalog.tagTemplates.getIamPolicy` to get policies on tag
        /// templates.
        /// - `datacatalog.entryGroups.getIamPolicy` to get policies on entry groups.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a resource.
        /// 
        /// May return:
        /// 
        /// * A`NOT_FOUND` error if the resource doesn't exist or you don't have the
        /// permission to view it.
        /// * An empty policy if the resource exists but doesn't have a set policy.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method doesn't get policies from Google Cloud Platform
        /// resources ingested into Data Catalog.
        /// 
        /// To call this method, you must have the following Google IAM permissions:
        /// 
        /// - `datacatalog.tagTemplates.getIamPolicy` to get policies on tag
        /// templates.
        /// - `datacatalog.entryGroups.getIamPolicy` to get policies on entry groups.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets your permissions on a resource.
        /// 
        /// Returns an empty set of permissions if the resource doesn't exist.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method gets policies only within Data Catalog and can't be
        /// used to get policies from BigQuery, Pub/Sub, Dataproc Metastore, and any
        /// external Google Cloud Platform resources ingested into Data Catalog.
        /// 
        /// No Google IAM permissions are required to call this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets your permissions on a resource.
        /// 
        /// Returns an empty set of permissions if the resource doesn't exist.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method gets policies only within Data Catalog and can't be
        /// used to get policies from BigQuery, Pub/Sub, Dataproc Metastore, and any
        /// external Google Cloud Platform resources ingested into Data Catalog.
        /// 
        /// No Google IAM permissions are required to call this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets your permissions on a resource.
        /// 
        /// Returns an empty set of permissions if the resource doesn't exist.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method gets policies only within Data Catalog and can't be
        /// used to get policies from BigQuery, Pub/Sub, Dataproc Metastore, and any
        /// external Google Cloud Platform resources ingested into Data Catalog.
        /// 
        /// No Google IAM permissions are required to call this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports entries from a source, such as data previously dumped into a
        /// Cloud Storage bucket, into Data Catalog. Import of entries
        /// is a sync operation that reconciles the state of the third-party system
        /// with the Data Catalog.
        /// 
        /// `ImportEntries` accepts source data snapshots of a third-party system.
        /// Snapshot should be delivered as a .wire or base65-encoded .txt file
        /// containing a sequence of Protocol Buffer messages of
        /// [DumpItem][google.cloud.datacatalog.v1.DumpItem] type.
        /// 
        /// `ImportEntries` returns a [long-running operation]
        /// [google.longrunning.Operation] resource that can be queried with
        /// [Operations.GetOperation][google.longrunning.Operations.GetOperation]
        /// to return
        /// [ImportEntriesMetadata][google.cloud.datacatalog.v1.ImportEntriesMetadata]
        /// and an
        /// [ImportEntriesResponse][google.cloud.datacatalog.v1.ImportEntriesResponse]
        /// message.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportEntriesResponse, ImportEntriesMetadata> ImportEntries(ImportEntriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports entries from a source, such as data previously dumped into a
        /// Cloud Storage bucket, into Data Catalog. Import of entries
        /// is a sync operation that reconciles the state of the third-party system
        /// with the Data Catalog.
        /// 
        /// `ImportEntries` accepts source data snapshots of a third-party system.
        /// Snapshot should be delivered as a .wire or base65-encoded .txt file
        /// containing a sequence of Protocol Buffer messages of
        /// [DumpItem][google.cloud.datacatalog.v1.DumpItem] type.
        /// 
        /// `ImportEntries` returns a [long-running operation]
        /// [google.longrunning.Operation] resource that can be queried with
        /// [Operations.GetOperation][google.longrunning.Operations.GetOperation]
        /// to return
        /// [ImportEntriesMetadata][google.cloud.datacatalog.v1.ImportEntriesMetadata]
        /// and an
        /// [ImportEntriesResponse][google.cloud.datacatalog.v1.ImportEntriesResponse]
        /// message.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportEntriesResponse, ImportEntriesMetadata>> ImportEntriesAsync(ImportEntriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports entries from a source, such as data previously dumped into a
        /// Cloud Storage bucket, into Data Catalog. Import of entries
        /// is a sync operation that reconciles the state of the third-party system
        /// with the Data Catalog.
        /// 
        /// `ImportEntries` accepts source data snapshots of a third-party system.
        /// Snapshot should be delivered as a .wire or base65-encoded .txt file
        /// containing a sequence of Protocol Buffer messages of
        /// [DumpItem][google.cloud.datacatalog.v1.DumpItem] type.
        /// 
        /// `ImportEntries` returns a [long-running operation]
        /// [google.longrunning.Operation] resource that can be queried with
        /// [Operations.GetOperation][google.longrunning.Operations.GetOperation]
        /// to return
        /// [ImportEntriesMetadata][google.cloud.datacatalog.v1.ImportEntriesMetadata]
        /// and an
        /// [ImportEntriesResponse][google.cloud.datacatalog.v1.ImportEntriesResponse]
        /// message.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportEntriesResponse, ImportEntriesMetadata>> ImportEntriesAsync(ImportEntriesRequest request, st::CancellationToken cancellationToken) =>
            ImportEntriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportEntries</c>.</summary>
        public virtual lro::OperationsClient ImportEntriesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportEntries</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportEntriesResponse, ImportEntriesMetadata> PollOnceImportEntries(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportEntriesResponse, ImportEntriesMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportEntriesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportEntries</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportEntriesResponse, ImportEntriesMetadata>> PollOnceImportEntriesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportEntriesResponse, ImportEntriesMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportEntriesOperationsClient, callSettings);
    }

    /// <summary>DataCatalog client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Data Catalog API service allows you to discover, understand, and manage
    /// your data.
    /// </remarks>
    public sealed partial class DataCatalogClientImpl : DataCatalogClient
    {
        private readonly gaxgrpc::ApiCall<SearchCatalogRequest, SearchCatalogResponse> _callSearchCatalog;

        private readonly gaxgrpc::ApiCall<CreateEntryGroupRequest, EntryGroup> _callCreateEntryGroup;

        private readonly gaxgrpc::ApiCall<GetEntryGroupRequest, EntryGroup> _callGetEntryGroup;

        private readonly gaxgrpc::ApiCall<UpdateEntryGroupRequest, EntryGroup> _callUpdateEntryGroup;

        private readonly gaxgrpc::ApiCall<DeleteEntryGroupRequest, wkt::Empty> _callDeleteEntryGroup;

        private readonly gaxgrpc::ApiCall<ListEntryGroupsRequest, ListEntryGroupsResponse> _callListEntryGroups;

        private readonly gaxgrpc::ApiCall<CreateEntryRequest, Entry> _callCreateEntry;

        private readonly gaxgrpc::ApiCall<UpdateEntryRequest, Entry> _callUpdateEntry;

        private readonly gaxgrpc::ApiCall<DeleteEntryRequest, wkt::Empty> _callDeleteEntry;

        private readonly gaxgrpc::ApiCall<GetEntryRequest, Entry> _callGetEntry;

        private readonly gaxgrpc::ApiCall<LookupEntryRequest, Entry> _callLookupEntry;

        private readonly gaxgrpc::ApiCall<ListEntriesRequest, ListEntriesResponse> _callListEntries;

        private readonly gaxgrpc::ApiCall<ModifyEntryOverviewRequest, EntryOverview> _callModifyEntryOverview;

        private readonly gaxgrpc::ApiCall<ModifyEntryContactsRequest, Contacts> _callModifyEntryContacts;

        private readonly gaxgrpc::ApiCall<CreateTagTemplateRequest, TagTemplate> _callCreateTagTemplate;

        private readonly gaxgrpc::ApiCall<GetTagTemplateRequest, TagTemplate> _callGetTagTemplate;

        private readonly gaxgrpc::ApiCall<UpdateTagTemplateRequest, TagTemplate> _callUpdateTagTemplate;

        private readonly gaxgrpc::ApiCall<DeleteTagTemplateRequest, wkt::Empty> _callDeleteTagTemplate;

        private readonly gaxgrpc::ApiCall<CreateTagTemplateFieldRequest, TagTemplateField> _callCreateTagTemplateField;

        private readonly gaxgrpc::ApiCall<UpdateTagTemplateFieldRequest, TagTemplateField> _callUpdateTagTemplateField;

        private readonly gaxgrpc::ApiCall<RenameTagTemplateFieldRequest, TagTemplateField> _callRenameTagTemplateField;

        private readonly gaxgrpc::ApiCall<RenameTagTemplateFieldEnumValueRequest, TagTemplateField> _callRenameTagTemplateFieldEnumValue;

        private readonly gaxgrpc::ApiCall<DeleteTagTemplateFieldRequest, wkt::Empty> _callDeleteTagTemplateField;

        private readonly gaxgrpc::ApiCall<CreateTagRequest, Tag> _callCreateTag;

        private readonly gaxgrpc::ApiCall<UpdateTagRequest, Tag> _callUpdateTag;

        private readonly gaxgrpc::ApiCall<DeleteTagRequest, wkt::Empty> _callDeleteTag;

        private readonly gaxgrpc::ApiCall<ListTagsRequest, ListTagsResponse> _callListTags;

        private readonly gaxgrpc::ApiCall<ReconcileTagsRequest, lro::Operation> _callReconcileTags;

        private readonly gaxgrpc::ApiCall<StarEntryRequest, StarEntryResponse> _callStarEntry;

        private readonly gaxgrpc::ApiCall<UnstarEntryRequest, UnstarEntryResponse> _callUnstarEntry;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        private readonly gaxgrpc::ApiCall<ImportEntriesRequest, lro::Operation> _callImportEntries;

        /// <summary>
        /// Constructs a client wrapper for the DataCatalog service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataCatalogSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataCatalogClientImpl(DataCatalog.DataCatalogClient grpcClient, DataCatalogSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataCatalogSettings effectiveSettings = settings ?? DataCatalogSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            ReconcileTagsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ReconcileTagsOperationsSettings, logger);
            ImportEntriesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportEntriesOperationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callSearchCatalog = clientHelper.BuildApiCall<SearchCatalogRequest, SearchCatalogResponse>("SearchCatalog", grpcClient.SearchCatalogAsync, grpcClient.SearchCatalog, effectiveSettings.SearchCatalogSettings);
            Modify_ApiCall(ref _callSearchCatalog);
            Modify_SearchCatalogApiCall(ref _callSearchCatalog);
            _callCreateEntryGroup = clientHelper.BuildApiCall<CreateEntryGroupRequest, EntryGroup>("CreateEntryGroup", grpcClient.CreateEntryGroupAsync, grpcClient.CreateEntryGroup, effectiveSettings.CreateEntryGroupSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEntryGroup);
            Modify_CreateEntryGroupApiCall(ref _callCreateEntryGroup);
            _callGetEntryGroup = clientHelper.BuildApiCall<GetEntryGroupRequest, EntryGroup>("GetEntryGroup", grpcClient.GetEntryGroupAsync, grpcClient.GetEntryGroup, effectiveSettings.GetEntryGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEntryGroup);
            Modify_GetEntryGroupApiCall(ref _callGetEntryGroup);
            _callUpdateEntryGroup = clientHelper.BuildApiCall<UpdateEntryGroupRequest, EntryGroup>("UpdateEntryGroup", grpcClient.UpdateEntryGroupAsync, grpcClient.UpdateEntryGroup, effectiveSettings.UpdateEntryGroupSettings).WithGoogleRequestParam("entry_group.name", request => request.EntryGroup?.Name);
            Modify_ApiCall(ref _callUpdateEntryGroup);
            Modify_UpdateEntryGroupApiCall(ref _callUpdateEntryGroup);
            _callDeleteEntryGroup = clientHelper.BuildApiCall<DeleteEntryGroupRequest, wkt::Empty>("DeleteEntryGroup", grpcClient.DeleteEntryGroupAsync, grpcClient.DeleteEntryGroup, effectiveSettings.DeleteEntryGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEntryGroup);
            Modify_DeleteEntryGroupApiCall(ref _callDeleteEntryGroup);
            _callListEntryGroups = clientHelper.BuildApiCall<ListEntryGroupsRequest, ListEntryGroupsResponse>("ListEntryGroups", grpcClient.ListEntryGroupsAsync, grpcClient.ListEntryGroups, effectiveSettings.ListEntryGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEntryGroups);
            Modify_ListEntryGroupsApiCall(ref _callListEntryGroups);
            _callCreateEntry = clientHelper.BuildApiCall<CreateEntryRequest, Entry>("CreateEntry", grpcClient.CreateEntryAsync, grpcClient.CreateEntry, effectiveSettings.CreateEntrySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEntry);
            Modify_CreateEntryApiCall(ref _callCreateEntry);
            _callUpdateEntry = clientHelper.BuildApiCall<UpdateEntryRequest, Entry>("UpdateEntry", grpcClient.UpdateEntryAsync, grpcClient.UpdateEntry, effectiveSettings.UpdateEntrySettings).WithGoogleRequestParam("entry.name", request => request.Entry?.Name);
            Modify_ApiCall(ref _callUpdateEntry);
            Modify_UpdateEntryApiCall(ref _callUpdateEntry);
            _callDeleteEntry = clientHelper.BuildApiCall<DeleteEntryRequest, wkt::Empty>("DeleteEntry", grpcClient.DeleteEntryAsync, grpcClient.DeleteEntry, effectiveSettings.DeleteEntrySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEntry);
            Modify_DeleteEntryApiCall(ref _callDeleteEntry);
            _callGetEntry = clientHelper.BuildApiCall<GetEntryRequest, Entry>("GetEntry", grpcClient.GetEntryAsync, grpcClient.GetEntry, effectiveSettings.GetEntrySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEntry);
            Modify_GetEntryApiCall(ref _callGetEntry);
            _callLookupEntry = clientHelper.BuildApiCall<LookupEntryRequest, Entry>("LookupEntry", grpcClient.LookupEntryAsync, grpcClient.LookupEntry, effectiveSettings.LookupEntrySettings);
            Modify_ApiCall(ref _callLookupEntry);
            Modify_LookupEntryApiCall(ref _callLookupEntry);
            _callListEntries = clientHelper.BuildApiCall<ListEntriesRequest, ListEntriesResponse>("ListEntries", grpcClient.ListEntriesAsync, grpcClient.ListEntries, effectiveSettings.ListEntriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEntries);
            Modify_ListEntriesApiCall(ref _callListEntries);
            _callModifyEntryOverview = clientHelper.BuildApiCall<ModifyEntryOverviewRequest, EntryOverview>("ModifyEntryOverview", grpcClient.ModifyEntryOverviewAsync, grpcClient.ModifyEntryOverview, effectiveSettings.ModifyEntryOverviewSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callModifyEntryOverview);
            Modify_ModifyEntryOverviewApiCall(ref _callModifyEntryOverview);
            _callModifyEntryContacts = clientHelper.BuildApiCall<ModifyEntryContactsRequest, Contacts>("ModifyEntryContacts", grpcClient.ModifyEntryContactsAsync, grpcClient.ModifyEntryContacts, effectiveSettings.ModifyEntryContactsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callModifyEntryContacts);
            Modify_ModifyEntryContactsApiCall(ref _callModifyEntryContacts);
            _callCreateTagTemplate = clientHelper.BuildApiCall<CreateTagTemplateRequest, TagTemplate>("CreateTagTemplate", grpcClient.CreateTagTemplateAsync, grpcClient.CreateTagTemplate, effectiveSettings.CreateTagTemplateSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTagTemplate);
            Modify_CreateTagTemplateApiCall(ref _callCreateTagTemplate);
            _callGetTagTemplate = clientHelper.BuildApiCall<GetTagTemplateRequest, TagTemplate>("GetTagTemplate", grpcClient.GetTagTemplateAsync, grpcClient.GetTagTemplate, effectiveSettings.GetTagTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTagTemplate);
            Modify_GetTagTemplateApiCall(ref _callGetTagTemplate);
            _callUpdateTagTemplate = clientHelper.BuildApiCall<UpdateTagTemplateRequest, TagTemplate>("UpdateTagTemplate", grpcClient.UpdateTagTemplateAsync, grpcClient.UpdateTagTemplate, effectiveSettings.UpdateTagTemplateSettings).WithGoogleRequestParam("tag_template.name", request => request.TagTemplate?.Name);
            Modify_ApiCall(ref _callUpdateTagTemplate);
            Modify_UpdateTagTemplateApiCall(ref _callUpdateTagTemplate);
            _callDeleteTagTemplate = clientHelper.BuildApiCall<DeleteTagTemplateRequest, wkt::Empty>("DeleteTagTemplate", grpcClient.DeleteTagTemplateAsync, grpcClient.DeleteTagTemplate, effectiveSettings.DeleteTagTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTagTemplate);
            Modify_DeleteTagTemplateApiCall(ref _callDeleteTagTemplate);
            _callCreateTagTemplateField = clientHelper.BuildApiCall<CreateTagTemplateFieldRequest, TagTemplateField>("CreateTagTemplateField", grpcClient.CreateTagTemplateFieldAsync, grpcClient.CreateTagTemplateField, effectiveSettings.CreateTagTemplateFieldSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTagTemplateField);
            Modify_CreateTagTemplateFieldApiCall(ref _callCreateTagTemplateField);
            _callUpdateTagTemplateField = clientHelper.BuildApiCall<UpdateTagTemplateFieldRequest, TagTemplateField>("UpdateTagTemplateField", grpcClient.UpdateTagTemplateFieldAsync, grpcClient.UpdateTagTemplateField, effectiveSettings.UpdateTagTemplateFieldSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateTagTemplateField);
            Modify_UpdateTagTemplateFieldApiCall(ref _callUpdateTagTemplateField);
            _callRenameTagTemplateField = clientHelper.BuildApiCall<RenameTagTemplateFieldRequest, TagTemplateField>("RenameTagTemplateField", grpcClient.RenameTagTemplateFieldAsync, grpcClient.RenameTagTemplateField, effectiveSettings.RenameTagTemplateFieldSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRenameTagTemplateField);
            Modify_RenameTagTemplateFieldApiCall(ref _callRenameTagTemplateField);
            _callRenameTagTemplateFieldEnumValue = clientHelper.BuildApiCall<RenameTagTemplateFieldEnumValueRequest, TagTemplateField>("RenameTagTemplateFieldEnumValue", grpcClient.RenameTagTemplateFieldEnumValueAsync, grpcClient.RenameTagTemplateFieldEnumValue, effectiveSettings.RenameTagTemplateFieldEnumValueSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRenameTagTemplateFieldEnumValue);
            Modify_RenameTagTemplateFieldEnumValueApiCall(ref _callRenameTagTemplateFieldEnumValue);
            _callDeleteTagTemplateField = clientHelper.BuildApiCall<DeleteTagTemplateFieldRequest, wkt::Empty>("DeleteTagTemplateField", grpcClient.DeleteTagTemplateFieldAsync, grpcClient.DeleteTagTemplateField, effectiveSettings.DeleteTagTemplateFieldSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTagTemplateField);
            Modify_DeleteTagTemplateFieldApiCall(ref _callDeleteTagTemplateField);
            _callCreateTag = clientHelper.BuildApiCall<CreateTagRequest, Tag>("CreateTag", grpcClient.CreateTagAsync, grpcClient.CreateTag, effectiveSettings.CreateTagSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTag);
            Modify_CreateTagApiCall(ref _callCreateTag);
            _callUpdateTag = clientHelper.BuildApiCall<UpdateTagRequest, Tag>("UpdateTag", grpcClient.UpdateTagAsync, grpcClient.UpdateTag, effectiveSettings.UpdateTagSettings).WithGoogleRequestParam("tag.name", request => request.Tag?.Name);
            Modify_ApiCall(ref _callUpdateTag);
            Modify_UpdateTagApiCall(ref _callUpdateTag);
            _callDeleteTag = clientHelper.BuildApiCall<DeleteTagRequest, wkt::Empty>("DeleteTag", grpcClient.DeleteTagAsync, grpcClient.DeleteTag, effectiveSettings.DeleteTagSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTag);
            Modify_DeleteTagApiCall(ref _callDeleteTag);
            _callListTags = clientHelper.BuildApiCall<ListTagsRequest, ListTagsResponse>("ListTags", grpcClient.ListTagsAsync, grpcClient.ListTags, effectiveSettings.ListTagsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTags);
            Modify_ListTagsApiCall(ref _callListTags);
            _callReconcileTags = clientHelper.BuildApiCall<ReconcileTagsRequest, lro::Operation>("ReconcileTags", grpcClient.ReconcileTagsAsync, grpcClient.ReconcileTags, effectiveSettings.ReconcileTagsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callReconcileTags);
            Modify_ReconcileTagsApiCall(ref _callReconcileTags);
            _callStarEntry = clientHelper.BuildApiCall<StarEntryRequest, StarEntryResponse>("StarEntry", grpcClient.StarEntryAsync, grpcClient.StarEntry, effectiveSettings.StarEntrySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStarEntry);
            Modify_StarEntryApiCall(ref _callStarEntry);
            _callUnstarEntry = clientHelper.BuildApiCall<UnstarEntryRequest, UnstarEntryResponse>("UnstarEntry", grpcClient.UnstarEntryAsync, grpcClient.UnstarEntry, effectiveSettings.UnstarEntrySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUnstarEntry);
            Modify_UnstarEntryApiCall(ref _callUnstarEntry);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            _callImportEntries = clientHelper.BuildApiCall<ImportEntriesRequest, lro::Operation>("ImportEntries", grpcClient.ImportEntriesAsync, grpcClient.ImportEntries, effectiveSettings.ImportEntriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportEntries);
            Modify_ImportEntriesApiCall(ref _callImportEntries);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SearchCatalogApiCall(ref gaxgrpc::ApiCall<SearchCatalogRequest, SearchCatalogResponse> call);

        partial void Modify_CreateEntryGroupApiCall(ref gaxgrpc::ApiCall<CreateEntryGroupRequest, EntryGroup> call);

        partial void Modify_GetEntryGroupApiCall(ref gaxgrpc::ApiCall<GetEntryGroupRequest, EntryGroup> call);

        partial void Modify_UpdateEntryGroupApiCall(ref gaxgrpc::ApiCall<UpdateEntryGroupRequest, EntryGroup> call);

        partial void Modify_DeleteEntryGroupApiCall(ref gaxgrpc::ApiCall<DeleteEntryGroupRequest, wkt::Empty> call);

        partial void Modify_ListEntryGroupsApiCall(ref gaxgrpc::ApiCall<ListEntryGroupsRequest, ListEntryGroupsResponse> call);

        partial void Modify_CreateEntryApiCall(ref gaxgrpc::ApiCall<CreateEntryRequest, Entry> call);

        partial void Modify_UpdateEntryApiCall(ref gaxgrpc::ApiCall<UpdateEntryRequest, Entry> call);

        partial void Modify_DeleteEntryApiCall(ref gaxgrpc::ApiCall<DeleteEntryRequest, wkt::Empty> call);

        partial void Modify_GetEntryApiCall(ref gaxgrpc::ApiCall<GetEntryRequest, Entry> call);

        partial void Modify_LookupEntryApiCall(ref gaxgrpc::ApiCall<LookupEntryRequest, Entry> call);

        partial void Modify_ListEntriesApiCall(ref gaxgrpc::ApiCall<ListEntriesRequest, ListEntriesResponse> call);

        partial void Modify_ModifyEntryOverviewApiCall(ref gaxgrpc::ApiCall<ModifyEntryOverviewRequest, EntryOverview> call);

        partial void Modify_ModifyEntryContactsApiCall(ref gaxgrpc::ApiCall<ModifyEntryContactsRequest, Contacts> call);

        partial void Modify_CreateTagTemplateApiCall(ref gaxgrpc::ApiCall<CreateTagTemplateRequest, TagTemplate> call);

        partial void Modify_GetTagTemplateApiCall(ref gaxgrpc::ApiCall<GetTagTemplateRequest, TagTemplate> call);

        partial void Modify_UpdateTagTemplateApiCall(ref gaxgrpc::ApiCall<UpdateTagTemplateRequest, TagTemplate> call);

        partial void Modify_DeleteTagTemplateApiCall(ref gaxgrpc::ApiCall<DeleteTagTemplateRequest, wkt::Empty> call);

        partial void Modify_CreateTagTemplateFieldApiCall(ref gaxgrpc::ApiCall<CreateTagTemplateFieldRequest, TagTemplateField> call);

        partial void Modify_UpdateTagTemplateFieldApiCall(ref gaxgrpc::ApiCall<UpdateTagTemplateFieldRequest, TagTemplateField> call);

        partial void Modify_RenameTagTemplateFieldApiCall(ref gaxgrpc::ApiCall<RenameTagTemplateFieldRequest, TagTemplateField> call);

        partial void Modify_RenameTagTemplateFieldEnumValueApiCall(ref gaxgrpc::ApiCall<RenameTagTemplateFieldEnumValueRequest, TagTemplateField> call);

        partial void Modify_DeleteTagTemplateFieldApiCall(ref gaxgrpc::ApiCall<DeleteTagTemplateFieldRequest, wkt::Empty> call);

        partial void Modify_CreateTagApiCall(ref gaxgrpc::ApiCall<CreateTagRequest, Tag> call);

        partial void Modify_UpdateTagApiCall(ref gaxgrpc::ApiCall<UpdateTagRequest, Tag> call);

        partial void Modify_DeleteTagApiCall(ref gaxgrpc::ApiCall<DeleteTagRequest, wkt::Empty> call);

        partial void Modify_ListTagsApiCall(ref gaxgrpc::ApiCall<ListTagsRequest, ListTagsResponse> call);

        partial void Modify_ReconcileTagsApiCall(ref gaxgrpc::ApiCall<ReconcileTagsRequest, lro::Operation> call);

        partial void Modify_StarEntryApiCall(ref gaxgrpc::ApiCall<StarEntryRequest, StarEntryResponse> call);

        partial void Modify_UnstarEntryApiCall(ref gaxgrpc::ApiCall<UnstarEntryRequest, UnstarEntryResponse> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void Modify_ImportEntriesApiCall(ref gaxgrpc::ApiCall<ImportEntriesRequest, lro::Operation> call);

        partial void OnConstruction(DataCatalog.DataCatalogClient grpcClient, DataCatalogSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataCatalog client</summary>
        public override DataCatalog.DataCatalogClient GrpcClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_SearchCatalogRequest(ref SearchCatalogRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEntryGroupRequest(ref CreateEntryGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEntryGroupRequest(ref GetEntryGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEntryGroupRequest(ref UpdateEntryGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEntryGroupRequest(ref DeleteEntryGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEntryGroupsRequest(ref ListEntryGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEntryRequest(ref CreateEntryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEntryRequest(ref UpdateEntryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEntryRequest(ref DeleteEntryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEntryRequest(ref GetEntryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LookupEntryRequest(ref LookupEntryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEntriesRequest(ref ListEntriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ModifyEntryOverviewRequest(ref ModifyEntryOverviewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ModifyEntryContactsRequest(ref ModifyEntryContactsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTagTemplateRequest(ref CreateTagTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTagTemplateRequest(ref GetTagTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTagTemplateRequest(ref UpdateTagTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTagTemplateRequest(ref DeleteTagTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTagTemplateFieldRequest(ref CreateTagTemplateFieldRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTagTemplateFieldRequest(ref UpdateTagTemplateFieldRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RenameTagTemplateFieldRequest(ref RenameTagTemplateFieldRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RenameTagTemplateFieldEnumValueRequest(ref RenameTagTemplateFieldEnumValueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTagTemplateFieldRequest(ref DeleteTagTemplateFieldRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTagRequest(ref CreateTagRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTagRequest(ref UpdateTagRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTagRequest(ref DeleteTagRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTagsRequest(ref ListTagsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReconcileTagsRequest(ref ReconcileTagsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StarEntryRequest(ref StarEntryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UnstarEntryRequest(ref UnstarEntryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportEntriesRequest(ref ImportEntriesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Searches Data Catalog for multiple resources like entries and tags that
        /// match a query.
        /// 
        /// This is a [Custom Method]
        /// (https://cloud.google.com/apis/design/custom_methods) that doesn't return
        /// all information on a resource, only its ID and high level fields. To get
        /// more information, you can subsequently call specific get methods.
        /// 
        /// Note: Data Catalog search queries don't guarantee full recall. Results
        /// that match your query might not be returned, even in subsequent
        /// result pages. Additionally, returned (and not returned) results can vary
        /// if you repeat search queries.
        /// 
        /// For more information, see [Data Catalog search syntax]
        /// (https://cloud.google.com/data-catalog/docs/how-to/search-reference).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SearchCatalogResult"/> resources.</returns>
        public override gax::PagedEnumerable<SearchCatalogResponse, SearchCatalogResult> SearchCatalog(SearchCatalogRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchCatalogRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchCatalogRequest, SearchCatalogResponse, SearchCatalogResult>(_callSearchCatalog, request, callSettings);
        }

        /// <summary>
        /// Searches Data Catalog for multiple resources like entries and tags that
        /// match a query.
        /// 
        /// This is a [Custom Method]
        /// (https://cloud.google.com/apis/design/custom_methods) that doesn't return
        /// all information on a resource, only its ID and high level fields. To get
        /// more information, you can subsequently call specific get methods.
        /// 
        /// Note: Data Catalog search queries don't guarantee full recall. Results
        /// that match your query might not be returned, even in subsequent
        /// result pages. Additionally, returned (and not returned) results can vary
        /// if you repeat search queries.
        /// 
        /// For more information, see [Data Catalog search syntax]
        /// (https://cloud.google.com/data-catalog/docs/how-to/search-reference).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SearchCatalogResult"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchCatalogResponse, SearchCatalogResult> SearchCatalogAsync(SearchCatalogRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchCatalogRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchCatalogRequest, SearchCatalogResponse, SearchCatalogResult>(_callSearchCatalog, request, callSettings);
        }

        /// <summary>
        /// Creates an entry group.
        /// 
        /// An entry group contains logically related entries together with [Cloud
        /// Identity and Access Management](/data-catalog/docs/concepts/iam) policies.
        /// These policies specify users who can create, edit, and view entries
        /// within entry groups.
        /// 
        /// Data Catalog automatically creates entry groups with names that start with
        /// the `@` symbol for the following resources:
        /// 
        /// * BigQuery entries (`@bigquery`)
        /// * Pub/Sub topics (`@pubsub`)
        /// * Dataproc Metastore services (`@dataproc_metastore_{SERVICE_NAME_HASH}`)
        /// 
        /// You can create your own entry groups for Cloud Storage fileset entries
        /// and custom entries together with the corresponding IAM policies.
        /// User-created entry groups can't contain the `@` symbol, it is reserved
        /// for automatically created groups.
        /// 
        /// Entry groups, like entries, can be searched.
        /// 
        /// A maximum of 10,000 entry groups may be created per organization across all
        /// locations.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EntryGroup CreateEntryGroup(CreateEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntryGroupRequest(ref request, ref callSettings);
            return _callCreateEntryGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an entry group.
        /// 
        /// An entry group contains logically related entries together with [Cloud
        /// Identity and Access Management](/data-catalog/docs/concepts/iam) policies.
        /// These policies specify users who can create, edit, and view entries
        /// within entry groups.
        /// 
        /// Data Catalog automatically creates entry groups with names that start with
        /// the `@` symbol for the following resources:
        /// 
        /// * BigQuery entries (`@bigquery`)
        /// * Pub/Sub topics (`@pubsub`)
        /// * Dataproc Metastore services (`@dataproc_metastore_{SERVICE_NAME_HASH}`)
        /// 
        /// You can create your own entry groups for Cloud Storage fileset entries
        /// and custom entries together with the corresponding IAM policies.
        /// User-created entry groups can't contain the `@` symbol, it is reserved
        /// for automatically created groups.
        /// 
        /// Entry groups, like entries, can be searched.
        /// 
        /// A maximum of 10,000 entry groups may be created per organization across all
        /// locations.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EntryGroup> CreateEntryGroupAsync(CreateEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntryGroupRequest(ref request, ref callSettings);
            return _callCreateEntryGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an entry group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EntryGroup GetEntryGroup(GetEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntryGroupRequest(ref request, ref callSettings);
            return _callGetEntryGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an entry group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EntryGroup> GetEntryGroupAsync(GetEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntryGroupRequest(ref request, ref callSettings);
            return _callGetEntryGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an entry group.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `entry_group.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EntryGroup UpdateEntryGroup(UpdateEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEntryGroupRequest(ref request, ref callSettings);
            return _callUpdateEntryGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an entry group.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `entry_group.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EntryGroup> UpdateEntryGroupAsync(UpdateEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEntryGroupRequest(ref request, ref callSettings);
            return _callUpdateEntryGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an entry group.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteEntryGroup(DeleteEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEntryGroupRequest(ref request, ref callSettings);
            _callDeleteEntryGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an entry group.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteEntryGroupAsync(DeleteEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEntryGroupRequest(ref request, ref callSettings);
            return _callDeleteEntryGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Lists entry groups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EntryGroup"/> resources.</returns>
        public override gax::PagedEnumerable<ListEntryGroupsResponse, EntryGroup> ListEntryGroups(ListEntryGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntryGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEntryGroupsRequest, ListEntryGroupsResponse, EntryGroup>(_callListEntryGroups, request, callSettings);
        }

        /// <summary>
        /// Lists entry groups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EntryGroup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEntryGroupsResponse, EntryGroup> ListEntryGroupsAsync(ListEntryGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntryGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEntryGroupsRequest, ListEntryGroupsResponse, EntryGroup>(_callListEntryGroups, request, callSettings);
        }

        /// <summary>
        /// Creates an entry.
        /// 
        /// You can create entries only with 'FILESET', 'CLUSTER', 'DATA_STREAM',
        /// or custom types. Data Catalog automatically creates entries with other
        /// types during metadata ingestion from integrated systems.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// 
        /// An entry group can have a maximum of 100,000 entries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Entry CreateEntry(CreateEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntryRequest(ref request, ref callSettings);
            return _callCreateEntry.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an entry.
        /// 
        /// You can create entries only with 'FILESET', 'CLUSTER', 'DATA_STREAM',
        /// or custom types. Data Catalog automatically creates entries with other
        /// types during metadata ingestion from integrated systems.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// 
        /// An entry group can have a maximum of 100,000 entries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Entry> CreateEntryAsync(CreateEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntryRequest(ref request, ref callSettings);
            return _callCreateEntry.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing entry.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `entry.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Entry UpdateEntry(UpdateEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEntryRequest(ref request, ref callSettings);
            return _callUpdateEntry.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an existing entry.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `entry.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Entry> UpdateEntryAsync(UpdateEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEntryRequest(ref request, ref callSettings);
            return _callUpdateEntry.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing entry.
        /// 
        /// You can delete only the entries created by the
        /// [CreateEntry][google.cloud.datacatalog.v1.DataCatalog.CreateEntry]
        /// method.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteEntry(DeleteEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEntryRequest(ref request, ref callSettings);
            _callDeleteEntry.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing entry.
        /// 
        /// You can delete only the entries created by the
        /// [CreateEntry][google.cloud.datacatalog.v1.DataCatalog.CreateEntry]
        /// method.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteEntryAsync(DeleteEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEntryRequest(ref request, ref callSettings);
            return _callDeleteEntry.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Entry GetEntry(GetEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntryRequest(ref request, ref callSettings);
            return _callGetEntry.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Entry> GetEntryAsync(GetEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntryRequest(ref request, ref callSettings);
            return _callGetEntry.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an entry by its target resource name.
        /// 
        /// The resource name comes from the source Google Cloud Platform service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Entry LookupEntry(LookupEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupEntryRequest(ref request, ref callSettings);
            return _callLookupEntry.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an entry by its target resource name.
        /// 
        /// The resource name comes from the source Google Cloud Platform service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Entry> LookupEntryAsync(LookupEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupEntryRequest(ref request, ref callSettings);
            return _callLookupEntry.Async(request, callSettings);
        }

        /// <summary>
        /// Lists entries.
        /// 
        /// Note: Currently, this method can list only custom entries.
        /// To get a list of both custom and automatically created entries, use
        /// [SearchCatalog][google.cloud.datacatalog.v1.DataCatalog.SearchCatalog].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Entry"/> resources.</returns>
        public override gax::PagedEnumerable<ListEntriesResponse, Entry> ListEntries(ListEntriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEntriesRequest, ListEntriesResponse, Entry>(_callListEntries, request, callSettings);
        }

        /// <summary>
        /// Lists entries.
        /// 
        /// Note: Currently, this method can list only custom entries.
        /// To get a list of both custom and automatically created entries, use
        /// [SearchCatalog][google.cloud.datacatalog.v1.DataCatalog.SearchCatalog].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Entry"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEntriesResponse, Entry> ListEntriesAsync(ListEntriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEntriesRequest, ListEntriesResponse, Entry>(_callListEntries, request, callSettings);
        }

        /// <summary>
        /// Modifies entry overview, part of the business context of an
        /// [Entry][google.cloud.datacatalog.v1.Entry].
        /// 
        /// To call this method, you must have the `datacatalog.entries.updateOverview`
        /// IAM permission on the corresponding project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EntryOverview ModifyEntryOverview(ModifyEntryOverviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ModifyEntryOverviewRequest(ref request, ref callSettings);
            return _callModifyEntryOverview.Sync(request, callSettings);
        }

        /// <summary>
        /// Modifies entry overview, part of the business context of an
        /// [Entry][google.cloud.datacatalog.v1.Entry].
        /// 
        /// To call this method, you must have the `datacatalog.entries.updateOverview`
        /// IAM permission on the corresponding project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EntryOverview> ModifyEntryOverviewAsync(ModifyEntryOverviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ModifyEntryOverviewRequest(ref request, ref callSettings);
            return _callModifyEntryOverview.Async(request, callSettings);
        }

        /// <summary>
        /// Modifies contacts, part of the business context of an
        /// [Entry][google.cloud.datacatalog.v1.Entry].
        /// 
        /// To call this method, you must have the `datacatalog.entries.updateContacts`
        /// IAM permission on the corresponding project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Contacts ModifyEntryContacts(ModifyEntryContactsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ModifyEntryContactsRequest(ref request, ref callSettings);
            return _callModifyEntryContacts.Sync(request, callSettings);
        }

        /// <summary>
        /// Modifies contacts, part of the business context of an
        /// [Entry][google.cloud.datacatalog.v1.Entry].
        /// 
        /// To call this method, you must have the `datacatalog.entries.updateContacts`
        /// IAM permission on the corresponding project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Contacts> ModifyEntryContactsAsync(ModifyEntryContactsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ModifyEntryContactsRequest(ref request, ref callSettings);
            return _callModifyEntryContacts.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by the
        /// `parent` parameter.
        /// For more information, see [Data Catalog resource project]
        /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TagTemplate CreateTagTemplate(CreateTagTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTagTemplateRequest(ref request, ref callSettings);
            return _callCreateTagTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by the
        /// `parent` parameter.
        /// For more information, see [Data Catalog resource project]
        /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TagTemplate> CreateTagTemplateAsync(CreateTagTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTagTemplateRequest(ref request, ref callSettings);
            return _callCreateTagTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a tag template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TagTemplate GetTagTemplate(GetTagTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTagTemplateRequest(ref request, ref callSettings);
            return _callGetTagTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a tag template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TagTemplate> GetTagTemplateAsync(GetTagTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTagTemplateRequest(ref request, ref callSettings);
            return _callGetTagTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a tag template.
        /// 
        /// You can't update template fields with this method. These fields are
        /// separate resources with their own create, update, and delete methods.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `tag_template.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TagTemplate UpdateTagTemplate(UpdateTagTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTagTemplateRequest(ref request, ref callSettings);
            return _callUpdateTagTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a tag template.
        /// 
        /// You can't update template fields with this method. These fields are
        /// separate resources with their own create, update, and delete methods.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `tag_template.name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TagTemplate> UpdateTagTemplateAsync(UpdateTagTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTagTemplateRequest(ref request, ref callSettings);
            return _callUpdateTagTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a tag template and all tags that use it.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTagTemplate(DeleteTagTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTagTemplateRequest(ref request, ref callSettings);
            _callDeleteTagTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a tag template and all tags that use it.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteTagTemplateAsync(DeleteTagTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTagTemplateRequest(ref request, ref callSettings);
            return _callDeleteTagTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a field in a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TagTemplateField CreateTagTemplateField(CreateTagTemplateFieldRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTagTemplateFieldRequest(ref request, ref callSettings);
            return _callCreateTagTemplateField.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a field in a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `parent` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TagTemplateField> CreateTagTemplateFieldAsync(CreateTagTemplateFieldRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTagTemplateFieldRequest(ref request, ref callSettings);
            return _callCreateTagTemplateField.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a field in a tag template.
        /// 
        /// You can't update the field type with this method.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TagTemplateField UpdateTagTemplateField(UpdateTagTemplateFieldRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTagTemplateFieldRequest(ref request, ref callSettings);
            return _callUpdateTagTemplateField.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a field in a tag template.
        /// 
        /// You can't update the field type with this method.
        /// 
        /// You must enable the Data Catalog API in the project
        /// identified by the `name` parameter. For more information, see [Data Catalog
        /// resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TagTemplateField> UpdateTagTemplateFieldAsync(UpdateTagTemplateFieldRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTagTemplateFieldRequest(ref request, ref callSettings);
            return _callUpdateTagTemplateField.Async(request, callSettings);
        }

        /// <summary>
        /// Renames a field in a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by the
        /// `name` parameter. For more information, see [Data Catalog resource project]
        /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TagTemplateField RenameTagTemplateField(RenameTagTemplateFieldRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenameTagTemplateFieldRequest(ref request, ref callSettings);
            return _callRenameTagTemplateField.Sync(request, callSettings);
        }

        /// <summary>
        /// Renames a field in a tag template.
        /// 
        /// You must enable the Data Catalog API in the project identified by the
        /// `name` parameter. For more information, see [Data Catalog resource project]
        /// (https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TagTemplateField> RenameTagTemplateFieldAsync(RenameTagTemplateFieldRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenameTagTemplateFieldRequest(ref request, ref callSettings);
            return _callRenameTagTemplateField.Async(request, callSettings);
        }

        /// <summary>
        /// Renames an enum value in a tag template.
        /// 
        /// Within a single enum field, enum values must be unique.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TagTemplateField RenameTagTemplateFieldEnumValue(RenameTagTemplateFieldEnumValueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenameTagTemplateFieldEnumValueRequest(ref request, ref callSettings);
            return _callRenameTagTemplateFieldEnumValue.Sync(request, callSettings);
        }

        /// <summary>
        /// Renames an enum value in a tag template.
        /// 
        /// Within a single enum field, enum values must be unique.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TagTemplateField> RenameTagTemplateFieldEnumValueAsync(RenameTagTemplateFieldEnumValueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenameTagTemplateFieldEnumValueRequest(ref request, ref callSettings);
            return _callRenameTagTemplateFieldEnumValue.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a field in a tag template and all uses of this field from the tags
        /// based on this template.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTagTemplateField(DeleteTagTemplateFieldRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTagTemplateFieldRequest(ref request, ref callSettings);
            _callDeleteTagTemplateField.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a field in a tag template and all uses of this field from the tags
        /// based on this template.
        /// 
        /// You must enable the Data Catalog API in the project identified by
        /// the `name` parameter. For more information, see [Data Catalog resource
        /// project](https://cloud.google.com/data-catalog/docs/concepts/resource-project).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteTagTemplateFieldAsync(DeleteTagTemplateFieldRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTagTemplateFieldRequest(ref request, ref callSettings);
            return _callDeleteTagTemplateField.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a tag and assigns it to:
        /// 
        /// * An [Entry][google.cloud.datacatalog.v1.Entry] if the method name is
        /// `projects.locations.entryGroups.entries.tags.create`.
        /// * Or [EntryGroup][google.cloud.datacatalog.v1.EntryGroup]if the method
        /// name is `projects.locations.entryGroups.tags.create`.
        /// 
        /// Note: The project identified by the `parent` parameter for the [tag]
        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.entries.tags/create#path-parameters)
        /// and the [tag template]
        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.tagTemplates/create#path-parameters)
        /// used to create the tag must be in the same organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Tag CreateTag(CreateTagRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTagRequest(ref request, ref callSettings);
            return _callCreateTag.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a tag and assigns it to:
        /// 
        /// * An [Entry][google.cloud.datacatalog.v1.Entry] if the method name is
        /// `projects.locations.entryGroups.entries.tags.create`.
        /// * Or [EntryGroup][google.cloud.datacatalog.v1.EntryGroup]if the method
        /// name is `projects.locations.entryGroups.tags.create`.
        /// 
        /// Note: The project identified by the `parent` parameter for the [tag]
        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.entries.tags/create#path-parameters)
        /// and the [tag template]
        /// (https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.tagTemplates/create#path-parameters)
        /// used to create the tag must be in the same organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Tag> CreateTagAsync(CreateTagRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTagRequest(ref request, ref callSettings);
            return _callCreateTag.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Tag UpdateTag(UpdateTagRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTagRequest(ref request, ref callSettings);
            return _callUpdateTag.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an existing tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Tag> UpdateTagAsync(UpdateTagRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTagRequest(ref request, ref callSettings);
            return _callUpdateTag.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTag(DeleteTagRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTagRequest(ref request, ref callSettings);
            _callDeleteTag.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a tag.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteTagAsync(DeleteTagRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTagRequest(ref request, ref callSettings);
            return _callDeleteTag.Async(request, callSettings);
        }

        /// <summary>
        /// Lists tags assigned to an [Entry][google.cloud.datacatalog.v1.Entry].
        /// The [columns][google.cloud.datacatalog.v1.Tag.column] in the response are
        /// lowercased.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Tag"/> resources.</returns>
        public override gax::PagedEnumerable<ListTagsResponse, Tag> ListTags(ListTagsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTagsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTagsRequest, ListTagsResponse, Tag>(_callListTags, request, callSettings);
        }

        /// <summary>
        /// Lists tags assigned to an [Entry][google.cloud.datacatalog.v1.Entry].
        /// The [columns][google.cloud.datacatalog.v1.Tag.column] in the response are
        /// lowercased.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Tag"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTagsResponse, Tag> ListTagsAsync(ListTagsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTagsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTagsRequest, ListTagsResponse, Tag>(_callListTags, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ReconcileTags</c>.</summary>
        public override lro::OperationsClient ReconcileTagsOperationsClient { get; }

        /// <summary>
        /// `ReconcileTags` creates or updates a list of tags on the entry.
        /// If the
        /// [ReconcileTagsRequest.force_delete_missing][google.cloud.datacatalog.v1.ReconcileTagsRequest.force_delete_missing]
        /// parameter is set, the operation deletes tags not included in the input tag
        /// list.
        /// 
        /// `ReconcileTags` returns a [long-running operation]
        /// [google.longrunning.Operation] resource that can be queried with
        /// [Operations.GetOperation][google.longrunning.Operations.GetOperation]
        /// to return [ReconcileTagsMetadata]
        /// [google.cloud.datacatalog.v1.ReconcileTagsMetadata] and
        /// a [ReconcileTagsResponse]
        /// [google.cloud.datacatalog.v1.ReconcileTagsResponse] message.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ReconcileTagsResponse, ReconcileTagsMetadata> ReconcileTags(ReconcileTagsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReconcileTagsRequest(ref request, ref callSettings);
            return new lro::Operation<ReconcileTagsResponse, ReconcileTagsMetadata>(_callReconcileTags.Sync(request, callSettings), ReconcileTagsOperationsClient);
        }

        /// <summary>
        /// `ReconcileTags` creates or updates a list of tags on the entry.
        /// If the
        /// [ReconcileTagsRequest.force_delete_missing][google.cloud.datacatalog.v1.ReconcileTagsRequest.force_delete_missing]
        /// parameter is set, the operation deletes tags not included in the input tag
        /// list.
        /// 
        /// `ReconcileTags` returns a [long-running operation]
        /// [google.longrunning.Operation] resource that can be queried with
        /// [Operations.GetOperation][google.longrunning.Operations.GetOperation]
        /// to return [ReconcileTagsMetadata]
        /// [google.cloud.datacatalog.v1.ReconcileTagsMetadata] and
        /// a [ReconcileTagsResponse]
        /// [google.cloud.datacatalog.v1.ReconcileTagsResponse] message.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ReconcileTagsResponse, ReconcileTagsMetadata>> ReconcileTagsAsync(ReconcileTagsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReconcileTagsRequest(ref request, ref callSettings);
            return new lro::Operation<ReconcileTagsResponse, ReconcileTagsMetadata>(await _callReconcileTags.Async(request, callSettings).ConfigureAwait(false), ReconcileTagsOperationsClient);
        }

        /// <summary>
        /// Marks an [Entry][google.cloud.datacatalog.v1.Entry] as starred by
        /// the current user. Starring information is private to each user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StarEntryResponse StarEntry(StarEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StarEntryRequest(ref request, ref callSettings);
            return _callStarEntry.Sync(request, callSettings);
        }

        /// <summary>
        /// Marks an [Entry][google.cloud.datacatalog.v1.Entry] as starred by
        /// the current user. Starring information is private to each user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StarEntryResponse> StarEntryAsync(StarEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StarEntryRequest(ref request, ref callSettings);
            return _callStarEntry.Async(request, callSettings);
        }

        /// <summary>
        /// Marks an [Entry][google.cloud.datacatalog.v1.Entry] as NOT starred by
        /// the current user. Starring information is private to each user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UnstarEntryResponse UnstarEntry(UnstarEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UnstarEntryRequest(ref request, ref callSettings);
            return _callUnstarEntry.Sync(request, callSettings);
        }

        /// <summary>
        /// Marks an [Entry][google.cloud.datacatalog.v1.Entry] as NOT starred by
        /// the current user. Starring information is private to each user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UnstarEntryResponse> UnstarEntryAsync(UnstarEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UnstarEntryRequest(ref request, ref callSettings);
            return _callUnstarEntry.Async(request, callSettings);
        }

        /// <summary>
        /// Sets an access control policy for a resource. Replaces any existing
        /// policy.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method sets policies only within Data Catalog and can't be
        /// used to manage policies in BigQuery, Pub/Sub, Dataproc Metastore, and any
        /// external Google Cloud Platform resources synced with the Data Catalog.
        /// 
        /// To call this method, you must have the following Google IAM permissions:
        /// 
        /// - `datacatalog.tagTemplates.setIamPolicy` to set policies on tag
        /// templates.
        /// - `datacatalog.entryGroups.setIamPolicy` to set policies on entry groups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets an access control policy for a resource. Replaces any existing
        /// policy.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method sets policies only within Data Catalog and can't be
        /// used to manage policies in BigQuery, Pub/Sub, Dataproc Metastore, and any
        /// external Google Cloud Platform resources synced with the Data Catalog.
        /// 
        /// To call this method, you must have the following Google IAM permissions:
        /// 
        /// - `datacatalog.tagTemplates.setIamPolicy` to set policies on tag
        /// templates.
        /// - `datacatalog.entryGroups.setIamPolicy` to set policies on entry groups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a resource.
        /// 
        /// May return:
        /// 
        /// * A`NOT_FOUND` error if the resource doesn't exist or you don't have the
        /// permission to view it.
        /// * An empty policy if the resource exists but doesn't have a set policy.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method doesn't get policies from Google Cloud Platform
        /// resources ingested into Data Catalog.
        /// 
        /// To call this method, you must have the following Google IAM permissions:
        /// 
        /// - `datacatalog.tagTemplates.getIamPolicy` to get policies on tag
        /// templates.
        /// - `datacatalog.entryGroups.getIamPolicy` to get policies on entry groups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a resource.
        /// 
        /// May return:
        /// 
        /// * A`NOT_FOUND` error if the resource doesn't exist or you don't have the
        /// permission to view it.
        /// * An empty policy if the resource exists but doesn't have a set policy.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method doesn't get policies from Google Cloud Platform
        /// resources ingested into Data Catalog.
        /// 
        /// To call this method, you must have the following Google IAM permissions:
        /// 
        /// - `datacatalog.tagTemplates.getIamPolicy` to get policies on tag
        /// templates.
        /// - `datacatalog.entryGroups.getIamPolicy` to get policies on entry groups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Gets your permissions on a resource.
        /// 
        /// Returns an empty set of permissions if the resource doesn't exist.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method gets policies only within Data Catalog and can't be
        /// used to get policies from BigQuery, Pub/Sub, Dataproc Metastore, and any
        /// external Google Cloud Platform resources ingested into Data Catalog.
        /// 
        /// No Google IAM permissions are required to call this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets your permissions on a resource.
        /// 
        /// Returns an empty set of permissions if the resource doesn't exist.
        /// 
        /// Supported resources are:
        /// 
        /// - Tag templates
        /// - Entry groups
        /// 
        /// Note: This method gets policies only within Data Catalog and can't be
        /// used to get policies from BigQuery, Pub/Sub, Dataproc Metastore, and any
        /// external Google Cloud Platform resources ingested into Data Catalog.
        /// 
        /// No Google IAM permissions are required to call this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ImportEntries</c>.</summary>
        public override lro::OperationsClient ImportEntriesOperationsClient { get; }

        /// <summary>
        /// Imports entries from a source, such as data previously dumped into a
        /// Cloud Storage bucket, into Data Catalog. Import of entries
        /// is a sync operation that reconciles the state of the third-party system
        /// with the Data Catalog.
        /// 
        /// `ImportEntries` accepts source data snapshots of a third-party system.
        /// Snapshot should be delivered as a .wire or base65-encoded .txt file
        /// containing a sequence of Protocol Buffer messages of
        /// [DumpItem][google.cloud.datacatalog.v1.DumpItem] type.
        /// 
        /// `ImportEntries` returns a [long-running operation]
        /// [google.longrunning.Operation] resource that can be queried with
        /// [Operations.GetOperation][google.longrunning.Operations.GetOperation]
        /// to return
        /// [ImportEntriesMetadata][google.cloud.datacatalog.v1.ImportEntriesMetadata]
        /// and an
        /// [ImportEntriesResponse][google.cloud.datacatalog.v1.ImportEntriesResponse]
        /// message.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportEntriesResponse, ImportEntriesMetadata> ImportEntries(ImportEntriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportEntriesRequest(ref request, ref callSettings);
            return new lro::Operation<ImportEntriesResponse, ImportEntriesMetadata>(_callImportEntries.Sync(request, callSettings), ImportEntriesOperationsClient);
        }

        /// <summary>
        /// Imports entries from a source, such as data previously dumped into a
        /// Cloud Storage bucket, into Data Catalog. Import of entries
        /// is a sync operation that reconciles the state of the third-party system
        /// with the Data Catalog.
        /// 
        /// `ImportEntries` accepts source data snapshots of a third-party system.
        /// Snapshot should be delivered as a .wire or base65-encoded .txt file
        /// containing a sequence of Protocol Buffer messages of
        /// [DumpItem][google.cloud.datacatalog.v1.DumpItem] type.
        /// 
        /// `ImportEntries` returns a [long-running operation]
        /// [google.longrunning.Operation] resource that can be queried with
        /// [Operations.GetOperation][google.longrunning.Operations.GetOperation]
        /// to return
        /// [ImportEntriesMetadata][google.cloud.datacatalog.v1.ImportEntriesMetadata]
        /// and an
        /// [ImportEntriesResponse][google.cloud.datacatalog.v1.ImportEntriesResponse]
        /// message.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportEntriesResponse, ImportEntriesMetadata>> ImportEntriesAsync(ImportEntriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportEntriesRequest(ref request, ref callSettings);
            return new lro::Operation<ImportEntriesResponse, ImportEntriesMetadata>(await _callImportEntries.Async(request, callSettings).ConfigureAwait(false), ImportEntriesOperationsClient);
        }
    }

    public partial class SearchCatalogRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEntryGroupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEntriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTagsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchCatalogResponse : gaxgrpc::IPageResponse<SearchCatalogResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SearchCatalogResult> GetEnumerator() => Results.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEntryGroupsResponse : gaxgrpc::IPageResponse<EntryGroup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EntryGroup> GetEnumerator() => EntryGroups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEntriesResponse : gaxgrpc::IPageResponse<Entry>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Entry> GetEnumerator() => Entries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTagsResponse : gaxgrpc::IPageResponse<Tag>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Tag> GetEnumerator() => Tags.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DataCatalog
    {
        public partial class DataCatalogClient
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

    public static partial class DataCatalog
    {
        public partial class DataCatalogClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gciv::IAMPolicy.IAMPolicyClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gciv::IAMPolicy.IAMPolicyClient"/> for the same target as this client.
            /// </returns>
            public virtual gciv::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() =>
                new gciv::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }
}
