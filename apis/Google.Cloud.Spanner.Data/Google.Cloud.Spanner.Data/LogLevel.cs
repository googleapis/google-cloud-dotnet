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

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Specifies the level of detail for Spanner client log messages.
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// Debug and higher level messages will be logged.
        /// </summary>
        Debug = V1.Internal.Logging.LogLevel.Debug,

        /// <summary>
        /// Info and higher level messages will be logged.
        /// </summary>
        Info = V1.Internal.Logging.LogLevel.Info,

        /// <summary>
        /// Warn and higher level messages will be logged.
        /// </summary>
        Warn = V1.Internal.Logging.LogLevel.Warn,

        /// <summary>
        /// Error messages will be logged.
        /// </summary>
        Error = V1.Internal.Logging.LogLevel.Error,

        /// <summary>
        /// Logging is turned off.
        /// </summary>
        None = V1.Internal.Logging.LogLevel.None
    }
}
