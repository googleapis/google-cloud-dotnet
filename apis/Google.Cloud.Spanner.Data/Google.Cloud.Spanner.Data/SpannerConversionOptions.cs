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
            SingleToFloat32,
            SingleToFloat64,
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
            DateToDateTime,
            DateToSpannerDate
        };

        // Constants for CLR to Spanner type mappings.
        internal const string SingleToFloat32 = nameof(SingleToFloat32);
        internal const string SingleToFloat64 = nameof(SingleToFloat64);
        internal const string DecimalToFloat64 = nameof(DecimalToFloat64);
        internal const string DecimalToNumeric = nameof(DecimalToNumeric);
        internal const string DecimalToPgNumeric = nameof(DecimalToPgNumeric);
        internal const string DateTimeToDate = nameof(DateTimeToDate);
        internal const string DateTimeToTimestamp = nameof(DateTimeToTimestamp);

        // Constants for Spanner To CLR type mappings.
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

        internal SpannerDbType SingleToConfiguredSpannerType { get; private set; }

        /// <summary>
        /// The configured SpannerDbType for the decimal CLR type.
        /// </summary>
        internal SpannerDbType DecimalToConfiguredSpannerType { get; private set; }

        /// <summary>
        /// The configured SpannerDbType for the DateTime CLR type.
        /// </summary>
        internal SpannerDbType DateTimeToConfiguredSpannerType { get; private set; }

        /// <summary>
        /// The configured SpannerDbType for the Interval CLR type.
        /// </summary>
        internal SpannerDbType IntervalToConfiguredSpannerType { get; private set; }

        /// <summary>
        /// The configured CLR type for the Date SpannerDbType.
        /// </summary>
        internal System.Type DateToConfiguredClrType { get; private set; }

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
            DateToConfiguredClrType = DateToConfiguredClrType
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

        internal void SetClrToSpannerTypeDefaults()
        {
            SingleToConfiguredSpannerType = SpannerDbType.Float32;
            DecimalToConfiguredSpannerType = SpannerDbType.Numeric;
            DateTimeToConfiguredSpannerType = SpannerDbType.Timestamp;
            IntervalToConfiguredSpannerType = SpannerDbType.Interval;
        }

        internal void SetSpannerToClrTypeDefaults()
        {
            DateToConfiguredClrType = typeof(DateTime);
        }

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

            var mappingType = nameof(SpannerConnectionStringBuilder.SpannerToClrTypeDefaultMappings);

            CheckValidMappings(mappings, AllowedSpannerToClrTypeMappings, mappingType);
            CheckMultipleMappingsForSameType("Date", mappings, mappingType);

            // If we reach here, all is well.
            foreach (var mapping in mappings)
            {
                if (string.Equals(mapping, DateToDateTime, StringComparison.OrdinalIgnoreCase))
                {
                    options.DateToConfiguredClrType = typeof(DateTime);
                }
                else if (string.Equals(mapping, DateToSpannerDate, StringComparison.OrdinalIgnoreCase))
                {
                    options.DateToConfiguredClrType = typeof(SpannerDate);
                }
            }
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

            var mappingType = nameof(SpannerConnectionStringBuilder.ClrToSpannerTypeDefaultMappings);

            CheckValidMappings(mappings, AllowedClrToSpannerTypeMappings, mappingType);
            CheckMultipleMappingsForSameType("Single", mappings, mappingType);
            CheckMultipleMappingsForSameType("Decimal", mappings, mappingType);
            CheckMultipleMappingsForSameType("DateTime", mappings, mappingType);

            // If we reach here all is well.
            foreach (var mapping in mappings)
            {
                if (string.Equals(mapping, SingleToFloat32, StringComparison.OrdinalIgnoreCase))
                {
                    options.SingleToConfiguredSpannerType = SpannerDbType.Float32;
                }
                else if (string.Equals(mapping, SingleToFloat64, StringComparison.OrdinalIgnoreCase))
                {
                    options.SingleToConfiguredSpannerType = SpannerDbType.Float64;
                }
                else if (string.Equals(mapping, DecimalToFloat64, StringComparison.OrdinalIgnoreCase))
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

        /// <summary>
        /// Validates that at least one mapping was specified for <paramref name="mappingType"/> and that all
        /// specified mappings are valid.
        /// </summary>
        private static void CheckValidMappings(string[] mappings, HashSet<string> validMappings, string mappingType)
        {
            if (!mappings.Any())
            {
                throw new ArgumentException($"No mappings were specified for ${mappingType}.");
            }

            var invalidMappings = mappings.Except(validMappings, StringComparer.OrdinalIgnoreCase);
            if (invalidMappings.Any())
            {
                throw new ArgumentException($"The following mappings are invalid:'{string.Join(",", invalidMappings)}' for ${mappingType}.");
            }
        }

        private static void CheckMultipleMappingsForSameType(string prefix, string[] mappings, string mappingType)
        {
            if (mappings.Count(mapping => mapping.StartsWith(prefix, StringComparison.OrdinalIgnoreCase)) > 1)
            {
                throw new ArgumentException($"Invalid {mappingType} value. At most, a single mapping for {prefix} may be specified.");
            }
        }
    }
}
