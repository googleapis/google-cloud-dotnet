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

using System.Data.Common;
using Google.Cloud.Spanner.Data;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Microsoft.EntityFrameworkCore.Storage.Internal
{
    /// <summary>
    /// This is internal functionality and not intended for public use.
    /// </summary>
    public class SpannerRelationalConnection : RelationalConnection, ISpannerRelationalConnection
    {
        //Note: Wraps around a SpannerConnection.  It also sets up the log bridge for ADO.NET logs
        // to be seen in EF logs and has logic to set up a connection to the "master" db -- which in the spanner
        // world is simply a connection string that does not include a database.

        /// <summary>
        /// This is internal functionality and not intended for public use.
        /// </summary>
        public SpannerRelationalConnection(RelationalConnectionDependencies dependencies)
            : base(dependencies)
        {
        }

        /// <inheritdoc />
        public override bool IsMultipleActiveResultSetsEnabled => true;

        /// <summary>
        /// </summary>
        public ISpannerRelationalConnection CreateMasterConnection()
        {
            var builder = new SpannerConnectionStringBuilder(ConnectionString);
            //Spanner actually has no master or admin db, so we just use a normal connection.
            var masterConn =
                new SpannerConnection($"Data Source=projects/{builder.Project}/instances/{builder.SpannerInstance}");
            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSpanner(masterConn);

            return new SpannerRelationalConnection(Dependencies.With(optionsBuilder.Options));
        }

        // TODO: Integrate Spanner logging with EF logging

        /// <inheritdoc />
        protected override DbConnection CreateDbConnection() => new SpannerConnection(ConnectionString);
    }
}