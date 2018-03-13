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

using BreakingChangesDetector.BreakingChanges;
using BreakingChangesDetector.MetadataItems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.UnitTests.BreakingChangesTests
{
	[TestClass]
	public class ChangedAccessibilityFromPublicToProtectedTests
	{
		#region ConstantTests

		[TestMethod]
		public void ConstantTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var publicConstant = TypeDefinitionData.FromType(typeof(PublicConstant));
			var protectedConstant = TypeDefinitionData.FromType(typeof(ProtectedConstant));
			var protectedInternalConstant = TypeDefinitionData.FromType(typeof(ProtectedInternalConstant));
			
			var breakingChanges = MetadataComparer.CompareTypes(publicConstant, protectedConstant);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a constant is changed from public to protected");
			Assert.AreEqual(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(PublicConstant)).GetMember("Constant"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedConstant)).GetMember("Constant"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(publicConstant, protectedInternalConstant);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a constant is changed from public to protected internal");
			Assert.AreEqual(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(PublicConstant)).GetMember("Constant"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedInternalConstant)).GetMember("Constant"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(protectedConstant, publicConstant);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a constant is changed from protected to public");

			breakingChanges = MetadataComparer.CompareTypes(protectedConstant, protectedInternalConstant);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a constant is changed from protected to protected internal");

			breakingChanges = MetadataComparer.CompareTypes(protectedInternalConstant, publicConstant);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a constant is changed from protected internal to public");

			breakingChanges = MetadataComparer.CompareTypes(protectedInternalConstant, protectedConstant);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a constant is changed from protected internal to protected");
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
			
			var breakingChanges = MetadataComparer.CompareTypes(publicConstructor, protectedConstructor);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a constant is changed from public to protected");
			Assert.AreEqual(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(PublicConstructor)).GetMembers(".ctor")[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedConstructor)).GetMembers(".ctor")[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(publicConstructor, protectedInternalConstructor);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a constructor is changed from public to protected internal");
			Assert.AreEqual(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(PublicConstructor)).GetMembers(".ctor")[0], breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedInternalConstructor)).GetMembers(".ctor")[0], breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(protectedConstructor, publicConstructor);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a constructor is changed from protected to public");

			breakingChanges = MetadataComparer.CompareTypes(protectedConstructor, protectedInternalConstructor);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a constructor is changed from protected to protected internal");

			breakingChanges = MetadataComparer.CompareTypes(protectedInternalConstructor, publicConstructor);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a constructor is changed from protected internal to public");

			breakingChanges = MetadataComparer.CompareTypes(protectedInternalConstructor, protectedConstructor);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a constructor is changed from protected internal to protected");
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
			
			var breakingChanges = MetadataComparer.CompareTypes(publicEvent, protectedEvent);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a constant is changed from public to protected");
			Assert.AreEqual(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(PublicEvent)).GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedEvent)).GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(publicEvent, protectedInternalEvent);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a event is changed from public to protected internal");
			Assert.AreEqual(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(PublicEvent)).GetMember("Event"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedInternalEvent)).GetMember("Event"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(protectedEvent, publicEvent);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a event is changed from protected to public");

			breakingChanges = MetadataComparer.CompareTypes(protectedEvent, protectedInternalEvent);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a event is changed from protected to protected internal");

			breakingChanges = MetadataComparer.CompareTypes(protectedInternalEvent, publicEvent);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a event is changed from protected internal to public");

			breakingChanges = MetadataComparer.CompareTypes(protectedInternalEvent, protectedEvent);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a event is changed from protected internal to protected");
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
			
			var breakingChanges = MetadataComparer.CompareTypes(publicField, protectedField);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a constant is changed from public to protected");
			Assert.AreEqual(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(PublicField)).GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedField)).GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(publicField, protectedInternalField);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a field is changed from public to protected internal");
			Assert.AreEqual(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(PublicField)).GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedInternalField)).GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(protectedField, publicField);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a field is changed from protected to public");

			breakingChanges = MetadataComparer.CompareTypes(protectedField, protectedInternalField);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a field is changed from protected to protected internal");

			breakingChanges = MetadataComparer.CompareTypes(protectedInternalField, publicField);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a field is changed from protected internal to public");

			breakingChanges = MetadataComparer.CompareTypes(protectedInternalField, protectedField);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a field is changed from protected internal to protected");
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
			
			var breakingChanges = MetadataComparer.CompareTypes(publicIndexer, protectedIndexer);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a constant is changed from public to protected");
			Assert.AreEqual(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(PublicIndexer)).GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedIndexer)).GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(publicIndexer, protectedInternalIndexer);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a indexer is changed from public to protected internal");
			Assert.AreEqual(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(PublicIndexer)).GetMember("Item"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedInternalIndexer)).GetMember("Item"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(protectedIndexer, publicIndexer);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a indexer is changed from protected to public");

			breakingChanges = MetadataComparer.CompareTypes(protectedIndexer, protectedInternalIndexer);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a indexer is changed from protected to protected internal");

			breakingChanges = MetadataComparer.CompareTypes(protectedInternalIndexer, publicIndexer);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a indexer is changed from protected internal to public");

			breakingChanges = MetadataComparer.CompareTypes(protectedInternalIndexer, protectedIndexer);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a indexer is changed from protected internal to protected");
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
			
			var breakingChanges = MetadataComparer.CompareTypes(publicMethod, protectedMethod);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a constant is changed from public to protected");
			Assert.AreEqual(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(PublicMethod)).GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedMethod)).GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(publicMethod, protectedInternalMethod);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a method is changed from public to protected internal");
			Assert.AreEqual(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(PublicMethod)).GetMember("Method"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedInternalMethod)).GetMember("Method"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(protectedMethod, publicMethod);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a method is changed from protected to public");

			breakingChanges = MetadataComparer.CompareTypes(protectedMethod, protectedInternalMethod);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a method is changed from protected to protected internal");

			breakingChanges = MetadataComparer.CompareTypes(protectedInternalMethod, publicMethod);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a method is changed from protected internal to public");

			breakingChanges = MetadataComparer.CompareTypes(protectedInternalMethod, protectedMethod);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a method is changed from protected internal to protected");
		}

		#endregion // MethodTests

		#region PropertyTests

		[TestMethod]
		public void PropertyTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var publicProperty = TypeDefinitionData.FromType(typeof(PublicProperty));
			var protectedProperty = TypeDefinitionData.FromType(typeof(ProtectedProperty));
			var protectedInternalProperty = TypeDefinitionData.FromType(typeof(ProtectedInternalProperty));
			
			var breakingChanges = MetadataComparer.CompareTypes(publicProperty, protectedProperty);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a constant is changed from public to protected");
			Assert.AreEqual(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(PublicProperty)).GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedProperty)).GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(publicProperty, protectedInternalProperty);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a property is changed from public to protected internal");
			Assert.AreEqual(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(PublicProperty)).GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedInternalProperty)).GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(protectedProperty, publicProperty);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a property is changed from protected to public");

			breakingChanges = MetadataComparer.CompareTypes(protectedProperty, protectedInternalProperty);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a property is changed from protected to protected internal");

			breakingChanges = MetadataComparer.CompareTypes(protectedInternalProperty, publicProperty);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a property is changed from protected internal to public");

			breakingChanges = MetadataComparer.CompareTypes(protectedInternalProperty, protectedProperty);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a property is changed from protected internal to protected");
		}

		#endregion // PropertyTests

		#region TypeTests

		[TestMethod]
		public void TypeTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedAccessibilityFromPublicToProtectedTests).Assembly);
			var publicNestedType = TypeDefinitionData.FromType(typeof(PublicNestedType));
			var protectedNestedType = TypeDefinitionData.FromType(typeof(ProtectedNestedType));
			var protectedInternalNestedType = TypeDefinitionData.FromType(typeof(ProtectedInternalNestedType));
			
			var breakingChanges = MetadataComparer.CompareTypes(publicNestedType, protectedNestedType);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a nested type is changed from public to protected");
			Assert.AreEqual(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(PublicNestedType.NestedType)), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedNestedType)).GetMember("NestedType"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(publicNestedType, protectedInternalNestedType);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when a nested type is changed from public to protected internal");
			Assert.AreEqual(BreakingChangeKind.ChangedAccessibilityFromPublicToProtected, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(PublicNestedType.NestedType)), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(TypeDefinitionData.FromType(typeof(ProtectedInternalNestedType.NestedType)), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(protectedNestedType, publicNestedType);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a nested type is changed from protected to public");

			breakingChanges = MetadataComparer.CompareTypes(protectedNestedType, protectedInternalNestedType);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a nested type is changed from protected to protected internal");

			breakingChanges = MetadataComparer.CompareTypes(protectedInternalNestedType, publicNestedType);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a nested type is changed from protected internal to public");

			breakingChanges = MetadataComparer.CompareTypes(protectedInternalNestedType, protectedNestedType);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when a nested type is changed from protected internal to protected");
		}

		#endregion // TypeTests
	}
}
