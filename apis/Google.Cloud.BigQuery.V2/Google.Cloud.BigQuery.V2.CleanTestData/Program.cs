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

using System;
using System.Linq;

namespace Google.Cloud.BigQuery.V2.CleanTestData
{
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
            var client = BigQueryClient.Create(projectId);
            var datasets = client.ListDatasets().ToList();
            foreach (var dataset in datasets.Where(IsTestDataset))
            {
                var id = dataset.Reference.DatasetId;
                try
                {
                    dataset.Delete(new DeleteDatasetOptions { DeleteContents = true });
                    Console.WriteLine($"Deleted {id}");
                }
                catch (GoogleApiException e)
                {
                    Console.WriteLine($"Failed to delete {id}: {e.Message}");
                }
            }
            return 0;
        }

        private static bool IsTestDataset(BigQueryDataset dataset)
        {
            var id = dataset.Reference.DatasetId;
            return id.StartsWith("test_") || id.StartsWith("snippets_") || id.StartsWith("testlabels_");
        }
    }
}
