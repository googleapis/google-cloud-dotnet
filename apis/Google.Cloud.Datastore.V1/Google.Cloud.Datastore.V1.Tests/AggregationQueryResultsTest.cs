// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
using Xunit;

namespace Google.Cloud.Datastore.V1.Tests;

public class AggregationQueryResultsTest
{
    [Fact]
    public void TestFromRunAggregationQueryResponse()
    {
        var moreResults = QueryResultBatch.Types.MoreResultsType.NoMoreResults;
        var readTime = Timestamp.FromDateTime(System.DateTime.UtcNow);
        MapField<string, Value> aggregateProperties = new MapField<string, Value>();
        aggregateProperties.Add("count", new Value { IntegerValue = 10 });
        var response = new RunAggregationQueryResponse
        {
            Batch = new AggregationResultBatch()
            {
                ReadTime = readTime,
                MoreResults = moreResults
            }
        };
        var aggregationResult = new AggregationResult();
        aggregationResult.AggregateProperties.Add(aggregateProperties);
        response.Batch.AggregationResults.Add(aggregationResult);

        var results = AggregationQueryResults.FromRunAggregationQueryResponse(response);
        Assert.Equal(readTime, results.ReadTime);
        Assert.Equal(moreResults, results.MoreResults);
        Assert.Equal(10, results["count"].IntegerValue);
        Assert.Null(results["invalidAlias"]);
    }

}
