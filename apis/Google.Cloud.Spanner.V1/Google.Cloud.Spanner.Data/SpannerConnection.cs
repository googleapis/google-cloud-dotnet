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
using Google.Apis.Auth.OAuth2;

// ReSharper disable UnusedParameter.Local

namespace Google.Cloud.Spanner
{
    /// <summary>
    /// </summary>
    public class SpannerConnection : DbConnection
    {
        /// <summary>
        /// </summary>
        public SpannerConnection()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="credential"></param>
        public SpannerConnection(string connectionString, ITokenAccess credential = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="connectionStringBuilder"></param>
        /// <param name="credential"></param>
        public SpannerConnection(SpannerConnectionStringBuilder connectionStringBuilder, ITokenAccess credential = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public SpannerBatchOperation BeginBatchOperation()
        {
            throw new NotImplementedException();
        }

#if NET451
        /// <inheritdoc />
        public override void EnlistTransaction(System.Transactions.Transaction transaction)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        protected override DbProviderFactory DbProviderFactory
        {
            get { throw new NotImplementedException(); }
        }
#endif

        /// <summary>
        /// </summary>
        public static ConnectionPoolOptions ConnectionPoolOptions
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// </summary>
        public ITokenAccess Credential
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        public override string ConnectionString
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        public override string Database
        {
            get { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        public override ConnectionState State
        {
            get { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        public override void Open()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="databaseTable"></param>
        /// <param name="insertParameters"></param>
        /// <returns></returns>
        public SpannerCommand CreateInsertCommand(string databaseTable, SpannerParameterCollection insertParameters = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="databaseTable"></param>
        /// <param name="updateParameters"></param>
        /// <returns></returns>
        public SpannerCommand CreateUpdateCommand(string databaseTable, SpannerParameterCollection updateParameters = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="databaseTable"></param>
        /// <param name="insertUpdateParameters"></param>
        /// <returns></returns>
        public SpannerCommand CreateInsertOrUpdateCommand(string databaseTable,
            SpannerParameterCollection insertUpdateParameters = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="databaseTable"></param>
        /// <param name="deleteFilterParameters"></param>
        /// <returns></returns>
        public SpannerCommand CreateDeleteCommand(string databaseTable,
            SpannerParameterCollection deleteFilterParameters = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="sqlQueryStatement"></param>
        /// <param name="selectParameters"></param>
        /// <returns></returns>
        public SpannerCommand CreateSelectCommand(string sqlQueryStatement,
            SpannerParameterCollection selectParameters = null)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override void Close()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        protected override void Dispose(bool disposing)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public SpannerTransaction BeginTransaction(TransactionMode mode = TransactionMode.ReadOnly)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="timestampBound"></param>
        /// <returns></returns>
        public SpannerTransaction BeginTransaction(TransactionMode mode,
            TimestampBound timestampBound)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override void ChangeDatabase(string newDataSource)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        protected override DbCommand CreateDbCommand()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override string DataSource
        {
            get { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        public override string ServerVersion
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// </summary>
        public string Project
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// </summary>
        public string SpannerInstance
        {
            get { throw new NotImplementedException(); }
        }
    }
}