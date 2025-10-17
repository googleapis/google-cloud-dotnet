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

using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Google.Cloud.PubSub.V1.Snippets;

// Temporarily disable warnings for obsolete methods. See
// https://github.com/googleapis/google-api-dotnet-client/pull/3043
// for more details.
#pragma warning disable CS0618

public class PublisherClientSnippets
{
    [Fact]
    public void AddPublisherClient()
    {
        string projectId = "projectId";
        string topicId = "topicId";
        var services = new ServiceCollection();

        // Sample: AddPublisherClient
        TopicName topicName = TopicName.FromProjectTopic(projectId, topicId);
        services.AddPublisherClient(topicName);
        // End sample
    }

    [Fact]
    public void AddCustomizedPublisherClient()
    {
        string projectId = "projectId";
        string topicId = "topicId";
        var services = new ServiceCollection();

        // Sample: AddCustomizedPublisherClient
        TopicName topicName = TopicName.FromProjectTopic(projectId, topicId);
        services.AddPublisherClient(builder =>
        {
            builder.TopicName = topicName;
            builder.CredentialsPath = "path/to/credentials.json";
            // Other settings to customize.
        });
        // End sample
    }

    [Fact]
    public void AddCustomizedPublisherClientWithProvider()
    {
        string projectId = "projectId";
        string topicId = "topicId";
        var services = new ServiceCollection();

        // Sample: AddCustomizedPublisherClientWithProvider
        // In one piece of configuration code...
        services.AddSingleton(TopicName.FromProjectTopic(projectId, topicId));
        // Elsewhere...
        services.AddPublisherClient((provider, builder) =>
            builder.TopicName = provider.GetRequiredService<TopicName>());
        // End sample
    }

    [Fact]
    public void AddPublisherClientAndService()
    {
        string projectId = "projectId";
        string topicId = "topicId";
        var services = new ServiceCollection();

        // Sample: AddPublisherClientAndService
        TopicName topicName = TopicName.FromProjectTopic(projectId, topicId);
        services.AddPublisherClient(topicName);
        services.AddSingleton<MyService>();
        // End sample
    }

    // Sample: UsePublisherClient
    public class MyService
    {
        private readonly PublisherClient _publisherClient;

        public MyService(PublisherClient publisherClient)
        {
            _publisherClient = publisherClient;
        }

        // Use the _publisherClient to publish messages.
    }
    // End sample
}
