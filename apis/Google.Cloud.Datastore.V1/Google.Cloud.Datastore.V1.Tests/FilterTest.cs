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
using System.Collections;
using System.Collections.Generic;
using Xunit;
using static Google.Cloud.Datastore.V1.PropertyFilter.Types;

namespace Google.Cloud.Datastore.V1.Tests
{
    public class FilterTest
    {
        [Fact]
        public void And()
        {
            var filter1 = Filter.Equal("x", 1);
            var filter2 = Filter.GreaterThan("y", 2);
            var filter3 = Filter.LessThan("z", 3);
            var actual = Filter.And(filter1, filter2, filter3);

            var expected = new Filter
            {
                CompositeFilter = new CompositeFilter
                {
                    Op = CompositeFilter.Types.Operator.And,
                    Filters = { filter1, filter2, filter3 }
                }
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Equal()
        {
            var actual = Filter.Equal("x", 1);
            var expected = new Filter
            {
                PropertyFilter = new PropertyFilter
                {
                    Op = Operator.Equal,
                    Property = new PropertyReference { Name = "x" },
                    Value = new Value { IntegerValue = 1 }
                }
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NotEqual()
        {
            var actual = Filter.NotEqual("x", 1);
            var expected = new Filter
            {
                PropertyFilter = new PropertyFilter
                {
                    Op = Operator.NotEqual,
                    Property = new PropertyReference { Name = "x" },
                    Value = new Value { IntegerValue = 1 }
                }
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NotIn()
        {
            var actual = Filter.NotIn("x", new ArrayValue(new string[2] { "1", "2" }));
            var expected = new Filter
            {
                PropertyFilter = new PropertyFilter
                {
                    Op = Operator.NotIn,
                    Property = new PropertyReference { Name = "x" },
                    Value = new ArrayValue(new string[2] { "1", "2" })
                }
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void In()
        {
            var actual = Filter.In("1", new ArrayValue(new string[2] { "1", "2" }));
            var expected = new Filter
            {
                PropertyFilter = new PropertyFilter
                {
                    Op = Operator.In,
                    Property = new PropertyReference { Name = "1" },
                    Value = new ArrayValue(new string[2] { "1", "2" })
                }
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreaterThan()
        {
            var actual = Filter.GreaterThan("x", 1);
            var expected = new Filter
            {
                PropertyFilter = new PropertyFilter
                {
                    Op = Operator.GreaterThan,
                    Property = new PropertyReference { Name = "x" },
                    Value = new Value { IntegerValue = 1 }
                }
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreaterThanOrEqual()
        {
            var actual = Filter.GreaterThanOrEqual("x", 1);
            var expected = new Filter
            {
                PropertyFilter = new PropertyFilter
                {
                    Op = Operator.GreaterThanOrEqual,
                    Property = new PropertyReference { Name = "x" },
                    Value = new Value { IntegerValue = 1 }
                }
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LessThan()
        {
            var actual = Filter.LessThan("x", 1);
            var expected = new Filter
            {
                PropertyFilter = new PropertyFilter
                {
                    Op = Operator.LessThan,
                    Property = new PropertyReference { Name = "x" },
                    Value = new Value { IntegerValue = 1 }
                }
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LessThanOrEqual()
        {
            var actual = Filter.LessThanOrEqual("x", 1);
            var expected = new Filter
            {
                PropertyFilter = new PropertyFilter
                {
                    Op = Operator.LessThanOrEqual,
                    Property = new PropertyReference { Name = "x" },
                    Value = new Value { IntegerValue = 1 }
                }
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HasAncestor()
        {
            var ancestorKey = new Key { PartitionId = new PartitionId("project", "ns") }.WithElement("author", 1);
            var actual = Filter.HasAncestor(ancestorKey);
            var expected = new Filter
            {
                PropertyFilter = new PropertyFilter
                {
                    Op = Operator.HasAncestor,
                    Property = new PropertyReference { Name = DatastoreConstants.KeyProperty },
                    Value = new Value { KeyValue = ancestorKey }
                }
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Property()
        {
            var actual = Filter.Property("x", 1, Operator.LessThan);
            var expected = new Filter
            {
                PropertyFilter = new PropertyFilter
                {
                    Op = Operator.LessThan,
                    Property = new PropertyReference { Name = "x" },
                    Value = new Value { IntegerValue = 1 }
                }
            };
            Assert.Equal(expected, actual);
        }
    }
}
