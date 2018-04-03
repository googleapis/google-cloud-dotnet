// Copyright 2017, Google Inc. All rights reserved.
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

using Google.Cloud.Bigtable.Admin.V2;
using Google.Cloud.ClientTesting;
using Google.Rpc;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Bigtable.V2.IntegrationTests
{
    // Note: this does not use CloudProjectFixtureBase as a base class, as an emulator can be used as an alternative.
    // If that pattern becomes more widespread, we can bring that into CloudProjectFixtureBase.
    [CollectionDefinition(nameof(BigtableFixture))]
    public class BigtableFixture : BigtableFixtureBase, ICollectionFixture<BigtableFixture>
    {
        public const string DefaultColumnFamily = "cf1";
        public const string DefaultColumnQualifier = "row_exists";
        public const string DefaultValue = "true";
        public const string OtherColumnFamily = "test_data";

        protected override Table CreateDefaultTable() =>
            new Table
            {
                Granularity = Table.Types.TimestampGranularity.Millis,
                ColumnFamilies =
                {
                    { DefaultColumnFamily, new ColumnFamily { GcRule = new GcRule { MaxNumVersions = 3 } } },
                    { OtherColumnFamily, new ColumnFamily { GcRule = new GcRule { MaxNumVersions = 3 } } }
                }
            };

        public async Task<BigtableByteString> InsertRowAsync(
            TableName tableName,
            string familyName = null,
            BigtableByteString? qualifierName = null,
            BigtableByteString? value = null,
            BigtableVersion? version = null)
        {
            BigtableByteString rowKey = Guid.NewGuid().ToString();

            familyName = familyName ?? DefaultColumnFamily;
            qualifierName = qualifierName ?? DefaultColumnQualifier;
            value = value ?? DefaultValue;

            await TableClient.MutateRowAsync(
                tableName,
                rowKey,
                Mutations.SetCell(
                    familyName,
                    qualifierName.Value,
                    value.Value,
                    version));

            await BigtableAssert.HasSingleValueAsync(
                TableClient,
                tableName,
                rowKey,
                familyName,
                qualifierName.Value,
                value.Value,
                version);

            return rowKey;
        }

        public async Task InsertRowsAsync(
            TableName tableName,
            IEnumerable<BigtableByteString> rowKeys,
            string familyName = null,
            BigtableByteString? qualifierName = null,
            BigtableByteString? valuePrefix = null,
            BigtableVersion? version = null)
        {
            BigtableByteString rowKey = Guid.NewGuid().ToString();

            familyName = familyName ?? DefaultColumnFamily;
            qualifierName = qualifierName ?? "row_index";
            valuePrefix = valuePrefix ?? "";

            int counter = 0;
            var response = await TableClient.MutateRowsAsync(
                tableName,
                rowKeys.Select(k =>
                    Mutations.CreateEntry(
                        k.Value,
                        Mutations.SetCell(
                            familyName,
                            qualifierName.Value,
                            valuePrefix.Value.Value.Concat(
                                new BigtableByteString(counter++).Value),
                            version))).ToArray());
            var entries = response.Entries.OrderBy(e => e.Index);
            Assert.All(entries, e => Assert.Equal((int)Code.Ok, e.Status.Code));
        }
    }
}
