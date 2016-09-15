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

using Google.Rpc;
using Xunit;

namespace Google.Cloud.Vision.V1.IntegrationTests
{
    public class ImageAnnotatorClientTest
    {
        private static readonly Image s_badImage = Image.FromBytes(new byte[10]);

        [Fact]
        public void AnnotateImage_BadImage()
        {
            var client = ImageAnnotatorClient.Create();
            var request = new AnnotateImageRequest
            {
                Image = s_badImage,
                Features = { new Feature { Type = Feature.Types.Type.FaceDetection } }
            };
            var exception = Assert.Throws<AnnotateImageException>(() => client.Annotate(request));
            Assert.Equal((int)Code.InvalidArgument, exception.Response.Error.Code);
        }

        [Fact]
        public void DetectFaces_BadImage()
        {
            var client = ImageAnnotatorClient.Create();
            var exception = Assert.Throws<AnnotateImageException>(() => client.DetectFaces(s_badImage));
            Assert.Equal((int)Code.InvalidArgument, exception.Response.Error.Code);
        }

        [Fact]
        public void DetectSafeSearch_BadImage()
        {
            var client = ImageAnnotatorClient.Create();
            var exception = Assert.Throws<AnnotateImageException>(() => client.DetectSafeSearch(s_badImage));
            // TODO: Re-enable this assertion. At the moment the code is "Internal"...
            // Assert.Equal((int)Code.InvalidArgument, exception.Response.Error.Code);
        }

        // No "bad image" tests for the other Detect* methods; the behaviour is covered by the above.
    }
}
