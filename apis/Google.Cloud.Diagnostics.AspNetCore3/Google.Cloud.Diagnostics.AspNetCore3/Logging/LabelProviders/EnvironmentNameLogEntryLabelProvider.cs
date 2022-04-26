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

using System;
using System.Collections.Generic;
using Google.Api.Gax;
using Microsoft.AspNetCore.Hosting;

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3
#elif NETSTANDARD2_0
namespace Google.Cloud.Diagnostics.AspNetCore
#else
#error unknown target framework
#endif
{
    /// <summary>
    /// A <see cref="ILogEntryLabelProvider"/> implementation which adds the <see cref="IHostingEnvironment.EnvironmentName"/> to the log entry labels.
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    public class EnvironmentNameLogEntryLabelProvider : ILogEntryLabelProvider, Common.ILogEntryLabelProvider
#pragma warning restore CS0618 // Type or member is obsolete
    {
#if NETCOREAPP3_1
        private readonly IWebHostEnvironment _hostingEnvironment;

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentNameLogEntryLabelProvider"/> class.
        /// </summary>
        /// <param name="hostingEnvironment">The <see cref="IWebHostEnvironment"/> instance to retrieve the environment name from.</param>
        public EnvironmentNameLogEntryLabelProvider(IWebHostEnvironment hostingEnvironment) =>
            _hostingEnvironment = GaxPreconditions.CheckNotNull(hostingEnvironment, nameof(hostingEnvironment));
#elif NETSTANDARD2_0
        private readonly IHostingEnvironment _hostingEnvironment;

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentNameLogEntryLabelProvider"/> class.
        /// </summary>
        /// <param name="hostingEnvironment">The <see cref="IHostingEnvironment"/> instance to retrieve the environment name from.</param>
        public EnvironmentNameLogEntryLabelProvider(IHostingEnvironment hostingEnvironment) =>
            _hostingEnvironment = GaxPreconditions.CheckNotNull(hostingEnvironment, nameof(hostingEnvironment));
#else
#error unknown target framework
#endif

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
