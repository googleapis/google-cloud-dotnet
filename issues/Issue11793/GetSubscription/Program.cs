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

using Google.Apis.Auth.OAuth2;
using Google.Cloud.PubSub.V1;

if (args.Length != 2)
{
    Console.WriteLine("Arguments: <project-id> <subscription-id>");
    return;
}
string projectId = args[0];
string subscriptionId = args[1];

var cred = GoogleCredential.GetApplicationDefault();
Console.WriteLine($"Service account ID: {((ServiceAccountCredential) cred.UnderlyingCredential).Id}");
var apiClient = new SubscriberServiceApiClientBuilder
{
}.Build();
var sub = apiClient.GetSubscription(new SubscriptionName(projectId, subscriptionId));
Console.WriteLine(sub);

