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

namespace BreakingChangesDetector.UnitTests.MetadataTypesTests
{
    public class DefaultValueInfoTests
    {
        [Fact]
        public void NullableBoolDefaultValueTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(DefaultValueInfoTests));
            var typeData = context.GetTypeDefinitionData(typeof(MethodWithDefaultValues));
            var method = typeData.GetMethod("MethodWithBools");

            Assert.Null(method.Parameters[0].DefaultValue);
            Assert.Equal(true, method.Parameters[1].DefaultValue);
        }

        [Fact]
        public void NullableDecimalDefaultValueTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(DefaultValueInfoTests));
            var typeData = context.GetTypeDefinitionData(typeof(MethodWithDefaultValues));
            var method = typeData.GetMethod("MethodWithDecimals");

            Assert.Null(method.Parameters[0].DefaultValue);
            Assert.Equal(0m, method.Parameters[1].DefaultValue);
        }

        [Fact]
        public void NullableEnumDefaultValueTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(DefaultValueInfoTests));
            var typeData = context.GetTypeDefinitionData(typeof(MethodWithDefaultValues));
            var method = typeData.GetMethod("MethodWithEnums");

            Assert.Null(method.Parameters[0].DefaultValue);
            Assert.Equal((ulong)DateTimeKind.Local, method.Parameters[1].DefaultValue);
        }

        [Fact]
        public void NullableIntDefaultValueTests()
        {
            var context = MetadataResolutionContext.CreateFromTypes(typeof(DefaultValueInfoTests));
            var typeData = context.GetTypeDefinitionData(typeof(MethodWithDefaultValues));
            var method = typeData.GetMethod("MethodWithInts");

            Assert.Null(method.Parameters[0].DefaultValue);
            Assert.Equal(0, method.Parameters[1].DefaultValue);
        }

        public class MethodWithDefaultValues
        {
            public void MethodWithBools(bool? x = null, bool? y = true) { }
            public void MethodWithDecimals(decimal? x = null, decimal? y = 0) { }
            public void MethodWithEnums(DateTimeKind? x = null, DateTimeKind? y = DateTimeKind.Local) { }
            public void MethodWithInts(int? x = null, int? y = 0) { }
        }
    }
}
