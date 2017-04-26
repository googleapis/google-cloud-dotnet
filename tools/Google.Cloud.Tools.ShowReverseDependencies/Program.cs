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

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ShowReverseDependencies
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Required arguments: json-file package-name depth");
                Console.WriteLine("e.g. nuget-dependencies.json Google.Apis 3");
                return;
            }


            var json = File.ReadAllText(args[0]);
            var allPackages = JsonConvert.DeserializeObject<List<PackageInfo>>(json);

            string package = args[1];
            int depth = int.Parse(args[2]);

            var reverseMap = allPackages
                .SelectMany(p => p.Dependencies.Select(d => new { from = p.Id, to = d }))
                .ToLookup(p => p.to, p => p.from);

            List<string> sourceSet = new[] { package }.ToList();

            for (int i = 1; i <= depth; i++)
            {
                sourceSet = sourceSet
                    .SelectMany(p => reverseMap[p])
                    .OrderBy(p => p)
                    .Distinct()
                    .ToList();
                Console.WriteLine($"Dependencies at depth {i}:");
                foreach (var dependency in sourceSet)
                {
                    Console.WriteLine(dependency);
                }

                Console.WriteLine();
            }
        }
    }
}
