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

using Moq;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text.RegularExpressions;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class TraceLabelsTest
    {
        [Fact]
        public void FromStackTrace()
        {
            var frameRequest = new Mock<StackFrame>("compare_file", 22);
            frameRequest.Setup(r => r.GetMethod()).Returns(typeof(FakeClass).GetMethod("SpecialMethod"));
            frameRequest.CallBase = true;

            var frameResponse = new Mock<StackFrame>();
            frameResponse.Setup(r => r.GetMethod()).Returns(typeof(FakeClass).GetMethod("UniqueMethod"));
            frameResponse.CallBase = true;

            var frameStack = new Mock<StackFrame>("concat_file", 33);
            frameStack.Setup(s => s.GetMethod()).Returns(typeof(FakeClass).GetMethod("ThisIsAMethod"));
            frameStack.CallBase = true;

            var stackTraceMock = new Mock<StackTrace>();
            stackTraceMock.Setup(t => t.GetFrames()).Returns(new StackFrame[] {
                frameRequest.Object, frameResponse.Object, frameStack.Object });

            var labels = TraceLabels.FromStackTrace(stackTraceMock.Object);
            Assert.Equal(1, labels.Count);
            string jsonTrace = labels[TraceLabels.StackTrace];

            Assert.Equal(Regex.Matches(jsonTrace, "stack_frame").Count, 1);
            Assert.Equal(Regex.Matches(jsonTrace, "class_name").Count, 3);
            Assert.Equal(Regex.Matches(jsonTrace, "method_name").Count, 3);
            Assert.Equal(Regex.Matches(jsonTrace, "file_name").Count, 2);
            Assert.Equal(Regex.Matches(jsonTrace, "line_number").Count, 2);

            Assert.Equal(Regex.Matches(jsonTrace, "compare_file").Count, 1);
            Assert.Equal(Regex.Matches(jsonTrace, "22").Count, 1);
            Assert.Equal(Regex.Matches(jsonTrace, "SpecialMethod").Count, 1);
            Assert.Equal(Regex.Matches(jsonTrace, "UniqueMethod").Count, 1);
            Assert.Equal(Regex.Matches(jsonTrace, "concat_file").Count, 1);
            Assert.Equal(Regex.Matches(jsonTrace, "33").Count, 1);
            Assert.Equal(Regex.Matches(jsonTrace, "ThisIsAMethod").Count, 1);
        }

        [Fact]
        public void FromStackTrace_Empty()
        {
            var stackTraceMock = new Mock<StackTrace>();
            stackTraceMock.Setup(t => t.GetFrames()).Returns(new StackFrame[] { });

            var labels = TraceLabels.FromStackTrace(stackTraceMock.Object);
            Assert.Equal(1, labels.Count);
            Assert.Equal(string.Empty, labels[TraceLabels.StackTrace]);
        }

        [Fact]
        public void FromStackTrace_Null()
        {
            var stackTraceMock = new Mock<StackTrace>();
            stackTraceMock.Setup(t => t.GetFrames()).Returns((StackFrame[]) null);

            var labels = TraceLabels.FromStackTrace(stackTraceMock.Object);
            Assert.Equal(1, labels.Count);
            Assert.Equal(string.Empty, labels[TraceLabels.StackTrace]);
        }

        [Fact]
        public void FromHttpRequestMessage()
        {
            HttpRequestMessage request = new HttpRequestMessage();
            request.Method = HttpMethod.Put;

            var labels = TraceLabels.FromHttpRequestMessage(request);
            Assert.Single(labels);
            Assert.Equal("PUT", labels[TraceLabels.HttpMethod]);
        }

        [Fact]
        public void FromHttpResponseMessage()
        {
            HttpResponseMessage response = new HttpResponseMessage();
            response.StatusCode = HttpStatusCode.Conflict;

            var labels = TraceLabels.FromHttpResponseMessage(response);
            Assert.Single(labels);
            Assert.Equal("409", labels[TraceLabels.HttpStatusCode]);
        }

        /// <summary>
        /// A simple fake class to test stack traces on.
        /// </summary>
        public class FakeClass
        {
            public void SpecialMethod() { }
            public void UniqueMethod() { }
            public void ThisIsAMethod() { }
        }
    }
}