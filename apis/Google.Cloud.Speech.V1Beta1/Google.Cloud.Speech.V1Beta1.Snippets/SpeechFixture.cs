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

using Google.Storage.V1;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace Google.Cloud.Speech.V1Beta1.Snippets
{
    [CollectionDefinition(nameof(SpeechFixture))]
    public sealed class SpeechFixture : IDisposable, ICollectionFixture<SpeechFixture>
    {
        private const string ProjectEnvironmentVariable = "TEST_PROJECT";

        private readonly string _projectId;
        private readonly string _bucketName = "snippets-" + Guid.NewGuid().ToString().ToLowerInvariant();
        private readonly IDictionary<string, string> _uploadedResources = new Dictionary<string, string>();
        private bool createdBucket = false;

        public SpeechFixture()
        {
            _projectId = Environment.GetEnvironmentVariable(ProjectEnvironmentVariable);
            if (string.IsNullOrEmpty(_projectId))
            {
                throw new InvalidOperationException(
                    $"Please set the {ProjectEnvironmentVariable} environment variable before running tests");
            }
        }

        /// <summary>
        /// Uploads an audio resource to Google Cloud Storage, returning the GCS URI.
        /// If this method is called multiple times for the same file, the same URI is returned each time.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string UploadAudioToStorage(string name)
        {
            string objectName;
            if (!_uploadedResources.TryGetValue(name, out objectName))
            {
                var client = StorageClient.Create();
                if (!createdBucket)
                {
                    client.CreateBucket(_projectId, _bucketName);
                    createdBucket = true;
                }
                objectName = Guid.NewGuid().ToString();
                var audio = LoadResourceAudio(name);
                using (var stream = OpenResourceStream(name))
                {
                    client.UploadObject(_bucketName, objectName, null, stream);
                }
                _uploadedResources[name] = objectName;
            }
            // TODO: This needs to be in the storage library somewhere...
            return $"gs://{_bucketName}/{objectName}";
        }

        internal RecognitionAudio LoadResourceAudio(string name)
        {
            using (var stream = OpenResourceStream(name))
            {
                return RecognitionAudio.FromStream(stream);
            }
        }

        internal Stream OpenResourceStream(string name)
        {
            var type = typeof(SpeechFixture);
            return type.Assembly.GetManifestResourceStream($"{type.Namespace}.{name}");
        }

        public void Dispose()
        {
            if (!createdBucket)
            {
                return;
            }
            var client = StorageClient.Create();
            foreach (var objectName in _uploadedResources.Values)
            {
                client.DeleteObject(_bucketName, objectName);
            }
            client.DeleteBucket(_bucketName);
        }

    }
}
