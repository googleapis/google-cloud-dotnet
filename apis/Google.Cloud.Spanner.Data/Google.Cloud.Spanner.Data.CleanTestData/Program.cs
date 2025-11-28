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

using Google.Cloud.Spanner.Admin.Database.V1;
using Google.Cloud.Spanner.Common.V1;
using Grpc.Core;
using System;
using System.Linq;

namespace Google.Cloud.Spanner.Data.CleanTestData
{
    public class Program
    {
        private static int Main(string[] args)
        {
            if (args.Length == 0 || args.Length > 2)
            {
                Console.WriteLine("Arguments: <project ID> [instance ID]");
                Console.WriteLine("A default instance ID of 'spannerintegration' will be used if not specified.");
                return 1;
            }
            string projectId = args[0];
            string instanceId = args.Length == 2 ? args[1] : "spannerintegration";
            var client = DatabaseAdminClient.Create();
            var instanceName = new InstanceName(projectId, instanceId);

            int remainingDatabases = 0;
            const int MaxAttempts = 3;
            for (int attempt = 0; attempt < MaxAttempts; attempt++)
            {
                remainingDatabases = TryClean(client, instanceName);
                if (remainingDatabases == 0)
                {
                    Console.WriteLine("All test databases cleaned");
                    break;
                }
                Console.WriteLine($"{remainingDatabases} databases remaining.");
            }
            if (remainingDatabases != 0)
            {
                Console.WriteLine($"After {MaxAttempts} attempts, {remainingDatabases} databases remain. Aborting.");
            }

            return remainingDatabases;
        }

        private static int TryClean(DatabaseAdminClient client, InstanceName instanceName)
        {
            int failedDatabases = 0;
            var backups = client.ListBackups(instanceName).ToList();
            foreach (var backup in backups)
            {
                if (backup.DatabaseAsDatabaseName.DatabaseId.StartsWith("testdb"))
                {
                    Console.WriteLine($"Dropping backup {backup.Name}");
                    client.DeleteBackup(backup.Name);
                }
            }

            var databases = client.ListDatabases(instanceName).ToList();
            foreach (var database in databases)
            {
                var name = database.DatabaseName;
                if (name.DatabaseId.StartsWith("testdb"))
                {
                    Console.WriteLine($"Dropping {name.DatabaseId}");
                    try
                    {
                        client.DropDatabase(name);
                    }
                    catch (RpcException ex)
                    {
                        Console.WriteLine($"Failed to delete {name.DatabaseId}: {ex.Message}");
                        failedDatabases++;
                    }
                }
            }
            return failedDatabases;
        }
    }
}
