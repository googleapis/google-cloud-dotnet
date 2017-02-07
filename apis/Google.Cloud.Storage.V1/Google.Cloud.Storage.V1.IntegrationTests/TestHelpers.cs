// Copyright 2015 Google Inc. All Rights Reserved.
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
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using Xunit;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    internal static class TestHelpers
    {
        /// <summary>
        /// Generates an object name which can reasonably be expected to be unique.
        /// </summary>
        internal static string GenerateName() => Guid.NewGuid().ToString();

        /// <summary>
        /// Generates a read-only stream of random data of the given size. The
        /// returned stream is positioned at the start of the data.
        /// </summary>
        internal static MemoryStream GenerateData(int size)
        {
            var rng = RandomNumberGenerator.Create();
            byte[] data = new byte[size];
            rng.GetBytes(data);
            return new MemoryStream(data);
        }

        internal static void ValidateData(string bucketName, string objectName, byte[] expectedData,
            StorageClient client = null, DownloadObjectOptions options = null)
        {
            client = client ?? StorageClient.Create();
            var downloaded = new MemoryStream();
            client.DownloadObject(bucketName, objectName, downloaded, options);
            Assert.Equal(expectedData, downloaded.ToArray());
        }


        internal static void ValidateData(string bucketName, string objectName, MemoryStream expectedData,
            StorageClient client = null, DownloadObjectOptions options = null) =>
            ValidateData(bucketName, objectName, expectedData.ToArray(), client, options);
    }
}
