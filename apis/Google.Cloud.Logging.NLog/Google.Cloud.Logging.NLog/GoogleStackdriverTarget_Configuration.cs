// Copyright 2018 Google LLC
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

using Google.Cloud.Logging.V2;
using Google.Protobuf.WellKnownTypes;
using NLog.Config;
using NLog.Layouts;
using NLog.Targets;
using System;
using System.Collections.Generic;

namespace Google.Cloud.Logging.NLog
{
    // Partial class to split out configuration options.
    // Target implementation is in GoogleStackdriverTarget.cs
    public partial class GoogleStackdriverTarget
    {
        /// <summary>
        /// The file path of a service account JSON file to use for authentication.
        /// Not necessary if running on GCE, GAE or GKE, or if the GOOGLE_APPLICATION_CREDENTIALS environment variable has been set.
        /// Must not be set if <see cref="CredentialJson"/> is set.
        /// </summary>
        public Layout CredentialFile { get; set; }

        /// <summary>
        /// JSON credential for authentication.
        /// Not necessary if running on GCE or GAE or if the GOOGLE_APPLICATION_CREDENTIALS environment variable has been set.
        /// Must not be set if <see cref="CredentialFile"/> is set.
        /// </summary>
        public Layout CredentialJson { get; set; }

        /// <summary>
        /// If set, disables resource-type detection based on platform,
        /// so ResourceType will default to "global" if not manually set. 
        /// </summary>
        public bool DisableResourceTypeDetection { get; set; }

        /// <summary>
        /// Configures how many outstanding write tasks before starting to throttle. Defaults to 5.
        /// </summary>
        public int TaskPendingLimit { get; set; } = 5;

        /// <summary>
        /// Configures "service" for the "serviceContext" when <see cref="SendJsonPayload" /> = true
        /// </summary>
        public Layout ServiceContextName { get; set; } = "${appdomain:cached=true:format=\\{1\\}}";

        /// <summary>
        /// Configures "version" for the "serviceContext" when <see cref="SendJsonPayload" /> = true
        /// </summary>
        public Layout ServiceContextVersion { get; set; } = "${assembly-version:cached=true:type=File}";

        /// <summary>
        /// The resource type of log entries.
        /// Default value depends on the detected platform. See the remarks section for details.
        /// </summary>
        /// <remarks>
        /// If this is not set, then Resource type is set depending on the detected execution platform:
        /// <list type="bullet">
        /// <item><description>
        /// Google App Engine: ResourceType "gae_app", with project_id, module_id, and version_id set approprately.
        /// </description></item>
        /// <item><description>
        /// Google Compute Engine: ResourceType "gce_instance", with project_id, instance_id, and zone set approprately.
        /// </description></item>
        /// <item><description>
        /// Google Kubernetes Engine: ResourceType "container", with project_id and other labels set approprately.
        /// </description></item>
        /// <item><description>
        /// Unknown: ResourceType "global", with project_id set from this configuration.
        /// </description></item>
        /// </list>
        /// If <see cref="DisableResourceTypeDetection"/> is <c>true</c>, then this platform detection
        /// is not performed, and this ResourceType defaults to "global" if not set.
        /// </remarks>
        public string ResourceType { get; set; }

        /// <summary>
        /// The project ID for all log entries.
        /// Must be configured if not executing on Google Compute Engine, Google App Engine or Google Kubernetes Engine.
        /// If running on GCE, GAE or GKE, the ProjectId will be automatically detected if not set.
        /// </summary>
        public Layout ProjectId { get; set; }

        /// <summary>
        /// LogID for all log entries. Defaults to "Default".
        /// </summary>
        public Layout LogId { get; set; } = "Default";

        /// <summary>
        /// Specify labels for the resource type;
        /// only used if platform detection is disabled or detects an unknown platform.
        /// </summary>
        [ArrayParameter(typeof(TargetPropertyWithContext), "resourcelabel")]
        public IList<TargetPropertyWithContext> ResourceLabels { get; }

        /// <inheritdoc/>
        [ArrayParameter(typeof(TargetPropertyWithContext), "contextproperty")]
        public override IList<TargetPropertyWithContext> ContextProperties { get { return _contextProperties; } }
        private readonly List<TargetPropertyWithContext> _contextProperties;

        /// <summary>
        /// How many seconds to wait for task completion before starting new task
        /// </summary>
        public int TimeoutSeconds { get; set; } = 2;

        /// <summary>
        /// Fills <see cref="LogEntry.JsonPayload"/> instead of <see cref="LogEntry.TextPayload"/>.
        /// JSON serialization can be customed using <see cref="JsonConverterTypeName"/> and <see cref="JsonConverterMethodName"/>,
        /// or <see cref="JsonConverter"/>.
        /// </summary>
        public bool SendJsonPayload { get; set; }

        /// <summary>
        /// When <see cref="SendJsonPayload"/> is <c>true</c>, a custom JSON serialization method may be specified by
        /// type-name and method-name. Specify the type-name here, and the method-name in <see cref="JsonConverterMethodName"/>.
        /// The instance or static method must have the signature <c>Value MyMethod(object obj)</c> or <c>JToken MyMethod(object o)</c>.
        /// Must not be set if <see cref="JsonConverter"/> is set.
        /// </summary>
        public string JsonConverterTypeName { get; set; }

        /// <summary>
        /// When <see cref="SendJsonPayload"/> is <c>true</c>, a custom JSON serialization method may be specified by
        /// type-name and method-name. Specify the type-name in <see cref="JsonConverterTypeName"/>, and the method-name here.
        /// The instance or static method must have the signature <c>Value MyMethod(object obj)</c> or <c>JToken MyMethod(object o)</c>.
        /// Must not be set if <see cref="JsonConverter"/> is set.
        /// </summary>
        public string JsonConverterMethodName { get; set; }

        /// <summary>
        /// When <see cref="SendJsonPayload"/> is <c>true</c>, a custom JSON serialization method may be programatically specified here.
        /// Must not be set if <see cref="JsonConverterTypeName"/> and <see cref="JsonConverterMethodName"/> are set.
        /// </summary>
        public Func<object, Value> JsonConverter { get; set; }
    }
}
