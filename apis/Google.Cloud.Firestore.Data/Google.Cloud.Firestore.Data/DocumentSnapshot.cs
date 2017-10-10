// Copyright 2017, Google Inc. All rights reserved.
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
using Google.Api.Gax;
using Google.Cloud.Firestore.V1Beta1;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Google.Cloud.Firestore.Data
{
    /// <summary>
    /// An immutable snapshot of the data for a document.
    /// </summary>
    public sealed class DocumentSnapshot
    {
        /// <summary>
        /// The proto representation of the document. Primarily visible for testing purposes.
        /// </summary>
        internal Document Document { get; }

        /// <summary>
        /// The full reference to the document.
        /// </summary>
        public DocumentReference Reference { get; }

        /// <summary>
        /// The database that owns the document.
        /// </summary>
        public FirestoreDb Database => Reference.Database;

        /// <summary>
        /// The ID of the document.
        /// </summary>
        public string Id => Reference.Id;

        /// <summary>
        /// Whether or not the document exists.
        /// </summary>
        public bool Exists => Document != null;

        /// <summary>
        /// The creation time of the document if it exists, or null otherwise.
        /// </summary>
        public Timestamp? CreateTime { get; }

        /// <summary>
        /// The update time of the document if it exists, or null otherwise.
        /// </summary>
        public Timestamp? UpdateTime { get; }

        /// <summary>
        /// The time at which this snapshot was read.
        /// </summary>
        public Timestamp ReadTime { get; }

        private DocumentSnapshot(FirestoreDb db, string resourceName, Document document, Timestamp readTime)
        {
            GaxPreconditions.CheckNotNull(db, nameof(db));
            GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName));
            Reference = db.GetDocumentReferenceFromResourceName(resourceName);
            Document = document;
            CreateTime = Timestamp.FromProtoOrNull(document?.CreateTime);
            UpdateTime = Timestamp.FromProtoOrNull(document?.UpdateTime);
            ReadTime = readTime;
        }

        internal static DocumentSnapshot ForDocument(FirestoreDb db, Document document, Timestamp readTime) =>
            new DocumentSnapshot(db, document.Name, document, readTime);

        internal static DocumentSnapshot ForMissingDocument(FirestoreDb db, string name, Timestamp readTime) =>
            new DocumentSnapshot(db, name, null, readTime);

        /// <summary>
        /// Returns the document data as an <see cref="IDictionary{String, Object}"/>.
        /// </summary>
        /// <exception cref="InvalidOperationException">This snapshot represents a missing document, i.e. <see cref="Exists"/> is false.</exception>
        /// <returns>An <see cref="ExpandoObject"/> containing the document data.</returns>
        public Dictionary<string, object> ToDictionary() => Deserialize<Dictionary<string, object>>();

        /// <summary>
        /// Deserializes the document data as the specified type.
        /// </summary>
        /// <typeparam name="T">The type to deserialize the document data as.</typeparam>
        /// <exception cref="InvalidOperationException">This snapshot represents a missing document, i.e. <see cref="Exists"/> is false.</exception>
        /// <returns>The deserialized data.</returns>
        public T Deserialize<T>()
        {
            GaxPreconditions.CheckState(Exists, "Document data cannot be accessed on a snapshot representing a missing document");
            return (T) ValueDeserializer.Default.DeserializeMap(Database, Document.Fields, typeof(T));
        }

        /// <summary>
        /// Fetches a field value from the document, throwing an exception if the field does not exist.
        /// </summary>
        /// <param name="path">The dot-separated field path to fetch. Must not be null or empty</param>
        /// <exception cref="InvalidOperationException">The field does not exist in the document data.</exception>
        /// <returns>The deserialized value.</returns>
        public T GetField<T>(string path) => GetField<T>(FieldPath.FromDotSeparatedString(path));

        /// <summary>
        /// Attempts to fetch the given field path from the document, returning whether or not it was found, and deserializing
        /// it if it was found.
        /// </summary>
        /// <remarks>
        /// This method does not throw an exception if the field is not found, but does throw an exception if the field was found
        /// but cannot be deserialized.
        /// </remarks>
        /// <typeparam name="T">The type to deserialize the value to, if it is found.</typeparam>
        /// <param name="path">The dot-separated field path to fetch. Must not be null or empty</param>
        /// <param name="value">When this method returns, contains the deserialized value if the field was found, or the default value
        /// of <typeparamref name="T"/> otherwise.</param>
        /// <returns>true if the field was found; false otherwise.</returns>
        public bool TryGetField<T>(string path, out T value) => TryGetField(FieldPath.FromDotSeparatedString(path), out value);

        /// <summary>
        /// Fetches a field value from the document, throwing an exception if the field does not exist.
        /// </summary>
        /// <param name="path">The field path to fetch. Must not be null.</param>
        /// <exception cref="InvalidOperationException">The field does not exist in the document data.</exception>
        /// <returns>The deserialized value.</returns>
        public T GetField<T>(FieldPath path)
        {
            var raw = ExtractValue(path);
            GaxPreconditions.CheckState(raw != null, $"Field {path} not found in document");
            return (T) ValueDeserializer.Default.Deserialize(Database, raw, typeof(T));
        }

        /// <summary>
        /// Attempts to fetch the given field path from the document, returning whether or not it was found, and deserializing
        /// it if it was found.
        /// </summary>
        /// <remarks>
        /// This method does not throw an exception if the field is not found, but does throw an exception if the field was found
        /// but cannot be deserialized.
        /// </remarks>
        /// <typeparam name="T">The type to deserialize the value to, if it is found.</typeparam>
        /// <param name="path">The field path to fetch. Must not be null.</param>
        /// <param name="value">When this method returns, contains the deserialized value if the field was found, or the default value
        /// of <typeparamref name="T"/> otherwise.</param>
        /// <returns>true if the field was found; false otherwise.</returns>
        public bool TryGetField<T>(FieldPath path, out T value)
        {
            var raw = ExtractValue(path);
            if (raw == null)
            {
                value = default(T);
                return false;
            }
            value = (T) ValueDeserializer.Default.Deserialize(Database, raw, typeof(T));
            return true;
        }

        /// <summary>
        /// Determines whether or not the given field path is present in the document. If this snapshot represents
        /// a missing document, this method will always return false.
        /// </summary>
        /// <param name="path">The dot-separated field path to check. Must not be null or empty.</param>
        /// <returns>true if the specified path represents a field in the document; false otherwise</returns>
        public bool Contains(string path) => Contains(FieldPath.FromDotSeparatedString(path));

        /// <summary>
        /// Determines whether or not the given field path is present in the document. If this snapshot represents
        /// a missing document, this method will always return false.
        /// </summary>
        /// <param name="path">The field path to check. Must not be null.</param>
        /// <returns>true if the specified path represents a field in the document; false otherwise</returns>
        public bool Contains(FieldPath path) => ExtractValue(path) != null;

        private Value ExtractValue(FieldPath path)
        {
            if (!Exists)
            {
                return null;
            }
            Value value = null;
            IDictionary<string, Value> map = Document.Fields;
            foreach (var segment in path.Segments)
            {
                if (map == null || !map.TryGetValue(segment, out value))
                {
                    return null;
                }
                map = value.ValueTypeCase == Value.ValueTypeOneofCase.MapValue ? value.MapValue.Fields : null;
            }
            return value;
        }
    }
}
