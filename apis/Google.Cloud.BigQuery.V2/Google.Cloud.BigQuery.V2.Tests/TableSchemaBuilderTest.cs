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
    public class TableSchemaBuilderTest
    {
        [Fact]
        public void AddWithType()
        {
            var builder = new TableSchemaBuilder
            {
                { "field", BigQueryDbType.Int64, BigQueryFieldMode.Repeated, "My field" }
            };
            var schema = builder.Build();
            var field = schema.Fields[0];
            Assert.Equal("field", field.Name);
            Assert.Equal("INTEGER", field.Type);
            Assert.Equal("REPEATED", field.Mode);
            Assert.Equal("My field", field.Description);
        }

        [Fact]
        public void AddNested()
        {
            var builder = new TableSchemaBuilder
            {
                { "outer", new TableSchemaBuilder { { "inner", BigQueryDbType.String } }, BigQueryFieldMode.Required, "Outer field" }
            };
            var schema = builder.Build();
            var field = schema.Fields[0];
            Assert.Equal("outer", field.Name);
            Assert.Equal("RECORD", field.Type);
            Assert.Equal("REQUIRED", field.Mode);
            Assert.Equal("Outer field", field.Description);
            var nestedField = field.Fields[0];
            Assert.Equal("inner", nestedField.Name);
            Assert.Equal("STRING", nestedField.Type);
            Assert.Equal("NULLABLE", nestedField.Mode);
        }

        [Fact]
        public void Add_InvalidName()
        {
            var builder = new TableSchemaBuilder();
            Assert.Throws<ArgumentException>(() => builder.Add("123", BigQueryDbType.Int64));
        }

        [Fact]
        public void ValidateFieldName_Valid()
        {
            TableSchemaBuilder.ValidateFieldName("abcABC_10", "field");
            TableSchemaBuilder.ValidateFieldName("_", "field");
            TableSchemaBuilder.ValidateFieldName(new string('a', 128), "field");
        }

        [Theory]
        [InlineData("")]
        [InlineData("1ab")]
        [InlineData("abc+123")]
        [InlineData("abc=123")]
        [InlineData("abc-123")]
        [InlineData("bc\u00e9")] // e acute
        public void ValidateFieldName_Invalid(string name)
        {
            Assert.Throws<ArgumentException>(() => TableSchemaBuilder.ValidateFieldName(name, "field"));
        }

        [Fact]
        public void ValidateFieldName_InvalidTooLong()
        {
            // Can't embed this name into an InlineData easily...
            Assert.Throws<ArgumentException>(() => TableSchemaBuilder.ValidateFieldName(new string('a', 129), "field"));
        }
    }
}
