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

using Google.Cloud.ClientTesting;
using System.Collections.Generic;
using System.Reflection;
using Xunit;

namespace Google.Cloud.Translation.V2.Tests
{
    public class TranslationClientTest : AbstractClientTester<TranslationClient, TranslationClientTest.DerivedTranslationClient>
    {
        public static IEnumerable<object[]> NotImplementedMethods => AllInstanceMethods;

        public class DerivedTranslationClient : TranslationClient
        {
        }

        [Theory]
        [MemberData(nameof(NotImplementedMethods))]
        public void NotImplementedMethodsThrow(MethodInfo method)
        {
            AssertNotImplemented(method);
        }
    }
}