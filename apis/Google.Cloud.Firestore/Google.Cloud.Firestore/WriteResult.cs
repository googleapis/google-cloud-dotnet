// Copyright 2017, Google Inc. All rights reserved.
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

using Google.Api.Gax;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// The result of a write operation, in terms of the server's update time.
    /// </summary>
    public sealed class WriteResult
    {
        /// <summary>
        /// The update time as exposed by the server. This can be used to create
        /// a precondition using <see cref="Precondition.LastUpdated(Timestamp)"/>.
        /// </summary>
        public Timestamp UpdateTime { get; }

        private WriteResult(Timestamp updateTime)
        {
            UpdateTime = updateTime;
        }

        internal static WriteResult FromProto(V1.WriteResult result, wkt::Timestamp commitTime)
        {
            GaxPreconditions.CheckNotNull(result, nameof(result));
            GaxPreconditions.CheckNotNull(commitTime, nameof(commitTime));
            return new WriteResult(Timestamp.FromProto(result.UpdateTime ?? commitTime));
        }
    }
}
