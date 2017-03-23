// Copyright 2017 Google Inc. All Rights Reserved.
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
using Google.Apis.Upload;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Class which can perform a resumable upload using a signed URL to initiate the session.
    /// </summary>
    /// <seealso cref="UrlSigner"/>
    public sealed class SignedUrlResumableUpload : ResumableUpload
    {
        private string SignedUrl { get; set; }

        private SignedUrlResumableUpload(string signedUrl, Stream contentStream, ResumableUploadOptions options)
            : base(contentStream, options)
        {
            SignedUrl = signedUrl;
        }

        /// <summary>
        /// Creates a <see cref="SignedUrlResumableUpload"/> instance.
        /// </summary>
        /// <param name="signedUrl">
        /// The signed URL which can be used to initiate a resumable upload session. See
        /// <see cref="UrlSigner.ResumableHttpMethod">UrlSigner.ResumableHttpMethod</see> for more information.
        /// </param>
        /// <param name="contentStream">The data to be uploaded.</param>
        /// <param name="options">The options for the upload operation.</param>
        /// <returns>The instance which can be used to upload the specified content.</returns>
        public static SignedUrlResumableUpload Create(
            string signedUrl,
            Stream contentStream,
            ResumableUploadOptions options = null)
        {
            return new SignedUrlResumableUpload(
                GaxPreconditions.CheckNotNull(signedUrl, nameof(signedUrl)),
                contentStream,
                options);
        }

        /// <inheritdoc/>
        public override async Task<Uri> InitiateSessionAsync(CancellationToken cancellationToken)
        {
            var httpClient = Options?.HttpClient ?? new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, SignedUrl);

            // The request may auto-populate the Content-Type to be "application/x-www-form-urlencoded",
            // so force it to be null so it is not auto-populated.
            request.Content = new ByteArrayContent(new byte[0]);
            request.Content.Headers.ContentType = null;

            request.Headers.Add("x-goog-resumable", "start");
            Options?.ModifySessionInitiationRequest?.Invoke(request);
            var result = await httpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
            if (!result.IsSuccessStatusCode)
            {
                throw await ExceptionForResponseAsync(result).ConfigureAwait(false);
            }
            return result.Headers.Location;
        }

        /// <summary>
        /// Initiates the resumable upload session by posting to the signed URL and returns the session URI.
        /// </summary>
        /// <param name="signedUrl">
        /// The signed URL which can be used to initiate a resumable upload session. See
        /// <see cref="UrlSigner.ResumableHttpMethod">UrlSigner.ResumableHttpMethod</see> for more information.
        /// </param>
        /// <param name="options">The options for the upload operation.</param>
        /// <returns>
        /// The session URI to use for the resumable upload.
        /// </returns>
        public static Uri InitiateSession(string signedUrl, ResumableUploadOptions options = null) =>
            InitiateSessionAsync(signedUrl, options).ResultWithUnwrappedExceptions();

        /// <summary>
        /// Initiates the resumable upload session by posting to the signed URL and returns the session URI.
        /// </summary>
        /// <param name="signedUrl">
        /// The signed URL which can be used to initiate a resumable upload session. See
        /// <see cref="UrlSigner.ResumableHttpMethod">UrlSigner.ResumableHttpMethod</see> for more information.
        /// </param>
        /// <param name="options">The options for the upload operation.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>
        /// A task containing the session URI to use for the resumable upload.
        /// </returns>
        public static Task<Uri> InitiateSessionAsync(
            string signedUrl,
            ResumableUploadOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            // We need an instance to call ExceptionForResponseAsync if the initiate request fails, so create a
            // temporary instance to initiate the session.
            var uploader = new SignedUrlResumableUpload(signedUrl, new MemoryStream(), options);
            return uploader.InitiateSessionAsync(cancellationToken);
        }
    }
}
