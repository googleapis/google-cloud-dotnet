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
using static Google.Cloud.Storage.V1.IntegrationTests.TestHelpers;

namespace Google.Cloud.Storage.V1.IntegrationTests;

[Collection(nameof(StorageFixture))]
public class MoveObjectTest
{
    private readonly StorageFixture _fixture;
    private string SmallNewObject { get; } = "smallNew.txt";
    private string LargeNewObject { get; } = "largeNew.txt";
    private string SmallThenLargeObject { get; } = "smallThenLargeNew.txt";

    public MoveObjectTest(StorageFixture fixture)
    {
        _fixture = fixture;
    }

    // Moves an object within a hierarchical namespace enabled bucket.
    [Fact]
    public async Task MoveObjectAsync()
    {
        var actual = await _fixture.Client.GetObjectAsync(_fixture.HnsBucket, _fixture.SmallThenLargeObject);
        _fixture.Client.UploadObject(_fixture.HnsBucket, LargeNewObject, "text/plain", new MemoryStream(_fixture.LargeContent));
        var expected = await _fixture.Client.MoveObjectAsync(_fixture.HnsBucket, _fixture.SmallThenLargeObject, LargeNewObject);
        using var stream = new MemoryStream();
        await _fixture.Client.DownloadObjectAsync(_fixture.HnsBucket, LargeNewObject, stream);
        // Assert that the content of the destination object is the same as the source object.
        Assert.Equal(_fixture.LargeContent, stream.ToArray());
        var objects = _fixture.Client.ListObjects(_fixture.HnsBucket).ToList();
        // Assert that the destination object exists after the move.
        Assert.Contains(objects, obj => obj.Name == expected.Name && obj.Generation == expected.Generation);
        // Assert that the source object does not exist after the move.
        Assert.DoesNotContain(objects, obj => obj.Name == actual.Name && obj.Generation == actual.Generation);
    }

    // Move an object to a folders and subfolders by creating folders and subfolders if necessary.
    [Fact]
    public async Task MoveObjectToDirectorySubDirectoryAsync()
    {
        var actual = await _fixture.Client.GetObjectAsync(_fixture.HnsBucket, _fixture.SmallObject);
        _fixture.Client.UploadObject(_fixture.HnsBucket, SmallNewObject, "text/plain", new MemoryStream(_fixture.SmallContent));
        var expected = await _fixture.Client.MoveObjectAsync(_fixture.HnsBucket, _fixture.SmallObject, $"folder/subfolder/" + SmallNewObject);
        using var stream = new MemoryStream();
        await _fixture.Client.DownloadObjectAsync(_fixture.HnsBucket, $"folder/subfolder/" + SmallNewObject, stream);
        // Assert that the content of the destination object is the same as the source object.
        Assert.Equal(_fixture.SmallContent, stream.ToArray());
        // Assert that the generation of the destination object is different from the source object indicating a new object at destination is created.
        Assert.NotEqual(actual.Generation, expected.Generation);
        var options = new ListObjectsOptions
        {
            MatchGlob = "folder/subfolder/*.txt"
        };
        var objects = _fixture.Client.ListObjects(_fixture.HnsBucket, null, options).ToList();
        // Assert that the destination object exists after the move.
        Assert.Contains(objects, obj => obj.Name == expected.Name && obj.Generation == expected.Generation);
        // Assert that the source object does not exist after the move.
        Assert.DoesNotContain(objects, obj => obj.Name == actual.Name && obj.Generation == actual.Generation);
    }

    // Prevent moving the source object to the destination object using bad preconditions (wrong destination generation) set.
    [Fact]
    public async Task PreventMoveObject_With_Wrong_GenerationAsync()
    {
        var actual = await _fixture.Client.UploadObjectAsync(_fixture.HnsBucket, "file.txt", null, GenerateData(128));
        var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.MoveObject(_fixture.HnsBucket, actual.Name, _fixture.SmallObject,
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
        var actual = await _fixture.Client.UploadObjectAsync(_fixture.HnsBucket, "sourceFile.txt", null, GenerateData(128));
        var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.MoveObject(_fixture.HnsBucket, actual.Name, _fixture.SmallObject,
            new MoveObjectOptions { IfSourceMetagenerationMatch = 0 }));
        Assert.Equal(HttpStatusCode.PreconditionFailed, exception.HttpStatusCode);
        var objects = _fixture.Client.ListObjects(_fixture.HnsBucket).ToList();
        // Assert that the source object is not deleted and destination object is not overwritten.
        Assert.Contains(objects, obj => obj.Name == actual.Name && obj.Generation == actual.Generation);
    }

    // Move the source object to the destination object using correct preconditions (source metageneration and source generation match) set.
    [Fact]
    public async Task MoveObject_With_Correct_PreconditionsAsync()
    {
        var actual = _fixture.Client.UploadObject(_fixture.HnsBucket, "sourceTestFile.txt", null, GenerateData(128));
        _fixture.Client.UploadObject(_fixture.HnsBucket, SmallThenLargeObject, "text/plain",
            new MemoryStream(_fixture.LargeContent));
        var expected = await _fixture.Client.MoveObjectAsync(_fixture.HnsBucket, actual.Name, SmallThenLargeObject,
            new MoveObjectOptions { IfSourceMetagenerationMatch = actual.Metageneration, IfSourceGenerationMatch = actual.Generation });
        var objects = _fixture.Client.ListObjects(_fixture.HnsBucket).ToList();
        // Assert that the destination object exists after the move.
        Assert.Contains(objects, obj => obj.Name == expected.Name && obj.Generation == expected.Generation);
        // Assert that the source object does not exist after the move.
        Assert.DoesNotContain(objects, obj => obj.Name == actual.Name && obj.Generation == actual.Generation);
    }

    [Fact]
    public async Task MetadataReturned()
    {
        var actual = await _fixture.Client.UploadObjectAsync(_fixture.HnsBucket, "sourceMeta.txt", "text/plain", GenerateData(128));
        var destUploadedObject = await _fixture.Client.UploadObjectAsync(_fixture.HnsBucket, "destMeta.txt", "text/plain",
            new MemoryStream(_fixture.LargeContent));
        var expected = _fixture.Client.MoveObject(_fixture.HnsBucket, actual.Name, destUploadedObject.Name);

        // Assert that the generation of the destination object is different from the source object indicating a new object at destination is created.
        Assert.NotEqual(actual.Generation, expected.Generation);
        // Assert that the id of the destination object is different from the source object indicating a new object at destination is created.
        Assert.NotEqual(actual.Id, expected.Id);
        // Just test the values we expect to be updated and not equal after move operation is performed.
        Assert.NotEqual(actual.TimeCreatedRaw, expected.TimeCreatedRaw);
        Assert.NotEqual(actual.TimeFinalizedRaw, expected.TimeFinalizedRaw);
        Assert.NotEqual(actual.UpdatedRaw, expected.UpdatedRaw);
        Assert.NotEqual(actual.TimeStorageClassUpdatedRaw, expected.TimeStorageClassUpdatedRaw);
        // Assert that the storage class of the destination object is set to Standard if Autoclass is enabled otherwise no change in storage class.
        if (_fixture.Client.GetBucket(_fixture.HnsBucket).Autoclass != null)
        {
            if (_fixture.Client.GetBucket(_fixture.HnsBucket).Autoclass.Enabled == true)
            {
                Assert.Equal(StorageClasses.Standard, expected.StorageClass);
            }
        }
        else
        {
            Assert.Equal(expected.StorageClass, actual.StorageClass);
        }
    }

    [Fact]
    public void MoveObjectFromInvalidBucket()
    {
        var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.MoveObject("!!!", _fixture.LargeObject, _fixture.SmallObject));
        Assert.Equal(HttpStatusCode.NotFound, exception.HttpStatusCode);
    }

    [Fact]
    public void MoveObjectWithInvalidSourceObject()
    {
        var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.MoveObject(_fixture.HnsBucket, "!!!", _fixture.SmallObject));
        Assert.Equal(HttpStatusCode.NotFound, exception.HttpStatusCode);
    }

    // The move operation can only be performed for HNS-enabled buckets (can change in the future).
    [Fact]
    public void MoveObjectFromNonHnsBucket()
    {
        var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.MoveObject(_fixture.ReadBucket, _fixture.LargeObject, _fixture.SmallObject));
        Assert.Equal(HttpStatusCode.Conflict, exception.HttpStatusCode);
    }

    // The move operation can only be performed with different source and destination object id.
    [Fact]
    public void MoveObjectWithSameObjectId()
    {
        var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.MoveObject(_fixture.HnsBucket, _fixture.SmallObject, _fixture.SmallObject));
        Assert.Equal(HttpStatusCode.BadRequest, exception.HttpStatusCode);
    }

    // Move operation can be performed on live objects only.
    [Fact]
    public void MoveObjectWithSoftDeletedObject()
    {
        var sourceUploadedObject = _fixture.Client.UploadObject(_fixture.HnsBucket, "sourcelive.txt", "text/plain", GenerateData(128));
        _fixture.Client.DeleteObject(_fixture.HnsBucket, sourceUploadedObject.Name);
        var actual = _fixture.Client.GetObject(_fixture.HnsBucket, sourceUploadedObject.Name, new GetObjectOptions { SoftDeletedOnly = true, Generation = sourceUploadedObject.Generation });
        var destUploadedObject = _fixture.Client.UploadObject(_fixture.HnsBucket, "dest.txt", "text/plain",
            new MemoryStream(_fixture.LargeContent));
        var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.MoveObject(_fixture.HnsBucket, actual.Name, destUploadedObject.Name));
        Assert.Equal(HttpStatusCode.NotFound, exception.HttpStatusCode);
    }
}
