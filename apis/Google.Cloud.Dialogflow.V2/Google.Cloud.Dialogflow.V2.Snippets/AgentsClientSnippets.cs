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
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
