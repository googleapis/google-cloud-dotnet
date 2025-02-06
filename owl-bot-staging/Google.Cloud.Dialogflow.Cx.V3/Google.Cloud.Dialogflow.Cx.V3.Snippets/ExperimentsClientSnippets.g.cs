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
    using Google.Cloud.Dialogflow.Cx.V3;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedExperimentsClientSnippets
    {
        /// <summary>Snippet for ListExperiments</summary>
        public void ListExperimentsRequestObject()
        {
            // Snippet: ListExperiments(ListExperimentsRequest, CallSettings)
            // Create client
            ExperimentsClient experimentsClient = ExperimentsClient.Create();
            // Initialize request argument(s)
            ListExperimentsRequest request = new ListExperimentsRequest
            {
                ParentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
            };
            // Make the request
            PagedEnumerable<ListExperimentsResponse, Experiment> response = experimentsClient.ListExperiments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Experiment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExperimentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Experiment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Experiment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Experiment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExperimentsAsync</summary>
        public async Task ListExperimentsRequestObjectAsync()
        {
            // Snippet: ListExperimentsAsync(ListExperimentsRequest, CallSettings)
            // Create client
            ExperimentsClient experimentsClient = await ExperimentsClient.CreateAsync();
            // Initialize request argument(s)
            ListExperimentsRequest request = new ListExperimentsRequest
            {
                ParentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListExperimentsResponse, Experiment> response = experimentsClient.ListExperimentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Experiment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExperimentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Experiment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Experiment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Experiment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExperiments</summary>
        public void ListExperiments()
        {
            // Snippet: ListExperiments(string, string, int?, CallSettings)
            // Create client
            ExperimentsClient experimentsClient = ExperimentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/environments/[ENVIRONMENT]";
            // Make the request
            PagedEnumerable<ListExperimentsResponse, Experiment> response = experimentsClient.ListExperiments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Experiment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExperimentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Experiment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Experiment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Experiment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExperimentsAsync</summary>
        public async Task ListExperimentsAsync()
        {
            // Snippet: ListExperimentsAsync(string, string, int?, CallSettings)
            // Create client
            ExperimentsClient experimentsClient = await ExperimentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/environments/[ENVIRONMENT]";
            // Make the request
            PagedAsyncEnumerable<ListExperimentsResponse, Experiment> response = experimentsClient.ListExperimentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Experiment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExperimentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Experiment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Experiment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Experiment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExperiments</summary>
        public void ListExperimentsResourceNames()
        {
            // Snippet: ListExperiments(EnvironmentName, string, int?, CallSettings)
            // Create client
            ExperimentsClient experimentsClient = ExperimentsClient.Create();
            // Initialize request argument(s)
            EnvironmentName parent = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]");
            // Make the request
            PagedEnumerable<ListExperimentsResponse, Experiment> response = experimentsClient.ListExperiments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Experiment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExperimentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Experiment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Experiment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Experiment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExperimentsAsync</summary>
        public async Task ListExperimentsResourceNamesAsync()
        {
            // Snippet: ListExperimentsAsync(EnvironmentName, string, int?, CallSettings)
            // Create client
            ExperimentsClient experimentsClient = await ExperimentsClient.CreateAsync();
            // Initialize request argument(s)
            EnvironmentName parent = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]");
            // Make the request
            PagedAsyncEnumerable<ListExperimentsResponse, Experiment> response = experimentsClient.ListExperimentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Experiment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExperimentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Experiment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Experiment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Experiment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetExperiment</summary>
        public void GetExperimentRequestObject()
        {
            // Snippet: GetExperiment(GetExperimentRequest, CallSettings)
            // Create client
            ExperimentsClient experimentsClient = ExperimentsClient.Create();
            // Initialize request argument(s)
            GetExperimentRequest request = new GetExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            // Make the request
            Experiment response = experimentsClient.GetExperiment(request);
            // End snippet
        }

        /// <summary>Snippet for GetExperimentAsync</summary>
        public async Task GetExperimentRequestObjectAsync()
        {
            // Snippet: GetExperimentAsync(GetExperimentRequest, CallSettings)
            // Additional: GetExperimentAsync(GetExperimentRequest, CancellationToken)
            // Create client
            ExperimentsClient experimentsClient = await ExperimentsClient.CreateAsync();
            // Initialize request argument(s)
            GetExperimentRequest request = new GetExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            // Make the request
            Experiment response = await experimentsClient.GetExperimentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetExperiment</summary>
        public void GetExperiment()
        {
            // Snippet: GetExperiment(string, CallSettings)
            // Create client
            ExperimentsClient experimentsClient = ExperimentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/environments/[ENVIRONMENT]/experiments/[EXPERIMENT]";
            // Make the request
            Experiment response = experimentsClient.GetExperiment(name);
            // End snippet
        }

        /// <summary>Snippet for GetExperimentAsync</summary>
        public async Task GetExperimentAsync()
        {
            // Snippet: GetExperimentAsync(string, CallSettings)
            // Additional: GetExperimentAsync(string, CancellationToken)
            // Create client
            ExperimentsClient experimentsClient = await ExperimentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/environments/[ENVIRONMENT]/experiments/[EXPERIMENT]";
            // Make the request
            Experiment response = await experimentsClient.GetExperimentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetExperiment</summary>
        public void GetExperimentResourceNames()
        {
            // Snippet: GetExperiment(ExperimentName, CallSettings)
            // Create client
            ExperimentsClient experimentsClient = ExperimentsClient.Create();
            // Initialize request argument(s)
            ExperimentName name = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]");
            // Make the request
            Experiment response = experimentsClient.GetExperiment(name);
            // End snippet
        }

        /// <summary>Snippet for GetExperimentAsync</summary>
        public async Task GetExperimentResourceNamesAsync()
        {
            // Snippet: GetExperimentAsync(ExperimentName, CallSettings)
            // Additional: GetExperimentAsync(ExperimentName, CancellationToken)
            // Create client
            ExperimentsClient experimentsClient = await ExperimentsClient.CreateAsync();
            // Initialize request argument(s)
            ExperimentName name = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]");
            // Make the request
            Experiment response = await experimentsClient.GetExperimentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateExperiment</summary>
        public void CreateExperimentRequestObject()
        {
            // Snippet: CreateExperiment(CreateExperimentRequest, CallSettings)
            // Create client
            ExperimentsClient experimentsClient = ExperimentsClient.Create();
            // Initialize request argument(s)
            CreateExperimentRequest request = new CreateExperimentRequest
            {
                ParentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
                Experiment = new Experiment(),
            };
            // Make the request
            Experiment response = experimentsClient.CreateExperiment(request);
            // End snippet
        }

        /// <summary>Snippet for CreateExperimentAsync</summary>
        public async Task CreateExperimentRequestObjectAsync()
        {
            // Snippet: CreateExperimentAsync(CreateExperimentRequest, CallSettings)
            // Additional: CreateExperimentAsync(CreateExperimentRequest, CancellationToken)
            // Create client
            ExperimentsClient experimentsClient = await ExperimentsClient.CreateAsync();
            // Initialize request argument(s)
            CreateExperimentRequest request = new CreateExperimentRequest
            {
                ParentAsEnvironmentName = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]"),
                Experiment = new Experiment(),
            };
            // Make the request
            Experiment response = await experimentsClient.CreateExperimentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateExperiment</summary>
        public void CreateExperiment()
        {
            // Snippet: CreateExperiment(string, Experiment, CallSettings)
            // Create client
            ExperimentsClient experimentsClient = ExperimentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/environments/[ENVIRONMENT]";
            Experiment experiment = new Experiment();
            // Make the request
            Experiment response = experimentsClient.CreateExperiment(parent, experiment);
            // End snippet
        }

        /// <summary>Snippet for CreateExperimentAsync</summary>
        public async Task CreateExperimentAsync()
        {
            // Snippet: CreateExperimentAsync(string, Experiment, CallSettings)
            // Additional: CreateExperimentAsync(string, Experiment, CancellationToken)
            // Create client
            ExperimentsClient experimentsClient = await ExperimentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/environments/[ENVIRONMENT]";
            Experiment experiment = new Experiment();
            // Make the request
            Experiment response = await experimentsClient.CreateExperimentAsync(parent, experiment);
            // End snippet
        }

        /// <summary>Snippet for CreateExperiment</summary>
        public void CreateExperimentResourceNames()
        {
            // Snippet: CreateExperiment(EnvironmentName, Experiment, CallSettings)
            // Create client
            ExperimentsClient experimentsClient = ExperimentsClient.Create();
            // Initialize request argument(s)
            EnvironmentName parent = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]");
            Experiment experiment = new Experiment();
            // Make the request
            Experiment response = experimentsClient.CreateExperiment(parent, experiment);
            // End snippet
        }

        /// <summary>Snippet for CreateExperimentAsync</summary>
        public async Task CreateExperimentResourceNamesAsync()
        {
            // Snippet: CreateExperimentAsync(EnvironmentName, Experiment, CallSettings)
            // Additional: CreateExperimentAsync(EnvironmentName, Experiment, CancellationToken)
            // Create client
            ExperimentsClient experimentsClient = await ExperimentsClient.CreateAsync();
            // Initialize request argument(s)
            EnvironmentName parent = EnvironmentName.FromProjectLocationAgentEnvironment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]");
            Experiment experiment = new Experiment();
            // Make the request
            Experiment response = await experimentsClient.CreateExperimentAsync(parent, experiment);
            // End snippet
        }

        /// <summary>Snippet for UpdateExperiment</summary>
        public void UpdateExperimentRequestObject()
        {
            // Snippet: UpdateExperiment(UpdateExperimentRequest, CallSettings)
            // Create client
            ExperimentsClient experimentsClient = ExperimentsClient.Create();
            // Initialize request argument(s)
            UpdateExperimentRequest request = new UpdateExperimentRequest
            {
                Experiment = new Experiment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Experiment response = experimentsClient.UpdateExperiment(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateExperimentAsync</summary>
        public async Task UpdateExperimentRequestObjectAsync()
        {
            // Snippet: UpdateExperimentAsync(UpdateExperimentRequest, CallSettings)
            // Additional: UpdateExperimentAsync(UpdateExperimentRequest, CancellationToken)
            // Create client
            ExperimentsClient experimentsClient = await ExperimentsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateExperimentRequest request = new UpdateExperimentRequest
            {
                Experiment = new Experiment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Experiment response = await experimentsClient.UpdateExperimentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateExperiment</summary>
        public void UpdateExperiment()
        {
            // Snippet: UpdateExperiment(Experiment, FieldMask, CallSettings)
            // Create client
            ExperimentsClient experimentsClient = ExperimentsClient.Create();
            // Initialize request argument(s)
            Experiment experiment = new Experiment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Experiment response = experimentsClient.UpdateExperiment(experiment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateExperimentAsync</summary>
        public async Task UpdateExperimentAsync()
        {
            // Snippet: UpdateExperimentAsync(Experiment, FieldMask, CallSettings)
            // Additional: UpdateExperimentAsync(Experiment, FieldMask, CancellationToken)
            // Create client
            ExperimentsClient experimentsClient = await ExperimentsClient.CreateAsync();
            // Initialize request argument(s)
            Experiment experiment = new Experiment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Experiment response = await experimentsClient.UpdateExperimentAsync(experiment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteExperiment</summary>
        public void DeleteExperimentRequestObject()
        {
            // Snippet: DeleteExperiment(DeleteExperimentRequest, CallSettings)
            // Create client
            ExperimentsClient experimentsClient = ExperimentsClient.Create();
            // Initialize request argument(s)
            DeleteExperimentRequest request = new DeleteExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            // Make the request
            experimentsClient.DeleteExperiment(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteExperimentAsync</summary>
        public async Task DeleteExperimentRequestObjectAsync()
        {
            // Snippet: DeleteExperimentAsync(DeleteExperimentRequest, CallSettings)
            // Additional: DeleteExperimentAsync(DeleteExperimentRequest, CancellationToken)
            // Create client
            ExperimentsClient experimentsClient = await ExperimentsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteExperimentRequest request = new DeleteExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            // Make the request
            await experimentsClient.DeleteExperimentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteExperiment</summary>
        public void DeleteExperiment()
        {
            // Snippet: DeleteExperiment(string, CallSettings)
            // Create client
            ExperimentsClient experimentsClient = ExperimentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/environments/[ENVIRONMENT]/experiments/[EXPERIMENT]";
            // Make the request
            experimentsClient.DeleteExperiment(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteExperimentAsync</summary>
        public async Task DeleteExperimentAsync()
        {
            // Snippet: DeleteExperimentAsync(string, CallSettings)
            // Additional: DeleteExperimentAsync(string, CancellationToken)
            // Create client
            ExperimentsClient experimentsClient = await ExperimentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/environments/[ENVIRONMENT]/experiments/[EXPERIMENT]";
            // Make the request
            await experimentsClient.DeleteExperimentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteExperiment</summary>
        public void DeleteExperimentResourceNames()
        {
            // Snippet: DeleteExperiment(ExperimentName, CallSettings)
            // Create client
            ExperimentsClient experimentsClient = ExperimentsClient.Create();
            // Initialize request argument(s)
            ExperimentName name = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]");
            // Make the request
            experimentsClient.DeleteExperiment(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteExperimentAsync</summary>
        public async Task DeleteExperimentResourceNamesAsync()
        {
            // Snippet: DeleteExperimentAsync(ExperimentName, CallSettings)
            // Additional: DeleteExperimentAsync(ExperimentName, CancellationToken)
            // Create client
            ExperimentsClient experimentsClient = await ExperimentsClient.CreateAsync();
            // Initialize request argument(s)
            ExperimentName name = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]");
            // Make the request
            await experimentsClient.DeleteExperimentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for StartExperiment</summary>
        public void StartExperimentRequestObject()
        {
            // Snippet: StartExperiment(StartExperimentRequest, CallSettings)
            // Create client
            ExperimentsClient experimentsClient = ExperimentsClient.Create();
            // Initialize request argument(s)
            StartExperimentRequest request = new StartExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            // Make the request
            Experiment response = experimentsClient.StartExperiment(request);
            // End snippet
        }

        /// <summary>Snippet for StartExperimentAsync</summary>
        public async Task StartExperimentRequestObjectAsync()
        {
            // Snippet: StartExperimentAsync(StartExperimentRequest, CallSettings)
            // Additional: StartExperimentAsync(StartExperimentRequest, CancellationToken)
            // Create client
            ExperimentsClient experimentsClient = await ExperimentsClient.CreateAsync();
            // Initialize request argument(s)
            StartExperimentRequest request = new StartExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            // Make the request
            Experiment response = await experimentsClient.StartExperimentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StartExperiment</summary>
        public void StartExperiment()
        {
            // Snippet: StartExperiment(string, CallSettings)
            // Create client
            ExperimentsClient experimentsClient = ExperimentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/environments/[ENVIRONMENT]/experiments/[EXPERIMENT]";
            // Make the request
            Experiment response = experimentsClient.StartExperiment(name);
            // End snippet
        }

        /// <summary>Snippet for StartExperimentAsync</summary>
        public async Task StartExperimentAsync()
        {
            // Snippet: StartExperimentAsync(string, CallSettings)
            // Additional: StartExperimentAsync(string, CancellationToken)
            // Create client
            ExperimentsClient experimentsClient = await ExperimentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/environments/[ENVIRONMENT]/experiments/[EXPERIMENT]";
            // Make the request
            Experiment response = await experimentsClient.StartExperimentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for StartExperiment</summary>
        public void StartExperimentResourceNames()
        {
            // Snippet: StartExperiment(ExperimentName, CallSettings)
            // Create client
            ExperimentsClient experimentsClient = ExperimentsClient.Create();
            // Initialize request argument(s)
            ExperimentName name = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]");
            // Make the request
            Experiment response = experimentsClient.StartExperiment(name);
            // End snippet
        }

        /// <summary>Snippet for StartExperimentAsync</summary>
        public async Task StartExperimentResourceNamesAsync()
        {
            // Snippet: StartExperimentAsync(ExperimentName, CallSettings)
            // Additional: StartExperimentAsync(ExperimentName, CancellationToken)
            // Create client
            ExperimentsClient experimentsClient = await ExperimentsClient.CreateAsync();
            // Initialize request argument(s)
            ExperimentName name = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]");
            // Make the request
            Experiment response = await experimentsClient.StartExperimentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for StopExperiment</summary>
        public void StopExperimentRequestObject()
        {
            // Snippet: StopExperiment(StopExperimentRequest, CallSettings)
            // Create client
            ExperimentsClient experimentsClient = ExperimentsClient.Create();
            // Initialize request argument(s)
            StopExperimentRequest request = new StopExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            // Make the request
            Experiment response = experimentsClient.StopExperiment(request);
            // End snippet
        }

        /// <summary>Snippet for StopExperimentAsync</summary>
        public async Task StopExperimentRequestObjectAsync()
        {
            // Snippet: StopExperimentAsync(StopExperimentRequest, CallSettings)
            // Additional: StopExperimentAsync(StopExperimentRequest, CancellationToken)
            // Create client
            ExperimentsClient experimentsClient = await ExperimentsClient.CreateAsync();
            // Initialize request argument(s)
            StopExperimentRequest request = new StopExperimentRequest
            {
                ExperimentName = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]"),
            };
            // Make the request
            Experiment response = await experimentsClient.StopExperimentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StopExperiment</summary>
        public void StopExperiment()
        {
            // Snippet: StopExperiment(string, CallSettings)
            // Create client
            ExperimentsClient experimentsClient = ExperimentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/environments/[ENVIRONMENT]/experiments/[EXPERIMENT]";
            // Make the request
            Experiment response = experimentsClient.StopExperiment(name);
            // End snippet
        }

        /// <summary>Snippet for StopExperimentAsync</summary>
        public async Task StopExperimentAsync()
        {
            // Snippet: StopExperimentAsync(string, CallSettings)
            // Additional: StopExperimentAsync(string, CancellationToken)
            // Create client
            ExperimentsClient experimentsClient = await ExperimentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/environments/[ENVIRONMENT]/experiments/[EXPERIMENT]";
            // Make the request
            Experiment response = await experimentsClient.StopExperimentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for StopExperiment</summary>
        public void StopExperimentResourceNames()
        {
            // Snippet: StopExperiment(ExperimentName, CallSettings)
            // Create client
            ExperimentsClient experimentsClient = ExperimentsClient.Create();
            // Initialize request argument(s)
            ExperimentName name = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]");
            // Make the request
            Experiment response = experimentsClient.StopExperiment(name);
            // End snippet
        }

        /// <summary>Snippet for StopExperimentAsync</summary>
        public async Task StopExperimentResourceNamesAsync()
        {
            // Snippet: StopExperimentAsync(ExperimentName, CallSettings)
            // Additional: StopExperimentAsync(ExperimentName, CancellationToken)
            // Create client
            ExperimentsClient experimentsClient = await ExperimentsClient.CreateAsync();
            // Initialize request argument(s)
            ExperimentName name = ExperimentName.FromProjectLocationAgentEnvironmentExperiment("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]");
            // Make the request
            Experiment response = await experimentsClient.StopExperimentAsync(name);
            // End snippet
        }
    }
}
