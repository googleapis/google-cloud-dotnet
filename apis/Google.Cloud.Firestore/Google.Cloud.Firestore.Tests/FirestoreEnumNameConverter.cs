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

namespace Google.Cloud.Firestore.Tests
{
    // Note: this is a prototype to prove that custom enum converters *can* work. Eventually it might be moved into
    // Google.Cloud.Firestore itself; we may need to add ways of specifying the names to use (e.g. to match Java etc).

    /// <summary>
    /// Custom converter which uses enum value names instead of integer values as the Firestore representation.
    /// </summary>
    /// <typeparam name="T">The enum type to convert</typeparam>
    public sealed class FirestoreEnumNameConverter<T> : IFirestoreConverter<T>
        where T : struct, Enum
    {
        /// <inheritdoc />
        public T FromFirestore(object value)
        {
            string name = (string) value;
            if (Enum.TryParse<T>(name, out var result))
            {
                return result;
            }
            throw new ArgumentException($"Unknown name {name} for enum {typeof(T).FullName}");
        }

        /// <inheritdoc />
        public object ToFirestore(T value) => value.ToString();
    }
}
