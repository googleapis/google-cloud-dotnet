// Copyright 2016 Google Inc. All Rights Reserved.
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
// limitations under the License.using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Globalization;

namespace Google.Devtools.AspNet.IntegrationTests
{
    public static class Utils
    {
        private const string ProjectEnvironmentVariable = "TEST_PROJECT";

        /// <returns>The test project Id.</returns>
        /// <exception cref="InvalidOperationException">If the 'TEST_PROJECT' environment
        /// variable is not set or empty</exception>
        public static string GetProjectIdFromEnvironment()
        {
            string projectId = Environment.GetEnvironmentVariable(ProjectEnvironmentVariable);
            if (string.IsNullOrEmpty(projectId))
            {
                throw new InvalidOperationException(
                    $"Please set the {ProjectEnvironmentVariable} environment variable before running tests");
            }
            return projectId;
        }

        /// <returns>An Id based on the date and time.</returns>
        public static string GetTestId()
        {
            return DateTime.UtcNow.ToString("'test'_yyyyMMddTHHmmssFFF", CultureInfo.InvariantCulture);
        }
    }
}
