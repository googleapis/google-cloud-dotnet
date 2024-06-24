// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using System;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// A DocumentChange represents a change to the documents matching a query. It contains the document
    /// affected and a the type of change that occurred (added, modifed, or removed).
    /// </summary>
    public sealed class DocumentChange : IEquatable<DocumentChange>
    {
        /// <summary>
        /// An enumeration of snapshot change types.
        /// </summary>
        public enum Type
        {
            /// <summary>
            /// Indicates a new document was added to the set of documents matching the query.
            /// </summary>
            Added = 1,

            /// <summary>
            /// Indicates a document within the query was removed (either deleted or no longer matches the query.
            /// </summary>
            Removed = 2,

            /// <summary>
            /// Indicates a document within the query was modified.
            /// </summary>
            Modified = 3
        }

        // Note: In theory we could infer the type based on the indexes, but it's simpler to store it separately.

        /// <summary>
        /// The newly added or modified document, or the document that was deleted.
        /// </summary>
        public DocumentSnapshot Document { get; }

        /// <summary>
        /// The type of change that was observed.
        /// </summary>
        public Type ChangeType { get; }

        /// <summary>
        /// The index of the changed document in the result set immediately prior to this DocumentChange
        /// (i.e. supposing that all prior DocumentChange objects have been applied), or null
        /// if the change type is <see cref="Type.Added"/>. The index will never be negative.
        /// </summary>
        public int? OldIndex { get; }

        /// <summary>
        /// The index of the changed document in the result set immediately after this DocumentChange
        /// (i.e. supposing that all prior DocumentChange objects and this one have been applied),
        /// null if the change type is <see cref="Type.Removed"/>. The index will never be negative.
        /// </summary>
        public int? NewIndex { get; }

        internal DocumentChange(DocumentSnapshot document, Type type, int? oldIndex, int? newIndex)
        {
            ChangeType = type;
            Document = document;
            if (oldIndex != null)
            {
                GaxPreconditions.CheckArgumentRange(oldIndex, nameof(oldIndex), 0, int.MaxValue);
            }
            if (newIndex != null)
            {
                GaxPreconditions.CheckArgumentRange(newIndex, nameof(newIndex), 0, int.MaxValue);
            }
            OldIndex = oldIndex;
            NewIndex = newIndex;
        }

        /// <summary>
        /// Compares this snapshot with another for equality. Only the document data and document reference
        /// are considered; the timestamps are ignored.
        /// </summary>
        /// <param name="other">The snapshot to compare this one with</param>
        /// <returns><c>true</c> if this snapshot is equal to <paramref name="other"/>; <c>false</c> otherwise.</returns>
        public bool Equals(DocumentChange other) =>
            other != null &&
            ChangeType == other.ChangeType &&
            OldIndex == other.OldIndex &&
            NewIndex == other.NewIndex &&
            Equals(Document, other.Document);

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as DocumentChange);

        /// <inheritdoc />
        public override int GetHashCode() =>
            GaxEqualityHelpers.CombineHashCodes((int) ChangeType, OldIndex ?? -1, NewIndex ?? -1, Document.GetHashCode());
    }
}
