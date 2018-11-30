// Copyright 2018 Google LLC
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

using Google.Cloud.Spanner.Data.CommonTesting;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [CollectionDefinition(nameof(DmlTableFixture))]
    public class DmlTableFixture : SpannerTableFixture, ICollectionFixture<DmlTableFixture>
    {
        public DmlTableFixture() : base("DmlTest")
        {
        }

        protected override void CreateTable()
        {
            ExecuteDdl($@"CREATE TABLE {TableName} (
                          Key           STRING(MAX) NOT NULL,
                          OriginalValue INT64,
                          Value         INT64,
                          UpdateMe      BOOL,
                          DeleteMe      BOOL,
                          CopyMe        BOOL,
                          ) PRIMARY KEY (Key, OriginalValue)");
        }

        /// <summary>
        /// Each test is able to use a different set of rows, varied by key value K.
        /// This method creates the rows with a random K and returns K.
        /// </summary>
        public string CreateTestRows([CallerMemberName] string testName = null)
        {
            string key = $"{testName} - {Guid.NewGuid()}";
            Insert(0, false, false, false);
            Insert(1, true, false, false);
            Insert(2, false, true, false);
            Insert(3, false, false, true);
            Insert(4, true, true, true);

            void Insert(int value, bool update, bool delete, bool copy)
            {
                RetryHelpers.ExecuteWithRetry(() =>
                {
                    using (var connection = GetConnection())
                    {
                        using (var command = connection.CreateInsertCommand(TableName))
                        {
                            command.Parameters.Add("Key", SpannerDbType.String, key);
                            command.Parameters.Add("OriginalValue", SpannerDbType.Int64, value);
                            command.Parameters.Add("Value", SpannerDbType.Int64, value);
                            command.Parameters.Add("UpdateMe", SpannerDbType.Bool, update);
                            command.Parameters.Add("DeleteMe", SpannerDbType.Bool, delete);
                            command.Parameters.Add("CopyMe", SpannerDbType.Bool, copy);
                            RetryHelpers.ExecuteWithRetry(() => command.ExecuteNonQuery());
                        }
                    }
                });
            }
            return key;
        }

        public Dictionary<int, int> FetchValues(string key, SpannerTransaction transaction = null)
        {
            using (var connection = GetConnection())
            {
                using (var command = connection.CreateSelectCommand($"SELECT OriginalValue, Value FROM {TableName} WHERE Key=@key"))
                {
                    if (transaction != null)
                    {
                        command.Transaction = transaction;
                    }
                    command.Parameters.Add("key", SpannerDbType.String, key);
                    using (var reader = command.ExecuteReader())
                    {
                        var dictionary = new Dictionary<int, int>();
                        while (reader.Read())
                        {
                            dictionary.Add(reader.GetInt32(0), reader.GetInt32(1));
                        }
                        return dictionary;
                    }
                }
            }
        }
    }
}
