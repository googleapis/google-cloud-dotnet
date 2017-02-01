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

using Google.Cloud.Logging.Type;
using Microsoft.Extensions.Logging;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.Tests
{
    public class LogUtilsTest
    {
        [Fact]
        public void ToLogSeverity()
        {
            Assert.Equal(LogSeverity.Debug, LogLevel.Trace.ToLogSeverity());
            Assert.Equal(LogSeverity.Debug, LogLevel.Debug.ToLogSeverity());
            Assert.Equal(LogSeverity.Info, LogLevel.Information.ToLogSeverity());
            Assert.Equal(LogSeverity.Warning, LogLevel.Warning.ToLogSeverity());
            Assert.Equal(LogSeverity.Error, LogLevel.Error.ToLogSeverity());
            Assert.Equal(LogSeverity.Critical, LogLevel.Critical.ToLogSeverity());
            Assert.Equal(LogSeverity.Default, LogLevel.None.ToLogSeverity());
            Assert.Equal(LogSeverity.Default, ((LogLevel)20).ToLogSeverity());
        }
    }
}
