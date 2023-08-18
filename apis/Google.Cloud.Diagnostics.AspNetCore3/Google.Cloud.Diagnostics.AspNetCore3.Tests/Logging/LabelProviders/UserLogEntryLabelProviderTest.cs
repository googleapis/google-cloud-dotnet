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

using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
            var identity = new ClaimsIdentity(authenticated ? "fake-authentication-type" : null);
            var httpContext = new DefaultHttpContext { User = new ClaimsPrincipal(identity) };
            var httpContextAccessor = new HttpContextAccessor { HttpContext = httpContext };

            var instance = new UserLogEntryLabelProvider(httpContextAccessor);
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
            var identity = new ClaimsIdentity("fake-authentication-type", "fake-name-type", "fake-role-type");
            identity.AddClaim(new Claim("fake-name-type", "Foo"));
            var httpContext = new DefaultHttpContext { User = new ClaimsPrincipal(identity) };

            var httpContextAccessor = new HttpContextAccessor { HttpContext = httpContext };

            var instance = new UserLogEntryLabelProvider(httpContextAccessor);
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
            var identity = new ClaimsIdentity(new[] { new Claim(claimType, "Foo") }, "Cookies");
            var httpContext = new DefaultHttpContext { User = new ClaimsPrincipal(identity) };

            var httpContextAccessor = new HttpContextAccessor { HttpContext = httpContext };

            var instance = new UserLogEntryLabelProvider(httpContextAccessor);
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
        public void DoesNotAddWhenNoUserIdentity()
        {
            // Arrange
            var httpContext = new DefaultHttpContext();
            httpContext.User = new ClaimsPrincipal(new ClaimsIdentity[0]);
            var httpContextAccessor = new HttpContextAccessor { HttpContext = httpContext };

            // Check that we're actually testing what we think.
            Assert.Null(httpContext.User.Identity);

            // Act
            var instance = new UserLogEntryLabelProvider(httpContextAccessor);
            var labels = new Dictionary<string, string>();
            instance.Invoke(labels);

            // Assert
            Assert.Empty(labels);
        }
    }
}
