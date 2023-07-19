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

using NuGet.Common;
using NuGet.Protocol;
using NuGet.Protocol.Core.Types;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Cloud.Tools.ReleaseManager;

/// <summary>
/// Command to delist all versions of the given NuGet package. Use with care!
/// </summary>
public sealed class DelistPackageCommand : CommandBase
{
    public DelistPackageCommand() : base("delist-package", "Delists all versions of a package from nuget.org", "id", "api-key")
    {
    }

    protected override int ExecuteImpl(string[] args)
    {
        string packageId = args[0];
        string apiKey = args[1];
        ExecuteAsync(packageId, apiKey).GetAwaiter().GetResult();
        return 0;
    }

    private async Task ExecuteAsync(string packageId, string apiKey)
    {
        var repository = Repository.Factory.GetCoreV3("https://api.nuget.org/v3/index.json");
        var packageFinder = await repository.GetResourceAsync<FindPackageByIdResource>();
        var packageUpdater = await repository.GetResourceAsync<PackageUpdateResource>();
        var logger = new NullLogger();
        var cache = new SourceCacheContext();

        var versions = (await packageFinder.GetAllVersionsAsync(packageId, cache, logger, default)).ToList();
        Console.WriteLine($"Versions to delist: {versions.Count}");
        foreach (var version in versions)
        {
            Console.Write($"Delisting {version}... ");
            await packageUpdater.Delete(packageId, version.ToString(), _ => apiKey, _ => true, noServiceEndpoint: true, logger);
            Console.WriteLine($"Done.");

            // The rate limit requests is only 250 per hour, which we'll easily blow through if delisting
            // multiple long-lived packages. A short pause may help if there are any undocumented shorter
            // rate limits, as well as giving a bit of an opportunity to abort quickly...
            await Task.Delay(500);
        }
    }
}
