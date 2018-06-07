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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf.WellKnownTypes;
using static System.String;

#if !NETSTANDARD1_5
using System.Data;

#endif

// ReSharper disable UnusedParameter.Local

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Reads a forward-only stream of rows from a data source.
    /// </summary>
    public sealed class SpannerDataReader : DbDataReader
    {
        private static long s_readerCount;
        private readonly List<Value> _innerList = new List<Value>();
        private readonly ReliableStreamReader _resultSet;
        private readonly ConcurrentDictionary<string, int> _fieldIndex = new ConcurrentDictionary<string, int>();
        private ResultSetMetadata _metadata;
        private readonly IDisposable _resourceToClose;
        private readonly SpannerConversionOptions _conversionOptions;
        private readonly bool _provideSchemaTable;

        // Lock for _closed; could possibly be removed and just used Interlocked, but this is simple.
        private readonly object _lock = new object();
        private bool _closed;

        internal SpannerDataReader(
            Logger logger,
            ReliableStreamReader resultSet,
            IDisposable resourceToClose,
            SpannerConversionOptions conversionOptions,
            bool provideSchemaTable)
        {
            GaxPreconditions.CheckNotNull(resultSet, nameof(resultSet));
            Logger = logger;
            Logger.LogPerformanceCounter(
                "SpannerDataReader.ActiveCount",
                () => Interlocked.Increment(ref s_readerCount));
            _resultSet = resultSet;
            _resourceToClose = resourceToClose;
            _conversionOptions = conversionOptions;
            _provideSchemaTable = provideSchemaTable;
        }

        private Logger Logger { get; }

        // Nesting is not supported, so we return 0.
        /// <inheritdoc />
        public override int Depth => 0;

        /// <inheritdoc />
        public override int FieldCount => PopulateMetadataAsync(CancellationToken.None).ResultWithUnwrappedExceptions()
            .RowType.Fields.Count;

        /// <inheritdoc />
        public override bool HasRows => _resultSet.HasDataAsync(CancellationToken.None).ResultWithUnwrappedExceptions();

        /// <inheritdoc />
        public override bool IsClosed => _resultSet.IsClosed;

        /// <inheritdoc />
        public override object this[int i] => GetSpannerFieldType(i).ConvertToClrType(_innerList[i], _conversionOptions);

        /// <inheritdoc />
        public override object this[string name] => this[
            GetFieldIndexAsync(name, CancellationToken.None).ResultWithUnwrappedExceptions()];

        /// <inheritdoc />
        public override int RecordsAffected => -1;

        /// <inheritdoc />
        public override bool GetBoolean(int i) => GetSpannerFieldType(i).ConvertToClrType<bool>(_innerList[i], _conversionOptions);

        /// <inheritdoc />
        public override byte GetByte(int i) => GetSpannerFieldType(i).ConvertToClrType<byte>(_innerList[i], _conversionOptions);

        /// <inheritdoc />
        public override long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length) => throw
            new NotSupportedException("Spanner does not support conversion to byte arrays.");

        /// <inheritdoc />
        public override char GetChar(int i) => GetSpannerFieldType(i).ConvertToClrType<char>(_innerList[i], _conversionOptions);

        /// <inheritdoc />
        public override long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length) => throw
            new NotSupportedException("Spanner does not support conversion to char arrays.");

        /// <inheritdoc />
        public override string GetDataTypeName(int i) => GetSpannerFieldType(i).ToString();

        /// <inheritdoc />
        public override DateTime GetDateTime(int i) => GetSpannerFieldType(i).ConvertToClrType<DateTime>(_innerList[i], _conversionOptions);

        /// <inheritdoc />
        public override decimal GetDecimal(int i) => GetSpannerFieldType(i).ConvertToClrType<decimal>(_innerList[i], _conversionOptions);

        /// <inheritdoc />
        public override double GetDouble(int i) => GetSpannerFieldType(i).ConvertToClrType<double>(_innerList[i], _conversionOptions);

        /// <inheritdoc />
        public override IEnumerator GetEnumerator()
        {
#if !NETSTANDARD1_5
            return new DbEnumerator(this);
#else
            throw new NotSupportedException("GetEnumerator not yet supported in .NET Core");
#endif
        }

        /// <inheritdoc />
        public override System.Type GetFieldType(int i)
        {
            var fieldMetadata = PopulateMetadataAsync(CancellationToken.None).ResultWithUnwrappedExceptions().RowType
                .Fields[i];
            return SpannerDbType.FromProtobufType(fieldMetadata.Type).DefaultClrType;
        }

        // TODO: Remove duplication by making all of the methods below call this one.
        // TODO: Validate that we're positioned on a row.
        /// <inheritdoc />
        public override T GetFieldValue<T>(int ordinal) =>
            GetSpannerFieldType(ordinal).ConvertToClrType<T>(_innerList[ordinal], _conversionOptions);

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
            return GetSpannerFieldType(ordinal).ConvertToClrType<T>(_innerList[ordinal], _conversionOptions);
        }

        /// <inheritdoc />
        public override float GetFloat(int i) => GetSpannerFieldType(i).ConvertToClrType<float>(_innerList[i], _conversionOptions);

        /// <inheritdoc />
        public override Guid GetGuid(int i) => GetSpannerFieldType(i).ConvertToClrType<Guid>(_innerList[i], _conversionOptions);

        /// <inheritdoc />
        public override short GetInt16(int i) => GetSpannerFieldType(i).ConvertToClrType<short>(_innerList[i], _conversionOptions);

        /// <inheritdoc />
        public override int GetInt32(int i) => GetSpannerFieldType(i).ConvertToClrType<int>(_innerList[i], _conversionOptions);

        /// <inheritdoc />
        public override long GetInt64(int i) => GetSpannerFieldType(i).ConvertToClrType<long>(_innerList[i], _conversionOptions);

        /// <summary>
        /// Gets the value of the specified column as a pure Protobuf type.
        /// </summary>
        /// <param name="i">The index of the column whose value will be returned.</param>
        /// <returns>The raw protobuf as a <see cref="Value"/>.</returns>
        public Value GetJsonValue(int i) => _innerList[i];

        /// <inheritdoc />
        public override string GetName(int i) => _resultSet.GetMetadataAsync(CancellationToken.None)
            .ResultWithUnwrappedExceptions().RowType.Fields[i]
            .Name;

        /// <inheritdoc />
        public override int GetOrdinal(string name) 
            => GetFieldIndexAsync(name, CancellationToken.None).ResultWithUnwrappedExceptions();

        /// <inheritdoc />
        public override string GetString(int i) => GetSpannerFieldType(i).ConvertToClrType<string>(_innerList[i], _conversionOptions);

        /// <summary>
        /// Gets the value of the specified column as type <see cref="Timestamp"/>.
        /// </summary>
        /// <param name="i">The index of the column to retrieve.</param>
        /// <returns>The value converted to a <see cref="Timestamp"/>.</returns>
        public Timestamp GetTimestamp(int i) => GetSpannerFieldType(i).ConvertToClrType<Timestamp>(_innerList[i], _conversionOptions);

        /// <inheritdoc />
        public override object GetValue(int i) => this[i];

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
            Logger.Warn(() => "Spanner does not support multiple SQL queries in a single command");
            return false;
        }

        /// <inheritdoc />
        public override bool Read() => ReadAsync(CancellationToken.None).ResultWithUnwrappedExceptions();

        /// <summary>
        /// Reads the next row of values from Cloud Spanner.
        /// Important: Cloud Spanner supports limited cancellation of this task.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token to cancel the read. Cloud Spanner currently
        /// supports limited cancellation while advancing the read to the next row.</param>
        /// <returns>True if another row was read.</returns>
        public override Task<bool> ReadAsync(CancellationToken cancellationToken)
        {
            return ExecuteHelper.WithErrorTranslationAndProfiling(
                async () =>
                {
                    if (_metadata == null)
                    {
                        await PopulateMetadataAsync(cancellationToken).ConfigureAwait(false);
                    }
                    _innerList.Clear();
                    //read # values == # fields.
                    var first = await _resultSet.NextAsync(cancellationToken).ConfigureAwait(false);
                    if (first == null)
                    {
                        return false;
                    }

                    _innerList.Add(first);
                    //we expect to get full rows...
                    for (var i = 1; i < _metadata.RowType.Fields.Count; i++)
                    {
                        _innerList.Add(await _resultSet.NextAsync(cancellationToken).ConfigureAwait(false));
                    }

                    return true;
                },
                "SpannerDataReader.Read", Logger);
        }

        /// <inheritdoc />
        protected override void Dispose(bool disposing)
        {
            CloseImpl();
            base.Dispose(disposing);
        }

        private async Task<int> GetFieldIndexAsync(string fieldName, CancellationToken cancellationToken)
        {
            GaxPreconditions.CheckNotNullOrEmpty(fieldName, nameof(fieldName));
            if (_fieldIndex.Count == 0)
            {
                var metadata = await PopulateMetadataAsync(cancellationToken).ConfigureAwait(false);
                if (metadata != null)
                {
                    var i = 0;
                    foreach (var field in metadata.RowType.Fields)
                    {
                        _fieldIndex[field.Name] = i;
                        i++;
                    }
                }
            }
            return _fieldIndex[fieldName];
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
            var fieldMetadata = PopulateMetadataAsync(CancellationToken.None).ResultWithUnwrappedExceptions().RowType
                .Fields[i];
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

#if !NETSTANDARD1_5

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
            var resultSet = PopulateMetadataAsync(CancellationToken.None).ResultWithUnwrappedExceptions();

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
                row["DataType"] = dbType.DefaultClrType;
                row["ProviderType"] = dbType;
                table.Rows.Add(row);

                ordinal++;
            }

            return table;
        }
#endif
    }
}
