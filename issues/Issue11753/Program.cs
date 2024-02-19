// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Google.Cloud.Storage.V1;
using System.Text;
using Object = Google.Apis.Storage.v1.Data.Object;

Console.WriteLine("Hello, World!");

if (args.Length != 2)
{
    Console.WriteLine("Command line arguments: <bucket-name> <object-name>");
    return;
}

var obj = new Object
{
    Bucket = args[0],
    Name = args[1],
    ContentType = "text/plain",
    CustomTimeDateTimeOffset = new DateTimeOffset(2005, 1, 1, 0, 0, 0, TimeSpan.Zero)
};

var client = StorageClient.Create();
using var stream = new MemoryStream(Encoding.UTF8.GetBytes("This object has a custom time"));

var uploaded = client.UploadObject(obj, stream);
Console.WriteLine($"Returned object custom DTO: {uploaded.CustomTimeDateTimeOffset}");
