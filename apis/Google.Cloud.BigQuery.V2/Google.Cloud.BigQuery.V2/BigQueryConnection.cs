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
using Google.Api.Gax;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Bigquery.v2.Data;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// </summary>
    public sealed partial class BigQueryConnection : DbConnection
    {
        private BigQueryConnectionStringBuilder _connectionStringBuilder;
        private ConnectionState _state;

        /// <summary>
        /// Creates a BigQueryConnection with no datasource or credential specified.
        /// </summary>
        public BigQueryConnection()
        {
        }

        /// <summary>
        /// Creates a BigQueryConnection with a datasource contained in connectionString
        /// and optional credential information supplied in connectionString or the credential
        /// argument.
        /// </summary>
        /// <param name="connectionString">
        /// A BigQuery formatted connection string. This is usually of the form
        /// `Data Source=projects/{project}/datasets/{datasetid}`
        /// </param>
        /// <param name="credential">An optional credential for operations to be performed on the BigQuery database.  May be null.</param>
        public BigQueryConnection(string connectionString, GoogleCredential credential = null)
            : this(new BigQueryConnectionStringBuilder(connectionString, credential))
        {
        }

        /// <summary>
        /// Creates a BigQueryConnection with a datasource contained in connectionString.
        /// </summary>
        /// <param name="connectionStringBuilder">
        /// A BigQueryConnectionStringBuilder containing a formatted connection string.  Must not be null.
        /// </param>
        public BigQueryConnection(BigQueryConnectionStringBuilder connectionStringBuilder)
        {
            GaxPreconditions.CheckNotNull(connectionStringBuilder, nameof(connectionStringBuilder));
            TrySetNewConnectionInfo(connectionStringBuilder);
        }

        internal BigQueryClient GetBigQueryClient()
        {
            AssertOpen();
            return BigQueryClient;
        }

        internal string GetProjectId()
        {
            return _connectionStringBuilder.Project;
        }

        internal string GetDatasetId()
        {
            return _connectionStringBuilder.BigQueryDataset;
        }

        internal BigQueryClient BigQueryClient { get; private set; }

        /// <inheritdoc />
        public override string ConnectionString
        {
            get => _connectionStringBuilder?.ToString();
            set => TrySetNewConnectionInfo(
                new BigQueryConnectionStringBuilder(value, _connectionStringBuilder?.Credential));
        }

        /// <inheritdoc />
        public override string Database => _connectionStringBuilder?.BigQueryDataset;

        /// <inheritdoc />
        public override ConnectionState State => _state;

        /// <inheritdoc />
        public override string DataSource => _connectionStringBuilder?.DataSource;

        /// <inheritdoc />
        public override string ServerVersion { get; } = "0.0";

        internal bool IsClosed => (State & ConnectionState.Open) == 0;

        internal bool IsOpen => (State & ConnectionState.Open) == ConnectionState.Open;

        internal BigQueryClient GetOpenedBigQueryClient()
        {
            AssertOpen();
            return BigQueryClient;
        }


        /// <inheritdoc />
        protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel) =>
            throw new NotSupportedException("BigQuery does not support transactions.");

        /// <inheritdoc />
        public override void ChangeDatabase(string newDataSource)
        {
            if (IsOpen)
                Close();

            TrySetNewConnectionInfo(_connectionStringBuilder?.CloneWithNewDataSource(newDataSource));
        }

        /// <inheritdoc />
        public override void Close()
        {
            _state = ConnectionState.Closed;
        }

        /// <inheritdoc />
        public override void Open()
        {
            if (IsOpen)
                return;
            BigQueryClient = BigQueryClient.Create(_connectionStringBuilder.Project,
                _connectionStringBuilder.Credential);
            _state = ConnectionState.Open;
        }

        /// <summary>
        /// </summary>
        public TableReference GetTableReference(string tableId) =>
            GetBigQueryClient().GetTableReference(_connectionStringBuilder.Project,
                _connectionStringBuilder.BigQueryDataset, tableId);

        /// <summary>
        /// </summary>
        public TableReference GetTableReference(string dataSetId, string tableId) =>
            GetBigQueryClient().GetTableReference(_connectionStringBuilder.Project, dataSetId, tableId);

        /// <summary>
        /// </summary>
        public TableReference GetTableReference(string projectId, string dataSetId, string tableId) =>
            GetBigQueryClient().GetTableReference(projectId, dataSetId, tableId);

        internal DatasetReference GetDatasetReference() => GetBigQueryClient()
            .GetDatasetReference(GetProjectId(), GetDatasetId());

        /// <inheritdoc />
        protected override DbCommand CreateDbCommand() => new BigQueryCommand();

        private void TrySetNewConnectionInfo(BigQueryConnectionStringBuilder newBuilder)
        {
            AssertClosed("change connection information.");
            // We will never allow our internal connectionstringbuilder to be touched from the outside, so its cloned.
            _connectionStringBuilder = newBuilder.Clone();
        }

        private void AssertClosed(string message)
        {
            if (!IsClosed)
                throw new InvalidOperationException("The connection must be closed. Failed to " + message);
        }

        private void AssertOpen()
        {
            if (!IsOpen)
                throw new InvalidOperationException("The connection must be open for this operation.");
        }
    }
}