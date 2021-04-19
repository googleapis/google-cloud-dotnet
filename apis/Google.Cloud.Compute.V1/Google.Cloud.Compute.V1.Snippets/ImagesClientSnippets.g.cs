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
    public sealed class GeneratedImagesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteImageRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            DeleteImageRequest request = new DeleteImageRequest
            {
                RequestId = "",
                Image = "",
                Project = "",
            };
            // Make the request
            Operation response = imagesClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteImageRequest, CallSettings)
            // Additional: DeleteAsync(DeleteImageRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteImageRequest request = new DeleteImageRequest
            {
                RequestId = "",
                Image = "",
                Project = "",
            };
            // Make the request
            Operation response = await imagesClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string image = "";
            // Make the request
            Operation response = imagesClient.Delete(project, image);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string image = "";
            // Make the request
            Operation response = await imagesClient.DeleteAsync(project, image);
            // End snippet
        }

        /// <summary>Snippet for Deprecate</summary>
        public void DeprecateRequestObject()
        {
            // Snippet: Deprecate(DeprecateImageRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            DeprecateImageRequest request = new DeprecateImageRequest
            {
                RequestId = "",
                DeprecationStatusResource = new DeprecationStatus(),
                Image = "",
                Project = "",
            };
            // Make the request
            Operation response = imagesClient.Deprecate(request);
            // End snippet
        }

        /// <summary>Snippet for DeprecateAsync</summary>
        public async Task DeprecateRequestObjectAsync()
        {
            // Snippet: DeprecateAsync(DeprecateImageRequest, CallSettings)
            // Additional: DeprecateAsync(DeprecateImageRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            DeprecateImageRequest request = new DeprecateImageRequest
            {
                RequestId = "",
                DeprecationStatusResource = new DeprecationStatus(),
                Image = "",
                Project = "",
            };
            // Make the request
            Operation response = await imagesClient.DeprecateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Deprecate</summary>
        public void Deprecate()
        {
            // Snippet: Deprecate(string, string, DeprecationStatus, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string image = "";
            DeprecationStatus deprecationStatusResource = new DeprecationStatus();
            // Make the request
            Operation response = imagesClient.Deprecate(project, image, deprecationStatusResource);
            // End snippet
        }

        /// <summary>Snippet for DeprecateAsync</summary>
        public async Task DeprecateAsync()
        {
            // Snippet: DeprecateAsync(string, string, DeprecationStatus, CallSettings)
            // Additional: DeprecateAsync(string, string, DeprecationStatus, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string image = "";
            DeprecationStatus deprecationStatusResource = new DeprecationStatus();
            // Make the request
            Operation response = await imagesClient.DeprecateAsync(project, image, deprecationStatusResource);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetImageRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            GetImageRequest request = new GetImageRequest
            {
                Image = "",
                Project = "",
            };
            // Make the request
            Image response = imagesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetImageRequest, CallSettings)
            // Additional: GetAsync(GetImageRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            GetImageRequest request = new GetImageRequest
            {
                Image = "",
                Project = "",
            };
            // Make the request
            Image response = await imagesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string image = "";
            // Make the request
            Image response = imagesClient.Get(project, image);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string image = "";
            // Make the request
            Image response = await imagesClient.GetAsync(project, image);
            // End snippet
        }

        /// <summary>Snippet for GetFromFamily</summary>
        public void GetFromFamilyRequestObject()
        {
            // Snippet: GetFromFamily(GetFromFamilyImageRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            GetFromFamilyImageRequest request = new GetFromFamilyImageRequest
            {
                Family = "",
                Project = "",
            };
            // Make the request
            Image response = imagesClient.GetFromFamily(request);
            // End snippet
        }

        /// <summary>Snippet for GetFromFamilyAsync</summary>
        public async Task GetFromFamilyRequestObjectAsync()
        {
            // Snippet: GetFromFamilyAsync(GetFromFamilyImageRequest, CallSettings)
            // Additional: GetFromFamilyAsync(GetFromFamilyImageRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            GetFromFamilyImageRequest request = new GetFromFamilyImageRequest
            {
                Family = "",
                Project = "",
            };
            // Make the request
            Image response = await imagesClient.GetFromFamilyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFromFamily</summary>
        public void GetFromFamily()
        {
            // Snippet: GetFromFamily(string, string, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string family = "";
            // Make the request
            Image response = imagesClient.GetFromFamily(project, family);
            // End snippet
        }

        /// <summary>Snippet for GetFromFamilyAsync</summary>
        public async Task GetFromFamilyAsync()
        {
            // Snippet: GetFromFamilyAsync(string, string, CallSettings)
            // Additional: GetFromFamilyAsync(string, string, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string family = "";
            // Make the request
            Image response = await imagesClient.GetFromFamilyAsync(project, family);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyImageRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            GetIamPolicyImageRequest request = new GetIamPolicyImageRequest
            {
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = imagesClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyImageRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyImageRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyImageRequest request = new GetIamPolicyImageRequest
            {
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await imagesClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            // Make the request
            Policy response = imagesClient.GetIamPolicy(project, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            // Make the request
            Policy response = await imagesClient.GetIamPolicyAsync(project, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertImageRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            InsertImageRequest request = new InsertImageRequest
            {
                RequestId = "",
                ImageResource = new Image(),
                ForceCreate = false,
                Project = "",
            };
            // Make the request
            Operation response = imagesClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertImageRequest, CallSettings)
            // Additional: InsertAsync(InsertImageRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            InsertImageRequest request = new InsertImageRequest
            {
                RequestId = "",
                ImageResource = new Image(),
                ForceCreate = false,
                Project = "",
            };
            // Make the request
            Operation response = await imagesClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, Image, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            Image imageResource = new Image();
            // Make the request
            Operation response = imagesClient.Insert(project, imageResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, Image, CallSettings)
            // Additional: InsertAsync(string, Image, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            Image imageResource = new Image();
            // Make the request
            Operation response = await imagesClient.InsertAsync(project, imageResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListImagesRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            ListImagesRequest request = new ListImagesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            ImageList response = imagesClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListImagesRequest, CallSettings)
            // Additional: ListAsync(ListImagesRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            ListImagesRequest request = new ListImagesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            ImageList response = await imagesClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            ImageList response = imagesClient.List(project);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, CallSettings)
            // Additional: ListAsync(string, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            ImageList response = await imagesClient.ListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchImageRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            PatchImageRequest request = new PatchImageRequest
            {
                RequestId = "",
                Image = "",
                ImageResource = new Image(),
                Project = "",
            };
            // Make the request
            Operation response = imagesClient.Patch(request);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchImageRequest, CallSettings)
            // Additional: PatchAsync(PatchImageRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            PatchImageRequest request = new PatchImageRequest
            {
                RequestId = "",
                Image = "",
                ImageResource = new Image(),
                Project = "",
            };
            // Make the request
            Operation response = await imagesClient.PatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, Image, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string image = "";
            Image imageResource = new Image();
            // Make the request
            Operation response = imagesClient.Patch(project, image, imageResource);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, Image, CallSettings)
            // Additional: PatchAsync(string, string, Image, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string image = "";
            Image imageResource = new Image();
            // Make the request
            Operation response = await imagesClient.PatchAsync(project, image, imageResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyImageRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            SetIamPolicyImageRequest request = new SetIamPolicyImageRequest
            {
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            Policy response = imagesClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyImageRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyImageRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyImageRequest request = new SetIamPolicyImageRequest
            {
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            Policy response = await imagesClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, GlobalSetPolicyRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetPolicyRequest globalSetPolicyRequestResource = new GlobalSetPolicyRequest();
            // Make the request
            Policy response = imagesClient.SetIamPolicy(project, resource, globalSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, GlobalSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, GlobalSetPolicyRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetPolicyRequest globalSetPolicyRequestResource = new GlobalSetPolicyRequest();
            // Make the request
            Policy response = await imagesClient.SetIamPolicyAsync(project, resource, globalSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabelsRequestObject()
        {
            // Snippet: SetLabels(SetLabelsImageRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            SetLabelsImageRequest request = new SetLabelsImageRequest
            {
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            Operation response = imagesClient.SetLabels(request);
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsRequestObjectAsync()
        {
            // Snippet: SetLabelsAsync(SetLabelsImageRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsImageRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsImageRequest request = new SetLabelsImageRequest
            {
                GlobalSetLabelsRequestResource = new GlobalSetLabelsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            Operation response = await imagesClient.SetLabelsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabels()
        {
            // Snippet: SetLabels(string, string, GlobalSetLabelsRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetLabelsRequest globalSetLabelsRequestResource = new GlobalSetLabelsRequest();
            // Make the request
            Operation response = imagesClient.SetLabels(project, resource, globalSetLabelsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsAsync()
        {
            // Snippet: SetLabelsAsync(string, string, GlobalSetLabelsRequest, CallSettings)
            // Additional: SetLabelsAsync(string, string, GlobalSetLabelsRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetLabelsRequest globalSetLabelsRequestResource = new GlobalSetLabelsRequest();
            // Make the request
            Operation response = await imagesClient.SetLabelsAsync(project, resource, globalSetLabelsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsImageRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsImageRequest request = new TestIamPermissionsImageRequest
            {
                TestPermissionsRequestResource = new TestPermissionsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            TestPermissionsResponse response = imagesClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsImageRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsImageRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsImageRequest request = new TestIamPermissionsImageRequest
            {
                TestPermissionsRequestResource = new TestPermissionsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            TestPermissionsResponse response = await imagesClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, TestPermissionsRequest, CallSettings)
            // Create client
            ImagesClient imagesClient = ImagesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = imagesClient.TestIamPermissions(project, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            ImagesClient imagesClient = await ImagesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await imagesClient.TestIamPermissionsAsync(project, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
