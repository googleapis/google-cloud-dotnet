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
using Google.Apis.Http;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Storage.V1.Tests;

public class StorageClientBuilderTest
{
    [Fact]
    public void GZipEnabled_DefaultIsTrue()
    {
        var client = new StorageClientBuilder { Credential = new FakeCredential() }.Build();
        Assert.True(client.Service.GZipEnabled);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void GZipEnabled_Explicit(bool enableGZip)
    {
        var client = new StorageClientBuilder { Credential = new FakeCredential(), GZipEnabled = enableGZip }.Build();
        Assert.Equal(enableGZip, client.Service.GZipEnabled);
    }

    [Fact]
    public async Task GZipEnabled_Async_DefaultIsTrue()
    {
        var client = await new StorageClientBuilder { Credential = new FakeCredential() }.BuildAsync();
        Assert.True(client.Service.GZipEnabled);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task GZipEnabled_Async_Explicit(bool enableGZip)
    {
        var client = await new StorageClientBuilder { Credential = new FakeCredential(), GZipEnabled = enableGZip }.BuildAsync();
        Assert.Equal(enableGZip, client.Service.GZipEnabled);
    }

    [Fact]
    public void StorageClientBuilder_ExponentialBackOffPolicy_DefaultIsNone()
    {
        var clientBuilder = new StorageClientBuilder { Credential = new FakeCredential() };
        Assert.Equal(ExponentialBackOffPolicy.None, clientBuilder.DefaultExpBackOffPolicy);
    }

    [Theory]
    [InlineData(ExponentialBackOffPolicy.None)]
    [InlineData(ExponentialBackOffPolicy.UnsuccessfulResponse503)]
    [InlineData(ExponentialBackOffPolicy.Exception)]
    public void StorageClientBuilder_ExponentialBackOffPolicy_Explicit(ExponentialBackOffPolicy backOffPolicy)
    {
        var clientBuilder = new StorageClientBuilder { Credential = new FakeCredential(), DefaultExpBackOffPolicy= backOffPolicy };
        Assert.Equal(backOffPolicy, clientBuilder.DefaultExpBackOffPolicy);
    }

    // Fake credential used just to ensure that we don't fetch the application default credentials
    // (which may not be available for unit tests).
    private class FakeCredential : ICredential
    {
        public Task<string> GetAccessTokenForRequestAsync(string authUri = null, CancellationToken cancellationToken = default) =>
            throw new NotImplementedException();

        public void Initialize(ConfigurableHttpClient httpClient)
        {
        }
    }
}
