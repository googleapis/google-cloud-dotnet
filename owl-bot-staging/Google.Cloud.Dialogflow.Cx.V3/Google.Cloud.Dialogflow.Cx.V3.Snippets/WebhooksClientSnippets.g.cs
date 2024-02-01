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
    using Google.Cloud.Dialogflow.Cx.V3;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedWebhooksClientSnippets
    {
        /// <summary>Snippet for ListWebhooks</summary>
        public void ListWebhooksRequestObject()
        {
            // Snippet: ListWebhooks(ListWebhooksRequest, CallSettings)
            // Create client
            WebhooksClient webhooksClient = WebhooksClient.Create();
            // Initialize request argument(s)
            ListWebhooksRequest request = new ListWebhooksRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            // Make the request
            PagedEnumerable<ListWebhooksResponse, Webhook> response = webhooksClient.ListWebhooks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Webhook item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWebhooksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Webhook item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Webhook> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Webhook item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWebhooksAsync</summary>
        public async Task ListWebhooksRequestObjectAsync()
        {
            // Snippet: ListWebhooksAsync(ListWebhooksRequest, CallSettings)
            // Create client
            WebhooksClient webhooksClient = await WebhooksClient.CreateAsync();
            // Initialize request argument(s)
            ListWebhooksRequest request = new ListWebhooksRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListWebhooksResponse, Webhook> response = webhooksClient.ListWebhooksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Webhook item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWebhooksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Webhook item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Webhook> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Webhook item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWebhooks</summary>
        public void ListWebhooks()
        {
            // Snippet: ListWebhooks(string, string, int?, CallSettings)
            // Create client
            WebhooksClient webhooksClient = WebhooksClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            // Make the request
            PagedEnumerable<ListWebhooksResponse, Webhook> response = webhooksClient.ListWebhooks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Webhook item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWebhooksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Webhook item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Webhook> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Webhook item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWebhooksAsync</summary>
        public async Task ListWebhooksAsync()
        {
            // Snippet: ListWebhooksAsync(string, string, int?, CallSettings)
            // Create client
            WebhooksClient webhooksClient = await WebhooksClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            // Make the request
            PagedAsyncEnumerable<ListWebhooksResponse, Webhook> response = webhooksClient.ListWebhooksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Webhook item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWebhooksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Webhook item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Webhook> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Webhook item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWebhooks</summary>
        public void ListWebhooksResourceNames()
        {
            // Snippet: ListWebhooks(AgentName, string, int?, CallSettings)
            // Create client
            WebhooksClient webhooksClient = WebhooksClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            PagedEnumerable<ListWebhooksResponse, Webhook> response = webhooksClient.ListWebhooks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Webhook item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWebhooksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Webhook item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Webhook> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Webhook item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWebhooksAsync</summary>
        public async Task ListWebhooksResourceNamesAsync()
        {
            // Snippet: ListWebhooksAsync(AgentName, string, int?, CallSettings)
            // Create client
            WebhooksClient webhooksClient = await WebhooksClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            PagedAsyncEnumerable<ListWebhooksResponse, Webhook> response = webhooksClient.ListWebhooksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Webhook item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWebhooksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Webhook item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Webhook> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Webhook item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetWebhook</summary>
        public void GetWebhookRequestObject()
        {
            // Snippet: GetWebhook(GetWebhookRequest, CallSettings)
            // Create client
            WebhooksClient webhooksClient = WebhooksClient.Create();
            // Initialize request argument(s)
            GetWebhookRequest request = new GetWebhookRequest
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
            };
            // Make the request
            Webhook response = webhooksClient.GetWebhook(request);
            // End snippet
        }

        /// <summary>Snippet for GetWebhookAsync</summary>
        public async Task GetWebhookRequestObjectAsync()
        {
            // Snippet: GetWebhookAsync(GetWebhookRequest, CallSettings)
            // Additional: GetWebhookAsync(GetWebhookRequest, CancellationToken)
            // Create client
            WebhooksClient webhooksClient = await WebhooksClient.CreateAsync();
            // Initialize request argument(s)
            GetWebhookRequest request = new GetWebhookRequest
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
            };
            // Make the request
            Webhook response = await webhooksClient.GetWebhookAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWebhook</summary>
        public void GetWebhook()
        {
            // Snippet: GetWebhook(string, CallSettings)
            // Create client
            WebhooksClient webhooksClient = WebhooksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/webhooks/[WEBHOOK]";
            // Make the request
            Webhook response = webhooksClient.GetWebhook(name);
            // End snippet
        }

        /// <summary>Snippet for GetWebhookAsync</summary>
        public async Task GetWebhookAsync()
        {
            // Snippet: GetWebhookAsync(string, CallSettings)
            // Additional: GetWebhookAsync(string, CancellationToken)
            // Create client
            WebhooksClient webhooksClient = await WebhooksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/webhooks/[WEBHOOK]";
            // Make the request
            Webhook response = await webhooksClient.GetWebhookAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetWebhook</summary>
        public void GetWebhookResourceNames()
        {
            // Snippet: GetWebhook(WebhookName, CallSettings)
            // Create client
            WebhooksClient webhooksClient = WebhooksClient.Create();
            // Initialize request argument(s)
            WebhookName name = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]");
            // Make the request
            Webhook response = webhooksClient.GetWebhook(name);
            // End snippet
        }

        /// <summary>Snippet for GetWebhookAsync</summary>
        public async Task GetWebhookResourceNamesAsync()
        {
            // Snippet: GetWebhookAsync(WebhookName, CallSettings)
            // Additional: GetWebhookAsync(WebhookName, CancellationToken)
            // Create client
            WebhooksClient webhooksClient = await WebhooksClient.CreateAsync();
            // Initialize request argument(s)
            WebhookName name = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]");
            // Make the request
            Webhook response = await webhooksClient.GetWebhookAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateWebhook</summary>
        public void CreateWebhookRequestObject()
        {
            // Snippet: CreateWebhook(CreateWebhookRequest, CallSettings)
            // Create client
            WebhooksClient webhooksClient = WebhooksClient.Create();
            // Initialize request argument(s)
            CreateWebhookRequest request = new CreateWebhookRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Webhook = new Webhook(),
            };
            // Make the request
            Webhook response = webhooksClient.CreateWebhook(request);
            // End snippet
        }

        /// <summary>Snippet for CreateWebhookAsync</summary>
        public async Task CreateWebhookRequestObjectAsync()
        {
            // Snippet: CreateWebhookAsync(CreateWebhookRequest, CallSettings)
            // Additional: CreateWebhookAsync(CreateWebhookRequest, CancellationToken)
            // Create client
            WebhooksClient webhooksClient = await WebhooksClient.CreateAsync();
            // Initialize request argument(s)
            CreateWebhookRequest request = new CreateWebhookRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Webhook = new Webhook(),
            };
            // Make the request
            Webhook response = await webhooksClient.CreateWebhookAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateWebhook</summary>
        public void CreateWebhook()
        {
            // Snippet: CreateWebhook(string, Webhook, CallSettings)
            // Create client
            WebhooksClient webhooksClient = WebhooksClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            Webhook webhook = new Webhook();
            // Make the request
            Webhook response = webhooksClient.CreateWebhook(parent, webhook);
            // End snippet
        }

        /// <summary>Snippet for CreateWebhookAsync</summary>
        public async Task CreateWebhookAsync()
        {
            // Snippet: CreateWebhookAsync(string, Webhook, CallSettings)
            // Additional: CreateWebhookAsync(string, Webhook, CancellationToken)
            // Create client
            WebhooksClient webhooksClient = await WebhooksClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            Webhook webhook = new Webhook();
            // Make the request
            Webhook response = await webhooksClient.CreateWebhookAsync(parent, webhook);
            // End snippet
        }

        /// <summary>Snippet for CreateWebhook</summary>
        public void CreateWebhookResourceNames()
        {
            // Snippet: CreateWebhook(AgentName, Webhook, CallSettings)
            // Create client
            WebhooksClient webhooksClient = WebhooksClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            Webhook webhook = new Webhook();
            // Make the request
            Webhook response = webhooksClient.CreateWebhook(parent, webhook);
            // End snippet
        }

        /// <summary>Snippet for CreateWebhookAsync</summary>
        public async Task CreateWebhookResourceNamesAsync()
        {
            // Snippet: CreateWebhookAsync(AgentName, Webhook, CallSettings)
            // Additional: CreateWebhookAsync(AgentName, Webhook, CancellationToken)
            // Create client
            WebhooksClient webhooksClient = await WebhooksClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            Webhook webhook = new Webhook();
            // Make the request
            Webhook response = await webhooksClient.CreateWebhookAsync(parent, webhook);
            // End snippet
        }

        /// <summary>Snippet for UpdateWebhook</summary>
        public void UpdateWebhookRequestObject()
        {
            // Snippet: UpdateWebhook(UpdateWebhookRequest, CallSettings)
            // Create client
            WebhooksClient webhooksClient = WebhooksClient.Create();
            // Initialize request argument(s)
            UpdateWebhookRequest request = new UpdateWebhookRequest
            {
                Webhook = new Webhook(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Webhook response = webhooksClient.UpdateWebhook(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateWebhookAsync</summary>
        public async Task UpdateWebhookRequestObjectAsync()
        {
            // Snippet: UpdateWebhookAsync(UpdateWebhookRequest, CallSettings)
            // Additional: UpdateWebhookAsync(UpdateWebhookRequest, CancellationToken)
            // Create client
            WebhooksClient webhooksClient = await WebhooksClient.CreateAsync();
            // Initialize request argument(s)
            UpdateWebhookRequest request = new UpdateWebhookRequest
            {
                Webhook = new Webhook(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Webhook response = await webhooksClient.UpdateWebhookAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateWebhook</summary>
        public void UpdateWebhook()
        {
            // Snippet: UpdateWebhook(Webhook, FieldMask, CallSettings)
            // Create client
            WebhooksClient webhooksClient = WebhooksClient.Create();
            // Initialize request argument(s)
            Webhook webhook = new Webhook();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Webhook response = webhooksClient.UpdateWebhook(webhook, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateWebhookAsync</summary>
        public async Task UpdateWebhookAsync()
        {
            // Snippet: UpdateWebhookAsync(Webhook, FieldMask, CallSettings)
            // Additional: UpdateWebhookAsync(Webhook, FieldMask, CancellationToken)
            // Create client
            WebhooksClient webhooksClient = await WebhooksClient.CreateAsync();
            // Initialize request argument(s)
            Webhook webhook = new Webhook();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Webhook response = await webhooksClient.UpdateWebhookAsync(webhook, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteWebhook</summary>
        public void DeleteWebhookRequestObject()
        {
            // Snippet: DeleteWebhook(DeleteWebhookRequest, CallSettings)
            // Create client
            WebhooksClient webhooksClient = WebhooksClient.Create();
            // Initialize request argument(s)
            DeleteWebhookRequest request = new DeleteWebhookRequest
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
                Force = false,
            };
            // Make the request
            webhooksClient.DeleteWebhook(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteWebhookAsync</summary>
        public async Task DeleteWebhookRequestObjectAsync()
        {
            // Snippet: DeleteWebhookAsync(DeleteWebhookRequest, CallSettings)
            // Additional: DeleteWebhookAsync(DeleteWebhookRequest, CancellationToken)
            // Create client
            WebhooksClient webhooksClient = await WebhooksClient.CreateAsync();
            // Initialize request argument(s)
            DeleteWebhookRequest request = new DeleteWebhookRequest
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
                Force = false,
            };
            // Make the request
            await webhooksClient.DeleteWebhookAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteWebhook</summary>
        public void DeleteWebhook()
        {
            // Snippet: DeleteWebhook(string, CallSettings)
            // Create client
            WebhooksClient webhooksClient = WebhooksClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/webhooks/[WEBHOOK]";
            // Make the request
            webhooksClient.DeleteWebhook(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWebhookAsync</summary>
        public async Task DeleteWebhookAsync()
        {
            // Snippet: DeleteWebhookAsync(string, CallSettings)
            // Additional: DeleteWebhookAsync(string, CancellationToken)
            // Create client
            WebhooksClient webhooksClient = await WebhooksClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/webhooks/[WEBHOOK]";
            // Make the request
            await webhooksClient.DeleteWebhookAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWebhook</summary>
        public void DeleteWebhookResourceNames()
        {
            // Snippet: DeleteWebhook(WebhookName, CallSettings)
            // Create client
            WebhooksClient webhooksClient = WebhooksClient.Create();
            // Initialize request argument(s)
            WebhookName name = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]");
            // Make the request
            webhooksClient.DeleteWebhook(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWebhookAsync</summary>
        public async Task DeleteWebhookResourceNamesAsync()
        {
            // Snippet: DeleteWebhookAsync(WebhookName, CallSettings)
            // Additional: DeleteWebhookAsync(WebhookName, CancellationToken)
            // Create client
            WebhooksClient webhooksClient = await WebhooksClient.CreateAsync();
            // Initialize request argument(s)
            WebhookName name = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]");
            // Make the request
            await webhooksClient.DeleteWebhookAsync(name);
            // End snippet
        }
    }
}
