// Copyright 2020 Google Inc. All Rights Reserved.
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
using System.Reflection;
using Xunit.Sdk;

namespace Google.Cloud.Spanner.Data.Tests
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class DisableResourceBasedRouting : BeforeAfterTestAttribute
    {
        static string ResourceBasedRoutingValue;
        public override void Before(MethodInfo methodUnderTest)
        {
            ResourceBasedRoutingValue = Environment.GetEnvironmentVariable(SpannerConstants.ResourceBasedRoutingVariableName);
            Environment.SetEnvironmentVariable(SpannerConstants.ResourceBasedRoutingVariableName, "false");
        }

        public override void After(MethodInfo methodUnderTest)
        {
            Environment.SetEnvironmentVariable(SpannerConstants.ResourceBasedRoutingVariableName, ResourceBasedRoutingValue);
        }
    }
}
