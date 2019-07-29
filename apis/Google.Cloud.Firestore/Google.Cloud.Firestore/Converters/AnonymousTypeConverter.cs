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
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BclType = System.Type;

namespace Google.Cloud.Firestore.Converters
{
    /// <summary>
    /// A converter for an anonymous type. Currently this only performs serialization, not deserialization.
    /// Using anonymous types for deserialization would be unusual in terms of the C# required, but not
    /// entirely infeasible. We can implement this if we're ever asked for it.
    /// </summary>
    internal sealed class AnonymousTypeConverter : MapConverterBase
    {
        private readonly IReadOnlyList<PropertyInfo> _properties;

        internal AnonymousTypeConverter(BclType targetType) : base(targetType)
        {
            _properties = targetType.GetTypeInfo().DeclaredProperties.ToList();
        }

        public override void SerializeMap(SerializationContext context, object value, IDictionary<string, Value> map)
        {
            foreach (var property in _properties)
            {
                map[property.Name] = ValueSerializer.Serialize(context, property.GetValue(value));
            }
        }
    }
}
