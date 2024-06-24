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
        /// This overload assumes that any custom serializers are configured via attributes. Use the overload
        /// accepting a <see cref="FirestoreDb" /> if you need to use database-registered custom serializers.
        /// </summary>
        /// <param name="values">The values to include in the resulting sentinel value. Must not be null.</param>
        /// <returns>A sentinel value representing an array union.</returns>
        public static object ArrayUnion(params object[] values) =>
            SentinelValue.ForArrayValue(SerializationContext.Default, SentinelKind.ArrayUnion, values);

        /// <summary>
        /// Creates a sentinel value to indicate the removal of the given values with an array.
        /// This overload assumes that any custom serializers are configured via attributes. Use the overload
        /// accepting a <see cref="FirestoreDb" /> if you need to use database-registered custom serializers.
        /// </summary>
        /// <param name="values">The values to include in the resulting sentinel value. Must not be null.</param>
        /// <returns>A sentinel value representing an array removal.</returns>
        public static object ArrayRemove(params object[] values) =>
            SentinelValue.ForArrayValue(SerializationContext.Default, SentinelKind.ArrayRemove, values);

        /// <summary>
        /// Creates a sentinel value to indicate the union of the given values with an array.
        /// </summary>
        /// <param name="database">Database to check for custom serialization.</param>
        /// <param name="values">The values to include in the resulting sentinel value. Must not be null.</param>
        /// <returns>A sentinel value representing an array union.</returns>
        public static object ArrayUnion(FirestoreDb database, params object[] values) =>
            SentinelValue.ForArrayValue(GaxPreconditions.CheckNotNull(database, nameof(database)).SerializationContext, SentinelKind.ArrayUnion, values);

        /// <summary>
        /// Creates a sentinel value to indicate the removal of the given values with an array. This over
        /// </summary>
        /// <param name="database">Database to check for custom serialization.</param>
        /// <param name="values">The values to include in the resulting sentinel value. Must not be null.</param>
        /// <returns>A sentinel value representing an array removal.</returns>
        public static object ArrayRemove(FirestoreDb database, params object[] values) =>
            SentinelValue.ForArrayValue(GaxPreconditions.CheckNotNull(database, nameof(database)).SerializationContext, SentinelKind.ArrayRemove, values);

        /// <summary>
        /// Creates a sentinel value to indicate an increment by the given value.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the current field value is an integer, possible integer overflows are resolved to
        /// <see cref="long.MaxValue"/> or <see cref="long.MinValue"/>. If the current field value
        /// is a double, both values will be interpreted as doubles and the arithmetic will follow IEEE 754 semantics.
        /// </para>
        /// <para>
        /// If the current field is not an integer or double, or if the field does not yet exist, the
        /// transformation will set the field to the given value.
        /// </para>
        /// </remarks>
        /// <param name="amount">The amount to increment the field by.</param>
        /// <returns>A sentinel value representing a field increment.</returns>
        public static object Increment(long amount) =>
            SentinelValue.ForIncrement(new Value { IntegerValue = amount });

        /// <summary>
        /// Creates a sentinel value to indicate an increment by the given value.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the current value is an integer or a double, both the current and the given value will be
        /// interpreted as doubles and all arithmetic will follow IEEE 754 semantics.Otherwise, the
        /// transformation will set the field to the given value.
        /// </para>
        /// </remarks>
        /// <param name="amount">The amount to increment the field by.</param>
        /// <returns>A sentinel value representing a field increment.</returns>
        public static object Increment(double amount) =>
            SentinelValue.ForIncrement(new Value { DoubleValue = amount });
    }
}
