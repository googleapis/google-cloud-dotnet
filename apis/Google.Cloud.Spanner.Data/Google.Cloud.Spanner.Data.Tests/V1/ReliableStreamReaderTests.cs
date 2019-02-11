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

using Google.Api.Gax.Grpc.Testing;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf.WellKnownTypes;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.V1.Tests
{
    public class ReliableStreamReaderTests
    {
        [Fact]
        public async Task SimpleStringValues()
        {
            var results = new[]
            {
                CreateResultSet("a", "b", "c"),
                CreateResultSet("d", "e"),
                CreateResultSet("f", "g", "h")
            };
            var reader = CreateReader(results); // Populates results[0].Metadata too
            await AssertValues(reader, "a", "b", "c", "d", "e", "f", "g", "h");
            Assert.Equal(results[0].Metadata, await reader.GetMetadataAsync(default));
        }

        [Fact]
        public async Task StringMerging()
        {
            var results = new[]
            {
                CreateResultSet("a", "x"),
                CreateResultSet("y", "c")
            };
            results[0].ChunkedValue = true;
            var reader = CreateReader(results);
            await AssertValues(reader, "a", "xy", "c");
        }

        private static async Task AssertValues(ReliableStreamReader reader, params string[] expectedValues)
        {
            var actual = new List<string>();
            Value value;
            while ((value = await reader.NextAsync(default)) != null)
            {
                Assert.Equal(Value.KindOneofCase.StringValue, value.KindCase);
                actual.Add(value.StringValue);
            }
            Assert.Equal(expectedValues, actual.ToArray());
        }

        private static PartialResultSet CreateResultSet(params string[] textValues) =>
            CreateResultSet(textValues.Select(text => Value.ForString(text)));

        private static PartialResultSet CreateResultSet(IEnumerable<Value> values) => new PartialResultSet { Values = { values } };

        private static ReliableStreamReader CreateReader(PartialResultSet[] results, ResultSetMetadata metadata = null)
        {
            results[0].Metadata = metadata ?? CreateSingleStringFieldMetadata();
            return new ReliableStreamReader(new AsyncStreamAdapter<PartialResultSet>(results.ToAsyncEnumerable().GetEnumerator()), Logger.DefaultLogger);
        }

        private static ResultSetMetadata CreateSingleStringFieldMetadata() =>
           new ResultSetMetadata
           {
               RowType = new StructType
               {
                   Fields =
                   {
                        new StructType.Types.Field
                        {
                            Name = "text", Type = new V1.Type { Code = TypeCode.String }
                        }
                   }
               }
           };
    }
}
