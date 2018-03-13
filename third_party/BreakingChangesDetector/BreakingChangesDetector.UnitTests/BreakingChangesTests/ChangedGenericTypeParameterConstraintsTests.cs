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
	public class ChangedGenericTypeParameterConstraintsTests
	{
		#region MethodTests

		[TestMethod]
		public void MethodTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var methodWithNoConstraints = TypeDefinitionData.FromType(typeof(MethodWithNoConstraints));
			var methodWithNewConstraint = TypeDefinitionData.FromType(typeof(MethodWithNewConstraint));
			var methodWithStructConstraint = TypeDefinitionData.FromType(typeof(MethodWithStructConstraint));
			var methodWithClassConstraint = TypeDefinitionData.FromType(typeof(MethodWithClassConstraint));
			var methodWithClassNewConstraints = TypeDefinitionData.FromType(typeof(MethodWithClassNewConstraints));
			var methodWithBaseInterfaceConstraint = TypeDefinitionData.FromType(typeof(MethodWithBaseInterfaceConstraint));
			var methodWithDerivedInterfaceConstraint = TypeDefinitionData.FromType(typeof(MethodWithDerivedInterfaceConstraint));
			var methodWithBaseTypeContraint = TypeDefinitionData.FromType(typeof(MethodWithBaseTypeContraint));
			
			var breakingChanges = MetadataComparer.CompareTypes(methodWithNoConstraints, methodWithNewConstraint);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((MethodData)methodWithNewConstraint.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(methodWithNoConstraints, methodWithStructConstraint);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((MethodData)methodWithStructConstraint.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(methodWithNoConstraints, methodWithClassConstraint);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((MethodData)methodWithClassConstraint.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(methodWithNoConstraints, methodWithClassNewConstraints);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((MethodData)methodWithClassNewConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(methodWithNoConstraints, methodWithBaseInterfaceConstraint);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((MethodData)methodWithBaseInterfaceConstraint.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(methodWithNoConstraints, methodWithDerivedInterfaceConstraint);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((MethodData)methodWithDerivedInterfaceConstraint.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(methodWithNoConstraints, methodWithBaseTypeContraint);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((MethodData)methodWithBaseTypeContraint.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			// Do the same tests in reverse order
			breakingChanges = MetadataComparer.CompareTypes(methodWithNewConstraint, methodWithNoConstraints);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((MethodData)methodWithNewConstraint.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(methodWithStructConstraint, methodWithNoConstraints);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((MethodData)methodWithStructConstraint.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(methodWithClassConstraint, methodWithNoConstraints);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((MethodData)methodWithClassConstraint.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(methodWithClassNewConstraints, methodWithNoConstraints);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((MethodData)methodWithClassNewConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(methodWithBaseInterfaceConstraint, methodWithNoConstraints);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((MethodData)methodWithBaseInterfaceConstraint.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(methodWithDerivedInterfaceConstraint, methodWithNoConstraints);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((MethodData)methodWithDerivedInterfaceConstraint.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(methodWithBaseTypeContraint, methodWithNoConstraints);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(((MethodData)methodWithBaseTypeContraint.GetMember("Method")).GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(((MethodData)methodWithNoConstraints.GetMember("Method")).GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // MethodTests

		#region NestedTypeTests

		[TestMethod]
		public void NestedTypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var nestedClassWithNoConstraints = TypeDefinitionData.FromType(typeof(NestedClassWithNoConstraints));
			var nestedClassWithNewConstraint = TypeDefinitionData.FromType(typeof(NestedClassWithNewConstraint));
			var nestedClassWithStructConstraint = TypeDefinitionData.FromType(typeof(NestedClassWithStructConstraint));
			var nestedClassWithClassConstraint = TypeDefinitionData.FromType(typeof(NestedClassWithClassConstraint));
			var nestedClassWithClassNewConstraints = TypeDefinitionData.FromType(typeof(NestedClassWithClassNewConstraints));
			var nestedClassWithBaseInterfaceConstraint = TypeDefinitionData.FromType(typeof(NestedClassWithBaseInterfaceConstraint));
			var nestedClassWithDerivedInterfaceConstraint = TypeDefinitionData.FromType(typeof(NestedClassWithDerivedInterfaceConstraint));
			var nestedClassWithBaseTypeContraint = TypeDefinitionData.FromType(typeof(NestedClassWithBaseTypeContraint));
			
			var breakingChanges = MetadataComparer.CompareTypes(nestedClassWithNoConstraints, nestedClassWithNewConstraint);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedClassWithNewConstraint.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedClassWithNoConstraints, nestedClassWithStructConstraint);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedClassWithStructConstraint.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedClassWithNoConstraints, nestedClassWithClassConstraint);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedClassWithClassConstraint.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedClassWithNoConstraints, nestedClassWithClassNewConstraints);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedClassWithClassNewConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedClassWithNoConstraints, nestedClassWithBaseInterfaceConstraint);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedClassWithBaseInterfaceConstraint.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedClassWithNoConstraints, nestedClassWithDerivedInterfaceConstraint);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedClassWithDerivedInterfaceConstraint.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedClassWithNoConstraints, nestedClassWithBaseTypeContraint);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedClassWithBaseTypeContraint.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			// Do the same tests in reverse order
			breakingChanges = MetadataComparer.CompareTypes(nestedClassWithNewConstraint, nestedClassWithNoConstraints);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedClassWithNewConstraint.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedClassWithStructConstraint, nestedClassWithNoConstraints);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedClassWithStructConstraint.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedClassWithClassConstraint, nestedClassWithNoConstraints);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedClassWithClassConstraint.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedClassWithClassNewConstraints, nestedClassWithNoConstraints);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedClassWithClassNewConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedClassWithBaseInterfaceConstraint, nestedClassWithNoConstraints);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedClassWithBaseInterfaceConstraint.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedClassWithDerivedInterfaceConstraint, nestedClassWithNoConstraints);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedClassWithDerivedInterfaceConstraint.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(nestedClassWithBaseTypeContraint, nestedClassWithNoConstraints);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(nestedClassWithBaseTypeContraint.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(nestedClassWithNoConstraints.GetNestedType("Class`1").GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // NestedTypeTests

		#region TypeTests

		[TestMethod]
		public void TypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var classWithNoConstraints = TypeDefinitionData.FromType(typeof(ClassWithNoConstraints<>));
			var classWithNewConstraint = TypeDefinitionData.FromType(typeof(ClassWithNewConstraint<>));
			var classWithStructConstraint = TypeDefinitionData.FromType(typeof(ClassWithStructConstraint<>));
			var classWithClassConstraint = TypeDefinitionData.FromType(typeof(ClassWithClassConstraint<>));
			var classWithClassNewConstraints = TypeDefinitionData.FromType(typeof(ClassWithClassNewConstraints<>));
			var classWithBaseInterfaceConstraint = TypeDefinitionData.FromType(typeof(ClassWithBaseInterfaceConstraint<>));
			var classWithDerivedInterfaceConstraint = TypeDefinitionData.FromType(typeof(ClassWithDerivedInterfaceConstraint<>));
			var classWithBaseTypeContraint = TypeDefinitionData.FromType(typeof(ClassWithBaseTypeContraint<>));
			
			var breakingChanges = MetadataComparer.CompareTypes(classWithNoConstraints, classWithNewConstraint);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(classWithNoConstraints.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(classWithNewConstraint.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(classWithNoConstraints, classWithStructConstraint);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(classWithNoConstraints.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(classWithStructConstraint.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(classWithNoConstraints, classWithClassConstraint);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(classWithNoConstraints.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(classWithClassConstraint.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(classWithNoConstraints, classWithClassNewConstraints);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(classWithNoConstraints.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(classWithClassNewConstraints.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(classWithNoConstraints, classWithBaseInterfaceConstraint);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(classWithNoConstraints.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(classWithBaseInterfaceConstraint.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(classWithNoConstraints, classWithDerivedInterfaceConstraint);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(classWithNoConstraints.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(classWithDerivedInterfaceConstraint.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(classWithNoConstraints, classWithBaseTypeContraint);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(classWithNoConstraints.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(classWithBaseTypeContraint.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			// Do the same tests in reverse order
			breakingChanges = MetadataComparer.CompareTypes(classWithNewConstraint, classWithNoConstraints);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(classWithNewConstraint.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(classWithNoConstraints.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(classWithStructConstraint, classWithNoConstraints);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(classWithStructConstraint.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(classWithNoConstraints.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(classWithClassConstraint, classWithNoConstraints);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(classWithClassConstraint.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(classWithNoConstraints.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(classWithClassNewConstraints, classWithNoConstraints);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(classWithClassNewConstraints.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(classWithNoConstraints.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(classWithBaseInterfaceConstraint, classWithNoConstraints);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(classWithBaseInterfaceConstraint.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(classWithNoConstraints.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(classWithDerivedInterfaceConstraint, classWithNoConstraints);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(classWithDerivedInterfaceConstraint.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(classWithNoConstraints.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(classWithBaseTypeContraint, classWithNoConstraints);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when type parameter constraints change.");
			Assert.AreEqual(BreakingChangeKind.ChangedGenericTypeParameterConstraints, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(classWithBaseTypeContraint.GenericParameters[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(classWithNoConstraints.GenericParameters[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // TypeTests

		public class NestedClassWithNoConstraints { public class Class<T> { } }
		public class NestedClassWithNewConstraint { public class Class<T> where T : new() { } }
		public class NestedClassWithStructConstraint { public class Class<T> where T : struct { } }
		public class NestedClassWithClassConstraint { public class Class<T> where T : class { } }
		public class NestedClassWithClassNewConstraints { public class Class<T> where T : class, new() { } }
		public class NestedClassWithBaseInterfaceConstraint { public class Class<T> where T : BaseInterface { } }
		public class NestedClassWithDerivedInterfaceConstraint { public class Class<T> where T : DerivedInterface { } }
		public class NestedClassWithBaseTypeContraint { public class Class<T> where T : Attribute { } }


		public class ClassWithNoConstraints<T> { }
		public class ClassWithNewConstraint<T> where T : new() { }
		public class ClassWithStructConstraint<T> where T : struct { }
		public class ClassWithClassConstraint<T> where T : class { }
		public class ClassWithClassNewConstraints<T> where T : class, new() { }
		public class ClassWithBaseInterfaceConstraint<T> where T : BaseInterface { }
		public class ClassWithDerivedInterfaceConstraint<T> where T : DerivedInterface { }
		public class ClassWithBaseTypeContraint<T> where T : Attribute { }

		public class MethodWithNoConstraints { public void Method<T>() { } }
		public class MethodWithNewConstraint { public void Method<T>() where T : new() { } }
		public class MethodWithStructConstraint { public void Method<T>() where T : struct { } }
		public class MethodWithClassConstraint { public void Method<T>() where T : class { } }
		public class MethodWithClassNewConstraints { public void Method<T>() where T : class, new() { } }
		public class MethodWithBaseInterfaceConstraint { public void Method<T>() where T : BaseInterface { } }
		public class MethodWithDerivedInterfaceConstraint { public void Method<T>() where T : DerivedInterface { } }
		public class MethodWithBaseTypeContraint { public void Method<T>() where T : Attribute { } }
	}
}
