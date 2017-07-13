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

using System;
using Google.Cloud.Spanner.V1.Logging;
using Xunit.Abstractions;

namespace Google.Cloud.Spanner.Data.Tests
{
    internal class TestLogger : DefaultLogger
    {
        private static readonly TestLogger s_instance = new TestLogger();

        private TestLogger()
        {
        }

        public static void Install()
        {
            SetLogger(s_instance);
        }

        // ReSharper disable once MemberCanBePrivate.Global
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public static ITestOutputHelper TestOutputHelper { get; set; }

        protected override void WriteLine(string message)
        {
            try
            {
                TestOutputHelper?.WriteLine(message);
            }
            catch (Exception)
            {
                //Eat the exception.  This can happen if we try to output a log
                //after a test has completed (some action ocurred asynchronously).
            }
        }
    }
}
