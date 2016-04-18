// Copyright 2016 Google Inc. All Rights Reserved.
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
using Google.Storage.V1;
using System;
using System.IO;

public class StorageClientSnippets
{
    public void Overview()
    {
        // <Overview>
        var projectId = "YOUR-PROJECT-ID";

        // GCS client connection
        var client = StorageClient.Create();

        // create a bucket (GCS bucket names must be globally unique)
        var bucket = "YOUR-BUCKET-NAME";
        client.Service.Buckets.Insert(new Bucket { Name = bucket }, projectId).Execute();

        // upload a file
        var source = "YOUR-LOCAL-FILENAME";
        var contentType = "YOUR-CONTENT-TYPE";
        var destination = "YOUR-OBJECT-NAME";
        using (var stream = File.OpenRead(source))
        {
            var obj = client.UploadObject(bucket, destination, contentType, stream,
                new UploadObjectOptions
                {
                    PredefinedAcl = ObjectsResource.InsertMediaUpload.PredefinedAclEnum.PublicRead
                }
            );

            Console.WriteLine($"Surf to {obj.MediaLink}");
        }

        // list objects in your bucket
        foreach (var obj in client.ListObjects(bucket, ""))
        {
            Console.WriteLine($"{obj.Name} of type {obj.ContentType}");
        }
        // </Overview>

        client.DeleteObject(bucket, destination);
        client.Service.Buckets.Delete(bucket).Execute();
    }

    static void ListBuckets(StorageClient client, string projectId)
    {
        // <ListBuckets>
        Console.WriteLine($"Buckets in {projectId}:");
        var buckets = client.ListBuckets(projectId);
        foreach (var bucket in buckets)
        {
            Console.WriteLine($"  {bucket.Name}");
        }
        // </ListBuckets>
    }

    static Bucket CreateBucket(StorageClient client, string projectId, string name)
    {
        // <CreateBucket>
        // GCS bucket names must be globally unique
        Console.WriteLine($"Creating bucket {name} in project {projectId}");
        return client.Service.Buckets.Insert(new Bucket { Name = name }, projectId).Execute();
        // </CreateBucket>
    }

    static void ListObjects(StorageClient client, string bucket, string prefix = "")
    {
        // <ListObjects>
        Console.WriteLine($"Objects in bucket {bucket}:");
        var objects = client.ListObjects(bucket, prefix);
        foreach (var obj in objects)
        {
            Console.WriteLine($"  {obj.Name} [{obj.ContentType}]");
        }
        // </ListObjects>
    }

    static void DownloadFile(StorageClient client, string bucket, string source, string destination)
    {
        // <DownloadFile>
        Console.WriteLine($"Downloading GCS file {source} from bucket {bucket} to local file {destination}:");
        using (var stream = File.Create(destination))
        {
            var progress = new Progress<IDownloadProgress>(
                p => Console.WriteLine($"  Downloaded {p.BytesDownloaded} bytes; status: {p.Status}")
            );

            client.DownloadObject(bucket, source, stream, null, progress);
        }
        // </DownloadFile>
    }

    static Google.Apis.Storage.v1.Data.Object UploadFile(StorageClient client, string bucket, string source, string destination, string contentType, bool makePublic)
    {
        // <UploadFile>
        Console.WriteLine($"Uploading local file {source} of type {contentType} to GCS file {destination} in {bucket}:");
        using (var stream = File.OpenRead(source))
        {
            var progress = new Progress<IUploadProgress>(
              p => Console.WriteLine($"  Uploaded {p.BytesSent} bytes; status: {p.Status}")
            );

            var options = new UploadObjectOptions
            {
                PredefinedAcl = makePublic ?
                    ObjectsResource.InsertMediaUpload.PredefinedAclEnum.PublicRead :
                    ObjectsResource.InsertMediaUpload.PredefinedAclEnum.AuthenticatedRead
            };

            return client.UploadObject(bucket, destination, contentType, stream, options, progress);
        }
        // </UploadFile>
    }

    static Google.Apis.Storage.v1.Data.Object GetObject(StorageClient client, string bucket, string name)
    {
        // <GetObject>
        Console.WriteLine($"Getting object {name} from bucket {bucket}:");

        var obj = client.GetObject(bucket, name);
        Console.WriteLine($"  Id: {obj.Id}");
        Console.WriteLine($"  Name: {obj.Name}");
        Console.WriteLine($"  ContentType: {obj.ContentType}");
        Console.WriteLine($"  Size: {obj.Size}");
        Console.WriteLine($"  MediaLink: {obj.MediaLink}");
        Console.WriteLine($"  SelfLink: {obj.SelfLink}");
        return obj;
        // </GetObject>
    }

    static Bucket GetBucket(StorageClient client, string name)
    {
        // <GetBucket>
        Console.WriteLine($"Getting bucket {name}:");

        var bucket = client.Service.Buckets.Get(name).Execute();
        Console.WriteLine($"  Id: {bucket.Id}");
        Console.WriteLine($"  Name: {bucket.Name}");
        return bucket;
        // </GetBucket>
    }

    static void DeleteObject(StorageClient client, string bucket, string name)
    {
        // <DeleteObject>
        Console.WriteLine($"Deleting file {name} from bucket {bucket}");
        client.DeleteObject(bucket, name);
        // </DeleteObject>
    }

    static void DeleteBucket(StorageClient client, string bucket)
    {
        // <DeleteBucket>
        Console.WriteLine($"Deleting bucket {bucket}");
        client.Service.Buckets.Delete(bucket).Execute();
        // </DeleteBucket>
    }
}