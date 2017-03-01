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
using System;
using System.Diagnostics;
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
        /// <list type="bullet">
        /// <term>
        /// If the string project id is not null and the MonitoredResource does not contain a project id
        /// then the string project id is retruned.
        /// </term>
        /// <term>
        /// If the string project id is not null and the MonitoredResource contains a project id
        /// then the string project id is retruned.  We do this as the explictly set project id should be
        /// defaulted too.
        /// </term>
        /// <term>
        /// If the string project id is null and the MonitoredResource does contains a project id
        /// then the project id from the MonitoredResource is retruned.
        /// </term>
        /// <term>
        /// If the string project id is null and the MonitoredResource does not contain a project id
        /// then an <see cref="InvalidOperationException"/> is thrown.
        /// </term>
        /// </list>
        /// </summary>
        /// <param name="projectId">The Google Cloud project ID.  Can be null.</param>
        /// <param name="monitoredResource">The monitored resource.</param>
        /// <returns>The Google Cloud project ID.</returns>
        internal static string GetAndCheckProjectId(string projectId, MonitoredResource monitoredResource)
        {
            string resourceProjectId;
            if (monitoredResource.Labels.TryGetValue("project_id", out resourceProjectId))
            {
                if (projectId == null)
                {
                    projectId = resourceProjectId;
                }
                else if (projectId != resourceProjectId)
                {
                    Debug.WriteLine("Google Cloud Platfrom project ID mismatch. " +
                        $"Project Id parameter '{projectId}' does not match " +
                        $"resource project ID '{resourceProjectId}' " +
                        $"Defaulting to project ID parameter '{projectId}'");
                }
            }

            if (projectId == null)
            {
                throw new InvalidOperationException("No Google Cloud project ID was passed in or detected.");
            }

            return projectId;
        }
        
    }
}
