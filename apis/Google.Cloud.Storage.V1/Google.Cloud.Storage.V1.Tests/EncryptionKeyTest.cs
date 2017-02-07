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
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace Google.Cloud.Storage.V1.Tests
{
    public class EncryptionKeyTest
    {
        [Fact]
        public void Generate()
        {
            EncryptionKey key1 = EncryptionKey.Generate();
            EncryptionKey key2 = EncryptionKey.Generate();

            Assert.NotNull(key1.Base64Key);
            Assert.NotNull(key1.Base64Hash);

            Assert.NotEqual(key1.Base64Key, key2.Base64Key);
            Assert.NotEqual(key1.Base64Hash, key2.Base64Hash);
        }

        [Fact]
        public void Create()
        {
            EncryptionKey key = EncryptionKey.Create(new byte[32]);
            Assert.Equal("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA=", key.Base64Key);
            Assert.Equal("Zmh6rfhivXdsj8GLjp+OIAiXFIVu4jOzkCpZHQ1fKSU=", key.Base64Hash);
        }

        [Fact]
        public void Create_Invalid()
        {
            Assert.Throws<ArgumentNullException>(() => EncryptionKey.Create(null));
            Assert.Throws<ArgumentException>(() => EncryptionKey.Create(new byte[33]));
            Assert.Throws<ArgumentException>(() => EncryptionKey.Create(new byte[31]));
        }

        [Fact]
        public void None()
        {
            Assert.Null(EncryptionKey.None.Base64Key);
            Assert.Null(EncryptionKey.None.Base64Hash);
        }

        [Fact]
        public void ModifyRequest_None()
        {
            var request = new HttpRequestMessage();
            EncryptionKey.None.ModifyRequest(request);
            IEnumerable<string> values;
            Assert.False(request.Headers.TryGetValues(EncryptionKey.AlgorithmHeader, out values));
            Assert.False(request.Headers.TryGetValues(EncryptionKey.KeyHeader, out values));
            Assert.False(request.Headers.TryGetValues(EncryptionKey.KeyHashHeader, out values));
            Assert.False(request.Headers.TryGetValues(EncryptionKey.CopySourceAlgorithmHeader, out values));
            Assert.False(request.Headers.TryGetValues(EncryptionKey.CopySourceKeyHeader, out values));
            Assert.False(request.Headers.TryGetValues(EncryptionKey.CopySourceKeyHashHeader, out values));
        }

        [Fact]
        public void ModifyRequest_NotNone()
        {
            EncryptionKey key = EncryptionKey.Create(new byte[32]);
            var request = new HttpRequestMessage();
            key.ModifyRequest(request);
            IEnumerable<string> values;
            Assert.True(request.Headers.TryGetValues(EncryptionKey.AlgorithmHeader, out values));
            Assert.Equal(new[] { EncryptionKey.AlgorithmValue }, values);
            Assert.True(request.Headers.TryGetValues(EncryptionKey.KeyHeader, out values));
            Assert.Equal(new[] { "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA=" }, values);
            Assert.True(request.Headers.TryGetValues(EncryptionKey.KeyHashHeader, out values));
            Assert.Equal(new[] { "Zmh6rfhivXdsj8GLjp+OIAiXFIVu4jOzkCpZHQ1fKSU=" }, values);

            Assert.False(request.Headers.TryGetValues(EncryptionKey.CopySourceAlgorithmHeader, out values));
            Assert.False(request.Headers.TryGetValues(EncryptionKey.CopySourceKeyHeader, out values));
            Assert.False(request.Headers.TryGetValues(EncryptionKey.CopySourceKeyHashHeader, out values));
        }

        [Fact]
        public void ModifyRequestForRewriteSource_None()
        {
            var request = new HttpRequestMessage();
            EncryptionKey.None.ModifyRequestForRewriteSource(request);
            IEnumerable<string> values;
            Assert.False(request.Headers.TryGetValues(EncryptionKey.CopySourceAlgorithmHeader, out values));
            Assert.False(request.Headers.TryGetValues(EncryptionKey.CopySourceKeyHeader, out values));
            Assert.False(request.Headers.TryGetValues(EncryptionKey.CopySourceKeyHashHeader, out values));

            Assert.False(request.Headers.TryGetValues(EncryptionKey.AlgorithmHeader, out values));
            Assert.False(request.Headers.TryGetValues(EncryptionKey.KeyHeader, out values));
            Assert.False(request.Headers.TryGetValues(EncryptionKey.KeyHashHeader, out values));
        }


        [Fact]
        public void ModifyRequestForRewriteSource_NotNone()
        {
            EncryptionKey key = EncryptionKey.Create(new byte[32]);
            var request = new HttpRequestMessage();
            key.ModifyRequestForRewriteSource(request);
            IEnumerable<string> values;
            Assert.True(request.Headers.TryGetValues(EncryptionKey.CopySourceAlgorithmHeader, out values));
            Assert.Equal(new[] { EncryptionKey.AlgorithmValue }, values);
            Assert.True(request.Headers.TryGetValues(EncryptionKey.CopySourceKeyHeader, out values));
            Assert.Equal(new[] { "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA=" }, values);
            Assert.True(request.Headers.TryGetValues(EncryptionKey.CopySourceKeyHashHeader, out values));
            Assert.Equal(new[] { "Zmh6rfhivXdsj8GLjp+OIAiXFIVu4jOzkCpZHQ1fKSU=" }, values);

            Assert.False(request.Headers.TryGetValues(EncryptionKey.AlgorithmHeader, out values));
            Assert.False(request.Headers.TryGetValues(EncryptionKey.KeyHeader, out values));
            Assert.False(request.Headers.TryGetValues(EncryptionKey.KeyHashHeader, out values));
        }
    }
}
