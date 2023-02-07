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
using System;
using Xunit;

namespace Google.Cloud.PubSub.V1.Tests;

public class ServiceCollectionExtensionsTest
{
    private readonly TopicName _topicName = TopicName.FromProjectTopic("projectId", "topicId");
    private readonly SubscriptionName _subscriptionName = SubscriptionName.FromProjectSubscription("projectId", "subscriptionId");

    [Fact]
    public void AddPublisherClient_TopicName()
    {
        IServiceCollection serviceCollection = new ServiceCollection();
        _ = serviceCollection.AddPublisherClient(_topicName);
        var provider = serviceCollection.BuildServiceProvider();
        var client = provider.GetService<PublisherClient>();
        Assert.NotNull(client);
        Assert.Equal(_topicName, client.TopicName);
    }

    [Fact]
    public void AddPublisherClient_PublisherClientBuilder()
    {
        IServiceCollection serviceCollection = new ServiceCollection();
        _ = serviceCollection.AddPublisherClient(builder => builder.TopicName = _topicName);
        var provider = serviceCollection.BuildServiceProvider();
        var client = provider.GetService<PublisherClient>();
        Assert.NotNull(client);
        Assert.Equal(_topicName, client.TopicName);
    }

    [Fact]
    public void AddPublisherClient_PublisherClientBuilder_NoTopicName()
    {
        IServiceCollection serviceCollection = new ServiceCollection();
        _ = serviceCollection.AddPublisherClient(builder => { });
        var provider = serviceCollection.BuildServiceProvider();
        Assert.Throws<InvalidOperationException>(provider.GetRequiredService<PublisherClient>);
    }

    [Fact]
    public void AddPublisherClient_NullTopicName()
    {
        IServiceCollection serviceCollection = new ServiceCollection();
        Assert.Throws<ArgumentNullException>(() => serviceCollection.AddPublisherClient(topicName: null));
    }

    [Fact]
    public void AddPublisherClient_NullPublisherClientBuilder()
    {
        IServiceCollection serviceCollection = new ServiceCollection();
        Assert.Throws<ArgumentNullException>(() => serviceCollection.AddPublisherClient(action: null));
    }

    [Fact]
    public void AddSubscriberClient_TopicName()
    {
        IServiceCollection serviceCollection = new ServiceCollection();
        _ = serviceCollection.AddSubscriberClient(_subscriptionName);
        var provider = serviceCollection.BuildServiceProvider();
        var client = provider.GetService<SubscriberClient>();
        Assert.NotNull(client);
        Assert.Equal(_subscriptionName, client.SubscriptionName);
    }

    [Fact]
    public void AddSubscriberClient_SubscriberClientBuilder()
    {
        IServiceCollection serviceCollection = new ServiceCollection();
        _ = serviceCollection.AddSubscriberClient(builder => builder.SubscriptionName = _subscriptionName);
        var provider = serviceCollection.BuildServiceProvider();
        var client = provider.GetService<SubscriberClient>();
        Assert.NotNull(client);
        Assert.Equal(_subscriptionName, client.SubscriptionName);
    }

    [Fact]
    public void AddSubscriberClient_SubscriberClientBuilder_NoSubscriptionName()
    {
        IServiceCollection serviceCollection = new ServiceCollection();
        _ = serviceCollection.AddSubscriberClient(builder => { });
        var provider = serviceCollection.BuildServiceProvider();
        Assert.Throws<InvalidOperationException>(provider.GetRequiredService<SubscriberClient>);
    }

    [Fact]
    public void AddSubscriberClient_NullSubscriptionName()
    {
        IServiceCollection serviceCollection = new ServiceCollection();
        Assert.Throws<ArgumentNullException>(() => serviceCollection.AddSubscriberClient(subscriptionName: null));
    }

    [Fact]
    public void AddSubscriberClient_NullSubscriberClientBuilder()
    {
        IServiceCollection serviceCollection = new ServiceCollection();
        Assert.Throws<ArgumentNullException>(() => serviceCollection.AddSubscriberClient(action: null));
    }
}
