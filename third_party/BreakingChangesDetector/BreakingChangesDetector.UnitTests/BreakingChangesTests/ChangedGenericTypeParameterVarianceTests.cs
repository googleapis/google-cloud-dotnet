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

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreakingChangesDetector.MetadataItems;
using BreakingChangesDetector.BreakingChanges;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
	[TestClass]
	public class ChangedGenericTypeParameterVarianceTests
	{
		#region NestedTypeTests

		[TestMethod]
		public void NestedTypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var nestedInterfaceWithNonVariantParam = TypeDefinitionData.FromType(typeof(NestedInterfaceWithNonVariantParam));
			var nestedInterfaceWithCovariantParam = TypeDefinitionData.FromType(typeof(NestedInterfaceWithCovariantParam));
			var nestedInterfaceWithContravariantParam = TypeDefinitionData.FromType(typeof(NestedInterfaceWithContravariantParam));
			
			var breakingChanges = MetadataComparer.CompareTypes(nestedInterfaceWithNonVariantParam, nestedInterfaceWithCovariantParam);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a type parameter changes from invariant to variant.");

			breakingChanges = MetadataComparer.CompareTypes(nestedInterfaceWithNonVariantParam, nestedInterfaceWithContravariantParam);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a type parameter changes from invariant to variant.");

			breakingChanges = MetadataComparer.CompareTypes(nestedInterfaceWithCovariantParam, nestedInterfaceWithNonVariantParam);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedInterfaceWithCovariantParam.GetNestedType("Interface`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedInterfaceWithNonVariantParam.GetNestedType("Interface`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedInterfaceWithCovariantParam, nestedInterfaceWithContravariantParam);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedInterfaceWithCovariantParam.GetNestedType("Interface`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedInterfaceWithContravariantParam.GetNestedType("Interface`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedInterfaceWithContravariantParam, nestedInterfaceWithNonVariantParam);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedInterfaceWithContravariantParam.GetNestedType("Interface`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedInterfaceWithNonVariantParam.GetNestedType("Interface`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedInterfaceWithContravariantParam, nestedInterfaceWithCovariantParam);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedInterfaceWithContravariantParam.GetNestedType("Interface`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedInterfaceWithCovariantParam.GetNestedType("Interface`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			var nestedDelegateWithNonVariantParam = TypeDefinitionData.FromType(typeof(NestedDelegateWithNonVariantParam));
			var nestedDelegateWithCovariantParam = TypeDefinitionData.FromType(typeof(NestedDelegateWithCovariantParam));
			var nestedDelegateWithContravariantParam = TypeDefinitionData.FromType(typeof(NestedDelegateWithContravariantParam));

			breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithNonVariantParam, nestedDelegateWithCovariantParam);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a type parameter changes from invariant to variant.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithNonVariantParam, nestedDelegateWithContravariantParam);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a type parameter changes from invariant to variant.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithCovariantParam, nestedDelegateWithNonVariantParam);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedDelegateWithCovariantParam.GetNestedType("Delegate`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedDelegateWithNonVariantParam.GetNestedType("Delegate`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithCovariantParam, nestedDelegateWithContravariantParam);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedDelegateWithCovariantParam.GetNestedType("Delegate`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedDelegateWithContravariantParam.GetNestedType("Delegate`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithContravariantParam, nestedDelegateWithNonVariantParam);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedDelegateWithContravariantParam.GetNestedType("Delegate`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedDelegateWithNonVariantParam.GetNestedType("Delegate`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithContravariantParam, nestedDelegateWithCovariantParam);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedDelegateWithContravariantParam.GetNestedType("Delegate`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedDelegateWithCovariantParam.GetNestedType("Delegate`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // NestedTypeTests

		#region TypeTests

		[TestMethod]
		public void TypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var interfaceWithNonVariantParam = TypeDefinitionData.FromType(typeof(InterfaceWithNonVariantParam<>));
			var interfaceWithCovariantParam = TypeDefinitionData.FromType(typeof(InterfaceWithCovariantParam<>));
			var interfaceWithContravariantParam = TypeDefinitionData.FromType(typeof(InterfaceWithContravariantParam<>));
			
			var breakingChanges = MetadataComparer.CompareTypes(interfaceWithNonVariantParam, interfaceWithCovariantParam);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a type parameter changes from invariant to variant.");

			breakingChanges = MetadataComparer.CompareTypes(interfaceWithNonVariantParam, interfaceWithContravariantParam);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a type parameter changes from invariant to variant.");

			breakingChanges = MetadataComparer.CompareTypes(interfaceWithCovariantParam, interfaceWithNonVariantParam);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(interfaceWithCovariantParam.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(interfaceWithNonVariantParam.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(interfaceWithCovariantParam, interfaceWithContravariantParam);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(interfaceWithCovariantParam.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(interfaceWithContravariantParam.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(interfaceWithContravariantParam, interfaceWithNonVariantParam);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(interfaceWithContravariantParam.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(interfaceWithNonVariantParam.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(interfaceWithContravariantParam, interfaceWithCovariantParam);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(interfaceWithContravariantParam.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(interfaceWithCovariantParam.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			var delegateWithNonVariantParam = TypeDefinitionData.FromType(typeof(DelegateWithNonVariantParam<>));
			var delegateWithCovariantParam = TypeDefinitionData.FromType(typeof(DelegateWithCovariantParam<>));
			var delegateWithContravariantParam = TypeDefinitionData.FromType(typeof(DelegateWithContravariantParam<>));

			breakingChanges = MetadataComparer.CompareTypes(delegateWithNonVariantParam, delegateWithCovariantParam);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a type parameter changes from invariant to variant.");

			breakingChanges = MetadataComparer.CompareTypes(delegateWithNonVariantParam, delegateWithContravariantParam);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a type parameter changes from invariant to variant.");

			breakingChanges = MetadataComparer.CompareTypes(delegateWithCovariantParam, delegateWithNonVariantParam);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(delegateWithCovariantParam.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(delegateWithNonVariantParam.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(delegateWithCovariantParam, delegateWithContravariantParam);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(delegateWithCovariantParam.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(delegateWithContravariantParam.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(delegateWithContravariantParam, delegateWithNonVariantParam);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(delegateWithContravariantParam.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(delegateWithNonVariantParam.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(delegateWithContravariantParam, delegateWithCovariantParam);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(delegateWithContravariantParam.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(delegateWithCovariantParam.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // TypeTests

		public class NestedInterfaceWithNonVariantParam { public interface Interface<T> { } }
		public class NestedInterfaceWithCovariantParam { public interface Interface<out T> { } }
		public class NestedInterfaceWithContravariantParam { public interface Interface<in T> { } }

		public class NestedDelegateWithNonVariantParam { public delegate void Delegate<T>();}
		public class NestedDelegateWithCovariantParam { public delegate void Delegate<out T>();}
		public class NestedDelegateWithContravariantParam { public delegate void Delegate<in T>();}


		public interface InterfaceWithNonVariantParam<T> { }
		public interface InterfaceWithCovariantParam<out T> { }
		public interface InterfaceWithContravariantParam<in T> { }

		public delegate void DelegateWithNonVariantParam<T>();
		public delegate void DelegateWithCovariantParam<out T>();
		public delegate void DelegateWithContravariantParam<in T>();
	}
}
