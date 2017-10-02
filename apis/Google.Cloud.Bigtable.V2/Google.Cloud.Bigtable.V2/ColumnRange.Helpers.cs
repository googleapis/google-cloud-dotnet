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

using System;
using System.Collections.Generic;
using System.Text;

namespace Google.Cloud.Bigtable.V2
{
    public partial class ColumnRange
    {

        /// <summary>
        /// Creates a <see cref="ColumnRange"/> instance with inclusive bounds.
        /// </summary>
        /// <param name="familyName">
        /// The name of the column family within which this range falls.
        /// </param>
        /// <param name="startQualifierClosed">
        /// The inclusive upper bound for the range. If null, it is interpreted as the infinite row key.
        /// </param>
        /// <param name="endQualifierClosed">
        /// The inclusive lower bound for the range. If null, it is interpreted as the empty string.
        /// </param>
        /// <returns>The created range.</returns>
        public static RowFilter Closed(
            string familyName, ColumnQualifier startQualifierClosed, ColumnQualifier endQualifierClosed)
        {
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Creates a <see cref="RowRange"/> instance with an inclusive lower bound and an exclusive upper bound.
        /// </summary>
        /// <param name="familyName">
        /// The name of the column family within which this range falls.
        /// </param>
        /// <param name="startQualifierClosed">
        /// The inclusive upper bound for the range. If null, it is interpreted as the infinite row key.
        /// </param>
        /// <param name="endQualifierOpen">
        /// The exclusive upper bound for the range. If null, it is interpreted as the infinite row key.
        /// </param>
        /// <returns>The created range.</returns>
        public static RowFilter ClosedOpen(
            string familyName, ColumnQualifier startQualifierClosed, ColumnQualifier endQualifierOpen)
        {
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Creates a <see cref="RowRange"/> instance with exclusive bounds.
        /// </summary>
        /// <param name="familyName">
        /// The name of the column family within which this range falls.
        /// </param>
        /// <param name="startQualifierOpen">
        /// The exclusive lower bound for the range. If null, it is interpreted as the empty string.
        /// </param>
        /// <param name="endQualifierOpen">
        /// The exclusive upper bound for the range. If null, it is interpreted as the infinite row key.
        /// </param>
        /// <returns>The created range.</returns>
        public static RowFilter Open(
            string familyName, ColumnQualifier startQualifierOpen, ColumnQualifier endQualifierOpen)
        {
            // TODO: The missing start key is the empty string, inclusive, so we must explicitly set the start key open to the empty string here when it is null.
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Creates a <see cref="RowRange"/> instance with an exclusive lower bound and an inclusive upper bound.
        /// </summary>
        /// <param name="familyName">
        /// The name of the column family within which this range falls.
        /// </param>
        /// <param name="startQualifierOpen">
        /// The exclusive lower bound for the range. If null, it is interpreted as the empty string.
        /// </param>
        /// <param name="endQualifierClosed">
        /// The inclusive lower bound for the range. If null, it is interpreted as the empty string.
        /// </param>
        /// <returns>The created range.</returns>
        public static RowFilter OpenClosed(
            string familyName, ColumnQualifier startQualifierOpen, ColumnQualifier endQualifierClosed)
        {
            // TODO: The missing start key is the empty string, inclusive, so we must explicitly set the start key open to the empty string here when it is null.
            throw new InvalidOperationException();
        }

    }
}
