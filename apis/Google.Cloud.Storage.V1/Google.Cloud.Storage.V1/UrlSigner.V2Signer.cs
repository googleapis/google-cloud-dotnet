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
            public string Sign(RequestTemplate requestTemplate, Options options, IBlobSigner blobSigner, IClock clock)
            {
                var state = new SigningState(requestTemplate, options, blobSigner, clock);
                var signature = blobSigner.CreateSignature(state._blobToSign);
                return state.GetResult(signature);
            }

            public async Task<string> SignAsync(
                RequestTemplate requestTemplate, Options options, IBlobSigner blobSigner, IClock clock, CancellationToken cancellationToken)
            {
                var state = new SigningState(requestTemplate, options, blobSigner, clock);
                var signature = await blobSigner.CreateSignatureAsync(state._blobToSign, cancellationToken).ConfigureAwait(false);
                return state.GetResult(signature);
            }

            private static SortedDictionary<string, StringBuilder> GetExtensionHeaders(
                IReadOnlyDictionary<string, IReadOnlyCollection<string>> requestHeaders,
                IReadOnlyDictionary<string, IReadOnlyCollection<string>> contentHeaders)
            {
                // These docs indicate how to include extension headers in the signature, but they're not exactly
                // correct (values must be trimmed, newlines are replaced with empty strings, not whitespace, and
                // values are concatenated with ", " instead of ",", but not when joining request and content headers).
                // https://cloud.google.com/storage/docs/access-control/signed-urls#about-canonical-extension-headers
                var extensionHeaders = new SortedDictionary<string, StringBuilder>();

                if (requestHeaders != null)
                {
                    PopulateExtensionHeaders(requestHeaders, extensionHeaders);
                }

                if (contentHeaders != null)
                {
                    PopulateExtensionHeaders(
                        contentHeaders,
                        extensionHeaders,
                        keysToExcludeSpaceInNextValueSeparator: new HashSet<string>(extensionHeaders.Keys));
                }

                return extensionHeaders;
            }

            private static void PopulateExtensionHeaders(
                IReadOnlyDictionary<string, IReadOnlyCollection<string>> headers,
                SortedDictionary<string, StringBuilder> extensionHeaders,
                HashSet<string> keysToExcludeSpaceInNextValueSeparator = null)
            {
                foreach (var header in headers)
                {
                    var key = header.Key.ToLowerInvariant();
                    if (!key.StartsWith(GoogHeaderPrefix) ||
                        key == EncryptionKey.KeyHeader ||
                        key == EncryptionKey.KeyHashHeader)
                    {
                        continue;
                    }

                    StringBuilder values;
                    if (!extensionHeaders.TryGetValue(key, out values))
                    {
                        values = new StringBuilder();
                        extensionHeaders.Add(key, values);
                    }
                    else
                    {
                        if (keysToExcludeSpaceInNextValueSeparator == null ||
                            !keysToExcludeSpaceInNextValueSeparator.Remove(key))
                        {
                            values.Append(' ');
                        }
                        values.Append(',');
                    }

                    values.Append(string.Join(", ", header.Value.Select(PrepareHeaderValue)));
                }
            }

            private static string GetFirstHeaderValue(IReadOnlyDictionary<string, IReadOnlyCollection<string>> contentHeaders, string name)
            {
                IReadOnlyCollection<string> values;
                if (contentHeaders != null && contentHeaders.TryGetValue(name, out values))
                {
                    return values.FirstOrDefault();
                }
                return null;
            }

            /// <summary>
            /// State which needs to be carried between the "pre-signing" stage and "post-signing" stages
            /// of the implementation.
            /// </summary>
            private struct SigningState
            {
                private string _resourcePath;
                private List<string> _queryParameters;
                internal byte[] _blobToSign;

                internal SigningState(RequestTemplate template, Options options, IBlobSigner blobSigner, IClock clock)
                {
                    options = options.ToExpiration(clock);

                    string expiryUnixSeconds = ((int) (options.Expiration.Value - UnixEpoch).TotalSeconds).ToString(CultureInfo.InvariantCulture);
                    _resourcePath = $"/{template.Bucket}";
                    if (template.ObjectName != null)
                    {
                        _resourcePath += $"/{Uri.EscapeDataString(template.ObjectName)}";
                    }

                    var extensionHeaders = GetExtensionHeaders(template.RequestHeaders, template.ContentHeaders);
                    var effectiveHttpMethod = template.HttpMethod;
                    if (effectiveHttpMethod == ResumableHttpMethod)
                    {
                        extensionHeaders["x-goog-resumable"] = new StringBuilder("start");
                        effectiveHttpMethod = HttpMethod.Post;
                    }

                    var contentMD5 = GetFirstHeaderValue(template.ContentHeaders, "Content-MD5");
                    var contentType = GetFirstHeaderValue(template.ContentHeaders, "Content-Type");

                    var signatureLines = new List<string>
                    {
                        effectiveHttpMethod.ToString(),
                        contentMD5,
                        contentType,
                        expiryUnixSeconds
                    };
                    signatureLines.AddRange(extensionHeaders.Select(
                        header => $"{header.Key}:{string.Join(", ", header.Value)}"));
                    signatureLines.Add(_resourcePath);
                    _blobToSign = Encoding.UTF8.GetBytes(string.Join("\n", signatureLines));
                    _queryParameters = new List<string> { $"GoogleAccessId={blobSigner.Id}" };
                    if (expiryUnixSeconds != null)
                    {
                        _queryParameters.Add($"Expires={expiryUnixSeconds}");
                    }
                }

                internal string GetResult(string signature)
                {
                    _queryParameters.Add($"Signature={WebUtility.UrlEncode(signature)}");
                    return $"{StorageHost}{_resourcePath}?{string.Join("&", _queryParameters)}";
                }
            }
        }
    }
}
