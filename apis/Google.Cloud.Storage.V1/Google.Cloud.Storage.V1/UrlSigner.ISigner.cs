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

using Google.Api.Gax;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1
{
    public sealed partial class UrlSigner
    {
        /// <summary>
        /// Abstraction over V2/V4 signing details.
        /// </summary>
        private interface ISigner
        {
            string Sign(
                RequestTemplate requestTemplate,
                Options options,
                BlobSignerProvider blobSignerProvider,
                IClock clock);

            Task<string> SignAsync(
                RequestTemplate requestTemplate,
                Options options,
                BlobSignerProvider blobSignerProvider,
                IClock clock,
                CancellationToken cancellationToken);

            SignedPostPolicy Sign(
                PostPolicy postPolicy,
                Options options,
                BlobSignerProvider blobSignerProvider,
                IClock clock);

            Task<SignedPostPolicy> SignAsync(
                PostPolicy postPolicy,
                Options options,
                BlobSignerProvider blobSignerProvider,
                IClock clock,
                CancellationToken cancellationToken);
        }
    }
}
