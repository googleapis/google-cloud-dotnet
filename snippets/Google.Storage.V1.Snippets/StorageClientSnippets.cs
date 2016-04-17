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

using Google.Apis.Storage.v1;
using Google.Apis.Storage.v1.Data;
using Google.Storage.V1;
using System;
using System.IO;

public class StorageClientSnippets
{
    public void Overview()
    {
        // <Overview>
        var projectId = "firm-site-126023"; // TODO "YOUR-PROJECT-ID";

        // GCS client connection
        var client = StorageClient.Create();

        // create a bucket (GCS bucket names must be globally unique)
        var bucket = DateTime.Now.Ticks.ToString(); // TODO "YOUR-BUCKET-NAME";
        client.Service.Buckets.Insert(new Bucket { Name = bucket }, projectId).Execute();

        // upload a file
        var source = @"C:\Users\Chris\Downloads\kitty.jpg"; // TODO "YOUR-LOCAL-FILENAME"
        var contentType = "image/jpg"; // TODO "YOUR-CONTENT-TYPE"
        var destination = "pets/kitty.jpg"; // TODO "YOUR-OBJECT-NAME"
        using (var stream = File.OpenRead(source))
        {
            var obj = client.UploadObject(bucket, destination, contentType, stream, 
                new UploadObjectOptions {
                    PredefinedAcl = ObjectsResource.InsertMediaUpload.PredefinedAclEnum.PublicRead
                }
            );

            Console.WriteLine($"Surf to {obj.MediaLink}");
        }

        // list objects in your bucket
        foreach( var obj in client.ListObjects(bucket, ""))
        {
            Console.WriteLine($"{obj.Name} of type {obj.ContentType}");
        }
        // </Overview>

        client.DeleteObject(bucket, destination);
        client.Service.Buckets.Delete(bucket).Execute();
    }

}