// Copyright 2022 Google LLC
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

using CloudNative.CloudEvents;
using System;
using System.Text.Json;
using Xunit;

namespace Google.Cloud.Eventarc.Publishing.V1.Snippets;

public class PublisherClientSnippets
{
    [Fact]
    public void PublishSingleCloudEvent()
    {
        // Prepare the CloudEvent
        var data = new
        {
            Date = DateTime.Parse("2019-08-01"),
            TemperatureCelsius = 25,
            Summary = "Hot"
        };

        var cloudEvent = new CloudEvent
        {
            Id = Guid.NewGuid().ToString(),
            Type = "event-type",
            Source = new Uri("/cloudevents/spec/pull/123", UriKind.RelativeOrAbsolute),
            // Note: any way of creating the JSON is fine, but Eventarc does require a JSON payload.
            Data = JsonSerializer.Serialize(data),
            DataContentType = "application/json"
        };

        // Construct the channel name
        // TODO: A Channel resource defined in the API would make this simpler.
        string projectId = "...";
        string location = "...";
        string channelId = "...";
        string channelName = $"projects/{projectId}/locations/{location}/channels/{channelId}";

        // Publish the event
        var client = PublisherClient.Create();
        client.PublishEvent(channelName, cloudEvent);
    }
}
