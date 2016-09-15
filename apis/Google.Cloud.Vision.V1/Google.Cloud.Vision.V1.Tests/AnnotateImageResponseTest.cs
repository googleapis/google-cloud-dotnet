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

using Xunit;

namespace Google.Cloud.Vision.V1.Tests
{
    public class AnnotateImageResponseTest
    {
        [Fact]
        public void ThrowOnError_NoError()
        {
            var response = new AnnotateImageResponse { TextAnnotations = { new EntityAnnotation { Description = "X" } } };
            Assert.Same(response, response.ThrowOnError());
        }

        [Fact]
        public void ThrowOnError_Error()
        {
            var response = new AnnotateImageResponse { Error = new Rpc.Status { Message = "Bang" } };
            var exception = Assert.Throws<AnnotateImageException>(() => response.ThrowOnError());
            Assert.Equal("Bang", exception.Message);
            Assert.Same(response, exception.Response);
        }
    }
}
