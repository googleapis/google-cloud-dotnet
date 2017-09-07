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

using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax;
using Google.Apis.Bigquery.v2.Data;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// A set of configuration options for a BigQuery command.
    /// </summary>
    public abstract class BigQueryCommandOptions
    {
        private BigQueryParameterMode _parameterMode = BigQueryParameterMode.Named;
        internal BigQueryConnection BigQueryConnection { get; set; }

        internal string CommandText { get; set; }

        internal int? CommandTimeout { get; set; }

        internal BigQueryParameterMode ParameterMode
        {
            get => _parameterMode;
            set => _parameterMode = GaxPreconditions.CheckEnumValue(value, nameof(value));
        }

        internal BigQueryParameterCollection Parameters { get; } = new BigQueryParameterCollection();

        /// <summary>
        /// The type of command currently configured. Currently the only valid value for this is
        /// <see cref="BigQueryCommandType.Sql"/>
        /// </summary>
        public abstract BigQueryCommandType BigQueryCommandType { get; }

        internal abstract Task<BigQueryJob> StartJobAsync(
            BigQueryConnection connection,
            CancellationToken cancellationToken);

        internal abstract Task<int> ExecuteNonQueryAsync(
            BigQueryConnection connection,
            CancellationToken cancellationToken);

        internal abstract Task<DbDataReader> ExecuteDbDataReaderAsync(
            BigQueryConnection connection,
            CommandBehavior behavior,
            CancellationToken cancellationToken);

        internal abstract void PopulateQueryRequest(QueryRequest queryRequest);

        internal abstract void PopulateJobConfigurationQuery(JobConfigurationQuery query);
    }
}