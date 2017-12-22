// Copyright 2017 Google Inc. All rights reserved.
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

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Bigtable.V2.ReadRowsResponse.Types;

namespace Google.Cloud.Bigtable.V2.Tests
{
    public class ReadRowsAcceptanceTest
    {
        public static TheoryData<ChunkTestCase> AcceptanceTestCases { get; } = GetAcceptanceTestCases();

        private static TheoryData<ChunkTestCase> GetAcceptanceTestCases()
        {
            var typeInfo = typeof(ReadRowsAcceptanceTest).GetTypeInfo();
            string resourceName = $"{typeInfo.Namespace}.read-rows-acceptance-test.json";
            using (var reader = new StreamReader(typeInfo.Assembly.GetManifestResourceStream(resourceName)))
            {
                var acceptanceTest = JsonConvert.DeserializeObject<AcceptanceTest>(reader.ReadToEnd());
                var result = new TheoryData<ChunkTestCase>();
                foreach (var testCase in acceptanceTest.Tests)
                {
                    result.Add(testCase);
                }
                return result;
            }
        }

        [Theory]
        [MemberData(nameof(AcceptanceTestCases))]
        public async Task Test(ChunkTestCase testCase)
        {
            var stream = new MockReadRowsStream(
                new ReadRowsResponse
                {
                    Chunks = { testCase.Chunks.Select(json => CellChunk.Parser.ParseJson(json)) }
                });

            List<Row> responses;
            try
            {
                responses = await stream.AsAsyncEnumerable().ToList();
                Assert.False(testCase.ExpectsError, testCase.Name);
            }
            catch
            {
                responses = new List<Row>();
                Assert.True(testCase.ExpectsError, testCase.Name);
            }

            var results = from row in responses
                          from family in row.Families
                          from column in family.Columns
                          from cell in column.Cells
                          select new TestResult
                          {
                              RowKey = row.Key.ToStringUtf8(),
                              FamilyName = family.Name,
                              Qualifier = column.Qualifier.ToStringUtf8(),
                              Timestamp = cell.TimestampMicros,
                              Value = cell.Value.ToStringUtf8(),
                              Label = cell.Labels.FirstOrDefault() ?? "",
                              Error = false
                          };
            var expectedResults = testCase.GetNonExceptionResults();
            Assert.True(expectedResults.SequenceEqual(results), testCase.Name);
        }
    }

    public class AcceptanceTest
    {
        public List<ChunkTestCase> Tests { get; set; }
    }

    public class ChunkTestCase
    {
        public String Name { get; set; }
        public List<String> Chunks { get; set; }
        public List<TestResult> Results { get; set; }

        public bool ExpectsError => Results?.LastOrDefault()?.Error ?? false;

        public IEnumerable<TestResult> GetNonExceptionResults() =>
            Results?.Where(r => !r.Error) ?? Enumerable.Empty<TestResult>();
    }

    public class TestResult
    {
        [JsonProperty("rk")]
        public String RowKey;
        [JsonProperty("fm")]
        public String FamilyName;
        [JsonProperty("qual")]
        public String Qualifier;
        [JsonProperty("ts")]
        public long Timestamp;
        public String Value;
        public String Label;
        public bool Error;

        public override bool Equals(object obj)
        {
            return
                obj is TestResult other &&
                RowKey == other.RowKey &&
                FamilyName == other.FamilyName &&
                Qualifier == other.Qualifier &&
                Timestamp == other.Timestamp &&
                Value == other.Value &&
                Label == other.Label &&
                Error == other.Error;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(RowKey, FamilyName, Qualifier, Timestamp, Value, Label, Error).GetHashCode();
        }
    }
}
