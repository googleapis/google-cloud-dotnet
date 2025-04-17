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
    private readonly string _originName;
    private readonly string _destinationName;
    private readonly string _contentType;
    private readonly MemoryStream _data;

    public MoveObjectTest(StorageFixture fixture)
    {
        _fixture = fixture;
        _bucket = _fixture.HnsBucket;
        _originName = IdGenerator.FromGuid();
        _destinationName = IdGenerator.FromGuid();
        _contentType = "application/octet-stream";
        _data = GenerateData(100);
    }

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

    [Fact]
    public async Task MoveObjectAsync_GenerationMismatch_Fails()
    {
        await _fixture.Client.UploadObjectAsync(_bucket, _originName, _contentType, _data);

        var exception = await Assert.ThrowsAsync<GoogleApiException>(() => _fixture.Client.MoveObjectAsync(
            _bucket, _originName, _destinationName,
            new MoveObjectOptions { IfSourceGenerationMatch = 1 }));
        Assert.Equal(HttpStatusCode.PreconditionFailed, exception.HttpStatusCode);
    }

    [Fact]
    public async Task MoveObjectAsync_MetaGenerationMismatch_Fails()
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

        Assert.Contains(objects, obj => obj.Name == _destinationName);
    }
}
