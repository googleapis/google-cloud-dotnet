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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.WebRisk.V1;
    using Google.LongRunning;
    using Google.Protobuf;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedWebRiskServiceClientSnippets
    {
        /// <summary>Snippet for ComputeThreatListDiff</summary>
        public void ComputeThreatListDiffRequestObject()
        {
            // Snippet: ComputeThreatListDiff(ComputeThreatListDiffRequest, CallSettings)
            // Create client
            WebRiskServiceClient webRiskServiceClient = WebRiskServiceClient.Create();
            // Initialize request argument(s)
            ComputeThreatListDiffRequest request = new ComputeThreatListDiffRequest
            {
                ThreatType = ThreatType.Unspecified,
                VersionToken = ByteString.Empty,
                Constraints = new ComputeThreatListDiffRequest.Types.Constraints(),
            };
            // Make the request
            ComputeThreatListDiffResponse response = webRiskServiceClient.ComputeThreatListDiff(request);
            // End snippet
        }

        /// <summary>Snippet for ComputeThreatListDiffAsync</summary>
        public async Task ComputeThreatListDiffRequestObjectAsync()
        {
            // Snippet: ComputeThreatListDiffAsync(ComputeThreatListDiffRequest, CallSettings)
            // Additional: ComputeThreatListDiffAsync(ComputeThreatListDiffRequest, CancellationToken)
            // Create client
            WebRiskServiceClient webRiskServiceClient = await WebRiskServiceClient.CreateAsync();
            // Initialize request argument(s)
            ComputeThreatListDiffRequest request = new ComputeThreatListDiffRequest
            {
                ThreatType = ThreatType.Unspecified,
                VersionToken = ByteString.Empty,
                Constraints = new ComputeThreatListDiffRequest.Types.Constraints(),
            };
            // Make the request
            ComputeThreatListDiffResponse response = await webRiskServiceClient.ComputeThreatListDiffAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ComputeThreatListDiff</summary>
        public void ComputeThreatListDiff()
        {
            // Snippet: ComputeThreatListDiff(ThreatType, ByteString, ComputeThreatListDiffRequest.Types.Constraints, CallSettings)
            // Create client
            WebRiskServiceClient webRiskServiceClient = WebRiskServiceClient.Create();
            // Initialize request argument(s)
            ThreatType threatType = ThreatType.Unspecified;
            ByteString versionToken = ByteString.Empty;
            ComputeThreatListDiffRequest.Types.Constraints constraints = new ComputeThreatListDiffRequest.Types.Constraints();
            // Make the request
            ComputeThreatListDiffResponse response = webRiskServiceClient.ComputeThreatListDiff(threatType, versionToken, constraints);
            // End snippet
        }

        /// <summary>Snippet for ComputeThreatListDiffAsync</summary>
        public async Task ComputeThreatListDiffAsync()
        {
            // Snippet: ComputeThreatListDiffAsync(ThreatType, ByteString, ComputeThreatListDiffRequest.Types.Constraints, CallSettings)
            // Additional: ComputeThreatListDiffAsync(ThreatType, ByteString, ComputeThreatListDiffRequest.Types.Constraints, CancellationToken)
            // Create client
            WebRiskServiceClient webRiskServiceClient = await WebRiskServiceClient.CreateAsync();
            // Initialize request argument(s)
            ThreatType threatType = ThreatType.Unspecified;
            ByteString versionToken = ByteString.Empty;
            ComputeThreatListDiffRequest.Types.Constraints constraints = new ComputeThreatListDiffRequest.Types.Constraints();
            // Make the request
            ComputeThreatListDiffResponse response = await webRiskServiceClient.ComputeThreatListDiffAsync(threatType, versionToken, constraints);
            // End snippet
        }

        /// <summary>Snippet for SearchUris</summary>
        public void SearchUrisRequestObject()
        {
            // Snippet: SearchUris(SearchUrisRequest, CallSettings)
            // Create client
            WebRiskServiceClient webRiskServiceClient = WebRiskServiceClient.Create();
            // Initialize request argument(s)
            SearchUrisRequest request = new SearchUrisRequest
            {
                Uri = "",
                ThreatTypes =
                {
                    ThreatType.Unspecified,
                },
            };
            // Make the request
            SearchUrisResponse response = webRiskServiceClient.SearchUris(request);
            // End snippet
        }

        /// <summary>Snippet for SearchUrisAsync</summary>
        public async Task SearchUrisRequestObjectAsync()
        {
            // Snippet: SearchUrisAsync(SearchUrisRequest, CallSettings)
            // Additional: SearchUrisAsync(SearchUrisRequest, CancellationToken)
            // Create client
            WebRiskServiceClient webRiskServiceClient = await WebRiskServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchUrisRequest request = new SearchUrisRequest
            {
                Uri = "",
                ThreatTypes =
                {
                    ThreatType.Unspecified,
                },
            };
            // Make the request
            SearchUrisResponse response = await webRiskServiceClient.SearchUrisAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SearchUris</summary>
        public void SearchUris()
        {
            // Snippet: SearchUris(string, IEnumerable<ThreatType>, CallSettings)
            // Create client
            WebRiskServiceClient webRiskServiceClient = WebRiskServiceClient.Create();
            // Initialize request argument(s)
            string uri = "";
            IEnumerable<ThreatType> threatTypes = new ThreatType[]
            {
                ThreatType.Unspecified,
            };
            // Make the request
            SearchUrisResponse response = webRiskServiceClient.SearchUris(uri, threatTypes);
            // End snippet
        }

        /// <summary>Snippet for SearchUrisAsync</summary>
        public async Task SearchUrisAsync()
        {
            // Snippet: SearchUrisAsync(string, IEnumerable<ThreatType>, CallSettings)
            // Additional: SearchUrisAsync(string, IEnumerable<ThreatType>, CancellationToken)
            // Create client
            WebRiskServiceClient webRiskServiceClient = await WebRiskServiceClient.CreateAsync();
            // Initialize request argument(s)
            string uri = "";
            IEnumerable<ThreatType> threatTypes = new ThreatType[]
            {
                ThreatType.Unspecified,
            };
            // Make the request
            SearchUrisResponse response = await webRiskServiceClient.SearchUrisAsync(uri, threatTypes);
            // End snippet
        }

        /// <summary>Snippet for SearchHashes</summary>
        public void SearchHashesRequestObject()
        {
            // Snippet: SearchHashes(SearchHashesRequest, CallSettings)
            // Create client
            WebRiskServiceClient webRiskServiceClient = WebRiskServiceClient.Create();
            // Initialize request argument(s)
            SearchHashesRequest request = new SearchHashesRequest
            {
                HashPrefix = ByteString.Empty,
                ThreatTypes =
                {
                    ThreatType.Unspecified,
                },
            };
            // Make the request
            SearchHashesResponse response = webRiskServiceClient.SearchHashes(request);
            // End snippet
        }

        /// <summary>Snippet for SearchHashesAsync</summary>
        public async Task SearchHashesRequestObjectAsync()
        {
            // Snippet: SearchHashesAsync(SearchHashesRequest, CallSettings)
            // Additional: SearchHashesAsync(SearchHashesRequest, CancellationToken)
            // Create client
            WebRiskServiceClient webRiskServiceClient = await WebRiskServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchHashesRequest request = new SearchHashesRequest
            {
                HashPrefix = ByteString.Empty,
                ThreatTypes =
                {
                    ThreatType.Unspecified,
                },
            };
            // Make the request
            SearchHashesResponse response = await webRiskServiceClient.SearchHashesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SearchHashes</summary>
        public void SearchHashes()
        {
            // Snippet: SearchHashes(ByteString, IEnumerable<ThreatType>, CallSettings)
            // Create client
            WebRiskServiceClient webRiskServiceClient = WebRiskServiceClient.Create();
            // Initialize request argument(s)
            ByteString hashPrefix = ByteString.Empty;
            IEnumerable<ThreatType> threatTypes = new ThreatType[]
            {
                ThreatType.Unspecified,
            };
            // Make the request
            SearchHashesResponse response = webRiskServiceClient.SearchHashes(hashPrefix, threatTypes);
            // End snippet
        }

        /// <summary>Snippet for SearchHashesAsync</summary>
        public async Task SearchHashesAsync()
        {
            // Snippet: SearchHashesAsync(ByteString, IEnumerable<ThreatType>, CallSettings)
            // Additional: SearchHashesAsync(ByteString, IEnumerable<ThreatType>, CancellationToken)
            // Create client
            WebRiskServiceClient webRiskServiceClient = await WebRiskServiceClient.CreateAsync();
            // Initialize request argument(s)
            ByteString hashPrefix = ByteString.Empty;
            IEnumerable<ThreatType> threatTypes = new ThreatType[]
            {
                ThreatType.Unspecified,
            };
            // Make the request
            SearchHashesResponse response = await webRiskServiceClient.SearchHashesAsync(hashPrefix, threatTypes);
            // End snippet
        }

        /// <summary>Snippet for CreateSubmission</summary>
        public void CreateSubmissionRequestObject()
        {
            // Snippet: CreateSubmission(CreateSubmissionRequest, CallSettings)
            // Create client
            WebRiskServiceClient webRiskServiceClient = WebRiskServiceClient.Create();
            // Initialize request argument(s)
            CreateSubmissionRequest request = new CreateSubmissionRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Submission = new Submission(),
            };
            // Make the request
            Submission response = webRiskServiceClient.CreateSubmission(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSubmissionAsync</summary>
        public async Task CreateSubmissionRequestObjectAsync()
        {
            // Snippet: CreateSubmissionAsync(CreateSubmissionRequest, CallSettings)
            // Additional: CreateSubmissionAsync(CreateSubmissionRequest, CancellationToken)
            // Create client
            WebRiskServiceClient webRiskServiceClient = await WebRiskServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSubmissionRequest request = new CreateSubmissionRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Submission = new Submission(),
            };
            // Make the request
            Submission response = await webRiskServiceClient.CreateSubmissionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSubmission</summary>
        public void CreateSubmission()
        {
            // Snippet: CreateSubmission(string, Submission, CallSettings)
            // Create client
            WebRiskServiceClient webRiskServiceClient = WebRiskServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Submission submission = new Submission();
            // Make the request
            Submission response = webRiskServiceClient.CreateSubmission(parent, submission);
            // End snippet
        }

        /// <summary>Snippet for CreateSubmissionAsync</summary>
        public async Task CreateSubmissionAsync()
        {
            // Snippet: CreateSubmissionAsync(string, Submission, CallSettings)
            // Additional: CreateSubmissionAsync(string, Submission, CancellationToken)
            // Create client
            WebRiskServiceClient webRiskServiceClient = await WebRiskServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Submission submission = new Submission();
            // Make the request
            Submission response = await webRiskServiceClient.CreateSubmissionAsync(parent, submission);
            // End snippet
        }

        /// <summary>Snippet for CreateSubmission</summary>
        public void CreateSubmissionResourceNames()
        {
            // Snippet: CreateSubmission(ProjectName, Submission, CallSettings)
            // Create client
            WebRiskServiceClient webRiskServiceClient = WebRiskServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Submission submission = new Submission();
            // Make the request
            Submission response = webRiskServiceClient.CreateSubmission(parent, submission);
            // End snippet
        }

        /// <summary>Snippet for CreateSubmissionAsync</summary>
        public async Task CreateSubmissionResourceNamesAsync()
        {
            // Snippet: CreateSubmissionAsync(ProjectName, Submission, CallSettings)
            // Additional: CreateSubmissionAsync(ProjectName, Submission, CancellationToken)
            // Create client
            WebRiskServiceClient webRiskServiceClient = await WebRiskServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Submission submission = new Submission();
            // Make the request
            Submission response = await webRiskServiceClient.CreateSubmissionAsync(parent, submission);
            // End snippet
        }

        /// <summary>Snippet for SubmitUri</summary>
        public void SubmitUriRequestObject()
        {
            // Snippet: SubmitUri(SubmitUriRequest, CallSettings)
            // Create client
            WebRiskServiceClient webRiskServiceClient = WebRiskServiceClient.Create();
            // Initialize request argument(s)
            SubmitUriRequest request = new SubmitUriRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Submission = new Submission(),
                ThreatInfo = new ThreatInfo(),
                ThreatDiscovery = new ThreatDiscovery(),
            };
            // Make the request
            Operation<Submission, SubmitUriMetadata> response = webRiskServiceClient.SubmitUri(request);

            // Poll until the returned long-running operation is complete
            Operation<Submission, SubmitUriMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Submission result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Submission, SubmitUriMetadata> retrievedResponse = webRiskServiceClient.PollOnceSubmitUri(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Submission retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SubmitUriAsync</summary>
        public async Task SubmitUriRequestObjectAsync()
        {
            // Snippet: SubmitUriAsync(SubmitUriRequest, CallSettings)
            // Additional: SubmitUriAsync(SubmitUriRequest, CancellationToken)
            // Create client
            WebRiskServiceClient webRiskServiceClient = await WebRiskServiceClient.CreateAsync();
            // Initialize request argument(s)
            SubmitUriRequest request = new SubmitUriRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Submission = new Submission(),
                ThreatInfo = new ThreatInfo(),
                ThreatDiscovery = new ThreatDiscovery(),
            };
            // Make the request
            Operation<Submission, SubmitUriMetadata> response = await webRiskServiceClient.SubmitUriAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Submission, SubmitUriMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Submission result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Submission, SubmitUriMetadata> retrievedResponse = await webRiskServiceClient.PollOnceSubmitUriAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Submission retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
