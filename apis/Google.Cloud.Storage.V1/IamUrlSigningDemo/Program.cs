// Copyright 2018 Google LLC
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
using Google.Apis.Iam.v1;
using Google.Apis.Services;
using Google.Cloud.Storage.V1;
using System;
using System.IO;
using System.Text;

namespace IamUrlSigningDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine($"Expected arguments: bucket-name service-account-id");
                return;
            }

            string bucket = args[0];
            string serviceAccountId = args[1];

            var storageClient = StorageClient.Create();
            var data = Encoding.UTF8.GetBytes("Data stored in GCS and made available via a signed URL");
            var obj = storageClient.UploadObject(bucket, "signing-test", "text/plain", new MemoryStream(data));

            var credentials = GoogleCredential.GetApplicationDefault().CreateScoped(IamService.Scope.CloudPlatform);
            var iamService = new IamService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credentials
            });

            var blobSigner = new IamBlobSigner(iamService, serviceAccountId);
            var urlSigner = UrlSigner.FromBlobSigner(blobSigner);
            var url = urlSigner.Sign(bucket, "signing-test", null, null);
            Console.WriteLine($"Signed URL: {url}");
        }
    }
}
