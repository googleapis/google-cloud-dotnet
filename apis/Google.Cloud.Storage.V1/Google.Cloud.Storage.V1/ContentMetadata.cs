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

using System;

namespace Google.Cloud.Storage.V1
{
    // FIXME: provide a public constructor of some kind, for test purposes.

    /// <summary>
    /// Provided metadata about the content that has been downloaded with a call to
    /// <see cref="StorageClient.DownloadObject(string, string, System.IO.Stream, DownloadObjectOptions, IProgress{Apis.Download.IDownloadProgress})"/>
    /// (or overloads and async equivalents). This is not the complete object metadata as returned by <see cref="StorageClient.GetObject(string, string, GetObjectOptions)"/>
    /// and related calls; it only provides the information returned by the server in HTTP headers along with the content.
    /// </summary>
    public sealed class ContentMetadata
    {
        /// <summary>
        /// FIXME
        /// </summary>
        public long? Generation { get; }

        /// <summary>
        /// FIXME
        /// </summary>
        public long? Metageneration { get; }

        /// <summary>
        /// FIXME
        /// </summary>
        public string Hash { get; }

        internal ContentMetadata(long? generation, long? metageneration, string hash)
        {
            Generation = generation;
            Metageneration = metageneration;
            Hash = hash;
        }
    }
}
