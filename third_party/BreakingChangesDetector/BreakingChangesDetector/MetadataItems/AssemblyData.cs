/*
    MIT License

    Copyright(c) 2014-2018 Infragistics, Inc.

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
using Mono.Cecil;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.MetadataItems
{
	/// <summary>
	/// Represents the metadata for externally visible types and members of an <see cref="Assembly"/>.
	/// </summary>
	public sealed class AssemblyData : MetadataItemBase
	{
		#region Static Variables

		private static readonly Dictionary<string, AssemblyData> _cachedAssemblyDatas = new Dictionary<string, AssemblyData>();

		#endregion // Static Variables

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

		internal AssemblyData(string fullName, string name, string versionComparisonName, IEnumerable<KeyValuePair<string, string>> namespaceRenames)
		{
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

		private AssemblyData(AssemblyDefinition underlyingAssembly)
			: this(underlyingAssembly.FullName, underlyingAssembly.Name.Name,
			Utilities.GetVersionComparisonName(underlyingAssembly),
			Utilities.GetNamespaceRenames(underlyingAssembly)) { }

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

		#region Public Methods

		#region FromAssembly

		/// <summary>
		/// Gets the <see cref="AssemblyData"/> instance containing the metadata for externally visible types and members of the specified <see cref="Assembly"/>.
		/// </summary>
		/// <param name="assembly">The Assembly for which the AssemblyData should be obtained.</param>
		/// <returns>The AssemblyData instance containing the metadata for externally visible types and members of the specified Assembly.</returns>
		public static AssemblyData FromAssembly(Assembly assembly)
		{
			return AssemblyData.FromAssembly(assembly.ToAssemblyDefinition());
		}

		/// <summary>
		/// Gets the <see cref="AssemblyData"/> instance containing the metadata for externally visible types and members of the specified <see cref="Assembly"/>.
		/// </summary>
		/// <param name="assembly">The Assembly for which the AssemblyData should be obtained.</param>
		/// <returns>The AssemblyData instance containing the metadata for externally visible types and members of the specified Assembly.</returns>
		public static AssemblyData FromAssembly(AssemblyDefinition assembly)
		{
			lock (_cachedAssemblyDatas)
			{
				AssemblyData assemblyData;
				if (_cachedAssemblyDatas.TryGetValue(assembly.FullName, out assemblyData) == false)
				{
					assemblyData = new AssemblyData(assembly);
					_cachedAssemblyDatas[assembly.FullName] = assemblyData;
					assemblyData.LoadFromMetadata(assembly);
				}

				return assemblyData;
			}
		}

		#endregion // FromAssembly

		#endregion // Public Methods

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

		internal GenericTypeParameterData GetGenericTypeParameterData(GenericParameter type)
		{
			if (type.DeclaringMethod != null)
				return this.GetGenericTypeParameterData(type.DeclaringMethod.Resolve(), type.Position);

			return this.GetGenericTypeParameterData(type.DeclaringType.Resolve(), type.Position);
		}

		private GenericTypeParameterData GetGenericTypeParameterData(MethodDefinition method, int position)
		{
			Debug.Assert(method.DeclaringType.GetDeclaringAssembly().FullName == this.FullName, "The method is not from this assembly");
			GenericTypeParameterData genericParameter;
			_methodOwnedGenericParameters.TryGetValue(Tuple.Create(new MethodSignature(method), position), out genericParameter);
			return genericParameter;
		}

		private GenericTypeParameterData GetGenericTypeParameterData(TypeDefinition type, int position)
		{
			Debug.Assert(type.GetDeclaringAssembly().FullName == this.FullName, "The method is not from this assembly");
			GenericTypeParameterData genericParameter;
			_typeOwnedGenericParameters.TryGetValue(Tuple.Create(type.FullName, position), out genericParameter);
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
			return _typeDefinitions.Values.OfType<TypeDefinitionData>().Where(t => t.DeclaringType == null);
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
		/// <param name="type">The type for which of corresponding to the TypeData to get.</param>
		/// <returns>The TypeData instance containing the metadata for externally visible types and members of the specified Type.</returns> 
#endif
		internal TypeData GetTypeData(TypeReference type)
		{
			Debug.Assert(type.GetType() != typeof(TypeReference), "The type has not been resolved yet, and may be from a different assembly.");
			Debug.Assert(type.GetDeclaringAssembly().FullName == this.FullName, "The type belongs to another assembly.");

			var genericParameter = type as GenericParameter;
			if (genericParameter != null)
				return this.GetGenericTypeParameterData(genericParameter);

			var accessibility = type.GetAccessibility();
			if (accessibility == null)
				return null;

			var typeDefinition = type as TypeDefinition;
			if (typeDefinition != null)
				return this.GetTypeDefinitionData(typeDefinition.FullName);

			DeclaringTypeData declaringType = null;
			if (type.DeclaringType != null)
				declaringType = (DeclaringTypeData)this.GetTypeData(type.DeclaringType.Resolve());

			var genericInstance = type as GenericInstanceType;
			if (genericInstance != null)
				return TypeDefinitionData.FromType(genericInstance.ElementType).GetConstructedGenericTypeData(genericInstance.GenericArguments.Select(a => TypeData.FromType(a)));

			if (type.IsByReference)
			{
				Debug.Fail("We should never create representations for by-ref types. They can only be parameter types and ref or out parameters store the element type and indicate whether they are ref or out.");
				return null;
			}

			var arrayType = type as ArrayType;
			if (arrayType != null)
			{
				Debug.Assert(declaringType == null, "Types with elements should not be declared within other types.");
				return TypeData.FromType(arrayType.ElementType).GetArrayType((byte)arrayType.Rank);
			}

			var pointerType = type as PointerType;
			if (pointerType != null)
				return TypeData.FromType(pointerType.ElementType).GetPointerType();

			var modifierType = type as IModifierType;
			if (modifierType != null)
				return TypeData.FromType(modifierType.ElementType);

			Debug.Fail("Unknown kind of type.");
			return TypeData.FromType(type.Resolve());
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

		private void IterateAllTypeDefinitions(AssemblyDefinition assembly,
			Func<TypeDefinition, bool> typeDefinitionAction,
			Action<GenericParameter> genericParameterAction = null)
		{
			foreach (var module in assembly.Modules)
				foreach (var type in module.Types)
					this.IterateAllTypeDefinitions(type, typeDefinitionAction, genericParameterAction);
		}

		private void IterateAllTypeDefinitions(TypeDefinition type,
			Func<TypeDefinition, bool> typeDefinitionAction,
			Action<GenericParameter> genericParameterAction)
		{
			if (typeDefinitionAction(type) == false)
				return;

			if (genericParameterAction != null)
			{
				foreach (var genericParameter in type.GenericParameters)
					genericParameterAction(genericParameter);

				foreach (var method in type.Methods.Where(m => m.HasGenericParameters && m.GetAccessibility() != null))
					foreach (var genericParameter in method.GenericParameters)
						genericParameterAction(genericParameter);
			}

			foreach (var nestedType in type.NestedTypes)
				this.IterateAllTypeDefinitions(nestedType, typeDefinitionAction, genericParameterAction);
		}

		#endregion // IterateAllTypeDefinitions

		#region LoadFromMetadata

		private void LoadFromMetadata(AssemblyDefinition assembly)
		{
			_isLoading = true;

			foreach (var module in assembly.Modules)
				foreach (var type in module.Types)
					this.RegisterType(type, null);

			// Finalize Definitions
			this.IterateAllTypeDefinitions(assembly,
				typeDefinitionAction: type =>
				{
					var typeData = (TypeDefinitionData)this.GetTypeData(type);
					if (typeData == null)
						return false;

					typeData.FinalizeDefinition(type);
					return true;
				},
				genericParameterAction: genericParameter =>
				{
					this.GetGenericTypeParameterData(genericParameter).FinalizeDefinition(genericParameter);
				});

			// Populate Members
			this.IterateAllTypeDefinitions(assembly,
				typeDefinitionAction: type =>
				{
					var typeData = (TypeDefinitionData)this.GetTypeData(type);
					if (typeData == null)
						return false;

					typeData.PopulateMembers(type);
					return true;
				});

			while (_constructedGenericsToFinalizeAfterLoad.Count != 0)
			{
				var temp = _constructedGenericsToFinalizeAfterLoad.ToArray();
				_constructedGenericsToFinalizeAfterLoad.Clear();
				foreach (var type in temp)
					type.FinalizeDefiniton();
			}

			foreach (var type in assembly.MainModule.ExportedTypes.Where(e => e.IsForwarder).Select(t => (TypeDefinitionData)TypeData.FromType(t.Resolve())).Where(t => t != null))
				this.AddForwardedType(type);

			foreach (var referenceName in assembly.Modules.SelectMany(m => m.AssemblyReferences))
			{
				AssemblyData reference;
				if (_cachedAssemblyDatas.TryGetValue(referenceName.FullName, out reference))
					_referencedAssemblies.Add(reference);
			}

			_isLoading = false;
		}

		#endregion // LoadFromMetadata

		#region RegisterType

		private void RegisterType(TypeDefinition type, TypeDefinitionData declaringType)
		{
			var accessibility = type.GetAccessibility();
			if (accessibility == null)
				return;

			var typeDefinitionData = new TypeDefinitionData(type, accessibility.Value, declaringType, this);
			_typeDefinitions.Add(type.FullName, typeDefinitionData);

			foreach (var genericParameter in type.GenericParameters)
				_typeOwnedGenericParameters.Add(Tuple.Create(type.FullName, genericParameter.Position), new GenericTypeParameterData(genericParameter, this));

			foreach (var method in type.Methods.Where(m => m.HasGenericParameters && m.GetAccessibility() != null))
			{
				var signature = new MethodSignature(method);
				foreach (var genericParameter in method.GenericParameters)
					_methodOwnedGenericParameters.Add(Tuple.Create(signature, genericParameter.Position), new GenericTypeParameterData(genericParameter, this));
			}

			foreach (var nestedType in type.NestedTypes)
				this.RegisterType(nestedType, typeDefinitionData);
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
