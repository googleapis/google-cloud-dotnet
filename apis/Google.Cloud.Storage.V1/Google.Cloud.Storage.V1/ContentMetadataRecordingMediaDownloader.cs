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
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// MediaDownloader subclass which creates a <see cref="ContentMetadata"/> instance
    /// from the headers it sees on a successful response. Note: if this ever becomes public,
    /// we should put more effort into naming it carefully.
    /// </summary>
    internal class ContentMetadataRecordingMediaDownloader : MediaDownloader
    {
        // TODO: Expose this? Storage class? Uploader ID?
        //private const string ETagHeader = "ETag";
        private const string GenerationHeader = "X-Goog-Generation";
        private const string MetagenerationHeader = "X-Goog-Metageneration";
        private const string HashHeader = "X-Goog-Hash";

        internal ContentMetadata ContentMetadata { get; private set; }

        /// <summary>Constructs a new downloader with the given client service.</summary>
        internal ContentMetadataRecordingMediaDownloader(IClientService service) : base(service)
        {
        }

        protected override void OnResponseReceived(HttpResponseMessage response)
        {
            base.OnResponseReceived(response);
            ContentMetadata = FromHttpResponseHeaders(response.Headers);
        }

        internal static ContentMetadata FromHttpResponseHeaders(HttpResponseHeaders headers)
        {
            long? generation = MaybeParse(GetFirstHeaderOrNull(GenerationHeader));
            long? metageneration = MaybeParse(GetFirstHeaderOrNull(MetagenerationHeader));
            string hash = GetFirstHeaderOrNull(HashHeader);
            return new ContentMetadata(generation, metageneration, hash);

            string GetFirstHeaderOrNull (string headerName) =>
                headers.TryGetValues(headerName, out var values) ? values.FirstOrDefault() : null;

            long? MaybeParse(string text) =>
                text is null || !long.TryParse(text, NumberStyles.None, CultureInfo.InvariantCulture, out var value)
                ? (long?) null
                : value;
        }
    }
}
