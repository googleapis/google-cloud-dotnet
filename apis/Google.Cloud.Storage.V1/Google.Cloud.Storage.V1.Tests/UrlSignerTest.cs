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
        public void Sign_Validations()
        {
            var signer = UrlSigner.FromBlobSigner(new FakeBlobSigner());

            Assert.Throws<ArgumentNullException>(() => signer.Sign(null, null));
            Assert.ThrowsAsync<ArgumentNullException>(() => signer.SignAsync(null, null));

            Assert.Throws<ArgumentNullException>(() => signer.Sign(null, Options.FromDuration(TimeSpan.Zero)));
            Assert.ThrowsAsync<ArgumentNullException>(() => signer.SignAsync(null, Options.FromDuration(TimeSpan.Zero)));

            Assert.Throws<ArgumentNullException>(() => signer.Sign(RequestTemplate.FromBucket("bucket"), null));
            Assert.ThrowsAsync<ArgumentNullException>(() => signer.SignAsync(RequestTemplate.FromBucket("bucket"), null));
        }

        private class FakeBlobSigner : UrlSigner.IBlobSigner
        {
            public string Id => "FakeId";

            public string CreateSignature(byte[] data) => "AAA=";

            public async Task<string> CreateSignatureAsync(byte[] data, CancellationToken cancellationToken)
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
