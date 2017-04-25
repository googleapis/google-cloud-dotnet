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
using TypeCode = Google.Cloud.Spanner.V1.TypeCode;

// ReSharper disable UnusedParameter.Local

namespace Google.Cloud.Spanner
{
    /// <summary>
    /// </summary>
    public sealed class SpannerParameter : DbParameter
#if NET451
        , ICloneable
#endif
    {
        private string _sourceColumn;

        private string _spannerColumnName;
        private TypeCode _spannerTypeCode;
        private ParameterDirection _direction = ParameterDirection.Input;
        private object _value;

        /// <summary>
        /// </summary>
        public SpannerParameter()
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="spannerColumnName"></param>
        /// <param name="type"></param>
        public SpannerParameter(string spannerColumnName, SpannerDbType type)
        {
            _spannerColumnName = spannerColumnName;
            _spannerTypeCode = type.GetSpannerTypeCode();
        }

        /// <summary>
        /// </summary>
        /// <param name="spannerColumnName"></param>
        /// <param name="type"></param>
        /// <param name="sourceColumn"></param>
        public SpannerParameter(string spannerColumnName, SpannerDbType type, string sourceColumn) : this(
            spannerColumnName, type)
        {
            _sourceColumn = sourceColumn;
        }

        /// <inheritdoc />
        public override DbType DbType
        {
            get { return _spannerTypeCode.GetDbType(); }
            set { _spannerTypeCode = value.GetSpannerType(); }
        }

        /// <inheritdoc />
        public override ParameterDirection Direction
        {
            get { return _direction; }
            set
            {
                throw new InvalidOperationException("Spanner does not support anything except input parameters.");
            }
        }

        /// <inheritdoc />
        public override bool IsNullable { get; set; } = true;

        /// <inheritdoc />
        public override string ParameterName
        {
            get { return _spannerColumnName; }
            set { _spannerColumnName = value; }
        }

        /// <inheritdoc />
        public override byte Precision { get; set; }

        /// <inheritdoc />
        public override byte Scale { get; set; }

        /// <inheritdoc />
        public override int Size { get; set; }

        /// <inheritdoc />
        public override string SourceColumn
        {
            get { return _sourceColumn; }
            set { _sourceColumn = value; }
        }

        /// <inheritdoc />
        public override bool SourceColumnNullMapping { get; set; } = true;

#if NET451

        /// <inheritdoc />
        public override DataRowVersion SourceVersion { get; set; } = DataRowVersion.Current;

#endif

        internal V1.TypeCode TypeCode =>  _spannerTypeCode;

        /// <summary>
        /// </summary>
        public SpannerDbType SpannerDbType
        {
            get { return _spannerTypeCode.GetSpannerDbType(); }
            set { _spannerTypeCode = value.GetSpannerTypeCode(); }
        }

        /// <inheritdoc />
        public override object Value
        {
            get { return _value; }
            set
            {
                if (_spannerTypeCode == TypeCode.Unspecified)
                {
                    throw new ArgumentException("SpannerDbType must be set to one of (Bool, Int64, Float64, Timestamp, Date, String, Bytes)");
                }
                _value = value;
            }
        }

        /// <inheritdoc />
        public object Clone()
        {
            return (SpannerParameter)MemberwiseClone();
        }

        /// <inheritdoc />
        public override void ResetDbType()
        {
            _spannerTypeCode = TypeCode.Unspecified;
        }
    }
}