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

using static Google.Cloud.Firestore.Tests.ProtoHelpers;

namespace Google.Cloud.Firestore.Tests.Converters;

public class DiscriminatedTypeTest
{
    private static readonly IDictionary<string, Value> s_sampleMap = new Dictionary<string, Value>
    {
        { nameof(BaseType.Discriminator), CreateValue("Type2") },
        { nameof(DerivedType2.Value), CreateValue(20) },
    };

    [Fact]
    public void Deserialize()
    {
        // This uses a hand-crafted map so we can validate that it's okay for other tests with bad
        // implementations of IFirestoreTypeDiscriminator<T>.
        var db = CreateDb(new TypeDiscriminator());
        var snapshot = CreateSnapshot(db, s_sampleMap);

        var deserialized = Assert.IsType<DerivedType2>(snapshot.ConvertTo<BaseType>());
        Assert.Equal(20, deserialized.Value);
    }

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

        var db = CreateDb(new TypeDiscriminator());
        var value = db.SerializationContext.GetConverter(typeof(Model)).Serialize(db.SerializationContext, model).MapValue;
        var snapshot = CreateSnapshot(db, value.Fields);

        var deserialized = snapshot.ConvertTo<Model>();
        Assert.Equal(2, model.Items.Count);
        Assert.Equal("Test", ((DerivedType1) model.Items[0]).Name);
        Assert.Equal(2, ((DerivedType2) model.Items[1]).Value);
    }

    [Fact]
    public void InvalidDiscriminator_ReturnsNull()
    {
        var db = CreateDb(new NullReturningTypeDiscriminator());
        var snapshot = CreateSnapshot(db, s_sampleMap);
        Assert.Throws<InvalidOperationException>(snapshot.ConvertTo<BaseType>);
    }

    [Fact]
    public void InvalidDiscriminator_ReturnsInappropriateType()
    {
        var db = CreateDb(new OtherTypeReturningTypeDiscriminator());
        var snapshot = CreateSnapshot(db, s_sampleMap);
        Assert.Throws<InvalidOperationException>(snapshot.ConvertTo<BaseType>);
    }

    private static FirestoreDb CreateDb(IFirestoreTypeDiscriminator<BaseType> discriminator) =>
        new FirestoreDbBuilder
        {
            ProjectId = "proj",
            DatabaseId = "db",
            Client = new FakeFirestoreClient(),
            ConverterRegistry = new ConverterRegistry { discriminator }
        }.Build();

    private static DocumentSnapshot CreateSnapshot(FirestoreDb db, IDictionary<string, Value> fields)
    {
        var snapshot = DocumentSnapshotHelpers.GetSampleSnapshot(db, "doc");
        snapshot.Document.Fields.Clear();
        snapshot.Document.Fields.Add(fields);
        return snapshot;
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
        public abstract string Discriminator { get; }
    }

    [FirestoreData]
    public class DerivedType1 : BaseType
    {
        [FirestoreProperty]
        public string Name { get; set; }

        public override string Discriminator => "Type1";
    }

    [FirestoreData]
    public class DerivedType2 : BaseType
    {
        [FirestoreProperty]
        public int Value { get; set; }

        public override string Discriminator => "Type2";
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

    public class NullReturningTypeDiscriminator : IFirestoreTypeDiscriminator<BaseType>
    {
        public System.Type GetConcreteType(IDictionary<string, Value> map) => null;
    }

    public class OtherTypeReturningTypeDiscriminator : IFirestoreTypeDiscriminator<BaseType>
    {
        public System.Type GetConcreteType(IDictionary<string, Value> map) => typeof(Model);
    }
}
