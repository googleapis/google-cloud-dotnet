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
using Google.Cloud.Language.V1;
using Grpc.Core;
using Xunit;

namespace Google.Cloud.Docs.Snippets;

public class ConfigurationSnippets
{
    // Note: If you change this sample, please also change the sample
    // in Google.Cloud.Language.V1.Snippets.
    [Fact]
    public void ApiKey_Simple()
    {
        string apiKey = "some-api-key";

        // Sample: ApiKey_Simple
        // Create a LanguageServiceClient which uses the given API key
        // instead of regular credentials.
        LanguageServiceClient client = new LanguageServiceClientBuilder
        {
            ApiKey = apiKey
        }.Build();
        // End sample

        Assert.NotNull(client);
    }
}
