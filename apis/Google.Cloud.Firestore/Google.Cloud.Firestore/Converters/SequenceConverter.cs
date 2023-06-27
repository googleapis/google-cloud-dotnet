// Copyright 2020, Google LLC
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

using Google.Cloud.Firestore.V1;
using Google.Protobuf.Collections;
using System;
using BclType = System.Type;

namespace Google.Cloud.Firestore.Converters
{
    /// <summary>
    /// List converter that only supports serialization. This is used by
    /// <see cref="ConverterCache"/> as a final option when we know something can
    /// be iterated over, but that's all. We can't deserialize to it, but that may well be okay.
    /// </summary>
    internal sealed class SequenceConverter : ListConverterBase
    {
        internal SequenceConverter(BclType targetType) : base(targetType)
        {
        }

        protected override object DeserializeArray(IDeserializationContext context, RepeatedField<Value> values) =>
            throw new NotSupportedException($"Type {TargetType} cannot be used for deserialization; only serialization.");
    }
}
