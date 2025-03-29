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

using Google.Api.Gax;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using TypeCode = Google.Cloud.Spanner.V1.TypeCode;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Reads a forward-only stream of rows from a data source.
    /// </summary>
    public sealed class SpannerDataReader : DbDataReader
    {
        private static long s_readerCount;

        private bool _rowValid = false;

        // Tristate:
        // - True if we've either checked already, or read a value
        // - False if we've either checked already, or failed or read a first value, or NextResult has been called
        // - Null if a call to HasRows should ask the reader.
        private bool? _hasRows = null;
        private readonly List<Value> _innerList = new List<Value>();
        private readonly ReliableStreamReader _resultSet;
        private ConcurrentDictionary<string, int> _fieldIndex;
        private ResultSetMetadata _metadata;
        private Timestamp _readTimestamp;
        private readonly IDisposable _resourceToClose;
        private readonly SpannerConversionOptions _conversionOptions;
        private readonly bool _provideSchemaTable;
        private readonly int _readTimeoutSeconds;

        // Lock for _closed; could possibly be removed and just used Interlocked, but this is simple.
        private readonly object _lock = new object();
        private bool _closed;

        internal SpannerDataReader(
            Logger logger,
            ReliableStreamReader resultSet,
            Timestamp readTimestamp,
            IDisposable resourceToClose,
            SpannerConversionOptions conversionOptions,
            bool provideSchemaTable,
            int readTimeoutSeconds)
        {
            GaxPreconditions.CheckNotNull(resultSet, nameof(resultSet));
            Logger = logger;
            Logger.LogPerformanceCounter(
                "SpannerDataReader.ActiveCount",
                () => Interlocked.Increment(ref s_readerCount));
            _resultSet = resultSet;
            _readTimestamp = readTimestamp;
            _resourceToClose = resourceToClose;
            _conversionOptions = conversionOptions;
            _provideSchemaTable = provideSchemaTable;
            _readTimeoutSeconds = readTimeoutSeconds;
        }

        private Logger Logger { get; }

        // Nesting is not supported, so we return 0.
        /// <inheritdoc />
        public override int Depth => 0;

        /// <inheritdoc />
        public override int FieldCount => PopulateMetadata().RowType.Fields.Count;

        /// <summary>
        /// Gets a value that indicates whether the SpannerDataReader contains one or more rows.
        /// If any rows have been read, this will continue to return true even when there are no more rows.
        /// </summary>
        public override bool HasRows =>
            // We only need to ask the result set if we haven't actually read any rows or checked before.
            _hasRows ?? (_hasRows = Task.Run(() => _resultSet.HasDataAsync(CancellationToken.None)).ResultWithUnwrappedExceptions()).Value;

        /// <inheritdoc />
        public override bool IsClosed => _resultSet.IsClosed;

        /// <inheritdoc />
        public override int RecordsAffected => -1;

        /// <inheritdoc />
        public override System.Type GetFieldType(int i)
        {
            var fieldMetadata = PopulateMetadata().RowType.Fields[i];
            return SpannerDbType.FromProtobufType(fieldMetadata.Type).GetConfiguredClrType(_conversionOptions);
        }

        /// <inheritdoc />
        public override T GetFieldValue<T>(int ordinal) =>
            GetSpannerFieldType(ordinal).ConvertToClrType<T>(GetJsonValue(ordinal), _conversionOptions);

        /// <summary>
        /// Gets the value of the specified column as type T.
        /// </summary>
        /// <typeparam name="T">The expected return type. If possible the return type will be converted to this type.
        /// If conversion is requested between incompatible types, an <see cref="InvalidOperationException"/>
        /// will be thrown.
        /// If the conversion fails due to the contents returned (for example a string representing a
        /// boolean does not have either 'true' or 'false') then a <see cref="FormatException"/> exception will be
        /// thrown as documented by the <see cref="Convert"/> class.</typeparam>
        /// <param name="columnName">The name of the column whose value will be returned. Must not be null.</param>
        /// <returns>The value of the column at the current row, converted to type T.</returns>
        public T GetFieldValue<T>(string columnName)
        {
            var ordinal = GetOrdinal(columnName);
            if (ordinal == -1)
            {
                throw new ArgumentException($"{columnName} is not a valid column", nameof(columnName));
            }
            return GetFieldValue<T>(ordinal);
        }

        // Field access helpers, all implemented via GetFieldValue.

        /// <inheritdoc />
        public override object this[int i] => GetFieldValue<object>(i);

        /// <inheritdoc />
        public override object this[string name] => this[GetOrdinal(name)];

        /// <inheritdoc />
        public override bool GetBoolean(int i) => GetFieldValue<bool>(i);

        /// <inheritdoc />
        public override byte GetByte(int i) => GetFieldValue<byte>(i);

        /// <inheritdoc />
        public override long GetBytes(int ordinal, long fieldOffset, byte[] buffer, int bufferOffset, int length)
        {
            GaxPreconditions.CheckArgument(GetSpannerFieldType(ordinal).TypeCode == TypeCode.Bytes, nameof(ordinal), "Spanner only supports conversion to byte arrays for columns of type BYTES.");
            GaxPreconditions.CheckArgumentRange(bufferOffset, nameof(bufferOffset), 0, buffer?.Length ?? 0);
            GaxPreconditions.CheckArgumentRange(length, nameof(length), 0, buffer?.Length ?? int.MaxValue);
            if (buffer != null)
            {
                GaxPreconditions.CheckArgumentRange(bufferOffset + length, nameof(length), 0, buffer.Length);
            }

            var bytes = IsDBNull(ordinal) ? null : GetFieldValue<byte[]>(ordinal);
            if (buffer == null)
            {
                // Return the length of the value if `buffer` is null:
                // https://docs.microsoft.com/en-us/dotnet/api/system.data.idatarecord.getbytes?view=netstandard-2.1#remarks
                return bytes?.Length ?? 0;
            }
            var copyLength = Math.Min(length, (bytes?.Length ?? 0) - (int)fieldOffset);
            if (copyLength < 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(fieldOffset), "Field offset exceeds the length of the field data");
            }
            if (bytes != null)
            {
                Array.Copy(bytes, (int) fieldOffset, buffer, bufferOffset, copyLength);
            }
            return copyLength;
        }

        /// <inheritdoc />
        public override char GetChar(int i) => GetFieldValue<char>(i);

        /// <inheritdoc />
        public override long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length) => throw
            new NotSupportedException("Spanner does not support conversion to char arrays.");

        /// <inheritdoc />
        public override string GetDataTypeName(int i) => GetSpannerFieldType(i).ToString();

        /// <inheritdoc />
        public override DateTime GetDateTime(int i) => GetFieldValue<DateTime>(i);

        /// <inheritdoc />
        public override decimal GetDecimal(int i) => GetFieldValue<decimal>(i);

        /// <inheritdoc />
        public override double GetDouble(int i) => GetFieldValue<double>(i);

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
        public override string GetString(int i) => GetFieldValue<string>(i);

        /// <summary>
        /// Gets the value of the specified column as type <see cref="Timestamp"/>.
        /// </summary>
        /// <param name="i">The index of the column to retrieve.</param>
        /// <returns>The value converted to a <see cref="Timestamp"/>.</returns>
        public Timestamp GetTimestamp(int i) => GetFieldValue<Timestamp>(i);

        /// <summary>
        /// Gets the value of the specified column as type <see cref="SpannerNumeric"/>.
        /// </summary>
        /// <param name="i">The index of the column to retrieve.</param>
        /// <returns>The value converted to a <see cref="SpannerNumeric"/>.</returns>
        public SpannerNumeric GetNumeric(int i) => GetFieldValue<SpannerNumeric>(i);

        /// <summary>
        /// Gets the value of the specified column as type <see cref="PgNumeric"/>.
        /// </summary>
        /// <param name="i">The index of the column to retrieve.</param>
        /// <returns>The value converted to a <see cref="PgNumeric"/>.</returns>
        public PgNumeric GetPgNumeric(int i) => GetFieldValue<PgNumeric>(i);

        /// <summary>
        /// Gets the value of the specified column as type <see cref="Interval"/>.
        /// </summary>
        /// <param name="i">The index of the column to retrieve.</param>
        /// <returns>The value converted to a <see cref="Interval"/>.</returns>
        public Interval GetInterval(int i) => GetFieldValue<Interval>(i);

        /// <summary>
        /// Gets the value of the specified column as type <see cref="SpannerDate"/>.
        /// </summary>
        /// <param name="i">The index of the column to retrieve.</param>
        /// <returns>The value converted to a <see cref="SpannerDate"/>.</returns>
        public SpannerDate GetSpannerDate(int i) => GetFieldValue<SpannerDate>(i);

        /// <inheritdoc />
        public override object GetValue(int i) => this[i];

        /// <inheritdoc />
        public override IEnumerator GetEnumerator() => new DbEnumerator(this);

        /// <summary>
        /// Gets the value of the specified column as a pure Protobuf type.
        /// </summary>
        /// <param name="i">The index of the column whose value will be returned.</param>
        /// <returns>The raw protobuf as a <see cref="Value"/>.</returns>
        /// <exception cref="InvalidOperationException">The reader is not currently positioned on a valid row.</exception>
        public Value GetJsonValue(int i)
        {
            GaxPreconditions.CheckState(_rowValid, "The reader is not currently positioned on a valid row.");
            return _innerList[i];
        }

        /// <inheritdoc />
        public override string GetName(int i) => PopulateMetadata().RowType.Fields[i].Name;

        /// <inheritdoc />
        public override int GetOrdinal(string name)
        {
            // We can complete synchronously so long as we have the metadata already.
            // (If we haven't already populated the field index, we can do so synchronously if there's metadata.)
            // The only time we *wouldn't* already have the metadata is if Read/ReadAsync hasn't already been
            // called. That isn't as uncommon as it sounds though, as it's not unreasonable to get the ordinals
            // of columns before entering a loop.
            GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name));
            if (_fieldIndex is null)
            {
                PopulateMetadata();
                InitializeFieldIndexFromMetadata();
            }
            return _fieldIndex[name];
        }

        /// <summary>
        /// Returns the column ordinal given the name of the column, asynchronously requesting metadata from
        /// the database if necessary.
        /// </summary>
        /// <param name="name">The name of the column.</param>
        /// <param name="cancellationToken">A cancellation token to cancel reading metadata. Defaults to <see cref="CancellationToken.None"/>.</param>
        /// <returns>The zero-based column ordinal.</returns>
        public async Task<int> GetOrdinalAsync(string name, CancellationToken cancellationToken = default)
        {
            GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name));
            if (_fieldIndex is null)
            {
                await PopulateMetadataAsync(cancellationToken).ConfigureAwait(false);
                InitializeFieldIndexFromMetadata();
            }
            return _fieldIndex[name];
        }

        /// <summary>
        /// Gets the read timestamp if <see cref="TimestampBound.ReturnReadTimestamp" /> was true
        /// else returns <c>null</c>.
        /// </summary>
        /// <remarks>
        /// The read timestamp can be read before <see cref="SpannerDataReader.Read"/> or
        /// <see cref="SpannerDataReader.ReadAsync"/> is called.
        /// </remarks>
        /// <remarks>
        /// The read timestamp is available even if no data is returned.
        /// </remarks>
        /// <returns>The value converted to a <see cref="Timestamp"/>, or <c>null</c> if
        /// <see cref="TimestampBound.ReturnReadTimestamp" /> was false.</returns>
        public Timestamp GetReadTimestamp()
        {
            if (_readTimestamp != null)
            {
                return _readTimestamp;
            }
            return Task.Run(() => GetReadTimestampAsync(CancellationToken.None)).ResultWithUnwrappedExceptions();
        }

        /// <summary>
        /// Gets the read timestamp if <see cref="TimestampBound.ReturnReadTimestamp" /> was true
        /// else returns <c>null</c>.
        /// </summary>
        /// <returns>The value converted to a <see cref="Timestamp"/>, or <c>null</c> if
        /// <see cref="TimestampBound.ReturnReadTimestamp" /> was false.</returns>
        public Task<Timestamp> GetReadTimestampAsync(CancellationToken cancellationToken)
        {
            if (_readTimestamp != null)
            {
                return Task.FromResult(_readTimestamp);
            }
            return ExecuteHelper.WithErrorTranslationAndProfiling(
                async () =>
                {
                    var metadata = await PopulateMetadataAsync(cancellationToken).ConfigureAwait(false);
                    _readTimestamp = metadata.Transaction?.ReadTimestamp;
		    return _readTimestamp;
                }, "SpannerDataReader.GetReadTimestamp", Logger);
        }

        // Initializes _fieldIndex, but should only be called after PopulateMetadata or PopulateMetadataAsync
        // is called. (These can still leave _metadata null, potentially.)
        private void InitializeFieldIndexFromMetadata()
        {
            _fieldIndex = new ConcurrentDictionary<string, int>();
            if (_metadata is object)
            {
                var i = 0;
                foreach (var field in _metadata.RowType.Fields)
                {
                    _fieldIndex[field.Name] = i;
                    i++;
                }
            }
        }

        /// <inheritdoc />
        public override int GetValues(object[] values)
        {
            int count = Math.Min(FieldCount, values.Length);
            for (var i = 0; i < count; i++)
            {
                values[i] = this[i];
            }

            return count;
        }

        /// <inheritdoc />
        public override bool IsDBNull(int i) => GetJsonValue(i).KindCase == Value.KindOneofCase.NullValue;

        /// <inheritdoc />
        public override bool NextResult()
        {
            _rowValid = false;
            _hasRows = false;
            _innerList.Clear();
            Logger.Warn("Spanner does not support multiple SQL queries in a single command");
            return false;
        }

        /// <inheritdoc />
        public override bool Read() => Task.Run(() => ReadAsync(CancellationToken.None)).ResultWithUnwrappedExceptions();

        /// <summary>
        /// Reads the next row of values from Cloud Spanner.
        /// Important: Cloud Spanner supports limited cancellation of this task.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token to cancel the read. Cloud Spanner currently
        /// supports limited cancellation while advancing the read to the next row.</param>
        /// <returns>True if another row was read.</returns>
        public override Task<bool> ReadAsync(CancellationToken cancellationToken) =>
            ExecuteHelper.WithErrorTranslationAndProfiling(async () =>
                {
                    using (var timeoutCts = new CancellationTokenSource(TimeSpan.FromSeconds(_readTimeoutSeconds)))
                    {
                        var timeoutToken = timeoutCts.Token;
                        using (var linkedCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, timeoutToken))
                        {
                            try
                            {
                                var effectiveToken = linkedCts.Token;
                                if (_metadata == null)
                                {
                                    await PopulateMetadataAsync(effectiveToken).ConfigureAwait(false);
                                }
                                _rowValid = false;
                                _innerList.Clear();

                                var first = await _resultSet.NextAsync(effectiveToken).ConfigureAwait(false);
                                if (first == null)
                                {
                                    // If this is the first thing we've tried to read, then we know there are no rows.
                                    if (_hasRows == null)
                                    {
                                        _hasRows = false;
                                    }
                                    return false;
                                }

                                _innerList.Add(first);
                                // We expect to get full rows...
                                for (var i = 1; i < _metadata.RowType.Fields.Count; i++)
                                {
                                    var value = await _resultSet.NextAsync(effectiveToken).ConfigureAwait(false);
                                    GaxPreconditions.CheckState(value != null, "Incomplete row returned by Spanner server");
                                    _innerList.Add(value);
                                }
                                _rowValid = true;
                                _hasRows = true;

                                return true;
                            }
                            // Translate timeouts from our own cancellation token into a Spanner exception.
                            // This mimics the behavior of SqlDataReader, which throws a SqlException on timeout.
                            // It's *possible* that the operation was cancelled due to the user-provided cancellation token,
                            // and that it just happens that the timeout has been fired as well... but there's a race
                            // condition anyway in that case, so it's probably reasonable to take the simple path.
                            catch (OperationCanceledException) when (timeoutToken.IsCancellationRequested)
                            {
                                throw new SpannerException(ErrorCode.DeadlineExceeded, "Read operation timed out");
                            }
                        }
                    }
                },
                "SpannerDataReader.Read", Logger);

        /// <inheritdoc />
        protected override void Dispose(bool disposing)
        {
            CloseImpl();
            base.Dispose(disposing);
        }

        internal ResultSetMetadata PopulateMetadata()
        {
            // If we've already got the metadata, complete synchronously
            if (_metadata != null)
            {
                return _metadata;
            }
            // Otherwise, run the async population code in a new task.
            return Task.Run(() => PopulateMetadataAsync(CancellationToken.None)).ResultWithUnwrappedExceptions();
        }

        internal Task<ResultSetMetadata> PopulateMetadataAsync(CancellationToken cancellationToken)
        {
            if (_metadata != null)
            {
                return Task.FromResult(_metadata);
            }
            return ExecuteHelper.WithErrorTranslationAndProfiling(
                async ()
                    => _metadata ?? (_metadata = await _resultSet.GetMetadataAsync(cancellationToken)
                        .ConfigureAwait(false)), "SpannerDataReader.GetMetadata", Logger);
        }

        private SpannerDbType GetSpannerFieldType(int i)
        {
            var fieldMetadata = PopulateMetadata().RowType.Fields[i];
            return SpannerDbType.FromProtobufType(fieldMetadata.Type);
        }

        /// <summary>
        /// Common code used by both Dispose and Close. Dispose can't call Close, as it's not
        /// present in .NET Standard 1.5; Close can't call dispose as we don't want to call into
        /// the base Dispose method.
        /// </summary>
        private void CloseImpl()
        {
            lock (_lock)
            {
                if (_closed)
                {
                    return;
                }
                _closed = true;
                Logger.LogPerformanceCounter(
                    "SpannerDataReader.ActiveCount",
                    () => Interlocked.Decrement(ref s_readerCount));

                _resultSet?.Dispose();
                _resourceToClose?.Dispose();
            }
        }

        /// <inheritdoc />
        public override void Close()
        {
            CloseImpl();
        }

        /// <summary>
        /// When enabled, returns the schema of the query as a <see cref="DataTable"/>. This feature needs
        /// to be enabled in the connection string via the <see cref="SpannerConnectionStringBuilder.EnableGetSchemaTable"/> property.
        /// </summary>
        /// <remarks>
        /// <para>
        /// <see cref="DbDataAdapter"/> will use this method automatically, but there is not enough information
        /// available for it to do so to reliably manage data sets. This method returns <c>null</c> by default to
        /// avoid this causing problems.
        /// </para>
        /// <para>
        /// When the <c>EnableGetSchemaTable</c> property in the connection string is set to <c>true</c>, a
        /// <c>DataTable</c> is returned with the following columns populated:
        /// <list type="bullet">
        /// <item><description>ColumnName (String): The name of the column</description></item>
        /// <item><description>ColumnOrdinal (Int32): The ordinal value of the column</description></item>
        /// <item><description>DataType (Type): The default CLR type of the column</description></item>
        /// <item><description>ProviderType (SpannerDbType): The Spanner-specific data type of the column</description></item>
        /// </list>
        /// The following additional columns are present in the table, but not currently populated:
        /// <list type="bullet">
        /// <item><description>ColumnSize</description></item>
        /// <item><description>NumericPrecision</description></item>
        /// <item><description>NumericScale</description></item>
        /// </list>
        /// Future releases may expand the set of columns, or populate more of the existing columns.
        /// </para>
        /// </remarks>
        /// <returns>A <c>DataTable</c> with schema information about the query, or <c>null</c> if the feature
        /// is not enabled in the connection string.</returns>
        public override DataTable GetSchemaTable()
        {
            // Spanner does not provide enough information for a schema table.
            // DbDataAdapter will adjust and fill the dataset with information from
            // this datareader (such as field type and name). By default, we just
            // return null. The feature needs to be explicitly enabled in the connection string.

            if (!_provideSchemaTable)
            {
                return null;
            }
            var resultSet = PopulateMetadata();

            // If the metadata couldn't be loaded, or there were no fields, just return null to indicate
            // that the schema isn't available.
            if ((resultSet?.RowType?.Fields?.Count ?? 0) == 0)
            {
                return null;
            }

            var table = new DataTable("SchemaTable")
            {
                Columns =
                {
                    { "ColumnName", typeof(string) },
                    { "ColumnOrdinal", typeof(int) },
                    { "DataType", typeof(System.Type) },
                    { "ProviderType", typeof(SpannerDbType) },

                    // Additional columns that are never populated.
                    { "ColumnSize", typeof(int) },
                    { "NumericPrecision", typeof(int) },
                    { "NumericScale", typeof(int) }
                }
            };

            int ordinal = 0;
            foreach (var field in resultSet.RowType.Fields)
            {
                var row = table.NewRow();
                SpannerDbType dbType = SpannerDbType.FromProtobufType(field.Type);

                row["ColumnName"] = field.Name;
                row["ColumnOrdinal"] = ordinal;
                row["DataType"] = dbType.GetConfiguredClrType(_conversionOptions);
                row["ProviderType"] = dbType;
                table.Rows.Add(row);

                ordinal++;
            }

            return table;
        }
    }
}
