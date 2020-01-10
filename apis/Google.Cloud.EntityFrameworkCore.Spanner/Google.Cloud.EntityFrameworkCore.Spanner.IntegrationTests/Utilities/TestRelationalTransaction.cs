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
using System.Diagnostics;
using Google.Cloud.Spanner.Data;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;

namespace Microsoft.EntityFrameworkCore.Utilities
{
    public class TestRelationalTransaction : IDbContextTransaction, IInfrastructure<DbTransaction>
    {
        private readonly IDbContextTransaction _realTransaction;
        private readonly TestSpannerConnection _testConnection;
        private bool _connectionClosed;

        public TestRelationalTransaction(
            TestSpannerConnection connection, DbTransaction transaction, ILoggerFactory loggerFactory,
            DiagnosticSource diagnosticSource, bool transactionOwned)
            : this(
                connection,
                new RelationalTransaction(
                    connection,
                    transaction,
                    new DiagnosticsLogger<DbLoggerCategory.Database.Transaction>(
                        loggerFactory, new LoggingOptions(), diagnosticSource),
                    transactionOwned))
        {
        }

        public TestRelationalTransaction(TestSpannerConnection connection, IDbContextTransaction transaction)
        {
            _testConnection = connection;
            _realTransaction = transaction;
        }

        public virtual Guid TransactionId { get; } = Guid.NewGuid();

        public void Dispose()
        {
            _realTransaction.Dispose();

            ClearTransaction();
        }

        public void Commit()
        {
            if (_testConnection.CommitFailures.Count > 0)
            {
                var fail = _testConnection.CommitFailures.Dequeue();
                if (fail.HasValue)
                {
                    if (fail.Value)
                    {
                        _realTransaction.GetDbTransaction().Rollback();
                    }
                    else
                    {
                        _realTransaction.GetDbTransaction().Commit();
                    }
                    _testConnection.DbConnection.Close();
                    throw new SpannerException(ErrorCode.Unknown, $"SqlState = {_testConnection.ErrorCode}");
                }
            }

            _realTransaction.Commit();

            ClearTransaction();
        }

        public void Rollback()
        {
            _realTransaction.Rollback();

            ClearTransaction();
        }

        public DbTransaction Instance => _realTransaction.GetDbTransaction();

        private void ClearTransaction()
        {
            _testConnection.UseTransaction(null);

            if (!_connectionClosed)
            {
                _connectionClosed = true;

                _testConnection.Close();
            }
        }
    }
}