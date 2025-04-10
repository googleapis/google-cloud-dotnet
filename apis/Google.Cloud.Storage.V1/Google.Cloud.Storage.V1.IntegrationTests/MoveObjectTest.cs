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
    private readonly string _bucket;
    private readonly string _name1;
    private readonly string _name2;
    private readonly string _contentType1;
    private readonly string _contentType2;
    private readonly MemoryStream _source1;
    private readonly MemoryStream _source2;

    public MoveObjectTest(StorageFixture fixture)
    {
        _fixture = fixture;
        _bucket = _fixture.HnsBucket;
        _originName = IdGenerator.FromGuid();
        _destinationName = IdGenerator.FromGuid();
        _contentType = "application/octet-stream";
        _data = GenerateData(100);
    }

    // Moves an object within a hierarchical namespace enabled bucket.
    [Fact]
    public async Task MoveObjectAsync()
    {
        await _fixture.Client.UploadObjectAsync(_bucket, _originName, _contentType, _data);
        
        await _fixture.Client.MoveObjectAsync(_bucket, _originName, _destinationName);
        
        var objects = _fixture.Client.ListObjects(_bucket);        
        Assert.DoesNotContain(objects, obj => obj.Name == _originName);
        Assert.Contains(objects, obj => obj.Name == _destinationName);
        
        using var stream = new MemoryStream();
        await _fixture.Client.DownloadObjectAsync(_bucket, _destinationName, stream);
        Assert.Equal(_data.ToArray(), stream.ToArray());
    }

    // Move an object to a folders and subfolders by creating folders and subfolders if necessary.
    [Fact]
    public async Task MoveObjectToDirectorySubDirectoryAsync()
    {
        var actual = await _fixture.Client.UploadObjectAsync(_bucket, _name1, _contentType1, _source1);
        _fixture.Client.UploadObject(_bucket, _name2, _contentType2, _source2);
        var expected = await _fixture.Client.MoveObjectAsync(_bucket, _name1, $"folder/subfolder/" + _name2);
        using var stream = new MemoryStream();
        await _fixture.Client.DownloadObjectAsync(_bucket, $"folder/subfolder/" + _name2, stream);
        // Assert that the content of the destination object is the same as the source object.
        Assert.Equal(_source1.ToArray(), stream.ToArray());
        // Assert that the generation of the destination object is different from the source object indicating a new object at destination is created.
        Assert.NotEqual(actual.Generation, expected.Generation);
        var options = new ListObjectsOptions
        {
            MatchGlob = "folder/subfolder/*"
        };
        var objects = _fixture.Client.ListObjects(_bucket, null, options).ToList();
        // Assert that the destination object exists after the move.
        Assert.Contains(objects, obj => obj.Name == expected.Name && obj.Generation == expected.Generation);
        // Assert that the source object does not exist after the move.
        Assert.DoesNotContain(objects, obj => obj.Name == actual.Name && obj.Generation == actual.Generation);
    }

    [Fact]
    public async Task MoveObjectAsync_GenerationMissmatch_Fails()
    {
        await _fixture.Client.UploadObjectAsync(_bucket, _originName, _contentType, _data);

        var exception = await Assert.ThrowsAsync<GoogleApiException>(() => _fixture.Client.MoveObjectAsync(
            _bucket, _originName, _destinationName,
            new MoveObjectOptions { IfGenerationMatch = 0 }));            
        Assert.Equal(HttpStatusCode.PreconditionFailed, exception.HttpStatusCode);
    }

    [Fact]
    public async Task MoveObjectAsync_MetaGenerationMissmatch_Fails()
    {
        await _fixture.Client.UploadObjectAsync(_bucket, _originName, _contentType, _data);
        
        var exception = await Assert.ThrowsAsync<GoogleApiException>(() => _fixture.Client.MoveObjectAsync(
            _bucket, _originName, _destinationName,
            new MoveObjectOptions { IfSourceMetagenerationMatch = 0 }));
        Assert.Equal(HttpStatusCode.PreconditionFailed, exception.HttpStatusCode);
    }

    [Fact]
    public async Task MoveObjectAsync_PreconditionsMatch()
    {
        var origin = await _fixture.Client.UploadObjectAsync(_bucket, _originName, _contentType, _data);

        await _fixture.Client.MoveObjectAsync(
            _bucket, _originName, _destinationName,
            new MoveObjectOptions
            {
                IfSourceMetagenerationMatch = origin.Metageneration,
                IfSourceGenerationMatch = origin.Generation
            });
        var objects = _fixture.Client.ListObjects(_bucket);

        Assert.Contains(objects, obj => obj.Name == expected.Name);
    }

    [Fact]
    public async Task MetadataReturned()
    {
        var actual = await _fixture.Client.UploadObjectAsync(_bucket, _name1, _contentType1, _source1);
        var uploadedObject = await _fixture.Client.UploadObjectAsync(_bucket, _name2, _contentType2, _source2);
        var expected = _fixture.Client.MoveObject(_bucket, actual.Name, uploadedObject.Name);

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
        if (_fixture.Client.GetBucket(_bucket).Autoclass != null)
        {
            if (_fixture.Client.GetBucket(_bucket).Autoclass.Enabled == true)
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
        _fixture.Client.UploadObject(_bucket, _name1, _contentType1, _source1);
        _fixture.Client.UploadObject(_bucket, _name2, _contentType2, _source2);
        var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.MoveObject("!!!", _name1, _name2));
        Assert.Equal(HttpStatusCode.NotFound, exception.HttpStatusCode);
    }

    [Fact]
    public void MoveObjectWithInvalidSourceObject()
    {
        _fixture.Client.UploadObject(_bucket, _name1, _contentType1, _source1);
        var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.MoveObject(_bucket, "!!!", _name1));
        Assert.Equal(HttpStatusCode.NotFound, exception.HttpStatusCode);
    }

    // The move operation can only be performed for HNS-enabled buckets (can change in the future).
    [Fact]
    public void MoveObjectFromNonHnsBucket()
    {
        _fixture.Client.UploadObject(_bucket, _name1, _contentType1, _source1);
        _fixture.Client.UploadObject(_bucket, _name2, _contentType2, _source2);
        var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.MoveObject(_fixture.ReadBucket, _name1, _name2));
        Assert.Equal(HttpStatusCode.Conflict, exception.HttpStatusCode);
    }

    // The move operation can only be performed with different source and destination object id.
    [Fact]
    public void MoveObjectWithSameObjectId()
    {
        _fixture.Client.UploadObject(_bucket, _name1, _contentType1, _source1);
        var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.MoveObject(_bucket, _name1, _name1));
        Assert.Equal(HttpStatusCode.BadRequest, exception.HttpStatusCode);
    }

    // Move operation can be performed on live objects only.
    [Fact]
    public void MoveObjectWithSoftDeletedObject()
    {
        var sourceUploadedObject = _fixture.Client.UploadObject(_bucket, _name1, _contentType1, _source1);
        _fixture.Client.DeleteObject(_bucket, sourceUploadedObject.Name);
        var actual = _fixture.Client.GetObject(_bucket, sourceUploadedObject.Name, new GetObjectOptions { SoftDeletedOnly = true, Generation = sourceUploadedObject.Generation });
        var destinationUploadedObject = _fixture.Client.UploadObject(_bucket, _name2, _contentType2, _source2);
        var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.MoveObject(_bucket, actual.Name, destinationUploadedObject.Name));
        Assert.Equal(HttpStatusCode.NotFound, exception.HttpStatusCode);
    }
}
