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
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedGrafeasClientStandaloneSnippets
    {
        /// <summary>Snippet for UpdateOccurrenceAsync</summary>
        public async Task UpdateOccurrenceRequestObjectAsync()
        {
            // Snippet: UpdateOccurrenceAsync(UpdateOccurrenceRequest, CallSettings)
            // Additional: UpdateOccurrenceAsync(UpdateOccurrenceRequest, CancellationToken)
            // Create client
            GrafeasClient grafeasClient = await GrafeasClient.CreateAsync();
            // Initialize request argument(s)
            UpdateOccurrenceRequest request = new UpdateOccurrenceRequest
            {
                OccurrenceName = OccurrenceName.FromProjectOccurrence("[PROJECT]", "[OCCURRENCE]"),
                Occurrence = new Occurrence(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Occurrence response = await grafeasClient.UpdateOccurrenceAsync(request);
            // End snippet
        }
    }
}
