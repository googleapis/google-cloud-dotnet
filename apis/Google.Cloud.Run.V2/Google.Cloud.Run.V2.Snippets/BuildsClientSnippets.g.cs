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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using System.Threading.Tasks;
    using gcrv = Google.Cloud.Run.V2;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedBuildsClientSnippets
    {
        /// <summary>Snippet for SubmitBuild</summary>
        public void SubmitBuildRequestObject()
        {
            // Snippet: SubmitBuild(SubmitBuildRequest, CallSettings)
            // Create client
            gcrv::BuildsClient buildsClient = gcrv::BuildsClient.Create();
            // Initialize request argument(s)
            gcrv::SubmitBuildRequest request = new gcrv::SubmitBuildRequest
            {
                Parent = "",
                StorageSource = new gcrv::StorageSource(),
                ImageUri = "",
                BuildpackBuild = new gcrv::SubmitBuildRequest.Types.BuildpacksBuild(),
                ServiceAccount = "",
                WorkerPoolAsWorkerPoolName = gcrv::WorkerPoolName.FromProjectLocationWorkerPool("[PROJECT]", "[LOCATION]", "[WORKER_POOL]"),
                Tags = { "", },
            };
            // Make the request
            gcrv::SubmitBuildResponse response = buildsClient.SubmitBuild(request);
            // End snippet
        }

        /// <summary>Snippet for SubmitBuildAsync</summary>
        public async Task SubmitBuildRequestObjectAsync()
        {
            // Snippet: SubmitBuildAsync(SubmitBuildRequest, CallSettings)
            // Additional: SubmitBuildAsync(SubmitBuildRequest, CancellationToken)
            // Create client
            gcrv::BuildsClient buildsClient = await gcrv::BuildsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::SubmitBuildRequest request = new gcrv::SubmitBuildRequest
            {
                Parent = "",
                StorageSource = new gcrv::StorageSource(),
                ImageUri = "",
                BuildpackBuild = new gcrv::SubmitBuildRequest.Types.BuildpacksBuild(),
                ServiceAccount = "",
                WorkerPoolAsWorkerPoolName = gcrv::WorkerPoolName.FromProjectLocationWorkerPool("[PROJECT]", "[LOCATION]", "[WORKER_POOL]"),
                Tags = { "", },
            };
            // Make the request
            gcrv::SubmitBuildResponse response = await buildsClient.SubmitBuildAsync(request);
            // End snippet
        }
    }
}
