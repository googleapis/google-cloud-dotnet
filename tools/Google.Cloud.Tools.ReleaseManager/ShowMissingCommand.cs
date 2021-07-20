// Copyright 2020 Google LLC
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

using Google.Cloud.Tools.ApiIndex.V1;
using Google.Cloud.Tools.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager
{
    /// <summary>
    /// Command to show APIs we're not building yet, but which exist in the service directory.
    /// </summary>
    public sealed class ShowMissingCommand : CommandBase
    {
        public ShowMissingCommand() : base("show-missing", "Shows APIs we're not building yet", "min-stability")
        {
        }

        protected override void ExecuteImpl(string[] args)
        {
            var catalog = ApiCatalog.Load();
            var root = DirectoryLayout.DetermineRootDirectory();
            var googleapis = Path.Combine(root, "googleapis");
            var directory = ServiceDirectory.LoadFromGoogleApis(googleapis);
            var stabilityFilter = BuildStabilityFilter(args[0]);

            var ignoredOrGeneratedPaths = new HashSet<string>(catalog.IgnoredPaths.Keys);
            ignoredOrGeneratedPaths.UnionWith(catalog.Apis.Select(api => api.ProtoPath));

            var missingServices = directory.Services
                .Where(stabilityFilter)
                .Where(svc => !ignoredOrGeneratedPaths.Contains(svc.ServiceDirectory))
                .ToList();

            Console.WriteLine($"Missing services: {missingServices.Count}");
            foreach (var service in missingServices)
            {
                Console.WriteLine(service.ServiceDirectory);
            }
        }

        private static Func<ServiceDirectory.Service, bool> BuildStabilityFilter(string minStability) => minStability switch
        {
            "stable" => service => service.Stable,
            "beta" => service => service.Stable || service.Version.Contains("beta"),
            "alpha" => service => true,
            _ => throw new UserErrorException($"Invalid min-stability specified. Valid values: stable, beta, alpha")
        };
    }
}
