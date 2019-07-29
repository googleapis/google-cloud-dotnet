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

using BclType = System.Type;

namespace Google.Cloud.Firestore.Converters
{
    /// <summary>
    /// Base class for types that always serialize to a map value.
    /// Derived classes need to implement deserialization as well as overriding
    /// <see cref="ConverterBase.SerializeMap(SerializationContext, object, System.Collections.Generic.IDictionary{string, Value})"/>,
    /// which is called by this class's implementation of <see cref="Serialize(SerializationContext, object)"/>.
    /// </summary>
    internal abstract class MapConverterBase : ConverterBase
    {
        internal MapConverterBase(BclType targetType) : base(targetType)
        {
        }

        public override Value Serialize(SerializationContext context, object value)
        {
            var proto = new Value { MapValue = new MapValue() };
            SerializeMap(context, value, proto.MapValue.Fields);
            return proto;
        }
    }
}
