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

using static Google.Cloud.Firestore.SentinelValue;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// A static class providing properties and methods to represent sentinel values.
    /// Sentinel values are special values where the client-side value is not part of the
    /// document modification sent to the server. A property decorated with
    /// <see cref="FirestorePropertyAttribute"/> can specify an additional attribute
    /// to indicate that it's a sentinel value, such as a<see cref="ServerTimestampAttribute"/>,
    /// or the sentinel values returned by the members of this class can be used directly as
    /// values to be serialized (for example, in anonymous types), and they will be handled
    /// directly by the serialization mechanism.
    /// </summary>
    public static class FieldValue
    {
        /// <summary>
        /// Sentinel value indicating that the field should be set to the timestamp of the
        /// commit that creates or modifies the document.
        /// </summary>
        public static object ServerTimestamp { get; } = SentinelValue.ServerTimestamp;

        /// <summary>
        /// Sentinel value indicating that the field should be deleted from the document.
        /// </summary>
        public static object Delete { get; } = SentinelValue.Delete;

        /// <summary>
        /// Creates a sentinel value to indicate the union of the given values with an array.
        /// </summary>
        /// <param name="values">The values to include in the resulting sentinel value. Must not be null.</param>
        /// <returns>A sentinel value representing an array union.</returns>
        public static object ArrayUnion(params object[] values) =>
            SentinelValue.ForArrayValue(SentinelKind.ArrayUnion, values);

        /// <summary>
        /// Creates a sentinel value to indicate the removal of the given values with an array.
        /// </summary>
        /// <param name="values">The values to include in the resulting sentinel value. Must not be null.</param>
        /// <returns>A sentinel value representing an array removal.</returns>
        public static object ArrayRemove(params object[] values) =>
            SentinelValue.ForArrayValue(SentinelKind.ArrayRemove, values);
    }
}
