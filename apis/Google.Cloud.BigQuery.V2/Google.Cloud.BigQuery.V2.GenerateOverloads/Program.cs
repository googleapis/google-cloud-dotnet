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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Google.Cloud.BigQuery.V2.GenerateOverloads
{
    /// <summary>
    /// BigQuery-specific overload generator.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The BigQuery library ends up with a lot of very similar methods, varying by how a dataset/job/table is specified,
    /// and whether or not it's asynchronous. This generator allows the description to be written a single time and then used
    /// to generate all the overloads. XML is chosen as the file format as most of the definition is in terms of XML documentation.
    /// </para>
    /// <para>
    /// For ease of later regeneration, files are checked into source control. The generation process is still run manually though.
    /// We generate .g.cs files, which are assumed to be entirely generated.
    /// </para>
    /// <para>
    /// This generator only handles the async + entity referencing overloads. Where multiple overloads have different parameter types
    /// (e.g. UploadJson with Stream and String[] parameters) these would be generated from multiple XML files.
    /// </para>
    /// </remarks>
    internal class Program
    {
        private static int Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Arguments: <xml filename> <source file>");
                return 1;
            }

            try
            {
                XDocument document = XDocument.Load(args[0]);
                var methods = document.Root.Elements("Method").Select(element => new ApiMethod(element));
                var codeForMethods = methods.SelectMany(method => method.GenerateCode()).ToList();
                // Remove the trailing blank line from the final method.
                codeForMethods.RemoveAt(codeForMethods.Count - 1);

                var code = GeneratePrologue(args[1])
                    .Concat(codeForMethods)
                    .Concat(GenerateEpilogue());

                File.WriteAllLines(args[1], code);
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
                return 1;
            }
        }

        /// <summary>
        /// Generates the start of a source file: copyright, using directives, namespace declaration,
        /// class declaration.
        /// </summary>
        private static IEnumerable<string> GeneratePrologue(string file)
        {
            string manualFile = file.Replace(".g.cs", ".cs");
            var copyright = File.ReadAllLines(manualFile).TakeWhile(line => line.StartsWith("//")).ToList();

            // We have more using directives than we need by doing this, but it does no harm.
            // We *could* specify "uncommon" ones in the XML document, if we wanted.
            var common =
@"
// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Apis.Bigquery.v2.Data;
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BigQuery.V2;

public abstract partial class BigQueryClient
{"
.Replace("\r", "").Split('\n');

            return copyright.Concat(common);
        }

        private static IEnumerable<string> GenerateEpilogue()
        {
            // Just close the class declaration.
            yield return "}";
        }
    }
}
