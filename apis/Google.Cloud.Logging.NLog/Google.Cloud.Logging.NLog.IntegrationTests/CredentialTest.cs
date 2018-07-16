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

using Google.Cloud.ClientTesting;
using NLog;
using NLog.Common;
using NLog.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Logging.NLog.IntegrationTests
{
    [SnippetOutputCollector]
    [Collection(nameof(NLogFixture))]
    public class CredentialTest
    {
        public CredentialTest(NLogFixture fixture) => _fixture = fixture;

        private readonly NLogFixture _fixture;

        private AsyncContinuation MakeContinuation(TaskCompletionSource<int> tcs) => ex =>
        {
            if (ex != null)
            {
                tcs.SetException(ex);
            }
            else
            {
                tcs.SetResult(0);
            }
        };

        private async Task AssertAsync<T>(GoogleStackdriverTarget target, bool shouldSucceed) where T : Exception
        {
            // ConfigureForTargetLogging() and a write are both required to trigger target initialization.
            SimpleConfigurator.ConfigureForTargetLogging(target);
            var tcs = new TaskCompletionSource<int>();
            target.WriteAsyncLogEvent(new AsyncLogEventInfo(LogEventInfo.CreateNullEvent(), MakeContinuation(tcs)));
            if (shouldSucceed)
            {
                // On "succees", a KeyNotFoundException is thrown, as we're using an empty LogEventInfo.
                // This does depend on an NLog implementation detail, but provides a simple way to test
                // the success case that doesn't actually log anything.
                await Assert.ThrowsAsync<KeyNotFoundException>(() => tcs.Task);
            }
            else
            {
                var nlogEx = await Assert.ThrowsAsync<NLogRuntimeException>(() => tcs.Task);
                Assert.IsType<T>(nlogEx.InnerException);
            }
        }

        [Fact]
        public async Task LoadCredentialFromFile()
        {
            var badTarget = new GoogleStackdriverTarget
            {
                ProjectId = "a_project_id",
                CredentialFile = "non-existent-file",
            };
            // Check that the appender attempts to load the non-existent credential file.
            await AssertAsync<FileNotFoundException>(badTarget, shouldSucceed: false);

            var goodTarget = new GoogleStackdriverTarget
            {
                ProjectId = "a_project_id",
                CredentialFile = _fixture.GoogleApplicationCredentials,
            };
            // Check that the valid credential file loads successfully.
            await AssertAsync<FileNotFoundException>(goodTarget, shouldSucceed: true);
        }

        [Fact]
        public async Task LoadCredentialFromJson()
        {
            var badTarget = new GoogleStackdriverTarget
            {
                ProjectId = "a_project_id",
                CredentialJson = "terrible json",
            };
            // Check that the appender attempts to load the non-existent credential file.
            await AssertAsync<InvalidOperationException>(badTarget, shouldSucceed: false);

            var goodTarget = new GoogleStackdriverTarget
            {
                ProjectId = "a_project_id",
                CredentialJson = File.ReadAllText(_fixture.GoogleApplicationCredentials),
            };
            // Check that the valid credential file loads successfully.
            await AssertAsync<InvalidOperationException>(goodTarget, shouldSucceed: true);
        }
    }
}
