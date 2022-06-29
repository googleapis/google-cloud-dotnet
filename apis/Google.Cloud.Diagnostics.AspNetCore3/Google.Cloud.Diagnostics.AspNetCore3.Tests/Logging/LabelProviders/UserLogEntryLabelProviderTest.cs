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
using System.Security.Claims;
using System.Security.Principal;
using Microsoft.AspNetCore.Http;
using Moq;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore3.Tests
{
    public class UserLogEntryLabelProviderTest
    {
        [Fact]
        public void ThrowsWithoutHttpContextAccessor()
        {
            Assert.Throws<ArgumentNullException>(
                "httpContextAccessor",
                () => new UserLogEntryLabelProvider(httpContextAccessor: null));
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void AddsUserAuthenticatedLabel(bool authenticated)
        {
            // Arrange
            var mockHttpContext = new Mock<HttpContext>();
            mockHttpContext.Setup(x => x.User.Identity.IsAuthenticated).Returns(authenticated);

            var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
            mockHttpContextAccessor.Setup(x => x.HttpContext).Returns(mockHttpContext.Object);

            var instance = new UserLogEntryLabelProvider(mockHttpContextAccessor.Object);
            var labels = new Dictionary<string, string>();

            // Act
            instance.Invoke(labels);

            // Assert
            Assert.Single(labels);
            var label = labels.Single();
            Assert.Equal("user_authenticated", label.Key);
            Assert.Equal(authenticated.ToString(), label.Value);
        }

        [Fact]
        public void AddsUserNameLabelWithUserName()
        {
            // Arrange
            var mockHttpContext = new Mock<HttpContext>();
            mockHttpContext.Setup(x => x.User.Identity.IsAuthenticated).Returns(true);
            mockHttpContext.Setup(x => x.User.Identity.Name).Returns("Foo");

            var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
            mockHttpContextAccessor.Setup(x => x.HttpContext).Returns(mockHttpContext.Object);

            var instance = new UserLogEntryLabelProvider(mockHttpContextAccessor.Object);
            var labels = new Dictionary<string, string>();

            // Act
            instance.Invoke(labels);

            // Assert
           var expected = new Dictionary<string, string>
            {
                { "user_authenticated", true.ToString() },
                { "user_name", "Foo" }
            };
            Assert.Equal(expected, labels);
        }

        [Theory]
        [InlineData("sub")]
        [InlineData(ClaimTypes.Name)]
        [InlineData(ClaimTypes.NameIdentifier)]
        public void AddsUserNameLabelWithUserNameFromClaim(string claimType)
        {
            // Arrange
            var mockHttpContext = new Mock<HttpContext>();
            mockHttpContext.Setup(x => x.User.Identity).Returns(new ClaimsIdentity(new[] { new Claim(claimType, "Foo") }, "Cookies"));

            var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
            mockHttpContextAccessor.Setup(x => x.HttpContext).Returns(mockHttpContext.Object);

            var instance = new UserLogEntryLabelProvider(mockHttpContextAccessor.Object);
            var labels = new Dictionary<string, string>();

            // Act
            instance.Invoke(labels);

            // Assert
            var expected = new Dictionary<string, string>
            {
                { "user_authenticated", true.ToString() },
                { "user_name", "Foo" }
            };
            Assert.Equal(expected, labels);
        }

        [Fact]
        public void DoesNotAddWhenNoUser()
        {
            var mockHttpContext = new Mock<HttpContext>();
            mockHttpContext.Setup(x => x.User).Returns((ClaimsPrincipal)null);
            AssertLabelsEmpty(mockHttpContext);
        }

        [Fact]
        public void DoesNotAddWhenNoUserIdentity()
        {
            var mockHttpContext = new Mock<HttpContext>();
            mockHttpContext.Setup(x => x.User.Identity).Returns((IIdentity)null);
            AssertLabelsEmpty(mockHttpContext);
        }

        private static void AssertLabelsEmpty(Mock<HttpContext> mockHttpContext)
        {
            // Arrange
            var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
            mockHttpContextAccessor.Setup(x => x.HttpContext).Returns(mockHttpContext.Object);

            // Act
            var instance = new UserLogEntryLabelProvider(mockHttpContextAccessor.Object);
            var labels = new Dictionary<string, string>();
            instance.Invoke(labels);

            // Assert
            Assert.Empty(labels);
        }
    }
}
