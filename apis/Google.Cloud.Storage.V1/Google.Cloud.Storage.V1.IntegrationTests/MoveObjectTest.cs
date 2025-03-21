// Copyright 2025 Google Inc. All Rights Reserved.
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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Storage.V1.IntegrationTests.TestHelpers;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1.IntegrationTests;

[Collection(nameof(StorageFixture))]
public class MoveObjectTest
{
    private readonly StorageFixture _fixture;

    public MoveObjectTest(StorageFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public async Task MoveObjectAsync()
    {
        await _fixture.Client.MoveObjectAsync(
            _fixture.HnsBucket, _fixture.SmallThenLargeObject,
            _fixture.LargeObject);
        using (var stream = new MemoryStream())
        {
            await _fixture.Client.DownloadObjectAsync(_fixture.HnsBucket, _fixture.LargeObject, stream);
            Assert.Equal(_fixture.LargeContent, stream.ToArray());
        }
    }
}
