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
    /// Represents the metadata for an externally visible array type.
    /// </summary>
    public sealed class ArrayTypeData : TypeWithElementData
    {
        internal ArrayTypeData(string name, MemberAccessibility accessibility, MemberFlags memberFlags, TypeKind typeKind, TypeData elementType, byte arrayRank)
            : base(name, accessibility, memberFlags, typeKind, elementType) =>
            ArrayRank = arrayRank;

        internal override bool DoesMatch(MetadataItemBase other)
        {
            if (base.DoesMatch(other) == false)
            {
                return false;
            }

            var otherTyped = other as ArrayTypeData;
            if (otherTyped == null)
            {
                return false;
            }

            if (ArrayRank != otherTyped.ArrayRank)
            {
                return false;
            }

            return true;
        }

        /// <inheritdoc/>
        internal override IEnumerable<TypeData> GetDirectImplicitConversions(bool onlyReferenceAndIdentityConversions)
        {
            var mscorlibData = AssemblyData.GetReferencedAssembly(Utilities.CommonObjectRuntimeAssemblyName);
            if (mscorlibData == null)
            {
                yield break;
            }

            yield return mscorlibData.GetTypeDefinitionData(Utilities.ArrayTypeName);
            yield return mscorlibData.GetTypeDefinitionData(Utilities.ICloneableTypeName);
            yield return mscorlibData.GetTypeDefinitionData(Utilities.IListTypeName);
            yield return mscorlibData.GetTypeDefinitionData(Utilities.ICollectionTypeName);
            yield return mscorlibData.GetTypeDefinitionData(Utilities.IEnumerableTypeName);
            yield return mscorlibData.GetTypeDefinitionData(Utilities.IStructuralComparableTypeName);
            yield return mscorlibData.GetTypeDefinitionData(Utilities.IStructuralEquatableTypeName);

            if (ArrayRank == 1)
            {
                var genericArguments = new TypeDataSequence(ElementType);
                yield return mscorlibData.GetTypeDefinitionData(Utilities.IListGenericTypeName).GetConstructedGenericTypeData(genericArguments);
                yield return mscorlibData.GetTypeDefinitionData(Utilities.ICollectionGenericTypeName).GetConstructedGenericTypeData(genericArguments);
                yield return mscorlibData.GetTypeDefinitionData(Utilities.IEnumerableGenericTypeName).GetConstructedGenericTypeData(genericArguments);
                yield return mscorlibData.GetTypeDefinitionData(Utilities.IReadOnlyCollectionGenericTypeName).GetConstructedGenericTypeData(genericArguments);
                yield return mscorlibData.GetTypeDefinitionData(Utilities.IReadOnlyListGenericTypeName).GetConstructedGenericTypeData(genericArguments);
            }
        }

        /// <inheritdoc/>
        public override string GetDisplayName(bool fullyQualify = true, bool includeGenericInfo = true) =>
            ElementType.GetDisplayName(fullyQualify, includeGenericInfo) + '[' + new string(',', ArrayRank - 1) + ']';

        /// <inheritdoc/>
        internal override TypeData GetEquivalentNewType(AssemblyFamily newAssemblyFamily)
        {
            var newElementType = ElementType.GetEquivalentNewType(newAssemblyFamily);
            if (newElementType == null)
            {
                return null;
            }

            return
                newElementType.GetArrayType(ArrayRank) ??
                new ArrayTypeData(Name, Accessibility, MemberFlags, TypeKind, newElementType, ArrayRank);
        }

        internal override bool IsArray(out int rank, out TypeData elementType)
        {
            rank = ArrayRank;
            elementType = ElementType;
            return true;
        }

        /// <inheritdoc/>
        internal override bool IsAssignableFrom(TypeData sourceType, IsAssignableFromContext context)
        {
            if (base.IsAssignableFrom(sourceType, context))
            {
                return true;
            }

            // From C# specification: (The implicit reference conversions are) 
            // - From an array-type S with an element type Se to an array-type T with an element type Te, provided all of the following are true:
            //   - S and T differ only in element type. In other words, S and T have the same number of dimensions.
            //   - Both Se and Te are reference-types.
            //   - An implicit reference conversion exists from Se to Te.
            if (ElementType.IsValueType == false)
            {
                if (sourceType.IsArray(out int sourceRank, out TypeData sourceElementType) &&
                    sourceElementType.IsValueType == false &&
                    ArrayRank == sourceRank)
                {
                    return ElementType.IsAssignableFrom(sourceElementType, new IsAssignableFromContext(context.NewAssemblyFamily, context.IsSourceTypeOld, onlyReferenceAndIdentityConversions: true));
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

            var other = newMember as ArrayTypeData;
            if (other == null)
            {
                return false;
            }

            return ArrayRank == other.ArrayRank;
        }

        /// <inheritdoc/>
        public override MetadataItemKinds MetadataItemKind => MetadataItemKinds.ArrayType;

        /// <inheritdoc/>
        internal override MemberDataBase ReplaceGenericTypeParameters(GenericTypeParameterCollection genericParameters, GenericTypeArgumentCollection genericArguments)
        {
            var replacedElementType = (TypeData)ElementType.ReplaceGenericTypeParameters(genericParameters, genericArguments);
            if (replacedElementType == ElementType)
            {
                return this;
            }

            return
                replacedElementType.GetArrayType(ArrayRank) ??
                new ArrayTypeData(
                    Name,
                    Accessibility,
                    MemberFlags,
                    TypeKind,
                    replacedElementType,
                    ArrayRank);
        }

        /// <summary>
        /// Gets the number of dimensions for array types if <see cref="IsArray"/> is true; 0 otherwise.
        /// </summary>
        public byte ArrayRank { get; } // TODO_Serialize: Round trip and unit test
    }
}
