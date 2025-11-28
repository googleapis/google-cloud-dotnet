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

using Google.Api.Gax;
using Google.Apis.Auth.OAuth2;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.PubSub.V1.Snippets
{
    public class SubscriberClientSnippets
    {
        [Fact]
        public void Emulator()
        {
            string projectId = "projectId";
            string subscriptionId = "subscriptionId";

            // Sample: Emulator
            SubscriptionName subscriptionName = SubscriptionName.FromProjectSubscription(projectId, subscriptionId);
            SubscriberClient subscriber = new SubscriberClientBuilder
            {
                SubscriptionName = subscriptionName,
                EmulatorDetection = EmulatorDetection.EmulatorOrProduction
            }.Build();
            // Use subscriber.StartAsync etc as normal
            // End sample
        }

        [Fact]
        public void AddSubscriberClient()
        {
            string projectId = "projectId";
            string subscriptionId = "subscriptionId";
            var services = new ServiceCollection();

            // Sample: AddSubscriberClient
            SubscriptionName subscriptionName = SubscriptionName.FromProjectSubscription(projectId, subscriptionId);
            services.AddSubscriberClient(subscriptionName);
            // End sample
        }

        [Fact]
        public void AddCustomizedSubscriberClient()
        {
            string projectId = "projectId";
            string subscriptionId = "subscriptionId";
            var services = new ServiceCollection();
            var googleCredential = GoogleCredential.FromAccessToken("fake-access-token");

            // Sample: AddCustomizedSubscriberClient
            SubscriptionName subscriptionName = SubscriptionName.FromProjectSubscription(projectId, subscriptionId);
            services.AddSubscriberClient(builder =>
            {
                builder.SubscriptionName = subscriptionName;
                // An instance of Google.Apis.Auth.OAuth2.GoogleCredential that you can create using Google.Apis.Auth.OAuth2.CredentialFactory and other GoogleCredential factory methods.
                builder.GoogleCredential = googleCredential;
                // Other settings to customize the client.
            });
            // End sample
        }

        [Fact]
        public void AddCustomizedSubscriberClientWithProvider()
        {
            string projectId = "projectId";
            string subscriptionId = "subscriptionId";
            var services = new ServiceCollection();

            // Sample: AddCustomizedSubscriberClientWithProvider
            // In one piece of configuration code...
            services.AddSingleton(SubscriptionName.FromProjectSubscription(projectId, subscriptionId));
            // Elsewhere...
            services.AddSubscriberClient((provider, builder) =>
                builder.SubscriptionName = provider.GetRequiredService<SubscriptionName>());
            // End sample
        }

        [Fact]
        public void AddHostedService()
        {
            var services = new ServiceCollection();

            // Sample: AddHostedService
            services.AddHostedService<SubscriberService>();
            // End sample
        }

        internal async Task UseSubscriberServiceInConsoleApp()
        {
            string projectId = "projectId";
            string subscriptionId = "subscriptionId";

            // Sample: UseSubscriberServiceInConsoleApp
            // Add `using Microsoft.Extensions.Hosting;` in the using directives.
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    SubscriptionName subscriptionName = SubscriptionName.FromProjectSubscription(projectId, subscriptionId);
                    services.AddSubscriberClient(subscriptionName);
                    services.AddHostedService<SubscriberService>();
                })
                .Build();

            await host.RunAsync();
            // End sample
        }
    }

    // Sample: UseSubscriberClient
    public class SubscriberService : BackgroundService
    {
        private readonly SubscriberClient _subscriberClient;
        private readonly ILogger<SubscriberService> _logger;

        public SubscriberService(SubscriberClient subscriberClient, ILogger<SubscriberService> logger)
        {
            _subscriberClient = subscriberClient;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken) =>
            await _subscriberClient.StartAsync((msg, token) =>
                {
                    _logger.LogInformation($"Received message {msg.MessageId}: {msg.Data.ToStringUtf8()}");
                    // Handle the message.
                    return Task.FromResult(SubscriberClient.Reply.Ack);
                });

        public override async Task StopAsync(CancellationToken stoppingToken) =>
            await _subscriberClient.StopAsync(stoppingToken);
    }
    // End sample
}
