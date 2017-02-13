// Copyright 2015 Google Inc. All Rights Reserved.
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

using Google.Api.Gax;
using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Class which helps create signed URLs which can be used to provide limited access to specific buckets and objects
    /// to anyone in possession of the URL, regardless of whether they have a Google account.
    /// </summary>
    /// <remarks>
    /// See https://cloud.google.com/storage/docs/access-control/signed-urls for more information on signed URLs.
    /// </remarks>
    public sealed class UrlSigner
    {
        private const string GoogHeaderPrefix = "x-goog-";
        private const string StorageHost = "https://storage.googleapis.com";

        /// <summary>
        /// Gets a special HTTP method which can be used to create a signed URL for initiating a resumable upload.
        /// See https://cloud.google.com/storage/docs/access-control/signed-urls#signing-resumable for more information.
        /// </summary>
        /// <remarks>
        /// Note: When using the RESUMABLE method to create a signed URL, a URL will actually be signed for the POST method with a header of
        /// 'x-goog-resumable:start'. The caller must perform a POST request with this URL and specify the 'x-goog-resumable:start' header as
        /// well or signature validation will fail.
        /// </remarks>
        public static HttpMethod ResumableHttpMethod { get; } = new HttpMethod("RESUMABLE");

        private static readonly DateTimeOffset UnixEpoch = new DateTimeOffset(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc), TimeSpan.Zero);

        private readonly ServiceAccountCredential _credentials;

        private UrlSigner(ServiceAccountCredential credentials)
        {
            _credentials = credentials;
        }

        /// <summary>
        /// Creates a new <see cref="UrlSigner"/> instance for a service account.
        /// </summary>
        /// <param name="credentialFilePath">The path to the JSON key file for a service account. Must not be null.</param>
        /// <exception cref="InvalidOperationException">
        /// The <paramref name="credentialFilePath"/> does not refer to a valid JSON service account key file.
        /// </exception>
        public static UrlSigner FromServiceAccountPath(string credentialFilePath)
        {
            GaxPreconditions.CheckNotNull(credentialFilePath, nameof(credentialFilePath));
            using (var credentialData = File.OpenRead(credentialFilePath))
            {
                return FromServiceAccountData(credentialData);
            }
        }

        /// <summary>
        /// Creates a new <see cref="UrlSigner"/> instance for a service account.
        /// </summary>
        /// <param name="credentialData">The stream from which to read the JSON key data for a service account. Must not be null.</param>
        /// <exception cref="InvalidOperationException">
        /// The <paramref name="credentialData"/> does not contain valid JSON service account key data.
        /// </exception>
        public static UrlSigner FromServiceAccountData(Stream credentialData)
        {
            GaxPreconditions.CheckNotNull(credentialData, nameof(credentialData));
            return UrlSigner.FromServiceAccountCredential(ServiceAccountCredential.FromServiceAccountData(credentialData));
        }

        /// <summary>
        /// Creates a new <see cref="UrlSigner"/> instance for a service account.
        /// </summary>
        /// <param name="credential">The credential for the a service account. Must not be null.</param>
        public static UrlSigner FromServiceAccountCredential(ServiceAccountCredential credential)
        {
            GaxPreconditions.CheckNotNull(credential, nameof(credential));
            return new UrlSigner(credential);
        }

        /// <summary>
        /// Creates a signed URL which can be used to provide limited access to specific buckets and objects to anyone
        /// in possession of the URL, regardless of whether they have a Google account.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When the <paramref name="request"/> is specified, some of its headers will be included in the signed URL's
        /// signature, and therefore must be included in requests made with the created URL. These are the Content-MD5 and
        /// Content-Type content headers as well as any content or request header with a name starting with "x-goog-".
        /// </para>
        /// <para>
        /// If <paramref name="request"/> is null, no headers are included in the signed URL's signature, so any requests
        /// made with the created URL must not contain Content-MD5, Content-Type, or any header starting with "x-goog-".
        /// </para>
        /// <para>
        /// Note that if the entity is encrypted with customer-supplied encryption keys (see
        /// https://cloud.google.com/storage/docs/encryption for more information), the <b>x-goog-encryption-algorithm</b>,
        /// <b>x-goog-encryption-key</b>, and <b>x-goog-encryption-key-sha256</b> headers will be required when making the
        /// request. However, only the x-goog-encryption-algorithm header is included in the signature for the signed URL.
        /// So the sample <paramref name="request"/> specified only needs to have the x-goog-encryption-algorithm request
        /// header. The other headers can be included, but will be ignored.
        /// </para>
        /// <para>
        /// Note that when GET is specified as the <paramref name="request"/>, both GET and HEAD requests can be made with
        /// the created signed URL.
        /// </para>
        /// <para>
        /// See https://cloud.google.com/storage/docs/access-control/signed-urls for more information on signed URLs.
        /// </para>
        /// </remarks>
        /// <param name="bucket">The name of the bucket. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. May be null, in which case the signed URL
        /// will refer to the bucket instead of an object.</param>
        /// <param name="duration">The length of time for which the signed URL should remain usable.</param>
        /// <param name="request">A sample request for which the signed URL might be used. May be null.</param>
        /// <returns>
        /// The signed URL which can be used to provide access to a bucket or object for a limited amount of time.
        /// </returns>
        public string Sign(string bucket, string objectName, TimeSpan duration, HttpRequestMessage request) =>
            Sign(bucket, objectName, DateTimeOffset.UtcNow + duration, request);

        /// <summary>
        /// Creates a signed URL which can be used to provide limited access to specific buckets and objects to anyone
        /// in possession of the URL, regardless of whether they have a Google account.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When the <paramref name="request"/> is specified, some of its headers will be included in the signed URL's
        /// signature, and therefore must be included in requests made with the created URL. These are the Content-MD5 and
        /// Content-Type content headers as well as any content or request header with a name starting with "x-goog-".
        /// </para>
        /// <para>
        /// If <paramref name="request"/> is null, no headers are included in the signed URL's signature, so any requests
        /// made with the created URL must not contain Content-MD5, Content-Type, or any header starting with "x-goog-".
        /// </para>
        /// <para>
        /// Note that if the entity is encrypted with customer-supplied encryption keys (see
        /// https://cloud.google.com/storage/docs/encryption for more information), the <b>x-goog-encryption-algorithm</b>,
        /// <b>x-goog-encryption-key</b>, and <b>x-goog-encryption-key-sha256</b> headers will be required when making the
        /// request. However, only the x-goog-encryption-algorithm header is included in the signature for the signed URL.
        /// So the sample <paramref name="request"/> specified only needs to have the x-goog-encryption-algorithm request
        /// header. The other headers can be included, but will be ignored.
        /// </para>
        /// <para>
        /// Note that when GET is specified as the <paramref name="request"/>, both GET and HEAD requests can be made with
        /// the created signed URL.
        /// </para>
        /// <para>
        /// See https://cloud.google.com/storage/docs/access-control/signed-urls for more information on signed URLs.
        /// </para>
        /// </remarks>
        /// <param name="bucket">The name of the bucket. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. May be null, in which case the signed URL
        /// will refer to the bucket instead of an object.</param>
        /// <param name="expiration">The point in time after which the signed URL will be invalid. May be null, in which
        /// case the signed URL never expires.</param>
        /// <param name="request">A sample request for which the signed URL might be used. May be null.</param>
        /// <returns>
        /// The signed URL which can be used to provide access to a bucket or object for a limited amount of time.
        /// </returns>
        public string Sign(string bucket, string objectName, DateTimeOffset? expiration, HttpRequestMessage request) =>
            Sign(
                bucket,
                objectName,
                expiration,
                request?.Method,
                request?.Headers?.ToDictionary(h => h.Key, h => h.Value),
                request?.Content?.Headers?.ToDictionary(h => h.Key, h => h.Value));

        /// <summary>
        /// Creates a signed URL which can be used to provide limited access to specific buckets and objects to anyone
        /// in possession of the URL, regardless of whether they have a Google account.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When either of the headers collections are specified, there are certain headers which will be included in the
        /// signed URL's signature, and therefore must be included in requests made with the created URL. These are the
        /// Content-MD5 and Content-Type content headers as well as any content or request header with a name starting
        /// with "x-goog-".
        /// </para>
        /// <para>
        /// If the headers collections are null or empty, no headers are included in the signed URL's signature, so any
        /// requests made with the created URL must not contain Content-MD5, Content-Type, or any header starting with "x-goog-".
        /// </para>
        /// <para>
        /// Note that if the entity is encrypted with customer-supplied encryption keys (see
        /// https://cloud.google.com/storage/docs/encryption for more information), the <b>x-goog-encryption-algorithm</b>,
        /// <b>x-goog-encryption-key</b>, and <b>x-goog-encryption-key-sha256</b> headers will be required when making the
        /// request. However, only the x-goog-encryption-algorithm header is included in the signature for the signed URL.
        /// So the <paramref name="requestHeaders"/> specified only need to have the x-goog-encryption-algorithm header.
        /// The other headers can be included, but will be ignored.
        /// </para>
        /// <para>
        /// Note that when GET is specified as the <paramref name="requestMethod"/> (or it is null, in which case GET is
        /// used), both GET and HEAD requests can be made with the created signed URL.
        /// </para>
        /// <para>
        /// See https://cloud.google.com/storage/docs/access-control/signed-urls for more information on signed URLs.
        /// </para>
        /// </remarks>
        /// <param name="bucket">The name of the bucket. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. May be null, in which case the signed URL
        /// will refer to the bucket instead of an object.</param>
        /// <param name="duration">The length of time for which the signed URL should remain usable.</param>
        /// <param name="requestMethod">The HTTP request method for which the signed URL is allowed to be used. May be null,
        /// in which case GET will be used.</param>
        /// <param name="requestHeaders">The headers which will be included with the request. May be null.</param>
        /// <param name="contentHeaders">The headers for the content which will be included with the request.
        /// May be null.</param>
        /// <returns>
        /// The signed URL which can be used to provide access to a bucket or object for a limited amount of time.
        /// </returns>
        public string Sign(
            string bucket,
            string objectName,
            TimeSpan duration,
            HttpMethod requestMethod = null,
            Dictionary<string, IEnumerable<string>> requestHeaders = null,
            Dictionary<string, IEnumerable<string>> contentHeaders = null) =>
                Sign(
                    bucket,
                    objectName,
                    DateTimeOffset.UtcNow + duration,
                    requestMethod,
                    requestHeaders,
                    contentHeaders);

        /// <summary>
        /// Creates a signed URL which can be used to provide limited access to specific buckets and objects to anyone
        /// in possession of the URL, regardless of whether they have a Google account.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When either of the headers collections are specified, there are certain headers which will be included in the
        /// signed URL's signature, and therefore must be included in requests made with the created URL. These are the
        /// Content-MD5 and Content-Type content headers as well as any content or request header with a name starting
        /// with "x-goog-".
        /// </para>
        /// <para>
        /// If the headers collections are null or empty, no headers are included in the signed URL's signature, so any
        /// requests made with the created URL must not contain Content-MD5, Content-Type, or any header starting with "x-goog-".
        /// </para>
        /// <para>
        /// Note that if the entity is encrypted with customer-supplied encryption keys (see
        /// https://cloud.google.com/storage/docs/encryption for more information), the <b>x-goog-encryption-algorithm</b>,
        /// <b>x-goog-encryption-key</b>, and <b>x-goog-encryption-key-sha256</b> headers will be required when making the
        /// request. However, only the x-goog-encryption-algorithm header is included in the signature for the signed URL.
        /// So the <paramref name="requestHeaders"/> specified only need to have the x-goog-encryption-algorithm header.
        /// The other headers can be included, but will be ignored.
        /// </para>
        /// <para>
        /// Note that when GET is specified as the <paramref name="requestMethod"/> (or it is null, in which case GET is
        /// used), both GET and HEAD requests can be made with the created signed URL.
        /// </para>
        /// <para>
        /// See https://cloud.google.com/storage/docs/access-control/signed-urls for more information on signed URLs.
        /// </para>
        /// </remarks>
        /// <param name="bucket">The name of the bucket. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. May be null, in which case the signed URL
        /// will refer to the bucket instead of an object.</param>
        /// <param name="expiration">The point in time after which the signed URL will be invalid. May be null, in which
        /// case the signed URL never expires.</param>
        /// <param name="requestMethod">The HTTP request method for which the signed URL is allowed to be used. May be null,
        /// in which case GET will be used.</param>
        /// <param name="requestHeaders">The headers which will be included with the request. May be null.</param>
        /// <param name="contentHeaders">The headers for the content which will be included with the request.
        /// May be null.</param>
        /// <returns>
        /// The signed URL which can be used to provide access to a bucket or object for a limited amount of time.
        /// </returns>
        public string Sign(
            string bucket,
            string objectName,
            DateTimeOffset? expiration,
            HttpMethod requestMethod = null,
            Dictionary<string, IEnumerable<string>> requestHeaders = null,
            Dictionary<string, IEnumerable<string>> contentHeaders = null)
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

            var expiryUnixSeconds = ((int?)((expiration - UnixEpoch)?.TotalSeconds))?.ToString(CultureInfo.InvariantCulture);
            var resourcePath = $"/{bucket}";
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

            var signature = _credentials.CreateSignature(Encoding.UTF8.GetBytes(string.Join("\n", signatureLines)));

            var queryParameters = new List<string> { $"GoogleAccessId={_credentials.Id}" };
            if (expiryUnixSeconds != null)
            {
                queryParameters.Add($"Expires={expiryUnixSeconds}");
            }
            queryParameters.Add($"Signature={WebUtility.UrlEncode(signature)}");
            return $"{StorageHost}{resourcePath}?{string.Join("&", queryParameters)}";
        }

        private static SortedDictionary<string, StringBuilder> GetExtensionHeaders(
            Dictionary<string, IEnumerable<string>> requestHeaders,
            Dictionary<string, IEnumerable<string>> contentHeaders)
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
            Dictionary<string, IEnumerable<string>> headers,
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

                values.Append(string.Join(", ",
                    header.Value.Select(s => s.Trim().Replace("\r\n", "").Replace("\n", ""))));
            }
        }

        private static string GetFirstHeaderValue(Dictionary<string, IEnumerable<string>> contentHeaders, string name)
        {
            IEnumerable<string> values;
            if (contentHeaders != null && contentHeaders.TryGetValue(name, out values))
            {
                return values.FirstOrDefault();
            }
            return null;
        }
    }
}
