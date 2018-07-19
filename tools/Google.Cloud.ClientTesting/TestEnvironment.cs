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

using System;
using System.Runtime.InteropServices;

namespace Google.Cloud.ClientTesting
{
    /// <summary>
    /// Utility methods for determining aspects of the test environment,
    /// typically through environment variables.
    /// </summary>
    public static class TestEnvironment
    {
        public const string TestProjectEnvironmentVariable = "TEST_PROJECT";

        /// <summary>
        /// Returns the project ID to use for testing.
        /// </summary>
        /// <param name="testProjectEnvironmentVariable">The environment variable to check, defaulting to TEST_PROJECT</param>
        /// <returns>The project ID, which is validated to be non-null and non-empty.</returns>
        public static string GetTestProjectId(string testProjectEnvironmentVariable = TestProjectEnvironmentVariable)
        {
            string projectId = Environment.GetEnvironmentVariable(testProjectEnvironmentVariable);
            if (string.IsNullOrEmpty(projectId))
            {
                throw new InvalidOperationException(
                    $"Please set the {testProjectEnvironmentVariable} environment variable to your test project ID before running tests");
            }
            return projectId;
        }

        /// <summary>
        /// Determines whether or not the test is running on Windows.
        /// </summary>
        /// <returns></returns>
        public static bool IsWindows()
        {
#if NET452
            return Environment.OSVersion.ToString().Contains("Windows");
#else
            return RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
#endif

        }
    }
}
