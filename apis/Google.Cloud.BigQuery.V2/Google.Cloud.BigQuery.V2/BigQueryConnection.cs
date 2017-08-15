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
using System.Data;
using System.Data.Common;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// </summary>
    public sealed class BigQueryConnection : DbConnection
    {
        /// <inheritdoc />
        protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override void ChangeDatabase(string databaseName)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override void Close()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override void Open()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override string ConnectionString { get; set; }

        /// <inheritdoc />
        public override string Database { get; }

        /// <inheritdoc />
        public override ConnectionState State { get; }

        /// <inheritdoc />
        public override string DataSource { get; }

        /// <inheritdoc />
        public override string ServerVersion { get; }

        /// <inheritdoc />
        protected override DbCommand CreateDbCommand()
        {
            throw new NotImplementedException();
        }
    }
}
