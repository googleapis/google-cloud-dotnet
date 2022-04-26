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
    public class HttpLogEntryLabelProviderTest
    {
        [Fact]
        public void ThrowsWithoutHttpContextAccessor()
        {
            Assert.Throws<ArgumentNullException>(
                "httpContextAccessor",
                () => new DummyHttpLogEntryLabelProvider(httpContextAccessor: null));
        }

        [Fact]
        public void DoesNotCallInvokeCoreWhenNoHttpContext()
        {
            // Arrange
            var instance = new ThrowingHttpLogEntryLabelProvider(Mock.Of<IHttpContextAccessor>());
            var labels = new Dictionary<string, string>();

            // Act
            // Should not throw because InvokeCore is never called and add any labels
            instance.Invoke(labels);

            // Assert
            Assert.Empty(labels);
        }

        [Fact]
        public void CallsInvokeCore()
        {
            // Arrange
            var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
            mockHttpContextAccessor.Setup(x => x.HttpContext).Returns(Mock.Of<HttpContext>());
            var instance = new DummyHttpLogEntryLabelProvider(mockHttpContextAccessor.Object);
            var labels = new Dictionary<string, string>();

            // Act
            instance.Invoke(labels);

            // Assert
            Assert.Single(labels);
            Assert.Equal("foo", labels.First().Key);
            Assert.Equal("bar", labels.First().Value);
        }

        private class DummyHttpLogEntryLabelProvider : HttpLogEntryLabelProvider
        {
            public DummyHttpLogEntryLabelProvider(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
            {
            }

            protected override void InvokeCore(Dictionary<string, string> labels, HttpContext httpContext)
            {
                labels["foo"] = "bar";
            }
        }

        private class ThrowingHttpLogEntryLabelProvider : HttpLogEntryLabelProvider
        {
            public ThrowingHttpLogEntryLabelProvider(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
            {
            }

            protected override void InvokeCore(Dictionary<string, string> labels, HttpContext httpContext) => throw new NotImplementedException();
        }
    }
}
