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
using System.Diagnostics;

namespace BreakingChangesDetector.MetadataItems
{
    /// <summary>
    /// Represents the metadata for an externally visible field.
    /// </summary>
    public sealed class FieldData : TypedMemberDataBase
    {
        internal FieldData(string name, MemberAccessibility accessibility, MemberFlags memberFlags, TypeData type, bool isTypeDynamic, bool isReadOnly)
            : base(name, accessibility, memberFlags, type, isTypeDynamic) =>
            IsReadOnly = isReadOnly;

        private FieldData(IFieldSymbol fieldSymbol, MemberAccessibility accessibility, DeclaringTypeData declaringType)
            : base(fieldSymbol, accessibility, fieldSymbol.Type, fieldSymbol.Type.TypeKind == TypeKind.Dynamic, fieldSymbol.IsStatic ? MemberFlags.Static : MemberFlags.None, declaringType) =>
            IsReadOnly = fieldSymbol.IsReadOnly;

        /// <inheritdoc/>
        public override void Accept(MetadataItemVisitor visitor) =>
            visitor.VisitFieldData(this);

        /// <inheritdoc/>
        internal override bool CanOverrideMember(MemberDataBase baseMember)
        {
            Debug.Fail("Fields cannot be overridden.");
            return false;
        }

        internal override bool DoesMatch(MetadataItemBase other)
        {
            if (base.DoesMatch(other) == false)
            {
                return false;
            }

            var otherTyped = other as FieldData;
            if (otherTyped == null)
            {
                return false;
            }

            if (IsReadOnly != otherTyped.IsReadOnly)
            {
                return false;
            }

            return true;
        }

        /// <inheritdoc/>
        public override MetadataItemKinds MetadataItemKind =>
            MetadataItemKinds.Field;

        /// <inheritdoc/>
        internal override MemberDataBase ReplaceGenericTypeParameters(GenericTypeParameterCollection genericParameters, GenericTypeArgumentCollection genericArguments)
        {
            var replacedType = (TypeData)Type.ReplaceGenericTypeParameters(genericParameters, genericArguments);
            if (replacedType == Type)
            {
                return this;
            }

            return new FieldData(Name, Accessibility, MemberFlags, replacedType, IsTypeDynamic, IsReadOnly);
        }

        internal static MemberDataBase FieldDataFromReflection(IFieldSymbol fieldSymbol, DeclaringTypeData declaringType)
        {
            var accessibility = fieldSymbol.GetAccessibility();
            if (accessibility == null)
            {
                return null;
            }

            return new FieldData(fieldSymbol, accessibility.Value, declaringType);
        }

        /// <summary>
        /// Gets the value indicating whether the field is read-only.
        /// </summary>
        public bool IsReadOnly { get; }
    }
}
