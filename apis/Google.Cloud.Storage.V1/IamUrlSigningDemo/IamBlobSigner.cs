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

using Google.Apis.Iam.v1;
using Google.Apis.Iam.v1.Data;
using Google.Cloud.Storage.V1;
using System;

namespace IamUrlSigningDemo
{
    internal sealed class IamBlobSigner : UrlSigner.IBlobSigner
    {
        private readonly IamService _iamService;
        public string Id { get; }

        internal IamBlobSigner(IamService service, string id)
        {
            _iamService = service;
            Id = id;
        }

        public string CreateSignature(byte[] data)
        {
            var body = new SignBlobRequest { BytesToSign = Convert.ToBase64String(data) };
            var account = $"projects/-/serviceAccounts/{Id}";
            var response = _iamService.Projects.ServiceAccounts.SignBlob(body, account).Execute();
            return response.Signature;
        }
    }
}
