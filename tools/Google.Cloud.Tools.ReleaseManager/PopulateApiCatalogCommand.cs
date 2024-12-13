// Copyright 2022 Google LLC
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
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager
{
    /// <summary>
    /// Tool to populate the API catalog (in google-cloud-dotnet) with values from the API index (in googleapis).
    /// This is only generally run when we add a new field to the API catalog, at which
    /// point this tool will need to change as well... but at least with it here,
    /// we don't need to rewrite the code every time.
    /// </summary>
    internal class PopulateApiCatalogCommand : CommandBase
    {
        public PopulateApiCatalogCommand() : base("populate-api-catalog", "Populates API catalog information from the API index. (You probably don't want this.)")
        {
        }

        protected override int ExecuteImpl(string[] args)
        {
            var catalog = ApiCatalog.Load(RootLayout);
            var apiIndex = ApiIndex.V1.Index.LoadFromGoogleApis(RootLayout.Googleapis);
            int modifiedCount = 0;

            var directories = File.ReadAllLines("bazel-files.txt").Select(path => path[2..^12]);

            foreach (var directory in directories)
            {
                var indexEntry = apiIndex.Apis.FirstOrDefault(x => x.Directory == directory);
                if (indexEntry is null)
                {
                    continue;
                }

                var id = indexEntry.DeriveCSharpNamespace();
                if (!catalog.TryGetApi(id, out var api))
                {
                    continue;
                }

                // Change this line when introducing a new field...
                api.Json.Last.AddAfterSelf(new JProperty("restNumericEnums", true));
                modifiedCount++;
            }

            Console.WriteLine($"Modified APIs: {modifiedCount}");
            catalog.Save(RootLayout);
            return 0;
        }
    }
}
