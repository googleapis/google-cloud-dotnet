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
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
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

    protected override void ExecuteImpl(string[] args)
    {
        string id = args[0];
        var catalog = ApiCatalog.Load();

        var ids = id == "all"
            ? catalog.Apis.Where(api => api.ProtoPath is string && api.Generator == GeneratorType.Micro).Select(api => api.Id).ToArray()
            : new[] { id };

        bool anyUpdated = false;
        foreach (var apiId in ids)
        {
            if (Update(catalog[apiId]))
            {
                anyUpdated = true;
                Console.WriteLine($"Modified configuration for {apiId}");
            }
        }

        if (anyUpdated)
        {
            File.WriteAllText(ApiCatalog.CatalogPath, catalog.FormatJson());
        }
    }

    public bool Update(ApiMetadata api)
    {
        var root = DirectoryLayout.DetermineRootDirectory();
        var googleapis = Path.Combine(root, "googleapis");

        var bazelFile = Path.Combine(googleapis, api.ProtoPath, "BUILD.bazel");
        if (!File.Exists(bazelFile))
        {
            throw new UserErrorException($"Expected Bazel file does not exist: '{bazelFile}'");
        }

        var lines = File.ReadAllLines(bazelFile).ToList();
        var start = lines.IndexOf("csharp_gapic_library(");
        if (start == -1)
        {
            // This is effectively a warning. (AI Platform has it commented out, for example.)
            Console.WriteLine($"Bazel file for {api.Id} does not include csharp_gapic_library target.");
            return false;
        }
        var end = lines.IndexOf(")", start);
        // Second check is just a safety-net, in case the end of the target is formatted badly and we've picked up a later one.
        if (end == -1 || end - start > 20)
        {
            throw new UserErrorException($"Cannot find end of csharp_gapic_library target in Bazel file for {api.Id}.");
        }

        // This is really pretty horrible, but it will do the job...
        var properties = lines
            .Skip(start)
            .Take(end - start)
            .Select(line => line.TrimEnd(','))
            .Where(line => line.Contains('='))
            .Select(line => line.Split('=', 2))
            .ToDictionary(bits => bits[0].Trim(), bits => bits[1].Trim('"', ' '));

        bool updated = false;

        bool restNumericEnums = properties.TryGetValue("rest_numeric_enums", out var restNumericEnumsValue) && restNumericEnumsValue == "True";
        if (api.RestNumericEnums != restNumericEnums)
        {
            api.RestNumericEnums = restNumericEnums;
            UpdateOrAddJson("restNumericEnums", restNumericEnums);
            updated = true;
        }

        string transport = properties.GetValueOrDefault("transport", "grpc");
        if ((api.Transport ?? "grpc") != transport)
        {
            api.Transport = transport;
            UpdateOrAddJson("transport", transport);
            updated = true;
        }

        string serviceConfig = properties.GetValueOrDefault("service_yaml", "none");
        serviceConfig = serviceConfig.Split(':').Last();
        if (api.ServiceConfigFile != serviceConfig)
        {
            api.ServiceConfigFile = serviceConfig;
            UpdateOrAddJson("serviceConfigFile", serviceConfig);
            updated = true;
        }
        return updated;

        void UpdateOrAddJson(string key, object value)
        {
            if (api.Json is not JObject obj)
            {
                return;
            }
            if (obj.ContainsKey(key))
            {
                obj[key] = JToken.FromObject(value);
            }
            else
            {
                obj.Last.AddAfterSelf(new JProperty(key, value));
            }
        }
    }
}
