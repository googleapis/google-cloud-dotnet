// Copyright 2017, Google Inc. All rights reserved.
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
using System;
using Xunit;

namespace Google.Cloud.Debugger.V2.Snippets
{
    [SnippetOutputCollector]
    [Collection(nameof(DebuggerServiceFixture))]
    public class Controller2ClientSnippets
    {
        private readonly DebuggerServiceFixture _fixture;

        public Controller2ClientSnippets(DebuggerServiceFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void RegisterDebuggee()
        {
            string projectId = _fixture.ProjectId;
            string agentVersion = "google.com/csharp/v1.0";
            string description = "module - version";
            string uniquifier = "uniquifier";
            // Sample: RegisterDebuggee
            Controller2Client client = Controller2Client.Create();
            Debuggee debuggee = new Debuggee
            {
                Project = projectId,
                AgentVersion = agentVersion,
                Description = description,
                Uniquifier = uniquifier,
            };
            RegisterDebuggeeResponse response = client.RegisterDebuggee(debuggee);
            Console.WriteLine($"Debugee Id: ${response.Debuggee.Id}");
            // End sample
        }
    }
}
