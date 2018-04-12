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

using Google.Apis.Storage.v1;
using System;
using Xunit;
using static Google.Cloud.Storage.V1.EncryptionKey; // For None and Generate()

namespace Google.Cloud.Storage.V1.Tests
{
    public class StorageClientImplTest
    {
        private static readonly EncryptionKey EncryptionKey1 = Generate();
        private static readonly EncryptionKey EncryptionKey2 = Generate();

        // Between this and GetEffectiveEncryptionKey_Invalid we should have all 12 combinations of:
        // - Client encryption key: None or EncryptionKey1
        // - Operation encryption key: null, None, EncryptionKey2
        // - KMS key: null or "key"
        public static TheoryData<EncryptionKey, EncryptionKey, string, EncryptionKey> GetEffectiveEncryptionKey_Valid_Data =>
            new TheoryData<EncryptionKey, EncryptionKey, string, EncryptionKey>
            {
                { None, null, null, None },
                { None, null, "key", None },
                { None, None, null, None },
                { None, None, "key", None },
                { None, EncryptionKey2, null, EncryptionKey2 },
                { EncryptionKey1, null, null, EncryptionKey1 },
                { EncryptionKey1, null, "key", None },
                { EncryptionKey1, None, null, None },
                { EncryptionKey1, None, "key", None },
                { EncryptionKey1, EncryptionKey2, null, EncryptionKey2 },
            };

        [Theory, MemberData(nameof(GetEffectiveEncryptionKey_Valid_Data))]
        public void GetEffectiveEncryptionKey_Valid(EncryptionKey clientkey, EncryptionKey operationKey, string kmsKey, EncryptionKey expected)
        {
            var service = new StorageService();
            var client = new StorageClientImpl(service, clientkey);
            var actual = client.GetEffectiveEncryptionKey(operationKey, kmsKey);
            Assert.Same(expected, actual);
        }

        public static TheoryData<EncryptionKey, EncryptionKey, string> GetEffectiveEncryptionKey_Invalid_Data =>
            new TheoryData<EncryptionKey, EncryptionKey, string>
            {
                { None, EncryptionKey2, "key" },
                { EncryptionKey1, EncryptionKey2, "key" }
            };

        [Theory, MemberData(nameof(GetEffectiveEncryptionKey_Invalid_Data))]
        public void GetEffectiveEncryptionKey_Invalid(EncryptionKey clientkey, EncryptionKey operationKey, string kmsKey)
        {
            var service = new StorageService();
            var client = new StorageClientImpl(service, clientkey);
            Assert.Throws<ArgumentException>(() => client.GetEffectiveEncryptionKey(operationKey, kmsKey));
        }
    }
}
