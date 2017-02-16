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


using Google.Api;
using Google.Api.Gax;
using System.Diagnostics;

namespace Google.Cloud.Diagnostics.Common
{
    internal static class MonitoredResourceUtils
    {
        /// <summary>The global resource.</summary>
        public static readonly MonitoredResource GlobalResource = new MonitoredResource { Type = "global" };

        /// <summary>
        /// Attempts to detect the current <see cref="MonitoredResource"/> this is being run in.
        /// If the monitored resource cannot be detected the global monitored resource is used.
        /// </summary>
        public static MonitoredResource DetectCurrentResource()
        {
            var platform = Platform.Instance();
            switch (platform.Type)
            {
                case PlatformType.Gae:
                    var gae = platform.GaeDetails;
                    return new MonitoredResource
                    {
                        Type = "gae_app",
                        Labels =
                        {
                            { "project_id",  gae.ProjectId },
                            { "module_id",  gae.ServiceId },
                            { "version_id",  gae.VersionId }
                        }
                    };
                case PlatformType.Gce:
                    var gce = platform.GceDetails;
                    return new MonitoredResource
                    {
                        Type = "gce_instance",
                        Labels =
                        {
                            { "project_id",  gce.ProjectId },
                            { "instance_id",  gce.InstanceId },
                            { "zone",  gce.ZoneName }
                        }
                    };
                case PlatformType.Unknown:
                    return GlobalResource;
                default:
                    Debug.Fail($"Unknown platform type '{platform.Type}'");
                    return GlobalResource;
            }
        }
    }
}
