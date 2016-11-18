// Copyright 2016 Google Inc. All Rights Reserved.
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
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Metadata.V1.Tests
{
    public class MetadataClientTest
    {
        [Fact]
        public void GetCustomInstanceMetadata_Validations()
        {
            var client = MetadataClient.Create();
            Assert.Throws<ArgumentException>(() => client.GetCustomInstanceMetadata(""));
            Assert.Throws<ArgumentException>(() => client.GetCustomInstanceMetadata("a b"));
            Assert.Throws<ArgumentException>(() => client.GetCustomInstanceMetadata("a^b"));
            Assert.Throws<ArgumentException>(() => client.GetCustomInstanceMetadata(
                "0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF"));

            Assert.ThrowsAsync<ArgumentException>(() => client.GetCustomInstanceMetadataAsync(""));
            Assert.ThrowsAsync<ArgumentException>(() => client.GetCustomInstanceMetadataAsync("a b"));
            Assert.ThrowsAsync<ArgumentException>(() => client.GetCustomInstanceMetadataAsync("a^b"));
            Assert.ThrowsAsync<ArgumentException>(() => client.GetCustomInstanceMetadataAsync(
                "0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF"));
        }

        [Fact]
        public void GetCustomProjectMetadata_Validations()
        {
            var client = MetadataClient.Create();
            Assert.Throws<ArgumentException>(() => client.GetCustomProjectMetadata(""));
            Assert.Throws<ArgumentException>(() => client.GetCustomProjectMetadata("a b"));
            Assert.Throws<ArgumentException>(() => client.GetCustomProjectMetadata("a^b"));
            Assert.Throws<ArgumentException>(() => client.GetCustomProjectMetadata(
                "0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF"));

            Assert.ThrowsAsync<ArgumentException>(() => client.GetCustomProjectMetadataAsync(""));
            Assert.ThrowsAsync<ArgumentException>(() => client.GetCustomProjectMetadataAsync("a b"));
            Assert.ThrowsAsync<ArgumentException>(() => client.GetCustomProjectMetadataAsync("a^b"));
            Assert.ThrowsAsync<ArgumentException>(() => client.GetCustomProjectMetadataAsync(
                "0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF0123456789ABCDEF"));
        }

        [Fact]
        public void WaitForChange_Validations()
        {
            var client = MetadataClient.Create();
            Assert.Throws<ArgumentException>(() => client.WaitForChange("a b"));
            Assert.Throws<ArgumentException>(() => client.WaitForChange("a?b"));
            Assert.Throws<ArgumentException>(() => client.WaitForChange("http://www.google.com"));
            Assert.Throws<ArgumentException>(() => client.WaitForChange("instance", lastETag: "bad-etag"));
            Assert.Throws<ArgumentException>(() => client.WaitForChange("instance", timeout: TimeSpan.FromSeconds(-1)));

            Assert.ThrowsAsync<ArgumentException>(() => client.WaitForChangeAsync("a b"));
            Assert.ThrowsAsync<ArgumentException>(() => client.WaitForChangeAsync("a?b"));
            Assert.ThrowsAsync<ArgumentException>(() => client.WaitForChangeAsync("http://www.google.com"));
            Assert.ThrowsAsync<ArgumentException>(() => client.WaitForChangeAsync("instance", lastETag: "bad-etag"));
            Assert.ThrowsAsync<ArgumentException>(() => client.WaitForChangeAsync("instance", timeout: TimeSpan.FromSeconds(-1)));
        }
    }
}
