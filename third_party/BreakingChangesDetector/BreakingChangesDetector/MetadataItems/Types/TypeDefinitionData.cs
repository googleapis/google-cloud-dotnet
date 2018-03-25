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

using Infragistics;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

namespace BreakingChangesDetector.MetadataItems
{
    /// <summary>
    /// Represents the metadata for an externally visible type definition.
    /// </summary>
    public sealed class TypeDefinitionData : DeclaringTypeData,
        IGenericItem,
        IParameterizedItem,
        ITypedItem
    {
        private static Dictionary<string, HashSet<string>> _implicitNumericConversions = new Dictionary<string, HashSet<string>>() {
            { typeof(sbyte).FullName, new HashSet<string> { typeof(short).FullName, typeof(int).FullName, typeof(long).FullName, typeof(float).FullName, typeof(double).FullName, typeof(decimal).FullName } },
            { typeof(byte).FullName, new HashSet<string> { typeof(short).FullName, typeof(ushort).FullName, typeof(int).FullName, typeof(uint).FullName, typeof(long).FullName, typeof(ulong).FullName, typeof(float).FullName, typeof(double).FullName, typeof(decimal).FullName } },
            { typeof(short).FullName, new HashSet<string> { typeof(int).FullName, typeof(long).FullName, typeof(float).FullName, typeof(double).FullName, typeof(decimal).FullName } },
            { typeof(ushort).FullName, new HashSet<string> { typeof(int).FullName, typeof(uint).FullName, typeof(long).FullName, typeof(ulong).FullName, typeof(float).FullName, typeof(double).FullName, typeof(decimal).FullName } },
            { typeof(int).FullName, new HashSet<string> { typeof(long).FullName, typeof(float).FullName, typeof(double).FullName, typeof(decimal).FullName } },
            { typeof(uint).FullName, new HashSet<string> { typeof(long).FullName, typeof(ulong).FullName, typeof(float).FullName, typeof(double).FullName, typeof(decimal).FullName } },
            { typeof(long).FullName, new HashSet<string> { typeof(float).FullName, typeof(double).FullName, typeof(decimal).FullName } },
            { typeof(ulong).FullName, new HashSet<string> { typeof(float).FullName, typeof(double).FullName, typeof(decimal).FullName } },
            { typeof(char).FullName, new HashSet<string> { typeof(ushort).FullName, typeof(int).FullName, typeof(uint).FullName, typeof(long).FullName, typeof(ulong).FullName, typeof(float).FullName, typeof(double).FullName, typeof(decimal).FullName } },
            { typeof(float).FullName, new HashSet<string> { typeof(double).FullName } }
        };

        private static Dictionary<string, string> _primitiveTypeNames = new Dictionary<string, string>() {
            { typeof(object).FullName, "object" },
            { typeof(sbyte).FullName, "sbyte" },
            { typeof(byte).FullName, "byte" },
            { typeof(short).FullName,"short" },
            { typeof(ushort).FullName,"ushort" },
            { typeof(int).FullName,"int" },
            { typeof(uint).FullName,"uint" },
            { typeof(long).FullName, "long" },
            { typeof(ulong).FullName,"ulong" },
            { typeof(char).FullName, "char" },
            { typeof(float).FullName, "float" },
            { typeof(double).FullName, "double" },
            { typeof(decimal).FullName, "decimal" },
            { typeof(void).FullName, "void" },
        };

        private Dictionary<TypeDataSequence, ConstructedGenericTypeData> _constructedGenericTypes;

        internal TypeDefinitionData(string name, MemberAccessibility accessibility, MemberFlags memberFlags, TypeKind typeKind, AssemblyData assembly, string fullName, TypeDefinitionFlags typeDefinitionFlags, bool delegateReturnTypeIsDynamic)
            : base(name, accessibility, memberFlags, typeKind)
        {
            AssemblyData = assembly;
            DelegateReturnTypeIsDynamic = delegateReturnTypeIsDynamic;
            FullName = fullName;
            TypeDefinitionFlags = typeDefinitionFlags;
        }

        internal TypeDefinitionData(INamedTypeSymbol typeSymbol, MemberAccessibility accessibility, DeclaringTypeData declaringType, AssemblyData assembly)
            : base(typeSymbol, accessibility, declaringType)
        {
            AssemblyData = assembly;

            var typeFlags = TypeDefinitionFlags.None;

            if (IsSealed == false)
            {
                // TODO_Refactor: we can probably clean this up

                // A type can only be inherited if it has at least one externally visible constructor and any abstract members are also externally visible.
                var canBeIherited = typeSymbol.Methods().Where(c => c.MethodKind == MethodKind.Constructor && c.GetAccessibility() != null).Any();
                if (CanBeInherited)
                {
                    if (typeSymbol.Methods().Where(m => m.AssociatedSymbol == null && m.MethodKind != MethodKind.StaticConstructor && m.MethodKind != MethodKind.Destructor && m.MethodKind != MethodKind.Constructor && m.GetAccessibility() == null && m.IsAbstract).Any() ||
                        typeSymbol.Events().Where(e => e.AddMethod.GetAccessibility() == null && e.AddMethod.IsAbstract).Any() ||
                        typeSymbol.Properties().Where(p => p.GetMethod != null ? p.GetMethod.GetAccessibility() == null && p.GetMethod.IsAbstract : p.SetMethod.GetAccessibility() == null && p.SetMethod.IsAbstract).Any())
                    {
                        canBeIherited = false;
                    }
                }

                if (canBeIherited)
                {
                    typeFlags |= TypeDefinitionFlags.CanBeInherited;
                }
            }

            if (TypeKind == TypeKind.Enum)
            {
                var flagsAttributeData = typeSymbol.GetAttributes().Where(a => a.AttributeClass.EqualsType(typeof(FlagsAttribute))).SingleOrDefault();
                if (flagsAttributeData != null)
                {
                    typeFlags |= TypeDefinitionFlags.FlagsEnum;
                }
            }

            TypeDefinitionFlags = typeFlags;
            FullName = typeSymbol.GetFullName();

            var renamedAttributeData = typeSymbol.GetAttributes().Where(a => a.AttributeClass.GetFullName() == typeof(TypeRenamedAttribute).FullName).SingleOrDefault();
            if (renamedAttributeData != null)
            {
                OldName = renamedAttributeData.ConstructorArguments[0].Value as string;
            }

            var typeForwardedFromAttribute = typeSymbol.GetAttributes().Where(a => a.AttributeClass.EqualsType(typeof(TypeForwardedFromAttribute))).SingleOrDefault();
            if (typeForwardedFromAttribute != null)
            {
                AssemblyData.AddForwardedTypeFromTarget(this, typeForwardedFromAttribute.ConstructorArguments[0].Value.ToString());
            }
        }

        bool IParameterizedItem.IsEquivalentToNewMember(MemberDataBase newMember, AssemblyFamily newAssemblyFamily, bool ignoreNewOptionalParameters) =>
            IsEquivalentToNewTypeHelper((TypeDefinitionData)newMember, newAssemblyFamily, ignoreNewOptionalParameters);

        ParameterCollection IParameterizedItem.Parameters => DelegateParameters;

        bool ITypedItem.IsTypeDynamic => DelegateReturnTypeIsDynamic;

        TypeData ITypedItem.Type => DelegateReturnType;

        /// <inheritdoc/>
        public override void Accept(MetadataItemVisitor visitor) => visitor.VisitTypeDefinitionData(this);

        /// <inheritdoc/>
        public override AssemblyData AssemblyData { get; }

        /// <inheritdoc/>
        internal override bool CanOverrideMember(MemberDataBase baseMember)
        {
            Debug.Fail("Types cannot be overridden.");
            return false;
        }

        internal override bool DoesMatch(MetadataItemBase other)
        {
            if (base.DoesMatch(other) == false)
            {
                return false;
            }

            var otherTyped = other as TypeDefinitionData;
            if (otherTyped == null)
            {
                return false;
            }

            if (FullName != otherTyped.FullName)
            {
                return false;
            }

            if (GenericParameters.DoesMatch(otherTyped.GenericParameters) == false)
            {
                return false;
            }

            if (NameForComparison != otherTyped.NameForComparison)
            {
                return false;
            }

            if (OldName != otherTyped.OldName)
            {
                return false;
            }

            if (TypeDefinitionFlags != otherTyped.TypeDefinitionFlags)
            {
                return false;
            }

            return true;
        }

        /// <inheritdoc/>
        internal override int GenericArity => GenericParameters.Count;

        /// <inheritdoc/>
        internal override IEnumerable<TypeData> GetDirectImplicitConversions(bool onlyReferenceAndIdentityConversions)
        {
            if (onlyReferenceAndIdentityConversions == false)
            {
                var mscorlibData = AssemblyData.GetReferencedAssembly(Utilities.CommonObjectRuntimeAssemblyName);
                if (mscorlibData != null)
                {
                    if (TypeKind == TypeKind.Enum)
                    {
                        yield return mscorlibData.GetTypeDefinitionData(Utilities.EnumTypeName);
                    }
                    else
                    {
                        // See if there is an implicit numeric conversion for the types.
                        if (mscorlibData != null &&
                            _implicitNumericConversions.TryGetValue(FullName, out HashSet<string> destTypeNames))
                        {
                            foreach (var numericTypeName in destTypeNames)
                            {
                                yield return mscorlibData.GetTypeDefinitionData(numericTypeName);
                            }
                        }
                    }
                }
            }

            foreach (var item in base.GetDirectImplicitConversions(onlyReferenceAndIdentityConversions))
            {
                yield return item;
            }
        }

        /// <inheritdoc/>
        internal override string GetDisplayName(bool fullyQualify, bool includeGenericInfo, GenericTypeArgumentCollection genericArguments)
        {
            if (_primitiveTypeNames.TryGetValue(FullName, out string primitiveTypeName))
            {
                return primitiveTypeName;
            }

            var rootName = Name;
            var tickIndex = rootName.LastIndexOf('`');
            if (0 <= tickIndex)
            {
                rootName = rootName.Substring(0, tickIndex);
            }

            if (includeGenericInfo)
            {
                var declaringTypeGenericArity = ContainingType == null ? 0 : ContainingType.GenericArity;

                if (genericArguments != null)
                {
                    rootName += genericArguments.GetGenericArgumentListDisplayText(includeGenericInfo, declaringTypeGenericArity, GenericParameters.Count - declaringTypeGenericArity);
                }
                else if (GenericParameters != null) // While initializing, this.GenericParameters could be null and we don't want this throwing an exception
                {
                    rootName += GenericParameters.GetParameterListText(skipCount: declaringTypeGenericArity);
                }
            }

            return PostProcessUnqualifiedName(rootName, fullyQualify, includeGenericInfo, genericArguments);
        }

        /// <inheritdoc/>
        internal override TypeData GetEquivalentNewType(AssemblyFamily newAssemblyFamily)
        {
            var newAssembly = newAssemblyFamily.GetEquivalentAssembly(AssemblyData);
            if (newAssembly == null)
            {
                return null;
            }

            var newType = newAssembly.GetTypeDefinitionData(FullName);
            if (newType != null)
            {
                return newType;
            }

            var oldNamespaceName = GetNamespaceName();
            var newNamespaceName = newAssembly.GetNewNamespaceName(oldNamespaceName);
            if (newNamespaceName != null)
            {
                var newFullName = newNamespaceName + FullName.Substring(oldNamespaceName.Length);
                newType = newAssembly.GetTypeDefinitionData(newFullName);
                if (newType != null)
                {
                    return newType;
                }
            }

            foreach (var otherAssembly in newAssemblyFamily)
            {
                if (otherAssembly == newAssembly)
                {
                    continue;
                }

                newType = otherAssembly.GetTypeDefinitionData(FullName);
                if (newType != null && otherAssembly.GetForwardedTypeSources(newType).Any(s => s == newAssembly.FullName))
                {
                    return newType;
                }
            }

            return null;
        }

        /// <inheritdoc/>
        internal override string GetNamespaceName()
        {
            if (_primitiveTypeNames.ContainsKey(FullName))
            {
                return null;
            }

            if (ContainingType != null)
            {
                return ContainingType.GetNamespaceName();
            }

            var lastDot = FullName.LastIndexOf(".");
            if (0 <= lastDot)
            {
                return FullName.Substring(0, lastDot);
            }

            return string.Empty;
        }

        /// <inheritdoc/>
        internal override bool IsEquivalentToNewMember(MemberDataBase newMember, AssemblyFamily newAssemblyFamily)
        {
            var newType = newMember as TypeDefinitionData;
            if (newType == null)
            {
                return false;
            }

            return IsEquivalentToNewTypeHelper(newType, newAssemblyFamily, ignoreNewOptionalParameters: false);
        }

        /// <inheritdoc/>
        public override MetadataItemKinds MetadataItemKind => MetadataItemKinds.TypeDefinition;

        /// <inheritdoc/>
        internal override MemberDataBase ReplaceGenericTypeParameters(GenericTypeParameterCollection genericParameters, GenericTypeArgumentCollection genericArguments) =>
            GenericParameters == genericParameters ? GetConstructedGenericTypeData(genericArguments) : (MemberDataBase)this;

        /// <summary>
        /// Gets the single nested type with the specified name or null if no such nested type exists. If multiple nested types exist with the specified name, 
        /// an exception will be thrown.
        /// </summary>
        /// <param name="name">The name of the nested type to get.</param>
        /// <returns>The single nested type with the specified name, or null if no such nested type exists.</returns>
        public TypeDefinitionData GetNestedType(string name) =>
            GetMembers(name).OfType<TypeDefinitionData>().SingleOrDefault();

        /// <summary>
        /// Populates the type with additional information which can't be loaded when the type is created (due to potential circularities in item dependencies).
        /// </summary>
        /// <param name="underlyingTypeSymbol">The underlying type this instance represents.</param>
        internal void FinalizeDefinition(INamedTypeSymbol underlyingTypeSymbol)
        {
            if (underlyingTypeSymbol.TypeKind == TypeKind.Enum)
            {
                BaseType = (DeclaringTypeData)Context.GetTypeData(underlyingTypeSymbol.EnumUnderlyingType);
            }
            else if (underlyingTypeSymbol.BaseType != null)
            {
                BaseType = (DeclaringTypeData)Context.GetTypeData(underlyingTypeSymbol.BaseType);
            }

            ImplementedInterfaces = new ImplementedInterfacesCollection(
                underlyingTypeSymbol.Interfaces.Select(i => (DeclaringTypeData)Context.GetTypeData(i)).Where(i => i != null)
                );

            if (TypeKind == TypeKind.Delegate)
            {
                var invokeMethod = underlyingTypeSymbol.Methods().Single(m => m.Name == "Invoke");
                DelegateParameters = new ParameterCollection(invokeMethod.Parameters, this);
                DelegateReturnType = Context.GetTypeData(invokeMethod.ReturnType);
                DelegateReturnTypeIsDynamic = invokeMethod.IsReturnTypeDynamic();
            }

            if (!underlyingTypeSymbol.TypeParameters.IsEmpty)
            {
                GenericParameters = Utilities.GetGenericParameters(underlyingTypeSymbol, this);
                Debug.Assert(
                    _constructedGenericTypes == null || _constructedGenericTypes.Values.All(c => c.GenericArguments.Count == GenericParameters.Count),
                    "The type arity does not match.");
            }
            else
            {
                GenericParameters = GenericTypeParameterData.EmptyList;
                Debug.Assert(_constructedGenericTypes == null, "There should be no constructed generic types.");
            }

            NameForComparison = GetDisplayName(fullyQualify: true, includeGenericInfo: false);

            Debug.Assert(_constructedGenericTypes == null || _constructedGenericTypes.Keys.All(t => t.Count == GenericParameters.Count), "A constructed generic has the wrong type arity.");
        }

        /// <summary>
        /// Gets a <see cref="ConstructedGenericTypeData"/> instance with the current type as its generic type definition and the specified sequence of type as its 
        /// generic type arguments.
        /// </summary>
        internal ConstructedGenericTypeData GetConstructedGenericTypeData(IEnumerable<TypeData> typeArguments) =>
            GetConstructedGenericTypeData(new TypeDataSequence(typeArguments));

        /// <summary>
        /// Gets a <see cref="ConstructedGenericTypeData"/> instance with the current type as its generic type definition and the specified sequence of type as its 
        /// generic type arguments.
        /// </summary>
        internal ConstructedGenericTypeData GetConstructedGenericTypeData(TypeDataSequence typeArguments)
        {
            Debug.Assert(GenericParameters == null || GenericParameters.Count == typeArguments.Count, "The type arity does not match.");

            if (_constructedGenericTypes == null)
            {
                _constructedGenericTypes = new Dictionary<TypeDataSequence, ConstructedGenericTypeData>();
            }

            if (_constructedGenericTypes.TryGetValue(typeArguments, out ConstructedGenericTypeData constructedGenericType) == false)
            {
                constructedGenericType = new ConstructedGenericTypeData(this, typeArguments);
                Debug.Assert(_constructedGenericTypes.ContainsKey(typeArguments), "The constructed generic type did not register itself.");
            }

            return constructedGenericType;
        }

        /// <summary>
        /// Indicates whether the specified type is represented by the current <see cref="TypeDefinitionData"/> instance.
        /// </summary> 
        internal bool IsType(Type type) =>
            FullName == type.FullName &&
            AssemblyData.Name == type.Assembly.GetName().Name;

        internal void PopulateMembers(INamedTypeSymbol underlyingTypeSymbol)
        {
            foreach (var member in underlyingTypeSymbol.Members())
            {
                AddMember(MemberDataFromReflection(member, this));
            }
        }

        /// <summary>
        /// Registers a <see cref="ConstructedGenericTypeData"/> instance with the current type as its generic type definition so it can be cached and re-used when trying 
        /// to get a constructed generic type with the same type arguments.
        /// </summary>
        internal void RegisterConstructedGenericTypeData(ConstructedGenericTypeData constructedGenericType)
        {
            Debug.Assert(GenericParameters == null || GenericParameters.Count == constructedGenericType.GenericArguments.Count, "The type arity does not match.");

            if (_constructedGenericTypes == null)
            {
                _constructedGenericTypes = new Dictionary<TypeDataSequence, ConstructedGenericTypeData>();
            }

            var key = new TypeDataSequence(constructedGenericType.GenericArguments);
            Debug.Assert(_constructedGenericTypes.ContainsKey(key) == false, "We should not register the same constructed generic twice.");
            _constructedGenericTypes[key] = constructedGenericType;
        }

        /// <summary>
        /// Indicates whether a new member of the same type and name is logically the same member as the current member, just from a newer build.
        /// </summary>
        /// <param name="newType">The new member to compare.</param>
        /// <param name="newAssemblyFamily">The assembly family in which new assemblies reside.</param>
        /// <param name="ignoreNewOptionalParameters">
        /// Indicates whether to ignore any new parameters at the end of the collection which are optional when comparing.
        /// </param>
        private bool IsEquivalentToNewTypeHelper(TypeDefinitionData newType, AssemblyFamily newAssemblyFamily, bool ignoreNewOptionalParameters)
        {
            if (base.IsEquivalentToNewMember(newType, newAssemblyFamily) == false)
            {
                return false;
            }

            var isEquivalent = AssemblyData.IsEquivalentToNewAssembly(newType.AssemblyData);
            if (isEquivalent == false)
            {
                foreach (var source in newType.AssemblyData.GetForwardedTypeSources(newType))
                {
                    if (AssemblyData.IsEquivalentToNewAssembly(newAssemblyFamily.GetAssembly(source)))
                    {
                        isEquivalent = true;
                        break;
                    }
                }

                if (isEquivalent == false)
                {
                    return false;
                }
            }

            return
                GenericParameters.Count == newType.GenericParameters.Count &&
                TypeKind == newType.TypeKind &&
                NameForComparison == newType.OldNameResolved;
        }

        /// <summary>
        /// Gets the value indicating whether the sealed class can be inherited by a type external to its assembly.
        /// </summary>
        public bool CanBeInherited => TypeDefinitionFlags.HasFlag(TypeDefinitionFlags.CanBeInherited);

        /// <summary>
        /// Gets the fully qualified name of the type.
        /// </summary>
        public string FullName { get; }

        /// <summary>
        /// Gets the collection of generic parameters for the type.
        /// </summary>
        public GenericTypeParameterCollection GenericParameters { get; internal set; }

        /// <summary>
        /// Gets the value indicating whether the type is an enum definition with the Flags attribute applied.
        /// </summary>
        public bool IsFlagsEnum => TypeDefinitionFlags.HasFlag(TypeDefinitionFlags.FlagsEnum);

        internal bool HasPublicConstructors => GetMembers(".ctor").Any(c => c.Accessibility == MemberAccessibility.Public);

        internal string NameForComparison { get; private set; }

        internal string OldName { get; set; } // TODO_Serialize: Test and round-trip

        internal string OldNameResolved => OldName ?? NameForComparison;

        internal TypeDefinitionFlags TypeDefinitionFlags { get; }
    }
}
