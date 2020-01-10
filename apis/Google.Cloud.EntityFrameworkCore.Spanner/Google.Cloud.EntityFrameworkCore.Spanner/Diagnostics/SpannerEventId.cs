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

using Microsoft.Extensions.Logging;

namespace Microsoft.EntityFrameworkCore.Diagnostics
{
    /// <summary>
    /// Event IDs for Cloud Spanner log messages
    /// </summary>
    public static class SpannerEventId
    {
        private static readonly string s_logPrefix = DbLoggerCategory.Database.Name + ".";

        /// <summary>
        /// </summary>
        public static EventId SpannerDiagnosticLog { get; } = MakeEventId(Id.SpannerDiagnosticLog);

        private static EventId MakeEventId(Id id) => new EventId((int) id, s_logPrefix + id);
        //For now, we are aggregating all the logging messages done within the ADO.NET
        //layer under the "SpannerDiagnosticLog" Id

        private enum Id
        {
            SpannerDiagnosticLog = CoreEventId.ProviderBaseId
        }
    }
}