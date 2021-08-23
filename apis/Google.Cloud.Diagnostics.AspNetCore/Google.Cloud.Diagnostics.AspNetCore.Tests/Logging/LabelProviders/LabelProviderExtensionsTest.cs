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

using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Xunit;

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3.Tests
#elif NETCOREAPP2_1 || NET461
namespace Google.Cloud.Diagnostics.AspNetCore.Tests
#else
#error unknown target framework
#endif
{
    public class LoggingExtensionsTest
    {
        [Fact]
        public void AddsServiceFromType()
        {
            // Act
            var services = new ServiceCollection()
                .AddLogEntryLabelProvider<TraceIdLogEntryLabelProvider>();

            // Assert
            Assert.IsAssignableFrom<IServiceCollection>(services);
            Assert.Single(services);
            var descriptor = services.Single();

            Assert.Equal(typeof(Common.ILogEntryLabelProvider), descriptor.ServiceType);
            Assert.Equal(typeof(TraceIdLogEntryLabelProvider), descriptor.ImplementationType);
            Assert.Equal(ServiceLifetime.Singleton, descriptor.Lifetime);
        }

        [Fact]
        public void AddsServiceFromFactory()
        {
            // Act
            var services = new ServiceCollection()
                .AddLogEntryLabelProvider(sp => new TraceIdLogEntryLabelProvider(sp.GetRequiredService<IHttpContextAccessor>()));

            // Assert
            Assert.IsAssignableFrom<IServiceCollection>(services);
            Assert.Single(services);
            var descriptor = services.Single();

            Assert.Equal(typeof(Common.ILogEntryLabelProvider), descriptor.ServiceType);
            Assert.NotNull(descriptor.ImplementationFactory);
            Assert.Equal(ServiceLifetime.Singleton, descriptor.Lifetime);
        }

        [Fact]
        public void AddsServiceFromInstance()
        {
            // Act
            var services = new ServiceCollection()
                .AddLogEntryLabelProvider(new TraceIdLogEntryLabelProvider(Mock.Of<IHttpContextAccessor>()));

            // Assert
            Assert.IsAssignableFrom<IServiceCollection>(services);
            Assert.Single(services);
            var descriptor = services.Single();

            Assert.Equal(typeof(Common.ILogEntryLabelProvider), descriptor.ServiceType);
            Assert.IsType<TraceIdLogEntryLabelProvider>(descriptor.ImplementationInstance);
            Assert.Equal(ServiceLifetime.Singleton, descriptor.Lifetime);
        }
    }
}
