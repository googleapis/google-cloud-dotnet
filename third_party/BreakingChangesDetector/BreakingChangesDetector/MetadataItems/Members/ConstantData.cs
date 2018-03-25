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
using System.Diagnostics;

namespace BreakingChangesDetector.MetadataItems
{
    /// <summary>
    /// Represents the metadata for an externally visible constant field.
    /// </summary>
    public sealed class ConstantData : TypedMemberDataBase
    {
        internal ConstantData(string name, MemberAccessibility accessibility, MemberFlags memberFlags, TypeData type, bool isTypeDynamic, object value)
            : base(name, accessibility, memberFlags, type, isTypeDynamic) =>
            Value = value;

        private ConstantData(IFieldSymbol fieldSymbol, MemberAccessibility accessibility, DeclaringTypeData declaringType)
            : base(fieldSymbol, accessibility, fieldSymbol.Type, fieldSymbol.Type.TypeKind == TypeKind.Dynamic, MemberFlags.Static, declaringType) =>
            Value = Utilities.PreprocessConstantValue(fieldSymbol.Type, fieldSymbol.ConstantValue);

        /// <inheritdoc/>
        public override void Accept(MetadataItemVisitor visitor) =>
            visitor.VisitConstantData(this);

        /// <inheritdoc/>
        internal override bool CanOverrideMember(MemberDataBase baseMember)
        {
            Debug.Fail("Constants cannot be overridden.");
            return false;
        }

        internal override bool DoesMatch(MetadataItemBase other)
        {
            if (base.DoesMatch(other) == false)
            {
                return false;
            }

            var otherTyped = other as ConstantData;
            if (otherTyped == null)
            {
                return false;
            }

            if (Object.Equals(Value, otherTyped.Value))
            {
                return false;
            }

            return true;
        }

        /// <inheritdoc/>
        public override MetadataItemKinds MetadataItemKind =>
            MetadataItemKinds.Constant;

        /// <inheritdoc/>
        internal override MemberDataBase ReplaceGenericTypeParameters(GenericTypeParameterCollection genericParameters, GenericTypeArgumentCollection genericArguments)
        {
            var replacedType = (TypeData)Type.ReplaceGenericTypeParameters(genericParameters, genericArguments);
            if (replacedType == Type)
            {
                return this;
            }

            Debug.Fail("It was assumed that constants cannot be generic");
            return new ConstantData(Name, Accessibility, MemberFlags, replacedType, IsTypeDynamic, Value);
        }

        internal static MemberDataBase ConstantDataFromReflection(IFieldSymbol fieldSymbol, DeclaringTypeData declaringType)
        {
            var accessibility = fieldSymbol.GetAccessibility();
            if (accessibility == null)
            {
                return null;
            }

            return new ConstantData(fieldSymbol, accessibility.Value, declaringType);
        }

        /// <summary>
        /// Gets the compiled constant value.
        /// </summary>
        public object Value { get; } // TODO_Serialize: Round trip and unit test
    }
}
