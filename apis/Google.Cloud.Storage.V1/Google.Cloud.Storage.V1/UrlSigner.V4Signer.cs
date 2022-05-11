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
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1
{
    public sealed partial class UrlSigner
    {
        private sealed class V4Signer : ISigner
        {
            private static readonly int MaxExpirySecondsInclusive = (int) TimeSpan.FromDays(7).TotalSeconds;

            // Note: It's irritating to have to convert from base64 to bytes and then to hex, but we can't change the IBlobSigner implementation
            // and ServiceAccountCredential.CreateSignature returns base64 anyway.

            public string Sign(RequestTemplate requestTemplate, Options options, IBlobSigner blobSigner, IClock clock)
            {
                var signerParameters = BlobSignerParameters.ForCurrentTimestamp(clock);
                var state = new UrlSigningState(requestTemplate, options, blobSigner, signerParameters);
                var base64Signature = blobSigner.CreateSignature(state._blobToSign, signerParameters);
                var rawSignature = Convert.FromBase64String(base64Signature);
                var hexSignature = FormatHex(rawSignature);
                return state.GetResult(hexSignature);
            }

            public async Task<string> SignAsync(
                RequestTemplate requestTemplate, Options options, IBlobSigner blobSigner, IClock clock, CancellationToken cancellationToken)
            {
                var signerParameters = BlobSignerParameters.ForCurrentTimestamp(clock);
                var state = new UrlSigningState(requestTemplate, options, blobSigner, signerParameters);
                var base64Signature = await blobSigner.CreateSignatureAsync(state._blobToSign, signerParameters, cancellationToken).ConfigureAwait(false);
                var rawSignature = Convert.FromBase64String(base64Signature);
                var hexSignature = FormatHex(rawSignature);
                return state.GetResult(hexSignature);
            }

            public SignedPostPolicy Sign(PostPolicy postPolicy, Options options, IBlobSigner blobSigner, IClock clock)
            {
                var signerParameters = BlobSignerParameters.ForCurrentTimestamp(clock);
                var state = new PostPolicySigningState(new PostPolicy(postPolicy), options, blobSigner, signerParameters);
                var base64Signature = blobSigner.CreateSignature(state._blobToSign, signerParameters);
                var rawSignature = Convert.FromBase64String(base64Signature);
                var hexSignature = FormatHex(rawSignature);
                return state.GetResult(hexSignature);
            }

            public async Task<SignedPostPolicy> SignAsync(PostPolicy postPolicy, Options options, IBlobSigner blobSigner, IClock clock, CancellationToken cancellationToken)
            {
                var signerParameters = BlobSignerParameters.ForCurrentTimestamp(clock);
                var state = new PostPolicySigningState(new PostPolicy(postPolicy), options, blobSigner, signerParameters);
                var base64Signature = await blobSigner.CreateSignatureAsync(state._blobToSign, signerParameters, cancellationToken).ConfigureAwait(false);
                var rawSignature = Convert.FromBase64String(base64Signature);
                var hexSignature = FormatHex(rawSignature);
                return state.GetResult(hexSignature);
            }

            /// <summary>
            /// State which needs to be carried between the "pre-signing" stage and "post-signing" stages
            /// of the implementation.
            /// </summary>
            private readonly struct UrlSigningState
            {
                private readonly string _resourcePath;
                private readonly string _canonicalQueryString;
                internal readonly byte[] _blobToSign;
                private readonly string _scheme;
                private readonly string _host;

                internal UrlSigningState(RequestTemplate template, Options options, IBlobSigner blobSigner, BlobSignerParameters signerParameters)
                {
                    (_host, _resourcePath) = options.UrlStyle switch
                    {
                        UrlStyle.PathStyle => (StorageHost, $"/{template.Bucket}"),
                        UrlStyle.VirtualHostedStyle => ($"{template.Bucket}.{StorageHost}", string.Empty),
                        UrlStyle.BucketBoundHostname => (options.BucketBoundHostname, string.Empty),
                        _ => throw new ArgumentOutOfRangeException(nameof(options.UrlStyle))
                    };

                    var now = signerParameters.SignatureTimestamp;

                    _scheme = options.Scheme;
                    options = options.ToExpiration(now);

                    var timestamp = now.ToString("yyyyMMdd'T'HHmmss'Z'", CultureInfo.InvariantCulture);
                    var datestamp = now.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
                    int expirySeconds = (int) (options.Expiration.Value - now).TotalSeconds;
                    if (expirySeconds <= 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(options.Expiration), "Expiration must be at least 1 second");
                    }
                    if (expirySeconds > MaxExpirySecondsInclusive)
                    {
                        throw new ArgumentOutOfRangeException(nameof(options.Expiration), "Expiration must not be greater than 7 days.");
                    }

                    string expiryText = expirySeconds.ToString(CultureInfo.InvariantCulture);

                    string credentialScope = $"{datestamp}/{signerParameters.Region}/{signerParameters.Service}/{signerParameters.RequestType}";

                    var headers = new SortedDictionary<string, string>(StringComparer.Ordinal);
                    headers.AddHeader("host", _host);
                    var effectiveRequestMethod = template.HttpMethod;
                    if (effectiveRequestMethod == ResumableHttpMethod)
                    {
                        effectiveRequestMethod = HttpMethod.Post;
                        headers.AddHeader("x-goog-resumable", "start");
                    }
                    headers.AddHeaders(template.RequestHeaders);
                    headers.AddHeaders(template.ContentHeaders);
                    var canonicalHeaders = string.Join("", headers.Select(pair => $"{pair.Key}:{pair.Value}\n"));
                    var signedHeaders = string.Join(";", headers.Keys.Select(k => k.ToLowerInvariant()));

                    var queryParameters = new SortedSet<string>(StringComparer.Ordinal);
                    queryParameters.AddQueryParameter("X-Goog-Algorithm", blobSigner.Algorithm);
                    queryParameters.AddQueryParameter("X-Goog-Credential", $"{blobSigner.Id}/{credentialScope}");
                    queryParameters.AddQueryParameter("X-Goog-Date", timestamp);
                    queryParameters.AddQueryParameter("X-Goog-Expires", expirySeconds.ToString(CultureInfo.InvariantCulture));
                    queryParameters.AddQueryParameter("X-Goog-SignedHeaders", signedHeaders);

                    queryParameters.AddQueryParameters(template.QueryParameters);

                    _canonicalQueryString = string.Join("&", queryParameters);
                    if (!string.IsNullOrEmpty(template.ObjectName))
                    {
                        // EscapeDataString escapes slashes, which we *don't* want to escape here. The simplest option is to
                        // split the path into segments by slashes, escape each segment, then join the escaped segments together again.
                        var segments = template.ObjectName.Split('/');
                        var escaped = string.Join("/", segments.Select(Uri.EscapeDataString));
                        _resourcePath = _resourcePath + "/" + escaped;
                    }

                    string payloadHash = "UNSIGNED-PAYLOAD";
                    var payloadHashHeader = headers.Where(
                        header => header.Key.Equals("X-Goog-Content-SHA256", StringComparison.OrdinalIgnoreCase)).ToList();
                    if (payloadHashHeader.Count == 1)
                    {
                        payloadHash = payloadHashHeader[0].Value;
                    }

                    var canonicalRequest = $"{effectiveRequestMethod}\n{_resourcePath}\n{_canonicalQueryString}\n{canonicalHeaders}\n{signedHeaders}\n{payloadHash}";

                    string hashHex;
                    using (var sha256 = SHA256.Create())
                    {
                        hashHex = FormatHex(sha256.ComputeHash(Encoding.UTF8.GetBytes(canonicalRequest)));
                    }

                    _blobToSign = Encoding.UTF8.GetBytes($"{blobSigner.Algorithm}\n{timestamp}\n{credentialScope}\n{hashHex}");
                }

                internal string GetResult(string signature) =>
                    $"{_scheme}://{_host}{_resourcePath}?{_canonicalQueryString}&X-Goog-Signature={WebUtility.UrlEncode(signature)}";
            }

            /// <summary>
            /// State which needs to be carried between the "pre-signing" stage and "post-signing" stages
            /// of the implementation.
            /// </summary>
            private readonly struct PostPolicySigningState
            {
                private readonly PostPolicy _policy;
                private readonly string _encodedPolicy;
                internal readonly byte[] _blobToSign;
                internal readonly DateTimeOffset _expiration;
                private readonly Uri _url;

                internal PostPolicySigningState(PostPolicy policy, Options options, IBlobSigner blobSigner, BlobSignerParameters signerParameters)
                {
                    string uri = options.UrlStyle switch
                    {
                        UrlStyle.PathStyle => policy.Bucket == null ? StorageHost : $"{StorageHost}/{policy.Bucket}",
                        UrlStyle.VirtualHostedStyle => policy.Bucket == null ?
                            throw new ArgumentNullException(nameof(PostPolicy.Bucket), $"When using {UrlStyle.VirtualHostedStyle} a bucket condition must be set in the policy.") :
                            $"{policy.Bucket}.{StorageHost}",
                        UrlStyle.BucketBoundHostname => options.BucketBoundHostname,
                        _ => throw new ArgumentOutOfRangeException(nameof(options.UrlStyle))
                    };

                    uri = $"{options.Scheme}://{uri}/";

                    var now = signerParameters.SignatureTimestamp;
                    options = options.ToExpiration(now);

                    int expirySeconds = (int)(options.Expiration.Value - now).TotalSeconds;
                    if (expirySeconds <= 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(options.Expiration), "Expiration must be at least 1 second.");
                    }
                    if (expirySeconds > MaxExpirySecondsInclusive)
                    {
                        throw new ArgumentOutOfRangeException(nameof(options.Expiration), "Expiration must not be greater than 7 days.");
                    }

                    var datestamp = now.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
                    string credentialScope = $"{datestamp}/{signerParameters.Region}/{signerParameters.Service}/{signerParameters.RequestType}";

                    policy.SetField(PolicyCreationDateTime.Element, now);
                    policy.SetField(PolicyAlgorithm.Element, blobSigner.Algorithm);
                    policy.SetField(PolicyCredential.Element, $"{blobSigner.Id}/{credentialScope}");

                    _expiration = options.Expiration.Value;
                    _policy = policy;
                    _url = new Uri(uri);

                    StringBuilder sb = new StringBuilder();
                    StringWriter sw = new StringWriter(sb);

                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        writer.StringEscapeHandling = StringEscapeHandling.EscapeNonAscii;
                        writer.WriteStartObject();
                        policy.WriteTo(writer);
                        writer.WritePropertyName("expiration");
                        writer.WriteValue(_expiration.UtcDateTime.ToString("yyyy-MM-dd'T'HH:mm:ss'Z'", CultureInfo.InvariantCulture));
                        writer.WriteEndObject();
                    }

                    var decodedPolicy = sb.ToString();
                    _encodedPolicy = Convert.ToBase64String(Encoding.UTF8.GetBytes(decodedPolicy));
                    _blobToSign = Encoding.UTF8.GetBytes(_encodedPolicy);
                }

                internal SignedPostPolicy GetResult(string signature) =>
                    new SignedPostPolicy(_policy, _encodedPolicy, signature, _expiration, _url);
            }

            private const string HexCharacters = "0123456789abcdef";
            private static string FormatHex(byte[] bytes)
            {
                // Could just use BitConverter, but it's inefficient to create multiple strings and
                // easy to do it ourselves instead.
                char[] chars = new char[bytes.Length * 2];
                for (int i = 0; i < bytes.Length; i++)
                {
                    chars[i * 2] = HexCharacters[bytes[i] >> 4];
                    chars[i * 2 + 1] = HexCharacters[bytes[i] & 0xf];
                }
                return new string(chars);
            }
        }
    }
}
