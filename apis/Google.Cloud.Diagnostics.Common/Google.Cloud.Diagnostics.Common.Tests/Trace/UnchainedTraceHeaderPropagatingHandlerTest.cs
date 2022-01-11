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

using Moq;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class UnchainedTraceHeaderPropagatingHandlerTest
    {
        [Fact]
        public void InnerHandler_Unset()
        {
            var mockTracer = new Mock<IManagedTracer>();
#pragma warning disable CS0618 // Type or member is obsolete
            var traceHandler = new UnchainedTraceHeaderPropagatingHandler(() => mockTracer.Object);
#pragma warning restore CS0618 // Type or member is obsolete

            Assert.Null(traceHandler.InnerHandler);
        }
    }
}
