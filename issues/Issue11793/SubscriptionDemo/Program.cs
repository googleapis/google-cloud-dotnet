// Copyright 2024 Google LLC
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

using Google.Api.Gax;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.PubSub.V1;
using Microsoft.Extensions.Logging;

TimeSpan DefaultDelay = TimeSpan.FromSeconds(10);

if (args.Length != 2)
{
    Console.WriteLine("Arguments: <project-id> <subscription-id>");
    return;
}
string projectId = args[0];
string subscriptionId = args[1];

using var loggerFactory = LoggerFactory.Create(builder =>
{
    builder.SetMinimumLevel(LogLevel.Trace);
    builder.AddSimpleConsole(opt =>
    {
        opt.TimestampFormat = "yyyy-MM-dd'T'HH:mm:ss.FFF'Z' ";
        opt.SingleLine = true;
    });
});

var logger = loggerFactory.CreateLogger("Demo");
var credential = await GoogleCredential.GetApplicationDefaultAsync();
Console.WriteLine($"Underlying credential type: {credential.UnderlyingCredential.GetType().Name}");

var subscriberClientBuilder = new SubscriberClientBuilder
{
    Settings = new()
    {
        FlowControlSettings = new FlowControlSettings(10, null),
    },
    ClientCount = 1,
    SubscriptionName = new(projectId, subscriptionId),
    Logger = loggerFactory.CreateLogger<SubscriberClient>(),
    Credential = credential
};

var subscriber = await subscriberClientBuilder.BuildAsync();

var subscriberTask = subscriber.StartAsync(async (message, ct) =>
{
    logger.LogInformation("Received message: ID='{id}'; Text='{text}'", message.MessageId, message.Data.ToStringUtf8());
    var delay = message.Attributes.TryGetValue("delay", out string delayValue) && int.TryParse(delayValue, out int delaySeconds)
        ? TimeSpan.FromSeconds(delaySeconds)
        : DefaultDelay;
    if (delay > TimeSpan.Zero)
    {
        logger.LogInformation("Delaying for {seconds} seconds (message ID {id})", (int) delay.TotalSeconds, message.MessageId);
        await Task.Delay(delay);
        logger.LogInformation("Delay complete for message {id}", message.MessageId);
    }
    return SubscriberClient.Reply.Ack;
});

var quitTask = PromptForQuit();
await Task.WhenAny(quitTask, subscriberTask);

if (!subscriberTask.IsCompleted)
{
    logger.LogInformation("Stopping subscriber");
    await subscriber.StopAsync(TimeSpan.FromMinutes(1));
}
await subscriberTask;

logger.LogInformation("Done");

async Task PromptForQuit()
{
    await Task.Yield();
    Console.WriteLine("Enter 'quit' to stop.");
    while (true)
    {
        var line = Console.ReadLine();
        if (line == "quit")
        {
            break;
        }
    }
}
