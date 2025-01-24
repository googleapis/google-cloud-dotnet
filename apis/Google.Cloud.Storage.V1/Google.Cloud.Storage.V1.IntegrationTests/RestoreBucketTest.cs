// Copyright 2024 Google Inc. All Rights Reserved.
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

using System;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Storage.V1.IntegrationTests;

[Collection(nameof(StorageFixture))]
public class RestoreBucketTest
{
    private readonly StorageFixture _fixture;

    public RestoreBucketTest(StorageFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public async Task RestoreSoftDeletedBucket()
    {
        var bucketName = _fixture.GenerateBucketName();
        var softDeleteBucket = _fixture.CreateBucket(bucketName, false, true);
        await _fixture.Client.DeleteBucketAsync(softDeleteBucket.Name, new DeleteBucketOptions { DeleteObjects = true });

        var restored = await _fixture.Client.RestoreBucketAsync(softDeleteBucket.Name, softDeleteBucket.Generation.Value);
        Assert.Equal(softDeleteBucket.Name, restored.Name);
        Assert.Equal(softDeleteBucket.Generation, restored.Generation);
    }
}
