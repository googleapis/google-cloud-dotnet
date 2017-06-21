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

using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Google.Cloud.Spanner.Data.StressTests
{
    internal class MySqlStressTests : BaseStressTest
    {
        private static readonly string s_guid = Guid.NewGuid().ToString();
        private static int s_myCounter = 1;

        protected override async Task<long> TestWrite1(Stopwatch sw)
        {
            await Task.Yield(); //We immediately yield to allow the spawning thread to continue.
            var connection = new MySqlConnection(Program.MySqlConnectionString);
            var localCounter = Interlocked.Increment(ref s_myCounter);
            await connection.OpenAsync();
            var insertCommand = connection.CreateCommand();
            insertCommand.CommandText = "INSERT INTO bookTable (ID, Title) VALUES (@ID, @Title)";
            insertCommand.Parameters.Add(new MySqlParameter("@ID", MySqlDbType.String));
            insertCommand.Parameters.Add(new MySqlParameter("@Title", MySqlDbType.String));

            insertCommand.Parameters["@ID"].Value = $"{s_guid}{localCounter}";
            insertCommand.Parameters["@Title"].Value = "Title";
            await insertCommand.ExecuteNonQueryAsync();

            await connection.CloseAsync();
            connection.Dispose();
            return sw.ElapsedMilliseconds;
        }
    }
}