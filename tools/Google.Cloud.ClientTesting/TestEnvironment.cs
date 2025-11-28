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
using System.IO;
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
        public const string GoogleApplicationCredentialsEnvironmentVariable = "GOOGLE_APPLICATION_CREDENTIALS";
        public const string GoogleCloudTestsInVpcScEnvironmentVariable = "GOOGLE_CLOUD_TESTS_IN_VPCSC";

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
        public static bool IsWindows() => RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

        /// <summary>
        /// Determines whether or not the test is running on Linux.
        /// </summary>
        public static bool IsLinux() => RuntimeInformation.IsOSPlatform(OSPlatform.Linux);

        /// <summary>
        /// Throws a <see cref="SkipException"/> if the tests are running in a VPC-SC constrained environment.
        /// Note that tests can be skipped in this situation even if the MUST_NOT_SKIP_TESTS environment variable is set.
        /// </summary>
        public static void SkipIfVpcSc()
        {
            if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable(GoogleCloudTestsInVpcScEnvironmentVariable)))
            {
                throw new SkipException("Test skipped in VPCSC environment");
            }
        }

        /// <summary>
        /// Throws a <see cref="SkipException"/> if the tests are running in a "restricted" environment
        /// (crudely detected by the absence of the GOOGLE_APPLICATION_CREDENTIALS environment variable).
        /// Note that tests can be skipped in this situation even if the MUST_NOT_SKIP_TESTS environment variable is set.
        /// </summary>
        public static void SkipOnRestrictedEnvironment()
        {
            if (string.IsNullOrEmpty(Environment.GetEnvironmentVariable(GoogleApplicationCredentialsEnvironmentVariable)))
            {
                throw new SkipException("Test skipped in VPCSC environment");
            }
        }

        /// <summary>
        /// Finds the conformance-tests directory, throwing an exception if it's not present.
        /// </summary>
        public static string FindConformanceTestsDirectory()
        {
            var root = FindRepositoryRootDirectory();
            var tests = Path.Combine(root, "conformance-tests");
            return Directory.Exists(tests) ? tests : throw new InvalidOperationException("conformance-tests directory not found");
        }

        /// <summary>
        /// Finds the root directory of the repository by looking for common files.
        /// </summary>
        /// <returns></returns>
        public static string FindRepositoryRootDirectory()
        {
            var currentDirectory = Path.GetFullPath(".");
            var directory = new DirectoryInfo(currentDirectory);
            while (directory != null &&
                (!File.Exists(Path.Combine(directory.FullName, "LICENSE"))
                || !Directory.Exists(Path.Combine(directory.FullName, "apis"))))
            {
                directory = directory.Parent;
            }
            if (directory == null)
            {
                throw new InvalidOperationException("Unable to determine root directory. Please run within google-cloud-dotnet repository.");
            }
            return directory.FullName;
        }
    }
}
