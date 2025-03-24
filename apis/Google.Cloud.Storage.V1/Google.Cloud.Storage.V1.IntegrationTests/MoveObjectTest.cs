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

using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Storage.V1.IntegrationTests;

[Collection(nameof(StorageFixture))]
public class MoveObjectTest
{
    private readonly StorageFixture _fixture;

    public MoveObjectTest(StorageFixture fixture)
    {
        _fixture = fixture;
    }

    // Moves the source object to the destination object within a bucket with hierarchical namespace enabled.
    [Fact]
    public async Task MoveObjectAsync()
    {
        var actual = await _fixture.Client.GetObjectAsync(_fixture.HnsBucket, _fixture.SmallThenLargeObject);
        await _fixture.Client.MoveObjectAsync(
            _fixture.HnsBucket, _fixture.SmallThenLargeObject,
            _fixture.LargeObject);
        using var stream = new MemoryStream();
        var expected = await _fixture.Client.DownloadObjectAsync(_fixture.HnsBucket, _fixture.LargeObject, stream);
        Assert.Equal(_fixture.LargeContent, stream.ToArray());
        // Assert that the generation of the destination object is different from the source object indicating a new object at destination is created.
        Assert.NotEqual(actual.Generation, expected.Generation);
        var objects = _fixture.Client.ListObjects(_fixture.HnsBucket).ToList();
        // Assert that the destination object exists after the move.
        Assert.Contains(objects, obj => obj.Name == expected.Name && obj.Generation == expected.Generation);
        // Assert that the source object does not exist after the move.
        Assert.DoesNotContain(objects, obj => obj.Name == actual.Name && obj.Generation == actual.Generation);
    }

    // Move the object to a folders and subfolders by creating folders and subfolders if necessary.
    [Fact]
    public async Task MoveObjectToDirectorySubDirectoryAsync()
    {
        var actual = await _fixture.Client.GetObjectAsync(_fixture.HnsBucket, _fixture.SmallObject);
        await _fixture.Client.MoveObjectAsync(
            _fixture.HnsBucket, _fixture.SmallObject,
            $"folder/subfolder/" + _fixture.SmallThenLargeObject);
        using var stream = new MemoryStream();
        var expected = await _fixture.Client.DownloadObjectAsync(_fixture.HnsBucket, $"folder/subfolder/" + _fixture.SmallThenLargeObject, stream);
        Assert.Equal(_fixture.SmallContent, stream.ToArray());
        // Assert that the generation of the destination object is different from the source object indicating a new object at destination is created.
        Assert.NotEqual(actual.Generation, expected.Generation);
        var objects = _fixture.Client.ListObjects(_fixture.HnsBucket).ToList();
        // Assert that the destination object exists after the move.
        Assert.Contains(objects, obj => obj.Name == expected.Name && obj.Generation == expected.Generation);
        // Assert that the source object does not exist after the move.
        Assert.DoesNotContain(objects, obj => obj.Name == actual.Name && obj.Generation == actual.Generation);
    }

    // Prevent overwriting of an existing destination object using preconditions.
    [Fact]
    public async Task PreventMoveObjectWithPreconditionsAsync()
    {
        var actual = await _fixture.Client.GetObjectAsync(_fixture.HnsBucket, _fixture.SmallThenLargeObject);
        var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.MoveObject(
            _fixture.HnsBucket, _fixture.SmallThenLargeObject, "small_then_large.txt",
            new MoveObjectOptions { IfGenerationMatch = 0 }));
        Assert.Equal(HttpStatusCode.BadRequest, exception.HttpStatusCode);
        var objects = _fixture.Client.ListObjects(_fixture.HnsBucket).ToList();
        // Assert that the source object is not deleted and destination object is not overwritten.
        Assert.Contains(objects, obj => obj.Name == actual.Name && obj.Generation == actual.Generation);
    }
}
