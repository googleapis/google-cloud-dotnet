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
using Google.Cloud.Spanner.V1;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using static System.String;

#if NET451
using System.Data;

#endif

// ReSharper disable UnusedParameter.Local

namespace Google.Cloud.Spanner
{
    /// <summary>
    /// </summary>
    public sealed class SpannerDataReader : DbDataReader
    {
        private readonly ReliableStreamReader _resultset;
        private readonly SpannerConnection _connectionToClose;
        private ResultSetMetadata _metadata;
        private readonly List<Value> _innerList = new List<Value>();
        private Dictionary<string, int> _fieldIndex;

        internal SpannerDataReader(ReliableStreamReader resultset)
        {
            _resultset = resultset;
        }

        internal SpannerDataReader(ReliableStreamReader resultset, SpannerConnection connectionToClose)
        {
            _resultset = resultset;
            _connectionToClose = connectionToClose;
        }

        // Nesting is not supported, so we return 0.
        /// <inheritdoc />
        public override int Depth => 0;

        /// <inheritdoc />
        public override int FieldCount => GetMetadataAsync(CancellationToken.None).Result.RowType.Fields.Count;

        /// <inheritdoc />
        public override bool HasRows => _resultset.HasData(CancellationToken.None).Result;

        /// <inheritdoc />
        public override bool IsClosed => _resultset.IsClosed;

        /// <inheritdoc />
        public override object this[int i] => _innerList[i].ConvertToClrType(GetSpannerFieldType(i));

        private async Task<int> GetFieldIndexAsync(string fieldName, CancellationToken cancellationToken)
        {
            if (_fieldIndex == null)
            {
                _fieldIndex = new Dictionary<string, int>();
                var metadata = await GetMetadataAsync(cancellationToken);
                if (metadata != null)
                {
                    int i = 0;
                    foreach (var field in metadata.RowType.Fields)
                    {
                        _fieldIndex[field.Name] = i;
                    }
                }
            }
            return _fieldIndex[fieldName];
        }
        /// <inheritdoc />
        public override object this[string name] => this[GetFieldIndexAsync(name, CancellationToken.None).Result];

        /// <inheritdoc />
        public override int RecordsAffected => -1;

        /// <inheritdoc />
        public override bool GetBoolean(int i)
        {
            return (bool)_innerList[i].ConvertToClrType(GetSpannerFieldType(i), typeof(bool));
        }

        /// <inheritdoc />
        public override byte GetByte(int i)
        {
            return (byte)_innerList[i].ConvertToClrType(GetSpannerFieldType(i), typeof(byte));
        }

        /// <inheritdoc />
        public override long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override char GetChar(int i)
        {
            return (char)_innerList[i].ConvertToClrType(GetSpannerFieldType(i), typeof(char));
        }

        /// <inheritdoc />
        public override long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override string GetDataTypeName(int i)
        {
            return GetSpannerFieldType(i).Code.ToString();
        }

        /// <inheritdoc />
        public override DateTime GetDateTime(int i)
        {
            return (DateTime)_innerList[i].ConvertToClrType(GetSpannerFieldType(i), typeof(DateTime));
        }

        /// <inheritdoc />
        public override decimal GetDecimal(int i)
        {
            return (decimal)_innerList[i].ConvertToClrType(GetSpannerFieldType(i), typeof(decimal));
        }

        /// <inheritdoc />
        public override double GetDouble(int i)
        {
            return (double)_innerList[i].ConvertToClrType(GetSpannerFieldType(i), typeof(double));
        }

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
            var fieldMetadata = GetMetadataAsync(CancellationToken.None).Result.RowType.Fields[i];
            return fieldMetadata.Type.Code.GetDefaultClrTypeFromSpannerType();
        }

        private V1.Type GetSpannerFieldType(int i)
        {
            var fieldMetadata = GetMetadataAsync(CancellationToken.None).Result.RowType.Fields[i];
            return fieldMetadata.Type;
        }

        /// <inheritdoc />
        public override float GetFloat(int i)
        {
            return (float)_innerList[i].ConvertToClrType(GetSpannerFieldType(i), typeof(float));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Value GetJsonValue(int i)
        {
            return (Value)_innerList[i].ConvertToClrType(GetSpannerFieldType(i), typeof(Value));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Timestamp GetTimestamp(int i)
        {
            //TODO, figure out how to better convert to Timestamp from RFC 3339
            return Timestamp.FromDateTime((DateTime)_innerList[i].ConvertToClrType(GetSpannerFieldType(i), typeof(DateTime)));
        }

        /// <inheritdoc />
        public override Guid GetGuid(int i)
        {
            return (Guid)_innerList[i].ConvertToClrType(GetSpannerFieldType(i), typeof(Guid));
        }

        /// <inheritdoc />
        public override short GetInt16(int i)
        {
            return (short)_innerList[i].ConvertToClrType(GetSpannerFieldType(i), typeof(short));
        }

        /// <inheritdoc />
        public override int GetInt32(int i)
        {
            return (int)_innerList[i].ConvertToClrType(GetSpannerFieldType(i), typeof(int));
        }

        /// <inheritdoc />
        public override long GetInt64(int i)
        {
            return (long)_innerList[i].ConvertToClrType(GetSpannerFieldType(i), typeof(long));
        }

        /// <inheritdoc />
        public override string GetName(int i)
        {
            return _resultset.GetMetadataAsync(CancellationToken.None).Result.RowType.Fields[i].Name;
        }

        /// <inheritdoc />
        public override int GetOrdinal(string name)
        {
            var fields = _resultset.GetMetadataAsync(CancellationToken.None).Result.RowType.Fields;
            for (int i = 0; i < fields.Count; i++)
            {
                if (name != null && Compare(name, fields[i].Name, StringComparison.Ordinal) == 0)
                    return i;
            }
            return -1;
        }

        /// <inheritdoc />
        public override string GetString(int i)
        {
            return (string)_innerList[i].ConvertToClrType(GetSpannerFieldType(i), typeof(string));
        }

        /// <inheritdoc />
        public override object GetValue(int i)
        {
            return this[i];
        }

        /// <inheritdoc />
        public override int GetValues(object[] values)
        {
            var count = Math.Min(FieldCount, values.Length);
            for (var i = 0; i < count; i++)
                values[i] = this[i];
            return count;
        }


        /// <inheritdoc />
        public override bool IsDBNull(int i)
        {
            return GetJsonValue(i).KindCase == Value.KindOneofCase.NullValue;
        }

        /// <inheritdoc />
        public override bool NextResult()
        {
            throw new NotSupportedException("Spanner does not support multiple SQL queries in a single command.");
        }

        /// <inheritdoc />
        public override bool Read()
        {
            return ReadAsync(CancellationToken.None).Result;
        }

        private async Task<ResultSetMetadata> GetMetadataAsync(CancellationToken cancellationToken)
        {
            return _metadata ?? (_metadata = await _resultset.GetMetadataAsync(cancellationToken));
        }

        /// <inheritdoc />
        public override async Task<bool> ReadAsync(CancellationToken cancellationToken)
        {
            var metadata = await GetMetadataAsync(cancellationToken);
            _innerList.Clear();
            //read # values == # fields.
            for (int i = 0; i < _metadata.RowType.Fields.Count; i++)
            {
                _innerList.Add(await _resultset.Next(cancellationToken));
            }

            return true;
        }

        /// <inheritdoc />
        protected override void Dispose(bool disposing)
        {
            _connectionToClose?.Close();
        }

#if NET451
        /// <inheritdoc />
        public override void Close()
        {
            _resultset.Close();
        }

        /// <inheritdoc />
        public override DataTable GetSchemaTable()
        {
            throw new NotSupportedException("Querying Schema information about queries is not supported in Spanner.");
        }

#endif
    }
}