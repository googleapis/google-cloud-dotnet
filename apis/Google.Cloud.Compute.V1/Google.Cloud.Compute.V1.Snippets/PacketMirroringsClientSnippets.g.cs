// Copyright 2021 Google LLC
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

namespace Google.Cloud.Compute.V1.Snippets
{
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedPacketMirroringsClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListPacketMirroringsRequest, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            AggregatedListPacketMirroringsRequest request = new AggregatedListPacketMirroringsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                IncludeAllScopes = false,
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PacketMirroringAggregatedList response = packetMirroringsClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListPacketMirroringsRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListPacketMirroringsRequest, CancellationToken)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListPacketMirroringsRequest request = new AggregatedListPacketMirroringsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                IncludeAllScopes = false,
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PacketMirroringAggregatedList response = await packetMirroringsClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PacketMirroringAggregatedList response = packetMirroringsClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PacketMirroringAggregatedList response = await packetMirroringsClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeletePacketMirroringRequest, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            DeletePacketMirroringRequest request = new DeletePacketMirroringRequest
            {
                PacketMirroring = "",
                RequestId = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = packetMirroringsClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeletePacketMirroringRequest, CallSettings)
            // Additional: DeleteAsync(DeletePacketMirroringRequest, CancellationToken)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            DeletePacketMirroringRequest request = new DeletePacketMirroringRequest
            {
                PacketMirroring = "",
                RequestId = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = await packetMirroringsClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string packetMirroring = "";
            // Make the request
            Operation response = packetMirroringsClient.Delete(project, region, packetMirroring);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string packetMirroring = "";
            // Make the request
            Operation response = await packetMirroringsClient.DeleteAsync(project, region, packetMirroring);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetPacketMirroringRequest, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            GetPacketMirroringRequest request = new GetPacketMirroringRequest
            {
                PacketMirroring = "",
                Region = "",
                Project = "",
            };
            // Make the request
            PacketMirroring response = packetMirroringsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetPacketMirroringRequest, CallSettings)
            // Additional: GetAsync(GetPacketMirroringRequest, CancellationToken)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            GetPacketMirroringRequest request = new GetPacketMirroringRequest
            {
                PacketMirroring = "",
                Region = "",
                Project = "",
            };
            // Make the request
            PacketMirroring response = await packetMirroringsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string packetMirroring = "";
            // Make the request
            PacketMirroring response = packetMirroringsClient.Get(project, region, packetMirroring);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string packetMirroring = "";
            // Make the request
            PacketMirroring response = await packetMirroringsClient.GetAsync(project, region, packetMirroring);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertPacketMirroringRequest, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            InsertPacketMirroringRequest request = new InsertPacketMirroringRequest
            {
                RequestId = "",
                Region = "",
                PacketMirroringResource = new PacketMirroring(),
                Project = "",
            };
            // Make the request
            Operation response = packetMirroringsClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertPacketMirroringRequest, CallSettings)
            // Additional: InsertAsync(InsertPacketMirroringRequest, CancellationToken)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            InsertPacketMirroringRequest request = new InsertPacketMirroringRequest
            {
                RequestId = "",
                Region = "",
                PacketMirroringResource = new PacketMirroring(),
                Project = "",
            };
            // Make the request
            Operation response = await packetMirroringsClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, PacketMirroring, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            PacketMirroring packetMirroringResource = new PacketMirroring();
            // Make the request
            Operation response = packetMirroringsClient.Insert(project, region, packetMirroringResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, PacketMirroring, CallSettings)
            // Additional: InsertAsync(string, string, PacketMirroring, CancellationToken)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            PacketMirroring packetMirroringResource = new PacketMirroring();
            // Make the request
            Operation response = await packetMirroringsClient.InsertAsync(project, region, packetMirroringResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListPacketMirroringsRequest, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            ListPacketMirroringsRequest request = new ListPacketMirroringsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                Region = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PacketMirroringList response = packetMirroringsClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListPacketMirroringsRequest, CallSettings)
            // Additional: ListAsync(ListPacketMirroringsRequest, CancellationToken)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            ListPacketMirroringsRequest request = new ListPacketMirroringsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                Region = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PacketMirroringList response = await packetMirroringsClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PacketMirroringList response = packetMirroringsClient.List(project, region);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PacketMirroringList response = await packetMirroringsClient.ListAsync(project, region);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchPacketMirroringRequest, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            PatchPacketMirroringRequest request = new PatchPacketMirroringRequest
            {
                PacketMirroring = "",
                RequestId = "",
                Region = "",
                PacketMirroringResource = new PacketMirroring(),
                Project = "",
            };
            // Make the request
            Operation response = packetMirroringsClient.Patch(request);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchPacketMirroringRequest, CallSettings)
            // Additional: PatchAsync(PatchPacketMirroringRequest, CancellationToken)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            PatchPacketMirroringRequest request = new PatchPacketMirroringRequest
            {
                PacketMirroring = "",
                RequestId = "",
                Region = "",
                PacketMirroringResource = new PacketMirroring(),
                Project = "",
            };
            // Make the request
            Operation response = await packetMirroringsClient.PatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, string, PacketMirroring, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string packetMirroring = "";
            PacketMirroring packetMirroringResource = new PacketMirroring();
            // Make the request
            Operation response = packetMirroringsClient.Patch(project, region, packetMirroring, packetMirroringResource);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, string, PacketMirroring, CallSettings)
            // Additional: PatchAsync(string, string, string, PacketMirroring, CancellationToken)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string packetMirroring = "";
            PacketMirroring packetMirroringResource = new PacketMirroring();
            // Make the request
            Operation response = await packetMirroringsClient.PatchAsync(project, region, packetMirroring, packetMirroringResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsPacketMirroringRequest, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsPacketMirroringRequest request = new TestIamPermissionsPacketMirroringRequest
            {
                Region = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            TestPermissionsResponse response = packetMirroringsClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsPacketMirroringRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsPacketMirroringRequest, CancellationToken)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsPacketMirroringRequest request = new TestIamPermissionsPacketMirroringRequest
            {
                Region = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            TestPermissionsResponse response = await packetMirroringsClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            PacketMirroringsClient packetMirroringsClient = PacketMirroringsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = packetMirroringsClient.TestIamPermissions(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            PacketMirroringsClient packetMirroringsClient = await PacketMirroringsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await packetMirroringsClient.TestIamPermissionsAsync(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
