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

namespace Google.Cloud.Irm.V1Alpha2.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using apis = Google.Cloud.Irm.V1Alpha2;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using static SearchSimilarIncidentsResponse.Types;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedIncidentServiceClientSnippets
    {
        /// <summary>Snippet for CreateIncidentAsync</summary>
        public async Task CreateIncidentAsync()
        {
            // Snippet: CreateIncidentAsync(Incident,ProjectName,CallSettings)
            // Additional: CreateIncidentAsync(Incident,ProjectName,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            Incident incident = new Incident();
            ProjectName parent = new ProjectName("[PROJECT]");
            // Make the request
            Incident response = await incidentServiceClient.CreateIncidentAsync(incident, parent);
            // End snippet
        }

        /// <summary>Snippet for CreateIncident</summary>
        public void CreateIncident()
        {
            // Snippet: CreateIncident(Incident,ProjectName,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            Incident incident = new Incident();
            ProjectName parent = new ProjectName("[PROJECT]");
            // Make the request
            Incident response = incidentServiceClient.CreateIncident(incident, parent);
            // End snippet
        }

        /// <summary>Snippet for CreateIncidentAsync</summary>
        public async Task CreateIncidentAsync_RequestObject()
        {
            // Snippet: CreateIncidentAsync(CreateIncidentRequest,CallSettings)
            // Additional: CreateIncidentAsync(CreateIncidentRequest,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateIncidentRequest request = new CreateIncidentRequest
            {
                Incident = new Incident(),
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            Incident response = await incidentServiceClient.CreateIncidentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateIncident</summary>
        public void CreateIncident_RequestObject()
        {
            // Snippet: CreateIncident(CreateIncidentRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            CreateIncidentRequest request = new CreateIncidentRequest
            {
                Incident = new Incident(),
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            Incident response = incidentServiceClient.CreateIncident(request);
            // End snippet
        }

        /// <summary>Snippet for GetIncidentAsync</summary>
        public async Task GetIncidentAsync()
        {
            // Snippet: GetIncidentAsync(IncidentName,CallSettings)
            // Additional: GetIncidentAsync(IncidentName,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            IncidentName name = new IncidentName("[PROJECT]", "[INCIDENT]");
            // Make the request
            Incident response = await incidentServiceClient.GetIncidentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIncident</summary>
        public void GetIncident()
        {
            // Snippet: GetIncident(IncidentName,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            IncidentName name = new IncidentName("[PROJECT]", "[INCIDENT]");
            // Make the request
            Incident response = incidentServiceClient.GetIncident(name);
            // End snippet
        }

        /// <summary>Snippet for GetIncidentAsync</summary>
        public async Task GetIncidentAsync_RequestObject()
        {
            // Snippet: GetIncidentAsync(GetIncidentRequest,CallSettings)
            // Additional: GetIncidentAsync(GetIncidentRequest,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetIncidentRequest request = new GetIncidentRequest
            {
                IncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
            };
            // Make the request
            Incident response = await incidentServiceClient.GetIncidentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIncident</summary>
        public void GetIncident_RequestObject()
        {
            // Snippet: GetIncident(GetIncidentRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            GetIncidentRequest request = new GetIncidentRequest
            {
                IncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
            };
            // Make the request
            Incident response = incidentServiceClient.GetIncident(request);
            // End snippet
        }

        /// <summary>Snippet for SearchIncidentsAsync</summary>
        public async Task SearchIncidentsAsync()
        {
            // Snippet: SearchIncidentsAsync(ProjectName,string,string,string,int?,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            string query = "";
            string timeZone = "";
            // Make the request
            PagedAsyncEnumerable<SearchIncidentsResponse, Incident> response =
                incidentServiceClient.SearchIncidentsAsync(parent, query, timeZone);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Incident item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchIncidentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Incident item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Incident> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Incident item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchIncidents</summary>
        public void SearchIncidents()
        {
            // Snippet: SearchIncidents(ProjectName,string,string,string,int?,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            string query = "";
            string timeZone = "";
            // Make the request
            PagedEnumerable<SearchIncidentsResponse, Incident> response =
                incidentServiceClient.SearchIncidents(parent, query, timeZone);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Incident item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchIncidentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Incident item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Incident> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Incident item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchIncidentsAsync</summary>
        public async Task SearchIncidentsAsync_RequestObject()
        {
            // Snippet: SearchIncidentsAsync(SearchIncidentsRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchIncidentsRequest request = new SearchIncidentsRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<SearchIncidentsResponse, Incident> response =
                incidentServiceClient.SearchIncidentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Incident item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchIncidentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Incident item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Incident> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Incident item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchIncidents</summary>
        public void SearchIncidents_RequestObject()
        {
            // Snippet: SearchIncidents(SearchIncidentsRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            SearchIncidentsRequest request = new SearchIncidentsRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<SearchIncidentsResponse, Incident> response =
                incidentServiceClient.SearchIncidents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Incident item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchIncidentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Incident item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Incident> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Incident item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateIncidentAsync</summary>
        public async Task UpdateIncidentAsync()
        {
            // Snippet: UpdateIncidentAsync(Incident,FieldMask,CallSettings)
            // Additional: UpdateIncidentAsync(Incident,FieldMask,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            Incident incident = new Incident();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Incident response = await incidentServiceClient.UpdateIncidentAsync(incident, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateIncident</summary>
        public void UpdateIncident()
        {
            // Snippet: UpdateIncident(Incident,FieldMask,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            Incident incident = new Incident();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Incident response = incidentServiceClient.UpdateIncident(incident, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateIncidentAsync</summary>
        public async Task UpdateIncidentAsync_RequestObject()
        {
            // Snippet: UpdateIncidentAsync(UpdateIncidentRequest,CallSettings)
            // Additional: UpdateIncidentAsync(UpdateIncidentRequest,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateIncidentRequest request = new UpdateIncidentRequest
            {
                Incident = new Incident(),
            };
            // Make the request
            Incident response = await incidentServiceClient.UpdateIncidentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateIncident</summary>
        public void UpdateIncident_RequestObject()
        {
            // Snippet: UpdateIncident(UpdateIncidentRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            UpdateIncidentRequest request = new UpdateIncidentRequest
            {
                Incident = new Incident(),
            };
            // Make the request
            Incident response = incidentServiceClient.UpdateIncident(request);
            // End snippet
        }

        /// <summary>Snippet for SearchSimilarIncidentsAsync</summary>
        public async Task SearchSimilarIncidentsAsync()
        {
            // Snippet: SearchSimilarIncidentsAsync(string,string,int?,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new IncidentName("[PROJECT]", "[INCIDENT]").ToString();
            // Make the request
            PagedAsyncEnumerable<SearchSimilarIncidentsResponse, Result> response =
                incidentServiceClient.SearchSimilarIncidentsAsync(formattedName);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SearchSimilarIncidentsResponse.Types.Result item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchSimilarIncidentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchSimilarIncidentsResponse.Types.Result item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchSimilarIncidentsResponse.Types.Result> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchSimilarIncidentsResponse.Types.Result item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchSimilarIncidents</summary>
        public void SearchSimilarIncidents()
        {
            // Snippet: SearchSimilarIncidents(string,string,int?,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = new IncidentName("[PROJECT]", "[INCIDENT]").ToString();
            // Make the request
            PagedEnumerable<SearchSimilarIncidentsResponse, Result> response =
                incidentServiceClient.SearchSimilarIncidents(formattedName);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SearchSimilarIncidentsResponse.Types.Result item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchSimilarIncidentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchSimilarIncidentsResponse.Types.Result item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchSimilarIncidentsResponse.Types.Result> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchSimilarIncidentsResponse.Types.Result item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchSimilarIncidentsAsync</summary>
        public async Task SearchSimilarIncidentsAsync_RequestObject()
        {
            // Snippet: SearchSimilarIncidentsAsync(SearchSimilarIncidentsRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchSimilarIncidentsRequest request = new SearchSimilarIncidentsRequest
            {
                Name = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
            };
            // Make the request
            PagedAsyncEnumerable<SearchSimilarIncidentsResponse, Result> response =
                incidentServiceClient.SearchSimilarIncidentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SearchSimilarIncidentsResponse.Types.Result item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchSimilarIncidentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchSimilarIncidentsResponse.Types.Result item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchSimilarIncidentsResponse.Types.Result> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchSimilarIncidentsResponse.Types.Result item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchSimilarIncidents</summary>
        public void SearchSimilarIncidents_RequestObject()
        {
            // Snippet: SearchSimilarIncidents(SearchSimilarIncidentsRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            SearchSimilarIncidentsRequest request = new SearchSimilarIncidentsRequest
            {
                Name = new IncidentName("[PROJECT]", "[INCIDENT]").ToString(),
            };
            // Make the request
            PagedEnumerable<SearchSimilarIncidentsResponse, Result> response =
                incidentServiceClient.SearchSimilarIncidents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SearchSimilarIncidentsResponse.Types.Result item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchSimilarIncidentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchSimilarIncidentsResponse.Types.Result item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchSimilarIncidentsResponse.Types.Result> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchSimilarIncidentsResponse.Types.Result item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateAnnotationAsync</summary>
        public async Task CreateAnnotationAsync()
        {
            // Snippet: CreateAnnotationAsync(IncidentName,Annotation,CallSettings)
            // Additional: CreateAnnotationAsync(IncidentName,Annotation,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            Annotation annotation = new Annotation();
            // Make the request
            Annotation response = await incidentServiceClient.CreateAnnotationAsync(parent, annotation);
            // End snippet
        }

        /// <summary>Snippet for CreateAnnotation</summary>
        public void CreateAnnotation()
        {
            // Snippet: CreateAnnotation(IncidentName,Annotation,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            Annotation annotation = new Annotation();
            // Make the request
            Annotation response = incidentServiceClient.CreateAnnotation(parent, annotation);
            // End snippet
        }

        /// <summary>Snippet for CreateAnnotationAsync</summary>
        public async Task CreateAnnotationAsync_RequestObject()
        {
            // Snippet: CreateAnnotationAsync(CreateAnnotationRequest,CallSettings)
            // Additional: CreateAnnotationAsync(CreateAnnotationRequest,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAnnotationRequest request = new CreateAnnotationRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Annotation = new Annotation(),
            };
            // Make the request
            Annotation response = await incidentServiceClient.CreateAnnotationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAnnotation</summary>
        public void CreateAnnotation_RequestObject()
        {
            // Snippet: CreateAnnotation(CreateAnnotationRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            CreateAnnotationRequest request = new CreateAnnotationRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Annotation = new Annotation(),
            };
            // Make the request
            Annotation response = incidentServiceClient.CreateAnnotation(request);
            // End snippet
        }

        /// <summary>Snippet for ListAnnotationsAsync</summary>
        public async Task ListAnnotationsAsync()
        {
            // Snippet: ListAnnotationsAsync(IncidentName,string,int?,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            // Make the request
            PagedAsyncEnumerable<ListAnnotationsResponse, Annotation> response =
                incidentServiceClient.ListAnnotationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Annotation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAnnotationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Annotation item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Annotation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Annotation item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnnotations</summary>
        public void ListAnnotations()
        {
            // Snippet: ListAnnotations(IncidentName,string,int?,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            // Make the request
            PagedEnumerable<ListAnnotationsResponse, Annotation> response =
                incidentServiceClient.ListAnnotations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Annotation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnnotationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Annotation item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Annotation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Annotation item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnnotationsAsync</summary>
        public async Task ListAnnotationsAsync_RequestObject()
        {
            // Snippet: ListAnnotationsAsync(ListAnnotationsRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAnnotationsRequest request = new ListAnnotationsRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAnnotationsResponse, Annotation> response =
                incidentServiceClient.ListAnnotationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Annotation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAnnotationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Annotation item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Annotation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Annotation item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnnotations</summary>
        public void ListAnnotations_RequestObject()
        {
            // Snippet: ListAnnotations(ListAnnotationsRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            ListAnnotationsRequest request = new ListAnnotationsRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
            };
            // Make the request
            PagedEnumerable<ListAnnotationsResponse, Annotation> response =
                incidentServiceClient.ListAnnotations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Annotation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnnotationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Annotation item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Annotation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Annotation item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateTagAsync</summary>
        public async Task CreateTagAsync()
        {
            // Snippet: CreateTagAsync(IncidentName,Tag,CallSettings)
            // Additional: CreateTagAsync(IncidentName,Tag,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            Tag tag = new Tag();
            // Make the request
            Tag response = await incidentServiceClient.CreateTagAsync(parent, tag);
            // End snippet
        }

        /// <summary>Snippet for CreateTag</summary>
        public void CreateTag()
        {
            // Snippet: CreateTag(IncidentName,Tag,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            Tag tag = new Tag();
            // Make the request
            Tag response = incidentServiceClient.CreateTag(parent, tag);
            // End snippet
        }

        /// <summary>Snippet for CreateTagAsync</summary>
        public async Task CreateTagAsync_RequestObject()
        {
            // Snippet: CreateTagAsync(CreateTagRequest,CallSettings)
            // Additional: CreateTagAsync(CreateTagRequest,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateTagRequest request = new CreateTagRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Tag = new Tag(),
            };
            // Make the request
            Tag response = await incidentServiceClient.CreateTagAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTag</summary>
        public void CreateTag_RequestObject()
        {
            // Snippet: CreateTag(CreateTagRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            CreateTagRequest request = new CreateTagRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Tag = new Tag(),
            };
            // Make the request
            Tag response = incidentServiceClient.CreateTag(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTagAsync</summary>
        public async Task DeleteTagAsync()
        {
            // Snippet: DeleteTagAsync(TagName,CallSettings)
            // Additional: DeleteTagAsync(TagName,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            TagName name = new TagName("[PROJECT]", "[INCIDENT]", "[TAG]");
            // Make the request
            await incidentServiceClient.DeleteTagAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTag</summary>
        public void DeleteTag()
        {
            // Snippet: DeleteTag(TagName,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            TagName name = new TagName("[PROJECT]", "[INCIDENT]", "[TAG]");
            // Make the request
            incidentServiceClient.DeleteTag(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTagAsync</summary>
        public async Task DeleteTagAsync_RequestObject()
        {
            // Snippet: DeleteTagAsync(DeleteTagRequest,CallSettings)
            // Additional: DeleteTagAsync(DeleteTagRequest,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTagRequest request = new DeleteTagRequest
            {
                TagName = new TagName("[PROJECT]", "[INCIDENT]", "[TAG]"),
            };
            // Make the request
            await incidentServiceClient.DeleteTagAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTag</summary>
        public void DeleteTag_RequestObject()
        {
            // Snippet: DeleteTag(DeleteTagRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            DeleteTagRequest request = new DeleteTagRequest
            {
                TagName = new TagName("[PROJECT]", "[INCIDENT]", "[TAG]"),
            };
            // Make the request
            incidentServiceClient.DeleteTag(request);
            // End snippet
        }

        /// <summary>Snippet for ListTagsAsync</summary>
        public async Task ListTagsAsync()
        {
            // Snippet: ListTagsAsync(IncidentName,string,int?,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            // Make the request
            PagedAsyncEnumerable<ListTagsResponse, Tag> response =
                incidentServiceClient.ListTagsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Tag item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTagsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tag item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tag> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tag item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTags</summary>
        public void ListTags()
        {
            // Snippet: ListTags(IncidentName,string,int?,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            // Make the request
            PagedEnumerable<ListTagsResponse, Tag> response =
                incidentServiceClient.ListTags(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Tag item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTagsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tag item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tag> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tag item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagsAsync</summary>
        public async Task ListTagsAsync_RequestObject()
        {
            // Snippet: ListTagsAsync(ListTagsRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTagsRequest request = new ListTagsRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListTagsResponse, Tag> response =
                incidentServiceClient.ListTagsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Tag item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTagsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tag item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tag> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tag item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTags</summary>
        public void ListTags_RequestObject()
        {
            // Snippet: ListTags(ListTagsRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            ListTagsRequest request = new ListTagsRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
            };
            // Make the request
            PagedEnumerable<ListTagsResponse, Tag> response =
                incidentServiceClient.ListTags(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Tag item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTagsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tag item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tag> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tag item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateSignalAsync</summary>
        public async Task CreateSignalAsync()
        {
            // Snippet: CreateSignalAsync(ProjectName,Signal,CallSettings)
            // Additional: CreateSignalAsync(ProjectName,Signal,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            Signal signal = new Signal();
            // Make the request
            Signal response = await incidentServiceClient.CreateSignalAsync(parent, signal);
            // End snippet
        }

        /// <summary>Snippet for CreateSignal</summary>
        public void CreateSignal()
        {
            // Snippet: CreateSignal(ProjectName,Signal,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            Signal signal = new Signal();
            // Make the request
            Signal response = incidentServiceClient.CreateSignal(parent, signal);
            // End snippet
        }

        /// <summary>Snippet for CreateSignalAsync</summary>
        public async Task CreateSignalAsync_RequestObject()
        {
            // Snippet: CreateSignalAsync(CreateSignalRequest,CallSettings)
            // Additional: CreateSignalAsync(CreateSignalRequest,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSignalRequest request = new CreateSignalRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Signal = new Signal(),
            };
            // Make the request
            Signal response = await incidentServiceClient.CreateSignalAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSignal</summary>
        public void CreateSignal_RequestObject()
        {
            // Snippet: CreateSignal(CreateSignalRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            CreateSignalRequest request = new CreateSignalRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Signal = new Signal(),
            };
            // Make the request
            Signal response = incidentServiceClient.CreateSignal(request);
            // End snippet
        }

        /// <summary>Snippet for SearchSignalsAsync</summary>
        public async Task SearchSignalsAsync()
        {
            // Snippet: SearchSignalsAsync(ProjectName,string,string,int?,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            string query = "";
            // Make the request
            PagedAsyncEnumerable<SearchSignalsResponse, Signal> response =
                incidentServiceClient.SearchSignalsAsync(parent, query);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Signal item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchSignalsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Signal item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Signal> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Signal item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchSignals</summary>
        public void SearchSignals()
        {
            // Snippet: SearchSignals(ProjectName,string,string,int?,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            string query = "";
            // Make the request
            PagedEnumerable<SearchSignalsResponse, Signal> response =
                incidentServiceClient.SearchSignals(parent, query);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Signal item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchSignalsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Signal item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Signal> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Signal item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchSignalsAsync</summary>
        public async Task SearchSignalsAsync_RequestObject()
        {
            // Snippet: SearchSignalsAsync(SearchSignalsRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchSignalsRequest request = new SearchSignalsRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<SearchSignalsResponse, Signal> response =
                incidentServiceClient.SearchSignalsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Signal item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchSignalsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Signal item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Signal> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Signal item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchSignals</summary>
        public void SearchSignals_RequestObject()
        {
            // Snippet: SearchSignals(SearchSignalsRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            SearchSignalsRequest request = new SearchSignalsRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<SearchSignalsResponse, Signal> response =
                incidentServiceClient.SearchSignals(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Signal item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchSignalsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Signal item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Signal> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Signal item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSignalAsync</summary>
        public async Task GetSignalAsync()
        {
            // Snippet: GetSignalAsync(SignalName,CallSettings)
            // Additional: GetSignalAsync(SignalName,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            SignalName name = new SignalName("[PROJECT]", "[SIGNAL]");
            // Make the request
            Signal response = await incidentServiceClient.GetSignalAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSignal</summary>
        public void GetSignal()
        {
            // Snippet: GetSignal(SignalName,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            SignalName name = new SignalName("[PROJECT]", "[SIGNAL]");
            // Make the request
            Signal response = incidentServiceClient.GetSignal(name);
            // End snippet
        }

        /// <summary>Snippet for GetSignalAsync</summary>
        public async Task GetSignalAsync_RequestObject()
        {
            // Snippet: GetSignalAsync(GetSignalRequest,CallSettings)
            // Additional: GetSignalAsync(GetSignalRequest,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSignalRequest request = new GetSignalRequest
            {
                SignalName = new SignalName("[PROJECT]", "[SIGNAL]"),
            };
            // Make the request
            Signal response = await incidentServiceClient.GetSignalAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSignal</summary>
        public void GetSignal_RequestObject()
        {
            // Snippet: GetSignal(GetSignalRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            GetSignalRequest request = new GetSignalRequest
            {
                SignalName = new SignalName("[PROJECT]", "[SIGNAL]"),
            };
            // Make the request
            Signal response = incidentServiceClient.GetSignal(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSignalAsync</summary>
        public async Task UpdateSignalAsync()
        {
            // Snippet: UpdateSignalAsync(Signal,FieldMask,CallSettings)
            // Additional: UpdateSignalAsync(Signal,FieldMask,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            Signal signal = new Signal();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Signal response = await incidentServiceClient.UpdateSignalAsync(signal, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSignal</summary>
        public void UpdateSignal()
        {
            // Snippet: UpdateSignal(Signal,FieldMask,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            Signal signal = new Signal();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Signal response = incidentServiceClient.UpdateSignal(signal, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSignalAsync</summary>
        public async Task UpdateSignalAsync_RequestObject()
        {
            // Snippet: UpdateSignalAsync(UpdateSignalRequest,CallSettings)
            // Additional: UpdateSignalAsync(UpdateSignalRequest,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSignalRequest request = new UpdateSignalRequest
            {
                Signal = new Signal(),
            };
            // Make the request
            Signal response = await incidentServiceClient.UpdateSignalAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSignal</summary>
        public void UpdateSignal_RequestObject()
        {
            // Snippet: UpdateSignal(UpdateSignalRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            UpdateSignalRequest request = new UpdateSignalRequest
            {
                Signal = new Signal(),
            };
            // Make the request
            Signal response = incidentServiceClient.UpdateSignal(request);
            // End snippet
        }

        /// <summary>Snippet for EscalateIncidentAsync</summary>
        public async Task EscalateIncidentAsync_RequestObject()
        {
            // Snippet: EscalateIncidentAsync(EscalateIncidentRequest,CallSettings)
            // Additional: EscalateIncidentAsync(EscalateIncidentRequest,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            EscalateIncidentRequest request = new EscalateIncidentRequest
            {
                Incident = new Incident(),
            };
            // Make the request
            EscalateIncidentResponse response = await incidentServiceClient.EscalateIncidentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for EscalateIncident</summary>
        public void EscalateIncident_RequestObject()
        {
            // Snippet: EscalateIncident(EscalateIncidentRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            EscalateIncidentRequest request = new EscalateIncidentRequest
            {
                Incident = new Incident(),
            };
            // Make the request
            EscalateIncidentResponse response = incidentServiceClient.EscalateIncident(request);
            // End snippet
        }

        /// <summary>Snippet for CreateArtifactAsync</summary>
        public async Task CreateArtifactAsync()
        {
            // Snippet: CreateArtifactAsync(IncidentName,Artifact,CallSettings)
            // Additional: CreateArtifactAsync(IncidentName,Artifact,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            Artifact artifact = new Artifact();
            // Make the request
            Artifact response = await incidentServiceClient.CreateArtifactAsync(parent, artifact);
            // End snippet
        }

        /// <summary>Snippet for CreateArtifact</summary>
        public void CreateArtifact()
        {
            // Snippet: CreateArtifact(IncidentName,Artifact,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            Artifact artifact = new Artifact();
            // Make the request
            Artifact response = incidentServiceClient.CreateArtifact(parent, artifact);
            // End snippet
        }

        /// <summary>Snippet for CreateArtifactAsync</summary>
        public async Task CreateArtifactAsync_RequestObject()
        {
            // Snippet: CreateArtifactAsync(CreateArtifactRequest,CallSettings)
            // Additional: CreateArtifactAsync(CreateArtifactRequest,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Artifact = new Artifact(),
            };
            // Make the request
            Artifact response = await incidentServiceClient.CreateArtifactAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateArtifact</summary>
        public void CreateArtifact_RequestObject()
        {
            // Snippet: CreateArtifact(CreateArtifactRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            CreateArtifactRequest request = new CreateArtifactRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Artifact = new Artifact(),
            };
            // Make the request
            Artifact response = incidentServiceClient.CreateArtifact(request);
            // End snippet
        }

        /// <summary>Snippet for ListArtifactsAsync</summary>
        public async Task ListArtifactsAsync()
        {
            // Snippet: ListArtifactsAsync(IncidentName,string,int?,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            // Make the request
            PagedAsyncEnumerable<ListArtifactsResponse, Artifact> response =
                incidentServiceClient.ListArtifactsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Artifact item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListArtifactsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Artifact item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Artifact> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Artifact item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListArtifacts</summary>
        public void ListArtifacts()
        {
            // Snippet: ListArtifacts(IncidentName,string,int?,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            // Make the request
            PagedEnumerable<ListArtifactsResponse, Artifact> response =
                incidentServiceClient.ListArtifacts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Artifact item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListArtifactsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Artifact item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Artifact> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Artifact item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListArtifactsAsync</summary>
        public async Task ListArtifactsAsync_RequestObject()
        {
            // Snippet: ListArtifactsAsync(ListArtifactsRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListArtifactsRequest request = new ListArtifactsRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListArtifactsResponse, Artifact> response =
                incidentServiceClient.ListArtifactsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Artifact item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListArtifactsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Artifact item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Artifact> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Artifact item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListArtifacts</summary>
        public void ListArtifacts_RequestObject()
        {
            // Snippet: ListArtifacts(ListArtifactsRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            ListArtifactsRequest request = new ListArtifactsRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
            };
            // Make the request
            PagedEnumerable<ListArtifactsResponse, Artifact> response =
                incidentServiceClient.ListArtifacts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Artifact item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListArtifactsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Artifact item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Artifact> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Artifact item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateArtifactAsync</summary>
        public async Task UpdateArtifactAsync()
        {
            // Snippet: UpdateArtifactAsync(Artifact,FieldMask,CallSettings)
            // Additional: UpdateArtifactAsync(Artifact,FieldMask,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            Artifact artifact = new Artifact();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Artifact response = await incidentServiceClient.UpdateArtifactAsync(artifact, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateArtifact</summary>
        public void UpdateArtifact()
        {
            // Snippet: UpdateArtifact(Artifact,FieldMask,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            Artifact artifact = new Artifact();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Artifact response = incidentServiceClient.UpdateArtifact(artifact, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateArtifactAsync</summary>
        public async Task UpdateArtifactAsync_RequestObject()
        {
            // Snippet: UpdateArtifactAsync(UpdateArtifactRequest,CallSettings)
            // Additional: UpdateArtifactAsync(UpdateArtifactRequest,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateArtifactRequest request = new UpdateArtifactRequest
            {
                Artifact = new Artifact(),
            };
            // Make the request
            Artifact response = await incidentServiceClient.UpdateArtifactAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateArtifact</summary>
        public void UpdateArtifact_RequestObject()
        {
            // Snippet: UpdateArtifact(UpdateArtifactRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            UpdateArtifactRequest request = new UpdateArtifactRequest
            {
                Artifact = new Artifact(),
            };
            // Make the request
            Artifact response = incidentServiceClient.UpdateArtifact(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteArtifactAsync</summary>
        public async Task DeleteArtifactAsync()
        {
            // Snippet: DeleteArtifactAsync(ArtifactName,CallSettings)
            // Additional: DeleteArtifactAsync(ArtifactName,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ArtifactName name = new ArtifactName("[PROJECT]", "[INCIDENT]", "[ARTIFACT]");
            // Make the request
            await incidentServiceClient.DeleteArtifactAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteArtifact</summary>
        public void DeleteArtifact()
        {
            // Snippet: DeleteArtifact(ArtifactName,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            ArtifactName name = new ArtifactName("[PROJECT]", "[INCIDENT]", "[ARTIFACT]");
            // Make the request
            incidentServiceClient.DeleteArtifact(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteArtifactAsync</summary>
        public async Task DeleteArtifactAsync_RequestObject()
        {
            // Snippet: DeleteArtifactAsync(DeleteArtifactRequest,CallSettings)
            // Additional: DeleteArtifactAsync(DeleteArtifactRequest,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteArtifactRequest request = new DeleteArtifactRequest
            {
                ArtifactName = new ArtifactName("[PROJECT]", "[INCIDENT]", "[ARTIFACT]"),
            };
            // Make the request
            await incidentServiceClient.DeleteArtifactAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteArtifact</summary>
        public void DeleteArtifact_RequestObject()
        {
            // Snippet: DeleteArtifact(DeleteArtifactRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            DeleteArtifactRequest request = new DeleteArtifactRequest
            {
                ArtifactName = new ArtifactName("[PROJECT]", "[INCIDENT]", "[ARTIFACT]"),
            };
            // Make the request
            incidentServiceClient.DeleteArtifact(request);
            // End snippet
        }

        /// <summary>Snippet for SendShiftHandoffAsync</summary>
        public async Task SendShiftHandoffAsync_RequestObject()
        {
            // Snippet: SendShiftHandoffAsync(SendShiftHandoffRequest,CallSettings)
            // Additional: SendShiftHandoffAsync(SendShiftHandoffRequest,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            SendShiftHandoffRequest request = new SendShiftHandoffRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Recipients = { },
                Subject = "",
            };
            // Make the request
            SendShiftHandoffResponse response = await incidentServiceClient.SendShiftHandoffAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SendShiftHandoff</summary>
        public void SendShiftHandoff_RequestObject()
        {
            // Snippet: SendShiftHandoff(SendShiftHandoffRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            SendShiftHandoffRequest request = new SendShiftHandoffRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Recipients = { },
                Subject = "",
            };
            // Make the request
            SendShiftHandoffResponse response = incidentServiceClient.SendShiftHandoff(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSubscriptionAsync</summary>
        public async Task CreateSubscriptionAsync()
        {
            // Snippet: CreateSubscriptionAsync(IncidentName,Subscription,CallSettings)
            // Additional: CreateSubscriptionAsync(IncidentName,Subscription,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            Subscription subscription = new Subscription();
            // Make the request
            Subscription response = await incidentServiceClient.CreateSubscriptionAsync(parent, subscription);
            // End snippet
        }

        /// <summary>Snippet for CreateSubscription</summary>
        public void CreateSubscription()
        {
            // Snippet: CreateSubscription(IncidentName,Subscription,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            Subscription subscription = new Subscription();
            // Make the request
            Subscription response = incidentServiceClient.CreateSubscription(parent, subscription);
            // End snippet
        }

        /// <summary>Snippet for CreateSubscriptionAsync</summary>
        public async Task CreateSubscriptionAsync_RequestObject()
        {
            // Snippet: CreateSubscriptionAsync(CreateSubscriptionRequest,CallSettings)
            // Additional: CreateSubscriptionAsync(CreateSubscriptionRequest,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSubscriptionRequest request = new CreateSubscriptionRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Subscription = new Subscription(),
            };
            // Make the request
            Subscription response = await incidentServiceClient.CreateSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSubscription</summary>
        public void CreateSubscription_RequestObject()
        {
            // Snippet: CreateSubscription(CreateSubscriptionRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            CreateSubscriptionRequest request = new CreateSubscriptionRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                Subscription = new Subscription(),
            };
            // Make the request
            Subscription response = incidentServiceClient.CreateSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSubscriptionAsync</summary>
        public async Task UpdateSubscriptionAsync()
        {
            // Snippet: UpdateSubscriptionAsync(Subscription,FieldMask,CallSettings)
            // Additional: UpdateSubscriptionAsync(Subscription,FieldMask,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            Subscription subscription = new Subscription();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Subscription response = await incidentServiceClient.UpdateSubscriptionAsync(subscription, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSubscription</summary>
        public void UpdateSubscription()
        {
            // Snippet: UpdateSubscription(Subscription,FieldMask,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            Subscription subscription = new Subscription();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Subscription response = incidentServiceClient.UpdateSubscription(subscription, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSubscriptionAsync</summary>
        public async Task UpdateSubscriptionAsync_RequestObject()
        {
            // Snippet: UpdateSubscriptionAsync(UpdateSubscriptionRequest,CallSettings)
            // Additional: UpdateSubscriptionAsync(UpdateSubscriptionRequest,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSubscriptionRequest request = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription(),
            };
            // Make the request
            Subscription response = await incidentServiceClient.UpdateSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSubscription</summary>
        public void UpdateSubscription_RequestObject()
        {
            // Snippet: UpdateSubscription(UpdateSubscriptionRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            UpdateSubscriptionRequest request = new UpdateSubscriptionRequest
            {
                Subscription = new Subscription(),
            };
            // Make the request
            Subscription response = incidentServiceClient.UpdateSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for ListSubscriptionsAsync</summary>
        public async Task ListSubscriptionsAsync()
        {
            // Snippet: ListSubscriptionsAsync(IncidentName,string,int?,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            // Make the request
            PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> response =
                incidentServiceClient.ListSubscriptionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Subscription item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSubscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscription> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscription item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubscriptions</summary>
        public void ListSubscriptions()
        {
            // Snippet: ListSubscriptions(IncidentName,string,int?,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            // Make the request
            PagedEnumerable<ListSubscriptionsResponse, Subscription> response =
                incidentServiceClient.ListSubscriptions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Subscription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscription> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscription item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubscriptionsAsync</summary>
        public async Task ListSubscriptionsAsync_RequestObject()
        {
            // Snippet: ListSubscriptionsAsync(ListSubscriptionsRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSubscriptionsRequest request = new ListSubscriptionsRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> response =
                incidentServiceClient.ListSubscriptionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Subscription item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSubscriptionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscription> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscription item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubscriptions</summary>
        public void ListSubscriptions_RequestObject()
        {
            // Snippet: ListSubscriptions(ListSubscriptionsRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            ListSubscriptionsRequest request = new ListSubscriptionsRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
            };
            // Make the request
            PagedEnumerable<ListSubscriptionsResponse, Subscription> response =
                incidentServiceClient.ListSubscriptions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Subscription item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubscriptionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subscription item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subscription> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subscription item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscriptionAsync</summary>
        public async Task DeleteSubscriptionAsync()
        {
            // Snippet: DeleteSubscriptionAsync(SubscriptionName,CallSettings)
            // Additional: DeleteSubscriptionAsync(SubscriptionName,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            SubscriptionName name = new SubscriptionName("[PROJECT]", "[INCIDENT]", "[SUBSCRIPTION]");
            // Make the request
            await incidentServiceClient.DeleteSubscriptionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscription</summary>
        public void DeleteSubscription()
        {
            // Snippet: DeleteSubscription(SubscriptionName,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            SubscriptionName name = new SubscriptionName("[PROJECT]", "[INCIDENT]", "[SUBSCRIPTION]");
            // Make the request
            incidentServiceClient.DeleteSubscription(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscriptionAsync</summary>
        public async Task DeleteSubscriptionAsync_RequestObject()
        {
            // Snippet: DeleteSubscriptionAsync(DeleteSubscriptionRequest,CallSettings)
            // Additional: DeleteSubscriptionAsync(DeleteSubscriptionRequest,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[INCIDENT]", "[SUBSCRIPTION]"),
            };
            // Make the request
            await incidentServiceClient.DeleteSubscriptionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubscription</summary>
        public void DeleteSubscription_RequestObject()
        {
            // Snippet: DeleteSubscription(DeleteSubscriptionRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            DeleteSubscriptionRequest request = new DeleteSubscriptionRequest
            {
                SubscriptionName = new SubscriptionName("[PROJECT]", "[INCIDENT]", "[SUBSCRIPTION]"),
            };
            // Make the request
            incidentServiceClient.DeleteSubscription(request);
            // End snippet
        }

        /// <summary>Snippet for CreateIncidentRoleAssignmentAsync</summary>
        public async Task CreateIncidentRoleAssignmentAsync()
        {
            // Snippet: CreateIncidentRoleAssignmentAsync(IncidentName,IncidentRoleAssignment,CallSettings)
            // Additional: CreateIncidentRoleAssignmentAsync(IncidentName,IncidentRoleAssignment,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            IncidentRoleAssignment incidentRoleAssignment = new IncidentRoleAssignment();
            // Make the request
            IncidentRoleAssignment response = await incidentServiceClient.CreateIncidentRoleAssignmentAsync(parent, incidentRoleAssignment);
            // End snippet
        }

        /// <summary>Snippet for CreateIncidentRoleAssignment</summary>
        public void CreateIncidentRoleAssignment()
        {
            // Snippet: CreateIncidentRoleAssignment(IncidentName,IncidentRoleAssignment,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            IncidentRoleAssignment incidentRoleAssignment = new IncidentRoleAssignment();
            // Make the request
            IncidentRoleAssignment response = incidentServiceClient.CreateIncidentRoleAssignment(parent, incidentRoleAssignment);
            // End snippet
        }

        /// <summary>Snippet for CreateIncidentRoleAssignmentAsync</summary>
        public async Task CreateIncidentRoleAssignmentAsync_RequestObject()
        {
            // Snippet: CreateIncidentRoleAssignmentAsync(CreateIncidentRoleAssignmentRequest,CallSettings)
            // Additional: CreateIncidentRoleAssignmentAsync(CreateIncidentRoleAssignmentRequest,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateIncidentRoleAssignmentRequest request = new CreateIncidentRoleAssignmentRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                IncidentRoleAssignment = new IncidentRoleAssignment(),
            };
            // Make the request
            IncidentRoleAssignment response = await incidentServiceClient.CreateIncidentRoleAssignmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateIncidentRoleAssignment</summary>
        public void CreateIncidentRoleAssignment_RequestObject()
        {
            // Snippet: CreateIncidentRoleAssignment(CreateIncidentRoleAssignmentRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            CreateIncidentRoleAssignmentRequest request = new CreateIncidentRoleAssignmentRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
                IncidentRoleAssignment = new IncidentRoleAssignment(),
            };
            // Make the request
            IncidentRoleAssignment response = incidentServiceClient.CreateIncidentRoleAssignment(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteIncidentRoleAssignmentAsync</summary>
        public async Task DeleteIncidentRoleAssignmentAsync()
        {
            // Snippet: DeleteIncidentRoleAssignmentAsync(RoleAssignmentName,CallSettings)
            // Additional: DeleteIncidentRoleAssignmentAsync(RoleAssignmentName,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            RoleAssignmentName name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]");
            // Make the request
            await incidentServiceClient.DeleteIncidentRoleAssignmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteIncidentRoleAssignment</summary>
        public void DeleteIncidentRoleAssignment()
        {
            // Snippet: DeleteIncidentRoleAssignment(RoleAssignmentName,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            RoleAssignmentName name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]");
            // Make the request
            incidentServiceClient.DeleteIncidentRoleAssignment(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteIncidentRoleAssignmentAsync</summary>
        public async Task DeleteIncidentRoleAssignmentAsync_RequestObject()
        {
            // Snippet: DeleteIncidentRoleAssignmentAsync(DeleteIncidentRoleAssignmentRequest,CallSettings)
            // Additional: DeleteIncidentRoleAssignmentAsync(DeleteIncidentRoleAssignmentRequest,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteIncidentRoleAssignmentRequest request = new DeleteIncidentRoleAssignmentRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
            };
            // Make the request
            await incidentServiceClient.DeleteIncidentRoleAssignmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteIncidentRoleAssignment</summary>
        public void DeleteIncidentRoleAssignment_RequestObject()
        {
            // Snippet: DeleteIncidentRoleAssignment(DeleteIncidentRoleAssignmentRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            DeleteIncidentRoleAssignmentRequest request = new DeleteIncidentRoleAssignmentRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
            };
            // Make the request
            incidentServiceClient.DeleteIncidentRoleAssignment(request);
            // End snippet
        }

        /// <summary>Snippet for ListIncidentRoleAssignmentsAsync</summary>
        public async Task ListIncidentRoleAssignmentsAsync()
        {
            // Snippet: ListIncidentRoleAssignmentsAsync(IncidentName,string,int?,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            // Make the request
            PagedAsyncEnumerable<ListIncidentRoleAssignmentsResponse, IncidentRoleAssignment> response =
                incidentServiceClient.ListIncidentRoleAssignmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((IncidentRoleAssignment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIncidentRoleAssignmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IncidentRoleAssignment item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IncidentRoleAssignment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IncidentRoleAssignment item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIncidentRoleAssignments</summary>
        public void ListIncidentRoleAssignments()
        {
            // Snippet: ListIncidentRoleAssignments(IncidentName,string,int?,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            IncidentName parent = new IncidentName("[PROJECT]", "[INCIDENT]");
            // Make the request
            PagedEnumerable<ListIncidentRoleAssignmentsResponse, IncidentRoleAssignment> response =
                incidentServiceClient.ListIncidentRoleAssignments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (IncidentRoleAssignment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIncidentRoleAssignmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IncidentRoleAssignment item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IncidentRoleAssignment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IncidentRoleAssignment item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIncidentRoleAssignmentsAsync</summary>
        public async Task ListIncidentRoleAssignmentsAsync_RequestObject()
        {
            // Snippet: ListIncidentRoleAssignmentsAsync(ListIncidentRoleAssignmentsRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListIncidentRoleAssignmentsRequest request = new ListIncidentRoleAssignmentsRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListIncidentRoleAssignmentsResponse, IncidentRoleAssignment> response =
                incidentServiceClient.ListIncidentRoleAssignmentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((IncidentRoleAssignment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIncidentRoleAssignmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IncidentRoleAssignment item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IncidentRoleAssignment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IncidentRoleAssignment item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIncidentRoleAssignments</summary>
        public void ListIncidentRoleAssignments_RequestObject()
        {
            // Snippet: ListIncidentRoleAssignments(ListIncidentRoleAssignmentsRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            ListIncidentRoleAssignmentsRequest request = new ListIncidentRoleAssignmentsRequest
            {
                ParentAsIncidentName = new IncidentName("[PROJECT]", "[INCIDENT]"),
            };
            // Make the request
            PagedEnumerable<ListIncidentRoleAssignmentsResponse, IncidentRoleAssignment> response =
                incidentServiceClient.ListIncidentRoleAssignments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (IncidentRoleAssignment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIncidentRoleAssignmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IncidentRoleAssignment item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IncidentRoleAssignment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IncidentRoleAssignment item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for RequestIncidentRoleHandoverAsync</summary>
        public async Task RequestIncidentRoleHandoverAsync()
        {
            // Snippet: RequestIncidentRoleHandoverAsync(RoleAssignmentName,User,CallSettings)
            // Additional: RequestIncidentRoleHandoverAsync(RoleAssignmentName,User,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            RoleAssignmentName name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]");
            User newAssignee = new User();
            // Make the request
            IncidentRoleAssignment response = await incidentServiceClient.RequestIncidentRoleHandoverAsync(name, newAssignee);
            // End snippet
        }

        /// <summary>Snippet for RequestIncidentRoleHandover</summary>
        public void RequestIncidentRoleHandover()
        {
            // Snippet: RequestIncidentRoleHandover(RoleAssignmentName,User,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            RoleAssignmentName name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]");
            User newAssignee = new User();
            // Make the request
            IncidentRoleAssignment response = incidentServiceClient.RequestIncidentRoleHandover(name, newAssignee);
            // End snippet
        }

        /// <summary>Snippet for RequestIncidentRoleHandoverAsync</summary>
        public async Task RequestIncidentRoleHandoverAsync_RequestObject()
        {
            // Snippet: RequestIncidentRoleHandoverAsync(RequestIncidentRoleHandoverRequest,CallSettings)
            // Additional: RequestIncidentRoleHandoverAsync(RequestIncidentRoleHandoverRequest,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            RequestIncidentRoleHandoverRequest request = new RequestIncidentRoleHandoverRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                NewAssignee = new User(),
            };
            // Make the request
            IncidentRoleAssignment response = await incidentServiceClient.RequestIncidentRoleHandoverAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RequestIncidentRoleHandover</summary>
        public void RequestIncidentRoleHandover_RequestObject()
        {
            // Snippet: RequestIncidentRoleHandover(RequestIncidentRoleHandoverRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            RequestIncidentRoleHandoverRequest request = new RequestIncidentRoleHandoverRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                NewAssignee = new User(),
            };
            // Make the request
            IncidentRoleAssignment response = incidentServiceClient.RequestIncidentRoleHandover(request);
            // End snippet
        }

        /// <summary>Snippet for ConfirmIncidentRoleHandoverAsync</summary>
        public async Task ConfirmIncidentRoleHandoverAsync()
        {
            // Snippet: ConfirmIncidentRoleHandoverAsync(RoleAssignmentName,User,CallSettings)
            // Additional: ConfirmIncidentRoleHandoverAsync(RoleAssignmentName,User,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            RoleAssignmentName name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]");
            User newAssignee = new User();
            // Make the request
            IncidentRoleAssignment response = await incidentServiceClient.ConfirmIncidentRoleHandoverAsync(name, newAssignee);
            // End snippet
        }

        /// <summary>Snippet for ConfirmIncidentRoleHandover</summary>
        public void ConfirmIncidentRoleHandover()
        {
            // Snippet: ConfirmIncidentRoleHandover(RoleAssignmentName,User,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            RoleAssignmentName name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]");
            User newAssignee = new User();
            // Make the request
            IncidentRoleAssignment response = incidentServiceClient.ConfirmIncidentRoleHandover(name, newAssignee);
            // End snippet
        }

        /// <summary>Snippet for ConfirmIncidentRoleHandoverAsync</summary>
        public async Task ConfirmIncidentRoleHandoverAsync_RequestObject()
        {
            // Snippet: ConfirmIncidentRoleHandoverAsync(ConfirmIncidentRoleHandoverRequest,CallSettings)
            // Additional: ConfirmIncidentRoleHandoverAsync(ConfirmIncidentRoleHandoverRequest,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConfirmIncidentRoleHandoverRequest request = new ConfirmIncidentRoleHandoverRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                NewAssignee = new User(),
            };
            // Make the request
            IncidentRoleAssignment response = await incidentServiceClient.ConfirmIncidentRoleHandoverAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ConfirmIncidentRoleHandover</summary>
        public void ConfirmIncidentRoleHandover_RequestObject()
        {
            // Snippet: ConfirmIncidentRoleHandover(ConfirmIncidentRoleHandoverRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            ConfirmIncidentRoleHandoverRequest request = new ConfirmIncidentRoleHandoverRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                NewAssignee = new User(),
            };
            // Make the request
            IncidentRoleAssignment response = incidentServiceClient.ConfirmIncidentRoleHandover(request);
            // End snippet
        }

        /// <summary>Snippet for ForceIncidentRoleHandoverAsync</summary>
        public async Task ForceIncidentRoleHandoverAsync()
        {
            // Snippet: ForceIncidentRoleHandoverAsync(RoleAssignmentName,User,CallSettings)
            // Additional: ForceIncidentRoleHandoverAsync(RoleAssignmentName,User,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            RoleAssignmentName name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]");
            User newAssignee = new User();
            // Make the request
            IncidentRoleAssignment response = await incidentServiceClient.ForceIncidentRoleHandoverAsync(name, newAssignee);
            // End snippet
        }

        /// <summary>Snippet for ForceIncidentRoleHandover</summary>
        public void ForceIncidentRoleHandover()
        {
            // Snippet: ForceIncidentRoleHandover(RoleAssignmentName,User,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            RoleAssignmentName name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]");
            User newAssignee = new User();
            // Make the request
            IncidentRoleAssignment response = incidentServiceClient.ForceIncidentRoleHandover(name, newAssignee);
            // End snippet
        }

        /// <summary>Snippet for ForceIncidentRoleHandoverAsync</summary>
        public async Task ForceIncidentRoleHandoverAsync_RequestObject()
        {
            // Snippet: ForceIncidentRoleHandoverAsync(ForceIncidentRoleHandoverRequest,CallSettings)
            // Additional: ForceIncidentRoleHandoverAsync(ForceIncidentRoleHandoverRequest,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ForceIncidentRoleHandoverRequest request = new ForceIncidentRoleHandoverRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                NewAssignee = new User(),
            };
            // Make the request
            IncidentRoleAssignment response = await incidentServiceClient.ForceIncidentRoleHandoverAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ForceIncidentRoleHandover</summary>
        public void ForceIncidentRoleHandover_RequestObject()
        {
            // Snippet: ForceIncidentRoleHandover(ForceIncidentRoleHandoverRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            ForceIncidentRoleHandoverRequest request = new ForceIncidentRoleHandoverRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                NewAssignee = new User(),
            };
            // Make the request
            IncidentRoleAssignment response = incidentServiceClient.ForceIncidentRoleHandover(request);
            // End snippet
        }

        /// <summary>Snippet for CancelIncidentRoleHandoverAsync</summary>
        public async Task CancelIncidentRoleHandoverAsync()
        {
            // Snippet: CancelIncidentRoleHandoverAsync(RoleAssignmentName,User,CallSettings)
            // Additional: CancelIncidentRoleHandoverAsync(RoleAssignmentName,User,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            RoleAssignmentName name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]");
            User newAssignee = new User();
            // Make the request
            IncidentRoleAssignment response = await incidentServiceClient.CancelIncidentRoleHandoverAsync(name, newAssignee);
            // End snippet
        }

        /// <summary>Snippet for CancelIncidentRoleHandover</summary>
        public void CancelIncidentRoleHandover()
        {
            // Snippet: CancelIncidentRoleHandover(RoleAssignmentName,User,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            RoleAssignmentName name = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]");
            User newAssignee = new User();
            // Make the request
            IncidentRoleAssignment response = incidentServiceClient.CancelIncidentRoleHandover(name, newAssignee);
            // End snippet
        }

        /// <summary>Snippet for CancelIncidentRoleHandoverAsync</summary>
        public async Task CancelIncidentRoleHandoverAsync_RequestObject()
        {
            // Snippet: CancelIncidentRoleHandoverAsync(CancelIncidentRoleHandoverRequest,CallSettings)
            // Additional: CancelIncidentRoleHandoverAsync(CancelIncidentRoleHandoverRequest,CancellationToken)
            // Create client
            IncidentServiceClient incidentServiceClient = await IncidentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CancelIncidentRoleHandoverRequest request = new CancelIncidentRoleHandoverRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                NewAssignee = new User(),
            };
            // Make the request
            IncidentRoleAssignment response = await incidentServiceClient.CancelIncidentRoleHandoverAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelIncidentRoleHandover</summary>
        public void CancelIncidentRoleHandover_RequestObject()
        {
            // Snippet: CancelIncidentRoleHandover(CancelIncidentRoleHandoverRequest,CallSettings)
            // Create client
            IncidentServiceClient incidentServiceClient = IncidentServiceClient.Create();
            // Initialize request argument(s)
            CancelIncidentRoleHandoverRequest request = new CancelIncidentRoleHandoverRequest
            {
                RoleAssignmentName = new RoleAssignmentName("[PROJECT]", "[INCIDENT]", "[ROLE_ASSIGNMENT]"),
                NewAssignee = new User(),
            };
            // Make the request
            IncidentRoleAssignment response = incidentServiceClient.CancelIncidentRoleHandover(request);
            // End snippet
        }

    }
}
