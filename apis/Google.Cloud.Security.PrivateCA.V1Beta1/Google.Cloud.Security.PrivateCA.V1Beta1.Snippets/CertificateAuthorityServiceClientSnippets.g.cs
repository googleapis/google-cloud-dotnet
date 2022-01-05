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

namespace Google.Cloud.Security.PrivateCA.V1Beta1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCertificateAuthorityServiceClientSnippets
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
                ParentAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                CertificateId = "",
                Certificate = new Certificate(),
                RequestId = "",
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
                ParentAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                CertificateId = "",
                Certificate = new Certificate(),
                RequestId = "",
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
            string parent = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
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
            string parent = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
            Certificate certificate = new Certificate();
            string certificateId = "";
            // Make the request
            Certificate response = await certificateAuthorityServiceClient.CreateCertificateAsync(parent, certificate, certificateId);
            // End snippet
        }

        /// <summary>Snippet for CreateCertificate</summary>
        public void CreateCertificateResourceNames()
        {
            // Snippet: CreateCertificate(CertificateAuthorityName, Certificate, string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CertificateAuthorityName parent = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]");
            Certificate certificate = new Certificate();
            string certificateId = "";
            // Make the request
            Certificate response = certificateAuthorityServiceClient.CreateCertificate(parent, certificate, certificateId);
            // End snippet
        }

        /// <summary>Snippet for CreateCertificateAsync</summary>
        public async Task CreateCertificateResourceNamesAsync()
        {
            // Snippet: CreateCertificateAsync(CertificateAuthorityName, Certificate, string, CallSettings)
            // Additional: CreateCertificateAsync(CertificateAuthorityName, Certificate, string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CertificateAuthorityName parent = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]");
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
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
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
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]/certificates/[CERTIFICATE]";
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]/certificates/[CERTIFICATE]";
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
            CertificateName name = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]");
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
            CertificateName name = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]");
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
                ParentAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
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
                ParentAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
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
            string parent = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
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
            string parent = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
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
            // Snippet: ListCertificates(CertificateAuthorityName, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CertificateAuthorityName parent = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]");
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
            // Snippet: ListCertificatesAsync(CertificateAuthorityName, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CertificateAuthorityName parent = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]");
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
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
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
                CertificateName = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]"),
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]/certificates/[CERTIFICATE]";
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]/certificates/[CERTIFICATE]";
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
            CertificateName name = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]");
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
            CertificateName name = CertificateName.FromProjectLocationCertificateAuthorityCertificate("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE]");
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
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
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
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
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
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]");
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
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]");
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
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
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
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
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
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
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
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
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
            // Snippet: CreateCertificateAuthority(LocationName, CertificateAuthority, string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
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
            // Snippet: CreateCertificateAuthorityAsync(LocationName, CertificateAuthority, string, CallSettings)
            // Additional: CreateCertificateAuthorityAsync(LocationName, CertificateAuthority, string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
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
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                RequestId = "",
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
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                RequestId = "",
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
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
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]");
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
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]");
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
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
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
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
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
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]");
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
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]");
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
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
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
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
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
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]");
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
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]");
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
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
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
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
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
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]");
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
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]");
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
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
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
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
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
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
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
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
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
            // Snippet: ListCertificateAuthorities(LocationName, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
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
            // Snippet: ListCertificateAuthoritiesAsync(LocationName, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
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

        /// <summary>Snippet for RestoreCertificateAuthority</summary>
        public void RestoreCertificateAuthorityRequestObject()
        {
            // Snippet: RestoreCertificateAuthority(RestoreCertificateAuthorityRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            RestoreCertificateAuthorityRequest request = new RestoreCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                RequestId = "",
            };
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.RestoreCertificateAuthority(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceRestoreCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreCertificateAuthorityAsync</summary>
        public async Task RestoreCertificateAuthorityRequestObjectAsync()
        {
            // Snippet: RestoreCertificateAuthorityAsync(RestoreCertificateAuthorityRequest, CallSettings)
            // Additional: RestoreCertificateAuthorityAsync(RestoreCertificateAuthorityRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            RestoreCertificateAuthorityRequest request = new RestoreCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                RequestId = "",
            };
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.RestoreCertificateAuthorityAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceRestoreCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreCertificateAuthority</summary>
        public void RestoreCertificateAuthority()
        {
            // Snippet: RestoreCertificateAuthority(string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.RestoreCertificateAuthority(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceRestoreCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreCertificateAuthorityAsync</summary>
        public async Task RestoreCertificateAuthorityAsync()
        {
            // Snippet: RestoreCertificateAuthorityAsync(string, CallSettings)
            // Additional: RestoreCertificateAuthorityAsync(string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.RestoreCertificateAuthorityAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceRestoreCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreCertificateAuthority</summary>
        public void RestoreCertificateAuthorityResourceNames()
        {
            // Snippet: RestoreCertificateAuthority(CertificateAuthorityName, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]");
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.RestoreCertificateAuthority(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceRestoreCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreCertificateAuthorityAsync</summary>
        public async Task RestoreCertificateAuthorityResourceNamesAsync()
        {
            // Snippet: RestoreCertificateAuthorityAsync(CertificateAuthorityName, CallSettings)
            // Additional: RestoreCertificateAuthorityAsync(CertificateAuthorityName, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]");
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.RestoreCertificateAuthorityAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceRestoreCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ScheduleDeleteCertificateAuthority</summary>
        public void ScheduleDeleteCertificateAuthorityRequestObject()
        {
            // Snippet: ScheduleDeleteCertificateAuthority(ScheduleDeleteCertificateAuthorityRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            ScheduleDeleteCertificateAuthorityRequest request = new ScheduleDeleteCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                RequestId = "",
            };
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.ScheduleDeleteCertificateAuthority(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceScheduleDeleteCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ScheduleDeleteCertificateAuthorityAsync</summary>
        public async Task ScheduleDeleteCertificateAuthorityRequestObjectAsync()
        {
            // Snippet: ScheduleDeleteCertificateAuthorityAsync(ScheduleDeleteCertificateAuthorityRequest, CallSettings)
            // Additional: ScheduleDeleteCertificateAuthorityAsync(ScheduleDeleteCertificateAuthorityRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            ScheduleDeleteCertificateAuthorityRequest request = new ScheduleDeleteCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
                RequestId = "",
            };
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.ScheduleDeleteCertificateAuthorityAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceScheduleDeleteCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ScheduleDeleteCertificateAuthority</summary>
        public void ScheduleDeleteCertificateAuthority()
        {
            // Snippet: ScheduleDeleteCertificateAuthority(string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.ScheduleDeleteCertificateAuthority(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceScheduleDeleteCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ScheduleDeleteCertificateAuthorityAsync</summary>
        public async Task ScheduleDeleteCertificateAuthorityAsync()
        {
            // Snippet: ScheduleDeleteCertificateAuthorityAsync(string, CallSettings)
            // Additional: ScheduleDeleteCertificateAuthorityAsync(string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.ScheduleDeleteCertificateAuthorityAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceScheduleDeleteCertificateAuthorityAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ScheduleDeleteCertificateAuthority</summary>
        public void ScheduleDeleteCertificateAuthorityResourceNames()
        {
            // Snippet: ScheduleDeleteCertificateAuthority(CertificateAuthorityName, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]");
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = certificateAuthorityServiceClient.ScheduleDeleteCertificateAuthority(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = certificateAuthorityServiceClient.PollOnceScheduleDeleteCertificateAuthority(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CertificateAuthority retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ScheduleDeleteCertificateAuthorityAsync</summary>
        public async Task ScheduleDeleteCertificateAuthorityResourceNamesAsync()
        {
            // Snippet: ScheduleDeleteCertificateAuthorityAsync(CertificateAuthorityName, CallSettings)
            // Additional: ScheduleDeleteCertificateAuthorityAsync(CertificateAuthorityName, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]");
            // Make the request
            Operation<CertificateAuthority, OperationMetadata> response = await certificateAuthorityServiceClient.ScheduleDeleteCertificateAuthorityAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<CertificateAuthority, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CertificateAuthority result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CertificateAuthority, OperationMetadata> retrievedResponse = await certificateAuthorityServiceClient.PollOnceScheduleDeleteCertificateAuthorityAsync(operationName);
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

        /// <summary>Snippet for GetCertificateRevocationList</summary>
        public void GetCertificateRevocationListRequestObject()
        {
            // Snippet: GetCertificateRevocationList(GetCertificateRevocationListRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            GetCertificateRevocationListRequest request = new GetCertificateRevocationListRequest
            {
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
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
                CertificateRevocationListName = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]"),
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]/certificateRevocationLists/[CERTIFICATE_REVOCATION_LIST]";
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]/certificateRevocationLists/[CERTIFICATE_REVOCATION_LIST]";
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
            CertificateRevocationListName name = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]");
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
            CertificateRevocationListName name = CertificateRevocationListName.FromProjectLocationCertificateAuthorityCertificateRevocationList("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]", "[CERTIFICATE_REVOCATION_LIST]");
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
                ParentAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
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
                ParentAsCertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]"),
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
            string parent = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
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
            string parent = "projects/[PROJECT]/locations/[LOCATION]/certificateAuthorities/[CERTIFICATE_AUTHORITY]";
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
            CertificateAuthorityName parent = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]");
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
            CertificateAuthorityName parent = CertificateAuthorityName.FromProjectLocationCertificateAuthority("[PROJECT]", "[LOCATION]", "[CERTIFICATE_AUTHORITY]");
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

        /// <summary>Snippet for GetReusableConfig</summary>
        public void GetReusableConfigRequestObject()
        {
            // Snippet: GetReusableConfig(GetReusableConfigRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            GetReusableConfigRequest request = new GetReusableConfigRequest
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
            };
            // Make the request
            ReusableConfig response = certificateAuthorityServiceClient.GetReusableConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetReusableConfigAsync</summary>
        public async Task GetReusableConfigRequestObjectAsync()
        {
            // Snippet: GetReusableConfigAsync(GetReusableConfigRequest, CallSettings)
            // Additional: GetReusableConfigAsync(GetReusableConfigRequest, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetReusableConfigRequest request = new GetReusableConfigRequest
            {
                ReusableConfigName = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]"),
            };
            // Make the request
            ReusableConfig response = await certificateAuthorityServiceClient.GetReusableConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetReusableConfig</summary>
        public void GetReusableConfig()
        {
            // Snippet: GetReusableConfig(string, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reusableConfigs/[REUSABLE_CONFIG]";
            // Make the request
            ReusableConfig response = certificateAuthorityServiceClient.GetReusableConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetReusableConfigAsync</summary>
        public async Task GetReusableConfigAsync()
        {
            // Snippet: GetReusableConfigAsync(string, CallSettings)
            // Additional: GetReusableConfigAsync(string, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reusableConfigs/[REUSABLE_CONFIG]";
            // Make the request
            ReusableConfig response = await certificateAuthorityServiceClient.GetReusableConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetReusableConfig</summary>
        public void GetReusableConfigResourceNames()
        {
            // Snippet: GetReusableConfig(ReusableConfigName, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            ReusableConfigName name = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]");
            // Make the request
            ReusableConfig response = certificateAuthorityServiceClient.GetReusableConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetReusableConfigAsync</summary>
        public async Task GetReusableConfigResourceNamesAsync()
        {
            // Snippet: GetReusableConfigAsync(ReusableConfigName, CallSettings)
            // Additional: GetReusableConfigAsync(ReusableConfigName, CancellationToken)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReusableConfigName name = ReusableConfigName.FromProjectLocationReusableConfig("[PROJECT]", "[LOCATION]", "[REUSABLE_CONFIG]");
            // Make the request
            ReusableConfig response = await certificateAuthorityServiceClient.GetReusableConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListReusableConfigs</summary>
        public void ListReusableConfigsRequestObject()
        {
            // Snippet: ListReusableConfigs(ListReusableConfigsRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            ListReusableConfigsRequest request = new ListReusableConfigsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListReusableConfigsResponse, ReusableConfig> response = certificateAuthorityServiceClient.ListReusableConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReusableConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReusableConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReusableConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReusableConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReusableConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReusableConfigsAsync</summary>
        public async Task ListReusableConfigsRequestObjectAsync()
        {
            // Snippet: ListReusableConfigsAsync(ListReusableConfigsRequest, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListReusableConfigsRequest request = new ListReusableConfigsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListReusableConfigsResponse, ReusableConfig> response = certificateAuthorityServiceClient.ListReusableConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReusableConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReusableConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReusableConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReusableConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReusableConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReusableConfigs</summary>
        public void ListReusableConfigs()
        {
            // Snippet: ListReusableConfigs(string, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListReusableConfigsResponse, ReusableConfig> response = certificateAuthorityServiceClient.ListReusableConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReusableConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReusableConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReusableConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReusableConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReusableConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReusableConfigsAsync</summary>
        public async Task ListReusableConfigsAsync()
        {
            // Snippet: ListReusableConfigsAsync(string, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListReusableConfigsResponse, ReusableConfig> response = certificateAuthorityServiceClient.ListReusableConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReusableConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReusableConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReusableConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReusableConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReusableConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReusableConfigs</summary>
        public void ListReusableConfigsResourceNames()
        {
            // Snippet: ListReusableConfigs(LocationName, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = CertificateAuthorityServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListReusableConfigsResponse, ReusableConfig> response = certificateAuthorityServiceClient.ListReusableConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReusableConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReusableConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReusableConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReusableConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReusableConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReusableConfigsAsync</summary>
        public async Task ListReusableConfigsResourceNamesAsync()
        {
            // Snippet: ListReusableConfigsAsync(LocationName, string, int?, CallSettings)
            // Create client
            CertificateAuthorityServiceClient certificateAuthorityServiceClient = await CertificateAuthorityServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListReusableConfigsResponse, ReusableConfig> response = certificateAuthorityServiceClient.ListReusableConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReusableConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReusableConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReusableConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReusableConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReusableConfig item in singlePage)
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
