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
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Logging;
using Google.Protobuf.WellKnownTypes;
using static System.String;
#if NET45 || NET451
using System.Data;

#endif

// ReSharper disable UnusedParameter.Local

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// </summary>
    public sealed class SpannerDataReader : DbDataReader
    {
        private static long s_readerCount;
        private readonly SpannerConnection _connectionToClose;
        private readonly List<Value> _innerList = new List<Value>();
        private readonly ReliableStreamReader _resultSet;
        private Dictionary<string, int> _fieldIndex;
        private ResultSetMetadata _metadata;

        internal SpannerDataReader(ReliableStreamReader resultSet)
        {
            GaxPreconditions.CheckNotNull(resultSet, nameof(resultSet));
            Logger.LogPerformanceCounter("SpannerDataReader.ActiveCount",
                () => Interlocked.Increment(ref s_readerCount));
            _resultSet = resultSet;
        }

        internal SpannerDataReader(ReliableStreamReader resultSet, SpannerConnection connectionToClose)
        {
            GaxPreconditions.CheckNotNull(resultSet, nameof(resultSet));
            Logger.LogPerformanceCounter("SpannerDataReader.ActiveCount",
                () => Interlocked.Increment(ref s_readerCount));
            _resultSet = resultSet;
            _connectionToClose = connectionToClose;
        }

        // Nesting is not supported, so we return 0.
        /// <inheritdoc />
        public override int Depth => 0;

        /// <inheritdoc />
        public override int FieldCount => PopulateMetadataAsync(CancellationToken.None).ResultWithUnwrappedExceptions().RowType.Fields.Count;

        /// <inheritdoc />
        public override bool HasRows => _resultSet.HasDataAsync(CancellationToken.None).ResultWithUnwrappedExceptions();

        /// <inheritdoc />
        public override bool IsClosed => _resultSet.IsClosed;

        /// <inheritdoc />
        public override object this[int i] => _innerList[i].ConvertToClrType(GetSpannerFieldType(i));

        /// <inheritdoc />
        public override object this[string name] => this[GetFieldIndexAsync(name, CancellationToken.None).ResultWithUnwrappedExceptions()];

        /// <inheritdoc />
        public override int RecordsAffected => -1;

        /// <inheritdoc />
        public override bool GetBoolean(int i) => _innerList[i].ConvertToClrType<bool>(GetSpannerFieldType(i));

        /// <inheritdoc />
        public override byte GetByte(int i) =>  _innerList[i].ConvertToClrType<byte>(GetSpannerFieldType(i));
    
        /// <inheritdoc />
        public override long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
        {
            //todo here.
            throw new NotSupportedException("Spanner does not support conversion to byte arrays.");
        }

        /// <inheritdoc />
        public override char GetChar(int i) => _innerList[i].ConvertToClrType<char>(GetSpannerFieldType(i));

        /// <inheritdoc />
        public override long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
        {
            //todo here.
            throw new NotSupportedException("Spanner does not support conversion to char arrays.");
        }

        /// <inheritdoc />
        public override string GetDataTypeName(int i) => GetSpannerFieldType(i).Code.ToString();

        /// <inheritdoc />
        public override DateTime GetDateTime(int i) => _innerList[i].ConvertToClrType<DateTime>(GetSpannerFieldType(i));

        /// <inheritdoc />
        public override decimal GetDecimal(int i) => _innerList[i].ConvertToClrType<decimal>(GetSpannerFieldType(i));

        /// <inheritdoc />
        public override double GetDouble(int i) => _innerList[i].ConvertToClrType<double>(GetSpannerFieldType(i));

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
        public override System.Type GetFieldType(int i)
        {
            var fieldMetadata = PopulateMetadataAsync(CancellationToken.None).ResultWithUnwrappedExceptions().RowType.Fields[i];
            return fieldMetadata.Type.Code.GetDefaultClrTypeFromSpannerType();
        }

        /// <inheritdoc />
        public override T GetFieldValue<T>(int ordinal)
        {
            return (T) _innerList[ordinal].ConvertToClrType(GetSpannerFieldType(ordinal), typeof(T));
        }

        /// <inheritdoc />
        public override float GetFloat(int i) => _innerList[i].ConvertToClrType<float>(GetSpannerFieldType(i));

        /// <inheritdoc />
        public override Guid GetGuid(int i) =>  _innerList[i].ConvertToClrType<Guid>(GetSpannerFieldType(i));

        /// <inheritdoc />
        public override short GetInt16(int i) => _innerList[i].ConvertToClrType<short>(GetSpannerFieldType(i));

        /// <inheritdoc />
        public override int GetInt32(int i) => _innerList[i].ConvertToClrType<int>(GetSpannerFieldType(i));

        /// <inheritdoc />
        public override long GetInt64(int i) => _innerList[i].ConvertToClrType<long>(GetSpannerFieldType(i));

        /// <summary>
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Value GetJsonValue(int i) => _innerList[i].ConvertToClrType<Value>(GetSpannerFieldType(i));

        /// <inheritdoc />
        public override string GetName(int i)
        {
            return _resultSet.GetMetadataAsync(CancellationToken.None).ResultWithUnwrappedExceptions().RowType.Fields[i].Name;
        }

        /// <inheritdoc />
        public override int GetOrdinal(string name)
        {
            GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name));
            var fields = _resultSet.GetMetadataAsync(CancellationToken.None).ResultWithUnwrappedExceptions().RowType.Fields;
            for (var i = 0; i < fields.Count; i++)
                if (Compare(name, fields[i].Name, StringComparison.Ordinal) == 0)
                    return i;
            return -1;
        }

        /// <inheritdoc />
        public override string GetString(int i) => _innerList[i].ConvertToClrType<string>(GetSpannerFieldType(i));

        /// <summary>
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Timestamp GetTimestamp(int i) => _innerList[i].ConvertToClrType<Timestamp>(GetSpannerFieldType(i));

        /// <inheritdoc />
        public override object GetValue(int i) => this[i];

        /// <inheritdoc />
        public override int GetValues(object[] values)
        {
            var count = Math.Min(FieldCount, values.Length);
            for (var i = 0; i < count; i++)
                values[i] = this[i];
            return count;
        }


        /// <inheritdoc />
        public override bool IsDBNull(int i) => GetJsonValue(i).KindCase == Value.KindOneofCase.NullValue;

        /// <inheritdoc />
        public override bool NextResult()
        {
            throw new NotSupportedException("Spanner does not support multiple SQL queries in a single command.");
        }

        /// <inheritdoc />
        public override bool Read() => ReadAsync(CancellationToken.None).ResultWithUnwrappedExceptions();

        /// <inheritdoc />
        public override Task<bool> ReadAsync(CancellationToken cancellationToken)
            => ExecuteHelper.WithErrorTranslationAndProfiling(async () => {

                    await PopulateMetadataAsync(cancellationToken).ConfigureAwait(false);
                    _innerList.Clear();
                    //read # values == # fields.
                    var first = await _resultSet.NextAsync(cancellationToken).ConfigureAwait(false);
                    if (first == null)
                        return false;
                    _innerList.Add(first);
                    //we expect to get full rows...
                    for (var i = 1; i < _metadata.RowType.Fields.Count; i++)
                        _innerList.Add(await _resultSet.NextAsync(cancellationToken).ConfigureAwait(false));

                    return true;
                },
                "SpannerDataReader.Read");

        /// <inheritdoc />
        protected override void Dispose(bool disposing)
        {
            Logger.LogPerformanceCounter("SpannerDataReader.ActiveCount",
                () => Interlocked.Decrement(ref s_readerCount));

            _resultSet?.Close();
            _connectionToClose?.Close();
            base.Dispose(disposing);
        }

        private async Task<int> GetFieldIndexAsync(string fieldName, CancellationToken cancellationToken)
        {
            GaxPreconditions.CheckNotNullOrEmpty(fieldName, nameof(fieldName));
            if (_fieldIndex == null)
            {
                _fieldIndex = new Dictionary<string, int>();
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
            return ExecuteHelper.WithErrorTranslationAndProfiling(async ()
                => _metadata ?? (_metadata = await _resultSet.GetMetadataAsync(cancellationToken)
                       .ConfigureAwait(false)), "SpannerDataReader.GetMetadata");
        }

        private V1.Type GetSpannerFieldType(int i)
        {
            var fieldMetadata = PopulateMetadataAsync(CancellationToken.None).ResultWithUnwrappedExceptions().RowType.Fields[i];
            return fieldMetadata.Type;
        }

#if NET45 || NET451
        /// <inheritdoc />
        public override void Close()
        {
            _resultSet?.Close();
            _connectionToClose?.Close();
        }

        /// <inheritdoc />
        public override DataTable GetSchemaTable()
        {
            //Spanner does not provide enough information for a schema table.
            //DbDataAdapter will adjust and fill the dataset with information from
            //this datareader (such as field type and name).
            return null;
//            var resultSet = GetMetadataAsync(CancellationToken.None).Result;
//            if (resultSet?.RowType?.Fields?.Count == 0) // No resultset
//                return null;
//
//            var table = new DataTable("SchemaTable");
//
//            table.Columns.Add("ColumnName", typeof(string));
//            table.Columns.Add("ColumnOrdinal", typeof(int));
//            table.Columns.Add("DataType", typeof(System.Type));
//            table.Columns.Add("NumericPrecision", typeof(int));
//            table.Columns.Add("ProviderType", typeof(SpannerDbType));
//
//            Debug.Assert(resultSet != null, "resultSet != null");
//            Debug.Assert(resultSet.RowType != null, "resultSet.RowType != null");
//            Debug.Assert(resultSet.RowType.Fields != null, "resultSet.RowType.Fields != null");
//
//            int ordinal = 0;
//            foreach (var field in resultSet.RowType.Fields)
//            {
//                var row = table.NewRow();
//
//                row["ColumnName"] = field.Name;
//                row["ColumnOrdinal"] = ordinal;
//                row["DataType"] = field.Type.Code.GetDefaultClrTypeFromSpannerType();
//                row["ProviderType"] = field.Type.Code.GetSpannerDbType();
//                table.Rows.Add(row);
//
//                ordinal++;
//            }
//
//            return table;
        }
#endif
    }
}