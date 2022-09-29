// Copyright 2022 Google LLC
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
using Grpc.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests;

public class ServiceCollectionExtensionsTests
{
    private const string SampleDataSource = "projects/x/instances/y";

    [Fact]
    public void AddSpannerConnection_NoConfiguration()
    {
        IServiceCollection serviceCollection = new ServiceCollection();
        serviceCollection.AddSpannerConnection("MyConnectionString");
        var provider = serviceCollection.BuildServiceProvider();
        Assert.Throws<InvalidOperationException>(() => provider.GetRequiredService<SpannerConnection>());
    }

    [Fact]
    public void AddSpannerConnection_NoConnectionStringsSection()
    {
        IServiceCollection serviceCollection = new ServiceCollection();
        AddConfiguration(serviceCollection);
        serviceCollection.AddSpannerConnection("MyConnectionString");
        var provider = serviceCollection.BuildServiceProvider();

        Assert.Throws<ArgumentException>(() => provider.GetRequiredService<SpannerConnection>());
    }

    [Fact]
    public void AddSpannerConnection_ConnectionStringMissing()
    {
        IServiceCollection serviceCollection = new ServiceCollection();
        AddConfiguration(serviceCollection, $"ConnectionStrings:OtherConnectionString=Data Source={SampleDataSource}");
        serviceCollection.AddSpannerConnection("MyConnectionString");
        var provider = serviceCollection.BuildServiceProvider();

        Assert.Throws<ArgumentException>(() => provider.GetRequiredService<SpannerConnection>());
    }

    [Fact]
    public void AddSpannerConnection_NoCredentials()
    {
        IServiceCollection serviceCollection = new ServiceCollection();
        AddConfiguration(serviceCollection, $"ConnectionStrings:MyConnectionString=Data Source={SampleDataSource}");
        serviceCollection.AddSpannerConnection("MyConnectionString");
        var provider = serviceCollection.BuildServiceProvider();

        using var connection = provider.GetRequiredService<SpannerConnection>();
        Assert.Null(connection.Builder.GoogleCredential);
        Assert.Null(connection.Builder.CredentialOverride);
        Assert.Equal(SampleDataSource, connection.DataSource);
    }

    [Fact]
    public void AddSpannerConnection_ChannelCredentials()
    {
        var channelCredentials = GoogleCredential.FromAccessToken("token").ToChannelCredentials();
        IServiceCollection serviceCollection = new ServiceCollection();
        AddConfiguration(serviceCollection, $"ConnectionStrings:MyConnectionString=Data Source={SampleDataSource}");
        serviceCollection.AddSpannerConnection("MyConnectionString");
        serviceCollection.AddSingleton(channelCredentials);
        var provider = serviceCollection.BuildServiceProvider();

        using var connection = provider.GetRequiredService<SpannerConnection>();
        Assert.Null(connection.Builder.GoogleCredential);
        Assert.Same(channelCredentials, connection.Builder.CredentialOverride);
        Assert.Equal(SampleDataSource, connection.DataSource);
    }

    [Fact]
    public void AddSpannerConnection_GoogleCredential()
    {
        var googleCredential = GoogleCredential.FromAccessToken("token");
        IServiceCollection serviceCollection = new ServiceCollection();
        AddConfiguration(serviceCollection, $"ConnectionStrings:MyConnectionString=Data Source={SampleDataSource}");
        serviceCollection.AddSpannerConnection("MyConnectionString");
        serviceCollection.AddSingleton(googleCredential);
        var provider = serviceCollection.BuildServiceProvider();

        using var connection = provider.GetRequiredService<SpannerConnection>();
        Assert.Same(googleCredential, connection.Builder.GoogleCredential);
        Assert.Null(connection.Builder.CredentialOverride);
        Assert.Equal(SampleDataSource, connection.DataSource);
    }

    [Fact]
    public void AddSpannerConnection_ChannelCredentialsAndGoogleCredential_ChannelCredentialsTakePriority()
    {
        var channelCredentials = GoogleCredential.FromAccessToken("token").ToChannelCredentials();
        var googleCredential = GoogleCredential.FromAccessToken("token");
        IServiceCollection serviceCollection = new ServiceCollection();
        AddConfiguration(serviceCollection, $"ConnectionStrings:MyConnectionString=Data Source={SampleDataSource}");
        serviceCollection.AddSpannerConnection("MyConnectionString");
        serviceCollection.AddSingleton(googleCredential);
        serviceCollection.AddSingleton(channelCredentials);
        var provider = serviceCollection.BuildServiceProvider();

        using var connection = provider.GetRequiredService<SpannerConnection>();
        Assert.Null(connection.Builder.GoogleCredential);
        Assert.Same(channelCredentials, connection.Builder.CredentialOverride);
        Assert.Equal(SampleDataSource, connection.DataSource);
    }

    /// <summary>
    /// Adds configuration to the service collection, with configuration pairs in the form key=value.
    /// </summary>
    private static void AddConfiguration(IServiceCollection collection, params string[] pairs)
    {
        var configurationManager = new ConfigurationManager();
        var keyValuePairs = pairs.Select(pair => new KeyValuePair<string, string>(pair.Split('=')[0], pair.Split(new[] { '=' }, 2)[1]));
        configurationManager.AddInMemoryCollection(keyValuePairs);
        collection.AddSingleton<IConfiguration>(configurationManager);
    }
}
