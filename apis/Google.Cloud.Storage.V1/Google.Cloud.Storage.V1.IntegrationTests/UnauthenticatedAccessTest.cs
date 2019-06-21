// Copyright 2017 Google Inc. All Rights Reserved.
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
using Xunit;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    [Collection(nameof(StorageFixture))]
    public class UnauthenticatedAccessTest
    {
        // See https://cloud.google.com/storage/docs/public-datasets/landsat
        // We pick one particular prefix/directory and a small file to test.
        private const string LandsatBucket = "gcp-public-data-landsat";
        private const string LandsatObject = "LC08/PRE/044/034/LC80440342016259LGN00/LC80440342016259LGN00_MTL.txt";

        private readonly StorageFixture _fixture;

        public UnauthenticatedAccessTest(StorageFixture fixture) => _fixture = fixture;

        [SkippableFact]
        public void DownloadPublicData()
        {
            TestEnvironment.SkipIfVpcSc();
            var client = StorageClient.CreateUnauthenticated();
            MemoryStream stream = new MemoryStream();
            client.DownloadObject(LandsatBucket, LandsatObject, stream);
            Assert.Equal(7903, stream.Length);
        }

        [SkippableFact]
        public void ListPublicData()
        {
            TestEnvironment.SkipIfVpcSc();
            var client = StorageClient.CreateUnauthenticated();
            var objects = client.ListObjects(StorageFixture.CrossLanguageTestBucket).ToList();
            Assert.Equal(3, objects.Count);
        }

        [Fact]
        public void DownloadInRegularBucket_Fails()
        {
            var client = StorageClient.CreateUnauthenticated();
            Assert.Throws<GoogleApiException>(() => client.DownloadObject(
                _fixture.ReadBucket, _fixture.SmallObject, new MemoryStream()));
        }

        [Fact]
        public void UploadInRegularBucket_Fails()
        {
            var client = StorageClient.CreateUnauthenticated();
            Assert.Throws<GoogleApiException>(() => client.UploadObject(
                _fixture.SingleVersionBucket, "foo.txt", "application/text", new MemoryStream(new byte[10])));
        }
    }
}
