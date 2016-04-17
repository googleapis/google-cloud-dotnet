// Copyright 2015 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Download;
using Google.Apis.Storage.v1;
using Google.Apis.Storage.v1.Data;
using Google.Apis.Upload;
using System;
using System.Diagnostics;
using System.IO;
using StorageObject = Google.Apis.Storage.v1.Data.Object;
using System.Net.Http;

namespace Google.Storage.V1.Demo
{
    /// Command line application to demonstrate features of the Google Cloud Storage client wrapper library.
    public class Program
    {
        public void Main(string[] args)
        {
            var projectId = "YOUR-PROJECT-ID";

            // create a file to test with
            if (!File.Exists("demo-test.txt")) { File.WriteAllText("demo-test.txt", "testing 123..."); }

            // create a connection to the GCS service
            var client = StorageClient.Create();

            // exercise Google Cloud Storage
            ListBuckets(client, projectId);
            Bucket bucket = CreateBucket(client, projectId, $"gcs-demo-bucket");
            Bucket bucketX = GetBucket(client, bucket.Name);
            Debug.Assert(bucket.Id == bucketX.Id);

            StorageObject file1 = UploadFile(client, bucket.Name, "demo-test.txt", "stuff/test1.txt", "text/plain", makePublic: true);
            StorageObject file2 = UploadFile(client, bucket.Name, "demo-test.txt", "stuff/test2.txt", "text/plain", makePublic: false);
            StorageObject fileX = GetObject(client, bucket.Name, "stuff/test1.txt");
            Debug.Assert(file1.Id == fileX.Id);
            DownloadFile(client, bucket.Name, file2.Name, "demo-download-test.txt");
            Debug.Assert(File.ReadAllText("demo-test.txt") == File.ReadAllText("demo-download-test.txt"));

            using( var http = new HttpClient() )
            {
                // should be able to download the file uploaded as public and not the one uploaded as private
                Debug.Assert(http.GetStringAsync(file1.MediaLink).Result == File.ReadAllText("demo-test.txt"));
                try { var x = http.GetStringAsync(file2.MediaLink).Result; Debug.Assert(false); }
                catch (Exception ex) { Console.WriteLine(ex.GetType().Name); }
            }

            ListObjects(client, bucket.Name);
            ListFilesAndFolders(client, bucket.Name);

            DeleteObject(client, bucket.Name, file1.Name);
            DeleteObject(client, bucket.Name, file2.Name);
            DeleteBucket(client, bucket.Name);
            ListBuckets(client, projectId);
        }

        // [START list_buckets]
        static void ListBuckets(StorageClient client, string projectId)
        {
            // list buckets
            Console.WriteLine($"Buckets in {projectId}:");
            var buckets = client.ListBuckets(projectId);
            foreach (var bucket in buckets)
            {
                Console.WriteLine($"  {bucket.Name}");
            }
        }
        // [END list_buckets]

        // [START create_bucket]
        static Bucket CreateBucket(StorageClient client, string projectId, string name)
        {
            // create a bucket (GCS bucket names must be globally unique)
            Console.WriteLine($"Creating bucket {name} in project {projectId}");
            return client.Service.Buckets.Insert(new Bucket { Name = name }, projectId).Execute();
        }
        // [END create_bucket]

        // [START list_objects]
        static void ListObjects(StorageClient client, string bucket, string prefix = "")
        {
            Console.WriteLine($"Objects in bucket {bucket}:");
            var objects = client.ListObjects(bucket, prefix);
            foreach (var obj in objects)
            {
                Console.WriteLine($"  {obj.Name} [{obj.ContentType}]");
            }
        }
        // [END list_objects]

        // [START list_files_and_folders]
        // Folders can be objects of zero length of content type application/x-www-form-urlencoded;charset=UTF-8
        // as used by the GCS Browser: https://console.cloud.google.com/storage/browser?project=YOUR-PROJECT-ID
        // Folders can also be implicit in file names with prefixes containing the delimited "/", also used by
        // the GCS Browser. The extension methods provided in BrowserHelper knows how to deal with both.
        static void ListFilesAndFolders(StorageClient client, string bucket, string parentFolder = "", string indent = "  ")
        {
            if (parentFolder == "") { Console.WriteLine($"Files and folders in bucket {bucket}:"); }

            string shortName = parentFolder == "" ? bucket : BucketHelper.ShortName(parentFolder);
            Console.WriteLine($"{indent}{shortName}/");
            indent += "  ";

            foreach (var file in client.ListFiles(bucket, parentFolder))
            {
                Console.WriteLine($"{indent}{file.ShortName()} [{file.ContentType}]");
            }

            foreach (var folder in client.ListFolders(bucket, parentFolder))
            {
                ListFilesAndFolders(client, bucket, folder, indent);
            }
        }
        // [END list_files_and_folders]

        // [START download_file]
        static void DownloadFile(StorageClient client, string bucket, string source, string destination)
        {
            Console.WriteLine($"Downloading GCS file {source} from bucket {bucket} to local file {destination}:");
            using (var stream = File.Create(destination))
            {
                var progress = new Progress<IDownloadProgress>(
                    p => Console.WriteLine($"  Downloaded {p.BytesDownloaded} bytes; status: {p.Status}")
                );

                client.DownloadObject(bucket, source, stream, null, progress);
            }
        }
        // [END download_file]

        // [START upload_file]
        static StorageObject UploadFile(StorageClient client, string bucket, string source, string destination, string contentType, bool makePublic)
        {
            Console.WriteLine($"Uploading local file {source} of type {contentType} to GCS file {destination} in {bucket}:");
            using (var stream = File.OpenRead(source))
            {
                var progress = new Progress<IUploadProgress>(
                  p => Console.WriteLine($"  Uploaded {p.BytesSent} bytes; status: {p.Status}")
                );

                var options = new UploadObjectOptions {
                    PredefinedAcl = makePublic ?
                        ObjectsResource.InsertMediaUpload.PredefinedAclEnum.PublicRead :
                        ObjectsResource.InsertMediaUpload.PredefinedAclEnum.AuthenticatedRead
                };

                return client.UploadObject(bucket, destination, contentType, stream, options, progress);
            }
        }
        // [END upload_file]

        // [START get_object]
        static StorageObject GetObject(StorageClient client, string bucket, string name)
        {
            Console.WriteLine($"Getting object {name} from bucket {bucket}:");

            var obj = client.GetObject(bucket, name);
            Console.WriteLine($"  Id: {obj.Id}");
            Console.WriteLine($"  Name: {obj.Name}");
            Console.WriteLine($"  ContentType: {obj.ContentType}");
            Console.WriteLine($"  Size: {obj.Size}");
            Console.WriteLine($"  MediaLink: {obj.MediaLink}");
            Console.WriteLine($"  SelfLink: {obj.SelfLink}");
            return obj;
        }
        // [END get_object]

        // [START get_bucket]
        static Bucket GetBucket(StorageClient client, string name)
        {
            Console.WriteLine($"Getting bucket {name}:");

            var bucket = client.Service.Buckets.Get(name).Execute();
            Console.WriteLine($"  Id: {bucket.Id}");
            Console.WriteLine($"  Name: {bucket.Name}");
            return bucket;
        }
        // [END get_object]

        // [START delete_object]
        static void DeleteObject(StorageClient client, string bucket, string name)
        {
            Console.WriteLine($"Deleting file {name} from bucket {bucket}");
            client.DeleteObject(bucket, name);
        }
        // [END delete_object]

        // [START delete_bucket]
        static void DeleteBucket(StorageClient client, string bucket)
        {
            Console.WriteLine($"Deleting bucket {bucket}");
            client.Service.Buckets.Delete(bucket).Execute();
        }
        // [END delete_bucket]

    }
}
