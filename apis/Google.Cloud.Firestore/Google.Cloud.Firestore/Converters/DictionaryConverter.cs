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
using System;
using System.Collections.Generic;
using System.Reflection;
using BclType = System.Type;

namespace Google.Cloud.Firestore.Converters
{
    /// <summary>
    /// Base class for dictionary-based map values.
    /// </summary>
    /// <typeparam name="TValue">Type of values in the dictionary.</typeparam>
    internal sealed class DictionaryConverter<TValue> : MapConverterBase
    {
        private readonly BclType _concreteType;

        internal DictionaryConverter(BclType targetType) : base(targetType)
        {
            _concreteType = targetType;
            // If we've been asked to deserialize to an interface, let's just see if Dictionary<,>
            // would work, but otherwise give up.
            if (targetType.GetTypeInfo().IsInterface)
            {
                var candidateType = typeof(Dictionary<string, TValue>);
                if (targetType.IsAssignableFrom(candidateType))
                {
                    _concreteType = candidateType;
                }
                else
                {
                    throw new ArgumentException($"Unable to deserialize map to {targetType}");
                }
            }
        }

        public override object DeserializeMap(IDeserializationContext context, IDictionary<string, Value> values)
        {
            // TODO: Compile an expression tree on construction, or at least accept an optional delegate for construction
            // (allowing for special-casing of Dictionary<string, object>).
            var ret = (IDictionary<string, TValue>) Activator.CreateInstance(_concreteType);
            foreach (var pair in values)
            {
                ret.Add(pair.Key, (TValue) ValueDeserializer.Deserialize(context, pair.Value, typeof(TValue)));
            }
            return ret;
        }

        public override void SerializeMap(SerializationContext context, object value, IDictionary<string, Value> map)
        {
            var dictionary = (IDictionary<string, TValue>) value;
            foreach (var pair in dictionary)
            {
                map[pair.Key] = ValueSerializer.Serialize(context, pair.Value);
            }
        }
    }
}
