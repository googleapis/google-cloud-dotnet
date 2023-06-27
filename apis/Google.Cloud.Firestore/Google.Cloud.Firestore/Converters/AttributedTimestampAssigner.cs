// Copyright 2019, Google LLC
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
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using BclType = System.Type;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Firestore.Converters
{
    /// <summary>
    /// Copies a snapshot's create/update/read timestamps to attributed properties.
    /// </summary>
    internal static class AttributedTimestampAssigner
    {
        private static readonly Dictionary<BclType, Func<Timestamp?, object>> s_converters = new Dictionary<BclType, Func<Timestamp?, object>>
        {
            { typeof(Timestamp?), timestamp => timestamp },
            { typeof(Timestamp), timestamp => timestamp ?? default },
            { typeof(DateTime?), timestamp => timestamp?.ToDateTime() },
            { typeof(DateTime), timestamp => timestamp?.ToDateTime() ?? default },
            { typeof(DateTimeOffset?), timestamp => timestamp?.ToDateTimeOffset() },
            { typeof(DateTimeOffset), timestamp => timestamp?.ToDateTimeOffset() ?? default },
            { typeof(wkt::Timestamp), timestamp => timestamp?.ToProto() },
        };
        
        private static readonly ConcurrentDictionary<BclType, Action<object, IDeserializationContext>> s_assigners =
            new ConcurrentDictionary<BclType, Action<object, IDeserializationContext>>();

        internal static void MaybeAssignTimestamps(object value, IDeserializationContext context)
        {
            if (value == null)
            {
                return;
            }
            var assigner = s_assigners.GetOrAdd(value.GetType(), MaybeCreateAssigner);
            assigner?.Invoke(value, context);
        }

        /// <summary>
        /// Returns an action (potentially multicast) to copy timestamps from a document snapshot to object properties.
        /// </summary>
        /// <param name="type">The type to inspect for ID properties.</param>
        /// <returns>An assigner, or null if the type doesn't need any timestamp assignments performed on it.</returns>
        private static Action<object, IDeserializationContext> MaybeCreateAssigner(BclType type)
        {
            var typeInfo = type.GetTypeInfo();
            if (!typeInfo.IsDefined(typeof(FirestoreDataAttribute)))
            {
                return null;
            }

            Action<object, IDeserializationContext> assigner = null;
            // We look for static properties specifically to find problems. We'll never use static properties.
            foreach (var property in typeInfo.GetProperties(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
            {
                bool hasAttribute = false;
                assigner += MaybeCreateAssigner<FirestoreDocumentCreateTimestampAttribute>(property, context => context.CreateTime, ref hasAttribute);
                assigner += MaybeCreateAssigner<FirestoreDocumentUpdateTimestampAttribute>(property, context => context.UpdateTime, ref hasAttribute);
                assigner += MaybeCreateAssigner<FirestoreDocumentReadTimestampAttribute>(property, context => context.ReadTime, ref hasAttribute);
            }
            return assigner;
        }

        private static Action<object, IDeserializationContext> MaybeCreateAssigner<T>(PropertyInfo property, Func<IDeserializationContext, Timestamp?> timestampSelector, ref bool hasAttribute)
            where T : Attribute
        {
            string typeName = property.DeclaringType.FullName;
            T attribute = property.GetCustomAttribute<T>(inherit: true);
            if (attribute == null)
            {
                return null;
            }
            var setMethod = property.GetSetMethod(nonPublic: true);
            GaxPreconditions.CheckState(setMethod != null,
                "{0}.{1} has no setter, and should not be decorated with {2}.",
                typeName, property.Name, typeof(T).Name);
            GaxPreconditions.CheckState(!setMethod.IsStatic,
                "{0}.{1} is static, and should not be decorated with {2}.",
                typeName, property.Name, typeof(T).Name);
            GaxPreconditions.CheckState(setMethod.GetParameters().Length == 1,
                "{0}.{1} is an indexer, and should not be decorated with {2}.",
                typeName, property.Name, typeof(T).Name);
            GaxPreconditions.CheckState(!property.IsDefined(typeof(FirestorePropertyAttribute)),
                "{0}.{1} is decorated with FirestorePropertyAttribute, and should not be decorated with {2}.",
                typeName, property.Name, typeof(T).Name);

            // Check we haven't already seen a timestamp attribute
            GaxPreconditions.CheckState(!hasAttribute,
                "{0}.{1} is decorated with multiple timestamp attributes",
                typeName, property.Name);
            
            // Prohibit later attributes from being applied.
            hasAttribute = true;

            bool validType = s_converters.TryGetValue(property.PropertyType, out var converter);
            GaxPreconditions.CheckState(validType,
                "{0}.{1} does not have a suitable type for {2}.",
                typeName, property.Name, typeof(T).Name);

            return (value, context) => property.SetValue(value, converter(timestampSelector(context)));
        }
    }
}
