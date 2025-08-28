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
    using Google.Api.Gax;
    using Google.Geo.Weather.V1;
    using Google.Type;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedWeatherClientSnippets
    {
        /// <summary>Snippet for LookupCurrentConditions</summary>
        public void LookupCurrentConditionsRequestObject()
        {
            // Snippet: LookupCurrentConditions(LookupCurrentConditionsRequest, CallSettings)
            // Create client
            WeatherClient weatherClient = WeatherClient.Create();
            // Initialize request argument(s)
            LookupCurrentConditionsRequest request = new LookupCurrentConditionsRequest
            {
                Location = new LatLng(),
                UnitsSystem = UnitsSystem.Unspecified,
                LanguageCode = "",
            };
            // Make the request
            LookupCurrentConditionsResponse response = weatherClient.LookupCurrentConditions(request);
            // End snippet
        }

        /// <summary>Snippet for LookupCurrentConditionsAsync</summary>
        public async Task LookupCurrentConditionsRequestObjectAsync()
        {
            // Snippet: LookupCurrentConditionsAsync(LookupCurrentConditionsRequest, CallSettings)
            // Additional: LookupCurrentConditionsAsync(LookupCurrentConditionsRequest, CancellationToken)
            // Create client
            WeatherClient weatherClient = await WeatherClient.CreateAsync();
            // Initialize request argument(s)
            LookupCurrentConditionsRequest request = new LookupCurrentConditionsRequest
            {
                Location = new LatLng(),
                UnitsSystem = UnitsSystem.Unspecified,
                LanguageCode = "",
            };
            // Make the request
            LookupCurrentConditionsResponse response = await weatherClient.LookupCurrentConditionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for LookupForecastHours</summary>
        public void LookupForecastHoursRequestObject()
        {
            // Snippet: LookupForecastHours(LookupForecastHoursRequest, CallSettings)
            // Create client
            WeatherClient weatherClient = WeatherClient.Create();
            // Initialize request argument(s)
            LookupForecastHoursRequest request = new LookupForecastHoursRequest
            {
                Location = new LatLng(),
                Hours = 0,
                UnitsSystem = UnitsSystem.Unspecified,
                LanguageCode = "",
            };
            // Make the request
            PagedEnumerable<LookupForecastHoursResponse, ForecastHour> response = weatherClient.LookupForecastHours(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ForecastHour item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (LookupForecastHoursResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ForecastHour item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ForecastHour> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ForecastHour item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for LookupForecastHoursAsync</summary>
        public async Task LookupForecastHoursRequestObjectAsync()
        {
            // Snippet: LookupForecastHoursAsync(LookupForecastHoursRequest, CallSettings)
            // Create client
            WeatherClient weatherClient = await WeatherClient.CreateAsync();
            // Initialize request argument(s)
            LookupForecastHoursRequest request = new LookupForecastHoursRequest
            {
                Location = new LatLng(),
                Hours = 0,
                UnitsSystem = UnitsSystem.Unspecified,
                LanguageCode = "",
            };
            // Make the request
            PagedAsyncEnumerable<LookupForecastHoursResponse, ForecastHour> response = weatherClient.LookupForecastHoursAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ForecastHour item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((LookupForecastHoursResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ForecastHour item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ForecastHour> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ForecastHour item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for LookupForecastDays</summary>
        public void LookupForecastDaysRequestObject()
        {
            // Snippet: LookupForecastDays(LookupForecastDaysRequest, CallSettings)
            // Create client
            WeatherClient weatherClient = WeatherClient.Create();
            // Initialize request argument(s)
            LookupForecastDaysRequest request = new LookupForecastDaysRequest
            {
                Location = new LatLng(),
                Days = 0,
                UnitsSystem = UnitsSystem.Unspecified,
                LanguageCode = "",
            };
            // Make the request
            PagedEnumerable<LookupForecastDaysResponse, ForecastDay> response = weatherClient.LookupForecastDays(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ForecastDay item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (LookupForecastDaysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ForecastDay item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ForecastDay> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ForecastDay item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for LookupForecastDaysAsync</summary>
        public async Task LookupForecastDaysRequestObjectAsync()
        {
            // Snippet: LookupForecastDaysAsync(LookupForecastDaysRequest, CallSettings)
            // Create client
            WeatherClient weatherClient = await WeatherClient.CreateAsync();
            // Initialize request argument(s)
            LookupForecastDaysRequest request = new LookupForecastDaysRequest
            {
                Location = new LatLng(),
                Days = 0,
                UnitsSystem = UnitsSystem.Unspecified,
                LanguageCode = "",
            };
            // Make the request
            PagedAsyncEnumerable<LookupForecastDaysResponse, ForecastDay> response = weatherClient.LookupForecastDaysAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ForecastDay item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((LookupForecastDaysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ForecastDay item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ForecastDay> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ForecastDay item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for LookupHistoryHours</summary>
        public void LookupHistoryHoursRequestObject()
        {
            // Snippet: LookupHistoryHours(LookupHistoryHoursRequest, CallSettings)
            // Create client
            WeatherClient weatherClient = WeatherClient.Create();
            // Initialize request argument(s)
            LookupHistoryHoursRequest request = new LookupHistoryHoursRequest
            {
                Location = new LatLng(),
                Hours = 0,
                UnitsSystem = UnitsSystem.Unspecified,
                LanguageCode = "",
            };
            // Make the request
            PagedEnumerable<LookupHistoryHoursResponse, HistoryHour> response = weatherClient.LookupHistoryHours(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HistoryHour item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (LookupHistoryHoursResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HistoryHour item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HistoryHour> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HistoryHour item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for LookupHistoryHoursAsync</summary>
        public async Task LookupHistoryHoursRequestObjectAsync()
        {
            // Snippet: LookupHistoryHoursAsync(LookupHistoryHoursRequest, CallSettings)
            // Create client
            WeatherClient weatherClient = await WeatherClient.CreateAsync();
            // Initialize request argument(s)
            LookupHistoryHoursRequest request = new LookupHistoryHoursRequest
            {
                Location = new LatLng(),
                Hours = 0,
                UnitsSystem = UnitsSystem.Unspecified,
                LanguageCode = "",
            };
            // Make the request
            PagedAsyncEnumerable<LookupHistoryHoursResponse, HistoryHour> response = weatherClient.LookupHistoryHoursAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HistoryHour item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((LookupHistoryHoursResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HistoryHour item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HistoryHour> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HistoryHour item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for LookupPublicAlerts</summary>
        public void LookupPublicAlertsRequestObject()
        {
            // Snippet: LookupPublicAlerts(LookupPublicAlertsRequest, CallSettings)
            // Create client
            WeatherClient weatherClient = WeatherClient.Create();
            // Initialize request argument(s)
            LookupPublicAlertsRequest request = new LookupPublicAlertsRequest
            {
                Location = new LatLng(),
                LanguageCode = "",
            };
            // Make the request
            PagedEnumerable<LookupPublicAlertsResponse, PublicAlerts> response = weatherClient.LookupPublicAlerts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PublicAlerts item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (LookupPublicAlertsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublicAlerts item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublicAlerts> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublicAlerts item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for LookupPublicAlertsAsync</summary>
        public async Task LookupPublicAlertsRequestObjectAsync()
        {
            // Snippet: LookupPublicAlertsAsync(LookupPublicAlertsRequest, CallSettings)
            // Create client
            WeatherClient weatherClient = await WeatherClient.CreateAsync();
            // Initialize request argument(s)
            LookupPublicAlertsRequest request = new LookupPublicAlertsRequest
            {
                Location = new LatLng(),
                LanguageCode = "",
            };
            // Make the request
            PagedAsyncEnumerable<LookupPublicAlertsResponse, PublicAlerts> response = weatherClient.LookupPublicAlertsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PublicAlerts item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((LookupPublicAlertsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublicAlerts item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublicAlerts> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublicAlerts item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
