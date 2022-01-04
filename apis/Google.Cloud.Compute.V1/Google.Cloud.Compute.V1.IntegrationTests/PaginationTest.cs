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

using System.Linq;
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
        public void ListAcceleratorTypes_ExplicitRequest()
        {   
            var client = AcceleratorTypesClient.Create();
            var allTypes = client.List(new ListAcceleratorTypesRequest { Project = _fixture.ProjectId, Zone = _fixture.Zone, MaxResults = 2 });
            Assert.Contains(allTypes, IsNVidiaTeslaT4);
        }

        [Fact]
        public void ListAcceleratorTypes_UsingPageSize()
        {
            var client = AcceleratorTypesClient.Create();
            var allTypes = client.List(_fixture.ProjectId, _fixture.Zone, pageSize: 2);
            Assert.Contains(allTypes, IsNVidiaTeslaT4);
        }

        [Fact]
        public void AggregatedListAcceleratorTypes()
        {   
            var client = AcceleratorTypesClient.Create();
            var allTypes = client.AggregatedList(_fixture.ProjectId);
            Assert.Contains(allTypes,
                entry => entry.Key == "zones/us-central1-a" && entry.Value.AcceleratorTypes.Any(IsNVidiaTeslaT4));
        }

        private static bool IsNVidiaTeslaT4(AcceleratorType type) => type.Name == "nvidia-tesla-t4";
    }
}
