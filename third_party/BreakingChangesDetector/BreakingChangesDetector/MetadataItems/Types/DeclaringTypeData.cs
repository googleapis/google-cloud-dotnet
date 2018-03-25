/*
    MIT License

    Copyright(c) 2014-2018 Infragistics, Inc.
    Copyright 2018 Google LLC

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
*/

using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BreakingChangesDetector.MetadataItems
{
    /// <summary>
    /// Abstract base sealed class representing metadata for an externally visible type which can contain member declarations.
    /// </summary>
    public abstract class DeclaringTypeData : TypeData
    {
        private readonly Dictionary<string, List<MemberDataBase>> _membersByName = new Dictionary<string, List<MemberDataBase>>();

        internal DeclaringTypeData(string name, MemberAccessibility accessibility, MemberFlags memberFlags, TypeKind typeKind)
            : base(name, accessibility, memberFlags, typeKind) { }

        internal DeclaringTypeData(ITypeSymbol typeSymbol, MemberAccessibility accessibility, DeclaringTypeData declaringType)
            : base(typeSymbol, accessibility, declaringType) { }

        internal override bool DoesMatch(MetadataItemBase other)
        {
            if (base.DoesMatch(other) == false)
            {
                return false;
            }

            var otherTyped = other as DeclaringTypeData;
            if (otherTyped == null)
            {
                return false;
            }

            if (BaseType == null ^ otherTyped.BaseType == null)
            {
                return false;
            }

            if (BaseType != null && BaseType.DisplayName != otherTyped.BaseType.DisplayName)
            {
                return false;
            }

            if (DelegateParameters == null ^ otherTyped.DelegateParameters == null)
            {
                return false;
            }

            if (DelegateParameters != null && DelegateParameters.DoesMatch(otherTyped.DelegateParameters) == false)
            {
                return false;
            }

            if (DelegateReturnType == null ^ otherTyped.DelegateReturnType == null)
            {
                return false;
            }

            if (DelegateReturnType != null && DelegateReturnType.DisplayName != otherTyped.DelegateReturnType.DisplayName)
            {
                return false;
            }

            if (DelegateReturnTypeIsDynamic != DelegateReturnTypeIsDynamic)
            {
                return false;
            }

            if (GenericArity != otherTyped.GenericArity)
            {
                return false;
            }

            if (_membersByName.Count != otherTyped._membersByName.Count)
            {
                return false;
            }

            foreach (var pair in _membersByName)
            {
                var value = pair.Value;
                if (otherTyped._membersByName.TryGetValue(pair.Key, out List<MemberDataBase> otherValue) == false)
                {
                    return false;
                }

                if (value.Count != otherValue.Count)
                {
                    return false;
                }

                for (int i = 0; i < value.Count; i++)
                {
                    if (value[i].DoesMatch(otherValue[i]) == false)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <inheritdoc/>
        internal override IEnumerable<TypeData> GetDirectImplicitConversions(bool onlyReferenceAndIdentityConversions)
        {
            if (onlyReferenceAndIdentityConversions && IsValueType)
            {
                yield break;
            }

            if (TypeKind != TypeKind.Enum && BaseType != null)
            {
                yield return BaseType;
            }

            foreach (var implementedInterface in ImplementedInterfaces)
            {
                yield return implementedInterface;
            }

            // Any interface type can convert to object
            if (TypeKind == TypeKind.Interface)
            {
                var mscorlibData = AssemblyData.GetReferencedAssembly(Utilities.CommonObjectRuntimeAssemblyName);
                if (mscorlibData != null)
                {
                    yield return mscorlibData.GetTypeDefinitionData(Utilities.ObjectTypeName);
                }
            }
        }

        /// <inheritdoc/>
        public override sealed string GetDisplayName(bool fullyQualify = true, bool includeGenericInfo = true) =>
            GetDisplayName(fullyQualify, includeGenericInfo, null);

        /// <inheritdoc/>
        internal override bool IsAssignableFrom(TypeData sourceType, IsAssignableFromContext context)
        {
            if (base.IsAssignableFrom(sourceType, context))
            {
                return true;
            }

            if (context.OnlyReferenceAndIdentityConversions == false)
            {
                // See if there are any user-defined implicit conversions from the source type to the target type defined in new types:
                // (we want to check in new types because a breaking change in a new version due to a type change can be mitigated by
                // defining an implicit conversion in one of the types in the new version).
                if (DoesSourceTypeHaveImplicitOperatorOverloadToTarget(sourceType, context))
                {
                    return true;
                }

                if (DoesTargetTypeHaveImplicitOperatorOverloadFromSource(sourceType, context))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Gets the single member with the specified name or null if no such member exists. If multiple members exist with the specified name, 
        /// an exception will be thrown.
        /// </summary>
        /// <param name="name">The name of the member to get.</param>
        /// <exception cref="InvalidOperationException">
        /// Occurs when multiple members have the specified name.
        /// </exception>
        /// <returns>The single member with the specified name, or null if no such member exists.</returns>
        public MemberDataBase GetMember(string name)
        {
            var members = GetMembers(name);
            if (members.Count == 0)
            {
                return null;
            }

            if (members.Count != 1)
            {
                throw new InvalidOperationException(string.Format("There are multiple members in {0} with the name '{1}'", Name, name));
            }

            return members[0];
        }

        /// <summary>
        /// Gets the collection of all members declared in the type.
        /// </summary>
        public IEnumerable<MemberDataBase> GetMembers() => _membersByName.OrderBy(p => p.Key).SelectMany(p => p.Value);

        /// <summary>
        /// Gets the collection of all members declared in the type with the specified name.
        /// </summary>
        public List<MemberDataBase> GetMembers(string name)
        {
            if (_membersByName.TryGetValue(name, out List<MemberDataBase> members))
            {
                return members;
            }

            return EmptyList;
        }

        /// <summary>
        /// Gets the single method with the specified name or null if no such method exists. If multiple methods exist with the specified name, 
        /// an exception will be thrown.
        /// </summary>
        /// <param name="name">The name of the method to get.</param>
        /// <returns>The single method with the specified name, or null if no such method exists.</returns>
        public MethodData GetMethod(string name) => GetMembers(name).OfType<MethodData>().SingleOrDefault();

        /// <summary>
        /// Adds the specified member to the declaring type.
        /// </summary> 
        internal void AddMember(MemberDataBase member)
        {
            if (member == null)
            {
                return;
            }

            if (member.Accessibility == MemberAccessibility.Protected && IsSealed)
            {
                return;
            }

            if (_membersByName.TryGetValue(member.Name, out List<MemberDataBase> members) == false)
            {
                members = new List<MemberDataBase>();
                _membersByName[member.Name] = members;
            }

            members.Add(member);
        }

        /// <summary>
        /// Gets the display name for the type, which can be used for generating user-readable messages about the type.
        /// </summary>
        /// <param name="fullyQualify">Indicates whether the type name should be fully qualified with declaring type and namespace names.</param>
        /// <param name="includeGenericInfo">Indicates whether generic parameters and arguments should be included in type names.</param>
        /// <param name="genericArguments">
        /// The generic arguments used to parameterize a type. For nested types, this will include the arguments for the declaring type before the arguments 
        /// for the nested type.
        /// </param>
        /// <returns>The display name of the type.</returns> 
        internal abstract string GetDisplayName(bool fullyQualify, bool includeGenericInfo, GenericTypeArgumentCollection genericArguments);

        /// <summary>
        /// Adds in the fully qualified information for the type name if necessary.
        /// </summary>
        /// <param name="unqualifiedName">The unqualified name of the type.</param>
        /// <param name="fullyQualify">Indicates whether the type name should be fully qualified with declaring type and namespace names.</param>
        /// <param name="includeGenericInfo">Indicates whether generic parameters and arguments should be included in type names.</param>
        /// <param name="genericArguments">
        /// The generic arguments used to parameterize a type. For nested types, this will include the arguments for the declaring type before the arguments 
        /// for the nested type.
        /// </param>
        internal string PostProcessUnqualifiedName(string unqualifiedName, bool fullyQualify, bool includeGenericInfo, GenericTypeArgumentCollection genericArguments)
        {
            if (fullyQualify)
            {
                if (ContainingType != null)
                {
                    return ContainingType.GetDisplayName(fullyQualify, includeGenericInfo, genericArguments) + "." + unqualifiedName;
                }

                var namespaceName = GetNamespaceName();
                if (string.IsNullOrEmpty(namespaceName) == false)
                {
                    return namespaceName + "." + unqualifiedName;
                }
            }

            return unqualifiedName;
        }

        private bool DoesSourceTypeHaveImplicitOperatorOverloadToTarget(TypeData sourceType, IsAssignableFromContext context)
        {
            var sourceDeclaringTypeData = sourceType as DeclaringTypeData;
            if (sourceDeclaringTypeData == null)
            {
                return false;
            }

            var newSourceType = context.IsSourceTypeOld
                ? sourceDeclaringTypeData.GetEquivalentNewType(context.NewAssemblyFamily) as DeclaringTypeData
                : sourceDeclaringTypeData;

            if (newSourceType == null)
            {
                return false;
            }

            var implicitOperatorsFromSource = newSourceType.GetMembers(OperatorData.ImplicitCastOperatorName)
                .OfType<OperatorData>()
                .Where(o => o.Parameters[0].Type == newSourceType);

            foreach (var op in implicitOperatorsFromSource)
            {
                if (context.IsTargetTypeOld)
                {
                    if (op.Type.IsEquivalentToOld(this, context.NewAssemblyFamily))
                    {
                        return true;
                    }
                }
                else
                {
                    if (op.Type == this)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool DoesTargetTypeHaveImplicitOperatorOverloadFromSource(TypeData sourceType, IsAssignableFromContext context)
        {
            var newTargetType = context.IsTargetTypeOld
                ? GetEquivalentNewType(context.NewAssemblyFamily) as DeclaringTypeData
                : this;

            if (newTargetType == null)
            {
                return false;
            }

            var implicitOperators = newTargetType.GetMembers(OperatorData.ImplicitCastOperatorName)
                .OfType<OperatorData>()
                .Where(o => o.Type == newTargetType);

            foreach (var op in implicitOperators)
            {
                if (context.IsSourceTypeOld)
                {
                    if (op.Parameters[0].Type.IsEquivalentToOld(sourceType, context.NewAssemblyFamily))
                    {
                        return true;
                    }
                }
                else
                {
                    if (op.Parameters[0].Type == sourceType)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Gets the base type of the current type.
        /// </summary>
        public DeclaringTypeData BaseType { get; internal set; }

        /// <summary>
        /// Gets the collection of parameters for delegate types, or null if the type is not a delegate.
        /// </summary>
        public ParameterCollection DelegateParameters { get; internal set; }

        /// <summary>
        /// Gets the return type for delegate types, or null if the tpye is not a delegate.
        /// </summary>
        public TypeData DelegateReturnType { get; internal set; }

        /// <summary>
        /// Gets the value indicating whether the return type of the delegate type is 'dynamic'. This value should be ignored for non-delegate types.
        /// </summary>
        public bool DelegateReturnTypeIsDynamic { get; internal set; } // TODO_Serialize: Round trip and unit test

        /// <summary>
        /// Gets the value indicating whether the type has any members declared.
        /// </summary>
        public bool HasMembers => _membersByName.Count != 0;

        /// <summary>
        /// Gets the collection of interfaces implemented by the type.
        /// </summary>
        public ImplementedInterfacesCollection ImplementedInterfaces { get; internal set; }

        /// <summary>
        /// Gets the number of generic parameters/arguments for the type.
        /// </summary> 
        internal abstract int GenericArity { get; }
    }
}
