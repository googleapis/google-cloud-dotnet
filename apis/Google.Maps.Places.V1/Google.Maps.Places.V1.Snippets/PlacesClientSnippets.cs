// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax.Grpc;
using Google.Cloud.ClientTesting;
using System;
using Xunit;

namespace Google.Maps.Places.V1.Snippets;

[SnippetOutputCollector]
public class PlacesClientSnippets
{
    [SkippableFact()]
    public void GettingStarted()
    {
        // See b/414750416
        TestEnvironment.SkipOnRestrictedEnvironment();

        // Sample: GettingStarted
        PlacesClient client = PlacesClient.Create();
        CallSettings callSettings = CallSettings.FromHeader("X-Goog-FieldMask", "*");
        SearchTextRequest request = new SearchTextRequest
        {
            TextQuery = "Google, 1600 Amphitheatre Parkway, CA"
        };
        SearchTextResponse response = client.SearchText(request, callSettings);
        Console.WriteLine(response);
        // End sample
    }
}
