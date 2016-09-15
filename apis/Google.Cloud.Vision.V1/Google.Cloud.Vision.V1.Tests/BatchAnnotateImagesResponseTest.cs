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
using System.Linq;
using Xunit;

namespace Google.Cloud.Vision.V1.Tests
{
    public class BatchAnnotateImagesResponseTest
    {
        [Fact]
        public void ThrowOnAnyError_NoErrors()
        {
            var response = new BatchAnnotateImagesResponse
            {
                Responses =
                {
                    new AnnotateImageResponse { TextAnnotations = { new EntityAnnotation { Description = "X" } } },
                    new AnnotateImageResponse { LandmarkAnnotations = { new EntityAnnotation { Description = "Y" } } },
                }
            };
            Assert.Same(response, response.ThrowOnAnyError());
        }

        [Fact]
        public void ThrowOnAnyError_OneError()
        {
            var response = new BatchAnnotateImagesResponse
            {
                Responses =
                {
                    new AnnotateImageResponse { TextAnnotations = { new EntityAnnotation { Description = "X" } } },
                    new AnnotateImageResponse { Error = new Rpc.Status { Message = "Bang" } }
                }
            };
            var exception = Assert.Throws<AggregateException>(() => response.ThrowOnAnyError());
            var nestedException = (AnnotateImageException)exception.InnerExceptions[0];
            Assert.Equal("Bang", nestedException.Message);
            Assert.Same(response.Responses[1], nestedException.Response);
        }

        [Fact]
        public void ThrowOnAnyError_MultipleErrors()
        {
            var response = new BatchAnnotateImagesResponse
            {
                Responses =
                {
                    new AnnotateImageResponse { Error = new Rpc.Status { Message = "Boom" } },
                    new AnnotateImageResponse { TextAnnotations = { new EntityAnnotation { Description = "X" } } },
                    new AnnotateImageResponse { Error = new Rpc.Status { Message = "Bang" } }
                }
            };
            var exception = Assert.Throws<AggregateException>(() => response.ThrowOnAnyError());
            var nestedExceptions = exception.InnerExceptions.Cast<AnnotateImageException>().ToList();
            Assert.Equal(2, nestedExceptions.Count);
            Assert.Equal("Boom", nestedExceptions[0].Message);
            Assert.Equal("Bang", nestedExceptions[1].Message);
            Assert.Same(response.Responses[0], nestedExceptions[0].Response);
            // response.Responses[1] is skipped as it had no error.
            Assert.Same(response.Responses[2], nestedExceptions[1].Response);
        }
    }
}
