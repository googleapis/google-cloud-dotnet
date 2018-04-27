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
using System.Collections.Generic;
using System.Text;

namespace Google.Cloud.Bigtable.V2
{
    public partial class ColumnRange
    {
        /// <summary>
        /// Creates a <see cref="ColumnRange"/> instance with inclusive bounds.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so the ranges can
        /// be specified using strings as well and their UTF-8 representations will be used for the qualifier.
        /// </para>
        /// </remarks>
        /// <param name="familyName">
        /// The name of the column family within which this range falls.
        /// Must match `[-_.a-zA-Z0-9]+`
        /// </param>
        /// <param name="startQualifierClosed">
        /// The inclusive lower bound for the range. If null or empty, it is interpreted as the empty string.
        /// </param>
        /// <param name="endQualifierClosed">
        /// The inclusive upper bound for the range. If null or empty, it is interpreted as the infinite qualifier.
        /// </param>
        /// <returns>The created range.</returns>
        public static ColumnRange Closed(
            string familyName, BigtableByteString? startQualifierClosed, BigtableByteString? endQualifierClosed) =>
            new ColumnRange
            {
                FamilyName = Utilities.ValidateFamilyName(familyName),
                StartQualifierClosed = (ByteString)startQualifierClosed ?? ByteString.Empty,
                EndQualifierClosed = (ByteString)endQualifierClosed ?? ByteString.Empty
            };

        /// <summary>
        /// Creates a <see cref="ColumnRange"/> instance with an inclusive lower bound and an exclusive upper bound.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so the ranges can
        /// be specified using strings as well and their UTF-8 representations will be used for the qualifier.
        /// </para>
        /// </remarks>
        /// <param name="familyName">
        /// The name of the column family within which this range falls.
        /// Must match `[-_.a-zA-Z0-9]+`
        /// </param>
        /// <param name="startQualifierClosed">
        /// The inclusive lower bound for the range. If null or empty, it is interpreted as the empty string.
        /// </param>
        /// <param name="endQualifierOpen">
        /// The exclusive upper bound for the range. If null or empty, it is interpreted as the infinite qualifier.
        /// </param>
        /// <returns>The created range.</returns>
        public static ColumnRange ClosedOpen(
            string familyName, BigtableByteString? startQualifierClosed, BigtableByteString? endQualifierOpen) =>
            new ColumnRange
            {
                FamilyName = Utilities.ValidateFamilyName(familyName),
                StartQualifierClosed = (ByteString)startQualifierClosed ?? ByteString.Empty,
                EndQualifierOpen = (ByteString)endQualifierOpen ?? ByteString.Empty
            };

        /// <summary>
        /// Creates a <see cref="ColumnRange"/> instance with exclusive bounds.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so the ranges can
        /// be specified using strings as well and their UTF-8 representations will be used for the qualifier.
        /// </para>
        /// </remarks>
        /// <param name="familyName">
        /// The name of the column family within which this range falls.
        /// Must match `[-_.a-zA-Z0-9]+`
        /// </param>
        /// <param name="startQualifierOpen">
        /// The exclusive lower bound for the range. If null or empty, it is interpreted as the empty string.
        /// </param>
        /// <param name="endQualifierOpen">
        /// The exclusive upper bound for the range. If null or empty, it is interpreted as the infinite qualifier.
        /// </param>
        /// <returns>The created range.</returns>
        public static ColumnRange Open(
            string familyName, BigtableByteString? startQualifierOpen, BigtableByteString? endQualifierOpen) =>
            new ColumnRange
            {
                FamilyName = Utilities.ValidateFamilyName(familyName),
                StartQualifierOpen = (ByteString)startQualifierOpen ?? ByteString.Empty,
                EndQualifierOpen = (ByteString)endQualifierOpen ?? ByteString.Empty
            };

        /// <summary>
        /// Creates a <see cref="ColumnRange"/> instance with an exclusive lower bound and an inclusive upper bound.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so the ranges can
        /// be specified using strings as well and their UTF-8 representations will be used for the qualifier.
        /// </para>
        /// </remarks>
        /// <param name="familyName">
        /// The name of the column family within which this range falls.
        /// Must match `[-_.a-zA-Z0-9]+`
        /// </param>
        /// <param name="startQualifierOpen">
        /// The exclusive lower bound for the range. If null or empty, it is interpreted as the empty string.
        /// </param>
        /// <param name="endQualifierClosed">
        /// The inclusive upper bound for the range. If null or empty, it is interpreted as the infinite qualifier.
        /// </param>
        /// <returns>The created range.</returns>
        public static ColumnRange OpenClosed(
            string familyName, BigtableByteString? startQualifierOpen, BigtableByteString? endQualifierClosed) =>
            new ColumnRange
            {
                FamilyName = Utilities.ValidateFamilyName(familyName),
                StartQualifierOpen = (ByteString)startQualifierOpen ?? ByteString.Empty,
                EndQualifierClosed = (ByteString)endQualifierClosed ?? ByteString.Empty
            };
    }
}
