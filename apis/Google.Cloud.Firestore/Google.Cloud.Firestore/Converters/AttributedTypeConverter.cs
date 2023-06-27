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

using Google.Api.Gax;
using Google.Cloud.Firestore.V1;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using BclType = System.Type;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Firestore.Converters
{
    internal sealed class AttributedTypeConverter : MapConverterBase
    {
        // Note: the use of a dictionary for writable properties and a list for readable ones is purely
        // driven by how we use this. If we ever want a dictionary for readable properties, that's easy to do.
        private readonly IReadOnlyDictionary<string, AttributedProperty> _writableProperties;
        private readonly IReadOnlyList<AttributedProperty> _readableProperties;
        private readonly Func<object> _createInstance;
        private readonly FirestoreDataAttribute _attribute;

        private AttributedTypeConverter(BclType targetType, FirestoreDataAttribute attribute) : base(targetType)
        {
            var typeInfo = targetType.GetTypeInfo();
            _attribute = attribute;
            
            // Check for user bugs in terms of attribute specifications.
            GaxPreconditions.CheckState(Enum.IsDefined(typeof(UnknownPropertyHandling), _attribute.UnknownPropertyHandling),
                "Type {0} has invalid {1} value", targetType.FullName, nameof(FirestoreDataAttribute.UnknownPropertyHandling));

            _createInstance = CreateObjectCreator(typeInfo);

            List<AttributedProperty> readableProperties = new List<AttributedProperty>();
            Dictionary<string, AttributedProperty> writableProperties = new Dictionary<string, AttributedProperty>();
            // We look for static properties specifically to find problems. We'll never use static properties.
            foreach (var property in typeInfo.GetProperties(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
            {
                FirestorePropertyAttribute propertyAttribute = property.GetCustomAttribute<FirestorePropertyAttribute>(inherit: true);
                if (propertyAttribute == null)
                {
                    continue;
                }
                var attributedProperty = new AttributedProperty(property, propertyAttribute);
                string firestoreName = attributedProperty.FirestoreName;

                // Note that we check readable and writable properties separately. We could theoretically have
                // two separate properties, one read-only and one write-only, with the same name in Firestore.
                if (attributedProperty.CanRead)
                {
                    // This is O(N), but done once per type so should be okay.
                    GaxPreconditions.CheckState(!readableProperties.Any(p => p.FirestoreName == firestoreName),
                        "Type {0} contains multiple readable properties with name {1}", targetType.FullName, firestoreName);
                    readableProperties.Add(attributedProperty);
                }
                if (attributedProperty.CanWrite)
                {
                    GaxPreconditions.CheckState(!writableProperties.ContainsKey(firestoreName),
                        "Type {0} contains multiple writable properties with name {1}", targetType.FullName, firestoreName);
                    writableProperties[firestoreName] = attributedProperty;
                }
            }
            _readableProperties = readableProperties.AsReadOnly();
            _writableProperties = new ReadOnlyDictionary<string, AttributedProperty>(writableProperties);
        }

        // Only used in the constructor, but extracted for readability.
        private static Func<object> CreateObjectCreator(TypeInfo typeInfo)
        {
            if (typeInfo.IsValueType)
            {
                return () => Activator.CreateInstance(typeInfo);
            }
            else
            {
                // TODO: Consider using a compiled expression tree for this.
                var ctor = typeInfo
                    .GetConstructors(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                    .SingleOrDefault(c => c.GetParameters().Length == 0);
                GaxPreconditions.CheckState(ctor != null, "Type {0} has no parameterless constructor", typeInfo.FullName);
                return () =>
                {
                    try
                    {
                        return ctor.Invoke(parameters: null);
                    }
                    catch (TargetInvocationException e) when (e.InnerException != null)
                    {
                        throw e.InnerException;
                    }
                };
            }
        }

        /// <summary>
        /// Factory method to construct a converter for an attributed type.
        /// </summary>
        internal static IFirestoreInternalConverter ForType(BclType targetType)
        {
            var typeInfo = targetType.GetTypeInfo();
            var attribute = typeInfo.GetCustomAttribute<FirestoreDataAttribute>(inherit: false);
            // This would be an internal library bug. We shouldn't be calling it in this case.
            GaxPreconditions.CheckState(attribute != null, "Type {0} is not decorated with {1}.", targetType.FullName, nameof(FirestoreDataAttribute));

            return attribute.ConverterType == null
                ? new AttributedTypeConverter(targetType, attribute)
                : CustomConverter.ForConverterType(attribute.ConverterType, targetType);
        }

        public override object DeserializeMap(IDeserializationContext context, IDictionary<string, Value> values)
        {
            object ret = _createInstance();

            foreach (var pair in values)
            {
                if (_writableProperties.TryGetValue(pair.Key, out var property))
                {
                    property.SetValue(context, pair.Value, ret);
                }
                else
                {
                    switch (_attribute.UnknownPropertyHandling)
                    {
                        case UnknownPropertyHandling.Ignore:
                            break;
                        case UnknownPropertyHandling.Warn:
                            context.Database.LogWarning($"No writable property for Firestore field {pair.Key} in type {TargetType.FullName}");
                            break;
                        case UnknownPropertyHandling.Throw:
                            throw new ArgumentException($"No writable property for Firestore field {pair.Key} in type {TargetType.FullName}");
                    }
                }
            }
            AttributedIdAssigner.MaybeAssignId(ret, context.DocumentReference);
            AttributedTimestampAssigner.MaybeAssignTimestamps(ret, context);
            return ret;
        }

        public override void SerializeMap(SerializationContext context, object value, IDictionary<string, Value> map)
        {
            foreach (var property in _readableProperties)
            {
                map[property.FirestoreName] = property.GetProtoValue(context, value);
            }
        }

        private sealed class AttributedProperty
        {
            private readonly PropertyInfo _propertyInfo;
            private readonly SentinelValue _sentinelValue;
            private readonly IFirestoreInternalConverter _converter;

            /// <summary>
            /// The name to use in Firestore serialization/deserialization. Defaults to the property
            /// name, but may be specified in <see cref="FirestorePropertyAttribute"/>.
            /// </summary>
            internal string FirestoreName { get; }
            internal bool CanRead => _propertyInfo.CanRead;
            internal bool CanWrite => _propertyInfo.CanWrite;

            internal AttributedProperty(PropertyInfo property, FirestorePropertyAttribute attribute)
            {
                _propertyInfo = property;
                FirestoreName = attribute.Name ?? property.Name;
                _sentinelValue = SentinelValue.FromPropertyAttributes(property);
                if (attribute.ConverterType != null)
                {
                    _converter = CustomConverter.ForConverterType(attribute.ConverterType, property.PropertyType);
                }

                string typeName = property.DeclaringType.FullName;
                GaxPreconditions.CheckState(property.GetIndexParameters().Length == 0,
                    "{0}.{1} is an indexer, and should not be decorated with {2}.",
                    typeName, property.Name, nameof(FirestorePropertyAttribute));

                // Annoyingly, we can't easily check whether the property is static - we have to check the individual methods.
                var getMethod = property.GetGetMethod(nonPublic: true);
                var setMethod = property.GetSetMethod(nonPublic: true);
                GaxPreconditions.CheckState(getMethod == null || !getMethod.IsStatic,
                    "{0}.{1} is static, and should not be decorated with {2}.",
                    typeName, property.Name, nameof(FirestorePropertyAttribute));
                GaxPreconditions.CheckState(setMethod == null || !setMethod.IsStatic,
                    "{0}.{1} is static, and should not be decorated with {2}.",
                    typeName, property.Name, nameof(FirestorePropertyAttribute));

                _converter = _converter ?? ValueTupleConverter.MaybeCreateConverter(property);
            }

            // TODO: Consider creating delegates for the property get/set methods.
            // Note: these methods have to handle null values when there's a custom converter involved, just like ValueSerializer/ValueDeserializer do.
            internal Value GetProtoValue(SerializationContext context, object obj)
            {
                if (_sentinelValue != null)
                {
                    return _sentinelValue.ToProtoValue();
                }
                object propertyValue = _propertyInfo.GetValue(obj);
                return _converter == null ? ValueSerializer.Serialize(context, propertyValue)
                    : propertyValue == null ? new Value { NullValue = wkt::NullValue.NullValue }
                    : _converter.Serialize(context, propertyValue);
            }

            internal void SetValue(IDeserializationContext context, Value value, object target)
            {
                object converted =
                    _converter == null ? ValueDeserializer.Deserialize(context, value, _propertyInfo.PropertyType)
                    : value.ValueTypeCase == Value.ValueTypeOneofCase.NullValue ? null
                    : _converter.DeserializeValue(context, value);
                _propertyInfo.SetValue(target, converted);
            }
        }
    }
}
