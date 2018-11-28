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

using System;
using System.Collections.Generic;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// Methods to help implement IEquatable{T}.
    /// </summary>
    internal static class EqualityHelpers
    {
        private const int HashInitialValue = 3581;

        /// <summary>
        /// Checks if two lists are equal, in an ordering-sensitive manner.
        /// </summary>
        internal static bool ListsEqual<T>(IReadOnlyList<T> left, IReadOnlyList<T> right)
            where T : IEquatable<T>
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            {
                return false;
            }
            if (left.Count != right.Count)
            {
                return false;
            }
            for (int i = 0; i < left.Count; i++)
            {
                if (!left[i].Equals(right[i]))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Computes an ordering-sensitive hash code for a list.
        /// </summary>
        internal static int GetListHashCode<T>(IReadOnlyList<T> list) where T : IEquatable<T>
        {            
            if (list == null)
            {
                return 0;
            }
            unchecked
            {
                int hash = HashInitialValue;
                int count = list.Count;
                for (int i = 0; i < count; i++)
                {
                    hash = (hash << 5) + hash + list[i].GetHashCode();
                }
                return hash;
            }
        }

        /// <summary>
        /// Computes an ordering-sensitive hash code for a sequence.
        /// </summary>
        internal static int GetEnumerableHashCode<T>(IEnumerable<T> sequence) where T : IEquatable<T>
        {
            if (sequence == null)
            {
                return 0;
            }
            unchecked
            {
                int hash = HashInitialValue;
                foreach (var item in sequence)
                {
                    hash = (hash << 5) + hash + item.GetHashCode();
                }
                return hash;
            }
        }

        // Hash code convenience methods using DJB2 constants.
        // Alternatives would be generic methods that call GetHashCode directly.
        // Only necessary overloads are present; more can be added.
        internal static int CombineHashCodes(int hash1, int hash2)
        {
            unchecked
            {
                int hash = HashInitialValue;
                hash = (hash << 5) + hash + hash1;
                hash = (hash << 5) + hash + hash2;
                return hash;
            }
        }

        internal static int CombineHashCodes(int hash1, int hash2, int hash3)
        {
            unchecked
            {
                int hash = HashInitialValue;
                hash = (hash << 5) + hash + hash1;
                hash = (hash << 5) + hash + hash2;
                hash = (hash << 5) + hash + hash3;
                return hash;
            }
        }

        internal static int CombineHashCodes(int hash1, int hash2, int hash3, int hash4)
        {
            unchecked
            {
                int hash = HashInitialValue;
                hash = (hash << 5) + hash + hash1;
                hash = (hash << 5) + hash + hash2;
                hash = (hash << 5) + hash + hash3;
                hash = (hash << 5) + hash + hash4;
                return hash;
            }
        }

        internal static int CombineHashCodes(int hash1, int hash2, int hash3, int hash4, int hash5, int hash6, int hash7, int hash8)
        {
            unchecked
            {
                int hash = HashInitialValue;
                hash = (hash << 5) + hash + hash1;
                hash = (hash << 5) + hash + hash2;
                hash = (hash << 5) + hash + hash3;
                hash = (hash << 5) + hash + hash4;
                hash = (hash << 5) + hash + hash5;
                hash = (hash << 5) + hash + hash6;
                hash = (hash << 5) + hash + hash7;
                hash = (hash << 5) + hash + hash8;
                return hash;
            }
        }
    }
}
