// Copyright 2020 Google LLC
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

using Google.Cloud.Spanner.V1;
using System;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class QueryOptionsTests
    {
        [Fact]
        public void FromProtoFromEmptyProto()
        {
            var proto = new V1.ExecuteSqlRequest.Types.QueryOptions();
            var queryOptions = QueryOptions.FromProto(proto);
            Assert.Equal("", queryOptions.OptimizerVersion);
            Assert.Equal("", queryOptions.OptimizerStatisticsPackage);
        }

        [Fact]
        public void NoOptionsSet()
        {
            var queryOptions = QueryOptions.Empty;
            Assert.Equal("", queryOptions.OptimizerVersion);
            Assert.Equal("", queryOptions.OptimizerStatisticsPackage);
        }

        [Fact]
        public void SetAndGetOptimizerVersion()
        {
            var queryOptions = QueryOptions.Empty.WithOptimizerVersion("latest");
            Assert.Equal("latest", queryOptions.OptimizerVersion);
        }

        [Fact]
        public void SetAndGetOptimizerStatisticsPackage()
        {
            var queryOptions = QueryOptions.Empty.WithOptimizerStatisticsPackage("latest");
            Assert.Equal("latest", queryOptions.OptimizerStatisticsPackage);
        }
    }
}
