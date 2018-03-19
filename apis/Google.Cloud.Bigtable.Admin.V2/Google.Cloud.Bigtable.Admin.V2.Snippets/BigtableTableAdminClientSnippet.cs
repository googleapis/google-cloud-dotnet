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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Bigtable.Admin.V2;
using Google.LongRunning;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.Admin.V2.Snippets
{
    public class BigtableTableAdminClientSnippets
    {
        public async Task CheckConsistencyAsync()
        {
            // TODO: When replication goes to beta or GA, having something cleaner available than what is below.

            // Snippet: CheckConsistencyAsync(TableName,string,CallSettings)
            // Additional: GenerateConsistencyTokenAsync(TableName,CallSettings)
            BigtableTableAdminClient adminClient = await BigtableTableAdminClient.CreateAsync();

            BigtableTableAdminSettings settings = BigtableTableAdminSettings.GetDefault();
            CallSettings generateSettings = settings.GenerateConsistencyTokenSettings;
            CallSettings checkConsistencySettings = settings.CheckConsistencySettings;

            // Create a consistency token for the table.
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            GenerateConsistencyTokenResponse generateResponse =
                await adminClient.GenerateConsistencyTokenAsync(tableName, generateSettings);
            string consistencyToken = generateResponse.ConsistencyToken;

            // Check for consistency for 60 seconds at 10 second intervals.
            TimeSpan pollingTimeout = TimeSpan.FromSeconds(60);
            TimeSpan pollingInterval = TimeSpan.FromSeconds(10);
            CheckConsistencyResponse checkConsistencyResponse =
                await Polling.PollRepeatedlyAsync(
                    deadline => adminClient.CheckConsistencyAsync(
                        tableName,
                        consistencyToken,
                        checkConsistencySettings.WithEarlierDeadline(deadline, settings.Clock)),
                    response => response.Consistent,
                    settings.Clock,
                    settings.Scheduler,
                    new PollSettings(Expiration.FromTimeout(pollingTimeout), pollingInterval),
                    checkConsistencySettings.CancellationToken ?? CancellationToken.None);

            if (checkConsistencyResponse.Consistent)
            {
                // Replication has caught up.
            }
            // End snippet
        }
    }
}
