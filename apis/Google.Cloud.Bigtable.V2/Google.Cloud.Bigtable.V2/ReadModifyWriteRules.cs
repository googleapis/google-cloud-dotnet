// Copyright 2017 Google Inc. All rights reserved.
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

using Google.Cloud.Bigtable.Common.V2;
using Google.Protobuf;
using System;

namespace Google.Cloud.Bigtable.V2
{
    /// <summary>
    /// Static class with convenience methods for creating various kinds of <see cref="ReadModifyWriteRule"/> instances.
    /// </summary>
    public static class ReadModifyWriteRules
    {
        /// <summary>
        /// Rule specifying that <paramref name="appendValue"/> be appended to the existing value.
        /// If the targeted cell is unset, it will be treated as containing the empty string.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>,
        /// so <paramref name="columnQualifier"/> can be specified using a string as well and
        /// its UTF-8 representations will be used.
        /// </para>
        /// </remarks>
        /// <param name="familyName">
        /// The name of the family to which the read/modify/write should be applied.
        /// Must match `[-_.a-zA-Z0-9]+`
        /// </param>
        /// <param name="columnQualifier">
        /// The qualifier of the column to which the read/modify/write should be
        /// applied. Can be any byte string, including the empty string.
        /// </param>
        /// <param name="appendValue">
        /// The value to append to the existing cell value.
        /// </param>
        /// <returns>
        /// The append value rule.
        /// </returns>
        public static ReadModifyWriteRule Append(
            string familyName, BigtableByteString columnQualifier, BigtableByteString appendValue) =>
            new ReadModifyWriteRule
            {
                FamilyName = Utilities.ValidateFamilyName(familyName),
                ColumnQualifier = columnQualifier.Value,
                AppendValue = appendValue.Value
            };
        
        /// <summary>
        /// Rule specifying that <paramref name="incrementAmount"/> be added to the existing value.
        /// If the targeted cell is unset, it will be treated as containing a zero.
        /// Otherwise, the targeted cell must contain an 8-byte value (interpreted
        /// as a 64-bit big-endian signed integer), or the entire request will fail.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>,
        /// so <paramref name="columnQualifier"/> can be specified using a string as well and
        /// its UTF-8 representations will be used.
        /// </para>
        /// </remarks>
        /// <param name="familyName">
        /// The name of the family to which the read/modify/write should be applied.
        /// Must match `[-_.a-zA-Z0-9]+`
        /// </param>
        /// <param name="columnQualifier">
        /// The qualifier of the column to which the read/modify/write should be
        /// applied. Can be any byte string, including the empty string.
        /// </param>
        /// <param name="incrementAmount">
        /// The amount to increment the existing cell value.
        /// </param>
        /// <returns>
        /// The increment amount rule.
        /// </returns>
        public static ReadModifyWriteRule Increment(
            string familyName, BigtableByteString columnQualifier, long incrementAmount) =>
            new ReadModifyWriteRule
            {
                FamilyName = Utilities.ValidateFamilyName(familyName),
                ColumnQualifier = columnQualifier.Value,
                IncrementAmount = incrementAmount
            };
    }
}
