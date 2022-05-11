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
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Storage.V1.UrlSigner;

#if NET461
using RsaKey = System.Security.Cryptography.RSACryptoServiceProvider;
#else
using RsaKey = System.Security.Cryptography.RSA;
#endif

namespace Google.Cloud.Storage.V1.Tests
{
    /// <summary>
    /// UrlSigner unit tests that are version-agnostic.
    /// </summary>
    public partial class UrlSignerTest
    {
        [Fact]
        public void FromServiceAccountPath_Validations()
        {
            Assert.Throws<ArgumentNullException>(() => UrlSigner.FromServiceAccountPath(null));
            Assert.Throws<FileNotFoundException>(() => UrlSigner.FromServiceAccountPath("does_not_exist.txt"));
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
        public async Task Sign_Validations()
        {
            var signer = UrlSigner.FromBlobSigner(new FakeBlobSigner());

            Assert.Throws<ArgumentNullException>(() => signer.Sign((RequestTemplate)null, null));
            await Assert.ThrowsAsync<ArgumentNullException>(() => signer.SignAsync((RequestTemplate)null, null));
            Assert.Throws<ArgumentNullException>(() => signer.Sign((PostPolicy)null, null));
            await Assert.ThrowsAsync<ArgumentNullException>(() => signer.SignAsync((PostPolicy)null, null));

            Assert.Throws<ArgumentNullException>(() => signer.Sign((RequestTemplate)null, Options.FromDuration(TimeSpan.Zero)));
            await Assert.ThrowsAsync<ArgumentNullException>(() => signer.SignAsync((RequestTemplate)null, Options.FromDuration(TimeSpan.Zero)));
            Assert.Throws<ArgumentNullException>(() => signer.Sign((PostPolicy)null, Options.FromDuration(TimeSpan.Zero)));
            await Assert.ThrowsAsync<ArgumentNullException>(() => signer.SignAsync((PostPolicy)null, Options.FromDuration(TimeSpan.Zero)));

            Assert.Throws<ArgumentNullException>(() => signer.Sign(RequestTemplate.FromBucket("bucket"), null));
            await Assert.ThrowsAsync<ArgumentNullException>(() => signer.SignAsync(RequestTemplate.FromBucket("bucket"), null));

            // Bucket names cannot be null or contain uppercase letters (among other rules).
            // Make sure we verify the presence and format of the bucket name in all overloads.
            Assert.Throws<ArgumentNullException>(() => signer.Sign(null, "objectName", TimeSpan.FromDays(1)));
            await Assert.ThrowsAsync<ArgumentNullException>(() => signer.SignAsync(null, "objectName", TimeSpan.FromDays(1)));
            Assert.Throws<ArgumentException>(() => signer.Sign("BUCKETNAME", "objectName", TimeSpan.FromDays(1)));
            await Assert.ThrowsAsync<ArgumentException>(() => signer.SignAsync("BUCKETNAME", "objectName", TimeSpan.FromDays(1)));

            // Make sure exceptions are not thrown for things which may be null or uppercase.	
            signer.Sign("bucketname", null, TimeSpan.FromDays(1), null, null);
            await signer.SignAsync("bucketname", null, TimeSpan.FromDays(1), null, null);
        }

        private class FakeBlobSigner : UrlSigner.IBlobSigner
        {
            public string Id => "FakeId";

            public string Algorithm => "GOOG4-RSA-SHA256";

            public string CreateSignature(byte[] data, BlobSignerParameters _) => "AAA=";

            public async Task<string> CreateSignatureAsync(byte[] data, BlobSignerParameters _, CancellationToken cancellationToken)
            {
                await Task.Yield();
                return "BBB=";
            }
        }

        private static ServiceAccountCredential CreateFakeServiceAccountCredential(string id = "test") =>
            new ServiceAccountCredential(new ServiceAccountCredential.Initializer(id)
            {
                Key = (RsaKey) RSA.Create()
            });
    }
}
