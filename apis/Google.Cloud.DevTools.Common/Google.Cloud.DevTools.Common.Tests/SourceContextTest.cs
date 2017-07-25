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

using Google.Cloud.DevTools.Source.V1;
using System;
using System.IO;
using Xunit;

namespace Google.Cloud.DevTools.Common.Tests
{
    public class SourceContextTest
    {
        private static readonly Func<string, string> s_oldReadAllFunc = SourceContext.s_fileReadAllTextFunc;
        private static readonly Func<string, bool> s_oldFileExistsFunc = SourceContext.s_fileExistsFunc;

        private const string TestRevisionId = "65a600df90f5b715451a3e0dbafc8a74472f8bb9";
        private static readonly string s_sampleContextFileContent = $@"
{{
  ""git"": {{
    ""revisionId"": ""{TestRevisionId}"", 
    ""url"": ""https://github.com/test-account/google-cloud-test-project.git""
  }}
}}
";
        /// <summary>
        /// The constructor restores the SourceContext static members
        /// before each test method execution.
        /// </summary>
        public SourceContextTest()
        {
            SourceContext.s_fileExistsFunc = s_oldFileExistsFunc;
            SourceContext.s_fileReadAllTextFunc = s_oldReadAllFunc;
            SourceContext.ResetAppSourceContext();
        }

        [Fact]
        public void Constructor()
        {
            var sourceContext = new SourceContext();
            Assert.Null(sourceContext.Git);
            Assert.Equal(sourceContext.ContextCase, SourceContext.ContextOneofCase.None);
        }

        [Fact] void DefaultEmptySourceContext()
        {
            Assert.Null(SourceContext.AppSourceContext);
        }

        [Fact] void ReadIOError()
        {
            SourceContext.s_fileExistsFunc = (path) => { return true; };
            SourceContext.s_fileReadAllTextFunc = (path) => { throw new IOException(); };
            Assert.Null(SourceContext.AppSourceContext);
        }

        [Fact] void ReadSourceContextByMock()
        {
            SourceContext.s_fileReadAllTextFunc = ReadSampleSourceContext;
            SourceContext.s_fileExistsFunc = (path) => { return true; };
            Assert.Equal(SourceContext.AppSourceContext?.Git?.RevisionId, TestRevisionId);
        }

        private string ReadSampleSourceContext(string path)
        {
            Assert.Equal(Path.GetFileName(path), "source-context.json");
            return s_sampleContextFileContent;
        }
    }
}
