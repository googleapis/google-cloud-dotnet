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
	public class ConstructorDataTests
	{
		#region ConstructorDataAccessibilityTest

		[TestMethod]
		public void ConstructorDataAccessibilityTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var members = typeData.GetMembers(".ctor");
			Assert.AreEqual(3, members.Count, "Incorrect number of constructors returned.");
			Assert.AreEqual(MemberAccessibility.Public, ((ConstructorData)members[0]).Accessibility, "Incorrect MemberAccessibility.");
			Assert.AreEqual(MemberAccessibility.Protected, ((ConstructorData)members[1]).Accessibility, "Incorrect MemberAccessibility.");
			Assert.AreEqual(MemberAccessibility.Protected, ((ConstructorData)members[2]).Accessibility, "Incorrect MemberAccessibility.");
		}

		#endregion // ConstructorDataAccessibilityTest

		#region ConstructorDataDeclaringTypeTest

		[TestMethod]
		public void ConstructorDataDeclaringTypeTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var constructor = typeData.GetMembers(".ctor")[0];
			Assert.AreEqual(typeData, constructor.DeclaringType, "The DeclaringType of a member should be the type in which it is defined.");
		}

		#endregion // ConstructorDataDeclaringTypeTest

		#region ConstructorDataNameTest

		[TestMethod]
		public void ConstructorDataNameTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var constructor = typeData.GetMembers(".ctor")[0];
			Assert.AreEqual(".ctor", constructor.Name, "The Name of the member is incorrect.");
		}

		#endregion // ConstructorDataNameTest

		#region ConstructorDataParametersTest

		[TestMethod]
		public void ConstructorDataParametersTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var members = typeData.GetMembers(".ctor");
			Assert.AreEqual(3, members.Count, "Incorrect number of constructors returned.");
			Assert.AreEqual(0, ((ConstructorData)members[0]).Parameters.Count, "The public constructor has the wrong number of parameters.");
			Assert.AreEqual(2, ((ConstructorData)members[1]).Parameters.Count, "The protected constructor has the wrong number of parameters.");
			Assert.AreEqual(3, ((ConstructorData)members[2]).Parameters.Count, "The protected internal constructor has the wrong number of parameters.");
		}

		#endregion // ConstructorDataParametersTest
	}
}
