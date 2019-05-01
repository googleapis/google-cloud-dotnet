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
using System;
using Xunit;
using BclType = System.Type;

namespace Google.Cloud.Firestore.Tests.Converters
{
    public class AttributedIdAssignerTest
    {
        [Fact]
        public void StringProperty()
        {
            var target = new StringPropertyModel();
            var db = FirestoreDb.Create("project", "database", new FakeFirestoreClient());
            var doc = db.Document("col/doc");
            AttributedIdAssigner.MaybeAssignId(target, doc);
            Assert.Equal(doc.Id, target.Id);
        }

        [FirestoreData]
        private class StringPropertyModel
        {
            [FirestoreDocumentId]
            public string Id { get; set; }
        }

        [Fact]
        public void DocumentReferenceProperty()
        {
            var target = new DocumentReferencePropertyModel();
            var db = FirestoreDb.Create("project", "database", new FakeFirestoreClient());
            var doc = db.Document("col/doc");
            AttributedIdAssigner.MaybeAssignId(target, doc);
            Assert.Equal(doc, target.Reference);
        }

        [FirestoreData]
        private class DocumentReferencePropertyModel
        {
            [FirestoreDocumentId]
            public DocumentReference Reference { get; set; }
        }

        [Fact]
        public void MultipleProperties()
        {
            var target = new MultiplePropertiesModel();
            var db = FirestoreDb.Create("project", "database", new FakeFirestoreClient());
            var doc = db.Document("col/doc");
            AttributedIdAssigner.MaybeAssignId(target, doc);
            Assert.Equal(doc.Id, target.Id);
            Assert.Equal(doc, target.Reference);
        }

        [FirestoreData]
        private class MultiplePropertiesModel
        {
            // Note: private setters just to check that works too...
            [FirestoreDocumentId]
            public string Id { get; private set; }

            [FirestoreDocumentId]
            public DocumentReference Reference { get; private set; }
        }

        [Theory]
        [InlineData(typeof(ReadOnlyProperty))]
        [InlineData(typeof(WrongPropertyType))]
        [InlineData(typeof(Indexer))]
        [InlineData(typeof(StaticProperty))]
        [InlineData(typeof(AlsoHasFirestorePropertyAttribute))]
        public void InvalidAttributes(BclType type)
        {
            var target = Activator.CreateInstance(type);
            var db = FirestoreDb.Create("project", "database", new FakeFirestoreClient());
            var doc = db.Document("col/doc");

            Assert.Throws<InvalidOperationException>(() => AttributedIdAssigner.MaybeAssignId(target, doc));
        }

        [FirestoreData]
        private class ReadOnlyProperty
        {
            [FirestoreDocumentId]
            public string Id => "";
        }

        [FirestoreData]
        private class WrongPropertyType
        {
            [FirestoreDocumentId]
            public int Id { get; set; }
        }

        [FirestoreData]
        private class Indexer
        {
            [FirestoreDocumentId]
            public string this[int index]
            {
                get => "";
                set { }
            }
        }

        [FirestoreData]
        private class StaticProperty
        {
            [FirestoreDocumentId]
            public static string Id { get; set; }
        }

        [FirestoreData]
        private class AlsoHasFirestorePropertyAttribute
        {
            [FirestoreDocumentId, FirestoreProperty]
            public string Id { get; set; }
        }
    }
}
