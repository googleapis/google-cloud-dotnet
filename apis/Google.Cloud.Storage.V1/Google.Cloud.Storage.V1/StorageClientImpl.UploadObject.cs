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
using Google.Apis.Storage.v1;
using Google.Apis.Upload;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1
{
    public sealed partial class StorageClientImpl : StorageClient
    {
        /// <inheritdoc />
        public override ObjectsResource.InsertMediaUpload CreateObjectUploader(
            string bucket,
            string objectName,
            string contentType,
            Stream source,
            UploadObjectOptions options = null)
        {
            ValidateBucketName(bucket);
            GaxPreconditions.CheckNotNull(objectName, nameof(objectName));
            return CreateObjectUploader(
                new Object { Bucket = bucket, Name = objectName, ContentType = contentType },
                source, options);
        }

        /// <inheritdoc />
        public override ObjectsResource.InsertMediaUpload CreateObjectUploader(
            Object destination,
            Stream source,
            UploadObjectOptions options = null)
        {
            ValidateObject(destination, nameof(destination));
            GaxPreconditions.CheckNotNull(source, nameof(source));
            var mediaUpload = new CustomMediaUpload(Service, destination, destination.Bucket, source, destination.ContentType);
            options?.ModifyMediaUpload(mediaUpload);
            ApplyEncryptionKey(options?.EncryptionKey, options?.KmsKeyName, mediaUpload);
            return mediaUpload;
        }

        /// <inheritdoc />
        public override Object UploadObject(
            string bucket,
            string objectName,
            string contentType,
            Stream source,
            UploadObjectOptions options = null,
            IProgress<IUploadProgress> progress = null)
        {
            ValidateBucketName(bucket);
            GaxPreconditions.CheckNotNull(objectName, nameof(objectName));
            return UploadObject(
                new Object { Bucket = bucket, Name = objectName, ContentType = contentType },
                source, options, progress);
        }

        /// <inheritdoc />
        public override Task<Object> UploadObjectAsync(
            string bucket,
            string objectName,
            string contentType,
            Stream source,
            UploadObjectOptions options = null,
            CancellationToken cancellationToken = default,
            IProgress<IUploadProgress> progress = null)
        {
            ValidateBucketName(bucket);
            GaxPreconditions.CheckNotNull(objectName, nameof(objectName));
            return UploadObjectAsync(new Object { Bucket = bucket, Name = objectName, ContentType = contentType },
                source, options, cancellationToken, progress);
        }

        /// <inheritdoc />
        public override Object UploadObject(
            Object destination,
            Stream source,
            UploadObjectOptions options = null,
            IProgress<IUploadProgress> progress = null) =>
            new UploadHelper(this, destination, source, options, progress).Execute();

        /// <inheritdoc />
        public override Task<Object> UploadObjectAsync(
            Object destination,
            Stream source,
            UploadObjectOptions options = null,
            CancellationToken cancellationToken = default,
            IProgress<IUploadProgress> progress = null) =>
            new UploadHelper(this, destination, source, options, progress).ExecuteAsync(cancellationToken);

        /// <inheritdoc />
        public override Task<Uri> InitiateUploadSessionAsync(
            Object destination,
            long? contentLength,
            UploadObjectOptions options = null,
            CancellationToken cancellationToken = default)
        {
            // We could potentially do a single validation, but the reasons for preventing negative and zero
            // values are somewhat different.   
            GaxPreconditions.CheckNonNegative(contentLength, nameof(contentLength));
            if (contentLength == 0)
            {
                throw new ArgumentOutOfRangeException("A content length of 0 cannot be enforced. Use a null content length for 'any length'.");
            }
            ValidateObject(destination, nameof(destination));
            var upload = CreateObjectUploader(destination, new LengthOnlyStream(contentLength), options);
            return upload.InitiateSessionAsync(cancellationToken);
        }

        /// <inheritdoc />
        public override Task<Uri> InitiateUploadSessionAsync(
            string bucket,
            string objectName,
            string contentType,
            long? contentLength,
            UploadObjectOptions options = null,
            CancellationToken cancellationToken = default)
        {
            ValidateBucketName(bucket);
            var obj = new Object { Bucket = bucket, Name = objectName, ContentType = contentType };
            return InitiateUploadSessionAsync(obj, contentLength, options, cancellationToken);
        }

        /// <summary>
        /// Helper class to provide common context between sync and async operations. Helps avoid quite so much duplicate code...
        /// </summary>
        private sealed class UploadHelper
        {
            private readonly StorageClient _client;
            private readonly ObjectsResource.InsertMediaUpload _mediaUpload;
            private readonly Crc32c _crc;
            private readonly Action<Object> _validationFailureAction;
            private readonly Func<Object, CancellationToken, Task> _validationFailureAsyncAction;

            internal UploadHelper(
                StorageClient client,
                Object destination,
                Stream source,
                UploadObjectOptions options,
                IProgress<IUploadProgress> progress)
            {
                _client = client;
                _mediaUpload = client.CreateObjectUploader(destination, source, options);
                if (progress != null)
                {
                    _mediaUpload.ProgressChanged += progress.Report;
                }

                var validationMode = options?.UploadValidationMode ?? UploadObjectOptions.DefaultValidationMode;
                GaxPreconditions.CheckEnumValue(validationMode, nameof(UploadObjectOptions.UploadValidationMode));
                switch (validationMode)
                {
                    case UploadValidationMode.DeleteAndThrow:
                        _crc = new Crc32c();
                        _mediaUpload.UploadStreamInterceptor += _crc.UpdateHash;
                        _validationFailureAction = obj => client.DeleteObject(obj, new DeleteObjectOptions { Generation = obj.Generation });
                        _validationFailureAsyncAction = (obj, token) => client.DeleteObjectAsync(obj, new DeleteObjectOptions { Generation = obj.Generation }, token);
                        break;
                    case UploadValidationMode.ThrowOnly:
                        _crc = new Crc32c();
                        _mediaUpload.UploadStreamInterceptor += _crc.UpdateHash;
                        break;
                }
            }

            internal Object Execute()
            {
                _mediaUpload.Upload();
                _mediaUpload.GetProgress().ThrowOnFailure();
                var result = _mediaUpload.ResponseBody;
                var hash = _crc == null ? result.Crc32c : Convert.ToBase64String(_crc.GetHash());
                if (hash != result.Crc32c)
                {
                    AggregateException additionalFailures = null;
                    try
                    {
                        _validationFailureAction?.Invoke(result);
                    }
                    catch (Exception e)
                    {
                        additionalFailures = new AggregateException(e);
                    }
                    throw new UploadValidationException(hash, result, additionalFailures);
                }
                return result;
            }

            internal async Task<Object> ExecuteAsync(CancellationToken cancellationToken)
            {
                await _mediaUpload.UploadAsync(cancellationToken).ConfigureAwait(false);
                _mediaUpload.GetProgress().ThrowOnFailure();
                var result = _mediaUpload.ResponseBody;
                var hash = _crc == null ? result.Crc32c : Convert.ToBase64String(_crc.GetHash());
                if (hash != result.Crc32c)
                {
                    AggregateException additionalFailures = null;
                    try
                    {
                        if (_validationFailureAsyncAction != null)
                        {
                            await _validationFailureAsyncAction(result, cancellationToken).ConfigureAwait(false);
                        }
                    }
                    catch (Exception e)
                    {
                        additionalFailures = new AggregateException(e);
                    }
                    throw new UploadValidationException(hash, result, additionalFailures);
                }
                return result;
            }
        }

        private sealed class LengthOnlyStream : Stream
        {
            private readonly long? _length;
            private long _position;
            internal LengthOnlyStream(long? length) => _length = length;

            public override long Length => _length ?? throw new NotSupportedException();
            public override bool CanSeek => _length.HasValue;
            public override bool CanRead => true;
            public override bool CanWrite => false;

            public override long Position
            {
                get => _position;
                set
                {
                    if (!CanSeek) throw new NotSupportedException();
                    if (value < 0 || value > Length) throw new ArgumentOutOfRangeException(nameof(value));
                    _position = value;
                }
            }

            public override int Read(byte[] buffer, int offset, int count)
            {
                if (!_length.HasValue)
                {
                    return 0;
                }
                long remaining = _length.Value - _position;
                if (remaining <= 0) return 0;

                int toRead = (int) Math.Min(count, remaining);

                Array.Clear(buffer, offset, toRead);

                _position += toRead;
                return toRead;
            }

            public override void Flush() { }

            public override long Seek(long offset, SeekOrigin origin)
            {
                switch (origin)
                {
                    case SeekOrigin.Begin: Position = offset; break;
                    case SeekOrigin.Current: Position += offset; break;
                    case SeekOrigin.End: Position = Length + offset; break;
                }
                return Position;
            }

            public override void SetLength(long value) => throw new NotSupportedException();
            public override void Write(byte[] buffer, int offset, int count) => throw new NotSupportedException();
        }
    }
}
