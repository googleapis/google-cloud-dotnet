// Copyright 2021 Google LLC
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
using static Google.Cloud.Compute.V1.Address.Types;

namespace Google.Cloud.Compute.V1.Tests
{
    public class ComputeEnumHelpersTest
    {
        [Theory]
        [InlineData(default(string), false, default(Purpose))]
        [InlineData("Unknown value", false, default(Purpose))]
        [InlineData("", false, default(Purpose))]
        // Field name isn't parsed
        [InlineData("PrivateServiceConnect", false, default(Purpose))]
        // Value is case-sensitive
        [InlineData("private_service_connect", false, default(Purpose))]
        // String representation of number isn't parsed
        [InlineData("48134724", false, default(Purpose))]
        // Valid value is parsed appropriately.
        [InlineData("PRIVATE_SERVICE_CONNECT", true, Purpose.PrivateServiceConnect)]
        public void TryParse(string value, bool expectedReturn, Purpose expectedResult)
        {
            Assert.Equal(expectedReturn, ComputeEnumHelpers.TryParse<Purpose>(value, out var result));
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Parse_KnownValue() =>
            Assert.Equal(Purpose.PrivateServiceConnect, ComputeEnumHelpers.Parse<Purpose>("PRIVATE_SERVICE_CONNECT"));

        [Theory]
        [InlineData("PrivateServiceConnect")]
        [InlineData("private_service_connect")]
        [InlineData("48134724")]
        [InlineData("")]
        public void Parse_UnknownValue(string value) =>
            Assert.Throws<ArgumentException>(() => ComputeEnumHelpers.Parse<Purpose>(value));

        [Fact]
        public void Parse_NullValue() =>
            Assert.Throws<ArgumentNullException>(() => ComputeEnumHelpers.Parse<Purpose>(null));

        [Fact]
        public void Format_KnownValue() =>
            Assert.Equal("PRIVATE_SERVICE_CONNECT", ComputeEnumHelpers.Format(Purpose.PrivateServiceConnect));

        [Fact]
        public void Format_UnknownValue() =>
            Assert.Throws<ArgumentException>(() => ComputeEnumHelpers.Format((Purpose) 12345678));
    }
}
