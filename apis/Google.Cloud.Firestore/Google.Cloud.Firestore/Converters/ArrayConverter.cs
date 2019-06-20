// Copyright 2018, Google LLC
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
    /// Converter for array types. Serialization is handled by the base class; only custom deserialization is required.
    /// </summary>
    internal sealed class ArrayConverter : ListConverterBase
    {
        private readonly BclType _elementType;

        internal ArrayConverter(BclType elementType) : base(elementType.MakeArrayType())
        {
            _elementType = elementType;
        }

        protected override object DeserializeArray(DeserializationContext context, RepeatedField<Value> values)
        {
            Array array = Array.CreateInstance(_elementType, values.Count);
            for (int i = 0; i < values.Count; i++)
            {
                var converted = ValueDeserializer.Deserialize(context, values[i], _elementType);
                array.SetValue(converted, i);
            }
            return array;
        }
    }
}
