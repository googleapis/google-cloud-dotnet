// Copyright 2022 Google LLC
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

namespace Google.Cloud.CertificateManager.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCertificateManagerClientSnippets
    {
        /// <summary>Snippet for ListCertificates</summary>
        public void ListCertificatesRequestObject()
        {
            // Snippet: ListCertificates(ListCertificatesRequest, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            ListCertificatesRequest request = new ListCertificatesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListCertificatesResponse, Certificate> response = certificateManagerClient.ListCertificates(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Certificate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCertificatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Certificate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Certificate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Certificate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificatesAsync</summary>
        public async Task ListCertificatesRequestObjectAsync()
        {
            // Snippet: ListCertificatesAsync(ListCertificatesRequest, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListCertificatesRequest request = new ListCertificatesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCertificatesResponse, Certificate> response = certificateManagerClient.ListCertificatesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Certificate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCertificatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Certificate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Certificate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Certificate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificates</summary>
        public void ListCertificates()
        {
            // Snippet: ListCertificates(string, string, int?, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListCertificatesResponse, Certificate> response = certificateManagerClient.ListCertificates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Certificate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCertificatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Certificate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Certificate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Certificate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificatesAsync</summary>
        public async Task ListCertificatesAsync()
        {
            // Snippet: ListCertificatesAsync(string, string, int?, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListCertificatesResponse, Certificate> response = certificateManagerClient.ListCertificatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Certificate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCertificatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Certificate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Certificate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Certificate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificates</summary>
        public void ListCertificatesResourceNames()
        {
            // Snippet: ListCertificates(LocationName, string, int?, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListCertificatesResponse, Certificate> response = certificateManagerClient.ListCertificates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Certificate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCertificatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Certificate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Certificate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Certificate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificatesAsync</summary>
        public async Task ListCertificatesResourceNamesAsync()
        {
            // Snippet: ListCertificatesAsync(LocationName, string, int?, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListCertificatesResponse, Certificate> response = certificateManagerClient.ListCertificatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Certificate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCertificatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Certificate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Certificate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Certificate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetCertificate</summary>
        public void GetCertificateRequestObject()
        {
            // Snippet: GetCertificate(GetCertificateRequest, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]"),
            };
            // Make the request
            Certificate response = certificateManagerClient.GetCertificate(request);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateAsync</summary>
        public async Task GetCertificateRequestObjectAsync()
        {
            // Snippet: GetCertificateAsync(GetCertificateRequest, CallSettings)
            // Additional: GetCertificateAsync(GetCertificateRequest, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]"),
            };
            // Make the request
            Certificate response = await certificateManagerClient.GetCertificateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCertificate</summary>
        public void GetCertificate()
        {
            // Snippet: GetCertificate(string, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificates/[CERTIFICATE]";
            // Make the request
            Certificate response = certificateManagerClient.GetCertificate(name);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateAsync</summary>
        public async Task GetCertificateAsync()
        {
            // Snippet: GetCertificateAsync(string, CallSettings)
            // Additional: GetCertificateAsync(string, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificates/[CERTIFICATE]";
            // Make the request
            Certificate response = await certificateManagerClient.GetCertificateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCertificate</summary>
        public void GetCertificateResourceNames()
        {
            // Snippet: GetCertificate(CertificateName, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            CertificateName name = CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]");
            // Make the request
            Certificate response = certificateManagerClient.GetCertificate(name);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateAsync</summary>
        public async Task GetCertificateResourceNamesAsync()
        {
            // Snippet: GetCertificateAsync(CertificateName, CallSettings)
            // Additional: GetCertificateAsync(CertificateName, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            CertificateName name = CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]");
            // Make the request
            Certificate response = await certificateManagerClient.GetCertificateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateCertificate</summary>
        public void CreateCertificateRequestObject()
        {
            // Snippet: CreateCertificate(CreateCertificateRequest, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            CreateCertificateRequest request = new CreateCertificateRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CertificateId = "",
                Certificate = new Certificate(),
            };
            // Make the request
            Operation<Certificate, OperationMetadata> response = certificateManagerClient.CreateCertificate(request);

            // Poll until the returned long-running operation is complete
            Operation<Certificate, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Certificate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Certificate, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceCreateCertificate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Certificate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateAsync</summary>
        public async Task CreateCertificateRequestObjectAsync()
        {
            // Snippet: CreateCertificateAsync(CreateCertificateRequest, CallSettings)
            // Additional: CreateCertificateAsync(CreateCertificateRequest, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateCertificateRequest request = new CreateCertificateRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CertificateId = "",
                Certificate = new Certificate(),
            };
            // Make the request
            Operation<Certificate, OperationMetadata> response = await certificateManagerClient.CreateCertificateAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Certificate, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Certificate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Certificate, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceCreateCertificateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Certificate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificate</summary>
        public void CreateCertificate()
        {
            // Snippet: CreateCertificate(string, Certificate, string, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Certificate certificate = new Certificate();
            string certificateId = "";
            // Make the request
            Operation<Certificate, OperationMetadata> response = certificateManagerClient.CreateCertificate(parent, certificate, certificateId);

            // Poll until the returned long-running operation is complete
            Operation<Certificate, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Certificate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Certificate, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceCreateCertificate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Certificate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateAsync</summary>
        public async Task CreateCertificateAsync()
        {
            // Snippet: CreateCertificateAsync(string, Certificate, string, CallSettings)
            // Additional: CreateCertificateAsync(string, Certificate, string, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Certificate certificate = new Certificate();
            string certificateId = "";
            // Make the request
            Operation<Certificate, OperationMetadata> response = await certificateManagerClient.CreateCertificateAsync(parent, certificate, certificateId);

            // Poll until the returned long-running operation is complete
            Operation<Certificate, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Certificate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Certificate, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceCreateCertificateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Certificate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificate</summary>
        public void CreateCertificateResourceNames()
        {
            // Snippet: CreateCertificate(LocationName, Certificate, string, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Certificate certificate = new Certificate();
            string certificateId = "";
            // Make the request
            Operation<Certificate, OperationMetadata> response = certificateManagerClient.CreateCertificate(parent, certificate, certificateId);

            // Poll until the returned long-running operation is complete
            Operation<Certificate, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Certificate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Certificate, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceCreateCertificate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Certificate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateAsync</summary>
        public async Task CreateCertificateResourceNamesAsync()
        {
            // Snippet: CreateCertificateAsync(LocationName, Certificate, string, CallSettings)
            // Additional: CreateCertificateAsync(LocationName, Certificate, string, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Certificate certificate = new Certificate();
            string certificateId = "";
            // Make the request
            Operation<Certificate, OperationMetadata> response = await certificateManagerClient.CreateCertificateAsync(parent, certificate, certificateId);

            // Poll until the returned long-running operation is complete
            Operation<Certificate, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Certificate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Certificate, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceCreateCertificateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Certificate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificate</summary>
        public void UpdateCertificateRequestObject()
        {
            // Snippet: UpdateCertificate(UpdateCertificateRequest, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            UpdateCertificateRequest request = new UpdateCertificateRequest
            {
                Certificate = new Certificate(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Certificate, OperationMetadata> response = certificateManagerClient.UpdateCertificate(request);

            // Poll until the returned long-running operation is complete
            Operation<Certificate, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Certificate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Certificate, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceUpdateCertificate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Certificate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificateAsync</summary>
        public async Task UpdateCertificateRequestObjectAsync()
        {
            // Snippet: UpdateCertificateAsync(UpdateCertificateRequest, CallSettings)
            // Additional: UpdateCertificateAsync(UpdateCertificateRequest, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCertificateRequest request = new UpdateCertificateRequest
            {
                Certificate = new Certificate(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Certificate, OperationMetadata> response = await certificateManagerClient.UpdateCertificateAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Certificate, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Certificate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Certificate, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceUpdateCertificateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Certificate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificate</summary>
        public void UpdateCertificate()
        {
            // Snippet: UpdateCertificate(Certificate, FieldMask, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            Certificate certificate = new Certificate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Certificate, OperationMetadata> response = certificateManagerClient.UpdateCertificate(certificate, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Certificate, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Certificate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Certificate, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceUpdateCertificate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Certificate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificateAsync</summary>
        public async Task UpdateCertificateAsync()
        {
            // Snippet: UpdateCertificateAsync(Certificate, FieldMask, CallSettings)
            // Additional: UpdateCertificateAsync(Certificate, FieldMask, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            Certificate certificate = new Certificate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Certificate, OperationMetadata> response = await certificateManagerClient.UpdateCertificateAsync(certificate, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Certificate, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Certificate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Certificate, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceUpdateCertificateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Certificate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificate</summary>
        public void DeleteCertificateRequestObject()
        {
            // Snippet: DeleteCertificate(DeleteCertificateRequest, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            DeleteCertificateRequest request = new DeleteCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = certificateManagerClient.DeleteCertificate(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceDeleteCertificate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateAsync</summary>
        public async Task DeleteCertificateRequestObjectAsync()
        {
            // Snippet: DeleteCertificateAsync(DeleteCertificateRequest, CallSettings)
            // Additional: DeleteCertificateAsync(DeleteCertificateRequest, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCertificateRequest request = new DeleteCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await certificateManagerClient.DeleteCertificateAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceDeleteCertificateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificate</summary>
        public void DeleteCertificate()
        {
            // Snippet: DeleteCertificate(string, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificates/[CERTIFICATE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = certificateManagerClient.DeleteCertificate(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceDeleteCertificate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateAsync</summary>
        public async Task DeleteCertificateAsync()
        {
            // Snippet: DeleteCertificateAsync(string, CallSettings)
            // Additional: DeleteCertificateAsync(string, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificates/[CERTIFICATE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await certificateManagerClient.DeleteCertificateAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceDeleteCertificateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificate</summary>
        public void DeleteCertificateResourceNames()
        {
            // Snippet: DeleteCertificate(CertificateName, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            CertificateName name = CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = certificateManagerClient.DeleteCertificate(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceDeleteCertificate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateAsync</summary>
        public async Task DeleteCertificateResourceNamesAsync()
        {
            // Snippet: DeleteCertificateAsync(CertificateName, CallSettings)
            // Additional: DeleteCertificateAsync(CertificateName, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            CertificateName name = CertificateName.FromProjectLocationCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await certificateManagerClient.DeleteCertificateAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceDeleteCertificateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListCertificateMaps</summary>
        public void ListCertificateMapsRequestObject()
        {
            // Snippet: ListCertificateMaps(ListCertificateMapsRequest, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            ListCertificateMapsRequest request = new ListCertificateMapsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListCertificateMapsResponse, CertificateMap> response = certificateManagerClient.ListCertificateMaps(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CertificateMap item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCertificateMapsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateMap> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateMap item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificateMapsAsync</summary>
        public async Task ListCertificateMapsRequestObjectAsync()
        {
            // Snippet: ListCertificateMapsAsync(ListCertificateMapsRequest, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListCertificateMapsRequest request = new ListCertificateMapsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCertificateMapsResponse, CertificateMap> response = certificateManagerClient.ListCertificateMapsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CertificateMap item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCertificateMapsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateMap> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateMap item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificateMaps</summary>
        public void ListCertificateMaps()
        {
            // Snippet: ListCertificateMaps(string, string, int?, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListCertificateMapsResponse, CertificateMap> response = certificateManagerClient.ListCertificateMaps(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CertificateMap item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCertificateMapsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateMap> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateMap item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificateMapsAsync</summary>
        public async Task ListCertificateMapsAsync()
        {
            // Snippet: ListCertificateMapsAsync(string, string, int?, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListCertificateMapsResponse, CertificateMap> response = certificateManagerClient.ListCertificateMapsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CertificateMap item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCertificateMapsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateMap> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateMap item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificateMaps</summary>
        public void ListCertificateMapsResourceNames()
        {
            // Snippet: ListCertificateMaps(LocationName, string, int?, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListCertificateMapsResponse, CertificateMap> response = certificateManagerClient.ListCertificateMaps(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CertificateMap item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCertificateMapsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateMap> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateMap item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificateMapsAsync</summary>
        public async Task ListCertificateMapsResourceNamesAsync()
        {
            // Snippet: ListCertificateMapsAsync(LocationName, string, int?, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListCertificateMapsResponse, CertificateMap> response = certificateManagerClient.ListCertificateMapsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CertificateMap item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCertificateMapsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateMap> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateMap item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetCertificateMap</summary>
        public void GetCertificateMapRequestObject()
        {
            // Snippet: GetCertificateMap(GetCertificateMapRequest, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            GetCertificateMapRequest request = new GetCertificateMapRequest
            {
                CertificateMapName = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]"),
            };
            // Make the request
            CertificateMap response = certificateManagerClient.GetCertificateMap(request);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateMapAsync</summary>
        public async Task GetCertificateMapRequestObjectAsync()
        {
            // Snippet: GetCertificateMapAsync(GetCertificateMapRequest, CallSettings)
            // Additional: GetCertificateMapAsync(GetCertificateMapRequest, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetCertificateMapRequest request = new GetCertificateMapRequest
            {
                CertificateMapName = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]"),
            };
            // Make the request
            CertificateMap response = await certificateManagerClient.GetCertificateMapAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateMap</summary>
        public void GetCertificateMap()
        {
            // Snippet: GetCertificateMap(string, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateMaps/[CERTIFICATE_MAP]";
            // Make the request
            CertificateMap response = certificateManagerClient.GetCertificateMap(name);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateMapAsync</summary>
        public async Task GetCertificateMapAsync()
        {
            // Snippet: GetCertificateMapAsync(string, CallSettings)
            // Additional: GetCertificateMapAsync(string, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateMaps/[CERTIFICATE_MAP]";
            // Make the request
            CertificateMap response = await certificateManagerClient.GetCertificateMapAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateMap</summary>
        public void GetCertificateMapResourceNames()
        {
            // Snippet: GetCertificateMap(CertificateMapName, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            CertificateMapName name = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]");
            // Make the request
            CertificateMap response = certificateManagerClient.GetCertificateMap(name);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateMapAsync</summary>
        public async Task GetCertificateMapResourceNamesAsync()
        {
            // Snippet: GetCertificateMapAsync(CertificateMapName, CallSettings)
            // Additional: GetCertificateMapAsync(CertificateMapName, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            CertificateMapName name = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]");
            // Make the request
            CertificateMap response = await certificateManagerClient.GetCertificateMapAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateMap</summary>
        public void CreateCertificateMapRequestObject()
        {
            // Snippet: CreateCertificateMap(CreateCertificateMapRequest, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            CreateCertificateMapRequest request = new CreateCertificateMapRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CertificateMapId = "",
                CertificateMap = new CertificateMap(),
            };
            // Make the request
            Operation<CertificateMap, OperationMetadata> response = certificateManagerClient.CreateCertificateMap(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateMap, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateMap result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateMap, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceCreateCertificateMap(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateMap retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateMapAsync</summary>
        public async Task CreateCertificateMapRequestObjectAsync()
        {
            // Snippet: CreateCertificateMapAsync(CreateCertificateMapRequest, CallSettings)
            // Additional: CreateCertificateMapAsync(CreateCertificateMapRequest, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateCertificateMapRequest request = new CreateCertificateMapRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CertificateMapId = "",
                CertificateMap = new CertificateMap(),
            };
            // Make the request
            Operation<CertificateMap, OperationMetadata> response = await certificateManagerClient.CreateCertificateMapAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateMap, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateMap result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateMap, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceCreateCertificateMapAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateMap retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateMap</summary>
        public void CreateCertificateMap()
        {
            // Snippet: CreateCertificateMap(string, CertificateMap, string, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CertificateMap certificateMap = new CertificateMap();
            string certificateMapId = "";
            // Make the request
            Operation<CertificateMap, OperationMetadata> response = certificateManagerClient.CreateCertificateMap(parent, certificateMap, certificateMapId);

            // Poll until the returned long-running operation is complete
            Operation<CertificateMap, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateMap result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateMap, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceCreateCertificateMap(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateMap retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateMapAsync</summary>
        public async Task CreateCertificateMapAsync()
        {
            // Snippet: CreateCertificateMapAsync(string, CertificateMap, string, CallSettings)
            // Additional: CreateCertificateMapAsync(string, CertificateMap, string, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CertificateMap certificateMap = new CertificateMap();
            string certificateMapId = "";
            // Make the request
            Operation<CertificateMap, OperationMetadata> response = await certificateManagerClient.CreateCertificateMapAsync(parent, certificateMap, certificateMapId);

            // Poll until the returned long-running operation is complete
            Operation<CertificateMap, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateMap result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateMap, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceCreateCertificateMapAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateMap retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateMap</summary>
        public void CreateCertificateMapResourceNames()
        {
            // Snippet: CreateCertificateMap(LocationName, CertificateMap, string, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CertificateMap certificateMap = new CertificateMap();
            string certificateMapId = "";
            // Make the request
            Operation<CertificateMap, OperationMetadata> response = certificateManagerClient.CreateCertificateMap(parent, certificateMap, certificateMapId);

            // Poll until the returned long-running operation is complete
            Operation<CertificateMap, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateMap result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateMap, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceCreateCertificateMap(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateMap retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateMapAsync</summary>
        public async Task CreateCertificateMapResourceNamesAsync()
        {
            // Snippet: CreateCertificateMapAsync(LocationName, CertificateMap, string, CallSettings)
            // Additional: CreateCertificateMapAsync(LocationName, CertificateMap, string, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CertificateMap certificateMap = new CertificateMap();
            string certificateMapId = "";
            // Make the request
            Operation<CertificateMap, OperationMetadata> response = await certificateManagerClient.CreateCertificateMapAsync(parent, certificateMap, certificateMapId);

            // Poll until the returned long-running operation is complete
            Operation<CertificateMap, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateMap result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateMap, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceCreateCertificateMapAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateMap retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificateMap</summary>
        public void UpdateCertificateMapRequestObject()
        {
            // Snippet: UpdateCertificateMap(UpdateCertificateMapRequest, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            UpdateCertificateMapRequest request = new UpdateCertificateMapRequest
            {
                CertificateMap = new CertificateMap(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<CertificateMap, OperationMetadata> response = certificateManagerClient.UpdateCertificateMap(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateMap, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateMap result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateMap, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceUpdateCertificateMap(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateMap retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificateMapAsync</summary>
        public async Task UpdateCertificateMapRequestObjectAsync()
        {
            // Snippet: UpdateCertificateMapAsync(UpdateCertificateMapRequest, CallSettings)
            // Additional: UpdateCertificateMapAsync(UpdateCertificateMapRequest, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCertificateMapRequest request = new UpdateCertificateMapRequest
            {
                CertificateMap = new CertificateMap(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<CertificateMap, OperationMetadata> response = await certificateManagerClient.UpdateCertificateMapAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateMap, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateMap result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateMap, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceUpdateCertificateMapAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateMap retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificateMap</summary>
        public void UpdateCertificateMap()
        {
            // Snippet: UpdateCertificateMap(CertificateMap, FieldMask, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            CertificateMap certificateMap = new CertificateMap();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<CertificateMap, OperationMetadata> response = certificateManagerClient.UpdateCertificateMap(certificateMap, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<CertificateMap, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateMap result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateMap, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceUpdateCertificateMap(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateMap retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificateMapAsync</summary>
        public async Task UpdateCertificateMapAsync()
        {
            // Snippet: UpdateCertificateMapAsync(CertificateMap, FieldMask, CallSettings)
            // Additional: UpdateCertificateMapAsync(CertificateMap, FieldMask, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            CertificateMap certificateMap = new CertificateMap();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<CertificateMap, OperationMetadata> response = await certificateManagerClient.UpdateCertificateMapAsync(certificateMap, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<CertificateMap, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateMap result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateMap, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceUpdateCertificateMapAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateMap retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateMap</summary>
        public void DeleteCertificateMapRequestObject()
        {
            // Snippet: DeleteCertificateMap(DeleteCertificateMapRequest, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            DeleteCertificateMapRequest request = new DeleteCertificateMapRequest
            {
                CertificateMapName = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = certificateManagerClient.DeleteCertificateMap(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceDeleteCertificateMap(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateMapAsync</summary>
        public async Task DeleteCertificateMapRequestObjectAsync()
        {
            // Snippet: DeleteCertificateMapAsync(DeleteCertificateMapRequest, CallSettings)
            // Additional: DeleteCertificateMapAsync(DeleteCertificateMapRequest, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCertificateMapRequest request = new DeleteCertificateMapRequest
            {
                CertificateMapName = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await certificateManagerClient.DeleteCertificateMapAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceDeleteCertificateMapAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateMap</summary>
        public void DeleteCertificateMap()
        {
            // Snippet: DeleteCertificateMap(string, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateMaps/[CERTIFICATE_MAP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = certificateManagerClient.DeleteCertificateMap(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceDeleteCertificateMap(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateMapAsync</summary>
        public async Task DeleteCertificateMapAsync()
        {
            // Snippet: DeleteCertificateMapAsync(string, CallSettings)
            // Additional: DeleteCertificateMapAsync(string, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateMaps/[CERTIFICATE_MAP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await certificateManagerClient.DeleteCertificateMapAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceDeleteCertificateMapAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateMap</summary>
        public void DeleteCertificateMapResourceNames()
        {
            // Snippet: DeleteCertificateMap(CertificateMapName, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            CertificateMapName name = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = certificateManagerClient.DeleteCertificateMap(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceDeleteCertificateMap(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateMapAsync</summary>
        public async Task DeleteCertificateMapResourceNamesAsync()
        {
            // Snippet: DeleteCertificateMapAsync(CertificateMapName, CallSettings)
            // Additional: DeleteCertificateMapAsync(CertificateMapName, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            CertificateMapName name = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await certificateManagerClient.DeleteCertificateMapAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceDeleteCertificateMapAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListCertificateMapEntries</summary>
        public void ListCertificateMapEntriesRequestObject()
        {
            // Snippet: ListCertificateMapEntries(ListCertificateMapEntriesRequest, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            ListCertificateMapEntriesRequest request = new ListCertificateMapEntriesRequest
            {
                ParentAsCertificateMapName = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListCertificateMapEntriesResponse, CertificateMapEntry> response = certificateManagerClient.ListCertificateMapEntries(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CertificateMapEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCertificateMapEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateMapEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateMapEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateMapEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificateMapEntriesAsync</summary>
        public async Task ListCertificateMapEntriesRequestObjectAsync()
        {
            // Snippet: ListCertificateMapEntriesAsync(ListCertificateMapEntriesRequest, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListCertificateMapEntriesRequest request = new ListCertificateMapEntriesRequest
            {
                ParentAsCertificateMapName = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCertificateMapEntriesResponse, CertificateMapEntry> response = certificateManagerClient.ListCertificateMapEntriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CertificateMapEntry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCertificateMapEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateMapEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateMapEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateMapEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificateMapEntries</summary>
        public void ListCertificateMapEntries()
        {
            // Snippet: ListCertificateMapEntries(string, string, int?, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/certificateMaps/[CERTIFICATE_MAP]";
            // Make the request
            PagedEnumerable<ListCertificateMapEntriesResponse, CertificateMapEntry> response = certificateManagerClient.ListCertificateMapEntries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CertificateMapEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCertificateMapEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateMapEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateMapEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateMapEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificateMapEntriesAsync</summary>
        public async Task ListCertificateMapEntriesAsync()
        {
            // Snippet: ListCertificateMapEntriesAsync(string, string, int?, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/certificateMaps/[CERTIFICATE_MAP]";
            // Make the request
            PagedAsyncEnumerable<ListCertificateMapEntriesResponse, CertificateMapEntry> response = certificateManagerClient.ListCertificateMapEntriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CertificateMapEntry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCertificateMapEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateMapEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateMapEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateMapEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificateMapEntries</summary>
        public void ListCertificateMapEntriesResourceNames()
        {
            // Snippet: ListCertificateMapEntries(CertificateMapName, string, int?, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            CertificateMapName parent = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]");
            // Make the request
            PagedEnumerable<ListCertificateMapEntriesResponse, CertificateMapEntry> response = certificateManagerClient.ListCertificateMapEntries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CertificateMapEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCertificateMapEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateMapEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateMapEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateMapEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificateMapEntriesAsync</summary>
        public async Task ListCertificateMapEntriesResourceNamesAsync()
        {
            // Snippet: ListCertificateMapEntriesAsync(CertificateMapName, string, int?, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            CertificateMapName parent = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]");
            // Make the request
            PagedAsyncEnumerable<ListCertificateMapEntriesResponse, CertificateMapEntry> response = certificateManagerClient.ListCertificateMapEntriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CertificateMapEntry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCertificateMapEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateMapEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateMapEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateMapEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetCertificateMapEntry</summary>
        public void GetCertificateMapEntryRequestObject()
        {
            // Snippet: GetCertificateMapEntry(GetCertificateMapEntryRequest, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            GetCertificateMapEntryRequest request = new GetCertificateMapEntryRequest
            {
                CertificateMapEntryName = CertificateMapEntryName.FromProjectLocationCertificateMapCertificateMapEntry("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]", "[CERTIFICATE_MAP_ENTRY]"),
            };
            // Make the request
            CertificateMapEntry response = certificateManagerClient.GetCertificateMapEntry(request);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateMapEntryAsync</summary>
        public async Task GetCertificateMapEntryRequestObjectAsync()
        {
            // Snippet: GetCertificateMapEntryAsync(GetCertificateMapEntryRequest, CallSettings)
            // Additional: GetCertificateMapEntryAsync(GetCertificateMapEntryRequest, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetCertificateMapEntryRequest request = new GetCertificateMapEntryRequest
            {
                CertificateMapEntryName = CertificateMapEntryName.FromProjectLocationCertificateMapCertificateMapEntry("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]", "[CERTIFICATE_MAP_ENTRY]"),
            };
            // Make the request
            CertificateMapEntry response = await certificateManagerClient.GetCertificateMapEntryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateMapEntry</summary>
        public void GetCertificateMapEntry()
        {
            // Snippet: GetCertificateMapEntry(string, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateMaps/[CERTIFICATE_MAP]/certificateMapEntries/[CERTIFICATE_MAP_ENTRY]";
            // Make the request
            CertificateMapEntry response = certificateManagerClient.GetCertificateMapEntry(name);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateMapEntryAsync</summary>
        public async Task GetCertificateMapEntryAsync()
        {
            // Snippet: GetCertificateMapEntryAsync(string, CallSettings)
            // Additional: GetCertificateMapEntryAsync(string, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateMaps/[CERTIFICATE_MAP]/certificateMapEntries/[CERTIFICATE_MAP_ENTRY]";
            // Make the request
            CertificateMapEntry response = await certificateManagerClient.GetCertificateMapEntryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateMapEntry</summary>
        public void GetCertificateMapEntryResourceNames()
        {
            // Snippet: GetCertificateMapEntry(CertificateMapEntryName, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            CertificateMapEntryName name = CertificateMapEntryName.FromProjectLocationCertificateMapCertificateMapEntry("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]", "[CERTIFICATE_MAP_ENTRY]");
            // Make the request
            CertificateMapEntry response = certificateManagerClient.GetCertificateMapEntry(name);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateMapEntryAsync</summary>
        public async Task GetCertificateMapEntryResourceNamesAsync()
        {
            // Snippet: GetCertificateMapEntryAsync(CertificateMapEntryName, CallSettings)
            // Additional: GetCertificateMapEntryAsync(CertificateMapEntryName, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            CertificateMapEntryName name = CertificateMapEntryName.FromProjectLocationCertificateMapCertificateMapEntry("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]", "[CERTIFICATE_MAP_ENTRY]");
            // Make the request
            CertificateMapEntry response = await certificateManagerClient.GetCertificateMapEntryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateMapEntry</summary>
        public void CreateCertificateMapEntryRequestObject()
        {
            // Snippet: CreateCertificateMapEntry(CreateCertificateMapEntryRequest, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            CreateCertificateMapEntryRequest request = new CreateCertificateMapEntryRequest
            {
                ParentAsCertificateMapName = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]"),
                CertificateMapEntryId = "",
                CertificateMapEntry = new CertificateMapEntry(),
            };
            // Make the request
            Operation<CertificateMapEntry, OperationMetadata> response = certificateManagerClient.CreateCertificateMapEntry(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateMapEntry, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateMapEntry result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateMapEntry, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceCreateCertificateMapEntry(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateMapEntry retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateMapEntryAsync</summary>
        public async Task CreateCertificateMapEntryRequestObjectAsync()
        {
            // Snippet: CreateCertificateMapEntryAsync(CreateCertificateMapEntryRequest, CallSettings)
            // Additional: CreateCertificateMapEntryAsync(CreateCertificateMapEntryRequest, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateCertificateMapEntryRequest request = new CreateCertificateMapEntryRequest
            {
                ParentAsCertificateMapName = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]"),
                CertificateMapEntryId = "",
                CertificateMapEntry = new CertificateMapEntry(),
            };
            // Make the request
            Operation<CertificateMapEntry, OperationMetadata> response = await certificateManagerClient.CreateCertificateMapEntryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateMapEntry, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateMapEntry result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateMapEntry, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceCreateCertificateMapEntryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateMapEntry retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateMapEntry</summary>
        public void CreateCertificateMapEntry()
        {
            // Snippet: CreateCertificateMapEntry(string, CertificateMapEntry, string, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/certificateMaps/[CERTIFICATE_MAP]";
            CertificateMapEntry certificateMapEntry = new CertificateMapEntry();
            string certificateMapEntryId = "";
            // Make the request
            Operation<CertificateMapEntry, OperationMetadata> response = certificateManagerClient.CreateCertificateMapEntry(parent, certificateMapEntry, certificateMapEntryId);

            // Poll until the returned long-running operation is complete
            Operation<CertificateMapEntry, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateMapEntry result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateMapEntry, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceCreateCertificateMapEntry(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateMapEntry retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateMapEntryAsync</summary>
        public async Task CreateCertificateMapEntryAsync()
        {
            // Snippet: CreateCertificateMapEntryAsync(string, CertificateMapEntry, string, CallSettings)
            // Additional: CreateCertificateMapEntryAsync(string, CertificateMapEntry, string, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/certificateMaps/[CERTIFICATE_MAP]";
            CertificateMapEntry certificateMapEntry = new CertificateMapEntry();
            string certificateMapEntryId = "";
            // Make the request
            Operation<CertificateMapEntry, OperationMetadata> response = await certificateManagerClient.CreateCertificateMapEntryAsync(parent, certificateMapEntry, certificateMapEntryId);

            // Poll until the returned long-running operation is complete
            Operation<CertificateMapEntry, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateMapEntry result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateMapEntry, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceCreateCertificateMapEntryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateMapEntry retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateMapEntry</summary>
        public void CreateCertificateMapEntryResourceNames()
        {
            // Snippet: CreateCertificateMapEntry(CertificateMapName, CertificateMapEntry, string, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            CertificateMapName parent = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]");
            CertificateMapEntry certificateMapEntry = new CertificateMapEntry();
            string certificateMapEntryId = "";
            // Make the request
            Operation<CertificateMapEntry, OperationMetadata> response = certificateManagerClient.CreateCertificateMapEntry(parent, certificateMapEntry, certificateMapEntryId);

            // Poll until the returned long-running operation is complete
            Operation<CertificateMapEntry, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateMapEntry result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateMapEntry, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceCreateCertificateMapEntry(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateMapEntry retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateMapEntryAsync</summary>
        public async Task CreateCertificateMapEntryResourceNamesAsync()
        {
            // Snippet: CreateCertificateMapEntryAsync(CertificateMapName, CertificateMapEntry, string, CallSettings)
            // Additional: CreateCertificateMapEntryAsync(CertificateMapName, CertificateMapEntry, string, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            CertificateMapName parent = CertificateMapName.FromProjectLocationCertificateMap("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]");
            CertificateMapEntry certificateMapEntry = new CertificateMapEntry();
            string certificateMapEntryId = "";
            // Make the request
            Operation<CertificateMapEntry, OperationMetadata> response = await certificateManagerClient.CreateCertificateMapEntryAsync(parent, certificateMapEntry, certificateMapEntryId);

            // Poll until the returned long-running operation is complete
            Operation<CertificateMapEntry, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateMapEntry result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateMapEntry, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceCreateCertificateMapEntryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateMapEntry retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificateMapEntry</summary>
        public void UpdateCertificateMapEntryRequestObject()
        {
            // Snippet: UpdateCertificateMapEntry(UpdateCertificateMapEntryRequest, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            UpdateCertificateMapEntryRequest request = new UpdateCertificateMapEntryRequest
            {
                CertificateMapEntry = new CertificateMapEntry(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<CertificateMapEntry, OperationMetadata> response = certificateManagerClient.UpdateCertificateMapEntry(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateMapEntry, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateMapEntry result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateMapEntry, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceUpdateCertificateMapEntry(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateMapEntry retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificateMapEntryAsync</summary>
        public async Task UpdateCertificateMapEntryRequestObjectAsync()
        {
            // Snippet: UpdateCertificateMapEntryAsync(UpdateCertificateMapEntryRequest, CallSettings)
            // Additional: UpdateCertificateMapEntryAsync(UpdateCertificateMapEntryRequest, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCertificateMapEntryRequest request = new UpdateCertificateMapEntryRequest
            {
                CertificateMapEntry = new CertificateMapEntry(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<CertificateMapEntry, OperationMetadata> response = await certificateManagerClient.UpdateCertificateMapEntryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateMapEntry, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateMapEntry result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateMapEntry, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceUpdateCertificateMapEntryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateMapEntry retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificateMapEntry</summary>
        public void UpdateCertificateMapEntry()
        {
            // Snippet: UpdateCertificateMapEntry(CertificateMapEntry, FieldMask, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            CertificateMapEntry certificateMapEntry = new CertificateMapEntry();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<CertificateMapEntry, OperationMetadata> response = certificateManagerClient.UpdateCertificateMapEntry(certificateMapEntry, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<CertificateMapEntry, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateMapEntry result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateMapEntry, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceUpdateCertificateMapEntry(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateMapEntry retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificateMapEntryAsync</summary>
        public async Task UpdateCertificateMapEntryAsync()
        {
            // Snippet: UpdateCertificateMapEntryAsync(CertificateMapEntry, FieldMask, CallSettings)
            // Additional: UpdateCertificateMapEntryAsync(CertificateMapEntry, FieldMask, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            CertificateMapEntry certificateMapEntry = new CertificateMapEntry();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<CertificateMapEntry, OperationMetadata> response = await certificateManagerClient.UpdateCertificateMapEntryAsync(certificateMapEntry, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<CertificateMapEntry, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateMapEntry result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateMapEntry, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceUpdateCertificateMapEntryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateMapEntry retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateMapEntry</summary>
        public void DeleteCertificateMapEntryRequestObject()
        {
            // Snippet: DeleteCertificateMapEntry(DeleteCertificateMapEntryRequest, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            DeleteCertificateMapEntryRequest request = new DeleteCertificateMapEntryRequest
            {
                CertificateMapEntryName = CertificateMapEntryName.FromProjectLocationCertificateMapCertificateMapEntry("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]", "[CERTIFICATE_MAP_ENTRY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = certificateManagerClient.DeleteCertificateMapEntry(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceDeleteCertificateMapEntry(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateMapEntryAsync</summary>
        public async Task DeleteCertificateMapEntryRequestObjectAsync()
        {
            // Snippet: DeleteCertificateMapEntryAsync(DeleteCertificateMapEntryRequest, CallSettings)
            // Additional: DeleteCertificateMapEntryAsync(DeleteCertificateMapEntryRequest, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCertificateMapEntryRequest request = new DeleteCertificateMapEntryRequest
            {
                CertificateMapEntryName = CertificateMapEntryName.FromProjectLocationCertificateMapCertificateMapEntry("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]", "[CERTIFICATE_MAP_ENTRY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await certificateManagerClient.DeleteCertificateMapEntryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceDeleteCertificateMapEntryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateMapEntry</summary>
        public void DeleteCertificateMapEntry()
        {
            // Snippet: DeleteCertificateMapEntry(string, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateMaps/[CERTIFICATE_MAP]/certificateMapEntries/[CERTIFICATE_MAP_ENTRY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = certificateManagerClient.DeleteCertificateMapEntry(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceDeleteCertificateMapEntry(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateMapEntryAsync</summary>
        public async Task DeleteCertificateMapEntryAsync()
        {
            // Snippet: DeleteCertificateMapEntryAsync(string, CallSettings)
            // Additional: DeleteCertificateMapEntryAsync(string, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateMaps/[CERTIFICATE_MAP]/certificateMapEntries/[CERTIFICATE_MAP_ENTRY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await certificateManagerClient.DeleteCertificateMapEntryAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceDeleteCertificateMapEntryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateMapEntry</summary>
        public void DeleteCertificateMapEntryResourceNames()
        {
            // Snippet: DeleteCertificateMapEntry(CertificateMapEntryName, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            CertificateMapEntryName name = CertificateMapEntryName.FromProjectLocationCertificateMapCertificateMapEntry("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]", "[CERTIFICATE_MAP_ENTRY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = certificateManagerClient.DeleteCertificateMapEntry(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceDeleteCertificateMapEntry(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateMapEntryAsync</summary>
        public async Task DeleteCertificateMapEntryResourceNamesAsync()
        {
            // Snippet: DeleteCertificateMapEntryAsync(CertificateMapEntryName, CallSettings)
            // Additional: DeleteCertificateMapEntryAsync(CertificateMapEntryName, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            CertificateMapEntryName name = CertificateMapEntryName.FromProjectLocationCertificateMapCertificateMapEntry("[PROJECT]", "[LOCATION]", "[CERTIFICATE_MAP]", "[CERTIFICATE_MAP_ENTRY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await certificateManagerClient.DeleteCertificateMapEntryAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceDeleteCertificateMapEntryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListDnsAuthorizations</summary>
        public void ListDnsAuthorizationsRequestObject()
        {
            // Snippet: ListDnsAuthorizations(ListDnsAuthorizationsRequest, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            ListDnsAuthorizationsRequest request = new ListDnsAuthorizationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListDnsAuthorizationsResponse, DnsAuthorization> response = certificateManagerClient.ListDnsAuthorizations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DnsAuthorization item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDnsAuthorizationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DnsAuthorization item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DnsAuthorization> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DnsAuthorization item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDnsAuthorizationsAsync</summary>
        public async Task ListDnsAuthorizationsRequestObjectAsync()
        {
            // Snippet: ListDnsAuthorizationsAsync(ListDnsAuthorizationsRequest, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListDnsAuthorizationsRequest request = new ListDnsAuthorizationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDnsAuthorizationsResponse, DnsAuthorization> response = certificateManagerClient.ListDnsAuthorizationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DnsAuthorization item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDnsAuthorizationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DnsAuthorization item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DnsAuthorization> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DnsAuthorization item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDnsAuthorizations</summary>
        public void ListDnsAuthorizations()
        {
            // Snippet: ListDnsAuthorizations(string, string, int?, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDnsAuthorizationsResponse, DnsAuthorization> response = certificateManagerClient.ListDnsAuthorizations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DnsAuthorization item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDnsAuthorizationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DnsAuthorization item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DnsAuthorization> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DnsAuthorization item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDnsAuthorizationsAsync</summary>
        public async Task ListDnsAuthorizationsAsync()
        {
            // Snippet: ListDnsAuthorizationsAsync(string, string, int?, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDnsAuthorizationsResponse, DnsAuthorization> response = certificateManagerClient.ListDnsAuthorizationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DnsAuthorization item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDnsAuthorizationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DnsAuthorization item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DnsAuthorization> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DnsAuthorization item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDnsAuthorizations</summary>
        public void ListDnsAuthorizationsResourceNames()
        {
            // Snippet: ListDnsAuthorizations(LocationName, string, int?, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDnsAuthorizationsResponse, DnsAuthorization> response = certificateManagerClient.ListDnsAuthorizations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DnsAuthorization item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDnsAuthorizationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DnsAuthorization item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DnsAuthorization> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DnsAuthorization item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDnsAuthorizationsAsync</summary>
        public async Task ListDnsAuthorizationsResourceNamesAsync()
        {
            // Snippet: ListDnsAuthorizationsAsync(LocationName, string, int?, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDnsAuthorizationsResponse, DnsAuthorization> response = certificateManagerClient.ListDnsAuthorizationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DnsAuthorization item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDnsAuthorizationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DnsAuthorization item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DnsAuthorization> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DnsAuthorization item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDnsAuthorization</summary>
        public void GetDnsAuthorizationRequestObject()
        {
            // Snippet: GetDnsAuthorization(GetDnsAuthorizationRequest, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            GetDnsAuthorizationRequest request = new GetDnsAuthorizationRequest
            {
                DnsAuthorizationName = DnsAuthorizationName.FromProjectLocationDnsAuthorization("[PROJECT]", "[LOCATION]", "[DNS_AUTHORIZATION]"),
            };
            // Make the request
            DnsAuthorization response = certificateManagerClient.GetDnsAuthorization(request);
            // End snippet
        }

        /// <summary>Snippet for GetDnsAuthorizationAsync</summary>
        public async Task GetDnsAuthorizationRequestObjectAsync()
        {
            // Snippet: GetDnsAuthorizationAsync(GetDnsAuthorizationRequest, CallSettings)
            // Additional: GetDnsAuthorizationAsync(GetDnsAuthorizationRequest, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetDnsAuthorizationRequest request = new GetDnsAuthorizationRequest
            {
                DnsAuthorizationName = DnsAuthorizationName.FromProjectLocationDnsAuthorization("[PROJECT]", "[LOCATION]", "[DNS_AUTHORIZATION]"),
            };
            // Make the request
            DnsAuthorization response = await certificateManagerClient.GetDnsAuthorizationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDnsAuthorization</summary>
        public void GetDnsAuthorization()
        {
            // Snippet: GetDnsAuthorization(string, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dnsAuthorizations/[DNS_AUTHORIZATION]";
            // Make the request
            DnsAuthorization response = certificateManagerClient.GetDnsAuthorization(name);
            // End snippet
        }

        /// <summary>Snippet for GetDnsAuthorizationAsync</summary>
        public async Task GetDnsAuthorizationAsync()
        {
            // Snippet: GetDnsAuthorizationAsync(string, CallSettings)
            // Additional: GetDnsAuthorizationAsync(string, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dnsAuthorizations/[DNS_AUTHORIZATION]";
            // Make the request
            DnsAuthorization response = await certificateManagerClient.GetDnsAuthorizationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDnsAuthorization</summary>
        public void GetDnsAuthorizationResourceNames()
        {
            // Snippet: GetDnsAuthorization(DnsAuthorizationName, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            DnsAuthorizationName name = DnsAuthorizationName.FromProjectLocationDnsAuthorization("[PROJECT]", "[LOCATION]", "[DNS_AUTHORIZATION]");
            // Make the request
            DnsAuthorization response = certificateManagerClient.GetDnsAuthorization(name);
            // End snippet
        }

        /// <summary>Snippet for GetDnsAuthorizationAsync</summary>
        public async Task GetDnsAuthorizationResourceNamesAsync()
        {
            // Snippet: GetDnsAuthorizationAsync(DnsAuthorizationName, CallSettings)
            // Additional: GetDnsAuthorizationAsync(DnsAuthorizationName, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            DnsAuthorizationName name = DnsAuthorizationName.FromProjectLocationDnsAuthorization("[PROJECT]", "[LOCATION]", "[DNS_AUTHORIZATION]");
            // Make the request
            DnsAuthorization response = await certificateManagerClient.GetDnsAuthorizationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDnsAuthorization</summary>
        public void CreateDnsAuthorizationRequestObject()
        {
            // Snippet: CreateDnsAuthorization(CreateDnsAuthorizationRequest, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            CreateDnsAuthorizationRequest request = new CreateDnsAuthorizationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DnsAuthorizationId = "",
                DnsAuthorization = new DnsAuthorization(),
            };
            // Make the request
            Operation<DnsAuthorization, OperationMetadata> response = certificateManagerClient.CreateDnsAuthorization(request);

            // Poll until the returned long-running operation is complete
            Operation<DnsAuthorization, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DnsAuthorization result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsAuthorization, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceCreateDnsAuthorization(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsAuthorization retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDnsAuthorizationAsync</summary>
        public async Task CreateDnsAuthorizationRequestObjectAsync()
        {
            // Snippet: CreateDnsAuthorizationAsync(CreateDnsAuthorizationRequest, CallSettings)
            // Additional: CreateDnsAuthorizationAsync(CreateDnsAuthorizationRequest, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateDnsAuthorizationRequest request = new CreateDnsAuthorizationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DnsAuthorizationId = "",
                DnsAuthorization = new DnsAuthorization(),
            };
            // Make the request
            Operation<DnsAuthorization, OperationMetadata> response = await certificateManagerClient.CreateDnsAuthorizationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DnsAuthorization, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DnsAuthorization result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsAuthorization, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceCreateDnsAuthorizationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsAuthorization retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDnsAuthorization</summary>
        public void CreateDnsAuthorization()
        {
            // Snippet: CreateDnsAuthorization(string, DnsAuthorization, string, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DnsAuthorization dnsAuthorization = new DnsAuthorization();
            string dnsAuthorizationId = "";
            // Make the request
            Operation<DnsAuthorization, OperationMetadata> response = certificateManagerClient.CreateDnsAuthorization(parent, dnsAuthorization, dnsAuthorizationId);

            // Poll until the returned long-running operation is complete
            Operation<DnsAuthorization, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DnsAuthorization result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsAuthorization, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceCreateDnsAuthorization(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsAuthorization retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDnsAuthorizationAsync</summary>
        public async Task CreateDnsAuthorizationAsync()
        {
            // Snippet: CreateDnsAuthorizationAsync(string, DnsAuthorization, string, CallSettings)
            // Additional: CreateDnsAuthorizationAsync(string, DnsAuthorization, string, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DnsAuthorization dnsAuthorization = new DnsAuthorization();
            string dnsAuthorizationId = "";
            // Make the request
            Operation<DnsAuthorization, OperationMetadata> response = await certificateManagerClient.CreateDnsAuthorizationAsync(parent, dnsAuthorization, dnsAuthorizationId);

            // Poll until the returned long-running operation is complete
            Operation<DnsAuthorization, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DnsAuthorization result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsAuthorization, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceCreateDnsAuthorizationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsAuthorization retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDnsAuthorization</summary>
        public void CreateDnsAuthorizationResourceNames()
        {
            // Snippet: CreateDnsAuthorization(LocationName, DnsAuthorization, string, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DnsAuthorization dnsAuthorization = new DnsAuthorization();
            string dnsAuthorizationId = "";
            // Make the request
            Operation<DnsAuthorization, OperationMetadata> response = certificateManagerClient.CreateDnsAuthorization(parent, dnsAuthorization, dnsAuthorizationId);

            // Poll until the returned long-running operation is complete
            Operation<DnsAuthorization, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DnsAuthorization result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsAuthorization, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceCreateDnsAuthorization(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsAuthorization retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDnsAuthorizationAsync</summary>
        public async Task CreateDnsAuthorizationResourceNamesAsync()
        {
            // Snippet: CreateDnsAuthorizationAsync(LocationName, DnsAuthorization, string, CallSettings)
            // Additional: CreateDnsAuthorizationAsync(LocationName, DnsAuthorization, string, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DnsAuthorization dnsAuthorization = new DnsAuthorization();
            string dnsAuthorizationId = "";
            // Make the request
            Operation<DnsAuthorization, OperationMetadata> response = await certificateManagerClient.CreateDnsAuthorizationAsync(parent, dnsAuthorization, dnsAuthorizationId);

            // Poll until the returned long-running operation is complete
            Operation<DnsAuthorization, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DnsAuthorization result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsAuthorization, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceCreateDnsAuthorizationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsAuthorization retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDnsAuthorization</summary>
        public void UpdateDnsAuthorizationRequestObject()
        {
            // Snippet: UpdateDnsAuthorization(UpdateDnsAuthorizationRequest, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            UpdateDnsAuthorizationRequest request = new UpdateDnsAuthorizationRequest
            {
                DnsAuthorization = new DnsAuthorization(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<DnsAuthorization, OperationMetadata> response = certificateManagerClient.UpdateDnsAuthorization(request);

            // Poll until the returned long-running operation is complete
            Operation<DnsAuthorization, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DnsAuthorization result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsAuthorization, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceUpdateDnsAuthorization(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsAuthorization retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDnsAuthorizationAsync</summary>
        public async Task UpdateDnsAuthorizationRequestObjectAsync()
        {
            // Snippet: UpdateDnsAuthorizationAsync(UpdateDnsAuthorizationRequest, CallSettings)
            // Additional: UpdateDnsAuthorizationAsync(UpdateDnsAuthorizationRequest, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDnsAuthorizationRequest request = new UpdateDnsAuthorizationRequest
            {
                DnsAuthorization = new DnsAuthorization(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<DnsAuthorization, OperationMetadata> response = await certificateManagerClient.UpdateDnsAuthorizationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DnsAuthorization, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DnsAuthorization result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsAuthorization, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceUpdateDnsAuthorizationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsAuthorization retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDnsAuthorization</summary>
        public void UpdateDnsAuthorization()
        {
            // Snippet: UpdateDnsAuthorization(DnsAuthorization, FieldMask, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            DnsAuthorization dnsAuthorization = new DnsAuthorization();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<DnsAuthorization, OperationMetadata> response = certificateManagerClient.UpdateDnsAuthorization(dnsAuthorization, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<DnsAuthorization, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DnsAuthorization result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsAuthorization, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceUpdateDnsAuthorization(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsAuthorization retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDnsAuthorizationAsync</summary>
        public async Task UpdateDnsAuthorizationAsync()
        {
            // Snippet: UpdateDnsAuthorizationAsync(DnsAuthorization, FieldMask, CallSettings)
            // Additional: UpdateDnsAuthorizationAsync(DnsAuthorization, FieldMask, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            DnsAuthorization dnsAuthorization = new DnsAuthorization();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<DnsAuthorization, OperationMetadata> response = await certificateManagerClient.UpdateDnsAuthorizationAsync(dnsAuthorization, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<DnsAuthorization, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DnsAuthorization result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DnsAuthorization, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceUpdateDnsAuthorizationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DnsAuthorization retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDnsAuthorization</summary>
        public void DeleteDnsAuthorizationRequestObject()
        {
            // Snippet: DeleteDnsAuthorization(DeleteDnsAuthorizationRequest, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            DeleteDnsAuthorizationRequest request = new DeleteDnsAuthorizationRequest
            {
                DnsAuthorizationName = DnsAuthorizationName.FromProjectLocationDnsAuthorization("[PROJECT]", "[LOCATION]", "[DNS_AUTHORIZATION]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = certificateManagerClient.DeleteDnsAuthorization(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceDeleteDnsAuthorization(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDnsAuthorizationAsync</summary>
        public async Task DeleteDnsAuthorizationRequestObjectAsync()
        {
            // Snippet: DeleteDnsAuthorizationAsync(DeleteDnsAuthorizationRequest, CallSettings)
            // Additional: DeleteDnsAuthorizationAsync(DeleteDnsAuthorizationRequest, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDnsAuthorizationRequest request = new DeleteDnsAuthorizationRequest
            {
                DnsAuthorizationName = DnsAuthorizationName.FromProjectLocationDnsAuthorization("[PROJECT]", "[LOCATION]", "[DNS_AUTHORIZATION]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await certificateManagerClient.DeleteDnsAuthorizationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceDeleteDnsAuthorizationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDnsAuthorization</summary>
        public void DeleteDnsAuthorization()
        {
            // Snippet: DeleteDnsAuthorization(string, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dnsAuthorizations/[DNS_AUTHORIZATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = certificateManagerClient.DeleteDnsAuthorization(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceDeleteDnsAuthorization(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDnsAuthorizationAsync</summary>
        public async Task DeleteDnsAuthorizationAsync()
        {
            // Snippet: DeleteDnsAuthorizationAsync(string, CallSettings)
            // Additional: DeleteDnsAuthorizationAsync(string, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dnsAuthorizations/[DNS_AUTHORIZATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await certificateManagerClient.DeleteDnsAuthorizationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceDeleteDnsAuthorizationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDnsAuthorization</summary>
        public void DeleteDnsAuthorizationResourceNames()
        {
            // Snippet: DeleteDnsAuthorization(DnsAuthorizationName, CallSettings)
            // Create client
            CertificateManagerClient certificateManagerClient = CertificateManagerClient.Create();
            // Initialize request argument(s)
            DnsAuthorizationName name = DnsAuthorizationName.FromProjectLocationDnsAuthorization("[PROJECT]", "[LOCATION]", "[DNS_AUTHORIZATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = certificateManagerClient.DeleteDnsAuthorization(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = certificateManagerClient.PollOnceDeleteDnsAuthorization(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDnsAuthorizationAsync</summary>
        public async Task DeleteDnsAuthorizationResourceNamesAsync()
        {
            // Snippet: DeleteDnsAuthorizationAsync(DnsAuthorizationName, CallSettings)
            // Additional: DeleteDnsAuthorizationAsync(DnsAuthorizationName, CancellationToken)
            // Create client
            CertificateManagerClient certificateManagerClient = await CertificateManagerClient.CreateAsync();
            // Initialize request argument(s)
            DnsAuthorizationName name = DnsAuthorizationName.FromProjectLocationDnsAuthorization("[PROJECT]", "[LOCATION]", "[DNS_AUTHORIZATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await certificateManagerClient.DeleteDnsAuthorizationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await certificateManagerClient.PollOnceDeleteDnsAuthorizationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
