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

using gcscv = Google.Cloud.Spanner.Common.V1;
using wkt = Google.Protobuf.WellKnownTypes;
using stt = System.Threading.Tasks;
using Xunit;
using Google.Cloud.Spanner.Admin.Instance.V1;
using System.Linq;
using System;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(SpannerDatabaseFixture))]
    [CommonTestDiagnostics]
    public class ResourceBasedRoutingTests
    {
        private readonly SpannerDatabaseFixture _fixture;
        public ResourceBasedRoutingTests(SpannerDatabaseFixture fixture) => _fixture = fixture;
        private const string ResourceBasedRouteVariableName = "GOOGLE_CLOUD_ENABLE_RESOURCE_BASED_ROUTING";
        [Fact]
        public async stt.Task Should_Override_Endpoint()
        {
            var resourceBasedRoutingFlag = Environment.GetEnvironmentVariable(ResourceBasedRouteVariableName);

            //enable Resource based routing
            Environment.SetEnvironmentVariable(ResourceBasedRouteVariableName, "true");

            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = new gcscv::InstanceName(_fixture.ProjectId, _fixture.Database.SpannerInstance),
                FieldMask = new wkt.FieldMask { Paths = { "endpoint_uris" } }
            };

            //default endpoint
            string expectedHost = InstanceAdminClient.DefaultEndpoint.Host;
            //get instance EndpointUris
            InstanceAdminClient instanceAdminClient = InstanceAdminClient.Create();
            var instance = await instanceAdminClient.GetInstanceAsync(request);

            if (instance.EndpointUris.Any())
            {
                expectedHost = instance.EndpointUris.FirstOrDefault();
            }
            using (var connection = _fixture.GetConnection())
            {
                //resource based routing will override the endpoint if available while open the connection.
                connection.Open();
                Assert.Equal(expectedHost, connection.Builder.Host);
            }
            Environment.SetEnvironmentVariable(ResourceBasedRouteVariableName, resourceBasedRoutingFlag);
        }
    }
}
