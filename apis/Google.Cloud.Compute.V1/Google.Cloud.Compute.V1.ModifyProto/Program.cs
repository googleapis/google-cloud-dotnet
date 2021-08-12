// Copyright 2021 Google LLC
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

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Google.Cloud.Compute.V1.ModifyProto
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Required single argument: path to proto");
                return 1;
            }
            string text = File.ReadAllText(args[0]);
            text = AnnotateOperationRpcs(text);
            File.WriteAllText(args[0], text);
            return 0;
        }

        static string AnnotateOperationRpcs(string proto)
        {
            // Make sure we've got the import
            proto = proto.Replace("import \"google/api/annotations.proto\";",
                "import \"google/api/annotations.proto\";\nimport \"google/longrunning/operations.proto\";");


            var pattern = new Regex(@"rpc (?<name>[^(]*)\((?<request>[^)]*)\) returns \(Operation\) {");
            var matches = pattern.Matches(proto);
            // Modify all 
            foreach (Match match in matches)
            {
                string name = match.Groups["name"].Value;
                string request = match.Groups["request"].Value;
                // Note: the services specifically for operations do *not* change.
                if (name != "Get" && name != "Wait")
                {
                    proto = proto.Replace(match.Value,
                        $"rpc {name}({request}) returns (google.longrunning.Operation) {{\n" +
                        "    option (google.longrunning.operation_info) = {\n" +
                        "      response_type: \"Operation\"\n" +
                        "      metadata_type: \"Operation\"\n" +
                        "    };");
                }
            }            
            return proto;
        }
    }
}
