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

namespace Google.Cloud.SecretManager.V1Beta1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Iam.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedSecretManagerServiceClientSnippets
    {
        /// <summary>Snippet for ListSecrets</summary>
        public void ListSecrets_RequestObject()
        {
            // Snippet: ListSecrets(ListSecretsRequest, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            ListSecretsRequest request = new ListSecretsRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListSecretsResponse, Secret> response = secretManagerServiceClient.ListSecrets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Secret item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecretsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Secret item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Secret> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Secret item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecrets</summary>
        public async Task ListSecretsAsync_RequestObject()
        {
            // Snippet: ListSecretsAsync(ListSecretsRequest, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSecretsRequest request = new ListSecretsRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSecretsResponse, Secret> response = secretManagerServiceClient.ListSecretsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Secret item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSecretsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Secret item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Secret> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Secret item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecrets</summary>
        public void ListSecrets()
        {
            // Snippet: ListSecrets(string, string, int?, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListSecretsResponse, Secret> response = secretManagerServiceClient.ListSecrets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Secret item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecretsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Secret item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Secret> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Secret item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecrets</summary>
        public async Task ListSecretsAsync()
        {
            // Snippet: ListSecretsAsync(string, string, int?, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListSecretsResponse, Secret> response = secretManagerServiceClient.ListSecretsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Secret item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSecretsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Secret item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Secret> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Secret item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecrets</summary>
        public void ListSecrets_ResourceNames()
        {
            // Snippet: ListSecrets(ProjectName, string, int?, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            // Make the request
            PagedEnumerable<ListSecretsResponse, Secret> response = secretManagerServiceClient.ListSecrets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Secret item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecretsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Secret item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Secret> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Secret item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecrets</summary>
        public async Task ListSecretsAsync_ResourceNames()
        {
            // Snippet: ListSecretsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListSecretsResponse, Secret> response = secretManagerServiceClient.ListSecretsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Secret item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSecretsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Secret item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Secret> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Secret item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateSecret</summary>
        public void CreateSecret_RequestObject()
        {
            // Snippet: CreateSecret(CreateSecretRequest, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            CreateSecretRequest request = new CreateSecretRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                SecretId = "",
                Secret = new Secret(),
            };
            // Make the request
            Secret response = secretManagerServiceClient.CreateSecret(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSecretAsync</summary>
        public async Task CreateSecretAsync_RequestObject()
        {
            // Snippet: CreateSecretAsync(CreateSecretRequest, CallSettings)
            // Additional: CreateSecretAsync(CreateSecretRequest, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSecretRequest request = new CreateSecretRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                SecretId = "",
                Secret = new Secret(),
            };
            // Make the request
            Secret response = await secretManagerServiceClient.CreateSecretAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSecret</summary>
        public void CreateSecret()
        {
            // Snippet: CreateSecret(string, string, Secret, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string secretId = "";
            Secret secret = new Secret();
            // Make the request
            Secret response = secretManagerServiceClient.CreateSecret(parent, secretId, secret);
            // End snippet
        }

        /// <summary>Snippet for CreateSecretAsync</summary>
        public async Task CreateSecretAsync()
        {
            // Snippet: CreateSecretAsync(string, string, Secret, CallSettings)
            // Additional: CreateSecretAsync(string, string, Secret, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string secretId = "";
            Secret secret = new Secret();
            // Make the request
            Secret response = await secretManagerServiceClient.CreateSecretAsync(parent, secretId, secret);
            // End snippet
        }

        /// <summary>Snippet for CreateSecret</summary>
        public void CreateSecret_ResourceNames()
        {
            // Snippet: CreateSecret(ProjectName, string, Secret, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            string secretId = "";
            Secret secret = new Secret();
            // Make the request
            Secret response = secretManagerServiceClient.CreateSecret(parent, secretId, secret);
            // End snippet
        }

        /// <summary>Snippet for CreateSecretAsync</summary>
        public async Task CreateSecretAsync_ResourceNames()
        {
            // Snippet: CreateSecretAsync(ProjectName, string, Secret, CallSettings)
            // Additional: CreateSecretAsync(ProjectName, string, Secret, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            string secretId = "";
            Secret secret = new Secret();
            // Make the request
            Secret response = await secretManagerServiceClient.CreateSecretAsync(parent, secretId, secret);
            // End snippet
        }

        /// <summary>Snippet for AddSecretVersion</summary>
        public void AddSecretVersion_RequestObject()
        {
            // Snippet: AddSecretVersion(AddSecretVersionRequest, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            AddSecretVersionRequest request = new AddSecretVersionRequest
            {
                ParentAsSecretName = new SecretName("[PROJECT]", "[SECRET]"),
                Payload = new SecretPayload(),
            };
            // Make the request
            SecretVersion response = secretManagerServiceClient.AddSecretVersion(request);
            // End snippet
        }

        /// <summary>Snippet for AddSecretVersionAsync</summary>
        public async Task AddSecretVersionAsync_RequestObject()
        {
            // Snippet: AddSecretVersionAsync(AddSecretVersionRequest, CallSettings)
            // Additional: AddSecretVersionAsync(AddSecretVersionRequest, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            AddSecretVersionRequest request = new AddSecretVersionRequest
            {
                ParentAsSecretName = new SecretName("[PROJECT]", "[SECRET]"),
                Payload = new SecretPayload(),
            };
            // Make the request
            SecretVersion response = await secretManagerServiceClient.AddSecretVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AddSecretVersion</summary>
        public void AddSecretVersion()
        {
            // Snippet: AddSecretVersion(string, SecretPayload, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/secrets/[SECRET]";
            SecretPayload payload = new SecretPayload();
            // Make the request
            SecretVersion response = secretManagerServiceClient.AddSecretVersion(parent, payload);
            // End snippet
        }

        /// <summary>Snippet for AddSecretVersionAsync</summary>
        public async Task AddSecretVersionAsync()
        {
            // Snippet: AddSecretVersionAsync(string, SecretPayload, CallSettings)
            // Additional: AddSecretVersionAsync(string, SecretPayload, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/secrets/[SECRET]";
            SecretPayload payload = new SecretPayload();
            // Make the request
            SecretVersion response = await secretManagerServiceClient.AddSecretVersionAsync(parent, payload);
            // End snippet
        }

        /// <summary>Snippet for AddSecretVersion</summary>
        public void AddSecretVersion_ResourceNames()
        {
            // Snippet: AddSecretVersion(SecretName, SecretPayload, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            SecretName parent = new SecretName("[PROJECT]", "[SECRET]");
            SecretPayload payload = new SecretPayload();
            // Make the request
            SecretVersion response = secretManagerServiceClient.AddSecretVersion(parent, payload);
            // End snippet
        }

        /// <summary>Snippet for AddSecretVersionAsync</summary>
        public async Task AddSecretVersionAsync_ResourceNames()
        {
            // Snippet: AddSecretVersionAsync(SecretName, SecretPayload, CallSettings)
            // Additional: AddSecretVersionAsync(SecretName, SecretPayload, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            SecretName parent = new SecretName("[PROJECT]", "[SECRET]");
            SecretPayload payload = new SecretPayload();
            // Make the request
            SecretVersion response = await secretManagerServiceClient.AddSecretVersionAsync(parent, payload);
            // End snippet
        }

        /// <summary>Snippet for GetSecret</summary>
        public void GetSecret_RequestObject()
        {
            // Snippet: GetSecret(GetSecretRequest, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            GetSecretRequest request = new GetSecretRequest
            {
                SecretName = new SecretName("[PROJECT]", "[SECRET]"),
            };
            // Make the request
            Secret response = secretManagerServiceClient.GetSecret(request);
            // End snippet
        }

        /// <summary>Snippet for GetSecretAsync</summary>
        public async Task GetSecretAsync_RequestObject()
        {
            // Snippet: GetSecretAsync(GetSecretRequest, CallSettings)
            // Additional: GetSecretAsync(GetSecretRequest, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSecretRequest request = new GetSecretRequest
            {
                SecretName = new SecretName("[PROJECT]", "[SECRET]"),
            };
            // Make the request
            Secret response = await secretManagerServiceClient.GetSecretAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSecret</summary>
        public void GetSecret()
        {
            // Snippet: GetSecret(string, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/secrets/[SECRET]";
            // Make the request
            Secret response = secretManagerServiceClient.GetSecret(name);
            // End snippet
        }

        /// <summary>Snippet for GetSecretAsync</summary>
        public async Task GetSecretAsync()
        {
            // Snippet: GetSecretAsync(string, CallSettings)
            // Additional: GetSecretAsync(string, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/secrets/[SECRET]";
            // Make the request
            Secret response = await secretManagerServiceClient.GetSecretAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSecret</summary>
        public void GetSecret_ResourceNames()
        {
            // Snippet: GetSecret(SecretName, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            SecretName name = new SecretName("[PROJECT]", "[SECRET]");
            // Make the request
            Secret response = secretManagerServiceClient.GetSecret(name);
            // End snippet
        }

        /// <summary>Snippet for GetSecretAsync</summary>
        public async Task GetSecretAsync_ResourceNames()
        {
            // Snippet: GetSecretAsync(SecretName, CallSettings)
            // Additional: GetSecretAsync(SecretName, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            SecretName name = new SecretName("[PROJECT]", "[SECRET]");
            // Make the request
            Secret response = await secretManagerServiceClient.GetSecretAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateSecret</summary>
        public void UpdateSecret_RequestObject()
        {
            // Snippet: UpdateSecret(UpdateSecretRequest, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            UpdateSecretRequest request = new UpdateSecretRequest
            {
                Secret = new Secret(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Secret response = secretManagerServiceClient.UpdateSecret(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSecretAsync</summary>
        public async Task UpdateSecretAsync_RequestObject()
        {
            // Snippet: UpdateSecretAsync(UpdateSecretRequest, CallSettings)
            // Additional: UpdateSecretAsync(UpdateSecretRequest, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSecretRequest request = new UpdateSecretRequest
            {
                Secret = new Secret(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Secret response = await secretManagerServiceClient.UpdateSecretAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSecret</summary>
        public void UpdateSecret()
        {
            // Snippet: UpdateSecret(Secret, FieldMask, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            Secret secret = new Secret();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Secret response = secretManagerServiceClient.UpdateSecret(secret, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSecretAsync</summary>
        public async Task UpdateSecretAsync()
        {
            // Snippet: UpdateSecretAsync(Secret, FieldMask, CallSettings)
            // Additional: UpdateSecretAsync(Secret, FieldMask, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            Secret secret = new Secret();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Secret response = await secretManagerServiceClient.UpdateSecretAsync(secret, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteSecret</summary>
        public void DeleteSecret_RequestObject()
        {
            // Snippet: DeleteSecret(DeleteSecretRequest, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            DeleteSecretRequest request = new DeleteSecretRequest
            {
                SecretName = new SecretName("[PROJECT]", "[SECRET]"),
            };
            // Make the request
            secretManagerServiceClient.DeleteSecret(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSecretAsync</summary>
        public async Task DeleteSecretAsync_RequestObject()
        {
            // Snippet: DeleteSecretAsync(DeleteSecretRequest, CallSettings)
            // Additional: DeleteSecretAsync(DeleteSecretRequest, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSecretRequest request = new DeleteSecretRequest
            {
                SecretName = new SecretName("[PROJECT]", "[SECRET]"),
            };
            // Make the request
            await secretManagerServiceClient.DeleteSecretAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSecret</summary>
        public void DeleteSecret()
        {
            // Snippet: DeleteSecret(string, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/secrets/[SECRET]";
            // Make the request
            secretManagerServiceClient.DeleteSecret(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSecretAsync</summary>
        public async Task DeleteSecretAsync()
        {
            // Snippet: DeleteSecretAsync(string, CallSettings)
            // Additional: DeleteSecretAsync(string, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/secrets/[SECRET]";
            // Make the request
            await secretManagerServiceClient.DeleteSecretAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSecret</summary>
        public void DeleteSecret_ResourceNames()
        {
            // Snippet: DeleteSecret(SecretName, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            SecretName name = new SecretName("[PROJECT]", "[SECRET]");
            // Make the request
            secretManagerServiceClient.DeleteSecret(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSecretAsync</summary>
        public async Task DeleteSecretAsync_ResourceNames()
        {
            // Snippet: DeleteSecretAsync(SecretName, CallSettings)
            // Additional: DeleteSecretAsync(SecretName, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            SecretName name = new SecretName("[PROJECT]", "[SECRET]");
            // Make the request
            await secretManagerServiceClient.DeleteSecretAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSecretVersions</summary>
        public void ListSecretVersions_RequestObject()
        {
            // Snippet: ListSecretVersions(ListSecretVersionsRequest, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            ListSecretVersionsRequest request = new ListSecretVersionsRequest
            {
                ParentAsSecretName = new SecretName("[PROJECT]", "[SECRET]"),
            };
            // Make the request
            PagedEnumerable<ListSecretVersionsResponse, SecretVersion> response = secretManagerServiceClient.ListSecretVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecretVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecretVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecretVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecretVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecretVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecretVersions</summary>
        public async Task ListSecretVersionsAsync_RequestObject()
        {
            // Snippet: ListSecretVersionsAsync(ListSecretVersionsRequest, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSecretVersionsRequest request = new ListSecretVersionsRequest
            {
                ParentAsSecretName = new SecretName("[PROJECT]", "[SECRET]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSecretVersionsResponse, SecretVersion> response = secretManagerServiceClient.ListSecretVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SecretVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSecretVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecretVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecretVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecretVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecretVersions</summary>
        public void ListSecretVersions()
        {
            // Snippet: ListSecretVersions(string, string, int?, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/secrets/[SECRET]";
            // Make the request
            PagedEnumerable<ListSecretVersionsResponse, SecretVersion> response = secretManagerServiceClient.ListSecretVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecretVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecretVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecretVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecretVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecretVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecretVersions</summary>
        public async Task ListSecretVersionsAsync()
        {
            // Snippet: ListSecretVersionsAsync(string, string, int?, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/secrets/[SECRET]";
            // Make the request
            PagedAsyncEnumerable<ListSecretVersionsResponse, SecretVersion> response = secretManagerServiceClient.ListSecretVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SecretVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSecretVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecretVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecretVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecretVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecretVersions</summary>
        public void ListSecretVersions_ResourceNames()
        {
            // Snippet: ListSecretVersions(SecretName, string, int?, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            SecretName parent = new SecretName("[PROJECT]", "[SECRET]");
            // Make the request
            PagedEnumerable<ListSecretVersionsResponse, SecretVersion> response = secretManagerServiceClient.ListSecretVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecretVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecretVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecretVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecretVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecretVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecretVersions</summary>
        public async Task ListSecretVersionsAsync_ResourceNames()
        {
            // Snippet: ListSecretVersionsAsync(SecretName, string, int?, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            SecretName parent = new SecretName("[PROJECT]", "[SECRET]");
            // Make the request
            PagedAsyncEnumerable<ListSecretVersionsResponse, SecretVersion> response = secretManagerServiceClient.ListSecretVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SecretVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSecretVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecretVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecretVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecretVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSecretVersion</summary>
        public void GetSecretVersion_RequestObject()
        {
            // Snippet: GetSecretVersion(GetSecretVersionRequest, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            GetSecretVersionRequest request = new GetSecretVersionRequest
            {
                SecretVersionName = new SecretVersionName("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            // Make the request
            SecretVersion response = secretManagerServiceClient.GetSecretVersion(request);
            // End snippet
        }

        /// <summary>Snippet for GetSecretVersionAsync</summary>
        public async Task GetSecretVersionAsync_RequestObject()
        {
            // Snippet: GetSecretVersionAsync(GetSecretVersionRequest, CallSettings)
            // Additional: GetSecretVersionAsync(GetSecretVersionRequest, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSecretVersionRequest request = new GetSecretVersionRequest
            {
                SecretVersionName = new SecretVersionName("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            // Make the request
            SecretVersion response = await secretManagerServiceClient.GetSecretVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSecretVersion</summary>
        public void GetSecretVersion()
        {
            // Snippet: GetSecretVersion(string, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/secrets/[SECRET]/versions/[SECRET_VERSION]";
            // Make the request
            SecretVersion response = secretManagerServiceClient.GetSecretVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetSecretVersionAsync</summary>
        public async Task GetSecretVersionAsync()
        {
            // Snippet: GetSecretVersionAsync(string, CallSettings)
            // Additional: GetSecretVersionAsync(string, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/secrets/[SECRET]/versions/[SECRET_VERSION]";
            // Make the request
            SecretVersion response = await secretManagerServiceClient.GetSecretVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSecretVersion</summary>
        public void GetSecretVersion_ResourceNames()
        {
            // Snippet: GetSecretVersion(SecretVersionName, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            SecretVersionName name = new SecretVersionName("[PROJECT]", "[SECRET]", "[SECRET_VERSION]");
            // Make the request
            SecretVersion response = secretManagerServiceClient.GetSecretVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetSecretVersionAsync</summary>
        public async Task GetSecretVersionAsync_ResourceNames()
        {
            // Snippet: GetSecretVersionAsync(SecretVersionName, CallSettings)
            // Additional: GetSecretVersionAsync(SecretVersionName, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            SecretVersionName name = new SecretVersionName("[PROJECT]", "[SECRET]", "[SECRET_VERSION]");
            // Make the request
            SecretVersion response = await secretManagerServiceClient.GetSecretVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for AccessSecretVersion</summary>
        public void AccessSecretVersion_RequestObject()
        {
            // Snippet: AccessSecretVersion(AccessSecretVersionRequest, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            AccessSecretVersionRequest request = new AccessSecretVersionRequest
            {
                SecretVersionName = new SecretVersionName("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            // Make the request
            AccessSecretVersionResponse response = secretManagerServiceClient.AccessSecretVersion(request);
            // End snippet
        }

        /// <summary>Snippet for AccessSecretVersionAsync</summary>
        public async Task AccessSecretVersionAsync_RequestObject()
        {
            // Snippet: AccessSecretVersionAsync(AccessSecretVersionRequest, CallSettings)
            // Additional: AccessSecretVersionAsync(AccessSecretVersionRequest, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccessSecretVersionRequest request = new AccessSecretVersionRequest
            {
                SecretVersionName = new SecretVersionName("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            // Make the request
            AccessSecretVersionResponse response = await secretManagerServiceClient.AccessSecretVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AccessSecretVersion</summary>
        public void AccessSecretVersion()
        {
            // Snippet: AccessSecretVersion(string, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/secrets/[SECRET]/versions/[SECRET_VERSION]";
            // Make the request
            AccessSecretVersionResponse response = secretManagerServiceClient.AccessSecretVersion(name);
            // End snippet
        }

        /// <summary>Snippet for AccessSecretVersionAsync</summary>
        public async Task AccessSecretVersionAsync()
        {
            // Snippet: AccessSecretVersionAsync(string, CallSettings)
            // Additional: AccessSecretVersionAsync(string, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/secrets/[SECRET]/versions/[SECRET_VERSION]";
            // Make the request
            AccessSecretVersionResponse response = await secretManagerServiceClient.AccessSecretVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for AccessSecretVersion</summary>
        public void AccessSecretVersion_ResourceNames()
        {
            // Snippet: AccessSecretVersion(SecretVersionName, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            SecretVersionName name = new SecretVersionName("[PROJECT]", "[SECRET]", "[SECRET_VERSION]");
            // Make the request
            AccessSecretVersionResponse response = secretManagerServiceClient.AccessSecretVersion(name);
            // End snippet
        }

        /// <summary>Snippet for AccessSecretVersionAsync</summary>
        public async Task AccessSecretVersionAsync_ResourceNames()
        {
            // Snippet: AccessSecretVersionAsync(SecretVersionName, CallSettings)
            // Additional: AccessSecretVersionAsync(SecretVersionName, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            SecretVersionName name = new SecretVersionName("[PROJECT]", "[SECRET]", "[SECRET_VERSION]");
            // Make the request
            AccessSecretVersionResponse response = await secretManagerServiceClient.AccessSecretVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DisableSecretVersion</summary>
        public void DisableSecretVersion_RequestObject()
        {
            // Snippet: DisableSecretVersion(DisableSecretVersionRequest, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            DisableSecretVersionRequest request = new DisableSecretVersionRequest
            {
                SecretVersionName = new SecretVersionName("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            // Make the request
            SecretVersion response = secretManagerServiceClient.DisableSecretVersion(request);
            // End snippet
        }

        /// <summary>Snippet for DisableSecretVersionAsync</summary>
        public async Task DisableSecretVersionAsync_RequestObject()
        {
            // Snippet: DisableSecretVersionAsync(DisableSecretVersionRequest, CallSettings)
            // Additional: DisableSecretVersionAsync(DisableSecretVersionRequest, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            DisableSecretVersionRequest request = new DisableSecretVersionRequest
            {
                SecretVersionName = new SecretVersionName("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            // Make the request
            SecretVersion response = await secretManagerServiceClient.DisableSecretVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DisableSecretVersion</summary>
        public void DisableSecretVersion()
        {
            // Snippet: DisableSecretVersion(string, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/secrets/[SECRET]/versions/[SECRET_VERSION]";
            // Make the request
            SecretVersion response = secretManagerServiceClient.DisableSecretVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DisableSecretVersionAsync</summary>
        public async Task DisableSecretVersionAsync()
        {
            // Snippet: DisableSecretVersionAsync(string, CallSettings)
            // Additional: DisableSecretVersionAsync(string, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/secrets/[SECRET]/versions/[SECRET_VERSION]";
            // Make the request
            SecretVersion response = await secretManagerServiceClient.DisableSecretVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DisableSecretVersion</summary>
        public void DisableSecretVersion_ResourceNames()
        {
            // Snippet: DisableSecretVersion(SecretVersionName, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            SecretVersionName name = new SecretVersionName("[PROJECT]", "[SECRET]", "[SECRET_VERSION]");
            // Make the request
            SecretVersion response = secretManagerServiceClient.DisableSecretVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DisableSecretVersionAsync</summary>
        public async Task DisableSecretVersionAsync_ResourceNames()
        {
            // Snippet: DisableSecretVersionAsync(SecretVersionName, CallSettings)
            // Additional: DisableSecretVersionAsync(SecretVersionName, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            SecretVersionName name = new SecretVersionName("[PROJECT]", "[SECRET]", "[SECRET_VERSION]");
            // Make the request
            SecretVersion response = await secretManagerServiceClient.DisableSecretVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for EnableSecretVersion</summary>
        public void EnableSecretVersion_RequestObject()
        {
            // Snippet: EnableSecretVersion(EnableSecretVersionRequest, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            EnableSecretVersionRequest request = new EnableSecretVersionRequest
            {
                SecretVersionName = new SecretVersionName("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            // Make the request
            SecretVersion response = secretManagerServiceClient.EnableSecretVersion(request);
            // End snippet
        }

        /// <summary>Snippet for EnableSecretVersionAsync</summary>
        public async Task EnableSecretVersionAsync_RequestObject()
        {
            // Snippet: EnableSecretVersionAsync(EnableSecretVersionRequest, CallSettings)
            // Additional: EnableSecretVersionAsync(EnableSecretVersionRequest, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            EnableSecretVersionRequest request = new EnableSecretVersionRequest
            {
                SecretVersionName = new SecretVersionName("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            // Make the request
            SecretVersion response = await secretManagerServiceClient.EnableSecretVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for EnableSecretVersion</summary>
        public void EnableSecretVersion()
        {
            // Snippet: EnableSecretVersion(string, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/secrets/[SECRET]/versions/[SECRET_VERSION]";
            // Make the request
            SecretVersion response = secretManagerServiceClient.EnableSecretVersion(name);
            // End snippet
        }

        /// <summary>Snippet for EnableSecretVersionAsync</summary>
        public async Task EnableSecretVersionAsync()
        {
            // Snippet: EnableSecretVersionAsync(string, CallSettings)
            // Additional: EnableSecretVersionAsync(string, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/secrets/[SECRET]/versions/[SECRET_VERSION]";
            // Make the request
            SecretVersion response = await secretManagerServiceClient.EnableSecretVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for EnableSecretVersion</summary>
        public void EnableSecretVersion_ResourceNames()
        {
            // Snippet: EnableSecretVersion(SecretVersionName, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            SecretVersionName name = new SecretVersionName("[PROJECT]", "[SECRET]", "[SECRET_VERSION]");
            // Make the request
            SecretVersion response = secretManagerServiceClient.EnableSecretVersion(name);
            // End snippet
        }

        /// <summary>Snippet for EnableSecretVersionAsync</summary>
        public async Task EnableSecretVersionAsync_ResourceNames()
        {
            // Snippet: EnableSecretVersionAsync(SecretVersionName, CallSettings)
            // Additional: EnableSecretVersionAsync(SecretVersionName, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            SecretVersionName name = new SecretVersionName("[PROJECT]", "[SECRET]", "[SECRET_VERSION]");
            // Make the request
            SecretVersion response = await secretManagerServiceClient.EnableSecretVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DestroySecretVersion</summary>
        public void DestroySecretVersion_RequestObject()
        {
            // Snippet: DestroySecretVersion(DestroySecretVersionRequest, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            DestroySecretVersionRequest request = new DestroySecretVersionRequest
            {
                SecretVersionName = new SecretVersionName("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            // Make the request
            SecretVersion response = secretManagerServiceClient.DestroySecretVersion(request);
            // End snippet
        }

        /// <summary>Snippet for DestroySecretVersionAsync</summary>
        public async Task DestroySecretVersionAsync_RequestObject()
        {
            // Snippet: DestroySecretVersionAsync(DestroySecretVersionRequest, CallSettings)
            // Additional: DestroySecretVersionAsync(DestroySecretVersionRequest, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            DestroySecretVersionRequest request = new DestroySecretVersionRequest
            {
                SecretVersionName = new SecretVersionName("[PROJECT]", "[SECRET]", "[SECRET_VERSION]"),
            };
            // Make the request
            SecretVersion response = await secretManagerServiceClient.DestroySecretVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DestroySecretVersion</summary>
        public void DestroySecretVersion()
        {
            // Snippet: DestroySecretVersion(string, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/secrets/[SECRET]/versions/[SECRET_VERSION]";
            // Make the request
            SecretVersion response = secretManagerServiceClient.DestroySecretVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DestroySecretVersionAsync</summary>
        public async Task DestroySecretVersionAsync()
        {
            // Snippet: DestroySecretVersionAsync(string, CallSettings)
            // Additional: DestroySecretVersionAsync(string, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/secrets/[SECRET]/versions/[SECRET_VERSION]";
            // Make the request
            SecretVersion response = await secretManagerServiceClient.DestroySecretVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DestroySecretVersion</summary>
        public void DestroySecretVersion_ResourceNames()
        {
            // Snippet: DestroySecretVersion(SecretVersionName, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            SecretVersionName name = new SecretVersionName("[PROJECT]", "[SECRET]", "[SECRET_VERSION]");
            // Make the request
            SecretVersion response = secretManagerServiceClient.DestroySecretVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DestroySecretVersionAsync</summary>
        public async Task DestroySecretVersionAsync_ResourceNames()
        {
            // Snippet: DestroySecretVersionAsync(SecretVersionName, CallSettings)
            // Additional: DestroySecretVersionAsync(SecretVersionName, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            SecretVersionName name = new SecretVersionName("[PROJECT]", "[SECRET]", "[SECRET_VERSION]");
            // Make the request
            SecretVersion response = await secretManagerServiceClient.DestroySecretVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy_RequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnknownResourceName("a/wildcard/resource"),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = secretManagerServiceClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync_RequestObject()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnknownResourceName("a/wildcard/resource"),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await secretManagerServiceClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy_RequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnknownResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = secretManagerServiceClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync_RequestObject()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnknownResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await secretManagerServiceClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions_RequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = SecretManagerServiceClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnknownResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = secretManagerServiceClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync_RequestObject()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            SecretManagerServiceClient secretManagerServiceClient = await SecretManagerServiceClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnknownResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await secretManagerServiceClient.TestIamPermissionsAsync(request);
            // End snippet
        }
    }
}
