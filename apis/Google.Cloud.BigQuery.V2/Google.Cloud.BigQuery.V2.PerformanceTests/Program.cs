// Copyright 2017 Google Inc. All Rights Reserved.
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

using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Google.Cloud.BigQuery.V2.PerformanceTests
{
    internal static class Program
    {
        private static int Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Arguments: <project-id> <path to JSON file containing queries>");
                return 1;
            }

            var client = BigQueryClient.Create(args[0]);
            // Force authentication
            client.ListProjects().ToList();
            var json = File.ReadAllText(args[1]);
            string[] queries = JsonConvert.DeserializeObject<string[]>(json);
            foreach (var query in queries)
            {
                RunQuery(client, query);
            }
            return 0;
        }

        private static void RunQuery(BigQueryClient client, string query)
        {
            Console.WriteLine($"Testing query: {query}");
            TimeSpan? firstRow = null;
            Stopwatch stopwatch = Stopwatch.StartNew();
            var results = client.ExecuteQuery(query, parameters: null);
            TimeSpan queryCompleted = stopwatch.Elapsed;
            int rows = 0;
            foreach (var row in results)
            {
                firstRow = firstRow ?? stopwatch.Elapsed;
                rows++;
            }
            TimeSpan finished = stopwatch.Elapsed;

            Console.WriteLine($"Total rows: {rows}");
            Console.WriteLine($"ExecuteQuery time: {queryCompleted.TotalSeconds}s");
            if (firstRow != null)
            {
                Console.WriteLine($"First row retrieved: {firstRow.Value.TotalSeconds}s");
            }
            Console.WriteLine($"Finished: {finished.TotalSeconds}s");
            Console.WriteLine();
        }
    }
}
