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
	public class ParameterDataTests
	{
		// TODO_Test: Delegates are not tested here.

		#region ParameterDataDeclaringMemberKindTest

		[TestMethod]
		public void ParameterDataDeclaringMemberKindTest()
		{
			var t = typeof(TestClassDefinition);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var constructor = (ConstructorData)typeData.GetMembers(".ctor")[1];
			Assert.AreEqual(constructor.MetadataItemKind, constructor.Parameters[0].DeclaringMemberKind, "The DeclaringMemberKind of the constructor parameter is not assigned correctly.");

			var method = (MethodData)typeData.GetMember("MethodInstanceProtected");
			Assert.AreEqual(method.MetadataItemKind, method.Parameters[0].DeclaringMemberKind, "The DeclaringMemberKind of the method parameter is not assigned correctly.");

			var indexer = (IndexerData)typeData.GetMembers("Item")[0];
			Assert.AreEqual(indexer.MetadataItemKind, indexer.Parameters[0].DeclaringMemberKind, "The DeclaringMemberKind of the indexer parameter is not assigned correctly.");
		}

		#endregion // ParameterDataDeclaringMemberKindTest

		#region ParameterDataDefaultValueTest

		[TestMethod]
		public void ParameterDataDefaultValueTest()
		{
			var t = typeof(VariousMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);

			var method = (MethodData)typeData.GetMember("MethodWithDefaultParameter");
			Assert.IsNull(method.Parameters[0].DefaultValue, "The DefaultValue of the method parameter is not assigned correctly.");
			Assert.AreEqual(1, method.Parameters[1].DefaultValue, "The DefaultValue of the method parameter is not assigned correctly.");
			Assert.AreEqual((ulong)DateTimeKind.Local, method.Parameters[2].DefaultValue, "The DefaultValue of the method parameter is not assigned correctly.");
			Assert.IsNull(method.Parameters[3].DefaultValue, "The DefaultValue of the method parameter is not assigned correctly.");
		}

		#endregion // ParameterDataDefaultValueTest

		#region ParameterDataHasDefaultValueTest

		[TestMethod]
		public void ParameterDataHasDefaultValueTest()
		{
			var t = typeof(VariousMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);

			var method = (MethodData)typeData.GetMember("MethodWithDefaultParameter");
			Assert.IsFalse(method.Parameters[0].IsOptional, "The IsOptional of the method parameter is not assigned correctly.");
			Assert.IsTrue(method.Parameters[1].IsOptional, "The IsOptional of the method parameter is not assigned correctly.");
			Assert.IsTrue(method.Parameters[2].IsOptional, "The IsOptional of the method parameter is not assigned correctly.");
		}

		#endregion // ParameterDataHasDefaultValueTest

		#region ParameterDataIsParamsArrayTest

		[TestMethod]
		public void ParameterDataIsParamsArrayTest()
		{
			var t = typeof(VariousMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);

			var method = (MethodData)typeData.GetMember("MethodWithParamsArray");
			Assert.IsFalse(method.Parameters[0].IsParamsArray, "The IsParamsArray of the method parameter is not assigned correctly.");
			Assert.IsTrue(method.Parameters[1].IsParamsArray, "The IsParamsArray of the method parameter is not assigned correctly.");
		}

		#endregion // ParameterDataIsParamsArrayTest

		#region ParameterDataGetDefaultValueDisplayText

		[TestMethod]
		public void ParameterDataGetDefaultValueDisplayText()
		{
			var typeData = TypeDefinitionData.FromType<DefualtValues>();

			var method = (MethodData)typeData.GetMember("Method1");
			Assert.AreEqual("Method1Values.A", method.Parameters[0].GetDefaultValueDisplayText(), "The display text of the default value is incorrect.");
			Assert.AreEqual("(Method1Values)3", method.Parameters[1].GetDefaultValueDisplayText(), "The display text of the default value is incorrect.");
			Assert.AreEqual("Method1Values.D", method.Parameters[2].GetDefaultValueDisplayText(), "The display text of the default value is incorrect.");
			Assert.AreEqual("(Method1Values)15", method.Parameters[3].GetDefaultValueDisplayText(), "The display text of the default value is incorrect.");

			method = (MethodData)typeData.GetMember("Method2");
			Assert.AreEqual("Method2Values.A", method.Parameters[0].GetDefaultValueDisplayText(), "The display text of the default value is incorrect.");
			Assert.AreEqual("Method2Values.A | Method2Values.B", method.Parameters[1].GetDefaultValueDisplayText(), "The display text of the default value is incorrect.");
			Assert.AreEqual("Method2Values.D", method.Parameters[2].GetDefaultValueDisplayText(), "The display text of the default value is incorrect.");
			Assert.AreEqual("(Method2Values)15", method.Parameters[3].GetDefaultValueDisplayText(), "The display text of the default value is incorrect.");
		}

		public class DefualtValues
		{
			public void Method1(
				Method1Values w = Method1Values.A,
				Method1Values x = Method1Values.A | Method1Values.B,
				Method1Values y = Method1Values.A | Method1Values.C,
				Method1Values z = (Method1Values)15)
			{
			}

			public enum Method1Values { A = 1 << 0, B = 1 << 1, C = 1 << 2, D = A | C }

			public void Method2(
				Method2Values w = Method2Values.A,
				Method2Values x = Method2Values.A | Method2Values.B,
				Method2Values y = Method2Values.A | Method2Values.C,
				Method2Values z = (Method2Values)15)
			{
			}

			[Flags]
			public enum Method2Values { A = 1 << 0, B = 1 << 1, C = 1 << 2, D = A | C }
		}

		#endregion // ParameterDataGetDefaultValueDisplayText

		#region ParameterDataModiferTest

		[TestMethod]
		public void ParameterDataModiferTest()
		{
			var t = typeof(VariousMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);

			var method = (MethodData)typeData.GetMember("MethodWithParameterModifiers");
			Assert.AreEqual(ParameterModifier.None, method.Parameters[0].Modifer, "The ParameterModifier of the method parameter is not assigned correctly.");
			Assert.AreEqual(ParameterModifier.Ref, method.Parameters[1].Modifer, "The ParameterModifier of the method parameter is not assigned correctly.");
			Assert.AreEqual(ParameterModifier.Out, method.Parameters[2].Modifer, "The ParameterModifier of the method parameter is not assigned correctly.");
		}

		#endregion // ParameterDataModiferTest

		#region ParameterDataNameTest

		[TestMethod]
		public void ParameterDataNameTest()
		{
			var t = typeof(VariousMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);

			var method = (MethodData)typeData.GetMember("MethodWithParameterModifiers");
			Assert.AreEqual("param1", method.Parameters[0].Name, "The Name of the method parameter is not assigned correctly.");
			Assert.AreEqual("param2", method.Parameters[1].Name, "The Name of the method parameter is not assigned correctly.");
			Assert.AreEqual("param3", method.Parameters[2].Name, "The Name of the method parameter is not assigned correctly.");
		}

		#endregion // ParameterDataNameTest

		#region ParameterDataTypeTest

		[TestMethod]
		public void ParameterDataTypeTest()
		{
			var t = typeof(VariousMemberFeatures);
			var assembly = AssemblyData.FromAssembly(t.Assembly);
			var typeData = TypeDefinitionData.FromType(t);
			var intType = TypeDefinitionData.FromType<int>();

			var method = (MethodData)typeData.GetMember("MethodWithParameterTypes");
			Assert.AreEqual(intType, method.Parameters[0].Type, "The Type of the method parameter is not assigned correctly.");
			Assert.AreEqual(typeData, method.Parameters[1].Type, "The Type of the method parameter is not assigned correctly.");
		}

		#endregion // ParameterDataTypeTest
	}
}
