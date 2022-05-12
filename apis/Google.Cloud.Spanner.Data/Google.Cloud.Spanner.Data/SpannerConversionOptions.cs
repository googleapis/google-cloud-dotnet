// Copyright 2018 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Options for nuances in conversions between protobuf and CLR types.
    /// </summary>
    internal class SpannerConversionOptions
    {
        internal static SpannerConversionOptions Default { get; } = new SpannerConversionOptions(true, false, false);

        /// <summary>
        /// True to return DBNull.Value for null values; false to return a null reference.
        /// </summary>
        internal bool UseDBNull { get; }

        /// <summary>
        /// True to use <see cref="SpannerDbType.Numeric"/> as default SpannerDbType for decimal values; false to use <see cref="SpannerDbType.Float64"/>.
        /// This should be used, only when working with Spanner Google Standard SQL (GSQL) dialect database.
        /// </summary>
        internal bool UseSpannerNumericForDecimal { get; }

        /// <summary>
        /// True to use <see cref="SpannerDbType.PgNumeric"/> as default SpannerDbType for decimal values; false to use <see cref="SpannerDbType.Float64"/>.
        /// This should be used, only when working with Spanner PostgreSQL dialect database.
        /// </summary>
        internal bool UsePgNumericForDecimal { get; }

        private SpannerConversionOptions(bool useDBNull,
            bool useSpannerNumericForDecimal,
            bool usePgNumericForDecimal)
        {
            UseDBNull = useDBNull;
            UseSpannerNumericForDecimal = useSpannerNumericForDecimal;
            UsePgNumericForDecimal = usePgNumericForDecimal;
        }

        /// <summary>
        /// Determines the right conversion options to use based on the connection string of the given connection.
        /// </summary>
        internal static SpannerConversionOptions ForConnection(SpannerConnection spannerConnection) =>
            ForConnectionStringBuilder(spannerConnection?.Builder);

        /// <summary>
        /// Determines the right conversion options to use based on the connection string of the given connection string builder.
        /// </summary>
        internal static SpannerConversionOptions ForConnectionStringBuilder(SpannerConnectionStringBuilder builder) =>
            builder == null ? Default : new SpannerConversionOptions(!builder.UseClrDefaultForNull, builder.UseSpannerNumericForDecimal, builder.UsePgNumericForDecimal);
    }
}
