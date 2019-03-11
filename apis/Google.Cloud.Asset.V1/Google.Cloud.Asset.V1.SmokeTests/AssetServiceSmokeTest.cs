// Copyright 2019 Google LLC
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

// Note: this is not currently generated, but is intended to take
// the same form as regular generated smoke tests.
    
namespace Google.Cloud.Asset.V1.SmokeTests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;

    public class AssetServiceSmokeTest
    {
        public static int Main(string[] args)
        {
            // Read projectId from args
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: Project ID must be passed as first argument.");
                Console.WriteLine();
                return 1;
            }
            string projectId = args[0];

            // Create client
            AssetServiceClient client = AssetServiceClient.Create();

            // Initialize request argument(s)
            var request = new BatchGetAssetsHistoryRequest
            {
                ParentAsProjectName = new ProjectName(projectId),
                ContentType = ContentType.Resource,
                ReadTimeWindow = new TimeWindow { StartTime = DateTime.UtcNow.AddDays(-1).ToTimestamp() },
            };

            // Call API method
            client.BatchGetAssetsHistory(request);

            // Success
            Console.WriteLine("Smoke test passed OK");
            return 0;
        }
    }
}
