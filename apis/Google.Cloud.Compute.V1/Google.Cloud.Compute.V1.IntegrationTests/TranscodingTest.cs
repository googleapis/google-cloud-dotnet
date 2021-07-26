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
    /// Integration tests focused on the GRPC Transcoding
    /// </summary>
    [Collection(nameof(ComputeFixture))]
    public sealed class TranscodingTest
    {
        private readonly ComputeFixture _fixture;

        public TranscodingTest(ComputeFixture fixture) => _fixture = fixture;

        [Fact]
        public void ListZones_MaxResults()
        {
            var client = ZonesClient.Create();
            var allZones = client.List(_fixture.ProjectId);
            Assert.InRange(allZones.Count(), 3, int.MaxValue);

            var twoZones = client.List(new ListZonesRequest { Project = _fixture.ProjectId, MaxResults = 2 });
            Assert.Equal(2, twoZones.Count());
        }
    }
}
