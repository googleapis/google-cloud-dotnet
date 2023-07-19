// Copyright 2019, Google LLC
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
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static Google.Cloud.Firestore.Tests.DocumentSnapshotHelpers;

namespace Google.Cloud.Firestore.Tests.Converters
{
    // Note: these tests are relatively low-level; more "integration" tests
    // are in ValueSerializerTest/ValueDeserializerTest via SerializationTestData.TupleModel
    public class ValueTupleConverterTest
    {
        private static readonly FirestoreDb s_db = new FirestoreDbBuilder
        {
            CallInvoker = new ThrowingInvoker(),
            ConverterRegistry = new ConverterRegistry
            {
                new CustomGuidConverter()
            },
            ProjectId = "test"
        }.Build();

        private static SerializationContext SerializationContext => s_db.SerializationContext;
        private static IDeserializationContext DeserializationContext => GetSampleSnapshot(s_db, "doc1");

        private static readonly object[] s_sampleValuesByArity =
        {
            null,
            null,
            (1, 2),
            (1, 2, 3),
            (1, 2, 3, 4),
            (1, 2, 3, 4, 5),
            (1, 2, 3, 4, 5, 6),
            (1, 2, 3, 4, 5, 6, 7)
        };

        [Theory, CombinatorialData]
        public void SimpleProperties_Serialize([CombinatorialValues(2, 3, 4, 5, 6, 7)] int arity)
        {
            var property = typeof(PropertyHolder).GetProperty($"Tuple{arity}");
            var converter = ValueTupleConverter.MaybeCreateConverter(property);
            Assert.NotNull(converter);
            var actualProtoValue = converter.Serialize(SerializationContext, s_sampleValuesByArity[arity]);
            var expectedProtoValue = new Value
            {
                MapValue = new MapValue
                {
                    Fields = { { Enumerable.Range(1, arity).ToDictionary(x => $"v{x}", x => new Value { IntegerValue = x }) } }
                }
            };
            Assert.Equal(expectedProtoValue, actualProtoValue);
        }

        [Theory, CombinatorialData]
        public void SimpleProperties_DeserializeMap([CombinatorialValues(2, 3, 4, 5, 6, 7)] int arity)
        {
            var property = typeof(PropertyHolder).GetProperty($"Tuple{arity}");
            var converter = ValueTupleConverter.MaybeCreateConverter(property);
            Assert.NotNull(converter);
            var map = Enumerable.Range(1, arity).ToDictionary(x => $"v{x}", x => new Value { IntegerValue = x });
            var actualTupleValue = converter.DeserializeMap(DeserializationContext, map);
            var expectedTupleValue = s_sampleValuesByArity[arity];
            Assert.Equal(expectedTupleValue, actualTupleValue);
        }

        [Fact]
        public void Nullable()
        {
            // The converter will never be provided with a null value; that's handled elsewhere.
            // But we need to make sure the nullability is swallowed, effectively.
            var property = typeof(PropertyHolder).GetProperty(nameof(PropertyHolder.NullableTuple2));
            var converter = ValueTupleConverter.MaybeCreateConverter(property);
            Assert.NotNull(converter);

            var map = new Dictionary<string, Value>
            {
                { "name", new Value { StringValue = "abc" } },
                { "value", new Value { IntegerValue = 42 } }
            };

            (string name, int value) tuple = ((string, int)) converter.DeserializeMap(DeserializationContext, map);
            Assert.Equal("abc", tuple.name);
            Assert.Equal(42, tuple.value);

            var serialized = converter.Serialize(SerializationContext, tuple);
            Assert.Equal(map, serialized.MapValue.Fields);
        }

        [Fact]
        public void CustomConversion()
        {
            var property = typeof(PropertyHolder).GetProperty(nameof(PropertyHolder.TupleWithGuid));
            var converter = ValueTupleConverter.MaybeCreateConverter(property);
            Assert.NotNull(converter);

            var tuple = (name: "xyz", guid: Guid.NewGuid());
            var serialized = converter.Serialize(SerializationContext, tuple);

            var expected = new Dictionary<string, Value>
            {
                { "name", new Value { StringValue = "xyz" } },
                { "guid", new Value { StringValue = $"{CustomGuidConverter.Prefix}{tuple.guid}" } }
            };
            Assert.Equal(expected, serialized.MapValue.Fields);

            Assert.Equal(tuple, converter.DeserializeValue(DeserializationContext, serialized));
        }

        [Theory]
        [InlineData(nameof(PropertyHolder.ListTuple2))]
        [InlineData(nameof(PropertyHolder.Tuple8))]
        [InlineData(nameof(PropertyHolder.NotATuple))]
        public void InvalidProperty(string propertyName)
        {
            var property = typeof(PropertyHolder).GetProperty(propertyName);
            Assert.Null(ValueTupleConverter.MaybeCreateConverter(property));
        }

        public class PropertyHolder
        {
            // Valid properties
            public (int v1, int v2) Tuple2 { get; set; }
            public (int v1, int v2, int v3) Tuple3 { get; set; }
            public (int v1, int v2, int v3, int v4) Tuple4 { get; set; }
            public (int v1, int v2, int v3, int v4, int v5) Tuple5 { get; set; }
            public (int v1, int v2, int v3, int v4, int v5, int v6) Tuple6 { get; set; }
            public (int v1, int v2, int v3, int v4, int v5, int v6, int v7) Tuple7 { get; set; }

            public (string name, int value)? NullableTuple2 { get; set; }
            public (string name, Guid guid) TupleWithGuid { get; set; }

            // Invalid properties (in terms of this converter)
            public List<(int v1, int v2)> ListTuple2 { get; set; }
            public (int v1, int v2, int v3, int v4, int v5, int v6, int v7, int v8) Tuple8 { get; set; }
            public string NotATuple { get; set; }
        }

        private class ThrowingInvoker : CallInvoker
        {
            public override AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options) =>
                throw new NotImplementedException();

            public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options) =>
                throw new NotImplementedException();

            public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request) =>
                throw new NotImplementedException();

            public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request) =>
                throw new NotImplementedException();

            public override TResponse BlockingUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request) =>
                throw new NotImplementedException();
        }

        /// <summary>
        /// Custom converter to check that the tuple converter integrates well with custom converters.
        /// </summary>
        private class CustomGuidConverter : IFirestoreConverter<Guid>
        {
            internal const string Prefix = "custom:";

            public Guid FromFirestore(object value)
            {
                string text = (string) value;
                Assert.StartsWith(Prefix, text);
                return Guid.Parse(text.Substring(Prefix.Length));
            }

            public object ToFirestore(Guid value) => $"{Prefix}{value}";
        }
    }
}
