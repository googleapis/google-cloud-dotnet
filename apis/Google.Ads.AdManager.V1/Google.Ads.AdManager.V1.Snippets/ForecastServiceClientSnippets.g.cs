// Copyright 2026 Google LLC
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
    using Google.Ads.AdManager.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedForecastServiceClientSnippets
    {
        /// <summary>Snippet for RunAvailabilityForecast</summary>
        public void RunAvailabilityForecastRequestObject()
        {
            // Snippet: RunAvailabilityForecast(RunAvailabilityForecastRequest, CallSettings)
            // Create client
            ForecastServiceClient forecastServiceClient = ForecastServiceClient.Create();
            // Initialize request argument(s)
            RunAvailabilityForecastRequest request = new RunAvailabilityForecastRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AvailabilityForecastOptions = new AvailabilityForecastOptions(),
                ExistingLineItemAsLineItemName = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
            };
            // Make the request
            RunAvailabilityForecastResponse response = forecastServiceClient.RunAvailabilityForecast(request);
            // End snippet
        }

        /// <summary>Snippet for RunAvailabilityForecastAsync</summary>
        public async Task RunAvailabilityForecastRequestObjectAsync()
        {
            // Snippet: RunAvailabilityForecastAsync(RunAvailabilityForecastRequest, CallSettings)
            // Additional: RunAvailabilityForecastAsync(RunAvailabilityForecastRequest, CancellationToken)
            // Create client
            ForecastServiceClient forecastServiceClient = await ForecastServiceClient.CreateAsync();
            // Initialize request argument(s)
            RunAvailabilityForecastRequest request = new RunAvailabilityForecastRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AvailabilityForecastOptions = new AvailabilityForecastOptions(),
                ExistingLineItemAsLineItemName = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
            };
            // Make the request
            RunAvailabilityForecastResponse response = await forecastServiceClient.RunAvailabilityForecastAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RunAvailabilityForecast</summary>
        public void RunAvailabilityForecast()
        {
            // Snippet: RunAvailabilityForecast(string, CallSettings)
            // Create client
            ForecastServiceClient forecastServiceClient = ForecastServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            RunAvailabilityForecastResponse response = forecastServiceClient.RunAvailabilityForecast(parent);
            // End snippet
        }

        /// <summary>Snippet for RunAvailabilityForecastAsync</summary>
        public async Task RunAvailabilityForecastAsync()
        {
            // Snippet: RunAvailabilityForecastAsync(string, CallSettings)
            // Additional: RunAvailabilityForecastAsync(string, CancellationToken)
            // Create client
            ForecastServiceClient forecastServiceClient = await ForecastServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            RunAvailabilityForecastResponse response = await forecastServiceClient.RunAvailabilityForecastAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for RunAvailabilityForecast</summary>
        public void RunAvailabilityForecastResourceNames()
        {
            // Snippet: RunAvailabilityForecast(NetworkName, CallSettings)
            // Create client
            ForecastServiceClient forecastServiceClient = ForecastServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            RunAvailabilityForecastResponse response = forecastServiceClient.RunAvailabilityForecast(parent);
            // End snippet
        }

        /// <summary>Snippet for RunAvailabilityForecastAsync</summary>
        public async Task RunAvailabilityForecastResourceNamesAsync()
        {
            // Snippet: RunAvailabilityForecastAsync(NetworkName, CallSettings)
            // Additional: RunAvailabilityForecastAsync(NetworkName, CancellationToken)
            // Create client
            ForecastServiceClient forecastServiceClient = await ForecastServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            RunAvailabilityForecastResponse response = await forecastServiceClient.RunAvailabilityForecastAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for RunDeliveryForecast</summary>
        public void RunDeliveryForecastRequestObject()
        {
            // Snippet: RunDeliveryForecast(RunDeliveryForecastRequest, CallSettings)
            // Create client
            ForecastServiceClient forecastServiceClient = ForecastServiceClient.Create();
            // Initialize request argument(s)
            RunDeliveryForecastRequest request = new RunDeliveryForecastRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                DeliveryForecastOptions = new DeliveryForecastOptions(),
                ExistingLineItems = new ExistingLineItemList(),
            };
            // Make the request
            RunDeliveryForecastResponse response = forecastServiceClient.RunDeliveryForecast(request);
            // End snippet
        }

        /// <summary>Snippet for RunDeliveryForecastAsync</summary>
        public async Task RunDeliveryForecastRequestObjectAsync()
        {
            // Snippet: RunDeliveryForecastAsync(RunDeliveryForecastRequest, CallSettings)
            // Additional: RunDeliveryForecastAsync(RunDeliveryForecastRequest, CancellationToken)
            // Create client
            ForecastServiceClient forecastServiceClient = await ForecastServiceClient.CreateAsync();
            // Initialize request argument(s)
            RunDeliveryForecastRequest request = new RunDeliveryForecastRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                DeliveryForecastOptions = new DeliveryForecastOptions(),
                ExistingLineItems = new ExistingLineItemList(),
            };
            // Make the request
            RunDeliveryForecastResponse response = await forecastServiceClient.RunDeliveryForecastAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RunDeliveryForecast</summary>
        public void RunDeliveryForecast()
        {
            // Snippet: RunDeliveryForecast(string, CallSettings)
            // Create client
            ForecastServiceClient forecastServiceClient = ForecastServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            RunDeliveryForecastResponse response = forecastServiceClient.RunDeliveryForecast(parent);
            // End snippet
        }

        /// <summary>Snippet for RunDeliveryForecastAsync</summary>
        public async Task RunDeliveryForecastAsync()
        {
            // Snippet: RunDeliveryForecastAsync(string, CallSettings)
            // Additional: RunDeliveryForecastAsync(string, CancellationToken)
            // Create client
            ForecastServiceClient forecastServiceClient = await ForecastServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            RunDeliveryForecastResponse response = await forecastServiceClient.RunDeliveryForecastAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for RunDeliveryForecast</summary>
        public void RunDeliveryForecastResourceNames()
        {
            // Snippet: RunDeliveryForecast(NetworkName, CallSettings)
            // Create client
            ForecastServiceClient forecastServiceClient = ForecastServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            RunDeliveryForecastResponse response = forecastServiceClient.RunDeliveryForecast(parent);
            // End snippet
        }

        /// <summary>Snippet for RunDeliveryForecastAsync</summary>
        public async Task RunDeliveryForecastResourceNamesAsync()
        {
            // Snippet: RunDeliveryForecastAsync(NetworkName, CallSettings)
            // Additional: RunDeliveryForecastAsync(NetworkName, CancellationToken)
            // Create client
            ForecastServiceClient forecastServiceClient = await ForecastServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            RunDeliveryForecastResponse response = await forecastServiceClient.RunDeliveryForecastAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for RunTrafficData</summary>
        public void RunTrafficDataRequestObject()
        {
            // Snippet: RunTrafficData(RunTrafficDataRequest, CallSettings)
            // Create client
            ForecastServiceClient forecastServiceClient = ForecastServiceClient.Create();
            // Initialize request argument(s)
            RunTrafficDataRequest request = new RunTrafficDataRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Targeting = new Targeting(),
                RequestedDateRange = new DateRange(),
            };
            // Make the request
            RunTrafficDataResponse response = forecastServiceClient.RunTrafficData(request);
            // End snippet
        }

        /// <summary>Snippet for RunTrafficDataAsync</summary>
        public async Task RunTrafficDataRequestObjectAsync()
        {
            // Snippet: RunTrafficDataAsync(RunTrafficDataRequest, CallSettings)
            // Additional: RunTrafficDataAsync(RunTrafficDataRequest, CancellationToken)
            // Create client
            ForecastServiceClient forecastServiceClient = await ForecastServiceClient.CreateAsync();
            // Initialize request argument(s)
            RunTrafficDataRequest request = new RunTrafficDataRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Targeting = new Targeting(),
                RequestedDateRange = new DateRange(),
            };
            // Make the request
            RunTrafficDataResponse response = await forecastServiceClient.RunTrafficDataAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RunTrafficData</summary>
        public void RunTrafficData()
        {
            // Snippet: RunTrafficData(string, CallSettings)
            // Create client
            ForecastServiceClient forecastServiceClient = ForecastServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            RunTrafficDataResponse response = forecastServiceClient.RunTrafficData(parent);
            // End snippet
        }

        /// <summary>Snippet for RunTrafficDataAsync</summary>
        public async Task RunTrafficDataAsync()
        {
            // Snippet: RunTrafficDataAsync(string, CallSettings)
            // Additional: RunTrafficDataAsync(string, CancellationToken)
            // Create client
            ForecastServiceClient forecastServiceClient = await ForecastServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            RunTrafficDataResponse response = await forecastServiceClient.RunTrafficDataAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for RunTrafficData</summary>
        public void RunTrafficDataResourceNames()
        {
            // Snippet: RunTrafficData(NetworkName, CallSettings)
            // Create client
            ForecastServiceClient forecastServiceClient = ForecastServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            RunTrafficDataResponse response = forecastServiceClient.RunTrafficData(parent);
            // End snippet
        }

        /// <summary>Snippet for RunTrafficDataAsync</summary>
        public async Task RunTrafficDataResourceNamesAsync()
        {
            // Snippet: RunTrafficDataAsync(NetworkName, CallSettings)
            // Additional: RunTrafficDataAsync(NetworkName, CancellationToken)
            // Create client
            ForecastServiceClient forecastServiceClient = await ForecastServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            RunTrafficDataResponse response = await forecastServiceClient.RunTrafficDataAsync(parent);
            // End snippet
        }
    }
}
