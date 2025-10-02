// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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
using System;
using System.Collections.Generic;
using Xunit;

namespace Google.Cloud.Firestore.Tests.Converters;

public class DiscriminatedTypeTest
{
    [Fact]
    public void SerializeDeserialize()
    {
        var model = new Model
        {
            Items =
            {
                new DerivedType1 { Name = "Test" },
                new DerivedType2 { Value = 2 }
            }
        };

        var db = new FirestoreDbBuilder
        {
            ProjectId = "proj",
            DatabaseId = "db",
            Client = new FakeFirestoreClient(),
            ConverterRegistry = new ConverterRegistry { new TypeDiscriminator() }
        }.Build();
        var value = db.SerializationContext.GetConverter(typeof(Model)).Serialize(db.SerializationContext, model).MapValue;
        var snapshot = DocumentSnapshotHelpers.GetSampleSnapshot(db, "doc");
        snapshot.Document.Fields.Clear();
        snapshot.Document.Fields.Add(value.Fields);

        var deserialized = snapshot.ConvertTo<Model>();
        Assert.Equal(2, model.Items.Count);
        Assert.Equal("Test", ((DerivedType1) model.Items[0]).Name);
        Assert.Equal(2, ((DerivedType2) model.Items[1]).Value);
    }

    [FirestoreData]
    public class Model
    {
        [FirestoreProperty]
        public List<BaseType> Items { get; set; } = [];
    }

    [FirestoreData]
    public abstract class BaseType
    {
        [FirestoreProperty]
        public string Discriminator { get; set; }
    }

    [FirestoreData]
    public class DerivedType1 : BaseType
    {
        public DerivedType1()
        {
            Discriminator = "Type1";
        }

        [FirestoreProperty]
        public string Name { get; set; }
    }

    [FirestoreData]
    public class DerivedType2 : BaseType
    {
        public DerivedType2()
        {
            Discriminator = "Type2";
        }

        [FirestoreProperty]
        public int Value { get; set; }
    }

    public class TypeDiscriminator : IFirestoreTypeDiscriminator<BaseType>
    {
        public System.Type GetConcreteType(IDictionary<string, Value> map)
        {
            if (!map.TryGetValue(nameof(BaseType.Discriminator), out var discriminator) ||
                discriminator?.StringValue is not string discriminatorText)
            {
                throw new InvalidOperationException("Dictionary must have a string discriminator");
            }
            return discriminatorText switch
            {
                "Type1" => typeof(DerivedType1),
                "Type2" => typeof(DerivedType2),
                _ => throw new InvalidOperationException($"Unexpected discriminator '{discriminatorText}'")
            };
        }
    }
}
