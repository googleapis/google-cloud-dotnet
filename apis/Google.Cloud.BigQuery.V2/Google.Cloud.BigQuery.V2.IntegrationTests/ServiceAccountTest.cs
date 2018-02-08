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

using Xunit;

namespace Google.Cloud.BigQuery.V2.IntegrationTests
{
    [Collection(nameof(BigQueryFixture))]
    public class ServiceAccountTest
    {
        private readonly BigQueryFixture _fixture;

        public ServiceAccountTest(BigQueryFixture fixture) => _fixture = fixture;

        [Fact]
        public void GetBigQueryServiceAccountEmail()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string serviceEmail = client.GetBigQueryServiceAccountEmail();
            Assert.Contains("gserviceaccount.com", serviceEmail);
        }
    }
}
