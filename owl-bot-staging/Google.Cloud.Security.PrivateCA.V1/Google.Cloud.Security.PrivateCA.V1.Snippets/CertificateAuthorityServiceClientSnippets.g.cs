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
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Security.PrivateCA.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCertificateAuthorityServiceClientSnippets
    {
        /// <summary>Snippet for CreateCertificate</summary>
        public void CreateCertificateRequestObject()
        {
            // Snippet: CreateCertificate(CreateCertificateRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CreateCertificateRequest request = new CreateCertificateRequest
            {
                ParentAsCaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                CertificateId = "",
                Certificate = new Certificate(),
                RequestId = "",
                ValidateOnly = false,
                IssuingCertificateAuthorityId = "",
            };
            // Make the request
            Certificate response = certificateAuthorityServiceClient.CreateCertificate(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateAsync</summary>
        public async Task CreateCertificateRequestObjectAsync()
        {
            // Snippet: CreateCertificateAsync(CreateCertificateRequest, CallSettings)
            // Additional: CreateCertificateAsync(CreateCertificateRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCertificateRequest request = new CreateCertificateRequest
            {
                ParentAsCaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                CertificateId = "",
                Certificate = new Certificate(),
                RequestId = "",
                ValidateOnly = false,
                IssuingCertificateAuthorityId = "",
            };
            // Make the request
            Certificate response = await certificateAuthorityServiceClient.CreateCertificateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCertificate</summary>
        public void CreateCertificate()
        {
            // Snippet: CreateCertificate(string, Certificate, string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]";
            Certificate certificate = new Certificate();
            string certificateId = "";
            // Make the request
            Certificate response = certificateAuthorityServiceClient.CreateCertificate(parent, certificate, certificateId);
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateAsync</summary>
        public async Task CreateCertificateAsync()
        {
            // Snippet: CreateCertificateAsync(string, Certificate, string, CallSettings)
            // Additional: CreateCertificateAsync(string, Certificate, string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]";
            Certificate certificate = new Certificate();
            string certificateId = "";
            // Make the request
            Certificate response = await certificateAuthorityServiceClient.CreateCertificateAsync(parent, certificate, certificateId);
            // End snippet
        }

        /// <summary>Snippet for CreateCertificate</summary>
        public void CreateCertificateResourceNames()
        {
            // Snippet: CreateCertificate(CaPoolName, Certificate, string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CaPoolName parent = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]");
            Certificate certificate = new Certificate();
            string certificateId = "";
            // Make the request
            Certificate response = certificateAuthorityServiceClient.CreateCertificate(parent, certificate, certificateId);
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateAsync</summary>
        public async Task CreateCertificateResourceNamesAsync()
        {
            // Snippet: CreateCertificateAsync(CaPoolName, Certificate, string, CallSettings)
            // Additional: CreateCertificateAsync(CaPoolName, Certificate, string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CaPoolName parent = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]");
            Certificate certificate = new Certificate();
            string certificateId = "";
            // Make the request
            Certificate response = await certificateAuthorityServiceClient.CreateCertificateAsync(parent, certificate, certificateId);
            // End snippet
        }

        /// <summary>Snippet for GetCertificate</summary>
        public void GetCertificateRequestObject()
        {
            // Snippet: GetCertificate(GetCertificateRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
            };
            // Make the request
            Certificate response = certificateAuthorityServiceClient.GetCertificate(request);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateAsync</summary>
        public async Task GetCertificateRequestObjectAsync()
        {
            // Snippet: GetCertificateAsync(GetCertificateRequest, CallSettings)
            // Additional: GetCertificateAsync(GetCertificateRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCertificateRequest request = new GetCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
            };
            // Make the request
            Certificate response = await certificateAuthorityServiceClient.GetCertificateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCertificate</summary>
        public void GetCertificate()
        {
            // Snippet: GetCertificate(string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]/certificates/[CERTIFICATE]";
            // Make the request
            Certificate response = certificateAuthorityServiceClient.GetCertificate(name);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateAsync</summary>
        public async Task GetCertificateAsync()
        {
            // Snippet: GetCertificateAsync(string, CallSettings)
            // Additional: GetCertificateAsync(string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]/certificates/[CERTIFICATE]";
            // Make the request
            Certificate response = await certificateAuthorityServiceClient.GetCertificateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCertificate</summary>
        public void GetCertificateResourceNames()
        {
            // Snippet: GetCertificate(CertificateName, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CertificateName name = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]");
            // Make the request
            Certificate response = certificateAuthorityServiceClient.GetCertificate(name);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateAsync</summary>
        public async Task GetCertificateResourceNamesAsync()
        {
            // Snippet: GetCertificateAsync(CertificateName, CallSettings)
            // Additional: GetCertificateAsync(CertificateName, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CertificateName name = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]");
            // Make the request
            Certificate response = await certificateAuthorityServiceClient.GetCertificateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCertificates</summary>
        public void ListCertificatesRequestObject()
        {
            // Snippet: ListCertificates(ListCertificatesRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            ListCertificatesRequest request = new ListCertificatesRequest
            {
                ParentAsCaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListCertificatesResponse, Certificate> response = certificateAuthorityServiceClient.ListCertificates(request);

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
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCertificatesRequest request = new ListCertificatesRequest
            {
                ParentAsCaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCertificatesResponse, Certificate> response = certificateAuthorityServiceClient.ListCertificatesAsync(request);

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
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]";
            // Make the request
            PagedEnumerable<ListCertificatesResponse, Certificate> response = certificateAuthorityServiceClient.ListCertificates(parent);

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
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]";
            // Make the request
            PagedAsyncEnumerable<ListCertificatesResponse, Certificate> response = certificateAuthorityServiceClient.ListCertificatesAsync(parent);

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
            // Snippet: ListCertificates(CaPoolName, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CaPoolName parent = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]");
            // Make the request
            PagedEnumerable<ListCertificatesResponse, Certificate> response = certificateAuthorityServiceClient.ListCertificates(parent);

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
            // Snippet: ListCertificatesAsync(CaPoolName, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CaPoolName parent = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]");
            // Make the request
            PagedAsyncEnumerable<ListCertificatesResponse, Certificate> response = certificateAuthorityServiceClient.ListCertificatesAsync(parent);

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

        /// <summary>Snippet for RevokeCertificate</summary>
        public void RevokeCertificateRequestObject()
        {
            // Snippet: RevokeCertificate(RevokeCertificateRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            RevokeCertificateRequest request = new RevokeCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                Reason = RevocationReason.Unspecified,
                RequestId = "",
            };
            // Make the request
            Certificate response = certificateAuthorityServiceClient.RevokeCertificate(request);
            // End snippet
        }

        /// <summary>Snippet for RevokeCertificateAsync</summary>
        public async Task RevokeCertificateRequestObjectAsync()
        {
            // Snippet: RevokeCertificateAsync(RevokeCertificateRequest, CallSettings)
            // Additional: RevokeCertificateAsync(RevokeCertificateRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            RevokeCertificateRequest request = new RevokeCertificateRequest
            {
                CertificateName = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]"),
                Reason = RevocationReason.Unspecified,
                RequestId = "",
            };
            // Make the request
            Certificate response = await certificateAuthorityServiceClient.RevokeCertificateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RevokeCertificate</summary>
        public void RevokeCertificate()
        {
            // Snippet: RevokeCertificate(string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]/certificates/[CERTIFICATE]";
            // Make the request
            Certificate response = certificateAuthorityServiceClient.RevokeCertificate(name);
            // End snippet
        }

        /// <summary>Snippet for RevokeCertificateAsync</summary>
        public async Task RevokeCertificateAsync()
        {
            // Snippet: RevokeCertificateAsync(string, CallSettings)
            // Additional: RevokeCertificateAsync(string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]/certificates/[CERTIFICATE]";
            // Make the request
            Certificate response = await certificateAuthorityServiceClient.RevokeCertificateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RevokeCertificate</summary>
        public void RevokeCertificateResourceNames()
        {
            // Snippet: RevokeCertificate(CertificateName, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CertificateName name = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]");
            // Make the request
            Certificate response = certificateAuthorityServiceClient.RevokeCertificate(name);
            // End snippet
        }

        /// <summary>Snippet for RevokeCertificateAsync</summary>
        public async Task RevokeCertificateResourceNamesAsync()
        {
            // Snippet: RevokeCertificateAsync(CertificateName, CallSettings)
            // Additional: RevokeCertificateAsync(CertificateName, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CertificateName name = CertificateName.FromProjectLocationCaPoolCertificate("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE]");
            // Make the request
            Certificate response = await certificateAuthorityServiceClient.RevokeCertificateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificate</summary>
        public void UpdateCertificateRequestObject()
        {
            // Snippet: UpdateCertificate(UpdateCertificateRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            UpdateCertificateRequest request = new UpdateCertificateRequest
            {
                Certificate = new Certificate(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Certificate response = certificateAuthorityServiceClient.UpdateCertificate(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificateAsync</summary>
        public async Task UpdateCertificateRequestObjectAsync()
        {
            // Snippet: UpdateCertificateAsync(UpdateCertificateRequest, CallSettings)
            // Additional: UpdateCertificateAsync(UpdateCertificateRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCertificateRequest request = new UpdateCertificateRequest
            {
                Certificate = new Certificate(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Certificate response = await certificateAuthorityServiceClient.UpdateCertificateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificate</summary>
        public void UpdateCertificate()
        {
            // Snippet: UpdateCertificate(Certificate, FieldMask, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            Certificate certificate = new Certificate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Certificate response = certificateAuthorityServiceClient.UpdateCertificate(certificate, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificateAsync</summary>
        public async Task UpdateCertificateAsync()
        {
            // Snippet: UpdateCertificateAsync(Certificate, FieldMask, CallSettings)
            // Additional: UpdateCertificateAsync(Certificate, FieldMask, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            Certificate certificate = new Certificate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Certificate response = await certificateAuthorityServiceClient.UpdateCertificateAsync(certificate, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ActivateCertificateAuthority</summary>
        public void ActivateCertificateAuthorityRequestObject()
        {
            // Snippet: ActivateCertificateAuthority(ActivateCertificateAuthorityRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            ActivateCertificateAuthorityRequest request = new ActivateCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                PemCaCertificate = "",
                SubordinateConfig = new SubordinateConfig(),
                RequestId = "",
            };
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.ActivateCertificateAuthority(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceActivateCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ActivateCertificateAuthorityAsync</summary>
        public async Task ActivateCertificateAuthorityRequestObjectAsync()
        {
            // Snippet: ActivateCertificateAuthorityAsync(ActivateCertificateAuthorityRequest, CallSettings)
            // Additional: ActivateCertificateAuthorityAsync(ActivateCertificateAuthorityRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            ActivateCertificateAuthorityRequest request = new ActivateCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                PemCaCertificate = "",
                SubordinateConfig = new SubordinateConfig(),
                RequestId = "",
            };
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.ActivateCertificateAuthorityAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceActivateCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ActivateCertificateAuthority</summary>
        public void ActivateCertificateAuthority()
        {
            // Snippet: ActivateCertificateAuthority(string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.ActivateCertificateAuthority(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceActivateCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ActivateCertificateAuthorityAsync</summary>
        public async Task ActivateCertificateAuthorityAsync()
        {
            // Snippet: ActivateCertificateAuthorityAsync(string, CallSettings)
            // Additional: ActivateCertificateAuthorityAsync(string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.ActivateCertificateAuthorityAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceActivateCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ActivateCertificateAuthority</summary>
        public void ActivateCertificateAuthorityResourceNames()
        {
            // Snippet: ActivateCertificateAuthority(CertificateAuthorityName, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]");
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.ActivateCertificateAuthority(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceActivateCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ActivateCertificateAuthorityAsync</summary>
        public async Task ActivateCertificateAuthorityResourceNamesAsync()
        {
            // Snippet: ActivateCertificateAuthorityAsync(CertificateAuthorityName, CallSettings)
            // Additional: ActivateCertificateAuthorityAsync(CertificateAuthorityName, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]");
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.ActivateCertificateAuthorityAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceActivateCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateAuthority</summary>
        public void CreateCertificateAuthorityRequestObject()
        {
            // Snippet: CreateCertificateAuthority(CreateCertificateAuthorityRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CreateCertificateAuthorityRequest request = new CreateCertificateAuthorityRequest
            {
                ParentAsCaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                CertificateAuthorityId = "",
                CertificateAuthority = new CertificateAuthority(),
                RequestId = "",
            };
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.CreateCertificateAuthority(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceCreateCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateAuthorityAsync</summary>
        public async Task CreateCertificateAuthorityRequestObjectAsync()
        {
            // Snippet: CreateCertificateAuthorityAsync(CreateCertificateAuthorityRequest, CallSettings)
            // Additional: CreateCertificateAuthorityAsync(CreateCertificateAuthorityRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCertificateAuthorityRequest request = new CreateCertificateAuthorityRequest
            {
                ParentAsCaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                CertificateAuthorityId = "",
                CertificateAuthority = new CertificateAuthority(),
                RequestId = "",
            };
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.CreateCertificateAuthorityAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceCreateCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateAuthority</summary>
        public void CreateCertificateAuthority()
        {
            // Snippet: CreateCertificateAuthority(string, CertificateAuthority, string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]";
            CertificateAuthority certificateAuthority = new CertificateAuthority();
            string certificateAuthorityId = "";
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.CreateCertificateAuthority(parent, certificateAuthority, certificateAuthorityId);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceCreateCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateAuthorityAsync</summary>
        public async Task CreateCertificateAuthorityAsync()
        {
            // Snippet: CreateCertificateAuthorityAsync(string, CertificateAuthority, string, CallSettings)
            // Additional: CreateCertificateAuthorityAsync(string, CertificateAuthority, string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]";
            CertificateAuthority certificateAuthority = new CertificateAuthority();
            string certificateAuthorityId = "";
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.CreateCertificateAuthorityAsync(parent, certificateAuthority, certificateAuthorityId);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceCreateCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateAuthority</summary>
        public void CreateCertificateAuthorityResourceNames()
        {
            // Snippet: CreateCertificateAuthority(CaPoolName, CertificateAuthority, string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CaPoolName parent = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]");
            CertificateAuthority certificateAuthority = new CertificateAuthority();
            string certificateAuthorityId = "";
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.CreateCertificateAuthority(parent, certificateAuthority, certificateAuthorityId);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceCreateCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateAuthorityAsync</summary>
        public async Task CreateCertificateAuthorityResourceNamesAsync()
        {
            // Snippet: CreateCertificateAuthorityAsync(CaPoolName, CertificateAuthority, string, CallSettings)
            // Additional: CreateCertificateAuthorityAsync(CaPoolName, CertificateAuthority, string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CaPoolName parent = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]");
            CertificateAuthority certificateAuthority = new CertificateAuthority();
            string certificateAuthorityId = "";
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.CreateCertificateAuthorityAsync(parent, certificateAuthority, certificateAuthorityId);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceCreateCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableCertificateAuthority</summary>
        public void DisableCertificateAuthorityRequestObject()
        {
            // Snippet: DisableCertificateAuthority(DisableCertificateAuthorityRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            DisableCertificateAuthorityRequest request = new DisableCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                RequestId = "",
                IgnoreDependentResources = false,
            };
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.DisableCertificateAuthority(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceDisableCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableCertificateAuthorityAsync</summary>
        public async Task DisableCertificateAuthorityRequestObjectAsync()
        {
            // Snippet: DisableCertificateAuthorityAsync(DisableCertificateAuthorityRequest, CallSettings)
            // Additional: DisableCertificateAuthorityAsync(DisableCertificateAuthorityRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            DisableCertificateAuthorityRequest request = new DisableCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                RequestId = "",
                IgnoreDependentResources = false,
            };
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.DisableCertificateAuthorityAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceDisableCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableCertificateAuthority</summary>
        public void DisableCertificateAuthority()
        {
            // Snippet: DisableCertificateAuthority(string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.DisableCertificateAuthority(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceDisableCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableCertificateAuthorityAsync</summary>
        public async Task DisableCertificateAuthorityAsync()
        {
            // Snippet: DisableCertificateAuthorityAsync(string, CallSettings)
            // Additional: DisableCertificateAuthorityAsync(string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.DisableCertificateAuthorityAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceDisableCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableCertificateAuthority</summary>
        public void DisableCertificateAuthorityResourceNames()
        {
            // Snippet: DisableCertificateAuthority(CertificateAuthorityName, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]");
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.DisableCertificateAuthority(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceDisableCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableCertificateAuthorityAsync</summary>
        public async Task DisableCertificateAuthorityResourceNamesAsync()
        {
            // Snippet: DisableCertificateAuthorityAsync(CertificateAuthorityName, CallSettings)
            // Additional: DisableCertificateAuthorityAsync(CertificateAuthorityName, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]");
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.DisableCertificateAuthorityAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceDisableCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableCertificateAuthority</summary>
        public void EnableCertificateAuthorityRequestObject()
        {
            // Snippet: EnableCertificateAuthority(EnableCertificateAuthorityRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            EnableCertificateAuthorityRequest request = new EnableCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                RequestId = "",
            };
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.EnableCertificateAuthority(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceEnableCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableCertificateAuthorityAsync</summary>
        public async Task EnableCertificateAuthorityRequestObjectAsync()
        {
            // Snippet: EnableCertificateAuthorityAsync(EnableCertificateAuthorityRequest, CallSettings)
            // Additional: EnableCertificateAuthorityAsync(EnableCertificateAuthorityRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            EnableCertificateAuthorityRequest request = new EnableCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                RequestId = "",
            };
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.EnableCertificateAuthorityAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceEnableCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableCertificateAuthority</summary>
        public void EnableCertificateAuthority()
        {
            // Snippet: EnableCertificateAuthority(string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.EnableCertificateAuthority(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceEnableCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableCertificateAuthorityAsync</summary>
        public async Task EnableCertificateAuthorityAsync()
        {
            // Snippet: EnableCertificateAuthorityAsync(string, CallSettings)
            // Additional: EnableCertificateAuthorityAsync(string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.EnableCertificateAuthorityAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceEnableCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableCertificateAuthority</summary>
        public void EnableCertificateAuthorityResourceNames()
        {
            // Snippet: EnableCertificateAuthority(CertificateAuthorityName, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]");
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.EnableCertificateAuthority(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceEnableCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableCertificateAuthorityAsync</summary>
        public async Task EnableCertificateAuthorityResourceNamesAsync()
        {
            // Snippet: EnableCertificateAuthorityAsync(CertificateAuthorityName, CallSettings)
            // Additional: EnableCertificateAuthorityAsync(CertificateAuthorityName, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]");
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.EnableCertificateAuthorityAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceEnableCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FetchCertificateAuthorityCsr</summary>
        public void FetchCertificateAuthorityCsrRequestObject()
        {
            // Snippet: FetchCertificateAuthorityCsr(FetchCertificateAuthorityCsrRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            FetchCertificateAuthorityCsrRequest request = new FetchCertificateAuthorityCsrRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
            };
            // Make the request
            FetchCertificateAuthorityCsrResponse response = certificateAuthorityServiceClient.FetchCertificateAuthorityCsr(request);
            // End snippet
        }

        /// <summary>Snippet for FetchCertificateAuthorityCsrAsync</summary>
        public async Task FetchCertificateAuthorityCsrRequestObjectAsync()
        {
            // Snippet: FetchCertificateAuthorityCsrAsync(FetchCertificateAuthorityCsrRequest, CallSettings)
            // Additional: FetchCertificateAuthorityCsrAsync(FetchCertificateAuthorityCsrRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            FetchCertificateAuthorityCsrRequest request = new FetchCertificateAuthorityCsrRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
            };
            // Make the request
            FetchCertificateAuthorityCsrResponse response = await certificateAuthorityServiceClient.FetchCertificateAuthorityCsrAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchCertificateAuthorityCsr</summary>
        public void FetchCertificateAuthorityCsr()
        {
            // Snippet: FetchCertificateAuthorityCsr(string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
            // Make the request
            FetchCertificateAuthorityCsrResponse response = certificateAuthorityServiceClient.FetchCertificateAuthorityCsr(name);
            // End snippet
        }

        /// <summary>Snippet for FetchCertificateAuthorityCsrAsync</summary>
        public async Task FetchCertificateAuthorityCsrAsync()
        {
            // Snippet: FetchCertificateAuthorityCsrAsync(string, CallSettings)
            // Additional: FetchCertificateAuthorityCsrAsync(string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
            // Make the request
            FetchCertificateAuthorityCsrResponse response = await certificateAuthorityServiceClient.FetchCertificateAuthorityCsrAsync(name);
            // End snippet
        }

        /// <summary>Snippet for FetchCertificateAuthorityCsr</summary>
        public void FetchCertificateAuthorityCsrResourceNames()
        {
            // Snippet: FetchCertificateAuthorityCsr(CertificateAuthorityName, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]");
            // Make the request
            FetchCertificateAuthorityCsrResponse response = certificateAuthorityServiceClient.FetchCertificateAuthorityCsr(name);
            // End snippet
        }

        /// <summary>Snippet for FetchCertificateAuthorityCsrAsync</summary>
        public async Task FetchCertificateAuthorityCsrResourceNamesAsync()
        {
            // Snippet: FetchCertificateAuthorityCsrAsync(CertificateAuthorityName, CallSettings)
            // Additional: FetchCertificateAuthorityCsrAsync(CertificateAuthorityName, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]");
            // Make the request
            FetchCertificateAuthorityCsrResponse response = await certificateAuthorityServiceClient.FetchCertificateAuthorityCsrAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateAuthority</summary>
        public void GetCertificateAuthorityRequestObject()
        {
            // Snippet: GetCertificateAuthority(GetCertificateAuthorityRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            GetCertificateAuthorityRequest request = new GetCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
            };
            // Make the request
            CertificateAuthority response = certificateAuthorityServiceClient.GetCertificateAuthority(request);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateAuthorityAsync</summary>
        public async Task GetCertificateAuthorityRequestObjectAsync()
        {
            // Snippet: GetCertificateAuthorityAsync(GetCertificateAuthorityRequest, CallSettings)
            // Additional: GetCertificateAuthorityAsync(GetCertificateAuthorityRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCertificateAuthorityRequest request = new GetCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
            };
            // Make the request
            CertificateAuthority response = await certificateAuthorityServiceClient.GetCertificateAuthorityAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateAuthority</summary>
        public void GetCertificateAuthority()
        {
            // Snippet: GetCertificateAuthority(string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
            // Make the request
            CertificateAuthority response = certificateAuthorityServiceClient.GetCertificateAuthority(name);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateAuthorityAsync</summary>
        public async Task GetCertificateAuthorityAsync()
        {
            // Snippet: GetCertificateAuthorityAsync(string, CallSettings)
            // Additional: GetCertificateAuthorityAsync(string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
            // Make the request
            CertificateAuthority response = await certificateAuthorityServiceClient.GetCertificateAuthorityAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateAuthority</summary>
        public void GetCertificateAuthorityResourceNames()
        {
            // Snippet: GetCertificateAuthority(CertificateAuthorityName, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]");
            // Make the request
            CertificateAuthority response = certificateAuthorityServiceClient.GetCertificateAuthority(name);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateAuthorityAsync</summary>
        public async Task GetCertificateAuthorityResourceNamesAsync()
        {
            // Snippet: GetCertificateAuthorityAsync(CertificateAuthorityName, CallSettings)
            // Additional: GetCertificateAuthorityAsync(CertificateAuthorityName, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]");
            // Make the request
            CertificateAuthority response = await certificateAuthorityServiceClient.GetCertificateAuthorityAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCertificateAuthorities</summary>
        public void ListCertificateAuthoritiesRequestObject()
        {
            // Snippet: ListCertificateAuthorities(ListCertificateAuthoritiesRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            ListCertificateAuthoritiesRequest request = new ListCertificateAuthoritiesRequest
            {
                ParentAsCaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListCertificateAuthoritiesResponse, CertificateAuthority> response = certificateAuthorityServiceClient.ListCertificateAuthorities(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CertificateAuthority item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCertificateAuthoritiesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateAuthority item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateAuthority> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateAuthority item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificateAuthoritiesAsync</summary>
        public async Task ListCertificateAuthoritiesRequestObjectAsync()
        {
            // Snippet: ListCertificateAuthoritiesAsync(ListCertificateAuthoritiesRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCertificateAuthoritiesRequest request = new ListCertificateAuthoritiesRequest
            {
                ParentAsCaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCertificateAuthoritiesResponse, CertificateAuthority> response = certificateAuthorityServiceClient.ListCertificateAuthoritiesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CertificateAuthority item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCertificateAuthoritiesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateAuthority item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateAuthority> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateAuthority item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificateAuthorities</summary>
        public void ListCertificateAuthorities()
        {
            // Snippet: ListCertificateAuthorities(string, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]";
            // Make the request
            PagedEnumerable<ListCertificateAuthoritiesResponse, CertificateAuthority> response = certificateAuthorityServiceClient.ListCertificateAuthorities(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CertificateAuthority item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCertificateAuthoritiesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateAuthority item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateAuthority> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateAuthority item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificateAuthoritiesAsync</summary>
        public async Task ListCertificateAuthoritiesAsync()
        {
            // Snippet: ListCertificateAuthoritiesAsync(string, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]";
            // Make the request
            PagedAsyncEnumerable<ListCertificateAuthoritiesResponse, CertificateAuthority> response = certificateAuthorityServiceClient.ListCertificateAuthoritiesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CertificateAuthority item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCertificateAuthoritiesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateAuthority item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateAuthority> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateAuthority item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificateAuthorities</summary>
        public void ListCertificateAuthoritiesResourceNames()
        {
            // Snippet: ListCertificateAuthorities(CaPoolName, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CaPoolName parent = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]");
            // Make the request
            PagedEnumerable<ListCertificateAuthoritiesResponse, CertificateAuthority> response = certificateAuthorityServiceClient.ListCertificateAuthorities(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CertificateAuthority item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCertificateAuthoritiesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateAuthority item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateAuthority> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateAuthority item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificateAuthoritiesAsync</summary>
        public async Task ListCertificateAuthoritiesResourceNamesAsync()
        {
            // Snippet: ListCertificateAuthoritiesAsync(CaPoolName, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CaPoolName parent = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]");
            // Make the request
            PagedAsyncEnumerable<ListCertificateAuthoritiesResponse, CertificateAuthority> response = certificateAuthorityServiceClient.ListCertificateAuthoritiesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CertificateAuthority item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCertificateAuthoritiesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateAuthority item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateAuthority> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateAuthority item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UndeleteCertificateAuthority</summary>
        public void UndeleteCertificateAuthorityRequestObject()
        {
            // Snippet: UndeleteCertificateAuthority(UndeleteCertificateAuthorityRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            UndeleteCertificateAuthorityRequest request = new UndeleteCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                RequestId = "",
            };
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.UndeleteCertificateAuthority(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceUndeleteCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteCertificateAuthorityAsync</summary>
        public async Task UndeleteCertificateAuthorityRequestObjectAsync()
        {
            // Snippet: UndeleteCertificateAuthorityAsync(UndeleteCertificateAuthorityRequest, CallSettings)
            // Additional: UndeleteCertificateAuthorityAsync(UndeleteCertificateAuthorityRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            UndeleteCertificateAuthorityRequest request = new UndeleteCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                RequestId = "",
            };
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.UndeleteCertificateAuthorityAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceUndeleteCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteCertificateAuthority</summary>
        public void UndeleteCertificateAuthority()
        {
            // Snippet: UndeleteCertificateAuthority(string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.UndeleteCertificateAuthority(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceUndeleteCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteCertificateAuthorityAsync</summary>
        public async Task UndeleteCertificateAuthorityAsync()
        {
            // Snippet: UndeleteCertificateAuthorityAsync(string, CallSettings)
            // Additional: UndeleteCertificateAuthorityAsync(string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.UndeleteCertificateAuthorityAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceUndeleteCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteCertificateAuthority</summary>
        public void UndeleteCertificateAuthorityResourceNames()
        {
            // Snippet: UndeleteCertificateAuthority(CertificateAuthorityName, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]");
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.UndeleteCertificateAuthority(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceUndeleteCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteCertificateAuthorityAsync</summary>
        public async Task UndeleteCertificateAuthorityResourceNamesAsync()
        {
            // Snippet: UndeleteCertificateAuthorityAsync(CertificateAuthorityName, CallSettings)
            // Additional: UndeleteCertificateAuthorityAsync(CertificateAuthorityName, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]");
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.UndeleteCertificateAuthorityAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceUndeleteCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateAuthority</summary>
        public void DeleteCertificateAuthorityRequestObject()
        {
            // Snippet: DeleteCertificateAuthority(DeleteCertificateAuthorityRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            DeleteCertificateAuthorityRequest request = new DeleteCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                RequestId = "",
                IgnoreActiveCertificates = false,
                SkipGracePeriod = false,
                IgnoreDependentResources = false,
            };
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.DeleteCertificateAuthority(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceDeleteCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateAuthorityAsync</summary>
        public async Task DeleteCertificateAuthorityRequestObjectAsync()
        {
            // Snippet: DeleteCertificateAuthorityAsync(DeleteCertificateAuthorityRequest, CallSettings)
            // Additional: DeleteCertificateAuthorityAsync(DeleteCertificateAuthorityRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCertificateAuthorityRequest request = new DeleteCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                RequestId = "",
                IgnoreActiveCertificates = false,
                SkipGracePeriod = false,
                IgnoreDependentResources = false,
            };
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.DeleteCertificateAuthorityAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceDeleteCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateAuthority</summary>
        public void DeleteCertificateAuthority()
        {
            // Snippet: DeleteCertificateAuthority(string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.DeleteCertificateAuthority(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceDeleteCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateAuthorityAsync</summary>
        public async Task DeleteCertificateAuthorityAsync()
        {
            // Snippet: DeleteCertificateAuthorityAsync(string, CallSettings)
            // Additional: DeleteCertificateAuthorityAsync(string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.DeleteCertificateAuthorityAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceDeleteCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateAuthority</summary>
        public void DeleteCertificateAuthorityResourceNames()
        {
            // Snippet: DeleteCertificateAuthority(CertificateAuthorityName, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]");
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.DeleteCertificateAuthority(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceDeleteCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateAuthorityAsync</summary>
        public async Task DeleteCertificateAuthorityResourceNamesAsync()
        {
            // Snippet: DeleteCertificateAuthorityAsync(CertificateAuthorityName, CallSettings)
            // Additional: DeleteCertificateAuthorityAsync(CertificateAuthorityName, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]");
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.DeleteCertificateAuthorityAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceDeleteCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificateAuthority</summary>
        public void UpdateCertificateAuthorityRequestObject()
        {
            // Snippet: UpdateCertificateAuthority(UpdateCertificateAuthorityRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            UpdateCertificateAuthorityRequest request = new UpdateCertificateAuthorityRequest
            {
                CertificateAuthority = new CertificateAuthority(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.UpdateCertificateAuthority(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceUpdateCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificateAuthorityAsync</summary>
        public async Task UpdateCertificateAuthorityRequestObjectAsync()
        {
            // Snippet: UpdateCertificateAuthorityAsync(UpdateCertificateAuthorityRequest, CallSettings)
            // Additional: UpdateCertificateAuthorityAsync(UpdateCertificateAuthorityRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCertificateAuthorityRequest request = new UpdateCertificateAuthorityRequest
            {
                CertificateAuthority = new CertificateAuthority(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.UpdateCertificateAuthorityAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceUpdateCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificateAuthority</summary>
        public void UpdateCertificateAuthority()
        {
            // Snippet: UpdateCertificateAuthority(CertificateAuthority, FieldMask, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CertificateAuthority certificateAuthority = new CertificateAuthority();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.UpdateCertificateAuthority(certificateAuthority, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceUpdateCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificateAuthorityAsync</summary>
        public async Task UpdateCertificateAuthorityAsync()
        {
            // Snippet: UpdateCertificateAuthorityAsync(CertificateAuthority, FieldMask, CallSettings)
            // Additional: UpdateCertificateAuthorityAsync(CertificateAuthority, FieldMask, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CertificateAuthority certificateAuthority = new CertificateAuthority();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.UpdateCertificateAuthorityAsync(certificateAuthority, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceUpdateCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCaPool</summary>
        public void CreateCaPoolRequestObject()
        {
            // Snippet: CreateCaPool(CreateCaPoolRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CreateCaPoolRequest request = new CreateCaPoolRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CaPoolId = "",
                CaPool = new CaPool(),
                RequestId = "",
            };
            // Make the request
            Operation<CaPool, OperationMetadata> response = certificateAuthorityServiceClient.CreateCaPool(request);

            // Poll until the returned long-running operation is complete
            Operation<CaPool, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CaPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CaPool, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceCreateCaPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CaPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCaPoolAsync</summary>
        public async Task CreateCaPoolRequestObjectAsync()
        {
            // Snippet: CreateCaPoolAsync(CreateCaPoolRequest, CallSettings)
            // Additional: CreateCaPoolAsync(CreateCaPoolRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCaPoolRequest request = new CreateCaPoolRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CaPoolId = "",
                CaPool = new CaPool(),
                RequestId = "",
            };
            // Make the request
            Operation<CaPool, OperationMetadata> response = await certificateAuthorityServiceClient.CreateCaPoolAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CaPool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CaPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CaPool, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceCreateCaPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CaPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCaPool</summary>
        public void CreateCaPool()
        {
            // Snippet: CreateCaPool(string, CaPool, string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CaPool caPool = new CaPool();
            string caPoolId = "";
            // Make the request
            Operation<CaPool, OperationMetadata> response = certificateAuthorityServiceClient.CreateCaPool(parent, caPool, caPoolId);

            // Poll until the returned long-running operation is complete
            Operation<CaPool, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CaPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CaPool, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceCreateCaPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CaPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCaPoolAsync</summary>
        public async Task CreateCaPoolAsync()
        {
            // Snippet: CreateCaPoolAsync(string, CaPool, string, CallSettings)
            // Additional: CreateCaPoolAsync(string, CaPool, string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CaPool caPool = new CaPool();
            string caPoolId = "";
            // Make the request
            Operation<CaPool, OperationMetadata> response = await certificateAuthorityServiceClient.CreateCaPoolAsync(parent, caPool, caPoolId);

            // Poll until the returned long-running operation is complete
            Operation<CaPool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CaPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CaPool, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceCreateCaPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CaPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCaPool</summary>
        public void CreateCaPoolResourceNames()
        {
            // Snippet: CreateCaPool(LocationName, CaPool, string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CaPool caPool = new CaPool();
            string caPoolId = "";
            // Make the request
            Operation<CaPool, OperationMetadata> response = certificateAuthorityServiceClient.CreateCaPool(parent, caPool, caPoolId);

            // Poll until the returned long-running operation is complete
            Operation<CaPool, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CaPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CaPool, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceCreateCaPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CaPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCaPoolAsync</summary>
        public async Task CreateCaPoolResourceNamesAsync()
        {
            // Snippet: CreateCaPoolAsync(LocationName, CaPool, string, CallSettings)
            // Additional: CreateCaPoolAsync(LocationName, CaPool, string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CaPool caPool = new CaPool();
            string caPoolId = "";
            // Make the request
            Operation<CaPool, OperationMetadata> response = await certificateAuthorityServiceClient.CreateCaPoolAsync(parent, caPool, caPoolId);

            // Poll until the returned long-running operation is complete
            Operation<CaPool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CaPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CaPool, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceCreateCaPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CaPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCaPool</summary>
        public void UpdateCaPoolRequestObject()
        {
            // Snippet: UpdateCaPool(UpdateCaPoolRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            UpdateCaPoolRequest request = new UpdateCaPoolRequest
            {
                CaPool = new CaPool(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<CaPool, OperationMetadata> response = certificateAuthorityServiceClient.UpdateCaPool(request);

            // Poll until the returned long-running operation is complete
            Operation<CaPool, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CaPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CaPool, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceUpdateCaPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CaPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCaPoolAsync</summary>
        public async Task UpdateCaPoolRequestObjectAsync()
        {
            // Snippet: UpdateCaPoolAsync(UpdateCaPoolRequest, CallSettings)
            // Additional: UpdateCaPoolAsync(UpdateCaPoolRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCaPoolRequest request = new UpdateCaPoolRequest
            {
                CaPool = new CaPool(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<CaPool, OperationMetadata> response = await certificateAuthorityServiceClient.UpdateCaPoolAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CaPool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CaPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CaPool, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceUpdateCaPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CaPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCaPool</summary>
        public void UpdateCaPool()
        {
            // Snippet: UpdateCaPool(CaPool, FieldMask, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CaPool caPool = new CaPool();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<CaPool, OperationMetadata> response = certificateAuthorityServiceClient.UpdateCaPool(caPool, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<CaPool, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CaPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CaPool, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceUpdateCaPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CaPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCaPoolAsync</summary>
        public async Task UpdateCaPoolAsync()
        {
            // Snippet: UpdateCaPoolAsync(CaPool, FieldMask, CallSettings)
            // Additional: UpdateCaPoolAsync(CaPool, FieldMask, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CaPool caPool = new CaPool();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<CaPool, OperationMetadata> response = await certificateAuthorityServiceClient.UpdateCaPoolAsync(caPool, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<CaPool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CaPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CaPool, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceUpdateCaPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CaPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetCaPool</summary>
        public void GetCaPoolRequestObject()
        {
            // Snippet: GetCaPool(GetCaPoolRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            GetCaPoolRequest request = new GetCaPoolRequest
            {
                CaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
            };
            // Make the request
            CaPool response = certificateAuthorityServiceClient.GetCaPool(request);
            // End snippet
        }

        /// <summary>Snippet for GetCaPoolAsync</summary>
        public async Task GetCaPoolRequestObjectAsync()
        {
            // Snippet: GetCaPoolAsync(GetCaPoolRequest, CallSettings)
            // Additional: GetCaPoolAsync(GetCaPoolRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCaPoolRequest request = new GetCaPoolRequest
            {
                CaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
            };
            // Make the request
            CaPool response = await certificateAuthorityServiceClient.GetCaPoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCaPool</summary>
        public void GetCaPool()
        {
            // Snippet: GetCaPool(string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]";
            // Make the request
            CaPool response = certificateAuthorityServiceClient.GetCaPool(name);
            // End snippet
        }

        /// <summary>Snippet for GetCaPoolAsync</summary>
        public async Task GetCaPoolAsync()
        {
            // Snippet: GetCaPoolAsync(string, CallSettings)
            // Additional: GetCaPoolAsync(string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]";
            // Make the request
            CaPool response = await certificateAuthorityServiceClient.GetCaPoolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCaPool</summary>
        public void GetCaPoolResourceNames()
        {
            // Snippet: GetCaPool(CaPoolName, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CaPoolName name = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]");
            // Make the request
            CaPool response = certificateAuthorityServiceClient.GetCaPool(name);
            // End snippet
        }

        /// <summary>Snippet for GetCaPoolAsync</summary>
        public async Task GetCaPoolResourceNamesAsync()
        {
            // Snippet: GetCaPoolAsync(CaPoolName, CallSettings)
            // Additional: GetCaPoolAsync(CaPoolName, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CaPoolName name = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]");
            // Make the request
            CaPool response = await certificateAuthorityServiceClient.GetCaPoolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCaPools</summary>
        public void ListCaPoolsRequestObject()
        {
            // Snippet: ListCaPools(ListCaPoolsRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            ListCaPoolsRequest request = new ListCaPoolsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListCaPoolsResponse, CaPool> response = certificateAuthorityServiceClient.ListCaPools(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CaPool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCaPoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CaPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CaPool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CaPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCaPoolsAsync</summary>
        public async Task ListCaPoolsRequestObjectAsync()
        {
            // Snippet: ListCaPoolsAsync(ListCaPoolsRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCaPoolsRequest request = new ListCaPoolsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCaPoolsResponse, CaPool> response = certificateAuthorityServiceClient.ListCaPoolsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CaPool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCaPoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CaPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CaPool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CaPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCaPools</summary>
        public void ListCaPools()
        {
            // Snippet: ListCaPools(string, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListCaPoolsResponse, CaPool> response = certificateAuthorityServiceClient.ListCaPools(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CaPool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCaPoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CaPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CaPool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CaPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCaPoolsAsync</summary>
        public async Task ListCaPoolsAsync()
        {
            // Snippet: ListCaPoolsAsync(string, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListCaPoolsResponse, CaPool> response = certificateAuthorityServiceClient.ListCaPoolsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CaPool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCaPoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CaPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CaPool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CaPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCaPools</summary>
        public void ListCaPoolsResourceNames()
        {
            // Snippet: ListCaPools(LocationName, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListCaPoolsResponse, CaPool> response = certificateAuthorityServiceClient.ListCaPools(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CaPool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCaPoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CaPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CaPool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CaPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCaPoolsAsync</summary>
        public async Task ListCaPoolsResourceNamesAsync()
        {
            // Snippet: ListCaPoolsAsync(LocationName, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListCaPoolsResponse, CaPool> response = certificateAuthorityServiceClient.ListCaPoolsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CaPool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCaPoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CaPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CaPool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CaPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteCaPool</summary>
        public void DeleteCaPoolRequestObject()
        {
            // Snippet: DeleteCaPool(DeleteCaPoolRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            DeleteCaPoolRequest request = new DeleteCaPoolRequest
            {
                CaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                RequestId = "",
                IgnoreDependentResources = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = certificateAuthorityServiceClient.DeleteCaPool(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceDeleteCaPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCaPoolAsync</summary>
        public async Task DeleteCaPoolRequestObjectAsync()
        {
            // Snippet: DeleteCaPoolAsync(DeleteCaPoolRequest, CallSettings)
            // Additional: DeleteCaPoolAsync(DeleteCaPoolRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCaPoolRequest request = new DeleteCaPoolRequest
            {
                CaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                RequestId = "",
                IgnoreDependentResources = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await certificateAuthorityServiceClient.DeleteCaPoolAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceDeleteCaPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCaPool</summary>
        public void DeleteCaPool()
        {
            // Snippet: DeleteCaPool(string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]";
            // Make the request
            Operation<Empty, OperationMetadata> response = certificateAuthorityServiceClient.DeleteCaPool(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceDeleteCaPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCaPoolAsync</summary>
        public async Task DeleteCaPoolAsync()
        {
            // Snippet: DeleteCaPoolAsync(string, CallSettings)
            // Additional: DeleteCaPoolAsync(string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await certificateAuthorityServiceClient.DeleteCaPoolAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceDeleteCaPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCaPool</summary>
        public void DeleteCaPoolResourceNames()
        {
            // Snippet: DeleteCaPool(CaPoolName, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CaPoolName name = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]");
            // Make the request
            Operation<Empty, OperationMetadata> response = certificateAuthorityServiceClient.DeleteCaPool(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceDeleteCaPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCaPoolAsync</summary>
        public async Task DeleteCaPoolResourceNamesAsync()
        {
            // Snippet: DeleteCaPoolAsync(CaPoolName, CallSettings)
            // Additional: DeleteCaPoolAsync(CaPoolName, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CaPoolName name = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await certificateAuthorityServiceClient.DeleteCaPoolAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceDeleteCaPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FetchCaCerts</summary>
        public void FetchCaCertsRequestObject()
        {
            // Snippet: FetchCaCerts(FetchCaCertsRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            FetchCaCertsRequest request = new FetchCaCertsRequest
            {
                CaPoolAsCaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                RequestId = "",
            };
            // Make the request
            FetchCaCertsResponse response = certificateAuthorityServiceClient.FetchCaCerts(request);
            // End snippet
        }

        /// <summary>Snippet for FetchCaCertsAsync</summary>
        public async Task FetchCaCertsRequestObjectAsync()
        {
            // Snippet: FetchCaCertsAsync(FetchCaCertsRequest, CallSettings)
            // Additional: FetchCaCertsAsync(FetchCaCertsRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            FetchCaCertsRequest request = new FetchCaCertsRequest
            {
                CaPoolAsCaPoolName = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]"),
                RequestId = "",
            };
            // Make the request
            FetchCaCertsResponse response = await certificateAuthorityServiceClient.FetchCaCertsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchCaCerts</summary>
        public void FetchCaCerts()
        {
            // Snippet: FetchCaCerts(string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string caPool = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]";
            // Make the request
            FetchCaCertsResponse response = certificateAuthorityServiceClient.FetchCaCerts(caPool);
            // End snippet
        }

        /// <summary>Snippet for FetchCaCertsAsync</summary>
        public async Task FetchCaCertsAsync()
        {
            // Snippet: FetchCaCertsAsync(string, CallSettings)
            // Additional: FetchCaCertsAsync(string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string caPool = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]";
            // Make the request
            FetchCaCertsResponse response = await certificateAuthorityServiceClient.FetchCaCertsAsync(caPool);
            // End snippet
        }

        /// <summary>Snippet for FetchCaCerts</summary>
        public void FetchCaCertsResourceNames()
        {
            // Snippet: FetchCaCerts(CaPoolName, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CaPoolName caPool = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]");
            // Make the request
            FetchCaCertsResponse response = certificateAuthorityServiceClient.FetchCaCerts(caPool);
            // End snippet
        }

        /// <summary>Snippet for FetchCaCertsAsync</summary>
        public async Task FetchCaCertsResourceNamesAsync()
        {
            // Snippet: FetchCaCertsAsync(CaPoolName, CallSettings)
            // Additional: FetchCaCertsAsync(CaPoolName, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CaPoolName caPool = CaPoolName.FromProjectLocationCaPool("[PROJECT]", "[LOCATION]", "[CA_POOL]");
            // Make the request
            FetchCaCertsResponse response = await certificateAuthorityServiceClient.FetchCaCertsAsync(caPool);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateRevocationList</summary>
        public void GetCertificateRevocationListRequestObject()
        {
            // Snippet: GetCertificateRevocationList(GetCertificateRevocationListRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            GetCertificateRevocationListRequest request = new GetCertificateRevocationListRequest
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCaPoolCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
            };
            // Make the request
            CertificateRevocationList response = certificateAuthorityServiceClient.GetCertificateRevocationList(request);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateRevocationListAsync</summary>
        public async Task GetCertificateRevocationListRequestObjectAsync()
        {
            // Snippet: GetCertificateRevocationListAsync(GetCertificateRevocationListRequest, CallSettings)
            // Additional: GetCertificateRevocationListAsync(GetCertificateRevocationListRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCertificateRevocationListRequest request = new GetCertificateRevocationListRequest
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCaPoolCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
            };
            // Make the request
            CertificateRevocationList response = await certificateAuthorityServiceClient.GetCertificateRevocationListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateRevocationList</summary>
        public void GetCertificateRevocationList()
        {
            // Snippet: GetCertificateRevocationList(string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]/certificateAuthorities/[CERTIFICATE_AUTHORITY]/certificateRevocationLists/[CERTIFICATE_REVOCATION_LIST]";
            // Make the request
            CertificateRevocationList response = certificateAuthorityServiceClient.GetCertificateRevocationList(name);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateRevocationListAsync</summary>
        public async Task GetCertificateRevocationListAsync()
        {
            // Snippet: GetCertificateRevocationListAsync(string, CallSettings)
            // Additional: GetCertificateRevocationListAsync(string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]/certificateAuthorities/[CERTIFICATE_AUTHORITY]/certificateRevocationLists/[CERTIFICATE_REVOCATION_LIST]";
            // Make the request
            CertificateRevocationList response = await certificateAuthorityServiceClient.GetCertificateRevocationListAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateRevocationList</summary>
        public void GetCertificateRevocationListResourceNames()
        {
            // Snippet: GetCertificateRevocationList(CertificateRevocationListName, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CertificateRevocationListName name = CertificateRevocationListName.FromProjectLocationCaPoolCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]");
            // Make the request
            CertificateRevocationList response = certificateAuthorityServiceClient.GetCertificateRevocationList(name);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateRevocationListAsync</summary>
        public async Task GetCertificateRevocationListResourceNamesAsync()
        {
            // Snippet: GetCertificateRevocationListAsync(CertificateRevocationListName, CallSettings)
            // Additional: GetCertificateRevocationListAsync(CertificateRevocationListName, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CertificateRevocationListName name = CertificateRevocationListName.FromProjectLocationCaPoolCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]");
            // Make the request
            CertificateRevocationList response = await certificateAuthorityServiceClient.GetCertificateRevocationListAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCertificateRevocationLists</summary>
        public void ListCertificateRevocationListsRequestObject()
        {
            // Snippet: ListCertificateRevocationLists(ListCertificateRevocationListsRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            ListCertificateRevocationListsRequest request = new ListCertificateRevocationListsRequest
            {
                ParentAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListCertificateRevocationListsResponse, CertificateRevocationList> response = certificateAuthorityServiceClient.ListCertificateRevocationLists(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CertificateRevocationList item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCertificateRevocationListsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateRevocationList item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateRevocationList> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateRevocationList item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificateRevocationListsAsync</summary>
        public async Task ListCertificateRevocationListsRequestObjectAsync()
        {
            // Snippet: ListCertificateRevocationListsAsync(ListCertificateRevocationListsRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCertificateRevocationListsRequest request = new ListCertificateRevocationListsRequest
            {
                ParentAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCertificateRevocationListsResponse, CertificateRevocationList> response = certificateAuthorityServiceClient.ListCertificateRevocationListsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CertificateRevocationList item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCertificateRevocationListsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateRevocationList item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateRevocationList> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateRevocationList item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificateRevocationLists</summary>
        public void ListCertificateRevocationLists()
        {
            // Snippet: ListCertificateRevocationLists(string, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
            // Make the request
            PagedEnumerable<ListCertificateRevocationListsResponse, CertificateRevocationList> response = certificateAuthorityServiceClient.ListCertificateRevocationLists(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CertificateRevocationList item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCertificateRevocationListsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateRevocationList item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateRevocationList> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateRevocationList item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificateRevocationListsAsync</summary>
        public async Task ListCertificateRevocationListsAsync()
        {
            // Snippet: ListCertificateRevocationListsAsync(string, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/caPools/[CA_POOL]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
            // Make the request
            PagedAsyncEnumerable<ListCertificateRevocationListsResponse, CertificateRevocationList> response = certificateAuthorityServiceClient.ListCertificateRevocationListsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CertificateRevocationList item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCertificateRevocationListsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateRevocationList item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateRevocationList> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateRevocationList item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificateRevocationLists</summary>
        public void ListCertificateRevocationListsResourceNames()
        {
            // Snippet: ListCertificateRevocationLists(CertificateAuthorityName, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CertificateAuthorityName parent = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]");
            // Make the request
            PagedEnumerable<ListCertificateRevocationListsResponse, CertificateRevocationList> response = certificateAuthorityServiceClient.ListCertificateRevocationLists(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CertificateRevocationList item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCertificateRevocationListsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateRevocationList item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateRevocationList> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateRevocationList item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificateRevocationListsAsync</summary>
        public async Task ListCertificateRevocationListsResourceNamesAsync()
        {
            // Snippet: ListCertificateRevocationListsAsync(CertificateAuthorityName, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CertificateAuthorityName parent = CertificateAuthorityName.FromProjectLocationCaPoolCertificateAuthority("[PROJECT]", "[LOCATION]", "[CA_POOL]", "[CERTIFICATE_AUTHORITY]");
            // Make the request
            PagedAsyncEnumerable<ListCertificateRevocationListsResponse, CertificateRevocationList> response = certificateAuthorityServiceClient.ListCertificateRevocationListsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CertificateRevocationList item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCertificateRevocationListsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateRevocationList item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateRevocationList> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateRevocationList item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificateRevocationList</summary>
        public void UpdateCertificateRevocationListRequestObject()
        {
            // Snippet: UpdateCertificateRevocationList(UpdateCertificateRevocationListRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            UpdateCertificateRevocationListRequest request = new UpdateCertificateRevocationListRequest
            {
                CertificateRevocationList = new CertificateRevocationList(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<CertificateRevocationList, OperationMetadata> response = certificateAuthorityServiceClient.UpdateCertificateRevocationList(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateRevocationList, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateRevocationList result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateRevocationList, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceUpdateCertificateRevocationList(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateRevocationList retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificateRevocationListAsync</summary>
        public async Task UpdateCertificateRevocationListRequestObjectAsync()
        {
            // Snippet: UpdateCertificateRevocationListAsync(UpdateCertificateRevocationListRequest, CallSettings)
            // Additional: UpdateCertificateRevocationListAsync(UpdateCertificateRevocationListRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCertificateRevocationListRequest request = new UpdateCertificateRevocationListRequest
            {
                CertificateRevocationList = new CertificateRevocationList(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<CertificateRevocationList, OperationMetadata> response = await certificateAuthorityServiceClient.UpdateCertificateRevocationListAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateRevocationList, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateRevocationList result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateRevocationList, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceUpdateCertificateRevocationListAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateRevocationList retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificateRevocationList</summary>
        public void UpdateCertificateRevocationList()
        {
            // Snippet: UpdateCertificateRevocationList(CertificateRevocationList, FieldMask, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CertificateRevocationList certificateRevocationList = new CertificateRevocationList();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<CertificateRevocationList, OperationMetadata> response = certificateAuthorityServiceClient.UpdateCertificateRevocationList(certificateRevocationList, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<CertificateRevocationList, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateRevocationList result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateRevocationList, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceUpdateCertificateRevocationList(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateRevocationList retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificateRevocationListAsync</summary>
        public async Task UpdateCertificateRevocationListAsync()
        {
            // Snippet: UpdateCertificateRevocationListAsync(CertificateRevocationList, FieldMask, CallSettings)
            // Additional: UpdateCertificateRevocationListAsync(CertificateRevocationList, FieldMask, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CertificateRevocationList certificateRevocationList = new CertificateRevocationList();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<CertificateRevocationList, OperationMetadata> response = await certificateAuthorityServiceClient.UpdateCertificateRevocationListAsync(certificateRevocationList, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<CertificateRevocationList, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateRevocationList result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateRevocationList, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceUpdateCertificateRevocationListAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateRevocationList retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateTemplate</summary>
        public void CreateCertificateTemplateRequestObject()
        {
            // Snippet: CreateCertificateTemplate(CreateCertificateTemplateRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CreateCertificateTemplateRequest request = new CreateCertificateTemplateRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CertificateTemplateId = "",
                CertificateTemplate = new CertificateTemplate(),
                RequestId = "",
            };
            // Make the request
            Operation<CertificateTemplate, OperationMetadata> response = certificateAuthorityServiceClient.CreateCertificateTemplate(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateTemplate, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateTemplate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateTemplate, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceCreateCertificateTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateTemplate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateTemplateAsync</summary>
        public async Task CreateCertificateTemplateRequestObjectAsync()
        {
            // Snippet: CreateCertificateTemplateAsync(CreateCertificateTemplateRequest, CallSettings)
            // Additional: CreateCertificateTemplateAsync(CreateCertificateTemplateRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCertificateTemplateRequest request = new CreateCertificateTemplateRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CertificateTemplateId = "",
                CertificateTemplate = new CertificateTemplate(),
                RequestId = "",
            };
            // Make the request
            Operation<CertificateTemplate, OperationMetadata> response = await certificateAuthorityServiceClient.CreateCertificateTemplateAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateTemplate, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateTemplate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateTemplate, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceCreateCertificateTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateTemplate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateTemplate</summary>
        public void CreateCertificateTemplate()
        {
            // Snippet: CreateCertificateTemplate(string, CertificateTemplate, string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CertificateTemplate certificateTemplate = new CertificateTemplate();
            string certificateTemplateId = "";
            // Make the request
            Operation<CertificateTemplate, OperationMetadata> response = certificateAuthorityServiceClient.CreateCertificateTemplate(parent, certificateTemplate, certificateTemplateId);

            // Poll until the returned long-running operation is complete
            Operation<CertificateTemplate, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateTemplate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateTemplate, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceCreateCertificateTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateTemplate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateTemplateAsync</summary>
        public async Task CreateCertificateTemplateAsync()
        {
            // Snippet: CreateCertificateTemplateAsync(string, CertificateTemplate, string, CallSettings)
            // Additional: CreateCertificateTemplateAsync(string, CertificateTemplate, string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CertificateTemplate certificateTemplate = new CertificateTemplate();
            string certificateTemplateId = "";
            // Make the request
            Operation<CertificateTemplate, OperationMetadata> response = await certificateAuthorityServiceClient.CreateCertificateTemplateAsync(parent, certificateTemplate, certificateTemplateId);

            // Poll until the returned long-running operation is complete
            Operation<CertificateTemplate, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateTemplate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateTemplate, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceCreateCertificateTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateTemplate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateTemplate</summary>
        public void CreateCertificateTemplateResourceNames()
        {
            // Snippet: CreateCertificateTemplate(LocationName, CertificateTemplate, string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CertificateTemplate certificateTemplate = new CertificateTemplate();
            string certificateTemplateId = "";
            // Make the request
            Operation<CertificateTemplate, OperationMetadata> response = certificateAuthorityServiceClient.CreateCertificateTemplate(parent, certificateTemplate, certificateTemplateId);

            // Poll until the returned long-running operation is complete
            Operation<CertificateTemplate, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateTemplate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateTemplate, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceCreateCertificateTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateTemplate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateTemplateAsync</summary>
        public async Task CreateCertificateTemplateResourceNamesAsync()
        {
            // Snippet: CreateCertificateTemplateAsync(LocationName, CertificateTemplate, string, CallSettings)
            // Additional: CreateCertificateTemplateAsync(LocationName, CertificateTemplate, string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CertificateTemplate certificateTemplate = new CertificateTemplate();
            string certificateTemplateId = "";
            // Make the request
            Operation<CertificateTemplate, OperationMetadata> response = await certificateAuthorityServiceClient.CreateCertificateTemplateAsync(parent, certificateTemplate, certificateTemplateId);

            // Poll until the returned long-running operation is complete
            Operation<CertificateTemplate, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateTemplate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateTemplate, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceCreateCertificateTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateTemplate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateTemplate</summary>
        public void DeleteCertificateTemplateRequestObject()
        {
            // Snippet: DeleteCertificateTemplate(DeleteCertificateTemplateRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            DeleteCertificateTemplateRequest request = new DeleteCertificateTemplateRequest
            {
                CertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = certificateAuthorityServiceClient.DeleteCertificateTemplate(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceDeleteCertificateTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateTemplateAsync</summary>
        public async Task DeleteCertificateTemplateRequestObjectAsync()
        {
            // Snippet: DeleteCertificateTemplateAsync(DeleteCertificateTemplateRequest, CallSettings)
            // Additional: DeleteCertificateTemplateAsync(DeleteCertificateTemplateRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCertificateTemplateRequest request = new DeleteCertificateTemplateRequest
            {
                CertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await certificateAuthorityServiceClient.DeleteCertificateTemplateAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceDeleteCertificateTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateTemplate</summary>
        public void DeleteCertificateTemplate()
        {
            // Snippet: DeleteCertificateTemplate(string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateTemplates/[CERTIFICATE_TEMPLATE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = certificateAuthorityServiceClient.DeleteCertificateTemplate(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceDeleteCertificateTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateTemplateAsync</summary>
        public async Task DeleteCertificateTemplateAsync()
        {
            // Snippet: DeleteCertificateTemplateAsync(string, CallSettings)
            // Additional: DeleteCertificateTemplateAsync(string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateTemplates/[CERTIFICATE_TEMPLATE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await certificateAuthorityServiceClient.DeleteCertificateTemplateAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceDeleteCertificateTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateTemplate</summary>
        public void DeleteCertificateTemplateResourceNames()
        {
            // Snippet: DeleteCertificateTemplate(CertificateTemplateName, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CertificateTemplateName name = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = certificateAuthorityServiceClient.DeleteCertificateTemplate(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceDeleteCertificateTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCertificateTemplateAsync</summary>
        public async Task DeleteCertificateTemplateResourceNamesAsync()
        {
            // Snippet: DeleteCertificateTemplateAsync(CertificateTemplateName, CallSettings)
            // Additional: DeleteCertificateTemplateAsync(CertificateTemplateName, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CertificateTemplateName name = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await certificateAuthorityServiceClient.DeleteCertificateTemplateAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceDeleteCertificateTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetCertificateTemplate</summary>
        public void GetCertificateTemplateRequestObject()
        {
            // Snippet: GetCertificateTemplate(GetCertificateTemplateRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            GetCertificateTemplateRequest request = new GetCertificateTemplateRequest
            {
                CertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
            };
            // Make the request
            CertificateTemplate response = certificateAuthorityServiceClient.GetCertificateTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateTemplateAsync</summary>
        public async Task GetCertificateTemplateRequestObjectAsync()
        {
            // Snippet: GetCertificateTemplateAsync(GetCertificateTemplateRequest, CallSettings)
            // Additional: GetCertificateTemplateAsync(GetCertificateTemplateRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCertificateTemplateRequest request = new GetCertificateTemplateRequest
            {
                CertificateTemplateName = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]"),
            };
            // Make the request
            CertificateTemplate response = await certificateAuthorityServiceClient.GetCertificateTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateTemplate</summary>
        public void GetCertificateTemplate()
        {
            // Snippet: GetCertificateTemplate(string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateTemplates/[CERTIFICATE_TEMPLATE]";
            // Make the request
            CertificateTemplate response = certificateAuthorityServiceClient.GetCertificateTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateTemplateAsync</summary>
        public async Task GetCertificateTemplateAsync()
        {
            // Snippet: GetCertificateTemplateAsync(string, CallSettings)
            // Additional: GetCertificateTemplateAsync(string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateTemplates/[CERTIFICATE_TEMPLATE]";
            // Make the request
            CertificateTemplate response = await certificateAuthorityServiceClient.GetCertificateTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateTemplate</summary>
        public void GetCertificateTemplateResourceNames()
        {
            // Snippet: GetCertificateTemplate(CertificateTemplateName, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CertificateTemplateName name = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]");
            // Make the request
            CertificateTemplate response = certificateAuthorityServiceClient.GetCertificateTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateTemplateAsync</summary>
        public async Task GetCertificateTemplateResourceNamesAsync()
        {
            // Snippet: GetCertificateTemplateAsync(CertificateTemplateName, CallSettings)
            // Additional: GetCertificateTemplateAsync(CertificateTemplateName, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CertificateTemplateName name = CertificateTemplateName.FromProjectLocationCertificateTemplate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_TEMPLATE]");
            // Make the request
            CertificateTemplate response = await certificateAuthorityServiceClient.GetCertificateTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCertificateTemplates</summary>
        public void ListCertificateTemplatesRequestObject()
        {
            // Snippet: ListCertificateTemplates(ListCertificateTemplatesRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            ListCertificateTemplatesRequest request = new ListCertificateTemplatesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListCertificateTemplatesResponse, CertificateTemplate> response = certificateAuthorityServiceClient.ListCertificateTemplates(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CertificateTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCertificateTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificateTemplatesAsync</summary>
        public async Task ListCertificateTemplatesRequestObjectAsync()
        {
            // Snippet: ListCertificateTemplatesAsync(ListCertificateTemplatesRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCertificateTemplatesRequest request = new ListCertificateTemplatesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCertificateTemplatesResponse, CertificateTemplate> response = certificateAuthorityServiceClient.ListCertificateTemplatesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CertificateTemplate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCertificateTemplatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificateTemplates</summary>
        public void ListCertificateTemplates()
        {
            // Snippet: ListCertificateTemplates(string, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListCertificateTemplatesResponse, CertificateTemplate> response = certificateAuthorityServiceClient.ListCertificateTemplates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CertificateTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCertificateTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificateTemplatesAsync</summary>
        public async Task ListCertificateTemplatesAsync()
        {
            // Snippet: ListCertificateTemplatesAsync(string, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListCertificateTemplatesResponse, CertificateTemplate> response = certificateAuthorityServiceClient.ListCertificateTemplatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CertificateTemplate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCertificateTemplatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificateTemplates</summary>
        public void ListCertificateTemplatesResourceNames()
        {
            // Snippet: ListCertificateTemplates(LocationName, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListCertificateTemplatesResponse, CertificateTemplate> response = certificateAuthorityServiceClient.ListCertificateTemplates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CertificateTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCertificateTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCertificateTemplatesAsync</summary>
        public async Task ListCertificateTemplatesResourceNamesAsync()
        {
            // Snippet: ListCertificateTemplatesAsync(LocationName, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListCertificateTemplatesResponse, CertificateTemplate> response = certificateAuthorityServiceClient.ListCertificateTemplatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CertificateTemplate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCertificateTemplatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CertificateTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CertificateTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CertificateTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificateTemplate</summary>
        public void UpdateCertificateTemplateRequestObject()
        {
            // Snippet: UpdateCertificateTemplate(UpdateCertificateTemplateRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            UpdateCertificateTemplateRequest request = new UpdateCertificateTemplateRequest
            {
                CertificateTemplate = new CertificateTemplate(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<CertificateTemplate, OperationMetadata> response = certificateAuthorityServiceClient.UpdateCertificateTemplate(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateTemplate, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateTemplate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateTemplate, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceUpdateCertificateTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateTemplate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificateTemplateAsync</summary>
        public async Task UpdateCertificateTemplateRequestObjectAsync()
        {
            // Snippet: UpdateCertificateTemplateAsync(UpdateCertificateTemplateRequest, CallSettings)
            // Additional: UpdateCertificateTemplateAsync(UpdateCertificateTemplateRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCertificateTemplateRequest request = new UpdateCertificateTemplateRequest
            {
                CertificateTemplate = new CertificateTemplate(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<CertificateTemplate, OperationMetadata> response = await certificateAuthorityServiceClient.UpdateCertificateTemplateAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateTemplate, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateTemplate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateTemplate, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceUpdateCertificateTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateTemplate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificateTemplate</summary>
        public void UpdateCertificateTemplate()
        {
            // Snippet: UpdateCertificateTemplate(CertificateTemplate, FieldMask, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CertificateTemplate certificateTemplate = new CertificateTemplate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<CertificateTemplate, OperationMetadata> response = certificateAuthorityServiceClient.UpdateCertificateTemplate(certificateTemplate, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<CertificateTemplate, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateTemplate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateTemplate, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceUpdateCertificateTemplate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateTemplate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCertificateTemplateAsync</summary>
        public async Task UpdateCertificateTemplateAsync()
        {
            // Snippet: UpdateCertificateTemplateAsync(CertificateTemplate, FieldMask, CallSettings)
            // Additional: UpdateCertificateTemplateAsync(CertificateTemplate, FieldMask, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CertificateTemplate certificateTemplate = new CertificateTemplate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<CertificateTemplate, OperationMetadata> response = await certificateAuthorityServiceClient.UpdateCertificateTemplateAsync(certificateTemplate, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<CertificateTemplate, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateTemplate result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateTemplate, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceUpdateCertificateTemplateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateTemplate retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
