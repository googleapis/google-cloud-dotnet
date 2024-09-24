// Copyright 2018, Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.Firestore.V1;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static Google.Cloud.Firestore.Tests.ProtoHelpers;

namespace Google.Cloud.Firestore.Tests
{
    public class ValueComparerTest
    {
        // Taken from OrderTest.java, with a few extra tests.
        // These are compared pairwise.
        private static readonly dynamic[] s_valuesInOrder =
        {
            // Null
            CreateNullValue(),

            // Booleans
            false,
            true,

            // Numbers
            double.NaN,
            double.NegativeInfinity,
            double.MinValue,
            long.MinValue,
            int.MinValue,
            -1.1,
            -1L,
            0L,
            double.Epsilon,
            0.1,
            1L,
            1.1,
            int.MaxValue,
            long.MaxValue,
            double.MaxValue,
            double.PositiveInfinity,

            // Timestamps
            new Timestamp(123, 0),
            new Timestamp(123, 123),
            new Timestamp(345, 0),

            // Strings
            "",
            "\u0000\ud7ff\ue000\uffff",
            "(╯°□°）╯︵ ┻━┻",
            "AB",
            // Longer strings later
            "ABC",
            // Case-sensitive, by ordinal - lower-case ASCII comes after upper-case ASCII
            "a",
            "abc def",
            // Latin small letter e + combining acute accent + latin small letter b
            "e\u0301b",
            "æ",
            // Latin small letter e with acute accent + latin small letter a
            "\u00e9a",
            // Surrogate pair (verdigris)
            "\U0001F728",
            // Note: positioning of this after the surrogate pair is due to using UTF-16
            // rather than UTF-8 as per the Firestore spec. This mirrors the Java behavior,
            // but we may well want to fix it at some point
            "\ue000",

            new Blob(),
            Blob.CopyFrom(new byte[] { 0 }),
            Blob.CopyFrom(new byte[] { 0, 1, 2, 3, 4 }),
            Blob.CopyFrom(new byte[] { 0, 1, 2, 4, 3 }),
            Blob.CopyFrom(new byte[] { 127 }),

            // Resource names
            CreateReference("projects/p1/databases/d1/documents/c1/doc1"),
            CreateReference("projects/p1/databases/d1/documents/c1/doc2"),
            CreateReference("projects/p1/databases/d1/documents/c1/doc2/c2/doc1"),
            CreateReference("projects/p1/databases/d1/documents/c1/doc2/c2/doc2"),
            CreateReference("projects/p1/databases/d1/documents/c10/doc1"),
            CreateReference("projects/p1/databases/dkkkkklkjnjkkk1/documents/c2/doc1"),
            CreateReference("projects/p2/databases/d2/documents/c1/doc1"),
            CreateReference("projects/p2/databases/d2/documents/c1-/doc1"),

            // Geopoints
            new GeoPoint(-90, -180),
            new GeoPoint(-90, 0),
            new GeoPoint(-90, 180),
            new GeoPoint(0, -180),
            new GeoPoint(0, 0),
            new GeoPoint(0, 180),
            new GeoPoint(1, -180),
            new GeoPoint(1, 0),
            new GeoPoint(1, 180),
            new GeoPoint(90, -180),
            new GeoPoint(90, 0),
            new GeoPoint(90, 180),

            // Arrays
            CreateArray(),
            CreateArray(CreateValue("bar")),
            CreateArray(CreateValue("foo")),
            CreateArray(CreateValue("foo"), CreateValue(0)),
            CreateArray(CreateValue("foo"), CreateValue(1)),
            CreateArray(CreateValue("foo"), CreateValue("0")),

            // Objects
            CreateMap("bar", CreateValue(0)),
            CreateMap(("bar", CreateValue(0)), ("foo", CreateValue(1))),
            CreateMap("bar", CreateValue(1)),
            CreateMap("bar", CreateValue(2)),
            CreateMap("bar", CreateValue("0")),
        };

        public static IEnumerable<object[]> Values => s_valuesInOrder.Select(x => new object[] { x });

        // Each group has equal values.
        public static TheoryData<IEnumerable<dynamic>> EqualityGroups { get; } = new TheoryData<IEnumerable<dynamic>>
        {
            new dynamic[] { 0, -0.0, 0.0 },
            new dynamic[] { 1, 1.0 },
        };

        // While this *could* be implemented as a Theory, we end up with such a huge number of
        // tests that it makes any test report hard to read.

        [Fact]
        public void Compare_Unequal()
        {
            var instance = ValueComparer.Instance;

            for (int i = 0; i < s_valuesInOrder.Length - 1; i++)
            {
                dynamic smaller = s_valuesInOrder[i];
                Value smallerValue = ProtoHelpers.CreateValue(smaller);
                for (int j = i + 1; j < s_valuesInOrder.Length; j++)
                {
                    dynamic larger = s_valuesInOrder[j];
                    Value largerValue = ProtoHelpers.CreateValue(larger);

                    Assert.InRange(instance.Compare(smallerValue, largerValue), int.MinValue, -1);
                    Assert.InRange(instance.Compare(largerValue, smallerValue), 1, int.MaxValue);
                }
            }
        }

        [Theory, MemberData(nameof(Values))]
        public void Compare_WithSelf(dynamic clrValue)
        {
            var instance = ValueComparer.Instance;
            Value value1 = ProtoHelpers.CreateValue(clrValue);
            Value value2 = ProtoHelpers.CreateValue(clrValue);
            Assert.Equal(0, instance.Compare(value1, value2));
        }

        [Theory, MemberData(nameof(EqualityGroups))]
        public void Compare_EqualValues(IEnumerable<dynamic> clrValues)
        {
            var instance = ValueComparer.Instance;
            Value[] values = clrValues.Select(d => (Value) ProtoHelpers.CreateValue(d)).ToArray();
            for (int i = 0; i < values.Length - 1; i++)
            {
                for (int j = i + 1; j < values.Length; j++)
                {
                    Assert.Equal(0, instance.Compare(values[i], values[j]));
                }
            }
        }

        [Fact]
        public void Compare_LossOfPrecision()
        {
            // Just to demonstrate that we lose precision when comparing a double with a long
            Value value1 = ProtoHelpers.CreateValue(long.MaxValue); // Represented precisely
            Value value2 = ProtoHelpers.CreateValue(long.MaxValue - 1.0); // Precision lost

            Assert.Equal(0, ValueComparer.Instance.Compare(value1, value2));
        }
    }
}
