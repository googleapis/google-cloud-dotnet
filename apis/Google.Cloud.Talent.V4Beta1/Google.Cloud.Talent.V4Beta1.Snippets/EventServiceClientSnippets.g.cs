// Copyright 2019 Google LLC
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

namespace Google.Cloud.Talent.V4Beta1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Talent.V4Beta1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedEventServiceClientSnippets
    {
        /// <summary>Snippet for CreateClientEventAsync</summary>
        public async Task CreateClientEventAsync()
        {
            // Snippet: CreateClientEventAsync(TenantOrProjectNameOneof,ClientEvent,CallSettings)
            // Additional: CreateClientEventAsync(TenantOrProjectNameOneof,ClientEvent,CancellationToken)
            // Create client
            EventServiceClient eventServiceClient = await EventServiceClient.CreateAsync();
            // Initialize request argument(s)
            TenantOrProjectNameOneof parent = TenantOrProjectNameOneof.From(new TenantName("[PROJECT]", "[TENANT]"));
            ClientEvent clientEvent = new ClientEvent();
            // Make the request
            ClientEvent response = await eventServiceClient.CreateClientEventAsync(parent, clientEvent);
            // End snippet
        }

        /// <summary>Snippet for CreateClientEvent</summary>
        public void CreateClientEvent()
        {
            // Snippet: CreateClientEvent(TenantOrProjectNameOneof,ClientEvent,CallSettings)
            // Create client
            EventServiceClient eventServiceClient = EventServiceClient.Create();
            // Initialize request argument(s)
            TenantOrProjectNameOneof parent = TenantOrProjectNameOneof.From(new TenantName("[PROJECT]", "[TENANT]"));
            ClientEvent clientEvent = new ClientEvent();
            // Make the request
            ClientEvent response = eventServiceClient.CreateClientEvent(parent, clientEvent);
            // End snippet
        }

        /// <summary>Snippet for CreateClientEventAsync</summary>
        public async Task CreateClientEventAsync_RequestObject()
        {
            // Snippet: CreateClientEventAsync(CreateClientEventRequest,CallSettings)
            // Additional: CreateClientEventAsync(CreateClientEventRequest,CancellationToken)
            // Create client
            EventServiceClient eventServiceClient = await EventServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateClientEventRequest request = new CreateClientEventRequest
            {
                ParentAsTenantOrProjectNameOneof = TenantOrProjectNameOneof.From(new TenantName("[PROJECT]", "[TENANT]")),
                ClientEvent = new ClientEvent(),
            };
            // Make the request
            ClientEvent response = await eventServiceClient.CreateClientEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateClientEvent</summary>
        public void CreateClientEvent_RequestObject()
        {
            // Snippet: CreateClientEvent(CreateClientEventRequest,CallSettings)
            // Create client
            EventServiceClient eventServiceClient = EventServiceClient.Create();
            // Initialize request argument(s)
            CreateClientEventRequest request = new CreateClientEventRequest
            {
                ParentAsTenantOrProjectNameOneof = TenantOrProjectNameOneof.From(new TenantName("[PROJECT]", "[TENANT]")),
                ClientEvent = new ClientEvent(),
            };
            // Make the request
            ClientEvent response = eventServiceClient.CreateClientEvent(request);
            // End snippet
        }

    }
}
