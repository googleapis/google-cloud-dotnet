// Copyright 2021 Google LLC
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

using System.Collections.Generic;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Provides a hook to augment labels when a log entry is being logged.
    /// </summary>
    public interface ILogEntryLabelProvider
    {
        /// <summary>
        /// Invokes the provider to augment log entry labels.
        /// </summary>
        /// <param name="labels">A dictionary of log entry labels.
        /// Keys and values added to <paramref name="labels"/> should not be null.
        /// If they are, an exception will be throw when attempting to log an entry.
        /// The entry won't be logged and the exception will be propagated depending
        /// on the value of <see cref="RetryOptions.ExceptionHandling"/>.</param>
        void Invoke(Dictionary<string, string> labels);
    }
}
