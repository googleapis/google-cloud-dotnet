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

using static Google.Cloud.Firestore.Tests.DocumentSnapshotHelpers;

namespace Google.Cloud.Firestore.Tests.Converters
{
    /// <summary>
    /// Tests for CustomConverter, mostly for error checking. Most tests for custom serialization
    /// are in <see cref="ValueSerializerTest"/> and <see cref="ValueDeserializerTest"/>.
    /// </summary>
    public class CustomConverterTest
    {
        [Fact]
        public void NullReturnsProhibited()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var context = new DeserializationContext(GetSampleSnapshot(db, "doc1"));
            var converter = CustomConverter.ForConverterType(typeof(NullReturningConverter), typeof(string));
            Assert.Throws<InvalidOperationException>(() => converter.Serialize(SerializationContext.Default, ""));
            Assert.Throws<InvalidOperationException>(() => converter.SerializeMap(SerializationContext.Default, "", new Dictionary<string, Value>()));
            Assert.Throws<InvalidOperationException>(() => converter.DeserializeValue(context, new Value { StringValue = "" }));
            Assert.Throws<InvalidOperationException>(() => converter.DeserializeMap(context, new Dictionary<string, Value>()));
        }

        [Fact]
        public void InvalidConverterType()
        {
            Assert.Throws<InvalidOperationException>(() => CustomConverter.ForConverterType(typeof(NullReturningConverter), typeof(int)));
        }

        [Fact]
        public void DeserializeMap_ServerReturnedProperties()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var context = new DeserializationContext(GetSampleSnapshot(db, "doc1"));
            context.DocumentSnapshot.Document.Fields["doc-field"] = ProtoHelpers.CreateValue("FieldValue");
            var converter = CustomConverter.ForConverterType(typeof(DictionaryHolderConverter), typeof(DictionaryHolder));
            var holder = (DictionaryHolder) converter.DeserializeMap(context, context.DocumentSnapshot.Document.Fields);
            var dictionary = holder.Dictionary;
            // The regular field deserialized from the document
            Assert.Equal("FieldValue", dictionary["doc-field"]);

            // The server-provided values
            Assert.Equal(context.DocumentReference, dictionary["DocumentId"]);
            Assert.Equal(context.DocumentSnapshot.CreateTime, dictionary["CreateTime"]);
            Assert.Equal(context.DocumentSnapshot.UpdateTime, dictionary["UpdateTime"]);
            Assert.Equal(context.DocumentSnapshot.ReadTime, dictionary["ReadTime"]);
        }

        [Fact]
        public void DeserializeValue_WhenMap_ServerReturnedProperties()
        {
            var db = FirestoreDb.Create("proj", "db", new FakeFirestoreClient());
            var context = new DeserializationContext(GetSampleSnapshot(db, "doc1"));
            var value = ProtoHelpers.CreateMap(("key1", ProtoHelpers.CreateValue("value1")), ("key2", ProtoHelpers.CreateValue("value2")));
            var converter = CustomConverter.ForConverterType(typeof(DictionaryHolderConverter), typeof(DictionaryHolder));
            var holder = (DictionaryHolder) converter.DeserializeValue(context, value);
            var dictionary = holder.Dictionary;
            // The regular fields deserialized from the map
            Assert.Equal("value1", dictionary["key1"]);
            Assert.Equal("value2", dictionary["key2"]);

            // The server-provided values
            Assert.Equal(context.DocumentReference, dictionary["DocumentId"]);
            Assert.Equal(context.DocumentSnapshot.CreateTime, dictionary["CreateTime"]);
            Assert.Equal(context.DocumentSnapshot.UpdateTime, dictionary["UpdateTime"]);
            Assert.Equal(context.DocumentSnapshot.ReadTime, dictionary["ReadTime"]);
        }

        public class NullReturningConverter : IFirestoreConverter<string>
        {
            public string FromFirestore(object value) => null;
            public object ToFirestore(string value) => null;
        }

        public class DictionaryHolder
        {
            public Dictionary<string, object> Dictionary { get; set; }
        }

        public class DictionaryHolderConverter : IFirestoreConverter<DictionaryHolder>
        {
            [FirestoreDeserializationConfiguration(DocumentIdKey = "DocumentId", CreateTimestampKey = "CreateTime", UpdateTimestampKey = "UpdateTime", ReadTimestampKey = "ReadTime")]
            public DictionaryHolder FromFirestore(object value) =>
                new DictionaryHolder { Dictionary = (Dictionary<string, object>) value };

            public object ToFirestore(DictionaryHolder value) =>
                throw new NotImplementedException();
        }
    }
}
