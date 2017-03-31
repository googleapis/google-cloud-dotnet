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

using Google.Api;
using Google.Api.Gax.Grpc;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.Common
{
    internal static class CommonUtils
    {
        /// <summary>The name of the this agent.</summary>
        internal const string AgentName = "google-cloud-csharp-diagnostics";

        /// <summary>A completed <see cref="Task"/>.</summary>
        internal readonly static Task CompletedTask = Task.FromResult(false);

        /// <summary>
        /// The agent name <see cref="AgentName"/> and version of the agent in the
        /// format "[agent-name] [agent-version]".
        /// </summary>
        internal readonly static string AgentNameAndVersion = $"{AgentName} {GetVersion(typeof(CommonUtils))}";

        /// <summary>Gets the version of the current library using reflection.</summary>
        internal static string GetVersion(System.Type type) =>
            type.GetTypeInfo()
                .Assembly
                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                .InformationalVersion;

        /// <summary>
        /// Determines the correct project id from a string project id and a <see cref="MonitoredResource"/>.
        /// If the specified project id is not null, it is returned. Otherwise, if the project id of
        /// the MonitoredResource is not null, it is returned. It both are null,
        /// an <see cref="InvalidOperationException"/> is thrown.
        /// </summary>
        /// <param name="projectId">The Google Cloud project ID.  Can be null.</param>
        /// <param name="monitoredResource">Optional, The monitored resource. If unset the monitored resource will
        ///     be auto detected.</param>
        /// <returns>The Google Cloud project ID.</returns>
        internal static string GetAndCheckProjectId(string projectId, MonitoredResource monitoredResource = null)
        {
            if (projectId != null)
            {
                return projectId;
            }

            monitoredResource = monitoredResource ?? MonitoredResourceBuilder.FromPlatform();
            string resourceProjectId;
            if (monitoredResource.Labels.TryGetValue("project_id", out resourceProjectId))
            {
                return resourceProjectId;
            }

            throw new InvalidOperationException("No Google Cloud project ID was passed in or detected.");
        }
    }
}
