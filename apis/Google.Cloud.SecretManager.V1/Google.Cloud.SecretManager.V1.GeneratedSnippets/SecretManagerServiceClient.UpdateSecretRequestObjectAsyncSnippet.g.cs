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

namespace GoogleCSharpSnippets
{
    // [START secretmanager_v1_generated_SecretManagerService_UpdateSecret_async]
    using Google.Cloud.SecretManager.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedSecretManagerServiceClientSnippets
    {
        /// <summary>Snippet for UpdateSecretAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task UpdateSecretRequestObjectAsync()
        {
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSecretRequest request = new UpdateSecretRequest
            {
                Secret = new Secret
                {
                    SecretName = SecretName.FromProjectSecret("[PROJECT]", "[SECRET]"),
                    Replication = new Replication
                    {
                        Automatic = new Replication.Types.Automatic
                        {
                            CustomerManagedEncryption = new CustomerManagedEncryption { KmsKeyName = "", },
                        },
                        UserManaged = new Replication.Types.UserManaged
                        {
                            Replicas =
                            {
                                new Replication.Types.UserManaged.Types.Replica
                                {
                                    Location = "",
                                    CustomerManagedEncryption = new CustomerManagedEncryption { KmsKeyName = "", },
                                },
                            },
                        },
                    },
                    CreateTime = new Timestamp
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                    Labels = { { "", "" }, },
                    Topics =
                    {
                        new Topic
                        {
                            TopicName = TopicName.FromProjectTopic("[PROJECT]", "[TOPIC]"),
                        },
                    },
                    ExpireTime = new Timestamp
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                    Ttl = new Duration
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                    Etag = "",
                    Rotation = new Rotation
                    {
                        NextRotationTime = new Timestamp
                        {
                            Seconds = 0L,
                            Nanos = 0,
                        },
                        RotationPeriod = new Duration
                        {
                            Seconds = 0L,
                            Nanos = 0,
                        },
                    },
                    VersionAliases = { { "", 0L }, },
                    Annotations = { { "", "" }, },
                    VersionDestroyTtl = new Duration
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                    CustomerManagedEncryption = new CustomerManagedEncryption { KmsKeyName = "", },
                },
                UpdateMask = new FieldMask { Paths = { "", }, },
            };
            // Make the request
            Secret response = await secretManagerServiceClient.UpdateSecretAsync(request);
        }
    }
    // [END secretmanager_v1_generated_SecretManagerService_UpdateSecret_async]
}
