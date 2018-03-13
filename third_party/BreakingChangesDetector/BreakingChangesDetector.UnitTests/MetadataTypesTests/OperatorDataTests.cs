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
	public class OperatorDataTests
	{
		#region OperatorDataAccessibilityTest

		[TestMethod]
		public void OperatorDataAccessibilityTest()
		{
			var t = typeof(VariousMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var member = typeData.GetMember("op_Addition");
			Assert.AreEqual(MemberAccessibility.Public, member.Accessibility, "Incorrect Accessibility");
		}

		#endregion // OperatorDataAccessibilityTest

		#region OperatorDataAllOperatorsTest

		[TestMethod]
		public void OperatorDataAllOperatorsTest()
		{
			var t = typeof(VariousMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			
			Assert.IsNotNull(typeData.GetMember("op_Implicit"));
			Assert.IsNotNull(typeData.GetMember("op_Explicit"));
			Assert.IsNotNull(typeData.GetMember("op_Addition"));
			Assert.IsNotNull(typeData.GetMember("op_Subtraction"));
			Assert.IsNotNull(typeData.GetMember("op_Multiply"));
			Assert.IsNotNull(typeData.GetMember("op_Division"));
			Assert.IsNotNull(typeData.GetMember("op_Modulus"));
			Assert.IsNotNull(typeData.GetMember("op_ExclusiveOr"));
			Assert.IsNotNull(typeData.GetMember("op_BitwiseAnd"));
			Assert.IsNotNull(typeData.GetMember("op_BitwiseOr"));
			Assert.IsNotNull(typeData.GetMember("op_LeftShift"));
			Assert.IsNotNull(typeData.GetMember("op_RightShift"));
			Assert.IsNotNull(typeData.GetMember("op_Equality"));
			Assert.IsNotNull(typeData.GetMember("op_GreaterThan"));
			Assert.IsNotNull(typeData.GetMember("op_LessThan"));
			Assert.IsNotNull(typeData.GetMember("op_Inequality"));
			Assert.IsNotNull(typeData.GetMember("op_GreaterThanOrEqual"));
			Assert.IsNotNull(typeData.GetMember("op_LessThanOrEqual"));
			Assert.IsNotNull(typeData.GetMember("op_Decrement"));
			Assert.IsNotNull(typeData.GetMember("op_Increment"));
			Assert.IsNotNull(typeData.GetMember("op_UnaryNegation"));
			Assert.IsNotNull(typeData.GetMember("op_UnaryPlus"));
			Assert.IsNotNull(typeData.GetMember("op_OnesComplement"));
			Assert.IsNotNull(typeData.GetMember("op_LogicalNot"));
			Assert.IsNotNull(typeData.GetMember("op_True"));
			Assert.IsNotNull(typeData.GetMember("op_False"));
		}

		#endregion // OperatorDataAllOperatorsTest

		#region OperatorDataDeclaringTypeTest

		[TestMethod]
		public void OperatorDataDeclaringTypeTest()
		{
			var t = typeof(VariousMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var method = typeData.GetMember("op_Addition");
			Assert.AreEqual(typeData, method.DeclaringType, "The DeclaringType of a member should be the type in which it is defined.");
		}

		#endregion // OperatorDataDeclaringTypeTest

		#region OperatorDataNameTest

		[TestMethod]
		public void OperatorDataNameTest()
		{
			var t = typeof(VariousMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var method = typeData.GetMember("op_Addition");
			Assert.AreEqual("op_Addition", method.Name, "The Name of the member is incorrect.");
		}

		#endregion // OperatorDataNameTest

		#region OperatorDataParametersTest

		[TestMethod]
		public void OperatorDataParametersTest()
		{
			var t = typeof(VariousMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var method = (OperatorData)typeData.GetMember("op_Addition");
			Assert.AreEqual(2, method.Parameters.Count, "The public method has the wrong number of parameters.");
		}

		#endregion // OperatorDataParametersTest

		#region OperatorDataTypeTest

		[TestMethod]
		public void OperatorDataTypeTest()
		{
			var t = typeof(VariousMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var voidType =TypeDefinitionData.FromType(typeof(void));

			var method = (OperatorData)typeData.GetMember("op_Addition");
			Assert.AreEqual(typeData, method.Type, "The Type of the member is incorrect.");
		}

		#endregion // OperatorDataTypeTest
	}
}
