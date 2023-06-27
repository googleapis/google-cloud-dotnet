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

using Google.Cloud.Firestore.Converters;
using Google.Cloud.Firestore.V1;
using System;
using System.Collections.Generic;
using Xunit;
using BclType = System.Type;
using static Google.Cloud.Firestore.Tests.DocumentSnapshotHelpers;

namespace Google.Cloud.Firestore.Tests.Converters
{
    public class AttributedTypeConverterTest
    {
        private class NotAttributed { }

        [FirestoreData((UnknownPropertyHandling)100)]
        private class InvalidUnknownPropertyHandling { }

        [FirestoreData]
        private class DuplicateReadableProperties
        {
            [FirestoreProperty] public int Foo { get; } = 1;
            [FirestoreProperty("Foo")] public int Bar { get; } = 2;
        }

        [FirestoreData]
        private class DuplicateWritableProperties
        {
            private int _field;
            [FirestoreProperty] public int Foo { set => _field = value; }
            [FirestoreProperty("Foo")] public int Bar { set => _field = value; }
        }

        [FirestoreData]
        private class StaticReadableProperty
        {
            [FirestoreProperty] public static int Foo { get; } = 1;
        }

        [FirestoreData]
        private class StaticWritableProperty
        {
            private static int _field;
            [FirestoreProperty] public static int Foo { set => _field = value; }
        }

        [FirestoreData]
        private class Indexer
        {
            [FirestoreProperty] public int this[string index] => 0;
        }

        [FirestoreData]
        private class NoParameterlessConstructor
        {
            [FirestoreProperty] public int Foo { get; set; }

            public NoParameterlessConstructor(int foo) => Foo = foo;
        }

        public static TheoryData<BclType, string> InvalidTypes = new TheoryData<BclType, string>
        {
            { typeof(NotAttributed), nameof(FirestoreDataAttribute) },
            { typeof(InvalidUnknownPropertyHandling), nameof(UnknownPropertyHandling) },
            { typeof(DuplicateReadableProperties), "Foo" },
            { typeof(DuplicateWritableProperties), "Foo" },
            { typeof(StaticReadableProperty), "static" },
            { typeof(StaticWritableProperty), "static" },
            { typeof(Indexer), "indexer" },
            { typeof(NoParameterlessConstructor), "constructor" }
        };

        [Theory, MemberData(nameof(InvalidTypes))]
        public void InvalidAttributedType(BclType type, string expectedErrorSubstring)
        {
            var exception = Assert.Throws<InvalidOperationException>(() => AttributedTypeConverter.ForType(type));
            Assert.Contains(expectedErrorSubstring, exception.Message);
        }

        [FirestoreData]
        private class Model
        {
            [FirestoreProperty]
            public int ReadOnly { get; } = 20;

            [FirestoreProperty]
            public int ReadWrite { get; set; }

            [FirestoreProperty]
            public int WriteOnly { set => WriteOnlyBackingProperty = value; }

            // Not attributed; used as storage for WriteOnly
            public int WriteOnlyBackingProperty { get; set; }

            // Two properties represented the same way in Firestore, but via separate CLR properties.
            // These also demonstrate that private properties are picked up.
            [FirestoreProperty("Separated")]
            private int SeparatedReadable => SeparatedBackingProperty;
            [FirestoreProperty("Separated")]
            private int SeparatedWritable { set => SeparatedBackingProperty = value; }

            // Not attributed; used as storage for SeparatedReadable and SeparatedWritable
            public int SeparatedBackingProperty { get; set; }

            [FirestoreProperty, ServerTimestamp]
            public Timestamp Created { get; set; }
        }
        
        [Fact]
        public void SerializeMap()
        {
            var converter = AttributedTypeConverter.ForType(typeof(Model));
            var sample = new Model { ReadWrite = 50, SeparatedBackingProperty = 100, Created = Timestamp.FromDateTime(DateTime.UtcNow) };
            var result = converter.Serialize(SerializationContext.Default, sample).MapValue.Fields;

            Assert.Equal(new Value { IntegerValue = 20 }, result["ReadOnly"]);
            Assert.Equal(new Value { IntegerValue = 50 }, result["ReadWrite"]);
            Assert.Equal(new Value { IntegerValue = 100 }, result["Separated"]);
            Assert.Equal(SentinelValue.ServerTimestamp.ToProtoValue(), result["Created"]);
        }

        [Fact]
        public void DeserializeMap()
        {
            var converter = AttributedTypeConverter.ForType(typeof(Model));

            var now = Timestamp.FromDateTime(DateTime.UtcNow);
            var map = new Dictionary<string, Value>
            {
                { "Created", new Value { TimestampValue = now.ToProto() } },
                { "ReadWrite", new Value { IntegerValue = 50 } },
                { "Separated", new Value { IntegerValue = 100 } },
                { "WriteOnly", new Value { IntegerValue = 200 } },
            };
            var db = FirestoreDb.Create("project", "database", new FakeFirestoreClient());
            var snapshot = GetSampleSnapshot(db, "doc1");
            Model model = (Model) converter.DeserializeMap(snapshot, map);
            Assert.Equal(now, model.Created);
            Assert.Equal(50, model.ReadWrite);
            Assert.Equal(100, model.SeparatedBackingProperty);
            Assert.Equal(200, model.WriteOnlyBackingProperty);
        }

        private abstract class ModelBase
        {
            [FirestoreProperty]
            public int BaseOnly { get; set; }

            [FirestoreProperty]
            public abstract int Abstract { get; set; }
        }

        [FirestoreData]
        private class ModelDerived : ModelBase
        {
            // Note: no attribute here
            public override int Abstract { get; set; }

            [FirestoreProperty]
            public int DerivedOnly { get; set; }
        }

        [Fact]
        public void InheritedProperties()
        {
            // Only testing that we can read properties - there's nothing inheritance-specific
            // in terms of the difference between reading and writing.
            var sample = new ModelDerived
            {
                Abstract = 1,
                BaseOnly = 2,
                DerivedOnly = 3
            };

            var converter = AttributedTypeConverter.ForType(typeof(ModelDerived));
            var result = converter.Serialize(SerializationContext.Default, sample).MapValue.Fields;
            Assert.Equal(new Value { IntegerValue = 1 }, result["Abstract"]);
            Assert.Equal(new Value { IntegerValue = 2 }, result["BaseOnly"]);
            Assert.Equal(new Value { IntegerValue = 3 }, result["DerivedOnly"]);
        }
    }
}
