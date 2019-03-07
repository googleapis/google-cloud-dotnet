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
using Xunit;

namespace Google.Cloud.ClientTesting
{
    /// <summary>
    /// Utility methods for determining aspects of the test environment,
    /// typically through environment variables.
    /// </summary>
    public static class TestEnvironment
    {
        public const string TestProjectEnvironmentVariable = "TEST_PROJECT";
        public const string ProjectLocationEnvironmentVariable = "TEST_PROJECT_LOCATION";

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
        /// Returns the location ID of the test project.
        /// </summary>
        /// <returns>The project ID, which is validated to be non-null and non-empty.</returns>
        public static string GetProjectLocationId()
        {
            string locationId = Environment.GetEnvironmentVariable(ProjectLocationEnvironmentVariable);
            if (string.IsNullOrEmpty(locationId))
            {
                throw new InvalidOperationException(
                    $"Please set the {ProjectLocationEnvironmentVariable} environment variable to your test project location ID before running tests");
            }
            return locationId;
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

        /// <summary>
        /// Throws a <see cref="SkipException"/> if the tests are running in a VPC-SC constrained environment.
        /// Note that tests can be skipped in this situation even if the MUST_NOT_SKIP_TESTS environment variable is set.
        /// </summary>
        public static void SkipIfVpcSc()
        {
            if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("GOOGLE_CLOUD_TESTS_IN_VPCSC")))
            {
                throw new SkipException("Test skipped in VPCSC environment");
            }
        }
    }
}
