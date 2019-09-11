// Copyright 2019 Google LLC
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

using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Tools.VersionCompat.CecilUtils
{
    internal static class CecilExtensions
    {
        public static bool IsExported(this TypeDefinition type) =>
            (type.IsPublic || type.IsNestedPublic || type.IsNestedFamily || type.IsNestedFamilyOrAssembly) &&
            (!type.IsNested || type.DeclaringType.IsExported());

        public static bool IsExported(this MethodDefinition method) =>
            method.IsPublic || method.IsFamily || method.IsFamilyOrAssembly;

        public static bool IsExported(this PropertyDefinition prop) =>
            (prop.GetMethod?.IsExported() ?? false) || (prop.SetMethod?.IsExported() ?? false);

        public static IEnumerable<TypeDefinition> WithNested(this IEnumerable<TypeDefinition> types) =>
            types.SelectMany(x => x.NestedTypes.WithNested().Prepend(x));

        public static IEnumerable<MethodDefinition> InstanceCtors(this TypeDefinition type) =>
            type.Methods.Where(x => x.IsConstructor && !x.IsStatic);

        public static bool IsStatic(this TypeDefinition type) => type.IsAbstract && type.IsSealed;

        public static bool IsAbstractOnly(this TypeDefinition type) => type.IsAbstract && !type.IsSealed;

        public static bool IsSealedOnly(this TypeDefinition type) => type.IsSealed && !type.IsAbstract;

        public static bool IsObject(this TypeReference type) => type.FullName == typeof(object).FullName;

        public static string SafeFullName(this TypeReference type) => type?.FullName ?? "<none>";

        public static TypeDefinition Def(this TypeReference type) => type as TypeDefinition;

        public static TypeType TypeType(this TypeDefinition type)
        {
            if (type.IsInterface)
            {
                return CecilUtils.TypeType.Interface;
            }
            if (type.IsEnum)
            {
                return CecilUtils.TypeType.Enum;
            }
            if (type.BaseType?.FullName == typeof(MulticastDelegate).FullName)
            {
                return CecilUtils.TypeType.Delegate;
            }
            if (type.BaseType?.FullName == typeof(ValueType).FullName)
            {
                return CecilUtils.TypeType.Struct;
            }
            if (type.IsClass)
            {
                return CecilUtils.TypeType.Class;
            }
            throw new InvalidOperationException($"What is type: '{type.FullName}'?");
        }

        public static bool IsStatic(this PropertyDefinition prop) => (prop.GetMethod ?? prop.SetMethod).IsStatic;
    }
}
