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
    using Google.Cloud.LicenseManager.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedLicenseManagerClientSnippets
    {
        /// <summary>Snippet for ListConfigurations</summary>
        public void ListConfigurationsRequestObject()
        {
            // Snippet: ListConfigurations(ListConfigurationsRequest, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            ListConfigurationsRequest request = new ListConfigurationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListConfigurationsResponse, Configuration> response = licenseManagerClient.ListConfigurations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Configuration item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConfigurationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Configuration item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Configuration> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Configuration item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConfigurationsAsync</summary>
        public async Task ListConfigurationsRequestObjectAsync()
        {
            // Snippet: ListConfigurationsAsync(ListConfigurationsRequest, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListConfigurationsRequest request = new ListConfigurationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListConfigurationsResponse, Configuration> response = licenseManagerClient.ListConfigurationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Configuration item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConfigurationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Configuration item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Configuration> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Configuration item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConfigurations</summary>
        public void ListConfigurations()
        {
            // Snippet: ListConfigurations(string, string, int?, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListConfigurationsResponse, Configuration> response = licenseManagerClient.ListConfigurations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Configuration item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConfigurationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Configuration item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Configuration> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Configuration item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConfigurationsAsync</summary>
        public async Task ListConfigurationsAsync()
        {
            // Snippet: ListConfigurationsAsync(string, string, int?, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListConfigurationsResponse, Configuration> response = licenseManagerClient.ListConfigurationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Configuration item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConfigurationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Configuration item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Configuration> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Configuration item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConfigurations</summary>
        public void ListConfigurationsResourceNames()
        {
            // Snippet: ListConfigurations(LocationName, string, int?, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListConfigurationsResponse, Configuration> response = licenseManagerClient.ListConfigurations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Configuration item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConfigurationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Configuration item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Configuration> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Configuration item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConfigurationsAsync</summary>
        public async Task ListConfigurationsResourceNamesAsync()
        {
            // Snippet: ListConfigurationsAsync(LocationName, string, int?, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListConfigurationsResponse, Configuration> response = licenseManagerClient.ListConfigurationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Configuration item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConfigurationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Configuration item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Configuration> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Configuration item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetConfiguration</summary>
        public void GetConfigurationRequestObject()
        {
            // Snippet: GetConfiguration(GetConfigurationRequest, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            GetConfigurationRequest request = new GetConfigurationRequest
            {
                ConfigurationName = ConfigurationName.FromProjectLocationConfiguration("[PROJECT]", "[LOCATION]", "[CONFIGURATION]"),
            };
            // Make the request
            Configuration response = licenseManagerClient.GetConfiguration(request);
            // End snippet
        }

        /// <summary>Snippet for GetConfigurationAsync</summary>
        public async Task GetConfigurationRequestObjectAsync()
        {
            // Snippet: GetConfigurationAsync(GetConfigurationRequest, CallSettings)
            // Additional: GetConfigurationAsync(GetConfigurationRequest, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetConfigurationRequest request = new GetConfigurationRequest
            {
                ConfigurationName = ConfigurationName.FromProjectLocationConfiguration("[PROJECT]", "[LOCATION]", "[CONFIGURATION]"),
            };
            // Make the request
            Configuration response = await licenseManagerClient.GetConfigurationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConfiguration</summary>
        public void GetConfiguration()
        {
            // Snippet: GetConfiguration(string, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/configurations/[CONFIGURATION]";
            // Make the request
            Configuration response = licenseManagerClient.GetConfiguration(name);
            // End snippet
        }

        /// <summary>Snippet for GetConfigurationAsync</summary>
        public async Task GetConfigurationAsync()
        {
            // Snippet: GetConfigurationAsync(string, CallSettings)
            // Additional: GetConfigurationAsync(string, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/configurations/[CONFIGURATION]";
            // Make the request
            Configuration response = await licenseManagerClient.GetConfigurationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConfiguration</summary>
        public void GetConfigurationResourceNames()
        {
            // Snippet: GetConfiguration(ConfigurationName, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            ConfigurationName name = ConfigurationName.FromProjectLocationConfiguration("[PROJECT]", "[LOCATION]", "[CONFIGURATION]");
            // Make the request
            Configuration response = licenseManagerClient.GetConfiguration(name);
            // End snippet
        }

        /// <summary>Snippet for GetConfigurationAsync</summary>
        public async Task GetConfigurationResourceNamesAsync()
        {
            // Snippet: GetConfigurationAsync(ConfigurationName, CallSettings)
            // Additional: GetConfigurationAsync(ConfigurationName, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            ConfigurationName name = ConfigurationName.FromProjectLocationConfiguration("[PROJECT]", "[LOCATION]", "[CONFIGURATION]");
            // Make the request
            Configuration response = await licenseManagerClient.GetConfigurationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateConfiguration</summary>
        public void CreateConfigurationRequestObject()
        {
            // Snippet: CreateConfiguration(CreateConfigurationRequest, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            CreateConfigurationRequest request = new CreateConfigurationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConfigurationId = "",
                Configuration = new Configuration(),
                RequestId = "",
            };
            // Make the request
            Operation<Configuration, OperationMetadata> response = licenseManagerClient.CreateConfiguration(request);

            // Poll until the returned long-running operation is complete
            Operation<Configuration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Configuration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Configuration, OperationMetadata> retrievedResponse = licenseManagerClient.PollOnceCreateConfiguration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Configuration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConfigurationAsync</summary>
        public async Task CreateConfigurationRequestObjectAsync()
        {
            // Snippet: CreateConfigurationAsync(CreateConfigurationRequest, CallSettings)
            // Additional: CreateConfigurationAsync(CreateConfigurationRequest, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateConfigurationRequest request = new CreateConfigurationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConfigurationId = "",
                Configuration = new Configuration(),
                RequestId = "",
            };
            // Make the request
            Operation<Configuration, OperationMetadata> response = await licenseManagerClient.CreateConfigurationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Configuration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Configuration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Configuration, OperationMetadata> retrievedResponse = await licenseManagerClient.PollOnceCreateConfigurationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Configuration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConfiguration</summary>
        public void CreateConfiguration()
        {
            // Snippet: CreateConfiguration(string, Configuration, string, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Configuration configuration = new Configuration();
            string configurationId = "";
            // Make the request
            Operation<Configuration, OperationMetadata> response = licenseManagerClient.CreateConfiguration(parent, configuration, configurationId);

            // Poll until the returned long-running operation is complete
            Operation<Configuration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Configuration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Configuration, OperationMetadata> retrievedResponse = licenseManagerClient.PollOnceCreateConfiguration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Configuration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConfigurationAsync</summary>
        public async Task CreateConfigurationAsync()
        {
            // Snippet: CreateConfigurationAsync(string, Configuration, string, CallSettings)
            // Additional: CreateConfigurationAsync(string, Configuration, string, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Configuration configuration = new Configuration();
            string configurationId = "";
            // Make the request
            Operation<Configuration, OperationMetadata> response = await licenseManagerClient.CreateConfigurationAsync(parent, configuration, configurationId);

            // Poll until the returned long-running operation is complete
            Operation<Configuration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Configuration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Configuration, OperationMetadata> retrievedResponse = await licenseManagerClient.PollOnceCreateConfigurationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Configuration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConfiguration</summary>
        public void CreateConfigurationResourceNames()
        {
            // Snippet: CreateConfiguration(LocationName, Configuration, string, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Configuration configuration = new Configuration();
            string configurationId = "";
            // Make the request
            Operation<Configuration, OperationMetadata> response = licenseManagerClient.CreateConfiguration(parent, configuration, configurationId);

            // Poll until the returned long-running operation is complete
            Operation<Configuration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Configuration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Configuration, OperationMetadata> retrievedResponse = licenseManagerClient.PollOnceCreateConfiguration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Configuration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConfigurationAsync</summary>
        public async Task CreateConfigurationResourceNamesAsync()
        {
            // Snippet: CreateConfigurationAsync(LocationName, Configuration, string, CallSettings)
            // Additional: CreateConfigurationAsync(LocationName, Configuration, string, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Configuration configuration = new Configuration();
            string configurationId = "";
            // Make the request
            Operation<Configuration, OperationMetadata> response = await licenseManagerClient.CreateConfigurationAsync(parent, configuration, configurationId);

            // Poll until the returned long-running operation is complete
            Operation<Configuration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Configuration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Configuration, OperationMetadata> retrievedResponse = await licenseManagerClient.PollOnceCreateConfigurationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Configuration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConfiguration</summary>
        public void UpdateConfigurationRequestObject()
        {
            // Snippet: UpdateConfiguration(UpdateConfigurationRequest, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            UpdateConfigurationRequest request = new UpdateConfigurationRequest
            {
                UpdateMask = new FieldMask(),
                Configuration = new Configuration(),
                RequestId = "",
            };
            // Make the request
            Operation<Configuration, OperationMetadata> response = licenseManagerClient.UpdateConfiguration(request);

            // Poll until the returned long-running operation is complete
            Operation<Configuration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Configuration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Configuration, OperationMetadata> retrievedResponse = licenseManagerClient.PollOnceUpdateConfiguration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Configuration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConfigurationAsync</summary>
        public async Task UpdateConfigurationRequestObjectAsync()
        {
            // Snippet: UpdateConfigurationAsync(UpdateConfigurationRequest, CallSettings)
            // Additional: UpdateConfigurationAsync(UpdateConfigurationRequest, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateConfigurationRequest request = new UpdateConfigurationRequest
            {
                UpdateMask = new FieldMask(),
                Configuration = new Configuration(),
                RequestId = "",
            };
            // Make the request
            Operation<Configuration, OperationMetadata> response = await licenseManagerClient.UpdateConfigurationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Configuration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Configuration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Configuration, OperationMetadata> retrievedResponse = await licenseManagerClient.PollOnceUpdateConfigurationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Configuration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConfiguration</summary>
        public void UpdateConfiguration()
        {
            // Snippet: UpdateConfiguration(Configuration, FieldMask, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            Configuration configuration = new Configuration();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Configuration, OperationMetadata> response = licenseManagerClient.UpdateConfiguration(configuration, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Configuration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Configuration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Configuration, OperationMetadata> retrievedResponse = licenseManagerClient.PollOnceUpdateConfiguration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Configuration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConfigurationAsync</summary>
        public async Task UpdateConfigurationAsync()
        {
            // Snippet: UpdateConfigurationAsync(Configuration, FieldMask, CallSettings)
            // Additional: UpdateConfigurationAsync(Configuration, FieldMask, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            Configuration configuration = new Configuration();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Configuration, OperationMetadata> response = await licenseManagerClient.UpdateConfigurationAsync(configuration, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Configuration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Configuration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Configuration, OperationMetadata> retrievedResponse = await licenseManagerClient.PollOnceUpdateConfigurationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Configuration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConfiguration</summary>
        public void DeleteConfigurationRequestObject()
        {
            // Snippet: DeleteConfiguration(DeleteConfigurationRequest, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            DeleteConfigurationRequest request = new DeleteConfigurationRequest
            {
                ConfigurationName = ConfigurationName.FromProjectLocationConfiguration("[PROJECT]", "[LOCATION]", "[CONFIGURATION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = licenseManagerClient.DeleteConfiguration(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = licenseManagerClient.PollOnceDeleteConfiguration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConfigurationAsync</summary>
        public async Task DeleteConfigurationRequestObjectAsync()
        {
            // Snippet: DeleteConfigurationAsync(DeleteConfigurationRequest, CallSettings)
            // Additional: DeleteConfigurationAsync(DeleteConfigurationRequest, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteConfigurationRequest request = new DeleteConfigurationRequest
            {
                ConfigurationName = ConfigurationName.FromProjectLocationConfiguration("[PROJECT]", "[LOCATION]", "[CONFIGURATION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await licenseManagerClient.DeleteConfigurationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await licenseManagerClient.PollOnceDeleteConfigurationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConfiguration</summary>
        public void DeleteConfiguration()
        {
            // Snippet: DeleteConfiguration(string, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/configurations/[CONFIGURATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = licenseManagerClient.DeleteConfiguration(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = licenseManagerClient.PollOnceDeleteConfiguration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConfigurationAsync</summary>
        public async Task DeleteConfigurationAsync()
        {
            // Snippet: DeleteConfigurationAsync(string, CallSettings)
            // Additional: DeleteConfigurationAsync(string, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/configurations/[CONFIGURATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await licenseManagerClient.DeleteConfigurationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await licenseManagerClient.PollOnceDeleteConfigurationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConfiguration</summary>
        public void DeleteConfigurationResourceNames()
        {
            // Snippet: DeleteConfiguration(ConfigurationName, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            ConfigurationName name = ConfigurationName.FromProjectLocationConfiguration("[PROJECT]", "[LOCATION]", "[CONFIGURATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = licenseManagerClient.DeleteConfiguration(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = licenseManagerClient.PollOnceDeleteConfiguration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConfigurationAsync</summary>
        public async Task DeleteConfigurationResourceNamesAsync()
        {
            // Snippet: DeleteConfigurationAsync(ConfigurationName, CallSettings)
            // Additional: DeleteConfigurationAsync(ConfigurationName, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            ConfigurationName name = ConfigurationName.FromProjectLocationConfiguration("[PROJECT]", "[LOCATION]", "[CONFIGURATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await licenseManagerClient.DeleteConfigurationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await licenseManagerClient.PollOnceDeleteConfigurationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstancesRequestObject()
        {
            // Snippet: ListInstances(ListInstancesRequest, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = licenseManagerClient.ListInstances(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesRequestObjectAsync()
        {
            // Snippet: ListInstancesAsync(ListInstancesRequest, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = licenseManagerClient.ListInstancesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Instance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstances()
        {
            // Snippet: ListInstances(string, string, int?, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = licenseManagerClient.ListInstances(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesAsync()
        {
            // Snippet: ListInstancesAsync(string, string, int?, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = licenseManagerClient.ListInstancesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Instance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstancesResourceNames()
        {
            // Snippet: ListInstances(LocationName, string, int?, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = licenseManagerClient.ListInstances(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesResourceNamesAsync()
        {
            // Snippet: ListInstancesAsync(LocationName, string, int?, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = licenseManagerClient.ListInstancesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Instance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstanceRequestObject()
        {
            // Snippet: GetInstance(GetInstanceRequest, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Instance response = licenseManagerClient.GetInstance(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceRequestObjectAsync()
        {
            // Snippet: GetInstanceAsync(GetInstanceRequest, CallSettings)
            // Additional: GetInstanceAsync(GetInstanceRequest, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Instance response = await licenseManagerClient.GetInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstance()
        {
            // Snippet: GetInstance(string, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Instance response = licenseManagerClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceAsync()
        {
            // Snippet: GetInstanceAsync(string, CallSettings)
            // Additional: GetInstanceAsync(string, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Instance response = await licenseManagerClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstanceResourceNames()
        {
            // Snippet: GetInstance(InstanceName, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Instance response = licenseManagerClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceResourceNamesAsync()
        {
            // Snippet: GetInstanceAsync(InstanceName, CallSettings)
            // Additional: GetInstanceAsync(InstanceName, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Instance response = await licenseManagerClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeactivateConfiguration</summary>
        public void DeactivateConfigurationRequestObject()
        {
            // Snippet: DeactivateConfiguration(DeactivateConfigurationRequest, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            DeactivateConfigurationRequest request = new DeactivateConfigurationRequest
            {
                ConfigurationName = ConfigurationName.FromProjectLocationConfiguration("[PROJECT]", "[LOCATION]", "[CONFIGURATION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Configuration, OperationMetadata> response = licenseManagerClient.DeactivateConfiguration(request);

            // Poll until the returned long-running operation is complete
            Operation<Configuration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Configuration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Configuration, OperationMetadata> retrievedResponse = licenseManagerClient.PollOnceDeactivateConfiguration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Configuration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeactivateConfigurationAsync</summary>
        public async Task DeactivateConfigurationRequestObjectAsync()
        {
            // Snippet: DeactivateConfigurationAsync(DeactivateConfigurationRequest, CallSettings)
            // Additional: DeactivateConfigurationAsync(DeactivateConfigurationRequest, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeactivateConfigurationRequest request = new DeactivateConfigurationRequest
            {
                ConfigurationName = ConfigurationName.FromProjectLocationConfiguration("[PROJECT]", "[LOCATION]", "[CONFIGURATION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Configuration, OperationMetadata> response = await licenseManagerClient.DeactivateConfigurationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Configuration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Configuration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Configuration, OperationMetadata> retrievedResponse = await licenseManagerClient.PollOnceDeactivateConfigurationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Configuration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeactivateConfiguration</summary>
        public void DeactivateConfiguration()
        {
            // Snippet: DeactivateConfiguration(string, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/configurations/[CONFIGURATION]";
            // Make the request
            Operation<Configuration, OperationMetadata> response = licenseManagerClient.DeactivateConfiguration(name);

            // Poll until the returned long-running operation is complete
            Operation<Configuration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Configuration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Configuration, OperationMetadata> retrievedResponse = licenseManagerClient.PollOnceDeactivateConfiguration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Configuration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeactivateConfigurationAsync</summary>
        public async Task DeactivateConfigurationAsync()
        {
            // Snippet: DeactivateConfigurationAsync(string, CallSettings)
            // Additional: DeactivateConfigurationAsync(string, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/configurations/[CONFIGURATION]";
            // Make the request
            Operation<Configuration, OperationMetadata> response = await licenseManagerClient.DeactivateConfigurationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Configuration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Configuration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Configuration, OperationMetadata> retrievedResponse = await licenseManagerClient.PollOnceDeactivateConfigurationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Configuration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeactivateConfiguration</summary>
        public void DeactivateConfigurationResourceNames()
        {
            // Snippet: DeactivateConfiguration(ConfigurationName, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            ConfigurationName name = ConfigurationName.FromProjectLocationConfiguration("[PROJECT]", "[LOCATION]", "[CONFIGURATION]");
            // Make the request
            Operation<Configuration, OperationMetadata> response = licenseManagerClient.DeactivateConfiguration(name);

            // Poll until the returned long-running operation is complete
            Operation<Configuration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Configuration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Configuration, OperationMetadata> retrievedResponse = licenseManagerClient.PollOnceDeactivateConfiguration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Configuration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeactivateConfigurationAsync</summary>
        public async Task DeactivateConfigurationResourceNamesAsync()
        {
            // Snippet: DeactivateConfigurationAsync(ConfigurationName, CallSettings)
            // Additional: DeactivateConfigurationAsync(ConfigurationName, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            ConfigurationName name = ConfigurationName.FromProjectLocationConfiguration("[PROJECT]", "[LOCATION]", "[CONFIGURATION]");
            // Make the request
            Operation<Configuration, OperationMetadata> response = await licenseManagerClient.DeactivateConfigurationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Configuration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Configuration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Configuration, OperationMetadata> retrievedResponse = await licenseManagerClient.PollOnceDeactivateConfigurationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Configuration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReactivateConfiguration</summary>
        public void ReactivateConfigurationRequestObject()
        {
            // Snippet: ReactivateConfiguration(ReactivateConfigurationRequest, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            ReactivateConfigurationRequest request = new ReactivateConfigurationRequest
            {
                ConfigurationName = ConfigurationName.FromProjectLocationConfiguration("[PROJECT]", "[LOCATION]", "[CONFIGURATION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Configuration, OperationMetadata> response = licenseManagerClient.ReactivateConfiguration(request);

            // Poll until the returned long-running operation is complete
            Operation<Configuration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Configuration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Configuration, OperationMetadata> retrievedResponse = licenseManagerClient.PollOnceReactivateConfiguration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Configuration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReactivateConfigurationAsync</summary>
        public async Task ReactivateConfigurationRequestObjectAsync()
        {
            // Snippet: ReactivateConfigurationAsync(ReactivateConfigurationRequest, CallSettings)
            // Additional: ReactivateConfigurationAsync(ReactivateConfigurationRequest, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            ReactivateConfigurationRequest request = new ReactivateConfigurationRequest
            {
                ConfigurationName = ConfigurationName.FromProjectLocationConfiguration("[PROJECT]", "[LOCATION]", "[CONFIGURATION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Configuration, OperationMetadata> response = await licenseManagerClient.ReactivateConfigurationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Configuration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Configuration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Configuration, OperationMetadata> retrievedResponse = await licenseManagerClient.PollOnceReactivateConfigurationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Configuration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReactivateConfiguration</summary>
        public void ReactivateConfiguration()
        {
            // Snippet: ReactivateConfiguration(string, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/configurations/[CONFIGURATION]";
            // Make the request
            Operation<Configuration, OperationMetadata> response = licenseManagerClient.ReactivateConfiguration(name);

            // Poll until the returned long-running operation is complete
            Operation<Configuration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Configuration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Configuration, OperationMetadata> retrievedResponse = licenseManagerClient.PollOnceReactivateConfiguration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Configuration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReactivateConfigurationAsync</summary>
        public async Task ReactivateConfigurationAsync()
        {
            // Snippet: ReactivateConfigurationAsync(string, CallSettings)
            // Additional: ReactivateConfigurationAsync(string, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/configurations/[CONFIGURATION]";
            // Make the request
            Operation<Configuration, OperationMetadata> response = await licenseManagerClient.ReactivateConfigurationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Configuration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Configuration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Configuration, OperationMetadata> retrievedResponse = await licenseManagerClient.PollOnceReactivateConfigurationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Configuration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReactivateConfiguration</summary>
        public void ReactivateConfigurationResourceNames()
        {
            // Snippet: ReactivateConfiguration(ConfigurationName, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            ConfigurationName name = ConfigurationName.FromProjectLocationConfiguration("[PROJECT]", "[LOCATION]", "[CONFIGURATION]");
            // Make the request
            Operation<Configuration, OperationMetadata> response = licenseManagerClient.ReactivateConfiguration(name);

            // Poll until the returned long-running operation is complete
            Operation<Configuration, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Configuration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Configuration, OperationMetadata> retrievedResponse = licenseManagerClient.PollOnceReactivateConfiguration(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Configuration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReactivateConfigurationAsync</summary>
        public async Task ReactivateConfigurationResourceNamesAsync()
        {
            // Snippet: ReactivateConfigurationAsync(ConfigurationName, CallSettings)
            // Additional: ReactivateConfigurationAsync(ConfigurationName, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            ConfigurationName name = ConfigurationName.FromProjectLocationConfiguration("[PROJECT]", "[LOCATION]", "[CONFIGURATION]");
            // Make the request
            Operation<Configuration, OperationMetadata> response = await licenseManagerClient.ReactivateConfigurationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Configuration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Configuration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Configuration, OperationMetadata> retrievedResponse = await licenseManagerClient.PollOnceReactivateConfigurationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Configuration retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for QueryConfigurationLicenseUsage</summary>
        public void QueryConfigurationLicenseUsageRequestObject()
        {
            // Snippet: QueryConfigurationLicenseUsage(QueryConfigurationLicenseUsageRequest, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            QueryConfigurationLicenseUsageRequest request = new QueryConfigurationLicenseUsageRequest
            {
                ConfigurationName = ConfigurationName.FromProjectLocationConfiguration("[PROJECT]", "[LOCATION]", "[CONFIGURATION]"),
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            // Make the request
            QueryConfigurationLicenseUsageResponse response = licenseManagerClient.QueryConfigurationLicenseUsage(request);
            // End snippet
        }

        /// <summary>Snippet for QueryConfigurationLicenseUsageAsync</summary>
        public async Task QueryConfigurationLicenseUsageRequestObjectAsync()
        {
            // Snippet: QueryConfigurationLicenseUsageAsync(QueryConfigurationLicenseUsageRequest, CallSettings)
            // Additional: QueryConfigurationLicenseUsageAsync(QueryConfigurationLicenseUsageRequest, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            QueryConfigurationLicenseUsageRequest request = new QueryConfigurationLicenseUsageRequest
            {
                ConfigurationName = ConfigurationName.FromProjectLocationConfiguration("[PROJECT]", "[LOCATION]", "[CONFIGURATION]"),
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            // Make the request
            QueryConfigurationLicenseUsageResponse response = await licenseManagerClient.QueryConfigurationLicenseUsageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for QueryConfigurationLicenseUsage</summary>
        public void QueryConfigurationLicenseUsage()
        {
            // Snippet: QueryConfigurationLicenseUsage(string, Timestamp, Timestamp, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/configurations/[CONFIGURATION]";
            Timestamp startTime = new Timestamp();
            Timestamp endTime = new Timestamp();
            // Make the request
            QueryConfigurationLicenseUsageResponse response = licenseManagerClient.QueryConfigurationLicenseUsage(name, startTime, endTime);
            // End snippet
        }

        /// <summary>Snippet for QueryConfigurationLicenseUsageAsync</summary>
        public async Task QueryConfigurationLicenseUsageAsync()
        {
            // Snippet: QueryConfigurationLicenseUsageAsync(string, Timestamp, Timestamp, CallSettings)
            // Additional: QueryConfigurationLicenseUsageAsync(string, Timestamp, Timestamp, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/configurations/[CONFIGURATION]";
            Timestamp startTime = new Timestamp();
            Timestamp endTime = new Timestamp();
            // Make the request
            QueryConfigurationLicenseUsageResponse response = await licenseManagerClient.QueryConfigurationLicenseUsageAsync(name, startTime, endTime);
            // End snippet
        }

        /// <summary>Snippet for QueryConfigurationLicenseUsage</summary>
        public void QueryConfigurationLicenseUsageResourceNames()
        {
            // Snippet: QueryConfigurationLicenseUsage(ConfigurationName, Timestamp, Timestamp, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            ConfigurationName name = ConfigurationName.FromProjectLocationConfiguration("[PROJECT]", "[LOCATION]", "[CONFIGURATION]");
            Timestamp startTime = new Timestamp();
            Timestamp endTime = new Timestamp();
            // Make the request
            QueryConfigurationLicenseUsageResponse response = licenseManagerClient.QueryConfigurationLicenseUsage(name, startTime, endTime);
            // End snippet
        }

        /// <summary>Snippet for QueryConfigurationLicenseUsageAsync</summary>
        public async Task QueryConfigurationLicenseUsageResourceNamesAsync()
        {
            // Snippet: QueryConfigurationLicenseUsageAsync(ConfigurationName, Timestamp, Timestamp, CallSettings)
            // Additional: QueryConfigurationLicenseUsageAsync(ConfigurationName, Timestamp, Timestamp, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            ConfigurationName name = ConfigurationName.FromProjectLocationConfiguration("[PROJECT]", "[LOCATION]", "[CONFIGURATION]");
            Timestamp startTime = new Timestamp();
            Timestamp endTime = new Timestamp();
            // Make the request
            QueryConfigurationLicenseUsageResponse response = await licenseManagerClient.QueryConfigurationLicenseUsageAsync(name, startTime, endTime);
            // End snippet
        }

        /// <summary>Snippet for AggregateUsage</summary>
        public void AggregateUsageRequestObject()
        {
            // Snippet: AggregateUsage(AggregateUsageRequest, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            AggregateUsageRequest request = new AggregateUsageRequest
            {
                ConfigurationName = ConfigurationName.FromProjectLocationConfiguration("[PROJECT]", "[LOCATION]", "[CONFIGURATION]"),
                Filter = "",
                OrderBy = "",
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            // Make the request
            PagedEnumerable<AggregateUsageResponse, Usage> response = licenseManagerClient.AggregateUsage(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Usage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (AggregateUsageResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Usage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Usage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Usage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregateUsageAsync</summary>
        public async Task AggregateUsageRequestObjectAsync()
        {
            // Snippet: AggregateUsageAsync(AggregateUsageRequest, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            AggregateUsageRequest request = new AggregateUsageRequest
            {
                ConfigurationName = ConfigurationName.FromProjectLocationConfiguration("[PROJECT]", "[LOCATION]", "[CONFIGURATION]"),
                Filter = "",
                OrderBy = "",
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            // Make the request
            PagedAsyncEnumerable<AggregateUsageResponse, Usage> response = licenseManagerClient.AggregateUsageAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Usage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((AggregateUsageResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Usage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Usage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Usage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregateUsage</summary>
        public void AggregateUsage()
        {
            // Snippet: AggregateUsage(string, Timestamp, Timestamp, string, int?, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/configurations/[CONFIGURATION]";
            Timestamp startTime = new Timestamp();
            Timestamp endTime = new Timestamp();
            // Make the request
            PagedEnumerable<AggregateUsageResponse, Usage> response = licenseManagerClient.AggregateUsage(name, startTime, endTime);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Usage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (AggregateUsageResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Usage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Usage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Usage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregateUsageAsync</summary>
        public async Task AggregateUsageAsync()
        {
            // Snippet: AggregateUsageAsync(string, Timestamp, Timestamp, string, int?, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/configurations/[CONFIGURATION]";
            Timestamp startTime = new Timestamp();
            Timestamp endTime = new Timestamp();
            // Make the request
            PagedAsyncEnumerable<AggregateUsageResponse, Usage> response = licenseManagerClient.AggregateUsageAsync(name, startTime, endTime);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Usage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((AggregateUsageResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Usage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Usage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Usage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregateUsage</summary>
        public void AggregateUsageResourceNames()
        {
            // Snippet: AggregateUsage(ConfigurationName, Timestamp, Timestamp, string, int?, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            ConfigurationName name = ConfigurationName.FromProjectLocationConfiguration("[PROJECT]", "[LOCATION]", "[CONFIGURATION]");
            Timestamp startTime = new Timestamp();
            Timestamp endTime = new Timestamp();
            // Make the request
            PagedEnumerable<AggregateUsageResponse, Usage> response = licenseManagerClient.AggregateUsage(name, startTime, endTime);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Usage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (AggregateUsageResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Usage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Usage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Usage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregateUsageAsync</summary>
        public async Task AggregateUsageResourceNamesAsync()
        {
            // Snippet: AggregateUsageAsync(ConfigurationName, Timestamp, Timestamp, string, int?, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            ConfigurationName name = ConfigurationName.FromProjectLocationConfiguration("[PROJECT]", "[LOCATION]", "[CONFIGURATION]");
            Timestamp startTime = new Timestamp();
            Timestamp endTime = new Timestamp();
            // Make the request
            PagedAsyncEnumerable<AggregateUsageResponse, Usage> response = licenseManagerClient.AggregateUsageAsync(name, startTime, endTime);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Usage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((AggregateUsageResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Usage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Usage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Usage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProducts</summary>
        public void ListProductsRequestObject()
        {
            // Snippet: ListProducts(ListProductsRequest, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            ListProductsRequest request = new ListProductsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListProductsResponse, Product> response = licenseManagerClient.ListProducts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Product item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProductsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Product item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Product> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Product item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProductsAsync</summary>
        public async Task ListProductsRequestObjectAsync()
        {
            // Snippet: ListProductsAsync(ListProductsRequest, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListProductsRequest request = new ListProductsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListProductsResponse, Product> response = licenseManagerClient.ListProductsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Product item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProductsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Product item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Product> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Product item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProducts</summary>
        public void ListProducts()
        {
            // Snippet: ListProducts(string, string, int?, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListProductsResponse, Product> response = licenseManagerClient.ListProducts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Product item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProductsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Product item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Product> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Product item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProductsAsync</summary>
        public async Task ListProductsAsync()
        {
            // Snippet: ListProductsAsync(string, string, int?, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListProductsResponse, Product> response = licenseManagerClient.ListProductsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Product item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProductsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Product item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Product> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Product item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProducts</summary>
        public void ListProductsResourceNames()
        {
            // Snippet: ListProducts(LocationName, string, int?, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListProductsResponse, Product> response = licenseManagerClient.ListProducts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Product item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProductsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Product item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Product> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Product item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProductsAsync</summary>
        public async Task ListProductsResourceNamesAsync()
        {
            // Snippet: ListProductsAsync(LocationName, string, int?, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListProductsResponse, Product> response = licenseManagerClient.ListProductsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Product item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProductsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Product item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Product> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Product item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetProduct</summary>
        public void GetProductRequestObject()
        {
            // Snippet: GetProduct(GetProductRequest, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            GetProductRequest request = new GetProductRequest
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            // Make the request
            Product response = licenseManagerClient.GetProduct(request);
            // End snippet
        }

        /// <summary>Snippet for GetProductAsync</summary>
        public async Task GetProductRequestObjectAsync()
        {
            // Snippet: GetProductAsync(GetProductRequest, CallSettings)
            // Additional: GetProductAsync(GetProductRequest, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetProductRequest request = new GetProductRequest
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            // Make the request
            Product response = await licenseManagerClient.GetProductAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProduct</summary>
        public void GetProduct()
        {
            // Snippet: GetProduct(string, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/products/[PRODUCT]";
            // Make the request
            Product response = licenseManagerClient.GetProduct(name);
            // End snippet
        }

        /// <summary>Snippet for GetProductAsync</summary>
        public async Task GetProductAsync()
        {
            // Snippet: GetProductAsync(string, CallSettings)
            // Additional: GetProductAsync(string, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/products/[PRODUCT]";
            // Make the request
            Product response = await licenseManagerClient.GetProductAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProduct</summary>
        public void GetProductResourceNames()
        {
            // Snippet: GetProduct(ProductName, CallSettings)
            // Create client
            LicenseManagerClient licenseManagerClient = LicenseManagerClient.Create();
            // Initialize request argument(s)
            ProductName name = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]");
            // Make the request
            Product response = licenseManagerClient.GetProduct(name);
            // End snippet
        }

        /// <summary>Snippet for GetProductAsync</summary>
        public async Task GetProductResourceNamesAsync()
        {
            // Snippet: GetProductAsync(ProductName, CallSettings)
            // Additional: GetProductAsync(ProductName, CancellationToken)
            // Create client
            LicenseManagerClient licenseManagerClient = await LicenseManagerClient.CreateAsync();
            // Initialize request argument(s)
            ProductName name = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]");
            // Make the request
            Product response = await licenseManagerClient.GetProductAsync(name);
            // End snippet
        }
    }
}
