// Copyright 2016 Google Inc. All Rights Reserved.
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
using Google.Protobuf;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Google.Cloud.Speech.V1
{
    public partial class RecognitionAudio
    {
        private static readonly HttpClient s_defaultHttpClient = new HttpClient();

        /// <summary>
        /// Constructs a <see cref="RecognitionAudio"/> with a <see cref="Uri"/> property referring to a Google Cloud
        /// Storage URI.
        /// </summary>
        /// <param name="storageUri">A Google Cloud Storage URI, of the form <c>gs://bucket-name/object-name</c>. Must not be null.</param>
        /// <returns>The newly created RecognitionAudio.</returns>
        public static RecognitionAudio FromStorageUri(string storageUri)
        {
            GaxPreconditions.CheckNotNull(storageUri, nameof(storageUri));
            // TODO: Validate that it looks like gs://bucket/object
            return new RecognitionAudio { Uri = storageUri };
        }

        /// <summary>
        /// Asynchronously constructs a <see cref="RecognitionAudio"/> by downloading data from the given URI.
        /// </summary>
        /// <param name="uri">The URI to fetch. Must not be null.</param>
        /// <param name="httpClient">The <see cref="HttpClient"/> to use to fetch the image, or
        /// <c>null</c> to use a default client.</param>
        /// <returns>A task representing the asynchronous operation. The result will be the newly created RecognitionAudio.</returns>
        public async static Task<RecognitionAudio> FetchFromUriAsync(Uri uri, HttpClient httpClient = null)
        {
            GaxPreconditions.CheckNotNull(uri, nameof(uri));
            httpClient = httpClient ?? s_defaultHttpClient;
            var bytes = await httpClient.GetByteArrayAsync(uri).ConfigureAwait(false);
            return FromBytes(bytes);
        }

        /// <summary>
        /// Asynchronously constructs a <see cref="RecognitionAudio"/> by downloading data from the given URI.
        /// </summary>
        /// <param name="uri">The URI to fetch. Must not be null.</param>
        /// <param name="httpClient">The <see cref="HttpClient"/> to use to fetch the image, or
        /// <c>null</c> to use a default client.</param>
        /// <returns>A task representing the asynchronous operation. The result will be the newly created RecognitionAudio.</returns>
        public async static Task<RecognitionAudio> FetchFromUriAsync(string uri, HttpClient httpClient = null)
        {
            GaxPreconditions.CheckNotNull(uri, nameof(uri));
            httpClient = httpClient ?? s_defaultHttpClient;
            var bytes = await httpClient.GetByteArrayAsync(uri).ConfigureAwait(false);
            return FromBytes(bytes);
        }

        // TODO: Find better synchronous HTTP fetching?

        /// <summary>
        /// Constructs a <see cref="RecognitionAudio"/> by downloading data from the given URI.
        /// </summary>
        /// <param name="uri">The URI to fetch. Must not be null.</param>
        /// <param name="httpClient">The <see cref="HttpClient"/> to use to fetch the image, or
        /// <c>null</c> to use a default client.</param>
        /// <returns>The newly created RecognitionAudio.</returns>
        public static RecognitionAudio FetchFromUri(string uri, HttpClient httpClient = null)
        {
            GaxPreconditions.CheckNotNull(uri, nameof(uri));
            return Task.Run(() => FetchFromUriAsync(uri, httpClient)).ResultWithUnwrappedExceptions();
        }

        /// <summary>
        /// Constructs a <see cref="RecognitionAudio"/> by downloading data from the given URI.
        /// </summary>
        /// <param name="uri">The URI to fetch. Must not be null.</param>
        /// <param name="httpClient">The <see cref="HttpClient"/> to use to fetch the image, or
        /// <c>null</c> to use a default client.</param>
        /// <returns>The newly created RecognitionAudio.</returns>
        public static RecognitionAudio FetchFromUri(Uri uri, HttpClient httpClient = null)
        {
            GaxPreconditions.CheckNotNull(uri, nameof(uri));
            return Task.Run(() => FetchFromUriAsync(uri, httpClient)).ResultWithUnwrappedExceptions();
        }

        /// <summary>
        /// Constructs a <see cref="RecognitionAudio"/> by loading data from the given file path.
        /// </summary>
        /// <param name="path">The file path to load RecognitionAudio data from. Must not be null.</param>
        /// <returns>The newly created RecognitionAudio.</returns>
        public static RecognitionAudio FromFile(string path)
        {
            GaxPreconditions.CheckNotNull(path, nameof(path));
            return FromBytes(File.ReadAllBytes(path));
        }

        /// <summary>
        /// Asynchronously constructs a <see cref="RecognitionAudio"/> by loading data from the given file path.
        /// </summary>
        /// <param name="path">The file path to load RecognitionAudio data from. Must not be null.</param>
        /// <returns>The newly created RecognitionAudio.</returns>
        public static Task<RecognitionAudio> FromFileAsync(string path) =>
            // We don't want any file system access to occur synchronously, including opening.
            // The ConfigureAwait(false) inside is unnecessary but harmless.
            Task.Run(async () =>
            {
                GaxPreconditions.CheckNotNull(path, nameof(path));
                using (var input = File.OpenRead(path))
                {
                    return await FromStreamAsync(input).ConfigureAwait(false);
                }
            });

        /// <summary>
        /// Constructs a <see cref="RecognitionAudio"/> by loading data from the given stream.
        /// </summary>
        /// <param name="stream">The stream to load RecognitionAudio data from. Must not be null.</param>
        /// <returns>The newly created RecognitionAudio.</returns>
        public static RecognitionAudio FromStream(Stream stream)
        {
            GaxPreconditions.CheckNotNull(stream, nameof(stream));
            return new RecognitionAudio { Content = ByteString.FromStream(stream) };
        }

        /// <summary>
        /// Asynchronously constructs a <see cref="RecognitionAudio"/> by loading data from the given stream.
        /// </summary>
        /// <param name="stream">The stream to load RecognitionAudio data from. Must not be null.</param>
        /// <returns>The newly created RecognitionAudio.</returns>
        public static async Task<RecognitionAudio> FromStreamAsync(Stream stream)
        {
            GaxPreconditions.CheckNotNull(stream, nameof(stream));
            return new RecognitionAudio { Content = await ByteString.FromStreamAsync(stream).ConfigureAwait(false) };
        }

        /// <summary>
        /// Constructs a <see cref="RecognitionAudio"/> from the given byte array.
        /// </summary>
        /// <remarks>This method copies the data from the byte array; modifications to <paramref name="bytes"/>
        /// after this method returns will not be reflected in the RecognitionAudio.</remarks>
        /// <param name="bytes">The bytes representing the raw RecognitionAudio data.</param>
        /// <returns>The newly created RecognitionAudio.</returns>
        public static RecognitionAudio FromBytes(byte[] bytes)
        {
            GaxPreconditions.CheckNotNull(bytes, nameof(bytes));
            return new RecognitionAudio { Content = ByteString.CopyFrom(bytes) };
        }

        /// <summary>
        /// Constructs a <see cref="RecognitionAudio"/> from a section of the given byte array.
        /// </summary>
        /// <remarks>This method copies the data from the byte array; modifications to <paramref name="bytes"/>
        /// after this method returns will not be reflected in the RecognitionAudio.</remarks>
        /// <param name="bytes">The bytes representing the raw RecognitionAudio data.</param>
        /// <param name="offset">The offset into the byte array of the start of the data to include in the RecognitionAudio.</param>
        /// <param name="count">The number of bytes to include in the RecognitionAudio.</param>
        /// <returns>The newly created RecognitionAudio.</returns>
        public static RecognitionAudio FromBytes(byte[] bytes, int offset, int count)
        {
            GaxPreconditions.CheckNotNull(bytes, nameof(bytes));
            return new RecognitionAudio { Content = ByteString.CopyFrom(bytes, offset, count) };
        }
    }
}
