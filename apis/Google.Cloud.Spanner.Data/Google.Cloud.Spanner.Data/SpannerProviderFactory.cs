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

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Represents a set of methods for creating instances of the Spanner data provider's implementation of the data source classes.
    /// </summary>
    public sealed class SpannerProviderFactory : DbProviderFactory
    {
        /// <summary>
        /// The default SpannerProviderFactory instance.
        /// This public static field is required for the providerfactory to work properly.
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public static readonly SpannerProviderFactory Instance = new SpannerProviderFactory();

        private SpannerProviderFactory() { }

        /// <inheritdoc />
        public override DbCommand CreateCommand() => new SpannerCommand();

        /// <inheritdoc />
        public override DbConnection CreateConnection() => new SpannerConnection();

        /// <inheritdoc />
        public override DbConnectionStringBuilder CreateConnectionStringBuilder() =>
            new SpannerConnectionStringBuilder();

        /// <inheritdoc />
        public override DbParameter CreateParameter() => new SpannerParameter();

#if NET45 || NET451

        /// <inheritdoc />
        public override DbDataAdapter CreateDataAdapter()
        {
            return new SpannerDataAdapter();
        }

#endif
    }
}
