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

#region

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

#endregion

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(TestDatabaseFixture))]
    public class AdminTests
    {
        // ReSharper disable once UnusedParameter.Local
        public AdminTests(TestDatabaseFixture testFixture, ITestOutputHelper outputHelper)
        {
            _testFixture = testFixture;
            TestLogger.TestOutputHelper = outputHelper;
        }

        private readonly TestDatabaseFixture _testFixture;

        [Fact]
        public async Task CreateDrop()
        {
            string dbName = "t_" + Guid.NewGuid().ToString("N").Substring(0, 28);

            using (var connection = new SpannerConnection(_testFixture.NoDbConnectionString))
            {
                var createCmd = connection.CreateDdlCommand($"CREATE DATABASE {dbName}");
                await createCmd.ExecuteNonQueryAsync().ConfigureAwait(false);
            }

            using (var connection = new SpannerConnection(_testFixture.NoDbConnectionString))
            {
                var dropCommand = connection.CreateDdlCommand($"DROP DATABASE {dbName}");
                await dropCommand.ExecuteNonQueryAsync().ConfigureAwait(false);
            }
        }
    }
}
