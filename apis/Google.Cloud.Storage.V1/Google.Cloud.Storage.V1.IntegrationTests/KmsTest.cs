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

using Google.Apis.Storage.v1.Data;
using Google.Cloud.ClientTesting;
using System;
using System.IO;
using System.Linq;
using System.Net;
using Xunit;
using static Google.Apis.Storage.v1.Data.Bucket;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    /// <summary>
    /// Tests for customer-managed encryption keys (CMEK) that use Cloud KMS.
    /// </summary>
    [Collection(nameof(StorageFixture))]
    public class KmsTest
    {
        // Name of a US-based keyring, which is expected to be in the test project, in "locations/us"
        private static string UsKeyring { get; } = Environment.GetEnvironmentVariable("US_KMS_TEST_KEYRING");
        // ID of the first test key within the US-based keyring, e.g. "test_key_1"
        private static string UsKeyId1 { get; } = Environment.GetEnvironmentVariable("US_KMS_TEST_KEY1");
        // ID of the first test key within the US-based keyring, e.g. "test_key_2"
        private static string UsKeyId2 { get; } = Environment.GetEnvironmentVariable("US_KMS_TEST_KEY2");

        private string FullUsKeyringName => $"projects/{_fixture.ProjectId}/locations/us/keyRings/{UsKeyring}";
        private string FullUsKeyName1 => $"{FullUsKeyringName}/cryptoKeys/{UsKeyId1}";
        private string FullUsKeyName2 => $"{FullUsKeyringName}/cryptoKeys/{UsKeyId2}";

        private string VersionedKeyName1Prefix => FullUsKeyName1 + "/cryptoKeyVersions/";
        private string VersionedKeyName2Prefix => FullUsKeyName2 + "/cryptoKeyVersions/";

        private static bool SkipTests => new[] { UsKeyId1, UsKeyId2, UsKeyring }.Any(env => string.IsNullOrEmpty(env));

        private readonly StorageFixture _fixture;

        public KmsTest(StorageFixture fixture) => _fixture = fixture;

        [SkippableFact]
        public void UploadObject_BucketHasDefaultKmsKey_UploadWithNoSpecifiedKey()
        {
            _fixture.SkipIf(SkipTests);
            var client = _fixture.Client;

            string bucketName = CreateBucketWithDefaultKmsKeyName(FullUsKeyName1);
            string objectName = IdGenerator.FromGuid();
            var data = TestHelpers.GenerateData(1024);

            // Upload an object without specifying a key name; it should use the bucket default.
            Object obj = client.UploadObject(bucketName, objectName, null, data);
            Assert.StartsWith(VersionedKeyName1Prefix, obj.KmsKeyName);

            // We should be able to download it again.
            TestHelpers.ValidateData(bucketName, objectName, data);
        }

        [SkippableFact]
        public void UploadObject_BucketHasDefaultKmsKey_UploadWithDifferentKmsKey()
        {
            _fixture.SkipIf(SkipTests);
            var client = _fixture.Client;

            string bucketName = CreateBucketWithDefaultKmsKeyName(FullUsKeyName1);
            string objectName = IdGenerator.FromGuid();
            var data = TestHelpers.GenerateData(1024);

            // Upload an object with a different key name.
            Object obj = client.UploadObject(bucketName, objectName, null, data, new UploadObjectOptions { KmsKeyName = FullUsKeyName2 });
            Assert.StartsWith(VersionedKeyName2Prefix, obj.KmsKeyName);

            // We should be able to download it again.
            TestHelpers.ValidateData(bucketName, objectName, data);
        }

        [SkippableFact(Skip = "Skip for release while investigating")]
        public void UploadObject_BucketHasDefaultKmsKey_UploadWithCsek()
        {
            _fixture.SkipIf(SkipTests);
            var client = _fixture.Client;

            string bucketName = CreateBucketWithDefaultKmsKeyName(FullUsKeyName1);
            string objectName = IdGenerator.FromGuid();
            var data = TestHelpers.GenerateData(1024);
            EncryptionKey key = EncryptionKey.Generate();

            // Upload an object with a customer-supplied key instead of a KMS key.
            Object obj = client.UploadObject(bucketName, objectName, null, data, new UploadObjectOptions { EncryptionKey = key });
            Assert.Null(obj.KmsKeyName);
            Assert.Equal(key.Base64Hash, obj.CustomerEncryption.KeySha256);

            // We shouldn't be able to download the object without supplying an encryption key.
            Assert.Throws<GoogleApiException>(() => client.DownloadObject(bucketName, objectName, new MemoryStream()));

            // We should be able to download it again when we supply the encryption key
            TestHelpers.ValidateData(bucketName, objectName, data, options: new DownloadObjectOptions { EncryptionKey = key });
        }

        [SkippableFact]
        public void UploadObject_BucketHasNoDefaultKmsKey_UploadWithKmsKey()
        {
            _fixture.SkipIf(SkipTests);
            var client = _fixture.Client;

            string bucketName = _fixture.InitiallyEmptyBucket;
            string objectName = IdGenerator.FromGuid();
            var data = TestHelpers.GenerateData(1024);
            EncryptionKey key = EncryptionKey.Generate();

            // Upload an object with a KMS key.
            Object obj = client.UploadObject(bucketName, objectName, null, data, new UploadObjectOptions { KmsKeyName = FullUsKeyName2 });
            Assert.StartsWith(VersionedKeyName2Prefix, obj.KmsKeyName);

            // We should be able to download it again.
            TestHelpers.ValidateData(bucketName, objectName, data);
        }

        [SkippableFact(Skip = "Skip for release while investigating")]
        public void UploadObject_BucketHasDefaultKmsKey_UploadWithClientDefaultCsek()
        {
            _fixture.SkipIf(SkipTests);

            string bucketName = CreateBucketWithDefaultKmsKeyName(FullUsKeyName1);
            string objectName = IdGenerator.FromGuid();
            var data = TestHelpers.GenerateData(1024);
            EncryptionKey key = EncryptionKey.Generate();
            var client = StorageClient.Create(encryptionKey: key);

            // Upload an object using a client that has an encryption key. The default KMS key is ignored.
            Object obj = client.UploadObject(bucketName, objectName, null, data);
            Assert.Null(obj.KmsKeyName);
            Assert.Equal(key.Base64Hash, obj.CustomerEncryption.KeySha256);

            // We shouldn't be able to download the object without supplying an encryption key, e.g. using the fixture's client
            Assert.Throws<GoogleApiException>(() => _fixture.Client.DownloadObject(bucketName, objectName, new MemoryStream()));

            // We should be able to download it again when we supply the encryption key, either as an option
            // or via the default encryption key in the client.
            TestHelpers.ValidateData(bucketName, objectName, data, _fixture.Client, new DownloadObjectOptions { EncryptionKey = key });
            TestHelpers.ValidateData(bucketName, objectName, data, client);
        }

        [SkippableFact]
        public void UploadObject_BucketHasNoDefaultKmsKey_UploadWithClientDefaultCsek_ExplicitKmsKey()
        {
            _fixture.SkipIf(SkipTests);

            string bucketName = _fixture.InitiallyEmptyBucket;
            string objectName = IdGenerator.FromGuid();
            var data = TestHelpers.GenerateData(1024);
            EncryptionKey key = EncryptionKey.Generate();
            var client = StorageClient.Create(encryptionKey: key);

            // Upload an object using a client that has an encryption key, but also specify a KMS key.
            // This should result in an error. The CSEK needs to be explicitly disabled.
            var options = new UploadObjectOptions { KmsKeyName = FullUsKeyName1 };
            Assert.Throws<ArgumentException>(() => client.UploadObject(bucketName, objectName, null, data, options));
        }

        [SkippableFact]
        public void UploadObject_BucketHasNoDefaultKmsKey_UploadWithClientDefaultCsek_ExplicitKmsKeyAndCsekDisabled()
        {
            _fixture.SkipIf(SkipTests);

            string bucketName = _fixture.InitiallyEmptyBucket;
            string objectName = IdGenerator.FromGuid();
            var data = TestHelpers.GenerateData(1024);
            EncryptionKey key = EncryptionKey.Generate();
            var client = StorageClient.Create(encryptionKey: key);

            // Upload an object using a client that has an encryption key, but also specify a KMS key and disable
            // the CSEK in options. The KMS key should be used.
            var options = new UploadObjectOptions { KmsKeyName = FullUsKeyName1, EncryptionKey = EncryptionKey.None };
            Object obj = client.UploadObject(bucketName, objectName, null, data, options);
            Assert.StartsWith(VersionedKeyName1Prefix, obj.KmsKeyName);

            // We should be able to download it again, even with a default (no CSEK) client.
            TestHelpers.ValidateData(bucketName, objectName, data);
        }

        [SkippableFact(Skip = "See https://github.com/googleapis/google-cloud-dotnet/issues/2412")]
        public void UploadObject_BucketHasDefaultKmsKey_UploadWithNoSpecifiedKey_DownloadWithClientWithCsek()
        {
            _fixture.SkipIf(SkipTests);
            var client = _fixture.Client;

            string bucketName = CreateBucketWithDefaultKmsKeyName(FullUsKeyName1);
            string objectName = IdGenerator.FromGuid();
            var data = TestHelpers.GenerateData(1024);

            // Upload an object without specifying anything, so it should be encrypted with key 1.
            Object obj = client.UploadObject(bucketName, objectName, null, data);
            Assert.StartsWith(VersionedKeyName1Prefix, obj.KmsKeyName);

            // We should be able to download the file even if we use a client that supplies CSEK by default.
            EncryptionKey key = EncryptionKey.Generate();
            var encryptionKeyClient = StorageClient.Create(encryptionKey: key);
            TestHelpers.ValidateData(bucketName, objectName, data, encryptionKeyClient);
        }

        [SkippableFact]
        public void UploadObject_SpecifyBothCsekAndKmsKey()
        {
            _fixture.SkipIf(SkipTests);
            var client = _fixture.Client;

            string objectName = IdGenerator.FromGuid();
            var data = TestHelpers.GenerateData(1024);

            // It's invalid to specify both an EncryptionKey (that's non-None) and a key name
            var options = new UploadObjectOptions { EncryptionKey = EncryptionKey.Generate(), KmsKeyName = FullUsKeyName1 };
            var exception = Assert.Throws<ArgumentException>(() => client.UploadObject(_fixture.InitiallyEmptyBucket, objectName, null, data, options));
            Assert.Contains(nameof(CopyObjectOptions.EncryptionKey), exception.Message);
            Assert.Contains(nameof(CopyObjectOptions.KmsKeyName), exception.Message);
        }

        [SkippableFact]
        public void CopyObject_ChangeKey()
        {
            _fixture.SkipIf(SkipTests);
            var client = _fixture.Client;
            string bucketName = _fixture.InitiallyEmptyBucket;
            string objectName = IdGenerator.FromGuid();
            var data = TestHelpers.GenerateData(1024);

            // Upload an object with a KMS key.
            Object obj = client.UploadObject(bucketName, objectName, null, data, new UploadObjectOptions { KmsKeyName = FullUsKeyName1 });
            Assert.StartsWith(VersionedKeyName1Prefix, obj.KmsKeyName);

            // Copy it (within the same bucket, for simplicity) with a different key

            string copyName = objectName + "-copy";
            Object obj2 = client.CopyObject(bucketName, objectName, bucketName, copyName, new CopyObjectOptions { KmsKeyName = FullUsKeyName2 });
            Assert.StartsWith(VersionedKeyName2Prefix, obj2.KmsKeyName);

            // We should be able to download it again.
            TestHelpers.ValidateData(bucketName, copyName, data);
        }

        [SkippableFact]
        public void CopyObject_MigrateFromCsekToKms()
        {
            _fixture.SkipIf(SkipTests);
            var client = _fixture.Client;
            string bucketName = _fixture.InitiallyEmptyBucket;
            string objectName = IdGenerator.FromGuid();
            var data = TestHelpers.GenerateData(1024);

            // Upload an object with a CSEK.
            var key = EncryptionKey.Generate();
            Object obj = client.UploadObject(bucketName, objectName, null, data, new UploadObjectOptions { EncryptionKey = key });
            Assert.Null(obj.KmsKeyName);
            Assert.Equal(key.Base64Hash, obj.CustomerEncryption.KeySha256);

            // Copy it (within the same bucket, for simplicity) with a KMS key
            string copyName = objectName + "-copy";
            Object obj2 = client.CopyObject(bucketName, objectName, bucketName, copyName,
                new CopyObjectOptions { KmsKeyName = FullUsKeyName1, SourceEncryptionKey = key });
            Assert.StartsWith(VersionedKeyName1Prefix, obj2.KmsKeyName);
            Assert.Null(obj2.CustomerEncryption);

            // We should be able to download it with no EncryptionKey.
            TestHelpers.ValidateData(bucketName, copyName, data);
        }

        [SkippableFact]
        public void CopyObject_SpecifyBothCsekAndKmsKey()
        {
            _fixture.SkipIf(SkipTests);
            var client = _fixture.Client;

            string objectName = IdGenerator.FromGuid();
            var data = TestHelpers.GenerateData(1024);

            // It's invalid to specify both an EncryptionKey (that's non-None) and a key name
            var options = new CopyObjectOptions { EncryptionKey = EncryptionKey.Generate(), KmsKeyName = FullUsKeyName1 };
            var exception = Assert.Throws<ArgumentException>(() => client.CopyObject(_fixture.ReadBucket, _fixture.SmallObject, _fixture.InitiallyEmptyBucket, objectName, options));
            Assert.Contains(nameof(CopyObjectOptions.EncryptionKey), exception.Message);
            Assert.Contains(nameof(CopyObjectOptions.KmsKeyName), exception.Message);
        }

        [SkippableFact]
        public void PatchObject_CannotChangeKms()
        {
            _fixture.SkipIf(SkipTests);
            var client = _fixture.Client;
            string bucketName = _fixture.InitiallyEmptyBucket;
            string objectName = IdGenerator.FromGuid();
            var data = TestHelpers.GenerateData(1024);

            // Upload an object without any encryption.
            Object obj = client.UploadObject(bucketName, objectName, null, data);
            // Try to use patch to set a KMS key. This will fail.
            var patch = new Object { Name = obj.Name, Bucket = obj.Bucket, KmsKeyName = FullUsKeyName1 };
            var exception = Assert.Throws<GoogleApiException>(() => client.PatchObject(patch));
            Assert.Equal(HttpStatusCode.BadRequest, exception.HttpStatusCode);
        }

        [SkippableFact]
        public void UpdateObject_CannotChangeKms()
        {
            _fixture.SkipIf(SkipTests);
            var client = _fixture.Client;
            string bucketName = _fixture.InitiallyEmptyBucket;
            string objectName = IdGenerator.FromGuid();
            var data = TestHelpers.GenerateData(1024);

            // Upload an object without any encryption.
            Object obj = client.UploadObject(bucketName, objectName, null, data);
            obj.KmsKeyName = FullUsKeyName1;
            // Try to use patch to set a KMS key. This will fail.
            var exception = Assert.Throws<GoogleApiException>(() => client.UpdateObject(obj));
            Assert.Equal(HttpStatusCode.BadRequest, exception.HttpStatusCode);
        }

        private string CreateBucketWithDefaultKmsKeyName(string keyName)
        {
            string bucketName = _fixture.GenerateBucketName();
            // TODO: Remove the Location = "US" part when the tests pass without it.
            // (This is a server-side issue; the bucket defaults to the US anyway, so we shouldn't
            // need to specify it.)
            Bucket bucket = new Bucket { Location = "US", Name = bucketName, Encryption = new EncryptionData { DefaultKmsKeyName = keyName } };
            bucket = _fixture.Client.CreateBucket(_fixture.ProjectId, bucket);
            StorageFixture.SleepAfterBucketCreateDelete();
            _fixture.RegisterBucketToDelete(bucketName);
            return bucketName;
        }
    }
}
