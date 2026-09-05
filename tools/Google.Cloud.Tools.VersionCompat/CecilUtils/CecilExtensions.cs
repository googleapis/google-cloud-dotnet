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
using System.Collections.Immutable;
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

        public static bool IsExported(this FieldDefinition field) =>
            field.IsPublic || field.IsFamily || field.IsFamilyOrAssembly;

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

        public static bool IsBreakableDefintion(this MethodDefinition method)
        {
            if (!method.IsVirtual)
            {
                return true;
            }

            return method.IsNewSlot || method.IsFinal;
        }

        public static bool IsBreakableDefinition(this PropertyDefinition property)
        {
            var methodDefinition = property.GetMethod ?? property.SetMethod;

            if (methodDefinition is null)
            {
                return false;
            }

            if (!methodDefinition.IsVirtual)
            {
                return true;
            }

            return methodDefinition.IsNewSlot || methodDefinition.IsFinal;
        }

        /// <summary>
        /// Looks up the family tree starting from <paramref name="typeDefinition"/>, and gets the first occurence of <paramref name="referenceMethod"/>
        /// from it finds, or nothing if no like method is found.
        /// </summary>
        /// <param name="descendentType">Type to start from.</param>
        /// <param name="referenceMethod">Like method to check for</param>
        /// <param name="methodFromAncestor">Out method to be filled with the found method reference, if one is found.</param>
        /// <returns></returns>
        public static bool TryGetMethodFromAncestor(this TypeDefinition descendentType, MethodDefinition referenceMethod, out MethodDefinition methodFromAncestor)
        {
            methodFromAncestor = null;

            // Look up the ancestor tree until we find a like implementation to this method
            var baseType = descendentType.BaseType?.Resolve();
            while (baseType != null)
            {
                // GetMethod here only checks for a subset of the info we need, so
                // also check visibility, static, and more.
                if (MetadataResolver.GetMethod(baseType.Methods, referenceMethod) is MethodDefinition baseTypeMethod
                    && AreLikeMethods(referenceMethod, baseTypeMethod))
                {
                    methodFromAncestor = baseTypeMethod;
                    return true;
                }

                baseType = baseType.BaseType?.Resolve();
            }

            return false;

            // This only supplements what is missing from MetadataResolver.GetMethod to ascertain if
            // the two methods are definitionally like, and should not be used separately.
            static bool AreLikeMethods(MethodDefinition referenceMethod, MethodDefinition likeMethod)
                => referenceMethod.IsPublic == likeMethod.IsPublic
                    && referenceMethod.IsFamily == likeMethod.IsFamily
                    && referenceMethod.IsStatic == likeMethod.IsStatic
                    // We only care that the like method is sealed if the reference method is too.
                    && (referenceMethod.IsVirtual ? likeMethod.IsVirtual : true);
        }

        /// <summary>
        /// Looks up the family tree starting from <paramref name="descendentType"/>, and tries to get one of both get and set accessors.
        ///
        /// Note: The accessors intentionally may be from separate classes in the family tree, as we want to ensure we are keeping any accessors
        /// from <paramref name="descendentType"/> itself, if they exist.
        /// </summary>
        /// <param name="descendentType">Type to start from.</param>
        /// <param name="propertyDefinition">Property of the accessors.</param>
        /// <param name="getMethod">Out get accessor of the property, if one is found.</param>
        /// <param name="setMethod">Out set accessor of the property, if one is found.</param>
        /// <returns></returns>
        public static bool TryGetAccessorsFromAncestry(this TypeDefinition descendentType, PropertyDefinition propertyDefinition, out MethodDefinition getMethod, out MethodDefinition setMethod)
        {
            var baseType = descendentType;
            getMethod = null;
            setMethod = null;

            while (baseType is not null)
            {
                if (baseType.Properties.Where(p => SamePropertyComparer.Instance.Equals(p, propertyDefinition)).FirstOrDefault() is PropertyDefinition matchingProperty)
                {
                    getMethod ??= matchingProperty.GetMethod;
                    setMethod ??= matchingProperty.SetMethod;

                    if (getMethod is not null && setMethod is not null)
                    {
                        return true;
                    }
                }

                baseType = baseType?.BaseType?.Resolve();
            }

            return getMethod is not null || setMethod is not null;
        }
    }
}
