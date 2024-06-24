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

using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// Immutable set of DocumentSnapshots, ordered by a custom comparer.
    /// </summary>
    internal sealed class DocumentSet : IEnumerable<DocumentSnapshot>
    {
        // TODO: Investigate whether the immutable collections are okay here. ImmutableSortedSet uses an AVL tree,
        // not a red-black tree.
        private static readonly ImmutableSortedDictionary<DocumentReference, DocumentSnapshot> _emptyKeyIndex =
            ImmutableSortedDictionary.Create<DocumentReference, DocumentSnapshot>();

        private readonly ImmutableSortedDictionary<DocumentReference, DocumentSnapshot> _keyIndex;
        private readonly ImmutableSortedSet<DocumentSnapshot> _sortedSet;

        internal int Count => _keyIndex.Count;
        internal bool Contains(DocumentReference docRef) => _keyIndex.ContainsKey(docRef);

        internal static DocumentSet Empty(IComparer<DocumentSnapshot> comparer) =>
            new DocumentSet(_emptyKeyIndex, ImmutableSortedSet.Create(comparer));

        private DocumentSet(
            ImmutableSortedDictionary<DocumentReference, DocumentSnapshot> keyIndex,
            ImmutableSortedSet<DocumentSnapshot> sortedSet)
        {
            _keyIndex = keyIndex;
            _sortedSet = sortedSet;
        }

        internal bool TryGetDocument(DocumentReference docRef, out DocumentSnapshot document) =>
            _keyIndex.TryGetValue(docRef, out document);

        internal int IndexOf(DocumentReference docRef)
        {
            if (!_keyIndex.TryGetValue(docRef, out var document))
            {
                return -1;
            }
            return _sortedSet.IndexOf(document);
        }

        internal DocumentSet WithDocumentAdded(DocumentSnapshot document)
        {
            // Remove any prior mapping of the document's key before adding, preventing sortedSet from
            // accumulating values that aren't in the index.
            DocumentSet removed = WithDocumentRemoved(document.Reference);

            var newKeyIndex = removed._keyIndex.Add(document.Reference, document);
            var newSortedSet = removed._sortedSet.Add(document);
            return new DocumentSet(newKeyIndex, newSortedSet);
        }

        internal DocumentSet WithDocumentRemoved(DocumentReference docRef)
        {
            _keyIndex.TryGetValue(docRef, out var document);
            if (document == null)
            {
                return this;
            }

            var newKeyIndex = _keyIndex.Remove(docRef);
            var newSortedSet = _sortedSet.Remove(document);
            return new DocumentSet(newKeyIndex, newSortedSet);
        }

        public IEnumerator<DocumentSnapshot> GetEnumerator() => _sortedSet.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
