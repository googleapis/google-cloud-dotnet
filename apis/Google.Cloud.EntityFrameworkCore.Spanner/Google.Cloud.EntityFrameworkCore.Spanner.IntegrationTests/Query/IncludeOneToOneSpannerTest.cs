// Copyright 2017 Google Inc. All Rights Reserved.
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

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Xunit;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests.Query
{
    /// <summary>
    /// TODO: implement tests for Spanner
    /// </summary>
    internal class IncludeOneToOneSpannerTest : IncludeOneToOneTestBase, IClassFixture<OneToOneQuerySpannerFixture>
    {
        private readonly OneToOneQuerySpannerFixture _fixture;

        public IncludeOneToOneSpannerTest(OneToOneQuerySpannerFixture fixture) => _fixture = fixture;

        protected override DbContext CreateContext() => _fixture.CreateContext();
    }
}