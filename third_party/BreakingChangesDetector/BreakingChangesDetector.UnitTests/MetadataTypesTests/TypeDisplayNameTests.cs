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
using System.Collections.Generic;

namespace BreakingChangesDetector.UnitTests.MetadataTypesTests
{
	public class TypeDisplayNameTests
	{
		#region ConstructedGenericTypeDataTests

		[Fact]
		public void ConstructedGenericTypeDataTests()
		{
            var context = MetadataResolutionContext.CreateFromTypes(typeof(object));
            Assert.Equal("object", context.GetTypeData<object>().DisplayName);
			Assert.Equal("System.Collections.Generic.IEnumerable<out T>", context.GetTypeData(typeof(IEnumerable<>)).DisplayName);
			Assert.Equal("System.Collections.Generic.IEnumerable<int>", context.GetTypeData(typeof(IEnumerable<int>)).DisplayName);
			Assert.Equal("System.Collections.Generic.IEnumerable<List<int[]>>", context.GetTypeData(typeof(IEnumerable<List<int[]>>)).DisplayName);
			Assert.Equal("int?", context.GetTypeData<Nullable<int>>().DisplayName);
		}

		#endregion // ConstructedGenericTypeDataTests

		#region GenericTypeParameterDataTests

		[Fact]
		public void GenericTypeParameterDataTests()
		{
            var context = MetadataResolutionContext.CreateFromTypes(typeof(object));
			Assert.Equal("T", context.GetTypeDefinitionData(typeof(IEnumerable<>)).GenericParameters[0].DisplayName);
			Assert.Equal("TKey", context.GetTypeDefinitionData(typeof(Dictionary<,>)).GenericParameters[0].DisplayName);
			Assert.Equal("TValue", context.GetTypeDefinitionData(typeof(Dictionary<,>)).GenericParameters[1].DisplayName);
		}

		#endregion // GenericTypeParameterDataTests

		#region TypeDefinitionDataTests

		[Fact]
		public void TypeDefinitionDataTests()
		{
            var context = MetadataResolutionContext.CreateFromTypes(typeof(object));
            Assert.Equal("object", context.GetTypeData<object>().DisplayName);
			Assert.Equal("System.Collections.Generic.IEnumerable<out T>", context.GetTypeData(typeof(IEnumerable<>)).DisplayName);
		}

		#endregion // TypeDefinitionDataTests

		#region TypeWithElementDataTest

		[Fact]
		public void TypeWithElementDataTest()
		{
            var context = MetadataResolutionContext.CreateFromTypes(typeof(TestMethods));
            var method = typeof(TestMethods).GetMethod("Method1");
			Assert.Equal("int*", context.GetTypeData(method.GetParameters()[0].ParameterType).DisplayName);

			method = typeof(TestMethods).GetMethod("Method2");
			Assert.Equal("void*", context.GetTypeData(method.GetParameters()[0].ParameterType).DisplayName);

			method = typeof(TestMethods).GetMethod("Method3");
			Assert.Equal("byte***", context.GetTypeData(method.GetParameters()[0].ParameterType).DisplayName);
		}

        #endregion // TypeWithElementDataTest

        private class TestMethods
        {
            public static unsafe void Method1(int* x) { }
            public static unsafe void Method2(void* x) { }
            public static unsafe void Method3(byte*** x) { }
        }
	}
}
