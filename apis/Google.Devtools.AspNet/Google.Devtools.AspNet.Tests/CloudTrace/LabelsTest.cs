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

using Moq;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web;
using Xunit;

namespace Google.Devtools.AspNet.Tests.CloudTrace
{
    public class LabelsTest
    {
        [Fact]
        public void FromHttpRequestWrapper()
        {
            HttpRequest request = new HttpRequest("name", "https://google.com", "");
            Mock<HttpRequestWrapper> mockWrapper = new Mock<HttpRequestWrapper>(request);
            mockWrapper.Setup(w => w.ContentLength).Returns(123);
            mockWrapper.Setup(w => w.UserHostName).Returns("google.com");
            mockWrapper.Setup(w => w.HttpMethod).Returns("PUT");

            Dictionary<string, string> labels = Labels.FromHttpRequestWrapper(mockWrapper.Object);
            Assert.Equal(3, labels.Count);
            Assert.Equal("123", labels[Labels.HttpRequestSize]);
            Assert.Equal("google.com", labels[Labels.HttpHost]);
            Assert.Equal("PUT", labels[Labels.HttpMethod]);
        }

        [Fact]
        public void FromHttpResponseWrapper()
        {
            HttpResponse response = new HttpResponse(new StringWriter());
            Mock<HttpResponseWrapper> mockWrapper = new Mock<HttpResponseWrapper>(response);
            mockWrapper.Setup(w => w.StatusCode).Returns(404);

            Dictionary<string, string> labels = Labels.FromHttpResponseWrapper(mockWrapper.Object);
            Assert.Equal(1, labels.Count);
            Assert.Equal("404", labels[Labels.HttpStatusCode]);
        }

        [Fact]
        public void FromStackTrace()
        {
            Mock<StackFrame> frameRequest = new Mock<StackFrame>("compare_file", 22);
            Mock<MethodBase> methodBaseRequest = new Mock<MethodBase>();
            methodBaseRequest.Setup(m => m.DeclaringType).Returns(typeof(FakeClass));
            methodBaseRequest.Setup(m => m.Name).Returns("SpecialMethod");
            frameRequest.Setup(r => r.GetMethod()).Returns(methodBaseRequest.Object);
            frameRequest.CallBase = true;

            Mock<StackFrame> frameResponse = new Mock<StackFrame>();
            Mock<MethodBase> methodBaseResponse = new Mock<MethodBase>();
            methodBaseResponse.Setup(m => m.DeclaringType).Returns(typeof(FakeClass));
            methodBaseResponse.Setup(m => m.Name).Returns("UniqueMethod");
            frameResponse.Setup(r => r.GetMethod()).Returns(methodBaseResponse.Object);
            frameResponse.CallBase = true;
           
            Mock<StackFrame> frameStack = new Mock<StackFrame>("concat_file", 33);
            Mock<MethodBase> methodBaseStack = new Mock<MethodBase>();
            methodBaseStack.Setup(m => m.DeclaringType).Returns(typeof(FakeClass));
            methodBaseStack.Setup(m => m.Name).Returns("ThisIsAMethod");
            frameStack.Setup(s => s.GetMethod()).Returns(methodBaseStack.Object);
            frameStack.CallBase = true;

            Mock<StackTrace> stackTraceMock = new Mock<StackTrace>();
            stackTraceMock.Setup(t => t.FrameCount).Returns(3);
            stackTraceMock.Setup(t => t.GetFrames()).Returns(new StackFrame[] {
                frameRequest.Object, frameResponse.Object, frameStack.Object });

            Dictionary<string, string> labels = Labels.FromStackTrace(stackTraceMock.Object);
            Assert.Equal(1, labels.Count);
            string jsonTrace = labels[Labels.StackTrace];

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
            Mock<StackTrace> stackTraceMock = new Mock<StackTrace>();
            stackTraceMock.Setup(t => t.FrameCount).Returns(0);

            Dictionary<string, string> labels = Labels.FromStackTrace(stackTraceMock.Object);
            Assert.Equal(1, labels.Count);
            Assert.Equal(string.Empty, labels[Labels.StackTrace]);
        }

        private class FakeClass
        {
            void SpecialMethod() { }
            void UniqueMethod() { }
            void ThisIsAMethod() { }
        }
    }
}