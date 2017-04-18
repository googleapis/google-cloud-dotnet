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
using System.Data.Common;
using Google.Cloud.Spanner.V1;
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
        internal SpannerDataReader(ResultSet resultset)
        {
        }

        /// <inheritdoc />
        public override int Depth
        {
            get { throw new NotImplementedException(); }
        }


        /// <inheritdoc />
        public override int FieldCount
        {
            get { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        public override bool HasRows
        {
            get { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        public override bool IsClosed
        {
            get { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        public override object this[int i]
        {
            get { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        public override object this[string name]
        {
            get { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        public override int RecordsAffected
        {
            get { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        public override bool GetBoolean(int i)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override byte GetByte(int i)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override char GetChar(int i)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override string GetDataTypeName(int i)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override DateTime GetDateTime(int i)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override decimal GetDecimal(int i)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override double GetDouble(int i)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override System.Type GetFieldType(int i)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override float GetFloat(int i)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override Guid GetGuid(int i)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override short GetInt16(int i)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override int GetInt32(int i)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override long GetInt64(int i)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override string GetName(int i)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override int GetOrdinal(string name)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override string GetString(int i)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override object GetValue(int i)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override int GetValues(object[] values)
        {
            throw new NotImplementedException();
        }


        /// <inheritdoc />
        public override bool IsDBNull(int i)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override bool NextResult()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override bool Read()
        {
            throw new NotImplementedException();
        }


        /// <inheritdoc />
        protected override void Dispose(bool disposing)
        {
            throw new NotImplementedException();
        }

#if NET451

        /// <inheritdoc />
        public override void Close()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override DataTable GetSchemaTable()
        {
            throw new NotImplementedException();
        }

#endif
    }
}