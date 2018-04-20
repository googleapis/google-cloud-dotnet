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

using System;
using System.Collections.Generic;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// Provides ordering comparisons for slash-separated resource paths.
    /// </summary>
    internal sealed class PathComparer : IComparer<string>
    {
        internal static PathComparer Instance { get; } = new PathComparer();

        private PathComparer()
        {
        }

        // Note: we don't handle null input, but this is never exposed, so we should never need to.
        public int Compare(string left, string right)
        {
            // We can't just do a string comparison, because of cases such as:
            // foo/bar/baz
            // foo/bar-/baz
            // Here "bar-" should come after "bar" because it's longer, but '-' is earlier than '/'.
            int length = Math.Min(left.Length, right.Length);
            for (int i = 0; i < length; i++)
            {
                char leftChar = left[i];
                char rightChar = right[i];
                if (leftChar != rightChar)
                {
                    return leftChar == '/' ? -1 // Left segment finishes earlier
                        : rightChar == '/' ? 1  // Right segment finishes earlier
                        : leftChar - rightChar; // Not a segment end, so just compare ordinals
                }
            }
            // Shorter comes before longer
            return left.Length.CompareTo(right.Length);
        }
    }
}
