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
                    client.DropDatabase(name);
                }
            }
            return 0;
        }
    }
}
