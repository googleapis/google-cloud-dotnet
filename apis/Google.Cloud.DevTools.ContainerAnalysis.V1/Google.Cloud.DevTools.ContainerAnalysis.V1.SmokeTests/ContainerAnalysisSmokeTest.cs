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

namespace Google.Cloud.DevTools.ContainerAnalysis.V1.SmokeTests
{
    using Google.Api.Gax;
    using Grafeas.V1;
    using System;

    public class ContainerAnalysisSmokeTest
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
            ContainerAnalysisClient containerAnalysisClient = ContainerAnalysisClient.Create();
            // ContainerAnalysisClient doesn't contain Grafeas methods; only IAM, and a way of getting at a GrafeasClient.
            GrafeasClient grafeasClient = containerAnalysisClient.GrafeasClient;

            // Call API method
            ProjectName projectName = new ProjectName(projectId);
            PagedEnumerable<ListNotesResponse, Note> notes = grafeasClient.ListNotes(projectName, "");

            // Show the result
            foreach (Note note in notes)
            {
                Console.WriteLine(notes);
            }

            // Success
            Console.WriteLine("Smoke test passed OK");
            return 0;
        }
    }
}
