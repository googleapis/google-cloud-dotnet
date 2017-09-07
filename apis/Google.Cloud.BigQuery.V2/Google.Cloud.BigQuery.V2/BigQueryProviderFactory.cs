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
#if NET45
using System;
#endif
using System.Data.Common;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Represents a set of methods for creating instances of the
    /// BigQuery data provider's implementation of the data source classes.
    /// </summary>
    public sealed class BigQueryProviderFactory : DbProviderFactory
    {
        /// <summary>
        /// The singleton instance of <see cref="BigQueryProviderFactory"/>
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public static readonly BigQueryProviderFactory Instance = new BigQueryProviderFactory();

        private BigQueryProviderFactory()
        {
        }

        /// <inheritdoc />
        public override DbCommand CreateCommand() => new BigQueryCommand();

        /// <inheritdoc />
        public override DbConnection CreateConnection() => new BigQueryConnection();

        /// <inheritdoc />
        public override DbConnectionStringBuilder CreateConnectionStringBuilder() =>
            new BigQueryConnectionStringBuilder();

        /// <inheritdoc />
        public override DbParameter CreateParameter() => new BigQueryParameter();

#if NET45
        /// <inheritdoc />
        public override DbDataAdapter CreateDataAdapter()
        {
            throw new NotSupportedException("BigQuery does not yet support DataAdapter");
        }
#endif
    }
}