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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BreakingChangesDetector.MetadataItems
{
    /// <summary>
    /// Represents the metadata for an externally visible constructed generic type.
    /// </summary>
    public sealed class ConstructedGenericTypeData : DeclaringTypeData
    {

        private readonly bool _isNullable;

        internal ConstructedGenericTypeData(TypeDefinitionData genericTypeDefinition, IEnumerable<TypeData> genericArguments)
            : base(genericTypeDefinition.Name, genericTypeDefinition.Accessibility, genericTypeDefinition.MemberFlags, genericTypeDefinition.TypeKind)
        {
            GenericTypeDefinition = genericTypeDefinition;
            ContainingType = genericTypeDefinition.ContainingType;

            _isNullable = genericTypeDefinition.IsType(typeof(Nullable<>));

            GenericArguments = new GenericTypeArgumentCollection(genericArguments);
            genericTypeDefinition.RegisterConstructedGenericTypeData(this);
            genericTypeDefinition.AssemblyData.RegisterForFinalize(this);
        }

        /// <inheritdoc/>
        public override void Accept(MetadataItemVisitor visitor) => visitor.VisitConstructedGenericTypeData(this);

        /// <inheritdoc/>
        public override AssemblyData AssemblyData => GenericTypeDefinition?.AssemblyData;

        internal override bool DoesMatch(MetadataItemBase other)
        {
            if (base.DoesMatch(other) == false)
            {
                return false;
            }

            var otherTyped = other as ConstructedGenericTypeData;
            if (otherTyped == null)
            {
                return false;
            }

            if (GenericArguments.DoesMatch(otherTyped.GenericArguments) == false)
            {
                return false;
            }

            if (GenericTypeDefinition.DisplayName != otherTyped.GenericTypeDefinition.DisplayName)
            {
                return false;
            }

            if (_isNullable != otherTyped._isNullable)
            {
                return false;
            }

            return true;
        }

        /// <inheritdoc/>
        internal override int GenericArity => GenericArguments.Count;

        /// <inheritdoc/>
        internal override AssemblyFamily GetDefiningAssemblyFamily()
        {
            if (IsNullable(out TypeData underlyingType))
            {
                return underlyingType.GetDefiningAssemblyFamily();
            }

            return base.GetDefiningAssemblyFamily();
        }

        /// <inheritdoc/>
        internal override IEnumerable<TypeData> GetDirectImplicitConversions(bool onlyReferenceAndIdentityConversions)
        {
            if (onlyReferenceAndIdentityConversions == false)
            {
                // An implicit conversion from S? to interfaces and base classes of S
                if (IsNullable(out TypeData underlyingType))
                {
                    foreach (var item in underlyingType.GetDirectImplicitConversions(onlyReferenceAndIdentityConversions))
                    {
                        if (item.IsValueType == false)
                        {
                            yield return item;
                        }
                    }
                }
            }

            foreach (var item in base.GetDirectImplicitConversions(onlyReferenceAndIdentityConversions))
            {
                yield return item;
            }
        }

        /// <inheritdoc/>
        internal override string GetDisplayName(bool fullyQualify, bool includeGenericInfo, GenericTypeArgumentCollection genericArguments)
        {
            if (IsNullable(out TypeData underlyingType))
            {
                return underlyingType.GetDisplayName(fullyQualify: false, includeGenericInfo: includeGenericInfo) + '?';
            }

            var genericArgumentsResolved = genericArguments ?? GenericArguments;

            var rootName = GenericTypeDefinition.GetDisplayName(fullyQualify: false, includeGenericInfo: false);
            if (includeGenericInfo)
            {
                var parentGenericArgumentCount = ContainingType == null ? 0 : ContainingType.GenericArity;
                rootName += genericArgumentsResolved.GetGenericArgumentListDisplayText(includeGenericInfo, parentGenericArgumentCount, GenericArguments.Count - parentGenericArgumentCount);
            }

            return PostProcessUnqualifiedName(rootName, fullyQualify, includeGenericInfo, genericArgumentsResolved);
        }

        /// <inheritdoc/>
        internal override TypeData GetEquivalentNewType(AssemblyFamily newAssemblyFamily)
        {
            var newGenericTypeDefinition = (TypeDefinitionData)GenericTypeDefinition.GetEquivalentNewType(newAssemblyFamily);
            if (newGenericTypeDefinition == null)
            {
                return null;
            }

            var newGenericArguments = new TypeData[GenericArguments.Count];
            for (int i = 0; i < GenericArguments.Count; i++)
            {
                var newGenericArgument = GenericArguments[i].GetEquivalentNewType(newAssemblyFamily);
                if (newGenericArgument == null)
                {
                    return null;
                }

                newGenericArguments[i] = newGenericArgument;
            }

            return newGenericTypeDefinition.GetConstructedGenericTypeData(newGenericArguments);
        }

        /// <inheritdoc/>
        internal override string GetNamespaceName()
        {
            // For nullable types, we want to get the namespace of the underlying type, not the System.Nullable<T> type, because it will be displayed as T?.
            if (IsNullable(out TypeData underlyingType))
            {
                return underlyingType.GetNamespaceName();
            }

            return GenericTypeDefinition.GetNamespaceName();
        }

        /// <inheritdoc/>
        internal override bool IsAssignableFrom(TypeData sourceType, IsAssignableFromContext context)
        {
            if (base.IsAssignableFrom(sourceType, context))
            {
                return true;
            }

            // Test for covariance and contravariance
            if (SupportsVariantTypeParameters && sourceType.IsVarianceConvertibleTo(this, context))
            {
                return true;
            }
            if (IsIListGenericType(out TypeData iListElementType) &&
                sourceType.IsArray(out int arrayRank, out TypeData arrayElementType) &&
                arrayRank == 1)
            {
                return iListElementType.IsAssignableFrom(arrayElementType, new IsAssignableFromContext(context.NewAssemblyFamily, context.IsSourceTypeOld, onlyReferenceAndIdentityConversions: true));
            }

            if (context.OnlyReferenceAndIdentityConversions == false)
            {
                if (IsNullable(out TypeData targetUnderlyingType))
                {
                    // An implicit conversion from S? to T?
                    if (sourceType.IsNullable(out TypeData sourceUnderlyingType))
                    {
                        return targetUnderlyingType.IsAssignableFrom(sourceUnderlyingType, context);
                    }

                    // An implicit conversion from S to T?
                    return targetUnderlyingType.IsAssignableFrom(sourceType, context);
                }
            }

            return false;
        }

        /// <inheritdoc/>
        internal override bool IsEquivalentToNewMember(MemberDataBase newMember, AssemblyFamily newAssemblyFamily)
        {
            if (base.IsEquivalentToNewMember(newMember, newAssemblyFamily) == false)
            {
                return false;
            }

            var other = newMember as ConstructedGenericTypeData;
            if (other == null)
            {
                return false;
            }

            if (GenericTypeDefinition.IsEquivalentToNew(other.GenericTypeDefinition, newAssemblyFamily) == false)
            {
                return false;
            }

            if (GenericArguments.Count != other.GenericArguments.Count)
            {
                return false;
            }

            for (int i = 0; i < GenericArguments.Count; i++)
            {
                if (GenericArguments[i].IsEquivalentToNewMember(other.GenericArguments[i], newAssemblyFamily) == false)
                {
                    return false;
                }
            }

            return true;
        }

        /// <inheritdoc/>
        internal override bool IsNullable(out TypeData underlyingType)
        {
            if (GenericArguments.Count == 1 &&
                _isNullable)
            {
                underlyingType = GenericArguments[0];
                return true;
            }

            underlyingType = null;
            return false;
        }

        /// <inheritdoc/>
        internal override bool IsVarianceConvertibleTo(ConstructedGenericTypeData target, IsAssignableFromContext context)
        {
            if (target.TypeKind == TypeKind &&
                target.GenericTypeDefinition == GenericTypeDefinition &&
                target.GenericArguments.Count == GenericArguments.Count)
            {
                Debug.Assert(
                    target.GenericArguments.Count == GenericArguments.Count,
                    "Two constructed generic types from the same generic type definition should have the same number of generic arguments.");

                var genericParameters = target.GenericTypeDefinition.GenericParameters;
                for (int i = 0, count = genericParameters.Count; i < count; i++)
                {
                    if (genericParameters[i].IsGenericTypeArgumentVariant(target.GenericArguments[i], GenericArguments[i], context) == false)
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        /// <inheritdoc/>
        public override MetadataItemKinds MetadataItemKind => MetadataItemKinds.ConstructedGenericType;

        /// <inheritdoc/>
        internal override MemberDataBase ReplaceGenericTypeParameters(GenericTypeParameterCollection genericParameters, GenericTypeArgumentCollection genericArguments)
        {
            List<TypeData> replacedGenericArguments = null;
            for (int i = 0; i < GenericArguments.Count; i++)
            {
                var currentArgument = GenericArguments[i];
                var replacedArgument = (TypeData)currentArgument.ReplaceGenericTypeParameters(genericParameters, genericArguments);
                if (replacedArgument == currentArgument)
                {
                    continue;
                }

                if (replacedGenericArguments == null)
                {
                    replacedGenericArguments = new List<TypeData>(GenericArguments);
                }

                replacedGenericArguments[i] = replacedArgument;
            }

            if (replacedGenericArguments != null)
            {
                return GenericTypeDefinition.GetConstructedGenericTypeData(replacedGenericArguments);
            }

            return this;
        }

        internal void FinalizeDefiniton()
        {
            var genericParameters = GenericTypeDefinition.GenericParameters;

            if (GenericTypeDefinition.BaseType != null)
            {
                BaseType = (DeclaringTypeData)GenericTypeDefinition.BaseType.ReplaceGenericTypeParameters(genericParameters, GenericArguments);
            }

            ImplementedInterfaces = new ImplementedInterfacesCollection(
                GenericTypeDefinition.ImplementedInterfaces.Select(i => (DeclaringTypeData)i.ReplaceGenericTypeParameters(genericParameters, GenericArguments))
                );

            if (TypeKind == Microsoft.CodeAnalysis.TypeKind.Delegate)
            {
                var invokeMethod = (MethodData)GenericTypeDefinition.GetMethod("Invoke").ReplaceGenericTypeParameters(genericParameters, GenericArguments);
                DelegateParameters = invokeMethod.Parameters;
                DelegateReturnType = invokeMethod.Type;
                DelegateReturnTypeIsDynamic = invokeMethod.IsTypeDynamic;
            }
            else
            {
                foreach (var member in GenericTypeDefinition.GetMembers().Where(m => m.MetadataItemKind != MetadataItemKinds.TypeDefinition))
                {
                    AddMember(member.ReplaceGenericTypeParameters(genericParameters, GenericArguments));
                }
            }
        }

        /// <summary>
        /// Indicates whether the type is an IList&lt;T&gt; constructed generic type.
        /// </summary> 
        private bool IsIListGenericType(out TypeData elementType)
        {
            if (GenericArguments.Count == 1 &&
                GenericTypeDefinition.IsType(typeof(IList<>)))
            {
                elementType = GenericArguments[0];
                return true;
            }

            elementType = null;
            return false;
        }

        /// <summary>
        /// Gets the collection of generic arguments specified when constructing this type.
        /// </summary>
        public GenericTypeArgumentCollection GenericArguments { get; } // TODO_Serialize: Round trip and unit test

        /// <summary>
        /// Gets the generic type definition.
        /// </summary>
        public TypeDefinitionData GenericTypeDefinition { get; } // TODO_Serialize: Round trip and unit test

        /// <summary>
        /// Gets the value indicating whether the type, if it were generic, supports variant type parameters (this is true for interfaces and delegates).
        /// </summary>  
        internal bool SupportsVariantTypeParameters =>
            TypeKind == Microsoft.CodeAnalysis.TypeKind.Interface ||
            TypeKind == Microsoft.CodeAnalysis.TypeKind.Delegate;
    }
}
