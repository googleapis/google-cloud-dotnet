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
    public void LanguageApiKey()
    {
        string apiKey = "some-api-key";

        // Sample: ApiKey
        // Create a LanguageServiceSettings that applies the X-Goog-Api-Key
        // header on every request
        LanguageServiceSettings settings = new LanguageServiceSettings
        {
            CallSettings = CallSettings.FromHeader("X-Goog-Api-Key", apiKey)
        };

        // Create a LanguageServiceClient which uses the settings to apply
        // the API key to every request. The ChannelCredentials are set to
        // just SSL; we don't authenticate at the channel level when
        // applying API keys.
        LanguageServiceClient client = new LanguageServiceClientBuilder
        {
            ChannelCredentials = ChannelCredentials.SecureSsl,
            Settings = settings
        }.Build();
        // End sample

        Assert.NotNull(client);
    }
}
