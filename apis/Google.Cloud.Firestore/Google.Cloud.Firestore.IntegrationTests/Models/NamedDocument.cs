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

using System;

namespace Google.Cloud.Firestore.IntegrationTests.Models
{
    /// <summary>
    /// A simple document that just has a Name property.
    /// </summary>
    [FirestoreData]
    public class NamedDocument : IEquatable<NamedDocument>
    {
        [FirestoreProperty]
        public string Name { get; set; }

        // Data for collection group testing
        public static NamedDocument Parent1 = new NamedDocument("parent doc 1");
        public static NamedDocument Parent2 = new NamedDocument("parent doc 2");
        public static NamedDocument Child1 = new NamedDocument("child doc 1");
        public static NamedDocument Child2 = new NamedDocument("child doc 2");

        public NamedDocument(string name) => Name = name;

        // For deserialization
        public NamedDocument() { }

        public override int GetHashCode() => Name?.GetHashCode() ?? 0;

        public override bool Equals(object obj) => Equals(obj as NamedDocument);

        public bool Equals(NamedDocument other) => other != null && Name == other.Name;
    }
}
