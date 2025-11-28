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
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Apps.Chat.V1
{
    /// <summary>Settings for <see cref="ChatServiceClient"/> instances.</summary>
    public sealed partial class ChatServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ChatServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ChatServiceSettings"/>.</returns>
        public static ChatServiceSettings GetDefault() => new ChatServiceSettings();

        /// <summary>Constructs a new <see cref="ChatServiceSettings"/> object with default settings.</summary>
        public ChatServiceSettings()
        {
        }

        private ChatServiceSettings(ChatServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateMessageSettings = existing.CreateMessageSettings;
            ListMessagesSettings = existing.ListMessagesSettings;
            ListMembershipsSettings = existing.ListMembershipsSettings;
            GetMembershipSettings = existing.GetMembershipSettings;
            GetMessageSettings = existing.GetMessageSettings;
            UpdateMessageSettings = existing.UpdateMessageSettings;
            DeleteMessageSettings = existing.DeleteMessageSettings;
            GetAttachmentSettings = existing.GetAttachmentSettings;
            UploadAttachmentSettings = existing.UploadAttachmentSettings;
            ListSpacesSettings = existing.ListSpacesSettings;
            SearchSpacesSettings = existing.SearchSpacesSettings;
            GetSpaceSettings = existing.GetSpaceSettings;
            CreateSpaceSettings = existing.CreateSpaceSettings;
            SetUpSpaceSettings = existing.SetUpSpaceSettings;
            UpdateSpaceSettings = existing.UpdateSpaceSettings;
            DeleteSpaceSettings = existing.DeleteSpaceSettings;
            CompleteImportSpaceSettings = existing.CompleteImportSpaceSettings;
            FindDirectMessageSettings = existing.FindDirectMessageSettings;
            CreateMembershipSettings = existing.CreateMembershipSettings;
            UpdateMembershipSettings = existing.UpdateMembershipSettings;
            DeleteMembershipSettings = existing.DeleteMembershipSettings;
            CreateReactionSettings = existing.CreateReactionSettings;
            ListReactionsSettings = existing.ListReactionsSettings;
            DeleteReactionSettings = existing.DeleteReactionSettings;
            CreateCustomEmojiSettings = existing.CreateCustomEmojiSettings;
            GetCustomEmojiSettings = existing.GetCustomEmojiSettings;
            ListCustomEmojisSettings = existing.ListCustomEmojisSettings;
            DeleteCustomEmojiSettings = existing.DeleteCustomEmojiSettings;
            GetSpaceReadStateSettings = existing.GetSpaceReadStateSettings;
            UpdateSpaceReadStateSettings = existing.UpdateSpaceReadStateSettings;
            GetThreadReadStateSettings = existing.GetThreadReadStateSettings;
            GetSpaceEventSettings = existing.GetSpaceEventSettings;
            ListSpaceEventsSettings = existing.ListSpaceEventsSettings;
            GetSpaceNotificationSettingSettings = existing.GetSpaceNotificationSettingSettings;
            UpdateSpaceNotificationSettingSettings = existing.UpdateSpaceNotificationSettingSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ChatServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.CreateMessage</c> and <c>ChatServiceClient.CreateMessageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMessageSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.ListMessages</c> and <c>ChatServiceClient.ListMessagesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMessagesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.ListMemberships</c> and <c>ChatServiceClient.ListMembershipsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMembershipsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.GetMembership</c> and <c>ChatServiceClient.GetMembershipAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMembershipSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.GetMessage</c> and <c>ChatServiceClient.GetMessageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMessageSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.UpdateMessage</c> and <c>ChatServiceClient.UpdateMessageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateMessageSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.DeleteMessage</c> and <c>ChatServiceClient.DeleteMessageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteMessageSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.GetAttachment</c> and <c>ChatServiceClient.GetAttachmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAttachmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.UploadAttachment</c> and <c>ChatServiceClient.UploadAttachmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UploadAttachmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.ListSpaces</c> and <c>ChatServiceClient.ListSpacesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSpacesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.SearchSpaces</c> and <c>ChatServiceClient.SearchSpacesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchSpacesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ChatServiceClient.GetSpace</c>
        ///  and <c>ChatServiceClient.GetSpaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSpaceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.CreateSpace</c> and <c>ChatServiceClient.CreateSpaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSpaceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.SetUpSpace</c> and <c>ChatServiceClient.SetUpSpaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetUpSpaceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.UpdateSpace</c> and <c>ChatServiceClient.UpdateSpaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSpaceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.DeleteSpace</c> and <c>ChatServiceClient.DeleteSpaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSpaceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.CompleteImportSpace</c> and <c>ChatServiceClient.CompleteImportSpaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CompleteImportSpaceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.FindDirectMessage</c> and <c>ChatServiceClient.FindDirectMessageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FindDirectMessageSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.CreateMembership</c> and <c>ChatServiceClient.CreateMembershipAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMembershipSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.UpdateMembership</c> and <c>ChatServiceClient.UpdateMembershipAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateMembershipSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.DeleteMembership</c> and <c>ChatServiceClient.DeleteMembershipAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteMembershipSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.CreateReaction</c> and <c>ChatServiceClient.CreateReactionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateReactionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.ListReactions</c> and <c>ChatServiceClient.ListReactionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListReactionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.DeleteReaction</c> and <c>ChatServiceClient.DeleteReactionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteReactionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.CreateCustomEmoji</c> and <c>ChatServiceClient.CreateCustomEmojiAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCustomEmojiSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.GetCustomEmoji</c> and <c>ChatServiceClient.GetCustomEmojiAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCustomEmojiSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.ListCustomEmojis</c> and <c>ChatServiceClient.ListCustomEmojisAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCustomEmojisSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.DeleteCustomEmoji</c> and <c>ChatServiceClient.DeleteCustomEmojiAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCustomEmojiSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.GetSpaceReadState</c> and <c>ChatServiceClient.GetSpaceReadStateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSpaceReadStateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.UpdateSpaceReadState</c> and <c>ChatServiceClient.UpdateSpaceReadStateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSpaceReadStateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.GetThreadReadState</c> and <c>ChatServiceClient.GetThreadReadStateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetThreadReadStateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.GetSpaceEvent</c> and <c>ChatServiceClient.GetSpaceEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSpaceEventSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.ListSpaceEvents</c> and <c>ChatServiceClient.ListSpaceEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSpaceEventsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.GetSpaceNotificationSetting</c> and
        /// <c>ChatServiceClient.GetSpaceNotificationSettingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSpaceNotificationSettingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChatServiceClient.UpdateSpaceNotificationSetting</c> and
        /// <c>ChatServiceClient.UpdateSpaceNotificationSettingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSpaceNotificationSettingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ChatServiceSettings"/> object.</returns>
        public ChatServiceSettings Clone() => new ChatServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ChatServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ChatServiceClientBuilder : gaxgrpc::ClientBuilderBase<ChatServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ChatServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ChatServiceClientBuilder() : base(ChatServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ChatServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ChatServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ChatServiceClient Build()
        {
            ChatServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ChatServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ChatServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ChatServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ChatServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ChatServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ChatServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ChatServiceClient.ChannelPool;
    }

    /// <summary>ChatService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Enables developers to build Chat apps and
    /// integrations on Google Chat Platform.
    /// </remarks>
    public abstract partial class ChatServiceClient
    {
        /// <summary>
        /// The default endpoint for the ChatService service, which is a host of "chat.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "chat.googleapis.com:443";

        /// <summary>The default ChatService scopes.</summary>
        /// <remarks>
        /// The default ChatService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/chat.admin.delete</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.admin.memberships</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.admin.memberships.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.admin.spaces</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.admin.spaces.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.app.delete</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.app.memberships</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.app.spaces</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.app.spaces.create</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.bot</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.customemojis</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.customemojis.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.delete</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.import</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.memberships</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.memberships.app</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.memberships.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.messages</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.messages.create</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.messages.reactions</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.messages.reactions.create</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.messages.reactions.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.messages.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.spaces</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.spaces.create</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.spaces.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.users.readstate</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.users.readstate.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.users.spacesettings</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/chat.admin.delete",
            "https://www.googleapis.com/auth/chat.admin.memberships",
            "https://www.googleapis.com/auth/chat.admin.memberships.readonly",
            "https://www.googleapis.com/auth/chat.admin.spaces",
            "https://www.googleapis.com/auth/chat.admin.spaces.readonly",
            "https://www.googleapis.com/auth/chat.app.delete",
            "https://www.googleapis.com/auth/chat.app.memberships",
            "https://www.googleapis.com/auth/chat.app.spaces",
            "https://www.googleapis.com/auth/chat.app.spaces.create",
            "https://www.googleapis.com/auth/chat.bot",
            "https://www.googleapis.com/auth/chat.customemojis",
            "https://www.googleapis.com/auth/chat.customemojis.readonly",
            "https://www.googleapis.com/auth/chat.delete",
            "https://www.googleapis.com/auth/chat.import",
            "https://www.googleapis.com/auth/chat.memberships",
            "https://www.googleapis.com/auth/chat.memberships.app",
            "https://www.googleapis.com/auth/chat.memberships.readonly",
            "https://www.googleapis.com/auth/chat.messages",
            "https://www.googleapis.com/auth/chat.messages.create",
            "https://www.googleapis.com/auth/chat.messages.reactions",
            "https://www.googleapis.com/auth/chat.messages.reactions.create",
            "https://www.googleapis.com/auth/chat.messages.reactions.readonly",
            "https://www.googleapis.com/auth/chat.messages.readonly",
            "https://www.googleapis.com/auth/chat.spaces",
            "https://www.googleapis.com/auth/chat.spaces.create",
            "https://www.googleapis.com/auth/chat.spaces.readonly",
            "https://www.googleapis.com/auth/chat.users.readstate",
            "https://www.googleapis.com/auth/chat.users.readstate.readonly",
            "https://www.googleapis.com/auth/chat.users.spacesettings",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ChatService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ChatServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ChatServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ChatServiceClient"/>.</returns>
        public static stt::Task<ChatServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ChatServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ChatServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ChatServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ChatServiceClient"/>.</returns>
        public static ChatServiceClient Create() => new ChatServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ChatServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ChatServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ChatServiceClient"/>.</returns>
        internal static ChatServiceClient Create(grpccore::CallInvoker callInvoker, ChatServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ChatService.ChatServiceClient grpcClient = new ChatService.ChatServiceClient(callInvoker);
            return new ChatServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ChatService client</summary>
        public virtual ChatService.ChatServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a message in a Google Chat space. For an example, see [Send a
        /// message](https://developers.google.com/workspace/chat/create-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages.create`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// Chat attributes the message sender differently depending on the type of
        /// authentication that you use in your request.
        /// 
        /// The following image shows how Chat attributes a message when you use app
        /// authentication. Chat displays the Chat app as the message
        /// sender. The content of the message can contain text (`text`), cards
        /// (`cardsV2`), and accessory widgets (`accessoryWidgets`).
        /// 
        /// ![Message sent with app
        /// authentication](https://developers.google.com/workspace/chat/images/message-app-auth.svg)
        /// 
        /// The following image shows how Chat attributes a message when you use user
        /// authentication. Chat displays the user as the message sender and attributes
        /// the Chat app to the message by displaying its name. The content of message
        /// can only contain text (`text`).
        /// 
        /// ![Message sent with user
        /// authentication](https://developers.google.com/workspace/chat/images/message-user-auth.svg)
        /// 
        /// The maximum message size, including the message contents, is 32,000 bytes.
        /// 
        /// For
        /// [webhook](https://developers.google.com/workspace/chat/quickstart/webhooks)
        /// requests, the response doesn't contain the full message. The response only
        /// populates the `name` and `thread.name` fields in addition to the
        /// information that was in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Message CreateMessage(CreateMessageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a message in a Google Chat space. For an example, see [Send a
        /// message](https://developers.google.com/workspace/chat/create-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages.create`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// Chat attributes the message sender differently depending on the type of
        /// authentication that you use in your request.
        /// 
        /// The following image shows how Chat attributes a message when you use app
        /// authentication. Chat displays the Chat app as the message
        /// sender. The content of the message can contain text (`text`), cards
        /// (`cardsV2`), and accessory widgets (`accessoryWidgets`).
        /// 
        /// ![Message sent with app
        /// authentication](https://developers.google.com/workspace/chat/images/message-app-auth.svg)
        /// 
        /// The following image shows how Chat attributes a message when you use user
        /// authentication. Chat displays the user as the message sender and attributes
        /// the Chat app to the message by displaying its name. The content of message
        /// can only contain text (`text`).
        /// 
        /// ![Message sent with user
        /// authentication](https://developers.google.com/workspace/chat/images/message-user-auth.svg)
        /// 
        /// The maximum message size, including the message contents, is 32,000 bytes.
        /// 
        /// For
        /// [webhook](https://developers.google.com/workspace/chat/quickstart/webhooks)
        /// requests, the response doesn't contain the full message. The response only
        /// populates the `name` and `thread.name` fields in addition to the
        /// information that was in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> CreateMessageAsync(CreateMessageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a message in a Google Chat space. For an example, see [Send a
        /// message](https://developers.google.com/workspace/chat/create-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages.create`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// Chat attributes the message sender differently depending on the type of
        /// authentication that you use in your request.
        /// 
        /// The following image shows how Chat attributes a message when you use app
        /// authentication. Chat displays the Chat app as the message
        /// sender. The content of the message can contain text (`text`), cards
        /// (`cardsV2`), and accessory widgets (`accessoryWidgets`).
        /// 
        /// ![Message sent with app
        /// authentication](https://developers.google.com/workspace/chat/images/message-app-auth.svg)
        /// 
        /// The following image shows how Chat attributes a message when you use user
        /// authentication. Chat displays the user as the message sender and attributes
        /// the Chat app to the message by displaying its name. The content of message
        /// can only contain text (`text`).
        /// 
        /// ![Message sent with user
        /// authentication](https://developers.google.com/workspace/chat/images/message-user-auth.svg)
        /// 
        /// The maximum message size, including the message contents, is 32,000 bytes.
        /// 
        /// For
        /// [webhook](https://developers.google.com/workspace/chat/quickstart/webhooks)
        /// requests, the response doesn't contain the full message. The response only
        /// populates the `name` and `thread.name` fields in addition to the
        /// information that was in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> CreateMessageAsync(CreateMessageRequest request, st::CancellationToken cancellationToken) =>
            CreateMessageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a message in a Google Chat space. For an example, see [Send a
        /// message](https://developers.google.com/workspace/chat/create-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages.create`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// Chat attributes the message sender differently depending on the type of
        /// authentication that you use in your request.
        /// 
        /// The following image shows how Chat attributes a message when you use app
        /// authentication. Chat displays the Chat app as the message
        /// sender. The content of the message can contain text (`text`), cards
        /// (`cardsV2`), and accessory widgets (`accessoryWidgets`).
        /// 
        /// ![Message sent with app
        /// authentication](https://developers.google.com/workspace/chat/images/message-app-auth.svg)
        /// 
        /// The following image shows how Chat attributes a message when you use user
        /// authentication. Chat displays the user as the message sender and attributes
        /// the Chat app to the message by displaying its name. The content of message
        /// can only contain text (`text`).
        /// 
        /// ![Message sent with user
        /// authentication](https://developers.google.com/workspace/chat/images/message-user-auth.svg)
        /// 
        /// The maximum message size, including the message contents, is 32,000 bytes.
        /// 
        /// For
        /// [webhook](https://developers.google.com/workspace/chat/quickstart/webhooks)
        /// requests, the response doesn't contain the full message. The response only
        /// populates the `name` and `thread.name` fields in addition to the
        /// information that was in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the space in which to create a message.
        /// 
        /// Format: `spaces/{space}`
        /// </param>
        /// <param name="message">
        /// Required. Message body.
        /// </param>
        /// <param name="messageId">
        /// Optional. A custom ID for a message. Lets Chat apps get, update, or delete
        /// a message without needing to store the system-assigned ID in the message's
        /// resource name (represented in the message `name` field).
        /// 
        /// The value for this field must meet the following requirements:
        /// 
        /// * Begins with `client-`. For example, `client-custom-name` is a valid
        /// custom ID, but `custom-name` is not.
        /// * Contains up to 63 characters and only lowercase letters, numbers, and
        /// hyphens.
        /// * Is unique within a space. A Chat app can't use the same custom ID for
        /// different messages.
        /// 
        /// For details, see [Name a
        /// message](https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Message CreateMessage(string parent, Message message, string messageId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMessage(new CreateMessageRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Message = gax::GaxPreconditions.CheckNotNull(message, nameof(message)),
                MessageId = messageId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a message in a Google Chat space. For an example, see [Send a
        /// message](https://developers.google.com/workspace/chat/create-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages.create`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// Chat attributes the message sender differently depending on the type of
        /// authentication that you use in your request.
        /// 
        /// The following image shows how Chat attributes a message when you use app
        /// authentication. Chat displays the Chat app as the message
        /// sender. The content of the message can contain text (`text`), cards
        /// (`cardsV2`), and accessory widgets (`accessoryWidgets`).
        /// 
        /// ![Message sent with app
        /// authentication](https://developers.google.com/workspace/chat/images/message-app-auth.svg)
        /// 
        /// The following image shows how Chat attributes a message when you use user
        /// authentication. Chat displays the user as the message sender and attributes
        /// the Chat app to the message by displaying its name. The content of message
        /// can only contain text (`text`).
        /// 
        /// ![Message sent with user
        /// authentication](https://developers.google.com/workspace/chat/images/message-user-auth.svg)
        /// 
        /// The maximum message size, including the message contents, is 32,000 bytes.
        /// 
        /// For
        /// [webhook](https://developers.google.com/workspace/chat/quickstart/webhooks)
        /// requests, the response doesn't contain the full message. The response only
        /// populates the `name` and `thread.name` fields in addition to the
        /// information that was in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the space in which to create a message.
        /// 
        /// Format: `spaces/{space}`
        /// </param>
        /// <param name="message">
        /// Required. Message body.
        /// </param>
        /// <param name="messageId">
        /// Optional. A custom ID for a message. Lets Chat apps get, update, or delete
        /// a message without needing to store the system-assigned ID in the message's
        /// resource name (represented in the message `name` field).
        /// 
        /// The value for this field must meet the following requirements:
        /// 
        /// * Begins with `client-`. For example, `client-custom-name` is a valid
        /// custom ID, but `custom-name` is not.
        /// * Contains up to 63 characters and only lowercase letters, numbers, and
        /// hyphens.
        /// * Is unique within a space. A Chat app can't use the same custom ID for
        /// different messages.
        /// 
        /// For details, see [Name a
        /// message](https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> CreateMessageAsync(string parent, Message message, string messageId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMessageAsync(new CreateMessageRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Message = gax::GaxPreconditions.CheckNotNull(message, nameof(message)),
                MessageId = messageId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a message in a Google Chat space. For an example, see [Send a
        /// message](https://developers.google.com/workspace/chat/create-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages.create`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// Chat attributes the message sender differently depending on the type of
        /// authentication that you use in your request.
        /// 
        /// The following image shows how Chat attributes a message when you use app
        /// authentication. Chat displays the Chat app as the message
        /// sender. The content of the message can contain text (`text`), cards
        /// (`cardsV2`), and accessory widgets (`accessoryWidgets`).
        /// 
        /// ![Message sent with app
        /// authentication](https://developers.google.com/workspace/chat/images/message-app-auth.svg)
        /// 
        /// The following image shows how Chat attributes a message when you use user
        /// authentication. Chat displays the user as the message sender and attributes
        /// the Chat app to the message by displaying its name. The content of message
        /// can only contain text (`text`).
        /// 
        /// ![Message sent with user
        /// authentication](https://developers.google.com/workspace/chat/images/message-user-auth.svg)
        /// 
        /// The maximum message size, including the message contents, is 32,000 bytes.
        /// 
        /// For
        /// [webhook](https://developers.google.com/workspace/chat/quickstart/webhooks)
        /// requests, the response doesn't contain the full message. The response only
        /// populates the `name` and `thread.name` fields in addition to the
        /// information that was in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the space in which to create a message.
        /// 
        /// Format: `spaces/{space}`
        /// </param>
        /// <param name="message">
        /// Required. Message body.
        /// </param>
        /// <param name="messageId">
        /// Optional. A custom ID for a message. Lets Chat apps get, update, or delete
        /// a message without needing to store the system-assigned ID in the message's
        /// resource name (represented in the message `name` field).
        /// 
        /// The value for this field must meet the following requirements:
        /// 
        /// * Begins with `client-`. For example, `client-custom-name` is a valid
        /// custom ID, but `custom-name` is not.
        /// * Contains up to 63 characters and only lowercase letters, numbers, and
        /// hyphens.
        /// * Is unique within a space. A Chat app can't use the same custom ID for
        /// different messages.
        /// 
        /// For details, see [Name a
        /// message](https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> CreateMessageAsync(string parent, Message message, string messageId, st::CancellationToken cancellationToken) =>
            CreateMessageAsync(parent, message, messageId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a message in a Google Chat space. For an example, see [Send a
        /// message](https://developers.google.com/workspace/chat/create-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages.create`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// Chat attributes the message sender differently depending on the type of
        /// authentication that you use in your request.
        /// 
        /// The following image shows how Chat attributes a message when you use app
        /// authentication. Chat displays the Chat app as the message
        /// sender. The content of the message can contain text (`text`), cards
        /// (`cardsV2`), and accessory widgets (`accessoryWidgets`).
        /// 
        /// ![Message sent with app
        /// authentication](https://developers.google.com/workspace/chat/images/message-app-auth.svg)
        /// 
        /// The following image shows how Chat attributes a message when you use user
        /// authentication. Chat displays the user as the message sender and attributes
        /// the Chat app to the message by displaying its name. The content of message
        /// can only contain text (`text`).
        /// 
        /// ![Message sent with user
        /// authentication](https://developers.google.com/workspace/chat/images/message-user-auth.svg)
        /// 
        /// The maximum message size, including the message contents, is 32,000 bytes.
        /// 
        /// For
        /// [webhook](https://developers.google.com/workspace/chat/quickstart/webhooks)
        /// requests, the response doesn't contain the full message. The response only
        /// populates the `name` and `thread.name` fields in addition to the
        /// information that was in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the space in which to create a message.
        /// 
        /// Format: `spaces/{space}`
        /// </param>
        /// <param name="message">
        /// Required. Message body.
        /// </param>
        /// <param name="messageId">
        /// Optional. A custom ID for a message. Lets Chat apps get, update, or delete
        /// a message without needing to store the system-assigned ID in the message's
        /// resource name (represented in the message `name` field).
        /// 
        /// The value for this field must meet the following requirements:
        /// 
        /// * Begins with `client-`. For example, `client-custom-name` is a valid
        /// custom ID, but `custom-name` is not.
        /// * Contains up to 63 characters and only lowercase letters, numbers, and
        /// hyphens.
        /// * Is unique within a space. A Chat app can't use the same custom ID for
        /// different messages.
        /// 
        /// For details, see [Name a
        /// message](https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Message CreateMessage(SpaceName parent, Message message, string messageId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMessage(new CreateMessageRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Message = gax::GaxPreconditions.CheckNotNull(message, nameof(message)),
                MessageId = messageId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a message in a Google Chat space. For an example, see [Send a
        /// message](https://developers.google.com/workspace/chat/create-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages.create`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// Chat attributes the message sender differently depending on the type of
        /// authentication that you use in your request.
        /// 
        /// The following image shows how Chat attributes a message when you use app
        /// authentication. Chat displays the Chat app as the message
        /// sender. The content of the message can contain text (`text`), cards
        /// (`cardsV2`), and accessory widgets (`accessoryWidgets`).
        /// 
        /// ![Message sent with app
        /// authentication](https://developers.google.com/workspace/chat/images/message-app-auth.svg)
        /// 
        /// The following image shows how Chat attributes a message when you use user
        /// authentication. Chat displays the user as the message sender and attributes
        /// the Chat app to the message by displaying its name. The content of message
        /// can only contain text (`text`).
        /// 
        /// ![Message sent with user
        /// authentication](https://developers.google.com/workspace/chat/images/message-user-auth.svg)
        /// 
        /// The maximum message size, including the message contents, is 32,000 bytes.
        /// 
        /// For
        /// [webhook](https://developers.google.com/workspace/chat/quickstart/webhooks)
        /// requests, the response doesn't contain the full message. The response only
        /// populates the `name` and `thread.name` fields in addition to the
        /// information that was in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the space in which to create a message.
        /// 
        /// Format: `spaces/{space}`
        /// </param>
        /// <param name="message">
        /// Required. Message body.
        /// </param>
        /// <param name="messageId">
        /// Optional. A custom ID for a message. Lets Chat apps get, update, or delete
        /// a message without needing to store the system-assigned ID in the message's
        /// resource name (represented in the message `name` field).
        /// 
        /// The value for this field must meet the following requirements:
        /// 
        /// * Begins with `client-`. For example, `client-custom-name` is a valid
        /// custom ID, but `custom-name` is not.
        /// * Contains up to 63 characters and only lowercase letters, numbers, and
        /// hyphens.
        /// * Is unique within a space. A Chat app can't use the same custom ID for
        /// different messages.
        /// 
        /// For details, see [Name a
        /// message](https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> CreateMessageAsync(SpaceName parent, Message message, string messageId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMessageAsync(new CreateMessageRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Message = gax::GaxPreconditions.CheckNotNull(message, nameof(message)),
                MessageId = messageId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a message in a Google Chat space. For an example, see [Send a
        /// message](https://developers.google.com/workspace/chat/create-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages.create`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// Chat attributes the message sender differently depending on the type of
        /// authentication that you use in your request.
        /// 
        /// The following image shows how Chat attributes a message when you use app
        /// authentication. Chat displays the Chat app as the message
        /// sender. The content of the message can contain text (`text`), cards
        /// (`cardsV2`), and accessory widgets (`accessoryWidgets`).
        /// 
        /// ![Message sent with app
        /// authentication](https://developers.google.com/workspace/chat/images/message-app-auth.svg)
        /// 
        /// The following image shows how Chat attributes a message when you use user
        /// authentication. Chat displays the user as the message sender and attributes
        /// the Chat app to the message by displaying its name. The content of message
        /// can only contain text (`text`).
        /// 
        /// ![Message sent with user
        /// authentication](https://developers.google.com/workspace/chat/images/message-user-auth.svg)
        /// 
        /// The maximum message size, including the message contents, is 32,000 bytes.
        /// 
        /// For
        /// [webhook](https://developers.google.com/workspace/chat/quickstart/webhooks)
        /// requests, the response doesn't contain the full message. The response only
        /// populates the `name` and `thread.name` fields in addition to the
        /// information that was in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the space in which to create a message.
        /// 
        /// Format: `spaces/{space}`
        /// </param>
        /// <param name="message">
        /// Required. Message body.
        /// </param>
        /// <param name="messageId">
        /// Optional. A custom ID for a message. Lets Chat apps get, update, or delete
        /// a message without needing to store the system-assigned ID in the message's
        /// resource name (represented in the message `name` field).
        /// 
        /// The value for this field must meet the following requirements:
        /// 
        /// * Begins with `client-`. For example, `client-custom-name` is a valid
        /// custom ID, but `custom-name` is not.
        /// * Contains up to 63 characters and only lowercase letters, numbers, and
        /// hyphens.
        /// * Is unique within a space. A Chat app can't use the same custom ID for
        /// different messages.
        /// 
        /// For details, see [Name a
        /// message](https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> CreateMessageAsync(SpaceName parent, Message message, string messageId, st::CancellationToken cancellationToken) =>
            CreateMessageAsync(parent, message, messageId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists messages in a space that the caller is a member of, including
        /// messages from blocked members and spaces. If you list messages from a
        /// space with no messages, the response is an empty object. When using a
        /// REST/HTTP interface, the response contains an empty JSON object, `{}`.
        /// For an example, see
        /// [List
        /// messages](https://developers.google.com/workspace/chat/api/guides/v1/messages/list).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Message"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMessagesResponse, Message> ListMessages(ListMessagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists messages in a space that the caller is a member of, including
        /// messages from blocked members and spaces. If you list messages from a
        /// space with no messages, the response is an empty object. When using a
        /// REST/HTTP interface, the response contains an empty JSON object, `{}`.
        /// For an example, see
        /// [List
        /// messages](https://developers.google.com/workspace/chat/api/guides/v1/messages/list).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Message"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMessagesResponse, Message> ListMessagesAsync(ListMessagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists messages in a space that the caller is a member of, including
        /// messages from blocked members and spaces. If you list messages from a
        /// space with no messages, the response is an empty object. When using a
        /// REST/HTTP interface, the response contains an empty JSON object, `{}`.
        /// For an example, see
        /// [List
        /// messages](https://developers.google.com/workspace/chat/api/guides/v1/messages/list).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the space to list messages from.
        /// 
        /// Format: `spaces/{space}`
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
        /// <returns>A pageable sequence of <see cref="Message"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMessagesResponse, Message> ListMessages(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMessagesRequest request = new ListMessagesRequest
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
            return ListMessages(request, callSettings);
        }

        /// <summary>
        /// Lists messages in a space that the caller is a member of, including
        /// messages from blocked members and spaces. If you list messages from a
        /// space with no messages, the response is an empty object. When using a
        /// REST/HTTP interface, the response contains an empty JSON object, `{}`.
        /// For an example, see
        /// [List
        /// messages](https://developers.google.com/workspace/chat/api/guides/v1/messages/list).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the space to list messages from.
        /// 
        /// Format: `spaces/{space}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Message"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMessagesResponse, Message> ListMessagesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMessagesRequest request = new ListMessagesRequest
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
            return ListMessagesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists messages in a space that the caller is a member of, including
        /// messages from blocked members and spaces. If you list messages from a
        /// space with no messages, the response is an empty object. When using a
        /// REST/HTTP interface, the response contains an empty JSON object, `{}`.
        /// For an example, see
        /// [List
        /// messages](https://developers.google.com/workspace/chat/api/guides/v1/messages/list).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the space to list messages from.
        /// 
        /// Format: `spaces/{space}`
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
        /// <returns>A pageable sequence of <see cref="Message"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMessagesResponse, Message> ListMessages(SpaceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMessagesRequest request = new ListMessagesRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMessages(request, callSettings);
        }

        /// <summary>
        /// Lists messages in a space that the caller is a member of, including
        /// messages from blocked members and spaces. If you list messages from a
        /// space with no messages, the response is an empty object. When using a
        /// REST/HTTP interface, the response contains an empty JSON object, `{}`.
        /// For an example, see
        /// [List
        /// messages](https://developers.google.com/workspace/chat/api/guides/v1/messages/list).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the space to list messages from.
        /// 
        /// Format: `spaces/{space}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Message"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMessagesResponse, Message> ListMessagesAsync(SpaceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMessagesRequest request = new ListMessagesRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMessagesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists memberships in a space. For an example, see [List users and Google
        /// Chat apps in a
        /// space](https://developers.google.com/workspace/chat/list-members). Listing
        /// memberships with [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// lists memberships in spaces that the Chat app has
        /// access to, but excludes Chat app memberships,
        /// including its own. Listing memberships with
        /// [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// lists memberships in spaces that the authenticated user has access to.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (requires
        /// [administrator approval](https://support.google.com/a?p=chat-app-auth))
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMembershipsResponse, Membership> ListMemberships(ListMembershipsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists memberships in a space. For an example, see [List users and Google
        /// Chat apps in a
        /// space](https://developers.google.com/workspace/chat/list-members). Listing
        /// memberships with [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// lists memberships in spaces that the Chat app has
        /// access to, but excludes Chat app memberships,
        /// including its own. Listing memberships with
        /// [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// lists memberships in spaces that the authenticated user has access to.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (requires
        /// [administrator approval](https://support.google.com/a?p=chat-app-auth))
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMembershipsResponse, Membership> ListMembershipsAsync(ListMembershipsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists memberships in a space. For an example, see [List users and Google
        /// Chat apps in a
        /// space](https://developers.google.com/workspace/chat/list-members). Listing
        /// memberships with [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// lists memberships in spaces that the Chat app has
        /// access to, but excludes Chat app memberships,
        /// including its own. Listing memberships with
        /// [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// lists memberships in spaces that the authenticated user has access to.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (requires
        /// [administrator approval](https://support.google.com/a?p=chat-app-auth))
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the space for which to fetch a membership
        /// list.
        /// 
        /// Format: spaces/{space}
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
        /// <returns>A pageable sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMembershipsResponse, Membership> ListMemberships(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembershipsRequest request = new ListMembershipsRequest
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
            return ListMemberships(request, callSettings);
        }

        /// <summary>
        /// Lists memberships in a space. For an example, see [List users and Google
        /// Chat apps in a
        /// space](https://developers.google.com/workspace/chat/list-members). Listing
        /// memberships with [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// lists memberships in spaces that the Chat app has
        /// access to, but excludes Chat app memberships,
        /// including its own. Listing memberships with
        /// [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// lists memberships in spaces that the authenticated user has access to.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (requires
        /// [administrator approval](https://support.google.com/a?p=chat-app-auth))
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the space for which to fetch a membership
        /// list.
        /// 
        /// Format: spaces/{space}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMembershipsResponse, Membership> ListMembershipsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembershipsRequest request = new ListMembershipsRequest
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
            return ListMembershipsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists memberships in a space. For an example, see [List users and Google
        /// Chat apps in a
        /// space](https://developers.google.com/workspace/chat/list-members). Listing
        /// memberships with [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// lists memberships in spaces that the Chat app has
        /// access to, but excludes Chat app memberships,
        /// including its own. Listing memberships with
        /// [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// lists memberships in spaces that the authenticated user has access to.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (requires
        /// [administrator approval](https://support.google.com/a?p=chat-app-auth))
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the space for which to fetch a membership
        /// list.
        /// 
        /// Format: spaces/{space}
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
        /// <returns>A pageable sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMembershipsResponse, Membership> ListMemberships(SpaceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembershipsRequest request = new ListMembershipsRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMemberships(request, callSettings);
        }

        /// <summary>
        /// Lists memberships in a space. For an example, see [List users and Google
        /// Chat apps in a
        /// space](https://developers.google.com/workspace/chat/list-members). Listing
        /// memberships with [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// lists memberships in spaces that the Chat app has
        /// access to, but excludes Chat app memberships,
        /// including its own. Listing memberships with
        /// [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// lists memberships in spaces that the authenticated user has access to.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (requires
        /// [administrator approval](https://support.google.com/a?p=chat-app-auth))
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the space for which to fetch a membership
        /// list.
        /// 
        /// Format: spaces/{space}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Membership"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMembershipsResponse, Membership> ListMembershipsAsync(SpaceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMembershipsRequest request = new ListMembershipsRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMembershipsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns details about a membership. For an example, see
        /// [Get details about a user's or Google Chat app's
        /// membership](https://developers.google.com/workspace/chat/get-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (requires
        /// [administrator approval](https://support.google.com/a?p=chat-app-auth))
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Membership GetMembership(GetMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns details about a membership. For an example, see
        /// [Get details about a user's or Google Chat app's
        /// membership](https://developers.google.com/workspace/chat/get-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (requires
        /// [administrator approval](https://support.google.com/a?p=chat-app-auth))
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> GetMembershipAsync(GetMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns details about a membership. For an example, see
        /// [Get details about a user's or Google Chat app's
        /// membership](https://developers.google.com/workspace/chat/get-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (requires
        /// [administrator approval](https://support.google.com/a?p=chat-app-auth))
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> GetMembershipAsync(GetMembershipRequest request, st::CancellationToken cancellationToken) =>
            GetMembershipAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns details about a membership. For an example, see
        /// [Get details about a user's or Google Chat app's
        /// membership](https://developers.google.com/workspace/chat/get-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (requires
        /// [administrator approval](https://support.google.com/a?p=chat-app-auth))
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the membership to retrieve.
        /// 
        /// To get the app's own membership [by using user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user),
        /// you can optionally use `spaces/{space}/members/app`.
        /// 
        /// Format: `spaces/{space}/members/{member}` or `spaces/{space}/members/app`
        /// 
        /// You can use the user's email as an alias for `{member}`. For example,
        /// `spaces/{space}/members/example@gmail.com` where `example@gmail.com` is the
        /// email of the Google Chat user.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Membership GetMembership(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMembership(new GetMembershipRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details about a membership. For an example, see
        /// [Get details about a user's or Google Chat app's
        /// membership](https://developers.google.com/workspace/chat/get-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (requires
        /// [administrator approval](https://support.google.com/a?p=chat-app-auth))
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the membership to retrieve.
        /// 
        /// To get the app's own membership [by using user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user),
        /// you can optionally use `spaces/{space}/members/app`.
        /// 
        /// Format: `spaces/{space}/members/{member}` or `spaces/{space}/members/app`
        /// 
        /// You can use the user's email as an alias for `{member}`. For example,
        /// `spaces/{space}/members/example@gmail.com` where `example@gmail.com` is the
        /// email of the Google Chat user.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> GetMembershipAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMembershipAsync(new GetMembershipRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details about a membership. For an example, see
        /// [Get details about a user's or Google Chat app's
        /// membership](https://developers.google.com/workspace/chat/get-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (requires
        /// [administrator approval](https://support.google.com/a?p=chat-app-auth))
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the membership to retrieve.
        /// 
        /// To get the app's own membership [by using user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user),
        /// you can optionally use `spaces/{space}/members/app`.
        /// 
        /// Format: `spaces/{space}/members/{member}` or `spaces/{space}/members/app`
        /// 
        /// You can use the user's email as an alias for `{member}`. For example,
        /// `spaces/{space}/members/example@gmail.com` where `example@gmail.com` is the
        /// email of the Google Chat user.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> GetMembershipAsync(string name, st::CancellationToken cancellationToken) =>
            GetMembershipAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns details about a membership. For an example, see
        /// [Get details about a user's or Google Chat app's
        /// membership](https://developers.google.com/workspace/chat/get-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (requires
        /// [administrator approval](https://support.google.com/a?p=chat-app-auth))
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the membership to retrieve.
        /// 
        /// To get the app's own membership [by using user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user),
        /// you can optionally use `spaces/{space}/members/app`.
        /// 
        /// Format: `spaces/{space}/members/{member}` or `spaces/{space}/members/app`
        /// 
        /// You can use the user's email as an alias for `{member}`. For example,
        /// `spaces/{space}/members/example@gmail.com` where `example@gmail.com` is the
        /// email of the Google Chat user.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Membership GetMembership(MembershipName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMembership(new GetMembershipRequest
            {
                MembershipName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details about a membership. For an example, see
        /// [Get details about a user's or Google Chat app's
        /// membership](https://developers.google.com/workspace/chat/get-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (requires
        /// [administrator approval](https://support.google.com/a?p=chat-app-auth))
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the membership to retrieve.
        /// 
        /// To get the app's own membership [by using user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user),
        /// you can optionally use `spaces/{space}/members/app`.
        /// 
        /// Format: `spaces/{space}/members/{member}` or `spaces/{space}/members/app`
        /// 
        /// You can use the user's email as an alias for `{member}`. For example,
        /// `spaces/{space}/members/example@gmail.com` where `example@gmail.com` is the
        /// email of the Google Chat user.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> GetMembershipAsync(MembershipName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMembershipAsync(new GetMembershipRequest
            {
                MembershipName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details about a membership. For an example, see
        /// [Get details about a user's or Google Chat app's
        /// membership](https://developers.google.com/workspace/chat/get-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (requires
        /// [administrator approval](https://support.google.com/a?p=chat-app-auth))
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the membership to retrieve.
        /// 
        /// To get the app's own membership [by using user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user),
        /// you can optionally use `spaces/{space}/members/app`.
        /// 
        /// Format: `spaces/{space}/members/{member}` or `spaces/{space}/members/app`
        /// 
        /// You can use the user's email as an alias for `{member}`. For example,
        /// `spaces/{space}/members/example@gmail.com` where `example@gmail.com` is the
        /// email of the Google Chat user.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> GetMembershipAsync(MembershipName name, st::CancellationToken cancellationToken) =>
            GetMembershipAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns details about a message.
        /// For an example, see [Get details about a
        /// message](https://developers.google.com/workspace/chat/get-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// 
        /// Note: Might return a message from a blocked member or space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Message GetMessage(GetMessageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns details about a message.
        /// For an example, see [Get details about a
        /// message](https://developers.google.com/workspace/chat/get-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// 
        /// Note: Might return a message from a blocked member or space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> GetMessageAsync(GetMessageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns details about a message.
        /// For an example, see [Get details about a
        /// message](https://developers.google.com/workspace/chat/get-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// 
        /// Note: Might return a message from a blocked member or space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> GetMessageAsync(GetMessageRequest request, st::CancellationToken cancellationToken) =>
            GetMessageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns details about a message.
        /// For an example, see [Get details about a
        /// message](https://developers.google.com/workspace/chat/get-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// 
        /// Note: Might return a message from a blocked member or space.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the message.
        /// 
        /// Format: `spaces/{space}/messages/{message}`
        /// 
        /// If you've set a custom ID for your message, you can use the value from the
        /// `clientAssignedMessageId` field for `{message}`. For details, see [Name a
        /// message]
        /// (https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Message GetMessage(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMessage(new GetMessageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details about a message.
        /// For an example, see [Get details about a
        /// message](https://developers.google.com/workspace/chat/get-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// 
        /// Note: Might return a message from a blocked member or space.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the message.
        /// 
        /// Format: `spaces/{space}/messages/{message}`
        /// 
        /// If you've set a custom ID for your message, you can use the value from the
        /// `clientAssignedMessageId` field for `{message}`. For details, see [Name a
        /// message]
        /// (https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> GetMessageAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMessageAsync(new GetMessageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details about a message.
        /// For an example, see [Get details about a
        /// message](https://developers.google.com/workspace/chat/get-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// 
        /// Note: Might return a message from a blocked member or space.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the message.
        /// 
        /// Format: `spaces/{space}/messages/{message}`
        /// 
        /// If you've set a custom ID for your message, you can use the value from the
        /// `clientAssignedMessageId` field for `{message}`. For details, see [Name a
        /// message]
        /// (https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> GetMessageAsync(string name, st::CancellationToken cancellationToken) =>
            GetMessageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns details about a message.
        /// For an example, see [Get details about a
        /// message](https://developers.google.com/workspace/chat/get-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// 
        /// Note: Might return a message from a blocked member or space.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the message.
        /// 
        /// Format: `spaces/{space}/messages/{message}`
        /// 
        /// If you've set a custom ID for your message, you can use the value from the
        /// `clientAssignedMessageId` field for `{message}`. For details, see [Name a
        /// message]
        /// (https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Message GetMessage(MessageName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMessage(new GetMessageRequest
            {
                MessageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details about a message.
        /// For an example, see [Get details about a
        /// message](https://developers.google.com/workspace/chat/get-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// 
        /// Note: Might return a message from a blocked member or space.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the message.
        /// 
        /// Format: `spaces/{space}/messages/{message}`
        /// 
        /// If you've set a custom ID for your message, you can use the value from the
        /// `clientAssignedMessageId` field for `{message}`. For details, see [Name a
        /// message]
        /// (https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> GetMessageAsync(MessageName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMessageAsync(new GetMessageRequest
            {
                MessageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details about a message.
        /// For an example, see [Get details about a
        /// message](https://developers.google.com/workspace/chat/get-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// 
        /// Note: Might return a message from a blocked member or space.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the message.
        /// 
        /// Format: `spaces/{space}/messages/{message}`
        /// 
        /// If you've set a custom ID for your message, you can use the value from the
        /// `clientAssignedMessageId` field for `{message}`. For details, see [Name a
        /// message]
        /// (https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> GetMessageAsync(MessageName name, st::CancellationToken cancellationToken) =>
            GetMessageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a message. There's a difference between the `patch` and `update`
        /// methods. The `patch`
        /// method uses a `patch` request while the `update` method uses a `put`
        /// request. We recommend using the `patch` method. For an example, see
        /// [Update a
        /// message](https://developers.google.com/workspace/chat/update-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When using app authentication, requests can only update messages
        /// created by the calling Chat app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Message UpdateMessage(UpdateMessageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a message. There's a difference between the `patch` and `update`
        /// methods. The `patch`
        /// method uses a `patch` request while the `update` method uses a `put`
        /// request. We recommend using the `patch` method. For an example, see
        /// [Update a
        /// message](https://developers.google.com/workspace/chat/update-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When using app authentication, requests can only update messages
        /// created by the calling Chat app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> UpdateMessageAsync(UpdateMessageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a message. There's a difference between the `patch` and `update`
        /// methods. The `patch`
        /// method uses a `patch` request while the `update` method uses a `put`
        /// request. We recommend using the `patch` method. For an example, see
        /// [Update a
        /// message](https://developers.google.com/workspace/chat/update-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When using app authentication, requests can only update messages
        /// created by the calling Chat app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> UpdateMessageAsync(UpdateMessageRequest request, st::CancellationToken cancellationToken) =>
            UpdateMessageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a message. There's a difference between the `patch` and `update`
        /// methods. The `patch`
        /// method uses a `patch` request while the `update` method uses a `put`
        /// request. We recommend using the `patch` method. For an example, see
        /// [Update a
        /// message](https://developers.google.com/workspace/chat/update-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When using app authentication, requests can only update messages
        /// created by the calling Chat app.
        /// </summary>
        /// <param name="message">
        /// Required. Message with fields updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field paths to update. Separate multiple values with commas
        /// or use `*` to update all field paths.
        /// 
        /// Currently supported field paths:
        /// 
        /// - `text`
        /// 
        /// - `attachment`
        /// 
        /// - `cards` (Requires [app
        /// authentication](/chat/api/guides/auth/service-accounts).)
        /// 
        /// - `cards_v2`  (Requires [app
        /// authentication](/chat/api/guides/auth/service-accounts).)
        /// 
        /// - `accessory_widgets`  (Requires [app
        /// authentication](/chat/api/guides/auth/service-accounts).)
        /// 
        /// - `quoted_message_metadata` (Only allows removal of the quoted message.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Message UpdateMessage(Message message, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMessage(new UpdateMessageRequest
            {
                Message = gax::GaxPreconditions.CheckNotNull(message, nameof(message)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a message. There's a difference between the `patch` and `update`
        /// methods. The `patch`
        /// method uses a `patch` request while the `update` method uses a `put`
        /// request. We recommend using the `patch` method. For an example, see
        /// [Update a
        /// message](https://developers.google.com/workspace/chat/update-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When using app authentication, requests can only update messages
        /// created by the calling Chat app.
        /// </summary>
        /// <param name="message">
        /// Required. Message with fields updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field paths to update. Separate multiple values with commas
        /// or use `*` to update all field paths.
        /// 
        /// Currently supported field paths:
        /// 
        /// - `text`
        /// 
        /// - `attachment`
        /// 
        /// - `cards` (Requires [app
        /// authentication](/chat/api/guides/auth/service-accounts).)
        /// 
        /// - `cards_v2`  (Requires [app
        /// authentication](/chat/api/guides/auth/service-accounts).)
        /// 
        /// - `accessory_widgets`  (Requires [app
        /// authentication](/chat/api/guides/auth/service-accounts).)
        /// 
        /// - `quoted_message_metadata` (Only allows removal of the quoted message.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> UpdateMessageAsync(Message message, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMessageAsync(new UpdateMessageRequest
            {
                Message = gax::GaxPreconditions.CheckNotNull(message, nameof(message)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a message. There's a difference between the `patch` and `update`
        /// methods. The `patch`
        /// method uses a `patch` request while the `update` method uses a `put`
        /// request. We recommend using the `patch` method. For an example, see
        /// [Update a
        /// message](https://developers.google.com/workspace/chat/update-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When using app authentication, requests can only update messages
        /// created by the calling Chat app.
        /// </summary>
        /// <param name="message">
        /// Required. Message with fields updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field paths to update. Separate multiple values with commas
        /// or use `*` to update all field paths.
        /// 
        /// Currently supported field paths:
        /// 
        /// - `text`
        /// 
        /// - `attachment`
        /// 
        /// - `cards` (Requires [app
        /// authentication](/chat/api/guides/auth/service-accounts).)
        /// 
        /// - `cards_v2`  (Requires [app
        /// authentication](/chat/api/guides/auth/service-accounts).)
        /// 
        /// - `accessory_widgets`  (Requires [app
        /// authentication](/chat/api/guides/auth/service-accounts).)
        /// 
        /// - `quoted_message_metadata` (Only allows removal of the quoted message.)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Message> UpdateMessageAsync(Message message, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMessageAsync(message, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a message.
        /// For an example, see [Delete a
        /// message](https://developers.google.com/workspace/chat/delete-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When using app authentication, requests can only delete messages
        /// created by the calling Chat app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMessage(DeleteMessageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a message.
        /// For an example, see [Delete a
        /// message](https://developers.google.com/workspace/chat/delete-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When using app authentication, requests can only delete messages
        /// created by the calling Chat app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMessageAsync(DeleteMessageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a message.
        /// For an example, see [Delete a
        /// message](https://developers.google.com/workspace/chat/delete-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When using app authentication, requests can only delete messages
        /// created by the calling Chat app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMessageAsync(DeleteMessageRequest request, st::CancellationToken cancellationToken) =>
            DeleteMessageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a message.
        /// For an example, see [Delete a
        /// message](https://developers.google.com/workspace/chat/delete-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When using app authentication, requests can only delete messages
        /// created by the calling Chat app.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the message.
        /// 
        /// Format: `spaces/{space}/messages/{message}`
        /// 
        /// If you've set a custom ID for your message, you can use the value from the
        /// `clientAssignedMessageId` field for `{message}`. For details, see [Name a
        /// message]
        /// (https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMessage(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMessage(new DeleteMessageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a message.
        /// For an example, see [Delete a
        /// message](https://developers.google.com/workspace/chat/delete-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When using app authentication, requests can only delete messages
        /// created by the calling Chat app.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the message.
        /// 
        /// Format: `spaces/{space}/messages/{message}`
        /// 
        /// If you've set a custom ID for your message, you can use the value from the
        /// `clientAssignedMessageId` field for `{message}`. For details, see [Name a
        /// message]
        /// (https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMessageAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMessageAsync(new DeleteMessageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a message.
        /// For an example, see [Delete a
        /// message](https://developers.google.com/workspace/chat/delete-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When using app authentication, requests can only delete messages
        /// created by the calling Chat app.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the message.
        /// 
        /// Format: `spaces/{space}/messages/{message}`
        /// 
        /// If you've set a custom ID for your message, you can use the value from the
        /// `clientAssignedMessageId` field for `{message}`. For details, see [Name a
        /// message]
        /// (https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMessageAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMessageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a message.
        /// For an example, see [Delete a
        /// message](https://developers.google.com/workspace/chat/delete-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When using app authentication, requests can only delete messages
        /// created by the calling Chat app.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the message.
        /// 
        /// Format: `spaces/{space}/messages/{message}`
        /// 
        /// If you've set a custom ID for your message, you can use the value from the
        /// `clientAssignedMessageId` field for `{message}`. For details, see [Name a
        /// message]
        /// (https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMessage(MessageName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMessage(new DeleteMessageRequest
            {
                MessageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a message.
        /// For an example, see [Delete a
        /// message](https://developers.google.com/workspace/chat/delete-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When using app authentication, requests can only delete messages
        /// created by the calling Chat app.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the message.
        /// 
        /// Format: `spaces/{space}/messages/{message}`
        /// 
        /// If you've set a custom ID for your message, you can use the value from the
        /// `clientAssignedMessageId` field for `{message}`. For details, see [Name a
        /// message]
        /// (https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMessageAsync(MessageName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMessageAsync(new DeleteMessageRequest
            {
                MessageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a message.
        /// For an example, see [Delete a
        /// message](https://developers.google.com/workspace/chat/delete-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When using app authentication, requests can only delete messages
        /// created by the calling Chat app.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the message.
        /// 
        /// Format: `spaces/{space}/messages/{message}`
        /// 
        /// If you've set a custom ID for your message, you can use the value from the
        /// `clientAssignedMessageId` field for `{message}`. For details, see [Name a
        /// message]
        /// (https://developers.google.com/workspace/chat/create-messages#name_a_created_message).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMessageAsync(MessageName name, st::CancellationToken cancellationToken) =>
            DeleteMessageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the metadata of a message attachment. The attachment data is fetched
        /// using the [media
        /// API](https://developers.google.com/workspace/chat/api/reference/rest/v1/media/download).
        /// For an example, see
        /// [Get metadata about a message
        /// attachment](https://developers.google.com/workspace/chat/get-media-attachments).
        /// 
        /// Requires [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Attachment GetAttachment(GetAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the metadata of a message attachment. The attachment data is fetched
        /// using the [media
        /// API](https://developers.google.com/workspace/chat/api/reference/rest/v1/media/download).
        /// For an example, see
        /// [Get metadata about a message
        /// attachment](https://developers.google.com/workspace/chat/get-media-attachments).
        /// 
        /// Requires [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attachment> GetAttachmentAsync(GetAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the metadata of a message attachment. The attachment data is fetched
        /// using the [media
        /// API](https://developers.google.com/workspace/chat/api/reference/rest/v1/media/download).
        /// For an example, see
        /// [Get metadata about a message
        /// attachment](https://developers.google.com/workspace/chat/get-media-attachments).
        /// 
        /// Requires [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attachment> GetAttachmentAsync(GetAttachmentRequest request, st::CancellationToken cancellationToken) =>
            GetAttachmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the metadata of a message attachment. The attachment data is fetched
        /// using the [media
        /// API](https://developers.google.com/workspace/chat/api/reference/rest/v1/media/download).
        /// For an example, see
        /// [Get metadata about a message
        /// attachment](https://developers.google.com/workspace/chat/get-media-attachments).
        /// 
        /// Requires [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the attachment, in the form
        /// `spaces/{space}/messages/{message}/attachments/{attachment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Attachment GetAttachment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttachment(new GetAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the metadata of a message attachment. The attachment data is fetched
        /// using the [media
        /// API](https://developers.google.com/workspace/chat/api/reference/rest/v1/media/download).
        /// For an example, see
        /// [Get metadata about a message
        /// attachment](https://developers.google.com/workspace/chat/get-media-attachments).
        /// 
        /// Requires [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the attachment, in the form
        /// `spaces/{space}/messages/{message}/attachments/{attachment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attachment> GetAttachmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttachmentAsync(new GetAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the metadata of a message attachment. The attachment data is fetched
        /// using the [media
        /// API](https://developers.google.com/workspace/chat/api/reference/rest/v1/media/download).
        /// For an example, see
        /// [Get metadata about a message
        /// attachment](https://developers.google.com/workspace/chat/get-media-attachments).
        /// 
        /// Requires [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the attachment, in the form
        /// `spaces/{space}/messages/{message}/attachments/{attachment}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attachment> GetAttachmentAsync(string name, st::CancellationToken cancellationToken) =>
            GetAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the metadata of a message attachment. The attachment data is fetched
        /// using the [media
        /// API](https://developers.google.com/workspace/chat/api/reference/rest/v1/media/download).
        /// For an example, see
        /// [Get metadata about a message
        /// attachment](https://developers.google.com/workspace/chat/get-media-attachments).
        /// 
        /// Requires [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the attachment, in the form
        /// `spaces/{space}/messages/{message}/attachments/{attachment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Attachment GetAttachment(AttachmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttachment(new GetAttachmentRequest
            {
                AttachmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the metadata of a message attachment. The attachment data is fetched
        /// using the [media
        /// API](https://developers.google.com/workspace/chat/api/reference/rest/v1/media/download).
        /// For an example, see
        /// [Get metadata about a message
        /// attachment](https://developers.google.com/workspace/chat/get-media-attachments).
        /// 
        /// Requires [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the attachment, in the form
        /// `spaces/{space}/messages/{message}/attachments/{attachment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attachment> GetAttachmentAsync(AttachmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAttachmentAsync(new GetAttachmentRequest
            {
                AttachmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the metadata of a message attachment. The attachment data is fetched
        /// using the [media
        /// API](https://developers.google.com/workspace/chat/api/reference/rest/v1/media/download).
        /// For an example, see
        /// [Get metadata about a message
        /// attachment](https://developers.google.com/workspace/chat/get-media-attachments).
        /// 
        /// Requires [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the attachment, in the form
        /// `spaces/{space}/messages/{message}/attachments/{attachment}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Attachment> GetAttachmentAsync(AttachmentName name, st::CancellationToken cancellationToken) =>
            GetAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Uploads an attachment. For an example, see
        /// [Upload media as a file
        /// attachment](https://developers.google.com/workspace/chat/upload-media-attachments).
        /// 
        /// Requires user
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.create`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// 
        /// You can upload attachments up to 200 MB. Certain file types aren't
        /// supported. For details, see [File types blocked by Google
        /// Chat](https://support.google.com/chat/answer/7651457?&amp;co=GENIE.Platform%3DDesktop#File%20types%20blocked%20in%20Google%20Chat).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UploadAttachmentResponse UploadAttachment(UploadAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads an attachment. For an example, see
        /// [Upload media as a file
        /// attachment](https://developers.google.com/workspace/chat/upload-media-attachments).
        /// 
        /// Requires user
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.create`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// 
        /// You can upload attachments up to 200 MB. Certain file types aren't
        /// supported. For details, see [File types blocked by Google
        /// Chat](https://support.google.com/chat/answer/7651457?&amp;co=GENIE.Platform%3DDesktop#File%20types%20blocked%20in%20Google%20Chat).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadAttachmentResponse> UploadAttachmentAsync(UploadAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads an attachment. For an example, see
        /// [Upload media as a file
        /// attachment](https://developers.google.com/workspace/chat/upload-media-attachments).
        /// 
        /// Requires user
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.create`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// 
        /// You can upload attachments up to 200 MB. Certain file types aren't
        /// supported. For details, see [File types blocked by Google
        /// Chat](https://support.google.com/chat/answer/7651457?&amp;co=GENIE.Platform%3DDesktop#File%20types%20blocked%20in%20Google%20Chat).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadAttachmentResponse> UploadAttachmentAsync(UploadAttachmentRequest request, st::CancellationToken cancellationToken) =>
            UploadAttachmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists spaces the caller is a member of. Group chats and DMs aren't listed
        /// until the first message is sent. For an example, see
        /// [List
        /// spaces](https://developers.google.com/workspace/chat/list-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// 
        /// To list all named spaces by Google Workspace organization, use the
        /// [`spaces.search()`](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces/search)
        /// method using Workspace administrator privileges instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Space"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSpacesResponse, Space> ListSpaces(ListSpacesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists spaces the caller is a member of. Group chats and DMs aren't listed
        /// until the first message is sent. For an example, see
        /// [List
        /// spaces](https://developers.google.com/workspace/chat/list-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// 
        /// To list all named spaces by Google Workspace organization, use the
        /// [`spaces.search()`](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces/search)
        /// method using Workspace administrator privileges instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Space"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSpacesResponse, Space> ListSpacesAsync(ListSpacesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists spaces the caller is a member of. Group chats and DMs aren't listed
        /// until the first message is sent. For an example, see
        /// [List
        /// spaces](https://developers.google.com/workspace/chat/list-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// 
        /// To list all named spaces by Google Workspace organization, use the
        /// [`spaces.search()`](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces/search)
        /// method using Workspace administrator privileges instead.
        /// </summary>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Space"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSpacesResponse, Space> ListSpaces(string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpacesRequest request = new ListSpacesRequest { };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSpaces(request, callSettings);
        }

        /// <summary>
        /// Lists spaces the caller is a member of. Group chats and DMs aren't listed
        /// until the first message is sent. For an example, see
        /// [List
        /// spaces](https://developers.google.com/workspace/chat/list-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// 
        /// To list all named spaces by Google Workspace organization, use the
        /// [`spaces.search()`](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces/search)
        /// method using Workspace administrator privileges instead.
        /// </summary>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Space"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSpacesResponse, Space> ListSpacesAsync(string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpacesRequest request = new ListSpacesRequest { };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSpacesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of spaces in a Google Workspace organization based on an
        /// administrator's search.
        /// 
        /// Requires [user
        /// authentication with administrator
        /// privileges](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user#admin-privileges)
        /// and one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.admin.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.spaces`
        /// 
        /// In the request, set `use_admin_access` to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Space"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchSpacesResponse, Space> SearchSpaces(SearchSpacesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of spaces in a Google Workspace organization based on an
        /// administrator's search.
        /// 
        /// Requires [user
        /// authentication with administrator
        /// privileges](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user#admin-privileges)
        /// and one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.admin.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.spaces`
        /// 
        /// In the request, set `use_admin_access` to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Space"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchSpacesResponse, Space> SearchSpacesAsync(SearchSpacesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of spaces in a Google Workspace organization based on an
        /// administrator's search.
        /// 
        /// Requires [user
        /// authentication with administrator
        /// privileges](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user#admin-privileges)
        /// and one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.admin.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.spaces`
        /// 
        /// In the request, set `use_admin_access` to `true`.
        /// </summary>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Space"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchSpacesResponse, Space> SearchSpaces(string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchSpacesRequest request = new SearchSpacesRequest { };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchSpaces(request, callSettings);
        }

        /// <summary>
        /// Returns a list of spaces in a Google Workspace organization based on an
        /// administrator's search.
        /// 
        /// Requires [user
        /// authentication with administrator
        /// privileges](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user#admin-privileges)
        /// and one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.admin.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.spaces`
        /// 
        /// In the request, set `use_admin_access` to `true`.
        /// </summary>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Space"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchSpacesResponse, Space> SearchSpacesAsync(string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchSpacesRequest request = new SearchSpacesRequest { };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchSpacesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns details about a space. For an example, see
        /// [Get details about a
        /// space](https://developers.google.com/workspace/chat/get-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.spaces` with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.spaces`
        /// 
        /// App authentication has the following limitations:
        /// 
        /// - `space.access_settings` is only populated when using the
        /// `chat.app.spaces` scope.
        /// - `space.predefind_permission_settings` and `space.permission_settings` are
        /// only populated when using the `chat.app.spaces` scope, and only for
        /// spaces the app created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Space GetSpace(GetSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns details about a space. For an example, see
        /// [Get details about a
        /// space](https://developers.google.com/workspace/chat/get-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.spaces` with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.spaces`
        /// 
        /// App authentication has the following limitations:
        /// 
        /// - `space.access_settings` is only populated when using the
        /// `chat.app.spaces` scope.
        /// - `space.predefind_permission_settings` and `space.permission_settings` are
        /// only populated when using the `chat.app.spaces` scope, and only for
        /// spaces the app created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> GetSpaceAsync(GetSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns details about a space. For an example, see
        /// [Get details about a
        /// space](https://developers.google.com/workspace/chat/get-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.spaces` with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.spaces`
        /// 
        /// App authentication has the following limitations:
        /// 
        /// - `space.access_settings` is only populated when using the
        /// `chat.app.spaces` scope.
        /// - `space.predefind_permission_settings` and `space.permission_settings` are
        /// only populated when using the `chat.app.spaces` scope, and only for
        /// spaces the app created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> GetSpaceAsync(GetSpaceRequest request, st::CancellationToken cancellationToken) =>
            GetSpaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns details about a space. For an example, see
        /// [Get details about a
        /// space](https://developers.google.com/workspace/chat/get-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.spaces` with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.spaces`
        /// 
        /// App authentication has the following limitations:
        /// 
        /// - `space.access_settings` is only populated when using the
        /// `chat.app.spaces` scope.
        /// - `space.predefind_permission_settings` and `space.permission_settings` are
        /// only populated when using the `chat.app.spaces` scope, and only for
        /// spaces the app created.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space, in the form `spaces/{space}`.
        /// 
        /// Format: `spaces/{space}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Space GetSpace(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpace(new GetSpaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details about a space. For an example, see
        /// [Get details about a
        /// space](https://developers.google.com/workspace/chat/get-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.spaces` with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.spaces`
        /// 
        /// App authentication has the following limitations:
        /// 
        /// - `space.access_settings` is only populated when using the
        /// `chat.app.spaces` scope.
        /// - `space.predefind_permission_settings` and `space.permission_settings` are
        /// only populated when using the `chat.app.spaces` scope, and only for
        /// spaces the app created.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space, in the form `spaces/{space}`.
        /// 
        /// Format: `spaces/{space}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> GetSpaceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpaceAsync(new GetSpaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details about a space. For an example, see
        /// [Get details about a
        /// space](https://developers.google.com/workspace/chat/get-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.spaces` with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.spaces`
        /// 
        /// App authentication has the following limitations:
        /// 
        /// - `space.access_settings` is only populated when using the
        /// `chat.app.spaces` scope.
        /// - `space.predefind_permission_settings` and `space.permission_settings` are
        /// only populated when using the `chat.app.spaces` scope, and only for
        /// spaces the app created.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space, in the form `spaces/{space}`.
        /// 
        /// Format: `spaces/{space}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> GetSpaceAsync(string name, st::CancellationToken cancellationToken) =>
            GetSpaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns details about a space. For an example, see
        /// [Get details about a
        /// space](https://developers.google.com/workspace/chat/get-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.spaces` with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.spaces`
        /// 
        /// App authentication has the following limitations:
        /// 
        /// - `space.access_settings` is only populated when using the
        /// `chat.app.spaces` scope.
        /// - `space.predefind_permission_settings` and `space.permission_settings` are
        /// only populated when using the `chat.app.spaces` scope, and only for
        /// spaces the app created.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space, in the form `spaces/{space}`.
        /// 
        /// Format: `spaces/{space}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Space GetSpace(SpaceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpace(new GetSpaceRequest
            {
                SpaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details about a space. For an example, see
        /// [Get details about a
        /// space](https://developers.google.com/workspace/chat/get-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.spaces` with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.spaces`
        /// 
        /// App authentication has the following limitations:
        /// 
        /// - `space.access_settings` is only populated when using the
        /// `chat.app.spaces` scope.
        /// - `space.predefind_permission_settings` and `space.permission_settings` are
        /// only populated when using the `chat.app.spaces` scope, and only for
        /// spaces the app created.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space, in the form `spaces/{space}`.
        /// 
        /// Format: `spaces/{space}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> GetSpaceAsync(SpaceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpaceAsync(new GetSpaceRequest
            {
                SpaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details about a space. For an example, see
        /// [Get details about a
        /// space](https://developers.google.com/workspace/chat/get-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.spaces` with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.spaces`
        /// 
        /// App authentication has the following limitations:
        /// 
        /// - `space.access_settings` is only populated when using the
        /// `chat.app.spaces` scope.
        /// - `space.predefind_permission_settings` and `space.permission_settings` are
        /// only populated when using the `chat.app.spaces` scope, and only for
        /// spaces the app created.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space, in the form `spaces/{space}`.
        /// 
        /// Format: `spaces/{space}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> GetSpaceAsync(SpaceName name, st::CancellationToken cancellationToken) =>
            GetSpaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a space. Can be used to create a named space, or a
        /// group chat in `Import mode`. For an example, see [Create a
        /// space](https://developers.google.com/workspace/chat/create-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.app.spaces.create`
        /// - `https://www.googleapis.com/auth/chat.app.spaces`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.create`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When authenticating as an app, the `space.customer` field must be set in
        /// the request.
        /// 
        /// When authenticating as an app, the Chat app is added as a member of the
        /// space. However, unlike human authentication, the Chat app is not added as a
        /// space manager. By default, the Chat app can be removed from the space by
        /// all space members. To allow only space managers to remove the app from a
        /// space, set `space.permission_settings.manage_apps` to `managers_allowed`.
        /// 
        /// Space membership upon creation depends on whether the space is created in
        /// `Import mode`:
        /// 
        /// * **Import mode:** No members are created.
        /// * **All other modes:**  The calling user is added as a member. This is:
        /// * The app itself when using app authentication.
        /// * The human user when using user authentication.
        /// 
        /// If you receive the error message `ALREADY_EXISTS` when creating
        /// a space, try a different `displayName`. An existing space within
        /// the Google Workspace organization might already use this display name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Space CreateSpace(CreateSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a space. Can be used to create a named space, or a
        /// group chat in `Import mode`. For an example, see [Create a
        /// space](https://developers.google.com/workspace/chat/create-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.app.spaces.create`
        /// - `https://www.googleapis.com/auth/chat.app.spaces`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.create`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When authenticating as an app, the `space.customer` field must be set in
        /// the request.
        /// 
        /// When authenticating as an app, the Chat app is added as a member of the
        /// space. However, unlike human authentication, the Chat app is not added as a
        /// space manager. By default, the Chat app can be removed from the space by
        /// all space members. To allow only space managers to remove the app from a
        /// space, set `space.permission_settings.manage_apps` to `managers_allowed`.
        /// 
        /// Space membership upon creation depends on whether the space is created in
        /// `Import mode`:
        /// 
        /// * **Import mode:** No members are created.
        /// * **All other modes:**  The calling user is added as a member. This is:
        /// * The app itself when using app authentication.
        /// * The human user when using user authentication.
        /// 
        /// If you receive the error message `ALREADY_EXISTS` when creating
        /// a space, try a different `displayName`. An existing space within
        /// the Google Workspace organization might already use this display name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> CreateSpaceAsync(CreateSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a space. Can be used to create a named space, or a
        /// group chat in `Import mode`. For an example, see [Create a
        /// space](https://developers.google.com/workspace/chat/create-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.app.spaces.create`
        /// - `https://www.googleapis.com/auth/chat.app.spaces`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.create`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When authenticating as an app, the `space.customer` field must be set in
        /// the request.
        /// 
        /// When authenticating as an app, the Chat app is added as a member of the
        /// space. However, unlike human authentication, the Chat app is not added as a
        /// space manager. By default, the Chat app can be removed from the space by
        /// all space members. To allow only space managers to remove the app from a
        /// space, set `space.permission_settings.manage_apps` to `managers_allowed`.
        /// 
        /// Space membership upon creation depends on whether the space is created in
        /// `Import mode`:
        /// 
        /// * **Import mode:** No members are created.
        /// * **All other modes:**  The calling user is added as a member. This is:
        /// * The app itself when using app authentication.
        /// * The human user when using user authentication.
        /// 
        /// If you receive the error message `ALREADY_EXISTS` when creating
        /// a space, try a different `displayName`. An existing space within
        /// the Google Workspace organization might already use this display name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> CreateSpaceAsync(CreateSpaceRequest request, st::CancellationToken cancellationToken) =>
            CreateSpaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a space. Can be used to create a named space, or a
        /// group chat in `Import mode`. For an example, see [Create a
        /// space](https://developers.google.com/workspace/chat/create-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.app.spaces.create`
        /// - `https://www.googleapis.com/auth/chat.app.spaces`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.create`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When authenticating as an app, the `space.customer` field must be set in
        /// the request.
        /// 
        /// When authenticating as an app, the Chat app is added as a member of the
        /// space. However, unlike human authentication, the Chat app is not added as a
        /// space manager. By default, the Chat app can be removed from the space by
        /// all space members. To allow only space managers to remove the app from a
        /// space, set `space.permission_settings.manage_apps` to `managers_allowed`.
        /// 
        /// Space membership upon creation depends on whether the space is created in
        /// `Import mode`:
        /// 
        /// * **Import mode:** No members are created.
        /// * **All other modes:**  The calling user is added as a member. This is:
        /// * The app itself when using app authentication.
        /// * The human user when using user authentication.
        /// 
        /// If you receive the error message `ALREADY_EXISTS` when creating
        /// a space, try a different `displayName`. An existing space within
        /// the Google Workspace organization might already use this display name.
        /// </summary>
        /// <param name="space">
        /// Required. The `displayName` and `spaceType` fields must be populated.  Only
        /// `SpaceType.SPACE`  and `SpaceType.GROUP_CHAT` are supported.
        /// `SpaceType.GROUP_CHAT` can only be used if `importMode` is set to true.
        /// 
        /// If you receive the error message `ALREADY_EXISTS`,
        /// try a different `displayName`. An existing space within the Google
        /// Workspace organization might already use this display name.
        /// 
        /// 
        /// The space `name` is assigned on the server so anything specified in this
        /// field will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Space CreateSpace(Space space, gaxgrpc::CallSettings callSettings = null) =>
            CreateSpace(new CreateSpaceRequest
            {
                Space = gax::GaxPreconditions.CheckNotNull(space, nameof(space)),
            }, callSettings);

        /// <summary>
        /// Creates a space. Can be used to create a named space, or a
        /// group chat in `Import mode`. For an example, see [Create a
        /// space](https://developers.google.com/workspace/chat/create-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.app.spaces.create`
        /// - `https://www.googleapis.com/auth/chat.app.spaces`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.create`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When authenticating as an app, the `space.customer` field must be set in
        /// the request.
        /// 
        /// When authenticating as an app, the Chat app is added as a member of the
        /// space. However, unlike human authentication, the Chat app is not added as a
        /// space manager. By default, the Chat app can be removed from the space by
        /// all space members. To allow only space managers to remove the app from a
        /// space, set `space.permission_settings.manage_apps` to `managers_allowed`.
        /// 
        /// Space membership upon creation depends on whether the space is created in
        /// `Import mode`:
        /// 
        /// * **Import mode:** No members are created.
        /// * **All other modes:**  The calling user is added as a member. This is:
        /// * The app itself when using app authentication.
        /// * The human user when using user authentication.
        /// 
        /// If you receive the error message `ALREADY_EXISTS` when creating
        /// a space, try a different `displayName`. An existing space within
        /// the Google Workspace organization might already use this display name.
        /// </summary>
        /// <param name="space">
        /// Required. The `displayName` and `spaceType` fields must be populated.  Only
        /// `SpaceType.SPACE`  and `SpaceType.GROUP_CHAT` are supported.
        /// `SpaceType.GROUP_CHAT` can only be used if `importMode` is set to true.
        /// 
        /// If you receive the error message `ALREADY_EXISTS`,
        /// try a different `displayName`. An existing space within the Google
        /// Workspace organization might already use this display name.
        /// 
        /// 
        /// The space `name` is assigned on the server so anything specified in this
        /// field will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> CreateSpaceAsync(Space space, gaxgrpc::CallSettings callSettings = null) =>
            CreateSpaceAsync(new CreateSpaceRequest
            {
                Space = gax::GaxPreconditions.CheckNotNull(space, nameof(space)),
            }, callSettings);

        /// <summary>
        /// Creates a space. Can be used to create a named space, or a
        /// group chat in `Import mode`. For an example, see [Create a
        /// space](https://developers.google.com/workspace/chat/create-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.app.spaces.create`
        /// - `https://www.googleapis.com/auth/chat.app.spaces`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.create`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When authenticating as an app, the `space.customer` field must be set in
        /// the request.
        /// 
        /// When authenticating as an app, the Chat app is added as a member of the
        /// space. However, unlike human authentication, the Chat app is not added as a
        /// space manager. By default, the Chat app can be removed from the space by
        /// all space members. To allow only space managers to remove the app from a
        /// space, set `space.permission_settings.manage_apps` to `managers_allowed`.
        /// 
        /// Space membership upon creation depends on whether the space is created in
        /// `Import mode`:
        /// 
        /// * **Import mode:** No members are created.
        /// * **All other modes:**  The calling user is added as a member. This is:
        /// * The app itself when using app authentication.
        /// * The human user when using user authentication.
        /// 
        /// If you receive the error message `ALREADY_EXISTS` when creating
        /// a space, try a different `displayName`. An existing space within
        /// the Google Workspace organization might already use this display name.
        /// </summary>
        /// <param name="space">
        /// Required. The `displayName` and `spaceType` fields must be populated.  Only
        /// `SpaceType.SPACE`  and `SpaceType.GROUP_CHAT` are supported.
        /// `SpaceType.GROUP_CHAT` can only be used if `importMode` is set to true.
        /// 
        /// If you receive the error message `ALREADY_EXISTS`,
        /// try a different `displayName`. An existing space within the Google
        /// Workspace organization might already use this display name.
        /// 
        /// 
        /// The space `name` is assigned on the server so anything specified in this
        /// field will be ignored.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> CreateSpaceAsync(Space space, st::CancellationToken cancellationToken) =>
            CreateSpaceAsync(space, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a space and adds specified users to it. The calling user is
        /// automatically added to the space, and shouldn't be specified as a
        /// membership in the request. For an example, see
        /// [Set up a space with initial
        /// members](https://developers.google.com/workspace/chat/set-up-spaces).
        /// 
        /// To specify the human members to add, add memberships with the appropriate
        /// `membership.member.name`. To add a human user, use `users/{user}`, where
        /// `{user}` can be the email address for the user. For users in the same
        /// Workspace organization `{user}` can also be the `id` for the person from
        /// the People API, or the `id` for the user in the Directory API. For example,
        /// if the People API Person profile ID for `user@example.com` is `123456789`,
        /// you can add the user to the space by setting the `membership.member.name`
        /// to `users/user@example.com` or `users/123456789`.
        /// 
        /// To specify the Google groups to add, add memberships with the
        /// appropriate `membership.group_member.name`. To add or invite a Google
        /// group, use `groups/{group}`, where `{group}` is the `id` for the group from
        /// the Cloud Identity Groups API. For example, you can use [Cloud Identity
        /// Groups lookup
        /// API](https://cloud.google.com/identity/docs/reference/rest/v1/groups/lookup)
        /// to retrieve the ID `123456789` for group email `group@example.com`, then
        /// you can add the group to the space by setting the
        /// `membership.group_member.name` to `groups/123456789`. Group email is not
        /// supported, and Google groups can only be added as members in named spaces.
        /// 
        /// For a named space or group chat, if the caller blocks, or is blocked
        /// by some members, or doesn't have permission to add some members, then
        /// those members aren't added to the created space.
        /// 
        /// To create a direct message (DM) between the calling user and another human
        /// user, specify exactly one membership to represent the human user. If
        /// one user blocks the other, the request fails and the DM isn't created.
        /// 
        /// To create a DM between the calling user and the calling app, set
        /// `Space.singleUserBotDm` to `true` and don't specify any memberships. You
        /// can only use this method to set up a DM with the calling app. To add the
        /// calling app as a member of a space or an existing DM between two human
        /// users, see
        /// [Invite or add a user or app to a
        /// space](https://developers.google.com/workspace/chat/create-members).
        /// 
        /// If a DM already exists between two users, even when one user blocks the
        /// other at the time a request is made, then the existing DM is returned.
        /// 
        /// Spaces with threaded replies aren't supported. If you receive the error
        /// message `ALREADY_EXISTS` when setting up a space, try a different
        /// `displayName`. An existing space within the Google Workspace organization
        /// might already use this display name.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.spaces.create`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Space SetUpSpace(SetUpSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a space and adds specified users to it. The calling user is
        /// automatically added to the space, and shouldn't be specified as a
        /// membership in the request. For an example, see
        /// [Set up a space with initial
        /// members](https://developers.google.com/workspace/chat/set-up-spaces).
        /// 
        /// To specify the human members to add, add memberships with the appropriate
        /// `membership.member.name`. To add a human user, use `users/{user}`, where
        /// `{user}` can be the email address for the user. For users in the same
        /// Workspace organization `{user}` can also be the `id` for the person from
        /// the People API, or the `id` for the user in the Directory API. For example,
        /// if the People API Person profile ID for `user@example.com` is `123456789`,
        /// you can add the user to the space by setting the `membership.member.name`
        /// to `users/user@example.com` or `users/123456789`.
        /// 
        /// To specify the Google groups to add, add memberships with the
        /// appropriate `membership.group_member.name`. To add or invite a Google
        /// group, use `groups/{group}`, where `{group}` is the `id` for the group from
        /// the Cloud Identity Groups API. For example, you can use [Cloud Identity
        /// Groups lookup
        /// API](https://cloud.google.com/identity/docs/reference/rest/v1/groups/lookup)
        /// to retrieve the ID `123456789` for group email `group@example.com`, then
        /// you can add the group to the space by setting the
        /// `membership.group_member.name` to `groups/123456789`. Group email is not
        /// supported, and Google groups can only be added as members in named spaces.
        /// 
        /// For a named space or group chat, if the caller blocks, or is blocked
        /// by some members, or doesn't have permission to add some members, then
        /// those members aren't added to the created space.
        /// 
        /// To create a direct message (DM) between the calling user and another human
        /// user, specify exactly one membership to represent the human user. If
        /// one user blocks the other, the request fails and the DM isn't created.
        /// 
        /// To create a DM between the calling user and the calling app, set
        /// `Space.singleUserBotDm` to `true` and don't specify any memberships. You
        /// can only use this method to set up a DM with the calling app. To add the
        /// calling app as a member of a space or an existing DM between two human
        /// users, see
        /// [Invite or add a user or app to a
        /// space](https://developers.google.com/workspace/chat/create-members).
        /// 
        /// If a DM already exists between two users, even when one user blocks the
        /// other at the time a request is made, then the existing DM is returned.
        /// 
        /// Spaces with threaded replies aren't supported. If you receive the error
        /// message `ALREADY_EXISTS` when setting up a space, try a different
        /// `displayName`. An existing space within the Google Workspace organization
        /// might already use this display name.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.spaces.create`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> SetUpSpaceAsync(SetUpSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a space and adds specified users to it. The calling user is
        /// automatically added to the space, and shouldn't be specified as a
        /// membership in the request. For an example, see
        /// [Set up a space with initial
        /// members](https://developers.google.com/workspace/chat/set-up-spaces).
        /// 
        /// To specify the human members to add, add memberships with the appropriate
        /// `membership.member.name`. To add a human user, use `users/{user}`, where
        /// `{user}` can be the email address for the user. For users in the same
        /// Workspace organization `{user}` can also be the `id` for the person from
        /// the People API, or the `id` for the user in the Directory API. For example,
        /// if the People API Person profile ID for `user@example.com` is `123456789`,
        /// you can add the user to the space by setting the `membership.member.name`
        /// to `users/user@example.com` or `users/123456789`.
        /// 
        /// To specify the Google groups to add, add memberships with the
        /// appropriate `membership.group_member.name`. To add or invite a Google
        /// group, use `groups/{group}`, where `{group}` is the `id` for the group from
        /// the Cloud Identity Groups API. For example, you can use [Cloud Identity
        /// Groups lookup
        /// API](https://cloud.google.com/identity/docs/reference/rest/v1/groups/lookup)
        /// to retrieve the ID `123456789` for group email `group@example.com`, then
        /// you can add the group to the space by setting the
        /// `membership.group_member.name` to `groups/123456789`. Group email is not
        /// supported, and Google groups can only be added as members in named spaces.
        /// 
        /// For a named space or group chat, if the caller blocks, or is blocked
        /// by some members, or doesn't have permission to add some members, then
        /// those members aren't added to the created space.
        /// 
        /// To create a direct message (DM) between the calling user and another human
        /// user, specify exactly one membership to represent the human user. If
        /// one user blocks the other, the request fails and the DM isn't created.
        /// 
        /// To create a DM between the calling user and the calling app, set
        /// `Space.singleUserBotDm` to `true` and don't specify any memberships. You
        /// can only use this method to set up a DM with the calling app. To add the
        /// calling app as a member of a space or an existing DM between two human
        /// users, see
        /// [Invite or add a user or app to a
        /// space](https://developers.google.com/workspace/chat/create-members).
        /// 
        /// If a DM already exists between two users, even when one user blocks the
        /// other at the time a request is made, then the existing DM is returned.
        /// 
        /// Spaces with threaded replies aren't supported. If you receive the error
        /// message `ALREADY_EXISTS` when setting up a space, try a different
        /// `displayName`. An existing space within the Google Workspace organization
        /// might already use this display name.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.spaces.create`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> SetUpSpaceAsync(SetUpSpaceRequest request, st::CancellationToken cancellationToken) =>
            SetUpSpaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a space. For an example, see
        /// [Update a
        /// space](https://developers.google.com/workspace/chat/update-spaces).
        /// 
        /// If you're updating the `displayName` field and receive the error message
        /// `ALREADY_EXISTS`, try a different display name.. An existing space within
        /// the Google Workspace organization might already use this display name.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.app.spaces`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.spaces`
        /// 
        /// App authentication has the following limitations:
        /// 
        /// - To update either `space.predefined_permission_settings` or
        /// `space.permission_settings`, the app must be the space creator.
        /// - Updating the `space.access_settings.audience` is not supported for app
        /// authentication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Space UpdateSpace(UpdateSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a space. For an example, see
        /// [Update a
        /// space](https://developers.google.com/workspace/chat/update-spaces).
        /// 
        /// If you're updating the `displayName` field and receive the error message
        /// `ALREADY_EXISTS`, try a different display name.. An existing space within
        /// the Google Workspace organization might already use this display name.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.app.spaces`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.spaces`
        /// 
        /// App authentication has the following limitations:
        /// 
        /// - To update either `space.predefined_permission_settings` or
        /// `space.permission_settings`, the app must be the space creator.
        /// - Updating the `space.access_settings.audience` is not supported for app
        /// authentication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> UpdateSpaceAsync(UpdateSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a space. For an example, see
        /// [Update a
        /// space](https://developers.google.com/workspace/chat/update-spaces).
        /// 
        /// If you're updating the `displayName` field and receive the error message
        /// `ALREADY_EXISTS`, try a different display name.. An existing space within
        /// the Google Workspace organization might already use this display name.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.app.spaces`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.spaces`
        /// 
        /// App authentication has the following limitations:
        /// 
        /// - To update either `space.predefined_permission_settings` or
        /// `space.permission_settings`, the app must be the space creator.
        /// - Updating the `space.access_settings.audience` is not supported for app
        /// authentication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> UpdateSpaceAsync(UpdateSpaceRequest request, st::CancellationToken cancellationToken) =>
            UpdateSpaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a space. For an example, see
        /// [Update a
        /// space](https://developers.google.com/workspace/chat/update-spaces).
        /// 
        /// If you're updating the `displayName` field and receive the error message
        /// `ALREADY_EXISTS`, try a different display name.. An existing space within
        /// the Google Workspace organization might already use this display name.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.app.spaces`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.spaces`
        /// 
        /// App authentication has the following limitations:
        /// 
        /// - To update either `space.predefined_permission_settings` or
        /// `space.permission_settings`, the app must be the space creator.
        /// - Updating the `space.access_settings.audience` is not supported for app
        /// authentication.
        /// </summary>
        /// <param name="space">
        /// Required. Space with fields to be updated. `Space.name` must be
        /// populated in the form of `spaces/{space}`. Only fields
        /// specified by `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The updated field paths, comma separated if there are
        /// multiple.
        /// 
        /// You can update the following fields for a space:
        /// 
        /// `space_details`: Updates the space's description. Supports up to 150
        /// characters.
        /// 
        /// `display_name`: Only supports updating the display name for spaces where
        /// `spaceType` field is `SPACE`.
        /// If you receive the error message `ALREADY_EXISTS`, try a different
        /// value. An existing space within the
        /// Google Workspace organization might already use this display name.
        /// 
        /// `space_type`: Only supports changing a `GROUP_CHAT` space type to
        /// `SPACE`. Include `display_name` together
        /// with `space_type` in the update mask and ensure that the specified space
        /// has a non-empty display name and the `SPACE` space type. Including the
        /// `space_type` mask and the `SPACE` type in the specified space when updating
        /// the display name is optional if the existing space already has the `SPACE`
        /// type. Trying to update the space type in other ways results in an invalid
        /// argument error.
        /// `space_type` is not supported with `useAdminAccess`.
        /// 
        /// `space_history_state`: Updates [space history
        /// settings](https://support.google.com/chat/answer/7664687) by turning
        /// history on or off for the space. Only supported if history settings are
        /// enabled for the Google Workspace organization. To update the
        /// space history state, you must omit all other field masks in your request.
        /// `space_history_state` is not supported with `useAdminAccess`.
        /// 
        /// `access_settings.audience`: Updates the [access
        /// setting](https://support.google.com/chat/answer/11971020) of who can
        /// discover the space, join the space, and preview the messages in named space
        /// where `spaceType` field is `SPACE`. If the existing space has a
        /// target audience, you can remove the audience and restrict space access by
        /// omitting a value for this field mask. To update access settings for a
        /// space, the authenticating user must be a space manager and omit all other
        /// field masks in your request. You can't update this field if the space is in
        /// [import
        /// mode](https://developers.google.com/workspace/chat/import-data-overview).
        /// To learn more, see [Make a space discoverable to specific
        /// users](https://developers.google.com/workspace/chat/space-target-audience).
        /// `access_settings.audience` is not supported with `useAdminAccess`.
        /// 
        /// `permission_settings`: Supports changing the
        /// [permission settings](https://support.google.com/chat/answer/13340792)
        /// of a space.
        /// When updating permission settings, you can only specify
        /// `permissionSettings` field masks; you cannot update other field masks
        /// at the same time. `permissionSettings` is not supported with
        /// `useAdminAccess`.
        /// The supported field masks include:
        /// 
        /// - `permission_settings.manageMembersAndGroups`
        /// - `permission_settings.modifySpaceDetails`
        /// - `permission_settings.toggleHistory`
        /// - `permission_settings.useAtMentionAll`
        /// - `permission_settings.manageApps`
        /// - `permission_settings.manageWebhooks`
        /// - `permission_settings.replyMessages`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Space UpdateSpace(Space space, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSpace(new UpdateSpaceRequest
            {
                Space = gax::GaxPreconditions.CheckNotNull(space, nameof(space)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a space. For an example, see
        /// [Update a
        /// space](https://developers.google.com/workspace/chat/update-spaces).
        /// 
        /// If you're updating the `displayName` field and receive the error message
        /// `ALREADY_EXISTS`, try a different display name.. An existing space within
        /// the Google Workspace organization might already use this display name.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.app.spaces`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.spaces`
        /// 
        /// App authentication has the following limitations:
        /// 
        /// - To update either `space.predefined_permission_settings` or
        /// `space.permission_settings`, the app must be the space creator.
        /// - Updating the `space.access_settings.audience` is not supported for app
        /// authentication.
        /// </summary>
        /// <param name="space">
        /// Required. Space with fields to be updated. `Space.name` must be
        /// populated in the form of `spaces/{space}`. Only fields
        /// specified by `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The updated field paths, comma separated if there are
        /// multiple.
        /// 
        /// You can update the following fields for a space:
        /// 
        /// `space_details`: Updates the space's description. Supports up to 150
        /// characters.
        /// 
        /// `display_name`: Only supports updating the display name for spaces where
        /// `spaceType` field is `SPACE`.
        /// If you receive the error message `ALREADY_EXISTS`, try a different
        /// value. An existing space within the
        /// Google Workspace organization might already use this display name.
        /// 
        /// `space_type`: Only supports changing a `GROUP_CHAT` space type to
        /// `SPACE`. Include `display_name` together
        /// with `space_type` in the update mask and ensure that the specified space
        /// has a non-empty display name and the `SPACE` space type. Including the
        /// `space_type` mask and the `SPACE` type in the specified space when updating
        /// the display name is optional if the existing space already has the `SPACE`
        /// type. Trying to update the space type in other ways results in an invalid
        /// argument error.
        /// `space_type` is not supported with `useAdminAccess`.
        /// 
        /// `space_history_state`: Updates [space history
        /// settings](https://support.google.com/chat/answer/7664687) by turning
        /// history on or off for the space. Only supported if history settings are
        /// enabled for the Google Workspace organization. To update the
        /// space history state, you must omit all other field masks in your request.
        /// `space_history_state` is not supported with `useAdminAccess`.
        /// 
        /// `access_settings.audience`: Updates the [access
        /// setting](https://support.google.com/chat/answer/11971020) of who can
        /// discover the space, join the space, and preview the messages in named space
        /// where `spaceType` field is `SPACE`. If the existing space has a
        /// target audience, you can remove the audience and restrict space access by
        /// omitting a value for this field mask. To update access settings for a
        /// space, the authenticating user must be a space manager and omit all other
        /// field masks in your request. You can't update this field if the space is in
        /// [import
        /// mode](https://developers.google.com/workspace/chat/import-data-overview).
        /// To learn more, see [Make a space discoverable to specific
        /// users](https://developers.google.com/workspace/chat/space-target-audience).
        /// `access_settings.audience` is not supported with `useAdminAccess`.
        /// 
        /// `permission_settings`: Supports changing the
        /// [permission settings](https://support.google.com/chat/answer/13340792)
        /// of a space.
        /// When updating permission settings, you can only specify
        /// `permissionSettings` field masks; you cannot update other field masks
        /// at the same time. `permissionSettings` is not supported with
        /// `useAdminAccess`.
        /// The supported field masks include:
        /// 
        /// - `permission_settings.manageMembersAndGroups`
        /// - `permission_settings.modifySpaceDetails`
        /// - `permission_settings.toggleHistory`
        /// - `permission_settings.useAtMentionAll`
        /// - `permission_settings.manageApps`
        /// - `permission_settings.manageWebhooks`
        /// - `permission_settings.replyMessages`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> UpdateSpaceAsync(Space space, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSpaceAsync(new UpdateSpaceRequest
            {
                Space = gax::GaxPreconditions.CheckNotNull(space, nameof(space)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a space. For an example, see
        /// [Update a
        /// space](https://developers.google.com/workspace/chat/update-spaces).
        /// 
        /// If you're updating the `displayName` field and receive the error message
        /// `ALREADY_EXISTS`, try a different display name.. An existing space within
        /// the Google Workspace organization might already use this display name.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.app.spaces`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.spaces`
        /// 
        /// App authentication has the following limitations:
        /// 
        /// - To update either `space.predefined_permission_settings` or
        /// `space.permission_settings`, the app must be the space creator.
        /// - Updating the `space.access_settings.audience` is not supported for app
        /// authentication.
        /// </summary>
        /// <param name="space">
        /// Required. Space with fields to be updated. `Space.name` must be
        /// populated in the form of `spaces/{space}`. Only fields
        /// specified by `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The updated field paths, comma separated if there are
        /// multiple.
        /// 
        /// You can update the following fields for a space:
        /// 
        /// `space_details`: Updates the space's description. Supports up to 150
        /// characters.
        /// 
        /// `display_name`: Only supports updating the display name for spaces where
        /// `spaceType` field is `SPACE`.
        /// If you receive the error message `ALREADY_EXISTS`, try a different
        /// value. An existing space within the
        /// Google Workspace organization might already use this display name.
        /// 
        /// `space_type`: Only supports changing a `GROUP_CHAT` space type to
        /// `SPACE`. Include `display_name` together
        /// with `space_type` in the update mask and ensure that the specified space
        /// has a non-empty display name and the `SPACE` space type. Including the
        /// `space_type` mask and the `SPACE` type in the specified space when updating
        /// the display name is optional if the existing space already has the `SPACE`
        /// type. Trying to update the space type in other ways results in an invalid
        /// argument error.
        /// `space_type` is not supported with `useAdminAccess`.
        /// 
        /// `space_history_state`: Updates [space history
        /// settings](https://support.google.com/chat/answer/7664687) by turning
        /// history on or off for the space. Only supported if history settings are
        /// enabled for the Google Workspace organization. To update the
        /// space history state, you must omit all other field masks in your request.
        /// `space_history_state` is not supported with `useAdminAccess`.
        /// 
        /// `access_settings.audience`: Updates the [access
        /// setting](https://support.google.com/chat/answer/11971020) of who can
        /// discover the space, join the space, and preview the messages in named space
        /// where `spaceType` field is `SPACE`. If the existing space has a
        /// target audience, you can remove the audience and restrict space access by
        /// omitting a value for this field mask. To update access settings for a
        /// space, the authenticating user must be a space manager and omit all other
        /// field masks in your request. You can't update this field if the space is in
        /// [import
        /// mode](https://developers.google.com/workspace/chat/import-data-overview).
        /// To learn more, see [Make a space discoverable to specific
        /// users](https://developers.google.com/workspace/chat/space-target-audience).
        /// `access_settings.audience` is not supported with `useAdminAccess`.
        /// 
        /// `permission_settings`: Supports changing the
        /// [permission settings](https://support.google.com/chat/answer/13340792)
        /// of a space.
        /// When updating permission settings, you can only specify
        /// `permissionSettings` field masks; you cannot update other field masks
        /// at the same time. `permissionSettings` is not supported with
        /// `useAdminAccess`.
        /// The supported field masks include:
        /// 
        /// - `permission_settings.manageMembersAndGroups`
        /// - `permission_settings.modifySpaceDetails`
        /// - `permission_settings.toggleHistory`
        /// - `permission_settings.useAtMentionAll`
        /// - `permission_settings.manageApps`
        /// - `permission_settings.manageWebhooks`
        /// - `permission_settings.replyMessages`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> UpdateSpaceAsync(Space space, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSpaceAsync(space, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a named space. Always performs a cascading delete, which means
        /// that the space's child resources—like messages posted in the space and
        /// memberships in the space—are also deleted. For an example, see
        /// [Delete a
        /// space](https://developers.google.com/workspace/chat/delete-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth) and the
        /// authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.delete` (only in
        /// spaces the app created)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.delete`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.delete`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSpace(DeleteSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a named space. Always performs a cascading delete, which means
        /// that the space's child resources—like messages posted in the space and
        /// memberships in the space—are also deleted. For an example, see
        /// [Delete a
        /// space](https://developers.google.com/workspace/chat/delete-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth) and the
        /// authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.delete` (only in
        /// spaces the app created)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.delete`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.delete`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSpaceAsync(DeleteSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a named space. Always performs a cascading delete, which means
        /// that the space's child resources—like messages posted in the space and
        /// memberships in the space—are also deleted. For an example, see
        /// [Delete a
        /// space](https://developers.google.com/workspace/chat/delete-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth) and the
        /// authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.delete` (only in
        /// spaces the app created)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.delete`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.delete`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSpaceAsync(DeleteSpaceRequest request, st::CancellationToken cancellationToken) =>
            DeleteSpaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a named space. Always performs a cascading delete, which means
        /// that the space's child resources—like messages posted in the space and
        /// memberships in the space—are also deleted. For an example, see
        /// [Delete a
        /// space](https://developers.google.com/workspace/chat/delete-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth) and the
        /// authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.delete` (only in
        /// spaces the app created)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.delete`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.delete`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space to delete.
        /// 
        /// Format: `spaces/{space}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSpace(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSpace(new DeleteSpaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a named space. Always performs a cascading delete, which means
        /// that the space's child resources—like messages posted in the space and
        /// memberships in the space—are also deleted. For an example, see
        /// [Delete a
        /// space](https://developers.google.com/workspace/chat/delete-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth) and the
        /// authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.delete` (only in
        /// spaces the app created)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.delete`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.delete`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space to delete.
        /// 
        /// Format: `spaces/{space}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSpaceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSpaceAsync(new DeleteSpaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a named space. Always performs a cascading delete, which means
        /// that the space's child resources—like messages posted in the space and
        /// memberships in the space—are also deleted. For an example, see
        /// [Delete a
        /// space](https://developers.google.com/workspace/chat/delete-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth) and the
        /// authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.delete` (only in
        /// spaces the app created)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.delete`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.delete`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space to delete.
        /// 
        /// Format: `spaces/{space}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSpaceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSpaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a named space. Always performs a cascading delete, which means
        /// that the space's child resources—like messages posted in the space and
        /// memberships in the space—are also deleted. For an example, see
        /// [Delete a
        /// space](https://developers.google.com/workspace/chat/delete-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth) and the
        /// authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.delete` (only in
        /// spaces the app created)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.delete`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.delete`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space to delete.
        /// 
        /// Format: `spaces/{space}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSpace(SpaceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSpace(new DeleteSpaceRequest
            {
                SpaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a named space. Always performs a cascading delete, which means
        /// that the space's child resources—like messages posted in the space and
        /// memberships in the space—are also deleted. For an example, see
        /// [Delete a
        /// space](https://developers.google.com/workspace/chat/delete-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth) and the
        /// authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.delete` (only in
        /// spaces the app created)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.delete`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.delete`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space to delete.
        /// 
        /// Format: `spaces/{space}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSpaceAsync(SpaceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSpaceAsync(new DeleteSpaceRequest
            {
                SpaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a named space. Always performs a cascading delete, which means
        /// that the space's child resources—like messages posted in the space and
        /// memberships in the space—are also deleted. For an example, see
        /// [Delete a
        /// space](https://developers.google.com/workspace/chat/delete-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth) and the
        /// authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.delete` (only in
        /// spaces the app created)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.delete`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.delete`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space to delete.
        /// 
        /// Format: `spaces/{space}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSpaceAsync(SpaceName name, st::CancellationToken cancellationToken) =>
            DeleteSpaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Completes the
        /// [import process](https://developers.google.com/workspace/chat/import-data)
        /// for the specified space and makes it visible to users.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// and domain-wide delegation with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.import`
        /// 
        /// For more information, see [Authorize Google
        /// Chat apps to import
        /// data](https://developers.google.com/workspace/chat/authorize-import).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CompleteImportSpaceResponse CompleteImportSpace(CompleteImportSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Completes the
        /// [import process](https://developers.google.com/workspace/chat/import-data)
        /// for the specified space and makes it visible to users.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// and domain-wide delegation with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.import`
        /// 
        /// For more information, see [Authorize Google
        /// Chat apps to import
        /// data](https://developers.google.com/workspace/chat/authorize-import).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompleteImportSpaceResponse> CompleteImportSpaceAsync(CompleteImportSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Completes the
        /// [import process](https://developers.google.com/workspace/chat/import-data)
        /// for the specified space and makes it visible to users.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// and domain-wide delegation with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.import`
        /// 
        /// For more information, see [Authorize Google
        /// Chat apps to import
        /// data](https://developers.google.com/workspace/chat/authorize-import).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompleteImportSpaceResponse> CompleteImportSpaceAsync(CompleteImportSpaceRequest request, st::CancellationToken cancellationToken) =>
            CompleteImportSpaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the existing direct message with the specified user. If no direct
        /// message space is found, returns a `404 NOT_FOUND` error. For an example,
        /// see
        /// [Find a direct message](/chat/api/guides/v1/spaces/find-direct-message).
        /// 
        /// With [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app),
        /// returns the direct message space between the specified user and the calling
        /// Chat app.
        /// 
        /// With [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user),
        /// returns the direct message space between the specified user and the
        /// authenticated user.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Space FindDirectMessage(FindDirectMessageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the existing direct message with the specified user. If no direct
        /// message space is found, returns a `404 NOT_FOUND` error. For an example,
        /// see
        /// [Find a direct message](/chat/api/guides/v1/spaces/find-direct-message).
        /// 
        /// With [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app),
        /// returns the direct message space between the specified user and the calling
        /// Chat app.
        /// 
        /// With [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user),
        /// returns the direct message space between the specified user and the
        /// authenticated user.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> FindDirectMessageAsync(FindDirectMessageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the existing direct message with the specified user. If no direct
        /// message space is found, returns a `404 NOT_FOUND` error. For an example,
        /// see
        /// [Find a direct message](/chat/api/guides/v1/spaces/find-direct-message).
        /// 
        /// With [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app),
        /// returns the direct message space between the specified user and the calling
        /// Chat app.
        /// 
        /// With [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user),
        /// returns the direct message space between the specified user and the
        /// authenticated user.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> FindDirectMessageAsync(FindDirectMessageRequest request, st::CancellationToken cancellationToken) =>
            FindDirectMessageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a membership for the calling Chat app, a user, or a Google Group.
        /// Creating memberships for other Chat apps isn't supported.
        /// When creating a membership, if the specified member has their auto-accept
        /// policy turned off, then they're invited, and must accept the space
        /// invitation before joining. Otherwise, creating a membership adds the member
        /// directly to the specified space.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.memberships.app` (to add the
        /// calling app to the space)
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// 
        /// App authentication is not supported for the following use cases:
        /// 
        /// - Inviting users external to the Workspace organization that owns the
        /// space.
        /// - Adding a Google Group to a space.
        /// - Adding a Chat app to a space.
        /// 
        /// For example usage, see:
        /// 
        /// - [Invite or add a user to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-user-membership).
        /// - [Invite or add a Google Group to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-group-membership).
        /// - [Add the Chat app to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-membership-calling-api).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Membership CreateMembership(CreateMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a membership for the calling Chat app, a user, or a Google Group.
        /// Creating memberships for other Chat apps isn't supported.
        /// When creating a membership, if the specified member has their auto-accept
        /// policy turned off, then they're invited, and must accept the space
        /// invitation before joining. Otherwise, creating a membership adds the member
        /// directly to the specified space.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.memberships.app` (to add the
        /// calling app to the space)
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// 
        /// App authentication is not supported for the following use cases:
        /// 
        /// - Inviting users external to the Workspace organization that owns the
        /// space.
        /// - Adding a Google Group to a space.
        /// - Adding a Chat app to a space.
        /// 
        /// For example usage, see:
        /// 
        /// - [Invite or add a user to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-user-membership).
        /// - [Invite or add a Google Group to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-group-membership).
        /// - [Add the Chat app to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-membership-calling-api).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> CreateMembershipAsync(CreateMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a membership for the calling Chat app, a user, or a Google Group.
        /// Creating memberships for other Chat apps isn't supported.
        /// When creating a membership, if the specified member has their auto-accept
        /// policy turned off, then they're invited, and must accept the space
        /// invitation before joining. Otherwise, creating a membership adds the member
        /// directly to the specified space.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.memberships.app` (to add the
        /// calling app to the space)
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// 
        /// App authentication is not supported for the following use cases:
        /// 
        /// - Inviting users external to the Workspace organization that owns the
        /// space.
        /// - Adding a Google Group to a space.
        /// - Adding a Chat app to a space.
        /// 
        /// For example usage, see:
        /// 
        /// - [Invite or add a user to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-user-membership).
        /// - [Invite or add a Google Group to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-group-membership).
        /// - [Add the Chat app to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-membership-calling-api).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> CreateMembershipAsync(CreateMembershipRequest request, st::CancellationToken cancellationToken) =>
            CreateMembershipAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a membership for the calling Chat app, a user, or a Google Group.
        /// Creating memberships for other Chat apps isn't supported.
        /// When creating a membership, if the specified member has their auto-accept
        /// policy turned off, then they're invited, and must accept the space
        /// invitation before joining. Otherwise, creating a membership adds the member
        /// directly to the specified space.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.memberships.app` (to add the
        /// calling app to the space)
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// 
        /// App authentication is not supported for the following use cases:
        /// 
        /// - Inviting users external to the Workspace organization that owns the
        /// space.
        /// - Adding a Google Group to a space.
        /// - Adding a Chat app to a space.
        /// 
        /// For example usage, see:
        /// 
        /// - [Invite or add a user to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-user-membership).
        /// - [Invite or add a Google Group to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-group-membership).
        /// - [Add the Chat app to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-membership-calling-api).
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the space for which to create the
        /// membership.
        /// 
        /// Format: spaces/{space}
        /// </param>
        /// <param name="membership">
        /// Required. The membership relation to create.
        /// 
        /// The `memberType` field must contain a user with the `user.name` and
        /// `user.type` fields populated. The server will assign a resource name
        /// and overwrite anything specified.
        /// 
        /// When a Chat app creates a membership relation for a human user, it must use
        /// certain authorization scopes and set specific values for certain fields:
        /// 
        /// - When [authenticating as a
        /// user](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user),
        /// the `chat.memberships` authorization scope is required.
        /// 
        /// - When [authenticating as an
        /// app](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app),
        /// the `chat.app.memberships` authorization scope is required.
        /// 
        /// - Set `user.type` to `HUMAN`, and set `user.name` with format
        /// `users/{user}`, where `{user}` can be the email address for the user. For
        /// users in the same Workspace organization `{user}` can also be the `id` of
        /// the [person](https://developers.google.com/people/api/rest/v1/people) from
        /// the People API, or the `id` for the user in the Directory API. For example,
        /// if the People API Person profile ID for `user@example.com` is `123456789`,
        /// you can add the user to the space by setting the `membership.member.name`
        /// to `users/user@example.com` or `users/123456789`.
        /// 
        /// Inviting users external to the Workspace organization that owns the space
        /// requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
        /// 
        /// When a Chat app creates a membership relation for itself, it must
        /// [authenticate as a
        /// user](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// and use the `chat.memberships.app` scope, set `user.type` to `BOT`, and set
        /// `user.name` to `users/app`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Membership CreateMembership(string parent, Membership membership, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembership(new CreateMembershipRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Membership = gax::GaxPreconditions.CheckNotNull(membership, nameof(membership)),
            }, callSettings);

        /// <summary>
        /// Creates a membership for the calling Chat app, a user, or a Google Group.
        /// Creating memberships for other Chat apps isn't supported.
        /// When creating a membership, if the specified member has their auto-accept
        /// policy turned off, then they're invited, and must accept the space
        /// invitation before joining. Otherwise, creating a membership adds the member
        /// directly to the specified space.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.memberships.app` (to add the
        /// calling app to the space)
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// 
        /// App authentication is not supported for the following use cases:
        /// 
        /// - Inviting users external to the Workspace organization that owns the
        /// space.
        /// - Adding a Google Group to a space.
        /// - Adding a Chat app to a space.
        /// 
        /// For example usage, see:
        /// 
        /// - [Invite or add a user to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-user-membership).
        /// - [Invite or add a Google Group to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-group-membership).
        /// - [Add the Chat app to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-membership-calling-api).
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the space for which to create the
        /// membership.
        /// 
        /// Format: spaces/{space}
        /// </param>
        /// <param name="membership">
        /// Required. The membership relation to create.
        /// 
        /// The `memberType` field must contain a user with the `user.name` and
        /// `user.type` fields populated. The server will assign a resource name
        /// and overwrite anything specified.
        /// 
        /// When a Chat app creates a membership relation for a human user, it must use
        /// certain authorization scopes and set specific values for certain fields:
        /// 
        /// - When [authenticating as a
        /// user](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user),
        /// the `chat.memberships` authorization scope is required.
        /// 
        /// - When [authenticating as an
        /// app](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app),
        /// the `chat.app.memberships` authorization scope is required.
        /// 
        /// - Set `user.type` to `HUMAN`, and set `user.name` with format
        /// `users/{user}`, where `{user}` can be the email address for the user. For
        /// users in the same Workspace organization `{user}` can also be the `id` of
        /// the [person](https://developers.google.com/people/api/rest/v1/people) from
        /// the People API, or the `id` for the user in the Directory API. For example,
        /// if the People API Person profile ID for `user@example.com` is `123456789`,
        /// you can add the user to the space by setting the `membership.member.name`
        /// to `users/user@example.com` or `users/123456789`.
        /// 
        /// Inviting users external to the Workspace organization that owns the space
        /// requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
        /// 
        /// When a Chat app creates a membership relation for itself, it must
        /// [authenticate as a
        /// user](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// and use the `chat.memberships.app` scope, set `user.type` to `BOT`, and set
        /// `user.name` to `users/app`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> CreateMembershipAsync(string parent, Membership membership, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembershipAsync(new CreateMembershipRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Membership = gax::GaxPreconditions.CheckNotNull(membership, nameof(membership)),
            }, callSettings);

        /// <summary>
        /// Creates a membership for the calling Chat app, a user, or a Google Group.
        /// Creating memberships for other Chat apps isn't supported.
        /// When creating a membership, if the specified member has their auto-accept
        /// policy turned off, then they're invited, and must accept the space
        /// invitation before joining. Otherwise, creating a membership adds the member
        /// directly to the specified space.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.memberships.app` (to add the
        /// calling app to the space)
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// 
        /// App authentication is not supported for the following use cases:
        /// 
        /// - Inviting users external to the Workspace organization that owns the
        /// space.
        /// - Adding a Google Group to a space.
        /// - Adding a Chat app to a space.
        /// 
        /// For example usage, see:
        /// 
        /// - [Invite or add a user to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-user-membership).
        /// - [Invite or add a Google Group to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-group-membership).
        /// - [Add the Chat app to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-membership-calling-api).
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the space for which to create the
        /// membership.
        /// 
        /// Format: spaces/{space}
        /// </param>
        /// <param name="membership">
        /// Required. The membership relation to create.
        /// 
        /// The `memberType` field must contain a user with the `user.name` and
        /// `user.type` fields populated. The server will assign a resource name
        /// and overwrite anything specified.
        /// 
        /// When a Chat app creates a membership relation for a human user, it must use
        /// certain authorization scopes and set specific values for certain fields:
        /// 
        /// - When [authenticating as a
        /// user](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user),
        /// the `chat.memberships` authorization scope is required.
        /// 
        /// - When [authenticating as an
        /// app](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app),
        /// the `chat.app.memberships` authorization scope is required.
        /// 
        /// - Set `user.type` to `HUMAN`, and set `user.name` with format
        /// `users/{user}`, where `{user}` can be the email address for the user. For
        /// users in the same Workspace organization `{user}` can also be the `id` of
        /// the [person](https://developers.google.com/people/api/rest/v1/people) from
        /// the People API, or the `id` for the user in the Directory API. For example,
        /// if the People API Person profile ID for `user@example.com` is `123456789`,
        /// you can add the user to the space by setting the `membership.member.name`
        /// to `users/user@example.com` or `users/123456789`.
        /// 
        /// Inviting users external to the Workspace organization that owns the space
        /// requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
        /// 
        /// When a Chat app creates a membership relation for itself, it must
        /// [authenticate as a
        /// user](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// and use the `chat.memberships.app` scope, set `user.type` to `BOT`, and set
        /// `user.name` to `users/app`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> CreateMembershipAsync(string parent, Membership membership, st::CancellationToken cancellationToken) =>
            CreateMembershipAsync(parent, membership, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a membership for the calling Chat app, a user, or a Google Group.
        /// Creating memberships for other Chat apps isn't supported.
        /// When creating a membership, if the specified member has their auto-accept
        /// policy turned off, then they're invited, and must accept the space
        /// invitation before joining. Otherwise, creating a membership adds the member
        /// directly to the specified space.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.memberships.app` (to add the
        /// calling app to the space)
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// 
        /// App authentication is not supported for the following use cases:
        /// 
        /// - Inviting users external to the Workspace organization that owns the
        /// space.
        /// - Adding a Google Group to a space.
        /// - Adding a Chat app to a space.
        /// 
        /// For example usage, see:
        /// 
        /// - [Invite or add a user to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-user-membership).
        /// - [Invite or add a Google Group to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-group-membership).
        /// - [Add the Chat app to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-membership-calling-api).
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the space for which to create the
        /// membership.
        /// 
        /// Format: spaces/{space}
        /// </param>
        /// <param name="membership">
        /// Required. The membership relation to create.
        /// 
        /// The `memberType` field must contain a user with the `user.name` and
        /// `user.type` fields populated. The server will assign a resource name
        /// and overwrite anything specified.
        /// 
        /// When a Chat app creates a membership relation for a human user, it must use
        /// certain authorization scopes and set specific values for certain fields:
        /// 
        /// - When [authenticating as a
        /// user](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user),
        /// the `chat.memberships` authorization scope is required.
        /// 
        /// - When [authenticating as an
        /// app](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app),
        /// the `chat.app.memberships` authorization scope is required.
        /// 
        /// - Set `user.type` to `HUMAN`, and set `user.name` with format
        /// `users/{user}`, where `{user}` can be the email address for the user. For
        /// users in the same Workspace organization `{user}` can also be the `id` of
        /// the [person](https://developers.google.com/people/api/rest/v1/people) from
        /// the People API, or the `id` for the user in the Directory API. For example,
        /// if the People API Person profile ID for `user@example.com` is `123456789`,
        /// you can add the user to the space by setting the `membership.member.name`
        /// to `users/user@example.com` or `users/123456789`.
        /// 
        /// Inviting users external to the Workspace organization that owns the space
        /// requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
        /// 
        /// When a Chat app creates a membership relation for itself, it must
        /// [authenticate as a
        /// user](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// and use the `chat.memberships.app` scope, set `user.type` to `BOT`, and set
        /// `user.name` to `users/app`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Membership CreateMembership(SpaceName parent, Membership membership, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembership(new CreateMembershipRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Membership = gax::GaxPreconditions.CheckNotNull(membership, nameof(membership)),
            }, callSettings);

        /// <summary>
        /// Creates a membership for the calling Chat app, a user, or a Google Group.
        /// Creating memberships for other Chat apps isn't supported.
        /// When creating a membership, if the specified member has their auto-accept
        /// policy turned off, then they're invited, and must accept the space
        /// invitation before joining. Otherwise, creating a membership adds the member
        /// directly to the specified space.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.memberships.app` (to add the
        /// calling app to the space)
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// 
        /// App authentication is not supported for the following use cases:
        /// 
        /// - Inviting users external to the Workspace organization that owns the
        /// space.
        /// - Adding a Google Group to a space.
        /// - Adding a Chat app to a space.
        /// 
        /// For example usage, see:
        /// 
        /// - [Invite or add a user to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-user-membership).
        /// - [Invite or add a Google Group to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-group-membership).
        /// - [Add the Chat app to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-membership-calling-api).
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the space for which to create the
        /// membership.
        /// 
        /// Format: spaces/{space}
        /// </param>
        /// <param name="membership">
        /// Required. The membership relation to create.
        /// 
        /// The `memberType` field must contain a user with the `user.name` and
        /// `user.type` fields populated. The server will assign a resource name
        /// and overwrite anything specified.
        /// 
        /// When a Chat app creates a membership relation for a human user, it must use
        /// certain authorization scopes and set specific values for certain fields:
        /// 
        /// - When [authenticating as a
        /// user](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user),
        /// the `chat.memberships` authorization scope is required.
        /// 
        /// - When [authenticating as an
        /// app](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app),
        /// the `chat.app.memberships` authorization scope is required.
        /// 
        /// - Set `user.type` to `HUMAN`, and set `user.name` with format
        /// `users/{user}`, where `{user}` can be the email address for the user. For
        /// users in the same Workspace organization `{user}` can also be the `id` of
        /// the [person](https://developers.google.com/people/api/rest/v1/people) from
        /// the People API, or the `id` for the user in the Directory API. For example,
        /// if the People API Person profile ID for `user@example.com` is `123456789`,
        /// you can add the user to the space by setting the `membership.member.name`
        /// to `users/user@example.com` or `users/123456789`.
        /// 
        /// Inviting users external to the Workspace organization that owns the space
        /// requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
        /// 
        /// When a Chat app creates a membership relation for itself, it must
        /// [authenticate as a
        /// user](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// and use the `chat.memberships.app` scope, set `user.type` to `BOT`, and set
        /// `user.name` to `users/app`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> CreateMembershipAsync(SpaceName parent, Membership membership, gaxgrpc::CallSettings callSettings = null) =>
            CreateMembershipAsync(new CreateMembershipRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Membership = gax::GaxPreconditions.CheckNotNull(membership, nameof(membership)),
            }, callSettings);

        /// <summary>
        /// Creates a membership for the calling Chat app, a user, or a Google Group.
        /// Creating memberships for other Chat apps isn't supported.
        /// When creating a membership, if the specified member has their auto-accept
        /// policy turned off, then they're invited, and must accept the space
        /// invitation before joining. Otherwise, creating a membership adds the member
        /// directly to the specified space.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.memberships.app` (to add the
        /// calling app to the space)
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// 
        /// App authentication is not supported for the following use cases:
        /// 
        /// - Inviting users external to the Workspace organization that owns the
        /// space.
        /// - Adding a Google Group to a space.
        /// - Adding a Chat app to a space.
        /// 
        /// For example usage, see:
        /// 
        /// - [Invite or add a user to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-user-membership).
        /// - [Invite or add a Google Group to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-group-membership).
        /// - [Add the Chat app to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-membership-calling-api).
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the space for which to create the
        /// membership.
        /// 
        /// Format: spaces/{space}
        /// </param>
        /// <param name="membership">
        /// Required. The membership relation to create.
        /// 
        /// The `memberType` field must contain a user with the `user.name` and
        /// `user.type` fields populated. The server will assign a resource name
        /// and overwrite anything specified.
        /// 
        /// When a Chat app creates a membership relation for a human user, it must use
        /// certain authorization scopes and set specific values for certain fields:
        /// 
        /// - When [authenticating as a
        /// user](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user),
        /// the `chat.memberships` authorization scope is required.
        /// 
        /// - When [authenticating as an
        /// app](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app),
        /// the `chat.app.memberships` authorization scope is required.
        /// 
        /// - Set `user.type` to `HUMAN`, and set `user.name` with format
        /// `users/{user}`, where `{user}` can be the email address for the user. For
        /// users in the same Workspace organization `{user}` can also be the `id` of
        /// the [person](https://developers.google.com/people/api/rest/v1/people) from
        /// the People API, or the `id` for the user in the Directory API. For example,
        /// if the People API Person profile ID for `user@example.com` is `123456789`,
        /// you can add the user to the space by setting the `membership.member.name`
        /// to `users/user@example.com` or `users/123456789`.
        /// 
        /// Inviting users external to the Workspace organization that owns the space
        /// requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user).
        /// 
        /// When a Chat app creates a membership relation for itself, it must
        /// [authenticate as a
        /// user](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// and use the `chat.memberships.app` scope, set `user.type` to `BOT`, and set
        /// `user.name` to `users/app`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> CreateMembershipAsync(SpaceName parent, Membership membership, st::CancellationToken cancellationToken) =>
            CreateMembershipAsync(parent, membership, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a membership. For an example, see [Update a user's membership in
        /// a space](https://developers.google.com/workspace/chat/update-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth) and the
        /// authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (only in
        /// spaces the app created)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Membership UpdateMembership(UpdateMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a membership. For an example, see [Update a user's membership in
        /// a space](https://developers.google.com/workspace/chat/update-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth) and the
        /// authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (only in
        /// spaces the app created)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> UpdateMembershipAsync(UpdateMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a membership. For an example, see [Update a user's membership in
        /// a space](https://developers.google.com/workspace/chat/update-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth) and the
        /// authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (only in
        /// spaces the app created)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> UpdateMembershipAsync(UpdateMembershipRequest request, st::CancellationToken cancellationToken) =>
            UpdateMembershipAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a membership. For an example, see [Update a user's membership in
        /// a space](https://developers.google.com/workspace/chat/update-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth) and the
        /// authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (only in
        /// spaces the app created)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="membership">
        /// Required. The membership to update. Only fields specified by `update_mask`
        /// are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field paths to update. Separate multiple values with commas
        /// or use `*` to update all field paths.
        /// 
        /// Currently supported field paths:
        /// 
        /// - `role`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Membership UpdateMembership(Membership membership, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMembership(new UpdateMembershipRequest
            {
                Membership = gax::GaxPreconditions.CheckNotNull(membership, nameof(membership)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a membership. For an example, see [Update a user's membership in
        /// a space](https://developers.google.com/workspace/chat/update-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth) and the
        /// authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (only in
        /// spaces the app created)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="membership">
        /// Required. The membership to update. Only fields specified by `update_mask`
        /// are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field paths to update. Separate multiple values with commas
        /// or use `*` to update all field paths.
        /// 
        /// Currently supported field paths:
        /// 
        /// - `role`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> UpdateMembershipAsync(Membership membership, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMembershipAsync(new UpdateMembershipRequest
            {
                Membership = gax::GaxPreconditions.CheckNotNull(membership, nameof(membership)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a membership. For an example, see [Update a user's membership in
        /// a space](https://developers.google.com/workspace/chat/update-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth) and the
        /// authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (only in
        /// spaces the app created)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="membership">
        /// Required. The membership to update. Only fields specified by `update_mask`
        /// are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field paths to update. Separate multiple values with commas
        /// or use `*` to update all field paths.
        /// 
        /// Currently supported field paths:
        /// 
        /// - `role`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> UpdateMembershipAsync(Membership membership, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMembershipAsync(membership, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a membership. For an example, see
        /// [Remove a user or a Google Chat app from a
        /// space](https://developers.google.com/workspace/chat/delete-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.memberships.app` (to remove
        /// the calling app from the space)
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// 
        /// App authentication is not supported for the following use cases:
        /// 
        /// - Removing a Google Group from a space.
        /// - Removing a Chat app from a space.
        /// 
        /// To delete memberships for space managers, the requester
        /// must be a space manager. If you're using [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// the Chat app must be the space creator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Membership DeleteMembership(DeleteMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a membership. For an example, see
        /// [Remove a user or a Google Chat app from a
        /// space](https://developers.google.com/workspace/chat/delete-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.memberships.app` (to remove
        /// the calling app from the space)
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// 
        /// App authentication is not supported for the following use cases:
        /// 
        /// - Removing a Google Group from a space.
        /// - Removing a Chat app from a space.
        /// 
        /// To delete memberships for space managers, the requester
        /// must be a space manager. If you're using [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// the Chat app must be the space creator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> DeleteMembershipAsync(DeleteMembershipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a membership. For an example, see
        /// [Remove a user or a Google Chat app from a
        /// space](https://developers.google.com/workspace/chat/delete-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.memberships.app` (to remove
        /// the calling app from the space)
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// 
        /// App authentication is not supported for the following use cases:
        /// 
        /// - Removing a Google Group from a space.
        /// - Removing a Chat app from a space.
        /// 
        /// To delete memberships for space managers, the requester
        /// must be a space manager. If you're using [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// the Chat app must be the space creator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> DeleteMembershipAsync(DeleteMembershipRequest request, st::CancellationToken cancellationToken) =>
            DeleteMembershipAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a membership. For an example, see
        /// [Remove a user or a Google Chat app from a
        /// space](https://developers.google.com/workspace/chat/delete-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.memberships.app` (to remove
        /// the calling app from the space)
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// 
        /// App authentication is not supported for the following use cases:
        /// 
        /// - Removing a Google Group from a space.
        /// - Removing a Chat app from a space.
        /// 
        /// To delete memberships for space managers, the requester
        /// must be a space manager. If you're using [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// the Chat app must be the space creator.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the membership to delete. Chat apps can delete
        /// human users' or their own memberships. Chat apps can't delete other apps'
        /// memberships.
        /// 
        /// When deleting a human membership, requires the `chat.memberships` scope
        /// with [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// or the `chat.memberships.app` scope with [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// and the `spaces/{space}/members/{member}` format.
        /// You can use the email as an alias for `{member}`. For example,
        /// `spaces/{space}/members/example@gmail.com` where `example@gmail.com` is the
        /// email of the Google Chat user.
        /// 
        /// When deleting an app membership, requires the `chat.memberships.app` scope
        /// and `spaces/{space}/members/app` format.
        /// 
        /// Format: `spaces/{space}/members/{member}` or `spaces/{space}/members/app`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Membership DeleteMembership(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMembership(new DeleteMembershipRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a membership. For an example, see
        /// [Remove a user or a Google Chat app from a
        /// space](https://developers.google.com/workspace/chat/delete-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.memberships.app` (to remove
        /// the calling app from the space)
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// 
        /// App authentication is not supported for the following use cases:
        /// 
        /// - Removing a Google Group from a space.
        /// - Removing a Chat app from a space.
        /// 
        /// To delete memberships for space managers, the requester
        /// must be a space manager. If you're using [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// the Chat app must be the space creator.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the membership to delete. Chat apps can delete
        /// human users' or their own memberships. Chat apps can't delete other apps'
        /// memberships.
        /// 
        /// When deleting a human membership, requires the `chat.memberships` scope
        /// with [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// or the `chat.memberships.app` scope with [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// and the `spaces/{space}/members/{member}` format.
        /// You can use the email as an alias for `{member}`. For example,
        /// `spaces/{space}/members/example@gmail.com` where `example@gmail.com` is the
        /// email of the Google Chat user.
        /// 
        /// When deleting an app membership, requires the `chat.memberships.app` scope
        /// and `spaces/{space}/members/app` format.
        /// 
        /// Format: `spaces/{space}/members/{member}` or `spaces/{space}/members/app`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> DeleteMembershipAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMembershipAsync(new DeleteMembershipRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a membership. For an example, see
        /// [Remove a user or a Google Chat app from a
        /// space](https://developers.google.com/workspace/chat/delete-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.memberships.app` (to remove
        /// the calling app from the space)
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// 
        /// App authentication is not supported for the following use cases:
        /// 
        /// - Removing a Google Group from a space.
        /// - Removing a Chat app from a space.
        /// 
        /// To delete memberships for space managers, the requester
        /// must be a space manager. If you're using [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// the Chat app must be the space creator.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the membership to delete. Chat apps can delete
        /// human users' or their own memberships. Chat apps can't delete other apps'
        /// memberships.
        /// 
        /// When deleting a human membership, requires the `chat.memberships` scope
        /// with [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// or the `chat.memberships.app` scope with [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// and the `spaces/{space}/members/{member}` format.
        /// You can use the email as an alias for `{member}`. For example,
        /// `spaces/{space}/members/example@gmail.com` where `example@gmail.com` is the
        /// email of the Google Chat user.
        /// 
        /// When deleting an app membership, requires the `chat.memberships.app` scope
        /// and `spaces/{space}/members/app` format.
        /// 
        /// Format: `spaces/{space}/members/{member}` or `spaces/{space}/members/app`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> DeleteMembershipAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMembershipAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a membership. For an example, see
        /// [Remove a user or a Google Chat app from a
        /// space](https://developers.google.com/workspace/chat/delete-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.memberships.app` (to remove
        /// the calling app from the space)
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// 
        /// App authentication is not supported for the following use cases:
        /// 
        /// - Removing a Google Group from a space.
        /// - Removing a Chat app from a space.
        /// 
        /// To delete memberships for space managers, the requester
        /// must be a space manager. If you're using [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// the Chat app must be the space creator.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the membership to delete. Chat apps can delete
        /// human users' or their own memberships. Chat apps can't delete other apps'
        /// memberships.
        /// 
        /// When deleting a human membership, requires the `chat.memberships` scope
        /// with [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// or the `chat.memberships.app` scope with [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// and the `spaces/{space}/members/{member}` format.
        /// You can use the email as an alias for `{member}`. For example,
        /// `spaces/{space}/members/example@gmail.com` where `example@gmail.com` is the
        /// email of the Google Chat user.
        /// 
        /// When deleting an app membership, requires the `chat.memberships.app` scope
        /// and `spaces/{space}/members/app` format.
        /// 
        /// Format: `spaces/{space}/members/{member}` or `spaces/{space}/members/app`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Membership DeleteMembership(MembershipName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMembership(new DeleteMembershipRequest
            {
                MembershipName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a membership. For an example, see
        /// [Remove a user or a Google Chat app from a
        /// space](https://developers.google.com/workspace/chat/delete-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.memberships.app` (to remove
        /// the calling app from the space)
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// 
        /// App authentication is not supported for the following use cases:
        /// 
        /// - Removing a Google Group from a space.
        /// - Removing a Chat app from a space.
        /// 
        /// To delete memberships for space managers, the requester
        /// must be a space manager. If you're using [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// the Chat app must be the space creator.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the membership to delete. Chat apps can delete
        /// human users' or their own memberships. Chat apps can't delete other apps'
        /// memberships.
        /// 
        /// When deleting a human membership, requires the `chat.memberships` scope
        /// with [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// or the `chat.memberships.app` scope with [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// and the `spaces/{space}/members/{member}` format.
        /// You can use the email as an alias for `{member}`. For example,
        /// `spaces/{space}/members/example@gmail.com` where `example@gmail.com` is the
        /// email of the Google Chat user.
        /// 
        /// When deleting an app membership, requires the `chat.memberships.app` scope
        /// and `spaces/{space}/members/app` format.
        /// 
        /// Format: `spaces/{space}/members/{member}` or `spaces/{space}/members/app`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> DeleteMembershipAsync(MembershipName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMembershipAsync(new DeleteMembershipRequest
            {
                MembershipName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a membership. For an example, see
        /// [Remove a user or a Google Chat app from a
        /// space](https://developers.google.com/workspace/chat/delete-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.memberships.app` (to remove
        /// the calling app from the space)
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// 
        /// App authentication is not supported for the following use cases:
        /// 
        /// - Removing a Google Group from a space.
        /// - Removing a Chat app from a space.
        /// 
        /// To delete memberships for space managers, the requester
        /// must be a space manager. If you're using [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// the Chat app must be the space creator.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the membership to delete. Chat apps can delete
        /// human users' or their own memberships. Chat apps can't delete other apps'
        /// memberships.
        /// 
        /// When deleting a human membership, requires the `chat.memberships` scope
        /// with [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// or the `chat.memberships.app` scope with [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// and the `spaces/{space}/members/{member}` format.
        /// You can use the email as an alias for `{member}`. For example,
        /// `spaces/{space}/members/example@gmail.com` where `example@gmail.com` is the
        /// email of the Google Chat user.
        /// 
        /// When deleting an app membership, requires the `chat.memberships.app` scope
        /// and `spaces/{space}/members/app` format.
        /// 
        /// Format: `spaces/{space}/members/{member}` or `spaces/{space}/members/app`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Membership> DeleteMembershipAsync(MembershipName name, st::CancellationToken cancellationToken) =>
            DeleteMembershipAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a reaction and adds it to a message. For an example, see
        /// [Add a reaction to a
        /// message](https://developers.google.com/workspace/chat/create-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.create`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Reaction CreateReaction(CreateReactionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a reaction and adds it to a message. For an example, see
        /// [Add a reaction to a
        /// message](https://developers.google.com/workspace/chat/create-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.create`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reaction> CreateReactionAsync(CreateReactionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a reaction and adds it to a message. For an example, see
        /// [Add a reaction to a
        /// message](https://developers.google.com/workspace/chat/create-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.create`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reaction> CreateReactionAsync(CreateReactionRequest request, st::CancellationToken cancellationToken) =>
            CreateReactionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a reaction and adds it to a message. For an example, see
        /// [Add a reaction to a
        /// message](https://developers.google.com/workspace/chat/create-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.create`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="parent">
        /// Required. The message where the reaction is created.
        /// 
        /// Format: `spaces/{space}/messages/{message}`
        /// </param>
        /// <param name="reaction">
        /// Required. The reaction to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Reaction CreateReaction(string parent, Reaction reaction, gaxgrpc::CallSettings callSettings = null) =>
            CreateReaction(new CreateReactionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Reaction = gax::GaxPreconditions.CheckNotNull(reaction, nameof(reaction)),
            }, callSettings);

        /// <summary>
        /// Creates a reaction and adds it to a message. For an example, see
        /// [Add a reaction to a
        /// message](https://developers.google.com/workspace/chat/create-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.create`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="parent">
        /// Required. The message where the reaction is created.
        /// 
        /// Format: `spaces/{space}/messages/{message}`
        /// </param>
        /// <param name="reaction">
        /// Required. The reaction to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reaction> CreateReactionAsync(string parent, Reaction reaction, gaxgrpc::CallSettings callSettings = null) =>
            CreateReactionAsync(new CreateReactionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Reaction = gax::GaxPreconditions.CheckNotNull(reaction, nameof(reaction)),
            }, callSettings);

        /// <summary>
        /// Creates a reaction and adds it to a message. For an example, see
        /// [Add a reaction to a
        /// message](https://developers.google.com/workspace/chat/create-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.create`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="parent">
        /// Required. The message where the reaction is created.
        /// 
        /// Format: `spaces/{space}/messages/{message}`
        /// </param>
        /// <param name="reaction">
        /// Required. The reaction to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reaction> CreateReactionAsync(string parent, Reaction reaction, st::CancellationToken cancellationToken) =>
            CreateReactionAsync(parent, reaction, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a reaction and adds it to a message. For an example, see
        /// [Add a reaction to a
        /// message](https://developers.google.com/workspace/chat/create-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.create`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="parent">
        /// Required. The message where the reaction is created.
        /// 
        /// Format: `spaces/{space}/messages/{message}`
        /// </param>
        /// <param name="reaction">
        /// Required. The reaction to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Reaction CreateReaction(MessageName parent, Reaction reaction, gaxgrpc::CallSettings callSettings = null) =>
            CreateReaction(new CreateReactionRequest
            {
                ParentAsMessageName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Reaction = gax::GaxPreconditions.CheckNotNull(reaction, nameof(reaction)),
            }, callSettings);

        /// <summary>
        /// Creates a reaction and adds it to a message. For an example, see
        /// [Add a reaction to a
        /// message](https://developers.google.com/workspace/chat/create-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.create`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="parent">
        /// Required. The message where the reaction is created.
        /// 
        /// Format: `spaces/{space}/messages/{message}`
        /// </param>
        /// <param name="reaction">
        /// Required. The reaction to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reaction> CreateReactionAsync(MessageName parent, Reaction reaction, gaxgrpc::CallSettings callSettings = null) =>
            CreateReactionAsync(new CreateReactionRequest
            {
                ParentAsMessageName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Reaction = gax::GaxPreconditions.CheckNotNull(reaction, nameof(reaction)),
            }, callSettings);

        /// <summary>
        /// Creates a reaction and adds it to a message. For an example, see
        /// [Add a reaction to a
        /// message](https://developers.google.com/workspace/chat/create-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.create`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="parent">
        /// Required. The message where the reaction is created.
        /// 
        /// Format: `spaces/{space}/messages/{message}`
        /// </param>
        /// <param name="reaction">
        /// Required. The reaction to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reaction> CreateReactionAsync(MessageName parent, Reaction reaction, st::CancellationToken cancellationToken) =>
            CreateReactionAsync(parent, reaction, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists reactions to a message. For an example, see
        /// [List reactions for a
        /// message](https://developers.google.com/workspace/chat/list-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Reaction"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReactionsResponse, Reaction> ListReactions(ListReactionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists reactions to a message. For an example, see
        /// [List reactions for a
        /// message](https://developers.google.com/workspace/chat/list-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Reaction"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReactionsResponse, Reaction> ListReactionsAsync(ListReactionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists reactions to a message. For an example, see
        /// [List reactions for a
        /// message](https://developers.google.com/workspace/chat/list-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// </summary>
        /// <param name="parent">
        /// Required. The message users reacted to.
        /// 
        /// Format: `spaces/{space}/messages/{message}`
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
        /// <returns>A pageable sequence of <see cref="Reaction"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReactionsResponse, Reaction> ListReactions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReactionsRequest request = new ListReactionsRequest
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
            return ListReactions(request, callSettings);
        }

        /// <summary>
        /// Lists reactions to a message. For an example, see
        /// [List reactions for a
        /// message](https://developers.google.com/workspace/chat/list-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// </summary>
        /// <param name="parent">
        /// Required. The message users reacted to.
        /// 
        /// Format: `spaces/{space}/messages/{message}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Reaction"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReactionsResponse, Reaction> ListReactionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReactionsRequest request = new ListReactionsRequest
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
            return ListReactionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists reactions to a message. For an example, see
        /// [List reactions for a
        /// message](https://developers.google.com/workspace/chat/list-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// </summary>
        /// <param name="parent">
        /// Required. The message users reacted to.
        /// 
        /// Format: `spaces/{space}/messages/{message}`
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
        /// <returns>A pageable sequence of <see cref="Reaction"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReactionsResponse, Reaction> ListReactions(MessageName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReactionsRequest request = new ListReactionsRequest
            {
                ParentAsMessageName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListReactions(request, callSettings);
        }

        /// <summary>
        /// Lists reactions to a message. For an example, see
        /// [List reactions for a
        /// message](https://developers.google.com/workspace/chat/list-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// </summary>
        /// <param name="parent">
        /// Required. The message users reacted to.
        /// 
        /// Format: `spaces/{space}/messages/{message}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Reaction"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReactionsResponse, Reaction> ListReactionsAsync(MessageName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReactionsRequest request = new ListReactionsRequest
            {
                ParentAsMessageName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListReactionsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a reaction to a message. For an example, see
        /// [Delete a
        /// reaction](https://developers.google.com/workspace/chat/delete-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteReaction(DeleteReactionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a reaction to a message. For an example, see
        /// [Delete a
        /// reaction](https://developers.google.com/workspace/chat/delete-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReactionAsync(DeleteReactionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a reaction to a message. For an example, see
        /// [Delete a
        /// reaction](https://developers.google.com/workspace/chat/delete-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReactionAsync(DeleteReactionRequest request, st::CancellationToken cancellationToken) =>
            DeleteReactionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a reaction to a message. For an example, see
        /// [Delete a
        /// reaction](https://developers.google.com/workspace/chat/delete-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="name">
        /// Required. Name of the reaction to delete.
        /// 
        /// Format: `spaces/{space}/messages/{message}/reactions/{reaction}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteReaction(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReaction(new DeleteReactionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a reaction to a message. For an example, see
        /// [Delete a
        /// reaction](https://developers.google.com/workspace/chat/delete-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="name">
        /// Required. Name of the reaction to delete.
        /// 
        /// Format: `spaces/{space}/messages/{message}/reactions/{reaction}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReactionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReactionAsync(new DeleteReactionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a reaction to a message. For an example, see
        /// [Delete a
        /// reaction](https://developers.google.com/workspace/chat/delete-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="name">
        /// Required. Name of the reaction to delete.
        /// 
        /// Format: `spaces/{space}/messages/{message}/reactions/{reaction}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReactionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteReactionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a reaction to a message. For an example, see
        /// [Delete a
        /// reaction](https://developers.google.com/workspace/chat/delete-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="name">
        /// Required. Name of the reaction to delete.
        /// 
        /// Format: `spaces/{space}/messages/{message}/reactions/{reaction}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteReaction(ReactionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReaction(new DeleteReactionRequest
            {
                ReactionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a reaction to a message. For an example, see
        /// [Delete a
        /// reaction](https://developers.google.com/workspace/chat/delete-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="name">
        /// Required. Name of the reaction to delete.
        /// 
        /// Format: `spaces/{space}/messages/{message}/reactions/{reaction}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReactionAsync(ReactionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReactionAsync(new DeleteReactionRequest
            {
                ReactionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a reaction to a message. For an example, see
        /// [Delete a
        /// reaction](https://developers.google.com/workspace/chat/delete-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="name">
        /// Required. Name of the reaction to delete.
        /// 
        /// Format: `spaces/{space}/messages/{message}/reactions/{reaction}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReactionAsync(ReactionName name, st::CancellationToken cancellationToken) =>
            DeleteReactionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a custom emoji.
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomEmoji CreateCustomEmoji(CreateCustomEmojiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a custom emoji.
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomEmoji> CreateCustomEmojiAsync(CreateCustomEmojiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a custom emoji.
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomEmoji> CreateCustomEmojiAsync(CreateCustomEmojiRequest request, st::CancellationToken cancellationToken) =>
            CreateCustomEmojiAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a custom emoji.
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="customEmoji">
        /// Required. The custom emoji to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomEmoji CreateCustomEmoji(CustomEmoji customEmoji, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomEmoji(new CreateCustomEmojiRequest
            {
                CustomEmoji = gax::GaxPreconditions.CheckNotNull(customEmoji, nameof(customEmoji)),
            }, callSettings);

        /// <summary>
        /// Creates a custom emoji.
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="customEmoji">
        /// Required. The custom emoji to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomEmoji> CreateCustomEmojiAsync(CustomEmoji customEmoji, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomEmojiAsync(new CreateCustomEmojiRequest
            {
                CustomEmoji = gax::GaxPreconditions.CheckNotNull(customEmoji, nameof(customEmoji)),
            }, callSettings);

        /// <summary>
        /// Creates a custom emoji.
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="customEmoji">
        /// Required. The custom emoji to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomEmoji> CreateCustomEmojiAsync(CustomEmoji customEmoji, st::CancellationToken cancellationToken) =>
            CreateCustomEmojiAsync(customEmoji, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns details about a custom emoji.
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis.readonly`
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomEmoji GetCustomEmoji(GetCustomEmojiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns details about a custom emoji.
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis.readonly`
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomEmoji> GetCustomEmojiAsync(GetCustomEmojiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns details about a custom emoji.
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis.readonly`
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomEmoji> GetCustomEmojiAsync(GetCustomEmojiRequest request, st::CancellationToken cancellationToken) =>
            GetCustomEmojiAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns details about a custom emoji.
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis.readonly`
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the custom emoji.
        /// 
        /// Format: `customEmojis/{customEmoji}`
        /// 
        /// You can use the emoji name as an alias for `{customEmoji}`. For example,
        /// `customEmojis/:example-emoji:` where `:example-emoji:` is the emoji name
        /// for a custom emoji.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomEmoji GetCustomEmoji(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomEmoji(new GetCustomEmojiRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details about a custom emoji.
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis.readonly`
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the custom emoji.
        /// 
        /// Format: `customEmojis/{customEmoji}`
        /// 
        /// You can use the emoji name as an alias for `{customEmoji}`. For example,
        /// `customEmojis/:example-emoji:` where `:example-emoji:` is the emoji name
        /// for a custom emoji.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomEmoji> GetCustomEmojiAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomEmojiAsync(new GetCustomEmojiRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details about a custom emoji.
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis.readonly`
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the custom emoji.
        /// 
        /// Format: `customEmojis/{customEmoji}`
        /// 
        /// You can use the emoji name as an alias for `{customEmoji}`. For example,
        /// `customEmojis/:example-emoji:` where `:example-emoji:` is the emoji name
        /// for a custom emoji.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomEmoji> GetCustomEmojiAsync(string name, st::CancellationToken cancellationToken) =>
            GetCustomEmojiAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns details about a custom emoji.
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis.readonly`
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the custom emoji.
        /// 
        /// Format: `customEmojis/{customEmoji}`
        /// 
        /// You can use the emoji name as an alias for `{customEmoji}`. For example,
        /// `customEmojis/:example-emoji:` where `:example-emoji:` is the emoji name
        /// for a custom emoji.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomEmoji GetCustomEmoji(CustomEmojiName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomEmoji(new GetCustomEmojiRequest
            {
                CustomEmojiName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details about a custom emoji.
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis.readonly`
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the custom emoji.
        /// 
        /// Format: `customEmojis/{customEmoji}`
        /// 
        /// You can use the emoji name as an alias for `{customEmoji}`. For example,
        /// `customEmojis/:example-emoji:` where `:example-emoji:` is the emoji name
        /// for a custom emoji.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomEmoji> GetCustomEmojiAsync(CustomEmojiName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomEmojiAsync(new GetCustomEmojiRequest
            {
                CustomEmojiName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details about a custom emoji.
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis.readonly`
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the custom emoji.
        /// 
        /// Format: `customEmojis/{customEmoji}`
        /// 
        /// You can use the emoji name as an alias for `{customEmoji}`. For example,
        /// `customEmojis/:example-emoji:` where `:example-emoji:` is the emoji name
        /// for a custom emoji.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomEmoji> GetCustomEmojiAsync(CustomEmojiName name, st::CancellationToken cancellationToken) =>
            GetCustomEmojiAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists custom emojis visible to the authenticated user.
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis.readonly`
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CustomEmoji"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomEmojisResponse, CustomEmoji> ListCustomEmojis(ListCustomEmojisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists custom emojis visible to the authenticated user.
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis.readonly`
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CustomEmoji"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomEmojisResponse, CustomEmoji> ListCustomEmojisAsync(ListCustomEmojisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists custom emojis visible to the authenticated user.
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis.readonly`
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CustomEmoji"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomEmojisResponse, CustomEmoji> ListCustomEmojis(string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomEmojisRequest request = new ListCustomEmojisRequest { };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCustomEmojis(request, callSettings);
        }

        /// <summary>
        /// Lists custom emojis visible to the authenticated user.
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis.readonly`
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CustomEmoji"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomEmojisResponse, CustomEmoji> ListCustomEmojisAsync(string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomEmojisRequest request = new ListCustomEmojisRequest { };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCustomEmojisAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a custom emoji. By default, users can only delete custom emoji they
        /// created. [Emoji managers](https://support.google.com/a/answer/12850085)
        /// assigned by the administrator can delete any custom emoji in the
        /// organization. See [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149).
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCustomEmoji(DeleteCustomEmojiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a custom emoji. By default, users can only delete custom emoji they
        /// created. [Emoji managers](https://support.google.com/a/answer/12850085)
        /// assigned by the administrator can delete any custom emoji in the
        /// organization. See [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149).
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCustomEmojiAsync(DeleteCustomEmojiRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a custom emoji. By default, users can only delete custom emoji they
        /// created. [Emoji managers](https://support.google.com/a/answer/12850085)
        /// assigned by the administrator can delete any custom emoji in the
        /// organization. See [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149).
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCustomEmojiAsync(DeleteCustomEmojiRequest request, st::CancellationToken cancellationToken) =>
            DeleteCustomEmojiAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a custom emoji. By default, users can only delete custom emoji they
        /// created. [Emoji managers](https://support.google.com/a/answer/12850085)
        /// assigned by the administrator can delete any custom emoji in the
        /// organization. See [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149).
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the custom emoji to delete.
        /// 
        /// Format: `customEmojis/{customEmoji}`
        /// 
        /// You can use the emoji name as an alias for `{customEmoji}`. For example,
        /// `customEmojis/:example-emoji:` where `:example-emoji:` is the emoji name
        /// for a custom emoji.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCustomEmoji(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomEmoji(new DeleteCustomEmojiRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a custom emoji. By default, users can only delete custom emoji they
        /// created. [Emoji managers](https://support.google.com/a/answer/12850085)
        /// assigned by the administrator can delete any custom emoji in the
        /// organization. See [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149).
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the custom emoji to delete.
        /// 
        /// Format: `customEmojis/{customEmoji}`
        /// 
        /// You can use the emoji name as an alias for `{customEmoji}`. For example,
        /// `customEmojis/:example-emoji:` where `:example-emoji:` is the emoji name
        /// for a custom emoji.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCustomEmojiAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomEmojiAsync(new DeleteCustomEmojiRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a custom emoji. By default, users can only delete custom emoji they
        /// created. [Emoji managers](https://support.google.com/a/answer/12850085)
        /// assigned by the administrator can delete any custom emoji in the
        /// organization. See [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149).
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the custom emoji to delete.
        /// 
        /// Format: `customEmojis/{customEmoji}`
        /// 
        /// You can use the emoji name as an alias for `{customEmoji}`. For example,
        /// `customEmojis/:example-emoji:` where `:example-emoji:` is the emoji name
        /// for a custom emoji.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCustomEmojiAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCustomEmojiAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a custom emoji. By default, users can only delete custom emoji they
        /// created. [Emoji managers](https://support.google.com/a/answer/12850085)
        /// assigned by the administrator can delete any custom emoji in the
        /// organization. See [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149).
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the custom emoji to delete.
        /// 
        /// Format: `customEmojis/{customEmoji}`
        /// 
        /// You can use the emoji name as an alias for `{customEmoji}`. For example,
        /// `customEmojis/:example-emoji:` where `:example-emoji:` is the emoji name
        /// for a custom emoji.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCustomEmoji(CustomEmojiName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomEmoji(new DeleteCustomEmojiRequest
            {
                CustomEmojiName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a custom emoji. By default, users can only delete custom emoji they
        /// created. [Emoji managers](https://support.google.com/a/answer/12850085)
        /// assigned by the administrator can delete any custom emoji in the
        /// organization. See [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149).
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the custom emoji to delete.
        /// 
        /// Format: `customEmojis/{customEmoji}`
        /// 
        /// You can use the emoji name as an alias for `{customEmoji}`. For example,
        /// `customEmojis/:example-emoji:` where `:example-emoji:` is the emoji name
        /// for a custom emoji.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCustomEmojiAsync(CustomEmojiName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomEmojiAsync(new DeleteCustomEmojiRequest
            {
                CustomEmojiName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a custom emoji. By default, users can only delete custom emoji they
        /// created. [Emoji managers](https://support.google.com/a/answer/12850085)
        /// assigned by the administrator can delete any custom emoji in the
        /// organization. See [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149).
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the custom emoji to delete.
        /// 
        /// Format: `customEmojis/{customEmoji}`
        /// 
        /// You can use the emoji name as an alias for `{customEmoji}`. For example,
        /// `customEmojis/:example-emoji:` where `:example-emoji:` is the emoji name
        /// for a custom emoji.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCustomEmojiAsync(CustomEmojiName name, st::CancellationToken cancellationToken) =>
            DeleteCustomEmojiAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns details about a user's read state within a space, used to identify
        /// read and unread messages. For an example, see [Get details about a user's
        /// space read
        /// state](https://developers.google.com/workspace/chat/get-space-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate.readonly`
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SpaceReadState GetSpaceReadState(GetSpaceReadStateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns details about a user's read state within a space, used to identify
        /// read and unread messages. For an example, see [Get details about a user's
        /// space read
        /// state](https://developers.google.com/workspace/chat/get-space-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate.readonly`
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceReadState> GetSpaceReadStateAsync(GetSpaceReadStateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns details about a user's read state within a space, used to identify
        /// read and unread messages. For an example, see [Get details about a user's
        /// space read
        /// state](https://developers.google.com/workspace/chat/get-space-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate.readonly`
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceReadState> GetSpaceReadStateAsync(GetSpaceReadStateRequest request, st::CancellationToken cancellationToken) =>
            GetSpaceReadStateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns details about a user's read state within a space, used to identify
        /// read and unread messages. For an example, see [Get details about a user's
        /// space read
        /// state](https://developers.google.com/workspace/chat/get-space-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate.readonly`
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space read state to retrieve.
        /// 
        /// Only supports getting read state for the calling user.
        /// 
        /// To refer to the calling user, set one of the following:
        /// 
        /// - The `me` alias. For example, `users/me/spaces/{space}/spaceReadState`.
        /// 
        /// - Their Workspace email address. For example,
        /// `users/user@example.com/spaces/{space}/spaceReadState`.
        /// 
        /// - Their user id. For example,
        /// `users/123456789/spaces/{space}/spaceReadState`.
        /// 
        /// Format: users/{user}/spaces/{space}/spaceReadState
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SpaceReadState GetSpaceReadState(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpaceReadState(new GetSpaceReadStateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details about a user's read state within a space, used to identify
        /// read and unread messages. For an example, see [Get details about a user's
        /// space read
        /// state](https://developers.google.com/workspace/chat/get-space-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate.readonly`
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space read state to retrieve.
        /// 
        /// Only supports getting read state for the calling user.
        /// 
        /// To refer to the calling user, set one of the following:
        /// 
        /// - The `me` alias. For example, `users/me/spaces/{space}/spaceReadState`.
        /// 
        /// - Their Workspace email address. For example,
        /// `users/user@example.com/spaces/{space}/spaceReadState`.
        /// 
        /// - Their user id. For example,
        /// `users/123456789/spaces/{space}/spaceReadState`.
        /// 
        /// Format: users/{user}/spaces/{space}/spaceReadState
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceReadState> GetSpaceReadStateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpaceReadStateAsync(new GetSpaceReadStateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details about a user's read state within a space, used to identify
        /// read and unread messages. For an example, see [Get details about a user's
        /// space read
        /// state](https://developers.google.com/workspace/chat/get-space-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate.readonly`
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space read state to retrieve.
        /// 
        /// Only supports getting read state for the calling user.
        /// 
        /// To refer to the calling user, set one of the following:
        /// 
        /// - The `me` alias. For example, `users/me/spaces/{space}/spaceReadState`.
        /// 
        /// - Their Workspace email address. For example,
        /// `users/user@example.com/spaces/{space}/spaceReadState`.
        /// 
        /// - Their user id. For example,
        /// `users/123456789/spaces/{space}/spaceReadState`.
        /// 
        /// Format: users/{user}/spaces/{space}/spaceReadState
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceReadState> GetSpaceReadStateAsync(string name, st::CancellationToken cancellationToken) =>
            GetSpaceReadStateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns details about a user's read state within a space, used to identify
        /// read and unread messages. For an example, see [Get details about a user's
        /// space read
        /// state](https://developers.google.com/workspace/chat/get-space-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate.readonly`
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space read state to retrieve.
        /// 
        /// Only supports getting read state for the calling user.
        /// 
        /// To refer to the calling user, set one of the following:
        /// 
        /// - The `me` alias. For example, `users/me/spaces/{space}/spaceReadState`.
        /// 
        /// - Their Workspace email address. For example,
        /// `users/user@example.com/spaces/{space}/spaceReadState`.
        /// 
        /// - Their user id. For example,
        /// `users/123456789/spaces/{space}/spaceReadState`.
        /// 
        /// Format: users/{user}/spaces/{space}/spaceReadState
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SpaceReadState GetSpaceReadState(SpaceReadStateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpaceReadState(new GetSpaceReadStateRequest
            {
                SpaceReadStateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details about a user's read state within a space, used to identify
        /// read and unread messages. For an example, see [Get details about a user's
        /// space read
        /// state](https://developers.google.com/workspace/chat/get-space-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate.readonly`
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space read state to retrieve.
        /// 
        /// Only supports getting read state for the calling user.
        /// 
        /// To refer to the calling user, set one of the following:
        /// 
        /// - The `me` alias. For example, `users/me/spaces/{space}/spaceReadState`.
        /// 
        /// - Their Workspace email address. For example,
        /// `users/user@example.com/spaces/{space}/spaceReadState`.
        /// 
        /// - Their user id. For example,
        /// `users/123456789/spaces/{space}/spaceReadState`.
        /// 
        /// Format: users/{user}/spaces/{space}/spaceReadState
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceReadState> GetSpaceReadStateAsync(SpaceReadStateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpaceReadStateAsync(new GetSpaceReadStateRequest
            {
                SpaceReadStateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details about a user's read state within a space, used to identify
        /// read and unread messages. For an example, see [Get details about a user's
        /// space read
        /// state](https://developers.google.com/workspace/chat/get-space-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate.readonly`
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the space read state to retrieve.
        /// 
        /// Only supports getting read state for the calling user.
        /// 
        /// To refer to the calling user, set one of the following:
        /// 
        /// - The `me` alias. For example, `users/me/spaces/{space}/spaceReadState`.
        /// 
        /// - Their Workspace email address. For example,
        /// `users/user@example.com/spaces/{space}/spaceReadState`.
        /// 
        /// - Their user id. For example,
        /// `users/123456789/spaces/{space}/spaceReadState`.
        /// 
        /// Format: users/{user}/spaces/{space}/spaceReadState
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceReadState> GetSpaceReadStateAsync(SpaceReadStateName name, st::CancellationToken cancellationToken) =>
            GetSpaceReadStateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a user's read state within a space, used to identify read and
        /// unread messages. For an example, see [Update a user's space read
        /// state](https://developers.google.com/workspace/chat/update-space-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SpaceReadState UpdateSpaceReadState(UpdateSpaceReadStateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a user's read state within a space, used to identify read and
        /// unread messages. For an example, see [Update a user's space read
        /// state](https://developers.google.com/workspace/chat/update-space-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceReadState> UpdateSpaceReadStateAsync(UpdateSpaceReadStateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a user's read state within a space, used to identify read and
        /// unread messages. For an example, see [Update a user's space read
        /// state](https://developers.google.com/workspace/chat/update-space-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceReadState> UpdateSpaceReadStateAsync(UpdateSpaceReadStateRequest request, st::CancellationToken cancellationToken) =>
            UpdateSpaceReadStateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a user's read state within a space, used to identify read and
        /// unread messages. For an example, see [Update a user's space read
        /// state](https://developers.google.com/workspace/chat/update-space-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="spaceReadState">
        /// Required. The space read state and fields to update.
        /// 
        /// Only supports updating read state for the calling user.
        /// 
        /// To refer to the calling user, set one of the following:
        /// 
        /// - The `me` alias. For example, `users/me/spaces/{space}/spaceReadState`.
        /// 
        /// - Their Workspace email address. For example,
        /// `users/user@example.com/spaces/{space}/spaceReadState`.
        /// 
        /// - Their user id. For example,
        /// `users/123456789/spaces/{space}/spaceReadState`.
        /// 
        /// Format: users/{user}/spaces/{space}/spaceReadState
        /// </param>
        /// <param name="updateMask">
        /// Required. The field paths to update. Currently supported field paths:
        /// 
        /// - `last_read_time`
        /// 
        /// When the `last_read_time` is before the latest message create time, the
        /// space appears as unread in the UI.
        /// 
        /// To mark the space as read, set `last_read_time` to any value later (larger)
        /// than the latest message create time. The `last_read_time` is coerced to
        /// match the latest message create time. Note that the space read state only
        /// affects the read state of messages that are visible in the space's
        /// top-level conversation. Replies in threads are unaffected by this
        /// timestamp, and instead rely on the thread read state.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SpaceReadState UpdateSpaceReadState(SpaceReadState spaceReadState, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSpaceReadState(new UpdateSpaceReadStateRequest
            {
                SpaceReadState = gax::GaxPreconditions.CheckNotNull(spaceReadState, nameof(spaceReadState)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a user's read state within a space, used to identify read and
        /// unread messages. For an example, see [Update a user's space read
        /// state](https://developers.google.com/workspace/chat/update-space-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="spaceReadState">
        /// Required. The space read state and fields to update.
        /// 
        /// Only supports updating read state for the calling user.
        /// 
        /// To refer to the calling user, set one of the following:
        /// 
        /// - The `me` alias. For example, `users/me/spaces/{space}/spaceReadState`.
        /// 
        /// - Their Workspace email address. For example,
        /// `users/user@example.com/spaces/{space}/spaceReadState`.
        /// 
        /// - Their user id. For example,
        /// `users/123456789/spaces/{space}/spaceReadState`.
        /// 
        /// Format: users/{user}/spaces/{space}/spaceReadState
        /// </param>
        /// <param name="updateMask">
        /// Required. The field paths to update. Currently supported field paths:
        /// 
        /// - `last_read_time`
        /// 
        /// When the `last_read_time` is before the latest message create time, the
        /// space appears as unread in the UI.
        /// 
        /// To mark the space as read, set `last_read_time` to any value later (larger)
        /// than the latest message create time. The `last_read_time` is coerced to
        /// match the latest message create time. Note that the space read state only
        /// affects the read state of messages that are visible in the space's
        /// top-level conversation. Replies in threads are unaffected by this
        /// timestamp, and instead rely on the thread read state.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceReadState> UpdateSpaceReadStateAsync(SpaceReadState spaceReadState, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSpaceReadStateAsync(new UpdateSpaceReadStateRequest
            {
                SpaceReadState = gax::GaxPreconditions.CheckNotNull(spaceReadState, nameof(spaceReadState)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a user's read state within a space, used to identify read and
        /// unread messages. For an example, see [Update a user's space read
        /// state](https://developers.google.com/workspace/chat/update-space-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="spaceReadState">
        /// Required. The space read state and fields to update.
        /// 
        /// Only supports updating read state for the calling user.
        /// 
        /// To refer to the calling user, set one of the following:
        /// 
        /// - The `me` alias. For example, `users/me/spaces/{space}/spaceReadState`.
        /// 
        /// - Their Workspace email address. For example,
        /// `users/user@example.com/spaces/{space}/spaceReadState`.
        /// 
        /// - Their user id. For example,
        /// `users/123456789/spaces/{space}/spaceReadState`.
        /// 
        /// Format: users/{user}/spaces/{space}/spaceReadState
        /// </param>
        /// <param name="updateMask">
        /// Required. The field paths to update. Currently supported field paths:
        /// 
        /// - `last_read_time`
        /// 
        /// When the `last_read_time` is before the latest message create time, the
        /// space appears as unread in the UI.
        /// 
        /// To mark the space as read, set `last_read_time` to any value later (larger)
        /// than the latest message create time. The `last_read_time` is coerced to
        /// match the latest message create time. Note that the space read state only
        /// affects the read state of messages that are visible in the space's
        /// top-level conversation. Replies in threads are unaffected by this
        /// timestamp, and instead rely on the thread read state.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceReadState> UpdateSpaceReadStateAsync(SpaceReadState spaceReadState, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSpaceReadStateAsync(spaceReadState, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns details about a user's read state within a thread, used to identify
        /// read and unread messages. For an example, see [Get details about a user's
        /// thread read
        /// state](https://developers.google.com/workspace/chat/get-thread-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate.readonly`
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ThreadReadState GetThreadReadState(GetThreadReadStateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns details about a user's read state within a thread, used to identify
        /// read and unread messages. For an example, see [Get details about a user's
        /// thread read
        /// state](https://developers.google.com/workspace/chat/get-thread-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate.readonly`
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ThreadReadState> GetThreadReadStateAsync(GetThreadReadStateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns details about a user's read state within a thread, used to identify
        /// read and unread messages. For an example, see [Get details about a user's
        /// thread read
        /// state](https://developers.google.com/workspace/chat/get-thread-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate.readonly`
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ThreadReadState> GetThreadReadStateAsync(GetThreadReadStateRequest request, st::CancellationToken cancellationToken) =>
            GetThreadReadStateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns details about a user's read state within a thread, used to identify
        /// read and unread messages. For an example, see [Get details about a user's
        /// thread read
        /// state](https://developers.google.com/workspace/chat/get-thread-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate.readonly`
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the thread read state to retrieve.
        /// 
        /// Only supports getting read state for the calling user.
        /// 
        /// To refer to the calling user, set one of the following:
        /// 
        /// - The `me` alias. For example,
        /// `users/me/spaces/{space}/threads/{thread}/threadReadState`.
        /// 
        /// - Their Workspace email address. For example,
        /// `users/user@example.com/spaces/{space}/threads/{thread}/threadReadState`.
        /// 
        /// - Their user id. For example,
        /// `users/123456789/spaces/{space}/threads/{thread}/threadReadState`.
        /// 
        /// Format: users/{user}/spaces/{space}/threads/{thread}/threadReadState
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ThreadReadState GetThreadReadState(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetThreadReadState(new GetThreadReadStateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details about a user's read state within a thread, used to identify
        /// read and unread messages. For an example, see [Get details about a user's
        /// thread read
        /// state](https://developers.google.com/workspace/chat/get-thread-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate.readonly`
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the thread read state to retrieve.
        /// 
        /// Only supports getting read state for the calling user.
        /// 
        /// To refer to the calling user, set one of the following:
        /// 
        /// - The `me` alias. For example,
        /// `users/me/spaces/{space}/threads/{thread}/threadReadState`.
        /// 
        /// - Their Workspace email address. For example,
        /// `users/user@example.com/spaces/{space}/threads/{thread}/threadReadState`.
        /// 
        /// - Their user id. For example,
        /// `users/123456789/spaces/{space}/threads/{thread}/threadReadState`.
        /// 
        /// Format: users/{user}/spaces/{space}/threads/{thread}/threadReadState
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ThreadReadState> GetThreadReadStateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetThreadReadStateAsync(new GetThreadReadStateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details about a user's read state within a thread, used to identify
        /// read and unread messages. For an example, see [Get details about a user's
        /// thread read
        /// state](https://developers.google.com/workspace/chat/get-thread-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate.readonly`
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the thread read state to retrieve.
        /// 
        /// Only supports getting read state for the calling user.
        /// 
        /// To refer to the calling user, set one of the following:
        /// 
        /// - The `me` alias. For example,
        /// `users/me/spaces/{space}/threads/{thread}/threadReadState`.
        /// 
        /// - Their Workspace email address. For example,
        /// `users/user@example.com/spaces/{space}/threads/{thread}/threadReadState`.
        /// 
        /// - Their user id. For example,
        /// `users/123456789/spaces/{space}/threads/{thread}/threadReadState`.
        /// 
        /// Format: users/{user}/spaces/{space}/threads/{thread}/threadReadState
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ThreadReadState> GetThreadReadStateAsync(string name, st::CancellationToken cancellationToken) =>
            GetThreadReadStateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns details about a user's read state within a thread, used to identify
        /// read and unread messages. For an example, see [Get details about a user's
        /// thread read
        /// state](https://developers.google.com/workspace/chat/get-thread-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate.readonly`
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the thread read state to retrieve.
        /// 
        /// Only supports getting read state for the calling user.
        /// 
        /// To refer to the calling user, set one of the following:
        /// 
        /// - The `me` alias. For example,
        /// `users/me/spaces/{space}/threads/{thread}/threadReadState`.
        /// 
        /// - Their Workspace email address. For example,
        /// `users/user@example.com/spaces/{space}/threads/{thread}/threadReadState`.
        /// 
        /// - Their user id. For example,
        /// `users/123456789/spaces/{space}/threads/{thread}/threadReadState`.
        /// 
        /// Format: users/{user}/spaces/{space}/threads/{thread}/threadReadState
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ThreadReadState GetThreadReadState(ThreadReadStateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetThreadReadState(new GetThreadReadStateRequest
            {
                ThreadReadStateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details about a user's read state within a thread, used to identify
        /// read and unread messages. For an example, see [Get details about a user's
        /// thread read
        /// state](https://developers.google.com/workspace/chat/get-thread-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate.readonly`
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the thread read state to retrieve.
        /// 
        /// Only supports getting read state for the calling user.
        /// 
        /// To refer to the calling user, set one of the following:
        /// 
        /// - The `me` alias. For example,
        /// `users/me/spaces/{space}/threads/{thread}/threadReadState`.
        /// 
        /// - Their Workspace email address. For example,
        /// `users/user@example.com/spaces/{space}/threads/{thread}/threadReadState`.
        /// 
        /// - Their user id. For example,
        /// `users/123456789/spaces/{space}/threads/{thread}/threadReadState`.
        /// 
        /// Format: users/{user}/spaces/{space}/threads/{thread}/threadReadState
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ThreadReadState> GetThreadReadStateAsync(ThreadReadStateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetThreadReadStateAsync(new GetThreadReadStateRequest
            {
                ThreadReadStateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details about a user's read state within a thread, used to identify
        /// read and unread messages. For an example, see [Get details about a user's
        /// thread read
        /// state](https://developers.google.com/workspace/chat/get-thread-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate.readonly`
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the thread read state to retrieve.
        /// 
        /// Only supports getting read state for the calling user.
        /// 
        /// To refer to the calling user, set one of the following:
        /// 
        /// - The `me` alias. For example,
        /// `users/me/spaces/{space}/threads/{thread}/threadReadState`.
        /// 
        /// - Their Workspace email address. For example,
        /// `users/user@example.com/spaces/{space}/threads/{thread}/threadReadState`.
        /// 
        /// - Their user id. For example,
        /// `users/123456789/spaces/{space}/threads/{thread}/threadReadState`.
        /// 
        /// Format: users/{user}/spaces/{space}/threads/{thread}/threadReadState
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ThreadReadState> GetThreadReadStateAsync(ThreadReadStateName name, st::CancellationToken cancellationToken) =>
            GetThreadReadStateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns an event from a Google Chat space. The [event
        /// payload](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.oneof_payload)
        /// contains the most recent version of the resource that changed. For example,
        /// if you request an event about a new message but the message was later
        /// updated, the server returns the updated `Message` resource in the event
        /// payload.
        /// 
        /// Note: The `permissionSettings` field is not returned in the Space
        /// object of the Space event data for this request.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with an [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes)
        /// appropriate for reading the requested data:
        /// 
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// 
        /// To get an event, the authenticated user must be a member of the space.
        /// 
        /// For an example, see [Get details about an
        /// event from a Google Chat
        /// space](https://developers.google.com/workspace/chat/get-space-event).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SpaceEvent GetSpaceEvent(GetSpaceEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns an event from a Google Chat space. The [event
        /// payload](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.oneof_payload)
        /// contains the most recent version of the resource that changed. For example,
        /// if you request an event about a new message but the message was later
        /// updated, the server returns the updated `Message` resource in the event
        /// payload.
        /// 
        /// Note: The `permissionSettings` field is not returned in the Space
        /// object of the Space event data for this request.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with an [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes)
        /// appropriate for reading the requested data:
        /// 
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// 
        /// To get an event, the authenticated user must be a member of the space.
        /// 
        /// For an example, see [Get details about an
        /// event from a Google Chat
        /// space](https://developers.google.com/workspace/chat/get-space-event).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceEvent> GetSpaceEventAsync(GetSpaceEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns an event from a Google Chat space. The [event
        /// payload](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.oneof_payload)
        /// contains the most recent version of the resource that changed. For example,
        /// if you request an event about a new message but the message was later
        /// updated, the server returns the updated `Message` resource in the event
        /// payload.
        /// 
        /// Note: The `permissionSettings` field is not returned in the Space
        /// object of the Space event data for this request.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with an [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes)
        /// appropriate for reading the requested data:
        /// 
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// 
        /// To get an event, the authenticated user must be a member of the space.
        /// 
        /// For an example, see [Get details about an
        /// event from a Google Chat
        /// space](https://developers.google.com/workspace/chat/get-space-event).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceEvent> GetSpaceEventAsync(GetSpaceEventRequest request, st::CancellationToken cancellationToken) =>
            GetSpaceEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns an event from a Google Chat space. The [event
        /// payload](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.oneof_payload)
        /// contains the most recent version of the resource that changed. For example,
        /// if you request an event about a new message but the message was later
        /// updated, the server returns the updated `Message` resource in the event
        /// payload.
        /// 
        /// Note: The `permissionSettings` field is not returned in the Space
        /// object of the Space event data for this request.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with an [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes)
        /// appropriate for reading the requested data:
        /// 
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// 
        /// To get an event, the authenticated user must be a member of the space.
        /// 
        /// For an example, see [Get details about an
        /// event from a Google Chat
        /// space](https://developers.google.com/workspace/chat/get-space-event).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the space event.
        /// 
        /// Format: `spaces/{space}/spaceEvents/{spaceEvent}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SpaceEvent GetSpaceEvent(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpaceEvent(new GetSpaceEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns an event from a Google Chat space. The [event
        /// payload](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.oneof_payload)
        /// contains the most recent version of the resource that changed. For example,
        /// if you request an event about a new message but the message was later
        /// updated, the server returns the updated `Message` resource in the event
        /// payload.
        /// 
        /// Note: The `permissionSettings` field is not returned in the Space
        /// object of the Space event data for this request.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with an [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes)
        /// appropriate for reading the requested data:
        /// 
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// 
        /// To get an event, the authenticated user must be a member of the space.
        /// 
        /// For an example, see [Get details about an
        /// event from a Google Chat
        /// space](https://developers.google.com/workspace/chat/get-space-event).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the space event.
        /// 
        /// Format: `spaces/{space}/spaceEvents/{spaceEvent}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceEvent> GetSpaceEventAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpaceEventAsync(new GetSpaceEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns an event from a Google Chat space. The [event
        /// payload](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.oneof_payload)
        /// contains the most recent version of the resource that changed. For example,
        /// if you request an event about a new message but the message was later
        /// updated, the server returns the updated `Message` resource in the event
        /// payload.
        /// 
        /// Note: The `permissionSettings` field is not returned in the Space
        /// object of the Space event data for this request.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with an [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes)
        /// appropriate for reading the requested data:
        /// 
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// 
        /// To get an event, the authenticated user must be a member of the space.
        /// 
        /// For an example, see [Get details about an
        /// event from a Google Chat
        /// space](https://developers.google.com/workspace/chat/get-space-event).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the space event.
        /// 
        /// Format: `spaces/{space}/spaceEvents/{spaceEvent}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceEvent> GetSpaceEventAsync(string name, st::CancellationToken cancellationToken) =>
            GetSpaceEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns an event from a Google Chat space. The [event
        /// payload](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.oneof_payload)
        /// contains the most recent version of the resource that changed. For example,
        /// if you request an event about a new message but the message was later
        /// updated, the server returns the updated `Message` resource in the event
        /// payload.
        /// 
        /// Note: The `permissionSettings` field is not returned in the Space
        /// object of the Space event data for this request.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with an [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes)
        /// appropriate for reading the requested data:
        /// 
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// 
        /// To get an event, the authenticated user must be a member of the space.
        /// 
        /// For an example, see [Get details about an
        /// event from a Google Chat
        /// space](https://developers.google.com/workspace/chat/get-space-event).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the space event.
        /// 
        /// Format: `spaces/{space}/spaceEvents/{spaceEvent}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SpaceEvent GetSpaceEvent(SpaceEventName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpaceEvent(new GetSpaceEventRequest
            {
                SpaceEventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns an event from a Google Chat space. The [event
        /// payload](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.oneof_payload)
        /// contains the most recent version of the resource that changed. For example,
        /// if you request an event about a new message but the message was later
        /// updated, the server returns the updated `Message` resource in the event
        /// payload.
        /// 
        /// Note: The `permissionSettings` field is not returned in the Space
        /// object of the Space event data for this request.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with an [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes)
        /// appropriate for reading the requested data:
        /// 
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// 
        /// To get an event, the authenticated user must be a member of the space.
        /// 
        /// For an example, see [Get details about an
        /// event from a Google Chat
        /// space](https://developers.google.com/workspace/chat/get-space-event).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the space event.
        /// 
        /// Format: `spaces/{space}/spaceEvents/{spaceEvent}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceEvent> GetSpaceEventAsync(SpaceEventName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpaceEventAsync(new GetSpaceEventRequest
            {
                SpaceEventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns an event from a Google Chat space. The [event
        /// payload](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.oneof_payload)
        /// contains the most recent version of the resource that changed. For example,
        /// if you request an event about a new message but the message was later
        /// updated, the server returns the updated `Message` resource in the event
        /// payload.
        /// 
        /// Note: The `permissionSettings` field is not returned in the Space
        /// object of the Space event data for this request.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with an [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes)
        /// appropriate for reading the requested data:
        /// 
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// 
        /// To get an event, the authenticated user must be a member of the space.
        /// 
        /// For an example, see [Get details about an
        /// event from a Google Chat
        /// space](https://developers.google.com/workspace/chat/get-space-event).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the space event.
        /// 
        /// Format: `spaces/{space}/spaceEvents/{spaceEvent}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceEvent> GetSpaceEventAsync(SpaceEventName name, st::CancellationToken cancellationToken) =>
            GetSpaceEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists events from a Google Chat space. For each event, the
        /// [payload](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.oneof_payload)
        /// contains the most recent version of the Chat resource. For example, if you
        /// list events about new space members, the server returns `Membership`
        /// resources that contain the latest membership details. If new members were
        /// removed during the requested period, the event payload contains an empty
        /// `Membership` resource.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with an [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes)
        /// appropriate for reading the requested data:
        /// 
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// 
        /// To list events, the authenticated user must be a member of the space.
        /// 
        /// For an example, see [List events from a Google Chat
        /// space](https://developers.google.com/workspace/chat/list-space-events).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SpaceEvent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSpaceEventsResponse, SpaceEvent> ListSpaceEvents(ListSpaceEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists events from a Google Chat space. For each event, the
        /// [payload](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.oneof_payload)
        /// contains the most recent version of the Chat resource. For example, if you
        /// list events about new space members, the server returns `Membership`
        /// resources that contain the latest membership details. If new members were
        /// removed during the requested period, the event payload contains an empty
        /// `Membership` resource.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with an [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes)
        /// appropriate for reading the requested data:
        /// 
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// 
        /// To list events, the authenticated user must be a member of the space.
        /// 
        /// For an example, see [List events from a Google Chat
        /// space](https://developers.google.com/workspace/chat/list-space-events).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SpaceEvent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSpaceEventsResponse, SpaceEvent> ListSpaceEventsAsync(ListSpaceEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists events from a Google Chat space. For each event, the
        /// [payload](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.oneof_payload)
        /// contains the most recent version of the Chat resource. For example, if you
        /// list events about new space members, the server returns `Membership`
        /// resources that contain the latest membership details. If new members were
        /// removed during the requested period, the event payload contains an empty
        /// `Membership` resource.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with an [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes)
        /// appropriate for reading the requested data:
        /// 
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// 
        /// To list events, the authenticated user must be a member of the space.
        /// 
        /// For an example, see [List events from a Google Chat
        /// space](https://developers.google.com/workspace/chat/list-space-events).
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the [Google Chat
        /// space](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces)
        /// where the events occurred.
        /// 
        /// Format: `spaces/{space}`.
        /// </param>
        /// <param name="filter">
        /// Required. A query filter.
        /// 
        /// You must specify at least one event type (`event_type`)
        /// using the has `:` operator. To filter by multiple event types, use the `OR`
        /// operator. Omit batch event types in your filter. The request automatically
        /// returns any related batch events. For example, if you filter by new
        /// reactions
        /// (`google.workspace.chat.reaction.v1.created`), the server also returns
        /// batch new reactions events
        /// (`google.workspace.chat.reaction.v1.batchCreated`). For a list of supported
        /// event types, see the [`SpaceEvents` reference
        /// documentation](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.event_type).
        /// 
        /// Optionally, you can also filter by start time (`start_time`) and
        /// end time (`end_time`):
        /// 
        /// * `start_time`: Exclusive timestamp from which to start listing space
        /// events.
        /// You can list events that occurred up to 28 days ago. If unspecified, lists
        /// space events from the past 28 days.
        /// * `end_time`: Inclusive timestamp until which space events are listed.
        /// If unspecified, lists events up to the time of the request.
        /// 
        /// To specify a start or end time, use the equals `=` operator and format in
        /// [RFC-3339](https://www.rfc-editor.org/rfc/rfc3339). To filter by both
        /// `start_time` and `end_time`, use the `AND` operator.
        /// 
        /// For example, the following queries are valid:
        /// 
        /// ```
        /// start_time="2023-08-23T19:20:33+00:00" AND
        /// end_time="2023-08-23T19:21:54+00:00"
        /// ```
        /// ```
        /// start_time="2023-08-23T19:20:33+00:00" AND
        /// (event_types:"google.workspace.chat.space.v1.updated" OR
        /// event_types:"google.workspace.chat.message.v1.created")
        /// ```
        /// 
        /// The following queries are invalid:
        /// 
        /// ```
        /// start_time="2023-08-23T19:20:33+00:00" OR
        /// end_time="2023-08-23T19:21:54+00:00"
        /// ```
        /// ```
        /// event_types:"google.workspace.chat.space.v1.updated" AND
        /// event_types:"google.workspace.chat.message.v1.created"
        /// ```
        /// 
        /// Invalid queries are rejected by the server with an `INVALID_ARGUMENT`
        /// error.
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
        /// <returns>A pageable sequence of <see cref="SpaceEvent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSpaceEventsResponse, SpaceEvent> ListSpaceEvents(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpaceEventsRequest request = new ListSpaceEventsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSpaceEvents(request, callSettings);
        }

        /// <summary>
        /// Lists events from a Google Chat space. For each event, the
        /// [payload](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.oneof_payload)
        /// contains the most recent version of the Chat resource. For example, if you
        /// list events about new space members, the server returns `Membership`
        /// resources that contain the latest membership details. If new members were
        /// removed during the requested period, the event payload contains an empty
        /// `Membership` resource.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with an [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes)
        /// appropriate for reading the requested data:
        /// 
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// 
        /// To list events, the authenticated user must be a member of the space.
        /// 
        /// For an example, see [List events from a Google Chat
        /// space](https://developers.google.com/workspace/chat/list-space-events).
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the [Google Chat
        /// space](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces)
        /// where the events occurred.
        /// 
        /// Format: `spaces/{space}`.
        /// </param>
        /// <param name="filter">
        /// Required. A query filter.
        /// 
        /// You must specify at least one event type (`event_type`)
        /// using the has `:` operator. To filter by multiple event types, use the `OR`
        /// operator. Omit batch event types in your filter. The request automatically
        /// returns any related batch events. For example, if you filter by new
        /// reactions
        /// (`google.workspace.chat.reaction.v1.created`), the server also returns
        /// batch new reactions events
        /// (`google.workspace.chat.reaction.v1.batchCreated`). For a list of supported
        /// event types, see the [`SpaceEvents` reference
        /// documentation](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.event_type).
        /// 
        /// Optionally, you can also filter by start time (`start_time`) and
        /// end time (`end_time`):
        /// 
        /// * `start_time`: Exclusive timestamp from which to start listing space
        /// events.
        /// You can list events that occurred up to 28 days ago. If unspecified, lists
        /// space events from the past 28 days.
        /// * `end_time`: Inclusive timestamp until which space events are listed.
        /// If unspecified, lists events up to the time of the request.
        /// 
        /// To specify a start or end time, use the equals `=` operator and format in
        /// [RFC-3339](https://www.rfc-editor.org/rfc/rfc3339). To filter by both
        /// `start_time` and `end_time`, use the `AND` operator.
        /// 
        /// For example, the following queries are valid:
        /// 
        /// ```
        /// start_time="2023-08-23T19:20:33+00:00" AND
        /// end_time="2023-08-23T19:21:54+00:00"
        /// ```
        /// ```
        /// start_time="2023-08-23T19:20:33+00:00" AND
        /// (event_types:"google.workspace.chat.space.v1.updated" OR
        /// event_types:"google.workspace.chat.message.v1.created")
        /// ```
        /// 
        /// The following queries are invalid:
        /// 
        /// ```
        /// start_time="2023-08-23T19:20:33+00:00" OR
        /// end_time="2023-08-23T19:21:54+00:00"
        /// ```
        /// ```
        /// event_types:"google.workspace.chat.space.v1.updated" AND
        /// event_types:"google.workspace.chat.message.v1.created"
        /// ```
        /// 
        /// Invalid queries are rejected by the server with an `INVALID_ARGUMENT`
        /// error.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SpaceEvent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSpaceEventsResponse, SpaceEvent> ListSpaceEventsAsync(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpaceEventsRequest request = new ListSpaceEventsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSpaceEventsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists events from a Google Chat space. For each event, the
        /// [payload](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.oneof_payload)
        /// contains the most recent version of the Chat resource. For example, if you
        /// list events about new space members, the server returns `Membership`
        /// resources that contain the latest membership details. If new members were
        /// removed during the requested period, the event payload contains an empty
        /// `Membership` resource.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with an [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes)
        /// appropriate for reading the requested data:
        /// 
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// 
        /// To list events, the authenticated user must be a member of the space.
        /// 
        /// For an example, see [List events from a Google Chat
        /// space](https://developers.google.com/workspace/chat/list-space-events).
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the [Google Chat
        /// space](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces)
        /// where the events occurred.
        /// 
        /// Format: `spaces/{space}`.
        /// </param>
        /// <param name="filter">
        /// Required. A query filter.
        /// 
        /// You must specify at least one event type (`event_type`)
        /// using the has `:` operator. To filter by multiple event types, use the `OR`
        /// operator. Omit batch event types in your filter. The request automatically
        /// returns any related batch events. For example, if you filter by new
        /// reactions
        /// (`google.workspace.chat.reaction.v1.created`), the server also returns
        /// batch new reactions events
        /// (`google.workspace.chat.reaction.v1.batchCreated`). For a list of supported
        /// event types, see the [`SpaceEvents` reference
        /// documentation](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.event_type).
        /// 
        /// Optionally, you can also filter by start time (`start_time`) and
        /// end time (`end_time`):
        /// 
        /// * `start_time`: Exclusive timestamp from which to start listing space
        /// events.
        /// You can list events that occurred up to 28 days ago. If unspecified, lists
        /// space events from the past 28 days.
        /// * `end_time`: Inclusive timestamp until which space events are listed.
        /// If unspecified, lists events up to the time of the request.
        /// 
        /// To specify a start or end time, use the equals `=` operator and format in
        /// [RFC-3339](https://www.rfc-editor.org/rfc/rfc3339). To filter by both
        /// `start_time` and `end_time`, use the `AND` operator.
        /// 
        /// For example, the following queries are valid:
        /// 
        /// ```
        /// start_time="2023-08-23T19:20:33+00:00" AND
        /// end_time="2023-08-23T19:21:54+00:00"
        /// ```
        /// ```
        /// start_time="2023-08-23T19:20:33+00:00" AND
        /// (event_types:"google.workspace.chat.space.v1.updated" OR
        /// event_types:"google.workspace.chat.message.v1.created")
        /// ```
        /// 
        /// The following queries are invalid:
        /// 
        /// ```
        /// start_time="2023-08-23T19:20:33+00:00" OR
        /// end_time="2023-08-23T19:21:54+00:00"
        /// ```
        /// ```
        /// event_types:"google.workspace.chat.space.v1.updated" AND
        /// event_types:"google.workspace.chat.message.v1.created"
        /// ```
        /// 
        /// Invalid queries are rejected by the server with an `INVALID_ARGUMENT`
        /// error.
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
        /// <returns>A pageable sequence of <see cref="SpaceEvent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSpaceEventsResponse, SpaceEvent> ListSpaceEvents(SpaceName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpaceEventsRequest request = new ListSpaceEventsRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSpaceEvents(request, callSettings);
        }

        /// <summary>
        /// Lists events from a Google Chat space. For each event, the
        /// [payload](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.oneof_payload)
        /// contains the most recent version of the Chat resource. For example, if you
        /// list events about new space members, the server returns `Membership`
        /// resources that contain the latest membership details. If new members were
        /// removed during the requested period, the event payload contains an empty
        /// `Membership` resource.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with an [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes)
        /// appropriate for reading the requested data:
        /// 
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// 
        /// To list events, the authenticated user must be a member of the space.
        /// 
        /// For an example, see [List events from a Google Chat
        /// space](https://developers.google.com/workspace/chat/list-space-events).
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the [Google Chat
        /// space](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces)
        /// where the events occurred.
        /// 
        /// Format: `spaces/{space}`.
        /// </param>
        /// <param name="filter">
        /// Required. A query filter.
        /// 
        /// You must specify at least one event type (`event_type`)
        /// using the has `:` operator. To filter by multiple event types, use the `OR`
        /// operator. Omit batch event types in your filter. The request automatically
        /// returns any related batch events. For example, if you filter by new
        /// reactions
        /// (`google.workspace.chat.reaction.v1.created`), the server also returns
        /// batch new reactions events
        /// (`google.workspace.chat.reaction.v1.batchCreated`). For a list of supported
        /// event types, see the [`SpaceEvents` reference
        /// documentation](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.event_type).
        /// 
        /// Optionally, you can also filter by start time (`start_time`) and
        /// end time (`end_time`):
        /// 
        /// * `start_time`: Exclusive timestamp from which to start listing space
        /// events.
        /// You can list events that occurred up to 28 days ago. If unspecified, lists
        /// space events from the past 28 days.
        /// * `end_time`: Inclusive timestamp until which space events are listed.
        /// If unspecified, lists events up to the time of the request.
        /// 
        /// To specify a start or end time, use the equals `=` operator and format in
        /// [RFC-3339](https://www.rfc-editor.org/rfc/rfc3339). To filter by both
        /// `start_time` and `end_time`, use the `AND` operator.
        /// 
        /// For example, the following queries are valid:
        /// 
        /// ```
        /// start_time="2023-08-23T19:20:33+00:00" AND
        /// end_time="2023-08-23T19:21:54+00:00"
        /// ```
        /// ```
        /// start_time="2023-08-23T19:20:33+00:00" AND
        /// (event_types:"google.workspace.chat.space.v1.updated" OR
        /// event_types:"google.workspace.chat.message.v1.created")
        /// ```
        /// 
        /// The following queries are invalid:
        /// 
        /// ```
        /// start_time="2023-08-23T19:20:33+00:00" OR
        /// end_time="2023-08-23T19:21:54+00:00"
        /// ```
        /// ```
        /// event_types:"google.workspace.chat.space.v1.updated" AND
        /// event_types:"google.workspace.chat.message.v1.created"
        /// ```
        /// 
        /// Invalid queries are rejected by the server with an `INVALID_ARGUMENT`
        /// error.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SpaceEvent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSpaceEventsResponse, SpaceEvent> ListSpaceEventsAsync(SpaceName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpaceEventsRequest request = new ListSpaceEventsRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSpaceEventsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the space notification setting. For an example, see [Get the
        /// caller's space notification
        /// setting](https://developers.google.com/workspace/chat/get-space-notification-setting).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.spacesettings`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SpaceNotificationSetting GetSpaceNotificationSetting(GetSpaceNotificationSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the space notification setting. For an example, see [Get the
        /// caller's space notification
        /// setting](https://developers.google.com/workspace/chat/get-space-notification-setting).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.spacesettings`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceNotificationSetting> GetSpaceNotificationSettingAsync(GetSpaceNotificationSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the space notification setting. For an example, see [Get the
        /// caller's space notification
        /// setting](https://developers.google.com/workspace/chat/get-space-notification-setting).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.spacesettings`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceNotificationSetting> GetSpaceNotificationSettingAsync(GetSpaceNotificationSettingRequest request, st::CancellationToken cancellationToken) =>
            GetSpaceNotificationSettingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the space notification setting. For an example, see [Get the
        /// caller's space notification
        /// setting](https://developers.google.com/workspace/chat/get-space-notification-setting).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.spacesettings`
        /// </summary>
        /// <param name="name">
        /// Required. Format: users/{user}/spaces/{space}/spaceNotificationSetting
        /// 
        /// - `users/me/spaces/{space}/spaceNotificationSetting`, OR
        /// - `users/user@example.com/spaces/{space}/spaceNotificationSetting`, OR
        /// - `users/123456789/spaces/{space}/spaceNotificationSetting`.
        /// Note: Only the caller's user id or email is allowed in the path.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SpaceNotificationSetting GetSpaceNotificationSetting(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpaceNotificationSetting(new GetSpaceNotificationSettingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the space notification setting. For an example, see [Get the
        /// caller's space notification
        /// setting](https://developers.google.com/workspace/chat/get-space-notification-setting).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.spacesettings`
        /// </summary>
        /// <param name="name">
        /// Required. Format: users/{user}/spaces/{space}/spaceNotificationSetting
        /// 
        /// - `users/me/spaces/{space}/spaceNotificationSetting`, OR
        /// - `users/user@example.com/spaces/{space}/spaceNotificationSetting`, OR
        /// - `users/123456789/spaces/{space}/spaceNotificationSetting`.
        /// Note: Only the caller's user id or email is allowed in the path.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceNotificationSetting> GetSpaceNotificationSettingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpaceNotificationSettingAsync(new GetSpaceNotificationSettingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the space notification setting. For an example, see [Get the
        /// caller's space notification
        /// setting](https://developers.google.com/workspace/chat/get-space-notification-setting).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.spacesettings`
        /// </summary>
        /// <param name="name">
        /// Required. Format: users/{user}/spaces/{space}/spaceNotificationSetting
        /// 
        /// - `users/me/spaces/{space}/spaceNotificationSetting`, OR
        /// - `users/user@example.com/spaces/{space}/spaceNotificationSetting`, OR
        /// - `users/123456789/spaces/{space}/spaceNotificationSetting`.
        /// Note: Only the caller's user id or email is allowed in the path.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceNotificationSetting> GetSpaceNotificationSettingAsync(string name, st::CancellationToken cancellationToken) =>
            GetSpaceNotificationSettingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the space notification setting. For an example, see [Get the
        /// caller's space notification
        /// setting](https://developers.google.com/workspace/chat/get-space-notification-setting).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.spacesettings`
        /// </summary>
        /// <param name="name">
        /// Required. Format: users/{user}/spaces/{space}/spaceNotificationSetting
        /// 
        /// - `users/me/spaces/{space}/spaceNotificationSetting`, OR
        /// - `users/user@example.com/spaces/{space}/spaceNotificationSetting`, OR
        /// - `users/123456789/spaces/{space}/spaceNotificationSetting`.
        /// Note: Only the caller's user id or email is allowed in the path.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SpaceNotificationSetting GetSpaceNotificationSetting(SpaceNotificationSettingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpaceNotificationSetting(new GetSpaceNotificationSettingRequest
            {
                SpaceNotificationSettingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the space notification setting. For an example, see [Get the
        /// caller's space notification
        /// setting](https://developers.google.com/workspace/chat/get-space-notification-setting).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.spacesettings`
        /// </summary>
        /// <param name="name">
        /// Required. Format: users/{user}/spaces/{space}/spaceNotificationSetting
        /// 
        /// - `users/me/spaces/{space}/spaceNotificationSetting`, OR
        /// - `users/user@example.com/spaces/{space}/spaceNotificationSetting`, OR
        /// - `users/123456789/spaces/{space}/spaceNotificationSetting`.
        /// Note: Only the caller's user id or email is allowed in the path.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceNotificationSetting> GetSpaceNotificationSettingAsync(SpaceNotificationSettingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpaceNotificationSettingAsync(new GetSpaceNotificationSettingRequest
            {
                SpaceNotificationSettingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the space notification setting. For an example, see [Get the
        /// caller's space notification
        /// setting](https://developers.google.com/workspace/chat/get-space-notification-setting).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.spacesettings`
        /// </summary>
        /// <param name="name">
        /// Required. Format: users/{user}/spaces/{space}/spaceNotificationSetting
        /// 
        /// - `users/me/spaces/{space}/spaceNotificationSetting`, OR
        /// - `users/user@example.com/spaces/{space}/spaceNotificationSetting`, OR
        /// - `users/123456789/spaces/{space}/spaceNotificationSetting`.
        /// Note: Only the caller's user id or email is allowed in the path.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceNotificationSetting> GetSpaceNotificationSettingAsync(SpaceNotificationSettingName name, st::CancellationToken cancellationToken) =>
            GetSpaceNotificationSettingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the space notification setting. For an example, see [Update
        /// the caller's space notification
        /// setting](https://developers.google.com/workspace/chat/update-space-notification-setting).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.spacesettings`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SpaceNotificationSetting UpdateSpaceNotificationSetting(UpdateSpaceNotificationSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the space notification setting. For an example, see [Update
        /// the caller's space notification
        /// setting](https://developers.google.com/workspace/chat/update-space-notification-setting).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.spacesettings`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceNotificationSetting> UpdateSpaceNotificationSettingAsync(UpdateSpaceNotificationSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the space notification setting. For an example, see [Update
        /// the caller's space notification
        /// setting](https://developers.google.com/workspace/chat/update-space-notification-setting).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.spacesettings`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceNotificationSetting> UpdateSpaceNotificationSettingAsync(UpdateSpaceNotificationSettingRequest request, st::CancellationToken cancellationToken) =>
            UpdateSpaceNotificationSettingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the space notification setting. For an example, see [Update
        /// the caller's space notification
        /// setting](https://developers.google.com/workspace/chat/update-space-notification-setting).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.spacesettings`
        /// </summary>
        /// <param name="spaceNotificationSetting">
        /// Required. The resource name for the space notification settings must be
        /// populated in the form of
        /// `users/{user}/spaces/{space}/spaceNotificationSetting`. Only fields
        /// specified by `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Supported field paths:
        /// 
        /// - `notification_setting`
        /// 
        /// - `mute_setting`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SpaceNotificationSetting UpdateSpaceNotificationSetting(SpaceNotificationSetting spaceNotificationSetting, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSpaceNotificationSetting(new UpdateSpaceNotificationSettingRequest
            {
                SpaceNotificationSetting = gax::GaxPreconditions.CheckNotNull(spaceNotificationSetting, nameof(spaceNotificationSetting)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the space notification setting. For an example, see [Update
        /// the caller's space notification
        /// setting](https://developers.google.com/workspace/chat/update-space-notification-setting).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.spacesettings`
        /// </summary>
        /// <param name="spaceNotificationSetting">
        /// Required. The resource name for the space notification settings must be
        /// populated in the form of
        /// `users/{user}/spaces/{space}/spaceNotificationSetting`. Only fields
        /// specified by `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Supported field paths:
        /// 
        /// - `notification_setting`
        /// 
        /// - `mute_setting`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceNotificationSetting> UpdateSpaceNotificationSettingAsync(SpaceNotificationSetting spaceNotificationSetting, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSpaceNotificationSettingAsync(new UpdateSpaceNotificationSettingRequest
            {
                SpaceNotificationSetting = gax::GaxPreconditions.CheckNotNull(spaceNotificationSetting, nameof(spaceNotificationSetting)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the space notification setting. For an example, see [Update
        /// the caller's space notification
        /// setting](https://developers.google.com/workspace/chat/update-space-notification-setting).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.spacesettings`
        /// </summary>
        /// <param name="spaceNotificationSetting">
        /// Required. The resource name for the space notification settings must be
        /// populated in the form of
        /// `users/{user}/spaces/{space}/spaceNotificationSetting`. Only fields
        /// specified by `update_mask` are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Supported field paths:
        /// 
        /// - `notification_setting`
        /// 
        /// - `mute_setting`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SpaceNotificationSetting> UpdateSpaceNotificationSettingAsync(SpaceNotificationSetting spaceNotificationSetting, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSpaceNotificationSettingAsync(spaceNotificationSetting, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ChatService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Enables developers to build Chat apps and
    /// integrations on Google Chat Platform.
    /// </remarks>
    public sealed partial class ChatServiceClientImpl : ChatServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateMessageRequest, Message> _callCreateMessage;

        private readonly gaxgrpc::ApiCall<ListMessagesRequest, ListMessagesResponse> _callListMessages;

        private readonly gaxgrpc::ApiCall<ListMembershipsRequest, ListMembershipsResponse> _callListMemberships;

        private readonly gaxgrpc::ApiCall<GetMembershipRequest, Membership> _callGetMembership;

        private readonly gaxgrpc::ApiCall<GetMessageRequest, Message> _callGetMessage;

        private readonly gaxgrpc::ApiCall<UpdateMessageRequest, Message> _callUpdateMessage;

        private readonly gaxgrpc::ApiCall<DeleteMessageRequest, wkt::Empty> _callDeleteMessage;

        private readonly gaxgrpc::ApiCall<GetAttachmentRequest, Attachment> _callGetAttachment;

        private readonly gaxgrpc::ApiCall<UploadAttachmentRequest, UploadAttachmentResponse> _callUploadAttachment;

        private readonly gaxgrpc::ApiCall<ListSpacesRequest, ListSpacesResponse> _callListSpaces;

        private readonly gaxgrpc::ApiCall<SearchSpacesRequest, SearchSpacesResponse> _callSearchSpaces;

        private readonly gaxgrpc::ApiCall<GetSpaceRequest, Space> _callGetSpace;

        private readonly gaxgrpc::ApiCall<CreateSpaceRequest, Space> _callCreateSpace;

        private readonly gaxgrpc::ApiCall<SetUpSpaceRequest, Space> _callSetUpSpace;

        private readonly gaxgrpc::ApiCall<UpdateSpaceRequest, Space> _callUpdateSpace;

        private readonly gaxgrpc::ApiCall<DeleteSpaceRequest, wkt::Empty> _callDeleteSpace;

        private readonly gaxgrpc::ApiCall<CompleteImportSpaceRequest, CompleteImportSpaceResponse> _callCompleteImportSpace;

        private readonly gaxgrpc::ApiCall<FindDirectMessageRequest, Space> _callFindDirectMessage;

        private readonly gaxgrpc::ApiCall<CreateMembershipRequest, Membership> _callCreateMembership;

        private readonly gaxgrpc::ApiCall<UpdateMembershipRequest, Membership> _callUpdateMembership;

        private readonly gaxgrpc::ApiCall<DeleteMembershipRequest, Membership> _callDeleteMembership;

        private readonly gaxgrpc::ApiCall<CreateReactionRequest, Reaction> _callCreateReaction;

        private readonly gaxgrpc::ApiCall<ListReactionsRequest, ListReactionsResponse> _callListReactions;

        private readonly gaxgrpc::ApiCall<DeleteReactionRequest, wkt::Empty> _callDeleteReaction;

        private readonly gaxgrpc::ApiCall<CreateCustomEmojiRequest, CustomEmoji> _callCreateCustomEmoji;

        private readonly gaxgrpc::ApiCall<GetCustomEmojiRequest, CustomEmoji> _callGetCustomEmoji;

        private readonly gaxgrpc::ApiCall<ListCustomEmojisRequest, ListCustomEmojisResponse> _callListCustomEmojis;

        private readonly gaxgrpc::ApiCall<DeleteCustomEmojiRequest, wkt::Empty> _callDeleteCustomEmoji;

        private readonly gaxgrpc::ApiCall<GetSpaceReadStateRequest, SpaceReadState> _callGetSpaceReadState;

        private readonly gaxgrpc::ApiCall<UpdateSpaceReadStateRequest, SpaceReadState> _callUpdateSpaceReadState;

        private readonly gaxgrpc::ApiCall<GetThreadReadStateRequest, ThreadReadState> _callGetThreadReadState;

        private readonly gaxgrpc::ApiCall<GetSpaceEventRequest, SpaceEvent> _callGetSpaceEvent;

        private readonly gaxgrpc::ApiCall<ListSpaceEventsRequest, ListSpaceEventsResponse> _callListSpaceEvents;

        private readonly gaxgrpc::ApiCall<GetSpaceNotificationSettingRequest, SpaceNotificationSetting> _callGetSpaceNotificationSetting;

        private readonly gaxgrpc::ApiCall<UpdateSpaceNotificationSettingRequest, SpaceNotificationSetting> _callUpdateSpaceNotificationSetting;

        /// <summary>
        /// Constructs a client wrapper for the ChatService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ChatServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ChatServiceClientImpl(ChatService.ChatServiceClient grpcClient, ChatServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ChatServiceSettings effectiveSettings = settings ?? ChatServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateMessage = clientHelper.BuildApiCall<CreateMessageRequest, Message>("CreateMessage", grpcClient.CreateMessageAsync, grpcClient.CreateMessage, effectiveSettings.CreateMessageSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMessage);
            Modify_CreateMessageApiCall(ref _callCreateMessage);
            _callListMessages = clientHelper.BuildApiCall<ListMessagesRequest, ListMessagesResponse>("ListMessages", grpcClient.ListMessagesAsync, grpcClient.ListMessages, effectiveSettings.ListMessagesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMessages);
            Modify_ListMessagesApiCall(ref _callListMessages);
            _callListMemberships = clientHelper.BuildApiCall<ListMembershipsRequest, ListMembershipsResponse>("ListMemberships", grpcClient.ListMembershipsAsync, grpcClient.ListMemberships, effectiveSettings.ListMembershipsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMemberships);
            Modify_ListMembershipsApiCall(ref _callListMemberships);
            _callGetMembership = clientHelper.BuildApiCall<GetMembershipRequest, Membership>("GetMembership", grpcClient.GetMembershipAsync, grpcClient.GetMembership, effectiveSettings.GetMembershipSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMembership);
            Modify_GetMembershipApiCall(ref _callGetMembership);
            _callGetMessage = clientHelper.BuildApiCall<GetMessageRequest, Message>("GetMessage", grpcClient.GetMessageAsync, grpcClient.GetMessage, effectiveSettings.GetMessageSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMessage);
            Modify_GetMessageApiCall(ref _callGetMessage);
            _callUpdateMessage = clientHelper.BuildApiCall<UpdateMessageRequest, Message>("UpdateMessage", grpcClient.UpdateMessageAsync, grpcClient.UpdateMessage, effectiveSettings.UpdateMessageSettings).WithGoogleRequestParam("message.name", request => request.Message?.Name);
            Modify_ApiCall(ref _callUpdateMessage);
            Modify_UpdateMessageApiCall(ref _callUpdateMessage);
            _callDeleteMessage = clientHelper.BuildApiCall<DeleteMessageRequest, wkt::Empty>("DeleteMessage", grpcClient.DeleteMessageAsync, grpcClient.DeleteMessage, effectiveSettings.DeleteMessageSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMessage);
            Modify_DeleteMessageApiCall(ref _callDeleteMessage);
            _callGetAttachment = clientHelper.BuildApiCall<GetAttachmentRequest, Attachment>("GetAttachment", grpcClient.GetAttachmentAsync, grpcClient.GetAttachment, effectiveSettings.GetAttachmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAttachment);
            Modify_GetAttachmentApiCall(ref _callGetAttachment);
            _callUploadAttachment = clientHelper.BuildApiCall<UploadAttachmentRequest, UploadAttachmentResponse>("UploadAttachment", grpcClient.UploadAttachmentAsync, grpcClient.UploadAttachment, effectiveSettings.UploadAttachmentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callUploadAttachment);
            Modify_UploadAttachmentApiCall(ref _callUploadAttachment);
            _callListSpaces = clientHelper.BuildApiCall<ListSpacesRequest, ListSpacesResponse>("ListSpaces", grpcClient.ListSpacesAsync, grpcClient.ListSpaces, effectiveSettings.ListSpacesSettings);
            Modify_ApiCall(ref _callListSpaces);
            Modify_ListSpacesApiCall(ref _callListSpaces);
            _callSearchSpaces = clientHelper.BuildApiCall<SearchSpacesRequest, SearchSpacesResponse>("SearchSpaces", grpcClient.SearchSpacesAsync, grpcClient.SearchSpaces, effectiveSettings.SearchSpacesSettings);
            Modify_ApiCall(ref _callSearchSpaces);
            Modify_SearchSpacesApiCall(ref _callSearchSpaces);
            _callGetSpace = clientHelper.BuildApiCall<GetSpaceRequest, Space>("GetSpace", grpcClient.GetSpaceAsync, grpcClient.GetSpace, effectiveSettings.GetSpaceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSpace);
            Modify_GetSpaceApiCall(ref _callGetSpace);
            _callCreateSpace = clientHelper.BuildApiCall<CreateSpaceRequest, Space>("CreateSpace", grpcClient.CreateSpaceAsync, grpcClient.CreateSpace, effectiveSettings.CreateSpaceSettings);
            Modify_ApiCall(ref _callCreateSpace);
            Modify_CreateSpaceApiCall(ref _callCreateSpace);
            _callSetUpSpace = clientHelper.BuildApiCall<SetUpSpaceRequest, Space>("SetUpSpace", grpcClient.SetUpSpaceAsync, grpcClient.SetUpSpace, effectiveSettings.SetUpSpaceSettings);
            Modify_ApiCall(ref _callSetUpSpace);
            Modify_SetUpSpaceApiCall(ref _callSetUpSpace);
            _callUpdateSpace = clientHelper.BuildApiCall<UpdateSpaceRequest, Space>("UpdateSpace", grpcClient.UpdateSpaceAsync, grpcClient.UpdateSpace, effectiveSettings.UpdateSpaceSettings).WithGoogleRequestParam("space.name", request => request.Space?.Name);
            Modify_ApiCall(ref _callUpdateSpace);
            Modify_UpdateSpaceApiCall(ref _callUpdateSpace);
            _callDeleteSpace = clientHelper.BuildApiCall<DeleteSpaceRequest, wkt::Empty>("DeleteSpace", grpcClient.DeleteSpaceAsync, grpcClient.DeleteSpace, effectiveSettings.DeleteSpaceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSpace);
            Modify_DeleteSpaceApiCall(ref _callDeleteSpace);
            _callCompleteImportSpace = clientHelper.BuildApiCall<CompleteImportSpaceRequest, CompleteImportSpaceResponse>("CompleteImportSpace", grpcClient.CompleteImportSpaceAsync, grpcClient.CompleteImportSpace, effectiveSettings.CompleteImportSpaceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCompleteImportSpace);
            Modify_CompleteImportSpaceApiCall(ref _callCompleteImportSpace);
            _callFindDirectMessage = clientHelper.BuildApiCall<FindDirectMessageRequest, Space>("FindDirectMessage", grpcClient.FindDirectMessageAsync, grpcClient.FindDirectMessage, effectiveSettings.FindDirectMessageSettings);
            Modify_ApiCall(ref _callFindDirectMessage);
            Modify_FindDirectMessageApiCall(ref _callFindDirectMessage);
            _callCreateMembership = clientHelper.BuildApiCall<CreateMembershipRequest, Membership>("CreateMembership", grpcClient.CreateMembershipAsync, grpcClient.CreateMembership, effectiveSettings.CreateMembershipSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMembership);
            Modify_CreateMembershipApiCall(ref _callCreateMembership);
            _callUpdateMembership = clientHelper.BuildApiCall<UpdateMembershipRequest, Membership>("UpdateMembership", grpcClient.UpdateMembershipAsync, grpcClient.UpdateMembership, effectiveSettings.UpdateMembershipSettings).WithGoogleRequestParam("membership.name", request => request.Membership?.Name);
            Modify_ApiCall(ref _callUpdateMembership);
            Modify_UpdateMembershipApiCall(ref _callUpdateMembership);
            _callDeleteMembership = clientHelper.BuildApiCall<DeleteMembershipRequest, Membership>("DeleteMembership", grpcClient.DeleteMembershipAsync, grpcClient.DeleteMembership, effectiveSettings.DeleteMembershipSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMembership);
            Modify_DeleteMembershipApiCall(ref _callDeleteMembership);
            _callCreateReaction = clientHelper.BuildApiCall<CreateReactionRequest, Reaction>("CreateReaction", grpcClient.CreateReactionAsync, grpcClient.CreateReaction, effectiveSettings.CreateReactionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateReaction);
            Modify_CreateReactionApiCall(ref _callCreateReaction);
            _callListReactions = clientHelper.BuildApiCall<ListReactionsRequest, ListReactionsResponse>("ListReactions", grpcClient.ListReactionsAsync, grpcClient.ListReactions, effectiveSettings.ListReactionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListReactions);
            Modify_ListReactionsApiCall(ref _callListReactions);
            _callDeleteReaction = clientHelper.BuildApiCall<DeleteReactionRequest, wkt::Empty>("DeleteReaction", grpcClient.DeleteReactionAsync, grpcClient.DeleteReaction, effectiveSettings.DeleteReactionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteReaction);
            Modify_DeleteReactionApiCall(ref _callDeleteReaction);
            _callCreateCustomEmoji = clientHelper.BuildApiCall<CreateCustomEmojiRequest, CustomEmoji>("CreateCustomEmoji", grpcClient.CreateCustomEmojiAsync, grpcClient.CreateCustomEmoji, effectiveSettings.CreateCustomEmojiSettings);
            Modify_ApiCall(ref _callCreateCustomEmoji);
            Modify_CreateCustomEmojiApiCall(ref _callCreateCustomEmoji);
            _callGetCustomEmoji = clientHelper.BuildApiCall<GetCustomEmojiRequest, CustomEmoji>("GetCustomEmoji", grpcClient.GetCustomEmojiAsync, grpcClient.GetCustomEmoji, effectiveSettings.GetCustomEmojiSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCustomEmoji);
            Modify_GetCustomEmojiApiCall(ref _callGetCustomEmoji);
            _callListCustomEmojis = clientHelper.BuildApiCall<ListCustomEmojisRequest, ListCustomEmojisResponse>("ListCustomEmojis", grpcClient.ListCustomEmojisAsync, grpcClient.ListCustomEmojis, effectiveSettings.ListCustomEmojisSettings);
            Modify_ApiCall(ref _callListCustomEmojis);
            Modify_ListCustomEmojisApiCall(ref _callListCustomEmojis);
            _callDeleteCustomEmoji = clientHelper.BuildApiCall<DeleteCustomEmojiRequest, wkt::Empty>("DeleteCustomEmoji", grpcClient.DeleteCustomEmojiAsync, grpcClient.DeleteCustomEmoji, effectiveSettings.DeleteCustomEmojiSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCustomEmoji);
            Modify_DeleteCustomEmojiApiCall(ref _callDeleteCustomEmoji);
            _callGetSpaceReadState = clientHelper.BuildApiCall<GetSpaceReadStateRequest, SpaceReadState>("GetSpaceReadState", grpcClient.GetSpaceReadStateAsync, grpcClient.GetSpaceReadState, effectiveSettings.GetSpaceReadStateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSpaceReadState);
            Modify_GetSpaceReadStateApiCall(ref _callGetSpaceReadState);
            _callUpdateSpaceReadState = clientHelper.BuildApiCall<UpdateSpaceReadStateRequest, SpaceReadState>("UpdateSpaceReadState", grpcClient.UpdateSpaceReadStateAsync, grpcClient.UpdateSpaceReadState, effectiveSettings.UpdateSpaceReadStateSettings).WithGoogleRequestParam("space_read_state.name", request => request.SpaceReadState?.Name);
            Modify_ApiCall(ref _callUpdateSpaceReadState);
            Modify_UpdateSpaceReadStateApiCall(ref _callUpdateSpaceReadState);
            _callGetThreadReadState = clientHelper.BuildApiCall<GetThreadReadStateRequest, ThreadReadState>("GetThreadReadState", grpcClient.GetThreadReadStateAsync, grpcClient.GetThreadReadState, effectiveSettings.GetThreadReadStateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetThreadReadState);
            Modify_GetThreadReadStateApiCall(ref _callGetThreadReadState);
            _callGetSpaceEvent = clientHelper.BuildApiCall<GetSpaceEventRequest, SpaceEvent>("GetSpaceEvent", grpcClient.GetSpaceEventAsync, grpcClient.GetSpaceEvent, effectiveSettings.GetSpaceEventSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSpaceEvent);
            Modify_GetSpaceEventApiCall(ref _callGetSpaceEvent);
            _callListSpaceEvents = clientHelper.BuildApiCall<ListSpaceEventsRequest, ListSpaceEventsResponse>("ListSpaceEvents", grpcClient.ListSpaceEventsAsync, grpcClient.ListSpaceEvents, effectiveSettings.ListSpaceEventsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSpaceEvents);
            Modify_ListSpaceEventsApiCall(ref _callListSpaceEvents);
            _callGetSpaceNotificationSetting = clientHelper.BuildApiCall<GetSpaceNotificationSettingRequest, SpaceNotificationSetting>("GetSpaceNotificationSetting", grpcClient.GetSpaceNotificationSettingAsync, grpcClient.GetSpaceNotificationSetting, effectiveSettings.GetSpaceNotificationSettingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSpaceNotificationSetting);
            Modify_GetSpaceNotificationSettingApiCall(ref _callGetSpaceNotificationSetting);
            _callUpdateSpaceNotificationSetting = clientHelper.BuildApiCall<UpdateSpaceNotificationSettingRequest, SpaceNotificationSetting>("UpdateSpaceNotificationSetting", grpcClient.UpdateSpaceNotificationSettingAsync, grpcClient.UpdateSpaceNotificationSetting, effectiveSettings.UpdateSpaceNotificationSettingSettings).WithGoogleRequestParam("space_notification_setting.name", request => request.SpaceNotificationSetting?.Name);
            Modify_ApiCall(ref _callUpdateSpaceNotificationSetting);
            Modify_UpdateSpaceNotificationSettingApiCall(ref _callUpdateSpaceNotificationSetting);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateMessageApiCall(ref gaxgrpc::ApiCall<CreateMessageRequest, Message> call);

        partial void Modify_ListMessagesApiCall(ref gaxgrpc::ApiCall<ListMessagesRequest, ListMessagesResponse> call);

        partial void Modify_ListMembershipsApiCall(ref gaxgrpc::ApiCall<ListMembershipsRequest, ListMembershipsResponse> call);

        partial void Modify_GetMembershipApiCall(ref gaxgrpc::ApiCall<GetMembershipRequest, Membership> call);

        partial void Modify_GetMessageApiCall(ref gaxgrpc::ApiCall<GetMessageRequest, Message> call);

        partial void Modify_UpdateMessageApiCall(ref gaxgrpc::ApiCall<UpdateMessageRequest, Message> call);

        partial void Modify_DeleteMessageApiCall(ref gaxgrpc::ApiCall<DeleteMessageRequest, wkt::Empty> call);

        partial void Modify_GetAttachmentApiCall(ref gaxgrpc::ApiCall<GetAttachmentRequest, Attachment> call);

        partial void Modify_UploadAttachmentApiCall(ref gaxgrpc::ApiCall<UploadAttachmentRequest, UploadAttachmentResponse> call);

        partial void Modify_ListSpacesApiCall(ref gaxgrpc::ApiCall<ListSpacesRequest, ListSpacesResponse> call);

        partial void Modify_SearchSpacesApiCall(ref gaxgrpc::ApiCall<SearchSpacesRequest, SearchSpacesResponse> call);

        partial void Modify_GetSpaceApiCall(ref gaxgrpc::ApiCall<GetSpaceRequest, Space> call);

        partial void Modify_CreateSpaceApiCall(ref gaxgrpc::ApiCall<CreateSpaceRequest, Space> call);

        partial void Modify_SetUpSpaceApiCall(ref gaxgrpc::ApiCall<SetUpSpaceRequest, Space> call);

        partial void Modify_UpdateSpaceApiCall(ref gaxgrpc::ApiCall<UpdateSpaceRequest, Space> call);

        partial void Modify_DeleteSpaceApiCall(ref gaxgrpc::ApiCall<DeleteSpaceRequest, wkt::Empty> call);

        partial void Modify_CompleteImportSpaceApiCall(ref gaxgrpc::ApiCall<CompleteImportSpaceRequest, CompleteImportSpaceResponse> call);

        partial void Modify_FindDirectMessageApiCall(ref gaxgrpc::ApiCall<FindDirectMessageRequest, Space> call);

        partial void Modify_CreateMembershipApiCall(ref gaxgrpc::ApiCall<CreateMembershipRequest, Membership> call);

        partial void Modify_UpdateMembershipApiCall(ref gaxgrpc::ApiCall<UpdateMembershipRequest, Membership> call);

        partial void Modify_DeleteMembershipApiCall(ref gaxgrpc::ApiCall<DeleteMembershipRequest, Membership> call);

        partial void Modify_CreateReactionApiCall(ref gaxgrpc::ApiCall<CreateReactionRequest, Reaction> call);

        partial void Modify_ListReactionsApiCall(ref gaxgrpc::ApiCall<ListReactionsRequest, ListReactionsResponse> call);

        partial void Modify_DeleteReactionApiCall(ref gaxgrpc::ApiCall<DeleteReactionRequest, wkt::Empty> call);

        partial void Modify_CreateCustomEmojiApiCall(ref gaxgrpc::ApiCall<CreateCustomEmojiRequest, CustomEmoji> call);

        partial void Modify_GetCustomEmojiApiCall(ref gaxgrpc::ApiCall<GetCustomEmojiRequest, CustomEmoji> call);

        partial void Modify_ListCustomEmojisApiCall(ref gaxgrpc::ApiCall<ListCustomEmojisRequest, ListCustomEmojisResponse> call);

        partial void Modify_DeleteCustomEmojiApiCall(ref gaxgrpc::ApiCall<DeleteCustomEmojiRequest, wkt::Empty> call);

        partial void Modify_GetSpaceReadStateApiCall(ref gaxgrpc::ApiCall<GetSpaceReadStateRequest, SpaceReadState> call);

        partial void Modify_UpdateSpaceReadStateApiCall(ref gaxgrpc::ApiCall<UpdateSpaceReadStateRequest, SpaceReadState> call);

        partial void Modify_GetThreadReadStateApiCall(ref gaxgrpc::ApiCall<GetThreadReadStateRequest, ThreadReadState> call);

        partial void Modify_GetSpaceEventApiCall(ref gaxgrpc::ApiCall<GetSpaceEventRequest, SpaceEvent> call);

        partial void Modify_ListSpaceEventsApiCall(ref gaxgrpc::ApiCall<ListSpaceEventsRequest, ListSpaceEventsResponse> call);

        partial void Modify_GetSpaceNotificationSettingApiCall(ref gaxgrpc::ApiCall<GetSpaceNotificationSettingRequest, SpaceNotificationSetting> call);

        partial void Modify_UpdateSpaceNotificationSettingApiCall(ref gaxgrpc::ApiCall<UpdateSpaceNotificationSettingRequest, SpaceNotificationSetting> call);

        partial void OnConstruction(ChatService.ChatServiceClient grpcClient, ChatServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ChatService client</summary>
        public override ChatService.ChatServiceClient GrpcClient { get; }

        partial void Modify_CreateMessageRequest(ref CreateMessageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMessagesRequest(ref ListMessagesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMembershipsRequest(ref ListMembershipsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMembershipRequest(ref GetMembershipRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMessageRequest(ref GetMessageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateMessageRequest(ref UpdateMessageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMessageRequest(ref DeleteMessageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAttachmentRequest(ref GetAttachmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UploadAttachmentRequest(ref UploadAttachmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSpacesRequest(ref ListSpacesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchSpacesRequest(ref SearchSpacesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSpaceRequest(ref GetSpaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSpaceRequest(ref CreateSpaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetUpSpaceRequest(ref SetUpSpaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSpaceRequest(ref UpdateSpaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSpaceRequest(ref DeleteSpaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CompleteImportSpaceRequest(ref CompleteImportSpaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FindDirectMessageRequest(ref FindDirectMessageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateMembershipRequest(ref CreateMembershipRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateMembershipRequest(ref UpdateMembershipRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMembershipRequest(ref DeleteMembershipRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateReactionRequest(ref CreateReactionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReactionsRequest(ref ListReactionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteReactionRequest(ref DeleteReactionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCustomEmojiRequest(ref CreateCustomEmojiRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCustomEmojiRequest(ref GetCustomEmojiRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCustomEmojisRequest(ref ListCustomEmojisRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCustomEmojiRequest(ref DeleteCustomEmojiRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSpaceReadStateRequest(ref GetSpaceReadStateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSpaceReadStateRequest(ref UpdateSpaceReadStateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetThreadReadStateRequest(ref GetThreadReadStateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSpaceEventRequest(ref GetSpaceEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSpaceEventsRequest(ref ListSpaceEventsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSpaceNotificationSettingRequest(ref GetSpaceNotificationSettingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSpaceNotificationSettingRequest(ref UpdateSpaceNotificationSettingRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a message in a Google Chat space. For an example, see [Send a
        /// message](https://developers.google.com/workspace/chat/create-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages.create`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// Chat attributes the message sender differently depending on the type of
        /// authentication that you use in your request.
        /// 
        /// The following image shows how Chat attributes a message when you use app
        /// authentication. Chat displays the Chat app as the message
        /// sender. The content of the message can contain text (`text`), cards
        /// (`cardsV2`), and accessory widgets (`accessoryWidgets`).
        /// 
        /// ![Message sent with app
        /// authentication](https://developers.google.com/workspace/chat/images/message-app-auth.svg)
        /// 
        /// The following image shows how Chat attributes a message when you use user
        /// authentication. Chat displays the user as the message sender and attributes
        /// the Chat app to the message by displaying its name. The content of message
        /// can only contain text (`text`).
        /// 
        /// ![Message sent with user
        /// authentication](https://developers.google.com/workspace/chat/images/message-user-auth.svg)
        /// 
        /// The maximum message size, including the message contents, is 32,000 bytes.
        /// 
        /// For
        /// [webhook](https://developers.google.com/workspace/chat/quickstart/webhooks)
        /// requests, the response doesn't contain the full message. The response only
        /// populates the `name` and `thread.name` fields in addition to the
        /// information that was in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Message CreateMessage(CreateMessageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMessageRequest(ref request, ref callSettings);
            return _callCreateMessage.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a message in a Google Chat space. For an example, see [Send a
        /// message](https://developers.google.com/workspace/chat/create-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages.create`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// Chat attributes the message sender differently depending on the type of
        /// authentication that you use in your request.
        /// 
        /// The following image shows how Chat attributes a message when you use app
        /// authentication. Chat displays the Chat app as the message
        /// sender. The content of the message can contain text (`text`), cards
        /// (`cardsV2`), and accessory widgets (`accessoryWidgets`).
        /// 
        /// ![Message sent with app
        /// authentication](https://developers.google.com/workspace/chat/images/message-app-auth.svg)
        /// 
        /// The following image shows how Chat attributes a message when you use user
        /// authentication. Chat displays the user as the message sender and attributes
        /// the Chat app to the message by displaying its name. The content of message
        /// can only contain text (`text`).
        /// 
        /// ![Message sent with user
        /// authentication](https://developers.google.com/workspace/chat/images/message-user-auth.svg)
        /// 
        /// The maximum message size, including the message contents, is 32,000 bytes.
        /// 
        /// For
        /// [webhook](https://developers.google.com/workspace/chat/quickstart/webhooks)
        /// requests, the response doesn't contain the full message. The response only
        /// populates the `name` and `thread.name` fields in addition to the
        /// information that was in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Message> CreateMessageAsync(CreateMessageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMessageRequest(ref request, ref callSettings);
            return _callCreateMessage.Async(request, callSettings);
        }

        /// <summary>
        /// Lists messages in a space that the caller is a member of, including
        /// messages from blocked members and spaces. If you list messages from a
        /// space with no messages, the response is an empty object. When using a
        /// REST/HTTP interface, the response contains an empty JSON object, `{}`.
        /// For an example, see
        /// [List
        /// messages](https://developers.google.com/workspace/chat/api/guides/v1/messages/list).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Message"/> resources.</returns>
        public override gax::PagedEnumerable<ListMessagesResponse, Message> ListMessages(ListMessagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMessagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMessagesRequest, ListMessagesResponse, Message>(_callListMessages, request, callSettings);
        }

        /// <summary>
        /// Lists messages in a space that the caller is a member of, including
        /// messages from blocked members and spaces. If you list messages from a
        /// space with no messages, the response is an empty object. When using a
        /// REST/HTTP interface, the response contains an empty JSON object, `{}`.
        /// For an example, see
        /// [List
        /// messages](https://developers.google.com/workspace/chat/api/guides/v1/messages/list).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Message"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMessagesResponse, Message> ListMessagesAsync(ListMessagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMessagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMessagesRequest, ListMessagesResponse, Message>(_callListMessages, request, callSettings);
        }

        /// <summary>
        /// Lists memberships in a space. For an example, see [List users and Google
        /// Chat apps in a
        /// space](https://developers.google.com/workspace/chat/list-members). Listing
        /// memberships with [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// lists memberships in spaces that the Chat app has
        /// access to, but excludes Chat app memberships,
        /// including its own. Listing memberships with
        /// [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// lists memberships in spaces that the authenticated user has access to.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (requires
        /// [administrator approval](https://support.google.com/a?p=chat-app-auth))
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Membership"/> resources.</returns>
        public override gax::PagedEnumerable<ListMembershipsResponse, Membership> ListMemberships(ListMembershipsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMembershipsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMembershipsRequest, ListMembershipsResponse, Membership>(_callListMemberships, request, callSettings);
        }

        /// <summary>
        /// Lists memberships in a space. For an example, see [List users and Google
        /// Chat apps in a
        /// space](https://developers.google.com/workspace/chat/list-members). Listing
        /// memberships with [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// lists memberships in spaces that the Chat app has
        /// access to, but excludes Chat app memberships,
        /// including its own. Listing memberships with
        /// [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// lists memberships in spaces that the authenticated user has access to.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (requires
        /// [administrator approval](https://support.google.com/a?p=chat-app-auth))
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Membership"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMembershipsResponse, Membership> ListMembershipsAsync(ListMembershipsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMembershipsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMembershipsRequest, ListMembershipsResponse, Membership>(_callListMemberships, request, callSettings);
        }

        /// <summary>
        /// Returns details about a membership. For an example, see
        /// [Get details about a user's or Google Chat app's
        /// membership](https://developers.google.com/workspace/chat/get-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (requires
        /// [administrator approval](https://support.google.com/a?p=chat-app-auth))
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Membership GetMembership(GetMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMembershipRequest(ref request, ref callSettings);
            return _callGetMembership.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns details about a membership. For an example, see
        /// [Get details about a user's or Google Chat app's
        /// membership](https://developers.google.com/workspace/chat/get-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (requires
        /// [administrator approval](https://support.google.com/a?p=chat-app-auth))
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Membership> GetMembershipAsync(GetMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMembershipRequest(ref request, ref callSettings);
            return _callGetMembership.Async(request, callSettings);
        }

        /// <summary>
        /// Returns details about a message.
        /// For an example, see [Get details about a
        /// message](https://developers.google.com/workspace/chat/get-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// 
        /// Note: Might return a message from a blocked member or space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Message GetMessage(GetMessageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMessageRequest(ref request, ref callSettings);
            return _callGetMessage.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns details about a message.
        /// For an example, see [Get details about a
        /// message](https://developers.google.com/workspace/chat/get-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// 
        /// Note: Might return a message from a blocked member or space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Message> GetMessageAsync(GetMessageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMessageRequest(ref request, ref callSettings);
            return _callGetMessage.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a message. There's a difference between the `patch` and `update`
        /// methods. The `patch`
        /// method uses a `patch` request while the `update` method uses a `put`
        /// request. We recommend using the `patch` method. For an example, see
        /// [Update a
        /// message](https://developers.google.com/workspace/chat/update-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When using app authentication, requests can only update messages
        /// created by the calling Chat app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Message UpdateMessage(UpdateMessageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMessageRequest(ref request, ref callSettings);
            return _callUpdateMessage.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a message. There's a difference between the `patch` and `update`
        /// methods. The `patch`
        /// method uses a `patch` request while the `update` method uses a `put`
        /// request. We recommend using the `patch` method. For an example, see
        /// [Update a
        /// message](https://developers.google.com/workspace/chat/update-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When using app authentication, requests can only update messages
        /// created by the calling Chat app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Message> UpdateMessageAsync(UpdateMessageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMessageRequest(ref request, ref callSettings);
            return _callUpdateMessage.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a message.
        /// For an example, see [Delete a
        /// message](https://developers.google.com/workspace/chat/delete-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When using app authentication, requests can only delete messages
        /// created by the calling Chat app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteMessage(DeleteMessageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMessageRequest(ref request, ref callSettings);
            _callDeleteMessage.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a message.
        /// For an example, see [Delete a
        /// message](https://developers.google.com/workspace/chat/delete-messages).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When using app authentication, requests can only delete messages
        /// created by the calling Chat app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteMessageAsync(DeleteMessageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMessageRequest(ref request, ref callSettings);
            return _callDeleteMessage.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the metadata of a message attachment. The attachment data is fetched
        /// using the [media
        /// API](https://developers.google.com/workspace/chat/api/reference/rest/v1/media/download).
        /// For an example, see
        /// [Get metadata about a message
        /// attachment](https://developers.google.com/workspace/chat/get-media-attachments).
        /// 
        /// Requires [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Attachment GetAttachment(GetAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAttachmentRequest(ref request, ref callSettings);
            return _callGetAttachment.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the metadata of a message attachment. The attachment data is fetched
        /// using the [media
        /// API](https://developers.google.com/workspace/chat/api/reference/rest/v1/media/download).
        /// For an example, see
        /// [Get metadata about a message
        /// attachment](https://developers.google.com/workspace/chat/get-media-attachments).
        /// 
        /// Requires [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Attachment> GetAttachmentAsync(GetAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAttachmentRequest(ref request, ref callSettings);
            return _callGetAttachment.Async(request, callSettings);
        }

        /// <summary>
        /// Uploads an attachment. For an example, see
        /// [Upload media as a file
        /// attachment](https://developers.google.com/workspace/chat/upload-media-attachments).
        /// 
        /// Requires user
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.create`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// 
        /// You can upload attachments up to 200 MB. Certain file types aren't
        /// supported. For details, see [File types blocked by Google
        /// Chat](https://support.google.com/chat/answer/7651457?&amp;co=GENIE.Platform%3DDesktop#File%20types%20blocked%20in%20Google%20Chat).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UploadAttachmentResponse UploadAttachment(UploadAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadAttachmentRequest(ref request, ref callSettings);
            return _callUploadAttachment.Sync(request, callSettings);
        }

        /// <summary>
        /// Uploads an attachment. For an example, see
        /// [Upload media as a file
        /// attachment](https://developers.google.com/workspace/chat/upload-media-attachments).
        /// 
        /// Requires user
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.create`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// 
        /// You can upload attachments up to 200 MB. Certain file types aren't
        /// supported. For details, see [File types blocked by Google
        /// Chat](https://support.google.com/chat/answer/7651457?&amp;co=GENIE.Platform%3DDesktop#File%20types%20blocked%20in%20Google%20Chat).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UploadAttachmentResponse> UploadAttachmentAsync(UploadAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadAttachmentRequest(ref request, ref callSettings);
            return _callUploadAttachment.Async(request, callSettings);
        }

        /// <summary>
        /// Lists spaces the caller is a member of. Group chats and DMs aren't listed
        /// until the first message is sent. For an example, see
        /// [List
        /// spaces](https://developers.google.com/workspace/chat/list-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// 
        /// To list all named spaces by Google Workspace organization, use the
        /// [`spaces.search()`](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces/search)
        /// method using Workspace administrator privileges instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Space"/> resources.</returns>
        public override gax::PagedEnumerable<ListSpacesResponse, Space> ListSpaces(ListSpacesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSpacesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSpacesRequest, ListSpacesResponse, Space>(_callListSpaces, request, callSettings);
        }

        /// <summary>
        /// Lists spaces the caller is a member of. Group chats and DMs aren't listed
        /// until the first message is sent. For an example, see
        /// [List
        /// spaces](https://developers.google.com/workspace/chat/list-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// 
        /// To list all named spaces by Google Workspace organization, use the
        /// [`spaces.search()`](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces/search)
        /// method using Workspace administrator privileges instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Space"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSpacesResponse, Space> ListSpacesAsync(ListSpacesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSpacesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSpacesRequest, ListSpacesResponse, Space>(_callListSpaces, request, callSettings);
        }

        /// <summary>
        /// Returns a list of spaces in a Google Workspace organization based on an
        /// administrator's search.
        /// 
        /// Requires [user
        /// authentication with administrator
        /// privileges](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user#admin-privileges)
        /// and one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.admin.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.spaces`
        /// 
        /// In the request, set `use_admin_access` to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Space"/> resources.</returns>
        public override gax::PagedEnumerable<SearchSpacesResponse, Space> SearchSpaces(SearchSpacesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchSpacesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchSpacesRequest, SearchSpacesResponse, Space>(_callSearchSpaces, request, callSettings);
        }

        /// <summary>
        /// Returns a list of spaces in a Google Workspace organization based on an
        /// administrator's search.
        /// 
        /// Requires [user
        /// authentication with administrator
        /// privileges](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user#admin-privileges)
        /// and one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.admin.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.spaces`
        /// 
        /// In the request, set `use_admin_access` to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Space"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchSpacesResponse, Space> SearchSpacesAsync(SearchSpacesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchSpacesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchSpacesRequest, SearchSpacesResponse, Space>(_callSearchSpaces, request, callSettings);
        }

        /// <summary>
        /// Returns details about a space. For an example, see
        /// [Get details about a
        /// space](https://developers.google.com/workspace/chat/get-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.spaces` with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.spaces`
        /// 
        /// App authentication has the following limitations:
        /// 
        /// - `space.access_settings` is only populated when using the
        /// `chat.app.spaces` scope.
        /// - `space.predefind_permission_settings` and `space.permission_settings` are
        /// only populated when using the `chat.app.spaces` scope, and only for
        /// spaces the app created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Space GetSpace(GetSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSpaceRequest(ref request, ref callSettings);
            return _callGetSpace.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns details about a space. For an example, see
        /// [Get details about a
        /// space](https://developers.google.com/workspace/chat/get-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// - `https://www.googleapis.com/auth/chat.app.spaces` with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// one of the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.admin.spaces`
        /// 
        /// App authentication has the following limitations:
        /// 
        /// - `space.access_settings` is only populated when using the
        /// `chat.app.spaces` scope.
        /// - `space.predefind_permission_settings` and `space.permission_settings` are
        /// only populated when using the `chat.app.spaces` scope, and only for
        /// spaces the app created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Space> GetSpaceAsync(GetSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSpaceRequest(ref request, ref callSettings);
            return _callGetSpace.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a space. Can be used to create a named space, or a
        /// group chat in `Import mode`. For an example, see [Create a
        /// space](https://developers.google.com/workspace/chat/create-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.app.spaces.create`
        /// - `https://www.googleapis.com/auth/chat.app.spaces`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.create`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When authenticating as an app, the `space.customer` field must be set in
        /// the request.
        /// 
        /// When authenticating as an app, the Chat app is added as a member of the
        /// space. However, unlike human authentication, the Chat app is not added as a
        /// space manager. By default, the Chat app can be removed from the space by
        /// all space members. To allow only space managers to remove the app from a
        /// space, set `space.permission_settings.manage_apps` to `managers_allowed`.
        /// 
        /// Space membership upon creation depends on whether the space is created in
        /// `Import mode`:
        /// 
        /// * **Import mode:** No members are created.
        /// * **All other modes:**  The calling user is added as a member. This is:
        /// * The app itself when using app authentication.
        /// * The human user when using user authentication.
        /// 
        /// If you receive the error message `ALREADY_EXISTS` when creating
        /// a space, try a different `displayName`. An existing space within
        /// the Google Workspace organization might already use this display name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Space CreateSpace(CreateSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSpaceRequest(ref request, ref callSettings);
            return _callCreateSpace.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a space. Can be used to create a named space, or a
        /// group chat in `Import mode`. For an example, see [Create a
        /// space](https://developers.google.com/workspace/chat/create-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.app.spaces.create`
        /// - `https://www.googleapis.com/auth/chat.app.spaces`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.create`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// 
        /// When authenticating as an app, the `space.customer` field must be set in
        /// the request.
        /// 
        /// When authenticating as an app, the Chat app is added as a member of the
        /// space. However, unlike human authentication, the Chat app is not added as a
        /// space manager. By default, the Chat app can be removed from the space by
        /// all space members. To allow only space managers to remove the app from a
        /// space, set `space.permission_settings.manage_apps` to `managers_allowed`.
        /// 
        /// Space membership upon creation depends on whether the space is created in
        /// `Import mode`:
        /// 
        /// * **Import mode:** No members are created.
        /// * **All other modes:**  The calling user is added as a member. This is:
        /// * The app itself when using app authentication.
        /// * The human user when using user authentication.
        /// 
        /// If you receive the error message `ALREADY_EXISTS` when creating
        /// a space, try a different `displayName`. An existing space within
        /// the Google Workspace organization might already use this display name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Space> CreateSpaceAsync(CreateSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSpaceRequest(ref request, ref callSettings);
            return _callCreateSpace.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a space and adds specified users to it. The calling user is
        /// automatically added to the space, and shouldn't be specified as a
        /// membership in the request. For an example, see
        /// [Set up a space with initial
        /// members](https://developers.google.com/workspace/chat/set-up-spaces).
        /// 
        /// To specify the human members to add, add memberships with the appropriate
        /// `membership.member.name`. To add a human user, use `users/{user}`, where
        /// `{user}` can be the email address for the user. For users in the same
        /// Workspace organization `{user}` can also be the `id` for the person from
        /// the People API, or the `id` for the user in the Directory API. For example,
        /// if the People API Person profile ID for `user@example.com` is `123456789`,
        /// you can add the user to the space by setting the `membership.member.name`
        /// to `users/user@example.com` or `users/123456789`.
        /// 
        /// To specify the Google groups to add, add memberships with the
        /// appropriate `membership.group_member.name`. To add or invite a Google
        /// group, use `groups/{group}`, where `{group}` is the `id` for the group from
        /// the Cloud Identity Groups API. For example, you can use [Cloud Identity
        /// Groups lookup
        /// API](https://cloud.google.com/identity/docs/reference/rest/v1/groups/lookup)
        /// to retrieve the ID `123456789` for group email `group@example.com`, then
        /// you can add the group to the space by setting the
        /// `membership.group_member.name` to `groups/123456789`. Group email is not
        /// supported, and Google groups can only be added as members in named spaces.
        /// 
        /// For a named space or group chat, if the caller blocks, or is blocked
        /// by some members, or doesn't have permission to add some members, then
        /// those members aren't added to the created space.
        /// 
        /// To create a direct message (DM) between the calling user and another human
        /// user, specify exactly one membership to represent the human user. If
        /// one user blocks the other, the request fails and the DM isn't created.
        /// 
        /// To create a DM between the calling user and the calling app, set
        /// `Space.singleUserBotDm` to `true` and don't specify any memberships. You
        /// can only use this method to set up a DM with the calling app. To add the
        /// calling app as a member of a space or an existing DM between two human
        /// users, see
        /// [Invite or add a user or app to a
        /// space](https://developers.google.com/workspace/chat/create-members).
        /// 
        /// If a DM already exists between two users, even when one user blocks the
        /// other at the time a request is made, then the existing DM is returned.
        /// 
        /// Spaces with threaded replies aren't supported. If you receive the error
        /// message `ALREADY_EXISTS` when setting up a space, try a different
        /// `displayName`. An existing space within the Google Workspace organization
        /// might already use this display name.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.spaces.create`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Space SetUpSpace(SetUpSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetUpSpaceRequest(ref request, ref callSettings);
            return _callSetUpSpace.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a space and adds specified users to it. The calling user is
        /// automatically added to the space, and shouldn't be specified as a
        /// membership in the request. For an example, see
        /// [Set up a space with initial
        /// members](https://developers.google.com/workspace/chat/set-up-spaces).
        /// 
        /// To specify the human members to add, add memberships with the appropriate
        /// `membership.member.name`. To add a human user, use `users/{user}`, where
        /// `{user}` can be the email address for the user. For users in the same
        /// Workspace organization `{user}` can also be the `id` for the person from
        /// the People API, or the `id` for the user in the Directory API. For example,
        /// if the People API Person profile ID for `user@example.com` is `123456789`,
        /// you can add the user to the space by setting the `membership.member.name`
        /// to `users/user@example.com` or `users/123456789`.
        /// 
        /// To specify the Google groups to add, add memberships with the
        /// appropriate `membership.group_member.name`. To add or invite a Google
        /// group, use `groups/{group}`, where `{group}` is the `id` for the group from
        /// the Cloud Identity Groups API. For example, you can use [Cloud Identity
        /// Groups lookup
        /// API](https://cloud.google.com/identity/docs/reference/rest/v1/groups/lookup)
        /// to retrieve the ID `123456789` for group email `group@example.com`, then
        /// you can add the group to the space by setting the
        /// `membership.group_member.name` to `groups/123456789`. Group email is not
        /// supported, and Google groups can only be added as members in named spaces.
        /// 
        /// For a named space or group chat, if the caller blocks, or is blocked
        /// by some members, or doesn't have permission to add some members, then
        /// those members aren't added to the created space.
        /// 
        /// To create a direct message (DM) between the calling user and another human
        /// user, specify exactly one membership to represent the human user. If
        /// one user blocks the other, the request fails and the DM isn't created.
        /// 
        /// To create a DM between the calling user and the calling app, set
        /// `Space.singleUserBotDm` to `true` and don't specify any memberships. You
        /// can only use this method to set up a DM with the calling app. To add the
        /// calling app as a member of a space or an existing DM between two human
        /// users, see
        /// [Invite or add a user or app to a
        /// space](https://developers.google.com/workspace/chat/create-members).
        /// 
        /// If a DM already exists between two users, even when one user blocks the
        /// other at the time a request is made, then the existing DM is returned.
        /// 
        /// Spaces with threaded replies aren't supported. If you receive the error
        /// message `ALREADY_EXISTS` when setting up a space, try a different
        /// `displayName`. An existing space within the Google Workspace organization
        /// might already use this display name.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.spaces.create`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Space> SetUpSpaceAsync(SetUpSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetUpSpaceRequest(ref request, ref callSettings);
            return _callSetUpSpace.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a space. For an example, see
        /// [Update a
        /// space](https://developers.google.com/workspace/chat/update-spaces).
        /// 
        /// If you're updating the `displayName` field and receive the error message
        /// `ALREADY_EXISTS`, try a different display name.. An existing space within
        /// the Google Workspace organization might already use this display name.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.app.spaces`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.spaces`
        /// 
        /// App authentication has the following limitations:
        /// 
        /// - To update either `space.predefined_permission_settings` or
        /// `space.permission_settings`, the app must be the space creator.
        /// - Updating the `space.access_settings.audience` is not supported for app
        /// authentication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Space UpdateSpace(UpdateSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSpaceRequest(ref request, ref callSettings);
            return _callUpdateSpace.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a space. For an example, see
        /// [Update a
        /// space](https://developers.google.com/workspace/chat/update-spaces).
        /// 
        /// If you're updating the `displayName` field and receive the error message
        /// `ALREADY_EXISTS`, try a different display name.. An existing space within
        /// the Google Workspace organization might already use this display name.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.app.spaces`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scopes is used:
        /// - `https://www.googleapis.com/auth/chat.admin.spaces`
        /// 
        /// App authentication has the following limitations:
        /// 
        /// - To update either `space.predefined_permission_settings` or
        /// `space.permission_settings`, the app must be the space creator.
        /// - Updating the `space.access_settings.audience` is not supported for app
        /// authentication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Space> UpdateSpaceAsync(UpdateSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSpaceRequest(ref request, ref callSettings);
            return _callUpdateSpace.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a named space. Always performs a cascading delete, which means
        /// that the space's child resources—like messages posted in the space and
        /// memberships in the space—are also deleted. For an example, see
        /// [Delete a
        /// space](https://developers.google.com/workspace/chat/delete-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth) and the
        /// authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.delete` (only in
        /// spaces the app created)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.delete`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.delete`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSpace(DeleteSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSpaceRequest(ref request, ref callSettings);
            _callDeleteSpace.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a named space. Always performs a cascading delete, which means
        /// that the space's child resources—like messages posted in the space and
        /// memberships in the space—are also deleted. For an example, see
        /// [Delete a
        /// space](https://developers.google.com/workspace/chat/delete-spaces).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth) and the
        /// authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.delete` (only in
        /// spaces the app created)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.delete`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.delete`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSpaceAsync(DeleteSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSpaceRequest(ref request, ref callSettings);
            return _callDeleteSpace.Async(request, callSettings);
        }

        /// <summary>
        /// Completes the
        /// [import process](https://developers.google.com/workspace/chat/import-data)
        /// for the specified space and makes it visible to users.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// and domain-wide delegation with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.import`
        /// 
        /// For more information, see [Authorize Google
        /// Chat apps to import
        /// data](https://developers.google.com/workspace/chat/authorize-import).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CompleteImportSpaceResponse CompleteImportSpace(CompleteImportSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CompleteImportSpaceRequest(ref request, ref callSettings);
            return _callCompleteImportSpace.Sync(request, callSettings);
        }

        /// <summary>
        /// Completes the
        /// [import process](https://developers.google.com/workspace/chat/import-data)
        /// for the specified space and makes it visible to users.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// and domain-wide delegation with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.import`
        /// 
        /// For more information, see [Authorize Google
        /// Chat apps to import
        /// data](https://developers.google.com/workspace/chat/authorize-import).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CompleteImportSpaceResponse> CompleteImportSpaceAsync(CompleteImportSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CompleteImportSpaceRequest(ref request, ref callSettings);
            return _callCompleteImportSpace.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the existing direct message with the specified user. If no direct
        /// message space is found, returns a `404 NOT_FOUND` error. For an example,
        /// see
        /// [Find a direct message](/chat/api/guides/v1/spaces/find-direct-message).
        /// 
        /// With [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app),
        /// returns the direct message space between the specified user and the calling
        /// Chat app.
        /// 
        /// With [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user),
        /// returns the direct message space between the specified user and the
        /// authenticated user.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Space FindDirectMessage(FindDirectMessageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FindDirectMessageRequest(ref request, ref callSettings);
            return _callFindDirectMessage.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the existing direct message with the specified user. If no direct
        /// message space is found, returns a `404 NOT_FOUND` error. For an example,
        /// see
        /// [Find a direct message](/chat/api/guides/v1/spaces/find-direct-message).
        /// 
        /// With [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app),
        /// returns the direct message space between the specified user and the calling
        /// Chat app.
        /// 
        /// With [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user),
        /// returns the direct message space between the specified user and the
        /// authenticated user.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.bot`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Space> FindDirectMessageAsync(FindDirectMessageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FindDirectMessageRequest(ref request, ref callSettings);
            return _callFindDirectMessage.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a membership for the calling Chat app, a user, or a Google Group.
        /// Creating memberships for other Chat apps isn't supported.
        /// When creating a membership, if the specified member has their auto-accept
        /// policy turned off, then they're invited, and must accept the space
        /// invitation before joining. Otherwise, creating a membership adds the member
        /// directly to the specified space.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.memberships.app` (to add the
        /// calling app to the space)
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// 
        /// App authentication is not supported for the following use cases:
        /// 
        /// - Inviting users external to the Workspace organization that owns the
        /// space.
        /// - Adding a Google Group to a space.
        /// - Adding a Chat app to a space.
        /// 
        /// For example usage, see:
        /// 
        /// - [Invite or add a user to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-user-membership).
        /// - [Invite or add a Google Group to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-group-membership).
        /// - [Add the Chat app to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-membership-calling-api).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Membership CreateMembership(CreateMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMembershipRequest(ref request, ref callSettings);
            return _callCreateMembership.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a membership for the calling Chat app, a user, or a Google Group.
        /// Creating memberships for other Chat apps isn't supported.
        /// When creating a membership, if the specified member has their auto-accept
        /// policy turned off, then they're invited, and must accept the space
        /// invitation before joining. Otherwise, creating a membership adds the member
        /// directly to the specified space.
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.memberships.app` (to add the
        /// calling app to the space)
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// 
        /// App authentication is not supported for the following use cases:
        /// 
        /// - Inviting users external to the Workspace organization that owns the
        /// space.
        /// - Adding a Google Group to a space.
        /// - Adding a Chat app to a space.
        /// 
        /// For example usage, see:
        /// 
        /// - [Invite or add a user to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-user-membership).
        /// - [Invite or add a Google Group to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-group-membership).
        /// - [Add the Chat app to a
        /// space](https://developers.google.com/workspace/chat/create-members#create-membership-calling-api).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Membership> CreateMembershipAsync(CreateMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMembershipRequest(ref request, ref callSettings);
            return _callCreateMembership.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a membership. For an example, see [Update a user's membership in
        /// a space](https://developers.google.com/workspace/chat/update-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth) and the
        /// authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (only in
        /// spaces the app created)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Membership UpdateMembership(UpdateMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMembershipRequest(ref request, ref callSettings);
            return _callUpdateMembership.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a membership. For an example, see [Update a user's membership in
        /// a space](https://developers.google.com/workspace/chat/update-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator
        /// approval](https://support.google.com/a?p=chat-app-auth) and the
        /// authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships` (only in
        /// spaces the app created)
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Membership> UpdateMembershipAsync(UpdateMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMembershipRequest(ref request, ref callSettings);
            return _callUpdateMembership.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a membership. For an example, see
        /// [Remove a user or a Google Chat app from a
        /// space](https://developers.google.com/workspace/chat/delete-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.memberships.app` (to remove
        /// the calling app from the space)
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// 
        /// App authentication is not supported for the following use cases:
        /// 
        /// - Removing a Google Group from a space.
        /// - Removing a Chat app from a space.
        /// 
        /// To delete memberships for space managers, the requester
        /// must be a space manager. If you're using [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// the Chat app must be the space creator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Membership DeleteMembership(DeleteMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMembershipRequest(ref request, ref callSettings);
            return _callDeleteMembership.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a membership. For an example, see
        /// [Remove a user or a Google Chat app from a
        /// space](https://developers.google.com/workspace/chat/delete-members).
        /// 
        /// Supports the following types of
        /// [authentication](https://developers.google.com/workspace/chat/authenticate-authorize):
        /// 
        /// - [App
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// with [administrator approval](https://support.google.com/a?p=chat-app-auth)
        /// and the authorization scope:
        /// - `https://www.googleapis.com/auth/chat.app.memberships`
        /// 
        /// - [User
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following authorization scopes:
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// - `https://www.googleapis.com/auth/chat.memberships.app` (to remove
        /// the calling app from the space)
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces
        /// only)
        /// - User authentication grants administrator privileges when an
        /// administrator account authenticates, `use_admin_access` is `true`, and
        /// the following authorization scope is used:
        /// - `https://www.googleapis.com/auth/chat.admin.memberships`
        /// 
        /// App authentication is not supported for the following use cases:
        /// 
        /// - Removing a Google Group from a space.
        /// - Removing a Chat app from a space.
        /// 
        /// To delete memberships for space managers, the requester
        /// must be a space manager. If you're using [app
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-app)
        /// the Chat app must be the space creator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Membership> DeleteMembershipAsync(DeleteMembershipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMembershipRequest(ref request, ref callSettings);
            return _callDeleteMembership.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a reaction and adds it to a message. For an example, see
        /// [Add a reaction to a
        /// message](https://developers.google.com/workspace/chat/create-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.create`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Reaction CreateReaction(CreateReactionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReactionRequest(ref request, ref callSettings);
            return _callCreateReaction.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a reaction and adds it to a message. For an example, see
        /// [Add a reaction to a
        /// message](https://developers.google.com/workspace/chat/create-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.create`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Reaction> CreateReactionAsync(CreateReactionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReactionRequest(ref request, ref callSettings);
            return _callCreateReaction.Async(request, callSettings);
        }

        /// <summary>
        /// Lists reactions to a message. For an example, see
        /// [List reactions for a
        /// message](https://developers.google.com/workspace/chat/list-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Reaction"/> resources.</returns>
        public override gax::PagedEnumerable<ListReactionsResponse, Reaction> ListReactions(ListReactionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReactionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReactionsRequest, ListReactionsResponse, Reaction>(_callListReactions, request, callSettings);
        }

        /// <summary>
        /// Lists reactions to a message. For an example, see
        /// [List reactions for a
        /// message](https://developers.google.com/workspace/chat/list-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Reaction"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListReactionsResponse, Reaction> ListReactionsAsync(ListReactionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReactionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReactionsRequest, ListReactionsResponse, Reaction>(_callListReactions, request, callSettings);
        }

        /// <summary>
        /// Deletes a reaction to a message. For an example, see
        /// [Delete a
        /// reaction](https://developers.google.com/workspace/chat/delete-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteReaction(DeleteReactionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReactionRequest(ref request, ref callSettings);
            _callDeleteReaction.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a reaction to a message. For an example, see
        /// [Delete a
        /// reaction](https://developers.google.com/workspace/chat/delete-reactions).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.import` (import mode spaces only)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteReactionAsync(DeleteReactionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReactionRequest(ref request, ref callSettings);
            return _callDeleteReaction.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a custom emoji.
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CustomEmoji CreateCustomEmoji(CreateCustomEmojiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomEmojiRequest(ref request, ref callSettings);
            return _callCreateCustomEmoji.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a custom emoji.
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CustomEmoji> CreateCustomEmojiAsync(CreateCustomEmojiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomEmojiRequest(ref request, ref callSettings);
            return _callCreateCustomEmoji.Async(request, callSettings);
        }

        /// <summary>
        /// Returns details about a custom emoji.
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis.readonly`
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CustomEmoji GetCustomEmoji(GetCustomEmojiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomEmojiRequest(ref request, ref callSettings);
            return _callGetCustomEmoji.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns details about a custom emoji.
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis.readonly`
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CustomEmoji> GetCustomEmojiAsync(GetCustomEmojiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomEmojiRequest(ref request, ref callSettings);
            return _callGetCustomEmoji.Async(request, callSettings);
        }

        /// <summary>
        /// Lists custom emojis visible to the authenticated user.
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis.readonly`
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CustomEmoji"/> resources.</returns>
        public override gax::PagedEnumerable<ListCustomEmojisResponse, CustomEmoji> ListCustomEmojis(ListCustomEmojisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomEmojisRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCustomEmojisRequest, ListCustomEmojisResponse, CustomEmoji>(_callListCustomEmojis, request, callSettings);
        }

        /// <summary>
        /// Lists custom emojis visible to the authenticated user.
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis.readonly`
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CustomEmoji"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCustomEmojisResponse, CustomEmoji> ListCustomEmojisAsync(ListCustomEmojisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomEmojisRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCustomEmojisRequest, ListCustomEmojisResponse, CustomEmoji>(_callListCustomEmojis, request, callSettings);
        }

        /// <summary>
        /// Deletes a custom emoji. By default, users can only delete custom emoji they
        /// created. [Emoji managers](https://support.google.com/a/answer/12850085)
        /// assigned by the administrator can delete any custom emoji in the
        /// organization. See [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149).
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteCustomEmoji(DeleteCustomEmojiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCustomEmojiRequest(ref request, ref callSettings);
            _callDeleteCustomEmoji.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a custom emoji. By default, users can only delete custom emoji they
        /// created. [Emoji managers](https://support.google.com/a/answer/12850085)
        /// assigned by the administrator can delete any custom emoji in the
        /// organization. See [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149).
        /// 
        /// Custom emojis are only available for Google Workspace accounts, and the
        /// administrator must turn custom emojis on for the organization. For more
        /// information, see [Learn about custom emojis in Google
        /// Chat](https://support.google.com/chat/answer/12800149) and
        /// [Manage custom emoji
        /// permissions](https://support.google.com/a/answer/12850085).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.customemojis`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteCustomEmojiAsync(DeleteCustomEmojiRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCustomEmojiRequest(ref request, ref callSettings);
            return _callDeleteCustomEmoji.Async(request, callSettings);
        }

        /// <summary>
        /// Returns details about a user's read state within a space, used to identify
        /// read and unread messages. For an example, see [Get details about a user's
        /// space read
        /// state](https://developers.google.com/workspace/chat/get-space-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate.readonly`
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SpaceReadState GetSpaceReadState(GetSpaceReadStateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSpaceReadStateRequest(ref request, ref callSettings);
            return _callGetSpaceReadState.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns details about a user's read state within a space, used to identify
        /// read and unread messages. For an example, see [Get details about a user's
        /// space read
        /// state](https://developers.google.com/workspace/chat/get-space-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate.readonly`
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SpaceReadState> GetSpaceReadStateAsync(GetSpaceReadStateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSpaceReadStateRequest(ref request, ref callSettings);
            return _callGetSpaceReadState.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a user's read state within a space, used to identify read and
        /// unread messages. For an example, see [Update a user's space read
        /// state](https://developers.google.com/workspace/chat/update-space-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SpaceReadState UpdateSpaceReadState(UpdateSpaceReadStateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSpaceReadStateRequest(ref request, ref callSettings);
            return _callUpdateSpaceReadState.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a user's read state within a space, used to identify read and
        /// unread messages. For an example, see [Update a user's space read
        /// state](https://developers.google.com/workspace/chat/update-space-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SpaceReadState> UpdateSpaceReadStateAsync(UpdateSpaceReadStateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSpaceReadStateRequest(ref request, ref callSettings);
            return _callUpdateSpaceReadState.Async(request, callSettings);
        }

        /// <summary>
        /// Returns details about a user's read state within a thread, used to identify
        /// read and unread messages. For an example, see [Get details about a user's
        /// thread read
        /// state](https://developers.google.com/workspace/chat/get-thread-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate.readonly`
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ThreadReadState GetThreadReadState(GetThreadReadStateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetThreadReadStateRequest(ref request, ref callSettings);
            return _callGetThreadReadState.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns details about a user's read state within a thread, used to identify
        /// read and unread messages. For an example, see [Get details about a user's
        /// thread read
        /// state](https://developers.google.com/workspace/chat/get-thread-read-state).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with one of the following [authorization
        /// scopes](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.readstate.readonly`
        /// - `https://www.googleapis.com/auth/chat.users.readstate`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ThreadReadState> GetThreadReadStateAsync(GetThreadReadStateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetThreadReadStateRequest(ref request, ref callSettings);
            return _callGetThreadReadState.Async(request, callSettings);
        }

        /// <summary>
        /// Returns an event from a Google Chat space. The [event
        /// payload](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.oneof_payload)
        /// contains the most recent version of the resource that changed. For example,
        /// if you request an event about a new message but the message was later
        /// updated, the server returns the updated `Message` resource in the event
        /// payload.
        /// 
        /// Note: The `permissionSettings` field is not returned in the Space
        /// object of the Space event data for this request.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with an [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes)
        /// appropriate for reading the requested data:
        /// 
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// 
        /// To get an event, the authenticated user must be a member of the space.
        /// 
        /// For an example, see [Get details about an
        /// event from a Google Chat
        /// space](https://developers.google.com/workspace/chat/get-space-event).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SpaceEvent GetSpaceEvent(GetSpaceEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSpaceEventRequest(ref request, ref callSettings);
            return _callGetSpaceEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns an event from a Google Chat space. The [event
        /// payload](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.oneof_payload)
        /// contains the most recent version of the resource that changed. For example,
        /// if you request an event about a new message but the message was later
        /// updated, the server returns the updated `Message` resource in the event
        /// payload.
        /// 
        /// Note: The `permissionSettings` field is not returned in the Space
        /// object of the Space event data for this request.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with an [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes)
        /// appropriate for reading the requested data:
        /// 
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// 
        /// To get an event, the authenticated user must be a member of the space.
        /// 
        /// For an example, see [Get details about an
        /// event from a Google Chat
        /// space](https://developers.google.com/workspace/chat/get-space-event).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SpaceEvent> GetSpaceEventAsync(GetSpaceEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSpaceEventRequest(ref request, ref callSettings);
            return _callGetSpaceEvent.Async(request, callSettings);
        }

        /// <summary>
        /// Lists events from a Google Chat space. For each event, the
        /// [payload](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.oneof_payload)
        /// contains the most recent version of the Chat resource. For example, if you
        /// list events about new space members, the server returns `Membership`
        /// resources that contain the latest membership details. If new members were
        /// removed during the requested period, the event payload contains an empty
        /// `Membership` resource.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with an [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes)
        /// appropriate for reading the requested data:
        /// 
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// 
        /// To list events, the authenticated user must be a member of the space.
        /// 
        /// For an example, see [List events from a Google Chat
        /// space](https://developers.google.com/workspace/chat/list-space-events).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SpaceEvent"/> resources.</returns>
        public override gax::PagedEnumerable<ListSpaceEventsResponse, SpaceEvent> ListSpaceEvents(ListSpaceEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSpaceEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSpaceEventsRequest, ListSpaceEventsResponse, SpaceEvent>(_callListSpaceEvents, request, callSettings);
        }

        /// <summary>
        /// Lists events from a Google Chat space. For each event, the
        /// [payload](https://developers.google.com/workspace/chat/api/reference/rest/v1/spaces.spaceEvents#SpaceEvent.FIELDS.oneof_payload)
        /// contains the most recent version of the Chat resource. For example, if you
        /// list events about new space members, the server returns `Membership`
        /// resources that contain the latest membership details. If new members were
        /// removed during the requested period, the event payload contains an empty
        /// `Membership` resource.
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with an [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes)
        /// appropriate for reading the requested data:
        /// 
        /// - `https://www.googleapis.com/auth/chat.spaces.readonly`
        /// - `https://www.googleapis.com/auth/chat.spaces`
        /// - `https://www.googleapis.com/auth/chat.messages.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions.readonly`
        /// - `https://www.googleapis.com/auth/chat.messages.reactions`
        /// - `https://www.googleapis.com/auth/chat.memberships.readonly`
        /// - `https://www.googleapis.com/auth/chat.memberships`
        /// 
        /// To list events, the authenticated user must be a member of the space.
        /// 
        /// For an example, see [List events from a Google Chat
        /// space](https://developers.google.com/workspace/chat/list-space-events).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SpaceEvent"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSpaceEventsResponse, SpaceEvent> ListSpaceEventsAsync(ListSpaceEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSpaceEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSpaceEventsRequest, ListSpaceEventsResponse, SpaceEvent>(_callListSpaceEvents, request, callSettings);
        }

        /// <summary>
        /// Gets the space notification setting. For an example, see [Get the
        /// caller's space notification
        /// setting](https://developers.google.com/workspace/chat/get-space-notification-setting).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.spacesettings`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SpaceNotificationSetting GetSpaceNotificationSetting(GetSpaceNotificationSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSpaceNotificationSettingRequest(ref request, ref callSettings);
            return _callGetSpaceNotificationSetting.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the space notification setting. For an example, see [Get the
        /// caller's space notification
        /// setting](https://developers.google.com/workspace/chat/get-space-notification-setting).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.spacesettings`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SpaceNotificationSetting> GetSpaceNotificationSettingAsync(GetSpaceNotificationSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSpaceNotificationSettingRequest(ref request, ref callSettings);
            return _callGetSpaceNotificationSetting.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the space notification setting. For an example, see [Update
        /// the caller's space notification
        /// setting](https://developers.google.com/workspace/chat/update-space-notification-setting).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.spacesettings`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SpaceNotificationSetting UpdateSpaceNotificationSetting(UpdateSpaceNotificationSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSpaceNotificationSettingRequest(ref request, ref callSettings);
            return _callUpdateSpaceNotificationSetting.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the space notification setting. For an example, see [Update
        /// the caller's space notification
        /// setting](https://developers.google.com/workspace/chat/update-space-notification-setting).
        /// 
        /// Requires [user
        /// authentication](https://developers.google.com/workspace/chat/authenticate-authorize-chat-user)
        /// with the [authorization
        /// scope](https://developers.google.com/workspace/chat/authenticate-authorize#chat-api-scopes):
        /// 
        /// - `https://www.googleapis.com/auth/chat.users.spacesettings`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SpaceNotificationSetting> UpdateSpaceNotificationSettingAsync(UpdateSpaceNotificationSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSpaceNotificationSettingRequest(ref request, ref callSettings);
            return _callUpdateSpaceNotificationSetting.Async(request, callSettings);
        }
    }

    public partial class ListMessagesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMembershipsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSpacesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchSpacesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReactionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCustomEmojisRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSpaceEventsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMessagesResponse : gaxgrpc::IPageResponse<Message>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Message> GetEnumerator() => Messages.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMembershipsResponse : gaxgrpc::IPageResponse<Membership>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Membership> GetEnumerator() => Memberships.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSpacesResponse : gaxgrpc::IPageResponse<Space>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Space> GetEnumerator() => Spaces.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchSpacesResponse : gaxgrpc::IPageResponse<Space>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Space> GetEnumerator() => Spaces.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListReactionsResponse : gaxgrpc::IPageResponse<Reaction>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Reaction> GetEnumerator() => Reactions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCustomEmojisResponse : gaxgrpc::IPageResponse<CustomEmoji>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CustomEmoji> GetEnumerator() => CustomEmojis.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSpaceEventsResponse : gaxgrpc::IPageResponse<SpaceEvent>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SpaceEvent> GetEnumerator() => SpaceEvents.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
