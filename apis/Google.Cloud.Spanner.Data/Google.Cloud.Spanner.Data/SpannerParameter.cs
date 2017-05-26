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

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// </summary>
    public sealed class SpannerParameter : DbParameter
#if NET45 || NET451
        , ICloneable
#endif
    {
        private string _spannerColumnName;
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
        /// <param name="sourceColumn"></param>
        /// <param name="size"></param>
        public SpannerParameter(string spannerColumnName, SpannerDbType type, string sourceColumn = null, int size = 0)
        {
            _spannerColumnName = spannerColumnName;
            TypeCode = type.GetSpannerTypeCode();
            SourceColumn = sourceColumn;
            Size = size;
        }

        /// <inheritdoc />
        public override DbType DbType
        {
            get { return TypeCode.GetDbType(); }
            set { TypeCode = value.GetSpannerType(); }
        }

        /// <inheritdoc />
        public override ParameterDirection Direction
        {
            get { return ParameterDirection.Input; }
            set { throw new InvalidOperationException("Spanner only supports input parameters."); }
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
        public override int Size { get; set; }

        /// <inheritdoc />
        public override string SourceColumn { get; set; }

        /// <inheritdoc />
        public override bool SourceColumnNullMapping { get; set; } = true;

#if NET45 || NET451

        /// <inheritdoc />
        public override DataRowVersion SourceVersion { get; set; } = DataRowVersion.Current;

#endif

        /// <summary>
        /// </summary>
        public SpannerDbType SpannerDbType
        {
            get { return TypeCode.GetSpannerDbType(); }
            set { TypeCode = value.GetSpannerTypeCode(); }
        }

        /// <inheritdoc />
        public override object Value
        {
            get { return _value; }
            set
            {
                if (TypeCode == TypeCode.Unspecified)
                    throw new ArgumentException(
                        "SpannerDbType must be set to one of (Bool, Int64, Float64, Timestamp, Date, String, Bytes)");
                _value = value;
            }
        }

        internal TypeCode TypeCode { get; private set; }

        /// <inheritdoc />
        public object Clone()
        {
            return (SpannerParameter) MemberwiseClone();
        }

        /// <inheritdoc />
        public override void ResetDbType()
        {
            TypeCode = TypeCode.Unspecified;
        }
    }
}