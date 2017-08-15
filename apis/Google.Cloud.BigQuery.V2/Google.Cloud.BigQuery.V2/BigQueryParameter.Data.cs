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

namespace Google.Cloud.BigQuery.V2
{
    public sealed partial class BigQueryParameter : DbParameter 
    {
        /// <inheritdoc />
        public override void ResetDbType()
        {
            throw new NotImplementedException();
        }
        /// <inheritdoc />
        public override DbType DbType { get; set; }
        /// <inheritdoc />
        public override ParameterDirection Direction { get; set; }
        /// <inheritdoc />
        public override bool IsNullable { get; set; }
        /// <inheritdoc />
        public override string ParameterName { get; set; }
        /// <inheritdoc />
        public override string SourceColumn { get; set; }
#if NET45
        /// <inheritdoc />
        public override DataRowVersion SourceVersion { get; set; }
#endif
        /// <inheritdoc />
        public override bool SourceColumnNullMapping { get; set; }
        /// <inheritdoc />
        public override int Size { get; set; }
    }
}
