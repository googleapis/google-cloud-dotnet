// Copyright 2021 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Cloud.ClientTesting;
using Google.Cloud.Diagnostics.Common.IntegrationTests;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Snippets
{

    public class ErrorReportingSnippets
    {
        public const string Service = EntryData.Service;
        public const string Version = EntryData.Version;
        private static readonly string ProjectId = TestEnvironment.GetTestProjectId();

        private readonly string _testId;

        public ErrorReportingSnippets()
        {
            _testId = IdGenerator.FromDateTime();
        }

        private static class DefaultHostBuilder
        {
            // Sample: Configure
            public static IHostBuilder CreateHostBuilder() =>
                new HostBuilder()
                    .ConfigureServices(services =>
                    {
                        services.AddGoogleErrorReporting(new ErrorReportingServiceOptions 
                        {
                            // Replace ProjectId with your Google Cloud Project ID.
                            ProjectId = ProjectId,
                            // Replace Service with a name or identifier for the service.
                            ServiceName = Service,
                            // Replace Version with a version for the service.
                            Version = Version
                        });
                        // Register other services here if you need them.
                    });
            // End sample
        }

        [Fact]
        public async Task LogsExceptionAsync()
        {
            // Naming it like a static variable so that it looks like that on sample code.
            IHost s_host = null;
            // To hide the diferentiating class.
            Func<IHostBuilder> CreateHostBuilder = DefaultHostBuilder.CreateHostBuilder;

            try
            {
                // Sample: Start
                s_host = CreateHostBuilder().Build();
                await s_host.StartAsync();
                // End sample

                // Sample: LogException
                IContextExceptionLogger exceptionLogger = s_host.Services.GetRequiredService<IContextExceptionLogger>();
                try
                {
                    // This method call throws an exception.
                    ThrowsException();
                }
                catch (Exception e)
                {
                    // The logger may receive an IContextWrapper as a second parameter
                    // with information about the HTTP operation, if any, that produced
                    // the error. It may be null in which case it will be ignored.
                    exceptionLogger.Log(e, null);
                }
                // End sample

                var errorEvent = ErrorEventEntryVerifiers.VerifySingle(ErrorEventEntryPolling.Default, _testId);
                ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(
                    errorEvent, _testId, nameof(ThrowsException), verifyHttpContext: false);
            }
            finally
            {
                if (s_host is object)
                {
                    await s_host.StopAsync();
                }
            }
        }

        private void ThrowsException() => throw new Exception(_testId);
    }
}
