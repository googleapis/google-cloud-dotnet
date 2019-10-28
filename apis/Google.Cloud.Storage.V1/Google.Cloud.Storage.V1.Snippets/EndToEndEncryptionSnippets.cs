// Copyright 2019 Google Inc. All Rights Reserved.
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

using Google.Cloud.ClientTesting;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Xunit;

namespace Google.Cloud.Storage.V1.Snippets
{
    [SnippetOutputCollector]
    [Collection(nameof(StorageSnippetFixture))]
    public class EndToEndEncryptionSnippets
    {
        private readonly StorageSnippetFixture _fixture;

        public EndToEndEncryptionSnippets(StorageSnippetFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void EndToEndEncryption()
        {
            var projectId = _fixture.ProjectId;
            var tuple = GenerateAesKeyAndInitializationVector();
            var key = tuple.Item1;
            var iv = tuple.Item2;

            // Sample: EncryptsAndUploads
            var client = StorageClient.Create();

            // Create a bucket with a globally unique name
            var bucketName = Guid.NewGuid().ToString();
            var bucket = client.CreateBucket(projectId, bucketName);

            var objectName = "aes-encrypted";

            string sensitiveData = "Some very sensitive data that should definetely be encrypted.";
            string sensitiveDataRoundtrip;

            // Use AES as the algorithm to encrypt and decrypt some content.
            using (Aes aesAlgo = Aes.Create())
            {
                // Obtain your encryption key and initialization vector
                // from your usual key storage.
                aesAlgo.Key = key;
                aesAlgo.IV = iv;

                // Prepare a stream with sensitive data.
                // This can be any stream, including one representing a file on your file system.
                var content = Encoding.UTF8.GetBytes(sensitiveData);
                using (MemoryStream source = new MemoryStream(content))
                {
                    // Encrypt the content client side and upload it.
                    var obj = client.CryptoTransformAndUploadObject(
                        bucketName, objectName, "application/octet-stream", source, aesAlgo.CreateEncryptor());

                    Console.WriteLine($"Content encrypted and uploaded to {obj.Name}");
                }

                // Download the encrypted content and decrypt it client side.
                using (MemoryStream destination = new MemoryStream())
                {
                    client.DownloadObjectAndCryptoTransform(
                        bucketName, objectName, destination, aesAlgo.CreateDecryptor());
                    // Download leaves the stream at the end.
                    destination.Position = 0;

                    using (StreamReader reader = new StreamReader(destination))
                    {
                        sensitiveDataRoundtrip = reader.ReadToEnd();
                    }
                }

                Console.WriteLine("Content downloaded and decrypted.");
                Console.WriteLine("Original:   {0}", sensitiveData);
                Console.WriteLine("Round Trip: {0}", sensitiveDataRoundtrip);
            }
            // End sample

            StorageSnippetFixture.SleepAfterBucketCreateDelete();

            _fixture.RegisterBucketToDelete(bucketName);
            StorageSnippetFixture.SleepAfterBucketCreateDelete();

            Assert.Equal(sensitiveData, sensitiveDataRoundtrip);
        }

        private Tuple<byte[], byte[]> GenerateAesKeyAndInitializationVector()
        {
            using (Aes algo = Aes.Create())
            {
                return Tuple.Create(algo.Key, algo.IV);
            }
        }
    }
}
