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

namespace Google.Cloud.VideoIntelligence.V1.Tests
{
    public class AnnotateVideoResponseTest
    {
        [Fact]
        public void ThrowOnAnyError_NoErrors()
        {
            var response = new AnnotateVideoResponse
            {
                AnnotationResults =
                {
                    new VideoAnnotationResults { ExplicitAnnotation = new ExplicitContentAnnotation() },
                    new VideoAnnotationResults { FaceAnnotations = { new FaceAnnotation() } }
                }
            };
            Assert.Same(response, response.ThrowOnAnyError());
        }

        [Fact]
        public void ThrowOnAnyError_OneError()
        {
            var response = new AnnotateVideoResponse
            {
                AnnotationResults =
                {
                    new VideoAnnotationResults { FaceAnnotations = { new FaceAnnotation() } },
                    new VideoAnnotationResults { Error = new Rpc.Status { Message = "Bang" } }
                }
            };
            var exception = Assert.Throws<AggregateException>(() => response.ThrowOnAnyError());
            var nestedException = (AnnotateVideoException) exception.InnerExceptions[0];
            Assert.Equal("Bang", nestedException.Message);
            Assert.Same(response.AnnotationResults[1], nestedException.Response);
        }

        [Fact]
        public void ThrowOnAnyError_MultipleErrors()
        {
            var response = new AnnotateVideoResponse
            {
                AnnotationResults =
                {
                    new VideoAnnotationResults { Error = new Rpc.Status { Message = "Boom" } },
                    new VideoAnnotationResults { ExplicitAnnotation = new ExplicitContentAnnotation() },
                    new VideoAnnotationResults { Error = new Rpc.Status { Message = "Bang" } }
                }
            };
            var exception = Assert.Throws<AggregateException>(() => response.ThrowOnAnyError());
            var nestedExceptions = exception.InnerExceptions.Cast<AnnotateVideoException>().ToList();
            Assert.Equal(2, nestedExceptions.Count);
            Assert.Equal("Boom", nestedExceptions[0].Message);
            Assert.Equal("Bang", nestedExceptions[1].Message);
            Assert.Same(response.AnnotationResults[0], nestedExceptions[0].Response);
            // response.AnnotationResults[1] is skipped as it had no error.
            Assert.Same(response.AnnotationResults[2], nestedExceptions[1].Response);
        }
    }
}
