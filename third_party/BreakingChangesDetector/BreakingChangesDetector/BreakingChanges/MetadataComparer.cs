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

using BreakingChangesDetector.BreakingChanges.Definitions;
using BreakingChangesDetector.MetadataItems;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.BreakingChanges
{
	/// <summary>
	/// A static class with methods that can compare two versions of a similar entity and return the break changes introduced in the 
	/// newer version.
	/// </summary>
	public static class MetadataComparer
	{
		#region Static Variables

		private static readonly Dictionary<MetadataItemKinds, List<BreakingChangeDefinitionBase>> _definitionsByKind;
		private static readonly MetadataItemKinds[] _metadataItemKinds;
		private static readonly IEnumerable<BreakingChangeBase> _noBreakingChanges = Enumerable.Empty<BreakingChangeBase>();

		#endregion // Static Variables

		#region Constructor

		static MetadataComparer()
		{
			var metadataItemKinds = new List<MetadataItemKinds>();
			foreach (var name in Enum.GetNames(typeof(MetadataItemKinds)))
				metadataItemKinds.Add((MetadataItemKinds)Enum.Parse(typeof(MetadataItemKinds), name));

			_metadataItemKinds = metadataItemKinds.ToArray();

			_definitionsByKind = new Dictionary<MetadataItemKinds, List<BreakingChangeDefinitionBase>>();
			foreach (var kind in _metadataItemKinds)
				_definitionsByKind[kind] = new List<BreakingChangeDefinitionBase>();

			Action<BreakingChangeDefinitionBase> addDefinition = definition =>
				{
					foreach (var kind in _metadataItemKinds.Where(k => definition.MembersKindsHandled.HasFlag(k)))
						_definitionsByKind[kind].Add(definition);
				};

			addDefinition(AddedBaseInterfaceDefinition.Instance);
			addDefinition(ChangedAccessibilityFromPublicToProtectedDefinition.Instance);
			addDefinition(ChangedClassToAbstractDefinition.Instance);
			addDefinition(ChangedFieldToReadOnlyDefinition.Instance);
			addDefinition(ChangedClassToStaticDefinition.Instance);
			addDefinition(ChangedGenericTypeParameterConstraintsDefinition.Instance);
			addDefinition(ChangedGenericTypeParameterVarianceDefinition.Instance);
			addDefinition(ChangedMemberToAbstractDefinition.Instance);
			addDefinition(ChangedMemberToNonVirtualDefinition.Instance);
			addDefinition(ChangedParameterDefaultValueDefinition.Instance);
			addDefinition(ChangedParameterModifierDefinition.Instance);
			addDefinition(ChangedParameterNameDefinition.Instance);
			addDefinition(ChangedParameterTypeDefinition.Instance);
			addDefinition(ChangedParameterCountDefinition.Instance);
			addDefinition(ChangedMemberTypeDefinition.Instance);
			addDefinition(ChangedStaticOrInstanceStatusDefinition.Instance);
			addDefinition(IncompatibleClassHierarchyDefinition.Instance);
			addDefinition(RemovedExtensionMethodModifierDefinition.Instance);
			addDefinition(RemovedImplementedInterfaceDefinition.Instance);
			addDefinition(RemovedPropertyAccessorsDefinition.Instance);
			addDefinition(SealedClassDefinition.Instance);
		}

		#endregion // Constructor

		#region Methods

		#region Public Methods

		/// <summary>
		/// Compares two <see cref="AssemblyFamily"/> instances and returns the breaking changes introduced in the newer assemblies if their 
		/// associated older versions exist in the <paramref name="oldFamily"/>.
		/// </summary>
		public static List<BreakingChangeBase> CompareAssemblyFamilies(AssemblyFamily oldFamily, AssemblyFamily newFamily)
		{
			var breakingChanges = new List<BreakingChangeBase>();

			foreach (var oldAssembly in oldFamily)
			{
				var newAssembly = newFamily.GetEquivalentAssembly(oldAssembly);
				if (newAssembly == null)
					breakingChanges.Add(new RemovedAssembly(oldAssembly));
				else
					breakingChanges.AddRange(MetadataComparer.CompareAssemblies(oldAssembly, newAssembly, newFamily));
			}

			return breakingChanges;
		}

		/// <summary>
		/// Compares two associated <see cref="AssemblyData"/> instances and returns the breaking changes introduced in the newer version of 
		/// the assembly.
		/// </summary>
		public static List<BreakingChangeBase> CompareAssemblies(AssemblyData oldAssembly, AssemblyData newAssembly)
		{
			return MetadataComparer.CompareAssemblies(oldAssembly, newAssembly, new AssemblyFamily { newAssembly });
		}

		/// <summary>
		/// Compares two associated <see cref="TypeData"/> instances and returns the breaking changes introduced in the newer version of the 
		/// type.
		/// </summary>
		public static List<BreakingChangeBase> CompareTypes(TypeData oldTypeBase, TypeData newTypeBase)
		{
			return MetadataComparer.CompareTypes(oldTypeBase, newTypeBase, newTypeBase.GetDefiningAssemblyFamily());
		}

		#endregion // Public Methods

		#region Private Methods

		private static List<BreakingChangeBase> CompareAssemblies(AssemblyData oldAssembly, AssemblyData newAssembly, AssemblyFamily newFamily)
		{
			var breakingChanges = new List<BreakingChangeBase>();
			foreach (var oldType in oldAssembly.GetNonNestedTypeDefinitions())
			{
				var newType = oldType.GetEquivalentNewType(newFamily);
				if (newType == null)
					breakingChanges.Add(new RemovedRootType(oldType));
				else
					breakingChanges.AddRange(MetadataComparer.CompareTypes(oldType, newType, newFamily));
			}
			return breakingChanges;
		}

		private static List<BreakingChangeBase> CompareGenericTypeParameters(GenericTypeParameterData oldGenericTypeParameter, GenericTypeParameterData newGenericTypeParameter, AssemblyFamily newAssemblyFamily)
		{
			return MetadataComparer.CompareItems(oldGenericTypeParameter, newGenericTypeParameter, newAssemblyFamily);
		}

		private static List<BreakingChangeBase> CompareIndexers(IndexerData oldIndexer, IndexerData newIndexer, AssemblyFamily newAssemblyFamily)
		{
			var breakingChanges = MetadataComparer.CompareItems(oldIndexer, newIndexer, newAssemblyFamily);
			MetadataComparer.CompareParameters(oldIndexer, newIndexer, newAssemblyFamily, breakingChanges);
			return breakingChanges;
		}

		private static List<BreakingChangeBase> CompareItems(MetadataItemBase oldItem, MetadataItemBase newItem, AssemblyFamily newAssemblyFamily, MetadataItemBase additionalInfo = null)
		{
			var breakingChanges = new List<BreakingChangeBase>();
			var context = new CompareItemsContext(oldItem, newItem, newAssemblyFamily, breakingChanges, additionalInfo);

			Debug.Assert(oldItem.MetadataItemKind == newItem.MetadataItemKind, "The items are not the same kind.");
			var definitions = _definitionsByKind[oldItem.MetadataItemKind];
			foreach (var definition in definitions)
				definition.CompareItems(context);

			return breakingChanges;
		}

		private static IEnumerable<BreakingChangeBase> CompareMembers(MemberDataBase oldMember, MemberDataBase newMember, AssemblyFamily newAssemblyFamily)
		{
			switch (oldMember.MetadataItemKind)
			{
				case MetadataItemKinds.Constant:
				case MetadataItemKinds.Event:
				case MetadataItemKinds.Field:
				case MetadataItemKinds.Property:
					return MetadataComparer.CompareItems(oldMember, newMember, newAssemblyFamily);

				case MetadataItemKinds.Indexer:
					return MetadataComparer.CompareIndexers((IndexerData)oldMember, (IndexerData)newMember, newAssemblyFamily);

				case MetadataItemKinds.Constructor:
				case MetadataItemKinds.Operator:
					{
						var breakingChanges = MetadataComparer.CompareItems(oldMember, newMember, newAssemblyFamily);
						MetadataComparer.CompareParameters((IParameterizedItem)oldMember, (IParameterizedItem)newMember, newAssemblyFamily, breakingChanges);
						return breakingChanges;
					}

				case MetadataItemKinds.Method:
					return MetadataComparer.CompareMethods((MethodData)oldMember, (MethodData)newMember, newAssemblyFamily);

				case MetadataItemKinds.TypeDefinition:
					return MetadataComparer.CompareTypes((TypeDefinitionData)oldMember, (TypeDefinitionData)newMember, newAssemblyFamily);

				case MetadataItemKinds.Assembly:
				case MetadataItemKinds.GenericTypeParameter:
				case MetadataItemKinds.Parameter:
					Debug.Fail("This is not a member: " + oldMember.MetadataItemKind);
					break;

				default:
					Debug.Fail("Unknown MetadataItemKinds: " + oldMember.MetadataItemKind);
					break;
			}

			return _noBreakingChanges;
		}

		private static List<BreakingChangeBase> CompareMethods(MethodData oldMethodBase, MethodData newMethodBase, AssemblyFamily newAssemblyFamily)
		{
			var breakingChanges = MetadataComparer.CompareItems(oldMethodBase, newMethodBase, newAssemblyFamily);
			MetadataComparer.CompareParameters(oldMethodBase, newMethodBase, newAssemblyFamily, breakingChanges);

			if (oldMethodBase.MetadataItemKind == MetadataItemKinds.Method)
			{
				var oldMethod = (MethodData)oldMethodBase;
				var newMethod = (MethodData)newMethodBase;

				if (oldMethod.GenericParameters.Count == newMethod.GenericParameters.Count)
				{
					for (int i = 0; i < oldMethod.GenericParameters.Count; i++)
						breakingChanges.AddRange(MetadataComparer.CompareGenericTypeParameters(oldMethod.GenericParameters[i], newMethod.GenericParameters[i], newAssemblyFamily));
				}
			}
			return breakingChanges;
		}

		private static void CompareParameters(IParameterizedItem oldParameterizedItem, IParameterizedItem newParameterizedItem, AssemblyFamily newAssemblyFamily, List<BreakingChangeBase> breakingChanges)
		{
			if (oldParameterizedItem.Parameters.Count == newParameterizedItem.Parameters.Count)
			{
				for (int i = 0; i < oldParameterizedItem.Parameters.Count; i++)
					breakingChanges.AddRange(MetadataComparer.CompareParameters(oldParameterizedItem.Parameters[i], newParameterizedItem.Parameters[i], newAssemblyFamily, (MetadataItemBase)newParameterizedItem));
			}
		}

		private static List<BreakingChangeBase> CompareParameters(ParameterData oldParameter, ParameterData newParameter, AssemblyFamily newAssemblyFamily, MetadataItemBase declaringMember)
		{
			var breakingChanges = MetadataComparer.CompareItems(oldParameter, newParameter, newAssemblyFamily, declaringMember);

			// If a parameter is changed completely, it will most likely have a new type and name. We should only warn about the type change.
			var typeChanges = new HashSet<ParameterData>(
				breakingChanges.OfType<ChangedParameterType>().Select(b => b.NewParameter)
				);
			breakingChanges.RemoveAll(b => b.BreakingChangeKind == BreakingChangeKind.ChangedParameterName && typeChanges.Contains((ParameterData)b.NewItem));

			return breakingChanges;
		}

		private static List<BreakingChangeBase> CompareTypes(TypeData oldTypeBase, TypeData newTypeBase, AssemblyFamily newAssemblyFamily)
		{
			var oldType = (TypeDefinitionData)oldTypeBase;
			var newType = (TypeDefinitionData)newTypeBase;

			var breakingChanges = MetadataComparer.CompareItems(oldType, newType, newAssemblyFamily);

			if (oldType.GenericParameters.Count == newType.GenericParameters.Count)
			{
				for (int i = 0; i < oldType.GenericParameters.Count; i++)
					breakingChanges.AddRange(MetadataComparer.CompareGenericTypeParameters(oldType.GenericParameters[i], newType.GenericParameters[i], newAssemblyFamily));
			}

			var hasExternallyVisibleConstructor = oldType.GetMembers(".ctor").Count != 0;

			if (oldType.TypeKind != TypeKind.Delegate)
			{
				foreach (var oldMember in oldType.GetMembers())
				{
					MemberDataBase newMember;
					if (oldType.TypeKind == TypeKind.Class && oldMember.IsOverride == false)
						newMember = MetadataComparer.FindEquivalentMemberInClassHierarchy(oldMember, newType, newAssemblyFamily);
					else
						newMember = MetadataComparer.FindEquivalentMember(oldMember, newType, newAssemblyFamily);

					if (newMember != null)
					{
						breakingChanges.AddRange(MetadataComparer.CompareMembers(oldMember, newMember, newAssemblyFamily));
						continue;
					}

					if (MetadataComparer.IsMemberKindChangeAllowed(oldMember, newType, newAssemblyFamily))
						continue;

					if (oldMember.IsOverride)
					{
						if (hasExternallyVisibleConstructor)
						{
							var baseMember = oldMember.GetBaseMember();
							if (baseMember.IsAbstract)
								breakingChanges.Add(new RemovedOverrideOfAbstractMember(oldMember, newType));
						}

						continue;
					}

					breakingChanges.Add(new RemovedMember(oldMember, newType));
				}
			}

			switch (oldType.TypeKind)
			{
				case TypeKind.Class:
					foreach (var newMember in newType.GetMembers())
					{
						if (newMember.IsAbstract)
						{
							var oldMember = MetadataComparer.FindEquivalentMemberInClassHierarchy(newMember, oldType, newAssemblyFamily);
							if (oldMember == null)
								breakingChanges.Add(new AddedAbstractMember(newMember));
						}
						else if (newType.IsSealed == false && newMember.IsSealed && newMember.IsOverride)
						{
							// If the class contains a sealed override member, find the original equivalent member and see if derived
							// classes would have been able to override the member previously.
							var oldMember = MetadataComparer.FindEquivalentMemberInClassHierarchy(newMember, oldType, newAssemblyFamily);
							if (oldMember != null && oldMember.CanBeOverridden)
								breakingChanges.Add(new SealedMember(oldMember, newMember));
						}
					}
					break;

				case TypeKind.Interface:
					foreach (var newMember in newType.GetMembers())
					{
						var oldMember = MetadataComparer.FindEquivalentMember(newMember, oldType, newAssemblyFamily);
						if (oldMember == null)
							breakingChanges.Add(new AddedInterfaceMember(newMember));
					}
					break;

				case TypeKind.Delegate:
					MetadataComparer.CompareParameters(oldType, newType, newAssemblyFamily, breakingChanges);
					break;
			}
			return breakingChanges;
		}

		private static MemberDataBase FindEquivalentMemberInClassHierarchy(MemberDataBase oldMember, DeclaringTypeData newType, AssemblyFamily newAssemblyFamily)
		{
			var allowMatchOnNameOnly = true;
			var current = newType;
			while (current != null)
			{
				var newMember = MetadataComparer.FindEquivalentMember(oldMember, current, newAssemblyFamily, allowMatchOnNameOnly);
				if (newMember != null)
					return newMember;

				current = current.BaseType;
				allowMatchOnNameOnly = false;
			}

			return null;
		}

		private static MemberDataBase FindEquivalentMember(MemberDataBase oldMember, DeclaringTypeData newType, AssemblyFamily newAssemblyFamily, bool allowMatchOnNameOnly = true)
		{
			var newMembers = newType.GetMembers(oldMember.Name);
			if (newMembers.Count == 0)
				return null;

			var candidateMembers = newMembers.Where(m => m.MetadataItemKind == oldMember.MetadataItemKind).ToList();
			foreach (var newMember in candidateMembers)
			{
				if (oldMember.IsEquivalentToNewMember(newMember, newAssemblyFamily))
					return newMember;
			}

			// TODO: This could match up a new item to multiple old items. This might need to be improved.
			// If we didn't find any match and the current member has parameters, we should try to match this method up
			// with any new method that has the same required parameters, but new optional parameters as well.
			var oldParameterizedMember = oldMember as IParameterizedItem;
			if (oldParameterizedMember != null)
			{
				foreach (var newParameterizedMember in candidateMembers)
				{
					if (oldParameterizedMember.IsEquivalentToNewMember(newParameterizedMember, newAssemblyFamily, ignoreNewOptionalParameters: true))
						return (MemberDataBase)newParameterizedMember;
				}
			}

			// If there is only one member, we may still want to return it (for example, if both types have a single method with the same name but
			// a different number of parameters, they are incompatible for normal comparison, but not since there is only one method in both versions
			// we can safely assume they are the "same" and report errors for the number or types of parameters changing.
			if (allowMatchOnNameOnly &&
				candidateMembers.Count == 1 &&
				oldMember.DeclaringType.GetMembers(oldMember.Name).Count == 1)
			{
				switch (oldMember.MetadataItemKind)
				{
					case MetadataItemKinds.Constant:
					case MetadataItemKinds.Constructor:
					case MetadataItemKinds.Event:
					case MetadataItemKinds.Field:
					case MetadataItemKinds.Indexer:
					case MetadataItemKinds.Method:
					case MetadataItemKinds.Operator:
					case MetadataItemKinds.Property:
					case MetadataItemKinds.TypeDefinition:
						return candidateMembers[0];
				}
			}

			return null;
		}

		private static bool IsMemberKindChangeAllowed(MemberDataBase oldMember, TypeDefinitionData newType, AssemblyFamily newAssemblyFamily)
		{
			if (oldMember.MetadataItemKind == MetadataItemKinds.Constant ||
				(oldMember.MetadataItemKind == MetadataItemKinds.Field && ((FieldData)oldMember).IsReadOnly) ||
				(oldMember.MetadataItemKind == MetadataItemKinds.Property && oldMember.CanBeOverridden == false))
			{
				var oldTypedMemer = (TypedMemberDataBase)oldMember;
				var candidateMembers = newType.GetMembers(oldMember.Name).Where(m =>
					(
						m.MetadataItemKind == MetadataItemKinds.Constant ||
						m.MetadataItemKind == MetadataItemKinds.Field ||
						m.MetadataItemKind == MetadataItemKinds.Property
					) &&
					oldTypedMemer.Accessibility <= m.Accessibility &&
					m.IsInstance == oldMember.IsInstance &&
					oldTypedMemer.Type.IsEquivalentToNew(((ITypedItem)m).Type, newAssemblyFamily)
					).ToList();

				if (candidateMembers.Count == 0)
					return false;

				Debug.Assert(candidateMembers.Count == 1, "There should only be one member with the same name.");

				var newMember = candidateMembers[0];
				if (oldMember.CanRead() && newMember.CanRead() == false)
					return false;

				if (oldMember.CanWrite() && newMember.CanWrite() == false)
					return false;

				var newProperty = newMember as PropertyData;
				if (newProperty != null && newProperty.GetMethodAccessibility < oldMember.Accessibility)
					return false;

				return true;
			}

			return false;
		}

		#endregion // Private Methods

		#endregion // Methods
	}
}
