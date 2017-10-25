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

using Google.Api.Gax.Grpc;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Bigtable.Admin.V2;
using Grpc.Core;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Bigtable.V2.IntegrationTests
{
    [CollectionDefinition(nameof(BigtableFixture))]
    public class BigtableFixture : IDisposable, ICollectionFixture<BigtableFixture>
    {
        private const string EmulatorEnvironmentVariable = "BIGTABLE_EMULATOR_HOST";
        private const string TestProjectEnvironmentVariable = "TEST_PROJECT";

        public const string ColumnFamily1 = "cf1";
        public const string OtherColumnFamily = "test_data";

        public ProjectName ProjectName { get; private set; }
        public InstanceName DefaultInstanceName { get; private set; }
        public TableName DefaultTableName { get; private set; }

        public BigtableInstanceAdminClient DefaultInstanceAdminClient { get; private set; }
        public BigtableTableAdminClient DefaultTableAdminClient { get; private set; }
        public BigtableClient DefaultTableClient { get; private set; }

        public Channel EmulatorChannel { get; }

        public BigtableFixture()
        {
            string emulatorHost = Environment.GetEnvironmentVariable(EmulatorEnvironmentVariable);

            string projectId;
            if (!string.IsNullOrEmpty(emulatorHost))
            {
                projectId = "emulator-test-project";
                EmulatorChannel = new Channel(emulatorHost, ChannelCredentials.Insecure);
            }
            else
            {
                projectId = Environment.GetEnvironmentVariable(TestProjectEnvironmentVariable);
                if (string.IsNullOrEmpty(projectId))
                {
                    throw new InvalidOperationException(
                        $"Please set either the {EmulatorEnvironmentVariable} or {TestProjectEnvironmentVariable} environment variable before running tests");
                }
            }

            ProjectName = new ProjectName(projectId);

            Task.Run(InitBigtableInstanceAndTable).Wait();
        }

        private async Task InitBigtableInstanceAndTable()
        {
            DefaultInstanceName = new InstanceName(ProjectName.ProjectId, "i" + Guid.NewGuid().ToString("N"));

            if (EmulatorChannel == null)
            {
                DefaultInstanceAdminClient = BigtableInstanceAdminClient.Create();
                DefaultTableAdminClient = BigtableTableAdminClient.Create();
                DefaultTableClient = BigtableClient.Create();

                // Cluster ID must be max 30 characters
                string clusterId = DefaultInstanceName.InstanceId.Substring(0, 22) + "-cluster";

                var instanceOperation = await DefaultInstanceAdminClient.CreateInstanceAsync(new CreateInstanceRequest
                {
                    Parent = ProjectName.ToString(),
                    InstanceId = DefaultInstanceName.InstanceId,
                    Instance = new Instance
                    {
                        DisplayName = "Integration tests instance",
                        Type = Instance.Types.Type.Development
                    },
                    Clusters =
                    {
                        {
                            clusterId,
                            new Cluster
                            {
                                ClusterName = new ClusterName(ProjectName.ProjectId, DefaultInstanceName.InstanceId, clusterId),
                                DefaultStorageType = StorageType.Hdd,
                                LocationAsLocationName = new LocationName(ProjectName.ProjectId, "us-central1-c")
                            }
                        }
                    }
                });
                await instanceOperation.PollUntilCompletedAsync();
            }
            else
            {
                DefaultTableAdminClient = BigtableTableAdminClient.Create(EmulatorChannel);
                DefaultTableClient = BigtableClient.Create(EmulatorChannel);
            }
            
            DefaultTableName = new TableName(ProjectName.ProjectId, DefaultInstanceName.InstanceId, "default-table");
            await DefaultTableAdminClient.CreateTableAsync(
                DefaultInstanceName,
                DefaultTableName.TableId,
                new Table
                {
                    Granularity = Table.Types.TimestampGranularity.Millis,
                    ColumnFamilies =
                    {
                        { ColumnFamily1, new ColumnFamily { GcRule = new GcRule { MaxNumVersions = 3 } } },
                        { OtherColumnFamily, new ColumnFamily { GcRule = new GcRule { MaxNumVersions = 3 } } }
                    }
                });
        }

        public async Task<BigtableByteString> InsertRowAsync(
            TableName tableName,
            string familyName = null,
            BigtableByteString? qualifierName = null,
            BigtableByteString? value = null,
            BigtableVersion? version = null)
        {
            BigtableByteString rowKey = Guid.NewGuid().ToString();

            familyName = familyName ?? ColumnFamily1;
            qualifierName = qualifierName ?? "row_exists";
            value = value ?? "true";

            await DefaultTableClient.MutateRowAsync(
                tableName,
                rowKey,
                new[]
                {
                    Mutations.SetCell(
                        familyName,
                        qualifierName.Value,
                        value.Value,
                        version)
                });

            await BigtableAssert.HasSingleValueAsync(
                DefaultTableClient,
                tableName,
                rowKey,
                familyName,
                qualifierName.Value,
                value.Value,
                version);

            return rowKey;
        }

        public void Dispose()
        {
            if (DefaultTableAdminClient != null && DefaultTableName != null)
            {
                DefaultTableAdminClient.DeleteTable(new DeleteTableRequest { Name = DefaultTableName.ToString() });
            }

            if (DefaultInstanceAdminClient != null && DefaultInstanceName != null)
            {
                DefaultInstanceAdminClient.DeleteInstance(DefaultInstanceName);
            }
        }
    }
}
