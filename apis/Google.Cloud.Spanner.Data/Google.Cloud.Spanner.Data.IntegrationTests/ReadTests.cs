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
using System.Collections;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

#endregion

// ReSharper disable PossibleNullReferenceException

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    public class ReadTests : IClassFixture<TestDatabaseFixture>
    {
        public ReadTests(TestDatabaseFixture testFixture) => _testFixture = testFixture;

        private readonly TestDatabaseFixture _testFixture;

        //[Fact]
        //public async Task TestReadDeadlineExceeded()
        //{
        //    Exception exceptionCaught = null;
        //    long result = 0;
        //    try
        //    {
        //        using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
        //        {
        //            var cmd =
        //                connection.CreateSelectCommand("SELECT 1");
        //            result = await cmd.ExecuteScalarAsync<long>();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        exceptionCaught = e;
        //    }

        //    Assert.NotNull(exceptionCaught);
        //    Assert.Equal(0, result);
        //}

        private async Task<T> ExecuteAsync<T>(string sql)
        {
            using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
            {
                var cmd = connection.CreateSelectCommand(sql);
                var result = await cmd.ExecuteScalarAsync<T>();
                return result;
            }
        }

        [Fact]
        public async Task BadColumnName()
        {
            // ReSharper disable once RedundantAssignment
            int rowsRead = -1;
            var exceptionCaught = false;

            try
            {
                using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
                {
                    var cmd = connection.CreateSelectCommand(
                        "SELECT badjuju FROM " + _testFixture.TestTable);
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        rowsRead = 0;
                        while (await reader.ReadAsync())
                        {
                            rowsRead++;
                        }
                    }
                }
            }
            catch (SpannerException e)
            {
                exceptionCaught = true;
                Debug.WriteLine("TestBadColumnName: Caught error code:" + e.ErrorCode);
                Assert.Equal(ErrorCode.InvalidArgument, e.ErrorCode);
                Assert.False(e.IsTransientSpannerFault());
            }

            Assert.True(exceptionCaught);
            Assert.True(rowsRead < 1);
        }

        [Fact]
        public async Task BadDbName()
        {
            string connectionString = "Data Source=" + _testFixture.TestProjectName + "/"
                + _testFixture.TestInstanceName + "/" + "badjuju";
            // ReSharper disable once RedundantAssignment
            int rowsRead = -1;
            var exceptionCaught = false;

            try
            {
                using (var connection = new SpannerConnection(connectionString))
                {
                    var cmd = connection.CreateSelectCommand(
                        "SELECT * FROM " + _testFixture.TestTable + " WHERE Key = 'k1'");
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        rowsRead = 0;
                        while (await reader.ReadAsync())
                        {
                            rowsRead++;
                        }
                    }
                }
            }
            catch (SpannerException e)
            {
                exceptionCaught = true;
                Assert.Equal(ErrorCode.NotFound, e.ErrorCode);
                Assert.False(e.IsTransientSpannerFault());
            }

            Assert.True(exceptionCaught);
            Assert.Equal(-1, rowsRead);
        }

        [Fact]
        public async Task BadTableName()
        {
            // ReSharper disable once RedundantAssignment
            int rowsRead = -1;
            var exceptionCaught = false;

            try
            {
                using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
                {
                    var cmd = connection.CreateSelectCommand(
                        "SELECT * FROM badjuju WHERE Key = 'k99'");
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        rowsRead = 0;
                        while (await reader.ReadAsync())
                        {
                            rowsRead++;
                        }
                    }
                }
            }
            catch (SpannerException e)
            {
                exceptionCaught = true;
                Assert.Equal(ErrorCode.InvalidArgument, e.ErrorCode);
                Assert.False(e.IsTransientSpannerFault());
            }

            Assert.True(exceptionCaught);
            Assert.Equal(0, rowsRead);
        }

        [Fact]
        public async Task CancelRead()
        {
            // ReSharper disable once RedundantAssignment
            var exceptionCaught = false;
            try
            {
                using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
                {
                    var cmd = connection.CreateSelectCommand(
                        "SELECT * FROM " + _testFixture.TestTable);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        var cancellationTokenSource =
                            new CancellationTokenSource();
                        var task = reader.ReadAsync(cancellationTokenSource.Token);
                        cancellationTokenSource.Cancel();
                        await task;
                    }
                }
            }
            catch (OperationCanceledException e)
            {
                exceptionCaught = true;
                Assert.False(e.IsTransientSpannerFault());
            }

            Assert.True(exceptionCaught);
        }

        [Fact]
        public async Task EmptyStructArray()
        {
            var sqlQuery = "SELECT ARRAY(SELECT AS STRUCT * FROM (SELECT 'a', 1) WHERE 0 = 1)";
            var result = await ExecuteAsync<IList>(sqlQuery);
            Assert.Equal(0, result.Count);
        }

        [Fact]
        public async Task NaN()
        {
            double result = await ExecuteAsync<double>("SELECT IEEE_DIVIDE(0, 0)");
            Assert.True(double.IsNaN(result));
        }

        [Fact]
        public async Task NaNArray()
        {
            var result =
                await ExecuteAsync<double[]>(
                    "SELECT [IEEE_DIVIDE(1, 0), IEEE_DIVIDE(-1, 0), IEEE_DIVIDE(0, 0)]");
            Assert.Equal(3, result.Length);
            Assert.True(double.IsPositiveInfinity(result[0]));
            Assert.True(double.IsNegativeInfinity(result[1]));
            Assert.True(double.IsNaN(result[2]));
        }

        [Fact]
        public async Task NegativeInf()
        {
            double result = await ExecuteAsync<double>("SELECT IEEE_DIVIDE(-1, 0)");
            Assert.True(double.IsNegativeInfinity(result));
        }

        [Fact]
        public async Task PointRead()
        {
            // ReSharper disable once RedundantAssignment
            int rowsRead = -1;

            using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
            {
                var cmd = connection.CreateSelectCommand(
                    "SELECT * FROM " + _testFixture.TestTable
                    + " WHERE Key = 'k1'");
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    rowsRead = 0;
                    while (await reader.ReadAsync())
                    {
                        Assert.Equal("k1", reader.GetString(0));
                        Assert.Equal("v1", reader.GetString(1));
                        rowsRead++;
                    }
                }
            }
            Assert.Equal(1, rowsRead);
        }

        [Fact]
        public async Task PointReadEmpty()
        {
            // ReSharper disable once RedundantAssignment
            int rowsRead = -1;

            using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
            {
                var cmd = connection.CreateSelectCommand(
                    "SELECT * FROM " + _testFixture.TestTable
                    + " WHERE Key = 'k99'");
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    rowsRead = 0;
                    while (await reader.ReadAsync())
                    {
                        rowsRead++;
                    }
                }
            }
            Assert.Equal(0, rowsRead);
        }

        [Fact]
        public async Task PositiveInf()
        {
            double result = await ExecuteAsync<double>("SELECT IEEE_DIVIDE(1, 0)");
            Assert.True(double.IsPositiveInfinity(result));
        }

        [Fact]
        public async Task QueryTypo()
        {
            // ReSharper disable once RedundantAssignment
            int rowsRead = -1;
            var exceptionCaught = false;

            try
            {
                using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
                {
                    var cmd = connection.CreateSelectCommand(
                        "SLECT * FROM " + _testFixture.TestTable);
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        rowsRead = 0;
                        while (await reader.ReadAsync())
                        {
                            rowsRead++;
                        }
                    }
                }
            }
            catch (SpannerException e)
            {
                exceptionCaught = true;
                Debug.WriteLine("TestBadColumnName: Caught error code:" + e.ErrorCode);
                Assert.Equal(ErrorCode.InvalidArgument, e.ErrorCode);
                Assert.False(e.IsTransientSpannerFault());
            }

            Assert.True(exceptionCaught);
            Assert.True(rowsRead < 1);
        }

        [Fact]
        public async Task ReadyEmpty()
        {
            // ReSharper disable once RedundantAssignment
            int rowsRead = -1;

            using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
            {
                var cmd = connection.CreateSelectCommand(
                    "SELECT * FROM " + _testFixture.TestTable
                    + " WHERE Key >= 'k99'");
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    rowsRead = 0;
                    while (await reader.ReadAsync())
                    {
                        rowsRead++;
                    }
                }
            }
            Assert.Equal(0, rowsRead);
        }

        [Fact]
        public async Task SelectOne()
        {
            long result = await ExecuteAsync<long>("SELECT 1");
            Assert.Equal(1, result);
        }

        [Fact]
        public async Task StructArray()
        {
            string sqlQuery = "SELECT ARRAY(SELECT AS STRUCT C1, C2 "
                + "FROM (SELECT 'a' AS C1, 1 AS C2 UNION ALL SELECT 'b' AS C1, 2 AS C2) "
                + "ORDER BY C1 ASC)";
            var result = await ExecuteAsync<IList>(sqlQuery);
            Assert.Equal(2, result.Count);
            var s1 = result[0] as IDictionary;

            Assert.Equal("a", (string) s1["C1"]);
            Assert.Equal(1, (long) s1["C2"]);

            s1 = result[1] as IDictionary;
            Assert.Equal("b", (string) s1["C1"]);
            Assert.Equal(2, (long) s1["C2"]);
        }
    }
}
