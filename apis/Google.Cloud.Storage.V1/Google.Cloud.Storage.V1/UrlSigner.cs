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
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Class which helps create signed URLs which can be used to provide limited access to specific buckets and objects
    /// to anyone in possession of the URL, regardless of whether they have a Google account.
    /// </summary>
    /// <remarks>
    /// See https://cloud.google.com/storage/docs/access-control/signed-urls for more information on signed URLs.
    /// </remarks>
    public sealed partial class UrlSigner
    {
        private const string InfiniteExpiryObsoleteMessage =
            "This overload is obsolete, as non-expiring signed URLs are a bug in the service that can cause security issues and should no longer be used. Please use the overload accepting a DateTimeOffset instead.";

        private static readonly ISigner s_v2Signer = new V2Signer();
        private static readonly ISigner s_v4Signer = new V4Signer();

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
        private static readonly DateTimeOffset MaxExpiration = UnixEpoch.AddSeconds(int.MaxValue);

        private readonly IBlobSigner _blobSigner;
        private readonly SigningVersion _signingVersion;
        private readonly IClock _clock;

        private UrlSigner(IBlobSigner blobSigner, SigningVersion signingVersion, IClock clock)
        {
            _blobSigner = blobSigner;
            _signingVersion = signingVersion;
            _clock = clock;
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
            return new UrlSigner(new ServiceAccountCredentialBlobSigner(credential), SigningVersion.Default, SystemClock.Instance);
        }

        /// <summary>
        /// Creates a new <see cref="UrlSigner"/> instance for a custom blob signer.
        /// </summary>
        /// <remarks>
        /// This method is typically used when a service account credential file isn't available, either
        /// for testing or to use the IAM service's blob signing capabilities.
        /// </remarks>
        /// <param name="signer">The blob signer to use. Must not be null.</param>
        /// <returns>A new <see cref="UrlSigner"/> using the specified blob signer.</returns>
        public static UrlSigner FromBlobSigner(IBlobSigner signer)
        {
            GaxPreconditions.CheckNotNull(signer, nameof(signer));
            return new UrlSigner(signer, SigningVersion.Default, SystemClock.Instance);
        }

        /// <summary>
        /// Returns a new instance of <see cref="UrlSigner"/> using the same signing source (e.g. a service account
        /// private key) but with the specified URL signing algorithm version.
        /// </summary>
        /// <param name="signingVersion">The algorithm version to use when signing URLs.</param>
        /// <returns>A new instance using the specified version.</returns>
        public UrlSigner WithSigningVersion(SigningVersion signingVersion)
        {
            GaxPreconditions.CheckEnumValue(signingVersion, nameof(signingVersion));
            return new UrlSigner(_blobSigner, signingVersion, _clock);
        }

        /// <summary>
        /// Only available for testing purposes, this allows the clock used for signature generation to be replaced.
        /// </summary>
        internal UrlSigner WithClock(IClock clock) => new UrlSigner(_blobSigner, _signingVersion, clock);

        /// <summary>
        /// Creates a signed URL which can be used to provide limited access to specific buckets and objects to anyone
        /// in possession of the URL, regardless of whether they have a Google account.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When a <see cref="UrlSigner"/> is created with a service account credential, the signing can be performed
        /// with no network access. When it is created with an implementation of <see cref="IBlobSigner"/>, that may require
        /// network access or other IO. In that case, one of the asynchronous methods should be used when the caller is
        /// in a context that should not block.
        /// </para>
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
            Sign(bucket, objectName, _clock.GetCurrentDateTimeUtc() + duration, request);

        /// <summary>
        /// Creates a signed URL which can be used to provide limited access to specific buckets and objects to anyone
        /// in possession of the URL, regardless of whether they have a Google account.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When a <see cref="UrlSigner"/> is created with a service account credential, the signing can be performed
        /// with no network access. When it is created with an implementation of <see cref="IBlobSigner"/>, that may require
        /// network access or other IO. In that case, one of the asynchronous methods should be used when the caller is
        /// in a context that should not block.
        /// </para>
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
        /// <para>
        /// Note that if a null value is passed for <paramref name="expiration"/>, an expiry date of 2038 is used.
        /// This is the maximum date that can be represented as an expiry date.
        /// This behavior maintains as much compatibility as possible with previous versions of this library, but ensures that
        /// an expiry date is always provided, in-keeping with server-side requirements.
        /// </para>
        /// </remarks>
        /// <param name="bucket">The name of the bucket. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. May be null, in which case the signed URL
        /// will refer to the bucket instead of an object.</param>
        /// <param name="expiration">The point in time after which the signed URL will be invalid. May be null, in which
        /// case the signed URL expires in 2038.</param>
        /// <param name="request">A sample request for which the signed URL might be used. May be null.</param>
        /// <returns>
        /// The signed URL which can be used to provide access to a bucket or object for a limited amount of time.
        /// </returns>
        [Obsolete(InfiniteExpiryObsoleteMessage)]
        public string Sign(string bucket, string objectName, DateTimeOffset? expiration, HttpRequestMessage request) =>
            Sign(bucket, objectName, expiration ?? MaxExpiration, request);

        /// <summary>
        /// Creates a signed URL which can be used to provide limited access to specific buckets and objects to anyone
        /// in possession of the URL, regardless of whether they have a Google account.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When a <see cref="UrlSigner"/> is created with a service account credential, the signing can be performed
        /// with no network access. When it is created with an implementation of <see cref="IBlobSigner"/>, that may require
        /// network access or other IO. In that case, one of the asynchronous methods should be used when the caller is
        /// in a context that should not block.
        /// </para>
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
        /// <param name="expiration">The point in time after which the signed URL will be invalid.</param>
        /// <param name="request">A sample request for which the signed URL might be used. May be null.</param>
        /// <returns>
        /// The signed URL which can be used to provide access to a bucket or object for a limited amount of time.
        /// </returns>
        public string Sign(string bucket, string objectName, DateTimeOffset expiration, HttpRequestMessage request) =>
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
        /// When a <see cref="UrlSigner"/> is created with a service account credential, the signing can be performed
        /// with no network access. When it is created with an implementation of <see cref="IBlobSigner"/>, that may require
        /// network access or other IO. In that case, one of the asynchronous methods should be used when the caller is
        /// in a context that should not block.
        /// </para>
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
                    _clock.GetCurrentDateTimeUtc() + duration,
                    requestMethod,
                    requestHeaders,
                    contentHeaders);

        /// <summary>
        /// Creates a signed URL which can be used to provide limited access to specific buckets and objects to anyone
        /// in possession of the URL, regardless of whether they have a Google account.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When a <see cref="UrlSigner"/> is created with a service account credential, the signing can be performed
        /// with no network access. When it is created with an implementation of <see cref="IBlobSigner"/>, that may require
        /// network access or other IO. In that case, one of the asynchronous methods should be used when the caller is
        /// in a context that should not block.
        /// </para>
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
        /// <para>
        /// Note that if a null value is passed for <paramref name="expiration"/>, an expiry date of 2038 is used.
        /// This is the maximum date that can be represented as an expiry date.
        /// This behavior maintains as much compatibility as possible with previous versions of this library, but ensures that
        /// an expiry date is always provided, in-keeping with server-side requirements.
        /// </para>
        /// </remarks>
        /// <param name="bucket">The name of the bucket. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. May be null, in which case the signed URL
        /// will refer to the bucket instead of an object.</param>
        /// <param name="expiration">The point in time after which the signed URL will be invalid. May be null, in which
        /// case the signed URL expires in 2038.</param>
        /// <param name="requestMethod">The HTTP request method for which the signed URL is allowed to be used. May be null,
        /// in which case GET will be used.</param>
        /// <param name="requestHeaders">The headers which will be included with the request. May be null.</param>
        /// <param name="contentHeaders">The headers for the content which will be included with the request.
        /// May be null.</param>
        /// <returns>
        /// The signed URL which can be used to provide access to a bucket or object for a limited amount of time.
        /// </returns>
        [Obsolete(InfiniteExpiryObsoleteMessage)]
        public string Sign(
            string bucket,
            string objectName,
            DateTimeOffset? expiration,
            HttpMethod requestMethod = null,
            Dictionary<string, IEnumerable<string>> requestHeaders = null,
            Dictionary<string, IEnumerable<string>> contentHeaders = null) =>
            Sign(bucket, objectName, expiration ?? MaxExpiration, requestMethod, requestHeaders, contentHeaders);

        /// <summary>
        /// Creates a signed URL which can be used to provide limited access to specific buckets and objects to anyone
        /// in possession of the URL, regardless of whether they have a Google account.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When a <see cref="UrlSigner"/> is created with a service account credential, the signing can be performed
        /// with no network access. When it is created with an implementation of <see cref="IBlobSigner"/>, that may require
        /// network access or other IO. In that case, one of the asynchronous methods should be used when the caller is
        /// in a context that should not block.
        /// </para>
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
        /// <param name="expiration">The point in time after which the signed URL will be invalid.</param>
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
            DateTimeOffset expiration,
            HttpMethod requestMethod = null,
            Dictionary<string, IEnumerable<string>> requestHeaders = null,
            Dictionary<string, IEnumerable<string>> contentHeaders = null) =>
            GetEffectiveSigner().Sign(bucket, objectName, expiration, requestMethod, requestHeaders, contentHeaders, _blobSigner, _clock);

        /// <summary>
        /// Asynchronously creates a signed URL which can be used to provide limited access to specific buckets and objects to anyone
        /// in possession of the URL, regardless of whether they have a Google account.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When a <see cref="UrlSigner"/> is created with a service account credential, the signing can be performed
        /// with no network access. When it is created with an implementation of <see cref="IBlobSigner"/>, that may require
        /// network access or other IO. In that case, one of the asynchronous methods should be used when the caller is
        /// in a context that should not block.
        /// </para>
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
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>
        /// A task representing the asynchronous operation, with a result returning the
        /// signed URL which can be used to provide access to a bucket or object for a limited amount of time.
        /// </returns>
        public Task<string> SignAsync(string bucket, string objectName, TimeSpan duration, HttpRequestMessage request, CancellationToken cancellationToken = default) =>
            SignAsync(bucket, objectName, _clock.GetCurrentDateTimeUtc() + duration, request, cancellationToken);

        /// <summary>
        /// Asynchronously creates a signed URL which can be used to provide limited access to specific buckets and objects to anyone
        /// in possession of the URL, regardless of whether they have a Google account.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When a <see cref="UrlSigner"/> is created with a service account credential, the signing can be performed
        /// with no network access. When it is created with an implementation of <see cref="IBlobSigner"/>, that may require
        /// network access or other IO. In that case, one of the asynchronous methods should be used when the caller is
        /// in a context that should not block.
        /// </para>
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
        /// <para>
        /// Note that if a null value is passed for <paramref name="expiration"/>, an expiry date of 2038 is used.
        /// This is the maximum date that can be represented as an expiry date.
        /// This behavior maintains as much compatibility as possible with previous versions of this library, but ensures that
        /// an expiry date is always provided, in-keeping with server-side requirements.
        /// </para>
        /// </remarks>
        /// <param name="bucket">The name of the bucket. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. May be null, in which case the signed URL
        /// will refer to the bucket instead of an object.</param>
        /// <param name="expiration">The point in time after which the signed URL will be invalid. May be null, in which
        /// case the signed URL expires in 2038.</param>
        /// <param name="request">A sample request for which the signed URL might be used. May be null.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>
        /// A task representing the asynchronous operation, with a result returning the
        /// signed URL which can be used to provide access to a bucket or object for a limited amount of time.
        /// </returns>
        [Obsolete(InfiniteExpiryObsoleteMessage)]
        public Task<string> SignAsync(string bucket, string objectName, DateTimeOffset? expiration, HttpRequestMessage request, CancellationToken cancellationToken = default) =>
            SignAsync(bucket, objectName, expiration ?? MaxExpiration, request, cancellationToken);

        /// <summary>
        /// Asynchronously creates a signed URL which can be used to provide limited access to specific buckets and objects to anyone
        /// in possession of the URL, regardless of whether they have a Google account.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When a <see cref="UrlSigner"/> is created with a service account credential, the signing can be performed
        /// with no network access. When it is created with an implementation of <see cref="IBlobSigner"/>, that may require
        /// network access or other IO. In that case, one of the asynchronous methods should be used when the caller is
        /// in a context that should not block.
        /// </para>
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
        /// <param name="expiration">The point in time after which the signed URL will be invalid.</param>
        /// <param name="request">A sample request for which the signed URL might be used. May be null.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>
        /// A task representing the asynchronous operation, with a result returning the
        /// signed URL which can be used to provide access to a bucket or object for a limited amount of time.
        /// </returns>
        public Task<string> SignAsync(string bucket, string objectName, DateTimeOffset expiration, HttpRequestMessage request, CancellationToken cancellationToken = default) =>
            SignAsync(
                bucket,
                objectName,
                expiration,
                request?.Method,
                request?.Headers?.ToDictionary(h => h.Key, h => h.Value),
                request?.Content?.Headers?.ToDictionary(h => h.Key, h => h.Value),
                cancellationToken);

        /// <summary>
        /// Asynchronously creates a signed URL which can be used to provide limited access to specific buckets and objects to anyone
        /// in possession of the URL, regardless of whether they have a Google account.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When a <see cref="UrlSigner"/> is created with a service account credential, the signing can be performed
        /// with no network access. When it is created with an implementation of <see cref="IBlobSigner"/>, that may require
        /// network access or other IO. In that case, one of the asynchronous methods should be used when the caller is
        /// in a context that should not block.
        /// </para>
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
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>
        /// A task representing the asynchronous operation, with a result returning the
        /// signed URL which can be used to provide access to a bucket or object for a limited amount of time.
        /// </returns>
        public Task<string> SignAsync(
            string bucket,
            string objectName,
            TimeSpan duration,
            HttpMethod requestMethod = null,
            Dictionary<string, IEnumerable<string>> requestHeaders = null,
            Dictionary<string, IEnumerable<string>> contentHeaders = null,
            CancellationToken cancellationToken = default) =>
                SignAsync(
                    bucket,
                    objectName,
                    _clock.GetCurrentDateTimeUtc() + duration,
                    requestMethod,
                    requestHeaders,
                    contentHeaders,
                    cancellationToken);

        /// <summary>
        /// Asynchronously creates a signed URL which can be used to provide limited access to specific buckets and objects to anyone
        /// in possession of the URL, regardless of whether they have a Google account.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When a <see cref="UrlSigner"/> is created with a service account credential, the signing can be performed
        /// with no network access. When it is created with an implementation of <see cref="IBlobSigner"/>, that may require
        /// network access or other IO. In that case, one of the asynchronous methods should be used when the caller is
        /// in a context that should not block.
        /// </para>
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
        /// <para>
        /// Note that if a null value is passed for <paramref name="expiration"/>, an expiry date of 2038 is used.
        /// This is the maximum date that can be represented as an expiry date.
        /// This behavior maintains as much compatibility as possible with previous versions of this library, but ensures that
        /// an expiry date is always provided, in-keeping with server-side requirements.
        /// </para>
        /// </remarks>
        /// <param name="bucket">The name of the bucket. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. May be null, in which case the signed URL
        /// will refer to the bucket instead of an object.</param>
        /// <param name="expiration">The point in time after which the signed URL will be invalid. May be null, in which
        /// case the signed URL expires in 2038.</param>
        /// <param name="requestMethod">The HTTP request method for which the signed URL is allowed to be used. May be null,
        /// in which case GET will be used.</param>
        /// <param name="requestHeaders">The headers which will be included with the request. May be null.</param>
        /// <param name="contentHeaders">The headers for the content which will be included with the request.
        /// May be null.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>
        /// A task representing the asynchronous operation, with a result returning the
        /// signed URL which can be used to provide access to a bucket or object for a limited amount of time.
        /// </returns>
        [Obsolete(InfiniteExpiryObsoleteMessage)]
        public Task<string> SignAsync(
            string bucket,
            string objectName,
            DateTimeOffset? expiration,
            HttpMethod requestMethod = null,
            Dictionary<string, IEnumerable<string>> requestHeaders = null,
            Dictionary<string, IEnumerable<string>> contentHeaders = null,
            CancellationToken cancellationToken = default) =>
            SignAsync(bucket, objectName, expiration ?? MaxExpiration, requestMethod, requestHeaders, contentHeaders, cancellationToken);

        /// <summary>
        /// Asynchronously creates a signed URL which can be used to provide limited access to specific buckets and objects to anyone
        /// in possession of the URL, regardless of whether they have a Google account.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When a <see cref="UrlSigner"/> is created with a service account credential, the signing can be performed
        /// with no network access. When it is created with an implementation of <see cref="IBlobSigner"/>, that may require
        /// network access or other IO. In that case, one of the asynchronous methods should be used when the caller is
        /// in a context that should not block.
        /// </para>
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
        /// <param name="expiration">The point in time after which the signed URL will be invalid.</param>
        /// <param name="requestMethod">The HTTP request method for which the signed URL is allowed to be used. May be null,
        /// in which case GET will be used.</param>
        /// <param name="requestHeaders">The headers which will be included with the request. May be null.</param>
        /// <param name="contentHeaders">The headers for the content which will be included with the request.
        /// May be null.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>
        /// A task representing the asynchronous operation, with a result returning the
        /// signed URL which can be used to provide access to a bucket or object for a limited amount of time.
        /// </returns>
        public Task<string> SignAsync(
            string bucket,
            string objectName,
            DateTimeOffset expiration,
            HttpMethod requestMethod = null,
            Dictionary<string, IEnumerable<string>> requestHeaders = null,
            Dictionary<string, IEnumerable<string>> contentHeaders = null,
            CancellationToken cancellationToken = default) =>
            GetEffectiveSigner().SignAsync(bucket, objectName, expiration, requestMethod, requestHeaders, contentHeaders, _blobSigner, _clock, cancellationToken);

        private ISigner GetEffectiveSigner()
        {
            switch (_signingVersion)
            {
                case SigningVersion.Default:
                    return s_v2Signer;
                case SigningVersion.V2:
                    return s_v2Signer;
                case SigningVersion.V4:
                    return s_v4Signer;
                default:
                    // We really shouldn't get here, as we validate any user-specified signing version.
                    throw new InvalidOperationException($"Invalid signing version: {_signingVersion}");
            }
        }

        private static readonly Regex s_newlineRegex = new Regex(@"\r?\n", RegexOptions.Compiled);
        private static readonly Regex s_whitespaceRegex = new Regex(@"\s+", RegexOptions.Compiled);

        /// <summary>
        /// Prepares a header value for signing, trimming both ends and collapsing internal whitespace.
        /// </summary>
        private static string PrepareHeaderValue(string value)
        {
            // Remove leading/trailing whitespace
            value = value.Trim();

            // Collapse whitespace runs: only keep the last character
            value = s_whitespaceRegex.Replace(value, match => match.Value[match.Value.Length - 1].ToString());

            // Remove newlines
            value = s_newlineRegex.Replace(value, "");

            return value;
        }

    }
}
