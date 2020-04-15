// Copyright 2020, Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Protobuf.WellKnownTypes;
using log4net.Core;
using log4net.Layout;

namespace Google.Cloud.Logging.Log4Net
{
    /// <summary>
    /// The equivalent to <see cref="ILayout"/>, but for converting
    /// a <see cref="LoggingEvent"/> to a JSON payload in the form of
    /// a <see cref="Struct"/>.
    /// </summary>
    public interface IJsonLayout
    {
        /// <summary>
        /// Formats the given logging event as a JSON logging payload.
        /// </summary>
        /// <param name="loggingEvent">The event to format. This will never be null.</param>
        /// <returns>The JSON payload to log, or null to log a text payload instead.</returns>
        Struct Format(LoggingEvent loggingEvent);
    }
}
