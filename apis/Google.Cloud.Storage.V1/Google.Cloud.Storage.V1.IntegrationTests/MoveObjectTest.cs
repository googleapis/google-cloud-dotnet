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

using Google.Apis.Storage.v1.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Storage.V1.IntegrationTests.TestHelpers;

namespace Google.Cloud.Storage.V1.IntegrationTests;

[Collection(nameof(StorageFixture))]
public class MoveObjectTest
{
    private readonly StorageFixture _fixture;
    private string SmallNewObject { get; } = "smallNew.txt";
    private string LargeNewObject { get; } = "largeNew.txt";
    private string SmallThenLargeObject { get; } = "smallThenLargeNew.txt";
    private Bucket HnsBucket { get; }

    public MoveObjectTest(StorageFixture fixture)
    {
        _fixture = fixture;
        HnsBucket = _fixture.CreateAndPopulateHnsBucket(_fixture.HnsBucket);
        _fixture.Client.UploadObject(_fixture.HnsBucket, SmallNewObject, "text/plain", new MemoryStream(_fixture.SmallContent));
        _fixture.Client.UploadObject(_fixture.HnsBucket, LargeNewObject, "text/plain", new MemoryStream(_fixture.LargeContent));
    }

    // Moves the source object to the destination object within a bucket with hierarchical namespace enabled.
    [Fact]
    public async Task MoveObjectDefaultAsync()
    {
        var actual = await _fixture.Client.GetObjectAsync(_fixture.HnsBucket, _fixture.SmallThenLargeObject);
        var expected = await _fixture.Client.MoveObjectAsync(_fixture.HnsBucket, _fixture.SmallThenLargeObject, LargeNewObject);
        using var stream = new MemoryStream();
        await _fixture.Client.DownloadObjectAsync(_fixture.HnsBucket, LargeNewObject, stream);
        Assert.Equal(_fixture.LargeContent, stream.ToArray());
        // Assert that the generation of the destination object is different from the source object indicating a new object at destination is created.
        Assert.NotEqual(actual.Generation, expected.Generation);
        // Assert that the id of the destination object is different from the source object indicating a new object at destination is created.
        Assert.NotEqual(actual.Id, expected.Id);
        Assert.NotEqual(actual.TimeCreatedRaw, expected.TimeCreatedRaw);
        Assert.NotEqual(actual.TimeFinalizedRaw, expected.TimeFinalizedRaw);
        Assert.NotEqual(actual.UpdatedRaw, expected.UpdatedRaw);
        Assert.NotEqual(actual.TimeStorageClassUpdatedRaw, expected.TimeStorageClassUpdatedRaw);
        if (HnsBucket.Autoclass != null)
        {
            if (expected != null)
            {
                Assert.Equal(expected.StorageClass, actual.StorageClass);
                Assert.Equal(expected.StorageClass, StorageClasses.Standard);
            }
        }
        else
        {
            Assert.Equal(expected.StorageClass, actual.StorageClass);
        }

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
        var expected = await _fixture.Client.MoveObjectAsync(_fixture.HnsBucket, _fixture.SmallObject, $"folder/subfolder/" + SmallNewObject);
        using var stream = new MemoryStream();
        await _fixture.Client.DownloadObjectAsync(_fixture.HnsBucket, $"folder/subfolder/" + SmallNewObject, stream);
        Assert.Equal(_fixture.SmallContent, stream.ToArray());
        // Assert that the generation of the destination object is different from the source object indicating a new object at destination is created.
        Assert.NotEqual(actual.Generation, expected.Generation);
        var objects = _fixture.Client.ListObjects(_fixture.HnsBucket).ToList();
        // Assert that the destination object exists after the move.
        Assert.Contains(objects, obj => obj.Name == expected.Name && obj.Generation == expected.Generation);
        // Assert that the source object does not exist after the move.
        Assert.DoesNotContain(objects, obj => obj.Name == actual.Name && obj.Generation == actual.Generation);
    }

    // Prevent moving the source object to the destination object using bad preconditions (wrong source generation) set.
    [Fact]
    public async Task PreventMoveObject_With_Wrong_GenerationAsync()
    {
        var bucketUploadedObject = _fixture.Client.UploadObject(_fixture.HnsBucket, "file.txt", null, GenerateData(128));
        var actual = await _fixture.Client.GetObjectAsync(_fixture.HnsBucket, bucketUploadedObject.Name);
        var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.MoveObject(_fixture.HnsBucket, bucketUploadedObject.Name, _fixture.SmallObject,
            new MoveObjectOptions { IfGenerationMatch = 0 }));
        Assert.Equal(HttpStatusCode.PreconditionFailed, exception.HttpStatusCode);
        var objects = _fixture.Client.ListObjects(_fixture.HnsBucket).ToList();
        // Assert that the source object is not deleted and destination object is not overwritten.
        Assert.Contains(objects, obj => obj.Name == actual.Name && obj.Generation == actual.Generation);
    }

    // Prevent moving the source object to the destination object using bad preconditions (wrong source metageneration) set.
    [Fact]
    public async Task PreventMoveObject_With_Wrong_SourceMetaGenerationAsync()
    {
        var bucketUploadedObject = _fixture.Client.UploadObject(_fixture.HnsBucket, "sourceFile.txt", null, GenerateData(128));
        var actual = await _fixture.Client.GetObjectAsync(_fixture.HnsBucket, bucketUploadedObject.Name);
        var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.MoveObject(_fixture.HnsBucket, bucketUploadedObject.Name, _fixture.SmallObject,
            new MoveObjectOptions { IfSourceMetagenerationMatch = 0 }));
        Assert.Equal(HttpStatusCode.PreconditionFailed, exception.HttpStatusCode);
        var objects = _fixture.Client.ListObjects(_fixture.HnsBucket).ToList();
        // Assert that the source object is not deleted and destination object is not overwritten.
        Assert.Contains(objects, obj => obj.Name == actual.Name && obj.Generation == actual.Generation);
    }

    // Move the source object to the destination object using correct preconditions (source metageneration and generation match) set.
    [Fact]
    public async Task MoveObject_With_Correct_PreconditionsAsync()
    {
        var bucketUploadedObject = _fixture.Client.UploadObject(_fixture.HnsBucket, "sourceTestFile.txt", null, GenerateData(128));
        var actual = await _fixture.Client.GetObjectAsync(_fixture.HnsBucket, bucketUploadedObject.Name);
        var expected = _fixture.Client.MoveObject(_fixture.HnsBucket, bucketUploadedObject.Name, SmallThenLargeObject,
            new MoveObjectOptions { IfSourceMetagenerationMatch = actual.Metageneration, IfSourceGenerationMatch = actual.Generation });
        var objects = _fixture.Client.ListObjects(_fixture.HnsBucket).ToList();
        // Assert that the destination object exists after the move.
        Assert.Contains(objects, obj => obj.Name == expected.Name && obj.Generation == expected.Generation);
        // Assert that the source object does not exist after the move.
        Assert.DoesNotContain(objects, obj => obj.Name == actual.Name && obj.Generation == actual.Generation);
    }
}
