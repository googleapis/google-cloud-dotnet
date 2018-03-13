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
	public class ConstantDataTests
	{
		#region ConstantDataAccessibilityTest

		[TestMethod]
		public void ConstantDataAccessibilityTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			TestUtilities.VerifyAccessibility(typeData, "Constant");
		}

		#endregion // ConstantDataAccessibilityTest

		#region ConstantDataDeclaringTypeTest

		[TestMethod]
		public void ConstantDataDeclaringTypeTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var constant = typeData.GetMember("Constant");
			Assert.AreEqual(typeData, constant.DeclaringType, "The DeclaringType of a member should be the type in which it is defined.");
		}

		#endregion // ConstantDataDeclaringTypeTest

		#region ConstantDataNameTest

		[TestMethod]
		public void ConstantDataNameTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var constant = typeData.GetMember("Constant");
			Assert.AreEqual("Constant", constant.Name, "The Name of the member is incorrect.");
		}

		#endregion // ConstantDataNameTest

		#region ConstantDataTypeTest

		[TestMethod]
		public void ConstantDataTypeTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var constant = (ConstantData)typeData.GetMember("Constant");
			var intType = TypeDefinitionData.FromType<int>();
			Assert.AreEqual(intType, constant.Type, "The Type of the member is incorrect.");
		}

		#endregion // ConstantDataTypeTest
	}
}
