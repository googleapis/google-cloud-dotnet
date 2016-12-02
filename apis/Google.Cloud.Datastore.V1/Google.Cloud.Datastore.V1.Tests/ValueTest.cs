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

using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Google.Type;
using System;
using Xunit;

namespace Google.Cloud.Datastore.V1.Tests
{
    public class ValueTest
    {
        [Fact]
        public void ConversionsToValue_Null()
        {
            Assert.Null((Value)(string)null);
            Assert.Null((Value)(long?)null);
            Assert.Null((Value)(Key)null);
            Assert.Null((Value)(double?)null);
            Assert.Null((Value)(bool?)null);
            Assert.Null((Value)(ArrayValue)null);
            Assert.Null((Value)(ByteString)null);
            Assert.Null((Value)(byte[])null);
            Assert.Null((Value)(Entity)null);
            Assert.Null((Value)(LatLng)null);
            Assert.Null((Value)(Timestamp)null);
            Assert.Null((Value)(DateTime?)null);
            Assert.Null((Value)(DateTimeOffset?)null);
        }

        [Fact]
        public void ConversionsToValue_NonNull()
        {
            Assert.Equal(new Value { StringValue = "foo" }, (Value)"foo");
            Assert.Equal(new Value { IntegerValue = 5 }, (Value) 5L);
            Assert.Equal(new Value { IntegerValue = 5 }, (Value) (long?) 5L);
            Assert.Equal(new Value { KeyValue = new Key { PartitionId = new PartitionId { ProjectId = "foo" } } },
                (Value) new Key { PartitionId = new PartitionId { ProjectId = "foo" } });
            Assert.Equal(new Value { DoubleValue = 1.5 }, (Value)1.5);
            Assert.Equal(new Value { DoubleValue = 1.5 }, (Value)(double?)1.5);
            Assert.Equal(new Value { BooleanValue = true }, (Value) true);
            Assert.Equal(new Value { BooleanValue = true}, (Value)(bool?)true);
            // Just to prove the "default" of false doesn't interfere...
            Assert.Equal(new Value { BooleanValue = false }, (Value)false);
            Assert.Equal(new Value { ArrayValue = new ArrayValue { Values = { "foo", "bar" } } },
                (Value) new ArrayValue { Values = { "foo", "bar" } });
            Assert.Equal(new Value { BlobValue = ByteString.CopyFromUtf8("foo")}, (Value)ByteString.CopyFromUtf8("foo"));
            Assert.Equal(new Value { BlobValue = ByteString.CopyFrom(new byte[] { 1, 2 }) }, (Value)new byte[] { 1, 2 });
            Assert.Equal(new Value { EntityValue = new Entity { Properties = { { "key", "value" } } } },
                (Value)new Entity { Properties = { { "key", "value" } } });
            Assert.Equal(new Value { GeoPointValue = new LatLng { Latitude = 5.0, Longitude = 2.5 } },
                (Value)new LatLng { Latitude = 5.0, Longitude = 2.5 });
            var dateTime = DateTime.UtcNow;
            Assert.Equal(new Value { TimestampValue = Timestamp.FromDateTime(dateTime) }, (Value)Timestamp.FromDateTime(dateTime));
            Assert.Equal(new Value { TimestampValue = Timestamp.FromDateTime(dateTime) }, (Value)dateTime);
            Assert.Equal(new Value { TimestampValue = Timestamp.FromDateTime(dateTime) }, new DateTimeOffset(dateTime));
        }

        [Fact]
        public void ConversionsFromValue_NullReference()
        {
            Value value = null;
            Assert.Null((string)value);
            Assert.Null((long?)value);
            Assert.Null((Key)value);
            Assert.Null((double?)value);
            Assert.Null((bool?)value);
            Assert.Null((ArrayValue)value);
            Assert.Null((ByteString)value);
            Assert.Null((byte[])value);
            Assert.Null((Entity)value);
            Assert.Null((LatLng)value);
            Assert.Null((Timestamp)value);
            Assert.Null((DateTime?)value);
            Assert.Null((DateTimeOffset?)value);
        }

        [Fact]
        public void ConversionsFromValue_NullValue()
        {
            Value value = new Value { NullValue = NullValue.NullValue };
            Assert.Null((string)value);
            Assert.Null((long?)value);
            Assert.Null((Key)value);
            Assert.Null((double?)value);
            Assert.Null((bool?)value);
            Assert.Null((ArrayValue)value);
            Assert.Null((ByteString)value);
            Assert.Null((byte[])value);
            Assert.Null((Entity)value);
            Assert.Null((LatLng)value);
            Assert.Null((Timestamp)value);
            Assert.Null((DateTime?)value);
            Assert.Null((DateTimeOffset?)value);
        }

        [Fact]
        public void ConversionsFromValue_CheckType()
        {
            // Just a small sample
            Value value = "text";
            // Calls to ToString are just so that it's a valid statement
            Assert.Throws<InvalidOperationException>(() => ((long?)value).ToString());
            Assert.Throws<InvalidOperationException>(() => ((double?)value).ToString());
            Assert.Throws<InvalidOperationException>(() => ((bool)value).ToString());
            Assert.Throws<InvalidOperationException>(() => ((Key)value).ToString());
            Assert.Throws<InvalidOperationException>(() => ((Entity)value).ToString());

            // More dubious - should we be able to convert here? Not if we think of it
            // as being like unboxing...
            value = 5;
            Assert.Throws<InvalidOperationException>(() => ((double?)value).ToString());
        }

        [Fact]
        public void ForNull()
        {
            Assert.Equal(new Value { NullValue = 0 }, Value.ForNull());
        }

        [Fact]
        public void OrNull()
        {
            Assert.Null(new Value { NullValue = 0 }.OrNull());
            Assert.Null(((Value) null).OrNull());
            Value nonNull = new Value { StringValue = "" };
            Assert.Same(nonNull, nonNull.OrNull());
        }

        [Fact]
        public void IsNull()
        {
            Assert.True(new Value { NullValue = 0 }.IsNull);
            Assert.False(new Value { StringValue = "" }.IsNull);
        }

        [Fact]
        public void DirectArrayConversion_ToValue()
        {
            Value value = new[] { "foo", "bar" };
            Assert.Equal(new Value { ArrayValue = new ArrayValue { Values = { "foo", "bar" } } }, value);
        }

        [Fact]
        public void DirectArrayConversion_FromValue()
        {
            Value value = new Value { ArrayValue = new ArrayValue { Values = { "foo", "bar" } } };
            var array = (string[])value;
            Assert.Equal(new[] { "foo", "bar" }, array);
        }
    }
}
