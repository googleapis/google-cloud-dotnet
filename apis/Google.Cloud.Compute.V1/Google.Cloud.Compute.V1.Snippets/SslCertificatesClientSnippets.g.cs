// Copyright 2021 Google LLC
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

namespace Google.Cloud.Compute.V1.Snippets
{
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedSslCertificatesClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListSslCertificatesRequest, CallSettings)
            // Create client
            SslCertificatesClient sslCertificatesClient = SslCertificatesClient.Create();
            // Initialize request argument(s)
            AggregatedListSslCertificatesRequest request = new AggregatedListSslCertificatesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                IncludeAllScopes = false,
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            SslCertificateAggregatedList response = sslCertificatesClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListSslCertificatesRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListSslCertificatesRequest, CancellationToken)
            // Create client
            SslCertificatesClient sslCertificatesClient = await SslCertificatesClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListSslCertificatesRequest request = new AggregatedListSslCertificatesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                IncludeAllScopes = false,
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            SslCertificateAggregatedList response = await sslCertificatesClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            SslCertificatesClient sslCertificatesClient = SslCertificatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            SslCertificateAggregatedList response = sslCertificatesClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            SslCertificatesClient sslCertificatesClient = await SslCertificatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            SslCertificateAggregatedList response = await sslCertificatesClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteSslCertificateRequest, CallSettings)
            // Create client
            SslCertificatesClient sslCertificatesClient = SslCertificatesClient.Create();
            // Initialize request argument(s)
            DeleteSslCertificateRequest request = new DeleteSslCertificateRequest
            {
                RequestId = "",
                SslCertificate = "",
                Project = "",
            };
            // Make the request
            Operation response = sslCertificatesClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteSslCertificateRequest, CallSettings)
            // Additional: DeleteAsync(DeleteSslCertificateRequest, CancellationToken)
            // Create client
            SslCertificatesClient sslCertificatesClient = await SslCertificatesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSslCertificateRequest request = new DeleteSslCertificateRequest
            {
                RequestId = "",
                SslCertificate = "",
                Project = "",
            };
            // Make the request
            Operation response = await sslCertificatesClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            SslCertificatesClient sslCertificatesClient = SslCertificatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string sslCertificate = "";
            // Make the request
            Operation response = sslCertificatesClient.Delete(project, sslCertificate);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            SslCertificatesClient sslCertificatesClient = await SslCertificatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string sslCertificate = "";
            // Make the request
            Operation response = await sslCertificatesClient.DeleteAsync(project, sslCertificate);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetSslCertificateRequest, CallSettings)
            // Create client
            SslCertificatesClient sslCertificatesClient = SslCertificatesClient.Create();
            // Initialize request argument(s)
            GetSslCertificateRequest request = new GetSslCertificateRequest
            {
                SslCertificate = "",
                Project = "",
            };
            // Make the request
            SslCertificate response = sslCertificatesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetSslCertificateRequest, CallSettings)
            // Additional: GetAsync(GetSslCertificateRequest, CancellationToken)
            // Create client
            SslCertificatesClient sslCertificatesClient = await SslCertificatesClient.CreateAsync();
            // Initialize request argument(s)
            GetSslCertificateRequest request = new GetSslCertificateRequest
            {
                SslCertificate = "",
                Project = "",
            };
            // Make the request
            SslCertificate response = await sslCertificatesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            SslCertificatesClient sslCertificatesClient = SslCertificatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string sslCertificate = "";
            // Make the request
            SslCertificate response = sslCertificatesClient.Get(project, sslCertificate);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            SslCertificatesClient sslCertificatesClient = await SslCertificatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string sslCertificate = "";
            // Make the request
            SslCertificate response = await sslCertificatesClient.GetAsync(project, sslCertificate);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertSslCertificateRequest, CallSettings)
            // Create client
            SslCertificatesClient sslCertificatesClient = SslCertificatesClient.Create();
            // Initialize request argument(s)
            InsertSslCertificateRequest request = new InsertSslCertificateRequest
            {
                RequestId = "",
                SslCertificateResource = new SslCertificate(),
                Project = "",
            };
            // Make the request
            Operation response = sslCertificatesClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertSslCertificateRequest, CallSettings)
            // Additional: InsertAsync(InsertSslCertificateRequest, CancellationToken)
            // Create client
            SslCertificatesClient sslCertificatesClient = await SslCertificatesClient.CreateAsync();
            // Initialize request argument(s)
            InsertSslCertificateRequest request = new InsertSslCertificateRequest
            {
                RequestId = "",
                SslCertificateResource = new SslCertificate(),
                Project = "",
            };
            // Make the request
            Operation response = await sslCertificatesClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, SslCertificate, CallSettings)
            // Create client
            SslCertificatesClient sslCertificatesClient = SslCertificatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            SslCertificate sslCertificateResource = new SslCertificate();
            // Make the request
            Operation response = sslCertificatesClient.Insert(project, sslCertificateResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, SslCertificate, CallSettings)
            // Additional: InsertAsync(string, SslCertificate, CancellationToken)
            // Create client
            SslCertificatesClient sslCertificatesClient = await SslCertificatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            SslCertificate sslCertificateResource = new SslCertificate();
            // Make the request
            Operation response = await sslCertificatesClient.InsertAsync(project, sslCertificateResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListSslCertificatesRequest, CallSettings)
            // Create client
            SslCertificatesClient sslCertificatesClient = SslCertificatesClient.Create();
            // Initialize request argument(s)
            ListSslCertificatesRequest request = new ListSslCertificatesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            SslCertificateList response = sslCertificatesClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListSslCertificatesRequest, CallSettings)
            // Additional: ListAsync(ListSslCertificatesRequest, CancellationToken)
            // Create client
            SslCertificatesClient sslCertificatesClient = await SslCertificatesClient.CreateAsync();
            // Initialize request argument(s)
            ListSslCertificatesRequest request = new ListSslCertificatesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            SslCertificateList response = await sslCertificatesClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, CallSettings)
            // Create client
            SslCertificatesClient sslCertificatesClient = SslCertificatesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            SslCertificateList response = sslCertificatesClient.List(project);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, CallSettings)
            // Additional: ListAsync(string, CancellationToken)
            // Create client
            SslCertificatesClient sslCertificatesClient = await SslCertificatesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            SslCertificateList response = await sslCertificatesClient.ListAsync(project);
            // End snippet
        }
    }
}
