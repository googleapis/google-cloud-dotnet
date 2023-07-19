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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using BclType = System.Type;

namespace Google.Cloud.Firestore.Converters
{
    /// <summary>
    /// Converter for <see cref="IList"/>-based types. (Note that this doesn't handle types that
    /// implement the generic <see cref="IList{T}"/> interface without the non-generic one.)
    /// This type handles deserialization; the base type handles serialization.
    /// </summary>
    internal sealed class ListConverter : ListConverterBase
    {
        private readonly BclType _elementType;

        internal ListConverter(BclType targetType) : base(targetType)
        {
            // We could make this type generic, like DictionaryConverter. There's a difference
            // in that we don't need a generic interface in the conversion code here.
            var interfaces = targetType.GetTypeInfo().GetInterfaces();

            var genericListInterface = interfaces.Select(t => t.GetTypeInfo()).FirstOrDefault(iface => iface.IsGenericType && iface.GetGenericTypeDefinition() == typeof(IList<>));
            // Just use object if the type isn't actually generic.
            _elementType = genericListInterface?.GenericTypeArguments[0] ?? typeof(object);
        }

        protected override object DeserializeArray(IDeserializationContext context, RepeatedField<Value> values)
        {
            // TODO: See if using a compiled expression tree is faster.
            var list = (IList) Activator.CreateInstance(TargetType);
            foreach (var value in values)
            {
                var deserialized = ValueDeserializer.Deserialize(context, value, _elementType);
                list.Add(deserialized);
            }
            return list;
        }
    }
}
