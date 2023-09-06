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

// Assumption: we can just use application default credentials.

using Google.Cloud.PubSub.V1;
using System.Diagnostics;

if (args.Length != 2)
{
    Console.WriteLine("Expected arguments: <project-id> <subscription-id>");
    return 1;
}

string projectId = args[0];
string subscriptionId = args[1];
var subscriptionName = new SubscriptionName(projectId, subscriptionId);

var client = new SubscriberClientBuilder
{
    ClientCount = 1,
    SubscriptionName = subscriptionName
}.Build();

Console.WriteLine($"{DateTime.UtcNow:HH:mm:ss}: Starting subscription");
await client.StartAsync((message, token) =>
{
    Console.WriteLine($"{DateTime.UtcNow:HH:mm:ss}: Received message ID {message.MessageId}");
    return Task.FromResult(SubscriberClient.Reply.Ack);
});

return 0;
