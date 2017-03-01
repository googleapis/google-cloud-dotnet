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
    }
}
