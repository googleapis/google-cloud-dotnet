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
    using Google.Cloud.Sql.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSqlSslCertsServiceClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(SqlSslCertsDeleteRequest, CallSettings)
            // Create client
            SqlSslCertsServiceClient sqlSslCertsServiceClient = SqlSslCertsServiceClient.Create();
            // Initialize request argument(s)
            SqlSslCertsDeleteRequest request = new SqlSslCertsDeleteRequest
            {
                Instance = "",
                Project = "",
                Sha1Fingerprint = "",
            };
            // Make the request
            Operation response = sqlSslCertsServiceClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(SqlSslCertsDeleteRequest, CallSettings)
            // Additional: DeleteAsync(SqlSslCertsDeleteRequest, CancellationToken)
            // Create client
            SqlSslCertsServiceClient sqlSslCertsServiceClient = await SqlSslCertsServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlSslCertsDeleteRequest request = new SqlSslCertsDeleteRequest
            {
                Instance = "",
                Project = "",
                Sha1Fingerprint = "",
            };
            // Make the request
            Operation response = await sqlSslCertsServiceClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(SqlSslCertsGetRequest, CallSettings)
            // Create client
            SqlSslCertsServiceClient sqlSslCertsServiceClient = SqlSslCertsServiceClient.Create();
            // Initialize request argument(s)
            SqlSslCertsGetRequest request = new SqlSslCertsGetRequest
            {
                Instance = "",
                Project = "",
                Sha1Fingerprint = "",
            };
            // Make the request
            SslCert response = sqlSslCertsServiceClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(SqlSslCertsGetRequest, CallSettings)
            // Additional: GetAsync(SqlSslCertsGetRequest, CancellationToken)
            // Create client
            SqlSslCertsServiceClient sqlSslCertsServiceClient = await SqlSslCertsServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlSslCertsGetRequest request = new SqlSslCertsGetRequest
            {
                Instance = "",
                Project = "",
                Sha1Fingerprint = "",
            };
            // Make the request
            SslCert response = await sqlSslCertsServiceClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(SqlSslCertsInsertRequest, CallSettings)
            // Create client
            SqlSslCertsServiceClient sqlSslCertsServiceClient = SqlSslCertsServiceClient.Create();
            // Initialize request argument(s)
            SqlSslCertsInsertRequest request = new SqlSslCertsInsertRequest
            {
                Instance = "",
                Project = "",
                Body = new SslCertsInsertRequest(),
            };
            // Make the request
            SslCertsInsertResponse response = sqlSslCertsServiceClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(SqlSslCertsInsertRequest, CallSettings)
            // Additional: InsertAsync(SqlSslCertsInsertRequest, CancellationToken)
            // Create client
            SqlSslCertsServiceClient sqlSslCertsServiceClient = await SqlSslCertsServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlSslCertsInsertRequest request = new SqlSslCertsInsertRequest
            {
                Instance = "",
                Project = "",
                Body = new SslCertsInsertRequest(),
            };
            // Make the request
            SslCertsInsertResponse response = await sqlSslCertsServiceClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(SqlSslCertsListRequest, CallSettings)
            // Create client
            SqlSslCertsServiceClient sqlSslCertsServiceClient = SqlSslCertsServiceClient.Create();
            // Initialize request argument(s)
            SqlSslCertsListRequest request = new SqlSslCertsListRequest
            {
                Instance = "",
                Project = "",
            };
            // Make the request
            SslCertsListResponse response = sqlSslCertsServiceClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(SqlSslCertsListRequest, CallSettings)
            // Additional: ListAsync(SqlSslCertsListRequest, CancellationToken)
            // Create client
            SqlSslCertsServiceClient sqlSslCertsServiceClient = await SqlSslCertsServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlSslCertsListRequest request = new SqlSslCertsListRequest
            {
                Instance = "",
                Project = "",
            };
            // Make the request
            SslCertsListResponse response = await sqlSslCertsServiceClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomerManagedCertificate</summary>
        public void UpdateCustomerManagedCertificateRequestObject()
        {
            // Snippet: UpdateCustomerManagedCertificate(UpdateCustomerManagedCertificateRequest, CallSettings)
            // Create client
            SqlSslCertsServiceClient sqlSslCertsServiceClient = SqlSslCertsServiceClient.Create();
            // Initialize request argument(s)
            UpdateCustomerManagedCertificateRequest request = new UpdateCustomerManagedCertificateRequest
            {
                Instance = "",
                Project = "",
                CustomerManagedCertificateConfig = new CustomerManagedCertificateConfig(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
                CertificateBundle = "",
            };
            // Make the request
            Operation response = sqlSslCertsServiceClient.UpdateCustomerManagedCertificate(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomerManagedCertificateAsync</summary>
        public async Task UpdateCustomerManagedCertificateRequestObjectAsync()
        {
            // Snippet: UpdateCustomerManagedCertificateAsync(UpdateCustomerManagedCertificateRequest, CallSettings)
            // Additional: UpdateCustomerManagedCertificateAsync(UpdateCustomerManagedCertificateRequest, CancellationToken)
            // Create client
            SqlSslCertsServiceClient sqlSslCertsServiceClient = await SqlSslCertsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCustomerManagedCertificateRequest request = new UpdateCustomerManagedCertificateRequest
            {
                Instance = "",
                Project = "",
                CustomerManagedCertificateConfig = new CustomerManagedCertificateConfig(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
                CertificateBundle = "",
            };
            // Make the request
            Operation response = await sqlSslCertsServiceClient.UpdateCustomerManagedCertificateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomerManagedCertificate</summary>
        public void DeleteCustomerManagedCertificateRequestObject()
        {
            // Snippet: DeleteCustomerManagedCertificate(DeleteCustomerManagedCertificateRequest, CallSettings)
            // Create client
            SqlSslCertsServiceClient sqlSslCertsServiceClient = SqlSslCertsServiceClient.Create();
            // Initialize request argument(s)
            DeleteCustomerManagedCertificateRequest request = new DeleteCustomerManagedCertificateRequest
            {
                Instance = "",
                Project = "",
                CertificateBundle = "",
            };
            // Make the request
            Operation response = sqlSslCertsServiceClient.DeleteCustomerManagedCertificate(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomerManagedCertificateAsync</summary>
        public async Task DeleteCustomerManagedCertificateRequestObjectAsync()
        {
            // Snippet: DeleteCustomerManagedCertificateAsync(DeleteCustomerManagedCertificateRequest, CallSettings)
            // Additional: DeleteCustomerManagedCertificateAsync(DeleteCustomerManagedCertificateRequest, CancellationToken)
            // Create client
            SqlSslCertsServiceClient sqlSslCertsServiceClient = await SqlSslCertsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCustomerManagedCertificateRequest request = new DeleteCustomerManagedCertificateRequest
            {
                Instance = "",
                Project = "",
                CertificateBundle = "",
            };
            // Make the request
            Operation response = await sqlSslCertsServiceClient.DeleteCustomerManagedCertificateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListCustomerManagedCertificates</summary>
        public void ListCustomerManagedCertificatesRequestObject()
        {
            // Snippet: ListCustomerManagedCertificates(ListCustomerManagedCertificatesRequest, CallSettings)
            // Create client
            SqlSslCertsServiceClient sqlSslCertsServiceClient = SqlSslCertsServiceClient.Create();
            // Initialize request argument(s)
            ListCustomerManagedCertificatesRequest request = new ListCustomerManagedCertificatesRequest
            {
                Instance = "",
                Project = "",
            };
            // Make the request
            ListCustomerManagedCertificatesResponse response = sqlSslCertsServiceClient.ListCustomerManagedCertificates(request);
            // End snippet
        }

        /// <summary>Snippet for ListCustomerManagedCertificatesAsync</summary>
        public async Task ListCustomerManagedCertificatesRequestObjectAsync()
        {
            // Snippet: ListCustomerManagedCertificatesAsync(ListCustomerManagedCertificatesRequest, CallSettings)
            // Additional: ListCustomerManagedCertificatesAsync(ListCustomerManagedCertificatesRequest, CancellationToken)
            // Create client
            SqlSslCertsServiceClient sqlSslCertsServiceClient = await SqlSslCertsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCustomerManagedCertificatesRequest request = new ListCustomerManagedCertificatesRequest
            {
                Instance = "",
                Project = "",
            };
            // Make the request
            ListCustomerManagedCertificatesResponse response = await sqlSslCertsServiceClient.ListCustomerManagedCertificatesAsync(request);
            // End snippet
        }
    }
}
