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
    public sealed partial class BigQueryCommand : DbCommand
    {
        /// <inheritdoc />
        public override void Cancel()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override int ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override object ExecuteScalar()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override void Prepare()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override string CommandText { get; set; }
        /// <inheritdoc />
        public override int CommandTimeout { get; set; }
        /// <inheritdoc />
        public override CommandType CommandType { get; set; }
        /// <inheritdoc />
        public override UpdateRowSource UpdatedRowSource { get; set; }
        /// <inheritdoc />
        protected override DbConnection DbConnection { get; set; }
        /// <inheritdoc />
        protected override DbParameterCollection DbParameterCollection { get; }
        /// <inheritdoc />
        protected override DbTransaction DbTransaction { get; set; }
        /// <inheritdoc />
        public override bool DesignTimeVisible { get; set; }

        /// <inheritdoc />
        protected override DbParameter CreateDbParameter()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior)
        {
            throw new NotImplementedException();
        }
    }
}
