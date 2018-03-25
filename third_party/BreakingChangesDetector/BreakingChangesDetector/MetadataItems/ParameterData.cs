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
    /// Represents the metadata for an externally visible method or indexer parameter.
    /// </summary>
    public sealed class ParameterData : MetadataItemBase,
        ITypedItem
    {
        private readonly InternalFlags _flags; // TODO_Serialize: round trip and test

        internal ParameterData(MetadataItemKinds declaringMemberKind, string name, TypeData type, ParameterModifier modifer, InternalFlags flags, object defaultValue)
        {
            _flags = flags;

            DeclaringMemberKind = declaringMemberKind;
            DefaultValue = defaultValue;
            Modifer = modifer;
            Name = name;
            Type = type;
        }

        internal ParameterData(IParameterSymbol parameterSymbol, MemberDataBase declaringMember)
        {
            Context = declaringMember.Context;

            var parameterType = parameterSymbol.Type;

            ParameterModifier modifer;
            switch (parameterSymbol.RefKind)
            {
                case RefKind.None:
                    modifer = ParameterModifier.None;
                    break;
                case RefKind.Out:
                    modifer = ParameterModifier.Out;
                    break;
                case RefKind.Ref:
                    modifer = ParameterModifier.Ref;
                    break;
                default:
                    throw new InvalidOperationException($"Unknown RefKind value: {parameterSymbol.RefKind}");
            }

            DeclaringMemberKind = declaringMember.MetadataItemKind;
            Modifer = modifer;
            Name = parameterSymbol.Name;
            Type = Context.GetTypeData(parameterType);

            if (parameterSymbol.IsOptional)
            {
                _flags |= InternalFlags.IsOptional;
                DefaultValue = Utilities.PreprocessConstantValue(parameterType, parameterSymbol.ExplicitDefaultValue);
            }

            if (parameterSymbol.IsParams)
            {
                _flags |= InternalFlags.IsParamsArray;
            }

            if (parameterSymbol.Type.TypeKind == TypeKind.Dynamic)
            {
                _flags |= InternalFlags.IsTypeDynamic;
            }
        }

        /// <summary>
        /// Performs the specified visitor's functionality on this instance.
        /// </summary>
        /// <param name="visitor">The visitor whose functionality should be performed on the instance.</param>
        public override void Accept(MetadataItemVisitor visitor) => visitor.VisitParameterData(this);

        // TODO_Refactor: Can we get away with this not storing the context? The parameter would need to store its owning member.
        public override MetadataResolutionContext Context { get; }

        /// <summary>
        /// Gets the name to use for this item in messages.
        /// </summary>
        public override string DisplayName => Name;

        internal override bool DoesMatch(MetadataItemBase other)
        {
            if (base.DoesMatch(other) == false)
            {
                return false;
            }

            var otherTyped = other as ParameterData;
            if (otherTyped == null)
            {
                return false;
            }

            if (_flags != otherTyped._flags)
            {
                return false;
            }

            if (DeclaringMemberKind != otherTyped.DeclaringMemberKind)
            {
                return false;
            }

            if (Object.Equals(DefaultValue, otherTyped.DefaultValue) == false)
            {
                return false;
            }

            if (Modifer != otherTyped.Modifer)
            {
                return false;
            }

            if (Name != otherTyped.Name)
            {
                return false;
            }

            if (Type.DisplayName != otherTyped.DisplayName)
            {
                return false;
            }

            return true;
        }

        internal string GetDefaultValueDisplayText()
        {
            if (IsOptional == false)
            {
                return null;
            }

            var value = DefaultValue;
            if (value == null)
            {
                return "null";
            }

            if (value is bool)
            {
                return value.ToString().ToLower();
            }

            if (Type.TypeKind == TypeKind.Enum)
            {
                return Utilities.FormatEnumValue((TypeDefinitionData)Type, value);
            }

            return value.ToString();
        }

        internal string GetParameterListDisplayText()
        {
            var typeName = IsTypeDynamic
                ? Utilities.DynamicTypeName
                : Type.GetDisplayName(fullyQualify: false);

            if (IsParamsArray)
            {
                typeName = "params " + typeName;
            }
            else
            {
                switch (Modifer)
                {
                    case ParameterModifier.None:
                        break;

                    case ParameterModifier.Ref:
                        typeName = "ref " + typeName;
                        break;

                    case ParameterModifier.Out:
                        typeName = "out " + typeName;
                        break;

                    default:
                        Debug.Fail("Unknown ParameterModifier: " + Modifer);
                        break;
                }
            }

            var defaultValueText = GetDefaultValueDisplayText();
            if (defaultValueText != null)
            {
                return typeName + " = " + defaultValueText;
            }

            return typeName;
        }

        /// <summary>
        /// Indicates whether the two parameter is equivalent to the specified parameter, meaning it has the same type and modifiers (name and default value are ignored).
        /// </summary> 
        internal bool IsEquivalentTo(ParameterData other) =>
            IsTypeDynamic == other.IsTypeDynamic &&
            IsParamsArray == other.IsParamsArray &&
            Modifer == other.Modifer &&
            Type == other.Type;

        /// <summary>
        /// Indicates whether a new parameter of the same type and name is logically the same member as the current parameter, just from a newer build.
        /// </summary> 
        internal bool IsEquivalentToNewParameter(ParameterData newParameter, AssemblyFamily newAssemblyFamily) =>
            IsTypeDynamic == newParameter.IsTypeDynamic &&
            IsParamsArray == newParameter.IsParamsArray &&
            Modifer == newParameter.Modifer &&
            Type.IsEquivalentToNew(newParameter.Type, newAssemblyFamily);

        /// <summary>
        /// Replaces all type parameters used by the member with their associated generic arguments specified in a constructed generic type.
        /// </summary>
        /// <param name="declaringMemberKind">The type of member owning the parameter collection.</param>
        /// <param name="genericParameters">The generic parameters being replaced.</param>
        /// <param name="genericArguments">The generic arguments replacing the parameters.</param>
        /// <returns>A new member with the replaced type parameters or the current instance if the member does not use any of the generic parameters.</returns> 
        internal ParameterData ReplaceGenericTypeParameters(MetadataItemKinds declaringMemberKind, GenericTypeParameterCollection genericParameters, GenericTypeArgumentCollection genericArguments)
        {
            var replacedType = (TypeData)Type.ReplaceGenericTypeParameters(genericParameters, genericArguments);
            if (replacedType == Type)
            {
                return this;
            }

            return new ParameterData(declaringMemberKind, Name, replacedType, Modifer, _flags, DefaultValue);
        }

        private bool GetFlag(InternalFlags flag) => (_flags & flag) == flag;

        /// <summary>
        /// Gets the type of member owning the parameter collection.
        /// </summary>
        public MetadataItemKinds DeclaringMemberKind { get; }

        /// <summary>
        /// Gets the default value of an optional parameter (only valid if <see cref="IsOptional"/> is true).
        /// </summary>
        /// <seealso cref="IsOptional"/>
        public object DefaultValue { get; }

        /// <summary>
        /// Gets the value indicating whether the parameter has a default value and is therefore optional.
        /// </summary>
        /// <seealso cref="DefaultValue"/>
        public bool IsOptional => GetFlag(InternalFlags.IsOptional);

        /// <summary>
        /// Gets the value indicating whether the parameter is a paras array.
        /// </summary>
        public bool IsParamsArray => GetFlag(InternalFlags.IsParamsArray);

        /// <summary>
        /// Gets the value indicating whether the parameter type is 'dynamic', in which case <see cref="Type"/> will be System.Object.
        /// </summary>
        public bool IsTypeDynamic => GetFlag(InternalFlags.IsTypeDynamic);

        /// <summary>
        /// Gets the type of item the instance represents.
        /// </summary>
        public override MetadataItemKinds MetadataItemKind => MetadataItemKinds.Parameter;

        /// <summary>
        /// Gets the value indicating whether a ref or out modifier is specified on the parameter.
        /// </summary>
        public ParameterModifier Modifer { get; }

        /// <summary>
        /// Gets the name of the parameter.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the type of the parameter.
        /// </summary>
        public TypeData Type { get; }

        [Flags]
        internal enum InternalFlags : byte
        {
            IsOptional = 1 << 0,
            IsParamsArray = 1 << 1,
            IsTypeDynamic = 1 << 2,
        }
    }
}
