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
    using Google.Cloud.ParameterManager.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
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
            await response.ForEachAsync((Parameter item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListParametersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Parameter item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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
            await response.ForEachAsync((Parameter item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListParametersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Parameter item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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
            await response.ForEachAsync((Parameter item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListParametersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Parameter item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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
            await response.ForEachAsync((ParameterVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListParameterVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ParameterVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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
            await response.ForEachAsync((ParameterVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListParameterVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ParameterVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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
            await response.ForEachAsync((ParameterVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListParameterVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ParameterVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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
    }
}
