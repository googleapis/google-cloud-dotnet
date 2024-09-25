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
    using Google.Shopping.Merchant.DataSources.V1Beta;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedFileUploadsServiceClientSnippets
    {
        /// <summary>Snippet for GetFileUpload</summary>
        public void GetFileUploadRequestObject()
        {
            // Snippet: GetFileUpload(GetFileUploadRequest, CallSettings)
            // Create client
            FileUploadsServiceClient fileUploadsServiceClient = FileUploadsServiceClient.Create();
            // Initialize request argument(s)
            GetFileUploadRequest request = new GetFileUploadRequest
            {
                FileUploadName = FileUploadName.FromAccountDatasourceFileupload("[ACCOUNT]", "[DATASOURCE]", "[FILEUPLOAD]"),
            };
            // Make the request
            FileUpload response = fileUploadsServiceClient.GetFileUpload(request);
            // End snippet
        }

        /// <summary>Snippet for GetFileUploadAsync</summary>
        public async Task GetFileUploadRequestObjectAsync()
        {
            // Snippet: GetFileUploadAsync(GetFileUploadRequest, CallSettings)
            // Additional: GetFileUploadAsync(GetFileUploadRequest, CancellationToken)
            // Create client
            FileUploadsServiceClient fileUploadsServiceClient = await FileUploadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFileUploadRequest request = new GetFileUploadRequest
            {
                FileUploadName = FileUploadName.FromAccountDatasourceFileupload("[ACCOUNT]", "[DATASOURCE]", "[FILEUPLOAD]"),
            };
            // Make the request
            FileUpload response = await fileUploadsServiceClient.GetFileUploadAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFileUpload</summary>
        public void GetFileUpload()
        {
            // Snippet: GetFileUpload(string, CallSettings)
            // Create client
            FileUploadsServiceClient fileUploadsServiceClient = FileUploadsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/dataSources/[DATASOURCE]/fileUploads/[FILEUPLOAD]";
            // Make the request
            FileUpload response = fileUploadsServiceClient.GetFileUpload(name);
            // End snippet
        }

        /// <summary>Snippet for GetFileUploadAsync</summary>
        public async Task GetFileUploadAsync()
        {
            // Snippet: GetFileUploadAsync(string, CallSettings)
            // Additional: GetFileUploadAsync(string, CancellationToken)
            // Create client
            FileUploadsServiceClient fileUploadsServiceClient = await FileUploadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/dataSources/[DATASOURCE]/fileUploads/[FILEUPLOAD]";
            // Make the request
            FileUpload response = await fileUploadsServiceClient.GetFileUploadAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFileUpload</summary>
        public void GetFileUploadResourceNames()
        {
            // Snippet: GetFileUpload(FileUploadName, CallSettings)
            // Create client
            FileUploadsServiceClient fileUploadsServiceClient = FileUploadsServiceClient.Create();
            // Initialize request argument(s)
            FileUploadName name = FileUploadName.FromAccountDatasourceFileupload("[ACCOUNT]", "[DATASOURCE]", "[FILEUPLOAD]");
            // Make the request
            FileUpload response = fileUploadsServiceClient.GetFileUpload(name);
            // End snippet
        }

        /// <summary>Snippet for GetFileUploadAsync</summary>
        public async Task GetFileUploadResourceNamesAsync()
        {
            // Snippet: GetFileUploadAsync(FileUploadName, CallSettings)
            // Additional: GetFileUploadAsync(FileUploadName, CancellationToken)
            // Create client
            FileUploadsServiceClient fileUploadsServiceClient = await FileUploadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            FileUploadName name = FileUploadName.FromAccountDatasourceFileupload("[ACCOUNT]", "[DATASOURCE]", "[FILEUPLOAD]");
            // Make the request
            FileUpload response = await fileUploadsServiceClient.GetFileUploadAsync(name);
            // End snippet
        }
    }
}
