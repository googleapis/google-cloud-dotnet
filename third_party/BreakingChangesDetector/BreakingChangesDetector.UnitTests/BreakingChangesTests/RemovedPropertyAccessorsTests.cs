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
	public class RemovedPropertyAccessorsTests
	{
		#region PropertyTests

		[TestMethod]
		public void PropertyTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedMemberTypeTests).Assembly);
			var PropertyReadOnly = TypeDefinitionData.FromType(typeof(PropertyReadOnly));
			var PropertyReadOnlyPublic = TypeDefinitionData.FromType(typeof(PropertyReadOnlyPublic));
			var PropertyReadWrite = TypeDefinitionData.FromType(typeof(PropertyReadWrite));
			var PropertyWriteOnly = TypeDefinitionData.FromType(typeof(PropertyWriteOnly));
			var PropertyWriteOnlyPublic = TypeDefinitionData.FromType(typeof(PropertyWriteOnlyPublic));
			
			var breakingChanges = MetadataComparer.CompareTypes(PropertyReadWrite, PropertyReadOnly);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when changing a read/write Property to read-only.");
			Assert.AreEqual(BreakingChangeKind.RemovedPropertyAccessors, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(PropertyReadWrite.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(PropertyReadOnly.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyReadWrite, PropertyReadOnlyPublic);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when changing a read/write Property to read-only.");
			Assert.AreEqual(BreakingChangeKind.RemovedPropertyAccessors, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(PropertyReadWrite.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(PropertyReadOnlyPublic.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyReadWrite, PropertyWriteOnly);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when changing a read/write Property to write-only.");
			Assert.AreEqual(BreakingChangeKind.RemovedPropertyAccessors, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(PropertyReadWrite.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(PropertyWriteOnly.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");

			breakingChanges = MetadataComparer.CompareTypes(PropertyReadWrite, PropertyWriteOnlyPublic);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when changing a read/write Property to write-only.");
			Assert.AreEqual(BreakingChangeKind.RemovedPropertyAccessors, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(PropertyReadWrite.GetMember("Property"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(PropertyWriteOnlyPublic.GetMember("Property"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // PropertyTests

		public class PropertyReadOnly { public int Property { get { return 0; } } }
		public class PropertyReadOnlyPublic { public int Property { get { return 0; } protected set { } } }
		public class PropertyReadWrite { public int Property { get { return 0; } set { } } }
		public class PropertyWriteOnly { public int Property { set { } } }
		public class PropertyWriteOnlyPublic { public int Property { protected get { return 0; } set { } } }
	}
}
