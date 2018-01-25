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

namespace Microsoft.EntityFrameworkCore.Storage.Internal
{
    /// <summary>
    /// This is internal functionality and not intended for public use.
    /// </summary>
    public class SpannerTypeMapper : RelationalTypeMapper
    {
        //Note: This SpannerTypeMapper serves a key role in all of queries, updates and even migration by handling the
        // conversion between ClrTypes and SpannerTypes.  While this class is fairly simple, it relies heavily on
        // the type conversion support supplied in SpannerDbType which automatically coerces values into their
        // appropriate form across the wire and when coming back.

        //TODO: Decimal unfortunately loses precision with FLOAT64 and it would be nice to replace with something better.

        private static readonly SpannerBoolTypeMapping s_bool
            = new SpannerBoolTypeMapping(SpannerDbType.Bool.ToString());

        private static readonly DateTimeTypeMapping s_date
            = new DateTimeTypeMapping(SpannerDbType.Date.ToString(), DbType.DateTime);

        private static readonly DateTimeTypeMapping s_datetime
            = new DateTimeTypeMapping(SpannerDbType.Timestamp.ToString(), DbType.DateTime);

        private static readonly StringTypeMapping s_defaultString
            = new StringTypeMapping(SpannerDbType.String.ToString(), DbType.String, true);

        private static readonly DoubleTypeMapping s_double
            = new SpannerDoubleTypeMapping();

        private static readonly LongTypeMapping s_long
            = new LongTypeMapping(SpannerDbType.Int64.ToString(), DbType.Int64);

        private static readonly DecimalTypeMapping s_decimal
            = new DecimalTypeMapping(SpannerDbType.Float64.ToString());

        private static readonly GuidTypeMapping s_guid
            = new GuidTypeMapping(SpannerDbType.String.ToString(), DbType.String);

        private static readonly SpannerComplexTypeMapping s_byteArray
            = new SpannerComplexTypeMapping(SpannerDbType.Bytes);

        private static readonly SpannerComplexTypeMapping s_stringArray
            = new SpannerComplexTypeMapping(SpannerDbType.ArrayOf(SpannerDbType.String));

        private static readonly SpannerComplexTypeMapping s_boolArray
            = new SpannerComplexTypeMapping(SpannerDbType.ArrayOf(SpannerDbType.Bool));

        private static readonly SpannerComplexTypeMapping s_doubleArray
            = new SpannerComplexTypeMapping(SpannerDbType.ArrayOf(SpannerDbType.Float64));

        private static readonly SpannerComplexTypeMapping s_longArray
            = new SpannerComplexTypeMapping(SpannerDbType.ArrayOf(SpannerDbType.Int64));

        private static readonly SpannerComplexTypeMapping s_dateArray
            = new SpannerComplexTypeMapping(SpannerDbType.ArrayOf(SpannerDbType.Timestamp));

        private static readonly Dictionary<Type, RelationalTypeMapping> s_clrTypeMappings
            = new Dictionary<Type, RelationalTypeMapping>
            {
                {typeof(short), s_long},
                {typeof(int), s_long},
                {typeof(long), s_long},
                {typeof(decimal), s_decimal},
                {typeof(uint), s_long},
                {typeof(bool), s_bool},
                {typeof(DateTime), s_datetime},
                {typeof(float), s_double},
                {typeof(double), s_double},
                {typeof(string), s_defaultString},
                {typeof(string[]), s_stringArray},
                {typeof(bool[]), s_boolArray},
                {typeof(double[]), s_doubleArray},
                {typeof(long[]), s_longArray},
                {typeof(DateTime[]), s_dateArray},
                {typeof(Guid), s_guid},
                {typeof(byte[]), s_byteArray}
            };

        private static readonly Dictionary<SpannerDbType, RelationalTypeMapping> s_dbTypeMappings
            = new Dictionary<SpannerDbType, RelationalTypeMapping>
            {
                {SpannerDbType.Bool, s_bool},
                {SpannerDbType.Bytes, s_byteArray},
                {SpannerDbType.Date, s_date},
                {SpannerDbType.Float64, s_double},
                {SpannerDbType.Int64, s_long},
                {SpannerDbType.Timestamp, s_datetime},
                {SpannerDbType.String, s_defaultString},
                {SpannerDbType.Unspecified, null}
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
        protected override IReadOnlyDictionary<Type, RelationalTypeMapping> GetClrTypeMappings()
            => s_clrTypeMappings;

        /// <inheritdoc />
        protected override IReadOnlyDictionary<string, RelationalTypeMapping> GetStoreTypeMappings()
            => null;

        /// <inheritdoc />
        protected override RelationalTypeMapping CreateMappingFromStoreType(string storeType)
        {
            if (SpannerDbType.TryParse(storeType, out SpannerDbType parsedType))
            {
                if (!parsedType.Size.HasValue
                    && s_dbTypeMappings.TryGetValue(parsedType, out RelationalTypeMapping mapping))
                {
                    return mapping;
                }
                if (parsedType.DbType == DbType.String)
                {
                    // return a sized string.
                    return new StringTypeMapping(storeType, parsedType.DbType, true, parsedType.Size);
                }
                return new SpannerComplexTypeMapping(parsedType);
            }
            return null;
        }
    }
}