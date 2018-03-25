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

namespace BreakingChangesDetector.MetadataItems
{
    /// <summary>
    /// Represents the metadata for an externally visible method.
    /// </summary>
    public sealed class MethodData : MethodDataBase, IGenericItem
    {
        internal MethodData(string name, MemberAccessibility accessibility, MemberFlags memberFlags, TypeData type, bool isTypeDynamic, GenericTypeParameterCollection genericParameters, bool isExtensionMethod, ParameterCollection parameters)
            : base(name, accessibility, memberFlags, type, isTypeDynamic, parameters)
        {
            GenericParameters = genericParameters;
            IsExtensionMethod = isExtensionMethod;
        }

        private MethodData(IMethodSymbol methodSymbol, MemberAccessibility accessibility, DeclaringTypeData declaringType)
            : base(methodSymbol, accessibility, declaringType)
        {
            if (methodSymbol.IsGenericMethod)
            {
                // TODO: This seems odd
                MemberDataBase declaringMember = null;
                if (!methodSymbol.ContainingType.IsConstructed())
                {
                    declaringMember = this;
                }

                GenericParameters = Utilities.GetGenericParameters(methodSymbol.TypeParameters, declaringMember);
            }
            else
            {
                GenericParameters = GenericTypeParameterData.EmptyList;
            }

            IsExtensionMethod = methodSymbol.IsExtensionMethod;
        }

        /// <inheritdoc/>
        public override void Accept(MetadataItemVisitor visitor) => visitor.VisitMethodData(this);

        /// <inheritdoc/>
        internal override bool CanOverrideMember(MemberDataBase baseMember)
        {
            if (base.CanOverrideMember(baseMember) == false)
            {
                return false;
            }

            var otherMethod = (MethodData)baseMember;
            return GenericParameters.Count == otherMethod.GenericParameters.Count;
        }

        /// <inheritdoc/>
        public override string DisplayName =>
            Name +
            GenericParameters.GetParameterListText() +
            Parameters.GetParameterListDisplayText(IsExtensionMethod);

        internal override bool DoesMatch(MetadataItemBase other)
        {
            if (base.DoesMatch(other) == false)
            {
                return false;
            }

            var otherTyped = other as MethodData;
            if (otherTyped == null)
            {
                return false;
            }

            if (GenericParameters.DoesMatch(otherTyped.GenericParameters) == false)
            {
                return false;
            }

            if (IsExtensionMethod != otherTyped.IsExtensionMethod)
            {
                return false;
            }

            return true;
        }

        /// <inheritdoc/>
        internal override bool IsEquivalentToNewMember(MemberDataBase newMember, AssemblyFamily newAssemblyFamily)
        {
            if (base.IsEquivalentToNewMember(newMember, newAssemblyFamily) == false)
            {
                return false;
            }

            var otherMethod = (MethodData)newMember;
            return GenericParameters.Count == otherMethod.GenericParameters.Count;
        }

        /// <inheritdoc/>
        public override MetadataItemKinds MetadataItemKind => MetadataItemKinds.Method;

        /// <inheritdoc/>
        internal override MemberDataBase ReplaceGenericTypeParameters(GenericTypeParameterCollection genericParameters, GenericTypeArgumentCollection genericArguments)
        {
            var replacedType = (TypeData)Type.ReplaceGenericTypeParameters(genericParameters, genericArguments);
            var replacedParameters = Parameters.ReplaceGenericTypeParameters(MetadataItemKind, genericParameters, genericArguments);
            if (replacedType == Type &&
                replacedParameters == Parameters)
            {
                return this;
            }

            return new MethodData(Name, Accessibility, MemberFlags, replacedType, IsTypeDynamic, GenericParameters, IsExtensionMethod, replacedParameters);
        }

        internal static MemberDataBase MethodDataFromReflection(IMethodSymbol methodSymbol, DeclaringTypeData declaringType)
        {
            var accessibility = methodSymbol.GetAccessibility();
            if (accessibility == null)
            {
                return null;
            }

            return new MethodData(methodSymbol, accessibility.Value, declaringType);
        }

        /// <summary>
        /// Gets the collection of generic parameters for the method.
        /// </summary>
        public GenericTypeParameterCollection GenericParameters { get; }

        /// <summary>
        /// Gets the value indicating whether the method is an extension method.
        /// </summary>
        public bool IsExtensionMethod { get; }
    }
}
