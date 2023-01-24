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
using Newtonsoft.Json.Linq;
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
        private const string PublishTargetFramework = "netstandard2.1";

        public SmokeTestCommand()
            : base("smoke-test", "Runs smoke tests for a package", "id")
        {
        }

        protected override void ExecuteImpl(string[] args)
        {
            string id = args[0];
            var smokeTests = LoadSmokeTests(id);
            if (smokeTests.Count == 0)
            {
                Console.WriteLine($"No smoke tests defined for {id}");
                return;
            }

            var assembly = PublishAndLoadAssembly(id);
            var templateVariables = CreateTemplateVariables();
            RunTests(smokeTests, assembly, templateVariables);
        }

        private List<SmokeTest> LoadSmokeTests(string id)
        {
            var smokeTestsFile = Path.Combine(DirectoryLayout.ForApi(id).SourceDirectory, "smoketests.json");
            return File.Exists(smokeTestsFile)
                ? JsonConvert.DeserializeObject<List<SmokeTest>>(File.ReadAllText(smokeTestsFile))
                : new List<SmokeTest>();
        }

        private Assembly PublishAndLoadAssembly(string id)
        {
            Console.WriteLine($"Publishing release version of library");
            var sourceRoot = DirectoryLayout.ForApi(id).SourceDirectory;
            Processes.RunDotnet(sourceRoot, "publish", "-nologo", "-clp:NoSummary", "-v", "quiet", "-c", "Release", id, "-f", PublishTargetFramework);

            var assemblyFile = Path.Combine(sourceRoot, id, "bin", "Release", PublishTargetFramework, "publish", $"{id}.dll");
            return Assembly.LoadFrom(assemblyFile);
        }

        private void RunTests(List<SmokeTest> tests, Assembly assembly, IReadOnlyDictionary<string, string> templateVariables)
        {
            var testOrTests = tests.Count == 1 ? "test" : "tests";
            Console.WriteLine($"Running {tests.Count} smoke {testOrTests}");

            foreach (var test in tests)
            {
                test.Execute(assembly, templateVariables);
            }
        }

        private static IReadOnlyDictionary<string, string> CreateTemplateVariables()
        {
            var ret = new Dictionary<string, string>();

            MaybeAddEnvironmentVariable("TEST_PROJECT", "PROJECT_ID");
            MaybeAddEnvironmentVariable("FIRESTORE_TEST_PROJECT", "FIRESTORE_PROJECT_ID");
            MaybeAddEnvironmentVariable("TEST_PROJECT_LOCATION", "PROJECT_APPENGINE_LOCATION");
            if (MaybeGetServiceAccountId() is string serviceAccountId)
            {
                ret["SERVICE_ACCOUNT_ID"] = serviceAccountId;
            }
            return ret;

            void MaybeAddEnvironmentVariable(string environmentVariableId, string templateVariableId)
            {
                var value = Environment.GetEnvironmentVariable(environmentVariableId);                
                if (!string.IsNullOrEmpty(value))
                {
                    ret[templateVariableId] = value;
                }
            }

            string MaybeGetServiceAccountId()
            {
                var credentialFile = Environment.GetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS");
                if (string.IsNullOrEmpty(credentialFile))
                {
                    return null;
                }
                var json = File.ReadAllText(credentialFile);
                var obj = JObject.Parse(json);
                return obj["type"] is JToken typeToken &&
                    typeToken.Value<string>() == "service_account" &&
                    obj["client_email"] is JToken clientEmailToken
                    ? clientEmailToken.Value<string>()
                    : null;
            }
        }
    }
}
