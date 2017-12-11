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
    public class BigtableFixture : IDisposable, ICollectionFixture<BigtableFixture>
    {
        private const string EmulatorEnvironmentVariable = "BIGTABLE_EMULATOR_HOST";
        private const string TestInstanceEnvironmentVariable = "BIGTABLE_TEST_INSTANCE";
        private const string TestProjectEnvironmentVariable = CloudProjectFixtureBase.TestProjectEnvironmentVariable;

        public const string DefaultColumnFamily = "cf1";
        public const string DefaultColumnQualifier = "row_exists";
        public const string DefaultValue = "true";
        public const string OtherColumnFamily = "test_data";

        public ProjectName ProjectName { get; private set; }
        public InstanceName InstanceName { get; private set; }
        public TableName TableName { get; private set; }

        public BigtableInstanceAdminClient InstanceAdminClient { get; private set; }
        public BigtableTableAdminClient TableAdminClient { get; private set; }
        public BigtableClient TableClient { get; private set; }

        public List<TableName> CreatedTables { get; } = new List<TableName>();
        public Channel EmulatorChannel { get; }

        public BigtableFixture()
        {
            string emulatorHost = Environment.GetEnvironmentVariable(EmulatorEnvironmentVariable);

            string projectId;
            string instanceId;
            if (!string.IsNullOrEmpty(emulatorHost))
            {
                projectId = "emulator-test-project";
                EmulatorChannel = new Channel(emulatorHost, ChannelCredentials.Insecure);

                instanceId = "doesnt-matter";
            }
            else
            {
                projectId = Environment.GetEnvironmentVariable(TestProjectEnvironmentVariable);
                if (string.IsNullOrEmpty(projectId))
                {
                    throw new InvalidOperationException(
                        $"Please set either the {EmulatorEnvironmentVariable} or {TestProjectEnvironmentVariable} environment variable before running tests");
                }

                instanceId = Environment.GetEnvironmentVariable(TestInstanceEnvironmentVariable);
                if (string.IsNullOrEmpty(instanceId))
                {
                    throw new InvalidOperationException(
                        $"Please set the {TestInstanceEnvironmentVariable} environment variable before running non-emulator tests.");
                }
            }

            ProjectName = new ProjectName(projectId);
            InstanceName = new InstanceName(projectId, instanceId);

            Task.Run(InitBigtableInstanceAndTable).Wait();
        }

        public async Task<TableName> CreateTable()
        {
            var tableName = new TableName(ProjectName.ProjectId, InstanceName.InstanceId, Guid.NewGuid().ToString());
            CreatedTables.Add(tableName);
            await TableAdminClient.CreateTableAsync(
                new InstanceName(tableName.ProjectId, tableName.InstanceId),
                tableName.TableId,
                new Table
                {
                    Granularity = Table.Types.TimestampGranularity.Millis,
                    ColumnFamilies =
                    {
                        { DefaultColumnFamily, new ColumnFamily { GcRule = new GcRule { MaxNumVersions = 3 } } },
                        { OtherColumnFamily, new ColumnFamily { GcRule = new GcRule { MaxNumVersions = 3 } } }
                    }
                });
            return tableName;
        }

        private async Task InitBigtableInstanceAndTable()
        {
            if (EmulatorChannel == null)
            {
                InstanceAdminClient = BigtableInstanceAdminClient.Create();
                TableAdminClient = BigtableTableAdminClient.Create();
                TableClient = BigtableClient.Create();

                try
                {
                    await InstanceAdminClient.GetInstanceAsync(InstanceName);
                }
                catch (RpcException e) when (e.Status.StatusCode == StatusCode.NotFound)
                {
                    Assert.True(false, $"The Bigtable instance for testing does not exist: {InstanceName}");
                }
            }
            else
            {
                TableAdminClient = BigtableTableAdminClient.Create(EmulatorChannel);
                TableClient = BigtableClient.Create(EmulatorChannel);
            }

            TableName = await CreateTable();
        }

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

            // TODO: Use cleaner API when available.
            int counter = 0;
            var request = new MutateRowsRequest
            {
                TableNameAsTableName = tableName,
                Entries =
                {
                    rowKeys.Select(k => new MutateRowsRequest.Types.Entry
                    {
                        RowKey = k.Value,
                        Mutations =
                        {
                            Mutations.SetCell(
                                familyName,
                                qualifierName.Value,
                                valuePrefix.Value.Value.Concat(new BigtableByteString(counter++).Value),
                                version)
                        }
                    })
                }
            };

            var response = TableClient.MutateRows(request);
            while (await response.ResponseStream.MoveNext(default))
                ;
        }

        public void Dispose()
        {
            if (TableAdminClient != null)
            {
                foreach (var tableName in CreatedTables)
                {
                    try
                    {
                        TableAdminClient.DeleteTable(new DeleteTableRequest { Name = tableName.ToString() });
                    }
                    catch { }
                }
            }
        }
    }
}
