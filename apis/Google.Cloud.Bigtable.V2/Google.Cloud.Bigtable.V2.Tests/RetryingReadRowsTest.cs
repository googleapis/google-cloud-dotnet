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

using Google.Api.Gax;
using Google.Cloud.Bigtable.Common.V2;
using Google.Protobuf;
using Grpc.Core;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Bigtable.V2.Tests
{
    public class RetryingReadRowsTest
    {
        [Fact]
        public async Task SimpleRetryWithKeys()
        {
            var request = new ReadRowsRequest
            {
                Rows = RowSet.FromRowKeys("a", "b", "c")
            };
            var client = Utilities.CreateReadRowsMockClient(
                request,
                initialStreamResponse: new[]
                {
                    new ReadRowsResponse
                    {
                        Chunks =
                        {
                            CreateChunk("a", "cf1", "column1", "value1", commitRow: true)
                        }
                    }
                },
                responsesForRetryStreams: new[]
                {
                    new []
                    {
                        new ReadRowsResponse
                        {
                            Chunks =
                            {
                                CreateChunk("b", "cf1", "column2", "value2", commitRow: true)
                            }
                        }
                    }
                });

            var rows = await client.ReadRows(request).ToListAsync();
            Assert.Equal(2, rows.Count);

            var row = rows[0];
            Assert.Equal("a", row.Key.ToStringUtf8());
            Assert.Equal("cf1", row.Families[0].Name);
            Assert.Equal("column1", row.Families[0].Columns[0].Qualifier.ToStringUtf8());
            Assert.Equal("value1", row.Families[0].Columns[0].Cells[0].Value.ToStringUtf8());

            row = rows[1];
            Assert.Equal("b", row.Key.ToStringUtf8());
            Assert.Equal("cf1", row.Families[0].Name);
            Assert.Equal("column2", row.Families[0].Columns[0].Qualifier.ToStringUtf8());
            Assert.Equal("value2", row.Families[0].Columns[0].Cells[0].Value.ToStringUtf8());
        }

        [Fact]
        public async Task SimpleRetryWithRanges()
        {
            var request = new ReadRowsRequest
            {
                Rows = RowSet.FromRowRanges(RowRange.Closed("a", "z"))
            };
            var client = Utilities.CreateReadRowsMockClient(
                request,
                initialStreamResponse: new[]
                {
                    new ReadRowsResponse
                    {
                        Chunks =
                        {
                            CreateChunk("a", "cf1", "column1", "value1", commitRow: true)
                        }
                    }
                },
                responsesForRetryStreams: new[]
                {
                    new []
                    {
                        new ReadRowsResponse
                        {
                            Chunks =
                            {
                                CreateChunk("b", "cf1", "column2", "value2", commitRow: true)
                            }
                        }
                    }
                });

            var rows = await client.ReadRows(request).ToListAsync();
            Assert.Equal(2, rows.Count);

            var row = rows[0];
            Assert.Equal("a", row.Key.ToStringUtf8());
            Assert.Equal("cf1", row.Families[0].Name);
            Assert.Equal("column1", row.Families[0].Columns[0].Qualifier.ToStringUtf8());
            Assert.Equal("value1", row.Families[0].Columns[0].Cells[0].Value.ToStringUtf8());

            row = rows[1];
            Assert.Equal("b", row.Key.ToStringUtf8());
            Assert.Equal("cf1", row.Families[0].Name);
            Assert.Equal("column2", row.Families[0].Columns[0].Qualifier.ToStringUtf8());
            Assert.Equal("value2", row.Families[0].Columns[0].Cells[0].Value.ToStringUtf8());
        }

        [Fact]
        public async Task RetryWithLastScannedKey()
        {
            var request = new ReadRowsRequest
            {
                Rows = RowSet.FromRowRanges(RowRange.Closed("a", "z"))
            };
            var client = Utilities.CreateReadRowsMockClient(
                request,
                initialStreamResponse: new[]
                {
                    new ReadRowsResponse
                    {
                        Chunks =
                        {
                            CreateChunk("a", "cf1", "column1", "value1", commitRow: true)
                        }
                    },
                    new ReadRowsResponse
                    {
                        LastScannedRowKey = ByteString.CopyFromUtf8("m")
                    }
                },
                responsesForRetryStreams: new[]
                {
                    new []
                    {
                        new ReadRowsResponse
                        {
                            Chunks =
                            {
                                CreateChunk("w", "cf1", "column2", "value2", commitRow: true)
                            }
                        }
                    }
                });

            var rows = await client.ReadRows(request).ToListAsync();
            Assert.Equal(2, rows.Count);

            var row = rows[0];
            Assert.Equal("a", row.Key.ToStringUtf8());
            Assert.Equal("cf1", row.Families[0].Name);
            Assert.Equal("column1", row.Families[0].Columns[0].Qualifier.ToStringUtf8());
            Assert.Equal("value1", row.Families[0].Columns[0].Cells[0].Value.ToStringUtf8());

            row = rows[1];
            Assert.Equal("w", row.Key.ToStringUtf8());
            Assert.Equal("cf1", row.Families[0].Name);
            Assert.Equal("column2", row.Families[0].Columns[0].Qualifier.ToStringUtf8());
            Assert.Equal("value2", row.Families[0].Columns[0].Cells[0].Value.ToStringUtf8());
        }

        [Fact]
        public async Task RetryWithLastScannedKey_Error()
        {
            var request = new ReadRowsRequest
            {
                Rows = RowSet.FromRowRanges(RowRange.Closed("a", "z"))
            };
            var client = Utilities.CreateReadRowsMockClient(
                request,
                initialStreamResponse: new[]
                {
                    new ReadRowsResponse
                    {
                        Chunks =
                        {
                            CreateChunk("a", "cf1", "column1", "value1", commitRow: true)
                        }
                    },
                    new ReadRowsResponse
                    {
                        LastScannedRowKey = ByteString.CopyFromUtf8("b")
                    }
                },
                responsesForRetryStreams: new[]
                {
                    new []
                    {
                        new ReadRowsResponse
                        {
                            Chunks =
                            {
                                CreateChunk("b", "cf1", "column2", "value2", commitRow: true)
                            }
                        }
                    }
                });

            var stream = client.ReadRows(request);

            // We should be able to read one full row and then there should be an exception in the request validator
            // of Utilities.CreateReadRowsMockClient because the response from the retry stream with the "b" row key
            // should be outside the range of (b-z] requested during retry.
            int rowCount = 0;
            await Assert.ThrowsAsync<InvalidOperationException>(() => stream.ForEachAsync(row => rowCount++));
            Assert.Equal(1, rowCount);
        }

        [Fact]
        public async Task RetryDuringPartialRow()
        {
            var request = new ReadRowsRequest
            {
                Rows = RowSet.FromRowRanges(RowRange.Closed("a", "z"))
            };
            var client = Utilities.CreateReadRowsMockClient(
                request,
                initialStreamResponse: new[]
                {
                    new ReadRowsResponse
                    {
                        Chunks =
                        {
                            CreateChunk("a", "cf1", "column1", "value1")
                        }
                    }
                },
                responsesForRetryStreams: new[]
                {
                    new []
                    {
                        new ReadRowsResponse
                        {
                            Chunks =
                            {
                                CreateChunk("a", "cf1", "column1", "value1"),
                                CreateChunk("a", "cf1", "column2", "value2", commitRow: true)
                            }
                        }
                    }
                });

            var rows = await client.ReadRows(request).ToListAsync();
            Assert.Equal(1, rows.Count);

            var row = rows[0];
            Assert.Equal("a", row.Key.ToStringUtf8());
            Assert.Equal("cf1", row.Families[0].Name);
            Assert.Equal("column1", row.Families[0].Columns[0].Qualifier.ToStringUtf8());
            Assert.Equal("value1", row.Families[0].Columns[0].Cells[0].Value.ToStringUtf8());
            Assert.Equal("column2", row.Families[0].Columns[1].Qualifier.ToStringUtf8());
            Assert.Equal("value2", row.Families[0].Columns[1].Cells[0].Value.ToStringUtf8());
        }

        [Fact]
        public async Task RetryDuringPartialRow_ChangedValue()
        {
            var request = new ReadRowsRequest
            {
                Rows = RowSet.FromRowRanges(RowRange.Closed("a", "z"))
            };
            var client = Utilities.CreateReadRowsMockClient(
                request,
                initialStreamResponse: new[]
                {
                    new ReadRowsResponse
                    {
                        Chunks =
                        {
                            CreateChunk("a", "cf1", "column1", "value1")
                        }
                    }
                },
                responsesForRetryStreams: new[]
                {
                    new []
                    {
                        new ReadRowsResponse
                        {
                            Chunks =
                            {
                                CreateChunk("a", "cf1", "column1", "value3"),
                                CreateChunk("a", "cf1", "column2", "value2", commitRow: true)
                            }
                        }
                    }
                });

            var rows = await client.ReadRows(request).ToListAsync();
            Assert.Equal(1, rows.Count);

            var row = rows[0];
            Assert.Equal("a", row.Key.ToStringUtf8());
            Assert.Equal("cf1", row.Families[0].Name);
            Assert.Equal("column1", row.Families[0].Columns[0].Qualifier.ToStringUtf8());
            Assert.Equal("value3", row.Families[0].Columns[0].Cells[0].Value.ToStringUtf8());
            Assert.Equal("column2", row.Families[0].Columns[1].Qualifier.ToStringUtf8());
            Assert.Equal("value2", row.Families[0].Columns[1].Cells[0].Value.ToStringUtf8());
        }

        [Fact]
        public async Task RetryPartialRowAfterCompleteRow()
        {
            var request = new ReadRowsRequest
            {
                Rows = RowSet.FromRowRanges(RowRange.Closed("a", "z"))
            };
            var client = Utilities.CreateReadRowsMockClient(
                request,
                initialStreamResponse: new[]
                {
                    new ReadRowsResponse
                    {
                        Chunks =
                        {
                            CreateChunk("a", "cf1", "column1", "value1", commitRow: true),
                            CreateChunk("b", "cf1", "column2", "value2")
                        }
                    }
                },
                responsesForRetryStreams: new[]
                {
                    new []
                    {
                        new ReadRowsResponse
                        {
                            Chunks =
                            {
                                CreateChunk("b", "cf1", "column2", "value2"),
                                CreateChunk("b", "cf1", "column3", "value3", commitRow: true)
                            }
                        }
                    }
                });

            var rows = await client.ReadRows(request).ToListAsync();
            Assert.Equal(2, rows.Count);

            var row = rows[0];
            Assert.Equal("a", row.Key.ToStringUtf8());
            Assert.Equal("cf1", row.Families[0].Name);
            Assert.Equal("column1", row.Families[0].Columns[0].Qualifier.ToStringUtf8());
            Assert.Equal("value1", row.Families[0].Columns[0].Cells[0].Value.ToStringUtf8());

            row = rows[1];
            Assert.Equal("b", row.Key.ToStringUtf8());
            Assert.Equal("cf1", row.Families[0].Name);
            Assert.Equal("column2", row.Families[0].Columns[0].Qualifier.ToStringUtf8());
            Assert.Equal("value2", row.Families[0].Columns[0].Cells[0].Value.ToStringUtf8());
            Assert.Equal("column3", row.Families[0].Columns[1].Qualifier.ToStringUtf8());
            Assert.Equal("value3", row.Families[0].Columns[1].Cells[0].Value.ToStringUtf8());
        }

        [Fact]
        public async Task RetryDuringSplitCell()
        {
            var request = new ReadRowsRequest
            {
                Rows = RowSet.FromRowRanges(RowRange.Closed("a", "z"))
            };
            var client = Utilities.CreateReadRowsMockClient(
                request,
                initialStreamResponse: new[]
                {
                    new ReadRowsResponse
                    {
                        Chunks =
                        {
                            CreateChunk("a", "cf1", "column1", "valu", valueSize: 6)
                        }
                    }
                },
                responsesForRetryStreams: new[]
                {
                    new []
                    {
                        new ReadRowsResponse
                        {
                            Chunks =
                            {
                                CreateChunk("a", "cf1", "column1", "valu", valueSize: 6),
                                CreateContinuationChunk("e1", commitRow: true)
                            }
                        }
                    }
                });

            var rows = await client.ReadRows(request).ToListAsync();
            Assert.Equal(1, rows.Count);

            var row = rows[0];
            Assert.Equal("a", row.Key.ToStringUtf8());
            Assert.Equal("cf1", row.Families[0].Name);
            Assert.Equal("column1", row.Families[0].Columns[0].Qualifier.ToStringUtf8());
            Assert.Equal("value1", row.Families[0].Columns[0].Cells[0].Value.ToStringUtf8());
        }

        [Fact]
        public async Task ErrorAtVeryEndDoesntCauseRetry()
        {
            var request = new ReadRowsRequest
            {
                Rows = RowSet.FromRowKeys("a")
            };
            var client = Utilities.CreateReadRowsMockClient(
                request,
                initialStreamResponse: new[]
                {
                    new ReadRowsResponse
                    {
                        Chunks =
                        {
                            CreateChunk("a", "cf1", "column1", "value1", commitRow: true)
                        }
                    }
                },
                errorAtEndOfLastStream: true);

            var rows = await client.ReadRows(request).ToListAsync();
            Assert.Equal(1, rows.Count);

            var row = rows[0];
            Assert.Equal("a", row.Key.ToStringUtf8());
            Assert.Equal("cf1", row.Families[0].Name);
            Assert.Equal("column1", row.Families[0].Columns[0].Qualifier.ToStringUtf8());
            Assert.Equal("value1", row.Families[0].Columns[0].Cells[0].Value.ToStringUtf8());
        }

        [Fact]
        public async Task RetryingAfterTotalExpiration()
        {
            var settings = new BigtableServiceApiSettings();
            // Don't allow for any time to retry.
            settings.ReadRowsRetrySettings =
                settings.ReadRowsRetrySettings.WithTotalExpiration(
                    Expiration.FromTimeout(TimeSpan.Zero));

            var request = new ReadRowsRequest
            {
                Rows = RowSet.FromRowKeys("a", "b", "c")
            };
            var client = Utilities.CreateReadRowsMockClient(
                request,
                initialStreamResponse: new[]
                {
                    new ReadRowsResponse
                    {
                        Chunks =
                        {
                            CreateChunk("a", "cf1", "column1", "value1", commitRow: true)
                        }
                    }
                },
                responsesForRetryStreams: new[]
                {
                    null, // A null entry will throw an Unavailable RpcException
                    new []
                    {
                        new ReadRowsResponse
                        {
                            Chunks =
                            {
                                CreateChunk("b", "cf1", "column2", "value2", commitRow: true)
                            }
                        }
                    }
                },
                settings: settings);

            var exception = await Assert.ThrowsAsync<RpcException>(() => client.ReadRows(request).ToListAsync().AsTask());
            Assert.Equal(StatusCode.Unavailable, exception.StatusCode);
        }

        [Fact]
        public async Task RetryingBeforeTotalExpiration()
        {
            var request = new ReadRowsRequest
            {
                Rows = RowSet.FromRowKeys("a", "b", "c")
            };
            var client = Utilities.CreateReadRowsMockClient(
                request,
                initialStreamResponse: new[]
                {
                    new ReadRowsResponse
                    {
                        Chunks =
                        {
                            CreateChunk("a", "cf1", "column1", "value1", commitRow: true)
                        }
                    }
                },
                responsesForRetryStreams: new[]
                {
                    null, // A null entry will throw an Unavailable RpcException
                    new []
                    {
                        new ReadRowsResponse
                        {
                            Chunks =
                            {
                                CreateChunk("b", "cf1", "column2", "value2", commitRow: true)
                            }
                        }
                    }
                });

            await client.ReadRows(request).ToListAsync();
        }

        private static ReadRowsResponse.Types.CellChunk CreateChunk(
            BigtableByteString rowKey,
            string familyName,
            BigtableByteString qualifier,
            BigtableByteString value,
            int valueSize = 0,
            bool commitRow = false) =>
            new ReadRowsResponse.Types.CellChunk
            {
                RowKey = (ByteString)rowKey,
                FamilyName = familyName,
                Qualifier = (ByteString)qualifier,
                Value = (ByteString)value,
                ValueSize = valueSize,
                CommitRow = commitRow
            };

        private static ReadRowsResponse.Types.CellChunk CreateContinuationChunk(
            BigtableByteString value,
            int valueSize = 0,
            bool commitRow = false) =>
            new ReadRowsResponse.Types.CellChunk
            {
                Value = (ByteString)value,
                ValueSize = valueSize,
                CommitRow = commitRow
            };
    }
}
