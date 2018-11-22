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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1
{
    public sealed partial class UrlSigner
    {
        private sealed class V2Signer : ISigner
        {
            public string Sign(
                string bucket,
                string objectName,
                DateTimeOffset? expiration,
                HttpMethod requestMethod,
                Dictionary<string, IEnumerable<string>> requestHeaders,
                Dictionary<string, IEnumerable<string>> contentHeaders,
                IBlobSigner blobSigner,
                IClock clock)
            {
                var state = new SigningState(bucket, objectName, expiration, requestMethod, requestHeaders, contentHeaders, blobSigner);
                var signature = blobSigner.CreateSignature(state.blobToSign);
                return state.GetResult(signature);
            }

            public async Task<string> SignAsync(
                string bucket,
                string objectName,
                DateTimeOffset? expiration,
                HttpMethod requestMethod,
                Dictionary<string, IEnumerable<string>> requestHeaders,
                Dictionary<string, IEnumerable<string>> contentHeaders,
                IBlobSigner blobSigner,
                IClock clock,
                CancellationToken cancellationToken)
            {
                var state = new SigningState(bucket, objectName, expiration, requestMethod, requestHeaders, contentHeaders, blobSigner);
                var signature = await blobSigner.CreateSignatureAsync(state.blobToSign, cancellationToken).ConfigureAwait(false);
                return state.GetResult(signature);
            }

            /// <summary>
            /// State which needs to be carried between the "pre-signing" stage and "post-signing" stages
            /// of the implementation.
            /// </summary>
            private struct SigningState
            {
                private string resourcePath;
                private List<string> queryParameters;
                internal byte[] blobToSign;

                internal SigningState(
                    string bucket,
                    string objectName,
                    DateTimeOffset? expiration,
                    HttpMethod requestMethod,
                    Dictionary<string, IEnumerable<string>> requestHeaders,
                    Dictionary<string, IEnumerable<string>> contentHeaders,
                    IBlobSigner blobSigner)
                {
                    StorageClientImpl.ValidateBucketName(bucket);

                    bool isResumableUpload = false;
                    if (requestMethod == null)
                    {
                        requestMethod = HttpMethod.Get;
                    }
                    else if (requestMethod == ResumableHttpMethod)
                    {
                        isResumableUpload = true;
                        requestMethod = HttpMethod.Post;
                    }

                    string expiryUnixSeconds = ((int?)((expiration - UnixEpoch)?.TotalSeconds))?.ToString(CultureInfo.InvariantCulture);
                    resourcePath = $"/{bucket}";
                    if (objectName != null)
                    {
                        resourcePath += $"/{Uri.EscapeDataString(objectName)}";
                    }
                    var extensionHeaders = GetExtensionHeaders(requestHeaders, contentHeaders);
                    if (isResumableUpload)
                    {
                        extensionHeaders["x-goog-resumable"] = new StringBuilder("start");
                    }

                    var contentMD5 = GetFirstHeaderValue(contentHeaders, "Content-MD5");
                    var contentType = GetFirstHeaderValue(contentHeaders, "Content-Type");

                    var signatureLines = new List<string>
                    {
                        requestMethod.ToString(),
                        contentMD5,
                        contentType,
                        expiryUnixSeconds
                    };
                    signatureLines.AddRange(extensionHeaders.Select(
                        header => $"{header.Key}:{string.Join(", ", header.Value)}"));
                    signatureLines.Add(resourcePath);
                    blobToSign = Encoding.UTF8.GetBytes(string.Join("\n", signatureLines));
                    queryParameters = new List<string> { $"GoogleAccessId={blobSigner.Id}" };
                    if (expiryUnixSeconds != null)
                    {
                        queryParameters.Add($"Expires={expiryUnixSeconds}");
                    }
                }

                internal string GetResult(string signature)
                {
                    queryParameters.Add($"Signature={WebUtility.UrlEncode(signature)}");
                    return $"{StorageHost}{resourcePath}?{string.Join("&", queryParameters)}";
                }
            }
        }
    }
}
