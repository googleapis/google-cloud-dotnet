// Copyright 2021 Google LLC
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

// Generated code. DO NOT EDIT!

namespace Grafeas.V1.Snippets
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public sealed partial class GeneratedGrafeasClientStandaloneSnippets
    {
        /// <summary>Snippet for BatchCreateOccurrencesAsync</summary>
        public async Task BatchCreateOccurrencesAsync()
        {
            // Snippet: BatchCreateOccurrencesAsync(string, IEnumerable<Occurrence>, CallSettings)
            // Additional: BatchCreateOccurrencesAsync(string, IEnumerable<Occurrence>, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = await GrafeasClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            IEnumerable<Occurrence> occurrences = new Occurrence[] { new Occurrence(), };
            // Make the request
            BatchCreateOccurrencesResponse response = await grafeasClient.BatchCreateOccurrencesAsync(parent, occurrences);
            // End snippet
        }
    }
}
