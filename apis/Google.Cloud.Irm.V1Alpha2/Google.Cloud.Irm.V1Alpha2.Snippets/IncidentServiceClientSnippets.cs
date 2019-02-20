// Copyright 2019 Google LLC
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

using Google.Api.Gax.ResourceNames;
using Google.Cloud.ClientTesting;
using Google.Protobuf.WellKnownTypes;
using System;
using Xunit;
using static Google.Cloud.Irm.V1Alpha2.Incident.Types;

namespace Google.Cloud.Irm.V1Alpha2.Snippets
{
    [Collection(nameof(IrmFixture))]
    [SnippetOutputCollector]
    public class IncidentServiceClientSnippets
    {
        private readonly IrmFixture _fixture;

        public IncidentServiceClientSnippets(IrmFixture fixture) => _fixture = fixture;

        [Fact]
        public void CreateAndUpdateIncident()
        {
            string projectId = _fixture.ProjectId;
            IncidentServiceClient client = IncidentServiceClient.Create();
            Incident incident = new Incident
            {
                Severity = Severity.Medium,
                Stage = Stage.Detected,
                Title = "Something is wrong"
            };
            ProjectName parent = new ProjectName(projectId);

            // Create the initial incident
            incident = client.CreateIncident(incident, parent);
            Console.WriteLine($"Created incident {incident.Name}");

            // Resolve the inciedent
            Incident patch = new Incident
            {
                IncidentName = incident.IncidentName,
                Stage = Stage.Resolved
            };
            client.UpdateIncident(patch, new FieldMask { Paths = { "stage" } });

            // Fetch and display
            Incident fetched = client.GetIncident(incident.IncidentName);
            Console.WriteLine($"Updated incident:");
            Console.WriteLine(fetched);
        }
    }
}
