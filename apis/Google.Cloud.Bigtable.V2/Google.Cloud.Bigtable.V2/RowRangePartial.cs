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
    public partial class RowRange
    {
        /// <summary>
        /// Creates a <see cref="RowRange"/> instance with inclusive bounds.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so the ranges can
        /// be specified using strings as well and their UTF-8 representations will be used for the key.
        /// </para>
        /// </remarks>
        /// <param name="startKeyClosed">
        /// The inclusive lower bound for the range. If null or empty, it is interpreted as the empty string.
        /// </param>
        /// <param name="endKeyClosed">
        /// The inclusive upper bound for the range. If null or empty, it is interpreted as the infinite row key.
        /// </param>
        /// <returns>The created range.</returns>
        public static RowRange Closed(BigtableByteString? startKeyClosed, BigtableByteString? endKeyClosed) =>
            new RowRange
            {
                StartKeyClosed = (ByteString)startKeyClosed ?? ByteString.Empty,
                EndKeyClosed = (ByteString)endKeyClosed ?? ByteString.Empty
            };

        /// <summary>
        /// Creates a <see cref="RowRange"/> instance with an inclusive lower bound and an exclusive upper bound.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so the ranges can
        /// be specified using strings as well and their UTF-8 representations will be used for the key.
        /// </para>
        /// </remarks>
        /// <param name="startKeyClosed">
        /// The inclusive lower bound for the range. If null or empty, it is interpreted as the empty string.
        /// </param>
        /// <param name="endKeyOpen">
        /// The exclusive upper bound for the range. If null or empty, it is interpreted as the infinite row key.
        /// </param>
        /// <returns>The created range.</returns>
        public static RowRange ClosedOpen(BigtableByteString? startKeyClosed, BigtableByteString? endKeyOpen) =>
            new RowRange
            {
                StartKeyClosed = (ByteString)startKeyClosed ?? ByteString.Empty,
                EndKeyOpen = (ByteString)endKeyOpen ?? ByteString.Empty
            };

        /// <summary>
        /// Creates a <see cref="RowRange"/> instance with exclusive bounds.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so the ranges can
        /// be specified using strings as well and their UTF-8 representations will be used for the key.
        /// </para>
        /// </remarks>
        /// <param name="startKeyOpen">
        /// The exclusive lower bound for the range. If null or empty, it is interpreted as the empty string.
        /// </param>
        /// <param name="endKeyOpen">
        /// The exclusive upper bound for the range. If null or empty, it is interpreted as the infinite row key.
        /// </param>
        /// <returns>The created range.</returns>
        public static RowRange Open(BigtableByteString? startKeyOpen, BigtableByteString? endKeyOpen) =>
            new RowRange
            {
                StartKeyOpen = (ByteString)startKeyOpen ?? ByteString.Empty,
                EndKeyOpen = (ByteString)endKeyOpen ?? ByteString.Empty
            };

        /// <summary>
        /// Creates a <see cref="RowRange"/> instance with an exclusive lower bound and an inclusive upper bound.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so the ranges can
        /// be specified using strings as well and their UTF-8 representations will be used for the key.
        /// </para>
        /// </remarks>
        /// <param name="startKeyOpen">
        /// The exclusive lower bound for the range. If null or empty, it is interpreted as the empty string.
        /// </param>
        /// <param name="endKeyClosed">
        /// The inclusive upper bound for the range. If null or empty, it is interpreted as the infinite row key.
        /// </param>
        /// <returns>The created range.</returns>
        public static RowRange OpenClosed(BigtableByteString? startKeyOpen, BigtableByteString? endKeyClosed) =>
            new RowRange
            {
                StartKeyOpen = (ByteString)startKeyOpen ?? ByteString.Empty,
                EndKeyClosed = (ByteString)endKeyClosed ?? ByteString.Empty
            };
    }
}
