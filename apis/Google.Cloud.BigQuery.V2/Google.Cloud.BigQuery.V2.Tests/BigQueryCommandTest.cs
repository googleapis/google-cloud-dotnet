// Copyright 2016 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Bigquery.v2.Data;
using System;
using Xunit;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class BigQueryCommandTest
    {
        [Fact]
        public void ParameterModeIsVerified()
        {
            var command = new BigQueryCommand();
            Assert.Throws<ArgumentException>(() => command.ParameterMode = (BigQueryParameterMode)3);
        }

        [Fact]
        public void ConstructionSample()
        {
            var command = new BigQueryCommand("sql here")
            {
                Parameters = { { BigQueryDbType.Int64, 10 } }
            };
            Assert.Equal("sql here", command.Sql);
            Assert.Equal(1, command.Parameters.Count);
            Assert.Equal(10, command.Parameters[0].Value);
            Assert.Equal(BigQueryDbType.Int64, command.Parameters[0].Type);
        }

        [Fact]
        public void PopulateQueryRequest()
        {
            var request = new QueryRequest();
            var command = new BigQueryCommand("sql here")
            {
                Parameters = { { BigQueryDbType.Int64, 10 } },
                ParameterMode = BigQueryParameterMode.Positional
            };
            command.PopulateQueryRequest(request);
            Assert.Equal("sql here", request.Query);
            Assert.Equal("positional", request.ParameterMode);
            Assert.Equal(1, request.QueryParameters.Count);
            Assert.Equal("10", request.QueryParameters[0].ParameterValue.Value);
        }

        [Fact]
        public void PopulateJobConfigurationQuery()
        {
            var jobConfig = new JobConfigurationQuery();
            var command = new BigQueryCommand("sql here")
            {
                Parameters = { { BigQueryDbType.Int64, 10 } },
                ParameterMode = BigQueryParameterMode.Positional
            };
            command.PopulateJobConfigurationQuery(jobConfig);
            Assert.Equal("sql here", jobConfig.Query);
            Assert.Equal("positional", jobConfig.ParameterMode);
            Assert.Equal(1, jobConfig.QueryParameters.Count);
            Assert.Equal("10", jobConfig.QueryParameters[0].ParameterValue.Value);
        }
    }
}
