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
	public class MethodDataTests
	{
		#region MethodDataAccessibilityTest

		[TestMethod]
		public void MethodDataAccessibilityTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			TestUtilities.VerifyAccessibility(typeData, "MethodInstance");
		}

		#endregion // MethodDataAccessibilityTest

		#region MethodDataDeclaringTypeTest

		[TestMethod]
		public void MethodDataDeclaringTypeTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var method = typeData.GetMember("MethodInstance");
			Assert.AreEqual(typeData, method.DeclaringType, "The DeclaringType of a member should be the type in which it is defined.");
		}

		#endregion // MethodDataDeclaringTypeTest

		#region MethodDataMemberFlagsTest

		[TestMethod]
		public void MethodDataMemberFlagsTest()
		{
			var t = typeof(OverloadedMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);

			var eventData = (MethodData)typeData.GetMember("MethodInstance");
			Assert.AreEqual(MemberFlags.None, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (MethodData)typeData.GetMember("MethodStatic");
			Assert.AreEqual(MemberFlags.Static, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (MethodData)typeData.GetMember("MethodInstanceAbstract");
			Assert.AreEqual(MemberFlags.Abstract, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (MethodData)typeData.GetMember("MethodInstanceVirtual");
			Assert.AreEqual(MemberFlags.Virtual, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (MethodData)typeData.GetMember("MethodInstanceOverrideAbstract");
			Assert.AreEqual(MemberFlags.Override, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (MethodData)typeData.GetMember("MethodInstanceOverrideAbstractSealed");
			Assert.AreEqual(MemberFlags.Override | MemberFlags.Sealed, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (MethodData)typeData.GetMember("MethodInstanceOverrideAbstractAbstract");
			Assert.AreEqual(MemberFlags.Override | MemberFlags.Abstract, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (MethodData)typeData.GetMember("MethodInstanceOverrideVirtual");
			Assert.AreEqual(MemberFlags.Override, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (MethodData)typeData.GetMember("MethodInstanceOverrideVirtualSealed");
			Assert.AreEqual(MemberFlags.Override | MemberFlags.Sealed, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (MethodData)typeData.GetMember("MethodInstanceOverrideVirtualAbstract");
			Assert.AreEqual(MemberFlags.Override | MemberFlags.Abstract, eventData.MemberFlags, "The Flags value of the member is wrong.");
		}

		#endregion // MethodDataMemberFlagsTest

		#region MethodDataGenericParametersTest

		[TestMethod]
		public void MethodDataGenericParametersTest()
		{
			var t = typeof(VariousMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);

			var typeData = TypeDefinitionData.FromType(t);
			var genericMethod = (MethodData)typeData.GetMember("GenericMethod");
			Assert.AreEqual(5, genericMethod.GenericParameters.Count, "The number of generic parameters is incorrect.");
		}

		#endregion // MethodDataGenericParametersTest

		#region MethodDataIsExtensionMethodTest

		[TestMethod]
		public void MethodDataIsExtensionMethodTest()
		{
			var assembly = AssemblyData.FromAssembly(typeof(MethodDataTests).Assembly);

			var typeData = TypeDefinitionData.FromType(typeof(StaticClass));
			var methodData = (MethodData)typeData.GetMember("Method");
			Assert.IsFalse(methodData.IsExtensionMethod, "The IsExtensionMethod value is incorrect.");
			
			typeData = TypeDefinitionData.FromType(typeof(ExtensionsClass));
			methodData = (MethodData)typeData.GetMember("Method");
			Assert.IsTrue(methodData.IsExtensionMethod, "The IsExtensionMethod value is incorrect.");
		}

		#endregion // MethodDataIsExtensionMethodTest

		#region MethodDataNameTest

		[TestMethod]
		public void MethodDataNameTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var method = typeData.GetMember("MethodInstance");
			Assert.AreEqual("MethodInstance", method.Name, "The Name of the member is incorrect.");
		}

		#endregion // MethodDataNameTest

		#region MethodDataParametersTest

		[TestMethod]
		public void MethodDataParametersTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var method = (MethodData)typeData.GetMember("MethodInstance");
			Assert.AreEqual(0, method.Parameters.Count, "The public method has the wrong number of parameters.");

			method = (MethodData)typeData.GetMember("MethodInstanceProtected");
			Assert.AreEqual(2, method.Parameters.Count, "The protected method has the wrong number of parameters.");

			method = (MethodData)typeData.GetMember("MethodInstanceProtectedInternal");
			Assert.AreEqual(3, method.Parameters.Count, "The protected internal method has the wrong number of parameters.");
		}

		#endregion // MethodDataParametersTest

		#region MethodDataTypeTest

		[TestMethod]
		public void MethodDataTypeTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var voidType = TypeDefinitionData.FromType(typeof(void));

			var method = (MethodData)typeData.GetMember("MethodInstance");
			Assert.AreEqual(voidType, method.Type, "The Type of the member is incorrect.");
		}

		#endregion // MethodDataTypeTest
	}
}
