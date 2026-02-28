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

using Google.Apis.Http;
using Google.Apis.Services;
using Google.Apis.Upload;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using static Google.Apis.Storage.v1.ObjectsResource;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Upload subclass which allows us to modify headers, for customer-supplied encryption keys.
    /// </summary>
    internal sealed class CustomMediaUpload : InsertMediaUpload
    {
        private readonly Stream _stream;
        private readonly Crc32cHashInterceptor _interceptor;
        private readonly IClientService _service;

        public CustomMediaUpload(IClientService service, Apis.Storage.v1.Data.Object body, string bucket,
            Stream stream, string contentType)
            : base(service, body, bucket, stream, contentType)
        {
            _stream = stream;
            _service = service;
            _interceptor = new Crc32cHashInterceptor(this, _stream, _service);
            _service?.HttpClient?.MessageHandler?.AddExecuteInterceptor(_interceptor);
        }

        internal new ResumableUploadOptions Options => base.Options;

        private sealed class Crc32cHashInterceptor : IHttpExecuteInterceptor
        {
            private const string GoogleHashHeader = "x-goog-hash";
            private const int ReadBufferSize = 81920;
            private readonly Stream _stream;
            private readonly IClientService _service;
            private readonly CustomMediaUpload _owner;
            private Uri _uploadUri;

            public Crc32cHashInterceptor(CustomMediaUpload owner, Stream stream, IClientService service)
            {
                _stream = stream;
                _service = service;
                _owner = owner;
                _owner.UploadSessionData += OnSessionData;
                _owner.ProgressChanged += OnProgressChanged;
            }

            public async Task InterceptAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                if (_uploadUri != null && !_uploadUri.Equals(request.RequestUri))
                {
                    return;
                }

                if (request.Method == System.Net.Http.HttpMethod.Put && request.Content?.Headers.Contains("Content-Range") is true)
                {
                    string rangeHeader = request.Content.Headers.GetValues("Content-Range").First();

                    if (IsFinalChunk(rangeHeader))
                    {
                        if (!_stream.CanSeek)
                        {
                            return;
                        }

                        long originalPosition = _stream.Position;
                        try
                        {
                            _stream.Position = 0;

                            var hasher = new Crc32c();
                            var buffer = System.Buffers.ArrayPool<byte>.Shared.Rent(ReadBufferSize);
                            try
                            {
                                int bytesRead;
                                while ((bytesRead = await _stream.ReadAsync(buffer, 0, buffer.Length, cancellationToken).ConfigureAwait(false)) > 0)
                                {
                                    hasher.UpdateHash(buffer, 0, bytesRead);
                                }
                            }
                            finally
                            {
                                System.Buffers.ArrayPool<byte>.Shared.Return(buffer);
                            }

                            byte[] hash = hasher.GetHash();
                            string calculatedHash = Convert.ToBase64String(hash);
                            request.Headers.TryAddWithoutValidation(GoogleHashHeader, $"crc32c={calculatedHash}");
                        }
                        finally
                        {
                            _stream.Position = originalPosition;
                        }
                    }
                }
            }

            private void OnSessionData(IUploadSessionData data)
            {
                _uploadUri = data.UploadUri;
                _owner.UploadSessionData -= OnSessionData;
            }

            private void OnProgressChanged(IUploadProgress progress)
            {
                if (progress.Status == UploadStatus.Completed || progress.Status == UploadStatus.Failed)
                {
                    // Clean up when upload is finished.
                    _service?.HttpClient?.MessageHandler?.RemoveExecuteInterceptor(this);
                    _owner.ProgressChanged -= OnProgressChanged;
                }
            }

            private bool IsFinalChunk(string rangeHeader)
            {
                // Expected format: "bytes {start}-{end}/{total}" or "bytes */{total}" for the final request.
                // We are interested in the final chunk of a known-size upload.
                const string prefix = "bytes ";
                if (!rangeHeader.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }

                ReadOnlySpan<char> span = rangeHeader.AsSpan(prefix.Length);
                int slashIndex = span.IndexOf('/');
                if (slashIndex == -1)
                {
                    return false;
                }

                var totalSpan = span.Slice(slashIndex + 1);
                if (totalSpan.IsEmpty || totalSpan[0] == '*')
                {
                    return false;
                }

                if (!long.TryParse(totalSpan.ToString(), System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.InvariantCulture, out long totalSize))
                {
                    return false;
                }

                var rangeSpan = span.Slice(0, slashIndex);
                int dashIndex = rangeSpan.IndexOf('-');
                if (dashIndex == -1)
                {
                    return false;
                }

                var endByteSpan = rangeSpan.Slice(dashIndex + 1);
                if (!long.TryParse(endByteSpan.ToString(), System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.InvariantCulture, out long endByte))
                {
                    return false;
                }

                // If endByte is the last byte of the file, it's the final chunk.
                return (endByte + 1) == totalSize;
            }
        }
    }
}
