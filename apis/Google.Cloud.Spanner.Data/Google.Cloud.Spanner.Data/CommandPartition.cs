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

using System;
using System.Runtime.Serialization;
using Google.Cloud.Spanner.V1;
using Google.Protobuf;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Represents a partition of data upon which a <see cref="SpannerCommand"/> will execute.
    /// Partitions are useful for parallelizing large operations across several tasks or processes.
    /// </summary>
    public sealed class CommandPartition : IEquatable<CommandPartition>
    {
        internal CommandPartition(ExecuteSqlRequest executeSqlRequest)
        {
            ExecuteSqlRequest = executeSqlRequest;
        }

        /// <summary>
        /// The Id for the set of data to be included when the <see cref="SpannerCommand"/> executes.
        /// </summary>
        public string PartitionId => ExecuteSqlRequest?.PartitionToken?.ToBase64();

        internal ExecuteSqlRequest ExecuteSqlRequest { get; }

        internal CommandPartition Clone()
        {
            return new CommandPartition(ExecuteSqlRequest.Clone());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string ToBase64String()
        {
            return ExecuteSqlRequest.ToByteString().ToBase64();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="base64String"></param>
        /// <returns></returns>
        public static CommandPartition FromBase64String(string base64String)
        {
            return new CommandPartition(ExecuteSqlRequest.Parser.ParseFrom(ByteString.FromBase64(base64String)));
        }

        /// <inheritdoc />
        public bool Equals(CommandPartition other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            return ReferenceEquals(this, other) || Equals(ExecuteSqlRequest, other.ExecuteSqlRequest);
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
            var commandPartition = obj as CommandPartition;
            return commandPartition != null && Equals(commandPartition);
        }

        /// <inheritdoc />
        public override int GetHashCode() => ExecuteSqlRequest?.GetHashCode() ?? 0;
    }
}
