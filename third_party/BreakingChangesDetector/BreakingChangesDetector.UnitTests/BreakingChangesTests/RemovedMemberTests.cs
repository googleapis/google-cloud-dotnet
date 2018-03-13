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
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreakingChangesDetector.MetadataItems;
using BreakingChangesDetector.BreakingChanges;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
	[TestClass]
	public class RemovedMemberTests
	{
		#region ChangeConstantToFieldTest

		[TestMethod]
		public void ChangeConstantToFieldTest()
		{
			var assembly = AssemblyData.FromAssembly(typeof(RemovedMemberTests).Assembly);
			var ClassWithConstant = TypeDefinitionData.FromType(typeof(ClassWithConstant));
			var ClassWithStaticReadOnlyField = TypeDefinitionData.FromType(typeof(ClassWithStaticReadOnlyField));
			var ClassWithStaticReadWriteField = TypeDefinitionData.FromType(typeof(ClassWithStaticReadWriteField));
			var ClassWithReadOnlyField = TypeDefinitionData.FromType(typeof(ClassWithReadOnlyField));
			var ClassWithReadWriteField = TypeDefinitionData.FromType(typeof(ClassWithReadWriteField));
			
			var breakingChanges = MetadataComparer.CompareTypes(ClassWithConstant, ClassWithStaticReadOnlyField);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a constant is changed to a read-only static field.");

			breakingChanges = MetadataComparer.CompareTypes(ClassWithConstant, ClassWithStaticReadWriteField);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a constant is changed to a read-write static field.");

			breakingChanges = MetadataComparer.CompareTypes(ClassWithConstant, ClassWithReadOnlyField);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a constant is changed to a read-only instance field.");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithConstant.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithReadOnlyField, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ClassWithConstant, ClassWithReadWriteField);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a constant is changed to a read-write instance field.");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithConstant.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithReadWriteField, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // ChangeConstantToFieldTest

		#region ChangeConstantToPropertyTest

		[TestMethod]
		public void ChangeConstantToPropertyTest()
		{
			var assembly = AssemblyData.FromAssembly(typeof(RemovedMemberTests).Assembly);
			var ClassWithConstant = TypeDefinitionData.FromType(typeof(ClassWithConstant));
			var ClassWithReadOnlyProperty = TypeDefinitionData.FromType(typeof(ClassWithReadOnlyProperty));
			var ClassWithStaticReadOnlyProperty = TypeDefinitionData.FromType(typeof(ClassWithStaticReadOnlyProperty));
			var ClassWithStaticReadOnlyProtectedProperty = TypeDefinitionData.FromType(typeof(ClassWithStaticReadOnlyProtectedProperty));
			var ClassWithStaticProtectedGetProperty = TypeDefinitionData.FromType(typeof(ClassWithStaticProtectedGetProperty));
			
			var breakingChanges = MetadataComparer.CompareTypes(ClassWithConstant, ClassWithReadOnlyProperty);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a constant is changed to an instance property");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithConstant.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithReadOnlyProperty, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ClassWithConstant, ClassWithStaticReadOnlyProperty);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a constant is changed to a static property with compatible access.");

			breakingChanges = MetadataComparer.CompareTypes(ClassWithConstant, ClassWithStaticReadOnlyProtectedProperty);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a constant is changed to a protected property.");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithConstant.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithStaticReadOnlyProtectedProperty, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ClassWithConstant, ClassWithStaticProtectedGetProperty);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a constant is changed to a public property with a protected get accessor.");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithConstant.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithStaticProtectedGetProperty, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // ChangeConstantToPropertyTest

		#region ChangeExplicitToImplicitMemberTests

		[TestMethod]
		public void ChangeExplicitToImplicitMemberTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(RemovedMemberTests).Assembly);
			var ExplicitInterfaceMember = TypeDefinitionData.FromType(typeof(ExplicitInterfaceMember));
			var ImplicitInterfaceMember = TypeDefinitionData.FromType(typeof(ImplicitInterfaceMember));
			
			var breakingChanges = MetadataComparer.CompareTypes(ImplicitInterfaceMember, ExplicitInterfaceMember);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an implicit interface member is changed to explicit");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ImplicitInterfaceMember.GetMember("Equals"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ExplicitInterfaceMember, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ExplicitInterfaceMember, ImplicitInterfaceMember);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an explicit interface member is changed to implicit");
		}

		#endregion // ChangeExplicitToImplicitMemberTests

		#region ChangeFieldToConstantTest

		[TestMethod]
		public void ChangeFieldToConstantTest()
		{
			var assembly = AssemblyData.FromAssembly(typeof(RemovedMemberTests).Assembly);
			var ClassWithConstant = TypeDefinitionData.FromType(typeof(ClassWithConstant));
			var ClassWithStaticReadOnlyField = TypeDefinitionData.FromType(typeof(ClassWithStaticReadOnlyField));
			var ClassWithStaticReadWriteField = TypeDefinitionData.FromType(typeof(ClassWithStaticReadWriteField));
			var ClassWithReadOnlyField = TypeDefinitionData.FromType(typeof(ClassWithReadOnlyField));
			var ClassWithReadWriteField = TypeDefinitionData.FromType(typeof(ClassWithReadWriteField));
			
			var breakingChanges = MetadataComparer.CompareTypes(ClassWithStaticReadOnlyField, ClassWithConstant);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a read-only static field is changed to a constant");

			breakingChanges = MetadataComparer.CompareTypes(ClassWithStaticReadWriteField, ClassWithConstant);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a read-write static is changed to a constant");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithStaticReadWriteField.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithConstant, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyField, ClassWithConstant);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a read-only instance is changed to a constant");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithReadOnlyField.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithConstant, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ClassWithReadWriteField, ClassWithConstant);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a read-write instance is changed to a constant");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithReadWriteField.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithConstant, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // ChangeFieldToConstantTest

		#region ChangeFieldToPropertyTest

		[TestMethod]
		public void ChangeFieldToPropertyTest()
		{
            var assembly = AssemblyData.FromAssembly(typeof(RemovedMemberTests).Assembly);
            var ClassWithReadOnlyField = TypeDefinitionData.FromType(typeof(ClassWithReadOnlyField));
            var ClassWithReadWriteField = TypeDefinitionData.FromType(typeof(ClassWithReadWriteField));
            var ClassWithReadOnlyProperty = TypeDefinitionData.FromType(typeof(ClassWithReadOnlyProperty));
            var ClassWithReadWriteProperty = TypeDefinitionData.FromType(typeof(ClassWithReadWriteProperty));
            var ClassWithWriteOnlyProperty = TypeDefinitionData.FromType(typeof(ClassWithWriteOnlyProperty));
            var ClassWithVirtualProperty = TypeDefinitionData.FromType(typeof(ClassWithVirtualProperty));
            var ClassWithSealedOverrideProperty = TypeDefinitionData.FromType(typeof(ClassWithSealedOverrideProperty));
            var ClassWithStaticReadOnlyField = TypeDefinitionData.FromType(typeof(ClassWithStaticReadOnlyField));
            var ClassWithStaticReadOnlyProperty = TypeDefinitionData.FromType(typeof(ClassWithStaticReadOnlyProperty));
            var ClassWithReadOnlyProtectedField = TypeDefinitionData.FromType(typeof(ClassWithReadOnlyProtectedField));
			var ClassWithReadOnlyProtectedProperty = TypeDefinitionData.FromType(typeof(ClassWithReadOnlyProtectedProperty));
			var ClassWithProtectedGetProperty = TypeDefinitionData.FromType(typeof(ClassWithProtectedGetProperty));
            
            var breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyField, ClassWithReadOnlyProperty);
            Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a property is changed to a field with compatible access");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadWriteField, ClassWithReadOnlyProperty);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a read/write field is changed to a property");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithReadWriteField.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithReadOnlyProperty, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyField, ClassWithReadWriteProperty);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a read-only field is changed to a property with compatible access");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadWriteField, ClassWithReadWriteProperty);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a read/write field is changed to a property");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithReadWriteField.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithReadWriteProperty, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyField, ClassWithWriteOnlyProperty);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a read-only field is changed to a write-only property.");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithReadOnlyField.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithWriteOnlyProperty, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadWriteField, ClassWithWriteOnlyProperty);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a read/write field is changed to a property");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithReadWriteField.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithWriteOnlyProperty, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyField, ClassWithVirtualProperty);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a read-only field is changed to a virtual property.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyField, ClassWithSealedOverrideProperty);
            breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.RemovedMember).ToList();
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a read-only field is changed to a sealed override property.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithStaticReadOnlyField, ClassWithStaticReadOnlyProperty);
            Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a read-only field is changed to a property with compatible access.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithStaticReadOnlyField, ClassWithReadOnlyProperty);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a read-only static field is changed to an instance property.");
            Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithStaticReadOnlyField.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithReadOnlyProperty, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyField, ClassWithStaticReadOnlyProperty);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a read-only instance field is changed to a static property.");
            Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithReadOnlyField.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithStaticReadOnlyProperty, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyField, ClassWithReadOnlyProtectedProperty);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a read-only public field is changed to a protected property.");
            Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithReadOnlyField.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithReadOnlyProtectedProperty, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyField, ClassWithProtectedGetProperty);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a read-only public field is changed to a public property with a protected get accessor.");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithReadOnlyField.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithProtectedGetProperty, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // ChangeFieldToPropertyTest

		#region ChangePropertyToConstantTest

		[TestMethod]
		public void ChangePropertyToConstantTest()
		{
			var assembly = AssemblyData.FromAssembly(typeof(RemovedMemberTests).Assembly);
			var ClassWithConstant = TypeDefinitionData.FromType(typeof(ClassWithConstant));
			var ClassWithReadOnlyProperty = TypeDefinitionData.FromType(typeof(ClassWithReadOnlyProperty));
			var ClassWithReadWriteProperty = TypeDefinitionData.FromType(typeof(ClassWithReadWriteProperty));
			var ClassWithWriteOnlyProperty = TypeDefinitionData.FromType(typeof(ClassWithWriteOnlyProperty));
			var ClassWithStaticReadOnlyProperty = TypeDefinitionData.FromType(typeof(ClassWithStaticReadOnlyProperty));
			var ClassWithStaticReadWriteProperty = TypeDefinitionData.FromType(typeof(ClassWithStaticReadWriteProperty));
			var ClassWithStaticWriteOnlyProperty = TypeDefinitionData.FromType(typeof(ClassWithStaticWriteOnlyProperty));
			
			var breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyProperty, ClassWithConstant);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a read-only instance property is changed to a constant");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithReadOnlyProperty.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithConstant, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ClassWithReadWriteProperty, ClassWithConstant);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a read-write instance property is changed to a constant");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithReadWriteProperty.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithConstant, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ClassWithWriteOnlyProperty, ClassWithConstant);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a write-only instance property is changed to a constant");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithWriteOnlyProperty.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithConstant, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ClassWithStaticReadOnlyProperty, ClassWithConstant);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a read-only static property is changed to a constant");

			breakingChanges = MetadataComparer.CompareTypes(ClassWithStaticReadWriteProperty, ClassWithConstant);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a read-write static property is changed to a constant");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithStaticReadWriteProperty.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithConstant, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(ClassWithStaticWriteOnlyProperty, ClassWithConstant);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a write-only static property is changed to a constant");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithStaticWriteOnlyProperty.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithConstant, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // ChangePropertyToConstantTest

		#region ChangePropertyToFieldTest

		[TestMethod]
		public void ChangePropertyToFieldTest()
		{
            var assembly = AssemblyData.FromAssembly(typeof(RemovedMemberTests).Assembly);
            var ClassWithReadOnlyField = TypeDefinitionData.FromType(typeof(ClassWithReadOnlyField));
            var ClassWithReadWriteField = TypeDefinitionData.FromType(typeof(ClassWithReadWriteField));
            var ClassWithReadOnlyProperty = TypeDefinitionData.FromType(typeof(ClassWithReadOnlyProperty));
            var ClassWithReadWriteProperty = TypeDefinitionData.FromType(typeof(ClassWithReadWriteProperty));
            var ClassWithWriteOnlyProperty = TypeDefinitionData.FromType(typeof(ClassWithWriteOnlyProperty));
            var ClassWithVirtualProperty = TypeDefinitionData.FromType(typeof(ClassWithVirtualProperty));
            var ClassWithSealedOverrideProperty = TypeDefinitionData.FromType(typeof(ClassWithSealedOverrideProperty));
            var ClassWithStaticReadOnlyField = TypeDefinitionData.FromType(typeof(ClassWithStaticReadOnlyField));
            var ClassWithStaticReadOnlyProperty = TypeDefinitionData.FromType(typeof(ClassWithStaticReadOnlyProperty));
            var ClassWithReadOnlyProtectedField = TypeDefinitionData.FromType(typeof(ClassWithReadOnlyProtectedField));
            
            var breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyProperty, ClassWithReadOnlyField);
            Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a property is changed to a field with compatible access");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyProperty, ClassWithReadWriteField);
            Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a property is changed to a field with compatible access");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadWriteProperty, ClassWithReadOnlyField);
            Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a property is changed to a field but the field has more restricted access");
            Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithReadWriteProperty.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
            Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithReadOnlyField, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadWriteProperty, ClassWithReadWriteField);
            Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a property is changed to a field with compatible access");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithWriteOnlyProperty, ClassWithReadOnlyField);
            Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a property is changed to a field but the field has more restricted access");
            Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithWriteOnlyProperty.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithReadOnlyField, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithWriteOnlyProperty, ClassWithReadWriteField);
            Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a property is changed to a field with compatible access");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithVirtualProperty, ClassWithReadOnlyField);
            Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a virtual property is changed to a field");
            Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithVirtualProperty.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithReadOnlyField, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithSealedOverrideProperty, ClassWithReadOnlyField);
            breakingChanges = breakingChanges.Where(b => b.BreakingChangeKind == BreakingChangeKind.RemovedMember).ToList();
            Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a virtual property is changed to a field");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithStaticReadOnlyProperty, ClassWithStaticReadOnlyField);
            Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a property is changed to a field with compatible access");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyProperty, ClassWithStaticReadOnlyField);
            Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when an instance property is changed to a static field");
            Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithReadOnlyProperty.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithStaticReadOnlyField, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithStaticReadOnlyProperty, ClassWithReadOnlyField);
            Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a static property is changed to an instance field");
            Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithStaticReadOnlyProperty.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithReadOnlyField, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

            breakingChanges = MetadataComparer.CompareTypes(ClassWithReadOnlyProperty, ClassWithReadOnlyProtectedField);
            Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a public property is changed to a protected field");
            Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(ClassWithReadOnlyProperty.GetMember("Data"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(ClassWithReadOnlyProtectedField, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // ChangePropertyToFieldTest

		#region ConstantTests

		[TestMethod]
		public void ConstantTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var publicConstant = TypeDefinitionData.FromType(typeof(PublicConstant));
			var protectedConstant = TypeDefinitionData.FromType(typeof(ProtectedConstant));
			var protectedInternalConstant = TypeDefinitionData.FromType(typeof(ProtectedInternalConstant));
			var internalConstant = TypeDefinitionData.FromType(typeof(InternalConstant));
			var privateConstant = TypeDefinitionData.FromType(typeof(PrivateConstant));
			var noConstant = TypeDefinitionData.FromType(typeof(NoConstant));
			
			var breakingChanges = MetadataComparer.CompareTypes(publicConstant, noConstant);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a public constant is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(PublicConstant)).GetMember("Constant"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NoConstant)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(protectedConstant, noConstant);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a protected constant is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedConstant)).GetMember("Constant"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NoConstant)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(protectedInternalConstant, noConstant);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a protected internal constant is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedInternalConstant)).GetMember("Constant"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NoConstant)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(internalConstant, noConstant);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an internal constant is removed");
			breakingChanges = MetadataComparer.CompareTypes(privateConstant, noConstant);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a private constant is removed");

			breakingChanges = MetadataComparer.CompareTypes(noConstant, publicConstant);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a public constant is added");
			breakingChanges = MetadataComparer.CompareTypes(noConstant, protectedConstant);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected constant is added");
			breakingChanges = MetadataComparer.CompareTypes(noConstant, protectedInternalConstant);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected internal constant is added");
			breakingChanges = MetadataComparer.CompareTypes(noConstant, internalConstant);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected internal constant is added");
			breakingChanges = MetadataComparer.CompareTypes(noConstant, privateConstant);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected internal constant is added");

			var EnumWithTwoMembers = TypeDefinitionData.FromType(typeof(EnumWithTwoMembers));
			var EnumWithOneMember = TypeDefinitionData.FromType(typeof(EnumWithOneMember));
			breakingChanges = MetadataComparer.CompareTypes(EnumWithTwoMembers, EnumWithOneMember);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a public constant is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(EnumWithTwoMembers.GetMember("Y"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(EnumWithOneMember, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(EnumWithOneMember, EnumWithTwoMembers);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a public constant is added");
		}

		#endregion // ConstantTests

		#region ConstructorTests

		[TestMethod]
		public void ConstructorTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var publicConstructor = TypeDefinitionData.FromType(typeof(PublicConstructor));
			var protectedConstructor = TypeDefinitionData.FromType(typeof(ProtectedConstructor));
			var protectedInternalConstructor = TypeDefinitionData.FromType(typeof(ProtectedInternalConstructor));
			var internalConstructor = TypeDefinitionData.FromType(typeof(InternalConstructor));
			var privateConstructor = TypeDefinitionData.FromType(typeof(PrivateConstructor));
			var noConstructor = TypeDefinitionData.FromType(typeof(NoConstructor));
			
			var breakingChanges = MetadataComparer.CompareTypes(publicConstructor, noConstructor);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a public constructor is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(PublicConstructor)).GetMembers(".ctor")[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NoConstructor)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(protectedConstructor, noConstructor);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a protected constructor is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedConstructor)).GetMembers(".ctor")[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NoConstructor)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(protectedInternalConstructor, noConstructor);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a protected internal constructor is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedInternalConstructor)).GetMembers(".ctor")[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NoConstructor)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(internalConstructor, noConstructor);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an internal constructor is removed");
			breakingChanges = MetadataComparer.CompareTypes(privateConstructor, noConstructor);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a private constructor is removed");

			breakingChanges = MetadataComparer.CompareTypes(noConstructor, publicConstructor);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a public constructor is added");
			breakingChanges = MetadataComparer.CompareTypes(noConstructor, protectedConstructor);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected constructor is added");
			breakingChanges = MetadataComparer.CompareTypes(noConstructor, protectedInternalConstructor);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected internal constructor is added");
			breakingChanges = MetadataComparer.CompareTypes(noConstructor, internalConstructor);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected internal constructor is added");
			breakingChanges = MetadataComparer.CompareTypes(noConstructor, privateConstructor);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected internal constructor is added");
		}

		#endregion // ConstructorTests

		#region EventTests

		[TestMethod]
		public void EventTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var publicEvent = TypeDefinitionData.FromType(typeof(PublicEvent));
			var protectedEvent = TypeDefinitionData.FromType(typeof(ProtectedEvent));
			var protectedInternalEvent = TypeDefinitionData.FromType(typeof(ProtectedInternalEvent));
			var internalEvent = TypeDefinitionData.FromType(typeof(InternalEvent));
			var privateEvent = TypeDefinitionData.FromType(typeof(PrivateEvent));
			var noEvent = TypeDefinitionData.FromType(typeof(NoEvent));
			
			var breakingChanges = MetadataComparer.CompareTypes(publicEvent, noEvent);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a public event is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(PublicEvent)).GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NoEvent)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(protectedEvent, noEvent);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a protected event is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedEvent)).GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NoEvent)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(protectedInternalEvent, noEvent);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a protected internal event is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedInternalEvent)).GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NoEvent)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(internalEvent, noEvent);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an internal event is removed");
			breakingChanges = MetadataComparer.CompareTypes(privateEvent, noEvent);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a private event is removed");

			breakingChanges = MetadataComparer.CompareTypes(noEvent, publicEvent);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a public event is added");
			breakingChanges = MetadataComparer.CompareTypes(noEvent, protectedEvent);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected event is added");
			breakingChanges = MetadataComparer.CompareTypes(noEvent, protectedInternalEvent);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected internal event is added");
			breakingChanges = MetadataComparer.CompareTypes(noEvent, internalEvent);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected internal event is added");
			breakingChanges = MetadataComparer.CompareTypes(noEvent, privateEvent);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected internal event is added");
		}

		#endregion // EventTests

		#region FieldTests

		[TestMethod]
		public void FieldTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var publicField = TypeDefinitionData.FromType(typeof(PublicField));
			var protectedField = TypeDefinitionData.FromType(typeof(ProtectedField));
			var protectedInternalField = TypeDefinitionData.FromType(typeof(ProtectedInternalField));
			var internalField = TypeDefinitionData.FromType(typeof(InternalField));
			var privateField = TypeDefinitionData.FromType(typeof(PrivateField));
			var noField = TypeDefinitionData.FromType(typeof(NoField));
			
			var breakingChanges = MetadataComparer.CompareTypes(publicField, noField);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a public field is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(PublicField)).GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NoField)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(protectedField, noField);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a protected field is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedField)).GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NoField)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(protectedInternalField, noField);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a protected internal field is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedInternalField)).GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NoField)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(internalField, noField);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an internal field is removed");
			breakingChanges = MetadataComparer.CompareTypes(privateField, noField);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a private field is removed");

			breakingChanges = MetadataComparer.CompareTypes(noField, publicField);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a public field is added");
			breakingChanges = MetadataComparer.CompareTypes(noField, protectedField);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected field is added");
			breakingChanges = MetadataComparer.CompareTypes(noField, protectedInternalField);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected internal field is added");
			breakingChanges = MetadataComparer.CompareTypes(noField, internalField);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected internal field is added");
			breakingChanges = MetadataComparer.CompareTypes(noField, privateField);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected internal field is added");
		}

		#endregion // FieldTests

		#region IndexerTests

		[TestMethod]
		public void IndexerTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var publicIndexer = TypeDefinitionData.FromType(typeof(PublicIndexer));
			var protectedIndexer = TypeDefinitionData.FromType(typeof(ProtectedIndexer));
			var protectedInternalIndexer = TypeDefinitionData.FromType(typeof(ProtectedInternalIndexer));
			var internalIndexer = TypeDefinitionData.FromType(typeof(InternalIndexer));
			var privateIndexer = TypeDefinitionData.FromType(typeof(PrivateIndexer));
			var noIndexer = TypeDefinitionData.FromType(typeof(NoIndexer));
			
			var breakingChanges = MetadataComparer.CompareTypes(publicIndexer, noIndexer);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a public indexer is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(PublicIndexer)).GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NoIndexer)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(protectedIndexer, noIndexer);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a protected indexer is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedIndexer)).GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NoIndexer)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(protectedInternalIndexer, noIndexer);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a protected internal indexer is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedInternalIndexer)).GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NoIndexer)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(internalIndexer, noIndexer);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an internal indexer is removed");
			breakingChanges = MetadataComparer.CompareTypes(privateIndexer, noIndexer);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a private indexer is removed");

			breakingChanges = MetadataComparer.CompareTypes(noIndexer, publicIndexer);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a public indexer is added");
			breakingChanges = MetadataComparer.CompareTypes(noIndexer, protectedIndexer);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected indexer is added");
			breakingChanges = MetadataComparer.CompareTypes(noIndexer, protectedInternalIndexer);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected internal indexer is added");
			breakingChanges = MetadataComparer.CompareTypes(noIndexer, internalIndexer);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected internal indexer is added");
			breakingChanges = MetadataComparer.CompareTypes(noIndexer, privateIndexer);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected internal indexer is added");
		}

		#endregion // IndexerTests

		#region MethodTests

		[TestMethod]
		public void MethodTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var publicMethod = TypeDefinitionData.FromType(typeof(PublicMethod));
			var protectedMethod = TypeDefinitionData.FromType(typeof(ProtectedMethod));
			var protectedInternalMethod = TypeDefinitionData.FromType(typeof(ProtectedInternalMethod));
			var internalMethod = TypeDefinitionData.FromType(typeof(InternalMethod));
			var privateMethod = TypeDefinitionData.FromType(typeof(PrivateMethod));
			var noMethod = TypeDefinitionData.FromType(typeof(NoMethod));
			
			var breakingChanges = MetadataComparer.CompareTypes(publicMethod, noMethod);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a public method is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(PublicMethod)).GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NoMethod)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(protectedMethod, noMethod);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a protected method is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedMethod)).GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NoMethod)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(protectedInternalMethod, noMethod);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a protected internal method is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedInternalMethod)).GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NoMethod)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(internalMethod, noMethod);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an internal method is removed");
			breakingChanges = MetadataComparer.CompareTypes(privateMethod, noMethod);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a private method is removed");

			breakingChanges = MetadataComparer.CompareTypes(noMethod, publicMethod);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a public method is added");
			breakingChanges = MetadataComparer.CompareTypes(noMethod, protectedMethod);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected method is added");
			breakingChanges = MetadataComparer.CompareTypes(noMethod, protectedInternalMethod);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected internal method is added");
			breakingChanges = MetadataComparer.CompareTypes(noMethod, internalMethod);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected internal method is added");
			breakingChanges = MetadataComparer.CompareTypes(noMethod, privateMethod);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected internal method is added");

			var InterfaceWithMethod = TypeDefinitionData.FromType(typeof(InterfaceWithMethod));
			var InterfaceWithoutMethod = TypeDefinitionData.FromType(typeof(InterfaceWithoutMethod));
			breakingChanges = MetadataComparer.CompareTypes(InterfaceWithMethod, InterfaceWithoutMethod);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a public method is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(InterfaceWithMethod.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(InterfaceWithoutMethod, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(InterfaceWithoutMethod, InterfaceWithMethod).Where(b => b.BreakingChangeKind == BreakingChangeKind.RemovedMember).ToList();
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a public method is added");

			var StructWithMethod = TypeDefinitionData.FromType(typeof(StructWithMethod));
			var StructWithoutMethod = TypeDefinitionData.FromType(typeof(StructWithoutMethod));
			breakingChanges = MetadataComparer.CompareTypes(StructWithMethod, StructWithoutMethod);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a public method is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(StructWithMethod.GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(StructWithoutMethod, breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(StructWithoutMethod, StructWithMethod);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a public method is added");

			var DerivedClassWithMethod = TypeDefinitionData.FromType(typeof(DerivedClassWithMethod));
			breakingChanges = MetadataComparer.CompareTypes(publicMethod, DerivedClassWithMethod);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a public method is added");
		}

		public class BaseClassWithMethod { public void Method() { } }
		public class DerivedClassWithMethod : BaseClassWithMethod { }

		#endregion // MethodTests

		#region OperatorTests

		[TestMethod]
		public void OperatorTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var publicOperator = TypeDefinitionData.FromType(typeof(PublicOperator));
			var noOperator = TypeDefinitionData.FromType(typeof(NoOperator));
			
			var breakingChanges = MetadataComparer.CompareTypes(publicOperator, noOperator);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a public operator is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(PublicOperator)).GetMember("op_Addition"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NoOperator)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(noOperator, publicOperator);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a public operator is added");
		}

		#endregion // OperatorTests

		#region RemovingOverrideInNonBreaking

		[TestMethod]
		public void RemovingOverrideInNonBreaking()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var ClassWithOverride = TypeDefinitionData.FromType(typeof(ClassWithOverride));
			var ClassWithoutOverride = TypeDefinitionData.FromType(typeof(ClassWithoutOverride));
			
			var breakingChanges = MetadataComparer.CompareTypes(ClassWithOverride, ClassWithoutOverride);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when removing an override of a virtual method");
		}

		#endregion // RemovingOverrideInNonBreaking

		#region PropertyTests

		[TestMethod]
		public void PropertyTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var publicProperty = TypeDefinitionData.FromType(typeof(PublicProperty));
			var protectedProperty = TypeDefinitionData.FromType(typeof(ProtectedProperty));
			var protectedInternalProperty = TypeDefinitionData.FromType(typeof(ProtectedInternalProperty));
			var internalProperty = TypeDefinitionData.FromType(typeof(InternalProperty));
			var privateProperty = TypeDefinitionData.FromType(typeof(PrivateProperty));
			var noProperty = TypeDefinitionData.FromType(typeof(NoProperty));
			
			var breakingChanges = MetadataComparer.CompareTypes(publicProperty, noProperty);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a public property is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(PublicProperty)).GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NoProperty)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(protectedProperty, noProperty);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a protected property is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedProperty)).GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NoProperty)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(protectedInternalProperty, noProperty);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a protected internal property is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedInternalProperty)).GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NoProperty)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(internalProperty, noProperty);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an internal property is removed");
			breakingChanges = MetadataComparer.CompareTypes(privateProperty, noProperty);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a private property is removed");

			breakingChanges = MetadataComparer.CompareTypes(noProperty, publicProperty);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a public property is added");
			breakingChanges = MetadataComparer.CompareTypes(noProperty, protectedProperty);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected property is added");
			breakingChanges = MetadataComparer.CompareTypes(noProperty, protectedInternalProperty);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected internal property is added");
			breakingChanges = MetadataComparer.CompareTypes(noProperty, internalProperty);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected internal property is added");
			breakingChanges = MetadataComparer.CompareTypes(noProperty, privateProperty);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected internal property is added");
		}

		#endregion // PropertyTests

		#region NestedTypeTests

		[TestMethod]
		public void NestedTypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var publicNestedType = TypeDefinitionData.FromType(typeof(PublicNestedType));
			var protectedNestedType = TypeDefinitionData.FromType(typeof(ProtectedNestedType));
			var protectedInternalNestedType = TypeDefinitionData.FromType(typeof(ProtectedInternalNestedType));
			var internalNestedType = TypeDefinitionData.FromType(typeof(InternalNestedType));
			var privateNestedType = TypeDefinitionData.FromType(typeof(PrivateNestedType));
			var noNestedType = TypeDefinitionData.FromType(typeof(NoNestedType));
			
			var breakingChanges = MetadataComparer.CompareTypes(publicNestedType, noNestedType);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a public nested type is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(PublicNestedType)).GetMember("NestedType"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NoNestedType)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(protectedNestedType, noNestedType);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a protected nested type is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedNestedType)).GetMember("NestedType"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NoNestedType)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(protectedInternalNestedType, noNestedType);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a protected internal nested type is removed");
			Assert.AreEqual(BreakingChangeKind.RemovedMember, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedInternalNestedType)).GetMember("NestedType"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.IsNull(breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(NoNestedType)), breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(internalNestedType, noNestedType);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when an internal nested type is removed");
			breakingChanges = MetadataComparer.CompareTypes(privateNestedType, noNestedType);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a private nested type is removed");

			breakingChanges = MetadataComparer.CompareTypes(noNestedType, publicNestedType);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a public nested type is added");
			breakingChanges = MetadataComparer.CompareTypes(noNestedType, protectedNestedType);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected nested type is added");
			breakingChanges = MetadataComparer.CompareTypes(noNestedType, protectedInternalNestedType);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected internal nested type is added");
			breakingChanges = MetadataComparer.CompareTypes(noNestedType, internalNestedType);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected internal nested type is added");
			breakingChanges = MetadataComparer.CompareTypes(noNestedType, privateNestedType);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a protected internal nested type is added");
		}

		#endregion // NestedTypeTests


		public class ExplicitInterfaceMember : IEquatable<int> { bool IEquatable<int>.Equals(int other) { return false; } }
		public class ImplicitInterfaceMember : IEquatable<int> { public bool Equals(int other) { return false; } }

		public class ClassWithOverride { public override string ToString() { return "X"; } }
		public class ClassWithoutOverride { }

		public enum EnumWithTwoMembers { X, Y }
		public enum EnumWithOneMember { X }

		public interface InterfaceWithMethod { void Method(); }
		public interface InterfaceWithoutMethod { }

		public struct StructWithMethod { public void Method() { } }
		public struct StructWithoutMethod { }



		public class ClassWithConstant { public const int Data = 0; }

		public class ClassWithReadOnlyField { public readonly int Data; }
		public class ClassWithReadWriteField { public int Data; }
		public class ClassWithReadOnlyProperty { public int Data { get { return 0; } } }
		public class ClassWithReadWriteProperty { public int Data { get; set; } }
		public class ClassWithWriteOnlyProperty { public int Data { set { } } }
		public class ClassWithVirtualProperty { public virtual int Data { get { return 0; } } }
		public class ClassWithSealedOverrideProperty : ClassWithVirtualProperty { public sealed override int Data { get { return 0; } } }

		public class ClassWithStaticReadOnlyField { public static readonly int Data; }
		public class ClassWithStaticReadWriteField { public static int Data; }
		public class ClassWithStaticReadOnlyProperty { public static int Data { get { return 0; } } }
		public class ClassWithStaticReadWriteProperty { public static int Data { get; set; } }
		public class ClassWithStaticWriteOnlyProperty { public static int Data { set { } } }

		public class ClassWithReadOnlyProtectedField { protected readonly int Data; }
		public class ClassWithReadOnlyProtectedProperty { protected int Data { get { return 0; } } }
		public class ClassWithProtectedGetProperty { public int Data { protected get; set; } }

		public class ClassWithStaticReadOnlyProtectedProperty { protected static int Data { get { return 0; } } }
		public class ClassWithStaticProtectedGetProperty { public static int Data { protected get; set; } }
	}
}
