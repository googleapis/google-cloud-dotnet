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

namespace Google.Cloud.Datastore.V1.Tests
{
    public class EntityTest
    {
        [Fact]
        public void IndexerGet_PresentPropertyReturnsValue()
        {
            var entity = new Entity { Properties = { { "key", "value" } } };
            Assert.Equal("value", entity["key"]);
        }

        [Fact]
        public void IndexerGet_MissingPropertyReturnsNull()
        {
            var entity = new Entity { Properties = { { "key", "value" } } };
            Assert.Null(entity["missing"]);
        }

        [Fact]
        public void IndexerSet_NonNullValue()
        {
            var actual = new Entity { ["key"] = "value" };
            var expected = new Entity { Properties = { { "key", "value" } } };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IndexerSet_NullValue()
        {
            var actual = new Entity
            {
                ["key"] = "value",
                ["deleteme"] = 10
            };
            actual["deleteme"] = null;
            actual["missing"] = null; // Just validate that if it's not there, nothing goes wrong...
            var expected = new Entity { Properties = { { "key", "value" } } };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Mutations_WithKey()
        {
            // Not actually a valid key, as there are no path elements, but we're not doing full
            // validation.
            var key = new Key { PartitionId = new PartitionId { ProjectId = "project" } };
            var entity = new Entity { Key = key, Properties = { { "key", "value" } } };
            Assert.Equal(new Mutation { Insert = entity }, entity.ToInsert());
            Assert.Equal(new Mutation { Update = entity }, entity.ToUpdate());
            Assert.Equal(new Mutation { Upsert = entity }, entity.ToUpsert());
            Assert.Equal(new Mutation { Delete = key }, entity.ToDelete());
        }

        [Fact]
        public void Mutations_NoKey()
        {
            var entity = new Entity { Properties = { { "key", "value" } } };
            Assert.Throws<InvalidOperationException>(() => entity.ToInsert());
            Assert.Throws<InvalidOperationException>(() => entity.ToUpdate());
            Assert.Throws<InvalidOperationException>(() => entity.ToUpsert());
            Assert.Throws<InvalidOperationException>(() => entity.ToDelete());
        }

        [Fact]
        public void ArrayProperties()
        {
            // Demonstrating three ways of specifying arrays as entity properties
            var variant1 = new Entity
            {
                ["tags"] = new[] { "a", "b", "c" }
            };

            var variant2 = new Entity
            {
                ["tags"] = new ArrayValue { Values = { "a", "b", "c" } }
            };

            Assert.Equal(variant1, variant2);

            // ... and pulling them out again.
            string[] tags = (string[])variant1["tags"];
            Assert.Equal(new[] { "a", "b", "c" }, tags);
        }
    }
}
