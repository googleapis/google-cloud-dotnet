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

namespace Google.Cloud.Firestore.Data
{
    /// <summary>
    /// An immutable path of field names, used to identify parts of a document.
    /// </summary>
    public sealed class FieldPath : IEquatable<FieldPath>
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

        internal FieldPath Append(FieldPath fieldPath)
        {
            GaxPreconditions.CheckNotNull(fieldPath, nameof(fieldPath));
            var newFields = new string[Segments.Length + fieldPath.Segments.Length];
            Array.Copy(Segments, newFields, Segments.Length);
            Array.Copy(fieldPath.Segments, 0, newFields, Segments.Length, fieldPath.Segments.Length);
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
    }
}
