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

using System;
using System.Linq;
using Xunit;
using BclType = System.Type;

namespace Google.Cloud.Firestore.Tests
{
    public class FirestoreDataAttributedTypeTest
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
            var exception = Assert.Throws<InvalidOperationException>(() => FirestoreDataAttributedType.ForType(type));
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
        public void ReadableProperties()
        {
            var attributedType = FirestoreDataAttributedType.ForType(typeof(Model));
            var properties = attributedType.ReadableProperties.ToDictionary(p => p.FirestoreName);

            Assert.Equal(
                new[] { nameof(Model.Created), nameof(Model.ReadOnly), nameof(Model.ReadWrite), "Separated" },
                properties.Keys.OrderBy(x => x));

            var sample = new Model { ReadWrite = 50, SeparatedBackingProperty = 100, Created = Timestamp.FromDateTime(DateTime.UtcNow) };
            Assert.Equal(sample.ReadOnly, properties[nameof(sample.ReadOnly)].GetValue(sample));
            Assert.Equal(sample.ReadWrite, properties[nameof(sample.ReadWrite)].GetValue(sample));
            Assert.Equal(sample.SeparatedBackingProperty, properties["Separated"].GetValue(sample));
            // Even though it's a sentinel, we can still read the actual value.
            Assert.Equal(sample.Created, properties[nameof(sample.Created)].GetValue(sample));

            Assert.Null(properties[nameof(sample.ReadWrite)].SentinelValue);
            Assert.Same(SentinelValue.ServerTimestamp, properties[nameof(sample.Created)].SentinelValue);
        }

        [Fact]
        public void WritableProperties()
        {
            var attributedType = FirestoreDataAttributedType.ForType(typeof(Model));
            var properties = attributedType.WritableProperties;

            Assert.Equal(
                new[] { nameof(Model.Created), nameof(Model.ReadWrite), "Separated", nameof(Model.WriteOnly) },
                properties.Keys.OrderBy(x => x));

            var sample = new Model();
            var now = Timestamp.FromDateTime(DateTime.UtcNow);
            properties[nameof(sample.Created)].SetValue(sample, now);
            properties[nameof(sample.ReadWrite)].SetValue(sample, 50);
            properties["Separated"].SetValue(sample, 100);
            properties[nameof(sample.WriteOnly)].SetValue(sample, 200);

            Assert.Equal(50, sample.ReadWrite);
            Assert.Equal(100, sample.SeparatedBackingProperty);
            Assert.Equal(200, sample.WriteOnlyBackingProperty);
            Assert.Equal(now, sample.Created);
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

            var attributedType = FirestoreDataAttributedType.ForType(typeof(ModelDerived));
            var properties = attributedType.ReadableProperties.ToDictionary(p => p.FirestoreName);

            Assert.Equal(
                new[] { nameof(sample.Abstract), nameof(sample.BaseOnly), nameof(sample.DerivedOnly) },
                properties.Keys.OrderBy(x => x));

            Assert.Equal(sample.Abstract, properties[nameof(sample.Abstract)].GetValue(sample));
            Assert.Equal(sample.BaseOnly, properties[nameof(sample.BaseOnly)].GetValue(sample));
            Assert.Equal(sample.DerivedOnly, properties[nameof(sample.DerivedOnly)].GetValue(sample));
        }
    }
}
