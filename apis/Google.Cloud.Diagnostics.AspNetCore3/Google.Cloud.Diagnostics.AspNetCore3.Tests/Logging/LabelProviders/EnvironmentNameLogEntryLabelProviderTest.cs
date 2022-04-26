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
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Moq;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore3.Tests
{
    public class EnvironmentNameLogEntryLabelProviderTest
    {
        [Fact]
        public void ThrowsWithoutHostingEnvironment()
        {
            Assert.Throws<ArgumentNullException>(
                "hostingEnvironment",
                () => new EnvironmentNameLogEntryLabelProvider(hostingEnvironment: null));
        }

        [Fact]
        public void AddsEnvironmentNameLabel()
        {
            // Arrange
            var hostingEnvironmentMock = new Mock<IWebHostEnvironment>();
            string expectedEnvironment = Environments.Production;

            hostingEnvironmentMock.Setup(x => x.EnvironmentName).Returns(expectedEnvironment);

            var instance = new EnvironmentNameLogEntryLabelProvider(hostingEnvironmentMock.Object);
            var labels = new Dictionary<string, string>();

            // Act
            instance.Invoke(labels);

            // Assert
            Assert.Single(labels);
            var label = labels.Single();
            Assert.Equal("aspnetcore_environment", label.Key);
            Assert.Equal(expectedEnvironment, label.Value);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void SkipsNullOrEmptyEnvironmentName(string label)
        {
            // Arrange
            var hostingEnvironmentMock = new Mock<IWebHostEnvironment>();
            hostingEnvironmentMock.Setup(x => x.EnvironmentName).Returns(label);

            var instance = new EnvironmentNameLogEntryLabelProvider(hostingEnvironmentMock.Object);
            var labels = new Dictionary<string, string>();

            // Act
            instance.Invoke(labels);

            // Assert
            Assert.Empty(labels);
        }
    }
}
