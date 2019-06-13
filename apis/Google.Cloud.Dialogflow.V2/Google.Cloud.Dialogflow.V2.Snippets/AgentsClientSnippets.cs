// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.ResourceNames;
using Google.Cloud.ClientTesting;
using Google.Protobuf;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Dialogflow.V2.Snippets
{
    [Collection(nameof(DialogflowFixture))]
    [SnippetOutputCollector]
    public class AgentsClientSnippets
    {
        private readonly DialogflowFixture _fixture;

        public AgentsClientSnippets(DialogflowFixture fixture) => _fixture = fixture;

        [Fact]
        public void SearchAgents()
        {
            string projectId = _fixture.ProjectId;

            // Note: deliberately not a snippet just yet, but written so that it's ready to be
            // if we think that would be better than the generated one.
            AgentsClient client = AgentsClient.Create();
            PagedEnumerable<SearchAgentsResponse, Agent> response = client.SearchAgents(new ProjectName(projectId));

            List<Agent> allAgents = response.ToList();

            foreach (Agent agent in allAgents)
            {
                Console.WriteLine($"Agent display name: {agent.DisplayName}");
            }
            Console.WriteLine($"Total agents: {allAgents.Count}");
        }

        // Sample: Webhook
        public class DialogflowController : ControllerBase
        {
            // A Protobuf JSON parser configured to ignore unknown fields. This makes
            // the action robust against new fields being introduced by Dialogflow.
            private static readonly JsonParser jsonParser =
                new JsonParser(JsonParser.Settings.Default.WithIgnoreUnknownFields(true));

            public ContentResult DialogAction()
            {
                // Parse the body of the request using the Protobuf JSON parser,
                // *not* Json.NET.
                WebhookRequest request;
                using (var reader = new StreamReader(Request.Body))
                {
                    request = jsonParser.Parse<WebhookRequest>(reader);
                }

                // Note: you should authenticate the request here.

                // Populate the response
                WebhookResponse response = new WebhookResponse
                {
                    // ...
                };

                // Ask Protobuf to format the JSON to return.
                // Again, we don't want to use Json.NET - it doesn't know how to handle Struct
                // values etc.
                string responseJson = response.ToString();
                return Content(responseJson, "application/json");
            }
        }
        // End sample

        // We don't want this project to depend on (classic) Web API properly, so we just declare our own
        // controller class with the single property we care about.
        public class ApiController
        {
            public HttpRequestMessage Request { get; set; }
        }

        // Sample: WebApiWebhook
        public class WebApiController : ApiController
        {
            // A Protobuf JSON parser configured to ignore unknown fields. This makes
            // the action robust against new fields being introduced by Dialogflow.
            private static readonly JsonParser jsonParser =
                new JsonParser(JsonParser.Settings.Default.WithIgnoreUnknownFields(true));

            [HttpPost]
            public async Task<HttpResponseMessage> Post()
            {
                WebhookRequest request;
                using (var stream = await Request.Content.ReadAsStreamAsync())
                {
                    using (var reader = new StreamReader(stream))
                    {
                        request = jsonParser.Parse<WebhookRequest>(reader);
                    }
                }
                WebhookResponse webhookResponse = new WebhookResponse
                {
                    // ...
                };
                HttpResponseMessage httpResponse = new HttpResponseMessage(HttpStatusCode.OK)
                {
                    // Ask Protobuf to format the JSON to return.
                    // Again, we don't want to use Json.NET - it doesn't know how to handle Struct
                    // values etc.
                    Content = new StringContent(webhookResponse.ToString())
                    {
                        Headers = { ContentType = new MediaTypeHeaderValue("text/json") }
                    }
                };

                return httpResponse;
            }
        }
        // End sample
    }
}
