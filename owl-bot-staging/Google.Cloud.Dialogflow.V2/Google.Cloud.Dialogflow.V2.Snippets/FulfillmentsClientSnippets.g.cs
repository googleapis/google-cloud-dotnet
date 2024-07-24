// Copyright 2024 Google LLC
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
    using Google.Cloud.Dialogflow.V2;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedFulfillmentsClientSnippets
    {
        /// <summary>Snippet for GetFulfillment</summary>
        public void GetFulfillmentRequestObject()
        {
            // Snippet: GetFulfillment(GetFulfillmentRequest, CallSettings)
            // Create client
            FulfillmentsClient fulfillmentsClient = FulfillmentsClient.Create();
            // Initialize request argument(s)
            GetFulfillmentRequest request = new GetFulfillmentRequest
            {
                FulfillmentName = FulfillmentName.FromProject("[PROJECT]"),
            };
            // Make the request
            Fulfillment response = fulfillmentsClient.GetFulfillment(request);
            // End snippet
        }

        /// <summary>Snippet for GetFulfillmentAsync</summary>
        public async Task GetFulfillmentRequestObjectAsync()
        {
            // Snippet: GetFulfillmentAsync(GetFulfillmentRequest, CallSettings)
            // Additional: GetFulfillmentAsync(GetFulfillmentRequest, CancellationToken)
            // Create client
            FulfillmentsClient fulfillmentsClient = await FulfillmentsClient.CreateAsync();
            // Initialize request argument(s)
            GetFulfillmentRequest request = new GetFulfillmentRequest
            {
                FulfillmentName = FulfillmentName.FromProject("[PROJECT]"),
            };
            // Make the request
            Fulfillment response = await fulfillmentsClient.GetFulfillmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFulfillment</summary>
        public void GetFulfillment()
        {
            // Snippet: GetFulfillment(string, CallSettings)
            // Create client
            FulfillmentsClient fulfillmentsClient = FulfillmentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/agent/fulfillment";
            // Make the request
            Fulfillment response = fulfillmentsClient.GetFulfillment(name);
            // End snippet
        }

        /// <summary>Snippet for GetFulfillmentAsync</summary>
        public async Task GetFulfillmentAsync()
        {
            // Snippet: GetFulfillmentAsync(string, CallSettings)
            // Additional: GetFulfillmentAsync(string, CancellationToken)
            // Create client
            FulfillmentsClient fulfillmentsClient = await FulfillmentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/agent/fulfillment";
            // Make the request
            Fulfillment response = await fulfillmentsClient.GetFulfillmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFulfillment</summary>
        public void GetFulfillmentResourceNames()
        {
            // Snippet: GetFulfillment(FulfillmentName, CallSettings)
            // Create client
            FulfillmentsClient fulfillmentsClient = FulfillmentsClient.Create();
            // Initialize request argument(s)
            FulfillmentName name = FulfillmentName.FromProject("[PROJECT]");
            // Make the request
            Fulfillment response = fulfillmentsClient.GetFulfillment(name);
            // End snippet
        }

        /// <summary>Snippet for GetFulfillmentAsync</summary>
        public async Task GetFulfillmentResourceNamesAsync()
        {
            // Snippet: GetFulfillmentAsync(FulfillmentName, CallSettings)
            // Additional: GetFulfillmentAsync(FulfillmentName, CancellationToken)
            // Create client
            FulfillmentsClient fulfillmentsClient = await FulfillmentsClient.CreateAsync();
            // Initialize request argument(s)
            FulfillmentName name = FulfillmentName.FromProject("[PROJECT]");
            // Make the request
            Fulfillment response = await fulfillmentsClient.GetFulfillmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateFulfillment</summary>
        public void UpdateFulfillmentRequestObject()
        {
            // Snippet: UpdateFulfillment(UpdateFulfillmentRequest, CallSettings)
            // Create client
            FulfillmentsClient fulfillmentsClient = FulfillmentsClient.Create();
            // Initialize request argument(s)
            UpdateFulfillmentRequest request = new UpdateFulfillmentRequest
            {
                Fulfillment = new Fulfillment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Fulfillment response = fulfillmentsClient.UpdateFulfillment(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFulfillmentAsync</summary>
        public async Task UpdateFulfillmentRequestObjectAsync()
        {
            // Snippet: UpdateFulfillmentAsync(UpdateFulfillmentRequest, CallSettings)
            // Additional: UpdateFulfillmentAsync(UpdateFulfillmentRequest, CancellationToken)
            // Create client
            FulfillmentsClient fulfillmentsClient = await FulfillmentsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFulfillmentRequest request = new UpdateFulfillmentRequest
            {
                Fulfillment = new Fulfillment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Fulfillment response = await fulfillmentsClient.UpdateFulfillmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFulfillment</summary>
        public void UpdateFulfillment()
        {
            // Snippet: UpdateFulfillment(Fulfillment, FieldMask, CallSettings)
            // Create client
            FulfillmentsClient fulfillmentsClient = FulfillmentsClient.Create();
            // Initialize request argument(s)
            Fulfillment fulfillment = new Fulfillment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Fulfillment response = fulfillmentsClient.UpdateFulfillment(fulfillment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateFulfillmentAsync</summary>
        public async Task UpdateFulfillmentAsync()
        {
            // Snippet: UpdateFulfillmentAsync(Fulfillment, FieldMask, CallSettings)
            // Additional: UpdateFulfillmentAsync(Fulfillment, FieldMask, CancellationToken)
            // Create client
            FulfillmentsClient fulfillmentsClient = await FulfillmentsClient.CreateAsync();
            // Initialize request argument(s)
            Fulfillment fulfillment = new Fulfillment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Fulfillment response = await fulfillmentsClient.UpdateFulfillmentAsync(fulfillment, updateMask);
            // End snippet
        }
    }
}
