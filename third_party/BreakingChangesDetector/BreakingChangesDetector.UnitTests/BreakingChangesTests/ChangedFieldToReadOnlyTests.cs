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
	public class ChangedFieldToReadOnlyTests
	{
		#region FieldTests

		[TestMethod]
		public void FieldTests()
		{
			var assembly = AssemblyData.FromAssembly(typeof(ChangedMemberTypeTests).Assembly);
			var FieldReadOnly = TypeDefinitionData.FromType(typeof(FieldReadOnly));
			var FieldReadWrite = TypeDefinitionData.FromType(typeof(FieldReadWrite));
			
			var breakingChanges = MetadataComparer.CompareTypes(FieldReadOnly, FieldReadWrite);
			Assert.AreEqual(0, breakingChanges.Count, "There should be no breaking changes when changing a read-only field to read/write.");

			breakingChanges = MetadataComparer.CompareTypes(FieldReadWrite, FieldReadOnly);
			Assert.AreEqual(1, breakingChanges.Count, "There should be one breaking change when changing a read/write field to read-only.");
			Assert.AreEqual(BreakingChangeKind.ChangedFieldToReadOnly, breakingChanges[0].BreakingChangeKind, "The BreakingChangeKind is incorrect.");
			Assert.AreEqual(FieldReadWrite.GetMember("Field"), breakingChanges[0].OldItem, "The OldItem is incorrect.");
			Assert.AreEqual(FieldReadOnly.GetMember("Field"), breakingChanges[0].NewItem, "The NewItem is incorrect.");
			Assert.IsNull(breakingChanges[0].AssociatedData, "The AssociatedData is incorrect.");
		}

		#endregion // FieldTests

		public class FieldReadOnly { public readonly int Field; }
		public class FieldReadWrite { public int Field; }
	}
}
