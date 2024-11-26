// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Storage.V1.IntegrationTests;
[Collection(nameof(StorageFixture))]
public class GetBucketTest
{
    private readonly StorageFixture _fixture;

    public GetBucketTest(StorageFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public async Task SoftDeleted()
    {
        var softDeleteBucket  = _fixture.CreateBucket(Guid.NewGuid().ToString() + "-soft-delete", false, true);
        var bucket = await _fixture.Client.GetBucketAsync(softDeleteBucket.Name, new GetBucketOptions { SoftDeleted = false });

        await _fixture.Client.DeleteBucketAsync(softDeleteBucket.Name, new DeleteBucketOptions { DeleteObjects = true });
        var softDeleted = await _fixture.Client.GetBucketAsync(softDeleteBucket.Name, new GetBucketOptions { SoftDeleted = true, Generation = bucket.Generation });
        Assert.NotNull(bucket.Generation);
        Assert.NotNull(softDeleted.Generation);
        Assert.Equal(bucket.Generation, softDeleted.Generation);
    }

    [Fact]
    public async Task GetSoftDeletedBucket()
    {
        var softDeleteBucket = _fixture.CreateBucket(Guid.NewGuid().ToString() + "-soft-delete", false, true);
        var bucket = await _fixture.Client.GetBucketAsync(softDeleteBucket.Name, new GetBucketOptions { SoftDeleted = false });
        await _fixture.Client.DeleteBucketAsync(softDeleteBucket.Name, new DeleteBucketOptions { DeleteObjects = true });

        var softDeleted = await _fixture.Client.GetBucketAsync(softDeleteBucket.Name, new GetBucketOptions { SoftDeleted = true, Generation = bucket.Generation });
        
        Assert.NotNull(bucket.Name);
        Assert.NotNull(softDeleted.Name);
        Assert.Equal(bucket.Name, softDeleted.Name);
        Assert.NotNull(softDeleted.SoftDeleteTimeDateTimeOffset);
        Assert.NotNull(softDeleted.HardDeleteTimeDateTimeOffset);
    }
}
