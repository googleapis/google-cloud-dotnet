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

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.ParameterManager.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedParameterManagerClientSnippets
    {
        /// <summary>Snippet for ListParameters</summary>
        public void ListParametersRequestObject()
        {
            // Snippet: ListParameters(ListParametersRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            ListParametersRequest request = new ListParametersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListParametersResponse, Parameter> response = parameterManagerClient.ListParameters(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Parameter item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListParametersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Parameter item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Parameter> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Parameter item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListParametersAsync</summary>
        public async Task ListParametersRequestObjectAsync()
        {
            // Snippet: ListParametersAsync(ListParametersRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListParametersRequest request = new ListParametersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListParametersResponse, Parameter> response = parameterManagerClient.ListParametersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Parameter item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListParametersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Parameter item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Parameter> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Parameter item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListParameters</summary>
        public void ListParameters()
        {
            // Snippet: ListParameters(string, string, int?, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListParametersResponse, Parameter> response = parameterManagerClient.ListParameters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Parameter item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListParametersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Parameter item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Parameter> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Parameter item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListParametersAsync</summary>
        public async Task ListParametersAsync()
        {
            // Snippet: ListParametersAsync(string, string, int?, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListParametersResponse, Parameter> response = parameterManagerClient.ListParametersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Parameter item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListParametersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Parameter item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Parameter> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Parameter item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListParameters</summary>
        public void ListParametersResourceNames()
        {
            // Snippet: ListParameters(LocationName, string, int?, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListParametersResponse, Parameter> response = parameterManagerClient.ListParameters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Parameter item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListParametersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Parameter item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Parameter> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Parameter item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListParametersAsync</summary>
        public async Task ListParametersResourceNamesAsync()
        {
            // Snippet: ListParametersAsync(LocationName, string, int?, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListParametersResponse, Parameter> response = parameterManagerClient.ListParametersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Parameter item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListParametersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Parameter item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Parameter> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Parameter item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetParameter</summary>
        public void GetParameterRequestObject()
        {
            // Snippet: GetParameter(GetParameterRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            GetParameterRequest request = new GetParameterRequest
            {
                ParameterName = ParameterName.FromProjectLocationParameter("[PROJECT]", "[LOCATION]", "[PARAMETER]"),
            };
            // Make the request
            Parameter response = parameterManagerClient.GetParameter(request);
            // End snippet
        }

        /// <summary>Snippet for GetParameterAsync</summary>
        public async Task GetParameterRequestObjectAsync()
        {
            // Snippet: GetParameterAsync(GetParameterRequest, CallSettings)
            // Additional: GetParameterAsync(GetParameterRequest, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetParameterRequest request = new GetParameterRequest
            {
                ParameterName = ParameterName.FromProjectLocationParameter("[PROJECT]", "[LOCATION]", "[PARAMETER]"),
            };
            // Make the request
            Parameter response = await parameterManagerClient.GetParameterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetParameter</summary>
        public void GetParameter()
        {
            // Snippet: GetParameter(string, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/parameters/[PARAMETER]";
            // Make the request
            Parameter response = parameterManagerClient.GetParameter(name);
            // End snippet
        }

        /// <summary>Snippet for GetParameterAsync</summary>
        public async Task GetParameterAsync()
        {
            // Snippet: GetParameterAsync(string, CallSettings)
            // Additional: GetParameterAsync(string, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/parameters/[PARAMETER]";
            // Make the request
            Parameter response = await parameterManagerClient.GetParameterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetParameter</summary>
        public void GetParameterResourceNames()
        {
            // Snippet: GetParameter(ParameterName, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            ParameterName name = ParameterName.FromProjectLocationParameter("[PROJECT]", "[LOCATION]", "[PARAMETER]");
            // Make the request
            Parameter response = parameterManagerClient.GetParameter(name);
            // End snippet
        }

        /// <summary>Snippet for GetParameterAsync</summary>
        public async Task GetParameterResourceNamesAsync()
        {
            // Snippet: GetParameterAsync(ParameterName, CallSettings)
            // Additional: GetParameterAsync(ParameterName, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            ParameterName name = ParameterName.FromProjectLocationParameter("[PROJECT]", "[LOCATION]", "[PARAMETER]");
            // Make the request
            Parameter response = await parameterManagerClient.GetParameterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateParameter</summary>
        public void CreateParameterRequestObject()
        {
            // Snippet: CreateParameter(CreateParameterRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            CreateParameterRequest request = new CreateParameterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ParameterId = "",
                Parameter = new Parameter(),
                RequestId = "",
            };
            // Make the request
            Parameter response = parameterManagerClient.CreateParameter(request);
            // End snippet
        }

        /// <summary>Snippet for CreateParameterAsync</summary>
        public async Task CreateParameterRequestObjectAsync()
        {
            // Snippet: CreateParameterAsync(CreateParameterRequest, CallSettings)
            // Additional: CreateParameterAsync(CreateParameterRequest, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateParameterRequest request = new CreateParameterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ParameterId = "",
                Parameter = new Parameter(),
                RequestId = "",
            };
            // Make the request
            Parameter response = await parameterManagerClient.CreateParameterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateParameter</summary>
        public void CreateParameter()
        {
            // Snippet: CreateParameter(string, Parameter, string, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Parameter parameter = new Parameter();
            string parameterId = "";
            // Make the request
            Parameter response = parameterManagerClient.CreateParameter(parent, parameter, parameterId);
            // End snippet
        }

        /// <summary>Snippet for CreateParameterAsync</summary>
        public async Task CreateParameterAsync()
        {
            // Snippet: CreateParameterAsync(string, Parameter, string, CallSettings)
            // Additional: CreateParameterAsync(string, Parameter, string, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Parameter parameter = new Parameter();
            string parameterId = "";
            // Make the request
            Parameter response = await parameterManagerClient.CreateParameterAsync(parent, parameter, parameterId);
            // End snippet
        }

        /// <summary>Snippet for CreateParameter</summary>
        public void CreateParameterResourceNames()
        {
            // Snippet: CreateParameter(LocationName, Parameter, string, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Parameter parameter = new Parameter();
            string parameterId = "";
            // Make the request
            Parameter response = parameterManagerClient.CreateParameter(parent, parameter, parameterId);
            // End snippet
        }

        /// <summary>Snippet for CreateParameterAsync</summary>
        public async Task CreateParameterResourceNamesAsync()
        {
            // Snippet: CreateParameterAsync(LocationName, Parameter, string, CallSettings)
            // Additional: CreateParameterAsync(LocationName, Parameter, string, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Parameter parameter = new Parameter();
            string parameterId = "";
            // Make the request
            Parameter response = await parameterManagerClient.CreateParameterAsync(parent, parameter, parameterId);
            // End snippet
        }

        /// <summary>Snippet for UpdateParameter</summary>
        public void UpdateParameterRequestObject()
        {
            // Snippet: UpdateParameter(UpdateParameterRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            UpdateParameterRequest request = new UpdateParameterRequest
            {
                UpdateMask = new FieldMask(),
                Parameter = new Parameter(),
                RequestId = "",
            };
            // Make the request
            Parameter response = parameterManagerClient.UpdateParameter(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateParameterAsync</summary>
        public async Task UpdateParameterRequestObjectAsync()
        {
            // Snippet: UpdateParameterAsync(UpdateParameterRequest, CallSettings)
            // Additional: UpdateParameterAsync(UpdateParameterRequest, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateParameterRequest request = new UpdateParameterRequest
            {
                UpdateMask = new FieldMask(),
                Parameter = new Parameter(),
                RequestId = "",
            };
            // Make the request
            Parameter response = await parameterManagerClient.UpdateParameterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateParameter</summary>
        public void UpdateParameter()
        {
            // Snippet: UpdateParameter(Parameter, FieldMask, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            Parameter parameter = new Parameter();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Parameter response = parameterManagerClient.UpdateParameter(parameter, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateParameterAsync</summary>
        public async Task UpdateParameterAsync()
        {
            // Snippet: UpdateParameterAsync(Parameter, FieldMask, CallSettings)
            // Additional: UpdateParameterAsync(Parameter, FieldMask, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            Parameter parameter = new Parameter();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Parameter response = await parameterManagerClient.UpdateParameterAsync(parameter, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteParameter</summary>
        public void DeleteParameterRequestObject()
        {
            // Snippet: DeleteParameter(DeleteParameterRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            DeleteParameterRequest request = new DeleteParameterRequest
            {
                ParameterName = ParameterName.FromProjectLocationParameter("[PROJECT]", "[LOCATION]", "[PARAMETER]"),
                RequestId = "",
            };
            // Make the request
            parameterManagerClient.DeleteParameter(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteParameterAsync</summary>
        public async Task DeleteParameterRequestObjectAsync()
        {
            // Snippet: DeleteParameterAsync(DeleteParameterRequest, CallSettings)
            // Additional: DeleteParameterAsync(DeleteParameterRequest, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteParameterRequest request = new DeleteParameterRequest
            {
                ParameterName = ParameterName.FromProjectLocationParameter("[PROJECT]", "[LOCATION]", "[PARAMETER]"),
                RequestId = "",
            };
            // Make the request
            await parameterManagerClient.DeleteParameterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteParameter</summary>
        public void DeleteParameter()
        {
            // Snippet: DeleteParameter(string, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/parameters/[PARAMETER]";
            // Make the request
            parameterManagerClient.DeleteParameter(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteParameterAsync</summary>
        public async Task DeleteParameterAsync()
        {
            // Snippet: DeleteParameterAsync(string, CallSettings)
            // Additional: DeleteParameterAsync(string, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/parameters/[PARAMETER]";
            // Make the request
            await parameterManagerClient.DeleteParameterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteParameter</summary>
        public void DeleteParameterResourceNames()
        {
            // Snippet: DeleteParameter(ParameterName, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            ParameterName name = ParameterName.FromProjectLocationParameter("[PROJECT]", "[LOCATION]", "[PARAMETER]");
            // Make the request
            parameterManagerClient.DeleteParameter(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteParameterAsync</summary>
        public async Task DeleteParameterResourceNamesAsync()
        {
            // Snippet: DeleteParameterAsync(ParameterName, CallSettings)
            // Additional: DeleteParameterAsync(ParameterName, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            ParameterName name = ParameterName.FromProjectLocationParameter("[PROJECT]", "[LOCATION]", "[PARAMETER]");
            // Make the request
            await parameterManagerClient.DeleteParameterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListParameterVersions</summary>
        public void ListParameterVersionsRequestObject()
        {
            // Snippet: ListParameterVersions(ListParameterVersionsRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            ListParameterVersionsRequest request = new ListParameterVersionsRequest
            {
                ParentAsParameterName = ParameterName.FromProjectLocationParameter("[PROJECT]", "[LOCATION]", "[PARAMETER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListParameterVersionsResponse, ParameterVersion> response = parameterManagerClient.ListParameterVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ParameterVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListParameterVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ParameterVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ParameterVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ParameterVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListParameterVersionsAsync</summary>
        public async Task ListParameterVersionsRequestObjectAsync()
        {
            // Snippet: ListParameterVersionsAsync(ListParameterVersionsRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListParameterVersionsRequest request = new ListParameterVersionsRequest
            {
                ParentAsParameterName = ParameterName.FromProjectLocationParameter("[PROJECT]", "[LOCATION]", "[PARAMETER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListParameterVersionsResponse, ParameterVersion> response = parameterManagerClient.ListParameterVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ParameterVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListParameterVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ParameterVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ParameterVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ParameterVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListParameterVersions</summary>
        public void ListParameterVersions()
        {
            // Snippet: ListParameterVersions(string, string, int?, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/parameters/[PARAMETER]";
            // Make the request
            PagedEnumerable<ListParameterVersionsResponse, ParameterVersion> response = parameterManagerClient.ListParameterVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ParameterVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListParameterVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ParameterVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ParameterVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ParameterVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListParameterVersionsAsync</summary>
        public async Task ListParameterVersionsAsync()
        {
            // Snippet: ListParameterVersionsAsync(string, string, int?, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/parameters/[PARAMETER]";
            // Make the request
            PagedAsyncEnumerable<ListParameterVersionsResponse, ParameterVersion> response = parameterManagerClient.ListParameterVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ParameterVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListParameterVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ParameterVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ParameterVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ParameterVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListParameterVersions</summary>
        public void ListParameterVersionsResourceNames()
        {
            // Snippet: ListParameterVersions(ParameterName, string, int?, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            ParameterName parent = ParameterName.FromProjectLocationParameter("[PROJECT]", "[LOCATION]", "[PARAMETER]");
            // Make the request
            PagedEnumerable<ListParameterVersionsResponse, ParameterVersion> response = parameterManagerClient.ListParameterVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ParameterVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListParameterVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ParameterVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ParameterVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ParameterVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListParameterVersionsAsync</summary>
        public async Task ListParameterVersionsResourceNamesAsync()
        {
            // Snippet: ListParameterVersionsAsync(ParameterName, string, int?, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            ParameterName parent = ParameterName.FromProjectLocationParameter("[PROJECT]", "[LOCATION]", "[PARAMETER]");
            // Make the request
            PagedAsyncEnumerable<ListParameterVersionsResponse, ParameterVersion> response = parameterManagerClient.ListParameterVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ParameterVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListParameterVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ParameterVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ParameterVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ParameterVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetParameterVersion</summary>
        public void GetParameterVersionRequestObject()
        {
            // Snippet: GetParameterVersion(GetParameterVersionRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            GetParameterVersionRequest request = new GetParameterVersionRequest
            {
                ParameterVersionName = ParameterVersionName.FromProjectLocationParameterParameterVersion("[PROJECT]", "[LOCATION]", "[PARAMETER]", "[PARAMETER_VERSION]"),
                View = View.Unspecified,
            };
            // Make the request
            ParameterVersion response = parameterManagerClient.GetParameterVersion(request);
            // End snippet
        }

        /// <summary>Snippet for GetParameterVersionAsync</summary>
        public async Task GetParameterVersionRequestObjectAsync()
        {
            // Snippet: GetParameterVersionAsync(GetParameterVersionRequest, CallSettings)
            // Additional: GetParameterVersionAsync(GetParameterVersionRequest, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetParameterVersionRequest request = new GetParameterVersionRequest
            {
                ParameterVersionName = ParameterVersionName.FromProjectLocationParameterParameterVersion("[PROJECT]", "[LOCATION]", "[PARAMETER]", "[PARAMETER_VERSION]"),
                View = View.Unspecified,
            };
            // Make the request
            ParameterVersion response = await parameterManagerClient.GetParameterVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetParameterVersion</summary>
        public void GetParameterVersion()
        {
            // Snippet: GetParameterVersion(string, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/parameters/[PARAMETER]/versions/[PARAMETER_VERSION]";
            // Make the request
            ParameterVersion response = parameterManagerClient.GetParameterVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetParameterVersionAsync</summary>
        public async Task GetParameterVersionAsync()
        {
            // Snippet: GetParameterVersionAsync(string, CallSettings)
            // Additional: GetParameterVersionAsync(string, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/parameters/[PARAMETER]/versions/[PARAMETER_VERSION]";
            // Make the request
            ParameterVersion response = await parameterManagerClient.GetParameterVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetParameterVersion</summary>
        public void GetParameterVersionResourceNames()
        {
            // Snippet: GetParameterVersion(ParameterVersionName, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            ParameterVersionName name = ParameterVersionName.FromProjectLocationParameterParameterVersion("[PROJECT]", "[LOCATION]", "[PARAMETER]", "[PARAMETER_VERSION]");
            // Make the request
            ParameterVersion response = parameterManagerClient.GetParameterVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetParameterVersionAsync</summary>
        public async Task GetParameterVersionResourceNamesAsync()
        {
            // Snippet: GetParameterVersionAsync(ParameterVersionName, CallSettings)
            // Additional: GetParameterVersionAsync(ParameterVersionName, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            ParameterVersionName name = ParameterVersionName.FromProjectLocationParameterParameterVersion("[PROJECT]", "[LOCATION]", "[PARAMETER]", "[PARAMETER_VERSION]");
            // Make the request
            ParameterVersion response = await parameterManagerClient.GetParameterVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RenderParameterVersion</summary>
        public void RenderParameterVersionRequestObject()
        {
            // Snippet: RenderParameterVersion(RenderParameterVersionRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            RenderParameterVersionRequest request = new RenderParameterVersionRequest
            {
                ParameterVersionName = ParameterVersionName.FromProjectLocationParameterParameterVersion("[PROJECT]", "[LOCATION]", "[PARAMETER]", "[PARAMETER_VERSION]"),
            };
            // Make the request
            RenderParameterVersionResponse response = parameterManagerClient.RenderParameterVersion(request);
            // End snippet
        }

        /// <summary>Snippet for RenderParameterVersionAsync</summary>
        public async Task RenderParameterVersionRequestObjectAsync()
        {
            // Snippet: RenderParameterVersionAsync(RenderParameterVersionRequest, CallSettings)
            // Additional: RenderParameterVersionAsync(RenderParameterVersionRequest, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            RenderParameterVersionRequest request = new RenderParameterVersionRequest
            {
                ParameterVersionName = ParameterVersionName.FromProjectLocationParameterParameterVersion("[PROJECT]", "[LOCATION]", "[PARAMETER]", "[PARAMETER_VERSION]"),
            };
            // Make the request
            RenderParameterVersionResponse response = await parameterManagerClient.RenderParameterVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RenderParameterVersion</summary>
        public void RenderParameterVersion()
        {
            // Snippet: RenderParameterVersion(string, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/parameters/[PARAMETER]/versions/[PARAMETER_VERSION]";
            // Make the request
            RenderParameterVersionResponse response = parameterManagerClient.RenderParameterVersion(name);
            // End snippet
        }

        /// <summary>Snippet for RenderParameterVersionAsync</summary>
        public async Task RenderParameterVersionAsync()
        {
            // Snippet: RenderParameterVersionAsync(string, CallSettings)
            // Additional: RenderParameterVersionAsync(string, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/parameters/[PARAMETER]/versions/[PARAMETER_VERSION]";
            // Make the request
            RenderParameterVersionResponse response = await parameterManagerClient.RenderParameterVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RenderParameterVersion</summary>
        public void RenderParameterVersionResourceNames()
        {
            // Snippet: RenderParameterVersion(ParameterVersionName, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            ParameterVersionName name = ParameterVersionName.FromProjectLocationParameterParameterVersion("[PROJECT]", "[LOCATION]", "[PARAMETER]", "[PARAMETER_VERSION]");
            // Make the request
            RenderParameterVersionResponse response = parameterManagerClient.RenderParameterVersion(name);
            // End snippet
        }

        /// <summary>Snippet for RenderParameterVersionAsync</summary>
        public async Task RenderParameterVersionResourceNamesAsync()
        {
            // Snippet: RenderParameterVersionAsync(ParameterVersionName, CallSettings)
            // Additional: RenderParameterVersionAsync(ParameterVersionName, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            ParameterVersionName name = ParameterVersionName.FromProjectLocationParameterParameterVersion("[PROJECT]", "[LOCATION]", "[PARAMETER]", "[PARAMETER_VERSION]");
            // Make the request
            RenderParameterVersionResponse response = await parameterManagerClient.RenderParameterVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateParameterVersion</summary>
        public void CreateParameterVersionRequestObject()
        {
            // Snippet: CreateParameterVersion(CreateParameterVersionRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            CreateParameterVersionRequest request = new CreateParameterVersionRequest
            {
                ParentAsParameterName = ParameterName.FromProjectLocationParameter("[PROJECT]", "[LOCATION]", "[PARAMETER]"),
                ParameterVersionId = "",
                ParameterVersion = new ParameterVersion(),
                RequestId = "",
            };
            // Make the request
            ParameterVersion response = parameterManagerClient.CreateParameterVersion(request);
            // End snippet
        }

        /// <summary>Snippet for CreateParameterVersionAsync</summary>
        public async Task CreateParameterVersionRequestObjectAsync()
        {
            // Snippet: CreateParameterVersionAsync(CreateParameterVersionRequest, CallSettings)
            // Additional: CreateParameterVersionAsync(CreateParameterVersionRequest, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateParameterVersionRequest request = new CreateParameterVersionRequest
            {
                ParentAsParameterName = ParameterName.FromProjectLocationParameter("[PROJECT]", "[LOCATION]", "[PARAMETER]"),
                ParameterVersionId = "",
                ParameterVersion = new ParameterVersion(),
                RequestId = "",
            };
            // Make the request
            ParameterVersion response = await parameterManagerClient.CreateParameterVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateParameterVersion</summary>
        public void CreateParameterVersion()
        {
            // Snippet: CreateParameterVersion(string, ParameterVersion, string, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/parameters/[PARAMETER]";
            ParameterVersion parameterVersion = new ParameterVersion();
            string parameterVersionId = "";
            // Make the request
            ParameterVersion response = parameterManagerClient.CreateParameterVersion(parent, parameterVersion, parameterVersionId);
            // End snippet
        }

        /// <summary>Snippet for CreateParameterVersionAsync</summary>
        public async Task CreateParameterVersionAsync()
        {
            // Snippet: CreateParameterVersionAsync(string, ParameterVersion, string, CallSettings)
            // Additional: CreateParameterVersionAsync(string, ParameterVersion, string, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/parameters/[PARAMETER]";
            ParameterVersion parameterVersion = new ParameterVersion();
            string parameterVersionId = "";
            // Make the request
            ParameterVersion response = await parameterManagerClient.CreateParameterVersionAsync(parent, parameterVersion, parameterVersionId);
            // End snippet
        }

        /// <summary>Snippet for CreateParameterVersion</summary>
        public void CreateParameterVersionResourceNames()
        {
            // Snippet: CreateParameterVersion(ParameterName, ParameterVersion, string, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            ParameterName parent = ParameterName.FromProjectLocationParameter("[PROJECT]", "[LOCATION]", "[PARAMETER]");
            ParameterVersion parameterVersion = new ParameterVersion();
            string parameterVersionId = "";
            // Make the request
            ParameterVersion response = parameterManagerClient.CreateParameterVersion(parent, parameterVersion, parameterVersionId);
            // End snippet
        }

        /// <summary>Snippet for CreateParameterVersionAsync</summary>
        public async Task CreateParameterVersionResourceNamesAsync()
        {
            // Snippet: CreateParameterVersionAsync(ParameterName, ParameterVersion, string, CallSettings)
            // Additional: CreateParameterVersionAsync(ParameterName, ParameterVersion, string, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            ParameterName parent = ParameterName.FromProjectLocationParameter("[PROJECT]", "[LOCATION]", "[PARAMETER]");
            ParameterVersion parameterVersion = new ParameterVersion();
            string parameterVersionId = "";
            // Make the request
            ParameterVersion response = await parameterManagerClient.CreateParameterVersionAsync(parent, parameterVersion, parameterVersionId);
            // End snippet
        }

        /// <summary>Snippet for UpdateParameterVersion</summary>
        public void UpdateParameterVersionRequestObject()
        {
            // Snippet: UpdateParameterVersion(UpdateParameterVersionRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            UpdateParameterVersionRequest request = new UpdateParameterVersionRequest
            {
                UpdateMask = new FieldMask(),
                ParameterVersion = new ParameterVersion(),
                RequestId = "",
            };
            // Make the request
            ParameterVersion response = parameterManagerClient.UpdateParameterVersion(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateParameterVersionAsync</summary>
        public async Task UpdateParameterVersionRequestObjectAsync()
        {
            // Snippet: UpdateParameterVersionAsync(UpdateParameterVersionRequest, CallSettings)
            // Additional: UpdateParameterVersionAsync(UpdateParameterVersionRequest, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateParameterVersionRequest request = new UpdateParameterVersionRequest
            {
                UpdateMask = new FieldMask(),
                ParameterVersion = new ParameterVersion(),
                RequestId = "",
            };
            // Make the request
            ParameterVersion response = await parameterManagerClient.UpdateParameterVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateParameterVersion</summary>
        public void UpdateParameterVersion()
        {
            // Snippet: UpdateParameterVersion(ParameterVersion, FieldMask, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            ParameterVersion parameterVersion = new ParameterVersion();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ParameterVersion response = parameterManagerClient.UpdateParameterVersion(parameterVersion, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateParameterVersionAsync</summary>
        public async Task UpdateParameterVersionAsync()
        {
            // Snippet: UpdateParameterVersionAsync(ParameterVersion, FieldMask, CallSettings)
            // Additional: UpdateParameterVersionAsync(ParameterVersion, FieldMask, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            ParameterVersion parameterVersion = new ParameterVersion();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ParameterVersion response = await parameterManagerClient.UpdateParameterVersionAsync(parameterVersion, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteParameterVersion</summary>
        public void DeleteParameterVersionRequestObject()
        {
            // Snippet: DeleteParameterVersion(DeleteParameterVersionRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            DeleteParameterVersionRequest request = new DeleteParameterVersionRequest
            {
                ParameterVersionName = ParameterVersionName.FromProjectLocationParameterParameterVersion("[PROJECT]", "[LOCATION]", "[PARAMETER]", "[PARAMETER_VERSION]"),
                RequestId = "",
            };
            // Make the request
            parameterManagerClient.DeleteParameterVersion(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteParameterVersionAsync</summary>
        public async Task DeleteParameterVersionRequestObjectAsync()
        {
            // Snippet: DeleteParameterVersionAsync(DeleteParameterVersionRequest, CallSettings)
            // Additional: DeleteParameterVersionAsync(DeleteParameterVersionRequest, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteParameterVersionRequest request = new DeleteParameterVersionRequest
            {
                ParameterVersionName = ParameterVersionName.FromProjectLocationParameterParameterVersion("[PROJECT]", "[LOCATION]", "[PARAMETER]", "[PARAMETER_VERSION]"),
                RequestId = "",
            };
            // Make the request
            await parameterManagerClient.DeleteParameterVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteParameterVersion</summary>
        public void DeleteParameterVersion()
        {
            // Snippet: DeleteParameterVersion(string, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/parameters/[PARAMETER]/versions/[PARAMETER_VERSION]";
            // Make the request
            parameterManagerClient.DeleteParameterVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteParameterVersionAsync</summary>
        public async Task DeleteParameterVersionAsync()
        {
            // Snippet: DeleteParameterVersionAsync(string, CallSettings)
            // Additional: DeleteParameterVersionAsync(string, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/parameters/[PARAMETER]/versions/[PARAMETER_VERSION]";
            // Make the request
            await parameterManagerClient.DeleteParameterVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteParameterVersion</summary>
        public void DeleteParameterVersionResourceNames()
        {
            // Snippet: DeleteParameterVersion(ParameterVersionName, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            ParameterVersionName name = ParameterVersionName.FromProjectLocationParameterParameterVersion("[PROJECT]", "[LOCATION]", "[PARAMETER]", "[PARAMETER_VERSION]");
            // Make the request
            parameterManagerClient.DeleteParameterVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteParameterVersionAsync</summary>
        public async Task DeleteParameterVersionResourceNamesAsync()
        {
            // Snippet: DeleteParameterVersionAsync(ParameterVersionName, CallSettings)
            // Additional: DeleteParameterVersionAsync(ParameterVersionName, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            ParameterVersionName name = ParameterVersionName.FromProjectLocationParameterParameterVersion("[PROJECT]", "[LOCATION]", "[PARAMETER]", "[PARAMETER_VERSION]");
            // Make the request
            await parameterManagerClient.DeleteParameterVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTemplates</summary>
        public void ListTemplatesRequestObject()
        {
            // Snippet: ListTemplates(ListTemplatesRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            ListTemplatesRequest request = new ListTemplatesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListTemplatesResponse, Template> response = parameterManagerClient.ListTemplates(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Template item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Template item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Template> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Template item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTemplatesAsync</summary>
        public async Task ListTemplatesRequestObjectAsync()
        {
            // Snippet: ListTemplatesAsync(ListTemplatesRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListTemplatesRequest request = new ListTemplatesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListTemplatesResponse, Template> response = parameterManagerClient.ListTemplatesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Template item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Template item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Template> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Template item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTemplates</summary>
        public void ListTemplates()
        {
            // Snippet: ListTemplates(string, string, int?, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListTemplatesResponse, Template> response = parameterManagerClient.ListTemplates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Template item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Template item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Template> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Template item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTemplatesAsync</summary>
        public async Task ListTemplatesAsync()
        {
            // Snippet: ListTemplatesAsync(string, string, int?, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListTemplatesResponse, Template> response = parameterManagerClient.ListTemplatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Template item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Template item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Template> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Template item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTemplates</summary>
        public void ListTemplatesResourceNames()
        {
            // Snippet: ListTemplates(LocationName, string, int?, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListTemplatesResponse, Template> response = parameterManagerClient.ListTemplates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Template item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Template item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Template> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Template item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTemplatesAsync</summary>
        public async Task ListTemplatesResourceNamesAsync()
        {
            // Snippet: ListTemplatesAsync(LocationName, string, int?, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListTemplatesResponse, Template> response = parameterManagerClient.ListTemplatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Template item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Template item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Template> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Template item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTemplate</summary>
        public void GetTemplateRequestObject()
        {
            // Snippet: GetTemplate(GetTemplateRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            GetTemplateRequest request = new GetTemplateRequest
            {
                TemplateName = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]"),
            };
            // Make the request
            Template response = parameterManagerClient.GetTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for GetTemplateAsync</summary>
        public async Task GetTemplateRequestObjectAsync()
        {
            // Snippet: GetTemplateAsync(GetTemplateRequest, CallSettings)
            // Additional: GetTemplateAsync(GetTemplateRequest, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetTemplateRequest request = new GetTemplateRequest
            {
                TemplateName = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]"),
            };
            // Make the request
            Template response = await parameterManagerClient.GetTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTemplate</summary>
        public void GetTemplate()
        {
            // Snippet: GetTemplate(string, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/templates/[TEMPLATE]";
            // Make the request
            Template response = parameterManagerClient.GetTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetTemplateAsync</summary>
        public async Task GetTemplateAsync()
        {
            // Snippet: GetTemplateAsync(string, CallSettings)
            // Additional: GetTemplateAsync(string, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/templates/[TEMPLATE]";
            // Make the request
            Template response = await parameterManagerClient.GetTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTemplate</summary>
        public void GetTemplateResourceNames()
        {
            // Snippet: GetTemplate(TemplateName, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            TemplateName name = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]");
            // Make the request
            Template response = parameterManagerClient.GetTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetTemplateAsync</summary>
        public async Task GetTemplateResourceNamesAsync()
        {
            // Snippet: GetTemplateAsync(TemplateName, CallSettings)
            // Additional: GetTemplateAsync(TemplateName, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            TemplateName name = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]");
            // Make the request
            Template response = await parameterManagerClient.GetTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTemplate</summary>
        public void CreateTemplateRequestObject()
        {
            // Snippet: CreateTemplate(CreateTemplateRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            CreateTemplateRequest request = new CreateTemplateRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TemplateId = "",
                Template = new Template(),
                RequestId = "",
            };
            // Make the request
            Template response = parameterManagerClient.CreateTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTemplateAsync</summary>
        public async Task CreateTemplateRequestObjectAsync()
        {
            // Snippet: CreateTemplateAsync(CreateTemplateRequest, CallSettings)
            // Additional: CreateTemplateAsync(CreateTemplateRequest, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateTemplateRequest request = new CreateTemplateRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TemplateId = "",
                Template = new Template(),
                RequestId = "",
            };
            // Make the request
            Template response = await parameterManagerClient.CreateTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTemplate</summary>
        public void CreateTemplate()
        {
            // Snippet: CreateTemplate(string, Template, string, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Template template = new Template();
            string templateId = "";
            // Make the request
            Template response = parameterManagerClient.CreateTemplate(parent, template, templateId);
            // End snippet
        }

        /// <summary>Snippet for CreateTemplateAsync</summary>
        public async Task CreateTemplateAsync()
        {
            // Snippet: CreateTemplateAsync(string, Template, string, CallSettings)
            // Additional: CreateTemplateAsync(string, Template, string, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Template template = new Template();
            string templateId = "";
            // Make the request
            Template response = await parameterManagerClient.CreateTemplateAsync(parent, template, templateId);
            // End snippet
        }

        /// <summary>Snippet for CreateTemplate</summary>
        public void CreateTemplateResourceNames()
        {
            // Snippet: CreateTemplate(LocationName, Template, string, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Template template = new Template();
            string templateId = "";
            // Make the request
            Template response = parameterManagerClient.CreateTemplate(parent, template, templateId);
            // End snippet
        }

        /// <summary>Snippet for CreateTemplateAsync</summary>
        public async Task CreateTemplateResourceNamesAsync()
        {
            // Snippet: CreateTemplateAsync(LocationName, Template, string, CallSettings)
            // Additional: CreateTemplateAsync(LocationName, Template, string, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Template template = new Template();
            string templateId = "";
            // Make the request
            Template response = await parameterManagerClient.CreateTemplateAsync(parent, template, templateId);
            // End snippet
        }

        /// <summary>Snippet for UpdateTemplate</summary>
        public void UpdateTemplateRequestObject()
        {
            // Snippet: UpdateTemplate(UpdateTemplateRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            UpdateTemplateRequest request = new UpdateTemplateRequest
            {
                UpdateMask = new FieldMask(),
                Template = new Template(),
                RequestId = "",
            };
            // Make the request
            Template response = parameterManagerClient.UpdateTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTemplateAsync</summary>
        public async Task UpdateTemplateRequestObjectAsync()
        {
            // Snippet: UpdateTemplateAsync(UpdateTemplateRequest, CallSettings)
            // Additional: UpdateTemplateAsync(UpdateTemplateRequest, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTemplateRequest request = new UpdateTemplateRequest
            {
                UpdateMask = new FieldMask(),
                Template = new Template(),
                RequestId = "",
            };
            // Make the request
            Template response = await parameterManagerClient.UpdateTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTemplate</summary>
        public void UpdateTemplate()
        {
            // Snippet: UpdateTemplate(Template, FieldMask, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            Template template = new Template();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Template response = parameterManagerClient.UpdateTemplate(template, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTemplateAsync</summary>
        public async Task UpdateTemplateAsync()
        {
            // Snippet: UpdateTemplateAsync(Template, FieldMask, CallSettings)
            // Additional: UpdateTemplateAsync(Template, FieldMask, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            Template template = new Template();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Template response = await parameterManagerClient.UpdateTemplateAsync(template, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteTemplate</summary>
        public void DeleteTemplateRequestObject()
        {
            // Snippet: DeleteTemplate(DeleteTemplateRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            DeleteTemplateRequest request = new DeleteTemplateRequest
            {
                TemplateName = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]"),
                RequestId = "",
            };
            // Make the request
            parameterManagerClient.DeleteTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTemplateAsync</summary>
        public async Task DeleteTemplateRequestObjectAsync()
        {
            // Snippet: DeleteTemplateAsync(DeleteTemplateRequest, CallSettings)
            // Additional: DeleteTemplateAsync(DeleteTemplateRequest, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTemplateRequest request = new DeleteTemplateRequest
            {
                TemplateName = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]"),
                RequestId = "",
            };
            // Make the request
            await parameterManagerClient.DeleteTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTemplate</summary>
        public void DeleteTemplate()
        {
            // Snippet: DeleteTemplate(string, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/templates/[TEMPLATE]";
            // Make the request
            parameterManagerClient.DeleteTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTemplateAsync</summary>
        public async Task DeleteTemplateAsync()
        {
            // Snippet: DeleteTemplateAsync(string, CallSettings)
            // Additional: DeleteTemplateAsync(string, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/templates/[TEMPLATE]";
            // Make the request
            await parameterManagerClient.DeleteTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTemplate</summary>
        public void DeleteTemplateResourceNames()
        {
            // Snippet: DeleteTemplate(TemplateName, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            TemplateName name = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]");
            // Make the request
            parameterManagerClient.DeleteTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTemplateAsync</summary>
        public async Task DeleteTemplateResourceNamesAsync()
        {
            // Snippet: DeleteTemplateAsync(TemplateName, CallSettings)
            // Additional: DeleteTemplateAsync(TemplateName, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            TemplateName name = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]");
            // Make the request
            await parameterManagerClient.DeleteTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTemplateVersions</summary>
        public void ListTemplateVersionsRequestObject()
        {
            // Snippet: ListTemplateVersions(ListTemplateVersionsRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            ListTemplateVersionsRequest request = new ListTemplateVersionsRequest
            {
                ParentAsTemplateName = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListTemplateVersionsResponse, TemplateVersion> response = parameterManagerClient.ListTemplateVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TemplateVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTemplateVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TemplateVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TemplateVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TemplateVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTemplateVersionsAsync</summary>
        public async Task ListTemplateVersionsRequestObjectAsync()
        {
            // Snippet: ListTemplateVersionsAsync(ListTemplateVersionsRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListTemplateVersionsRequest request = new ListTemplateVersionsRequest
            {
                ParentAsTemplateName = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListTemplateVersionsResponse, TemplateVersion> response = parameterManagerClient.ListTemplateVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (TemplateVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListTemplateVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TemplateVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TemplateVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TemplateVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTemplateVersions</summary>
        public void ListTemplateVersions()
        {
            // Snippet: ListTemplateVersions(string, string, int?, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/templates/[TEMPLATE]";
            // Make the request
            PagedEnumerable<ListTemplateVersionsResponse, TemplateVersion> response = parameterManagerClient.ListTemplateVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TemplateVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTemplateVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TemplateVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TemplateVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TemplateVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTemplateVersionsAsync</summary>
        public async Task ListTemplateVersionsAsync()
        {
            // Snippet: ListTemplateVersionsAsync(string, string, int?, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/templates/[TEMPLATE]";
            // Make the request
            PagedAsyncEnumerable<ListTemplateVersionsResponse, TemplateVersion> response = parameterManagerClient.ListTemplateVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (TemplateVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListTemplateVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TemplateVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TemplateVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TemplateVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTemplateVersions</summary>
        public void ListTemplateVersionsResourceNames()
        {
            // Snippet: ListTemplateVersions(TemplateName, string, int?, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            TemplateName parent = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]");
            // Make the request
            PagedEnumerable<ListTemplateVersionsResponse, TemplateVersion> response = parameterManagerClient.ListTemplateVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TemplateVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTemplateVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TemplateVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TemplateVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TemplateVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTemplateVersionsAsync</summary>
        public async Task ListTemplateVersionsResourceNamesAsync()
        {
            // Snippet: ListTemplateVersionsAsync(TemplateName, string, int?, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            TemplateName parent = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]");
            // Make the request
            PagedAsyncEnumerable<ListTemplateVersionsResponse, TemplateVersion> response = parameterManagerClient.ListTemplateVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (TemplateVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListTemplateVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TemplateVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TemplateVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TemplateVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTemplateVersion</summary>
        public void GetTemplateVersionRequestObject()
        {
            // Snippet: GetTemplateVersion(GetTemplateVersionRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            GetTemplateVersionRequest request = new GetTemplateVersionRequest
            {
                TemplateVersionName = TemplateVersionName.FromProjectLocationTemplateTemplateVersion("[PROJECT]", "[LOCATION]", "[TEMPLATE]", "[TEMPLATE_VERSION]"),
                View = View.Unspecified,
            };
            // Make the request
            TemplateVersion response = parameterManagerClient.GetTemplateVersion(request);
            // End snippet
        }

        /// <summary>Snippet for GetTemplateVersionAsync</summary>
        public async Task GetTemplateVersionRequestObjectAsync()
        {
            // Snippet: GetTemplateVersionAsync(GetTemplateVersionRequest, CallSettings)
            // Additional: GetTemplateVersionAsync(GetTemplateVersionRequest, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetTemplateVersionRequest request = new GetTemplateVersionRequest
            {
                TemplateVersionName = TemplateVersionName.FromProjectLocationTemplateTemplateVersion("[PROJECT]", "[LOCATION]", "[TEMPLATE]", "[TEMPLATE_VERSION]"),
                View = View.Unspecified,
            };
            // Make the request
            TemplateVersion response = await parameterManagerClient.GetTemplateVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTemplateVersion</summary>
        public void GetTemplateVersion()
        {
            // Snippet: GetTemplateVersion(string, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/templates/[TEMPLATE]/versions/[TEMPLATE_VERSION]";
            // Make the request
            TemplateVersion response = parameterManagerClient.GetTemplateVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetTemplateVersionAsync</summary>
        public async Task GetTemplateVersionAsync()
        {
            // Snippet: GetTemplateVersionAsync(string, CallSettings)
            // Additional: GetTemplateVersionAsync(string, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/templates/[TEMPLATE]/versions/[TEMPLATE_VERSION]";
            // Make the request
            TemplateVersion response = await parameterManagerClient.GetTemplateVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTemplateVersion</summary>
        public void GetTemplateVersionResourceNames()
        {
            // Snippet: GetTemplateVersion(TemplateVersionName, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            TemplateVersionName name = TemplateVersionName.FromProjectLocationTemplateTemplateVersion("[PROJECT]", "[LOCATION]", "[TEMPLATE]", "[TEMPLATE_VERSION]");
            // Make the request
            TemplateVersion response = parameterManagerClient.GetTemplateVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetTemplateVersionAsync</summary>
        public async Task GetTemplateVersionResourceNamesAsync()
        {
            // Snippet: GetTemplateVersionAsync(TemplateVersionName, CallSettings)
            // Additional: GetTemplateVersionAsync(TemplateVersionName, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            TemplateVersionName name = TemplateVersionName.FromProjectLocationTemplateTemplateVersion("[PROJECT]", "[LOCATION]", "[TEMPLATE]", "[TEMPLATE_VERSION]");
            // Make the request
            TemplateVersion response = await parameterManagerClient.GetTemplateVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTemplateVersion</summary>
        public void CreateTemplateVersionRequestObject()
        {
            // Snippet: CreateTemplateVersion(CreateTemplateVersionRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            CreateTemplateVersionRequest request = new CreateTemplateVersionRequest
            {
                ParentAsTemplateName = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]"),
                TemplateVersionId = "",
                TemplateVersion = new TemplateVersion(),
                RequestId = "",
            };
            // Make the request
            TemplateVersion response = parameterManagerClient.CreateTemplateVersion(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTemplateVersionAsync</summary>
        public async Task CreateTemplateVersionRequestObjectAsync()
        {
            // Snippet: CreateTemplateVersionAsync(CreateTemplateVersionRequest, CallSettings)
            // Additional: CreateTemplateVersionAsync(CreateTemplateVersionRequest, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateTemplateVersionRequest request = new CreateTemplateVersionRequest
            {
                ParentAsTemplateName = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]"),
                TemplateVersionId = "",
                TemplateVersion = new TemplateVersion(),
                RequestId = "",
            };
            // Make the request
            TemplateVersion response = await parameterManagerClient.CreateTemplateVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTemplateVersion</summary>
        public void CreateTemplateVersion()
        {
            // Snippet: CreateTemplateVersion(string, TemplateVersion, string, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/templates/[TEMPLATE]";
            TemplateVersion templateVersion = new TemplateVersion();
            string templateVersionId = "";
            // Make the request
            TemplateVersion response = parameterManagerClient.CreateTemplateVersion(parent, templateVersion, templateVersionId);
            // End snippet
        }

        /// <summary>Snippet for CreateTemplateVersionAsync</summary>
        public async Task CreateTemplateVersionAsync()
        {
            // Snippet: CreateTemplateVersionAsync(string, TemplateVersion, string, CallSettings)
            // Additional: CreateTemplateVersionAsync(string, TemplateVersion, string, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/templates/[TEMPLATE]";
            TemplateVersion templateVersion = new TemplateVersion();
            string templateVersionId = "";
            // Make the request
            TemplateVersion response = await parameterManagerClient.CreateTemplateVersionAsync(parent, templateVersion, templateVersionId);
            // End snippet
        }

        /// <summary>Snippet for CreateTemplateVersion</summary>
        public void CreateTemplateVersionResourceNames()
        {
            // Snippet: CreateTemplateVersion(TemplateName, TemplateVersion, string, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            TemplateName parent = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]");
            TemplateVersion templateVersion = new TemplateVersion();
            string templateVersionId = "";
            // Make the request
            TemplateVersion response = parameterManagerClient.CreateTemplateVersion(parent, templateVersion, templateVersionId);
            // End snippet
        }

        /// <summary>Snippet for CreateTemplateVersionAsync</summary>
        public async Task CreateTemplateVersionResourceNamesAsync()
        {
            // Snippet: CreateTemplateVersionAsync(TemplateName, TemplateVersion, string, CallSettings)
            // Additional: CreateTemplateVersionAsync(TemplateName, TemplateVersion, string, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            TemplateName parent = TemplateName.FromProjectLocationTemplate("[PROJECT]", "[LOCATION]", "[TEMPLATE]");
            TemplateVersion templateVersion = new TemplateVersion();
            string templateVersionId = "";
            // Make the request
            TemplateVersion response = await parameterManagerClient.CreateTemplateVersionAsync(parent, templateVersion, templateVersionId);
            // End snippet
        }

        /// <summary>Snippet for UpdateTemplateVersion</summary>
        public void UpdateTemplateVersionRequestObject()
        {
            // Snippet: UpdateTemplateVersion(UpdateTemplateVersionRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            UpdateTemplateVersionRequest request = new UpdateTemplateVersionRequest
            {
                UpdateMask = new FieldMask(),
                TemplateVersion = new TemplateVersion(),
                RequestId = "",
            };
            // Make the request
            TemplateVersion response = parameterManagerClient.UpdateTemplateVersion(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTemplateVersionAsync</summary>
        public async Task UpdateTemplateVersionRequestObjectAsync()
        {
            // Snippet: UpdateTemplateVersionAsync(UpdateTemplateVersionRequest, CallSettings)
            // Additional: UpdateTemplateVersionAsync(UpdateTemplateVersionRequest, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTemplateVersionRequest request = new UpdateTemplateVersionRequest
            {
                UpdateMask = new FieldMask(),
                TemplateVersion = new TemplateVersion(),
                RequestId = "",
            };
            // Make the request
            TemplateVersion response = await parameterManagerClient.UpdateTemplateVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTemplateVersion</summary>
        public void UpdateTemplateVersion()
        {
            // Snippet: UpdateTemplateVersion(TemplateVersion, FieldMask, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            TemplateVersion templateVersion = new TemplateVersion();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TemplateVersion response = parameterManagerClient.UpdateTemplateVersion(templateVersion, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTemplateVersionAsync</summary>
        public async Task UpdateTemplateVersionAsync()
        {
            // Snippet: UpdateTemplateVersionAsync(TemplateVersion, FieldMask, CallSettings)
            // Additional: UpdateTemplateVersionAsync(TemplateVersion, FieldMask, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            TemplateVersion templateVersion = new TemplateVersion();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TemplateVersion response = await parameterManagerClient.UpdateTemplateVersionAsync(templateVersion, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteTemplateVersion</summary>
        public void DeleteTemplateVersionRequestObject()
        {
            // Snippet: DeleteTemplateVersion(DeleteTemplateVersionRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            DeleteTemplateVersionRequest request = new DeleteTemplateVersionRequest
            {
                TemplateVersionName = TemplateVersionName.FromProjectLocationTemplateTemplateVersion("[PROJECT]", "[LOCATION]", "[TEMPLATE]", "[TEMPLATE_VERSION]"),
                RequestId = "",
            };
            // Make the request
            parameterManagerClient.DeleteTemplateVersion(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTemplateVersionAsync</summary>
        public async Task DeleteTemplateVersionRequestObjectAsync()
        {
            // Snippet: DeleteTemplateVersionAsync(DeleteTemplateVersionRequest, CallSettings)
            // Additional: DeleteTemplateVersionAsync(DeleteTemplateVersionRequest, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTemplateVersionRequest request = new DeleteTemplateVersionRequest
            {
                TemplateVersionName = TemplateVersionName.FromProjectLocationTemplateTemplateVersion("[PROJECT]", "[LOCATION]", "[TEMPLATE]", "[TEMPLATE_VERSION]"),
                RequestId = "",
            };
            // Make the request
            await parameterManagerClient.DeleteTemplateVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTemplateVersion</summary>
        public void DeleteTemplateVersion()
        {
            // Snippet: DeleteTemplateVersion(string, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/templates/[TEMPLATE]/versions/[TEMPLATE_VERSION]";
            // Make the request
            parameterManagerClient.DeleteTemplateVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTemplateVersionAsync</summary>
        public async Task DeleteTemplateVersionAsync()
        {
            // Snippet: DeleteTemplateVersionAsync(string, CallSettings)
            // Additional: DeleteTemplateVersionAsync(string, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/templates/[TEMPLATE]/versions/[TEMPLATE_VERSION]";
            // Make the request
            await parameterManagerClient.DeleteTemplateVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTemplateVersion</summary>
        public void DeleteTemplateVersionResourceNames()
        {
            // Snippet: DeleteTemplateVersion(TemplateVersionName, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            TemplateVersionName name = TemplateVersionName.FromProjectLocationTemplateTemplateVersion("[PROJECT]", "[LOCATION]", "[TEMPLATE]", "[TEMPLATE_VERSION]");
            // Make the request
            parameterManagerClient.DeleteTemplateVersion(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTemplateVersionAsync</summary>
        public async Task DeleteTemplateVersionResourceNamesAsync()
        {
            // Snippet: DeleteTemplateVersionAsync(TemplateVersionName, CallSettings)
            // Additional: DeleteTemplateVersionAsync(TemplateVersionName, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            TemplateVersionName name = TemplateVersionName.FromProjectLocationTemplateTemplateVersion("[PROJECT]", "[LOCATION]", "[TEMPLATE]", "[TEMPLATE_VERSION]");
            // Make the request
            await parameterManagerClient.DeleteTemplateVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RenderTemplateVersion</summary>
        public void RenderTemplateVersionRequestObject()
        {
            // Snippet: RenderTemplateVersion(RenderTemplateVersionRequest, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            RenderTemplateVersionRequest request = new RenderTemplateVersionRequest
            {
                TemplateVersionName = TemplateVersionName.FromProjectLocationTemplateTemplateVersion("[PROJECT]", "[LOCATION]", "[TEMPLATE]", "[TEMPLATE_VERSION]"),
                ParameterVersionAsParameterVersionName = ParameterVersionName.FromProjectLocationParameterParameterVersion("[PROJECT]", "[LOCATION]", "[PARAMETER]", "[PARAMETER_VERSION]"),
            };
            // Make the request
            RenderTemplateVersionResponse response = parameterManagerClient.RenderTemplateVersion(request);
            // End snippet
        }

        /// <summary>Snippet for RenderTemplateVersionAsync</summary>
        public async Task RenderTemplateVersionRequestObjectAsync()
        {
            // Snippet: RenderTemplateVersionAsync(RenderTemplateVersionRequest, CallSettings)
            // Additional: RenderTemplateVersionAsync(RenderTemplateVersionRequest, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            RenderTemplateVersionRequest request = new RenderTemplateVersionRequest
            {
                TemplateVersionName = TemplateVersionName.FromProjectLocationTemplateTemplateVersion("[PROJECT]", "[LOCATION]", "[TEMPLATE]", "[TEMPLATE_VERSION]"),
                ParameterVersionAsParameterVersionName = ParameterVersionName.FromProjectLocationParameterParameterVersion("[PROJECT]", "[LOCATION]", "[PARAMETER]", "[PARAMETER_VERSION]"),
            };
            // Make the request
            RenderTemplateVersionResponse response = await parameterManagerClient.RenderTemplateVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RenderTemplateVersion</summary>
        public void RenderTemplateVersion()
        {
            // Snippet: RenderTemplateVersion(string, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/templates/[TEMPLATE]/versions/[TEMPLATE_VERSION]";
            // Make the request
            RenderTemplateVersionResponse response = parameterManagerClient.RenderTemplateVersion(name);
            // End snippet
        }

        /// <summary>Snippet for RenderTemplateVersionAsync</summary>
        public async Task RenderTemplateVersionAsync()
        {
            // Snippet: RenderTemplateVersionAsync(string, CallSettings)
            // Additional: RenderTemplateVersionAsync(string, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/templates/[TEMPLATE]/versions/[TEMPLATE_VERSION]";
            // Make the request
            RenderTemplateVersionResponse response = await parameterManagerClient.RenderTemplateVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RenderTemplateVersion</summary>
        public void RenderTemplateVersionResourceNames()
        {
            // Snippet: RenderTemplateVersion(TemplateVersionName, CallSettings)
            // Create client
            ParameterManagerClient parameterManagerClient = ParameterManagerClient.Create();
            // Initialize request argument(s)
            TemplateVersionName name = TemplateVersionName.FromProjectLocationTemplateTemplateVersion("[PROJECT]", "[LOCATION]", "[TEMPLATE]", "[TEMPLATE_VERSION]");
            // Make the request
            RenderTemplateVersionResponse response = parameterManagerClient.RenderTemplateVersion(name);
            // End snippet
        }

        /// <summary>Snippet for RenderTemplateVersionAsync</summary>
        public async Task RenderTemplateVersionResourceNamesAsync()
        {
            // Snippet: RenderTemplateVersionAsync(TemplateVersionName, CallSettings)
            // Additional: RenderTemplateVersionAsync(TemplateVersionName, CancellationToken)
            // Create client
            ParameterManagerClient parameterManagerClient = await ParameterManagerClient.CreateAsync();
            // Initialize request argument(s)
            TemplateVersionName name = TemplateVersionName.FromProjectLocationTemplateTemplateVersion("[PROJECT]", "[LOCATION]", "[TEMPLATE]", "[TEMPLATE_VERSION]");
            // Make the request
            RenderTemplateVersionResponse response = await parameterManagerClient.RenderTemplateVersionAsync(name);
            // End snippet
        }
    }
}
