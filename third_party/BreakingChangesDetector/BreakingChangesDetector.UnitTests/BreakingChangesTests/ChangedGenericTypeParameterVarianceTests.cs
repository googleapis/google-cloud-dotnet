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

using System;
using Xunit;
using BreakingChangesDetector.MetadataItems;
using BreakingChangesDetector.BreakingChanges;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
	public class ChangedGenericTypeParameterVarianceTests
	{
		#region NestedTypeTests

		[Fact]
		public void NestedTypeTests()
		{
			var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
			var nestedInterfaceWithNonVariantParam = context.GetTypeDefinitionData(typeof(NestedInterfaceWithNonVariantParam));
			var nestedInterfaceWithCovariantParam = context.GetTypeDefinitionData(typeof(NestedInterfaceWithCovariantParam));
			var nestedInterfaceWithContravariantParam = context.GetTypeDefinitionData(typeof(NestedInterfaceWithContravariantParam));
			
			var breakingChanges = MetadataComparer.CompareTypes(nestedInterfaceWithNonVariantParam, nestedInterfaceWithCovariantParam);
			AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a type parameter changes from invariant to variant.");

			breakingChanges = MetadataComparer.CompareTypes(nestedInterfaceWithNonVariantParam, nestedInterfaceWithContravariantParam);
			AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a type parameter changes from invariant to variant.");

			breakingChanges = MetadataComparer.CompareTypes(nestedInterfaceWithCovariantParam, nestedInterfaceWithNonVariantParam);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(nestedInterfaceWithCovariantParam.GetNestedType("Interface`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(nestedInterfaceWithNonVariantParam.GetNestedType("Interface`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedInterfaceWithCovariantParam, nestedInterfaceWithContravariantParam);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(nestedInterfaceWithCovariantParam.GetNestedType("Interface`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(nestedInterfaceWithContravariantParam.GetNestedType("Interface`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedInterfaceWithContravariantParam, nestedInterfaceWithNonVariantParam);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(nestedInterfaceWithContravariantParam.GetNestedType("Interface`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(nestedInterfaceWithNonVariantParam.GetNestedType("Interface`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedInterfaceWithContravariantParam, nestedInterfaceWithCovariantParam);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(nestedInterfaceWithContravariantParam.GetNestedType("Interface`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(nestedInterfaceWithCovariantParam.GetNestedType("Interface`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			var nestedDelegateWithNonVariantParam = context.GetTypeDefinitionData(typeof(NestedDelegateWithNonVariantParam));
			var nestedDelegateWithCovariantParam = context.GetTypeDefinitionData(typeof(NestedDelegateWithCovariantParam));
			var nestedDelegateWithContravariantParam = context.GetTypeDefinitionData(typeof(NestedDelegateWithContravariantParam));

			breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithNonVariantParam, nestedDelegateWithCovariantParam);
			AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a type parameter changes from invariant to variant.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithNonVariantParam, nestedDelegateWithContravariantParam);
			AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a type parameter changes from invariant to variant.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithCovariantParam, nestedDelegateWithNonVariantParam);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(nestedDelegateWithCovariantParam.GetNestedType("Delegate`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(nestedDelegateWithNonVariantParam.GetNestedType("Delegate`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithCovariantParam, nestedDelegateWithContravariantParam);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(nestedDelegateWithCovariantParam.GetNestedType("Delegate`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(nestedDelegateWithContravariantParam.GetNestedType("Delegate`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithContravariantParam, nestedDelegateWithNonVariantParam);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(nestedDelegateWithContravariantParam.GetNestedType("Delegate`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(nestedDelegateWithNonVariantParam.GetNestedType("Delegate`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedDelegateWithContravariantParam, nestedDelegateWithCovariantParam);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(nestedDelegateWithContravariantParam.GetNestedType("Delegate`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(nestedDelegateWithCovariantParam.GetNestedType("Delegate`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // NestedTypeTests

		#region TypeTests

		[Fact]
		public void TypeTests()
		{
			var context = MetadataResolutionContext.CreateFromTypes(typeof(ChangedAccessibilityFromPublicToProtectedTests));
			var interfaceWithNonVariantParam = context.GetTypeDefinitionData(typeof(InterfaceWithNonVariantParam<>));
			var interfaceWithCovariantParam = context.GetTypeDefinitionData(typeof(InterfaceWithCovariantParam<>));
			var interfaceWithContravariantParam = context.GetTypeDefinitionData(typeof(InterfaceWithContravariantParam<>));
			
			var breakingChanges = MetadataComparer.CompareTypes(interfaceWithNonVariantParam, interfaceWithCovariantParam);
			AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a type parameter changes from invariant to variant.");

			breakingChanges = MetadataComparer.CompareTypes(interfaceWithNonVariantParam, interfaceWithContravariantParam);
			AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a type parameter changes from invariant to variant.");

			breakingChanges = MetadataComparer.CompareTypes(interfaceWithCovariantParam, interfaceWithNonVariantParam);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(interfaceWithCovariantParam.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(interfaceWithNonVariantParam.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(interfaceWithCovariantParam, interfaceWithContravariantParam);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(interfaceWithCovariantParam.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(interfaceWithContravariantParam.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(interfaceWithContravariantParam, interfaceWithNonVariantParam);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(interfaceWithContravariantParam.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(interfaceWithNonVariantParam.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(interfaceWithContravariantParam, interfaceWithCovariantParam);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(interfaceWithContravariantParam.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(interfaceWithCovariantParam.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			var delegateWithNonVariantParam = context.GetTypeDefinitionData(typeof(DelegateWithNonVariantParam<>));
			var delegateWithCovariantParam = context.GetTypeDefinitionData(typeof(DelegateWithCovariantParam<>));
			var delegateWithContravariantParam = context.GetTypeDefinitionData(typeof(DelegateWithContravariantParam<>));

			breakingChanges = MetadataComparer.CompareTypes(delegateWithNonVariantParam, delegateWithCovariantParam);
			AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a type parameter changes from invariant to variant.");

			breakingChanges = MetadataComparer.CompareTypes(delegateWithNonVariantParam, delegateWithContravariantParam);
			AssertX.Equal(0, breakingChanges.Count, "There should be no breaking changes when a type parameter changes from invariant to variant.");

			breakingChanges = MetadataComparer.CompareTypes(delegateWithCovariantParam, delegateWithNonVariantParam);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(delegateWithCovariantParam.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(delegateWithNonVariantParam.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(delegateWithCovariantParam, delegateWithContravariantParam);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(delegateWithCovariantParam.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(delegateWithContravariantParam.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(delegateWithContravariantParam, delegateWithNonVariantParam);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(delegateWithContravariantParam.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(delegateWithNonVariantParam.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(delegateWithContravariantParam, delegateWithCovariantParam);
			AssertX.Equal(1, breakingChanges.Count, "There should be one breaking change when type parameter variance changes.");
			AssertX.Equal(BreakingChangeKind.ChangedGenericTypeParameterVariance, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			AssertX.Equal(delegateWithContravariantParam.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			AssertX.Equal(delegateWithCovariantParam.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			AssertX.Null(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
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
