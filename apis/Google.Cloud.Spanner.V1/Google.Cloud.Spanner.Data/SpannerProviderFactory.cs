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
using System.Data.Common;

namespace Google.Cloud.Spanner
{
    /// <summary>
    /// </summary>
    public sealed class SpannerProviderFactory : DbProviderFactory
    {
        /// <summary>
        ///     The default SpannerProviderFactory instance.
        /// </summary>
        public static readonly SpannerProviderFactory Instance = new SpannerProviderFactory();

        private SpannerProviderFactory()
        {
        }

        /// <inheritdoc />
        public override DbCommand CreateCommand()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override DbConnection CreateConnection()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override DbConnectionStringBuilder CreateConnectionStringBuilder()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override DbParameter CreateParameter()
        {
            throw new NotImplementedException();
        }

#if NET451

        /// <inheritdoc />
        public override DbDataAdapter CreateDataAdapter()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public SpannerCommandBuilder CreateSpannerCommandBuilder()
        {
            throw new NotImplementedException();
        }

#endif
    }
}