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

using Google.Cloud.Tools.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Tools.MetadataGenerator
{
    /// <summary>
    /// Experimental crawler to load service YAML files in googleapis and make
    /// the data within them more conveniently accessible. We might want to then write
    /// them out as JSON in the future, but before then we can still get useful information out,
    /// such as which stable APIs exist but aren't yet generated as C# libraries.
    /// </summary>
    internal class Program
    {
        private static void Main()
        {
            var directory = ServiceDirectory.LoadFromGoogleapis();

            var catalog = ApiCatalog.Load();
            var paths = new HashSet<string>(catalog.Apis.Select(api => api.ProtoPath));
            var serviceDirectories = directory.Services
                .Where(service => service.Stable)
                .Select(service => service.ServiceDirectory).ToList();

            var ungenerated = serviceDirectories
                .Except(paths)
                .Except(catalog.IgnoredPaths)
                .OrderBy(path => path).ToList();
            ungenerated.ForEach(Console.WriteLine);
        }
    }
}
