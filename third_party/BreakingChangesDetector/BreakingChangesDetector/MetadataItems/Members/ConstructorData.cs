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
    /// Represents the metadata for an externally visible constructor.
    /// </summary>
    public sealed class ConstructorData : MemberDataBase,
        IParameterizedItem
    {
        internal ConstructorData(string name, MemberAccessibility accessibility, MemberFlags memberFlags, ParameterCollection parameters)
            : base(name, accessibility, memberFlags) =>
            Parameters = parameters;

        private ConstructorData(IMethodSymbol methodSymbol, MemberAccessibility accessibility, DeclaringTypeData declaringType)
            : base(methodSymbol, accessibility, Utilities.GetMemberFlags(methodSymbol), declaringType) =>
            Parameters = new ParameterCollection(methodSymbol.Parameters, this);

        bool IParameterizedItem.IsEquivalentToNewMember(MemberDataBase newMember, AssemblyFamily newAssemblyFamily, bool ignoreNewOptionalParameters)
        {
            var newConstructor = newMember as ConstructorData;
            if (newConstructor == null)
            {
                return false;
            }

            return IsEquivalentToNewMember(newConstructor, newAssemblyFamily, ignoreNewOptionalParameters);
        }

        /// <summary>
        /// Performs the specified visitor's functionality on this instance.
        /// </summary>
        /// <param name="visitor">The visitor whose functionality should be performed on the instance.</param>
        public override void Accept(MetadataItemVisitor visitor) =>
            visitor.VisitConstructorData(this);

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

            var otherConstructor = (ConstructorData)baseMember;
            return Parameters.IsEquivalentTo(otherConstructor.Parameters);
        }

        /// <summary>
        /// Gets the name to use for this item in messages.
        /// </summary>
        public override string DisplayName =>
            Name + Parameters.GetParameterListDisplayText();

        internal override bool DoesMatch(MetadataItemBase other)
        {
            if (base.DoesMatch(other) == false)
            {
                return false;
            }

            var otherTyped = other as ConstructorData;
            if (otherTyped == null)
            {
                return false;
            }

            if (Parameters.DoesMatch(otherTyped.Parameters) == false)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Indicates whether a new member of the same type and name is logically the same member as the current member, just from a newer build.
        /// </summary> 
        internal override bool IsEquivalentToNewMember(MemberDataBase newMember, AssemblyFamily newAssemblyFamily)
        {
            var newConstructor = newMember as ConstructorData;
            if (newConstructor == null)
            {
                return false;
            }

            return IsEquivalentToNewMember(newConstructor, newAssemblyFamily, ignoreNewOptionalParameters: false);
        }

        /// <summary>
        /// Gets the type of item the instance represents.
        /// </summary>
        public override MetadataItemKinds MetadataItemKind =>
            MetadataItemKinds.Constructor;

        /// <summary>
        /// Replaces all type parameters used by the member with their associated generic arguments specified in a constructed generic type.
        /// </summary>
        /// <param name="genericParameters">The generic parameters being replaced.</param>
        /// <param name="genericArguments">The generic arguments replacing the parameters.</param>
        /// <returns>A new member with the replaced type parameters or the current instance if the member does not use any of the generic parameters.</returns> 
        internal override MemberDataBase ReplaceGenericTypeParameters(GenericTypeParameterCollection genericParameters, GenericTypeArgumentCollection genericArguments)
        {
            var replacedParameters = Parameters.ReplaceGenericTypeParameters(MetadataItemKind, genericParameters, genericArguments);
            if (replacedParameters == Parameters)
            {
                return this;
            }

            return new ConstructorData(Name, Accessibility, MemberFlags, replacedParameters);
        }

        internal static ConstructorData ConstructorDataFromReflection(IMethodSymbol methodSymbol, DeclaringTypeData declaringType)
        {
            var accessibility = methodSymbol.GetAccessibility();
            if (accessibility == null)
            {
                return null;
            }

            return new ConstructorData(methodSymbol, accessibility.Value, declaringType);
        }

        /// <summary>
        /// Indicates whether a new member of the same type and name is logically the same member as the current member, just from a newer build.
        /// </summary>
        /// <param name="newMember">The new member to compare.</param>
        /// <param name="newAssemblyFamily">The assembly family in which new assemblies reside.</param>
        /// <param name="ignoreNewOptionalParameters">
        /// Indicates whether to ignore any new parameters at the end of the collection which are optional when comparing.
        /// </param>
        private bool IsEquivalentToNewMember(ConstructorData newMember, AssemblyFamily newAssemblyFamily, bool ignoreNewOptionalParameters)
        {
            if (base.IsEquivalentToNewMember(newMember, newAssemblyFamily) == false)
            {
                return false;
            }

            return Parameters.IsEquivalentToNewParameters(newMember.Parameters, newAssemblyFamily, ignoreNewOptionalParameters);
        }

        /// <summary>
        /// Gets the collection of parameters for the constructor.
        /// </summary>
        public ParameterCollection Parameters { get; }
    }
}
