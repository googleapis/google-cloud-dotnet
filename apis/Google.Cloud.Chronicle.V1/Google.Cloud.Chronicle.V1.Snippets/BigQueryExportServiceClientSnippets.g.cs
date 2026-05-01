// Copyright 2026 Google LLC
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
    using Google.Cloud.Chronicle.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedBigQueryExportServiceClientSnippets
    {
        /// <summary>Snippet for GetBigQueryExport</summary>
        public void GetBigQueryExportRequestObject()
        {
            // Snippet: GetBigQueryExport(GetBigQueryExportRequest, CallSettings)
            // Create client
            BigQueryExportServiceClient bigQueryExportServiceClient = BigQueryExportServiceClient.Create();
            // Initialize request argument(s)
            GetBigQueryExportRequest request = new GetBigQueryExportRequest
            {
                BigQueryExportName = BigQueryExportName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            BigQueryExport response = bigQueryExportServiceClient.GetBigQueryExport(request);
            // End snippet
        }

        /// <summary>Snippet for GetBigQueryExportAsync</summary>
        public async Task GetBigQueryExportRequestObjectAsync()
        {
            // Snippet: GetBigQueryExportAsync(GetBigQueryExportRequest, CallSettings)
            // Additional: GetBigQueryExportAsync(GetBigQueryExportRequest, CancellationToken)
            // Create client
            BigQueryExportServiceClient bigQueryExportServiceClient = await BigQueryExportServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetBigQueryExportRequest request = new GetBigQueryExportRequest
            {
                BigQueryExportName = BigQueryExportName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            BigQueryExport response = await bigQueryExportServiceClient.GetBigQueryExportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBigQueryExport</summary>
        public void GetBigQueryExport()
        {
            // Snippet: GetBigQueryExport(string, CallSettings)
            // Create client
            BigQueryExportServiceClient bigQueryExportServiceClient = BigQueryExportServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/bigQueryExport";
            // Make the request
            BigQueryExport response = bigQueryExportServiceClient.GetBigQueryExport(name);
            // End snippet
        }

        /// <summary>Snippet for GetBigQueryExportAsync</summary>
        public async Task GetBigQueryExportAsync()
        {
            // Snippet: GetBigQueryExportAsync(string, CallSettings)
            // Additional: GetBigQueryExportAsync(string, CancellationToken)
            // Create client
            BigQueryExportServiceClient bigQueryExportServiceClient = await BigQueryExportServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/bigQueryExport";
            // Make the request
            BigQueryExport response = await bigQueryExportServiceClient.GetBigQueryExportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBigQueryExport</summary>
        public void GetBigQueryExportResourceNames()
        {
            // Snippet: GetBigQueryExport(BigQueryExportName, CallSettings)
            // Create client
            BigQueryExportServiceClient bigQueryExportServiceClient = BigQueryExportServiceClient.Create();
            // Initialize request argument(s)
            BigQueryExportName name = BigQueryExportName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            BigQueryExport response = bigQueryExportServiceClient.GetBigQueryExport(name);
            // End snippet
        }

        /// <summary>Snippet for GetBigQueryExportAsync</summary>
        public async Task GetBigQueryExportResourceNamesAsync()
        {
            // Snippet: GetBigQueryExportAsync(BigQueryExportName, CallSettings)
            // Additional: GetBigQueryExportAsync(BigQueryExportName, CancellationToken)
            // Create client
            BigQueryExportServiceClient bigQueryExportServiceClient = await BigQueryExportServiceClient.CreateAsync();
            // Initialize request argument(s)
            BigQueryExportName name = BigQueryExportName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            BigQueryExport response = await bigQueryExportServiceClient.GetBigQueryExportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateBigQueryExport</summary>
        public void UpdateBigQueryExportRequestObject()
        {
            // Snippet: UpdateBigQueryExport(UpdateBigQueryExportRequest, CallSettings)
            // Create client
            BigQueryExportServiceClient bigQueryExportServiceClient = BigQueryExportServiceClient.Create();
            // Initialize request argument(s)
            UpdateBigQueryExportRequest request = new UpdateBigQueryExportRequest
            {
                BigQueryExport = new BigQueryExport(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            BigQueryExport response = bigQueryExportServiceClient.UpdateBigQueryExport(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBigQueryExportAsync</summary>
        public async Task UpdateBigQueryExportRequestObjectAsync()
        {
            // Snippet: UpdateBigQueryExportAsync(UpdateBigQueryExportRequest, CallSettings)
            // Additional: UpdateBigQueryExportAsync(UpdateBigQueryExportRequest, CancellationToken)
            // Create client
            BigQueryExportServiceClient bigQueryExportServiceClient = await BigQueryExportServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBigQueryExportRequest request = new UpdateBigQueryExportRequest
            {
                BigQueryExport = new BigQueryExport(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            BigQueryExport response = await bigQueryExportServiceClient.UpdateBigQueryExportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBigQueryExport</summary>
        public void UpdateBigQueryExport()
        {
            // Snippet: UpdateBigQueryExport(BigQueryExport, FieldMask, CallSettings)
            // Create client
            BigQueryExportServiceClient bigQueryExportServiceClient = BigQueryExportServiceClient.Create();
            // Initialize request argument(s)
            BigQueryExport bigQueryExport = new BigQueryExport();
            FieldMask updateMask = new FieldMask();
            // Make the request
            BigQueryExport response = bigQueryExportServiceClient.UpdateBigQueryExport(bigQueryExport, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateBigQueryExportAsync</summary>
        public async Task UpdateBigQueryExportAsync()
        {
            // Snippet: UpdateBigQueryExportAsync(BigQueryExport, FieldMask, CallSettings)
            // Additional: UpdateBigQueryExportAsync(BigQueryExport, FieldMask, CancellationToken)
            // Create client
            BigQueryExportServiceClient bigQueryExportServiceClient = await BigQueryExportServiceClient.CreateAsync();
            // Initialize request argument(s)
            BigQueryExport bigQueryExport = new BigQueryExport();
            FieldMask updateMask = new FieldMask();
            // Make the request
            BigQueryExport response = await bigQueryExportServiceClient.UpdateBigQueryExportAsync(bigQueryExport, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ProvisionBigQueryExport</summary>
        public void ProvisionBigQueryExportRequestObject()
        {
            // Snippet: ProvisionBigQueryExport(ProvisionBigQueryExportRequest, CallSettings)
            // Create client
            BigQueryExportServiceClient bigQueryExportServiceClient = BigQueryExportServiceClient.Create();
            // Initialize request argument(s)
            ProvisionBigQueryExportRequest request = new ProvisionBigQueryExportRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            BigQueryExport response = bigQueryExportServiceClient.ProvisionBigQueryExport(request);
            // End snippet
        }

        /// <summary>Snippet for ProvisionBigQueryExportAsync</summary>
        public async Task ProvisionBigQueryExportRequestObjectAsync()
        {
            // Snippet: ProvisionBigQueryExportAsync(ProvisionBigQueryExportRequest, CallSettings)
            // Additional: ProvisionBigQueryExportAsync(ProvisionBigQueryExportRequest, CancellationToken)
            // Create client
            BigQueryExportServiceClient bigQueryExportServiceClient = await BigQueryExportServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProvisionBigQueryExportRequest request = new ProvisionBigQueryExportRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            BigQueryExport response = await bigQueryExportServiceClient.ProvisionBigQueryExportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ProvisionBigQueryExport</summary>
        public void ProvisionBigQueryExport()
        {
            // Snippet: ProvisionBigQueryExport(string, CallSettings)
            // Create client
            BigQueryExportServiceClient bigQueryExportServiceClient = BigQueryExportServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            BigQueryExport response = bigQueryExportServiceClient.ProvisionBigQueryExport(parent);
            // End snippet
        }

        /// <summary>Snippet for ProvisionBigQueryExportAsync</summary>
        public async Task ProvisionBigQueryExportAsync()
        {
            // Snippet: ProvisionBigQueryExportAsync(string, CallSettings)
            // Additional: ProvisionBigQueryExportAsync(string, CancellationToken)
            // Create client
            BigQueryExportServiceClient bigQueryExportServiceClient = await BigQueryExportServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            BigQueryExport response = await bigQueryExportServiceClient.ProvisionBigQueryExportAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for ProvisionBigQueryExport</summary>
        public void ProvisionBigQueryExportResourceNames()
        {
            // Snippet: ProvisionBigQueryExport(InstanceName, CallSettings)
            // Create client
            BigQueryExportServiceClient bigQueryExportServiceClient = BigQueryExportServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            BigQueryExport response = bigQueryExportServiceClient.ProvisionBigQueryExport(parent);
            // End snippet
        }

        /// <summary>Snippet for ProvisionBigQueryExportAsync</summary>
        public async Task ProvisionBigQueryExportResourceNamesAsync()
        {
            // Snippet: ProvisionBigQueryExportAsync(InstanceName, CallSettings)
            // Additional: ProvisionBigQueryExportAsync(InstanceName, CancellationToken)
            // Create client
            BigQueryExportServiceClient bigQueryExportServiceClient = await BigQueryExportServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            BigQueryExport response = await bigQueryExportServiceClient.ProvisionBigQueryExportAsync(parent);
            // End snippet
        }
    }
}
