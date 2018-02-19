// Copyright 2018 Google LLC
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

using Google.Protobuf.WellKnownTypes;
using System;
using TypeCode = Google.Cloud.Spanner.V1.TypeCode;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Class to represent a value which should be replaced with a commit timestamp.
    /// Currently a singleton, but that could change if necessary.
    /// </summary>
    internal sealed class CommitTimestamp
    {
        internal static CommitTimestamp Instance { get; } = new CommitTimestamp();

        internal const string ProtoStringValue = "spanner.commit_timestamp()";

        private CommitTimestamp()
        {
        }

        internal Value ToProtobufValue(SpannerDbType type) =>
            type.TypeCode == TypeCode.Timestamp
                ? new Value { StringValue = ProtoStringValue }
                : throw new InvalidOperationException(
                    $"{nameof(SpannerParameter.CommitTimestamp)} is only valid for {nameof(SpannerDbType.Timestamp)} parameters");

        public override string ToString() => "Commit timestamp";
    }
}
