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
using Xunit.Abstractions;

namespace Google.Cloud.Compute.V1.IntegrationTests
{
    /// <summary>
    /// Integration tests for firewalls.
    /// </summary>
    [Collection(nameof(ComputeFixture))]
    public sealed class FirewallsTest
    {
        private readonly ITestOutputHelper _output;
        private readonly ComputeFixture _fixture;

        public FirewallsTest(ComputeFixture fixture, ITestOutputHelper output) =>
            (_fixture, _output) = (fixture, output);

        /// <summary>
        /// This test is primarily to check the "IPProtocol" property,
        /// which is declared as I_p_protocol in the proto (yes, with a capital I).
        /// </summary>
        [Fact(Skip = "https://github.com/googleapis/google-cloud-dotnet/issues/7649")]
        public void CreateFirewall()
        {   
            var client = FirewallsClient.Create();
            var firewallName = _fixture.GenerateResourceId();
            var firewallResource = new Firewall
            {
                Name = firewallName,
                SourceRanges = 
                {
                    "0.0.0.0/0"
                },
                Allowed = 
                {
                    new Allowed 
                    {
                        IPProtocol = "tcp",
                        Ports = 
                        {
                            "80",
                        },
                    }
                }
            };
            var insertOp = client.Insert(new InsertFirewallRequest { Project = _fixture.ProjectId, FirewallResource = firewallResource });
            var completed = insertOp.PollUntilCompleted();
            var result = completed.Result;
            _output.WriteLine(
                    $"Operation to insert firewall completed: status {result.Status}; start time {result.StartTime}; end time {result.EndTime}");
            var fetched = client.Get(new GetFirewallRequest { Project = _fixture.ProjectId, Firewall = firewallName });
            Assert.Equal(firewallName, fetched.Name);
            Assert.Equal("tcp", fetched.Allowed[0].IPProtocol);
        }
    }
}
