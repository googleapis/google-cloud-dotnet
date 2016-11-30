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
using static Google.Cloud.Datastore.V1.PropertyOrder.Types;

namespace Google.Cloud.Datastore.V1.Tests
{
    public class QueryTest
    {
        [Fact]
        public void Constructor()
        {
            Assert.Equal(new Query { Kind = { new KindExpression("kind") } }, new Query("kind"));
        }

        [Fact]
        public void Orderings()
        {
            var expected = new Query
            {
                Order =
                {
                    new PropertyOrder { Property = new PropertyReference("prop1"), Direction = Direction.Ascending },
                    new PropertyOrder { Property = new PropertyReference("prop2"), Direction = Direction.Descending }
                }
            };
            var actual = new Query { Order = { "prop1", { "prop2", Direction.Descending } } };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Projection()
        {
            var expected = new Query { Projection = { new Projection("prop1"), new Projection("prop2") } };
            var actual = new Query { Projection = { "prop1", "prop2" } };
            Assert.Equal(expected, actual);
        }
    }
}
