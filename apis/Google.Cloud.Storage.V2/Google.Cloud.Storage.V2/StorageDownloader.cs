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
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V2;

/// <summary>
/// Helper class to manage downloads. Eventually we'd probably use a partial class to put
/// this code directly in StorageClient, but that can come later after a lot of design work.
/// </summary>
public class StorageDownloader
{
    private readonly StorageClient _client;

    /// <summary>
    /// Creates a new downloader wrapping the given client.
    /// </summary>
    /// <param name="client">The client to use for downloading. Must not be null.</param>
    public StorageDownloader(StorageClient client)
    {
        this._client = GaxPreconditions.CheckNotNull(client, nameof(client));
    }

    /// <summary>
    /// Downloads an object, writing the data into the given stream.
    /// </summary>
    /// <param name="bucket">The bucket containing the object.</param>
    /// <param name="objectName">The name of the object within the bucket.</param>
    /// <param name="stream">The stream to write the content into.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public async Task DownloadObjectAsync(BucketName bucket, string objectName, Stream stream)
    {
        GaxPreconditions.CheckNotNull(bucket, nameof(bucket));
        GaxPreconditions.CheckNotNullOrEmpty(objectName, nameof(objectName));
        GaxPreconditions.CheckNotNull(stream, nameof(stream));

        var request = new ReadObjectRequest { BucketAsBucketName = bucket, Object = objectName };
        using var readStream = _client.ReadObject(request);
        long bytesReceived = 0;

        IAsyncEnumerable<ReadObjectResponse> responseStream = readStream.GetResponseStream();
        await foreach (var response in responseStream.ConfigureAwait(false))
        {
            bytesReceived += response.ChecksummedData.Content.Length;
            // TODO: See if we can add a ByteString.WriteAsync(Stream) method to avoid the copying
            // in .NET 4.6.2.
#if NETSTANDARD2_1_OR_GREATER
            await stream.WriteAsync(response.ChecksummedData.Content.Memory).ConfigureAwait(false);
#else
            byte[] bytes = response.ChecksummedData.Content.ToByteArray();
            await stream.WriteAsync(bytes, 0, bytes.Length).ConfigureAwait(false);
#endif
        }
    }
}
