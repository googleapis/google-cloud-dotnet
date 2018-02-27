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

using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class TraceTargetTests
    {
        private const string _pid = "some-pid";

        [Fact]
        public void Project()
        {
            TraceTarget target = TraceTarget.ForProject(_pid);
            Assert.Equal(_pid, target.ProjectId);
        }

        [Fact]
        public void GetFullLogName_Project()
        {
            string traceId = "trace-id";
            TraceTarget target = TraceTarget.ForProject(_pid);
            string traceName = target.GetFullTraceName(traceId);
            Assert.Contains(traceId, traceName);
            Assert.Contains(_pid, traceName);
        }
    }
}
