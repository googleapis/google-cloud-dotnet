// Copyright 2018 Google LLC
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
using System;
using System.IO;
using Xunit;

namespace Google.Cloud.Logging.Log4Net.IntegrationTests
{
    [SnippetOutputCollector]
    [Collection(nameof(Log4NetFixture))]
    public class CredentialTests
    {
        public CredentialTests(Log4NetFixture fixture) => _fixture = fixture;

        private Log4NetFixture _fixture;

        [Fact]
        public void LoadCredentialFromFile()
        {
            var badAppender = new GoogleStackdriverAppender
            {
                ProjectId = _fixture.ProjectId,
                LogId = "irrelevant",
                CredentialFile = "non-existent-file",
            };
            // Check that the appender attempts to load the non-existent credential file.
            Assert.Throws<FileNotFoundException>(() => badAppender.ActivateOptions());

            var goodAppender = new GoogleStackdriverAppender
            {
                ProjectId = _fixture.ProjectId,
                LogId = "irrelevant",
                CredentialFile = _fixture.GoogleApplicationCredentials,
            };
            // Check that the valid credential file loads successfully.
            goodAppender.ActivateOptions();
            // No need to do any logging; if the appender activated successfully then the credential must have loaded.
        }

        [Fact]
        public void LoadCredentialFromJson()
        {
            var badAppender = new GoogleStackdriverAppender
            {
                ProjectId = _fixture.ProjectId,
                LogId = "irrelevant",
                CredentialJson = "terrible json",
            };
            // Check that the appender attempts to load the invalid JSON
            var ex = Assert.Throws<InvalidOperationException>(() => badAppender.ActivateOptions());
            Assert.Contains("JSON", ex.Message.ToUpperInvariant());

            var goodAppender = new GoogleStackdriverAppender
            {
                ProjectId = _fixture.ProjectId,
                LogId = "irrelevant",
                CredentialJson = File.ReadAllText(_fixture.GoogleApplicationCredentials),
            };
            // Check that the valid credential JSON loads successfully.
            goodAppender.ActivateOptions();
            // No need to do any logging; if the appender activated successfully then the credential must have loaded.
        }
    }
}
