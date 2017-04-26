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

using System;
using System.IO;
using YamlDotNet.RepresentationModel;

namespace Google.Cloud.Tools.CheckGapicConfigs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Root path of gapic configs missing.");
                return;
            }
            string gapicConfigsRoot = args[0];

            Console.WriteLine($"Checking GAPIC configs under '{gapicConfigsRoot}'...");
            foreach (var fileName in Directory.EnumerateFiles(gapicConfigsRoot, "*_gapic.yaml", SearchOption.AllDirectories))
            {
                Console.WriteLine($"{fileName}:");

                string yamlText = File.ReadAllText(fileName);
                var yaml = new YamlStream();
                yaml.Load(new StringReader(yamlText));
                var root = (YamlMappingNode)yaml.Documents[0].RootNode;
                var interfaces = (YamlSequenceNode)root.Children["interfaces"];

                foreach (YamlMappingNode iface in (YamlSequenceNode)interfaces)
                {
                    Console.WriteLine($"    {iface["name"]}:");

                    foreach (YamlMappingNode method in (YamlSequenceNode)iface["methods"])
                    {
                        string msg;
                        bool isError = true;
                        if (method.Children.ContainsKey("field_name_patterns"))
                        {
                            if (!method.Children.ContainsKey("resource_name_treatment"))
                            {
                                msg = "Missing 'resource_name_treatment'";
                            }
                            else
                            {
                                var treatment = ((YamlScalarNode)method["resource_name_treatment"]).Value;
                                if (treatment != "STATIC_TYPES")
                                {
                                    msg = "Incorrect resource_name_treatment: '{treatment}', should be 'STATIC_TYPES'";
                                }
                                else
                                {
                                    isError = false;
                                    msg = "Resource-names correctly configured";
                                }
                            }
                        }
                        else
                        {
                            isError = false;
                            msg = "No resource-names";
                        }
                        Console.ForegroundColor = isError ? ConsoleColor.Red : ConsoleColor.White;
                        Console.WriteLine($"        {method["name"]}: {msg}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
        }
    }
}
