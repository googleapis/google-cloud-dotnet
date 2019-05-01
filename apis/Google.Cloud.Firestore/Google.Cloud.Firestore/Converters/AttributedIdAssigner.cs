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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using BclType = System.Type;

namespace Google.Cloud.Firestore.Converters
{
    internal sealed class AttributedIdAssigner
    {
        private static readonly ConcurrentDictionary<BclType, AttributedIdAssigner> s_assigners =
            new ConcurrentDictionary<BclType, AttributedIdAssigner>();

        private readonly List<MethodInfo> _setMethods;

        private AttributedIdAssigner(List<MethodInfo> setMethods) => _setMethods = setMethods;

        private void AssignId(object value, DocumentReference reference)
        {
            // TODO: Create delegates instead of using reflection?

            // TODO: This part is ugly... should we have a simple way of getting at this?
            var fullPath = reference.Path;
            var databasePath = reference.Database.DocumentsPath;
            // Skip the document path and the trailing slash
            var relativePath = fullPath.Substring(databasePath.Length + 1);

            var args = new object[] { relativePath };
            foreach (var method in _setMethods)
            {
                method.Invoke(value, args);
            }
        }

        internal static void MaybeAssignId(object value, DocumentReference reference)
        {
            if (value == null)
            {
                return;
            }
            var assigner = s_assigners.GetOrAdd(value.GetType(), MaybeCreateAssigner);
            assigner?.AssignId(value, reference);
        }

        /// <summary>
        /// Returns an "ID assigner" suitable 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private static AttributedIdAssigner MaybeCreateAssigner(BclType type)
        {
            var typeInfo = type.GetTypeInfo();
            if (!typeInfo.IsDefined(typeof(FirestoreDataAttribute)))
            {
                return null;
            }

            // While it's unusual, it's not an error to have multiple attributes decorated with [FirestoreId]
            List<MethodInfo> setMethods = new List<MethodInfo>();
            // We look for static properties specifically to find problems. We'll never use static properties.
            foreach (var property in typeInfo.GetProperties(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
            {
                string typeName = property.DeclaringType.FullName;
                FirestoreIdAttribute idAttribute = property.GetCustomAttribute<FirestoreIdAttribute>(inherit: true);
                if (idAttribute == null)
                {
                    continue;
                }
                var setMethod = property.GetSetMethod(nonPublic: true);
                GaxPreconditions.CheckState(setMethod != null,
                    "{0}.{1} has no setter, and should not be decorated with {2}.",
                    typeName, property.Name, nameof(FirestoreIdAttribute));
                GaxPreconditions.CheckState(!setMethod.IsStatic,
                    "{0}.{1} is static, and should not be decorated with {2}.",
                    typeName, property.Name, nameof(FirestoreIdAttribute));
                var parameters = setMethod.GetParameters();
                GaxPreconditions.CheckState(parameters.Length == 1,
                    "{0}.{1} is an indexer, and should not be decorated with {2}.",
                    typeName, property.Name, nameof(FirestoreIdAttribute));

                // TODO: How about accepting properties of type DocumentReference?
                GaxPreconditions.CheckState(parameters[0].ParameterType == typeof(string),
                    "{0}.{1} is not a string property, and should not be decorated with {2}.",
                    typeName, property.Name, nameof(FirestoreIdAttribute));
                setMethods.Add(setMethod);
            }
            return setMethods.Count == 0 ? null : new AttributedIdAssigner(setMethods);
        }
    }
}
