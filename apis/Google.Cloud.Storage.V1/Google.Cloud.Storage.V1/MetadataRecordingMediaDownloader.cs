// Copyright 2022 Google LLC
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

using Google.Apis.Download;
using Google.Apis.Services;
using Google.Apis.Storage.v1.Data;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Google.Cloud.Storage.V1;

/// <summary>
/// MediaDownloader subclass which populates an <see cref="Object"/> instance
/// from the headers it sees on a successful response. Note: if this ever becomes public,
/// we should put more effort into naming it carefully.
/// </summary>
internal class ContentMetadataRecordingMediaDownloader : MediaDownloader
{
    private const string ETagHeader = "ETag";
    private const string GenerationHeader = "X-Goog-Generation";
    private const string MetagenerationHeader = "X-Goog-Metageneration";
    private const string HashHeader = "X-Goog-Hash";
    private const string ContentTypeHeader = "Content-Type";

    // The hashes are comma-separated...
    private static readonly char[] HashToElementSplitter = new[] { ',' };
    // ... and each hash is a key=value pair
    private static readonly char[] HashKeyValueSplitter = new[] { '=' };

    private readonly Object metadata;

    /// <summary>Constructs a new downloader with the given client service.</summary>
    /// <param name="metadata">The object in which to record metadata.</param>
    /// <param name="service">The client service.</param>
    internal ContentMetadataRecordingMediaDownloader(Object metadata, IClientService service) : base(service)
    {
        this.metadata = metadata;
    }

    protected override void OnResponseReceived(HttpResponseMessage response)
    {
        base.OnResponseReceived(response);
        ProcessMetadataHeaders(response.Headers, response.Content.Headers);
    }

    private void ProcessMetadataHeaders(HttpResponseHeaders headers, HttpContentHeaders contentHeaders)
    {
        metadata.Generation = MaybeParse(GetFirstHeaderOrNull(GenerationHeader));
        metadata.Metageneration = MaybeParse(GetFirstHeaderOrNull(MetagenerationHeader));
        metadata.ETag = GetFirstHeaderOrNull(ETagHeader);
        var hashes = GetFirstHeaderOrNull(HashHeader) ?? "";
        // The hash header returns multiple comma-separated hashes.
        var hashesByKey = hashes.Split(HashToElementSplitter)
            .Where(hash => hash.Contains('='))
            .Select(hash => hash.Split(HashKeyValueSplitter, 2))
            .ToDictionary(bits => bits[0], bits => bits[1]);
        metadata.Crc32c = hashesByKey.TryGetValue("crc32c", out string crc32c) ? crc32c : null;
        metadata.Md5Hash = hashesByKey.TryGetValue("md5", out string md5) ? md5 : null;
        metadata.ContentType = contentHeaders.ContentType?.ToString();

        string GetFirstHeaderOrNull(string headerName) =>
            headers.TryGetValues(headerName, out var values) ? values.FirstOrDefault() : null;

        long? MaybeParse(string text) =>
            text is null || !long.TryParse(text, NumberStyles.None, CultureInfo.InvariantCulture, out var value)
            ? (long?) null
            : value;
    }
}
