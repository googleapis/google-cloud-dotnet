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

        // TODO: Should this just throw an exception instead?
        [Fact]
        public void AnnotateImage_BadImage()
        {
            var client = ImageAnnotatorClient.Create();
            var response = client.Annotate(new AnnotateImageRequest
            {
                Image = s_badImage,
                Features = { new Feature { Type = Feature.Types.Type.FaceDetection } }
            });
            Assert.NotNull(response.Error);
            Assert.Equal((int)Code.InvalidArgument, response.Error.Code);            
        }

        // TODO: Should this just throw an exception instead?
        [Fact]
        public void DetectFaces_BadImage()
        {
            var client = ImageAnnotatorClient.Create();
            var result = client.DetectFaces(s_badImage);
            Assert.NotNull(result.Error);
            Assert.Equal((int)Code.InvalidArgument, result.Error.Code);
        }

        // TODO: Here we lose the error entirely! Throw an exception?
        // Awaiting more information from the API team.
        [Fact]
        public void DetectSafeSearch_BadImage()
        {
            var client = ImageAnnotatorClient.Create();
            var result = client.DetectSafeSearch(s_badImage);
            Assert.Null(result);
        }

        // No "bad image" tests for the other Detect* methods; the behaviour is covered by the above.
    }
}
