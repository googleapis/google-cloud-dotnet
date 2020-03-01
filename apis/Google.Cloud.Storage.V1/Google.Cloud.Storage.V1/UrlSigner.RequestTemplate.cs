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

using System.Collections.Generic;
using System.Net.Http;

namespace Google.Cloud.Storage.V1
{
    public sealed partial class UrlSigner
    {
        /// <summary>
        /// Represents the request template to be signed.
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
        /// Note that when GET is specified as the <see cref="HttpMethod"/> (or it is null, in which case GET is
        /// used), both GET and HEAD requests can be made with the created signed URL.
        /// </para>
        /// </remarks>
        public sealed class RequestTemplate
        {
            /// <summary>
            /// The name of the bucket. Won't be null.
            /// </summary>
            public string Bucket { get; }

            /// <summary>
            /// The name of the object within the bucket. May be null, in which case the signed URL
            /// will refer to the bucket instead of an object.
            /// </summary>
            public string ObjectName { get; }

            /// <summary>
            /// The HTTP request method for which the signed URL is allowed to be used.
            /// Won't be null. If null is specified in <see cref="WithObjectName(string)"/>
            /// then this value will be set to <see cref="HttpMethod.Get"/>.
            /// Will default to <see cref="HttpMethod.Get"/>.
            /// </summary>
            /// <remarks>
            /// <para>
            /// Note that when GET is specified as the <see cref="HttpMethod"/>, 
            /// both GET and HEAD requests can be made with the created signed URL.
            /// </para>
            /// </remarks>
            public HttpMethod HttpMethod { get; }

            /// <summary>
            /// The headers which will be included with the request. Won't be null.
            /// If null is specified in <see cref="WithRequestHeaders(IEnumerable{KeyValuePair{string, IEnumerable{string}}})"/>
            /// or <see cref="WithRequestHeaders(IReadOnlyDictionary{string, IReadOnlyCollection{string}})"/> then an empty
            /// dictionary will be used.
            /// </summary>
            /// <remarks>
            /// <para>
            /// When either of <see cref="RequestHeaders"/> or <see cref="ContentHeaders"/> are specified, there are certain 
            /// headers which will be included in the signed URL's signature, and therefore must be included in requests made 
            /// with the created URL. These are the Content-MD5 and Content-Type content headers as well as any content or 
            /// request header with a name starting with "x-goog-".
            /// </para>
            /// <para>
            /// If both <see cref="RequestHeaders"/> or <see cref="ContentHeaders"/> are null or empty, no headers are included 
            /// in the signed URL's signature, so any requests made with the created URL must not contain Content-MD5, Content-Type,
            /// or any header starting with "x-goog-".
            /// </para>
            /// <para>
            /// Note that if the entity is encrypted with customer-supplied encryption keys (see
            /// https://cloud.google.com/storage/docs/encryption for more information), the <b>x-goog-encryption-algorithm</b>,
            /// <b>x-goog-encryption-key</b>, and <b>x-goog-encryption-key-sha256</b> headers will be required when making the
            /// request. However, only the x-goog-encryption-algorithm header is included in the signature for the signed URL.
            /// So the <see cref="RequestHeaders"/> specified only need to have the x-goog-encryption-algorithm header.
            /// </para>
            /// </remarks>
            public IReadOnlyDictionary<string, IReadOnlyCollection<string>> RequestHeaders { get; }

            /// <summary>
            /// The headers for the content which will be included with the request. Won't be null.
            /// If null is specified in <see cref="WithContentHeaders(IEnumerable{KeyValuePair{string, IEnumerable{string}}})"/>
            /// or <see cref="WithContentHeaders(IReadOnlyDictionary{string, IReadOnlyCollection{string}})"/> then an empty
            /// dictionary will be used.
            /// </summary>
            /// <remarks>
            /// <para>
            /// When either of <see cref="RequestHeaders"/> or <see cref="ContentHeaders"/> are specified, there are certain 
            /// headers which will be included in the signed URL's signature, and therefore must be included in requests made 
            /// with the created URL. These are the Content-MD5 and Content-Type content headers as well as any content or 
            /// request header with a name starting with "x-goog-".
            /// </para>
            /// <para>
            /// If both <see cref="RequestHeaders"/> or <see cref="ContentHeaders"/> are null or empty, no headers are included 
            /// in the signed URL's signature, so any requests made with the created URL must not contain Content-MD5, Content-Type,
            /// or any header starting with "x-goog-".
            /// </para>
            /// </remarks>
            public IReadOnlyDictionary<string, IReadOnlyCollection<string>> ContentHeaders { get; }

            /// <summary>
            /// The query parameters which will be included with the request. Won't be null.
            /// If null is specified in <see cref="WithQueryParameters(IEnumerable{KeyValuePair{string, IEnumerable{string}}})"/>
            /// or <see cref="WithQueryParameters(IReadOnlyDictionary{string, IReadOnlyCollection{string}})"/> then an empty dictionary
            /// will be used.
            /// </summary>
            public IReadOnlyDictionary<string, IReadOnlyCollection<string>> QueryParameters { get; }

            private RequestTemplate(
                string bucket,
                string objectName,
                HttpMethod httpMethod,
                IReadOnlyDictionary<string, IReadOnlyCollection<string>> requestHeaders,
                IReadOnlyDictionary<string, IReadOnlyCollection<string>> contentHeaders,
                IReadOnlyDictionary<string, IReadOnlyCollection<string>> queryParameters)
            {
                Bucket = StorageClientImpl.ValidateBucketName(bucket);
                ObjectName = objectName;
                HttpMethod = httpMethod ?? HttpMethod.Get;
                RequestHeaders = requestHeaders ?? UrlSignerHelperExtensions.s_empty;
                ContentHeaders = contentHeaders ?? UrlSignerHelperExtensions.s_empty;
                QueryParameters = queryParameters ?? UrlSignerHelperExtensions.s_empty;
            }

            /// <summary>
            /// Creates a new request template to sign from the given bucket name.
            /// </summary>
            /// <param name="bucket">The name of the bucket for which the signed URL will be created.
            /// Must not be null.</param>
            /// <returns>A new request template.</returns>
            public static RequestTemplate FromBucket(string bucket) =>
                new RequestTemplate(bucket, null, null, null, null, null);

            /// <summary>
            /// Returns a new request template with all the same settings as this one
            /// except for the bucket name.
            /// </summary>
            /// <param name="bucket">The new bucket name. Must not be null.</param>
            /// <returns>A new request template.</returns>
            public RequestTemplate WithBucket(string bucket) =>
                new RequestTemplate(bucket, ObjectName, HttpMethod, RequestHeaders, ContentHeaders, QueryParameters);

            /// <summary>
            /// Returns a new request template with all the same settings as this one
            /// except for the object name.
            /// </summary>
            /// <param name="objectName">The new object name.  May be null, in which case the signed URL
            /// will refer to the bucket instead of an object.</param>
            /// <returns>A new request template.</returns>
            public RequestTemplate WithObjectName(string objectName) =>
                new RequestTemplate(Bucket, objectName, HttpMethod, RequestHeaders, ContentHeaders, QueryParameters);

            /// <summary>
            /// Returns a new request template with all the same settings as this one
            /// except for the HTTP method.
            /// </summary>
            /// <param name="method">The new HTTP method. May be null, in which case
            /// <see cref="HttpMethod.Get"/> will be used.</param>
            /// <returns>A new request template.</returns>
            public RequestTemplate WithHttpMethod(HttpMethod method) =>
                new RequestTemplate(Bucket, ObjectName, method, RequestHeaders, ContentHeaders, QueryParameters);

            /// <summary>
            /// Returns a new request template with all the same settings as this one
            /// except for the request headers.
            /// </summary>
            /// <param name="requestHeaders">The new request headers. May be null, in which case
            /// an empty collection will be used.</param>
            /// <returns>A new request template.</returns>
            public RequestTemplate WithRequestHeaders(IReadOnlyDictionary<string, IReadOnlyCollection<string>> requestHeaders) =>
                new RequestTemplate(Bucket, ObjectName, HttpMethod, requestHeaders, ContentHeaders, QueryParameters);

            /// <summary>
            /// Returns a new request template with all the same settings as this one
            /// except for the request headers.
            /// </summary>
            /// <param name="requestHeaders">The new request headers. May be null, in which case
            /// an empty collection will be used.</param>
            /// <returns>A new request template.</returns>
            public RequestTemplate WithRequestHeaders(IEnumerable<KeyValuePair<string, IEnumerable<string>>> requestHeaders) =>
                new RequestTemplate(Bucket, ObjectName, HttpMethod, requestHeaders.AsReadOnly(), ContentHeaders, QueryParameters);

            /// <summary>
            /// Returns a new request template with all the same settings as this one
            /// except for the content headers.
            /// </summary>
            /// <param name="contentHeaders">The new content headers. May be null, in which case
            /// an empty collection will be used.</param>
            /// <returns>A new request template.</returns>
            public RequestTemplate WithContentHeaders(IReadOnlyDictionary<string, IReadOnlyCollection<string>> contentHeaders) =>
                new RequestTemplate(Bucket, ObjectName, HttpMethod, RequestHeaders, contentHeaders, QueryParameters);

            /// <summary>
            /// Returns a new request template with all the same settings as this one
            /// except for the content headers.
            /// </summary>
            /// <param name="contentHeaders">The new content headers. May be null, in which case
            /// an empty collection will be used.</param>
            /// <returns>A new request template.</returns>
            public RequestTemplate WithContentHeaders(IEnumerable<KeyValuePair<string, IEnumerable<string>>> contentHeaders) =>
                new RequestTemplate(Bucket, ObjectName, HttpMethod, RequestHeaders, contentHeaders.AsReadOnly(), QueryParameters);

            /// <summary>
            /// Returns a new request template with all the same settings as this one
            /// except for the query parameters.
            /// </summary>
            /// <param name="queryParameters">The new query parameters. May be null, in which case
            /// an empty collection will be used.</param>
            /// <returns>A new request template.</returns>
            public RequestTemplate WithQueryParameters(IReadOnlyDictionary<string, IReadOnlyCollection<string>> queryParameters) =>
                new RequestTemplate(Bucket, ObjectName, HttpMethod, RequestHeaders, ContentHeaders, queryParameters);

            /// <summary>
            /// Returns a new request template with all the same settings as this one
            /// except for the query parameters.
            /// </summary>
            /// <param name="queryParameters">The new query parameters. May be null, in which case
            /// an empty collection will be used.</param>
            /// <returns>A new request template.</returns>
            public RequestTemplate WithQueryParameters(IEnumerable<KeyValuePair<string, IEnumerable<string>>> queryParameters) =>
                new RequestTemplate(Bucket, ObjectName, HttpMethod, RequestHeaders, ContentHeaders, queryParameters.AsReadOnly());

            /// <summary>
            /// Returns a new request template with all the same settings as this one
            /// except for all the information that can be obtained from <paramref name="requestMessage"/>,
            /// that is the HTTP method, the request headers and the content headers.
            /// </summary>
            /// <param name="requestMessage">The new request message. May be null, in which case
            /// the default values for all the affected properties will be used..</param>
            /// <returns>A new request template.</returns>
            public RequestTemplate WithHttpRequestMessage(HttpRequestMessage requestMessage) =>
                new RequestTemplate(
                    Bucket,
                    ObjectName,
                    requestMessage?.Method,
                    requestMessage?.Headers.AsReadOnly(),
                    requestMessage?.Content?.Headers.AsReadOnly(),
                    requestMessage?.RequestUri.QueryAsReadOnly());
        }
    }
}
