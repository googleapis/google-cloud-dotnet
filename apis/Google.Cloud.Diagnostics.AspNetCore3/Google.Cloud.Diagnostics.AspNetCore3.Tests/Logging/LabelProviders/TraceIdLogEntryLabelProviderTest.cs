// Copyright 2018 Google Inc. All Rights Reserved.
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
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Moq;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore3.Tests
{
    public class TraceIdLogEntryLabelProviderTest
    {
        [Fact]
        public void ThrowsWithoutHttpContextAccessor()
        {
            Assert.Throws<ArgumentNullException>(
                "httpContextAccessor",
                () => new TraceIdLogEntryLabelProvider(httpContextAccessor: null));
        }

        [Fact]
        public void AddsTraceIdLabel()
        {
            // Arrange
            var traceId = Guid.NewGuid().ToString();

            var mockHttpContext = new Mock<HttpContext>();
            mockHttpContext.Setup(x => x.TraceIdentifier).Returns(traceId);

            var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
            mockHttpContextAccessor.Setup(x => x.HttpContext).Returns(mockHttpContext.Object);

            var instance = new TraceIdLogEntryLabelProvider(mockHttpContextAccessor.Object);
            var labels = new Dictionary<string, string>();

            // Act
            instance.Invoke(labels);

            // Assert
            Assert.Single(labels);
            var label = labels.Single();
            Assert.Equal("trace_identifier", label.Key);
            Assert.Equal(traceId, label.Value);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void DoesNotAddWhenNoTraceId(string traceId)
        {
            // Arrange
            var mockHttpContext = new Mock<HttpContext>();
            mockHttpContext.Setup(x => x.TraceIdentifier).Returns(traceId);

            var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
            mockHttpContextAccessor.Setup(x => x.HttpContext).Returns(mockHttpContext.Object);

            var instance = new TraceIdLogEntryLabelProvider(mockHttpContextAccessor.Object);
            var labels = new Dictionary<string, string>();

            // Act
            instance.Invoke(labels);

            // Assert
            Assert.Empty(labels);
        }
    }
}
