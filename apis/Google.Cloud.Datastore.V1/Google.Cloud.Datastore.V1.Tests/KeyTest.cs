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
using Xunit;
using static Google.Cloud.Datastore.V1.Key.Types;

namespace Google.Cloud.Datastore.V1.Tests
{
    public class KeyTest
    {
        [Fact]
        public void ToDelete()
        {
            // Not actually a valid key, as there are no path elements, but we're not doing full
            // validation.
            var key = new Key { PartitionId = new PartitionId { ProjectId = "project" } };
            Assert.Equal(new Mutation { Delete = key }, key.ToDelete());
        }

        [Fact]
        public void WithElement()
        {
            var key = new Key
            {
                PartitionId = new PartitionId { ProjectId = "project" },
                Path = { new PathElement { Id = 20L, Kind = "parent" } }
            };
            var keyClone = key.Clone();
            var actual = key.WithElement(new PathElement { Name = "x", Kind = "child" });
            Assert.Equal(keyClone, key); // Original key is unchanged
            var expected = new Key
            {
                PartitionId = new PartitionId { ProjectId = "project" },
                Path =
                {
                    new PathElement { Id = 20L, Kind = "parent" },
                    new PathElement { Name = "x", Kind = "child" }
                }
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetParent_Valid()
        {
            var partitionId = new PartitionId("project", "ns");
            var parent = new Key { PartitionId = partitionId }.WithElement("foo", 0);
            var child = parent.WithElement("bar", 1);
            Assert.Equal(parent, child.GetParent());
        }

        [Fact]
        public void GetParent_Invalid()
        {
            var key = new Key { PartitionId = new PartitionId("project", "ns") };
            Assert.Throws<InvalidOperationException>(() => key.GetParent());
        }

        [Fact]
        public void IsRoot()
        {
            var root = new Key { PartitionId = new PartitionId("project", "ns") };
            var notRoot = root.WithElement("foo", 0);
            Assert.True(root.IsRoot);
            Assert.False(notRoot.IsRoot);
        }
    }
}
