// Copyright 2015 Google Inc. All Rights Reserved.
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

using System.Collections.Generic;
using System.Linq;
using System.Net;
using Xunit;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    using static TestHelpers;

    [Collection(nameof(StorageFixture))]
    public class DeleteObjectTest
    {
        private readonly StorageFixture _fixture;

        public DeleteObjectTest(StorageFixture fixture)
        {
            _fixture = fixture;
        }
        
        [Fact]
        public void ImplicitLatestVersion_SingleVersionBucket()
        {
            var bucket = _fixture.SingleVersionBucket;
            var name = CreateObjects(bucket, 1)[0].Name;
            _fixture.Client.DeleteObject(bucket, name);
            Assert.Empty(ListObjects(bucket, name, true));
        }

        [Fact]
        public void ImplicitLatestVersion_MultiVersionBucket()
        {
            var bucket = _fixture.MultiVersionBucket;
            var name = CreateObjects(bucket, 1)[0].Name;
            _fixture.Client.DeleteObject(bucket, name);
            // Without asking for versions, we don't get anything
            Assert.Empty(ListObjects(bucket, name, false));
            // If we ask for versions, we get the deleted object
            var allVersions = ListObjects(bucket, name, true);
            Assert.Equal(1, allVersions.Count);
            Assert.NotNull(allVersions[0].TimeDeleted);
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void SingleVersionObject_DeleteExplicitVersion(bool multiVersionBucket)
        {
            string bucket = multiVersionBucket ? _fixture.MultiVersionBucket : _fixture.SingleVersionBucket;
            var obj = CreateObjects(bucket, 1)[0];
            _fixture.Client.DeleteObject(obj, new DeleteObjectOptions { Generation = obj.Generation });
            Assert.Empty(ListObjects(obj, true));
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void NonExistentObject(bool multiVersionBucket)
        {
            string bucket = multiVersionBucket ? _fixture.MultiVersionBucket : _fixture.SingleVersionBucket;
            var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.DeleteObject(bucket, GenerateName()));
            Assert.Equal(HttpStatusCode.NotFound, exception.HttpStatusCode);
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void WrongGeneration(bool multiVersionBucket)
        {
            string bucket = multiVersionBucket ? _fixture.MultiVersionBucket : _fixture.SingleVersionBucket;
            var obj = CreateObjects(bucket, 1)[0];
            var options = new DeleteObjectOptions { Generation = obj.Generation.Value + 1 };
            var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.DeleteObject(obj, options));
            Assert.Equal(HttpStatusCode.NotFound, exception.HttpStatusCode);
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void DeleteSameGenerationTwice(bool multiVersionBucket)
        {
            string bucket = multiVersionBucket ? _fixture.MultiVersionBucket : _fixture.SingleVersionBucket;
            var obj = CreateObjects(bucket, 1)[0];
            var options = new DeleteObjectOptions { Generation = obj.Generation.Value };
            // First time is fine
            _fixture.Client.DeleteObject(obj, options);
            // Second time throws an exception
            var exception = Assert.Throws<GoogleApiException>(() => _fixture.Client.DeleteObject(obj, options));
            Assert.Equal(HttpStatusCode.NotFound, exception.HttpStatusCode);
        }

        [Fact]
        public void DeleteImplicitlyThenExplicitly()
        {
            var bucket = _fixture.MultiVersionBucket;
            var obj = CreateObjects(bucket, 1)[0];
            _fixture.Client.DeleteObject(obj);
            _fixture.Client.DeleteObject(obj, new DeleteObjectOptions { Generation = obj.Generation.Value });
            Assert.Empty(ListObjects(obj, true));
        }

        [Fact]
        public void MultipleVersionsCreated_SingleVersionBucket()
        {
            var bucket = _fixture.SingleVersionBucket;
            var obj = CreateObjects(bucket, 3)[0];
            _fixture.Client.DeleteObject(obj);
            Assert.Empty(ListObjects(obj, true));
        }

        [Fact]
        public void MultipleVersionsCreated_MultiVersionBucket()
        {
            var bucket = _fixture.MultiVersionBucket;
            var objects = CreateObjects(bucket, 3);
            for (int i = 0; i < 3; i++)
            {
                var options = new DeleteObjectOptions { Generation = objects[i].Generation };
                _fixture.Client.DeleteObject(objects[0], options);
                Assert.Equal(2 - i, ListObjects(objects[0], true).Count);
            }
        }

        private List<Object> ListObjects(Object obj, bool versions) =>
            ListObjects(obj.Bucket, obj.Name, versions);

        private List<Object> ListObjects(string bucket, string name, bool versions) =>
            // Use the same prefix as the name - filtering to be certain later.
            _fixture.Client.ListObjects(bucket, name, new ListObjectsOptions { Versions = versions })                
                .Where(o => o.Name == name)
                .ToList();

        private List<Object> CreateObjects(string bucket, int versionCount)
        {
            string name = GenerateName();
            var objects = new List<Object>();
            for (int i = 0; i < versionCount; i++)
            {
                objects.Add(_fixture.Client.UploadObject(bucket, name, "", GenerateData(i * 10)));
            }
            return objects;
        }
    }
}
