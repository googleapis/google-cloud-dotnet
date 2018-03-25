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
using System.Collections.Generic;

namespace BreakingChangesDetector.MetadataItems
{
    /// <summary>
    /// Represents the metadata for an externally visible pointer type.
    /// </summary>
    public sealed class PointerTypeData : TypeWithElementData
    {
        internal PointerTypeData(string name, MemberAccessibility accessibility, MemberFlags memberFlags, TypeKind typeKind, TypeData elementType)
            : base(name, accessibility, memberFlags, typeKind, elementType) { }

        /// <inheritdoc/>
        internal override IEnumerable<TypeData> GetDirectImplicitConversions(bool onlyReferenceAndIdentityConversions)
        {
            yield break;
        }

        /// <inheritdoc/>
        public override string GetDisplayName(bool fullyQualify = true, bool includeGenericInfo = true) =>
            ElementType.GetDisplayName(fullyQualify, includeGenericInfo) + '*';

        /// <inheritdoc/>
        internal override TypeData GetEquivalentNewType(AssemblyFamily newAssemblyFamily) =>
            ElementType.GetEquivalentNewType(newAssemblyFamily)?.GetPointerType();

        /// <inheritdoc/>
        public override MetadataItemKinds MetadataItemKind => MetadataItemKinds.PointerType;

        /// <inheritdoc/>
        internal override MemberDataBase ReplaceGenericTypeParameters(GenericTypeParameterCollection genericParameters, GenericTypeArgumentCollection genericArguments)
        {
            var replacedElementType = (TypeData)ElementType.ReplaceGenericTypeParameters(genericParameters, genericArguments);
            if (replacedElementType == ElementType)
            {
                return this;
            }

            return replacedElementType.GetPointerType();
        }
    }
}
