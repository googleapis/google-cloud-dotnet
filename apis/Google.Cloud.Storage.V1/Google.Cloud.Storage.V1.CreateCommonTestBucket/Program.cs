// Copyright 2020 Google LLC
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

using Google.Apis.Auth.OAuth2;
using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;

namespace Google.Cloud.Storage.V1.CreateCommonTestBucket
{
    /// <summary>
    /// Creates and populates a bucket for cross-language testing purposes, where it's easy to do
    /// "slightly the wrong thing".
    /// </summary>
    internal sealed class Program
    {
        private readonly string _bucket;
        private readonly StorageClient _client;

        private Program(string bucket)
        {
            _bucket = bucket;
            _client = StorageClient.Create();
        }

        private static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Required arguments: <bucket>");
                return 1;
            }
            var program = new Program(args[0]);
            program.PopulateBucket();
            return 0;
        }

        private void PopulateBucket()
        {
            MaybeCreateBucket();
            DeleteExistingFiles();
            CreateNormalizationFiles();
            CreateGZippedContent();
        }

        private void MaybeCreateBucket()
        {
            try
            {
                _client.GetBucket(_bucket);
                return;
            }
            catch (GoogleApiException ex) when (ex.HttpStatusCode == HttpStatusCode.NotFound)
            {
                // Need to create the bucket...
                // (But let's do so outside the catch.)
            }
            Console.WriteLine($"Creating bucket '{_bucket}'");
            var serviceAccount = GoogleCredential.GetApplicationDefault().UnderlyingCredential as ServiceAccountCredential;
            if (serviceAccount is null)
            {
                throw new InvalidOperationException("Default credentials are not for a service account, so we can't determine the project ID");
            }
            _client.CreateBucket(serviceAccount.ProjectId, _bucket);
        }

        private void DeleteExistingFiles()
        {
            var objects = _client.ListObjects(_bucket).ToList();
            foreach (var obj in objects)
            {
                Console.WriteLine($"Deleting {obj.Name}");
                _client.DeleteObject(obj);
            }
        }

        private void CreateNormalizationFiles()
        {
            // Normalization Form C: a single character for e-acute.
            // URL should end with Caf%C3%A9
            _client.UploadObject(_bucket, "Caf\u00e9", "text/plain", new MemoryStream(Encoding.UTF8.GetBytes("Normalization Form C")));
            // Normalization Form D: an ASCII e followed by U+0301 combining character
            // URL should end with Cafe%CC%81
            _client.UploadObject(_bucket, "Cafe\u0301", "text/plain", new MemoryStream(Encoding.UTF8.GetBytes("Normalization Form D")));
            Console.WriteLine("Created normalization test files");
        }

        private void CreateGZippedContent()
        {
            byte[] textData = Encoding.UTF8.GetBytes("hello world");
            var compressedData = new MemoryStream();
            using (var gzipStream = new GZipStream(compressedData, CompressionLevel.Optimal, leaveOpen: true))
            {
                gzipStream.Write(textData);
            }
            compressedData.Position = 0;

            // First upload the compressed data
            var obj = _client.UploadObject(_bucket, "gzipped-text.txt", "text/plain", compressedData);

            // Then set the content encoding on the metadata
            obj.ContentEncoding = "gzip";
            _client.UpdateObject(obj);
            Console.WriteLine("Created gzip test file");
        }

        private void CreateFile(string name, string contentType, byte[] content)
        {
            _client.UploadObject(_bucket, name, contentType, new MemoryStream(content));
        }
    }
}
