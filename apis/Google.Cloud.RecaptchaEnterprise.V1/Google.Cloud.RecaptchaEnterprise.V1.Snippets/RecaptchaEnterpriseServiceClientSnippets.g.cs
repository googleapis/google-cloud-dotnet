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

namespace Google.Cloud.RecaptchaEnterprise.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedRecaptchaEnterpriseServiceClientSnippets
    {
        /// <summary>Snippet for CreateAssessment</summary>
        public void CreateAssessmentRequestObject()
        {
            // Snippet: CreateAssessment(CreateAssessmentRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            CreateAssessmentRequest request = new CreateAssessmentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Assessment = new Assessment(),
            };
            // Make the request
            Assessment response = recaptchaEnterpriseServiceClient.CreateAssessment(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAssessmentAsync</summary>
        public async Task CreateAssessmentRequestObjectAsync()
        {
            // Snippet: CreateAssessmentAsync(CreateAssessmentRequest, CallSettings)
            // Additional: CreateAssessmentAsync(CreateAssessmentRequest, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAssessmentRequest request = new CreateAssessmentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Assessment = new Assessment(),
            };
            // Make the request
            Assessment response = await recaptchaEnterpriseServiceClient.CreateAssessmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAssessment</summary>
        public void CreateAssessment()
        {
            // Snippet: CreateAssessment(string, Assessment, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Assessment assessment = new Assessment();
            // Make the request
            Assessment response = recaptchaEnterpriseServiceClient.CreateAssessment(parent, assessment);
            // End snippet
        }

        /// <summary>Snippet for CreateAssessmentAsync</summary>
        public async Task CreateAssessmentAsync()
        {
            // Snippet: CreateAssessmentAsync(string, Assessment, CallSettings)
            // Additional: CreateAssessmentAsync(string, Assessment, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Assessment assessment = new Assessment();
            // Make the request
            Assessment response = await recaptchaEnterpriseServiceClient.CreateAssessmentAsync(parent, assessment);
            // End snippet
        }

        /// <summary>Snippet for CreateAssessment</summary>
        public void CreateAssessmentResourceNames()
        {
            // Snippet: CreateAssessment(ProjectName, Assessment, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Assessment assessment = new Assessment();
            // Make the request
            Assessment response = recaptchaEnterpriseServiceClient.CreateAssessment(parent, assessment);
            // End snippet
        }

        /// <summary>Snippet for CreateAssessmentAsync</summary>
        public async Task CreateAssessmentResourceNamesAsync()
        {
            // Snippet: CreateAssessmentAsync(ProjectName, Assessment, CallSettings)
            // Additional: CreateAssessmentAsync(ProjectName, Assessment, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Assessment assessment = new Assessment();
            // Make the request
            Assessment response = await recaptchaEnterpriseServiceClient.CreateAssessmentAsync(parent, assessment);
            // End snippet
        }

        /// <summary>Snippet for AnnotateAssessment</summary>
        public void AnnotateAssessmentRequestObject()
        {
            // Snippet: AnnotateAssessment(AnnotateAssessmentRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            AnnotateAssessmentRequest request = new AnnotateAssessmentRequest
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified,
                Reasons =
                {
                    AnnotateAssessmentRequest.Types.Reason.Unspecified,
                },
            };
            // Make the request
            AnnotateAssessmentResponse response = recaptchaEnterpriseServiceClient.AnnotateAssessment(request);
            // End snippet
        }

        /// <summary>Snippet for AnnotateAssessmentAsync</summary>
        public async Task AnnotateAssessmentRequestObjectAsync()
        {
            // Snippet: AnnotateAssessmentAsync(AnnotateAssessmentRequest, CallSettings)
            // Additional: AnnotateAssessmentAsync(AnnotateAssessmentRequest, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnnotateAssessmentRequest request = new AnnotateAssessmentRequest
            {
                AssessmentName = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]"),
                Annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified,
                Reasons =
                {
                    AnnotateAssessmentRequest.Types.Reason.Unspecified,
                },
            };
            // Make the request
            AnnotateAssessmentResponse response = await recaptchaEnterpriseServiceClient.AnnotateAssessmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AnnotateAssessment</summary>
        public void AnnotateAssessment()
        {
            // Snippet: AnnotateAssessment(string, AnnotateAssessmentRequest.Types.Annotation, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/assessments/[ASSESSMENT]";
            AnnotateAssessmentRequest.Types.Annotation annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified;
            // Make the request
            AnnotateAssessmentResponse response = recaptchaEnterpriseServiceClient.AnnotateAssessment(name, annotation);
            // End snippet
        }

        /// <summary>Snippet for AnnotateAssessmentAsync</summary>
        public async Task AnnotateAssessmentAsync()
        {
            // Snippet: AnnotateAssessmentAsync(string, AnnotateAssessmentRequest.Types.Annotation, CallSettings)
            // Additional: AnnotateAssessmentAsync(string, AnnotateAssessmentRequest.Types.Annotation, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/assessments/[ASSESSMENT]";
            AnnotateAssessmentRequest.Types.Annotation annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified;
            // Make the request
            AnnotateAssessmentResponse response = await recaptchaEnterpriseServiceClient.AnnotateAssessmentAsync(name, annotation);
            // End snippet
        }

        /// <summary>Snippet for AnnotateAssessment</summary>
        public void AnnotateAssessmentResourceNames()
        {
            // Snippet: AnnotateAssessment(AssessmentName, AnnotateAssessmentRequest.Types.Annotation, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            AssessmentName name = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]");
            AnnotateAssessmentRequest.Types.Annotation annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified;
            // Make the request
            AnnotateAssessmentResponse response = recaptchaEnterpriseServiceClient.AnnotateAssessment(name, annotation);
            // End snippet
        }

        /// <summary>Snippet for AnnotateAssessmentAsync</summary>
        public async Task AnnotateAssessmentResourceNamesAsync()
        {
            // Snippet: AnnotateAssessmentAsync(AssessmentName, AnnotateAssessmentRequest.Types.Annotation, CallSettings)
            // Additional: AnnotateAssessmentAsync(AssessmentName, AnnotateAssessmentRequest.Types.Annotation, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            AssessmentName name = AssessmentName.FromProjectAssessment("[PROJECT]", "[ASSESSMENT]");
            AnnotateAssessmentRequest.Types.Annotation annotation = AnnotateAssessmentRequest.Types.Annotation.Unspecified;
            // Make the request
            AnnotateAssessmentResponse response = await recaptchaEnterpriseServiceClient.AnnotateAssessmentAsync(name, annotation);
            // End snippet
        }

        /// <summary>Snippet for CreateKey</summary>
        public void CreateKeyRequestObject()
        {
            // Snippet: CreateKey(CreateKeyRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            CreateKeyRequest request = new CreateKeyRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Key = new Key(),
            };
            // Make the request
            Key response = recaptchaEnterpriseServiceClient.CreateKey(request);
            // End snippet
        }

        /// <summary>Snippet for CreateKeyAsync</summary>
        public async Task CreateKeyRequestObjectAsync()
        {
            // Snippet: CreateKeyAsync(CreateKeyRequest, CallSettings)
            // Additional: CreateKeyAsync(CreateKeyRequest, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateKeyRequest request = new CreateKeyRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Key = new Key(),
            };
            // Make the request
            Key response = await recaptchaEnterpriseServiceClient.CreateKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListKeys</summary>
        public void ListKeysRequestObject()
        {
            // Snippet: ListKeys(ListKeysRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            ListKeysRequest request = new ListKeysRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListKeysResponse, Key> response = recaptchaEnterpriseServiceClient.ListKeys(request);

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

        /// <summary>Snippet for ListKeysAsync</summary>
        public async Task ListKeysRequestObjectAsync()
        {
            // Snippet: ListKeysAsync(ListKeysRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListKeysRequest request = new ListKeysRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListKeysResponse, Key> response = recaptchaEnterpriseServiceClient.ListKeysAsync(request);

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
        public void GetKeyRequestObject()
        {
            // Snippet: GetKey(GetKeyRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            GetKeyRequest request = new GetKeyRequest
            {
                KeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            // Make the request
            Key response = recaptchaEnterpriseServiceClient.GetKey(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeyAsync</summary>
        public async Task GetKeyRequestObjectAsync()
        {
            // Snippet: GetKeyAsync(GetKeyRequest, CallSettings)
            // Additional: GetKeyAsync(GetKeyRequest, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetKeyRequest request = new GetKeyRequest
            {
                KeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            // Make the request
            Key response = await recaptchaEnterpriseServiceClient.GetKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateKey</summary>
        public void UpdateKeyRequestObject()
        {
            // Snippet: UpdateKey(UpdateKeyRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            UpdateKeyRequest request = new UpdateKeyRequest
            {
                Key = new Key(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Key response = recaptchaEnterpriseServiceClient.UpdateKey(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateKeyAsync</summary>
        public async Task UpdateKeyRequestObjectAsync()
        {
            // Snippet: UpdateKeyAsync(UpdateKeyRequest, CallSettings)
            // Additional: UpdateKeyAsync(UpdateKeyRequest, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateKeyRequest request = new UpdateKeyRequest
            {
                Key = new Key(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Key response = await recaptchaEnterpriseServiceClient.UpdateKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteKey</summary>
        public void DeleteKeyRequestObject()
        {
            // Snippet: DeleteKey(DeleteKeyRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            DeleteKeyRequest request = new DeleteKeyRequest
            {
                KeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            // Make the request
            recaptchaEnterpriseServiceClient.DeleteKey(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteKeyAsync</summary>
        public async Task DeleteKeyRequestObjectAsync()
        {
            // Snippet: DeleteKeyAsync(DeleteKeyRequest, CallSettings)
            // Additional: DeleteKeyAsync(DeleteKeyRequest, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteKeyRequest request = new DeleteKeyRequest
            {
                KeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            // Make the request
            await recaptchaEnterpriseServiceClient.DeleteKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MigrateKey</summary>
        public void MigrateKeyRequestObject()
        {
            // Snippet: MigrateKey(MigrateKeyRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            MigrateKeyRequest request = new MigrateKeyRequest
            {
                KeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            // Make the request
            Key response = recaptchaEnterpriseServiceClient.MigrateKey(request);
            // End snippet
        }

        /// <summary>Snippet for MigrateKeyAsync</summary>
        public async Task MigrateKeyRequestObjectAsync()
        {
            // Snippet: MigrateKeyAsync(MigrateKeyRequest, CallSettings)
            // Additional: MigrateKeyAsync(MigrateKeyRequest, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            MigrateKeyRequest request = new MigrateKeyRequest
            {
                KeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            // Make the request
            Key response = await recaptchaEnterpriseServiceClient.MigrateKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMetrics</summary>
        public void GetMetricsRequestObject()
        {
            // Snippet: GetMetrics(GetMetricsRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            GetMetricsRequest request = new GetMetricsRequest
            {
                MetricsName = MetricsName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            // Make the request
            Metrics response = recaptchaEnterpriseServiceClient.GetMetrics(request);
            // End snippet
        }

        /// <summary>Snippet for GetMetricsAsync</summary>
        public async Task GetMetricsRequestObjectAsync()
        {
            // Snippet: GetMetricsAsync(GetMetricsRequest, CallSettings)
            // Additional: GetMetricsAsync(GetMetricsRequest, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetMetricsRequest request = new GetMetricsRequest
            {
                MetricsName = MetricsName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            // Make the request
            Metrics response = await recaptchaEnterpriseServiceClient.GetMetricsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMetrics</summary>
        public void GetMetrics()
        {
            // Snippet: GetMetrics(string, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/keys/[KEY]/metrics";
            // Make the request
            Metrics response = recaptchaEnterpriseServiceClient.GetMetrics(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetricsAsync</summary>
        public async Task GetMetricsAsync()
        {
            // Snippet: GetMetricsAsync(string, CallSettings)
            // Additional: GetMetricsAsync(string, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/keys/[KEY]/metrics";
            // Make the request
            Metrics response = await recaptchaEnterpriseServiceClient.GetMetricsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetrics</summary>
        public void GetMetricsResourceNames()
        {
            // Snippet: GetMetrics(MetricsName, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            MetricsName name = MetricsName.FromProjectKey("[PROJECT]", "[KEY]");
            // Make the request
            Metrics response = recaptchaEnterpriseServiceClient.GetMetrics(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetricsAsync</summary>
        public async Task GetMetricsResourceNamesAsync()
        {
            // Snippet: GetMetricsAsync(MetricsName, CallSettings)
            // Additional: GetMetricsAsync(MetricsName, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            MetricsName name = MetricsName.FromProjectKey("[PROJECT]", "[KEY]");
            // Make the request
            Metrics response = await recaptchaEnterpriseServiceClient.GetMetricsAsync(name);
            // End snippet
        }
    }
}
