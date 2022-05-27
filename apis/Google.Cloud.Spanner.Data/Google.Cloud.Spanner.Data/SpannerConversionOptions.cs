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

using Google.Cloud.Spanner.V1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Options for nuances in conversions between protobuf and CLR types.
    /// </summary>
    internal class SpannerConversionOptions
    {
        /// <summary>
        /// The set of valid CLR to Spanner type mappings used to validate <see cref="SpannerConnectionStringBuilder.ClrToSpannerTypeDefaultMappings"/>.
        /// </summary>
        internal static readonly HashSet<string> AllowedClrToSpannerTypeMappings = new HashSet<string>()
        {
            DecimalToFloat64,
            DecimalToNumeric,
            DecimalToPgNumeric,
            DateTimeToDate,
            DateTimeToTimestamp
        };

        /// <summary>
        /// The set of valid Spanner to CLR type mappings used to validate <see cref="SpannerConnectionStringBuilder.SpannerToClrTypeDefaultMappings"/>.
        /// </summary>
        internal static readonly HashSet<string> AllowedSpannerToClrTypeMappings = new HashSet<string>()
        {
            Float64ToSingle,
            Float64ToDouble,
            Float64ToDecimal,
            Float64ToSpannerNumeric,
            Float64ToPgNumeric,
            DateToDateTime,
            DateToSpannerDate
        };

        // Constants for CLR to Spanner type mappings.
        internal const string DecimalToFloat64 = nameof(DecimalToFloat64);
        internal const string DecimalToNumeric = nameof(DecimalToNumeric);
        internal const string DecimalToPgNumeric = nameof(DecimalToPgNumeric);
        internal const string DateTimeToDate = nameof(DateTimeToDate);
        internal const string DateTimeToTimestamp = nameof(DateTimeToTimestamp);

        // Constants for Spanner To CLR type mappings.
        internal const string Float64ToSingle = nameof(Float64ToSingle);
        internal const string Float64ToDouble = nameof(Float64ToDouble);
        internal const string Float64ToDecimal = nameof(Float64ToDecimal);
        internal const string Float64ToSpannerNumeric = nameof(Float64ToSpannerNumeric);
        internal const string Float64ToPgNumeric = nameof(Float64ToPgNumeric);
        internal const string DateToSpannerDate = nameof(DateToSpannerDate);
        internal const string DateToDateTime = nameof(DateToDateTime);

        // Predefined instances; these will change as the class grows, but hopefully
        // for most cases we can avoid creating new instances.
        private static readonly SpannerConversionOptions s_useDBNullForNull = new SpannerConversionOptions(true);

        internal static SpannerConversionOptions Default { get; } = s_useDBNullForNull;

        /// <summary>
        /// True to return DBNull.Value for null values; false to return a null reference.
        /// </summary>
        internal bool UseDBNull { get; private set; }

        /// <summary>
        /// Gets the configured SpannerDbType for the decimal CLR type.
        /// </summary>
        internal SpannerDbType DecimalToConfiguredSpannerType { get; private set; }

        /// <summary>
        /// Gets the configured SpannerDbType for the DateTime CLR type.
        /// </summary>
        internal SpannerDbType DateTimeToConfiguredSpannerType { get; private set; }

        /// <summary>
        /// Gets the configured CLR type for the Date SpannerDbType.
        /// </summary>
        internal System.Type DateToConfiguredClrType { get; private set; }

        /// <summary>
        /// Gets the configured CLR type for the Float64 SpannerDbType.
        /// </summary>
        internal System.Type Float64ToConfiguredClrType { get; private set; }

        private SpannerConversionOptions(bool useDBNull)
        {
            UseDBNull = useDBNull;
            // Set to defaults.
            SetClrToSpannerTypeDefaults();
            SetSpannerToClrTypeDefaults();
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
            builder == null ? Default : builder.ConversionOptions;

        internal SpannerConversionOptions Clone() => new SpannerConversionOptions(UseDBNull)
        {
            DateTimeToConfiguredSpannerType = DateTimeToConfiguredSpannerType,
            DecimalToConfiguredSpannerType = DecimalToConfiguredSpannerType,
            DateToConfiguredClrType = DateToConfiguredClrType,
            Float64ToConfiguredClrType = Float64ToConfiguredClrType
        };

        internal SpannerConversionOptions WithClrDefaultForNullSetting(bool useClrDefaultToNull)
        {
            var clone = Clone();
            clone.UseDBNull = !useClrDefaultToNull;
            return clone;
        }

        internal SpannerConversionOptions WithClrToSpannerMappings(string clrToSpannerMappings)
        {
            var clone = Clone();
            ValidateAndParseClrToSpannerTypeMappings(clrToSpannerMappings, clone);
            return clone;
        }

        internal SpannerConversionOptions WithSpannerToClrMappings(string spannerToClrMappings)
        {
            var clone = Clone();
            ValidateAndParseSpannerToClrTypeMappings(spannerToClrMappings, clone);
            return clone;
        }

        // TODO: Reuse code in both validation methods and remove code duplication.
        private void ValidateAndParseSpannerToClrTypeMappings(string input, SpannerConversionOptions options)
        {
            // Empty string or null is valid to unset the values.
            if (string.IsNullOrEmpty(input))
            {
                // Set defaults.
                options.SetSpannerToClrTypeDefaults();
                return;
            }

            // Get all type mappings.
            var mappings = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            // Validate that mappings are valid.
            if (!mappings.Any())
            {
                throw new ArgumentException($"'{input}' is not a valid value for ${nameof(SpannerConnectionStringBuilder.SpannerToClrTypeDefaultMappings)}");
            }

            // Validate that mapping matches one of the pre-defined values.
            var invalidMappings = mappings.Except(AllowedSpannerToClrTypeMappings, StringComparer.OrdinalIgnoreCase);
            if (invalidMappings.Any())
            {
                throw new ArgumentException($"The following mappings are invalid:'{string.Join(",", invalidMappings)}' for ${nameof(SpannerConnectionStringBuilder.SpannerToClrTypeDefaultMappings)}");
            }

            // Check multiples for each type.
            // Currently, we have Float64 and Date to check.
            if (mappings.Count(j => j.StartsWith("Float64", StringComparison.OrdinalIgnoreCase)) > 1)
            {
                throw new ArgumentException($"'{input}' is not a valid value as multiple mappings from Float64 to CLR type are provided for ${nameof(SpannerConnectionStringBuilder.SpannerToClrTypeDefaultMappings)}");
            }

            if (mappings.Count(j => j.StartsWith("Date", StringComparison.OrdinalIgnoreCase)) > 1)
            {
                throw new ArgumentException($"'{input}' is not a valid value as multiple mappings from Date to CLR type are provided for ${nameof(SpannerConnectionStringBuilder.SpannerToClrTypeDefaultMappings)}");
            }

            // If we reach here, all is well.
            foreach (var mapping in mappings)
            {
                if (string.Equals(mapping, Float64ToDecimal, StringComparison.OrdinalIgnoreCase))
                {
                    options.Float64ToConfiguredClrType = typeof(decimal);
                }
                else if (string.Equals(mapping, Float64ToDouble, StringComparison.OrdinalIgnoreCase))
                {
                    options.Float64ToConfiguredClrType = typeof(double);
                }
                else if (string.Equals(mapping, Float64ToSingle, StringComparison.OrdinalIgnoreCase))
                {
                    options.Float64ToConfiguredClrType = typeof(float);
                }
                else if (string.Equals(mapping, Float64ToSpannerNumeric, StringComparison.OrdinalIgnoreCase))
                {
                    options.Float64ToConfiguredClrType = typeof(SpannerNumeric);
                }
                else if (string.Equals(mapping, Float64ToPgNumeric, StringComparison.OrdinalIgnoreCase))
                {
                    options.Float64ToConfiguredClrType = typeof(PgNumeric);
                }
                else if (string.Equals(mapping, DateToDateTime, StringComparison.OrdinalIgnoreCase))
                {
                    options.DateToConfiguredClrType = typeof(DateTime);
                }
                else if (string.Equals(mapping, DateToSpannerDate, StringComparison.OrdinalIgnoreCase))
                {
                    options.DateToConfiguredClrType = typeof(SpannerDate);
                }
            }
        }

        internal void SetClrToSpannerTypeDefaults()
        {
            DecimalToConfiguredSpannerType = SpannerDbType.Float64;
            DateTimeToConfiguredSpannerType = SpannerDbType.Timestamp;
        }

        internal void SetSpannerToClrTypeDefaults()
        {
            DateToConfiguredClrType = typeof(DateTime);
            Float64ToConfiguredClrType = typeof(double);
        }

        private void ValidateAndParseClrToSpannerTypeMappings(string input, SpannerConversionOptions options)
        {
            // Empty string or null is valid to unset the values.
            if (string.IsNullOrEmpty(input))
            {
                // Set default mappings.
                options.SetClrToSpannerTypeDefaults();
                return;
            }

            // Get all type mappings.
            var mappings = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            // Validate that mappings are valid.
            if (!mappings.Any())
            {
                throw new ArgumentException($"'{input}' is not a valid value for ${nameof(SpannerConnectionStringBuilder.ClrToSpannerTypeDefaultMappings)}");
            }

            // Validate that mapping, matches one of the pre-defined values.
            var invalidMappings = mappings.Except(AllowedClrToSpannerTypeMappings, StringComparer.OrdinalIgnoreCase);
            if (invalidMappings.Any())
            {
                throw new ArgumentException($"The following mappings are invalid:'{string.Join(",", invalidMappings)}' for ${nameof(SpannerConnectionStringBuilder.ClrToSpannerTypeDefaultMappings)}");
            }

            // Check multiples for each type.
            // Currently, we have Decimal and DateTime to check.
            if (mappings.Count(j => j.StartsWith("Decimal", StringComparison.OrdinalIgnoreCase)) > 1)
            {
                throw new ArgumentException($"'{input}' is not a valid value as multiple mappings from Decimal to SpannerDbType are provided for ${nameof(SpannerConnectionStringBuilder.ClrToSpannerTypeDefaultMappings)}");
            }

            if (mappings.Count(j => j.StartsWith("DateTime", StringComparison.OrdinalIgnoreCase)) > 1)
            {
                throw new ArgumentException($"'{input}' is not a valid value as multiple mappings from DateTime to SpannerDbType are provided for ${nameof(SpannerConnectionStringBuilder.ClrToSpannerTypeDefaultMappings)}");
            }

            // If we reach here all is well.
            foreach (var mapping in mappings)
            {
                if (string.Equals(mapping, DecimalToFloat64, StringComparison.OrdinalIgnoreCase))
                {
                    options.DecimalToConfiguredSpannerType = SpannerDbType.Float64;
                }
                else if (string.Equals(mapping, DecimalToNumeric, StringComparison.OrdinalIgnoreCase))
                {
                    options.DecimalToConfiguredSpannerType = SpannerDbType.Numeric;
                }
                else if (string.Equals(mapping, DecimalToPgNumeric, StringComparison.OrdinalIgnoreCase))
                {
                    options.DecimalToConfiguredSpannerType = SpannerDbType.PgNumeric;
                }
                else if (string.Equals(mapping, DateTimeToDate, StringComparison.OrdinalIgnoreCase))
                {
                    options.DateTimeToConfiguredSpannerType = SpannerDbType.Date;
                }
                else if (string.Equals(mapping, DateTimeToTimestamp, StringComparison.OrdinalIgnoreCase))
                {
                    options.DateTimeToConfiguredSpannerType = SpannerDbType.Timestamp;
                }
            }
        }
    }
}
