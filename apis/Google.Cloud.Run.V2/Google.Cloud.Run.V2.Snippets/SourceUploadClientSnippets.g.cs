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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax.ResourceNames;
    using System.Threading.Tasks;
    using gcrv = Google.Cloud.Run.V2;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSourceUploadClientSnippets
    {
        /// <summary>Snippet for UploadSource</summary>
        public void UploadSourceRequestObject()
        {
            // Snippet: UploadSource(UploadSourceRequest, CallSettings)
            // Create client
            gcrv::SourceUploadClient sourceUploadClient = gcrv::SourceUploadClient.Create();
            // Initialize request argument(s)
            gcrv::UploadSourceRequest request = new gcrv::UploadSourceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ServiceAsServiceName = gcrv::ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
            };
            // Make the request
            gcrv::UploadSourceResponse response = sourceUploadClient.UploadSource(request);
            // End snippet
        }

        /// <summary>Snippet for UploadSourceAsync</summary>
        public async Task UploadSourceRequestObjectAsync()
        {
            // Snippet: UploadSourceAsync(UploadSourceRequest, CallSettings)
            // Additional: UploadSourceAsync(UploadSourceRequest, CancellationToken)
            // Create client
            gcrv::SourceUploadClient sourceUploadClient = await gcrv::SourceUploadClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::UploadSourceRequest request = new gcrv::UploadSourceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ServiceAsServiceName = gcrv::ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
            };
            // Make the request
            gcrv::UploadSourceResponse response = await sourceUploadClient.UploadSourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UploadSource</summary>
        public void UploadSource()
        {
            // Snippet: UploadSource(string, CallSettings)
            // Create client
            gcrv::SourceUploadClient sourceUploadClient = gcrv::SourceUploadClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            gcrv::UploadSourceResponse response = sourceUploadClient.UploadSource(parent);
            // End snippet
        }

        /// <summary>Snippet for UploadSourceAsync</summary>
        public async Task UploadSourceAsync()
        {
            // Snippet: UploadSourceAsync(string, CallSettings)
            // Additional: UploadSourceAsync(string, CancellationToken)
            // Create client
            gcrv::SourceUploadClient sourceUploadClient = await gcrv::SourceUploadClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            gcrv::UploadSourceResponse response = await sourceUploadClient.UploadSourceAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for UploadSource</summary>
        public void UploadSourceResourceNames()
        {
            // Snippet: UploadSource(LocationName, CallSettings)
            // Create client
            gcrv::SourceUploadClient sourceUploadClient = gcrv::SourceUploadClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            gcrv::UploadSourceResponse response = sourceUploadClient.UploadSource(parent);
            // End snippet
        }

        /// <summary>Snippet for UploadSourceAsync</summary>
        public async Task UploadSourceResourceNamesAsync()
        {
            // Snippet: UploadSourceAsync(LocationName, CallSettings)
            // Additional: UploadSourceAsync(LocationName, CancellationToken)
            // Create client
            gcrv::SourceUploadClient sourceUploadClient = await gcrv::SourceUploadClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            gcrv::UploadSourceResponse response = await sourceUploadClient.UploadSourceAsync(parent);
            // End snippet
        }
    }
}
