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

using System.IO;
using System.Text;
using Xunit;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    /// <summary>
    /// Tests that ensure the client does *not* perform any normalization.
    /// The bucket <see cref="s_bucket"/> contains two files, which are both named "Café"
    /// but using different normalization. The client should be able to retrieve both.
    /// </summary>
    public class NormalizationTest
    {
        private const string s_bucket = "storage-library-test-bucket";

        [Theory]
        // Normalization Form C: a single character for e-acute.
        // URL should end with Caf%C3%A9
        [InlineData("Caf\u00e9", "Normalization Form C")]
        // Normalization Form D: an ASCII e followed by U+0301 combining character
        // URL should end with Cafe%CC%81
        [InlineData("Cafe\u0301", "Normalization Form D")]
        public void FetchObjectAndCheckContent(string name, string expectedContent)
        {
            var client = StorageClient.Create();
            var obj = client.GetObject(s_bucket, name);
            Assert.Equal(name, obj.Name);

            var stream = new MemoryStream();
            client.DownloadObject(s_bucket, name, stream);
            string text = Encoding.UTF8.GetString(stream.ToArray());
            Assert.Equal(expectedContent, text);
        }
    }
}
