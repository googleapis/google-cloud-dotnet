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

using Google.Cloud.Storage.Control.V2;
using System;

namespace Google.Cloud.Storage.Control.V2.Snippets
{
    public class DeleteFolderRecursiveSample
    {
        public void DeleteFolderRecursive(string bucketName, string folderName)
        {
            // [START storage_control_delete_folder_recursive]
            StorageControlClient storageControlClient = StorageControlClient.Create();

            // Format: projects/{project}/buckets/{bucket}/folders/{folder}
            string folderResourceName = $"projects/_/buckets/{bucketName}/folders/{folderName}";

            storageControlClient.DeleteFolderRecursive(folderResourceName).PollUntilCompleted();

            Console.WriteLine($"Deleted folder {folderName} recursively");
            // [END storage_control_delete_folder_recursive]
        }
    }
}
