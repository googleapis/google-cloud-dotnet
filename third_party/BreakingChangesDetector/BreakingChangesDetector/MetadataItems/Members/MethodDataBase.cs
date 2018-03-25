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
    /// Abstract base sealed class representing metadata for externally visible methods.
    /// </summary>
    public abstract class MethodDataBase : TypedMemberDataBase,
        IParameterizedItem
    {
        internal MethodDataBase(string name, MemberAccessibility accessibility, MemberFlags memberFlags, TypeData type, bool isTypeDynamic, ParameterCollection parameters)
            : base(name, accessibility, memberFlags, type, isTypeDynamic) =>
            Parameters = parameters;

        internal MethodDataBase(IMethodSymbol methodSymbol, MemberAccessibility accessibility, DeclaringTypeData declaringType)
            : base(methodSymbol, accessibility, methodSymbol.ReturnType, methodSymbol.IsReturnTypeDynamic(), Utilities.GetMemberFlags(methodSymbol), declaringType) =>
            Parameters = new ParameterCollection(methodSymbol.Parameters, this);

        /// <inheritdoc/>
        internal override bool CanOverrideMember(MemberDataBase baseMember)
        {
            if (base.CanOverrideMember(baseMember) == false)
            {
                return false;
            }

            var otherMethodBase = (MethodDataBase)baseMember;
            return Parameters.IsEquivalentTo(otherMethodBase.Parameters);
        }

        /// <inheritdoc/>
        public override string DisplayName => Name + Parameters.GetParameterListDisplayText();

        internal override bool DoesMatch(MetadataItemBase other)
        {
            if (base.DoesMatch(other) == false)
            {
                return false;
            }

            var otherTyped = other as MethodDataBase;
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

        /// <inheritdoc/>
        internal override bool IsEquivalentToNewMember(MemberDataBase newMember, AssemblyFamily newAssemblyFamily) =>
            IsEquivalentToNewMember((MethodDataBase)newMember, newAssemblyFamily, ignoreNewOptionalParameters: false);

        bool IParameterizedItem.IsEquivalentToNewMember(MemberDataBase newMember, AssemblyFamily newAssemblyFamily, bool ignoreNewOptionalParameters) =>
            IsEquivalentToNewMember((MethodDataBase)newMember, newAssemblyFamily, ignoreNewOptionalParameters);

        /// <summary>
        /// Indicates whether a new member of the same type and name is logically the same member as the current member, just from a newer build.
        /// </summary>
        /// <param name="newMember">The new member to compare.</param>
        /// <param name="newAssemblyFamily">The assembly family in which new assemblies reside.</param>
        /// <param name="ignoreNewOptionalParameters">
        /// Indicates whether to ignore any new parameters at the end of the collection which are optional when comparing.
        /// </param>
        private bool IsEquivalentToNewMember(MethodDataBase newMember, AssemblyFamily newAssemblyFamily, bool ignoreNewOptionalParameters)
        {
            if (base.IsEquivalentToNewMember(newMember, newAssemblyFamily) == false)
            {
                return false;
            }

            return Parameters.IsEquivalentToNewParameters(newMember.Parameters, newAssemblyFamily, ignoreNewOptionalParameters);
        }

        /// <summary>
        /// Gets the collection of parameters for the method.
        /// </summary>
        public ParameterCollection Parameters { get; }
    }
}
