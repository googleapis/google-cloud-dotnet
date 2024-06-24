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
using System;
using System.Linq;
using System.Text;
using static Google.Cloud.Firestore.V1.StructuredQuery.Types;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// An immutable path of field names, used to identify parts of a document.
    /// </summary>
    /// <remarks>
    /// Ordering between field paths is primarily to provide canonical orderings for sets of
    /// paths, for example in a <see cref="FieldMask"/>. This ordering is performed segment-wise,
    /// using ordinal string comparisons.
    /// </remarks>
    public sealed class FieldPath : IEquatable<FieldPath>, IComparable<FieldPath>
    {
        private static readonly char[] s_dotSplit = { '.' };

        /// <summary>
        /// Characters prohibited within dot-separated field paths.
        /// </summary>
        private static readonly char[] s_prohibitedCharacters = { '~', '*', '[', ']', '/' };

        /// <summary>
        /// Sentinel field path to refer to the ID of a document. Used in queries to sort or filter
        /// by the document ID.
        /// </summary>
        public static FieldPath DocumentId { get; } = new FieldPath(new[] { "__name__" }, true);

        /// <summary>
        /// An empty field path, appropriate for appending
        /// </summary>
        internal static FieldPath Empty { get; } = new FieldPath(new string[0], true);

        /// <summary>
        /// Segments of the path: do not mutate or expose publicly!
        /// </summary>
        internal string[] Segments { get; }

        private string _encodedPath;

        internal string EncodedPath => _encodedPath ?? (_encodedPath = GetCanonicalPath(Segments));

        /// <summary>
        /// Constructor that trusts the value
        /// </summary>
        /// <param name="segments">The segments</param>
        /// <param name="trusted">True to bypass both copying and validation; false otherwise.</param>
        private FieldPath(string[] segments, bool trusted)
        {
            if (trusted)
            {
                Segments = segments;
            }
            else
            {
                Segments = GaxPreconditions.CheckNotNull(segments, nameof(segments)).ToArray();
                GaxPreconditions.CheckArgument(segments.Length != 0, nameof(segments), "Path must not be empty");
                GaxPreconditions.CheckArgument(Segments.All(n => !string.IsNullOrEmpty(n)), nameof(segments), "Path must not contain null or empty names");
            }
        }

        /// <summary>
        /// Creates a path from multiple segments. Each segment is treated verbatim: it may contain dots, which will lead to the segment being escaped in the
        /// path's string representation.
        /// </summary>
        /// <param name="segments">The segments of the path. This must not be null or empty, and it must not contain any null or empty elements.</param>
        public FieldPath(params string[] segments) : this(segments, false)
        {
        }

        internal static FieldPath FromDotSeparatedString(string path)
        {
            GaxPreconditions.CheckNotNullOrEmpty(path, nameof(path));
            GaxPreconditions.CheckArgument(path.IndexOfAny(s_prohibitedCharacters) == -1, nameof(path), "Use the constructor for field names containing any of '~*/[]'.");
            string[] elements = path.Split(s_dotSplit);
            if (elements.Contains(""))
            {
                throw new ArgumentException("Path cannot contain empty elements", nameof(path));
            }
            // Avoid the copy or more validation.
            return new FieldPath(elements, true);
        }

        /// <summary>
        /// Creates a new path from this one, with the specified segment appended.
        /// </summary>
        /// <param name="segment">The segment to append. Must not be null or empty.</param>
        internal FieldPath Append(string segment)
        {
            GaxPreconditions.CheckNotNullOrEmpty(segment, nameof(segment));
            var newFields = new string[Segments.Length + 1];
            Array.Copy(Segments, newFields, Segments.Length);
            newFields[Segments.Length] = segment;
            return new FieldPath(newFields, true);
        }

        private static string GetCanonicalPath(string[] fields)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < fields.Length; i++)
            {
                if (i > 0)
                {
                    builder.Append(".");
                }
                // Escape backslashes and backticks.
                string escaped = fields[i].Replace(@"\", @"\\").Replace("`", @"\`");
                if (!IsValidIdentifier(escaped))
                {
                    builder.Append('`').Append(escaped).Append('`');
                }
                else
                {
                    builder.Append(escaped);
                }
            }
            return builder.ToString();
        }

        /// <summary>
        /// Return true if the string could be used as a segment in a field path without escaping. Valid
        /// identifiers follow the regex [a-zA-Z_][a-zA-Z0-9_]*.
        /// (Using a regular expression is significantly slower though.)
        /// </summary>
        private static bool IsValidIdentifier(string identifier)
        {
            // This will never be called with any empty strings.
            char first = identifier[0];
            if (first != '_' && (first < 'a' || first > 'z') && (first < 'A' || first > 'Z'))
            {
                return false;
            }
            for (int i = 1; i < identifier.Length; i++)
            {
                char c = identifier[i];
                if (c != '_' && (c < 'a' || c > 'z') && (c < 'A' || c > 'Z') && (c < '0' || c > '9'))
                {
                    return false;
                }
            }
            return true;
        }

        /// <inheritdoc />
        public override string ToString() => EncodedPath;

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as FieldPath);

        /// <inheritdoc />
        public override int GetHashCode() => EncodedPath.GetHashCode();

        /// <inheritdoc />
        public bool Equals(FieldPath other) => EncodedPath == other?.EncodedPath;

        /// <inheritdoc />
        public int CompareTo(FieldPath other)
        {
            // Every non-null value is greater than null.
            if (other is null)
            {
                return 1;
            }
            int segmentsToCompare = Math.Min(Segments.Length, other.Segments.Length);
            for (int i = 0; i < segmentsToCompare; i++)
            {
                int segmentComparison = string.Compare(Segments[i], other.Segments[i], StringComparison.Ordinal);
                if (segmentComparison != 0)
                {
                    return segmentComparison;
                }
            }
            // Either the paths are equal, or one is a prefix of the other. Use the number of segments to
            // determine which situation we're in, with a shorter path being deemed "less than" a longer one.
            return Segments.Length - other.Segments.Length;
        }

        /// <summary>
        /// Conversion from FieldPath to FieldReference.
        /// </summary>
        internal FieldReference ToFieldReference() => new FieldReference { FieldPath = EncodedPath };

        /// <summary>
        /// Checks whether the specified path starts with the same path segments as this path. A path
        /// is considered a prefix of itself, in the way that "a".StartsWith("a") returns true.
        /// </summary>
        internal bool IsPrefixOf(FieldPath path)
        {
            if (path.Segments.Length < Segments.Length)
            {
                return false;
            }
            for (int i = 0; i < Segments.Length; i++)
            {
                if (Segments[i] != path.Segments[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
