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

using Google.Cloud.Spanner.V1;
using System.Reflection;
using System.Text;
using Xunit;
using Xunit.Sdk;

namespace Google.Cloud.Spanner.Data.CommonTesting
{
    /// <summary>
    /// When applied to a class or method, each test has the state of the client and session pools checked
    /// before and after the test.
    /// </summary>
    public class ValidatePoolBeforeAfterTestAttribute : BeforeAfterTestAttribute
    {
        public override void Before(MethodInfo methodUnderTest) => ValidatePoolInfo("Before", methodUnderTest);

        public override void After(MethodInfo methodUnderTest) => ValidatePoolInfo("After", methodUnderTest);

        /// <summary>
        /// The purpose of this method is to review the state of both the client (grpc channel) pool and session pool.
        /// The session pool should have sessions perfectly evenly distributed among each channel.
        /// The channel pool at test end should all have refcounts = 0.
        /// </summary>
        protected static void ValidatePoolInfo(string beforeOrAfter, MethodInfo method)
        {
            string methodName = $"{method.DeclaringType.Name}.{method.Name}";
            string message = $"{beforeOrAfter} {methodName}: ";
            StringBuilder s = new StringBuilder();
            int sessions = SessionPool.Default.GetPoolInfo(s);
            Assert.True(sessions < 2, message + s);

            s.Clear();
            int clients = ClientPool.Default.GetPoolInfo(s);
            Assert.True(clients == 0, message + s);
        }
    }
}
