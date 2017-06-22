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

namespace Google.Cloud.Vision.V1
{
    public partial class Image
    {
        private static readonly HttpClient s_defaultHttpClient = new HttpClient();

        /// <summary>
        /// Constructs an <see cref="Image"/> with a <see cref="Image.Source"/> property referring to a URI,
        /// which may either be a Google Cloud Storage URI or a publicly accessible HTTP or HTTPS URI. The
        /// image is fetched from the URI by the Google Cloud Vision server.
        /// </summary>
        /// <param name="uri">The URI of the image, which may either be a Google Cloud Storage URI of the form <c>gs://bucket-name/file-name</c>
        /// or a publicly accessibly HTTP or HTTPS URI. Must not be null.</param>
        /// <returns>The newly created image.</returns>
        public static Image FromUri(string uri)
        {
            GaxPreconditions.CheckNotNull(uri, nameof(uri));
            return new Image { Source = new ImageSource { ImageUri = uri } };
        }

        /// <summary>
        /// Constructs an <see cref="Image"/> with a <see cref="Image.Source"/> property referring to a URI,
        /// which may either be a Google Cloud Storage URI or a publicly accessible HTTP or HTTPS URI. The
        /// image is fetched from the URI by the Google Cloud Vision server.
        /// </summary>
        /// <param name="uri">The URI of the image, which may either be a Google Cloud Storage URI of the form <c>gs://bucket-name/file-name</c>
        /// or a publicly accessibly HTTP or HTTPS URI. Must not be null.</param>
        /// <returns>The newly created image.</returns>
        public static Image FromUri(Uri uri)
        {
            GaxPreconditions.CheckNotNull(uri, nameof(uri));
            GaxPreconditions.CheckArgument(uri.IsAbsoluteUri, nameof(uri), "URI must be absolute");
            return new Image { Source = new ImageSource { ImageUri = uri.AbsoluteUri } };
        }

        /// <summary>
        /// Asynchronously constructs an <see cref="Image"/> by downloading data from the given URI.
        /// </summary>
        /// <remarks>
        /// <para>Unlike <see cref="FromUri(Uri)"/>, this method downloads the image locally then uploads
        /// it to the Google Cloud Vision server.</para>
        /// </remarks>
        /// <param name="uri">The URI to fetch. Must not be null.</param>
        /// <param name="httpClient">The <see cref="HttpClient"/> to use to fetch the image, or
        /// <c>null</c> to use a default client.</param>
        /// <returns>A task representing the asynchronous operation. The result will be the newly created image.</returns>
        public async static Task<Image> FetchFromUriAsync(Uri uri, HttpClient httpClient = null)
        {
            GaxPreconditions.CheckNotNull(uri, nameof(uri));
            httpClient = httpClient ?? s_defaultHttpClient;
            var bytes = await httpClient.GetByteArrayAsync(uri).ConfigureAwait(false);
            return FromBytes(bytes);
        }

        /// <summary>
        /// Asynchronously constructs an <see cref="Image"/> by downloading data from the given URI.
        /// </summary>
        /// <remarks>
        /// <para>Unlike <see cref="FromUri(Uri)"/>, this method downloads the image locally then uploads
        /// it to the Google Cloud Vision server.</para>
        /// </remarks>
        /// <param name="uri">The URI to fetch. Must not be null.</param>
        /// <param name="httpClient">The <see cref="HttpClient"/> to use to fetch the image, or
        /// <c>null</c> to use a default client.</param>
        /// <returns>A task representing the asynchronous operation. The result will be the newly created image.</returns>
        public async static Task<Image> FetchFromUriAsync(string uri, HttpClient httpClient = null)
        {
            GaxPreconditions.CheckNotNull(uri, nameof(uri));
            httpClient = httpClient ?? s_defaultHttpClient;
            var bytes = await httpClient.GetByteArrayAsync(uri).ConfigureAwait(false);
            return FromBytes(bytes);
        }

        // TODO: Find better synchronous HTTP fetching?

        /// <summary>
        /// Constructs an <see cref="Image"/> by downloading data from the given URI.
        /// </summary>
        /// <remarks>
        /// <para>Unlike <see cref="FromUri(string)"/>, this method downloads the image locally then uploads
        /// it to the Google Cloud Vision server.</para>
        /// </remarks>
        /// <param name="uri">The URI to fetch. Must not be null.</param>
        /// <param name="httpClient">The <see cref="HttpClient"/> to use to fetch the image, or
        /// <c>null</c> to use a default client.</param>
        /// <returns>The newly created image.</returns>
        public static Image FetchFromUri(string uri, HttpClient httpClient = null)
        {
            GaxPreconditions.CheckNotNull(uri, nameof(uri));
            return Task.Run(() => FetchFromUriAsync(uri, httpClient)).ResultWithUnwrappedExceptions();
        }

        /// <summary>
        /// Constructs an <see cref="Image"/> by downloading data from the given URI.
        /// </summary>
        /// <remarks>
        /// <para>Unlike <see cref="FromUri(string)"/>, this method downloads the image locally then uploads
        /// it to the Google Cloud Vision server.</para>
        /// </remarks>
        /// <param name="uri">The URI to fetch. Must not be null.</param>
        /// <param name="httpClient">The <see cref="HttpClient"/> to use to fetch the image, or
        /// <c>null</c> to use a default client.</param>
        /// <returns>The newly created image.</returns>
        public static Image FetchFromUri(Uri uri, HttpClient httpClient = null)
        {
            GaxPreconditions.CheckNotNull(uri, nameof(uri));
            // TODO: Use ResultWithUnwrappedExceptions when it's public in GAX.
            return Task.Run(() => FetchFromUriAsync(uri, httpClient)).ResultWithUnwrappedExceptions();
        }

        /// <summary>
        /// Constructs an <see cref="Image"/> by loading data from the given file path.
        /// </summary>
        /// <param name="path">The file path to load image data from. Must not be null.</param>
        /// <returns>The newly created image.</returns>
        public static Image FromFile(string path)
        {
            GaxPreconditions.CheckNotNull(path, nameof(path));
            return FromBytes(File.ReadAllBytes(path));
        }

        /// <summary>
        /// Asynchronously constructs an <see cref="Image"/> by loading data from the given file path.
        /// </summary>
        /// <param name="path">The file path to load image data from. Must not be null.</param>
        /// <returns>The newly created image.</returns>
        public static Task<Image> FromFileAsync(string path) =>
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
        /// Constructs an <see cref="Image"/> by loading data from the given stream.
        /// </summary>
        /// <param name="stream">The stream to load image data from. Must not be null.</param>
        /// <returns>The newly created image.</returns>
        public static Image FromStream(Stream stream)
        {
            GaxPreconditions.CheckNotNull(stream, nameof(stream));
            return new Image { Content = ByteString.FromStream(stream) };
        }

        /// <summary>
        /// Asynchronously constructs an <see cref="Image"/> by loading data from the given stream.
        /// </summary>
        /// <param name="stream">The stream to load image data from. Must not be null.</param>
        /// <returns>The newly created image.</returns>
        public static async Task<Image> FromStreamAsync(Stream stream)
        {
            GaxPreconditions.CheckNotNull(stream, nameof(stream));
            return new Image { Content = await ByteString.FromStreamAsync(stream).ConfigureAwait(false) };
        }

        /// <summary>
        /// Constructs an <see cref="Image"/> from the given byte array.
        /// </summary>
        /// <remarks>This method copies the data from the byte array; modifications to <paramref name="bytes"/>
        /// after this method returns will not be reflected in the image.</remarks>
        /// <param name="bytes">The bytes representing the raw image data.</param>
        /// <returns>The newly created image.</returns>
        public static Image FromBytes(byte[] bytes)
        {
            GaxPreconditions.CheckNotNull(bytes, nameof(bytes));
            return new Image { Content = ByteString.CopyFrom(bytes) };
        }

        /// <summary>
        /// Constructs an <see cref="Image"/> from a section of the given byte array.
        /// </summary>
        /// <remarks>This method copies the data from the byte array; modifications to <paramref name="bytes"/>
        /// after this method returns will not be reflected in the image.</remarks>
        /// <param name="bytes">The bytes representing the raw image data.</param>
        /// <param name="offset">The offset into the byte array of the start of the data to include in the image.</param>
        /// <param name="count">The number of bytes to include in the image.</param>
        /// <returns>The newly created image.</returns>
        public static Image FromBytes(byte[] bytes, int offset, int count)
        {
            GaxPreconditions.CheckNotNull(bytes, nameof(bytes));
            return new Image { Content = ByteString.CopyFrom(bytes, offset, count) };
        }
    }
}
