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
    // [START spanner_v1_generated_DatabaseAdmin_CreateDatabase_async]
    using Google.Cloud.Spanner.Admin.Database.V1;
    using Google.Cloud.Spanner.Common.V1;
    using Google.LongRunning;
    using Google.Protobuf;
    using System.Threading.Tasks;

    public sealed partial class GeneratedDatabaseAdminClientSnippets
    {
        /// <summary>Snippet for CreateDatabaseAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreateDatabaseRequestObjectAsync()
        {
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateDatabaseRequest request = new CreateDatabaseRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                CreateStatement = "",
                ExtraStatements = { "", },
                EncryptionConfig = new EncryptionConfig(),
                DatabaseDialect = DatabaseDialect.Unspecified,
                ProtoDescriptors = ByteString.Empty,
            };
            // Make the request
            Operation<Database, CreateDatabaseMetadata> response = await databaseAdminClient.CreateDatabaseAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Database, CreateDatabaseMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database, CreateDatabaseMetadata> retrievedResponse = await databaseAdminClient.PollOnceCreateDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END spanner_v1_generated_DatabaseAdmin_CreateDatabase_async]
}
