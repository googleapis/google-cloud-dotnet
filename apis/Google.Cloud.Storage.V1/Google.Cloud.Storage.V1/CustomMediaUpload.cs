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
using Google.Apis.Services;
using Google.Apis.Upload;
using System;
using System.IO;
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
        private readonly HashingStream _hashingStream;
        private const string GoogleHashHeader = "x-goog-hash";

        public CustomMediaUpload(IClientService service, Apis.Storage.v1.Data.Object body, string bucket,
            Stream stream, string contentType, UploadObjectOptions options)
            : base(service, body, bucket, (options?.UploadValidationMode ?? UploadObjectOptions.DefaultValidationMode) != UploadValidationMode.None ? new HashingStream(stream) : stream, contentType)
        {
            var validationMode = options?.UploadValidationMode ?? UploadObjectOptions.DefaultValidationMode;
            GaxPreconditions.CheckEnumValue(validationMode, nameof(UploadObjectOptions.UploadValidationMode));
            if (validationMode != UploadValidationMode.None)
            {
                _hashingStream = ContentStream as HashingStream;
                LastRequestExecuting += (HttpRequestMessage request) =>
                {
                    if (_hashingStream != null)
                    {
                        if (_hashingStream.HasGaps)
                        {
                            throw new ArgumentException(
                                "Cannot perform hash validation when resuming an upload from a non-zero offset, " +
                                "as the complete stream contents are required to compute the hash. " +
                                "To resume this upload, disable validation by setting UploadValidationMode to None.",
                                nameof(stream));
                        }
                        if (_hashingStream.IsHashComplete)
                        {
                            var calculatedHash = _hashingStream.GetBase64Hash();
                            bool hasCrc32c = false;
                            if (request.Headers.TryGetValues(GoogleHashHeader, out var values))
                            {
                                foreach (var value in values)
                                {
                                    if (value?.IndexOf("crc32c", StringComparison.OrdinalIgnoreCase) >= 0)
                                    {
                                        hasCrc32c = true;
                                        break;
                                    }
                                }
                            }
                            if (!hasCrc32c)
                            {
                                request.Headers.TryAddWithoutValidation(GoogleHashHeader, $"crc32c={calculatedHash}");
                            }
                        }
                    }
                };
            }
        }

        internal new ResumableUploadOptions Options => base.Options;

        internal sealed class HashingStream : Stream
        {
            private readonly Stream _stream;
            private readonly Crc32c _hasher;
            private long _maxPositionHashed = 0;
            private long _position = 0;
            private bool _hasGaps = false;
            private bool _reachedEof = false;
            public bool HasGaps => _hasGaps;

            public HashingStream(Stream stream)
            {
                _stream = stream;
                _hasher = new Crc32c();
            }

            public bool IsHashComplete => !_hasGaps && (_stream.CanSeek ? _maxPositionHashed == _stream.Length : _reachedEof);

            public override int Read(byte[] buffer, int offset, int count)
            {
                long startingPos = _stream.CanSeek ? _stream.Position : _position;
                int bytesRead = _stream.Read(buffer, offset, count);
                if (count > 0 && bytesRead == 0)
                {
                    _reachedEof = true;
                }
                ProcessBytes(buffer, offset, bytesRead, startingPos);
                if (!_stream.CanSeek)
                {
                    _position += bytesRead;
                }
                return bytesRead;
            }

            public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
            {
                long startingPos = _stream.CanSeek ? _stream.Position : _position;
                int bytesRead = await _stream.ReadAsync(buffer, offset, count, cancellationToken).ConfigureAwait(false);
                if (count > 0 && bytesRead == 0)
                {
                    _reachedEof = true;
                }
                ProcessBytes(buffer, offset, bytesRead, startingPos);
                if (!_stream.CanSeek)
                {
                    _position += bytesRead;
                }
                return bytesRead;
            }

            private void ProcessBytes(byte[] buffer, int offset, int bytesRead, long startingPos)
            {
                if (bytesRead <= 0) return;

                if (startingPos > _maxPositionHashed)
                {
                    _hasGaps = true;
                    return;
                }

                // Only hash bytes that are beyond the furthest point we've already hashed.
                // This handles the rewind and re-read scenario during retries.
                if (startingPos + bytesRead > _maxPositionHashed)
                {
                    long newBytesStart = Math.Max(startingPos, _maxPositionHashed);
                    int actuallyNewCount = (int) ((startingPos + bytesRead) - newBytesStart);
                    int bufferOffset = offset + (int) (newBytesStart - startingPos);

                    _hasher.UpdateHash(buffer, bufferOffset, actuallyNewCount);
                    _maxPositionHashed = startingPos + bytesRead;
                }
            }

            public override long Position
            {
                get => _stream.CanSeek ? _stream.Position : _position;
                set
                {
                    if (_stream.CanSeek)
                    {
                        _stream.Position = value;
                    }
                    else
                    {
                        throw new NotSupportedException();
                    }
                }
            }

            public override long Seek(long offset, SeekOrigin origin)
            {
                if (_stream.CanSeek)
                {
                    return _stream.Seek(offset, origin);
                }
                throw new NotSupportedException();
            }

            public string GetBase64Hash() => Convert.ToBase64String(_hasher.GetHash());
            public override bool CanRead => _stream.CanRead;
            public override bool CanSeek => _stream.CanSeek;
            public override bool CanWrite => _stream.CanWrite;
            public override long Length => _stream.Length;
            public override void Flush() => _stream.Flush();
            public override void SetLength(long value) => _stream.SetLength(value);
            public override void Write(byte[] buffer, int offset, int count) => _stream.Write(buffer, offset, count);
            protected override void Dispose(bool disposing)
            {
                if (disposing)
                {
                    _stream?.Dispose();
                }
                base.Dispose(disposing);
            }
        }
    }
}
