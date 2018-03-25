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
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BreakingChangesDetector.MetadataItems
{
    /// <summary>
    /// Represents the metadata for externally visible types and members of an <see cref="Assembly"/>.
    /// </summary>
    public sealed class AssemblyData : MetadataItemBase
    {
        #region Member Variables

        private readonly List<ConstructedGenericTypeData> _constructedGenericsToFinalizeAfterLoad;
        private readonly Dictionary<TypeDefinitionData, List<AssemblyData>> _forwardedTypeSources;
        private readonly Dictionary<TypeDefinitionData, string> _forwardedTypeSourcesOnTarget;
        private bool _isLoading;
        private readonly Dictionary<Tuple<MethodSignature, int>, GenericTypeParameterData> _methodOwnedGenericParameters;
        private readonly Dictionary<string, string> _namespaceRenames;
        private readonly HashSet<AssemblyData> _referencedAssemblies; // TODO_Serialize: Round trip and unit test
        private readonly Dictionary<string, TypeDefinitionData> _typeDefinitions;
        private readonly Dictionary<Tuple<string, int>, GenericTypeParameterData> _typeOwnedGenericParameters;

        #endregion // Member Variables

        #region Constructor

        internal AssemblyData(
            MetadataResolutionContext context,
            string fullName,
            string name,
            string versionComparisonName,
            IEnumerable<KeyValuePair<string, string>> namespaceRenames)
        {
            Context = context;

            _constructedGenericsToFinalizeAfterLoad = new List<ConstructedGenericTypeData>();
            _forwardedTypeSources = new Dictionary<TypeDefinitionData, List<AssemblyData>>();
            _forwardedTypeSourcesOnTarget = new Dictionary<TypeDefinitionData, string>();
            _methodOwnedGenericParameters = new Dictionary<Tuple<MethodSignature, int>, GenericTypeParameterData>();
            _namespaceRenames = new Dictionary<string, string>();
            _referencedAssemblies = new HashSet<AssemblyData>();
            _typeDefinitions = new Dictionary<string, TypeDefinitionData>();
            _typeOwnedGenericParameters = new Dictionary<Tuple<string, int>, GenericTypeParameterData>();

            this.FullName = fullName;
            this.Name = name;
            this.VersionComparisonName = versionComparisonName;

            if (namespaceRenames != null)
            {
                foreach (var namespaceRename in namespaceRenames)
                    _namespaceRenames[namespaceRename.Key] = namespaceRename.Value;
            }
        }

        internal AssemblyData(MetadataResolutionContext context, IAssemblySymbol underlyingAssemblySymbol)
            : this(context, underlyingAssemblySymbol.ToDisplayString(), underlyingAssemblySymbol.Name,
            Utilities.GetVersionComparisonName(underlyingAssemblySymbol),
            Utilities.GetNamespaceRenames(underlyingAssemblySymbol))
        { }

        #endregion // Constructor

        #region Base Class Overrides

        #region Accept

        /// <summary>
        /// Performs the specified visitor's functionality on this instance.
        /// </summary>
        /// <param name="visitor">The visitor whose functionality should be performed on the instance.</param>
        public override void Accept(MetadataItemVisitor visitor)
        {
            visitor.VisitAssemblyData(this);
        }

        #endregion // Accept

        public override MetadataResolutionContext Context { get; }

        #region DisplayName

        /// <summary>
        /// Gets the name to use for this item in messages.
        /// </summary>
        public override string DisplayName
        {
            get { return this.Name; }
        }

        #endregion // DisplayName

        #region DoesMatch

        internal override bool DoesMatch(MetadataItemBase other)
        {
            if (base.DoesMatch(other) == false)
                return false;

            var otherTyped = other as AssemblyData;
            if (otherTyped == null)
                return false;

            if (this.FullName != otherTyped.FullName)
                return false;

            if (this.Name != otherTyped.Name)
                return false;

            if (this.VersionComparisonName != otherTyped.VersionComparisonName)
                return false;

            if (_typeDefinitions.Count != otherTyped._typeDefinitions.Count)
                return false;

            foreach (var pair in _typeDefinitions)
            {
                var type = pair.Value;
                TypeDefinitionData otherType;
                if (otherTyped._typeDefinitions.TryGetValue(pair.Key, out otherType) == false)
                    return false;

                if (type.DoesMatch(otherType) == false)
                    return false;
            }

            if (_typeOwnedGenericParameters.Count != otherTyped._typeOwnedGenericParameters.Count)
                return false;

            foreach (var pair in _typeOwnedGenericParameters)
            {
                var type = pair.Value;
                GenericTypeParameterData otherType;
                if (otherTyped._typeOwnedGenericParameters.TryGetValue(pair.Key, out otherType) == false)
                    return false;

                if (type.DoesMatch(otherType) == false)
                    return false;
            }

            if (_methodOwnedGenericParameters.Count != otherTyped._methodOwnedGenericParameters.Count)
                return false;

            foreach (var pair in _methodOwnedGenericParameters)
            {
                var type = pair.Value;
                GenericTypeParameterData otherType;
                if (otherTyped._methodOwnedGenericParameters.TryGetValue(pair.Key, out otherType) == false)
                    return false;

                if (type.DoesMatch(otherType) == false)
                    return false;
            }

            if (_namespaceRenames.Count != otherTyped._namespaceRenames.Count)
                return false;

            foreach (var pair in _namespaceRenames)
            {
                var newName = pair.Value;
                var otherNewName = otherTyped._namespaceRenames[pair.Key];

                if (newName != otherNewName)
                    return false;
            }

            var referenceNames = _referencedAssemblies.Select(a => a.FullName).OrderBy(n => n).ToArray();
            var otherReferenceNames = otherTyped._referencedAssemblies.Select(a => a.FullName).OrderBy(n => n).ToArray();
            if (referenceNames.Length != otherReferenceNames.Length)
                return false;

            for (int i = 0; i < referenceNames.Length; i++)
                if (referenceNames[i] != otherReferenceNames[i])
                    return false;

            if (_forwardedTypeSources.Count != otherTyped._forwardedTypeSources.Count)
                return false;

            foreach (var pair in _forwardedTypeSources)
            {
                var assemblies = pair.Value;
                var otherAssemblies = otherTyped._forwardedTypeSources[otherTyped.GetTypeDefinitionData(pair.Key.FullName)];

                if (assemblies.Count != otherAssemblies.Count)
                    return false;

                for (int i = 0; i < assemblies.Count; i++)
                    if (assemblies[i].FullName != otherAssemblies[i].FullName)
                        return false;
            }

            if (_forwardedTypeSourcesOnTarget.Count != otherTyped._forwardedTypeSourcesOnTarget.Count)
                return false;

            foreach (var pair in _forwardedTypeSourcesOnTarget)
            {
                var fullName = pair.Value;
                var otherFullName = otherTyped._forwardedTypeSourcesOnTarget[otherTyped.GetTypeDefinitionData(pair.Key.FullName)];

                if (fullName != otherFullName)
                    return false;
            }

            return true;
        }

        #endregion // DoesMatch

        #region MetadataItemKind

        /// <summary>
        /// Gets the type of item the instance represents.
        /// </summary>
        public override MetadataItemKinds MetadataItemKind
        {
            get { return MetadataItemKinds.Assembly; }
        }

        #endregion // MetadataItemKind

        #endregion // Base Class Overrides

        #region Methods

        #region Internal Methods

        #region AddForwardedTypeFromTarget

        internal void AddForwardedTypeFromTarget(TypeDefinitionData type, string sourceAssembly)
        {
            _forwardedTypeSourcesOnTarget.Add(type, sourceAssembly);
        }

        #endregion // AddForwardedTypeFromTarget

        #region GetForwardedTypeSources

        internal IEnumerable<string> GetForwardedTypeSources(TypeDefinitionData type)
        {
            List<AssemblyData> sourceAssemblies;
            if (_forwardedTypeSources.TryGetValue(type, out sourceAssemblies))
            {
                foreach (var sourceAssembly in sourceAssemblies)
                    yield return sourceAssembly.FullName;
            }

            string sourceFullName;
            if (_forwardedTypeSourcesOnTarget.TryGetValue(type, out sourceFullName))
                yield return sourceFullName;
        }

        #endregion // GetForwardedTypeSources

        #region GetGenericTypeParameterData

        internal GenericTypeParameterData GetGenericTypeParameterData(ITypeParameterSymbol typeParameterSymbol)
        {
            if (typeParameterSymbol.DeclaringMethod != null)
                return this.GetGenericTypeParameterData(typeParameterSymbol.DeclaringMethod, typeParameterSymbol.Ordinal);

            return this.GetGenericTypeParameterData(typeParameterSymbol.ContainingType, typeParameterSymbol.Ordinal);
        }

        private GenericTypeParameterData GetGenericTypeParameterData(IMethodSymbol methodSymbol, int position)
        {
            Debug.Assert(
                Context.GetDeclaringAssemblySymbol(methodSymbol.ContainingType).ToDisplayString() == this.FullName,
                "The method is not from this assembly");
            GenericTypeParameterData genericParameter;
            _methodOwnedGenericParameters.TryGetValue(
                Tuple.Create(new MethodSignature(Context, methodSymbol), position),
                out genericParameter);
            return genericParameter;
        }

        private GenericTypeParameterData GetGenericTypeParameterData(INamedTypeSymbol typeSymbol, int position)
        {
            Debug.Assert(
                Context.GetDeclaringAssemblySymbol(typeSymbol).ToDisplayString() == this.FullName,
                "The method is not from this assembly");
            GenericTypeParameterData genericParameter;
            _typeOwnedGenericParameters.TryGetValue(Tuple.Create(typeSymbol.GetFullName(), position), out genericParameter);
            return genericParameter;
        }

        #endregion // GetGenericTypeParameterData

        #region GetNewNamespaceName

        internal string GetNewNamespaceName(string oldNamespaceName)
        {
            if (oldNamespaceName == null)
                return null;

            string newNamespaceName;
            _namespaceRenames.TryGetValue(oldNamespaceName, out newNamespaceName);
            return newNamespaceName;
        }

        #endregion // GetNewNamespaceName

        #region GetNonNestedTypeDefinitions

#if DEBUG
        /// <summary>
        /// Gets all non-nested types which are type definitions and therefore not constructed generic, array, by-ref, or pointer types.
        /// </summary>
        /// <returns>An enumerable collection of all non-nested type definitions.</returns> 
#endif
        internal IEnumerable<TypeDefinitionData> GetNonNestedTypeDefinitions()
        {
            return _typeDefinitions.Values.OfType<TypeDefinitionData>().Where(t => t.ContainingType == null);
        }

        #endregion // GetNonNestedTypeDefinitions

        #region GetReferencedAssemblies

        internal IEnumerable<AssemblyData> GetReferencedAssemblies()
        {
            return _referencedAssemblies;
        }

        #endregion // GetReferencedAssembly

        #region GetReferencedAssembly

        internal AssemblyData GetReferencedAssembly(string name)
        {
            if (this.Name == name)
                return this;

            return this.GetReferencedAssemblies().Where(a => a.Name == name).FirstOrDefault();
        }

        #endregion // GetReferencedAssembly

        #region GetTypeData

#if DEBUG
        /// <summary>
        /// Gets the <see cref="TypeData"/> instance containing the metadata for externally visible types and members of the specified <see cref="Type"/>.
        /// </summary>
        /// <param name="typeSymbol">The type for which of corresponding to the TypeData to get.</param>
        /// <returns>The TypeData instance containing the metadata for externally visible types and members of the specified Type.</returns> 
#endif
        internal TypeData GetTypeData(ITypeSymbol typeSymbol)
        {
            Debug.Assert(
                Context.GetDeclaringAssemblySymbol(typeSymbol).ToDisplayString() == this.FullName,
                "The type belongs to another assembly.");

            var typeParameterSymbol = typeSymbol as ITypeParameterSymbol;
            if (typeParameterSymbol != null)
                return this.GetGenericTypeParameterData(typeParameterSymbol);

            var accessibility = typeSymbol.GetAccessibility();
            if (accessibility == null)
                return null;

            var namedTypeSymbol = typeSymbol as INamedTypeSymbol;
            if (namedTypeSymbol != null)
            {
                // TODO: I think this may be a bug. Report if so: ValueTuple<T1> doesn't report its fully qualified name correctly unless we do this.
                //       However, this is needed anyway to get the proper type info for tuple types.
                if (namedTypeSymbol.IsTupleType)
                {
                    namedTypeSymbol = namedTypeSymbol.TupleUnderlyingType;
                }

                if (namedTypeSymbol.IsConstructed())
                {
                    return Context.GetTypeDefinitionData(namedTypeSymbol.ConstructedFrom).GetConstructedGenericTypeData(namedTypeSymbol.TypeArguments.Select(a => Context.GetTypeData(a)));
                }

                return this.GetTypeDefinitionData(namedTypeSymbol.GetFullName());
            }

            DeclaringTypeData declaringType = null;
            if (typeSymbol.ContainingType != null)
            {
                declaringType = (DeclaringTypeData)this.GetTypeData(typeSymbol.ContainingType);
            }

            var arrayType = typeSymbol as IArrayTypeSymbol;
            if (arrayType != null)
            {
                Debug.Assert(declaringType == null, "Types with elements should not be declared within other types.");
                var elementType = Context.GetTypeData(arrayType.ElementType);
                return elementType.GetArrayType((byte)arrayType.Rank);
            }

            var pointerTypeSymbol = typeSymbol as IPointerTypeSymbol;
            if (pointerTypeSymbol != null)
            {
                return Context.GetTypeData(pointerTypeSymbol.PointedAtType).GetPointerType();
            }

            var dynamicTypeSymbol = typeSymbol as IDynamicTypeSymbol;
            if (dynamicTypeSymbol != null)
            {
                // TODO: Not sure if this is the right thing to do
                return this.GetTypeDefinitionData(Utilities.ObjectTypeName);
            }

            Debug.Fail("Unknown kind of type.");
            return Context.GetTypeData(typeSymbol);
        }

        #endregion // GetTypeData

        #region GetTypeDatas

#if DEBUG
        /// <summary>
        /// Gets all <see cref="TypeData"/> instance in the <see cref="AssemblyData"/>.
        /// </summary> 
#endif
        internal IList<TypeData> GetTypeDatas()
        {
            return _typeDefinitions.OrderBy(p => p.Key).Select(p => p.Value).Cast<TypeData>().ToList();
        }

        #endregion // GetTypeDatas

        #region GetTypeDefinitionData

#if DEBUG
        /// <summary>
        /// Gets the <see cref="DeclaringTypeData"/> representing the type with the specified full name.
        /// </summary>
        /// <param name="fullName">The full name of the type to get.</param>
        /// <returns>The type with the specified full name or null if no such type exists.</returns> 
#endif
        internal TypeDefinitionData GetTypeDefinitionData(string fullName)
        {
            TypeDefinitionData internalType;
            if (_typeDefinitions.TryGetValue(fullName, out internalType))
                return internalType;

            return null;
        }

        #endregion // GetTypeDefinitionData

        #region IsEquivalentToNewAssembly

#if DEBUG
        /// <summary>
        /// Indicates whether the current assembly is logically equivalent to the specified assembly, just from a different version.
        /// </summary>
        /// <param name="assemblyData"></param> 
#endif
        internal bool IsEquivalentToNewAssembly(AssemblyData assemblyData)
        {
            return assemblyData != null && this.VersionComparisonName == assemblyData.VersionComparisonName;
        }

        #endregion // IsEquivalentToNewAssembly

        #region RegisterForFinalize

        internal void RegisterForFinalize(ConstructedGenericTypeData type)
        {
            if (_isLoading)
                _constructedGenericsToFinalizeAfterLoad.Add(type);
            else
                type.FinalizeDefiniton();
        }

        #endregion // RegisterForFinalize

        #endregion // Internal Methods

        #region Private Methods

        #region AddForwardedType

        private void AddForwardedType(TypeDefinitionData type)
        {
            Debug.Assert(this != type.AssemblyData, "A type should not be forwarded to its own assembly.");

            List<AssemblyData> forwardedTypeSources;
            if (type.AssemblyData._forwardedTypeSources.TryGetValue(type, out forwardedTypeSources) == false)
                type.AssemblyData._forwardedTypeSources[type] = forwardedTypeSources = new List<AssemblyData>();

            forwardedTypeSources.Add(this);
        }

        #endregion // AddForwardedType

        #region AddReference

#if DEBUG
        /// <summary>
        /// Adds the <see cref="AssemblyData"/> of a directly assembly reference to the current AssemblyData.
        /// </summary>
        /// <param name="reference">The AssemblyData of the directly referenced assembly.</param> 
#endif
        private void AddReference(AssemblyData reference)
        {
            _referencedAssemblies.Add(reference);
        }

        #endregion // AddReference

        #region IterateAllTypeDefinitions

        private void IterateAllTypeDefinitions(IAssemblySymbol assemblySymbol,
            Func<INamedTypeSymbol, bool> namedTypeAction,
            Action<ITypeParameterSymbol> typeParameterAction = null)
        {
            this.IterateAllTypeDefinitions(assemblySymbol.GlobalNamespace, namedTypeAction, typeParameterAction);
        }

        private void IterateAllTypeDefinitions(INamespaceSymbol namespaceSymbol,
            Func<INamedTypeSymbol, bool> namedTypeAction,
            Action<ITypeParameterSymbol> typeParameterAction = null)
        {
            foreach (var namespaceOrTypeSymbol in namespaceSymbol.GetMembers())
            {
                if (namespaceOrTypeSymbol.IsType)
                {
                    this.IterateAllTypeDefinitions((INamedTypeSymbol)namespaceOrTypeSymbol, namedTypeAction, typeParameterAction);
                }
                else
                {
                    this.IterateAllTypeDefinitions((INamespaceSymbol)namespaceOrTypeSymbol, namedTypeAction, typeParameterAction);
                }
            }
        }

        private void IterateAllTypeDefinitions(INamedTypeSymbol namedTypeSymbol,
            Func<INamedTypeSymbol, bool> namedTypeAction,
            Action<ITypeParameterSymbol> typeParameterAction)
        {
            if (namedTypeAction(namedTypeSymbol) == false)
                return;

            if (typeParameterAction != null)
            {
                foreach (var genericParameter in namedTypeSymbol.TypeParameters)
                    typeParameterAction(genericParameter);

                foreach (var method in namedTypeSymbol.Methods().Where(m => !m.TypeParameters.IsEmpty && m.GetAccessibility() != null))
                    foreach (var genericParameter in method.TypeParameters)
                        typeParameterAction(genericParameter);
            }

            foreach (var nestedType in namedTypeSymbol.GetTypeMembers())
                this.IterateAllTypeDefinitions(nestedType, namedTypeAction, typeParameterAction);
        }

        #endregion // IterateAllTypeDefinitions

        #region LoadFromMetadata

        internal void LoadFromMetadata(IAssemblySymbol assemblySymbol)
        {
            _isLoading = true;
            IterateAllTypeDefinitions(assemblySymbol, namedTypeSymbol =>
            {
                this.RegisterType(namedTypeSymbol, null);

                // Return false so we don't process nested types. RegisterType will register nested type recursively.
                return false;
            });

            // Finalize Definitions
            this.IterateAllTypeDefinitions(assemblySymbol,
                namedTypeAction: namedTypeSymbol =>
                {
                    var typeData = (TypeDefinitionData)this.GetTypeData(namedTypeSymbol);
                    if (typeData == null)
                        return false;

                    typeData.FinalizeDefinition(namedTypeSymbol);
                    return true;
                },
                typeParameterAction: typeParameterSymbol =>
                {
                    this.GetGenericTypeParameterData(typeParameterSymbol).FinalizeDefinition(typeParameterSymbol);
                });

            // Populate Members
            this.IterateAllTypeDefinitions(assemblySymbol,
                namedTypeAction: namedTypeSymbol =>
                {
                    var typeData = (TypeDefinitionData)this.GetTypeData(namedTypeSymbol);
                    if (typeData == null)
                        return false;

                    typeData.PopulateMembers(namedTypeSymbol);
                    return true;
                });

            while (_constructedGenericsToFinalizeAfterLoad.Count != 0)
            {
                var temp = _constructedGenericsToFinalizeAfterLoad.ToArray();
                _constructedGenericsToFinalizeAfterLoad.Clear();
                foreach (var type in temp)
                    type.FinalizeDefiniton();
            }

            var metadataReader = assemblySymbol.Modules.First().GetMetadata().GetMetadataReader();
            var forwarders = metadataReader.ExportedTypes.Select(metadataReader.GetExportedType).Where(e => e.IsForwarder);
            foreach (var forwarder in forwarders)
            {
                var metadataName = metadataReader.GetString(forwarder.Name);
                if (!forwarder.Namespace.IsNil)
                {
                    metadataName = $"{metadataReader.GetString(forwarder.Namespace)}.{metadataName}";
                }
                var forwardedType = assemblySymbol.ResolveForwardedType(metadataName);
                if (forwardedType != null)
                {
                    var forwardedTypeData = (TypeDefinitionData)Context.GetTypeData(forwardedType);
                    if (forwardedTypeData != null)
                    {
                        AddForwardedType(forwardedTypeData);
                    }
                }
            }

            foreach (var referenceIdentity in assemblySymbol.Modules.SelectMany(m => m.ReferencedAssemblies))
            {
                AssemblyData reference;
                if (Context._cachedAssemblyDatas.TryGetValue(referenceIdentity, out reference))
                    _referencedAssemblies.Add(reference);
            }

            _isLoading = false;
        }

        #endregion // LoadFromMetadata

        #region RegisterType

        private void RegisterType(INamedTypeSymbol namedTypeSymbol, TypeDefinitionData declaringType)
        {
            var accessibility = namedTypeSymbol.GetAccessibility();
            if (accessibility == null)
                return;

            var typeDefinitionData = new TypeDefinitionData(namedTypeSymbol, accessibility.Value, declaringType, this);
            _typeDefinitions.Add(namedTypeSymbol.GetFullName(), typeDefinitionData);

            foreach (var typeParameterSymbol in namedTypeSymbol.TypeParameters)
                _typeOwnedGenericParameters.Add(Tuple.Create(namedTypeSymbol.GetFullName(), typeParameterSymbol.Ordinal), new GenericTypeParameterData(typeParameterSymbol, this));

            foreach (var method in namedTypeSymbol.Methods().Where(m => !m.TypeParameters.IsEmpty && m.GetAccessibility() != null))
            {
                var signature = new MethodSignature(Context, method);
                foreach (var typeParameterSymbol in method.TypeParameters)
                    _methodOwnedGenericParameters.Add(Tuple.Create(signature, typeParameterSymbol.Ordinal), new GenericTypeParameterData(typeParameterSymbol, this));
            }

            foreach (var nestedTypeSymbol in namedTypeSymbol.GetTypeMembers())
                this.RegisterType(nestedTypeSymbol, typeDefinitionData);
        }

        #endregion // RegisterType

        #endregion // Private Methods

        #endregion // Methods

        #region Properties

        /// <summary>
        /// Gets the full name of the assembly.
        /// </summary>
        public string FullName { get; private set; }

        /// <summary>
        /// Gets the name of the assembly.
        /// </summary>
        public string Name { get; private set; } // TODO_Serialize: Round trip and unit test

        /// <summary>
        /// Gets the name used to compare logically equivalent assemblies from different versions. This should not change across versions 
        /// of the assembly.
        /// </summary>
        public string VersionComparisonName { get; private set; } // TODO_Serialize: Round trip and unit test

        #endregion // Properties
    }
}
