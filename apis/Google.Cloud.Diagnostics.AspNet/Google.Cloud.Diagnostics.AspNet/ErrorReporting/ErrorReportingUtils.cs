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

using Google.Cloud.ErrorReporting.V1Beta1;
using System;
using System.Diagnostics;

namespace Google.Cloud.Diagnostics.AspNet
{
    public static class ErrorReportingUtils
    {
        /// <summary>
        /// Gets information about the source location where the exception occured 
        /// and populates a <see cref="SourceLocation"/> object.
        /// </summary>
        internal static SourceLocation CreateSourceLocation(Exception exception)
        {
            if (exception == null)
            {
                return new SourceLocation();
            }

            StackTrace stackTrace = new StackTrace(exception, true);
            if (stackTrace.FrameCount == 0)
            {
                return new SourceLocation();
            }

            StackFrame frame = stackTrace.GetFrame(0);
            return new SourceLocation()
            {
                FilePath = frame.GetFileName() ?? "",
                LineNumber = frame.GetFileLineNumber(),
                FunctionName = frame.GetMethod()?.Name ?? "",
            };
        }
    }
}
