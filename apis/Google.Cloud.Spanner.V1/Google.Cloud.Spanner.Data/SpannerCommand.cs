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

// ReSharper disable UnusedParameter.Local

namespace Google.Cloud.Spanner
{
    /// <summary>
    /// 
    /// </summary>
    public class SpannerCommand : DbCommand
#if NET451
        , ICloneable
#endif
    {
        /// <summary>
        /// 
        /// </summary>
        public SpannerCommand()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commandTextBuilder"></param>
        /// <param name="connection"></param>
        /// <param name="transaction"></param>
        /// <param name="parameters"></param>
        public SpannerCommand(SpannerCommandTextBuilder commandTextBuilder, SpannerConnection connection,
            SpannerTransaction transaction = null, SpannerParameterCollection parameters = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commandText"></param>
        /// <param name="connection"></param>
        /// <param name="transaction"></param>
        /// <param name="parameters"></param>
        public SpannerCommand(string commandText, SpannerConnection connection, SpannerTransaction transaction = null,
            SpannerParameterCollection parameters = null)
            : this(SpannerCommandTextBuilder.FromCommandText(commandText), connection, transaction, parameters)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public SpannerCommandTextBuilder SpannerCommandTextBuilder
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        public override string CommandText
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        public override int CommandTimeout
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        public override CommandType CommandType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// 
        /// </summary>
        public SpannerConnection SpannerConnection
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        public override UpdateRowSource UpdatedRowSource
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

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


        /// <summary>
        /// 
        /// </summary>
        /// <param name="behavior"></param>
        /// <returns></returns>
        public DbDataReader ExecuteReaderImpl(CommandBehavior behavior)
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
        protected override void Dispose(bool disposing)
        {
            throw new NotImplementedException();
        }

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

        /// <inheritdoc />
        protected override DbConnection DbConnection
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// 
        /// </summary>
        public new SpannerParameterCollection Parameters
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        protected override DbParameterCollection DbParameterCollection
        {
            get { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        protected override DbTransaction DbTransaction
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        public override bool DesignTimeVisible
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}