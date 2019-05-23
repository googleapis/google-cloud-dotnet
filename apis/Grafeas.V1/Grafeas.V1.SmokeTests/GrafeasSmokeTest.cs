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

namespace Grafeas.V1.SmokeTests
{
    using Google.Api.Gax;
    using Google.Apis.Auth.OAuth2;
    using Grpc.Auth;
    using Grpc.Core;
    using System;

    public class GrafeasSmokeTest
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
            
            // Smoke test against the Google Container Analysis implementation, using
            // a known endpoint.

            // Create client
            var channelCredential = GoogleCredential.GetApplicationDefault().ToChannelCredentials();
            var channel = new Channel("containeranalysis.googleapis.com", channelCredential);
            GrafeasClient client = GrafeasClient.Create(channel);

            // Call API method
            ProjectName projectName = new ProjectName(projectId);
            PagedEnumerable<ListNotesResponse, Note> notes = client.ListNotes(projectName, "");

            // Show the result
            foreach (Note note in notes)
            {
                Console.WriteLine(note);
            }

            // Success
            Console.WriteLine("Smoke test passed OK");
            return 0;
        }
    }
}
