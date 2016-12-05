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
using static Google.Cloud.Datastore.V1.Key.Types;

namespace Google.Cloud.Datastore.V1.Tests
{
    public class ArrayValueTest
    {
        [Fact]
        public void SimpleArrayConversions()
        {
            DateTime sampleDateTime = new DateTime(2016, 9, 20, 1, 1, 1, DateTimeKind.Utc);
            Key sampleKey = new Key { PartitionId = new PartitionId("proj", "ns"), Path = { new PathElement("kind", 0L) } };
            ArrayValue sampleArray = new[] { "a", "b" };
            ByteString sampleByteString = ByteString.CopyFrom(1, 2);
            Entity sampleEntity = new Entity();
            LatLng sampleLatLng = new LatLng { Latitude = 1, Longitude = 2 };
            Timestamp sampleTimestamp = Timestamp.FromDateTime(sampleDateTime);
            DateTimeOffset sampleDateTimeOffset = new DateTimeOffset(sampleDateTime, TimeSpan.Zero);

            AssertArrayConversions(new ArrayValue { Values = { "a", "b" } }, new[] { "a", "b" });
            AssertArrayConversions(new ArrayValue { Values = { 1, 2 } }, new long[] { 1, 2 });
            AssertArrayConversions(new ArrayValue { Values = { 1, 2 } }, new long?[] { 1, 2 });
            AssertArrayConversions(new ArrayValue { Values = { sampleKey } }, new Key[] { sampleKey });
            AssertArrayConversions(new ArrayValue { Values = { 1.0, 2.0 } }, new double[] { 1.0, 2.0 });
            AssertArrayConversions(new ArrayValue { Values = { 1.0, 2.0 } }, new double?[] { 1.0, 2.0 });
            AssertArrayConversions(new ArrayValue { Values = { false, true } }, new bool[] { false, true });
            AssertArrayConversions(new ArrayValue { Values = { false, true } }, new bool?[] { false, true });
            AssertArrayConversions(new ArrayValue { Values = { sampleArray } }, new ArrayValue[] { sampleArray });
            AssertArrayConversions(new ArrayValue { Values = { sampleByteString } }, new ByteString[] { sampleByteString });
            AssertArrayConversions(new ArrayValue { Values = { new byte[] { 1, 2 } } }, new byte[][] { new byte[] { 1, 2 } });
            AssertArrayConversions(new ArrayValue { Values = { sampleEntity } }, new Entity[] { sampleEntity });
            AssertArrayConversions(new ArrayValue { Values = { sampleLatLng } }, new LatLng[] { sampleLatLng });
            AssertArrayConversions(new ArrayValue { Values = { sampleTimestamp } }, new Timestamp[] { sampleTimestamp });

            AssertArrayConversions(new ArrayValue { Values = { sampleDateTime } }, new DateTime[] { sampleDateTime });
            AssertArrayConversions(new ArrayValue { Values = { sampleDateTime } }, new DateTime?[] { sampleDateTime });
            AssertArrayConversions(new ArrayValue { Values = { sampleDateTimeOffset } }, new DateTimeOffset[] { sampleDateTime });
            AssertArrayConversions(new ArrayValue { Values = { sampleDateTimeOffset } }, new DateTimeOffset?[] { sampleDateTime });
            AssertArrayConversions(new ArrayValue { Values = { "a", 1, true, Value.ForNull() } }, new Value[] { "a", 1, true, null });
        }

        private static void AssertArrayConversions<T>(ArrayValue arrayValue, T[] input)
        {
            dynamic dynamicInput = input;
            ArrayValue convertedInput = dynamicInput;
            // Test implicit conversion to ArrayValue
            Assert.Equal(arrayValue, convertedInput);

            // Test explicit conversion back to an array
            T[] convertedBack = (T[])(dynamic)arrayValue;
            Assert.Equal(input, convertedBack);

            // Test conversion from array to just Value
            Value singleValue = new Value { ArrayValue = arrayValue };
            Value convertedInputToValue = dynamicInput;
            Assert.Equal(singleValue, convertedInputToValue);

            // Test conversion from Value to array
            convertedBack = (T[])(dynamic)singleValue;
            Assert.Equal(input, convertedBack);
        }

        [Fact]
        public void ConversionToArrayValue_NullInputArray()
        {
            Assert.Null((ArrayValue) (string[]) null);
            Assert.Null((ArrayValue) (long[])null);
            Assert.Null((ArrayValue) (long?[])null);
            Assert.Null((ArrayValue) (Key[])null);
            Assert.Null((ArrayValue) (double[])null);
            Assert.Null((ArrayValue) (double?[])null);
            Assert.Null((ArrayValue) (bool[])null);
            Assert.Null((ArrayValue) (bool?[])null);
            Assert.Null((ArrayValue) (ArrayValue[])null);
            Assert.Null((ArrayValue) (ByteString[])null);
            Assert.Null((ArrayValue) (byte[][])null);
            Assert.Null((ArrayValue) (Entity[])null);
            Assert.Null((ArrayValue) (LatLng[])null);
            Assert.Null((ArrayValue) (Timestamp[])null);
            Assert.Null((ArrayValue) (DateTime[])null);
            Assert.Null((ArrayValue) (DateTime?[])null);
            Assert.Null((ArrayValue) (DateTimeOffset[])null);
            Assert.Null((ArrayValue) (DateTimeOffset?[])null);
            Assert.Null((ArrayValue) (Value[])null);
        }

        [Fact]
        public void ConversionToArrayValue_NullElements()
        {
            Assert.Equal(new ArrayValue { Values = { Value.ForNull(), "b" } }, new[] { null, "b" });
            Assert.Equal(new ArrayValue { Values = { Value.ForNull(), 2 } }, new long?[] { null, 2 });
        }
    }
}
