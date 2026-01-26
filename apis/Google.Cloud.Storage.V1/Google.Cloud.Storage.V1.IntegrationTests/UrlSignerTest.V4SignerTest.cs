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

using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    public partial class UrlSignerTest
    {
        [Collection(nameof(StorageFixture))]
        public class V4SignerTest
        {
            private readonly StorageFixture _fixture;

            public V4SignerTest(StorageFixture fixture)
            {
                _fixture = fixture;
                _fixture.RegisterDelayTests(this);
            }

            private static string GetTestName([CallerMemberName] string methodName = null) => $"{nameof(V4SignerTest)}.{methodName}";

            [Fact(Skip = "b/478856508")]
            public async Task DeleteTest() => await _fixture.FinishDelayTest(GetTestName());
            private void DeleteTest_InitDelayTest() => DeleteTest_Common(_fixture, SigningVersion.V4);


            [Fact(Skip = "b/478856508")]
            public async Task GetTest() => await _fixture.FinishDelayTest(GetTestName());
            private void GetTest_InitDelayTest() => GetTest_Common(_fixture, SigningVersion.V4);

            [Fact(Skip = "b/478856508")]
            public async Task GetBucketTest() => await _fixture.FinishDelayTest(GetTestName());
            private void GetBucketTest_InitDelayTest() => GetBucketTest_Common(_fixture, SigningVersion.V4);

            [Fact(Skip = "b/478856508")]
            public async Task GetObjectWithSpacesTest() => await _fixture.FinishDelayTest(GetTestName());
            private void GetObjectWithSpacesTest_InitDelayTest() => GetObjectWithSpacesTest_Common(_fixture, SigningVersion.V4);

            [Fact(Skip = "b/478856508")]
            public async Task GetWithCustomerSuppliedEncryptionKeysTest() => await _fixture.FinishDelayTest(GetTestName());
            private void GetWithCustomerSuppliedEncryptionKeysTest_InitDelayTest() => GetWithCustomerSuppliedEncryptionKeysTest_Common(_fixture, SigningVersion.V4);

            [Fact(Skip = "b/478856508")]
            public async Task GetWithCustomHeadersTest() => await _fixture.FinishDelayTest(GetTestName());
            private void GetWithCustomHeadersTest_InitDelayTest() => GetWithCustomHeadersTest_Common(_fixture, SigningVersion.V4);

            [Fact(Skip = "b/478856508")]
            public async Task GetWithVirtualHostedStyleTest() => await _fixture.FinishDelayTest(GetTestName());
            private void GetWithVirtualHostedStyleTest_InitDelayTest() => GetWithVirtualHostedStyleTest_Common(_fixture, SigningVersion.V4);

            [Fact(Skip = "b/478856508")]
            public async Task GetWithHttpTest() => await _fixture.FinishDelayTest(GetTestName());
            private void GetWithHttpTest_InitDelayTest() => GetWithHttpTest_Common(_fixture, SigningVersion.V4);

            [Fact(Skip = "b/478856508")]
            public async Task HeadTest() => await _fixture.FinishDelayTest(GetTestName());
            private void HeadTest_InitDelayTest() => HeadTest_Common(_fixture, SigningVersion.V4);

            [Fact(Skip = "b/478856508")]
            public async Task HeadWithGetMethodSignedURLTest() => await _fixture.FinishDelayTest(GetTestName());
            private void HeadWithGetMethodSignedURLTest_InitDelayTest() => HeadWithGetMethodSignedURLTest_Common(_fixture, SigningVersion.V4);

            [Fact(Skip = "b/478856508")]
            public async Task PutTest() => await _fixture.FinishDelayTest(GetTestName());
            private void PutTest_InitDelayTest() => PutTest_Common(_fixture, SigningVersion.V4);

            [Fact(Skip = "b/478856508")]
            public async Task PutWithCustomerSuppliedEncryptionKeysTest() => await _fixture.FinishDelayTest(GetTestName());
            private void PutWithCustomerSuppliedEncryptionKeysTest_InitDelayTest() => PutWithCustomerSuppliedEncryptionKeysTest_Common(_fixture, SigningVersion.V4);

            [Fact(Skip = "b/478856508")]
            public async Task PutWithCustomHeadersTest() => await _fixture.FinishDelayTest(GetTestName());
            private void PutWithCustomHeadersTest_InitDelayTest() => PutWithCustomHeadersTest_Common(_fixture, SigningVersion.V4);


            [Fact(Skip = "b/478856508")]
            public async Task ResumableUploadTest() => await _fixture.FinishDelayTest(GetTestName());
            private void ResumableUploadTest_InitDelayTest() => ResumableUploadTest_Common(_fixture, SigningVersion.V4);

            [Fact(Skip = "b/478856508")]
            public async Task ResumableUploadResumeTest() => await _fixture.FinishDelayTest(GetTestName());
            private void ResumableUploadResumeTest_InitDelayTest() => ResumableUploadResumeTest_Common(_fixture, SigningVersion.V4);

            [Fact(Skip = "b/478856508")]
            public async Task ResumableUploadWithCustomerSuppliedEncryptionKeysTest() => await _fixture.FinishDelayTest(GetTestName());
            private void ResumableUploadWithCustomerSuppliedEncryptionKeysTest_InitDelayTest() => ResumableUploadWithCustomerSuppliedEncryptionKeysTest_Common(_fixture, SigningVersion.V4);
        }
    }
}
