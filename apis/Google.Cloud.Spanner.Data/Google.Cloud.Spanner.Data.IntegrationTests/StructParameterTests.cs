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

using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(SpannerDatabaseFixture))]
    [CommonTestDiagnostics]
    public class StructParameterTests
    {
        private readonly SpannerDatabaseFixture _fixture;

        public StructParameterTests(SpannerDatabaseFixture fixture) => _fixture = fixture;

        [Fact]
        public async Task SimpleFieldAccess()
        {
            var structParam = new SpannerStruct
            {
                { "threadf", SpannerDbType.Int64, 1 },
                { "userf", SpannerDbType.String, "bob" }
            };
            using (var connection = _fixture.GetConnection())
            {
                using (var cmd = connection.CreateSelectCommand("SELECT @struct_param.userf, @p4"))
                {
                    cmd.Parameters.Add("struct_param", structParam.GetSpannerDbType(), structParam);
                    cmd.Parameters.Add("p4", SpannerDbType.Int64, 10);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        Assert.True(await reader.ReadAsync());
                        Assert.Equal("bob", reader.GetString(0));
                        Assert.Equal(10L, reader.GetInt64(1));
                        Assert.False(await reader.ReadAsync());
                    }
                }
            }
        }

        [Fact]
        public async Task SimpleFieldAccess_NullStructValue()
        {
            var structSchema = new SpannerStruct
            {
                { "threadf", SpannerDbType.Int64, 1 },
                { "userf", SpannerDbType.String, "bob" }
            }.GetSpannerDbType();
            using (var connection = _fixture.GetConnection())
            {
                using (var cmd = connection.CreateSelectCommand("SELECT @struct_param.userf"))
                {
                    cmd.Parameters.Add("struct_param", structSchema, null);
                    cmd.Parameters.Add("p4", SpannerDbType.Int64, 10);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        Assert.True(await reader.ReadAsync());
                        Assert.True(reader.IsDBNull(0));
                        Assert.False(await reader.ReadAsync());
                    }
                }
            }
        }

        [Fact]
        public async Task NestedStructFieldAccess()
        {
            var nestedStruct = new SpannerStruct
            {
                { "nestedf", SpannerDbType.String, "bob" }
            };
            var outerStruct = new SpannerStruct
            {
                { "structf", nestedStruct.GetSpannerDbType(), nestedStruct }
            };

            using (var connection = _fixture.GetConnection())
            {
                using (var cmd = connection.CreateSelectCommand("SELECT @struct_param.structf.nestedf"))
                {
                    cmd.Parameters.Add("struct_param", outerStruct.GetSpannerDbType(), outerStruct);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        Assert.True(await reader.ReadAsync());
                        Assert.Equal("bob", reader.GetString(0));
                        Assert.False(await reader.ReadAsync());
                    }
                }
            }
        }

        [Fact]
        public async Task NestedStructFieldAccess_NullStructValue()
        {
            var nestedStruct = new SpannerStruct
            {
                { "nestedf", SpannerDbType.String, "bob" }
            };
            var outerStruct = new SpannerStruct
            {
                { "structf", nestedStruct.GetSpannerDbType(), nestedStruct }
            };

            using (var connection = _fixture.GetConnection())
            {
                using (var cmd = connection.CreateSelectCommand("SELECT @struct_param.structf.nestedf"))
                {
                    cmd.Parameters.Add("struct_param", outerStruct.GetSpannerDbType(), null);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        Assert.True(await reader.ReadAsync());
                        Assert.True(reader.IsDBNull(0));
                        Assert.False(await reader.ReadAsync());
                    }
                }
            }
        }

        [Fact]
        public async Task EmptyStruct()
        {
            var emptyStruct = new SpannerStruct();

            using (var connection = _fixture.GetConnection())
            {
                using (var cmd = connection.CreateSelectCommand("SELECT @struct_param IS NULL"))
                {
                    cmd.Parameters.Add("struct_param", emptyStruct.GetSpannerDbType(), emptyStruct);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        Assert.True(await reader.ReadAsync());
                        Assert.False(reader.GetBoolean(0));
                        Assert.False(await reader.ReadAsync());
                    }
                }
            }
        }

        [Fact]
        public async Task EmptyStruct_NullValue()
        {
            var emptyStruct = new SpannerStruct();

            using (var connection = _fixture.GetConnection())
            {
                using (var cmd = connection.CreateSelectCommand("SELECT @struct_param IS NULL"))
                {
                    cmd.Parameters.Add("struct_param", emptyStruct.GetSpannerDbType(), null);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        Assert.True(await reader.ReadAsync());
                        Assert.True(reader.GetBoolean(0));
                        Assert.False(await reader.ReadAsync());
                    }
                }
            }
        }

        [Fact]
        public async Task NullFieldValue()
        {
            var structValue = new SpannerStruct
            {
                { "f1", SpannerDbType.Int64, null }
            };

            using (var connection = _fixture.GetConnection())
            {
                using (var cmd = connection.CreateSelectCommand("SELECT @struct_param.f1"))
                {
                    cmd.Parameters.Add("struct_param", structValue.GetSpannerDbType(), structValue);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        Assert.True(await reader.ReadAsync());
                        Assert.True(reader.IsDBNull(0));
                        Assert.False(await reader.ReadAsync());
                    }
                }
            }
        }

        [Theory]
        [InlineData("bob", true)]
        [InlineData("jeff", false)]
        public async Task ServerStructEquality(string parameterFieldValue, bool expectedEqualityResult)
        {
            var structValue = new SpannerStruct
            {
                { "threadf", SpannerDbType.Int64, 1 },
                { "userf", SpannerDbType.String, parameterFieldValue }
            };

            using (var connection = _fixture.GetConnection())
            {
                using (var cmd = connection.CreateSelectCommand("SELECT @struct_param = STRUCT < threadf INT64, userf STRING>(1,\"bob\")"))
                {
                    cmd.Parameters.Add("struct_param", structValue.GetSpannerDbType(), structValue);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        Assert.True(await reader.ReadAsync());
                        Assert.Equal(expectedEqualityResult, reader.GetBoolean(0));
                        Assert.False(await reader.ReadAsync());
                    }
                }
            }
        }        

        [Fact]
        public async Task NullnessCheck()
        {
            var structValue = new SpannerStruct
            {
                { "threadf", SpannerDbType.Int64, 1 },
                { "userf", SpannerDbType.String, "bob" }
            };

            using (var connection = _fixture.GetConnection())
            {
                using (var cmd = connection.CreateSelectCommand("SELECT @struct_arr_param IS NULL"))
                {
                    cmd.Parameters.Add(
                        "struct_arr_param",
                        SpannerDbType.ArrayOf(structValue.GetSpannerDbType()),
                        new[] { structValue });

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        Assert.True(await reader.ReadAsync());
                        Assert.False(reader.GetBoolean(0));
                        Assert.False(await reader.ReadAsync());
                    }
                }
            }
        }

        [Fact]
        public async Task NullArrayOfStructField()
        {
            var nestedStruct = new SpannerStruct
            {
                { "threadid", SpannerDbType.Int64, null }
            };
            var structValue = new SpannerStruct
            {
                { "intf", SpannerDbType.Int64, 1 },
                { "arraysf", SpannerDbType.ArrayOf(nestedStruct.GetSpannerDbType()), null }
            };

            using (var connection = _fixture.GetConnection())
            {
                using (var cmd = connection.CreateSelectCommand("SELECT a.threadid FROM UNNEST(@struct_param.arraysf) a"))
                {
                    cmd.Parameters.Add("struct_param", structValue.GetSpannerDbType(), structValue);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        // No rows
                        Assert.False(await reader.ReadAsync());
                    }
                }
            }
        }

        [Fact]
        public async Task NullArrayOfStruct()
        {
            var structValue = new SpannerStruct
            {
                { "threadid", SpannerDbType.Int64, null }
            };

            using (var connection = _fixture.GetConnection())
            {
                using (var cmd = connection.CreateSelectCommand("SELECT a.threadid FROM UNNEST(@struct_arr_param) a"))
                {
                    cmd.Parameters.Add("struct_arr_param", SpannerDbType.ArrayOf(structValue.GetSpannerDbType()), null);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        // No rows
                        Assert.False(await reader.ReadAsync());
                    }
                }
            }
        }

        [SkippableFact]
        public async Task SelectStructFails()
        {
            Skip.If(_fixture.RunningOnEmulator, "Emulator allows structs to be selected");
            var structParam = new SpannerStruct
            {
                { "x", SpannerDbType.Int64, 1 },
                { "y", SpannerDbType.String, "bob" }
            };
            using (var connection = _fixture.GetConnection())
            {
                using (var cmd = connection.CreateSelectCommand("SELECT @p"))
                {
                    cmd.Parameters.Add("p", structParam.GetSpannerDbType(), structParam);
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        await Assert.ThrowsAsync<SpannerException>(async () => await reader.ReadAsync());
                    }
                }
            }
        }

        [SkippableFact]
        public async Task SelectStructArrayFails()
        {
            Skip.If(_fixture.RunningOnEmulator, "Emulator allows struct arrays to be selected");
            var structParam = new SpannerStruct
            {
                { "x", SpannerDbType.Int64, 1 },
                { "y", SpannerDbType.String, "bob" }
            };
            using (var connection = _fixture.GetConnection())
            {
                using (var cmd = connection.CreateSelectCommand("SELECT @p"))
                {
                    cmd.Parameters.Add("p",
                        SpannerDbType.ArrayOf(structParam.GetSpannerDbType()),
                        new[] { structParam });

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        await Assert.ThrowsAsync<SpannerException>(async () => await reader.ReadAsync());
                    }
                }
            }
        }

        [Fact]
        public async Task SelectAmbiguousFieldFails()
        {
            var structParam = new SpannerStruct
            {
                { "x", SpannerDbType.Int64, 1 },
                { "x", SpannerDbType.String, "bob" }
            };
            using (var connection = _fixture.GetConnection())
            {
                using (var cmd = connection.CreateSelectCommand("SELECT @p.x"))
                {
                    cmd.Parameters.Add("p", structParam.GetSpannerDbType(), structParam);
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        await Assert.ThrowsAsync<SpannerException>(async () => await reader.ReadAsync());
                    }
                }
            }
        }
    }
}
