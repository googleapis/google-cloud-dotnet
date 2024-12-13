// Copyright 2016 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Xunit;

namespace Google.Cloud.ClientTesting
{
    public static class CodeHealthTester
    {
        private static readonly List<string> s_exemptedNamespacePrefixs = new List<string>
        {
            "Microsoft.CodeAnalysis",
            "System.Runtime.CompilerServices"
        };

        /// <summary>
        /// Asserts that all the fields in the assembly containing the given type are private,
        /// other than for constants.
        /// </summary>
        public static void AssertAllFieldsPrivate(Type sampleType, IEnumerable<Type> exemptedTypes = null)
        {
            exemptedTypes = exemptedTypes ?? Enumerable.Empty<Type>();
            var badFields = from type in sampleType.GetTypeInfo().Assembly.DefinedTypes.Except(exemptedTypes.Select(t => t.GetTypeInfo()))
                            // Exempt enums, compiler-generated types and nested private types.
                            // (Sometimes the compiler generates nested private types but doesn't put the CompilerGeneratedAttribute
                            // on the nested type. It's easiest just to ignore all nested private types.)
                            where !type.IsEnum && !type.IsDefined(typeof(CompilerGeneratedAttribute)) && !type.IsNestedPrivate
                            from field in type.DeclaredFields
                            where !field.IsPrivate && !field.IsLiteral
                            // Allow internal static readonly fields, e.g. for singletons
                            where !(field.IsAssembly && field.IsStatic && field.IsInitOnly)
                            select $"{type.Name}.{field.Name}";
            // Force output to show the bad fields
            Assert.Equal(new string[0], badFields.ToList());
        }

        /// <summary>
        /// Asserts that all the classes in the assembly containing the given type are either abstract
        /// or sealed.
        /// </summary>
        public static void AssertClassesAreSealedOrAbstract(Type sampleType, IEnumerable<Type> exemptedTypes = null)
        {
            exemptedTypes = exemptedTypes ?? Enumerable.Empty<Type>();
            var badTypes = from type in sampleType.GetTypeInfo().Assembly.DefinedTypes.Except(exemptedTypes.Select(t => t.GetTypeInfo()))
                           where type.IsClass && !type.IsAbstract && !type.IsSealed
                           select type.Name;
            // Force output to show the bad types
            Assert.Equal(new string[0], badTypes.ToList());
        }

        /// <summary>
        /// Asserts that the assembly containing the given type does not define the disallowed namespaces.
        /// </summary>
        public static void AssertNoDisallowedNamespaces(Type sampleType, params string[] disallowedNamespaces)
        {
            var badTypes = sampleType.Assembly.DefinedTypes
                .Where(t => disallowedNamespaces.Contains(t.Namespace))
                .Select(t => t.FullName);

            Assert.Empty(badTypes);
        }

        /// <summary>
        /// Asserts that the assembly containing the given type only defines the allowed namespaces.
        /// </summary>
        public static void AssertOnlyAllowedNamespaces(Type sampleType, params string[] allowedNamespaces)
        {
            var badTypes = sampleType.Assembly.DefinedTypes
                .Where(t => !allowedNamespaces.Contains(t.Namespace) &&
                            !s_exemptedNamespacePrefixs.Any(prefix => t.Namespace.StartsWith(prefix)))
                .Select(t => t.FullName);

            Assert.Empty(badTypes);
        }
    }
}
