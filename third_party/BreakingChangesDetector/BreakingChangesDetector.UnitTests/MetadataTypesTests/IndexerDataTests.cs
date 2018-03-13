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

namespace BreakingChangesDetector.UnitTests.MetadataTypesTests
{
	[TestClass]
	public class IndexerDataTests
	{
		#region IndexerDataAccessibilityTest

		[TestMethod]
		public void IndexerDataAccessibilityTest()
		{
			var t = typeof(VariousMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);

			var members = typeData.GetMembers("Item");
			Assert.AreEqual(3, members.Count, "Incorrect number of indexers returned.");
			Assert.AreEqual(MemberAccessibility.Protected, ((IndexerData)members[0]).Accessibility, "Incorrect MemberAccessibility.");
			Assert.AreEqual(MemberAccessibility.Public, ((IndexerData)members[1]).Accessibility, "Incorrect MemberAccessibility.");
			Assert.AreEqual(MemberAccessibility.Public, ((IndexerData)members[2]).Accessibility, "Incorrect MemberAccessibility.");
		}

		#endregion // IndexerDataAccessibilityTest

		#region IndexerDataDeclaringTypeTest

		[TestMethod]
		public void IndexerDataDeclaringTypeTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var indexer = typeData.GetMembers("Item")[0];
			Assert.AreEqual(typeData, indexer.DeclaringType, "The DeclaringType of a member should be the type in which it is defined.");
		}

		#endregion // IndexerDataDeclaringTypeTest

		#region IndexerDataMemberFlagsTest

		[TestMethod]
		public void IndexerDataMemberFlagsTest()
		{
			var t = typeof(OverloadedMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);

			var members = typeData.GetMembers("Item");
			Assert.AreEqual(9, members.Count, "Incorrect number of indexers");

			var indexerData = (IndexerData)members[0];
			Assert.AreEqual(MemberFlags.None, indexerData.MemberFlags, "The Flags value of the member is wrong.");
			indexerData = (IndexerData)members[1];
			Assert.AreEqual(MemberFlags.Abstract, indexerData.MemberFlags, "The Flags value of the member is wrong.");
			indexerData = (IndexerData)members[2];
			Assert.AreEqual(MemberFlags.Virtual, indexerData.MemberFlags, "The Flags value of the member is wrong.");
			indexerData = (IndexerData)members[3];
			Assert.AreEqual(MemberFlags.Override, indexerData.MemberFlags, "The Flags value of the member is wrong.");
			indexerData = (IndexerData)members[4];
			Assert.AreEqual(MemberFlags.Override | MemberFlags.Sealed, indexerData.MemberFlags, "The Flags value of the member is wrong.");
			indexerData = (IndexerData)members[5];
			Assert.AreEqual(MemberFlags.Override | MemberFlags.Abstract, indexerData.MemberFlags, "The Flags value of the member is wrong.");
			indexerData = (IndexerData)members[6];
			Assert.AreEqual(MemberFlags.Override, indexerData.MemberFlags, "The Flags value of the member is wrong.");
			indexerData = (IndexerData)members[7];
			Assert.AreEqual(MemberFlags.Override | MemberFlags.Sealed, indexerData.MemberFlags, "The Flags value of the member is wrong.");
			indexerData = (IndexerData)members[8];
			Assert.AreEqual(MemberFlags.Override | MemberFlags.Abstract, indexerData.MemberFlags, "The Flags value of the member is wrong.");
		}

		#endregion // IndexerDataMemberFlagsTest

		#region IndexerDataGetMethodAccessibilityTest

		[TestMethod]
		public void IndexerDataGetMethodAccessibilityTest()
		{
			var t = typeof(VariousMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);

			var members = typeData.GetMembers("Item");

			var readOnlyIndexer = (IndexerData)members[0];
			Assert.AreEqual(MemberAccessibility.Protected, readOnlyIndexer.GetMethodAccessibility, "The GetMethodAccessibility of the read only property is incorrect.");

			var writeOnlyIndexer = (IndexerData)members[1];
			Assert.AreEqual(null, writeOnlyIndexer.GetMethodAccessibility, "The GetMethodAccessibility of the write only property is incorrect.");

			var readWriteIndexer = (IndexerData)members[2];
			Assert.AreEqual(MemberAccessibility.Public, readWriteIndexer.GetMethodAccessibility, "The GetMethodAccessibility of the read write property is incorrect.");
		}

		#endregion // IndexerDataGetMethodAccessibilityTest

		#region IndexerDataNameTest

		[TestMethod]
		public void IndexerDataNameTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var indexer = typeData.GetMembers("Item")[0];
			Assert.AreEqual("Item", indexer.Name, "The Name of the member is incorrect.");
		}

		#endregion // IndexerDataNameTest

		#region IndexerDataParametersTest

		[TestMethod]
		public void IndexerDataParametersTest()
		{
			var t = typeof(VariousMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var members = typeData.GetMembers("Item");
			Assert.AreEqual(3, members.Count, "Incorrect number of constructors returned.");
			Assert.AreEqual(1, ((IndexerData)members[0]).Parameters.Count, "The read only indexer has the wrong number of parameters.");
			Assert.AreEqual(2, ((IndexerData)members[1]).Parameters.Count, "The write only indexer has the wrong number of parameters.");
			Assert.AreEqual(3, ((IndexerData)members[2]).Parameters.Count, "The read write indexer has the wrong number of parameters.");
		}

		#endregion // IndexerDataParametersTest

		#region IndexerDataSetMethodAccessibilityTest

		[TestMethod]
		public void IndexerDataSetMethodAccessibilityTest()
		{
			var t = typeof(VariousMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);

			var members = typeData.GetMembers("Item");

			var readOnlyIndexer = (IndexerData)members[0];
			Assert.AreEqual(null, readOnlyIndexer.SetMethodAccessibility, "The SetMethodAccessibility of the read only property is incorrect.");

			var writeOnlyIndexer = (IndexerData)members[1];
			Assert.AreEqual(MemberAccessibility.Public, writeOnlyIndexer.SetMethodAccessibility, "The SetMethodAccessibility of the write only property is incorrect.");

			var readWriteIndexer = (IndexerData)members[2];
			Assert.AreEqual(MemberAccessibility.Protected, readWriteIndexer.SetMethodAccessibility, "The SetMethodAccessibility of the read write property is incorrect.");
		}

		#endregion // IndexerDataSetMethodAccessibilityTest

		#region IndexerDataTypeTest

		[TestMethod]
		public void IndexerDataTypeTest()
		{
			var t = typeof(VariousMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var indexer = (IndexerData)typeData.GetMembers("Item")[0];
			var objectType = TypeDefinitionData.FromType<object>();
			Assert.AreEqual(objectType, indexer.Type, "The Type of the member is incorrect.");
		}

		#endregion // IndexerDataTypeTest
	}
}
