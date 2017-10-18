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
using System.Collections.Generic;
using System.Data;
using Google.Cloud.Spanner.Data;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage;

namespace Google.Cloud.EntityFrameworkCore.Spanner.Storage.Internal
{
    /// <summary>
    /// </summary>
    public class SpannerTypeMapper : RelationalTypeMapper
    {
        private static readonly BoolTypeMapping s_bool = new BoolTypeMapping(SpannerDbType.Bool.DatabaseTypeName);
        private static readonly DateTimeTypeMapping s_date =
            new DateTimeTypeMapping(SpannerDbType.Date.DatabaseTypeName, DbType.Date);
        private static readonly DateTimeTypeMapping s_datetime =
            new DateTimeTypeMapping(SpannerDbType.Timestamp.DatabaseTypeName, DbType.DateTime);
        private static readonly StringTypeMapping s_defaultString
            = new StringTypeMapping(SpannerDbType.String.DatabaseTypeName, DbType.String, true);
        private static readonly DoubleTypeMapping s_double = new DoubleTypeMapping(SpannerDbType.Float64.DatabaseTypeName);
        private static readonly LongTypeMapping s_long =
            new LongTypeMapping(SpannerDbType.Int64.DatabaseTypeName, DbType.Int64);

        private static readonly Dictionary<string, RelationalTypeMapping> s_storeTypeMappings 
            = new Dictionary<string, RelationalTypeMapping>(StringComparer.OrdinalIgnoreCase)
        {
            {s_long.StoreType, s_long},
            {s_bool.StoreType, s_bool},
            {s_date.StoreType, s_date},
            {s_datetime.StoreType, s_datetime},
            {s_double.StoreType, s_double},
            {s_defaultString.StoreType, s_defaultString}
        };

        private static readonly Dictionary<System.Type, RelationalTypeMapping> s_clrTypeMappings
            = new Dictionary<System.Type, RelationalTypeMapping>
            {
                {typeof(int), s_long},
                {typeof(long), s_long},
                {typeof(uint), s_long},
                {typeof(bool), s_long},
                {typeof(DateTime), s_long},
                {typeof(float), s_double},
                {typeof(double), s_double},
                {typeof(string), s_defaultString}
            };

        /// <summary>
        /// </summary>
        public SpannerTypeMapper(RelationalTypeMapperDependencies dependencies)
            : base(dependencies)
        {
        }

        /// <inheritdoc />
        protected override string GetColumnType(IProperty property)
            => new RelationalPropertyAnnotations(property).ColumnType;

        /// <inheritdoc />
        protected override IReadOnlyDictionary<System.Type, RelationalTypeMapping> GetClrTypeMappings()
            => s_clrTypeMappings;

        /// <inheritdoc />
        protected override IReadOnlyDictionary<string, RelationalTypeMapping> GetStoreTypeMappings()
            => s_storeTypeMappings;
    }
}