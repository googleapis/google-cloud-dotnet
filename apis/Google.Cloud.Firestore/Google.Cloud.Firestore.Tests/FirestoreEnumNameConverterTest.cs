// Copyright 2019, Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using Xunit;

namespace Google.Cloud.Firestore.Tests
{
    // Note: General integration (with the rest of the framework) tests are in SerializationTestData.
    public class FirestoreEnumNameConverterTest
    {
        private static readonly FirestoreEnumNameConverter<SampleEnum> s_converter = new FirestoreEnumNameConverter<SampleEnum>();

        [Theory]
        [InlineData("Foo", SampleEnum.Foo)]
        [InlineData("Bar", SampleEnum.Bar)]
        [InlineData("Bar2", SampleEnum.Bar)]
        public void FromFirestore_Valid(string text, SampleEnum expectedResult) =>
            Assert.Equal(expectedResult, s_converter.FromFirestore(text));

        [Fact]
        public void FromFirestore_UnknownValue() =>
            Assert.Throws<ArgumentException>(() => s_converter.FromFirestore("Baz"));

        [Fact]
        public void FromFirestore_NonString() =>
            Assert.Throws<InvalidCastException>(() => s_converter.FromFirestore(new object()));

        [Fact]
        public void FromFirestore_NumericString() =>
            Assert.Throws<ArgumentException>(() => s_converter.FromFirestore("10"));

        [Fact]
        public void ToFirestore_UnknownValue() =>
            Assert.Throws<ArgumentException>(() => s_converter.ToFirestore((SampleEnum) 15));

        [Fact]
        public void ToFirestore_Unique() =>
            Assert.Equal(nameof(SampleEnum.Foo), s_converter.ToFirestore(SampleEnum.Foo));

        [Fact]
        public void ToFirestore_NotUnique()
        {
            string actual = (string) s_converter.ToFirestore(SampleEnum.Bar);
            Assert.Contains(actual, new[] { nameof(SampleEnum.Bar), nameof(SampleEnum.Bar2) });
        }

        public enum SampleEnum
        {
            Foo = 10,
            Bar = 20,
            Bar2 = 20
        }

        [Fact]
        public void EnumCanBePrivate()
        {
            var converter = new FirestoreEnumNameConverter<PrivateEnum>();
            Assert.Equal(nameof(PrivateEnum.SampleValue), converter.ToFirestore(PrivateEnum.SampleValue));
            Assert.Equal(PrivateEnum.SampleValue, converter.FromFirestore(nameof(PrivateEnum.SampleValue)));
        }
        
        /// <summary>
        /// SampleEnum has to be public so we can use it in a theory. We have a single test that
        /// private enums work too.
        /// </summary>
        private enum PrivateEnum
        {
            SampleValue = 5
        }
    }
}
