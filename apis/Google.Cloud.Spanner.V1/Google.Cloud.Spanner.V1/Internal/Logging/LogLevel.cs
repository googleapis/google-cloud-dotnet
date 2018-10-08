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

namespace Google.Cloud.Spanner.V1.Internal.Logging
{
    /// <summary>
    /// Log levels for Spanner client internal logging.
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// Never used for an actual log entry, a logger with this level will never log.
        /// </summary>
        None = 0,
        /// <summary>
        /// Used for logging errors, usually indicating a problem with the Spanner libraries.
        /// </summary>
        Error = 1,
        /// <summary>
        /// Used for logging warnings, for example to indicate a non-critical error such as a failure
        /// to refresh a session.
        /// </summary>
        Warn = 2,
        /// <summary>
        /// Used for logging general-purpose information.
        /// </summary>
        Info = 3,
        /// <summary>
        /// Used for logging debug (diagnostic) information, primarily for debugging library issues.
        /// </summary>
        Debug = 4
    }
}