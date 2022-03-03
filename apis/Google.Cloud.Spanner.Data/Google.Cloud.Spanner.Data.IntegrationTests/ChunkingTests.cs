// Copyright 2017 Google Inc. All Rights Reserved.
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

using Google.Cloud.ClientTesting;
using Google.Cloud.Spanner.Data.CommonTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(ChunkingTableFixture))]
    [CommonTestDiagnostics]
    public class ChunkingTests
    {
        private readonly ChunkingTableFixture _fixture;
        private const int MaxDataSize = 2621000;
        private const int MinDataSize = 1000000;
        private readonly Dictionary<string, string> _stringValues = new Dictionary<string, string>();
        private readonly Dictionary<string, byte[]> _bytesValues = new Dictionary<string, byte[]>();
        private readonly Dictionary<string, string[]> _stringArrayValues = new Dictionary<string, string[]>();
        private readonly Dictionary<string, byte[][]> _bytesArrayValues = new Dictionary<string, byte[][]>();
        private readonly HashSet<string> _addedKeys = new HashSet<string>();

        private readonly Random _random;
        private readonly int _seed;

        public ChunkingTests(ChunkingTableFixture fixture)
        {
            _fixture = fixture;
            _seed = Environment.TickCount;
            _random = new Random(_seed);
        }

        private string GetLargeString(int minSize, int maxSize)
        {
            var builder = new StringBuilder();
            int size = _random.Next(minSize, maxSize);
            for (var i = 0; i < size; i++)
            {
                builder.Append((char) ('a' + _random.Next(26)));
            }
            return builder.ToString();
        }

        private string[] GetLargeStringArray() =>
            Enumerable.Range(0, _random.Next(10, 20)).Select(_ => GetLargeString(100000, 200000)).ToArray();

        private byte[] GetLargeBytes(int minSize, int maxSize)
        {
            int size = _random.Next(minSize, maxSize);
            var bytes = new byte[size];
            _random.NextBytes(bytes);
            return bytes;
        }

        private byte[][] GetLargeBytesArray() =>
            Enumerable.Range(0, _random.Next(10, 20)).Select(_ => GetLargeBytes(100000, 200000)).ToArray();

        private Task InsertRowAsync(SpannerCommand writeCommand)
        {
            string k = IdGenerator.FromGuid();
            _addedKeys.Add(k);
            writeCommand.Parameters["K"].Value = k;
            _stringValues[k] = (string) (writeCommand.Parameters["StringValue"].Value =
                GetLargeString(MinDataSize, MaxDataSize));
            _stringArrayValues[k] = (string[]) (writeCommand.Parameters["StringArrayValue"].Value =
                GetLargeStringArray());
            _bytesValues[k] = (byte[]) (writeCommand.Parameters["BytesValue"].Value =
                GetLargeBytes(MinDataSize, MaxDataSize));
            _bytesArrayValues[k] = (byte[][]) (writeCommand.Parameters["BytesArrayValue"].Value = GetLargeBytesArray());

            return writeCommand.ExecuteNonQueryAsync();
        }

        [Fact]
        public async Task TestChunking()
        {
            FileLogger.Log($"Seed={_seed}");
            var rowsRead = 0;
            int rowsToWrite = _random.Next(1, 6);

            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();
                await RetryHelpers.ExecuteWithRetryAsync(async () =>
                {
                    using (var tx = await connection.BeginTransactionAsync())
                    {
                        using (var cmd = connection.CreateInsertCommand(
                            _fixture.TableName, new SpannerParameterCollection
                            {
                            new SpannerParameter("K", SpannerDbType.String),
                            new SpannerParameter("StringValue", SpannerDbType.String),
                            new SpannerParameter("StringArrayValue", SpannerDbType.ArrayOf(SpannerDbType.String)),
                            new SpannerParameter("BytesValue", SpannerDbType.Bytes),
                            new SpannerParameter("BytesArrayValue", SpannerDbType.ArrayOf(SpannerDbType.Bytes))
                            }))
                        {
                            cmd.Transaction = tx;

                            //write 1-5 rows
                            for (var i = 0; i < rowsToWrite; i++)
                            {
                                await InsertRowAsync(cmd);
                            }

                            await tx.CommitAsync();
                        }
                    }
                });

                using (var readCmd = connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName}"))
                {
                    using (var reader = await readCmd.ExecuteReaderAsync())
                    {
                        var keySet = new HashSet<string>();
                        while (await reader.ReadAsync())
                        {
                            var k = reader.GetFieldValue<string>("K");
                            if (!_addedKeys.Contains(k))
                            {
                                continue; // this key is from a previous test run.
                            }
                            rowsRead++;
                            Assert.True(keySet.Add(k));
                            Assert.Equal(_stringValues[k], reader.GetFieldValue<string>("StringValue"));
                            Assert.Equal(_stringArrayValues[k], reader.GetFieldValue<string[]>("StringArrayValue"));
                            Assert.Equal(_bytesValues[k], reader.GetFieldValue<byte[]>("BytesValue"));
                            Assert.Equal(_bytesArrayValues[k], reader.GetFieldValue<byte[][]>("BytesArrayValue"));
                        }
                    }
                }
            }

            Assert.Equal(rowsToWrite, rowsRead);
        }
    }
}
