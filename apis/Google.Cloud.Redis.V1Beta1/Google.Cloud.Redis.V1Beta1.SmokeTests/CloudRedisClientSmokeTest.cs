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

using System;
using Google.Api.Gax.ResourceNames;

namespace Google.Cloud.Redis.V1Beta1.SmokeTests
{
    public class CloudRedisClientSmokeTest
    {
        public static int Main(string[] args)
        {
            var client = CloudRedisClient.Create();
            var locationName = new LocationName(args[0], "-");
            var instances = client.ListInstances(locationName);
            foreach (var instance in instances)
            {
                Console.WriteLine(instance.Name);
            }

            // Success
            Console.WriteLine("Smoke test passed OK");
            return 0;
        }
    }
}
