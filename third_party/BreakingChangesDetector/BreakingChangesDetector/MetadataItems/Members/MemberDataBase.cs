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
using System.Linq;
using System.Reflection;

namespace BreakingChangesDetector.MetadataItems
{
    /// <summary>
    /// Abstract base sealed class representing metadata for externally visible members declared within a type.
    /// </summary>
    public abstract class MemberDataBase : MetadataItemBase
    {
        internal const BindingFlags DeclaredOnlyFlags =
            BindingFlags.Public | BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.Static |
            BindingFlags.DeclaredOnly;

        internal static readonly List<MemberDataBase> EmptyList = new List<MemberDataBase>();

        internal MemberDataBase(string name, MemberAccessibility accessibility, MemberFlags memberFlags)
        {
            Accessibility = accessibility;
            MemberFlags = memberFlags;
            Name = name;
        }

        internal MemberDataBase(ISymbol underlyingSymbol, MemberAccessibility accessibility, MemberFlags memberFlags, DeclaringTypeData declaringType)
        {
            Accessibility = accessibility;
            ContainingType = declaringType;
            MemberFlags = memberFlags;
            Name = underlyingSymbol.MetadataName;
        }

        public override MetadataResolutionContext Context => AssemblyData?.Context;

        /// <inheritdoc/>
        public override string DisplayName => Name;

        internal override bool DoesMatch(MetadataItemBase other)
        {
            if (base.DoesMatch(other) == false)
            {
                return false;
            }

            var otherTyped = other as MemberDataBase;
            if (otherTyped == null)
            {
                return false;
            }

            if (Accessibility != otherTyped.Accessibility)
            {
                return false;
            }

            if (ContainingType == null ^ otherTyped.ContainingType == null)
            {
                return false;
            }

            if (ContainingType != null && ContainingType.DisplayName != otherTyped.ContainingType.DisplayName)
            {
                return false;
            }

            if (MemberFlags != otherTyped.MemberFlags)
            {
                return false;
            }

            if (Name != otherTyped.Name)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Indicates whether the current member can override the specified member from a base type.
        /// </summary>
        /// <param name="baseMember">The member from the base type.</param>
        /// <returns>True if the current member can override the base member; False otherwise.</returns>  
        internal virtual bool CanOverrideMember(MemberDataBase baseMember)
        {
            // Static members cannot be overridden
            if (IsStatic || baseMember.IsStatic)
            {
                return false;
            }

            // Members which are not virtual, abstract, or override cannot be overridden.
            if (IsVirtualCallType == false || baseMember.IsVirtualCallType == false)
            {
                return false;
            }

            return
                Accessibility == baseMember.Accessibility &&
                Name == baseMember.Name;
        }

        /// <summary>
        /// Gets the base member this member overrides, or null if this member doesn't override anything.
        /// </summary>
        /// <returns></returns>  
        internal MemberDataBase GetBaseMember()
        {
            if (ContainingType == null || IsOverride == false)
            {
                return null;
            }

            var baseType = ContainingType.BaseType;
            while (baseType != null)
            {
                var members = baseType.GetMembers(Name).Where(m => m.MetadataItemKind == MetadataItemKind && m.CanBeOverridden);
                foreach (var member in members)
                {
                    if (CanOverrideMember(member))
                    {
                        return member;
                    }
                }

                baseType = baseType.BaseType;
            }

            return null;
        }

        /// <summary>
        /// Indicates whether a new member of the same type and name is logically the same member as the current member, just from a newer build.
        /// </summary> 
        internal virtual bool IsEquivalentToNewMember(MemberDataBase newMember, AssemblyFamily newAssemblyFamily)
        {
            if (IsNameUsedToVerifyEquivalence && Name != newMember.Name)
            {
                return false;
            }

            return MetadataItemKind == newMember.MetadataItemKind;
        }

        internal static MemberDataBase MemberDataFromReflection(ISymbol symbol, DeclaringTypeData declaringType)
        {
            // TODO: Use a symbol visitor instead?
            switch (symbol.Kind)
            {
                case SymbolKind.NamedType:
                    return declaringType.AssemblyData.GetTypeData((ITypeSymbol)symbol);

                case SymbolKind.Method:
                    {
                        var method = (IMethodSymbol)symbol;

                        if (method.MethodKind == MethodKind.Constructor)
                        {
                            if (declaringType.TypeKind == TypeKind.Enum)
                            {
                                return null;
                            }
                            return ConstructorData.ConstructorDataFromReflection(method, declaringType);
                        }

                        if (method.MethodKind == MethodKind.UserDefinedOperator ||
                            method.MethodKind == MethodKind.Conversion)
                        {
                            if (method.DeclaredAccessibility == Microsoft.CodeAnalysis.Accessibility.Public && method.IsStatic && method.Name.StartsWith("op_"))
                            {
                                return new OperatorData(method, declaringType);
                            }
                        }

                        if (method.MethodKind == MethodKind.Ordinary ||
                            method.MethodKind == MethodKind.DelegateInvoke)
                        {
                            return MethodData.MethodDataFromReflection(method, declaringType);
                        }

                        return null;
                    }

                case SymbolKind.Field:
                    {
                        var field = (IFieldSymbol)symbol;

                        // Filter out the "value__" field on enums
                        if (declaringType.TypeKind == TypeKind.Enum && field.IsStatic == false)
                        {
                            return null;
                        }

                        if (field.IsConst)
                        {
                            return ConstantData.ConstantDataFromReflection(field, declaringType);
                        }

                        return FieldData.FieldDataFromReflection(field, declaringType);
                    }

                case SymbolKind.Event:
                    return EventData.EventDataFromReflection((IEventSymbol)symbol, declaringType);

                case SymbolKind.Property:
                    {
                        var property = (IPropertySymbol)symbol;
                        if (property.IsIndexer)
                        {
                            return IndexerData.IndexerDataFromReflection(property, declaringType);
                        }

                        return PropertyData.PropertyDataFromReflection(property, declaringType);
                    }

                default:
                    Debug.Fail("Unknown SymbolKind: " + symbol.Kind);
                    return null;
            }
        }

        /// <summary>
        /// Replaces all type parameters used by the member with their associated generic arguments specified in a constructed generic type.
        /// </summary>
        /// <param name="genericParameters">The generic parameters being replaced.</param>
        /// <param name="genericArguments">The generic arguments replacing the parameters.</param>
        /// <returns>A new member with the replaced type parameters or the current instance if the member does not use any of the generic parameters.</returns> 
        internal abstract MemberDataBase ReplaceGenericTypeParameters(GenericTypeParameterCollection genericParameters, GenericTypeArgumentCollection genericArguments);

        /// <summary>
        /// Gets the external accessibility of the member, which indicates whether it is public or protected.
        /// </summary>
        public MemberAccessibility Accessibility { get; }

        /// <summary>
        /// Gets the <see cref="T:AssemblyData"/> representing the assembly in which the member is defined.
        /// </summary>
        public virtual AssemblyData AssemblyData => ContainingType?.AssemblyData;

        /// <summary>
        /// Gets the value indicating whether the member can be overridden in derived types.
        /// </summary>
        public bool CanBeOverridden => IsSealed == false && IsVirtualCallType;

        /// <summary>
        /// Gets the type in which this member is declared.
        /// </summary>
        public DeclaringTypeData ContainingType { get; internal set; } // TODO: Make private?

        /// <summary>
        /// Gets the value indicating whether the member is marked abstract.
        /// </summary>
        public bool IsAbstract => MemberFlags.HasFlag(MemberFlags.Abstract);

        /// <summary>
        /// Gets the value indicating whether the member is and instance member.
        /// </summary>
        public bool IsInstance => IsStatic == false;

        /// <summary>
        /// Gets the value indicating whether the <see cref="Name"/> of the member is primarily used to determine whether it is equivalent to another member.
        /// </summary>
        public virtual bool IsNameUsedToVerifyEquivalence => true;

        /// <summary>
        /// Gets the value indicating whether the member overrides another.
        /// </summary>
        public bool IsOverride => MemberFlags.HasFlag(MemberFlags.Override);

        /// <summary>
        /// Gets the value indicating whether the member is marked sealed.
        /// </summary>
        public bool IsSealed => MemberFlags.HasFlag(MemberFlags.Sealed);

        /// <summary>
        /// Gets the value indicating whether the member is marked static.
        /// </summary>
        public bool IsStatic => MemberFlags.HasFlag(MemberFlags.Static);

        /// <summary>
        /// Gets the value indicating whether the member is marked virtual.
        /// </summary>
        public bool IsVirtual => MemberFlags.HasFlag(MemberFlags.Virtual);

        /// <summary>
        /// Gets the value indicating whether the member uses a virtual call type (is marked virtual, abstract, or override).
        /// </summary>
        public bool IsVirtualCallType =>
            (MemberFlags & (MemberFlags.Virtual | MemberFlags.Abstract | MemberFlags.Override)) != 0;

        /// <summary>
        /// Gets the name of the member.
        /// </summary>
        public string Name { get; }

        internal MemberFlags MemberFlags { get; }
    }
}
