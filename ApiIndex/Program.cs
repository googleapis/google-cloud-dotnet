// Copyright 2020, Google LLC
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

using Google.Protobuf;
using Google.Protobuf.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ApiIndex
{
    internal static class Program
    {
        private static int Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Expected arguments: <descriptor-set file> <googleapis directory> <output directory>");
                return 1;
            }

            using var descriptorSetInput = File.OpenRead(args[0]);
            FileDescriptorSet descriptorSet = FileDescriptorSet.Parser.ParseFrom(descriptorSetInput);

            var apiModels = ApiModel.Load(descriptorSet, args[1]);

            WriteV1Index(args[2], apiModels);

            return 0;
        }

        private static void WriteV1Index(string outputDirectory, IEnumerable<ApiModel> apiModels)
        {
            var index = new V1.Index
            {
                Metadata = new V1.IndexMetadata
                {
                    SchemaVersion = "v1",
                    SchemaStability = V1.SchemaStability.Unstable
                },
                Apis = { apiModels.Select(model => model.ToV1Api()) }
            };

            var json = FormatJson(index);
            var file = Path.Combine(outputDirectory, "api-index-v1.json");
            File.WriteAllText(file, json);
        }

        private static string FormatJson(IMessage message)
        {
            string json = message.ToString();
            // TODO: Does this do weird things to dates?
            JObject obj = JObject.Parse(json);
            return obj.ToString(Formatting.Indented);
        }
    }
}
