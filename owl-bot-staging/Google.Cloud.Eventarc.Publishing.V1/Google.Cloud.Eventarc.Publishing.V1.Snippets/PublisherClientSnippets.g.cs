// Copyright 2025 Google LLC
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

// Generated code. DO NOT EDIT!

namespace GoogleCSharpSnippets
{
    using Google.Cloud.Eventarc.Publishing.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPublisherClientSnippets
    {
        /// <summary>Snippet for PublishChannelConnectionEvents</summary>
        public void PublishChannelConnectionEventsRequestObject()
        {
            // Snippet: PublishChannelConnectionEvents(PublishChannelConnectionEventsRequest, CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            PublishChannelConnectionEventsRequest request = new PublishChannelConnectionEventsRequest
            {
                ChannelConnection = "",
                Events = { new Any(), },
                TextEvents = { "", },
            };
            // Make the request
            PublishChannelConnectionEventsResponse response = publisherClient.PublishChannelConnectionEvents(request);
            // End snippet
        }

        /// <summary>Snippet for PublishChannelConnectionEventsAsync</summary>
        public async Task PublishChannelConnectionEventsRequestObjectAsync()
        {
            // Snippet: PublishChannelConnectionEventsAsync(PublishChannelConnectionEventsRequest, CallSettings)
            // Additional: PublishChannelConnectionEventsAsync(PublishChannelConnectionEventsRequest, CancellationToken)
            // Create client
            PublisherClient publisherClient = await PublisherClient.CreateAsync();
            // Initialize request argument(s)
            PublishChannelConnectionEventsRequest request = new PublishChannelConnectionEventsRequest
            {
                ChannelConnection = "",
                Events = { new Any(), },
                TextEvents = { "", },
            };
            // Make the request
            PublishChannelConnectionEventsResponse response = await publisherClient.PublishChannelConnectionEventsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PublishEvents</summary>
        public void PublishEventsRequestObject()
        {
            // Snippet: PublishEvents(PublishEventsRequest, CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            PublishEventsRequest request = new PublishEventsRequest
            {
                Channel = "",
                Events = { new Any(), },
                TextEvents = { "", },
            };
            // Make the request
            PublishEventsResponse response = publisherClient.PublishEvents(request);
            // End snippet
        }

        /// <summary>Snippet for PublishEventsAsync</summary>
        public async Task PublishEventsRequestObjectAsync()
        {
            // Snippet: PublishEventsAsync(PublishEventsRequest, CallSettings)
            // Additional: PublishEventsAsync(PublishEventsRequest, CancellationToken)
            // Create client
            PublisherClient publisherClient = await PublisherClient.CreateAsync();
            // Initialize request argument(s)
            PublishEventsRequest request = new PublishEventsRequest
            {
                Channel = "",
                Events = { new Any(), },
                TextEvents = { "", },
            };
            // Make the request
            PublishEventsResponse response = await publisherClient.PublishEventsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Publish</summary>
        public void PublishRequestObject()
        {
            // Snippet: Publish(PublishRequest, CallSettings)
            // Create client
            PublisherClient publisherClient = PublisherClient.Create();
            // Initialize request argument(s)
            PublishRequest request = new PublishRequest
            {
                MessageBus = "",
                ProtoMessage = new CloudEvent(),
            };
            // Make the request
            PublishResponse response = publisherClient.Publish(request);
            // End snippet
        }

        /// <summary>Snippet for PublishAsync</summary>
        public async Task PublishRequestObjectAsync()
        {
            // Snippet: PublishAsync(PublishRequest, CallSettings)
            // Additional: PublishAsync(PublishRequest, CancellationToken)
            // Create client
            PublisherClient publisherClient = await PublisherClient.CreateAsync();
            // Initialize request argument(s)
            PublishRequest request = new PublishRequest
            {
                MessageBus = "",
                ProtoMessage = new CloudEvent(),
            };
            // Make the request
            PublishResponse response = await publisherClient.PublishAsync(request);
            // End snippet
        }
    }
}
