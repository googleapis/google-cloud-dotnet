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
using System.Diagnostics;

namespace BreakingChangesDetector.MetadataItems
{
    /// <summary>
    /// Abstract base sealed class representing metadata for an externally visible type.
    /// </summary>
    public abstract class TypeData : MemberDataBase
    {
        private Dictionary<byte, ArrayTypeData> _arrayTypes;
        private PointerTypeData _pointerType;

        internal TypeData(string name, MemberAccessibility accessibility, MemberFlags memberFlags, TypeKind typeKind)
            : base(name, accessibility, memberFlags) =>
            TypeKind = typeKind;

        internal TypeData(ITypeSymbol typeSymbol, MemberAccessibility accessibility, DeclaringTypeData declaringType)
            : base(typeSymbol, accessibility, Utilities.GetMemberFlags(typeSymbol), declaringType) =>
            TypeKind = Utilities.GetTypeKind(typeSymbol);

        /// <summary>
        /// Gets the name to use for this item in messages.
        /// </summary>
        public sealed override string DisplayName => GetDisplayName();

        internal override bool DoesMatch(MetadataItemBase other)
        {
            if (base.DoesMatch(other) == false)
            {
                return false;
            }

            var otherTyped = other as TypeData;
            if (otherTyped == null)
            {
                return false;
            }

            if (TypeKind != otherTyped.TypeKind)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Gets the value indicating whether the <see cref="MemberDataBase.Name"/> of the member is primarily used to determine whether it is equivalent to another member.
        /// </summary>
        public sealed override bool IsNameUsedToVerifyEquivalence =>
            // TODO_Refactor: Why is this returned here and not on GenericTypeParameterData
            // For generic parameters, the position is used to verify equivalence (the name doesn't matter as long as it is used consistently 
            // within the class). For other types, the full name is used to verify equivalence, not the name
            false;

        /// <summary>
        /// Gets the display name for the type, which can be used for generating user-readable messages about the type.
        /// </summary>
        /// <param name="fullyQualify">Indicates whether the type name should be fully qualified with declaring type and namespace names.</param>
        /// <param name="includeGenericInfo">Indicates whether generic parameters and arguments should be included in type names.</param>
        /// <returns>The display name of the type.</returns>
        public abstract string GetDisplayName(bool fullyQualify = true, bool includeGenericInfo = true);

        /// <summary>
        /// Indicates whether a new type is logically the same as the current type, just from a newer build.
        /// </summary> 
        public bool IsEquivalentToNew(TypeData newType, AssemblyFamily newAssemblyFamily) =>
            IsEquivalentToNewMember(newType, newAssemblyFamily);

        /// <summary>
        /// Indicates whether an old type is logically the same as the current type, just from an older build.
        /// </summary> 
        public bool IsEquivalentToOld(TypeData oldType, AssemblyFamily newAssemblyFamily) =>
            oldType.IsEquivalentToNewMember(this, newAssemblyFamily);

        internal ArrayTypeData GetArrayType(byte rank)
        {
            if (_arrayTypes == null)
            {
                _arrayTypes = new Dictionary<byte, ArrayTypeData>();
            }

            if (_arrayTypes.TryGetValue(rank, out ArrayTypeData arrayTypeData) == false)
            {
                Debug.Assert(_arrayTypes.ContainsKey(rank) == false, "The array type was cached twice");
                _arrayTypes[rank] = arrayTypeData = new ArrayTypeData(
                    string.Format("{0}[{1}]", Name, new string(',', rank - 1)),
                    MemberAccessibility.Public,
                    MemberFlags.None,
                    TypeKind.Class,
                    this,
                    rank);
            }

            return arrayTypeData;
        }

        /// <summary>
        /// Gets the <see cref="AssemblyFamily"/> containing the type. If the type is nullable and type with element, 
        /// such as T?, T[], or T*, this returns the family containing the type T.
        /// </summary> 
        internal virtual AssemblyFamily GetDefiningAssemblyFamily() =>
            new AssemblyFamily { AssemblyData };

        /// <summary>
        /// Gets the types to which this type can implicitly convert. For type hierarchy conversions, only the direct base type will be enumerated.
        /// Ancestor base types will can be enumerated recursively by calling this method on the base type.
        /// </summary>
        /// <param name="onlyReferenceAndIdentityConversions">
        /// True if reference and identify conversions are they only allowed conversions; False if all implicit conversions are allowed.
        /// </param>
        /// <returns>
        /// A collection of all types to which this type can convert explicitly, except for ancestor base types which are not the direct base type.
        /// </returns> 
        internal abstract IEnumerable<TypeData> GetDirectImplicitConversions(bool onlyReferenceAndIdentityConversions);

        /// <summary>
        /// Gets the type equivalent to this one which is from a newer assembly.
        /// </summary>
        /// <param name="newAssemblyFamily">The assembly family in which new assemblies reside.</param>
        internal abstract TypeData GetEquivalentNewType(AssemblyFamily newAssemblyFamily);

        /// <summary>
        /// Gets the name of the namespace in which the type is defined, or null if it is not defined in a namespace.
        /// </summary> 
        internal virtual string GetNamespaceName() => null;

        internal PointerTypeData GetPointerType()
        {
            if (_pointerType == null)
            {
                _pointerType = new PointerTypeData(Name + "*", Accessibility, MemberFlags.None, TypeKind.Class, this);
            }
            return _pointerType;
        }

        internal virtual bool IsArray(out int rank, out TypeData elementType)
        {
            rank = 0;
            elementType = null;
            return false;
        }

        /// <summary>
        /// Indicates whether a variable of the current type is assignable from the specified source type.
        /// </summary>
        /// <param name="sourceType">The source type from which to test assignability to this type.</param>
        /// <param name="context">Information about the context of the IsAssignableFrom invocation.</param>
        /// <returns>True if a value of the source type is assignable to a variable of the current type.</returns> 
        internal virtual bool IsAssignableFrom(TypeData sourceType, IsAssignableFromContext context)
        {
            if (IsEquivalentTo(sourceType, context.NewAssemblyFamily, context.IsSourceTypeOld))
            {
                return true;
            }

            foreach (var implicitConversionType in sourceType.GetDirectImplicitConversions(context.OnlyReferenceAndIdentityConversions))
            {
                if (IsAssignableFrom(implicitConversionType, context))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Indicates whether a variable of the current type is assignable from the specified source type, which is from a newer build, if they
        /// had been from the same assembly version.
        /// </summary>
        /// <param name="newSourceType">The newer source type from which to test assignability to this type.</param>
        /// <param name="newAssemblyFamily">
        /// The newer family of assemblies from which to obtain equivalents of older types, or null to use a default family containing only the new type's assembly.
        /// </param>
        internal bool IsAssignableFromNew(TypeData newSourceType, AssemblyFamily newAssemblyFamily = null)
        {
            newAssemblyFamily = newAssemblyFamily ?? newSourceType.GetDefiningAssemblyFamily();
            return IsAssignableFrom(newSourceType, new IsAssignableFromContext(newAssemblyFamily, isSourceTypeOld: false, onlyReferenceAndIdentityConversions: false));
        }

        /// <summary>
        /// Indicates whether a variable of the current type is assignable from the specified source type, which is from an older build, if they
        /// had been from the same assembly version.
        /// </summary>
        /// <param name="oldSourceType">The older source type from which to test assignability to this type.</param>
        /// <param name="newAssemblyFamily">
        /// The newer family of assemblies from which to obtain equivalents of older types, or null to use a default family containing only the new type's assembly.
        /// </param>
        internal bool IsAssignableFromOld(TypeData oldSourceType, AssemblyFamily newAssemblyFamily = null)
        {
            newAssemblyFamily = newAssemblyFamily ?? GetDefiningAssemblyFamily();
            return IsAssignableFrom(oldSourceType, new IsAssignableFromContext(newAssemblyFamily, isSourceTypeOld: true, onlyReferenceAndIdentityConversions: false));
        }

        /// <summary>
        /// Indicates whether the specified type is equivalent to the current type (but from another version).
        /// </summary>
        /// <param name="otherType">The type to compare to the current type.</param>
        /// <param name="newAssemblyFamily">The assembly family in which new assemblies reside.</param>
        /// <param name="isOtherTypeOld">Indicates whether the type on which this method is called is from the older version of assemblies.</param>
        /// <returns>True if the types are equivalent but from different assembly versions; False otherwise.</returns> 
        internal bool IsEquivalentTo(TypeData otherType, AssemblyFamily newAssemblyFamily, bool isOtherTypeOld) =>
            isOtherTypeOld
                ? otherType.IsEquivalentToNewMember(this, newAssemblyFamily)
                : IsEquivalentToNewMember(otherType, newAssemblyFamily);

        /// <summary>
        /// Indicates whether the type is a nullable value type.
        /// </summary>
        /// <param name="underlyingType">[Out] Will be set to the underlying value type if the tpye is nullable; will be null otherwise.</param>
        /// <returns>True if the type is nullable; False otherwise.</returns> 
        internal virtual bool IsNullable(out TypeData underlyingType)
        {
            underlyingType = null;
            return false;
        }

        /// <summary>
        /// Indicates whether the type can convert to the specified target type using type parameter variance.
        /// </summary>
        /// <param name="target">The target type to which this type might convert.</param>
        /// <param name="context">Information about the context of the IsAssignableFrom invocation.</param>
        /// <returns>True is the type is variance convertible to the target; False otherwise.</returns> 
        internal virtual bool IsVarianceConvertibleTo(ConstructedGenericTypeData target, IsAssignableFromContext context) => false;

        /// <summary>
        /// Gets the kind of type this instance represents.
        /// </summary>
        public TypeKind TypeKind { get; }

        /// <summary>
        /// Gets the value indicating whether the type represents a value type.
        /// </summary>
        internal bool IsValueType => TypeKind == TypeKind.Enum || TypeKind == TypeKind.Struct;
    }
}
