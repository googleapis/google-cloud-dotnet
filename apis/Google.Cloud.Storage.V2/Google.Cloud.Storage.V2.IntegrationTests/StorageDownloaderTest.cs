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
public class StorageDownloaderTest
{
    private readonly StorageFixture _fixture;

    public StorageDownloaderTest(StorageFixture fixture)
    {
        _fixture = fixture;
    }

    [SkippableTheory]
    [InlineData(50)]
    [InlineData(5_000_000)]
    [InlineData(50_000_000)]
    public async Task DownloadObjectAsync_RandomData(int size)
    {
        Skip.If(!_fixture.Enabled);

        // Upload using v1
        var bytes = new byte[size];
        RandomNumberGenerator.Create().GetBytes(bytes);
        var obj = _fixture.GenerateObjectName();
        await _fixture.V1Client.UploadObjectAsync(_fixture.ReadWriteBucket.BucketId, obj, null, new MemoryStream(bytes));

        // Download using v2
        var downloader = new StorageDownloader(_fixture.Client);
        var stream = new MemoryStream();
        await downloader.DownloadObjectAsync(_fixture.ReadWriteBucket, obj, stream);
        Assert.Equal(bytes, stream.ToArray());
    }
}
