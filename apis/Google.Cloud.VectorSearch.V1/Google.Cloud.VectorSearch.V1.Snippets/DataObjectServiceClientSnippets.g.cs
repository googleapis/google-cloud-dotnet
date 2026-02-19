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
    using Google.Cloud.VectorSearch.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDataObjectServiceClientSnippets
    {
        /// <summary>Snippet for CreateDataObject</summary>
        public void CreateDataObjectRequestObject()
        {
            // Snippet: CreateDataObject(CreateDataObjectRequest, CallSettings)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = DataObjectServiceClient.Create();
            // Initialize request argument(s)
            CreateDataObjectRequest request = new CreateDataObjectRequest
            {
                ParentAsCollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                DataObjectId = "",
                DataObject = new DataObject(),
            };
            // Make the request
            DataObject response = dataObjectServiceClient.CreateDataObject(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataObjectAsync</summary>
        public async Task CreateDataObjectRequestObjectAsync()
        {
            // Snippet: CreateDataObjectAsync(CreateDataObjectRequest, CallSettings)
            // Additional: CreateDataObjectAsync(CreateDataObjectRequest, CancellationToken)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = await DataObjectServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDataObjectRequest request = new CreateDataObjectRequest
            {
                ParentAsCollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                DataObjectId = "",
                DataObject = new DataObject(),
            };
            // Make the request
            DataObject response = await dataObjectServiceClient.CreateDataObjectAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataObject</summary>
        public void CreateDataObject()
        {
            // Snippet: CreateDataObject(string, DataObject, string, CallSettings)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = DataObjectServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]";
            DataObject dataObject = new DataObject();
            string dataObjectId = "";
            // Make the request
            DataObject response = dataObjectServiceClient.CreateDataObject(parent, dataObject, dataObjectId);
            // End snippet
        }

        /// <summary>Snippet for CreateDataObjectAsync</summary>
        public async Task CreateDataObjectAsync()
        {
            // Snippet: CreateDataObjectAsync(string, DataObject, string, CallSettings)
            // Additional: CreateDataObjectAsync(string, DataObject, string, CancellationToken)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = await DataObjectServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]";
            DataObject dataObject = new DataObject();
            string dataObjectId = "";
            // Make the request
            DataObject response = await dataObjectServiceClient.CreateDataObjectAsync(parent, dataObject, dataObjectId);
            // End snippet
        }

        /// <summary>Snippet for CreateDataObject</summary>
        public void CreateDataObjectResourceNames()
        {
            // Snippet: CreateDataObject(CollectionName, DataObject, string, CallSettings)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = DataObjectServiceClient.Create();
            // Initialize request argument(s)
            CollectionName parent = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            DataObject dataObject = new DataObject();
            string dataObjectId = "";
            // Make the request
            DataObject response = dataObjectServiceClient.CreateDataObject(parent, dataObject, dataObjectId);
            // End snippet
        }

        /// <summary>Snippet for CreateDataObjectAsync</summary>
        public async Task CreateDataObjectResourceNamesAsync()
        {
            // Snippet: CreateDataObjectAsync(CollectionName, DataObject, string, CallSettings)
            // Additional: CreateDataObjectAsync(CollectionName, DataObject, string, CancellationToken)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = await DataObjectServiceClient.CreateAsync();
            // Initialize request argument(s)
            CollectionName parent = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            DataObject dataObject = new DataObject();
            string dataObjectId = "";
            // Make the request
            DataObject response = await dataObjectServiceClient.CreateDataObjectAsync(parent, dataObject, dataObjectId);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateDataObjects</summary>
        public void BatchCreateDataObjectsRequestObject()
        {
            // Snippet: BatchCreateDataObjects(BatchCreateDataObjectsRequest, CallSettings)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = DataObjectServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateDataObjectsRequest request = new BatchCreateDataObjectsRequest
            {
                ParentAsCollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                Requests =
                {
                    new CreateDataObjectRequest(),
                },
            };
            // Make the request
            BatchCreateDataObjectsResponse response = dataObjectServiceClient.BatchCreateDataObjects(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateDataObjectsAsync</summary>
        public async Task BatchCreateDataObjectsRequestObjectAsync()
        {
            // Snippet: BatchCreateDataObjectsAsync(BatchCreateDataObjectsRequest, CallSettings)
            // Additional: BatchCreateDataObjectsAsync(BatchCreateDataObjectsRequest, CancellationToken)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = await DataObjectServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateDataObjectsRequest request = new BatchCreateDataObjectsRequest
            {
                ParentAsCollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                Requests =
                {
                    new CreateDataObjectRequest(),
                },
            };
            // Make the request
            BatchCreateDataObjectsResponse response = await dataObjectServiceClient.BatchCreateDataObjectsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataObject</summary>
        public void GetDataObjectRequestObject()
        {
            // Snippet: GetDataObject(GetDataObjectRequest, CallSettings)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = DataObjectServiceClient.Create();
            // Initialize request argument(s)
            GetDataObjectRequest request = new GetDataObjectRequest
            {
                DataObjectName = DataObjectName.FromProjectLocationCollectionDataObject("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[DATAOBJECT]"),
            };
            // Make the request
            DataObject response = dataObjectServiceClient.GetDataObject(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataObjectAsync</summary>
        public async Task GetDataObjectRequestObjectAsync()
        {
            // Snippet: GetDataObjectAsync(GetDataObjectRequest, CallSettings)
            // Additional: GetDataObjectAsync(GetDataObjectRequest, CancellationToken)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = await DataObjectServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDataObjectRequest request = new GetDataObjectRequest
            {
                DataObjectName = DataObjectName.FromProjectLocationCollectionDataObject("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[DATAOBJECT]"),
            };
            // Make the request
            DataObject response = await dataObjectServiceClient.GetDataObjectAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataObject</summary>
        public void GetDataObject()
        {
            // Snippet: GetDataObject(string, CallSettings)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = DataObjectServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/dataObjects/[DATAOBJECT]";
            // Make the request
            DataObject response = dataObjectServiceClient.GetDataObject(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataObjectAsync</summary>
        public async Task GetDataObjectAsync()
        {
            // Snippet: GetDataObjectAsync(string, CallSettings)
            // Additional: GetDataObjectAsync(string, CancellationToken)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = await DataObjectServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/dataObjects/[DATAOBJECT]";
            // Make the request
            DataObject response = await dataObjectServiceClient.GetDataObjectAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataObject</summary>
        public void GetDataObjectResourceNames()
        {
            // Snippet: GetDataObject(DataObjectName, CallSettings)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = DataObjectServiceClient.Create();
            // Initialize request argument(s)
            DataObjectName name = DataObjectName.FromProjectLocationCollectionDataObject("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[DATAOBJECT]");
            // Make the request
            DataObject response = dataObjectServiceClient.GetDataObject(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataObjectAsync</summary>
        public async Task GetDataObjectResourceNamesAsync()
        {
            // Snippet: GetDataObjectAsync(DataObjectName, CallSettings)
            // Additional: GetDataObjectAsync(DataObjectName, CancellationToken)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = await DataObjectServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataObjectName name = DataObjectName.FromProjectLocationCollectionDataObject("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[DATAOBJECT]");
            // Make the request
            DataObject response = await dataObjectServiceClient.GetDataObjectAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataObject</summary>
        public void UpdateDataObjectRequestObject()
        {
            // Snippet: UpdateDataObject(UpdateDataObjectRequest, CallSettings)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = DataObjectServiceClient.Create();
            // Initialize request argument(s)
            UpdateDataObjectRequest request = new UpdateDataObjectRequest
            {
                DataObject = new DataObject(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DataObject response = dataObjectServiceClient.UpdateDataObject(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataObjectAsync</summary>
        public async Task UpdateDataObjectRequestObjectAsync()
        {
            // Snippet: UpdateDataObjectAsync(UpdateDataObjectRequest, CallSettings)
            // Additional: UpdateDataObjectAsync(UpdateDataObjectRequest, CancellationToken)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = await DataObjectServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDataObjectRequest request = new UpdateDataObjectRequest
            {
                DataObject = new DataObject(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DataObject response = await dataObjectServiceClient.UpdateDataObjectAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataObject</summary>
        public void UpdateDataObject()
        {
            // Snippet: UpdateDataObject(DataObject, FieldMask, CallSettings)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = DataObjectServiceClient.Create();
            // Initialize request argument(s)
            DataObject dataObject = new DataObject();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataObject response = dataObjectServiceClient.UpdateDataObject(dataObject, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataObjectAsync</summary>
        public async Task UpdateDataObjectAsync()
        {
            // Snippet: UpdateDataObjectAsync(DataObject, FieldMask, CallSettings)
            // Additional: UpdateDataObjectAsync(DataObject, FieldMask, CancellationToken)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = await DataObjectServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataObject dataObject = new DataObject();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataObject response = await dataObjectServiceClient.UpdateDataObjectAsync(dataObject, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateDataObjects</summary>
        public void BatchUpdateDataObjectsRequestObject()
        {
            // Snippet: BatchUpdateDataObjects(BatchUpdateDataObjectsRequest, CallSettings)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = DataObjectServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateDataObjectsRequest request = new BatchUpdateDataObjectsRequest
            {
                ParentAsCollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                Requests =
                {
                    new UpdateDataObjectRequest(),
                },
            };
            // Make the request
            BatchUpdateDataObjectsResponse response = dataObjectServiceClient.BatchUpdateDataObjects(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateDataObjectsAsync</summary>
        public async Task BatchUpdateDataObjectsRequestObjectAsync()
        {
            // Snippet: BatchUpdateDataObjectsAsync(BatchUpdateDataObjectsRequest, CallSettings)
            // Additional: BatchUpdateDataObjectsAsync(BatchUpdateDataObjectsRequest, CancellationToken)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = await DataObjectServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateDataObjectsRequest request = new BatchUpdateDataObjectsRequest
            {
                ParentAsCollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                Requests =
                {
                    new UpdateDataObjectRequest(),
                },
            };
            // Make the request
            BatchUpdateDataObjectsResponse response = await dataObjectServiceClient.BatchUpdateDataObjectsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateDataObjects</summary>
        public void BatchUpdateDataObjects()
        {
            // Snippet: BatchUpdateDataObjects(string, IEnumerable<UpdateDataObjectRequest>, CallSettings)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = DataObjectServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]";
            IEnumerable<UpdateDataObjectRequest> requests = new UpdateDataObjectRequest[]
            {
                new UpdateDataObjectRequest(),
            };
            // Make the request
            BatchUpdateDataObjectsResponse response = dataObjectServiceClient.BatchUpdateDataObjects(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateDataObjectsAsync</summary>
        public async Task BatchUpdateDataObjectsAsync()
        {
            // Snippet: BatchUpdateDataObjectsAsync(string, IEnumerable<UpdateDataObjectRequest>, CallSettings)
            // Additional: BatchUpdateDataObjectsAsync(string, IEnumerable<UpdateDataObjectRequest>, CancellationToken)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = await DataObjectServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]";
            IEnumerable<UpdateDataObjectRequest> requests = new UpdateDataObjectRequest[]
            {
                new UpdateDataObjectRequest(),
            };
            // Make the request
            BatchUpdateDataObjectsResponse response = await dataObjectServiceClient.BatchUpdateDataObjectsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateDataObjects</summary>
        public void BatchUpdateDataObjectsResourceNames()
        {
            // Snippet: BatchUpdateDataObjects(CollectionName, IEnumerable<UpdateDataObjectRequest>, CallSettings)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = DataObjectServiceClient.Create();
            // Initialize request argument(s)
            CollectionName parent = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            IEnumerable<UpdateDataObjectRequest> requests = new UpdateDataObjectRequest[]
            {
                new UpdateDataObjectRequest(),
            };
            // Make the request
            BatchUpdateDataObjectsResponse response = dataObjectServiceClient.BatchUpdateDataObjects(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateDataObjectsAsync</summary>
        public async Task BatchUpdateDataObjectsResourceNamesAsync()
        {
            // Snippet: BatchUpdateDataObjectsAsync(CollectionName, IEnumerable<UpdateDataObjectRequest>, CallSettings)
            // Additional: BatchUpdateDataObjectsAsync(CollectionName, IEnumerable<UpdateDataObjectRequest>, CancellationToken)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = await DataObjectServiceClient.CreateAsync();
            // Initialize request argument(s)
            CollectionName parent = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            IEnumerable<UpdateDataObjectRequest> requests = new UpdateDataObjectRequest[]
            {
                new UpdateDataObjectRequest(),
            };
            // Make the request
            BatchUpdateDataObjectsResponse response = await dataObjectServiceClient.BatchUpdateDataObjectsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataObject</summary>
        public void DeleteDataObjectRequestObject()
        {
            // Snippet: DeleteDataObject(DeleteDataObjectRequest, CallSettings)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = DataObjectServiceClient.Create();
            // Initialize request argument(s)
            DeleteDataObjectRequest request = new DeleteDataObjectRequest
            {
                DataObjectName = DataObjectName.FromProjectLocationCollectionDataObject("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[DATAOBJECT]"),
                Etag = "",
            };
            // Make the request
            dataObjectServiceClient.DeleteDataObject(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataObjectAsync</summary>
        public async Task DeleteDataObjectRequestObjectAsync()
        {
            // Snippet: DeleteDataObjectAsync(DeleteDataObjectRequest, CallSettings)
            // Additional: DeleteDataObjectAsync(DeleteDataObjectRequest, CancellationToken)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = await DataObjectServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDataObjectRequest request = new DeleteDataObjectRequest
            {
                DataObjectName = DataObjectName.FromProjectLocationCollectionDataObject("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[DATAOBJECT]"),
                Etag = "",
            };
            // Make the request
            await dataObjectServiceClient.DeleteDataObjectAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataObject</summary>
        public void DeleteDataObject()
        {
            // Snippet: DeleteDataObject(string, CallSettings)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = DataObjectServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/dataObjects/[DATAOBJECT]";
            // Make the request
            dataObjectServiceClient.DeleteDataObject(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataObjectAsync</summary>
        public async Task DeleteDataObjectAsync()
        {
            // Snippet: DeleteDataObjectAsync(string, CallSettings)
            // Additional: DeleteDataObjectAsync(string, CancellationToken)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = await DataObjectServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/dataObjects/[DATAOBJECT]";
            // Make the request
            await dataObjectServiceClient.DeleteDataObjectAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataObject</summary>
        public void DeleteDataObjectResourceNames()
        {
            // Snippet: DeleteDataObject(DataObjectName, CallSettings)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = DataObjectServiceClient.Create();
            // Initialize request argument(s)
            DataObjectName name = DataObjectName.FromProjectLocationCollectionDataObject("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[DATAOBJECT]");
            // Make the request
            dataObjectServiceClient.DeleteDataObject(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataObjectAsync</summary>
        public async Task DeleteDataObjectResourceNamesAsync()
        {
            // Snippet: DeleteDataObjectAsync(DataObjectName, CallSettings)
            // Additional: DeleteDataObjectAsync(DataObjectName, CancellationToken)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = await DataObjectServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataObjectName name = DataObjectName.FromProjectLocationCollectionDataObject("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[DATAOBJECT]");
            // Make the request
            await dataObjectServiceClient.DeleteDataObjectAsync(name);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteDataObjects</summary>
        public void BatchDeleteDataObjectsRequestObject()
        {
            // Snippet: BatchDeleteDataObjects(BatchDeleteDataObjectsRequest, CallSettings)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = DataObjectServiceClient.Create();
            // Initialize request argument(s)
            BatchDeleteDataObjectsRequest request = new BatchDeleteDataObjectsRequest
            {
                ParentAsCollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                Requests =
                {
                    new DeleteDataObjectRequest(),
                },
            };
            // Make the request
            dataObjectServiceClient.BatchDeleteDataObjects(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteDataObjectsAsync</summary>
        public async Task BatchDeleteDataObjectsRequestObjectAsync()
        {
            // Snippet: BatchDeleteDataObjectsAsync(BatchDeleteDataObjectsRequest, CallSettings)
            // Additional: BatchDeleteDataObjectsAsync(BatchDeleteDataObjectsRequest, CancellationToken)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = await DataObjectServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeleteDataObjectsRequest request = new BatchDeleteDataObjectsRequest
            {
                ParentAsCollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                Requests =
                {
                    new DeleteDataObjectRequest(),
                },
            };
            // Make the request
            await dataObjectServiceClient.BatchDeleteDataObjectsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteDataObjects</summary>
        public void BatchDeleteDataObjects()
        {
            // Snippet: BatchDeleteDataObjects(string, IEnumerable<DeleteDataObjectRequest>, CallSettings)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = DataObjectServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]";
            IEnumerable<DeleteDataObjectRequest> requests = new DeleteDataObjectRequest[]
            {
                new DeleteDataObjectRequest(),
            };
            // Make the request
            dataObjectServiceClient.BatchDeleteDataObjects(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteDataObjectsAsync</summary>
        public async Task BatchDeleteDataObjectsAsync()
        {
            // Snippet: BatchDeleteDataObjectsAsync(string, IEnumerable<DeleteDataObjectRequest>, CallSettings)
            // Additional: BatchDeleteDataObjectsAsync(string, IEnumerable<DeleteDataObjectRequest>, CancellationToken)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = await DataObjectServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]";
            IEnumerable<DeleteDataObjectRequest> requests = new DeleteDataObjectRequest[]
            {
                new DeleteDataObjectRequest(),
            };
            // Make the request
            await dataObjectServiceClient.BatchDeleteDataObjectsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteDataObjects</summary>
        public void BatchDeleteDataObjectsResourceNames()
        {
            // Snippet: BatchDeleteDataObjects(CollectionName, IEnumerable<DeleteDataObjectRequest>, CallSettings)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = DataObjectServiceClient.Create();
            // Initialize request argument(s)
            CollectionName parent = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            IEnumerable<DeleteDataObjectRequest> requests = new DeleteDataObjectRequest[]
            {
                new DeleteDataObjectRequest(),
            };
            // Make the request
            dataObjectServiceClient.BatchDeleteDataObjects(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteDataObjectsAsync</summary>
        public async Task BatchDeleteDataObjectsResourceNamesAsync()
        {
            // Snippet: BatchDeleteDataObjectsAsync(CollectionName, IEnumerable<DeleteDataObjectRequest>, CallSettings)
            // Additional: BatchDeleteDataObjectsAsync(CollectionName, IEnumerable<DeleteDataObjectRequest>, CancellationToken)
            // Create client
            DataObjectServiceClient dataObjectServiceClient = await DataObjectServiceClient.CreateAsync();
            // Initialize request argument(s)
            CollectionName parent = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            IEnumerable<DeleteDataObjectRequest> requests = new DeleteDataObjectRequest[]
            {
                new DeleteDataObjectRequest(),
            };
            // Make the request
            await dataObjectServiceClient.BatchDeleteDataObjectsAsync(parent, requests);
            // End snippet
        }
    }
}
