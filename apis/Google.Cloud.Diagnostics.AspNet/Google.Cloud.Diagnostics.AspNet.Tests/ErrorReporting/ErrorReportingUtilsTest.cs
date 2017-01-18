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
using System;
using Xunit;

using ERUtils = Google.Cloud.Diagnostics.AspNet.ErrorReportingUtils;

namespace Google.Cloud.Diagnostics.AspNet.Tests
{
    public class ErrorReportingUtilsTest
    {
        private static readonly SourceLocation s_emptyLocation = new SourceLocation();

        [Fact]
        public void CreateSourceLocation_Null()
        {
            var location = ERUtils.CreateSourceLocation(null);
            Assert.Equal(s_emptyLocation, location);
        }

        [Fact]
        public void CreateSourceLocation_NoFrames()
        {
            var exception = new Exception();
            var location = ERUtils.CreateSourceLocation(exception);
            Assert.Equal(s_emptyLocation, location);
        }

        [Fact]
        public void CreateSourceLocation()
        {
            Exception exception;
            try
            {
                throw new Exception();
            }
            catch (Exception e)
            {
                exception = e;
            }

            var location = ERUtils.CreateSourceLocation(exception);
            if (ErrorReportingUtils.IsWindows)
            {
                Assert.NotEmpty(location.FilePath);
                Assert.True(location.LineNumber > 0);
            }
            Assert.Equal(nameof(CreateSourceLocation), location.FunctionName);
        }
    }
}
