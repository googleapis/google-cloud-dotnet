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

using Google.Apis.Auth.OAuth2;
using Grpc.Auth;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.PubSub.V1.Tests;

public class ServiceCollectionExtensionsTest
{
    [Fact]
    public void AddPublisherClient_WithTopicName()
    {
        // Arrange.
        TopicName topicName = TopicName.FromProjectTopic("projectId", "topicId");
        IServiceCollection serviceCollection = new ServiceCollection();
        // As Application Default Credentials are not available for unit tests, we need to pass a fake credential.
        serviceCollection.AddSingleton(new FakeCredential().ToChannelCredentials());

        // Act.
        serviceCollection.AddPublisherClient(topicName);
        var provider = serviceCollection.BuildServiceProvider();
        var client = provider.GetService<PublisherClient>();

        // Assert.
        Assert.NotNull(client);
        Assert.Equal(topicName, client.TopicName);
    }

    [Fact]
    public void AddPublisherClient_WithAction()
    {
        // Arrange.
        TopicName topicName = TopicName.FromProjectTopic("projectId", "topicId");
        IServiceCollection serviceCollection = new ServiceCollection();
        // As Application Default Credentials are not available for unit tests, we need to pass a fake credential.
        serviceCollection.AddSingleton(new FakeCredential().ToChannelCredentials());

        // Act.
        serviceCollection.AddPublisherClient(builder => builder.TopicName = topicName);
        var provider = serviceCollection.BuildServiceProvider();
        var client = provider.GetService<PublisherClient>();

        // Assert.
        Assert.NotNull(client);
        Assert.Equal(topicName, client.TopicName);
    }

    [Fact]
    public void AddPublisherClient_WithAction_NoTopicName()
    {
        // Arrange.
        IServiceCollection serviceCollection = new ServiceCollection();
        serviceCollection.AddSingleton(new FakeCredential().ToChannelCredentials());

        // Act.
        serviceCollection.AddPublisherClient(builder => { });
        var provider = serviceCollection.BuildServiceProvider();

        // Assert.
        // When TopicName isn't specified, it results in an InvalidOperationException.
        Assert.Throws<InvalidOperationException>(provider.GetRequiredService<PublisherClient>);
    }

    [Fact]
    public void AddPublisherClient_WithNullTopicName()
    {
        // Arrange.
        // Passing null topicName to AddPublisherClient should throw ArgumentNullException.
        IServiceCollection serviceCollection = new ServiceCollection();

        // Act and Assert.
        Assert.Throws<ArgumentNullException>(() => serviceCollection.AddPublisherClient(topicName: null));
    }

    [Fact]
    public void AddPublisherClient_WithNullAction()
    {
        // Arrange.
        // Passing null action to AddPublisherClient should throw ArgumentNullException.
        IServiceCollection serviceCollection = new ServiceCollection();

        // Act and assert.
        Assert.Throws<ArgumentNullException>(() => serviceCollection.AddPublisherClient(action: null));
    }

    [Fact]
    public void AddSubscriberClient_WithTopicName()
    {
        // Arrange.
        SubscriptionName subscriptionName = SubscriptionName.FromProjectSubscription("projectId", "subscriptionId");
        IServiceCollection serviceCollection = new ServiceCollection();
        // As Application Default Credentials are not available for unit tests, we need to pass a fake credential.
        serviceCollection.AddSingleton(new FakeCredential().ToChannelCredentials());

        // Act.
        serviceCollection.AddSubscriberClient(subscriptionName);
        var provider = serviceCollection.BuildServiceProvider();
        var client = provider.GetService<SubscriberClient>();

        // Assert.
        Assert.NotNull(client);
        Assert.Equal(subscriptionName, client.SubscriptionName);
    }

    [Fact]
    public void AddSubscriberClient_WithAction()
    {
        // Arrange.
        SubscriptionName subscriptionName = SubscriptionName.FromProjectSubscription("projectId", "subscriptionId");
        IServiceCollection serviceCollection = new ServiceCollection();
        // As Application Default Credentials are not available for unit tests, we need to pass a fake credential.
        serviceCollection.AddSingleton(new FakeCredential().ToChannelCredentials());

        // Act.
        serviceCollection.AddSubscriberClient(builder => builder.SubscriptionName = subscriptionName);
        var provider = serviceCollection.BuildServiceProvider();
        var client = provider.GetService<SubscriberClient>();

        // Assert.
        Assert.NotNull(client);
        Assert.Equal(subscriptionName, client.SubscriptionName);
    }

    [Fact]
    public void AddSubscriberClient_WithAction_NoSubscriptionName()
    {
        // Arrange.
        // When SubscriptionName isn't specified in the builder, it should result in an InvalidOperationException.
        IServiceCollection serviceCollection = new ServiceCollection();

        //Act.
        serviceCollection.AddSubscriberClient(builder => { });
        var provider = serviceCollection.BuildServiceProvider();

        // Assert.
        Assert.Throws<InvalidOperationException>(provider.GetRequiredService<SubscriberClient>);
    }

    [Fact]
    public void AddSubscriberClient_WithNullSubscriptionName()
    {
        // Arrange.
        // Passing null subscriptionName to AddSubscriberClient should throw ArgumentNullException.
        IServiceCollection serviceCollection = new ServiceCollection();

        // Act and assert.
        Assert.Throws<ArgumentNullException>(() => serviceCollection.AddSubscriberClient(subscriptionName: null));
    }

    [Fact]
    public void AddSubscriberClient_WithNullAction()
    {
        // Arrange.
        // Passing null action to AddSubscriberClient should throw ArgumentNullException.
        IServiceCollection serviceCollection = new ServiceCollection();

        // Act and assert.
        Assert.Throws<ArgumentNullException>(() => serviceCollection.AddSubscriberClient(action: null));
    }

    // Fake credential used just to ensure that we don't fetch the application default credentials
    // (which may not be available for unit tests).
    private class FakeCredential : ITokenAccess
    {
        public Task<string> GetAccessTokenForRequestAsync(string authUri = null, CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();
    }
}
