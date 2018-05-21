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

using System.Reflection;
using Xunit.Sdk;

namespace Google.Cloud.ClientTesting
{
    /// <summary>
    /// When applied to a class or method, the start and end of each test is logged with
    /// <see cref="FileLogger"/>.
    /// </summary>
    public class FileLoggerBeforeAfterTestAttribute : BeforeAfterTestAttribute
    {
        public override void Before(MethodInfo methodUnderTest) => Log(methodUnderTest, "Starting");

        public override void After(MethodInfo methodUnderTest) => Log(methodUnderTest, "Finished");

        private void Log(MethodInfo method, string message) =>
            FileLogger.Log($"{method.DeclaringType.Name}.{method.Name}: {message}");
    }
}
