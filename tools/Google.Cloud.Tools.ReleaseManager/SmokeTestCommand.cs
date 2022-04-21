// Copyright 2020 Google LLC
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

using Google.Cloud.Tools.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Google.Cloud.Tools.ReleaseManager
{
    /// <summary>
    /// A command to execute all the smoke tests defined in JSON for an API.
    /// The tests are expected to be defined in a file called smoketests.json in the root of the API folder,
    /// e.g. apis/Google.Cloud.Vision.V1/smoketests.json
    /// </summary>
    public class SmokeTestCommand : CommandBase
    {
        private const string TestTargetFramework = "netcoreapp3.1";
        private const string TestProjectEnvironmentVariable = "TEST_PROJECT";

        public SmokeTestCommand()
            : base("smoke-test", "Runs smoke tests for a package", "id")
        {
        }

        protected override void ExecuteImpl(string[] args)
        {
            string id = args[0];
            string projectId = Environment.GetEnvironmentVariable(TestProjectEnvironmentVariable);
            if (string.IsNullOrEmpty(projectId))
            {
                throw new UserErrorException($"Environment variable {TestProjectEnvironmentVariable} must be set before running smoke tests");
            }

            var smokeTests = LoadSmokeTests(id);
            if (smokeTests.Count == 0)
            {
                Console.WriteLine($"No smoke tests defined for {id}");
                return;
            }

            var assembly = PublishUnitTestsAndLoadAssembly(id);
            RunTests(smokeTests, assembly, projectId);
        }

        private List<SmokeTest> LoadSmokeTests(string id)
        {
            var smokeTestsFile = Path.Combine(DirectoryLayout.ForApi(id).SourceDirectory, "smoketests.json");
            return File.Exists(smokeTestsFile)
                ? JsonConvert.DeserializeObject<List<SmokeTest>>(File.ReadAllText(smokeTestsFile))
                : new List<SmokeTest>();
        }

        private Assembly PublishUnitTestsAndLoadAssembly(string id)
        {
            // We publish the *test* project, as that's executable - so the appropriate gRPC native
            // libraries are published as well. (They're not published within the library project.)
            Console.WriteLine($"Publishing release version of unit test project");
            var sourceRoot = DirectoryLayout.ForApi(id).SourceDirectory;
            var testProject = $"{id}.Tests";
            Processes.RunDotnet(sourceRoot, "publish", "-nologo", "-clp:NoSummary", "-v", "quiet", "-c", "Release", testProject, "-f", TestTargetFramework);

            var assemblyFile = Path.Combine(sourceRoot, testProject, "bin", "Release", TestTargetFramework, "publish", $"{id}.dll");
            return Assembly.LoadFrom(assemblyFile);
        }

        private void RunTests(List<SmokeTest> tests, Assembly assembly, string projectId)
        {
            var testOrTests = tests.Count == 1 ? "test" : "tests";
            Console.WriteLine($"Running {tests.Count} smoke {testOrTests}");

            foreach (var test in tests)
            {
                test.Execute(assembly, projectId);
            }
        }
    }
}
