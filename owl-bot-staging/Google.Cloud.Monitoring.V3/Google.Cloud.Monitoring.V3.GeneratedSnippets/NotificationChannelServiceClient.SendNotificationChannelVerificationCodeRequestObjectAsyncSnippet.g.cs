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

namespace GoogleCSharpSnippets
{
    // [START monitoring_v3_generated_NotificationChannelService_SendNotificationChannelVerificationCode_async]
    using Google.Cloud.Monitoring.V3;
    using System.Threading.Tasks;

    public sealed partial class GeneratedNotificationChannelServiceClientSnippets
    {
        /// <summary>Snippet for SendNotificationChannelVerificationCodeAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task SendNotificationChannelVerificationCodeRequestObjectAsync()
        {
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = await NotificationChannelServiceClient.CreateAsync();
            // Initialize request argument(s)
            SendNotificationChannelVerificationCodeRequest request = new SendNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
            };
            // Make the request
            await notificationChannelServiceClient.SendNotificationChannelVerificationCodeAsync(request);
        }
    }
    // [END monitoring_v3_generated_NotificationChannelService_SendNotificationChannelVerificationCode_async]
}
