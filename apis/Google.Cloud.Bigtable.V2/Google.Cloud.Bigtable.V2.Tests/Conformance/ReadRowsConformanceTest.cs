// Copyright 2019 Google LLC
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

using Google.Cloud.ClientTesting;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Bigtable.V2.Tests.Conformance
{
    public class ReadRowsConformanceTest
    {
        public static TheoryData<ReadRowsTest> TestData { get; } =
            ConformanceTestData.Load<TestFile>("bigtable", "v2").GetTheoryData(file => file.ReadRowsTests);

        [Theory, MemberData(nameof(TestData))]
        public async Task ReadRows(ReadRowsTest testCase)
        {
            var request = new ReadRowsRequest
            {
                Rows = RowSet.FromRowRanges(RowRange.Closed("", null))
            };
            var client = Utilities.CreateReadRowsMockClient(
                request,
                initialStreamResponse: new[]
                {
                    new ReadRowsResponse
                    {
                        Chunks = { testCase.Chunks }
                    }
                });
            var stream = client.ReadRows(request);

            List<Row> responses;
            if (testCase.Results.LastOrDefault()?.Error ?? false)
            {
                // Do not use ToList() here. We want to get all results before the first failure.
                responses = new List<Row>();
                await Assert.ThrowsAsync<InvalidOperationException>(
                    () => stream.ForEachAsync(row => responses.Add(row)));
            }
            else
            {
                responses = await stream.ToListAsync();
            }

            var results = from row in responses
                          from family in row.Families
                          from column in family.Columns
                          from cell in column.Cells
                          select new ReadRowsTest.Types.Result
                          {
                              RowKey = row.Key.ToStringUtf8(),
                              FamilyName = family.Name,
                              Qualifier = column.Qualifier.ToStringUtf8(),
                              TimestampMicros = cell.TimestampMicros,
                              Value = cell.Value.ToStringUtf8(),
                              Label = cell.Labels.FirstOrDefault() ?? "",
                              Error = false
                          };
            var expectedResults = testCase.Results.Where(r => !r.Error);
            Assert.True(expectedResults.SequenceEqual(results), testCase.Description);
        }
    }
    
    public partial class ReadRowsTest : ICustomDiagnosticMessage
    {
        public string ToDiagnosticString() => Description;
    }
}