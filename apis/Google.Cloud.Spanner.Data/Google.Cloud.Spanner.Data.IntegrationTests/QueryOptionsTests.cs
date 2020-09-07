// Copyright 2020 Google Inc. All Rights Reserved.
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

using Google.Apis.Auth.OAuth2;
using Google.Cloud.Spanner.Data.CommonTesting;
using Google.Cloud.Spanner.V1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(ReadTableFixture))]
    [CommonTestDiagnostics]
    public class QueryOptionsTests
    {
        private readonly ReadTableFixture _fixture;

        public QueryOptionsTests(ReadTableFixture fixture) =>
            _fixture = fixture;

        [Fact]
        public async Task PointReadWithConnectionLevelQueryOptions()
        {
            using (var connection = _fixture.GetConnection())
            {
                connection.QueryOptions = QueryOptions.Empty
                    .WithOptimizerVersion("1")
                    .WithOptimizerStatisticsPackage("auto_20191128_14_47_22UTC");
                var cmd = connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName} WHERE Key = 'k1'");
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    Assert.True(await reader.ReadAsync());
                    Assert.Equal("k1", reader.GetString(0));
                    Assert.Equal("v1", reader.GetString(1));

                    Assert.False(await reader.ReadAsync());
                }
            }
        }

        [Fact]
        public async Task PointReadWithQueryLevelOptions()
        {
            using (var connection = _fixture.GetConnection())
            {
                var cmd = connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName} WHERE Key = 'k1'");
                cmd.QueryOptions = QueryOptions.Empty
                    .WithOptimizerVersion("1")
                    .WithOptimizerStatisticsPackage("auto_20191128_14_47_22UTC");
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    Assert.True(await reader.ReadAsync());
                    Assert.Equal("k1", reader.GetString(0));
                    Assert.Equal("v1", reader.GetString(1));

                    Assert.False(await reader.ReadAsync());
                }
            }
        }

        [SkippableFact]
        public async Task PointReadWithInvalidConnectionLevelQueryOptions()
        {
            Skip.If(_fixture.RunningOnEmulator, "Emulator doesn't fail with invalid optimizer versions");
            using (var connection = _fixture.GetConnection())
            {
                connection.QueryOptions = QueryOptions.Empty.WithOptimizerVersion("invalid");
                var cmd = connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName} WHERE Key = 'k1'");
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    var e = await Assert.ThrowsAsync<SpannerException>(() => reader.ReadAsync());
                    Assert.Equal(ErrorCode.InvalidArgument, e.ErrorCode);
                    Assert.False(e.IsTransientSpannerFault());
                }
            }
        }
    }
}
