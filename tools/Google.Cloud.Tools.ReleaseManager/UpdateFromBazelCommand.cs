// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Google.Cloud.Tools.Common;
using System;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager;

/// <summary>
/// A class to update parameters in the API catalog based on BUILD.bazel files.
/// (This is a stopgap measure until we've got a single configuration source.)
/// </summary>
public sealed class UpdateFromBazelCommand : CommandBase
{
    public UpdateFromBazelCommand() : base("update-from-bazel", "Updates the API catalog based on BUILD.bazel files", "id")
    {
    }

    protected override int ExecuteImpl(string[] args)
    {
        string id = args[0];
        var catalog = ApiCatalog.Load(RootLayout);

        var ids = id == "all"
            ? catalog.Apis.Where(api => api.ProtoPath is string && api.Generator == GeneratorType.Micro).Select(api => api.Id).ToArray()
            : new[] { id };

        bool anyUpdated = false;
        foreach (var apiId in ids)
        {
            if (ApiAnalyzer.UpdateFromBazel(catalog[apiId], RootLayout.Googleapis))
            {
                anyUpdated = true;
                Console.WriteLine($"Modified configuration for {apiId}");
            }
        }

        if (anyUpdated)
        {
            catalog.Save(RootLayout);
        }
        return 0;
    }
}
