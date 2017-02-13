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

using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using Xunit;

namespace Google.Cloud.Storage.V1.Tests
{
    public class UrlSignerTest
    {
        [Fact]
        public void FromServiceAccountPath_Validations()
        {
            Assert.Throws<ArgumentNullException>(() => UrlSigner.FromServiceAccountPath(null));
            Assert.Throws<DirectoryNotFoundException>(() => UrlSigner.FromServiceAccountPath("C:\\does_not_exist\\foo.txt"));
        }

        [Fact]
        public void FromServiceAccountData_Validations()
        {
            Assert.Throws<ArgumentNullException>(() => UrlSigner.FromServiceAccountData(null));
        }

        [Fact]
        public void FromServiceAccountCredential_Validations()
        {
            Assert.Throws<ArgumentNullException>(() => UrlSigner.FromServiceAccountCredential(null));
        }

        [Fact]
        public void Sign_Validations()
        {
            var signer = UrlSigner.FromServiceAccountCredential(
                GoogleCredential.GetApplicationDefaultAsync().Result.UnderlyingCredential as ServiceAccountCredential);

            Assert.Throws<ArgumentNullException>(() => signer.Sign(null, "objectName", TimeSpan.FromDays(1), new HttpRequestMessage()));
            Assert.Throws<ArgumentException>(() => signer.Sign("BUCKETNAME", "objectName", TimeSpan.FromDays(1), new HttpRequestMessage()));

            Assert.Throws<ArgumentNullException>(() => signer.Sign(null, "objectName", DateTimeOffset.UtcNow, new HttpRequestMessage()));
            Assert.Throws<ArgumentException>(() => signer.Sign("BUCKETNAME", "objectName", DateTimeOffset.UtcNow, new HttpRequestMessage()));

            var emptyHeaders = new Dictionary<string, IEnumerable<string>>();
            Assert.Throws<ArgumentNullException>(() => signer.Sign(null, "objectName", TimeSpan.FromDays(1), HttpMethod.Get, emptyHeaders, emptyHeaders));
            Assert.Throws<ArgumentException>(() => signer.Sign("BUCKETNAME", "objectName", TimeSpan.FromDays(1), HttpMethod.Get, emptyHeaders, emptyHeaders));

            Assert.Throws<ArgumentNullException>(() => signer.Sign(null, "objectName", DateTimeOffset.UtcNow, HttpMethod.Get, emptyHeaders, emptyHeaders));
            Assert.Throws<ArgumentException>(() => signer.Sign("BUCKETNAME", "objectName", DateTimeOffset.UtcNow, HttpMethod.Get, emptyHeaders, emptyHeaders));

            // Make sure exceptions are not thrown for things which may be null or uppercase.
            signer.Sign("bucketname", null, TimeSpan.FromDays(1), null);
            signer.Sign("bucketname", null, null, null, null, null);
            signer.Sign("bucketname", "OBJECTNAME", null, null, null, null);
        }

        [Fact]
        public void DefaultHttpMethodIsGet()
        {
            var signer = UrlSigner.FromServiceAccountCredential(
                GoogleCredential.GetApplicationDefaultAsync().Result.UnderlyingCredential as ServiceAccountCredential);

            var bucketName = "bucket-name";
            var objectName = "object-name";
            var expiration = DateTimeOffset.UtcNow + TimeSpan.FromDays(1);
            var url1 = signer.Sign(bucketName, objectName, expiration, requestMethod: null);
            var url2 = signer.Sign(bucketName, objectName, expiration, requestMethod: HttpMethod.Get);
            Assert.Equal(url1, url2);
        }

        [Fact]
        public void EncryptionKeyAndHashAreIgnored()
        {
            var signer = UrlSigner.FromServiceAccountCredential(
                GoogleCredential.GetApplicationDefaultAsync().Result.UnderlyingCredential as ServiceAccountCredential);

            var bucketName = "bucket-name";
            var objectName = "object-name";
            var expiration = DateTimeOffset.UtcNow + TimeSpan.FromDays(1);
            var url1 = signer.Sign(bucketName, objectName, expiration, requestHeaders: new Dictionary<string, IEnumerable<string>> {
                    { "x-goog-encryption-algorithm", new [] { "AES256" } }
                });
            var url2 = signer.Sign(bucketName, objectName, expiration, requestHeaders: new Dictionary<string, IEnumerable<string>> {
                    { "x-goog-encryption-algorithm", new [] { "AES256" } },
                    { "x-goog-encryption-key", new [] { "abc" } },
                    { "x-goog-encryption-key-sha256", new [] { "def" } }
                });
            Assert.Equal(url1, url2);

            // However, make sure the encryption algorithm is not ignored.
            var url3 = signer.Sign(bucketName, objectName, expiration);
            Assert.NotEqual(url1, url3);
        }

        [Fact]
        public void ResumableEquivalentToPostWithStartHeader()
        {
            var signer = UrlSigner.FromServiceAccountCredential(
                GoogleCredential.GetApplicationDefaultAsync().Result.UnderlyingCredential as ServiceAccountCredential);

            var bucketName = "bucket-name";
            var objectName = "object-name";
            var expiration = DateTimeOffset.UtcNow + TimeSpan.FromDays(1);
            var url1 = signer.Sign(bucketName, objectName, expiration, UrlSigner.ResumableHttpMethod);
            var url2 = signer.Sign(bucketName, objectName, expiration, HttpMethod.Post,
                new Dictionary<string, IEnumerable<string>> { { "x-goog-resumable", new[] { "start" } } });
            Assert.Equal(url1, url2);
        }
    }
}
