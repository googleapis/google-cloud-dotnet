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
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class LabelsTest
    {
        [Fact]
        public void FromStackTrace()
        {
            var frameRequest = new Mock<StackFrame>("compare_file", 22);
            var methodBaseRequest = new Mock<MethodBase>();
            methodBaseRequest.Setup(m => m.DeclaringType).Returns(typeof(FakeClass));
            methodBaseRequest.Setup(m => m.Name).Returns("SpecialMethod");
            frameRequest.Setup(r => r.GetMethod()).Returns(methodBaseRequest.Object);
            frameRequest.CallBase = true;

            var frameResponse = new Mock<StackFrame>();
            var methodBaseResponse = new Mock<MethodBase>();
            methodBaseResponse.Setup(m => m.DeclaringType).Returns(typeof(FakeClass));
            methodBaseResponse.Setup(m => m.Name).Returns("UniqueMethod");
            frameResponse.Setup(r => r.GetMethod()).Returns(methodBaseResponse.Object);
            frameResponse.CallBase = true;

            var frameStack = new Mock<StackFrame>("concat_file", 33);
            var methodBaseStack = new Mock<MethodBase>();
            methodBaseStack.Setup(m => m.DeclaringType).Returns(typeof(FakeClass));
            methodBaseStack.Setup(m => m.Name).Returns("ThisIsAMethod");
            frameStack.Setup(s => s.GetMethod()).Returns(methodBaseStack.Object);
            frameStack.CallBase = true;

            var stackTraceMock = new Mock<StackTrace>();
            stackTraceMock.Setup(t => t.GetFrames().Length).Returns(3);
            stackTraceMock.Setup(t => t.GetFrames()).Returns(new StackFrame[] {
                frameRequest.Object, frameResponse.Object, frameStack.Object });

            var labels = Labels.FromStackTrace(stackTraceMock.Object);
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
            var stackTraceMock = new Mock<StackTrace>();
            stackTraceMock.Setup(t => t.GetFrames().Length).Returns(0);

            var labels = Labels.FromStackTrace(stackTraceMock.Object);
            Assert.Equal(1, labels.Count);
            Assert.Equal(string.Empty, labels[Labels.StackTrace]);
        }

        /// <summary>
        /// A simple fake class to test stack traces on.
        /// </summary>
        private class FakeClass
        {
            void SpecialMethod() { }
            void UniqueMethod() { }
            void ThisIsAMethod() { }
        }
    }
}