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
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// </summary>
    public sealed class BigQueryDataReader : DbDataReader
    {
        private readonly GetQueryResultsOptions _resultOptions;
        private readonly BigQueryConnection _connectionToClose;
        private IAsyncEnumerator<BigQueryRow> _results;
        private bool _isEnumerating;

        internal BigQueryDataReader(BigQueryConnection connectionToClose)
        {
            _connectionToClose = connectionToClose;
            _isEnumerating = true;
        }
        internal BigQueryDataReader(IAsyncEnumerable<BigQueryRow> results,
            BigQueryConnection connectionToClose = null) : this(connectionToClose)
        {
            GaxPreconditions.CheckNotNull(results, nameof(results));
            _results = results.GetEnumerator();
        }

        internal BigQueryDataReader(BigQueryJob job,
            GetQueryResultsOptions resultOptions = null,
            BigQueryConnection connectionToClose = null) : this(connectionToClose)
        {
            _resultOptions = resultOptions;
            GaxPreconditions.CheckNotNull(job, nameof(job));
            BigQueryJob = job;
        }

        internal BigQueryDataReader(BigQueryResults bigQueryResults)
        {
            GaxPreconditions.CheckNotNull(bigQueryResults, nameof(bigQueryResults));
            BigQueryResults = bigQueryResults;
        }


#if NET45

        /// <inheritdoc />
        public override void Close()
        {
            _results?.Dispose();
            _connectionToClose?.Close();
        }

        /// <inheritdoc />
        public override System.Data.DataTable GetSchemaTable()
        {
            // We cannot throw here as some scenarios (datatable) will call this method
            return null;
        }
#endif

        /// <inheritdoc />
        public override bool NextResult()
        {
            return false;
        }

        /// <inheritdoc />
        public override bool Read()
            => ReadAsync(CancellationToken.None).ResultWithUnwrappedExceptions();

        /// <inheritdoc />
        public override async Task<bool> ReadAsync(CancellationToken cancellationToken) 
            => _isEnumerating = await MoveNextAsync(cancellationToken).ConfigureAwait(false);

        /// <inheritdoc />
        public override int Depth => 0;

        /// <inheritdoc />
        public override bool HasRows => _isEnumerating && _results?.Current != null;

        /// <inheritdoc />
        public override bool IsClosed => !_isEnumerating;

        /// <inheritdoc />
        public override object this[int i] => Current?[i];

        /// <inheritdoc />
        public override object this[string name] => Current?[name];

        /// <inheritdoc />
        public override int RecordsAffected => -1;

        /// <inheritdoc />
        public override bool GetBoolean(int i) => GetFieldValue<bool>(i);

        /// <inheritdoc />
        public override byte GetByte(int i) => GetFieldValue<byte>(i);

        /// <inheritdoc />
        public override long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length) => throw
            new NotSupportedException("BigQuery does not support conversion to byte arrays.");

        /// <inheritdoc />
        public override char GetChar(int i) => GetFieldValue<char>(i);

        /// <inheritdoc />
        public override long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length) => throw
            new NotSupportedException("BigQuery does not support conversion to char arrays.");

        /// <inheritdoc />
        public override string GetDataTypeName(int i) => Current?.Schema.Fields[i].GetFieldType().ToString();

        /// <inheritdoc />
        public override DateTime GetDateTime(int i) => GetFieldValue<DateTime>(i);

        /// <inheritdoc />
        public override decimal GetDecimal(int i) => GetFieldValue<decimal>(i);

        /// <inheritdoc />
        public override double GetDouble(int i) => GetFieldValue<double>(i);

        /// <inheritdoc />
        public override IEnumerator GetEnumerator()
        {
#if NET45 || NET451
            return new DbEnumerator(this);
#else
            throw new NotSupportedException("GetEnumerator not yet supported in .NET Core");
#endif
        }

        /// <inheritdoc />
        public override Type GetFieldType(int i) => Current?.Schema.Fields[i].ToClrType();

        /// <inheritdoc />
        public override T GetFieldValue<T>(int ordinal) 
            => (T)Convert.ChangeType(Current?[ordinal], typeof(T));

        /// <summary>
        /// </summary>
        public T GetFieldValue<T>(string columnName) => GetFieldValue<T>(GetOrdinal(columnName));

        /// <inheritdoc />
        public override float GetFloat(int i) => GetFieldValue<float>(i);

        /// <inheritdoc />
        public override Guid GetGuid(int i) => GetFieldValue<Guid>(i);

        /// <inheritdoc />
        public override short GetInt16(int i) => GetFieldValue<short>(i);

        /// <inheritdoc />
        public override int GetInt32(int i) => GetFieldValue<int>(i);

        /// <inheritdoc />
        public override long GetInt64(int i) => GetFieldValue<long>(i);

        /// <inheritdoc />
        public override string GetName(int i) => Current?.Schema.Fields[i].Name;

        /// <inheritdoc />
        public override int GetOrdinal(string name)
        {
            var fields = Current?.Schema.Fields;
            if (fields == null)
            {
                return -1;
            }

            var index = 0;
            foreach (var field in fields)
            {
                if (field.Name == name)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        /// <inheritdoc />
        public override string GetString(int i) => GetFieldValue<string>(i);

        /// <inheritdoc />
        public override object GetValue(int i) => this[i];

        /// <inheritdoc />
        public override int GetValues(object[] values)
        {
            var count = Math.Min(FieldCount, values.Length);
            for (var i = 0; i < count; i++)
            {
                values[i] = this[i];
            }

            return count;
        }

        /// <summary>
        /// </summary>
        public override bool IsDBNull(int ordinal) => GetValue(ordinal) == null;

        /// <inheritdoc />
        public override int FieldCount => Current?.Schema.Fields.Count ?? 0;

        /// <inheritdoc />
        protected override void Dispose(bool disposing)
        {
            _results?.Dispose();
            _connectionToClose?.Close();
            base.Dispose(disposing);
        }

        private BigQueryRow Current => _isEnumerating ? _results?.Current : null;

        /// <summary>
        /// </summary>
        private BigQueryJob BigQueryJob { get; }

        private BigQueryResults BigQueryResults { get; }

        private async Task<bool> MoveNextAsync(CancellationToken cancellationToken)
        {
            var results = await GetResultsAsync(cancellationToken).ConfigureAwait(false);
            return await results.MoveNext().ConfigureAwait(false);
        }
        private async Task<IAsyncEnumerator<BigQueryRow>> GetResultsAsync(CancellationToken cancellationToken)
        {
            if (_results != null)
            {
                return _results;
            }
            if (_results == null && BigQueryJob != null)
            {
                var results = await BigQueryJob.GetQueryResultsAsync(_resultOptions, cancellationToken)
                    .ConfigureAwait(false);
                _results = results?.GetRowsAsync().GetEnumerator();
            }
            if (_results == null && BigQueryResults != null)
            {
                _results = BigQueryResults.GetRowsAsync().GetEnumerator();
            }

            return _results;
        }
    }
}
