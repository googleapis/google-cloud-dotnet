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
    /// Abstract base class representing metadata for externally visible members with an type or return type.
    /// </summary>
    public abstract class TypedMemberDataBase : MemberDataBase,
        ITypedItem
    {
        internal TypedMemberDataBase(string name, MemberAccessibility accessibility, MemberFlags memberFlags, TypeData type, bool isTypeDynamic)
            : base(name, accessibility, memberFlags)
        {
            Type = type;
            IsTypeDynamic = isTypeDynamic;
        }

        internal TypedMemberDataBase(ISymbol symbol, MemberAccessibility accessibility, ITypeSymbol type, bool isTypeDynamic, MemberFlags flags, DeclaringTypeData declaringType)
            : base(symbol, accessibility, flags, declaringType)
        {
            Type = declaringType.Context.GetTypeData(type);
            IsTypeDynamic = isTypeDynamic;
            Debug.Assert(Type != null, "Unable to get the TypeData.");
        }

        /// <summary>
        /// Indicates whether the current member can override the specified member from a base type.
        /// </summary>
        /// <param name="baseMember">The member from the base type.</param>
        /// <returns>True if the current member can override the base member; False otherwise.</returns>  
        internal override bool CanOverrideMember(MemberDataBase baseMember)
        {
            if (base.CanOverrideMember(baseMember) == false)
            {
                return false;
            }

            return Type == ((TypedMemberDataBase)baseMember).Type;
        }

        internal override bool DoesMatch(MetadataItemBase other)
        {
            if (base.DoesMatch(other) == false)
            {
                return false;
            }

            var otherTyped = other as TypedMemberDataBase;
            if (otherTyped == null)
            {
                return false;
            }

            if (IsTypeDynamic != otherTyped.IsTypeDynamic)
            {
                return false;
            }

            if (Type.DisplayName != otherTyped.Type.DisplayName)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Gets the value indicating whether the type is dynamic.
        /// </summary>
        public bool IsTypeDynamic { get; } // TODO_Serialize: round trip and test

        /// <summary>
        /// Gets the type (or return type) of the member.
        /// </summary>
        public TypeData Type { get; }
    }
}
