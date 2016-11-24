// Copyright 2016 Google Inc. All Rights Reserved.
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

using Google.Api.Gax;
using Google.Apis.Bigquery.v2.Data;
using System.Linq;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// A SQL query (or DML command) to be sent to BigQuery, optionally
    /// including parameters.
    /// </summary>
    public sealed class BigQueryCommand
    {
        /// <summary>
        /// The SQL of the command. This must not be null by the time
        /// the command is executed.
        /// </summary>
        public string Sql { get; set; }

        private BigQueryParameterMode _parameterMode = BigQueryParameterMode.Named;
        /// <summary>
        /// The mode of the parameter, either named (for parameters such of the form <c>@myparam</c>)
        /// or positional (for parameters specified as <c>?</c> in the query).
        /// </summary>
        public BigQueryParameterMode ParameterMode
        {
            get { return _parameterMode; }
            set { _parameterMode = GaxPreconditions.CheckEnumValue(value, nameof(value)); }
        }

        /// <summary>
        /// The parameters used within this command.
        /// </summary>
        public BigQueryParameterCollection Parameters { get; } = new BigQueryParameterCollection();

        /// <summary>
        /// Constructs an instance with no SQL set yet.
        /// </summary>
        public BigQueryCommand()
        {
        }

        /// <summary>
        /// Constructs an instance for the given SQL.
        /// </summary>
        /// <param name="sql">The SQL to execute.</param>
        public BigQueryCommand(string sql)
        {
            Sql = sql;
        }

        internal void PopulateQueryRequest(QueryRequest queryRequest)
        {
            queryRequest.Query = Sql;
            // Safe for now; we only have "named" or "positional". This is unlikely to change.
            queryRequest.ParameterMode = ParameterMode.ToString().ToLowerInvariant();
            queryRequest.QueryParameters = Parameters.Select(p => p.ToQueryParameter(ParameterMode)).ToList();
        }

        internal void PopulateJobConfigurationQuery(JobConfigurationQuery query)
        {
            query.Query = Sql;
            // Safe for now; we only have "named" or "positional". This is unlikely to change.
            query.ParameterMode = ParameterMode.ToString().ToLowerInvariant();
            query.QueryParameters = Parameters.Select(p => p.ToQueryParameter(ParameterMode)).ToList();
        }
    }
}
