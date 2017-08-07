// Copyright 2016 Google Inc. All Rights Reserved.
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

using Google.Cloud.Storage.V1;
using System;
using System.Linq;
using System.Threading;

namespace Google.Storage.V2.CleanTestData
{
    /// <summary>
    /// Deletes any buckets left over from test/snippet runs.
    /// </summary>
    public class Program
    {
        private static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.Error.WriteLine("Specify the project ID as the only command line argument");
                return 1;
            }
            string projectId = args[0];
            var client = StorageClient.Create();
            var buckets = client.ListBuckets(projectId).Select(b => b.Name).ToList();
            foreach (var bucket in buckets.Where(IsTestBucket))
            {
                try
                {
                    // Avoid rate limiting
                    Thread.Sleep(1000);
                    DeleteBucket(client, bucket);
                }
                catch (GoogleApiException e)
                {
                    Console.WriteLine($"Failed to delete {bucket}: {e.Message}");
                }
            }
            return 0;
        }

        private static void DeleteBucket(StorageClient client, string bucket)
        {
            var objects = client.ListObjects(bucket, options: new ListObjectsOptions { Versions = true });
            foreach (var obj in objects)
            {
                client.DeleteObject(bucket, obj.Name, new DeleteObjectOptions { Generation = obj.Generation });
                Console.WriteLine($"Deleted {bucket} / {obj.Name} / v{obj.Generation}");
            }
            client.DeleteBucket(bucket);
            Console.WriteLine($"Deleted {bucket}");
        }

        private static bool IsTestBucket(string name) =>
            name.StartsWith("tests-") || name.StartsWith("snippets-") || name.StartsWith("bigquerysnippets-");
    }
}
