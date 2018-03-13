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
using System.Collections.Generic;

namespace BreakingChangesDetector.UnitTests.MetadataTypesTests
{
	[TestClass]
	public class TypeDisplayNameTests
	{
		#region ConstructedGenericTypeDataTests

		[TestMethod]
		public void ConstructedGenericTypeDataTests()
		{
			Assert.AreEqual("object", TypeData.FromType<object>().DisplayName);
			Assert.AreEqual("System.Collections.Generic.IEnumerable<out T>", TypeData.FromType(typeof(IEnumerable<>)).DisplayName);
			Assert.AreEqual("System.Collections.Generic.IEnumerable<int>", TypeData.FromType(typeof(IEnumerable<int>)).DisplayName);
			Assert.AreEqual("System.Collections.Generic.IEnumerable<List<int[]>>", TypeData.FromType(typeof(IEnumerable<List<int[]>>)).DisplayName);
			Assert.AreEqual("int?", TypeData.FromType<Nullable<int>>().DisplayName);
		}

		#endregion // ConstructedGenericTypeDataTests

		#region GenericTypeParameterDataTests

		[TestMethod]
		public void GenericTypeParameterDataTests()
		{
			Assert.AreEqual("T", TypeDefinitionData.FromType(typeof(IEnumerable<>)).GenericParameters[0].DisplayName);
			Assert.AreEqual("TKey", TypeDefinitionData.FromType(typeof(Dictionary<,>)).GenericParameters[0].DisplayName);
			Assert.AreEqual("TValue", TypeDefinitionData.FromType(typeof(Dictionary<,>)).GenericParameters[1].DisplayName);
		}

		#endregion // GenericTypeParameterDataTests

		#region TypeDefinitionDataTests

		[TestMethod]
		public void TypeDefinitionDataTests()
		{
			Assert.AreEqual("object", TypeData.FromType<object>().DisplayName);
			Assert.AreEqual("System.Collections.Generic.IEnumerable<out T>", TypeData.FromType(typeof(IEnumerable<>)).DisplayName);
		}

		#endregion // TypeDefinitionDataTests

		#region TypeWithElementDataTest

		[TestMethod]
		public void TypeWithElementDataTest()
		{
			var method = typeof(TypeDisplayNameTests).GetMethod("Method1");
			Assert.AreEqual("int*", TypeData.FromType(method.GetParameters()[0].ParameterType).DisplayName);

			method = typeof(TypeDisplayNameTests).GetMethod("Method2");
			Assert.AreEqual("void*", TypeData.FromType(method.GetParameters()[0].ParameterType).DisplayName);

			method = typeof(TypeDisplayNameTests).GetMethod("Method3");
			Assert.AreEqual("byte***", TypeData.FromType(method.GetParameters()[0].ParameterType).DisplayName);
		}

		#endregion // TypeWithElementDataTest

		public static unsafe void Method1(int* x) { }
		public static unsafe void Method2(void* x) { }
		public static unsafe void Method3(byte*** x) { }
	}
}
