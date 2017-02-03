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

using Google.Cloud.ErrorReporting.V1Beta1;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests.ErrorReporting
{
    public class ErrorReportingExtensionTest
    {
        /// <summary>
        /// This test is mainly just a sanity check that the extension "ToStruct" 
        /// does the right thing.
        /// </summary>
        [Fact]
        public void ToStruct()
        {
            var message = "exception message";
            var method = "DELETE";
            var lineNumber = 116;

            var errorEvent = new ReportedErrorEvent()
            {
                Message = message,
                Context = new ErrorContext()
                {
                    HttpRequest = new HttpRequestContext() { Method = method },
                    ReportLocation = new SourceLocation() { LineNumber = lineNumber }
                },
                
            };

            var errorStruct = errorEvent.ToStruct();
            Assert.NotEmpty(errorStruct?.Fields);
            Assert.Equal(message, errorStruct.Fields["message"].StringValue);

            var contextStruct = errorStruct.Fields["context"].StructValue;
            Assert.NotEmpty(contextStruct?.Fields);

            var httpStruct = contextStruct.Fields["httpRequest"].StructValue;
            Assert.NotEmpty(httpStruct?.Fields);
            Assert.Equal(method, httpStruct.Fields["method"].StringValue);

            var locationStruct = contextStruct.Fields["reportLocation"].StructValue;
            Assert.NotEmpty(locationStruct?.Fields);
            Assert.Equal(lineNumber, locationStruct.Fields["lineNumber"].NumberValue);
        }
    }
}
