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

using Google.Apis.Download;
using Google.Apis.Http;
using Google.Apis.Services;
using Google.Apis.Storage.v1.Data;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Subclass of <see cref="MediaDownloader"/> which validates the data it receives
    /// against a CRC32c hash set in the header.
    /// </summary>
    internal sealed class HashValidatingDownloader : ContentMetadataRecordingMediaDownloader
    {
        private string crc32cHashBase64;
        private Crc32c hasher;

        /// <summary>Constructs a new downloader with the given client service.</summary>
        internal HashValidatingDownloader(Object metadata, IClientService service) : base(metadata, service)
        {
            ResponseStreamInterceptorProvider = CreateInterceptor;
        }

        private StreamInterceptor CreateInterceptor(HttpResponseMessage response)
        {
            crc32cHashBase64 = null;
            hasher = null;

            IEnumerable<string> values;
            if (response.Headers.TryGetValues(Crc32c.HashHeaderName, out values))
            {
                string prefix = Crc32c.HashName + "=";
                foreach (var value in values.SelectMany(v => v.Split(',')))
                {
                    if (value.StartsWith(prefix))
                    {
                        hasher = new Crc32c();
                        crc32cHashBase64 = value.Substring(prefix.Length);
                        return hasher.UpdateHash;
                    }
                }
            }
            return null;
        }

        protected override void OnDownloadCompleted()
        {
            base.OnDownloadCompleted();

            if (crc32cHashBase64 != null)
            {
                string actualHash = System.Convert.ToBase64String(hasher.GetHash());
                if (actualHash != crc32cHashBase64)
                {
                    throw new IOException($"Incorrect hash: expected '{crc32cHashBase64}' (base64), was '{actualHash}' (base64)");
                }
            }
        }
    }
}