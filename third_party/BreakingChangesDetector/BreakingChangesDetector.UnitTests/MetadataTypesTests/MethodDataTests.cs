/*
    MIT License

    Copyright(c) 2014-2018 Infragistics, Inc.
    Copyright 2018 Google LLC

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
using Xunit;
using BreakingChangesDetector.MetadataItems;

namespace BreakingChangesDetector.UnitTests.MetadataTypesTests
{
	public class MethodDataTests
	{
		#region MethodDataAccessibilityTest

		[Fact]
		public void MethodDataAccessibilityTest()
		{
			var t = typeof(TestClassDefinition);
            var context = MetadataResolutionContext.CreateFromTypes(t);
            var typeData = context.GetTypeDefinitionData(t);
			TestUtilities.VerifyAccessibility(typeData, "MethodInstance");
		}

		#endregion // MethodDataAccessibilityTest

		#region MethodDataDeclaringTypeTest

		[Fact]
		public void MethodDataDeclaringTypeTest()
		{
			var t = typeof(TestClassDefinition);
			var context = MetadataResolutionContext.CreateFromTypes(t);
			var typeData = context.GetTypeDefinitionData(t);
			var method = typeData.GetMember("MethodInstance");
			AssertX.Equal(typeData, method.ContainingType, "The DeclaringType of a member should be the type in which it is defined.");
		}

		#endregion // MethodDataDeclaringTypeTest

		#region MethodDataMemberFlagsTest

		[Fact]
		public void MethodDataMemberFlagsTest()
		{
			var t = typeof(OverloadedMemberFeatures);
			var context = MetadataResolutionContext.CreateFromTypes(t);
			var typeData = context.GetTypeDefinitionData(t);

			var eventData = (MethodData)typeData.GetMember("MethodInstance");
			AssertX.Equal(MemberFlags.None, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (MethodData)typeData.GetMember("MethodStatic");
			AssertX.Equal(MemberFlags.Static, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (MethodData)typeData.GetMember("MethodInstanceAbstract");
			AssertX.Equal(MemberFlags.Abstract, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (MethodData)typeData.GetMember("MethodInstanceVirtual");
			AssertX.Equal(MemberFlags.Virtual, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (MethodData)typeData.GetMember("MethodInstanceOverrideAbstract");
			AssertX.Equal(MemberFlags.Override, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (MethodData)typeData.GetMember("MethodInstanceOverrideAbstractSealed");
			AssertX.Equal(MemberFlags.Override | MemberFlags.Sealed, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (MethodData)typeData.GetMember("MethodInstanceOverrideAbstractAbstract");
			AssertX.Equal(MemberFlags.Override | MemberFlags.Abstract, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (MethodData)typeData.GetMember("MethodInstanceOverrideVirtual");
			AssertX.Equal(MemberFlags.Override, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (MethodData)typeData.GetMember("MethodInstanceOverrideVirtualSealed");
			AssertX.Equal(MemberFlags.Override | MemberFlags.Sealed, eventData.MemberFlags, "The Flags value of the member is wrong.");
			eventData = (MethodData)typeData.GetMember("MethodInstanceOverrideVirtualAbstract");
			AssertX.Equal(MemberFlags.Override | MemberFlags.Abstract, eventData.MemberFlags, "The Flags value of the member is wrong.");
		}

		#endregion // MethodDataMemberFlagsTest

		#region MethodDataGenericParametersTest

		[Fact]
		public void MethodDataGenericParametersTest()
		{
			var t = typeof(VariousMemberFeatures);
			var context = MetadataResolutionContext.CreateFromTypes(t);

			var typeData = context.GetTypeDefinitionData(t);
			var genericMethod = (MethodData)typeData.GetMember("GenericMethod");
			AssertX.Equal(5, genericMethod.GenericParameters.Count, "The number of generic parameters is incorrect.");
		}

		#endregion // MethodDataGenericParametersTest

		#region MethodDataIsExtensionMethodTest

		[Fact]
		public void MethodDataIsExtensionMethodTest()
		{
			var context = MetadataResolutionContext.CreateFromTypes(typeof(MethodDataTests));

			var typeData = context.GetTypeDefinitionData(typeof(StaticClass));
			var methodData = (MethodData)typeData.GetMember("Method");
			Assert.False(methodData.IsExtensionMethod, "The IsExtensionMethod value is incorrect.");
			
			typeData = context.GetTypeDefinitionData(typeof(ExtensionsClass));
			methodData = (MethodData)typeData.GetMember("Method");
			Assert.True(methodData.IsExtensionMethod, "The IsExtensionMethod value is incorrect.");
		}

		#endregion // MethodDataIsExtensionMethodTest

		#region MethodDataNameTest

		[Fact]
		public void MethodDataNameTest()
		{
			var t = typeof(TestClassDefinition);
			var context = MetadataResolutionContext.CreateFromTypes(t);
			var typeData = context.GetTypeDefinitionData(t);
			var method = typeData.GetMember("MethodInstance");
			AssertX.Equal("MethodInstance", method.Name, "The Name of the member is incorrect.");
		}

		#endregion // MethodDataNameTest

		#region MethodDataParametersTest

		[Fact]
		public void MethodDataParametersTest()
		{
			var t = typeof(TestClassDefinition);
			var context = MetadataResolutionContext.CreateFromTypes(t);
			var typeData = context.GetTypeDefinitionData(t);
			var method = (MethodData)typeData.GetMember("MethodInstance");
			AssertX.Equal(0, method.Parameters.Count, "The public method has the wrong number of parameters.");

			method = (MethodData)typeData.GetMember("MethodInstanceProtected");
			AssertX.Equal(2, method.Parameters.Count, "The protected method has the wrong number of parameters.");

			method = (MethodData)typeData.GetMember("MethodInstanceProtectedInternal");
			AssertX.Equal(3, method.Parameters.Count, "The protected internal method has the wrong number of parameters.");
		}

		#endregion // MethodDataParametersTest

		#region MethodDataTypeTest

		[Fact]
		public void MethodDataTypeTest()
		{
			var t = typeof(TestClassDefinition);
			var context = MetadataResolutionContext.CreateFromTypes(t);
			var typeData = context.GetTypeDefinitionData(t);
			var voidType = context.GetTypeDefinitionData(typeof(void));

			var method = (MethodData)typeData.GetMember("MethodInstance");
			AssertX.Equal(voidType, method.Type, "The Type of the member is incorrect.");
		}

		#endregion // MethodDataTypeTest
	}
}
