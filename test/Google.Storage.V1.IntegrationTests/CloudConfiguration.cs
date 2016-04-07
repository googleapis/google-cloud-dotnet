// Copyright 2015 Google Inc. All Rights Reserved.
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
using System.Threading.Tasks;

namespace Google.Storage.V1.IntegrationTests
{
    /// <summary>
    /// Represents all the environmental information we need for integration tests,
    /// such as project name. We assume the user has already authenticated with gcloud auth.
    /// Currently a singleton, which is a bit of a smell... but we can refactor when we have better
    /// understanding of what we need.
    /// </summary>
    internal sealed class CloudConfiguration
    {
        private const string ProjectEnvironmentVariable = "TEST_PROJECT";

        internal static CloudConfiguration Instance { get; } = FromEnvironmentVariables();

        internal string Project { get; }
        internal string TempBucketPrefix { get; }
        internal StorageClient Client { get; }

        private CloudConfiguration(string project)
        {
            Project = project;
            Client = Task.Run(async () => await StorageClient.FromApplicationCredentials("Test")).Result;
            TempBucketPrefix = Project + "_integrationtests-";
        }

        private static CloudConfiguration FromEnvironmentVariables()
        {
            var project = Environment.GetEnvironmentVariable(ProjectEnvironmentVariable);
            if (string.IsNullOrEmpty(project))
            {
                throw new InvalidOperationException($"Please set {ProjectEnvironmentVariable} before running tests");
            }
            return new CloudConfiguration(project);
        }
    }
}
