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

using System;
using Google.Apis.Bigquery.v2.Data;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// A SQL query (or DML command) to be sent to BigQuery, optionally
    /// including parameters.
    /// </summary>
    public sealed partial class BigQueryCommand
    {
        /// <summary>
        /// The SQL of the command. This must not be null by the time
        /// the command is executed.
        /// </summary>
        [Obsolete("Please use the CommandText property")]
        public string Sql
        {
            get => CommandText;
            set => CommandText = value;
        }

        /// <summary>
        /// The mode of the parameter, either named (for parameters such of the form <c>@myparam</c>)
        /// or positional (for parameters specified as <c>?</c> in the query).
        /// </summary>
        public BigQueryParameterMode ParameterMode
        {
            get => CommandOptions.ParameterMode;
            set => CommandOptions.ParameterMode = value;
        }

        /// <summary>
        /// The parameters used within this command.
        /// </summary>
        public new BigQueryParameterCollection Parameters => CommandOptions.Parameters;

        /// <summary>
        /// Constructs an instance of a <see cref="BigQueryCommand"/>.
        /// </summary>
        public BigQueryCommand()
        {
        }

        /// <summary>
        /// Constructs an instance for the given SQL.
        /// </summary>
        /// <param name="commandText">The SQL to execute.</param>
        public BigQueryCommand(string commandText)
        {
            CommandText = commandText;
        }

        internal void PopulateQueryRequest(QueryRequest queryRequest)
            => CommandOptions.PopulateQueryRequest(queryRequest);

        internal void PopulateJobConfigurationQuery(JobConfigurationQuery query)
            => CommandOptions.PopulateJobConfigurationQuery(query);
    }
}
