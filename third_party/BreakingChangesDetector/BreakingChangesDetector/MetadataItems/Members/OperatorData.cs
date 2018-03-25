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
    /// Represents the metadata for an externally visible operator overload.
    /// </summary>
    public sealed class OperatorData : MethodDataBase
    {
        internal const string ImplicitCastOperatorName = "op_Implicit";

        internal OperatorData(string name, MemberAccessibility accessibility, MemberFlags memberFlags, TypeData type, bool isTypeDynamic, ParameterCollection parameters)
            : base(name, accessibility, memberFlags, type, isTypeDynamic, parameters) { }

        internal OperatorData(IMethodSymbol methodSymbol, DeclaringTypeData declaringType)
            : base(methodSymbol, MemberAccessibility.Public, declaringType) { }

        /// <inheritdoc/>
        public override void Accept(MetadataItemVisitor visitor) => visitor.VisitOperatorData(this);

        /// <inheritdoc/>
        public override MetadataItemKinds MetadataItemKind => MetadataItemKinds.Operator;

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

            return new OperatorData(Name, Accessibility, MemberFlags, replacedType, IsTypeDynamic, replacedParameters);
        }
    }
}
