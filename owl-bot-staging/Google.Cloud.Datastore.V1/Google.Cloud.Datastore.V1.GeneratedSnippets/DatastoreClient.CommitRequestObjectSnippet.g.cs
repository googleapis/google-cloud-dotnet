// Copyright 2022 Google LLC
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

namespace Google.Cloud.Datastore.V1.Snippets
{
    // [START datastore_v1_generated_Datastore_Commit_sync]
    using Google.Cloud.Datastore.V1;
    using Google.Protobuf;

    public sealed partial class GeneratedDatastoreClientSnippets
    {
        /// <summary>Snippet for Commit</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CommitRequestObject()
        {
            // Create client
            DatastoreClient datastoreClient = DatastoreClient.Create();
            // Initialize request argument(s)
            CommitRequest request = new CommitRequest
            {
                Transaction = ByteString.Empty,
                Mode = CommitRequest.Types.Mode.Unspecified,
                Mutations = { new Mutation(), },
                ProjectId = "",
            };
            // Make the request
            CommitResponse response = datastoreClient.Commit(request);
        }
    }
    // [END datastore_v1_generated_Datastore_Commit_sync]
}
