// Copyright 2019 Google LLC
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

using Google.Cloud.Tools.Common;
using PublicApiGenerator;
using System;
using System.IO;
using System.Reflection;
using System.Xml.Linq;

namespace Google.Cloud.Tools.GeneratePublicApi
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length != 4)
            {
                Console.WriteLine($"Arguments: <package name> <version or 'project'> <framework> <working area>");
                return 1;
            }

            string package = args[0];
            string version = args[1];
            string framework = args[2];
            string workingArea = args[3];

            try
            {
                GenerateProject(package, version, framework, workingArea);
                Processes.RunDotnet(workingArea, "publish");
                var relativePath = Path.Combine(workingArea, "bin", "debug", framework, "publish", $"{package}.dll");
                var fullPath = Path.GetFullPath(relativePath);
                Assembly asm = Assembly.LoadFile(fullPath);
                Console.WriteLine(ApiGenerator.GeneratePublicApi(asm));
                return 0;
            }
            catch (UserErrorException e)
            {
                Console.WriteLine($"Configuration error: {e.Message}");
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed: {e}");
                return 1;
            }
        }        

        static void GenerateProject(string package, string version, string framework, string workingArea)
        {
            if (File.Exists(workingArea) || Directory.Exists(workingArea))
            {
                throw new UserErrorException($"{workingArea} already exists");
            }
            Directory.CreateDirectory(workingArea);

            XElement targetReference;
            if (version == "project")
            {
                DirectoryLayout layout = DirectoryLayout.ForApi(package);
                var packageProjectFile = Path.Combine(layout.SourceDirectory, package, $"{package}.csproj");
                targetReference = new XElement("ProjectReference", new XAttribute("Include", packageProjectFile));
            }
            else
            {
                targetReference = new XElement("PackageReference", new XAttribute("Include", package), new XAttribute("Version", version));
            }
            var projectFile = new XDocument(
                new XElement("Project", new XAttribute("Sdk", "Microsoft.NET.Sdk"),
                    new XElement("PropertyGroup",
                        new XElement("TargetFramework", framework)
                    ),
                    new XElement("ItemGroup", targetReference)
                )
            );
            using (var output = File.Create(Path.Combine(workingArea, "project.csproj")))
            {
                projectFile.Save(output);
            }
        }
    }
}
