// Copyright 2020 Google LLC
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
using Google.Cloud.Spanner.Admin.Instance.V1;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(SpannerDatabaseFixture))]
    [CommonTestDiagnostics]
    public class ResourceBasedRoutingTests
    {
        private readonly SpannerDatabaseFixture _fixture;
        public ResourceBasedRoutingTests(SpannerDatabaseFixture fixture) => _fixture = fixture;
        [Fact]
        public void Should_Override_Endpoint()
        {
            string resourceBasedRoutingFlag = Environment.GetEnvironmentVariable(SpannerConstants.ResourceBasedRouteVariableName);

            //enable Resource based routing
            Environment.SetEnvironmentVariable(SpannerConstants.ResourceBasedRouteVariableName, "true");

            //default endpoint
            string expectedHost = InstanceAdminClient.DefaultEndpoint.Host;

            using (SpannerConnection connection = _fixture.GetConnection())
            {
                using (SpannerCommand command = new SpannerCommand(connection))
                {
                    string instanceEndpointUri = Task.Run(() => InstanceHostManager.Default.GetHostAsnyc(connection.Project, connection.SpannerInstance)).ResultWithUnwrappedExceptions();
                    if (!string.IsNullOrWhiteSpace(instanceEndpointUri))
                    {
                        expectedHost = instanceEndpointUri;
                    }
                }
                //resource based routing will override the endpoint if available while open the connection.
                connection.Open();
                Assert.Equal(expectedHost, connection.Builder.Host);
            }
            Environment.SetEnvironmentVariable(SpannerConstants.ResourceBasedRouteVariableName, resourceBasedRoutingFlag);
        }
    }
}
