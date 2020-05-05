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

using Google.Apis.Bigquery.v2;
using Xunit;
using static Google.Apis.Bigquery.v2.RoutinesResource;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class ListRoutinesOptionsTest
    {
        [Fact]
        public void ModifyRequest()
        {
            var options = new ListRoutinesOptions
            {
                PageSize = 25,
                PageToken = "nextpage",
                ReadMask = "a,b,c",
            };
            ListRequest request = new ListRequest(new BigqueryService(), "project", "dataset");
            options.ModifyRequest(request);
            Assert.Equal(25, request.MaxResults);
            Assert.Equal("nextpage", request.PageToken);
            Assert.Equal("a,b,c", request.ReadMask);
        }

        [Fact]
        public void ModifyRequest_FilterScalar()
        {
            var options = new ListRoutinesOptions
            {
                RoutineTypeFilter = RoutineType.ScalarFunction
            };
            ListRequest request = new ListRequest(new BigqueryService(), "project", "dataset");
            options.ModifyRequest(request);
            Assert.Equal("routineType:SCALAR_FUNCTION", request.Filter);
        }

        [Fact]
        public void ModifyRequest_FilterProcedure()
        {
            var options = new ListRoutinesOptions
            {
                RoutineTypeFilter = RoutineType.StoredProcedure
            };
            ListRequest request = new ListRequest(new BigqueryService(), "project", "dataset");
            options.ModifyRequest(request);
            Assert.Equal("routineType:PROCEDURE", request.Filter);
        }
    }
}
