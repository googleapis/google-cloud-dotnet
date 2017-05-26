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

using Google.Apis.Services;
using Google.Apis.Upload;
using System;
using System.IO;
using Xunit;
using static Google.Apis.Storage.v1.ObjectsResource;
using static Google.Apis.Storage.v1.ObjectsResource.InsertMediaUpload;
using Google.Apis;
using Google.Apis.Http;
using Google.Apis.Requests;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1.Tests
{
    public class UploadObjectOptionsTest
    {
        [Theory]
        [InlineData(UploadObjectOptions.MinimumChunkSize)]
        [InlineData(UploadObjectOptions.MinimumChunkSize * 2)]
        [InlineData(UploadObjectOptions.MinimumChunkSize * 1000)]
        public void ValidChunkSize(int chunkSize)
        {
            // ToString call used as a constructor call isn't a statement expression
            new UploadObjectOptions { ChunkSize = chunkSize }.ToString();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-UploadObjectOptions.MinimumChunkSize)]
        [InlineData(UploadObjectOptions.MinimumChunkSize / 2)]
        public void InvalidChunkSize(int chunkSize)
        {
            // ToString call used as a constructor call isn't a statement expression
            Assert.Throws<ArgumentException>(() => new UploadObjectOptions { ChunkSize = chunkSize }.ToString());
        }

        [Fact]
        public void ModifyMediaUpload_DefaultOptions()
        {
            var upload = new InsertMediaUpload(new DummyService(), null, "bucket", new MemoryStream(), null);
            var options = new UploadObjectOptions();
            options.ModifyMediaUpload(upload);
            Assert.Equal(ResumableUpload<InsertMediaUpload>.DefaultChunkSize, upload.ChunkSize);
            Assert.Null(upload.IfGenerationMatch);
            Assert.Null(upload.IfGenerationNotMatch);
            Assert.Null(upload.IfMetagenerationMatch);
            Assert.Null(upload.IfMetagenerationNotMatch);
            Assert.Null(upload.PredefinedAcl);
            Assert.Null(upload.Projection);
            Assert.Null(upload.UserProject);
        }

        [Fact]
        public void ModifyMediaUpload_AllOptions_PositiveMatch()
        {
            var upload = new InsertMediaUpload(new DummyService(), null, "bucket", new MemoryStream(), null);
            var options = new UploadObjectOptions
            {
                ChunkSize = UploadObjectOptions.MinimumChunkSize * 3,
                IfGenerationMatch = 1L,
                IfMetagenerationMatch = 2L,
                PredefinedAcl = PredefinedObjectAcl.BucketOwnerRead,
                Projection = Projection.Full,
                UserProject = "proj"
            };
            options.ModifyMediaUpload(upload);
            Assert.Equal(1L, upload.IfGenerationMatch);
            Assert.Null(upload.IfGenerationNotMatch);
            Assert.Equal(2L, upload.IfMetagenerationMatch);
            Assert.Null(upload.IfMetagenerationNotMatch);
            Assert.Equal(PredefinedAclEnum.BucketOwnerRead, upload.PredefinedAcl);
            Assert.Equal(ProjectionEnum.Full, upload.Projection);
            Assert.Equal("proj", upload.UserProject);
        }

        [Fact]
        public void ModifyMediaUpload_AllOptions_NegativeMatch()
        {
            var upload = new InsertMediaUpload(new DummyService(), null, "bucket", new MemoryStream(), null);
            var options = new UploadObjectOptions
            {
                ChunkSize = UploadObjectOptions.MinimumChunkSize * 3,
                IfGenerationNotMatch = 1L,
                IfMetagenerationNotMatch = 2L,
                PredefinedAcl = PredefinedObjectAcl.BucketOwnerRead,
                Projection = Projection.Full
            };
            options.ModifyMediaUpload(upload);
            Assert.Null(upload.IfGenerationMatch);
            Assert.Equal(1L, upload.IfGenerationNotMatch);
            Assert.Null(upload.IfMetagenerationMatch);
            Assert.Equal(2L, upload.IfMetagenerationNotMatch);
            Assert.Equal(PredefinedAclEnum.BucketOwnerRead, upload.PredefinedAcl);
            Assert.Equal(ProjectionEnum.Full, upload.Projection);
        }

        [Fact]
        public void ModifyMediaUpload_MatchNotMatchConflicts()
        {
            var upload = new InsertMediaUpload(new DummyService(), null, "bucket", new MemoryStream(), null);
            Assert.Throws<ArgumentException>(() =>
            {
                var options = new UploadObjectOptions { IfGenerationMatch = 1L, IfGenerationNotMatch = 2L };
                options.ModifyMediaUpload(upload);
            });
            Assert.Throws<ArgumentException>(() =>
            {
                var options = new UploadObjectOptions { IfMetagenerationMatch = 1L, IfMetagenerationNotMatch = 2L };
                options.ModifyMediaUpload(upload);
            });
        }

        // Just a no-op implementation allowing us to pass a non-null reference into the upload constructor.
        private class DummyService : IClientService
        {
            public string ApiKey => "";
            public string ApplicationName => "";
            public string BasePath => "";
            public string BaseUri => "";
            public IList<string> Features { get; } = new List<string>();
            public bool GZipEnabled => false;
            public ConfigurableHttpClient HttpClient => null;
            public IConfigurableHttpClientInitializer HttpClientInitializer => null;
            public string Name => "";
            public ISerializer Serializer => null;
            public Task<RequestError> DeserializeError(HttpResponseMessage response) => Task.FromResult(new RequestError());

            public Task<T> DeserializeResponse<T>(HttpResponseMessage response) => Task.FromResult(default(T));

            public void Dispose() { }

            public string SerializeObject(object data) => "";

            public void SetRequestSerailizedContent(HttpRequestMessage request, object body) { }
        }
    }
}
