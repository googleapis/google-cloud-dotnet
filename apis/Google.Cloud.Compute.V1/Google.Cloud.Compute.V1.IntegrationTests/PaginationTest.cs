// Copyright 2021 Google LLC
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

using Xunit;

namespace Google.Cloud.Compute.V1.IntegrationTests
{
    /// <summary>
    /// Integration tests focused on pagination
    /// </summary>
    [Collection(nameof(ComputeFixture))]
    public sealed class PaginationTest
    {
        private readonly ComputeFixture _fixture;

        public PaginationTest(ComputeFixture fixture) => _fixture = fixture;

        [Fact]
        public void ListAcTypes()
        {   
            var client = AcceleratorTypesClient.Create();
            var allTypes = client.List(new ListAcceleratorTypesRequest{ Project = _fixture.ProjectId, Zone=_fixture.Zone, MaxResults = 2});
            bool foundInResponse = false;
            foreach (AcceleratorType at in allTypes)
                if (at.Name.Equals("nvidia-tesla-t4"))
                {
                    foundInResponse = true;
                    break;
                }
            Assert.True(foundInResponse);
        }

        [Fact]
        public void AggregatedListAcTypes()
        {   
            var client = AcceleratorTypesClient.Create();
            var allTypes = client.AggregatedList(new AggregatedListAcceleratorTypesRequest{ Project = _fixture.ProjectId});
            bool foundInResponse = false;
            foreach (var item in allTypes)
                if (item.Key.Equals("zones/us-central1-a"))
                {
                    foreach (AcceleratorType at in item.Value.AcceleratorTypes)
                        if (at.Name.Equals("nvidia-tesla-t4"))
                        {
                            foundInResponse = true;
                            break;
                        }
                    if (foundInResponse) 
                    {
                        break; 
                    }
                }
            Assert.True(foundInResponse);
        }
    }
}
