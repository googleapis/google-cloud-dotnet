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

using Google.Cloud.Spanner.Data;
using Google.Cloud.Spanner.Data.IntegrationTests;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf.WellKnownTypes;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.V1.IntegrationTests
{
    [Collection(nameof(ReadTableFixture))]
    [CommonTestDiagnostics]
    public class ReliableStreamReaderTests
    {
        private readonly ReadTableFixture _fixture;

        public ReliableStreamReaderTests(ReadTableFixture fixture) =>
            _fixture = fixture;

        [Theory]
        [InlineData("k0", 1)]
        [InlineData("not found", 0)]
        public async Task HasDataAsync(string key, int expectedValueCount)
        {
            var request = new ExecuteSqlRequest
            {
                Sql = $"SELECT Key FROM {_fixture.TableName} WHERE Key=@Key",
                Params = new Struct { Fields = { { "Key", Value.ForString(key) } } },
                ParamTypes = { { "Key", new Type { Code = TypeCode.String } } }
            };
            var builder = new SpannerConnectionStringBuilder(_fixture.ConnectionString);
            var managedSession = await builder.AcquireManagedSessionAsync();
            try
            {
                using (SpannerConnection connection = new SpannerConnection(builder))
                {
                    await connection.OpenAsync(default);
                    ManagedTransaction managedTransaction = connection.AcquireManagedTransaction(null, out _);
                    using (var reader = await managedTransaction.ExecuteSqlStreamReaderAsync(request, null))
                    {
                        // While there are more values to read, HasDataAsync should return true
                        for (int valuesRead = 0; valuesRead < expectedValueCount; valuesRead++)
                        {
                            // We can call HasDataAsync multiple times without it changing state
                            for (int i = 0; i < 5; i++)
                            {
                                Assert.True(await reader.HasDataAsync(default));
                            }
                            Assert.NotNull(await reader.NextAsync(default));
                        }

                        // We can still call HasDataAsync multiple times
                        for (int i = 0; i < 5; i++)
                        {
                            Assert.False(await reader.HasDataAsync(default));
                        }
                    }
                }
            }
            finally
            {
                // Nothing to clean here
            }
        }
    }
}
