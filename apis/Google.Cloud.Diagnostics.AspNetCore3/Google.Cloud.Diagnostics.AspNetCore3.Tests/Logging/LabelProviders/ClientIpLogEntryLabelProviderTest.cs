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
using System.Net;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore3.Tests
{
    public class ClientIpLogEntryLabelProviderTest
    {
        [Fact]
        public void ThrowsWithoutHttpContextAccessor()
        {
            Assert.Throws<ArgumentNullException>(
                "httpContextAccessor",
                () => new ClientIpLogEntryLabelProvider(httpContextAccessor: null));
        }

        [Fact]
        public void AddClientIpLabel()
        {
            // Arrange
            var httpContext = new DefaultHttpContext { Connection = { RemoteIpAddress = IPAddress.Loopback } };
            var httpContextAccessor = new HttpContextAccessor { HttpContext = httpContext };

            var instance = new ClientIpLogEntryLabelProvider(httpContextAccessor);
            var labels = new Dictionary<string, string>();

            // Act
            instance.Invoke(labels);

            // Assert
            Assert.Single(labels);
            var label = labels.Single();
            Assert.Equal("client_ip", label.Key);
            Assert.Equal(IPAddress.Loopback.ToString(), label.Value);
        }

        [Fact]
        public void DoesNotAddWhenNoRemoteIp()
        {
            // Arrange
            var httpContext = new DefaultHttpContext { Connection = { RemoteIpAddress = null } };
            var httpContextAccessor = new HttpContextAccessor { HttpContext = httpContext };

            var instance = new ClientIpLogEntryLabelProvider(httpContextAccessor);
            var labels = new Dictionary<string, string>();

            // Act
            instance.Invoke(labels);

            // Assert
            Assert.Empty(labels);
        }
    }
}
