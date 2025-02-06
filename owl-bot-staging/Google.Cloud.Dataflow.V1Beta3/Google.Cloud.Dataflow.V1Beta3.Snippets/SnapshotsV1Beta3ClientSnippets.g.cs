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
    using Google.Cloud.Dataflow.V1Beta3;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSnapshotsV1Beta3ClientSnippets
    {
        /// <summary>Snippet for GetSnapshot</summary>
        public void GetSnapshotRequestObject()
        {
            // Snippet: GetSnapshot(GetSnapshotRequest, CallSettings)
            // Create client
            SnapshotsV1Beta3Client snapshotsV1Beta3Client = SnapshotsV1Beta3Client.Create();
            // Initialize request argument(s)
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                ProjectId = "",
                SnapshotId = "",
                Location = "",
            };
            // Make the request
            Snapshot response = snapshotsV1Beta3Client.GetSnapshot(request);
            // End snippet
        }

        /// <summary>Snippet for GetSnapshotAsync</summary>
        public async Task GetSnapshotRequestObjectAsync()
        {
            // Snippet: GetSnapshotAsync(GetSnapshotRequest, CallSettings)
            // Additional: GetSnapshotAsync(GetSnapshotRequest, CancellationToken)
            // Create client
            SnapshotsV1Beta3Client snapshotsV1Beta3Client = await SnapshotsV1Beta3Client.CreateAsync();
            // Initialize request argument(s)
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                ProjectId = "",
                SnapshotId = "",
                Location = "",
            };
            // Make the request
            Snapshot response = await snapshotsV1Beta3Client.GetSnapshotAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshot</summary>
        public void DeleteSnapshotRequestObject()
        {
            // Snippet: DeleteSnapshot(DeleteSnapshotRequest, CallSettings)
            // Create client
            SnapshotsV1Beta3Client snapshotsV1Beta3Client = SnapshotsV1Beta3Client.Create();
            // Initialize request argument(s)
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                ProjectId = "",
                SnapshotId = "",
                Location = "",
            };
            // Make the request
            DeleteSnapshotResponse response = snapshotsV1Beta3Client.DeleteSnapshot(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshotAsync</summary>
        public async Task DeleteSnapshotRequestObjectAsync()
        {
            // Snippet: DeleteSnapshotAsync(DeleteSnapshotRequest, CallSettings)
            // Additional: DeleteSnapshotAsync(DeleteSnapshotRequest, CancellationToken)
            // Create client
            SnapshotsV1Beta3Client snapshotsV1Beta3Client = await SnapshotsV1Beta3Client.CreateAsync();
            // Initialize request argument(s)
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                ProjectId = "",
                SnapshotId = "",
                Location = "",
            };
            // Make the request
            DeleteSnapshotResponse response = await snapshotsV1Beta3Client.DeleteSnapshotAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListSnapshots</summary>
        public void ListSnapshotsRequestObject()
        {
            // Snippet: ListSnapshots(ListSnapshotsRequest, CallSettings)
            // Create client
            SnapshotsV1Beta3Client snapshotsV1Beta3Client = SnapshotsV1Beta3Client.Create();
            // Initialize request argument(s)
            ListSnapshotsRequest request = new ListSnapshotsRequest
            {
                ProjectId = "",
                Location = "",
                JobId = "",
            };
            // Make the request
            ListSnapshotsResponse response = snapshotsV1Beta3Client.ListSnapshots(request);
            // End snippet
        }

        /// <summary>Snippet for ListSnapshotsAsync</summary>
        public async Task ListSnapshotsRequestObjectAsync()
        {
            // Snippet: ListSnapshotsAsync(ListSnapshotsRequest, CallSettings)
            // Additional: ListSnapshotsAsync(ListSnapshotsRequest, CancellationToken)
            // Create client
            SnapshotsV1Beta3Client snapshotsV1Beta3Client = await SnapshotsV1Beta3Client.CreateAsync();
            // Initialize request argument(s)
            ListSnapshotsRequest request = new ListSnapshotsRequest
            {
                ProjectId = "",
                Location = "",
                JobId = "",
            };
            // Make the request
            ListSnapshotsResponse response = await snapshotsV1Beta3Client.ListSnapshotsAsync(request);
            // End snippet
        }
    }
}
