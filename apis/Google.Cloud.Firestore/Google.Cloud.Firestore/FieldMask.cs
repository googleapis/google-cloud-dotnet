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
using Google.Api.Gax;
using Google.Cloud.Firestore.V1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// An immutable set of field paths, used to limit the data returned by calls to
    /// <see cref="FirestoreDb.GetAllSnapshotsAsync(IEnumerable{DocumentReference}, System.Threading.CancellationToken)"/>
    /// and similar calls.
    /// </summary>
    public sealed class FieldMask : IEquatable<FieldMask>
    {
        // We store the paths in order for the sake of testability: we can predict the protobuf form easily, and this
        // provides setwise behavior too.
        private readonly SortedSet<FieldPath> _fieldPaths;

        private FieldMask(IEnumerable<FieldPath> paths)
        {
            _fieldPaths = new SortedSet<FieldPath>(paths);
        }

        /// <summary>
        /// Creates a mask from the given paths. Each path is treated as a dot-separated sequence of field names.
        /// </summary>
        /// <param name="paths">The paths, as dot-separated strings. This must not be null, and it must not contain any null or empty elements.</param>
        public FieldMask(params string[] paths) : this(ConvertPaths(paths))
        {
        }

        static IEnumerable<FieldPath> ConvertPaths(string[] paths)
        {
            GaxPreconditions.CheckNotNull(paths, nameof(paths));
            return paths.Select(path =>
            {
                GaxPreconditions.CheckArgument(!string.IsNullOrEmpty(path), nameof(paths), "Path array must not contain any null or empty elements");
                return FieldPath.FromDotSeparatedString(path);
            });
        }

        /// <summary>
        /// Creates a mask from the given paths.
        /// </summary>
        /// <param name="paths">The segments of the path. This must not be null, and it must not contain any null elements.</param>
        public FieldMask(params FieldPath[] paths) : this(CheckPaths(paths))
        {
        }

        static IEnumerable<FieldPath> CheckPaths(FieldPath[] paths)
        {
            GaxPreconditions.CheckNotNull(paths, nameof(paths));
            GaxPreconditions.CheckArgument(!paths.Contains(null), nameof(paths), "Path array must not contain any null elements");
            return paths;
        }

        internal DocumentMask ToProto() => new DocumentMask { FieldPaths = { _fieldPaths.Select(p => p.EncodedPath) } };

        // Note: even though this is order-sensitive (which is odd for set behavior), that's fine as we use a sorted set.
        /// <inheritdoc />
        public override int GetHashCode() => EqualityHelpers.GetEnumerableHashCode(_fieldPaths);

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as FieldMask);

        /// <inheritdoc />
        public bool Equals(FieldMask other) =>
            other != null &&
            _fieldPaths.Count == other._fieldPaths.Count && // Surprisingly, it looks like this optimization isn't in SortedSet<T>
            _fieldPaths.SetEquals(other._fieldPaths);
    }
}
