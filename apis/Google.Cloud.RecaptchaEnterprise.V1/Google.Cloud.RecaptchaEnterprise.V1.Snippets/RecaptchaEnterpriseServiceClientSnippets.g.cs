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

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.RecaptchaEnterprise.V1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRecaptchaEnterpriseServiceClientSnippets
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
                HashedAccountId = ByteString.Empty,
                TransactionEvent = new TransactionEvent(),
                AccountId = "",
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
                HashedAccountId = ByteString.Empty,
                TransactionEvent = new TransactionEvent(),
                AccountId = "",
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

        /// <summary>Snippet for CreateKey</summary>
        public void CreateKey()
        {
            // Snippet: CreateKey(string, Key, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Key key = new Key();
            // Make the request
            Key response = recaptchaEnterpriseServiceClient.CreateKey(parent, key);
            // End snippet
        }

        /// <summary>Snippet for CreateKeyAsync</summary>
        public async Task CreateKeyAsync()
        {
            // Snippet: CreateKeyAsync(string, Key, CallSettings)
            // Additional: CreateKeyAsync(string, Key, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Key key = new Key();
            // Make the request
            Key response = await recaptchaEnterpriseServiceClient.CreateKeyAsync(parent, key);
            // End snippet
        }

        /// <summary>Snippet for CreateKey</summary>
        public void CreateKeyResourceNames()
        {
            // Snippet: CreateKey(ProjectName, Key, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Key key = new Key();
            // Make the request
            Key response = recaptchaEnterpriseServiceClient.CreateKey(parent, key);
            // End snippet
        }

        /// <summary>Snippet for CreateKeyAsync</summary>
        public async Task CreateKeyResourceNamesAsync()
        {
            // Snippet: CreateKeyAsync(ProjectName, Key, CallSettings)
            // Additional: CreateKeyAsync(ProjectName, Key, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Key key = new Key();
            // Make the request
            Key response = await recaptchaEnterpriseServiceClient.CreateKeyAsync(parent, key);
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

        /// <summary>Snippet for ListKeys</summary>
        public void ListKeys()
        {
            // Snippet: ListKeys(string, string, int?, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListKeysResponse, Key> response = recaptchaEnterpriseServiceClient.ListKeys(parent);

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
        public async Task ListKeysAsync()
        {
            // Snippet: ListKeysAsync(string, string, int?, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListKeysResponse, Key> response = recaptchaEnterpriseServiceClient.ListKeysAsync(parent);

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

        /// <summary>Snippet for ListKeys</summary>
        public void ListKeysResourceNames()
        {
            // Snippet: ListKeys(ProjectName, string, int?, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListKeysResponse, Key> response = recaptchaEnterpriseServiceClient.ListKeys(parent);

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
        public async Task ListKeysResourceNamesAsync()
        {
            // Snippet: ListKeysAsync(ProjectName, string, int?, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListKeysResponse, Key> response = recaptchaEnterpriseServiceClient.ListKeysAsync(parent);

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

        /// <summary>Snippet for RetrieveLegacySecretKey</summary>
        public void RetrieveLegacySecretKeyRequestObject()
        {
            // Snippet: RetrieveLegacySecretKey(RetrieveLegacySecretKeyRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            RetrieveLegacySecretKeyRequest request = new RetrieveLegacySecretKeyRequest
            {
                KeyAsKeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            // Make the request
            RetrieveLegacySecretKeyResponse response = recaptchaEnterpriseServiceClient.RetrieveLegacySecretKey(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveLegacySecretKeyAsync</summary>
        public async Task RetrieveLegacySecretKeyRequestObjectAsync()
        {
            // Snippet: RetrieveLegacySecretKeyAsync(RetrieveLegacySecretKeyRequest, CallSettings)
            // Additional: RetrieveLegacySecretKeyAsync(RetrieveLegacySecretKeyRequest, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            RetrieveLegacySecretKeyRequest request = new RetrieveLegacySecretKeyRequest
            {
                KeyAsKeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
            };
            // Make the request
            RetrieveLegacySecretKeyResponse response = await recaptchaEnterpriseServiceClient.RetrieveLegacySecretKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveLegacySecretKey</summary>
        public void RetrieveLegacySecretKey()
        {
            // Snippet: RetrieveLegacySecretKey(string, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            string key = "projects/[PROJECT]/keys/[KEY]";
            // Make the request
            RetrieveLegacySecretKeyResponse response = recaptchaEnterpriseServiceClient.RetrieveLegacySecretKey(key);
            // End snippet
        }

        /// <summary>Snippet for RetrieveLegacySecretKeyAsync</summary>
        public async Task RetrieveLegacySecretKeyAsync()
        {
            // Snippet: RetrieveLegacySecretKeyAsync(string, CallSettings)
            // Additional: RetrieveLegacySecretKeyAsync(string, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string key = "projects/[PROJECT]/keys/[KEY]";
            // Make the request
            RetrieveLegacySecretKeyResponse response = await recaptchaEnterpriseServiceClient.RetrieveLegacySecretKeyAsync(key);
            // End snippet
        }

        /// <summary>Snippet for RetrieveLegacySecretKey</summary>
        public void RetrieveLegacySecretKeyResourceNames()
        {
            // Snippet: RetrieveLegacySecretKey(KeyName, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            KeyName key = KeyName.FromProjectKey("[PROJECT]", "[KEY]");
            // Make the request
            RetrieveLegacySecretKeyResponse response = recaptchaEnterpriseServiceClient.RetrieveLegacySecretKey(key);
            // End snippet
        }

        /// <summary>Snippet for RetrieveLegacySecretKeyAsync</summary>
        public async Task RetrieveLegacySecretKeyResourceNamesAsync()
        {
            // Snippet: RetrieveLegacySecretKeyAsync(KeyName, CallSettings)
            // Additional: RetrieveLegacySecretKeyAsync(KeyName, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyName key = KeyName.FromProjectKey("[PROJECT]", "[KEY]");
            // Make the request
            RetrieveLegacySecretKeyResponse response = await recaptchaEnterpriseServiceClient.RetrieveLegacySecretKeyAsync(key);
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

        /// <summary>Snippet for GetKey</summary>
        public void GetKey()
        {
            // Snippet: GetKey(string, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/keys/[KEY]";
            // Make the request
            Key response = recaptchaEnterpriseServiceClient.GetKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetKeyAsync</summary>
        public async Task GetKeyAsync()
        {
            // Snippet: GetKeyAsync(string, CallSettings)
            // Additional: GetKeyAsync(string, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/keys/[KEY]";
            // Make the request
            Key response = await recaptchaEnterpriseServiceClient.GetKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetKey</summary>
        public void GetKeyResourceNames()
        {
            // Snippet: GetKey(KeyName, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            KeyName name = KeyName.FromProjectKey("[PROJECT]", "[KEY]");
            // Make the request
            Key response = recaptchaEnterpriseServiceClient.GetKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetKeyAsync</summary>
        public async Task GetKeyResourceNamesAsync()
        {
            // Snippet: GetKeyAsync(KeyName, CallSettings)
            // Additional: GetKeyAsync(KeyName, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyName name = KeyName.FromProjectKey("[PROJECT]", "[KEY]");
            // Make the request
            Key response = await recaptchaEnterpriseServiceClient.GetKeyAsync(name);
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

        /// <summary>Snippet for UpdateKey</summary>
        public void UpdateKey()
        {
            // Snippet: UpdateKey(Key, FieldMask, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            Key key = new Key();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Key response = recaptchaEnterpriseServiceClient.UpdateKey(key, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateKeyAsync</summary>
        public async Task UpdateKeyAsync()
        {
            // Snippet: UpdateKeyAsync(Key, FieldMask, CallSettings)
            // Additional: UpdateKeyAsync(Key, FieldMask, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            Key key = new Key();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Key response = await recaptchaEnterpriseServiceClient.UpdateKeyAsync(key, updateMask);
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

        /// <summary>Snippet for DeleteKey</summary>
        public void DeleteKey()
        {
            // Snippet: DeleteKey(string, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/keys/[KEY]";
            // Make the request
            recaptchaEnterpriseServiceClient.DeleteKey(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteKeyAsync</summary>
        public async Task DeleteKeyAsync()
        {
            // Snippet: DeleteKeyAsync(string, CallSettings)
            // Additional: DeleteKeyAsync(string, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/keys/[KEY]";
            // Make the request
            await recaptchaEnterpriseServiceClient.DeleteKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteKey</summary>
        public void DeleteKeyResourceNames()
        {
            // Snippet: DeleteKey(KeyName, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            KeyName name = KeyName.FromProjectKey("[PROJECT]", "[KEY]");
            // Make the request
            recaptchaEnterpriseServiceClient.DeleteKey(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteKeyAsync</summary>
        public async Task DeleteKeyResourceNamesAsync()
        {
            // Snippet: DeleteKeyAsync(KeyName, CallSettings)
            // Additional: DeleteKeyAsync(KeyName, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyName name = KeyName.FromProjectKey("[PROJECT]", "[KEY]");
            // Make the request
            await recaptchaEnterpriseServiceClient.DeleteKeyAsync(name);
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
                SkipBillingCheck = false,
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
                SkipBillingCheck = false,
            };
            // Make the request
            Key response = await recaptchaEnterpriseServiceClient.MigrateKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AddIpOverride</summary>
        public void AddIpOverrideRequestObject()
        {
            // Snippet: AddIpOverride(AddIpOverrideRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            AddIpOverrideRequest request = new AddIpOverrideRequest
            {
                KeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
                IpOverrideData = new IpOverrideData(),
            };
            // Make the request
            AddIpOverrideResponse response = recaptchaEnterpriseServiceClient.AddIpOverride(request);
            // End snippet
        }

        /// <summary>Snippet for AddIpOverrideAsync</summary>
        public async Task AddIpOverrideRequestObjectAsync()
        {
            // Snippet: AddIpOverrideAsync(AddIpOverrideRequest, CallSettings)
            // Additional: AddIpOverrideAsync(AddIpOverrideRequest, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            AddIpOverrideRequest request = new AddIpOverrideRequest
            {
                KeyName = KeyName.FromProjectKey("[PROJECT]", "[KEY]"),
                IpOverrideData = new IpOverrideData(),
            };
            // Make the request
            AddIpOverrideResponse response = await recaptchaEnterpriseServiceClient.AddIpOverrideAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AddIpOverride</summary>
        public void AddIpOverride()
        {
            // Snippet: AddIpOverride(string, IpOverrideData, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/keys/[KEY]";
            IpOverrideData ipOverrideData = new IpOverrideData();
            // Make the request
            AddIpOverrideResponse response = recaptchaEnterpriseServiceClient.AddIpOverride(name, ipOverrideData);
            // End snippet
        }

        /// <summary>Snippet for AddIpOverrideAsync</summary>
        public async Task AddIpOverrideAsync()
        {
            // Snippet: AddIpOverrideAsync(string, IpOverrideData, CallSettings)
            // Additional: AddIpOverrideAsync(string, IpOverrideData, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/keys/[KEY]";
            IpOverrideData ipOverrideData = new IpOverrideData();
            // Make the request
            AddIpOverrideResponse response = await recaptchaEnterpriseServiceClient.AddIpOverrideAsync(name, ipOverrideData);
            // End snippet
        }

        /// <summary>Snippet for AddIpOverride</summary>
        public void AddIpOverrideResourceNames()
        {
            // Snippet: AddIpOverride(KeyName, IpOverrideData, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            KeyName name = KeyName.FromProjectKey("[PROJECT]", "[KEY]");
            IpOverrideData ipOverrideData = new IpOverrideData();
            // Make the request
            AddIpOverrideResponse response = recaptchaEnterpriseServiceClient.AddIpOverride(name, ipOverrideData);
            // End snippet
        }

        /// <summary>Snippet for AddIpOverrideAsync</summary>
        public async Task AddIpOverrideResourceNamesAsync()
        {
            // Snippet: AddIpOverrideAsync(KeyName, IpOverrideData, CallSettings)
            // Additional: AddIpOverrideAsync(KeyName, IpOverrideData, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyName name = KeyName.FromProjectKey("[PROJECT]", "[KEY]");
            IpOverrideData ipOverrideData = new IpOverrideData();
            // Make the request
            AddIpOverrideResponse response = await recaptchaEnterpriseServiceClient.AddIpOverrideAsync(name, ipOverrideData);
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

        /// <summary>Snippet for CreateFirewallPolicy</summary>
        public void CreateFirewallPolicyRequestObject()
        {
            // Snippet: CreateFirewallPolicy(CreateFirewallPolicyRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            CreateFirewallPolicyRequest request = new CreateFirewallPolicyRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                FirewallPolicy = new FirewallPolicy(),
            };
            // Make the request
            FirewallPolicy response = recaptchaEnterpriseServiceClient.CreateFirewallPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFirewallPolicyAsync</summary>
        public async Task CreateFirewallPolicyRequestObjectAsync()
        {
            // Snippet: CreateFirewallPolicyAsync(CreateFirewallPolicyRequest, CallSettings)
            // Additional: CreateFirewallPolicyAsync(CreateFirewallPolicyRequest, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateFirewallPolicyRequest request = new CreateFirewallPolicyRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                FirewallPolicy = new FirewallPolicy(),
            };
            // Make the request
            FirewallPolicy response = await recaptchaEnterpriseServiceClient.CreateFirewallPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFirewallPolicy</summary>
        public void CreateFirewallPolicy()
        {
            // Snippet: CreateFirewallPolicy(string, FirewallPolicy, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            FirewallPolicy firewallPolicy = new FirewallPolicy();
            // Make the request
            FirewallPolicy response = recaptchaEnterpriseServiceClient.CreateFirewallPolicy(parent, firewallPolicy);
            // End snippet
        }

        /// <summary>Snippet for CreateFirewallPolicyAsync</summary>
        public async Task CreateFirewallPolicyAsync()
        {
            // Snippet: CreateFirewallPolicyAsync(string, FirewallPolicy, CallSettings)
            // Additional: CreateFirewallPolicyAsync(string, FirewallPolicy, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            FirewallPolicy firewallPolicy = new FirewallPolicy();
            // Make the request
            FirewallPolicy response = await recaptchaEnterpriseServiceClient.CreateFirewallPolicyAsync(parent, firewallPolicy);
            // End snippet
        }

        /// <summary>Snippet for CreateFirewallPolicy</summary>
        public void CreateFirewallPolicyResourceNames()
        {
            // Snippet: CreateFirewallPolicy(ProjectName, FirewallPolicy, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            FirewallPolicy firewallPolicy = new FirewallPolicy();
            // Make the request
            FirewallPolicy response = recaptchaEnterpriseServiceClient.CreateFirewallPolicy(parent, firewallPolicy);
            // End snippet
        }

        /// <summary>Snippet for CreateFirewallPolicyAsync</summary>
        public async Task CreateFirewallPolicyResourceNamesAsync()
        {
            // Snippet: CreateFirewallPolicyAsync(ProjectName, FirewallPolicy, CallSettings)
            // Additional: CreateFirewallPolicyAsync(ProjectName, FirewallPolicy, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            FirewallPolicy firewallPolicy = new FirewallPolicy();
            // Make the request
            FirewallPolicy response = await recaptchaEnterpriseServiceClient.CreateFirewallPolicyAsync(parent, firewallPolicy);
            // End snippet
        }

        /// <summary>Snippet for ListFirewallPolicies</summary>
        public void ListFirewallPoliciesRequestObject()
        {
            // Snippet: ListFirewallPolicies(ListFirewallPoliciesRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            ListFirewallPoliciesRequest request = new ListFirewallPoliciesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListFirewallPoliciesResponse, FirewallPolicy> response = recaptchaEnterpriseServiceClient.ListFirewallPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FirewallPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFirewallPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFirewallPoliciesAsync</summary>
        public async Task ListFirewallPoliciesRequestObjectAsync()
        {
            // Snippet: ListFirewallPoliciesAsync(ListFirewallPoliciesRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListFirewallPoliciesRequest request = new ListFirewallPoliciesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListFirewallPoliciesResponse, FirewallPolicy> response = recaptchaEnterpriseServiceClient.ListFirewallPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FirewallPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFirewallPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFirewallPolicies</summary>
        public void ListFirewallPolicies()
        {
            // Snippet: ListFirewallPolicies(string, string, int?, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListFirewallPoliciesResponse, FirewallPolicy> response = recaptchaEnterpriseServiceClient.ListFirewallPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FirewallPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFirewallPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFirewallPoliciesAsync</summary>
        public async Task ListFirewallPoliciesAsync()
        {
            // Snippet: ListFirewallPoliciesAsync(string, string, int?, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListFirewallPoliciesResponse, FirewallPolicy> response = recaptchaEnterpriseServiceClient.ListFirewallPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FirewallPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFirewallPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFirewallPolicies</summary>
        public void ListFirewallPoliciesResourceNames()
        {
            // Snippet: ListFirewallPolicies(ProjectName, string, int?, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListFirewallPoliciesResponse, FirewallPolicy> response = recaptchaEnterpriseServiceClient.ListFirewallPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FirewallPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFirewallPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFirewallPoliciesAsync</summary>
        public async Task ListFirewallPoliciesResourceNamesAsync()
        {
            // Snippet: ListFirewallPoliciesAsync(ProjectName, string, int?, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListFirewallPoliciesResponse, FirewallPolicy> response = recaptchaEnterpriseServiceClient.ListFirewallPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FirewallPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFirewallPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetFirewallPolicy</summary>
        public void GetFirewallPolicyRequestObject()
        {
            // Snippet: GetFirewallPolicy(GetFirewallPolicyRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            GetFirewallPolicyRequest request = new GetFirewallPolicyRequest
            {
                FirewallPolicyName = FirewallPolicyName.FromProjectFirewallpolicy("[PROJECT]", "[FIREWALLPOLICY]"),
            };
            // Make the request
            FirewallPolicy response = recaptchaEnterpriseServiceClient.GetFirewallPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetFirewallPolicyAsync</summary>
        public async Task GetFirewallPolicyRequestObjectAsync()
        {
            // Snippet: GetFirewallPolicyAsync(GetFirewallPolicyRequest, CallSettings)
            // Additional: GetFirewallPolicyAsync(GetFirewallPolicyRequest, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFirewallPolicyRequest request = new GetFirewallPolicyRequest
            {
                FirewallPolicyName = FirewallPolicyName.FromProjectFirewallpolicy("[PROJECT]", "[FIREWALLPOLICY]"),
            };
            // Make the request
            FirewallPolicy response = await recaptchaEnterpriseServiceClient.GetFirewallPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFirewallPolicy</summary>
        public void GetFirewallPolicy()
        {
            // Snippet: GetFirewallPolicy(string, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/firewallpolicies/[FIREWALLPOLICY]";
            // Make the request
            FirewallPolicy response = recaptchaEnterpriseServiceClient.GetFirewallPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetFirewallPolicyAsync</summary>
        public async Task GetFirewallPolicyAsync()
        {
            // Snippet: GetFirewallPolicyAsync(string, CallSettings)
            // Additional: GetFirewallPolicyAsync(string, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/firewallpolicies/[FIREWALLPOLICY]";
            // Make the request
            FirewallPolicy response = await recaptchaEnterpriseServiceClient.GetFirewallPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFirewallPolicy</summary>
        public void GetFirewallPolicyResourceNames()
        {
            // Snippet: GetFirewallPolicy(FirewallPolicyName, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            FirewallPolicyName name = FirewallPolicyName.FromProjectFirewallpolicy("[PROJECT]", "[FIREWALLPOLICY]");
            // Make the request
            FirewallPolicy response = recaptchaEnterpriseServiceClient.GetFirewallPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetFirewallPolicyAsync</summary>
        public async Task GetFirewallPolicyResourceNamesAsync()
        {
            // Snippet: GetFirewallPolicyAsync(FirewallPolicyName, CallSettings)
            // Additional: GetFirewallPolicyAsync(FirewallPolicyName, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            FirewallPolicyName name = FirewallPolicyName.FromProjectFirewallpolicy("[PROJECT]", "[FIREWALLPOLICY]");
            // Make the request
            FirewallPolicy response = await recaptchaEnterpriseServiceClient.GetFirewallPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateFirewallPolicy</summary>
        public void UpdateFirewallPolicyRequestObject()
        {
            // Snippet: UpdateFirewallPolicy(UpdateFirewallPolicyRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            UpdateFirewallPolicyRequest request = new UpdateFirewallPolicyRequest
            {
                FirewallPolicy = new FirewallPolicy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            FirewallPolicy response = recaptchaEnterpriseServiceClient.UpdateFirewallPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFirewallPolicyAsync</summary>
        public async Task UpdateFirewallPolicyRequestObjectAsync()
        {
            // Snippet: UpdateFirewallPolicyAsync(UpdateFirewallPolicyRequest, CallSettings)
            // Additional: UpdateFirewallPolicyAsync(UpdateFirewallPolicyRequest, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFirewallPolicyRequest request = new UpdateFirewallPolicyRequest
            {
                FirewallPolicy = new FirewallPolicy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            FirewallPolicy response = await recaptchaEnterpriseServiceClient.UpdateFirewallPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFirewallPolicy</summary>
        public void UpdateFirewallPolicy()
        {
            // Snippet: UpdateFirewallPolicy(FirewallPolicy, FieldMask, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            FirewallPolicy firewallPolicy = new FirewallPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            FirewallPolicy response = recaptchaEnterpriseServiceClient.UpdateFirewallPolicy(firewallPolicy, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateFirewallPolicyAsync</summary>
        public async Task UpdateFirewallPolicyAsync()
        {
            // Snippet: UpdateFirewallPolicyAsync(FirewallPolicy, FieldMask, CallSettings)
            // Additional: UpdateFirewallPolicyAsync(FirewallPolicy, FieldMask, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            FirewallPolicy firewallPolicy = new FirewallPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            FirewallPolicy response = await recaptchaEnterpriseServiceClient.UpdateFirewallPolicyAsync(firewallPolicy, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteFirewallPolicy</summary>
        public void DeleteFirewallPolicyRequestObject()
        {
            // Snippet: DeleteFirewallPolicy(DeleteFirewallPolicyRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            DeleteFirewallPolicyRequest request = new DeleteFirewallPolicyRequest
            {
                FirewallPolicyName = FirewallPolicyName.FromProjectFirewallpolicy("[PROJECT]", "[FIREWALLPOLICY]"),
            };
            // Make the request
            recaptchaEnterpriseServiceClient.DeleteFirewallPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteFirewallPolicyAsync</summary>
        public async Task DeleteFirewallPolicyRequestObjectAsync()
        {
            // Snippet: DeleteFirewallPolicyAsync(DeleteFirewallPolicyRequest, CallSettings)
            // Additional: DeleteFirewallPolicyAsync(DeleteFirewallPolicyRequest, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFirewallPolicyRequest request = new DeleteFirewallPolicyRequest
            {
                FirewallPolicyName = FirewallPolicyName.FromProjectFirewallpolicy("[PROJECT]", "[FIREWALLPOLICY]"),
            };
            // Make the request
            await recaptchaEnterpriseServiceClient.DeleteFirewallPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteFirewallPolicy</summary>
        public void DeleteFirewallPolicy()
        {
            // Snippet: DeleteFirewallPolicy(string, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/firewallpolicies/[FIREWALLPOLICY]";
            // Make the request
            recaptchaEnterpriseServiceClient.DeleteFirewallPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFirewallPolicyAsync</summary>
        public async Task DeleteFirewallPolicyAsync()
        {
            // Snippet: DeleteFirewallPolicyAsync(string, CallSettings)
            // Additional: DeleteFirewallPolicyAsync(string, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/firewallpolicies/[FIREWALLPOLICY]";
            // Make the request
            await recaptchaEnterpriseServiceClient.DeleteFirewallPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFirewallPolicy</summary>
        public void DeleteFirewallPolicyResourceNames()
        {
            // Snippet: DeleteFirewallPolicy(FirewallPolicyName, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            FirewallPolicyName name = FirewallPolicyName.FromProjectFirewallpolicy("[PROJECT]", "[FIREWALLPOLICY]");
            // Make the request
            recaptchaEnterpriseServiceClient.DeleteFirewallPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFirewallPolicyAsync</summary>
        public async Task DeleteFirewallPolicyResourceNamesAsync()
        {
            // Snippet: DeleteFirewallPolicyAsync(FirewallPolicyName, CallSettings)
            // Additional: DeleteFirewallPolicyAsync(FirewallPolicyName, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            FirewallPolicyName name = FirewallPolicyName.FromProjectFirewallpolicy("[PROJECT]", "[FIREWALLPOLICY]");
            // Make the request
            await recaptchaEnterpriseServiceClient.DeleteFirewallPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ReorderFirewallPolicies</summary>
        public void ReorderFirewallPoliciesRequestObject()
        {
            // Snippet: ReorderFirewallPolicies(ReorderFirewallPoliciesRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            ReorderFirewallPoliciesRequest request = new ReorderFirewallPoliciesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                FirewallPolicyNames =
                {
                    FirewallPolicyName.FromProjectFirewallpolicy("[PROJECT]", "[FIREWALLPOLICY]"),
                },
            };
            // Make the request
            ReorderFirewallPoliciesResponse response = recaptchaEnterpriseServiceClient.ReorderFirewallPolicies(request);
            // End snippet
        }

        /// <summary>Snippet for ReorderFirewallPoliciesAsync</summary>
        public async Task ReorderFirewallPoliciesRequestObjectAsync()
        {
            // Snippet: ReorderFirewallPoliciesAsync(ReorderFirewallPoliciesRequest, CallSettings)
            // Additional: ReorderFirewallPoliciesAsync(ReorderFirewallPoliciesRequest, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReorderFirewallPoliciesRequest request = new ReorderFirewallPoliciesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                FirewallPolicyNames =
                {
                    FirewallPolicyName.FromProjectFirewallpolicy("[PROJECT]", "[FIREWALLPOLICY]"),
                },
            };
            // Make the request
            ReorderFirewallPoliciesResponse response = await recaptchaEnterpriseServiceClient.ReorderFirewallPoliciesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReorderFirewallPolicies</summary>
        public void ReorderFirewallPolicies()
        {
            // Snippet: ReorderFirewallPolicies(string, IEnumerable<string>, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            IEnumerable<string> names = new string[]
            {
                "projects/[PROJECT]/firewallpolicies/[FIREWALLPOLICY]",
            };
            // Make the request
            ReorderFirewallPoliciesResponse response = recaptchaEnterpriseServiceClient.ReorderFirewallPolicies(parent, names);
            // End snippet
        }

        /// <summary>Snippet for ReorderFirewallPoliciesAsync</summary>
        public async Task ReorderFirewallPoliciesAsync()
        {
            // Snippet: ReorderFirewallPoliciesAsync(string, IEnumerable<string>, CallSettings)
            // Additional: ReorderFirewallPoliciesAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            IEnumerable<string> names = new string[]
            {
                "projects/[PROJECT]/firewallpolicies/[FIREWALLPOLICY]",
            };
            // Make the request
            ReorderFirewallPoliciesResponse response = await recaptchaEnterpriseServiceClient.ReorderFirewallPoliciesAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for ReorderFirewallPolicies</summary>
        public void ReorderFirewallPoliciesResourceNames()
        {
            // Snippet: ReorderFirewallPolicies(ProjectName, IEnumerable<FirewallPolicyName>, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            IEnumerable<FirewallPolicyName> names = new FirewallPolicyName[]
            {
                FirewallPolicyName.FromProjectFirewallpolicy("[PROJECT]", "[FIREWALLPOLICY]"),
            };
            // Make the request
            ReorderFirewallPoliciesResponse response = recaptchaEnterpriseServiceClient.ReorderFirewallPolicies(parent, names);
            // End snippet
        }

        /// <summary>Snippet for ReorderFirewallPoliciesAsync</summary>
        public async Task ReorderFirewallPoliciesResourceNamesAsync()
        {
            // Snippet: ReorderFirewallPoliciesAsync(ProjectName, IEnumerable<FirewallPolicyName>, CallSettings)
            // Additional: ReorderFirewallPoliciesAsync(ProjectName, IEnumerable<FirewallPolicyName>, CancellationToken)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            IEnumerable<FirewallPolicyName> names = new FirewallPolicyName[]
            {
                FirewallPolicyName.FromProjectFirewallpolicy("[PROJECT]", "[FIREWALLPOLICY]"),
            };
            // Make the request
            ReorderFirewallPoliciesResponse response = await recaptchaEnterpriseServiceClient.ReorderFirewallPoliciesAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for ListRelatedAccountGroups</summary>
        public void ListRelatedAccountGroupsRequestObject()
        {
            // Snippet: ListRelatedAccountGroups(ListRelatedAccountGroupsRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            ListRelatedAccountGroupsRequest request = new ListRelatedAccountGroupsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListRelatedAccountGroupsResponse, RelatedAccountGroup> response = recaptchaEnterpriseServiceClient.ListRelatedAccountGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RelatedAccountGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRelatedAccountGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RelatedAccountGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RelatedAccountGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RelatedAccountGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRelatedAccountGroupsAsync</summary>
        public async Task ListRelatedAccountGroupsRequestObjectAsync()
        {
            // Snippet: ListRelatedAccountGroupsAsync(ListRelatedAccountGroupsRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRelatedAccountGroupsRequest request = new ListRelatedAccountGroupsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListRelatedAccountGroupsResponse, RelatedAccountGroup> response = recaptchaEnterpriseServiceClient.ListRelatedAccountGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RelatedAccountGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRelatedAccountGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RelatedAccountGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RelatedAccountGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RelatedAccountGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRelatedAccountGroups</summary>
        public void ListRelatedAccountGroups()
        {
            // Snippet: ListRelatedAccountGroups(string, string, int?, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListRelatedAccountGroupsResponse, RelatedAccountGroup> response = recaptchaEnterpriseServiceClient.ListRelatedAccountGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RelatedAccountGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRelatedAccountGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RelatedAccountGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RelatedAccountGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RelatedAccountGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRelatedAccountGroupsAsync</summary>
        public async Task ListRelatedAccountGroupsAsync()
        {
            // Snippet: ListRelatedAccountGroupsAsync(string, string, int?, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListRelatedAccountGroupsResponse, RelatedAccountGroup> response = recaptchaEnterpriseServiceClient.ListRelatedAccountGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RelatedAccountGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRelatedAccountGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RelatedAccountGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RelatedAccountGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RelatedAccountGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRelatedAccountGroups</summary>
        public void ListRelatedAccountGroupsResourceNames()
        {
            // Snippet: ListRelatedAccountGroups(ProjectName, string, int?, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListRelatedAccountGroupsResponse, RelatedAccountGroup> response = recaptchaEnterpriseServiceClient.ListRelatedAccountGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RelatedAccountGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRelatedAccountGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RelatedAccountGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RelatedAccountGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RelatedAccountGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRelatedAccountGroupsAsync</summary>
        public async Task ListRelatedAccountGroupsResourceNamesAsync()
        {
            // Snippet: ListRelatedAccountGroupsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListRelatedAccountGroupsResponse, RelatedAccountGroup> response = recaptchaEnterpriseServiceClient.ListRelatedAccountGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RelatedAccountGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRelatedAccountGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RelatedAccountGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RelatedAccountGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RelatedAccountGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRelatedAccountGroupMemberships</summary>
        public void ListRelatedAccountGroupMembershipsRequestObject()
        {
            // Snippet: ListRelatedAccountGroupMemberships(ListRelatedAccountGroupMembershipsRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            ListRelatedAccountGroupMembershipsRequest request = new ListRelatedAccountGroupMembershipsRequest
            {
                ParentAsRelatedAccountGroupName = RelatedAccountGroupName.FromProjectRelatedaccountgroup("[PROJECT]", "[RELATEDACCOUNTGROUP]"),
            };
            // Make the request
            PagedEnumerable<ListRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> response = recaptchaEnterpriseServiceClient.ListRelatedAccountGroupMemberships(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RelatedAccountGroupMembership item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRelatedAccountGroupMembershipsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RelatedAccountGroupMembership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RelatedAccountGroupMembership> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RelatedAccountGroupMembership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRelatedAccountGroupMembershipsAsync</summary>
        public async Task ListRelatedAccountGroupMembershipsRequestObjectAsync()
        {
            // Snippet: ListRelatedAccountGroupMembershipsAsync(ListRelatedAccountGroupMembershipsRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRelatedAccountGroupMembershipsRequest request = new ListRelatedAccountGroupMembershipsRequest
            {
                ParentAsRelatedAccountGroupName = RelatedAccountGroupName.FromProjectRelatedaccountgroup("[PROJECT]", "[RELATEDACCOUNTGROUP]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> response = recaptchaEnterpriseServiceClient.ListRelatedAccountGroupMembershipsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RelatedAccountGroupMembership item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRelatedAccountGroupMembershipsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RelatedAccountGroupMembership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RelatedAccountGroupMembership> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RelatedAccountGroupMembership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRelatedAccountGroupMemberships</summary>
        public void ListRelatedAccountGroupMemberships()
        {
            // Snippet: ListRelatedAccountGroupMemberships(string, string, int?, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/relatedaccountgroups/[RELATEDACCOUNTGROUP]";
            // Make the request
            PagedEnumerable<ListRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> response = recaptchaEnterpriseServiceClient.ListRelatedAccountGroupMemberships(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RelatedAccountGroupMembership item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRelatedAccountGroupMembershipsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RelatedAccountGroupMembership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RelatedAccountGroupMembership> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RelatedAccountGroupMembership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRelatedAccountGroupMembershipsAsync</summary>
        public async Task ListRelatedAccountGroupMembershipsAsync()
        {
            // Snippet: ListRelatedAccountGroupMembershipsAsync(string, string, int?, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/relatedaccountgroups/[RELATEDACCOUNTGROUP]";
            // Make the request
            PagedAsyncEnumerable<ListRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> response = recaptchaEnterpriseServiceClient.ListRelatedAccountGroupMembershipsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RelatedAccountGroupMembership item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRelatedAccountGroupMembershipsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RelatedAccountGroupMembership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RelatedAccountGroupMembership> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RelatedAccountGroupMembership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRelatedAccountGroupMemberships</summary>
        public void ListRelatedAccountGroupMembershipsResourceNames()
        {
            // Snippet: ListRelatedAccountGroupMemberships(RelatedAccountGroupName, string, int?, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            RelatedAccountGroupName parent = RelatedAccountGroupName.FromProjectRelatedaccountgroup("[PROJECT]", "[RELATEDACCOUNTGROUP]");
            // Make the request
            PagedEnumerable<ListRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> response = recaptchaEnterpriseServiceClient.ListRelatedAccountGroupMemberships(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RelatedAccountGroupMembership item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRelatedAccountGroupMembershipsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RelatedAccountGroupMembership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RelatedAccountGroupMembership> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RelatedAccountGroupMembership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRelatedAccountGroupMembershipsAsync</summary>
        public async Task ListRelatedAccountGroupMembershipsResourceNamesAsync()
        {
            // Snippet: ListRelatedAccountGroupMembershipsAsync(RelatedAccountGroupName, string, int?, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            RelatedAccountGroupName parent = RelatedAccountGroupName.FromProjectRelatedaccountgroup("[PROJECT]", "[RELATEDACCOUNTGROUP]");
            // Make the request
            PagedAsyncEnumerable<ListRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> response = recaptchaEnterpriseServiceClient.ListRelatedAccountGroupMembershipsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RelatedAccountGroupMembership item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRelatedAccountGroupMembershipsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RelatedAccountGroupMembership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RelatedAccountGroupMembership> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RelatedAccountGroupMembership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchRelatedAccountGroupMemberships</summary>
        public void SearchRelatedAccountGroupMembershipsRequestObject()
        {
            // Snippet: SearchRelatedAccountGroupMemberships(SearchRelatedAccountGroupMembershipsRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            SearchRelatedAccountGroupMembershipsRequest request = new SearchRelatedAccountGroupMembershipsRequest
            {
                ProjectAsProjectName = ProjectName.FromProject("[PROJECT]"),
                AccountId = "",
            };
            // Make the request
            PagedEnumerable<SearchRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> response = recaptchaEnterpriseServiceClient.SearchRelatedAccountGroupMemberships(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RelatedAccountGroupMembership item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchRelatedAccountGroupMembershipsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RelatedAccountGroupMembership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RelatedAccountGroupMembership> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RelatedAccountGroupMembership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchRelatedAccountGroupMembershipsAsync</summary>
        public async Task SearchRelatedAccountGroupMembershipsRequestObjectAsync()
        {
            // Snippet: SearchRelatedAccountGroupMembershipsAsync(SearchRelatedAccountGroupMembershipsRequest, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchRelatedAccountGroupMembershipsRequest request = new SearchRelatedAccountGroupMembershipsRequest
            {
                ProjectAsProjectName = ProjectName.FromProject("[PROJECT]"),
                AccountId = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> response = recaptchaEnterpriseServiceClient.SearchRelatedAccountGroupMembershipsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RelatedAccountGroupMembership item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchRelatedAccountGroupMembershipsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RelatedAccountGroupMembership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RelatedAccountGroupMembership> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RelatedAccountGroupMembership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchRelatedAccountGroupMemberships</summary>
        public void SearchRelatedAccountGroupMemberships()
        {
            // Snippet: SearchRelatedAccountGroupMemberships(string, ByteString, string, int?, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            string project = "projects/[PROJECT]";
            ByteString hashedAccountId = ByteString.Empty;
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<SearchRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> response = recaptchaEnterpriseServiceClient.SearchRelatedAccountGroupMemberships(project, hashedAccountId);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RelatedAccountGroupMembership item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchRelatedAccountGroupMembershipsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RelatedAccountGroupMembership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RelatedAccountGroupMembership> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RelatedAccountGroupMembership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchRelatedAccountGroupMembershipsAsync</summary>
        public async Task SearchRelatedAccountGroupMembershipsAsync()
        {
            // Snippet: SearchRelatedAccountGroupMembershipsAsync(string, ByteString, string, int?, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string project = "projects/[PROJECT]";
            ByteString hashedAccountId = ByteString.Empty;
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<SearchRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> response = recaptchaEnterpriseServiceClient.SearchRelatedAccountGroupMembershipsAsync(project, hashedAccountId);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RelatedAccountGroupMembership item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchRelatedAccountGroupMembershipsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RelatedAccountGroupMembership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RelatedAccountGroupMembership> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RelatedAccountGroupMembership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchRelatedAccountGroupMemberships</summary>
        public void SearchRelatedAccountGroupMembershipsResourceNames()
        {
            // Snippet: SearchRelatedAccountGroupMemberships(ProjectName, ByteString, string, int?, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = RecaptchaEnterpriseServiceClient.Create();
            // Initialize request argument(s)
            ProjectName project = ProjectName.FromProject("[PROJECT]");
            ByteString hashedAccountId = ByteString.Empty;
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<SearchRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> response = recaptchaEnterpriseServiceClient.SearchRelatedAccountGroupMemberships(project, hashedAccountId);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RelatedAccountGroupMembership item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchRelatedAccountGroupMembershipsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RelatedAccountGroupMembership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RelatedAccountGroupMembership> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RelatedAccountGroupMembership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchRelatedAccountGroupMembershipsAsync</summary>
        public async Task SearchRelatedAccountGroupMembershipsResourceNamesAsync()
        {
            // Snippet: SearchRelatedAccountGroupMembershipsAsync(ProjectName, ByteString, string, int?, CallSettings)
            // Create client
            RecaptchaEnterpriseServiceClient recaptchaEnterpriseServiceClient = await RecaptchaEnterpriseServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName project = ProjectName.FromProject("[PROJECT]");
            ByteString hashedAccountId = ByteString.Empty;
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<SearchRelatedAccountGroupMembershipsResponse, RelatedAccountGroupMembership> response = recaptchaEnterpriseServiceClient.SearchRelatedAccountGroupMembershipsAsync(project, hashedAccountId);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RelatedAccountGroupMembership item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchRelatedAccountGroupMembershipsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RelatedAccountGroupMembership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RelatedAccountGroupMembership> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RelatedAccountGroupMembership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
