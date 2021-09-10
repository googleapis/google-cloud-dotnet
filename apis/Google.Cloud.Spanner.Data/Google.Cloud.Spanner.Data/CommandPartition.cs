// Copyright 2018 Google Inc. All Rights Reserved.
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
using Google.Cloud.Spanner.V1;
using Google.Protobuf;
using System;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Represents a partition of data upon which a <see cref="SpannerCommand"/> will execute.
    /// Partitions are useful for parallelizing large operations across several tasks or processes.
    /// </summary>
    public sealed class CommandPartition : IEquatable<CommandPartition>
    {
        internal CommandPartition(ReadOrQueryRequest request)
        {
            Request = GaxPreconditions.CheckNotNull(request, nameof(request));
        }

        /// <summary>
        /// The Id for the set of data to be included when the <see cref="SpannerCommand"/> executes.
        /// </summary>
        public string PartitionId => Request.PartitionToken?.ToBase64();

        internal ReadOrQueryRequest Request { get; }

        internal CommandPartition Clone()
        {
            return new CommandPartition(Request.CloneRequest());
        }

        /// <summary>
        /// Serializes this command partition as base64 text.
        /// </summary>
        /// <remarks>
        /// After partitioning a query, the partitions can be serialized using this method, then deserialized
        /// with <see cref="FromBase64String(string)"/> on multiple machines, allowing parallel processing.
        /// </remarks>
        /// <returns>The base64 representation of this partition.</returns>
        public string ToBase64String()
            => Request?.ToByteString().ToBase64();

        /// <summary>
        /// Creates a new <see cref="CommandPartition"/> based on the text returned by a previous
        /// call to <see cref="ToBase64String"/>.
        /// </summary>
        /// <param name="base64String">The base64 representation of the command partition. Must not be null.</param>
        /// <returns>The <see cref="CommandPartition"/> representation of the partition.</returns>
        public static CommandPartition FromBase64String(string base64String)
        {
            GaxPreconditions.CheckNotNull(base64String, nameof(base64String));
            try
            {
                var request = ExecuteSqlRequest.Parser.ParseFrom(ByteString.FromBase64(base64String));
                return new CommandPartition(ReadOrQueryRequest.FromQueryRequest(request));
            }
            catch (Exception)
            {
                // ignore and try to parse as a ReadRequest.
                return new CommandPartition(ReadOrQueryRequest.FromReadRequest(ReadRequest.Parser.ParseFrom(ByteString.FromBase64(base64String))));
            }
        }

        /// <inheritdoc />
        public bool Equals(CommandPartition other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            return ReferenceEquals(this, other) || Equals(Request, other.Request);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            return obj is CommandPartition commandPartition && Equals(commandPartition);
        }

        /// <inheritdoc />
        public override int GetHashCode() => Request?.GetHashCode() ?? 0;
    }
}
