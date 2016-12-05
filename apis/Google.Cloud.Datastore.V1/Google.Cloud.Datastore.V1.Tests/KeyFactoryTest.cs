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

using Xunit;
using static Google.Cloud.Datastore.V1.Key.Types;

namespace Google.Cloud.Datastore.V1.Tests
{
    public class KeyFactoryTest
    {
        [Fact]
        public void PartitionOnlyFactory()
        {
            var factory = new KeyFactory("project", "ns", "book");
            var actual = factory.CreateKey(10L);
            var expected = new Key
            {
                PartitionId = new PartitionId { ProjectId = "project", NamespaceId = "ns" },
                Path = { new PathElement { Id = 10L, Kind = "book" } }
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FactoryFromKey()
        {
            var parentKey = new Key
            {
                PartitionId = new PartitionId { ProjectId = "project", NamespaceId = "ns" },
                Path = { new PathElement { Id = 10L, Kind = "author" } }
            };
            var factory = new KeyFactory(parentKey, "book");
            var actual = factory.CreateKey("subkey-name");
            var expected = new Key
            {
                PartitionId = new PartitionId { ProjectId = "project", NamespaceId = "ns" },
                Path = {
                    new PathElement { Id = 10L, Kind = "author" },
                    new PathElement { Name = "subkey-name", Kind = "book" }
                }
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FactoryFromEntity()
        {
            var parentKey = new Key
            {
                PartitionId = new PartitionId { ProjectId = "project", NamespaceId = "ns" },
                Path = { new PathElement { Id = 10L, Kind = "author" } }
            };
            var book = new Entity { Key = parentKey };
            var factory = new KeyFactory(book, "book");
            var actual = factory.CreateKey(20L);
            var expected = new Key
            {
                PartitionId = new PartitionId { ProjectId = "project", NamespaceId = "ns" },
                Path = {
                    new PathElement { Id = 10L, Kind = "author" },
                    new PathElement { Id = 20L, Kind = "book" }
                }
            };
            Assert.Equal(expected, actual);
        }
    }
}
