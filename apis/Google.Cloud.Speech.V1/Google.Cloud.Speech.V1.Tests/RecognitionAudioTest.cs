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

using Google.Cloud.Speech.V1;
using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Vision.V1.Tests
{
    public class RecognitionAudioTest
    {
        // The tests which use a URI don't actually care that we're loading an image instead of an audio file.
        // If we could find a nice stable URL with an audio file, that would be good...
        private const string IconUri = "https://cloud.google.com/images/devtools-icon-64x64.png";
        private const int IconContentSize = 1776;

        [Fact]
        public void FromFile()
        {
            using (var tempFile = TempFile.Generate(500))
            {
                var audio = RecognitionAudio.FromFile(tempFile.Name);
                Assert.Equal(tempFile.Bytes, audio.Content.ToByteArray());
            }
        }

        [Fact]
        public async Task FromFileAsync()
        {
            using (var tempFile = TempFile.Generate(500))
            {
                var audio = await RecognitionAudio.FromFileAsync(tempFile.Name);
                Assert.Equal(tempFile.Bytes, audio.Content.ToByteArray());
            }
        }

        [Fact]
        public void FetchFromUri_String()
        {
            var audio = RecognitionAudio.FetchFromUri(IconUri);
            Assert.Equal(IconContentSize, audio.Content.Length);
        }

        [Fact]
        public void FetchFromUri_Uri()
        {
            var audio = RecognitionAudio.FetchFromUri(new Uri(IconUri));
            Assert.Equal(IconContentSize, audio.Content.Length);
        }

        [Fact]
        public async Task FetchFromUriAsync_String()
        {
            var audio = await RecognitionAudio.FetchFromUriAsync(IconUri);
            Assert.Equal(IconContentSize, audio.Content.Length);
        }

        [Fact]
        public async Task FetchFromUriAsync_Uri()
        {
            var audio = await RecognitionAudio.FetchFromUriAsync(new Uri(IconUri));
            Assert.Equal(IconContentSize, audio.Content.Length);
        }

        private class TempFile : IDisposable
        {
            public string Name { get; }
            public byte[] Bytes { get; }

            private TempFile(string name, byte[] bytes)
            {
                Name = name;
                Bytes = bytes;
            }

            public static TempFile Generate(int byteCount)
            {
                Random rng = new Random();
                var bytes = new byte[byteCount];
                rng.NextBytes(bytes);
                string name = Path.GetTempFileName();
                File.WriteAllBytes(name, bytes);
                return new TempFile(name, bytes);
            }

            public void Dispose() => File.Delete(Name);
        }
    }
}
