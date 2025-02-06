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
    using Google.Cloud.Talent.V4;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedEventServiceClientSnippets
    {
        /// <summary>Snippet for CreateClientEvent</summary>
        public void CreateClientEventRequestObject()
        {
            // Snippet: CreateClientEvent(CreateClientEventRequest, CallSettings)
            // Create client
            EventServiceClient eventServiceClient = EventServiceClient.Create();
            // Initialize request argument(s)
            CreateClientEventRequest request = new CreateClientEventRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ClientEvent = new ClientEvent(),
            };
            // Make the request
            ClientEvent response = eventServiceClient.CreateClientEvent(request);
            // End snippet
        }

        /// <summary>Snippet for CreateClientEventAsync</summary>
        public async Task CreateClientEventRequestObjectAsync()
        {
            // Snippet: CreateClientEventAsync(CreateClientEventRequest, CallSettings)
            // Additional: CreateClientEventAsync(CreateClientEventRequest, CancellationToken)
            // Create client
            EventServiceClient eventServiceClient = await EventServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateClientEventRequest request = new CreateClientEventRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                ClientEvent = new ClientEvent(),
            };
            // Make the request
            ClientEvent response = await eventServiceClient.CreateClientEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateClientEvent</summary>
        public void CreateClientEvent()
        {
            // Snippet: CreateClientEvent(string, ClientEvent, CallSettings)
            // Create client
            EventServiceClient eventServiceClient = EventServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/tenants/[TENANT]";
            ClientEvent clientEvent = new ClientEvent();
            // Make the request
            ClientEvent response = eventServiceClient.CreateClientEvent(parent, clientEvent);
            // End snippet
        }

        /// <summary>Snippet for CreateClientEventAsync</summary>
        public async Task CreateClientEventAsync()
        {
            // Snippet: CreateClientEventAsync(string, ClientEvent, CallSettings)
            // Additional: CreateClientEventAsync(string, ClientEvent, CancellationToken)
            // Create client
            EventServiceClient eventServiceClient = await EventServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/tenants/[TENANT]";
            ClientEvent clientEvent = new ClientEvent();
            // Make the request
            ClientEvent response = await eventServiceClient.CreateClientEventAsync(parent, clientEvent);
            // End snippet
        }

        /// <summary>Snippet for CreateClientEvent</summary>
        public void CreateClientEventResourceNames()
        {
            // Snippet: CreateClientEvent(TenantName, ClientEvent, CallSettings)
            // Create client
            EventServiceClient eventServiceClient = EventServiceClient.Create();
            // Initialize request argument(s)
            TenantName parent = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]");
            ClientEvent clientEvent = new ClientEvent();
            // Make the request
            ClientEvent response = eventServiceClient.CreateClientEvent(parent, clientEvent);
            // End snippet
        }

        /// <summary>Snippet for CreateClientEventAsync</summary>
        public async Task CreateClientEventResourceNamesAsync()
        {
            // Snippet: CreateClientEventAsync(TenantName, ClientEvent, CallSettings)
            // Additional: CreateClientEventAsync(TenantName, ClientEvent, CancellationToken)
            // Create client
            EventServiceClient eventServiceClient = await EventServiceClient.CreateAsync();
            // Initialize request argument(s)
            TenantName parent = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]");
            ClientEvent clientEvent = new ClientEvent();
            // Make the request
            ClientEvent response = await eventServiceClient.CreateClientEventAsync(parent, clientEvent);
            // End snippet
        }
    }
}
