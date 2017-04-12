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

// ReSharper disable UnusedParameter.Local

namespace Google.Cloud.Spanner
{
    /// <summary>
    /// 
    /// </summary>
    public class SpannerParameter : DbParameter
#if NET451
        , ICloneable
#endif
    {
        /// <summary>
        /// 
        /// </summary>
        public SpannerParameter()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="spannerColumnName"></param>
        public SpannerParameter(string spannerColumnName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="spannerColumnName"></param>
        /// <param name="sourceDataTableName"></param>
        public SpannerParameter(string spannerColumnName, string sourceDataTableName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="spannerColumnName"></param>
        /// <param name="type"></param>
        public SpannerParameter(string spannerColumnName, SpannerDbType type) : this(spannerColumnName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="spannerColumnName"></param>
        /// <param name="type"></param>
        public SpannerParameter(string spannerColumnName, DbType type) : this(spannerColumnName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="spannerColumnName"></param>
        /// <param name="value"></param>
        public SpannerParameter(string spannerColumnName, object value) : this(spannerColumnName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="spannerColumnName"></param>
        /// <param name="type"></param>
        /// <param name="sourceColumn"></param>
        public SpannerParameter(string spannerColumnName, SpannerDbType type, string sourceColumn) : this(
            spannerColumnName, type)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override DbType DbType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// 
        /// </summary>
        public SpannerDbType SpannerDbType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        public override ParameterDirection Direction
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        public override bool IsNullable
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        public override string ParameterName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        public override string SourceColumn
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

#if NET451

        /// <inheritdoc />
        public override DataRowVersion SourceVersion
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
#endif

        /// <inheritdoc />
        public override object Value
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        public override byte Precision
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        public override byte Scale
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        public override int Size
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        public override void ResetDbType()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override bool SourceColumnNullMapping
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}