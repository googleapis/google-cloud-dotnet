// Copyright 2017 Google Inc. All rights reserved.
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

using Google.Api.Gax;
using Google.Protobuf;
using System;
using System.Text.RegularExpressions;

namespace Google.Cloud.Bigtable.V2
{
    /// <summary>
    /// Static class with convenience methods for creating various kinds of <see cref="Mutation"/> instances.
    /// </summary>
    public static class Mutations
    {
        private static readonly Regex FamilyNameRegex =
            new Regex("^[-_.A-Z0-9]+$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        /// <summary>
        /// Creates a <see cref="Mutation"/> which deletes cells from the specified column, optionally
        /// restricting the deletions to a given version range.
        /// </summary>
        /// <remarks>
        /// <para> 
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>,
        /// so <paramref name="columnQualifier"/> can be specified using a string as well and
        /// its UTF-8 representations will be used.
        /// </para>
        /// </remarks>
        /// <param name="familyName">
        /// The name of the family from which cells should be deleted.
        /// Must match `[-_.a-zA-Z0-9]+`
        /// </param>
        /// <param name="columnQualifier">
        /// The qualifier of the column from which cells should be deleted.
        /// Can be any byte string, including the empty string.
        /// </param>
        /// <param name="versionRange">
        /// [Optional] The range of versions within which cells should be deleted.
        /// If unspecified, all versions will be deleted.
        /// </param>
        /// <returns>The created Mutation instance.</returns>
        public static Mutation DeleteFromColumn(
            string familyName,
            BigtableByteString columnQualifier,
            BigtableVersionRange versionRange = null) =>
            new Mutation
            {
                DeleteFromColumn = new Mutation.Types.DeleteFromColumn
                {
                    FamilyName = ValidateFamilyName(familyName),
                    ColumnQualifier = columnQualifier.Value,
                    TimeRange = versionRange.ToTimestampRange()
                }
            };

        /// <summary>
        /// Creates a <see cref="Mutation"/> which deletes all cells from the specified column family.
        /// </summary>
        /// <param name="familyName">
        /// The name of the family from which cells should be deleted.
        /// Must match `[-_.a-zA-Z0-9]+`
        /// </param>
        /// <returns>The created Mutation instance.</returns>
        public static Mutation DeleteFromFamily(string familyName) =>
            new Mutation
            {
                DeleteFromFamily = new Mutation.Types.DeleteFromFamily
                {
                    FamilyName = ValidateFamilyName(familyName)
                }
            };

        /// <summary>
        /// Creates a <see cref="Mutation"/> which deletes all cells from the containing row.
        /// </summary>
        /// <returns>The created Mutation instance.</returns>
        public static Mutation DeleteFromRow() =>
            new Mutation
            {
                DeleteFromRow = new Mutation.Types.DeleteFromRow()
            };

        /// <summary>
        /// Creates a <see cref="Mutation"/> which sets the value of the specified cell.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>,
        /// so <paramref name="columnQualifier"/> or <paramref name="value"/> can be specified
        /// using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// </remarks>
        /// <param name="familyName">
        /// The name of the family into which new data should be written.
        /// Must match `[-_.a-zA-Z0-9]+`
        /// </param>
        /// <param name="columnQualifier">
        /// The qualifier of the column into which new data should be written.
        /// Can be any byte string, including the empty string.
        /// </param>
        /// <param name="value">
        /// The value to be written into the specified cell.
        /// </param>
        /// <param name="version">
        /// [Optional] The version of the cell into which new data should be written.
        /// If unspecified, the version will be initialized from the current UTC time.
        /// </param>
        /// <returns>The created Mutation instance.</returns>
        public static Mutation SetCell(
            string familyName,
            BigtableByteString columnQualifier,
            BigtableByteString value,
            BigtableVersion? version = null) =>
            new Mutation
            {
                SetCell = new Mutation.Types.SetCell
                {
                    FamilyName = ValidateFamilyName(familyName),
                    ColumnQualifier = columnQualifier.Value,
                    Value = value.Value,
                    TimestampMicros = version.ToTimestampMicros()
                }
            };

        private static string ValidateFamilyName(string familyName)
        {
            GaxPreconditions.CheckArgument(
                familyName != null && FamilyNameRegex.IsMatch(familyName),
                nameof(familyName),
                "The family name must be non-null and match [-_.a-zA-Z0-9]+");

            return familyName;
        }
    }
}
