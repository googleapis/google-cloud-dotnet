// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V2;

/// <summary>
/// Helper class to manage uploads. Eventually we'd probably use a partial class to put
/// this code directly in StorageClient, but that can come later after a lot of design work.
/// </summary>
public class StorageUploader
{
    private const int ChunkSize = 1 << 21;
    private readonly StorageClient _client;

    /// <summary>
    /// Creates a new uploader wrapping the given client.
    /// </summary>
    /// <param name="client">The client to use for uploading. Must not be null.</param>
    public StorageUploader(StorageClient client)
    {
        this._client = GaxPreconditions.CheckNotNull(client, nameof(client));
    }

    /// <summary>
    /// Uploads an object with data read from a stream.
    /// </summary>
    /// <param name="bucket">The bucket to upload to. Must not be null.</param>
    /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
    /// <param name="stream">The stream containing data to upload. Must not be null.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public async Task<Object> UploadObjectAsync(BucketName bucket, string objectName, Stream stream)
    {
        GaxPreconditions.CheckNotNull(bucket, nameof(bucket));
        GaxPreconditions.CheckNotNullOrEmpty(objectName, nameof(objectName));
        GaxPreconditions.CheckNotNull(stream, nameof(stream));

        var headerCallSettings = CallSettings.FromHeader("x-goog-request-params", $"bucket={Uri.EscapeDataString(bucket.ToString())}");
        using var requestStream = _client.WriteObject(headerCallSettings);

        // TODO: Ouch! Can we avoid this?
        byte[] buffer = new byte[ChunkSize];

        long bytesWritten = 0;
        bool firstRequest = true;
        bool finished = false;
        Task currentWriteTask = null;

        while (!finished)
        {
            int bytesRead = await FillBufferAsync().ConfigureAwait(false);

            if (currentWriteTask is not null)
            {
                await currentWriteTask.ConfigureAwait(false);
            }

            // TODO: This ends up with an unnecessary request at the end, if we've read precisely as far as the
            // buffer. The simplicity is appealing though.
            // Note that we can't just break out of the loop if bytesRead is 0 and it's not the first request,
            // because we need to send a request with FinishWrite=true.
            finished = bytesRead != ChunkSize;
            var request = new WriteObjectRequest
            {
                ChecksummedData = new ChecksummedData { Content = ByteString.CopyFrom(buffer, 0, bytesRead) },
                FinishWrite = finished,
                WriteOffset = bytesWritten
            };
            if (firstRequest)
            {
                request.WriteObjectSpec = new WriteObjectSpec
                {
                    Resource = new Object
                    {
                        BucketAsBucketName = bucket,
                        Name = objectName
                    }
                };
                firstRequest = false;
            }
            // Don't wait on the write: we can parallelize "fill the buffer" and "write over the network".
            currentWriteTask = requestStream.WriteAsync(request);
            bytesWritten += bytesRead;
        }

        if (currentWriteTask is not null)
        {
            await currentWriteTask.ConfigureAwait(false);
        }

        await requestStream.WriteCompleteAsync().ConfigureAwait(false);

        var response = await requestStream.ResponseAsync.ConfigureAwait(false);
        return response.Resource;

        async Task<int> FillBufferAsync()
        {
            int position = 0;
            while (position < buffer.Length)
            {
                int bytesRead = await stream.ReadAsync(buffer, position, buffer.Length - position).ConfigureAwait(false);
                if (bytesRead == 0)
                {
                    break;
                }
                position += bytesRead;
            }
            return position;
        }
    }
}
