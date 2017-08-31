// Copyright 2016 Google Inc. All Rights Reserved.
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
using Google.Api.Gax;

namespace Google.Cloud.BigQuery.V2
{
    public sealed partial class BigQueryParameter : DbParameter
#if NET45 || NET451
        , ICloneable
#endif
    {
        /// <inheritdoc />
        public override DbType DbType
        {
            get
            {
                switch (Type)
                {
                    case BigQueryDbType.Int64:
                        return DbType.Int64;
                    case BigQueryDbType.Float64:
                        return DbType.Double;
                    case BigQueryDbType.Bool:
                        return DbType.Boolean;
                    case BigQueryDbType.String:
                        return DbType.String;
                    case BigQueryDbType.Bytes:
                        return DbType.Binary;
                    case BigQueryDbType.Date:
                        return DbType.Date;
                    case BigQueryDbType.Timestamp:
                    case BigQueryDbType.DateTime:
                        return DbType.DateTime;
                    case BigQueryDbType.Time:
                        return DbType.Time;
                    default:
                        return DbType.Object;
                }
            }
            set
            {
                switch (value)
                {
                    case DbType.Binary:
                        Type = BigQueryDbType.Bytes;
                        break;
                    case DbType.Boolean:
                        Type = BigQueryDbType.Bool;
                        break;
                    case DbType.Date:
                        Type = BigQueryDbType.Date;
                        break;
                    case DbType.DateTime:
                        Type = BigQueryDbType.DateTime;
                        break;
                    case DbType.Time:
                        Type = BigQueryDbType.Time;
                        break;
                    case DbType.Double:
                        Type = BigQueryDbType.Float64;
                        break;
                    case DbType.Int64:
                        Type = BigQueryDbType.Int64;
                        break;
                    case DbType.Object:
                        Type = BigQueryDbType.Struct;
                        break;
                    case DbType.String:
                        Type = BigQueryDbType.String;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(DbType), value, null);
                }
            }
        }

        /// <inheritdoc />
        public override ParameterDirection Direction
        {
            get => ParameterDirection.Input;
            set
            {
                if (value != ParameterDirection.Input)
                {
                    throw new InvalidOperationException("BigQuery only supports input parameters.");
                }
            }
        }

        /// <inheritdoc />
        public override bool IsNullable { get; set; } = true;

        /// <inheritdoc />
        public override string ParameterName {
            get => Name;
            set => Name = value;
        }

        /// <inheritdoc />
        public override int Size { get; set; }

        /// <inheritdoc />
        public override string SourceColumn { get; set; }

        /// <inheritdoc />
        public override bool SourceColumnNullMapping { get; set; }

#if NET45 || NET451
        /// <inheritdoc />
        public override DataRowVersion SourceVersion { get; set; } = DataRowVersion.Current;

#endif

        /// <inheritdoc />
        public object Clone() => (BigQueryParameter)MemberwiseClone();

        /// <inheritdoc />
        public override void ResetDbType()
        {
            Type = BigQueryDbType.Struct;
        }
    }
}
