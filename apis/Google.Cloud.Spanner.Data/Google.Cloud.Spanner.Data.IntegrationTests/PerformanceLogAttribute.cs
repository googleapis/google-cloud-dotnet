// Copyright 2017 Google Inc. All Rights Reserved.
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

using System.Reflection;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Xunit.Sdk;

namespace Google.Cloud.Spanner.Data.IntegrationTests {
    internal class PerformanceLogAttribute : BeforeAfterTestAttribute
    {
        /// <inheritdoc />
        public override void Before(MethodInfo methodUnderTest)
        {
            Logger.DefaultLogger.LogPerformanceData();
            base.Before(methodUnderTest);
        }

        /// <inheritdoc />
        public override void After(MethodInfo methodUnderTest)
        {
            Logger.DefaultLogger.LogPerformanceData();
            base.After(methodUnderTest);
        }
    }
}