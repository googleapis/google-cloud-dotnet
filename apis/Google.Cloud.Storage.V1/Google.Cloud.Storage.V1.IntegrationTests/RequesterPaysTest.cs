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
using System;
using System.IO;
using System.Linq;
using System.Net;
using Xunit;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    // TODO: Make this indicate that tests are skipped when the environment variables aren't set.
    // It's doable with Xunit, but a bit fiddly. See
    // https://github.com/xunit/samples.xunit/tree/master/DynamicSkipExample

    [Collection(nameof(StorageFixture))]
    public class RequesterPaysTest
    {
        private readonly StorageFixture _fixture;
        private readonly bool _skip;

        public RequesterPaysTest(StorageFixture fixture)
        {
            _fixture = fixture;
            _skip = _fixture.RequesterPaysBucket == null;
        }

        [Fact]
        public void DownloadObject_WithoutOption()
        {
            if (_skip)
            {
                return;
            }

            var exception = Assert.Throws<GoogleApiException>(
                () => _fixture.Client.DownloadObject(_fixture.RequesterPaysBucket, _fixture.SmallObject, new MemoryStream()));
            Assert.Equal(HttpStatusCode.BadRequest, exception.HttpStatusCode);
        }

        [Fact]
        public void DownloadObject_WithOption()
        {
            if (_skip)
            {
                return;
            }

            var destination = new MemoryStream();
            _fixture.Client.DownloadObject(_fixture.RequesterPaysBucket, _fixture.SmallObject, destination,
                new DownloadObjectOptions { UserProject = _fixture.ProjectId });
        }

        [Fact]
        public void ListObjects_WithoutOption()
        {
            if (_skip)
            {
                return;
            }

            var exception = Assert.Throws<GoogleApiException>(
                () => _fixture.Client.ListObjects(_fixture.RequesterPaysBucket).ToList());
            Assert.Equal(HttpStatusCode.BadRequest, exception.HttpStatusCode);
        }

        [Fact]
        public void ListObjects_WithOption()
        {
            if (_skip)
            {
                return;
            }

            var objects = _fixture.Client
                .ListObjects(_fixture.RequesterPaysBucket, options: new ListObjectsOptions { UserProject = _fixture.ProjectId })
                .ToList();
            Assert.Contains(_fixture.SmallObject, objects.Select(o => o.Name));
        }

        [Fact]
        public void UploadObject_WithoutOption()
        {
            if (_skip)
            {
                return;
            }

            var exception = Assert.Throws<GoogleApiException>(
                () => _fixture.Client.UploadObject(_fixture.RequesterPaysBucket, "other-upload.txt", "text/plain", new MemoryStream(_fixture.SmallContent)));
            Assert.Equal(HttpStatusCode.BadRequest, exception.HttpStatusCode);
        }

        [Fact]
        public void UploadObject_WithOption()
        {
            if (_skip)
            {
                return;
            }

            _fixture.Client.UploadObject(_fixture.RequesterPaysBucket, "other-upload.txt", "text/plain",
                new MemoryStream(_fixture.SmallContent), new UploadObjectOptions { UserProject = _fixture.ProjectId });            
        }
    }
}
