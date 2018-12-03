// Copyright 2018 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
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

using Google.Cloud.ClientTesting;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    public partial class UrlSignerTest
    {
        [Collection(nameof(StorageFixture))]
        public class V2SignerTest
        {
            private readonly StorageFixture _fixture;

            private UrlSigner Signer => _fixture.UrlSigner.WithSigningVersion(SigningVersion.V2);

            public V2SignerTest(StorageFixture fixture)
            {
                _fixture = fixture;
                _fixture.RegisterDelayTests(this);
            }

            private static string GetTestName([CallerMemberName] string methodName = null) => $"{nameof(V2SignerTest)}.{methodName}";

            [Fact]
            public async Task DeleteTest() => await _fixture.FinishDelayTest(GetTestName());
            private void DeleteTest_InitDelayTest() => DeleteTest_Common(_fixture, Signer);

            [Fact]
            public async Task GetTest() => await _fixture.FinishDelayTest(GetTestName());
            private void GetTest_InitDelayTest() => GetTest_Common(_fixture, Signer);

            [Fact]
            public async Task GetBucketTest() => await _fixture.FinishDelayTest(GetTestName());
            private void GetBucketTest_InitDelayTest() => GetBucketTest_Common(_fixture, Signer);

            [Fact]
            public async Task GetObjectWithSpacesTest() => await _fixture.FinishDelayTest(GetTestName());
            private void GetObjectWithSpacesTest_InitDelayTest() => GetObjectWithSpacesTest_Common(_fixture, Signer);

            [Fact]
            public async Task GetWithCustomerSuppliedEncryptionKeysTest() => await _fixture.FinishDelayTest(GetTestName());
            private void GetWithCustomerSuppliedEncryptionKeysTest_InitDelayTest() => GetWithCustomerSuppliedEncryptionKeysTest_Common(_fixture, Signer);

            [Fact]
            public async Task GetNoExpirationSpecifiedTest()
            {
#pragma warning disable CS0618 // Type or member is obsolete
                var url = Signer.Sign(_fixture.ReadBucket, _fixture.SmallObject, expiration: null);
#pragma warning restore CS0618 // Type or member is obsolete

                // We use int.MaxValue seconds, i.e. the January 3rd 2038, as a value "as close to infinite as we can represent"
                Assert.Contains("Expires=2147483647", url);

                // Verify that the URL works.
                var response = await _fixture.HttpClient.GetAsync(url);
                var result = await response.Content.ReadAsByteArrayAsync();
                AssertContentEqual(_fixture.SmallContent, result);
            }

            [Fact]
            public async Task GetWithCustomHeadersTest() => await _fixture.FinishDelayTest(GetTestName());
            private void GetWithCustomHeadersTest_InitDelayTest() => GetWithCustomHeadersTest_Common(_fixture, Signer);

            [Fact]
            public async Task HeadTest() => await _fixture.FinishDelayTest(GetTestName());
            private void HeadTest_InitDelayTest() => HeadTest_Common(_fixture, Signer);

            [Fact]
            public async Task HeadWithGetMethodSignedURLTest() => await _fixture.FinishDelayTest(GetTestName());
            private void HeadWithGetMethodSignedURLTest_InitDelayTest() => HeadWithGetMethodSignedURLTest_Common(_fixture, Signer);

            [Fact]
            public async Task PutTest() => await _fixture.FinishDelayTest(GetTestName());
            private void PutTest_InitDelayTest() => PutTest_Common(_fixture, Signer);

            [Fact]
            public async Task PutWithCustomerSuppliedEncryptionKeysTest() => await _fixture.FinishDelayTest(GetTestName());
            private void PutWithCustomerSuppliedEncryptionKeysTest_InitDelayTest() => PutWithCustomerSuppliedEncryptionKeysTest_Common(_fixture, Signer);

            [Fact]
            public async Task PutWithCustomHeadersTest() => await _fixture.FinishDelayTest(GetTestName());
            private void PutWithCustomHeadersTest_InitDelayTest() => PutWithCustomHeadersTest_Common(_fixture, Signer);


            [Fact]
            public async Task ResumableUploadTest() => await _fixture.FinishDelayTest(GetTestName());
            private void ResumableUploadTest_InitDelayTest() => ResumableUploadTest_Common(_fixture, Signer);

            [Fact]
            public async Task ResumableUploadResumeTest() => await _fixture.FinishDelayTest(GetTestName());
            private void ResumableUploadResumeTest_InitDelayTest() => ResumableUploadResumeTest_Common(_fixture, Signer);

            [Fact]
            public async Task ResumableUploadWithCustomerSuppliedEncryptionKeysTest() => await _fixture.FinishDelayTest(GetTestName());
            private void ResumableUploadWithCustomerSuppliedEncryptionKeysTest_InitDelayTest() => ResumableUploadWithCustomerSuppliedEncryptionKeysTest_Common(_fixture, Signer);
        }
    }
}
