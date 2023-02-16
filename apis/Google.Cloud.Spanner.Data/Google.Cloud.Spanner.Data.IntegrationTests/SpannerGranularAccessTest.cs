// Copyright 2022 Google LLC
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

using Google.Cloud.Spanner.Data.CommonTesting;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests;

[Collection(nameof(SpannerReaderRoleFixture))]
[CommonTestDiagnostics]
[Trait(Constants.SupportedOnEmulator, Constants.No)]
public class SpannerGranularAccessTest
{
    private readonly SpannerReaderRoleFixture _fixture;

    public SpannerGranularAccessTest(SpannerReaderRoleFixture fixture) =>
        _fixture = fixture;

    [Fact]
    public async Task ReadWithReaderDbRoleTest()
    {
        // Try to read data from the table using connection with reader role.
        using var readerConnection = _fixture.GetReadOnlyConnection();
        using var cmd = readerConnection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName}");

        using var reader = await cmd.ExecuteReaderAsync();
        await reader.ReadAsync();
        Assert.Equal("key", reader.GetFieldValue<string>("K"));
        Assert.Equal("value", reader.GetFieldValue<string>("StringValue"));
    }

    [Fact]
    public async Task WriteWithReaderDbRoleTest()
    {
        // Try to insert data on table using connection with reader role. This should throw SpannerException.
        using var readerConnection = _fixture.GetReadOnlyConnection();
        using var insertCmd = readerConnection.CreateInsertCommand(_fixture.TableName, new SpannerParameterCollection
        {
            { "K", SpannerDbType.String, "key1" },
            { "StringValue", SpannerDbType.String, "value1" }
        });

        var e = await Assert.ThrowsAsync<SpannerException>(async () => await insertCmd.ExecuteNonQueryAsync());
        Assert.Equal(ErrorCode.PermissionDenied, e.ErrorCode);
        Assert.Contains("does not have required privileges", e.InnerException.Message);
    }
}
