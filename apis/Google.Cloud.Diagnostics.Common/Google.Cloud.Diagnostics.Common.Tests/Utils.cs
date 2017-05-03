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
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    internal class Utils
    {
        private const string _projectEnvironmentVariable = "TEST_PROJECT";

        /// <returns>The test project Id.</returns>
        /// <exception cref="InvalidOperationException">If the 'TEST_PROJECT' environment
        /// variable is not set or empty</exception>
        public static string GetProjectIdFromEnvironment()
        {
            string projectId = Environment.GetEnvironmentVariable(_projectEnvironmentVariable);
            if (string.IsNullOrEmpty(projectId))
            {
                throw new InvalidOperationException(
                    $"Please set the {_projectEnvironmentVariable} environment variable before running tests");
            }
            return projectId;
        }

        public static bool IsWindows()
        {
#if NET452
            return Environment.OSVersion.ToString().Contains("Windows");
#else
            return RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
#endif

        }

        /// <summary>A unique test Id.</summary>
        public static string GetTestId()
        {
            return Guid.NewGuid().ToString();
        }

        public static class ConstantSizer<T>
        {
            /// <summary>Always returns 2.</summary>
            public static int GetSize(T item) => 2;
        }

        /// <summary>
        /// An <see cref="IConsumer{T}"/> for ints.
        /// </summary>
        public class IntConsumer : IConsumer<int>
        {
            /// <summary>Does nothing with the passed in items.</summary>
            public void Receive(IEnumerable<int> items) {}

            /// <summary>Does nothing with the passed in items.</summary>
            public Task ReceiveAsync(IEnumerable<int> items, CancellationToken cancellationToken) => 
                CommonUtils.CompletedTask;

            /// <inheritdoc />
            public void Dispose() { }
        }
    }
}
