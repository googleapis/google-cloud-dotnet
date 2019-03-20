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

namespace Google.Cloud.Tasks.V2.SmokeTests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;

    public class CloudTasksClientSmokeTest
    {
        private const string LocationEnvironmentVariable = "TEST_PROJECT_LOCATION";

        public static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Error: please specify a project ID");
                return 1;
            }
            string projectId = args[0];
            string location = Environment.GetEnvironmentVariable(LocationEnvironmentVariable);
            if (string.IsNullOrEmpty(location))
            {
                Console.WriteLine($"Error: please specify a project location in {LocationEnvironmentVariable} environment variable");
                return 1;
            }

            LocationName locationName = new LocationName(args[0], location);

            // Create client
            CloudTasksClient client = CloudTasksClient.Create();
            var queues = client.ListQueues(locationName);
            foreach (var queue in queues)
            {
                Console.WriteLine(queue.Name);
            }
            Console.WriteLine("Smoke test passed OK");
            return 0;
        }
    }
}
