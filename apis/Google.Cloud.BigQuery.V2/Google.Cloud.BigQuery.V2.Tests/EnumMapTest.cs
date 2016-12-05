// Copyright 2016 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using Xunit;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class EnumMapTest
    {
        [Theory]
        [InlineData(typeof(WriteDisposition), (int) WriteDisposition.WriteIfEmpty, "WRITE_EMPTY")]
        [InlineData(typeof(BigQueryDbType), (int) BigQueryDbType.Float64, "FLOAT")]
        public void ValidConversion(Type type, int value, string name)
        {
            // Note: this is pretty horrible in terms of how the values are specified, but xUnit
            // doesn't seem to like boxing enums.
            dynamic converted = Enum.Parse(type, value.ToString());
            Validate(converted, name);
        }

        [Fact]
        public void InvalidConversion()
        {
            Assert.Throws<ArgumentException>(() => EnumMap<WriteDisposition>.ToValue("WRITEIFEMPTY"));
            Assert.Throws<ArgumentException>(() => EnumMap<WriteDisposition>.ToValue("Bogus"));
            Assert.Throws<ArgumentException>(() => EnumMap<WriteDisposition>.ToValue("Write_Empty"));
            Assert.Throws<ArgumentException>(() => EnumMap<WriteDisposition>.ToApiValue((WriteDisposition) 100));
        }

        private static void Validate<T>(T value, string name) where T : struct
        {
            Assert.Equal(name, EnumMap<T>.ToApiValue(value));
            Assert.Equal(value, EnumMap<T>.ToValue(name));
        }
    }
}
