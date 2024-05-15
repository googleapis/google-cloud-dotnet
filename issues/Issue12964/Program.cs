// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

using Google.Cloud.PubSub.V1;
using Microsoft.Extensions.Logging;

if (args.Length != 2)
{
    Console.WriteLine("Arguments: <project-id> <subscription-id>");
    return;
}

var loggerFactory = LoggerFactory.Create(builder => builder.AddSimpleConsole(options =>
{
    options.SingleLine = true;
    options.TimestampFormat = "yyyy-MM-dd'T'HH:mm:ss.fff'Z '";
    options.UseUtcTimestamp = true;
}));

var client = new SubscriberClientBuilder
{
    SubscriptionName = new SubscriptionName(args[0], args[1]),
    Logger = loggerFactory.CreateLogger("Subscriber")
}.Build();

var handlerLogger = loggerFactory.CreateLogger("Handler");

loggerFactory.CreateLogger("Timing").LogInformation("Starting subscriber");
var task = client.StartAsync((message, cancellationToken) =>
{
    handlerLogger.LogInformation("Received message with text '{text}'. MessageID='{id}'",
        message.Data.ToStringUtf8(), message.MessageId);
    return Task.FromResult(SubscriberClient.Reply.Ack);
});

await task;
