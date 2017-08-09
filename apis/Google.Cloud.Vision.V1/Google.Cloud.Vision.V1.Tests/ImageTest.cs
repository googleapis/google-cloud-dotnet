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
using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Vision.V1.Tests
{
    public class ImageTest
    {
        // Very unlikely this icon will change...
        private const string IconUri = "https://cloud.google.com/images/devtools-icon-64x64.png";
        private const int IconContentSize = 1776;

        [Fact]
        public void FromUri_String()
        {
            string uri = "gs://bucket/file";
            var image = Image.FromUri(uri);
            Assert.Equal(uri, image.Source.ImageUri);
        }

        [Fact]
        public void FromUri_Uri()
        {
            Uri uri = new Uri("https://google.com/someimage.png");
            var image = Image.FromUri(uri);
            Assert.Equal("https://google.com/someimage.png", image.Source.ImageUri);
        }

        [Fact]
        public async Task FromStream()
        {
            var data = new byte[] { 1, 2, 3 };
            var image = Image.FromStream(new MemoryStream(data));
            Assert.Equal(data, image.Content.ToByteArray());

            image = await Image.FromStreamAsync(new MemoryStream(data));
            Assert.Equal(data, image.Content.ToByteArray());
        }

        [Fact]
        public void FromBytes()
        {
            var data = new byte[] { 1, 2, 3 };
            var image = Image.FromBytes(data);
            Assert.Equal(data, image.Content.ToByteArray());
        }

        [Fact]
        public void FromBytes_WithOffset()
        {
            var data = new byte[] { 0, 0, 1, 2, 3, 0, 0 };
            var image = Image.FromBytes(data, 2, 3);
            Assert.Equal(new byte[] { 1, 2, 3 }, image.Content.ToByteArray());
        }

        [Fact]
        public void FromFile()
        {
            using (var tempFile = TempFile.Generate(500))
            {
                var image = Image.FromFile(tempFile.Name);
                Assert.Equal(tempFile.Bytes, image.Content.ToByteArray());
            }
        }

        [Fact]
        public async Task FromFileAsync()
        {
            using (var tempFile = TempFile.Generate(500))
            {
                var image = await Image.FromFileAsync(tempFile.Name);
                Assert.Equal(tempFile.Bytes, image.Content.ToByteArray());
            }
        }

        [Fact]
        public void FetchFromUri_String()
        {
            var image = Image.FetchFromUri(IconUri);
            Assert.Equal(IconContentSize, image.Content.Length);
        }

        [Fact]
        public void FetchFromUri_Uri()
        {
            var image = Image.FetchFromUri(new Uri(IconUri));
            Assert.Equal(IconContentSize, image.Content.Length);
        }

        [Fact]
        public async Task FetchFromUriAsync_String()
        {
            var image = await Image.FetchFromUriAsync(IconUri);
            Assert.Equal(IconContentSize, image.Content.Length);
        }

        [Fact]
        public async Task FetchFromUriAsync_Uri()
        {
            var image = await Image.FetchFromUriAsync(new Uri(IconUri));
            Assert.Equal(IconContentSize, image.Content.Length);
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
