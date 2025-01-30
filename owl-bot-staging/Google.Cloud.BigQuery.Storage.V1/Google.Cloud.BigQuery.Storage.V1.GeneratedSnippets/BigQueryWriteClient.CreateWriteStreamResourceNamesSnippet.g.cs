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
    // [START bigquerystorage_v1_generated_BigQueryWrite_CreateWriteStream_sync_flattened_resourceNames]
    using Google.Cloud.BigQuery.Storage.V1;

    public sealed partial class GeneratedBigQueryWriteClientSnippets
    {
        /// <summary>Snippet for CreateWriteStream</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateWriteStreamResourceNames()
        {
            // Create client
            BigQueryWriteClient bigQueryWriteClient = BigQueryWriteClient.Create();
            // Initialize request argument(s)
            TableName parent = TableName.FromProjectDatasetTable("[PROJECT]", "[DATASET]", "[TABLE]");
            WriteStream writeStream = new WriteStream();
            // Make the request
            WriteStream response = bigQueryWriteClient.CreateWriteStream(parent, writeStream);
        }
    }
    // [END bigquerystorage_v1_generated_BigQueryWrite_CreateWriteStream_sync_flattened_resourceNames]
}
