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
    // [START bigtable_v2_generated_Bigtable_ReadModifyWriteRow_async]
    using Google.Cloud.Bigtable.Common.V2;
    using Google.Cloud.Bigtable.V2;
    using Google.Protobuf;
    using System.Threading.Tasks;

    public sealed partial class GeneratedBigtableServiceApiClientSnippets
    {
        /// <summary>Snippet for ReadModifyWriteRowAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task ReadModifyWriteRowRequestObjectAsync()
        {
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = await BigtableServiceApiClient.CreateAsync();
            // Initialize request argument(s)
            ReadModifyWriteRowRequest request = new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.Empty,
                Rules =
                {
                    new ReadModifyWriteRule(),
                },
                AppProfileId = "",
                AuthorizedViewNameAsAuthorizedViewName = AuthorizedViewName.FromProjectInstanceTableAuthorizedView("[PROJECT]", "[INSTANCE]", "[TABLE]", "[AUTHORIZED_VIEW]"),
            };
            // Make the request
            ReadModifyWriteRowResponse response = await bigtableServiceApiClient.ReadModifyWriteRowAsync(request);
        }
    }
    // [END bigtable_v2_generated_Bigtable_ReadModifyWriteRow_async]
}
