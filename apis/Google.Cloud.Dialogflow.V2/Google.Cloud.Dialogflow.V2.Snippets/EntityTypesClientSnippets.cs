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
using Google.Cloud.ClientTesting;
using System;
using Xunit;

namespace Google.Cloud.Dialogflow.V2.Snippets
{
    [Collection(nameof(DialogflowFixture))]
    [SnippetOutputCollector]
    public class EntityTypesClientSnippets
    {
        private readonly DialogflowFixture _fixture;

        public EntityTypesClientSnippets(DialogflowFixture fixture) => _fixture = fixture;

        [Fact(Skip = "Only works for projects that already have an agent")]
        public void ListEntityTypes()
        {
            string projectId = _fixture.ProjectId;

            // Note: deliberately not a snippet just yet, but written so that it's ready to be
            // if we think that would be better than the generated one.
            EntityTypesClient client = EntityTypesClient.Create();
            PagedEnumerable<ListEntityTypesResponse, EntityType> response = client.ListEntityTypes(AgentName.FromProject(projectId));

            foreach (EntityType entityType in response)
            {
                Console.WriteLine($"Entity name: {entityType.Name}");
                Console.WriteLine($"Entity display name: {entityType.DisplayName}");
                Console.WriteLine($"Number of entities: {entityType.Entities.Count}");
            }
        }
    }
}
