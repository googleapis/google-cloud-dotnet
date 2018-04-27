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
    public partial class ValueRange
    {
        /// <summary>
        /// Creates a <see cref="ValueRange"/> instance with inclusive bounds.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so the ranges can
        /// be specified using strings as well and their UTF-8 representations will be used for the value.
        /// </para>
        /// </remarks>
        /// <param name="startValueClosed">
        /// The inclusive lower bound for the range. If null or empty, it is interpreted as the empty string.
        /// </param>
        /// <param name="endValueClosed">
        /// The inclusive upper bound for the range. If null or empty, it is interpreted as the infinite value.
        /// </param>
        /// <returns>The created range.</returns>
        public static ValueRange Closed(BigtableByteString? startValueClosed, BigtableByteString? endValueClosed) =>
            new ValueRange
            {
                StartValueClosed = (ByteString)startValueClosed ?? ByteString.Empty,
                EndValueClosed = (ByteString)endValueClosed ?? ByteString.Empty
            };

        /// <summary>
        /// Creates a <see cref="ValueRange"/> instance with an inclusive lower bound and an exclusive upper bound.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so the ranges can
        /// be specified using strings as well and their UTF-8 representations will be used for the value.
        /// </para>
        /// </remarks>
        /// <param name="startValueClosed">
        /// The inclusive lower bound for the range. If null or empty, it is interpreted as the empty string.
        /// </param>
        /// <param name="endValueOpen">
        /// The exclusive upper bound for the range. If null or empty, it is interpreted as the infinite value.
        /// </param>
        /// <returns>The created range.</returns>
        public static ValueRange ClosedOpen(BigtableByteString? startValueClosed, BigtableByteString? endValueOpen) =>
            new ValueRange
            {
                StartValueClosed = (ByteString)startValueClosed ?? ByteString.Empty,
                EndValueOpen = (ByteString)endValueOpen ?? ByteString.Empty
            };

        /// <summary>
        /// Creates a <see cref="ValueRange"/> instance with exclusive bounds.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so the ranges can
        /// be specified using strings as well and their UTF-8 representations will be used for the value.
        /// </para>
        /// </remarks>
        /// <param name="startValueOpen">
        /// The exclusive lower bound for the range. If null or empty, it is interpreted as the empty string.
        /// </param>
        /// <param name="endValueOpen">
        /// The exclusive upper bound for the range. If null or empty, it is interpreted as the infinite value.
        /// </param>
        /// <returns>The created range.</returns>
        public static ValueRange Open(BigtableByteString? startValueOpen, BigtableByteString? endValueOpen) =>
            new ValueRange
            {
                StartValueOpen = (ByteString)startValueOpen ?? ByteString.Empty,
                EndValueOpen = (ByteString)endValueOpen ?? ByteString.Empty
            };

        /// <summary>
        /// Creates a <see cref="ValueRange"/> instance with an exclusive lower bound and an inclusive upper bound.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so the ranges can
        /// be specified using strings as well and their UTF-8 representations will be used for the value.
        /// </para>
        /// </remarks>
        /// <param name="startValueOpen">
        /// The exclusive lower bound for the range. If null or empty, it is interpreted as the empty string.
        /// </param>
        /// <param name="endValueClosed">
        /// The inclusive upper bound for the range. If null or empty, it is interpreted as the infinite value.
        /// </param>
        /// <returns>The created range.</returns>
        public static ValueRange OpenClosed(BigtableByteString? startValueOpen, BigtableByteString? endValueClosed) =>
            new ValueRange
            {
                StartValueOpen = (ByteString)startValueOpen ?? ByteString.Empty,
                EndValueClosed = (ByteString)endValueClosed ?? ByteString.Empty
            };
    }
}
