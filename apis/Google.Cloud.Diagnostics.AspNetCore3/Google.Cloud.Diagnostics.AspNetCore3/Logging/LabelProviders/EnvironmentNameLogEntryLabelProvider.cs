// Copyright 2018 Google Inc. All Rights Reserved.
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

using Google.Api.Gax;
using Google.Cloud.Diagnostics.Common;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;

namespace Google.Cloud.Diagnostics.AspNetCore3
{
    /// <summary>
    /// A <see cref="ILogEntryLabelProvider"/> implementation which adds the <see cref="IHostingEnvironment.EnvironmentName"/> to the log entry labels.
    /// </summary>
    public class EnvironmentNameLogEntryLabelProvider : ILogEntryLabelProvider
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentNameLogEntryLabelProvider"/> class.
        /// </summary>
        /// <param name="hostingEnvironment">The <see cref="IWebHostEnvironment"/> instance to retrieve the environment name from.</param>
        public EnvironmentNameLogEntryLabelProvider(IWebHostEnvironment hostingEnvironment) =>
            _hostingEnvironment = GaxPreconditions.CheckNotNull(hostingEnvironment, nameof(hostingEnvironment));

        /// <inheritdoc/>
        public void Invoke(Dictionary<string, string> labels)
        {
            if(!string.IsNullOrEmpty(_hostingEnvironment.EnvironmentName))
            {
                labels["aspnetcore_environment"] = _hostingEnvironment.EnvironmentName;
            }
        }
    }
}
