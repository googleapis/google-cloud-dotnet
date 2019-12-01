// Copyright 2019 Google LLC
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

namespace Google.Cloud.RecaptchaEnterprise.V1Beta1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedRecaptchaEnterpriseServiceV1Beta1ClientSnippets
    {
        /// <summary>Snippet for CreateAssessment</summary>
        public void CreateAssessment_RequestObject()
        {
            // Snippet: CreateAssessment(CreateAssessmentRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = RecaptchaEnterpriseServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            CreateAssessmentRequest request = new CreateAssessmentRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Assessment = new Assessment(),
            };
            // Make the request
            Assessment response = recaptchaEnterpriseServiceV1Beta1Client.CreateAssessment(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAssessmentAsync</summary>
        public async Task CreateAssessmentAsync_RequestObject()
        {
            // Snippet: CreateAssessmentAsync(CreateAssessmentRequest, CallSettings)
            // Additional: CreateAssessmentAsync(CreateAssessmentRequest, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = await RecaptchaEnterpriseServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            CreateAssessmentRequest request = new CreateAssessmentRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Assessment = new Assessment(),
            };
            // Make the request
            Assessment response = await recaptchaEnterpriseServiceV1Beta1Client.CreateAssessmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAssessment</summary>
        public void CreateAssessment()
        {
            // Snippet: CreateAssessment(string, Assessment, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = RecaptchaEnterpriseServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Assessment assessment = new Assessment();
            // Make the request
            Assessment response = recaptchaEnterpriseServiceV1Beta1Client.CreateAssessment(parent, assessment);
            // End snippet
        }

        /// <summary>Snippet for CreateAssessmentAsync</summary>
        public async Task CreateAssessmentAsync()
        {
            // Snippet: CreateAssessmentAsync(string, Assessment, CallSettings)
            // Additional: CreateAssessmentAsync(string, Assessment, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = await RecaptchaEnterpriseServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Assessment assessment = new Assessment();
            // Make the request
            Assessment response = await recaptchaEnterpriseServiceV1Beta1Client.CreateAssessmentAsync(parent, assessment);
            // End snippet
        }

        /// <summary>Snippet for CreateAssessment</summary>
        public void CreateAssessment_ResourceNames()
        {
            // Snippet: CreateAssessment(ProjectName, Assessment, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = RecaptchaEnterpriseServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            Assessment assessment = new Assessment();
            // Make the request
            Assessment response = recaptchaEnterpriseServiceV1Beta1Client.CreateAssessment(parent, assessment);
            // End snippet
        }

        /// <summary>Snippet for CreateAssessmentAsync</summary>
        public async Task CreateAssessmentAsync_ResourceNames()
        {
            // Snippet: CreateAssessmentAsync(ProjectName, Assessment, CallSettings)
            // Additional: CreateAssessmentAsync(ProjectName, Assessment, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = await RecaptchaEnterpriseServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            Assessment assessment = new Assessment();
            // Make the request
            Assessment response = await recaptchaEnterpriseServiceV1Beta1Client.CreateAssessmentAsync(parent, assessment);
            // End snippet
        }

        /// <summary>Snippet for AnnotateAssessment</summary>
        public void AnnotateAssessment_RequestObject()
        {
            // Snippet: AnnotateAssessment(AnnotateAssessmentRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = RecaptchaEnterpriseServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            AnnotateAssessmentRequest request = new AnnotateAssessmentRequest
            {
                AssessmentName = new AssessmentName("[PROJECT]", "[ASSESSMENT]"),
                Annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified,
            };
            // Make the request
            AnnotateAssessmentResponse response = recaptchaEnterpriseServiceV1Beta1Client.AnnotateAssessment(request);
            // End snippet
        }

        /// <summary>Snippet for AnnotateAssessmentAsync</summary>
        public async Task AnnotateAssessmentAsync_RequestObject()
        {
            // Snippet: AnnotateAssessmentAsync(AnnotateAssessmentRequest, CallSettings)
            // Additional: AnnotateAssessmentAsync(AnnotateAssessmentRequest, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = await RecaptchaEnterpriseServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            AnnotateAssessmentRequest request = new AnnotateAssessmentRequest
            {
                AssessmentName = new AssessmentName("[PROJECT]", "[ASSESSMENT]"),
                Annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified,
            };
            // Make the request
            AnnotateAssessmentResponse response = await recaptchaEnterpriseServiceV1Beta1Client.AnnotateAssessmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AnnotateAssessment</summary>
        public void AnnotateAssessment()
        {
            // Snippet: AnnotateAssessment(string, AnnotateAssessmentRequest.Types.Annotation, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = RecaptchaEnterpriseServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/assessments/[ASSESSMENT]";
            AnnotateAssessmentRequest.Types.Annotation annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified;
            // Make the request
            AnnotateAssessmentResponse response = recaptchaEnterpriseServiceV1Beta1Client.AnnotateAssessment(name, annotation);
            // End snippet
        }

        /// <summary>Snippet for AnnotateAssessmentAsync</summary>
        public async Task AnnotateAssessmentAsync()
        {
            // Snippet: AnnotateAssessmentAsync(string, AnnotateAssessmentRequest.Types.Annotation, CallSettings)
            // Additional: AnnotateAssessmentAsync(string, AnnotateAssessmentRequest.Types.Annotation, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = await RecaptchaEnterpriseServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/assessments/[ASSESSMENT]";
            AnnotateAssessmentRequest.Types.Annotation annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified;
            // Make the request
            AnnotateAssessmentResponse response = await recaptchaEnterpriseServiceV1Beta1Client.AnnotateAssessmentAsync(name, annotation);
            // End snippet
        }

        /// <summary>Snippet for AnnotateAssessment</summary>
        public void AnnotateAssessment_ResourceNames()
        {
            // Snippet: AnnotateAssessment(AssessmentName, AnnotateAssessmentRequest.Types.Annotation, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = RecaptchaEnterpriseServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            AssessmentName name = new AssessmentName("[PROJECT]", "[ASSESSMENT]");
            AnnotateAssessmentRequest.Types.Annotation annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified;
            // Make the request
            AnnotateAssessmentResponse response = recaptchaEnterpriseServiceV1Beta1Client.AnnotateAssessment(name, annotation);
            // End snippet
        }

        /// <summary>Snippet for AnnotateAssessmentAsync</summary>
        public async Task AnnotateAssessmentAsync_ResourceNames()
        {
            // Snippet: AnnotateAssessmentAsync(AssessmentName, AnnotateAssessmentRequest.Types.Annotation, CallSettings)
            // Additional: AnnotateAssessmentAsync(AssessmentName, AnnotateAssessmentRequest.Types.Annotation, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = await RecaptchaEnterpriseServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            AssessmentName name = new AssessmentName("[PROJECT]", "[ASSESSMENT]");
            AnnotateAssessmentRequest.Types.Annotation annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified;
            // Make the request
            AnnotateAssessmentResponse response = await recaptchaEnterpriseServiceV1Beta1Client.AnnotateAssessmentAsync(name, annotation);
            // End snippet
        }

        /// <summary>Snippet for CreateKey</summary>
        public void CreateKey_RequestObject()
        {
            // Snippet: CreateKey(CreateKeyRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = RecaptchaEnterpriseServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            CreateKeyRequest request = new CreateKeyRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Key = new Key(),
            };
            // Make the request
            Key response = recaptchaEnterpriseServiceV1Beta1Client.CreateKey(request);
            // End snippet
        }

        /// <summary>Snippet for CreateKeyAsync</summary>
        public async Task CreateKeyAsync_RequestObject()
        {
            // Snippet: CreateKeyAsync(CreateKeyRequest, CallSettings)
            // Additional: CreateKeyAsync(CreateKeyRequest, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = await RecaptchaEnterpriseServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            CreateKeyRequest request = new CreateKeyRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Key = new Key(),
            };
            // Make the request
            Key response = await recaptchaEnterpriseServiceV1Beta1Client.CreateKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListKeys</summary>
        public void ListKeys_RequestObject()
        {
            // Snippet: ListKeys(ListKeysRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = RecaptchaEnterpriseServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            ListKeysRequest request = new ListKeysRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListKeysResponse, Key> response = recaptchaEnterpriseServiceV1Beta1Client.ListKeys(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Key item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Key item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Key> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Key item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeys</summary>
        public async Task ListKeysAsync_RequestObject()
        {
            // Snippet: ListKeysAsync(ListKeysRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = await RecaptchaEnterpriseServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            ListKeysRequest request = new ListKeysRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListKeysResponse, Key> response = recaptchaEnterpriseServiceV1Beta1Client.ListKeysAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Key item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Key item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Key> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Key item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetKey</summary>
        public void GetKey_RequestObject()
        {
            // Snippet: GetKey(GetKeyRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = RecaptchaEnterpriseServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            GetKeyRequest request = new GetKeyRequest
            {
                KeyName = new KeyName("[PROJECT]", "[KEY]"),
            };
            // Make the request
            Key response = recaptchaEnterpriseServiceV1Beta1Client.GetKey(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeyAsync</summary>
        public async Task GetKeyAsync_RequestObject()
        {
            // Snippet: GetKeyAsync(GetKeyRequest, CallSettings)
            // Additional: GetKeyAsync(GetKeyRequest, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = await RecaptchaEnterpriseServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            GetKeyRequest request = new GetKeyRequest
            {
                KeyName = new KeyName("[PROJECT]", "[KEY]"),
            };
            // Make the request
            Key response = await recaptchaEnterpriseServiceV1Beta1Client.GetKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateKey</summary>
        public void UpdateKey_RequestObject()
        {
            // Snippet: UpdateKey(UpdateKeyRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = RecaptchaEnterpriseServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            UpdateKeyRequest request = new UpdateKeyRequest
            {
                Key = new Key(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Key response = recaptchaEnterpriseServiceV1Beta1Client.UpdateKey(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateKeyAsync</summary>
        public async Task UpdateKeyAsync_RequestObject()
        {
            // Snippet: UpdateKeyAsync(UpdateKeyRequest, CallSettings)
            // Additional: UpdateKeyAsync(UpdateKeyRequest, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = await RecaptchaEnterpriseServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            UpdateKeyRequest request = new UpdateKeyRequest
            {
                Key = new Key(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Key response = await recaptchaEnterpriseServiceV1Beta1Client.UpdateKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteKey</summary>
        public void DeleteKey_RequestObject()
        {
            // Snippet: DeleteKey(DeleteKeyRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = RecaptchaEnterpriseServiceV1Beta1Client.Create();
            // Initialize request argument(s)
            DeleteKeyRequest request = new DeleteKeyRequest
            {
                KeyName = new KeyName("[PROJECT]", "[KEY]"),
            };
            // Make the request
            recaptchaEnterpriseServiceV1Beta1Client.DeleteKey(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteKeyAsync</summary>
        public async Task DeleteKeyAsync_RequestObject()
        {
            // Snippet: DeleteKeyAsync(DeleteKeyRequest, CallSettings)
            // Additional: DeleteKeyAsync(DeleteKeyRequest, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceV1Beta1Client recaptchaEnterpriseServiceV1Beta1Client = await RecaptchaEnterpriseServiceV1Beta1Client.CreateAsync();
            // Initialize request argument(s)
            DeleteKeyRequest request = new DeleteKeyRequest
            {
                KeyName = new KeyName("[PROJECT]", "[KEY]"),
            };
            // Make the request
            await recaptchaEnterpriseServiceV1Beta1Client.DeleteKeyAsync(request);
            // End snippet
        }
    }
}
