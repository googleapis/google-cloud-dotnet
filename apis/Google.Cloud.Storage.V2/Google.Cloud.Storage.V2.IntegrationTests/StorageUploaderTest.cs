// Copyright 2023 Google LLC
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

using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Storage.V2.IntegrationTests;

[Collection(nameof(StorageFixture))]
public class StorageUploaderTest
{
    private readonly StorageFixture _fixture;

    public StorageUploaderTest(StorageFixture fixture)
    {
        _fixture = fixture;
    }

    [SkippableTheory]
    [InlineData(50)]
    [InlineData(5_000_000)]
    [InlineData(50_000_000)]
    public async Task UploadObjectAsync_RandomData(int size)
    {
        Skip.If(!_fixture.Enabled);

        // Upload using v2
        var bytes = new byte[size];
        RandomNumberGenerator.Create().GetBytes(bytes);
        var obj = _fixture.GenerateObjectName();
        var uploader = new StorageUploader(_fixture.Client);
        await uploader.UploadObjectAsync(_fixture.ReadWriteBucket, obj, new MemoryStream(bytes));

        // Download using v1
        var stream = new MemoryStream();
        await _fixture.V1Client.DownloadObjectAsync(_fixture.ReadWriteBucket.BucketId, obj, stream);
        Assert.Equal(bytes, stream.ToArray());
    }
}
