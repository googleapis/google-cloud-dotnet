// Copyright 2019 Google LLC
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

using Google.Cloud.ClientTesting;
using Xunit;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class BigQueryGeographyTest
    {
        [Fact]
        public void Parse()
        {
            var text = "POINT(30 10)";
            var geography = BigQueryGeography.Parse(text);
            Assert.Equal(text, geography.Text);
            Assert.Equal(text, geography.ToString());
        }

        [Fact]
        public void Equality()
        {
            EqualityTester.AssertEqual(BigQueryGeography.Parse("POINT(30 10)"),
                new[] { BigQueryGeography.Parse("POINT(30 10)") },
                new[]
                {
                    BigQueryGeography.Parse("POINT (30 10)"), // Whitespace is relevant
                    BigQueryGeography.Parse("POINT"),
                    BigQueryGeography.Parse("LINESTRING (30 10, 10 30, 40 40)")
                });
        }
    }
}
