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
    /// Represents the metadata for an externally visible property.
    /// </summary>
    public class PropertyData : TypedMemberDataBase
    {
        internal PropertyData(string name, MemberAccessibility accessibility, MemberFlags memberFlags, TypeData type, bool isTypeDynamic, MemberAccessibility? getMethodAccessibility, MemberAccessibility? setMethodAccessibility)
            : base(name, accessibility, memberFlags, type, isTypeDynamic)
        {
            GetMethodAccessibility = getMethodAccessibility;
            SetMethodAccessibility = setMethodAccessibility;
        }

        internal PropertyData(IPropertySymbol propertySymbol, MemberAccessibility? getAccessibility, MemberAccessibility? setAccessibility, DeclaringTypeData declaringType)
            : base(propertySymbol,
            Utilities.GetLeastRestrictiveAccessibility(getAccessibility, setAccessibility),
            propertySymbol.Type,
            propertySymbol.IsPropertyTypeDynamic(),
            Utilities.GetMemberFlags(propertySymbol.GetMethod) | Utilities.GetMemberFlags(propertySymbol.SetMethod),
            declaringType)
        {
            GetMethodAccessibility = getAccessibility;
            SetMethodAccessibility = setAccessibility;
        }

        /// <inheritdoc/>
        public override void Accept(MetadataItemVisitor visitor) => visitor.VisitPropertyData(this);

        /// <inheritdoc/>
        internal override bool CanOverrideMember(MemberDataBase baseMember)
        {
            if (base.CanOverrideMember(baseMember) == false)
            {
                return false;
            }

            var basePropertyData = (PropertyData)baseMember;

            // Overrides cannot add accessors
            if (GetMethodAccessibility != null && basePropertyData.GetMethodAccessibility == null)
            {
                return false;
            }

            if (SetMethodAccessibility != null && basePropertyData.SetMethodAccessibility == null)
            {
                return false;
            }

            // Overrides cannot change the accessibility of accessors
            if (GetMethodAccessibility != null &&
                basePropertyData.GetMethodAccessibility != null &&
                GetMethodAccessibility != basePropertyData.GetMethodAccessibility)
            {
                return false;
            }

            if (SetMethodAccessibility != null &&
                basePropertyData.SetMethodAccessibility != null &&
                SetMethodAccessibility != basePropertyData.SetMethodAccessibility)
            {
                return false;
            }

            return true;
        }

        internal override bool DoesMatch(MetadataItemBase other)
        {
            if (base.DoesMatch(other) == false)
            {
                return false;
            }

            var otherTyped = other as PropertyData;
            if (otherTyped == null)
            {
                return false;
            }

            if (GetMethodAccessibility != otherTyped.GetMethodAccessibility)
            {
                return false;
            }

            if (SetMethodAccessibility != otherTyped.SetMethodAccessibility)
            {
                return false;
            }

            return true;
        }

        /// <inheritdoc/>
        public override MetadataItemKinds MetadataItemKind => MetadataItemKinds.Property;

        /// <inheritdoc/>
        internal override MemberDataBase ReplaceGenericTypeParameters(GenericTypeParameterCollection genericParameters, GenericTypeArgumentCollection genericArguments)
        {
            var replacedType = (TypeData)Type.ReplaceGenericTypeParameters(genericParameters, genericArguments);
            if (replacedType == Type)
            {
                return this;
            }

            return new PropertyData(Name, Accessibility, MemberFlags, replacedType, IsTypeDynamic, GetMethodAccessibility, SetMethodAccessibility);
        }

        internal static PropertyData PropertyDataFromReflection(IPropertySymbol propertySymbol, DeclaringTypeData declaringType)
        {
            var getAccessibility = propertySymbol.GetMethod.GetAccessibility();
            var setAccessibility = propertySymbol.SetMethod.GetAccessibility();
            if (getAccessibility == null && setAccessibility == null)
            {
                return null;
            }

            return new PropertyData(propertySymbol, getAccessibility, setAccessibility, declaringType);
        }

        /// <summary>
        /// Gets the accessibility of the get accessor, or null if it is not externally visible.
        /// </summary>
        public MemberAccessibility? GetMethodAccessibility { get; }

        /// <summary>
        /// Gets the accessibility of the set accessor, or null if it is not externally visible.
        /// </summary>
        public MemberAccessibility? SetMethodAccessibility { get; }
    }
}
