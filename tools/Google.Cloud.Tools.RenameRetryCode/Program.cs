// Copyright 2019 Google LLC.
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
using System.Collections.Generic;
using System.IO;

namespace Google.Cloud.Tools.RenameRetryCode
{
    /// <summary>
    /// Console app to rename retry codes within a GAPIC config in a safe/conservative fashion
    /// (compared with just using sed). This is a temporary measure until all APIs are migrated
    /// off GAPIC configurations.
    /// </summary>
    internal static class Program
    {
        private static int Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine($"Required arguments: <file> <original retry code name> <desired retry code name>");
                return 1;
            }

            string filename = args[0];
            string originalName = args[1];
            string desiredName = args[2];

            var originalLines = File.ReadAllLines(filename);
            var desiredLines = ProcessLines(originalLines, originalName, desiredName);
            File.WriteAllLines(filename, desiredLines);
            return 0;
        }

        private static IEnumerable<string> ProcessLines(IEnumerable<string> lines, string originalName, string desiredName)
        {
            // We assume that each retry code block starts with "- name" rather than a different property,
            // and that each reference is within a method where the name is the first property.

            bool seenReference = false;
            bool seenDefinition = false;
            
            string originalDefinitionLine = $"  - name: {originalName}";
            string desiredDefinitionLine = $"  - name: {desiredName}";

            string originalReferenceLine = $"    retry_codes_name: {originalName}";
            string desiredReferenceLine = $"    retry_codes_name: {desiredName}";

            bool inRetryDefinition = false;
            foreach (var inputLine in lines)
            {
                string outputLine = inputLine;
                if (inRetryDefinition)
                {
                    if (inputLine == originalDefinitionLine)
                    {
                        if (seenDefinition)
                        {
                            throw new Exception($"Retry code {originalName} appears to be defined twice");
                        }
                        seenDefinition = true;
                        outputLine = desiredDefinitionLine;
                    }
                    // Detect the end of the retry_codes_def block, with either
                    // another property within the interface, or a new top-level property
                    if (inputLine.Length <= 2)
                    {
                        inRetryDefinition = false;
                    }
                    else
                    {
                        char c = inputLine[2];
                        if (c != ' ' && c != '-' && c != '#')
                        {
                            inRetryDefinition = false;
                        }
                    }
                }
                else if (inputLine == "  retry_codes_def:")
                {
                    inRetryDefinition = true;
                }
                else if (inputLine == originalReferenceLine)
                {
                    // It's fine for there to be more than one reference
                    seenReference = true;
                    outputLine = desiredReferenceLine;
                }
                yield return outputLine;
            }
            if (!seenDefinition)
            {
                throw new Exception($"Retry code {originalName} is never defined.");
            }
            if (!seenReference)
            {
                throw new Exception($"Retry code {originalName} is never used.");
            }
        }
    }
}
