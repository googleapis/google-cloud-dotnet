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

namespace Google.Cloud.Bigtable.V2
{
    public partial class Cell
    {
        /// <summary>
        /// Gets the version of the cell, which uniquely identifies it within its column.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note: version values are stored on the server as if they are microseconds since the Unix epoch.
        /// However, the server only supports millisecond granularity, so the server only allows microseconds
        /// in multiples of 1,000. <see cref="BigtableVersion"/> attempts to hide this complexity by exposing
        /// its underlying <see cref="Value"/> in terms of milliseconds, so if desired, a custom versioning
        /// scheme of 1, 2, ... can be used rather than 1000, 2000, ... However, access to the underlying
        /// microsecond value is still provided via <see cref="BigtableVersion.Micros"/>.
        /// </para>
        /// <para>
        /// Note: when using ReadModifyWriteRow, modified columns automatically use a server version, which
        /// is based on the current timestamp since the Unix epoch. For those columns, other reads and writes
        /// should use <see cref="BigtableVersion"/> values constructed from DateTime values, as opposed to
        /// using a custom versioning scheme with 64-bit values.
        /// </para>
        /// </remarks>
        public BigtableVersion Version => BigtableVersion.FromMicros(TimestampMicros);
    }
}
