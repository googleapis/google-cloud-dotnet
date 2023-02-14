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

using Google.Cloud.ClientTesting;
using Google.Cloud.Spanner.Data.CommonTesting;
using System;
using System.Data;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    /// <summary>
    /// Integration tests to ensure that <see cref="SpannerDataAdapter"/> works properly.
    /// </summary>
    [Collection(nameof(DataAdapterTableFixture))]
    [CommonTestDiagnostics]
    public class DataAdapterTests
    {
        private readonly DataAdapterTableFixture _fixture;

        public DataAdapterTests(DataAdapterTableFixture fixture) =>
            _fixture = fixture;

        [Fact]
        public void AdapterFill()
        {
            using (var connection = _fixture.GetConnection())
            {
                var adapter = new SpannerDataAdapter(connection, _fixture.TableName, "Key");

                var testDataSet = new DataSet();
                adapter.Fill(testDataSet);
                Assert.Equal(1, testDataSet.Tables.Count);
                Assert.Equal(2, testDataSet.Tables[0].Columns.Count);
                Assert.Equal(_fixture.RowCount, testDataSet.Tables[0].Rows.Count);
            }
        }

        [Fact]
        public void AdapterDeleteInsert()
        {
            RetryHelpers.ExecuteWithRetry(() =>
            {
                using (var connection = _fixture.GetConnection())
                {
                    var adapter = new SpannerDataAdapter(connection, _fixture.TableName, "Key");

                    //Load
                    var testDataSet = new DataSet();
                    adapter.Fill(testDataSet);
                    var k0 = testDataSet.Tables[0].Rows[0]["Key"];
                    var stringValue0 = testDataSet.Tables[0].Rows[0]["StringValue"];
                    Assert.IsType<string>(k0);
                    Assert.IsType<string>(stringValue0);

                    //Delete, reload
                    testDataSet.Tables[0].Rows[0].Delete();
                    adapter.Update(testDataSet);
                    testDataSet.Clear();
                    adapter.Fill(testDataSet);
                    Assert.Equal(_fixture.RowCount - 1, testDataSet.Tables[0].Rows.Count);

                    //insert, reload
                    var newRow = testDataSet.Tables[0].NewRow();
                    newRow["Key"] = k0;
                    newRow["StringValue"] = stringValue0;
                    testDataSet.Tables[0].Rows.Add(newRow);
                    adapter.Update(testDataSet);
                    testDataSet.Clear();
                    adapter.Fill(testDataSet);
                    Assert.Equal(_fixture.RowCount, testDataSet.Tables[0].Rows.Count);
                }
            });
        }

        [Fact]
        public void AdapterUpdate()
        {
            RetryHelpers.ExecuteWithRetry(() =>
            {
                using (var connection = _fixture.GetConnection())
                {
                    var adapter = new SpannerDataAdapter(connection, _fixture.TableName, "Key");

                    //Load
                    var testDataSet = new DataSet();
                    adapter.Fill(testDataSet);

                    //update, reload
                    var newValue = IdGenerator.FromGuid();
                    var oldKey = testDataSet.Tables[0].Rows[1]["Key"];
                    testDataSet.Tables[0].Rows[1]["StringValue"] = newValue;
                    adapter.Update(testDataSet);
                    testDataSet.Clear();
                    adapter.Fill(testDataSet);
                    int i = 0;
                    for (; i < testDataSet.Tables[0].Rows.Count; i++)
                    {
                        if (testDataSet.Tables[0].Rows[i]["Key"].Equals(oldKey))
                        {
                            break;
                        }
                    }
                    var row = testDataSet.Tables[0].Rows.Cast<DataRow>()
                                    .FirstOrDefault(r => r["Key"].Equals(oldKey));
                    Assert.NotNull(row);
                    Assert.Equal(newValue, row["StringValue"]);
                }
            });
        }

        [Fact]
        public void AdapterOverrideSelect()
        {
            RetryHelpers.ExecuteWithRetry(() =>
            {

                using (var connection = _fixture.GetConnection())
                {
                    var adapter = new SpannerDataAdapter(connection, _fixture.TableName, "Key")
                    {
                        SelectCommand =
                            connection.CreateSelectCommand(
                                $"SELECT * FROM {_fixture.TableName} WHERE Key='k2'")
                    };

                    //Load
                    var testDataSet = new DataSet();
                    adapter.Fill(testDataSet);
                    Assert.Equal(1, testDataSet.Tables[0].Rows.Count);

                    //update, reload (update still works even with an overloaded selectcommand)
                    string newValue = IdGenerator.FromGuid();
                    testDataSet.Tables[0].Rows[0]["StringValue"] = newValue;
                    adapter.Update(testDataSet);
                    testDataSet.Clear();
                    adapter.Fill(testDataSet);
                    Assert.Equal(newValue, testDataSet.Tables[0].Rows[0]["StringValue"]);
                }
            });
        }
    }
}
