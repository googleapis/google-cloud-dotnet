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

using Google.Cloud.ClientTesting;

namespace Google.Cloud.Spanner.Data.CommonTesting
{
    /// <summary>
    /// Base classes for test fixtures for tables.
    /// </summary>
    public abstract class SpannerTableFixture : SpannerFixtureBase
    {
        public string TableName { get; }

        public SpannerTableFixture(string tableName)
        {
            TableName = tableName;
            if (Database.Fresh)
            {
                FileLogger.Log($"Creating table {TableName}");
                CreateTable();
            }
            RetryHelpers.ResetStats();
            FileLogger.Log($"Populating table {TableName}");
            PopulateTable(Database.Fresh);
            FileLogger.Log($"Ready to run tests");
            RetryHelpers.MaybeLogStats($"Population of {TableName}");
            RetryHelpers.ResetStats();
        }

        /// <summary>
        /// Creates the table. This method is only called when a new database has been created.
        /// </summary>
        protected abstract void CreateTable();

        /// <summary>
        /// Optional operation; populates the table, potentially doing different things based on whether
        /// the database is new or not.
        /// </summary>
        protected virtual void PopulateTable(bool fresh)
        {
        }

        protected void ExecuteDdl(string ddl)
        {
            using (var connection = GetConnection())
            {
                connection.CreateDdlCommand(ddl).ExecuteNonQuery();
            }
        }

        public override void Dispose()
        {
            base.Dispose();
            RetryHelpers.MaybeLogStats($"Disposal of fixture for {TableName}");
        }
    }
}
