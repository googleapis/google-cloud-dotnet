
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

using System.ComponentModel;
using System.Data;
using System.Data.Common;

using Google.Cloud.Spanner.Data;
using Google.Cloud.Spanner.V1;

using KeySet = Google.Cloud.Spanner.V1.KeySet;
using Transaction = System.Transactions.Transaction;

namespace Google.Cloud.Spanner.Data
{
    public interface ISpannerConnection : IDisposable
    {
        event StateChangeEventHandler? StateChange;

        event EventHandler? Disposed;

        string ConnectionString { get; set; }

        string Database { get; }

        string DataSource { get; }

        string Project { get; }

        string ServerVersion { get; }

        string SpannerInstance { get; }

        ConnectionState State { get; }

        ExecuteSqlRequest.Types.QueryOptions QueryOptions { get; set; }

        bool LogCommitStats { get; }

        bool EnlistInTransaction { get; set; }

        IContainer? Container { get; }

        ISite? Site { get; set; }

        int ConnectionTimeout { get; }

        bool CanCreateBatch { get; }

        Task<SpannerTransaction> BeginReadOnlyTransactionAsync(CancellationToken cancellationToken = default);

        Task<SpannerTransaction> BeginReadOnlyTransactionAsync(TimestampBound targetReadTimestamp, CancellationToken cancellationToken = default);

        SpannerTransaction BeginReadOnlyTransaction();

        SpannerTransaction BeginReadOnlyTransaction(TimestampBound targetReadTimestamp);

        SpannerTransaction BeginReadOnlyTransaction(TransactionId transactionId);

        SpannerTransaction BeginTransaction();

        DbTransaction BeginTransaction(IsolationLevel isolationLevel);

        Task<SpannerTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default);

        ValueTask<DbTransaction> BeginTransactionAsync(IsolationLevel isolationLevel, CancellationToken cancellationToken);

        Task<TResult> RunWithRetriableTransactionAsync<TResult>(Func<SpannerTransaction, Task<TResult>> asyncWork, CancellationToken cancellationToken = default);

        Task RunWithRetriableTransactionAsync(Func<SpannerTransaction, Task> asyncWork, CancellationToken cancellationToken = default);

        TResult RunWithRetriableTransaction<TResult>(Func<SpannerTransaction, TResult> work);

        void RunWithRetriableTransaction(Action<SpannerTransaction> work);

        void ChangeDatabase(string newDataSource);

        void Close();

        SpannerCommand CreateReadCommand(string databaseTable, ReadOptions readOptions, KeySet keySet);

        SpannerCommand CreateDeleteCommand(string databaseTable, SpannerParameterCollection primaryKeys = null);

        SpannerCommand CreateInsertCommand(string databaseTable, SpannerParameterCollection insertedColumns = null);

        SpannerCommand CreateInsertOrUpdateCommand(string databaseTable, SpannerParameterCollection insertUpdateColumns = null);

        SpannerCommand CreateSelectCommand(string sqlQueryStatement, SpannerParameterCollection selectParameters = null);

        SpannerCommand CreateCommandWithPartition(CommandPartition partition, SpannerTransaction transaction);

        SpannerCommand CreateUpdateCommand(string databaseTable, SpannerParameterCollection updateColumns = null);

        SpannerCommand CreateDdlCommand(string ddlStatement, params string[] extraDdlStatements);

        SpannerCommand CreateDmlCommand(string dmlStatement, SpannerParameterCollection dmlParameters = null);

        SpannerBatchCommand CreateBatchDmlCommand();

        void Open();

        Task OpenAsync(CancellationToken cancellationToken);

        Task OpenAsync();

        Task WhenSessionPoolReady(CancellationToken cancellationToken = default);

        Task ShutdownSessionPoolAsync(CancellationToken cancellationToken = default);

        SessionPool.DatabaseStatistics GetSessionPoolDatabaseStatistics();

        void OpenAsReadOnly(TimestampBound timestampBound = null);

        void OpenAsReadOnly(TransactionId transactionId);

        Task OpenAsReadOnlyAsync(TimestampBound timestampBound = null, CancellationToken cancellationToken = default);

        void EnlistTransaction(Transaction? transaction);

        string ToString();

        object GetLifetimeService();

        object InitializeLifetimeService();

        Task ChangeDatabaseAsync(string databaseName, CancellationToken cancellationToken);

        Task CloseAsync();

        DbBatch CreateBatch();

        DbCommand CreateCommand();

        ValueTask DisposeAsync();

        DataTable GetSchema();

        DataTable GetSchema(string collectionName);

        DataTable GetSchema(string collectionName, string?[] restrictionValues);

        Task<DataTable> GetSchemaAsync(CancellationToken cancellationToken);

        Task<DataTable> GetSchemaAsync(string collectionName, CancellationToken cancellationToken);

        Task<DataTable> GetSchemaAsync(string collectionName, string?[] restrictionValues, CancellationToken cancellationToken);
    }
}