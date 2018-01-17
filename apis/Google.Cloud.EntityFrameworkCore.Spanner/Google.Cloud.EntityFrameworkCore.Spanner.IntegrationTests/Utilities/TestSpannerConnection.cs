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
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;

namespace Microsoft.EntityFrameworkCore.Utilities
{
    public class TestSpannerConnection : ISpannerRelationalConnection
    {
        private readonly ISpannerRelationalConnection _realConnection;

        public TestSpannerConnection(RelationalConnectionDependencies dependencies)
            : this(new SpannerRelationalConnection(dependencies))
        {
        }

        protected TestSpannerConnection(ISpannerRelationalConnection connection)
            => _realConnection = connection;

        public string ErrorCode { get; set; } = "XX000";
        public Queue<bool?> OpenFailures { get; } = new Queue<bool?>();
        public int OpenCount { get; set; }
        public Queue<bool?> CommitFailures { get; } = new Queue<bool?>();
        public Queue<bool?> ExecutionFailures { get; } = new Queue<bool?>();
        public int ExecutionCount { get; set; }

        public virtual string ConnectionString => _realConnection.ConnectionString;
        public virtual DbConnection DbConnection => _realConnection.DbConnection;

        public virtual int? CommandTimeout
        {
            get => _realConnection.CommandTimeout;
            set => _realConnection.CommandTimeout = value;
        }

        public virtual IDbContextTransaction CurrentTransaction { get; private set; }

        public SemaphoreSlim Semaphore => new SemaphoreSlim(1);

        public virtual bool IsMultipleActiveResultSetsEnabled => _realConnection.IsMultipleActiveResultSetsEnabled;

        public Guid ConnectionId { get; } = Guid.NewGuid();

        public void RegisterBufferable(IBufferable bufferable)
        {
        }

        public Task RegisterBufferableAsync(IBufferable bufferable, CancellationToken cancellationToken)
            => Task.CompletedTask;

        public virtual bool Open(bool errorsExpected = false)
        {
            PreOpen();

            return _realConnection.Open(errorsExpected);
        }

        public virtual Task<bool> OpenAsync(CancellationToken cancellationToken, bool errorsExpected = false)
        {
            PreOpen();

            return _realConnection.OpenAsync(cancellationToken, errorsExpected);
        }

        private void PreOpen()
        {
            if (_realConnection.DbConnection.State == ConnectionState.Open)
            {
                return;
            }

            OpenCount++;
            if (OpenFailures.Count <= 0)
            {
                return;
            }
            var fail = OpenFailures.Dequeue();
            if (fail.HasValue)
            {
                throw new Exception($"error:{ErrorCode}");
            }
        }

        public virtual bool Close() => _realConnection.Close();

        public virtual IDbContextTransaction BeginTransaction()
            => BeginTransaction(IsolationLevel.Unspecified);

        public virtual Task<IDbContextTransaction> BeginTransactionAsync(
            CancellationToken cancellationToken = new CancellationToken())
            => BeginTransactionAsync(IsolationLevel.Unspecified, cancellationToken);

        public virtual IDbContextTransaction BeginTransaction(IsolationLevel isolationLevel)
        {
            Open();
            CurrentTransaction = new TestRelationalTransaction(this, _realConnection.BeginTransaction(isolationLevel));
            return CurrentTransaction;
        }

        public virtual async Task<IDbContextTransaction> BeginTransactionAsync(
            IsolationLevel isolationLevel, CancellationToken cancellationToken = new CancellationToken())
        {
            await OpenAsync(cancellationToken);
            CurrentTransaction = new TestRelationalTransaction(this,
                await _realConnection.BeginTransactionAsync(isolationLevel, cancellationToken));
            return CurrentTransaction;
        }

        public IDbContextTransaction UseTransaction(DbTransaction transaction)
        {
            var realTransaction = _realConnection.UseTransaction(transaction);
            if (realTransaction == null)
            {
                CurrentTransaction = null;
                return null;
            }

            Open();
            CurrentTransaction = new TestRelationalTransaction(this, realTransaction);
            return CurrentTransaction;
        }

        public void CommitTransaction() => CurrentTransaction.Commit();

        public void RollbackTransaction() => CurrentTransaction.Rollback();

        void IResettableService.ResetState() => Dispose();

        public void Dispose()
        {
            CurrentTransaction?.Dispose();

            _realConnection.Dispose();
        }

        public ISpannerRelationalConnection CreateMasterConnection() => new TestSpannerConnection(_realConnection
            .CreateMasterConnection());
    }
}