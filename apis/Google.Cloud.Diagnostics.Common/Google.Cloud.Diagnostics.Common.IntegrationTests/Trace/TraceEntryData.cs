// Copyright 2018 Google Inc. All Rights Reserved.
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
using System.Diagnostics;

namespace Google.Cloud.Diagnostics.Common.IntegrationTests
{
    public static class TraceEntryData
    {
        public const string TraceLabel = "SomeLabel";
        public const string TraceLabelValue = "SomeValue";

        public static readonly IDictionary<string, string> HttpGetSuccessLabels =
            new Dictionary<string, string>
            {
                {TraceLabels.HttpMethod, "GET" },
                {TraceLabels.HttpStatusCode, "200" }
            };

        /// <summary>Creates the StackTrace for a thrown exception.</summary>
        public static StackTrace CreateStackTrace()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception e)
            {
                return new StackTrace(e, true);
            }
        }
    }
}
