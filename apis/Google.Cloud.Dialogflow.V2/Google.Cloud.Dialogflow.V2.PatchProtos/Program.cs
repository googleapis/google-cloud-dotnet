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

using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Google.Cloud.Dialogflow.V2.PatchProtos
{
    class Program
    {
        private static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Expected argument: proto directory for Dialogflow");
                return 1;
            }
            var protoDirectory = args[0];
            if (!Directory.Exists(protoDirectory))
            {
                Console.WriteLine($"Directory '{protoDirectory}' does not exist. Aborting.");
                return 1;
            }
            foreach (var proto in Directory.GetFiles(protoDirectory, "*.proto"))
            {
                FixProto(proto);
            }
            return 0;
        }

        private static void FixProto(string proto)
        {
            var lines = File.ReadAllLines(proto);
            lines = lines.Select(FixLine).ToArray();
            File.WriteAllLines(proto, lines);
        }

        private static readonly Regex OperationPattern = new Regex(@"Operation <response: \[([^\]]*)\]\[[^\]]*\]>");

        private static string FixLine(string line)
        {
            // Remove link that's always going to be broken.
            line = OperationPattern.Replace(line, "Operation result type: $1");
            if (!line.Contains('`'))
            {
                return line;
            }

            StringBuilder builder = new StringBuilder();
            bool inBackticks = false;
            foreach (char original in line)
            {
                char result = original;
                if (original == '`')
                {
                    inBackticks = !inBackticks;
                }
                if (original == '<' && inBackticks)
                {
                    result = '{';
                }
                if (original == '>' && inBackticks)
                {
                    result = '}';
                }
                builder.Append(result);
            }

            return builder.ToString();
        }
    }
}
