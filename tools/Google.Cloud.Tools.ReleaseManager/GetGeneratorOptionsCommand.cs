// Copyright 2024 Google LLC
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
using System.IO;

namespace Google.Cloud.Tools.ReleaseManager;

/// <summary>
/// Works out what options to pass to protoc when invoking the generator, primarily
/// (but not solely) in terms of --gapic_opt.
/// </summary>
public sealed class GetGeneratorOptionsCommand : CommandBase
{
    public GetGeneratorOptionsCommand()
        : base("get-generator-options", "Prints out the generator options to pass to protoc for a single API", "id", "googleapis")
    {
    }

    protected override int ExecuteImpl(string[] args)
    {
        string id = args[0];
        string googleApis = args[1];
        var catalog = ApiCatalog.Load();
        var api = catalog[id];

        var apiSrcDir = Path.Combine(googleApis, api.ProtoPath);

        EmitOption("log", $"tmp/generator-log-{id}.txt");
        EmitOption("transport", api.Transport ?? "grpc");
        EmitOption("rest-numeric-enums", api.RestNumericEnums.ToString());

        if (api.ServiceConfigFile != "none")
        {
            EmitOption("service-config", $"{apiSrcDir}/{api.ServiceConfigFile}");
        }

        var serviceConfigFiles = Directory.GetFiles(apiSrcDir, "*_grpc_service_config.json");
        if (serviceConfigFiles.Length == 1)
        {
            EmitOption("grpc-service-config", serviceConfigFiles[0]);
        }

        EmitOption("common-resources-config", "CommonResourcesConfig.json");
        if (api.CommonResourcesConfig is string config)
        {
            EmitOption("common-resources-config", config);
        }

        // Final argument, not a GAPIC option, can be the common resources proto to include.
        if (api.IncludeCommonResourcesProto == true)
        {
            Console.Write($"{googleApis}/google/cloud/common_resources.proto");
        }

        return 0;

        void EmitOption(string name, string value) => Console.Write($"--gapic_opt={name}={value} ");
    }
}
